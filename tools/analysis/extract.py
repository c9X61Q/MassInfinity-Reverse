#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
extract.py — 从 il-all-v4.tsv + map.txt 生成最终可回填数据集

产出 recovered.jsonl，每行：
  { mvid, token, type, method, sig, kind, maxStack, il, localsCount, eh:[...] }

· kind=real  → 真实原始 IL，可回填
· kind=vm    → HVM 桩（16 字节调 VM 派发器），逻辑在 HVM 字节码里
· kind=tail  → `call X; ret` 转发桩
· localsCount 由 IL 指令边界扫描得出（保护器抹掉了 locals 签名，只能这样重建）
· EH 子句在 post(ILCode 之后) / pre(之前) 里按标准 COR_ILMETHOD_SECT_EH 严格校验恢复
"""
import sys, os, json, struct, collections

HERE = os.path.dirname(os.path.abspath(__file__))
sys.path.insert(0, os.path.abspath(os.path.join(HERE, "..")))
import locals_check as LC


def classify(il: bytes):
    if len(il) == 11 and il[0] == 0x72 and il[5] == 0x73 and il[10] == 0x7a:
        return "throw"
    if len(il) == 16 and il[0] == 0x20 and il[5] == 0x20 and il[10] == 0x28 and il[15] == 0x2a:
        return "vm"
    if len(il) == 6 and il[0] == 0x28 and il[5] == 0x2a:
        return "tail"
    return "real"


def valid_eh(base, off, n, ilsize, fat, want_n):
    """严格校验 EH 子句表"""
    clen = 24 if fat else 12
    if off + n * clen > len(base):
        return None
    out = []
    for i in range(n):
        c = base[off + i * clen: off + (i + 1) * clen]
        if fat:
            flags, tryoff, trylen, hoff, hlen, tok = struct.unpack_from("<IIIIII", c, 0)
        else:
            flags = struct.unpack_from("<H", c, 0)[0]
            tryoff = struct.unpack_from("<H", c, 2)[0]
            trylen = c[4]
            hoff = struct.unpack_from("<H", c, 5)[0]
            hlen = c[7]
            tok = struct.unpack_from("<I", c, 8)[0]
        if (flags & 0x7) not in (0, 1, 2, 4, 5):
            return None
        if trylen == 0 or hlen == 0:
            return None
        if tryoff + trylen > ilsize or hoff + hlen > ilsize:
            return None
        out.append({"flags": flags & 0x7, "tryOff": tryoff, "tryLen": trylen,
                    "hOff": hoff, "hLen": hlen, "tok": tok})
    return out


def find_eh(post: bytes, pre: bytes, ilsize: int, ehcount: int):
    """先按标准 SECT 头定位，再做位置暴力扫（两种子句宽度都试）"""
    if ehcount <= 0:
        return []
    for buf in (post, pre):
        if not buf:
            continue
        # (a) 标准头：Kind(1) DataSize(含 4 字节头) Reserved(2)
        for off in range(0, min(len(buf), 96)):
            kind = buf[off]
            if (kind & 0x3F) != 0x01:
                continue
            fat = (kind & 0x40) != 0
            clen = 24 if fat else 12
            if off + 4 > len(buf):
                continue
            if fat:
                dsz = buf[off + 1] | (buf[off + 2] << 8) | (buf[off + 3] << 16)
            else:
                dsz = buf[off + 1]
            if dsz >= 4 and off + dsz <= len(buf) and (dsz - 4) % clen == 0 and (dsz - 4) // clen == ehcount:
                r = valid_eh(buf, off + 4, ehcount, ilsize, fat, ehcount)
                if r:
                    return r
        # (b) 无头裸表：直接找一个位置使 ehcount 条子句全部通过校验
        for fat in (False, True):
            clen = 24 if fat else 12
            for off in range(0, min(len(buf), 256)):
                r = valid_eh(buf, off, ehcount, ilsize, fat, ehcount)
                if r:
                    return r
    return []


def main():
    ilf = os.path.join(HERE, "il-all-v4.tsv")
    mapf = os.path.join(HERE, "map-v4.txt")
    out = os.path.join(HERE, "recovered.jsonl")

    md2id = {}
    for line in open(mapf, encoding="utf-8", errors="replace"):
        if line.startswith("#") or not line.strip():
            continue
        p = line.rstrip("\n").split("|")
        if len(p) < 6:
            continue
        md2id[p[0].lower()] = [p[1], p[2], p[3], p[4], "|".join(p[5:])]

    best = {}
    for line in open(ilf, encoding="utf-8", errors="replace"):
        if line.startswith("#") or not line.strip():
            continue
        p = line.rstrip("\n").split("\t")
        if len(p) < 9:
            continue
        ftn = p[0].lower().replace("0x", "")
        try:
            il = bytes.fromhex(p[4])
        except ValueError:
            continue
        k = classify(il)
        prev = best.get(ftn)
        # 取最长 / 优先 real
        if prev is None or (k == "real" and prev[0] != "real") or (k == prev[0] and len(il) > len(prev[1])):
            best[ftn] = (k, il, p)

    stats = collections.Counter()
    nell = 0
    nloc = 0
    with open(out, "w", encoding="utf-8") as f:
        for ftn, (k, il, p) in best.items():
            ident = md2id.get(ftn)
            if ident is None:
                continue
            mvid, token, typ, mname, sig = ident
            used, maxloc = LC.walk(il)
            nlocals = (maxloc + 1) if used else 0
            ehc = int(p[3])
            eh = find_eh(bytes.fromhex(p[6]) if p[6] else b"",
                         bytes.fromhex(p[5]) if p[5] else b"", len(il), ehc)
            if ehc > 0:
                nell += 1
                if eh:
                    pass
            if nlocals > 0:
                nloc += 1
            stats[k] += 1
            f.write(json.dumps({
                "mvid": mvid, "token": token, "type": typ, "method": mname, "sig": sig,
                "kind": k, "maxStack": int(p[2]), "il": p[4],
                "localsCount": nlocals, "ehCount": ehc, "eh": eh,
            }, ensure_ascii=False) + "\n")

    print(f"写出 {out}")
    print("形态分布:", dict(stats))
    print(f"需要局部变量签名的方法: {nloc}")
    print(f"ehCount>0 的方法: {nell}")


if __name__ == "__main__":
    main()
