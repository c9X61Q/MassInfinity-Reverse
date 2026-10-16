/*
 * hook-blob2.js — 用描述符表 64 字节当指纹定位 Mass.WinUI 的映射基址，再 dump 加密块
 */
const OUT = "C:\\mass\\dumper\\";
const PAT = "01 33 00 00 21 33 00 00 35 b2 00 00 45 b2 00 00 13 8b 00 00 07 20 00 00 23 8b 00 00 24 3c 01 00 00 00 00 00 15 b2 00 00 b4 c5 04 00 53 8b 00 00 a4 3c 01 00 75 b2 00 00 a5 b2 00 00 b5 b3 00 00";
const TABLE_RVA = 0x1a330;
const LO = 0xee00, HI = 0x1b1e00, CHUNK = 0x40000;
function findBase() {
    const ranges = Process.enumerateRanges("r--");
    for (const r of ranges) {
        if (r.size < 0x200000) continue;
        try {
            const hits = Memory.scanSync(r.base, r.size, PAT);
            if (hits.length > 0) return { base: hits[0].address.sub(TABLE_RVA), range: r };
        } catch (e) { }
    }
    return null;
}
function dump(tag) {
    try {
        const f = findBase();
        if (f === null) { console.log("[blob2] " + tag + " not found"); return; }
        const size = HI - LO;
        const fo = new File(OUT + "blob-" + tag + ".bin", "wb");
        let done = 0;
        while (done < size) {
            const n = Math.min(CHUNK, size - done);
            const b = f.base.add(LO + done).readByteArray(n);
            if (b === null) break;
            fo.write(b); done += n;
        }
        fo.flush(); fo.close();
        console.log("[blob2] " + tag + " base=" + f.base + " dumped " + done);
    } catch (e) { console.log("[blob2] " + tag + " fail: " + e); }
}
setTimeout(function () { dump("early"); }, 3000);
setTimeout(function () { dump("late"); }, 11500);
setInterval(function () { }, 3000);
