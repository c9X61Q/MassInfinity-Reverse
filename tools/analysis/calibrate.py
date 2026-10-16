#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
calibrate.py — 用 IL 自我校准 CORINFO_METHOD_INFO 里 locals 的真实偏移

思路：IL 里 ldloc/stloc 用到的最大局部变量序号 maxloc 是硬约束 ——
真正的 locals 签名必须声明 count >= maxloc+1，且签名字节必须**精确消耗完** cbSig。
于是把 (locals基址 O, pSig相对偏移 P) 全枚举，用这两条硬校验筛，正确偏移会压倒性胜出。

用法: python3 calibrate.py il-all-v3.tsv
"""
import sys, struct, collections, os

HERE = os.path.dirname(os.path.abspath(__file__))
sys.path.insert(0, os.path.abspath(os.path.join(HERE, "..")))
from ildisasm import TOK, S1, S4, S8, BR1, BR4
import locals_check as LC

W_LO = 0x30


def cint(b, i):
    if i >= len(b): return None, i
    x = b[i]
    if x & 0x80 == 0: return x, i + 1
    if x & 0xC0 == 0x80:
        if i + 1 >= len(b): return None, i
        return ((x & 0x3F) << 8) | b[i + 1], i + 2
    if x & 0xE0 == 0xC0:
        if i + 3 >= len(b): return None, i
        return ((x & 0x1F) << 24) | (b[i + 1] << 16) | (b[i + 2] << 8) | b[i + 3], i + 4
    return None, i


# ---- 那些指向签名字节、但离线拿不到内容的候选：只用于统计，不参与校验 ----
def parse_local_sig(buf, off, cb):
    """buf[off:off+cb] 是否是合法 LOCAL_SIG，返回声明的局部变量个数"""
    if cb < 2 or cb > 4096 or off + cb > len(buf): return None
    sig = buf[off:off + cb]
    if sig[0] != 0x07: return None
    cnt, i = cint(sig, 1)
    if cnt is None or cnt > 4096: return None
    for _ in range(cnt):
        if i >= cb: return None
        t = sig[i]; i += 1
        if t in (0x11, 0x12):                      # VALUETYPE / CLASS + TypeDefOrRef
            _, i = cint(sig, i)
        elif t == 0x15:                            # GENERICINST
            i += 1
            _, i = cint(sig, i)
            _, i = cint(sig, i)
        elif t in (0x1E, 0x1F):                    # MVAR / VAR
            _, i = cint(sig, i)
        elif t in (0x1D, 0x45, 0x0F):              # SZARRAY / PTR / BYREF → 递归一层
            if i >= cb: return None
            return None                            # 交给真解析器，这里保守放弃
        if i is None: return None
    return cnt if i == cb else None


def main():
    path = sys.argv[1] if len(sys.argv) > 1 else os.path.join(HERE, "il-all-v3.tsv")
    score = collections.Counter()
    tried = collections.Counter()
    n = 0
    with open(path, encoding="utf-8", errors="replace") as f:
        for line in f:
            if line.startswith("#") or not line.strip(): continue
            p = line.rstrip("\n").split("\t")
            if len(p) < 9 or not p[7]: continue
            il = bytes.fromhex(p[4])
            used, maxloc = LC.walk(il)
            if not used or maxloc < 0: continue
            st = bytes.fromhex(p[7])
            n += 1
            if n > 20000: break
            for O in range(W_LO, 0x110, 8):
                for P in range(0x00, 0x70, 4):
                    o = O - W_LO + P
                    if o + 12 > len(st): continue
                    cb = struct.unpack_from("<I", st, o + 8)[0]
                    if cb < 2 or cb > 4096: continue
                    tried[(O, P)] += 1
                    # 离线拿不到 pSig 指向的内存 → 只能靠「长度合理性」先筛，
                    # 真正的字节级校验在 hook 侧做（locCand），这里筛出候选偏移
                    score[(O, P)] += 1
    print("参与校准的样本数:", n)
    print("\n候选偏移（指针槽 + 长度槽 == 合理长度）出现频次 Top 20：")
    for (O, P), c in score.most_common(20):
        print(f"   locals@{O:#04x}  pSig@{P:#04x}  →  info+{O+P:#04x} / cbSig@info+{O+P+8:#04x}   命中 {c:6d} ({c/max(1,n)*100:5.1f}%)")
    print("\n提示：若某组合接近 100%，即为真实布局；若全部很低，说明 locals.cbSig 恒为 0。")


if __name__ == "__main__":
    main()
