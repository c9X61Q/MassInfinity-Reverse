#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
extract_stubs.py — 从（已去混淆 token 的）IL 里抽出 DNGuard 的 VM 方法登记表

受保护方法的体被换成统一桩：
    ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), <k>, <progid>, new IntPtr(<desc>), 15)
    → 返回原生函数指针 → 用真实实参调用

IL 形状（0x180016ed0 生成）：
    ldsfld <ZYXDNGuarder.a>            ; 空检查 → throw
    call   MethodBase.GetCurrentMethod()
    ldc.i4 <k>                         ← 调用约定/元数类别
    ldc.i4 <progid>                    ← 每方法唯一的程序编号
    ldc.i8 <desc>                      ← 每方法描述符地址（JIT 时烧入，逐次运行不同）
    ldc.i4 15
    call   <ZYXDNGuarder.a>
    calli
    ... 真实实参 ...

产出：stub-table.jsonl —— {mvid, token, type, method, sig, kind, k, progid, desc}
"""
import sys, json, struct, gzip, collections, re

TOK1 = {0x28,0x6f,0x73,0x7b,0x7c,0x7d,0x7e,0x7f,0x80,0x81,0x8c,0x8d,0x8f,0xa3,0xa4,0xa5,
        0x70,0x71,0x74,0x75,0x79,0xd0,0xc6,0xc2,0x72,0x29}
S1 = {0x0e,0x0f,0x10,0x11,0x12,0x13,0x1f}
S4 = {0x20,0x22}
S8 = {0x21,0x23}
BR1 = {0x2b,0x2c,0x2d,0x2e,0x2f,0x30,0x31,0x32,0x33,0x34,0x35,0x36,0x37,0xde}
BR4 = {0x38,0x39,0x3a,0x3b,0x3c,0x3d,0x3e,0x3f,0x40,0x41,0x42,0x43,0x44,0xdd}
FE_TOK = {0x06,0x07,0x08,0x15,0x16,0x1c}


def walk(il):
    """产出 (op, kind, value)：kind ∈ None|'i4'|'i8'|'tok'|'var'|'br'|'u8'"""
    i, n = 0, len(il)
    while i < n:
        op = il[i]; i += 1
        if op == 0xFE:
            if i >= n: return
            o2 = il[i]; i += 1
            if o2 in (0x09,0x0a,0x0b,0x0c,0x0d,0x0e) and i + 2 <= n:
                yield ('FE%02x' % o2, 'var', struct.unpack_from('<H', il, i)[0]); i += 2
            elif o2 in (0x12,0x19) and i < n:
                yield ('FE%02x' % o2, 'u8', il[i]); i += 1
            elif o2 in FE_TOK and i + 4 <= n:
                yield ('FE%02x' % o2, 'tok', struct.unpack_from('<I', il, i)[0]); i += 4
            else:
                yield ('FE%02x' % o2, None, None)
            continue
        if op in TOK1:
            if i + 4 <= n:
                yield (op, 'tok', struct.unpack_from('<I', il, i)[0]); i += 4
            else:
                yield (op, None, None)
        elif op == 0x1F:                      # ldc.i4.s
            if i < n: yield (op, 'i4', struct.unpack_from('<b', il, i)[0]); i += 1
            else: yield (op, None, None)
        elif 0x16 <= op <= 0x1E:              # ldc.i4.0..8 / ldc.i4.m1
            yield (op, 'i4', op - 0x16 if op != 0x15 else -1)
        elif op in S1:
            if i < n: yield (op, 'var', il[i]); i += 1
            else: yield (op, None, None)
        elif op in S4:
            if i + 4 <= n: yield (op, 'i4', struct.unpack_from('<i', il, i)[0]); i += 4
            else: yield (op, None, None)
        elif op in S8:
            if i + 8 <= n: yield (op, 'i8', struct.unpack_from('<q', il, i)[0]); i += 8
            else: yield (op, None, None)
        elif op in BR1:
            if i < n: yield (op, 'br', i + 1 + struct.unpack_from('<b', il, i)[0]); i += 1
            else: yield (op, None, None)
        elif op in BR4:
            if i + 4 <= n: yield (op, 'br', i + 4 + struct.unpack_from('<i', il, i)[0]); i += 4
            else: yield (op, None, None)
        elif op == 0x45:
            if i + 4 > n: return
            k = struct.unpack_from('<I', il, i)[0]
            i += 4 + 4 * k
            yield (op, 'switch', k)
        else:
            yield (op, None, None)


def extract(il: bytes):
    """扫描指令流：把 progid 落 0x6A 家族的那一处前一条当 k、后一条 i8 当描述符地址"""
    seq = list(walk(il))
    for j, (op, kind, val) in enumerate(seq):
        if kind != 'i4' or not isinstance(val, int): continue
        if (val & 0xff000000) != 0x6a000000: continue
        k = None
        if j >= 1 and seq[j-1][1] == 'i4' and isinstance(seq[j-1][2], int) and 0 <= seq[j-1][2] <= 15:
            k = seq[j-1][2]
        desc = None
        for t in range(j+1, min(j+5, len(seq))):
            if seq[t][1] == 'i8' and isinstance(seq[t][2], int) and 0x100000000 <= seq[t][2] < 0x800000000000:
                desc = seq[t][2]; break
        if k is not None and desc is not None:
            return k, val, desc
    return None


def main():
    src = sys.argv[1]
    dst = sys.argv[2]
    op = gzip.open if src.endswith('.gz') else open
    n = 0
    rows = []
    ks = collections.Counter()
    for line in op(src, 'rt', encoding='utf-8'):
        if not line.strip(): continue
        r = json.loads(line)
        if r.get('kind') != 'real': continue
        n += 1
        e = extract(bytes.fromhex(r['il']))
        if e is None: continue
        k, progid, desc = e
        ks[k] += 1
        rows.append({'mvid': r['mvid'], 'token': r['token'], 'type': r['type'], 'method': r['method'],
                     'sig': r.get('sig', ''), 'k': k, 'progid': progid, 'desc': desc})
    with open(dst, 'w', encoding='utf-8') as f:
        for r in rows:
            f.write(json.dumps(r, ensure_ascii=False) + '\n')
    print(f"扫描 kind=real {n} 条，抽出 VM 桩 {len(rows)} 条 → {dst}")
    print(f"  k（调用约定/元数类别）分布: {dict(ks.most_common())}")
    if rows:
        print(f"  progid 范围: 0x{min(r['progid'] for r in rows):08x} .. 0x{max(r['progid'] for r in rows):08x}")
        print(f"  不同 progid: {len(set(r['progid'] for r in rows))}")
        print("  样本:")
        for r in rows[:6]:
            print(f"    k={r['k']} progid={r['progid']} desc=0x{r['desc']:x}  {r['type'][-38:]}.{r['method'][:20]}  {r['sig'][:40]}")


if __name__ == '__main__':
    main()
