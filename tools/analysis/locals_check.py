#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
locals_check.py — 用「IL 里实际用到的最大局部变量序号」校验候选局部变量签名

DNGuard 把元数据里的 StandAloneSig 行全部填成 0xCC，局部变量签名只能从运行时
CORINFO_METHOD_INFO 结构里扫出来。hook 侧扫到的候选签名（首字节 0x07 = LOCAL_SIG）
用 IL 自身做交叉验证：签名里声明的局部变量个数必须 > IL 里 ldloc/stloc 用到的最大序号。

用法: python3 locals_check.py il-all-v2.tsv
"""
import sys, json, struct, collections, os

sys.path.insert(0, os.path.join(os.path.dirname(os.path.abspath(__file__)), "..", ".."))
sys.path.insert(0, os.path.abspath(os.path.join(os.path.dirname(os.path.abspath(__file__)), "..")))

from ildisasm import OP1, OP2, TOK, S1, S4, S8, BR1, BR4

# 局部变量相关指令
LOC_SHORT = {0x06: 0, 0x07: 1, 0x08: 2, 0x09: 3, 0x0a: 0, 0x0b: 1, 0x0c: 2, 0x0d: 3}
LOC_S = {0x11, 0x12, 0x13}          # ldloc.s / ldloca.s / stloc.s
LOC_LONG = {0x0c, 0x0d, 0x0e}       # fe 0c/0d/0e


def walk(il: bytes):
    """按指令边界走一遍，返回 (是否用到局部变量, 最大局部变量序号)"""
    i, n = 0, len(il)
    used, mx = False, -1
    while i < n:
        op = il[i]; i += 1
        if op == 0xfe:
            if i >= n: break
            op2 = il[i]; i += 1
            if op2 in LOC_LONG:
                if i + 2 <= n:
                    v = struct.unpack('<H', il[i:i+2])[0]; i += 2
                    used = True; mx = max(mx, v)
            elif op2 in (0x09, 0x0a, 0x0b):
                i += 2
            elif op2 == 0x12 or op2 == 0x19:
                i += 1
            elif op2 in (0x15, 0x16, 0x1c):
                i += 4
            continue
        if op in LOC_SHORT:
            used = True; mx = max(mx, LOC_SHORT[op])
        elif op in LOC_S:
            if i < n:
                v = il[i]; i += 1
                used = True; mx = max(mx, v)
        elif op in TOK:
            i += 4
        elif op in S1:
            i += 1
        elif op in S4:
            i += 4
        elif op in S8:
            i += 8
        elif op in BR1:
            i += 1
        elif op in BR4:
            i += 4
        elif op == 0x45:                      # switch
            if i + 4 > n: break
            k = struct.unpack('<I', il[i:i+4])[0]; i += 4 + 4 * k
    return used, mx


def cint(b: bytes, i: int):
    """ECMA 压缩无符号整数"""
    if i >= len(b): return None, i
    x = b[i]
    if x & 0x80 == 0:
        return x, i + 1
    if x & 0xC0 == 0x80:
        if i + 1 >= len(b): return None, i
        return ((x & 0x3F) << 8) | b[i+1], i + 2
    if x & 0xE0 == 0xC0:
        if i + 3 >= len(b): return None, i
        return ((x & 0x1F) << 24) | (b[i+1] << 16) | (b[i+2] << 8) | b[i+3], i + 4
    return None, i


def sig_local_count(blob: bytes):
    if not blob or blob[0] != 0x07:
        return None
    n, _ = cint(blob, 1)
    return n


def main():
    path = sys.argv[1] if len(sys.argv) > 1 else "il-all-v2.tsv"
    recs = []
    for line in open(path, encoding="utf-8", errors="replace"):
        if line.startswith("#") or not line.strip():
            continue
        p = line.rstrip("\n").split("\t")
        if len(p) < 10:
            continue
        recs.append(p)

    n_used = 0
    n_cand = 0
    n_valid = 0
    n_invalid = 0
    multi = collections.Counter()
    bad_examples = []
    for p in recs:
        il = bytes.fromhex(p[4])
        used, mx = walk(il)
        cands = [c for c in p[8].split(";") if c]
        if not used:
            continue
        n_used += 1
        if not cands:
            if len(bad_examples) < 6:
                bad_examples.append(("无候选", p[0], len(il), mx, p[4][:80]))
            continue
        n_cand += 1
        multi[len(cands)] += 1
        ok = False
        for c in cands:
            try:
                off, size, hexb = c.split(":", 2)
                blob = bytes.fromhex(hexb)
            except ValueError:
                continue
            cnt = sig_local_count(blob)
            if cnt is None:
                continue
            if cnt > mx and cnt >= 1:
                ok = True
                break
        if ok:
            n_valid += 1
        else:
            n_invalid += 1
            if len(bad_examples) < 12:
                best = []
                for c in cands:
                    off, size, hexb = c.split(":", 2)
                    best.append((off, size, sig_local_count(bytes.fromhex(hexb))))
                bad_examples.append(("候选不符", p[0], len(il), mx, best))

    print(f"总记录                : {len(recs)}")
    print(f"真正用到局部变量的方法 : {n_used}")
    print(f"  其中 hook 扫到候选   : {n_cand}  ({n_cand/max(1,n_used)*100:.1f}%)")
    print(f"  候选通过 IL 交叉验证 : {n_valid}  ({n_valid/max(1,n_used)*100:.1f}%)")
    print(f"  候选不通过           : {n_invalid}")
    print(f"每方法候选个数分布     : {dict(multi)}")
    print("\n样本:")
    for e in bad_examples:
        print("   ", e)


if __name__ == "__main__":
    main()
