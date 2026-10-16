/*
 * hook-vm.js — 在**同一次运行**里做 VM 程序取证
 *
 * 原理：
 *   DNGuard 把 IL 解密到自己的缓冲区后，会把 IL 里烧死的“数据地址常量”补成运行时真实地址，
 *   再交给真 JIT。我们 hook 在真 JIT 入口（clrjit+0xed430），抓到的 IL 里就带着**本次运行**
 *   的有效绝对地址。于是可以当场去那块内存取证，不需要跨进程/跨批次。
 *
 * 产出：
 *   vm-map.txt        —— 进程里所有大块 RW 私有内存区（基址/大小/熵/前 32 字节）
 *   vm-probe.txt      —— 从 IL 里提取到的地址常量 + 可读性 + 所在区域信息
 *   vm-dump-<n>.bin   —— 命中的内存区内容（每个最多 4MB）
 *   vm-ready.txt      —— 完成标记
 *
 * 与 hook-dump.js 相同的启动方式（frida-inject -f <app> -s hook-vm.js）
 */

const OUT = "C:\\mass\\dumper\\";
const MAX_DUMP = 4 * 1024 * 1024;
const CLRJIT_OFF = 0xed430;

function ws(name, data) {
    try {
        const f = new File(OUT + name, "wb");
        if (typeof data === "string") f.write(data); else f.write(data);
        f.flush(); f.close();
    } catch (e) { console.log("write " + name + " failed: " + e); }
}
function log(s) { console.log(s); }

/* ---------- 熵 ---------- */
function entropy(buf) {
    const c = new Array(256).fill(0);
    for (let i = 0; i < buf.length; i++) c[buf[i] & 0xff]++;
    let e = 0;
    for (let i = 0; i < 256; i++) if (c[i]) { const q = c[i] / buf.length; e -= q * Math.log2(q); }
    return e;
}

/* ---------- ① 大块 RW 私有区清单 ---------- */
function dumpMap() {
    const lines = ["# base size protect entropy first32"];
    let ranges = [];
    try {
        ranges = Process.enumerateRanges({ protection: "rw-", coalesce: true });
    } catch (e) { log("enumerateRanges failed: " + e); return; }
    let big = 0;
    for (const r of ranges) {
        if (r.size < 512 * 1024) continue;
        let head = null;
        try { head = r.base.readByteArray(4096); } catch (e) { continue; }
        if (head === null) continue;
        const h = new Uint8Array(head);
        const e = entropy(h);
        const first = Array.from(h.slice(0, 32)).map(x => x.toString(16).padStart(2, "0")).join(" ");
        lines.push(`${r.base} 0x${r.size.toString(16)} ${r.protection} ${e.toFixed(3)} ${first}`);
        big++;
    }
    ws("vm-map.txt", lines.join("\n") + "\n");
    log(`[vm] 大块 RW 区 ${big} 个 → vm-map.txt`);
}

/* ---------- ② 从 IL 里提取疑似绝对地址 ---------- */
const candidates = new Map();   // addr -> count
function scanIlForAddrs(ilBuf) {
    const b = new Uint8Array(ilBuf);
    for (let i = 0; i + 8 <= b.length; i++) {
        // 只认 0x21 (ldc.i8) 后面 8 字节的小端值 —— 允许少量错位，可读性会过滤掉误报
        if (b[i] !== 0x21 && b[i] !== 0x22) continue;
        let v = 0n;
        for (let k = 7; k >= 0; k--) v = (v << 8n) | BigInt(b[i + 1 + k]);
        const n = Number(v);
        // 只关心用户态高位数据/代码地址：0x1_0000_0000 ~ 0x7FFF_FFFF_FFFF
        if (n > 0x100000000 && n < 0x7fffffffffff) {
            candidates.set(n, (candidates.get(n) || 0) + 1);
        }
    }
}

/* ---------- ③ 去候选地址取证 ---------- */
function probeCandidates() {
    const lines = ["# addr hits readable regionBase regionSize protect entropy first32"];
    let dumped = 0;
    const seenRegion = new Set();
    const sorted = Array.from(candidates.entries()).sort((a, b) => b[1] - a[1]).slice(0, 400);
    for (const [n, hits] of sorted) {
        const addr = ptr(n);
        let range = null;
        try { range = Process.findRangeByAddress(addr); } catch (e) { }
        if (range === null) { lines.push(`0x${n.toString(16)} ${hits} NO`); continue; }
        let head = null, ent = -1;
        try {
            head = addr.readByteArray(4096);
            if (head) ent = entropy(new Uint8Array(head));
        } catch (e) { }
        const first = head ? Array.from(new Uint8Array(head).slice(0, 32)).map(x => x.toString(16).padStart(2, "0")).join(" ") : "-";
        lines.push(`0x${n.toString(16)} ${hits} YES ${range.base} 0x${range.size.toString(16)} ${range.protection} ${ent.toFixed(3)} ${first}`);

        const key = range.base.toString();
        if (!seenRegion.has(key) && range.size >= 4096 && dumped < 6) {
            seenRegion.add(key);
            try {
                const len = Math.min(range.size, MAX_DUMP);
                const data = range.base.readByteArray(len);
                if (data) { ws(`vm-dump-${dumped}.bin`, data); dumped++; log(`[vm] 已 dump ${range.base} 0x${range.size.toString(16)}`); }
            } catch (e) { log("[vm] dump 失败 " + e); }
        }
    }
    ws("vm-probe.txt", lines.join("\n") + "\n");
    log(`[vm] 候选地址 ${candidates.size} 个，dump 区域 ${dumped} 个 → vm-probe.txt`);
}

/* ---------- 挂钩 ---------- */
let stat = { calls: 0, scanned: 0 };
function attach() {
    const mod = Process.findModuleByName("clrjit.dll");
    if (mod === null) { setTimeout(attach, 200); return; }
    log("[vm] clrjit.dll @ " + mod.base + " size=0x" + mod.size.toString(16));
    const target = mod.base.add(CLRJIT_OFF);
    Interceptor.attach(target, {
        onEnter(args) {
            stat.calls++;
            if (stat.scanned >= 4000) return;      // 只扫前 4000 个，够采样
            const info = args[2];
            if (info.isNull()) return;
            try {
                const ilP = info.add(16).readPointer();
                const ilS = info.add(24).readU32();
                if (ilP.isNull() || ilS === 0 || ilS > 1 << 20) return;
                const buf = ilP.readByteArray(ilS);
                if (buf === null) return;
                stat.scanned++;
                scanIlForAddrs(buf);
            } catch (e) { }
        }
    });
    log("[vm] hook 就绪 @ " + target);

    // 等目标把保护器装上、跑过一段之后再取证
    setTimeout(() => {
        dumpMap();
        probeCandidates();
        ws("vm-stats.txt", `calls=${stat.calls} scanned=${stat.scanned} candidates=${candidates.size}\n`);
        ws("vm-ready.txt", "ok\n");
        log("[vm] ==== 取证完成 ====");
    }, 12000);
}

const runtime64 = Process.findModuleByName("Mass.Runtime64.dll");
log("[vm] Mass.Runtime64.dll = " + (runtime64 ? runtime64.base + " size=0x" + runtime64.size.toString(16) : "(尚未加载)"));
attach();
setInterval(() => { }, 3000);   // 保活
