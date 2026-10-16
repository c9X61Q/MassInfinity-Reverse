#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
verify_backfill.py — 回填的语义级验证

问题：dnlib 写盘时会归一化元数据表顺序，IL 里的 token 操作数被整体重写
（长度不变、字节不同），所以字节比对必然失败。这里把 token 操作数掩码掉，
再按「类型 + 方法名」定位、逐指令比对 —— 能抓出真正的指令级错误，
同时容忍 token 重映射。

用法: python3 verify_backfill.py recovered.jsonl _out-il.tsv
"""
import sys, json, struct, collections, os
sys.path.insert(0, os.path.abspath(os.path.join(os.path.dirname(os.path.abspath(__file__)), "..")))
from ildisasm import TOK, S1, S4, S8, BR1, BR4, OP1, OP2

TOK_OP = set(TOK) | {0x72, 0x29} | {0x15, 0x16, 0x1c}   # ldstr(#US) / calli(StandAloneSig) 也是 token
FE_TOK = {0x06, 0x07} | {0x15, 0x16, 0x1c}    # ldftn / ldvirtftn / initobj / constrained. / sizeof


def decode(il: bytes):
    """返回指令序列（规范化文本），token 操作数掩码为 #TOK"""
    out = []
    i, n = 0, len(il)
    while i < n:
        start = i
        op = il[i]; i += 1
        if op == 0xFE:
            if i >= n: break
            op2 = il[i]; i += 1
            nm = "fe%02x" % op2
            if op2 in (0x09, 0x0a, 0x0b, 0x0c, 0x0d, 0x0e):
                if i + 2 <= n: out.append("%s v%d" % (nm, struct.unpack_from('<H', il, i)[0])); i += 2
                else: out.append(nm)
            elif op2 == 0x12:
                if i < n: out.append("%s %d" % (nm, il[i])); i += 1
                else: out.append(nm)
            elif op2 == 0x19:
                if i < n: out.append("%s %d" % (nm, il[i])); i += 1
                else: out.append(nm)
            elif op2 in FE_TOK:
                if i + 4 <= n: out.append("%s #TOK" % nm); i += 4
                else: out.append(nm)
            else:
                out.append(nm)
        else:
            nm = OP1.get(op, "0x%02x" % op)
            if op in TOK_OP:
                if i + 4 <= n: out.append("%s #TOK" % nm); i += 4
                else: out.append(nm)
            elif op in S1:
                if i < n: out.append("%s %d" % (nm, il[i])); i += 1
                else: out.append(nm)
            elif op in S4:
                if i + 4 <= n: out.append("%s %d" % (nm, struct.unpack_from('<i', il, i)[0])); i += 4
                else: out.append(nm)
            elif op in S8:
                if i + 8 <= n: out.append("%s %d" % (nm, struct.unpack_from('<q', il, i)[0])); i += 8
                else: out.append(nm)
            elif op in BR1:
                if i < n: out.append("%s @%d" % (nm, i + 1 + struct.unpack_from('<b', il, i)[0])); i += 1
                else: out.append(nm)
            elif op in BR4:
                if i + 4 <= n: out.append("%s @%d" % (nm, i + 4 + struct.unpack_from('<i', il, i)[0])); i += 4
                else: out.append(nm)
            elif op == 0x45:
                if i + 4 <= n:
                    k = struct.unpack_from('<I', il, i)[0]; i += 4
                    base = i + k * 4
                    tg = []
                    if base > n:
                        out.append("switch <bad>"); break
                    for j in range(k):
                        tg.append(base + struct.unpack_from('<i', il, i + j * 4)[0])
                    out.append("switch %s" % ",".join(map(str, tg))); i = base
                else: out.append(nm)
            else:
                out.append(nm)
        if i <= start:
            break
    return out


def canon(il: bytes):
    """把 IL 里所有 token 操作数（4 字节）清零，其余字节原样保留。
    dnlib 写盘会重排元数据表 → token 被重写；掩码后即可逐字节比对。"""
    b = bytearray(il)
    i, n = 0, len(il)
    while i < n:
        op = il[i]; i += 1
        spans = []
        if op == 0xFE:
            if i >= n: break
            op2 = il[i]; i += 1
            if op2 in (0x09, 0x0a, 0x0b, 0x0c, 0x0d, 0x0e): i += 2
            elif op2 in (0x12, 0x19): i += 1
            elif op2 in FE_TOK:
                spans.append((i, 4)); i += 4
        else:
            if op in TOK_OP:
                spans.append((i, 4)); i += 4
            elif op in S1: i += 1
            elif op in S4: i += 4
            elif op in S8: i += 8
            elif op in BR1: i += 1
            elif op in BR4: i += 4
            elif op == 0x45:
                if i + 4 > n: break
                k = struct.unpack_from('<I', il, i)[0]; i += 4 + 4 * k
        for off, ln in spans:
            for j in range(off, min(off + ln, n)):
                b[j] = 0
    return bytes(b)


def mask_tokens(seq):
    """把 token 掩码后的序列里，分支目标偏移也可能因 token 长度不变而保持 —— 无需额外处理"""
    return "\n".join(seq)


def main():
    recf = sys.argv[1] if len(sys.argv) > 1 else "recovered.jsonl"
    outf = sys.argv[2] if len(sys.argv) > 2 else "_out-il.tsv"

    want = collections.defaultdict(list)
    for line in open(recf, encoding="utf-8"):
        if not line.strip(): continue
        r = json.loads(line)
        if r.get("kind") != "real": continue
        key = (r["type"] + "\u0001" + r["method"]).lower()
        want[key].append(bytes.fromhex(r["il"]))

    have = collections.defaultdict(list)
    for line in open(outf, encoding="utf-8"):
        if line.startswith("#") or not line.strip(): continue
        p = line.rstrip("\n").split("|")
        if len(p) < 6: continue
        try: il = bytes.fromhex(p[-1])
        except ValueError: continue
        have[(p[2] + "\u0001" + "|".join(p[3:-2])).lower()].append(il)

    ok = bad = miss = 0
    bad_examples = []
    for key, lst in want.items():
        pool = list(have.get(key, []))
        if not pool:
            miss += len(lst); continue
        for exp in lst:
            ce = canon(exp)
            hit = -1
            for j, cand in enumerate(pool):
                if canon(cand) == ce:
                    hit = j; break
            if hit >= 0:
                pool.pop(hit); ok += 1
            else:
                bad += 1
                if len(bad_examples) < 4 and pool:
                    got = mask_tokens(decode(pool[0]))
                    a = mask_tokens(decode(exp)).split("\n"); b = got.split("\n")
                    d = next((i for i in range(max(len(a), len(b))) if (a[i] if i < len(a) else None) != (b[i] if i < len(b) else None)), -1)
                    bad_examples.append((key.replace("\u0001", "::"), len(a), len(b), d,
                                         a[max(0, d-2):d+3], b[max(0, d-2):d+3]))

    total = ok + bad + miss
    print(f"期望方法 {total}")
    print(f"  指令级等价 : {ok}  ({ok/max(1,total)*100:.1f}%)")
    print(f"  不一致     : {bad}")
    print(f"  输出侧缺失 : {miss}")
    for e in bad_examples:
        print("\n  样本:", e[0], f"  指令数 期望{e[1]} 实际{e[2]}   首个不同位置={e[3]}")
        print("    期望:", e[4])
        print("    实际:", e[5])


if __name__ == "__main__":
    main()
