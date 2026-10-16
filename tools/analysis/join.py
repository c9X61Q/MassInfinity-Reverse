#!/usr/bin/env python3
"""
join.py — 把 Frida 抓到的 (MethodDesc → IL) 与托管侧 (MethodDesc → 身份) 做 join

输入:
  il-all.tsv   ftn | ilSize | maxStack | eh | il(hex) | pre(hex) | post(hex)
  map.txt      md_hex | mvid | token | type | method | sig

输出:
  joined.jsonl    每行一个 (身份, IL, 分类, EH 子句)
  统计摘要
"""
import sys, os, json, collections, struct

HERE = os.path.dirname(os.path.abspath(__file__))
IL = os.path.join(HERE, "il-all.tsv")
MAP = os.path.join(HERE, "map.txt")
OUT = os.path.join(HERE, "joined.jsonl")

def classify(il: bytes):
    """判定 IL 形态"""
    if len(il) == 11 and il[0] == 0x72 and il[5] == 0x73 and il[10] == 0x7a:
        return "throw"                      # DNGuard 落盘抛错桩（保护器没解密成功）
    if len(il) == 16 and il[0] == 0x20 and il[5] == 0x20 and il[10] == 0x28 and il[15] == 0x2a:
        return "vm"                         # HVM 桩：ldc.i4 progid; ldc.i4 idx; call VM; ret
    if len(il) == 6 and il[0] == 0x28 and il[5] == 0x2a:
        return "tail"                       # call; ret
    return "real"

def parse_eh(post: bytes, ilsize: int, ehcount: int, pre: bytes = b""):
    """
    复原异常处理子句表。
    原始方法体结尾就是标准 COR_ILMETHOD_SECT_EH：
        [code][4字节对齐 padding][Kind][DataSize..][Reserved(2)][12/24字节子句...]
    Kind 低位 0x01 = EHTable；0x40 置位 = 肥子句；DataSize **含** 4 字节头。
    （已用手工样本 ZYXDNGuarder.Startup 验证：try@9 len12 handler@21 len3 token 0x01000330）
    """
    if ehcount <= 0 or not post:
        return []
    for base in (post, pre[-32:] if pre else b""):
        if not base:
            continue
        for off in range(0, min(16, len(base))):
            kind = base[off]
            if (kind & 0x3F) != 0x01:
                continue
            fat = (kind & 0x40) != 0
            if fat:
                if off + 4 > len(base):
                    continue
                dsz = base[off+1] | (base[off+2] << 8) | (base[off+3] << 16)
                clen = 24
            else:
                if off + 2 > len(base):
                    continue
                dsz = base[off+1]
                clen = 12
            if dsz < 4 or off + dsz > len(base):
                continue
            data = base[off+4: off+dsz]
            if len(data) % clen != 0 or len(data) // clen != ehcount:
                continue
            out = []
            ok = True
            for i in range(ehcount):
                c = data[i*clen:(i+1)*clen]
                if fat:
                    flags, tryoff, trylen, hoff, hlen, tok = struct.unpack_from("<IIIIII", c, 0)
                else:
                    flags = struct.unpack_from("<H", c, 0)[0]
                    tryoff = struct.unpack_from("<H", c, 2)[0]
                    trylen = c[4]
                    hoff = struct.unpack_from("<H", c, 5)[0]
                    hlen = c[7]
                    tok = struct.unpack_from("<I", c, 8)[0]
                # 合理性校验：区域必须落在方法体内
                if flags > 4 or tryoff + trylen > ilsize + 1 or hoff + hlen > ilsize + 1:
                    ok = False
                    break
                out.append({"flags": flags, "tryOff": tryoff, "tryLen": trylen,
                            "hOff": hoff, "hLen": hlen, "tok": tok})
            if ok:
                return out
    return []

def main():
    # --- map ---
    md2id = {}
    with open(MAP, "r", encoding="utf-8", errors="replace") as f:
        for line in f:
            if line.startswith("#") or not line.strip():
                continue
            p = line.rstrip("\n").split("|")
            if len(p) < 6:
                continue
            md2id[p[0].lower()] = [p[1], p[2], p[3], p[4], "|".join(p[5:])]

    # --- il ---
    recs = collections.defaultdict(list)
    n_calls = 0
    with open(IL, "r", encoding="utf-8", errors="replace") as f:
        for line in f:
            if line.startswith("#") or not line.strip():
                continue
            p = line.rstrip("\n").split("\t")
            if len(p) < 7:
                continue
            n_calls += 1
            ftn = p[0].lower().replace("0x", "")
            recs[ftn].append(p)

    print(f"compileMethod 事件总数     : {n_calls}")
    print(f"不同 MethodDesc 数         : {len(recs)}")
    print(f"map.txt 条目数             : {len(md2id)}")

    joined = set(ftn for ftn in recs if ftn in md2id)
    print(f"join 命中（Mass 方法）     : {len(joined)}")
    print(f"未命中（框架/dumper 自身） : {len(recs) - len(joined)}")

    kind_by_md = {}
    stats = collections.Counter()
    with open(OUT, "w", encoding="utf-8") as out:
        for ftn, plist in recs.items():
            ident = md2id.get(ftn)
            if ident is None:
                continue
            mvid, token, typ, mname, sig = ident
            # 同一 MethodDesc 可能被编译多次（tiering/重试）：取最长的真实 IL
            best = None
            kinds = set()
            for p in plist:
                try:
                    il = bytes.fromhex(p[4])
                except ValueError:
                    continue
                k = classify(il)
                kinds.add(k)
                if best is None or (k != "real" and len(il) > len(best[0])) or (best[2] != "real" and k == "real"):
                    best = (il, p, k)
            if best is None:
                continue
            il, p, k = best
            ehc = parse_eh(bytes.fromhex(p[6]) if p[6] else b"", int(p[1]), int(p[3]), bytes.fromhex(p[5]) if p[5] else b"")
            stats[k] += 1
            kind_by_md[ftn] = k
            out.write(json.dumps({
                "md": ftn, "mvid": mvid, "token": token, "type": typ, "method": mname,
                "sig": sig, "kind": k, "ilSize": int(p[1]), "maxStack": int(p[2]),
                "ehCount": int(p[3]), "eh": ehc, "il": p[4], "pre": p[5], "post": p[6],
                "kindsSeen": sorted(kinds), "compiles": len(plist),
            }, ensure_ascii=False) + "\n")

    print("\n--- join 命中的 IL 形态 ---")
    for k, v in stats.most_common():
        print(f"  {k:6s} {v:7d}   ({v/max(1,sum(stats.values()))*100:.1f}%)")
    print(f"  合计     {sum(stats.values()):7d}")
    print(f"\n写出 {OUT}")

if __name__ == "__main__":
    main()
