/*
 * hook-mem.js — 抓「物化」动作
 * 物化的特征：从 .hvm0（映像内 VA 0x1800b2000..0x1803a3000）读，写到 arena（堆/可写区）。
 * 这里 hook 内存拷贝助手 0x180047390 与分配器 0x180046ce0，记录 (dst, src, len) / (size, caller)。
 */
const OUT = "C:\\mass\\dumper\\";
const MEMCPY = 0x47390;
const ALLOC = 0x46ce0;
const IMG_LO = 0x180000000, IMG_HI = 0x1803a3000;
const HVM_LO = 0x1800b2000, HVM_HI = 0x1803a3000;
let fhC = null, fhA = null;
let nc = 0, na = 0, hvmHits = 0;
function open() {
    try { fhC = new File(OUT + "mem-copy.tsv", "wb"); fhC.write("#dst src len srcInImg srcInHvm retAddr\n"); fhC.flush(); } catch (e) { }
    try { fhA = new File(OUT + "mem-alloc.tsv", "wb"); fhA.write("#size ret size ret\n"); fhA.flush(); } catch (e) { }
}
function attach() {
    const m = Process.findModuleByName("Mass.Runtime64.dll");
    if (m === null) { setTimeout(attach, 200); return; }
    open();
    Interceptor.attach(m.base.add(MEMCPY), {
        onEnter(a) {
            // 常见 memcpy 约定：被保护器用 (dst, src, len) 还是 (len, dst, src) 都记下来
            const v = [a[0], a[1], a[2]];
            let dst = null, src = null, len = 0;
            for (let i = 0; i < 3; i++) {
                const x = v[i];
                if (x.compare(ptr("0x1000")) < 0) { if (len === 0) len = x.toInt32(); }
            }
            // 取两个像指针的
            const cand = v.filter(x => x.compare(ptr("0x10000")) > 0);
            if (cand.length >= 2) { dst = cand[0]; src = cand[1]; }
            if (dst === null || src === null || len <= 0 || len > 0x2000000) return;
            nc++;
            const s = src.toInt32() >>> 0;
            const inImg = (s >= IMG_LO && s < IMG_HI);
            const inHvm = (s >= HVM_LO && s < HVM_HI);
            if (inHvm) hvmHits++;
            try { if (fhC && nc < 20000 && (len > 0x40 || inImg)) fhC.write(`${dst} ${src} ${len} ${inImg ? 1 : 0} ${inHvm ? 1 : 0} ${this.returnAddress}\n`); } catch (e) { }
        }
    });
    Interceptor.attach(m.base.add(ALLOC), {
        onEnter(a) {
            na++;
            try { if (fhA && na < 20000) fhA.write(`${a[0].toInt32()} ${this.returnAddress}\n`); } catch (e) { }
        }
    });
    console.log("[mem] 已挂");
    setInterval(() => { try { if (fhC) fhC.flush(); if (fhA) fhA.flush(); } catch (e) { } }, 2000);
    setTimeout(() => { console.log(`[mem] done copies=${nc} allocs=${na} hvm=${hvmHits}`); }, 12000);
}
attach();
setInterval(() => { }, 3000);
