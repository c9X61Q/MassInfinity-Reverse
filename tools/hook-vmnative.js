/*
 * hook-vmnative.js — 一次性 dump VM 反虚拟化的两类输入
 *
 * 对每个受保护方法：
 *   ① 解析它**本次运行**生成的桩 IL（ldc.i4 k; ldc.i4 progid; ldc.i8 desc）
 *      → dump 描述符内存（VM 程序）
 *   ② 从 compileMethod 的第 5 个参数 nativeEntry** 读出 DNGuard VM 编译出的
 *      原生代码入口 → dump 代码字节（这就是该方法的"语义"）
 *
 * 产出：vmnative.tsv 每行 = ftn | ilSize | k | progid | desc | descHex | codeAddr | codeHex
 */
const OUT = "C:\\mass\\dumper\\";
const CLRJIT_OFF = 0xed430;
const MAX = 1200;          // 最多采样多少条
const DESC_LEN = 256;
const CODE_LEN = 256;

const lines = [];
let calls = 0, stubs = 0, withCode = 0;

function ws(n, d) { try { const f = new File(OUT + n, "wb"); f.write(d); f.flush(); f.close(); } catch (e) { } }
function hex(p, len) {
    try { const b = p.readByteArray(len); if (b === null) return ""; const u = new Uint8Array(b); let s = ""; for (let i = 0; i < u.length; i++) s += u[i].toString(16).padStart(2, "0"); return s; } catch (e) { return ""; }
}

/* 在 IL 里找 ldc.i4 k; ldc.i4 progid(0x6A家族); ldc.i8 desc */
function parseStub(il) {
    for (let i = 0; i + 10 < il.length; i++) {
        if (il[i] !== 0x21) continue;                       // ldc.i8
        let v = 0n;
        for (let k = 7; k >= 0; k--) v = (v << 8n) | BigInt(il[i + 1 + k]);
        if (v < 0x100000000n || v >= 0x800000000000n) continue;
        for (let j = Math.max(0, i - 12); j < i; j++) {
            if (il[j] === 0x20 && j + 4 < i) {
                const b = il.slice(j + 1, j + 5);
                let p = (b[0] | (b[1] << 8) | (b[2] << 16) | (b[3] << 24)) >>> 0;
                if ((p & 0xff000000) === 0x6a000000) {
                    // k = 再往前一条 ldc.i4 系列指令
                    let k = -1;
                    for (let m = j - 1; m >= Math.max(0, j - 6); m--) {
                        const o = il[m];
                        if (o >= 0x16 && o <= 0x1e) { k = o - 0x16; break; }
                        if (o === 0x1f) { k = (il[m + 1] << 24) >> 24; break; }
                        if (o === 0x20) { k = b2i(il.slice(m + 1, m + 5)); break; }
                    }
                    return { k: k, progid: p >>> 0, desc: v, ret: (r) => r };
                }
            }
        }
    }
    return null;
}
function b2i(b) { return b[0] | (b[1] << 8) | (b[2] << 16) | (b[3] << 24); }

function attach() {
    const mod = Process.findModuleByName("clrjit.dll");
    if (mod === null) { setTimeout(attach, 200); return; }
    Interceptor.attach(mod.base.add(CLRJIT_OFF), {
        onEnter(args) {
            calls++;
            if (lines.length >= MAX) return;
            const info = args[2];
            if (info.isNull()) return;
            try {
                const ilP = info.add(16).readPointer();
                const ilS = info.add(24).readU32();
                if (ilP.isNull() || ilS === 0 || ilS > 1 << 20) return;
                const buf = ilP.readByteArray(ilS);
                if (buf === null) return;
                this.st = parseStub(new Uint8Array(buf));
                this.ilP = ilP; this.ilS = ilS;
                this.nativeEntry = args[4];       // 第 5 个参数：nativeEntry**
            } catch (e) { }
        },
        onLeave(rv) {
            const st = this.st;
            if (!st) return;
            stubs++;
            let codeAddr = 0, codeHex = "";
            try {
                if (this.nativeEntry && !this.nativeEntry.isNull()) {
                    codeAddr = this.nativeEntry.readPointer().toInt32();   // 低 32 位足够判断
                    const ca = this.nativeEntry.readPointer();
                    if (!ca.isNull()) { codeHex = hex(ca, CODE_LEN); if (codeHex.length > 0) withCode++; }
                }
            } catch (e) { }
            const descHex = hex(ptr(st.desc.toString()), DESC_LEN);
            lines.push(`${this.ilP} ${this.ilS} ${st.k} ${st.progid} ${st.desc.toString()} ${descHex} ${codeAddr} ${codeHex}`);
        }
    });
    console.log("[vmn] hook 就绪 " + mod.base.add(CLRJIT_OFF));
    setTimeout(() => {
        ws("vmnative.tsv", "#ilP ilSize k progid desc descHex codeAddr codeHex\n" + lines.join("\n") + "\n");
        ws("vmnative-stats.txt", `calls=${calls} stubs=${stubs} lines=${lines.length} withCode=${withCode}\n`);
        ws("vmnative-ready.txt", "ok\n");
        console.log(`[vmn] done calls=${calls} stubs=${stubs} dumped=${lines.length} withCode=${withCode}`);
    }, 16000);
}
attach();
setInterval(() => { }, 3000);
