/*
 * hook-appblob.js — 跑真 App 时对 DNGuard 加密块的可写副本按帧取样
 * 目的：判定「App 真正调用受保护方法」时，是否有更多数据被解密成明文（= 原 IL 可能materialize）
 */
const OUT = "C:\\mass\\dumper\\";
const PAT = "01 33 00 00 21 33 00 00 35 b2 00 00 45 b2 00 00 13 8b 00 00 07 20 00 00 23 8b 00 00 24 3c 01 00 00 00 00 00 15 b2 00 00 b4 c5 04 00 53 8b 00 00 a4 3c 01 00 75 b2 00 00 a5 b2 00 00 b5 b3 00 00";
const TABLE_RVA = 0x1a330, LO = 0xee00, HI = 0x1b1e00, CHUNK = 0x40000;
let base = null;
function findBase() {
    for (const r of Process.enumerateRanges("r--")) {
        if (r.size < 0x200000) continue;
        try { const h = Memory.scanSync(r.base, r.size, PAT); if (h.length > 0) return h[0].address.sub(TABLE_RVA); } catch (e) { }
    }
    return null;
}
function dump(tag) {
    try {
        if (base === null) base = findBase();
        if (base === null) { console.log("[app] " + tag + " base not found"); return; }
        const size = HI - LO;
        const f = new File(OUT + "app-" + tag + ".bin", "wb");
        let done = 0;
        while (done < size) {
            const n = Math.min(CHUNK, size - done);
            const b = base.add(LO + done).readByteArray(n);
            if (b === null) break;
            f.write(b); done += n;
        }
        f.flush(); f.close();
        console.log("[app] " + tag + " base=" + base + " bytes=" + done);
    } catch (e) { console.log("[app] " + tag + " fail: " + e); }
}
[5000, 15000, 30000, 50000].forEach(function (t, i) { setTimeout(function () { dump("t" + (i + 1)); }, t); });
setInterval(function () { }, 3000);
