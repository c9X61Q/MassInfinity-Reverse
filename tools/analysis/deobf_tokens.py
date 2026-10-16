#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
deobf_tokens.py — 验证/执行「合成 token 清除 bit23」还原

假设：DNGuard 生成的 IL 里，token 操作数 = 真实 token | 0x00800000（bit23 当 flag）。
依据：`sub_180016ed0` 的发射式 `TABLE[v & 0xf] | (v >> 4)`，而实测合成 token 形如
      0x04800001 / 0x01800002 / 0x0a800003 —— RID 恰为 0x800001/0x800002/0x800003（连续）。

若假设成立 → 清掉 bit23（即 RID 减 0x800000）后，这些体就变成**合法可编译 IL**。

用法: python3 deobf_tokens.py <recovered.jsonl> <out.jsonl>
"""
import sys, json, struct, collections, gzip

# 操作数宽度表（含 FE 08 jmp 的修正）
TOK1 = {0x28,0x6f,0x73,0x7b,0x7c,0x7d,0x7e,0x7f,0x80,0x81,0x8c,0x8d,0x8f,0xa3,0xa4,0xa5,
        0x70,0x71,0x74,0x75,0x79,0xd0,0xc6,0xc2,0x72,0x29}
S1 = {0x0e,0x0f,0x10,0x11,0x12,0x13,0x1f}
S4 = {0x20,0x22}
S8 = {0x21,0x23}
BR1 = {0x2b,0x2c,0x2d,0x2e,0x2f,0x30,0x31,0x32,0x33,0x34,0x35,0x36,0x37,0xde}
BR4 = {0x38,0x39,0x3a,0x3b,0x3c,0x3d,0x3e,0x3f,0x40,0x41,0x42,0x43,0x44,0xdd}
FE_TOK = {0x06,0x07,0x08,0x15,0x16,0x1c}
BIT23 = 0x00800000


def deobf(il: bytes):
    """返回 (新 IL, 修正的 token 数, 修正明细)"""
    b = bytearray(il)
    i, n = 0, len(il)
    fixed = 0
    detail = []
    while i < n:
        op = il[i]; i += 1
        if op == 0xFE:
            if i >= n: break
            o2 = il[i]; i += 1
            if o2 in (0x09,0x0a,0x0b,0x0c,0x0d,0x0e): i += 2
            elif o2 in (0x12,0x19): i += 1
            elif o2 in FE_TOK and i + 4 <= n:
                t = struct.unpack_from('<I', il, i)[0]
                if t & BIT23:
                    nt = t & ~BIT23
                    struct.pack_into('<I', b, i, nt)
                    fixed += 1
                    if len(detail) < 4: detail.append(('FE%02x' % o2, t, nt))
                i += 4
            continue
        if op in TOK1:
            if i + 4 <= n:
                t = struct.unpack_from('<I', il, i)[0]
                if t & BIT23:
                    nt = t & ~BIT23
                    struct.pack_into('<I', b, i, nt)
                    fixed += 1
                    if len(detail) < 4: detail.append(('%02x' % op, t, nt))
                i += 4
        elif op in S1: i += 1
        elif op in S4: i += 4
        elif op in S8: i += 8
        elif op in BR1: i += 1
        elif op in BR4: i += 4
        elif op == 0x45:
            if i + 4 > n: break
            k = struct.unpack_from('<I', il, i)[0]
            i += 4 + 4 * k
    return bytes(b), fixed, detail


def main():
    src = sys.argv[1] if len(sys.argv) > 1 else 'recovered.jsonl'
    dst = sys.argv[2] if len(sys.argv) > 2 else 'recovered-deobf.jsonl'
    op = gzip.open if src.endswith('.gz') else open
    n = 0
    touched = 0
    total_fixed = 0
    samples = []
    with op(src, 'rt', encoding='utf-8') as f, open(dst, 'w', encoding='utf-8') as o:
        for line in f:
            if not line.strip(): continue
            r = json.loads(line)
            st = r.get('kind')
            if st == 'real':
                il = bytes.fromhex(r['il'])
                new, fixed, detail = deobf(il)
                if fixed:
                    touched += 1
                    total_fixed += fixed
                    r['il'] = new.hex()
                    r['deobf_tokens'] = fixed
                    if len(samples) < 6: samples.append((r['type'], r['method'], detail))
                n += 1
            o.write(json.dumps(r, ensure_ascii=False) + '\n')
    print(f"处理 kind=real {n} 条；其中 {touched} 条含合成 token，共修正 {total_fixed} 个")
    for t, m, d in samples:
        print(f"  样本 {t[-40:]}.{m[:20]}")
        for opn, a, b in d:
            print(f"      op={opn} 0x{a:08x} → 0x{b:08x}")


if __name__ == '__main__':
    main()
