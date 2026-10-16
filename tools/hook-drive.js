/*
 * hook-drive.js —— 路线 A：驱动 VM 逐个编译受保护方法，dump 编译产物
 *
 * 已实证的调用链：
 *   桩 IL:  ZYXDNGuarder.a(GetCurrentMethod(), k, progid, IntPtr(desc), 15) → calli
 *   字段 a = 0x1800093e0（每个程序集都一样，实测反射确认）
 *   0x1800093e0: if (k == *(u32*)0x1800a7d40) return 0; else tail → 0x180001310(method, progid)
 *   → 0x180001310 是真正的 VM handler，返回该方法的原生代码指针
 *
 * 本脚本：
 *   ① hook clrjit 收集桩里的 (ftn, k, progid, desc)
 *   ② 收集窗口结束后，对每条调用 handler(ftn, progid) —— 只是"编译"，不执行方法
 *   ③ dump 返回指针处的代码，落 drive.tsv
 */
const OUT = "C:\\mass\\dumper\\";
const CLRJIT_OFF = 0xed430;
const HANDLER = 0x180001310;      // VM handler（映像基址固定 0x180000000）
const MAXCALL = 4000;
const CODE_LEN = 384;

const lines = [];
const pend = [];
let calls = 0, stubs = 0, hit = 0, nullret = 0, errs = 0;

function ws(n, d) { try { const f = new File(OUT + n, "wb"); f.write(d); f.flush(); f.close(); } catch (e) { } }
function hex(p, len) {
    try { const b = p.readByteArray(len); if (b === null) return ""; const u = new Uint8Array(b); let s = "";
        for (let i = 0; i < u.length; i++) s += u[i].toString(16).padStart(2, "0"); return s; } catch (e) { return ""; }
}
function b2i(b) { return b[0] | (b[1] << 8) | (b[2] << 16) | (b[3] << 24); }

function parseStub(il) {
    for (let i = 0; i + 10 < il.length; i++) {
        if (il[i] !== 0x21) continue;
        let v = 0n;
        for (let k = 7; k >= 0; k--) v = (v << 8n) | BigInt(il[i + 1 + k]);
        if (v < 0x100000000n || v >= 0x800000000000n) continue;
        for (let j = Math.max(0, i - 12); j < i; j++) {
            if (il[j] === 0x20 && j + 4 < i) {
                const p = b2i(il.slice(j + 1, j + 5)) >>> 0;
                if ((p & 0xff000000) === 0x6a000000) {
                    let kk = -1;
                    for (let m = j - 1; m >= Math.max(0, j - 6); m--) {
                        const o = il[m];
                        if (o >= 0x16 && o <= 0x1e) { kk = o - 0x16; break; }
                        if (o === 0x1f) { kk = (il[m + 1] << 24) >> 24; break; }
                        if (o === 0x20) { kk = b2i(il.slice(m + 1, m + 5)); break; }
                    }
                    return { k: kk, progid: p >>> 0, desc: v };
                }
            }
        }
    }
    return null;
}

function attach() {
    const mod = Process.findModuleByName("clrjit.dll");
    if (mod === null) { setTimeout(attach, 200); return; }
    Interceptor.attach(mod.base.add(CLRJIT_OFF), {
        onEnter(args) {
            calls++;
            const info = args[2];
            if (info.isNull() || pend.length >= MAXCALL) return;
            try {
                const ilP = info.add(16).readPointer();
                const ilS = info.add(24).readU32();
                if (ilP.isNull() || ilS === 0 || ilS > 1 << 20) return;
                const buf = ilP.readByteArray(ilS);
                if (buf === null) return;
                const st = parseStub(new Uint8Array(buf));
                if (!st) return;
                stubs++;
                pend.push({ ftn: info.readPointer(), k: st.k, progid: st.progid, desc: st.desc });
            } catch (e) { }
        }
    });
    console.log("[drive] hook 就绪");

    // 收集窗口 12 秒，然后逐个驱动 handler
    setTimeout(() => {
        let fn = null;
        try {
            const base = Process.findModuleByName("Mass.Runtime64.dll");
            fn = new NativeFunction(base.base.add(HANDLER - 0x180000000), 'pointer', ['pointer', 'int']);
            console.log("[drive] handler NativeFunction 就绪 " + base.base.add(HANDLER - 0x180000000));
        } catch (e) { console.log("[drive] handler 构造失败: " + e); }
        if (fn === null) { ws("drive-stats.txt", `hook fail calls=${calls} stubs=${stubs}\n`); ws("drive-ready.txt", "x\n"); return; }

        for (let i = 0; i < pend.length; i++) {
            const e = pend[i];
            let code = null;
            try { code = fn(e.ftn, e.progid); } catch (ex) { errs++; continue; }
            if (code === null || code.isNull()) { nullret++; continue; }
            hit++;
            const ch = hex(code, CODE_LEN);
            lines.push(`${e.ftn} ${e.k} ${e.progid} ${e.desc.toString()} ${code} ${ch}`);
        }
        ws("drive.tsv", "#ftn k progid desc codeAddr codeHex\n" + lines.join("\n") + "\n");
        ws("drive-stats.txt", `calls=${calls} stubs=${stubs} collected=${pend.length} hit=${hit} nullret=${nullret} errs=${errs}\n`);
        ws("drive-ready.txt", "ok\n");
        console.log(`[drive] 完成 collected=${pend.length} hit=${hit} nullret=${nullret} errs=${errs}`);
    }, 12000);
}
attach();
setInterval(() => { }, 3000);
