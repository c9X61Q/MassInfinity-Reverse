/*
 * hook-gen.js — 动态跟踪主生成器 0x18000bb90
 * 目的：绕开 .text 混淆，直接拿到它对每个方法的「输入（含描述符表）与输出」
 *
 * 已由静态代码得知：生成器从「上下文对象 +0xD8 / +0xE0」读 64 字节描述符表；
 * 上下文对象还有 +0x100（真 ICorJitInfo）、+0x118（info）。
 * 本脚本对每个参数做启发式识别（info：+0x18 是小整数且 +0x10 是有效指针），
 * 并把疑似上下文对象的 +0xD8/+0xE0 表内容 dump 出来。
 */
const OUT = "C:\\mass\\dumper\\";
const FN = 0xbb90;
const TAB_LEN = 64;
const MAXR = 4000;
let n = 0, ctxHit = 0, infoHit = 0;
let fh = null;
function open() { try { fh = new File(OUT + "gen.tsv", "wb"); fh.write("#n rcx rdx r8 r9 a5 ftn ilP ilSize k? descA descAHex descB descBHex\n"); fh.flush(); } catch (e) { } }
function app(s) { try { if (fh) { fh.write(s + "\n"); fh.flush(); } } catch (e) { } }
function hex(p, l) { try { const b = p.readByteArray(l); if (b === null) return ""; const u = new Uint8Array(b); let s = ""; for (let i = 0; i < u.length; i++) s += u[i].toString(16).padStart(2, "0"); return s; } catch (e) { return ""; } }
function looksInfo(p) {
    try {
        if (p.isNull()) return null;
        const ilP = p.add(0x10).readPointer();
        const sz = p.add(0x18).readU32();
        if (ilP.isNull()) return null;
        if (sz === 0 || sz > 0x100000) return null;
        return { ilP: ilP, sz: sz, ftn: p.readPointer() };
    } catch (e) { return null; }
}
function ctxTables(p) {
    try {
        if (p.isNull()) return null;
        const a = p.add(0xd8).readPointer();
        const b = p.add(0xe0).readPointer();
        if (a.isNull() && b.isNull()) return null;
        return { a: a, b: b };
    } catch (e) { return null; }
}
function attach() {
    const m = Process.findModuleByName("Mass.Runtime64.dll");
    if (m === null) { setTimeout(attach, 200); return; }
    open();
    Interceptor.attach(m.base.add(FN), {
        onEnter(args) {
            if (n >= MAXR) return;
            n++;
            const a = [args[0], args[1], args[2], args[3]];
            let a5 = ptr(0);
            try { a5 = this.context.rsp.add(0x28).readPointer(); } catch (e) { }
            // 找 info
            let info = null, infoArg = -1;
            for (let i = 0; i < 4; i++) { const r = looksInfo(a[i]); if (r) { info = r; infoArg = i; break; } }
            if (!info) { const r = looksInfo(a5); if (r) { info = r; infoArg = 4; } }
            if (info) infoHit++;
            // 找上下文（含 +0xD8/+0xE0）
            let ctx = null, ctxArg = -1;
            for (let i = 0; i < 4; i++) { const r = ctxTables(a[i]); if (r) { ctx = r; ctxArg = i; break; } }
            if (!ctx) { const r = ctxTables(a5); if (r) { ctx = r; ctxArg = 4; } }
            if (ctx) ctxHit++;
            const f = info ? info.ftn.toString() : "0";
            const il = info ? info.ilP.toString() : "0";
            const sz = info ? info.sz : 0;
            app(`${n} ${a[0]} ${a[1]} ${a[2]} ${a[3]} ${a5} ${f} ${il} ${sz} ${infoArg} ${ctx ? ctx.a : "0"} ${ctx ? hex(ctx.a, TAB_LEN) : ""} ${ctx ? ctx.b : "0"} ${ctx ? hex(ctx.b, TAB_LEN) : ""}`);
        }
    });
    console.log("[gen] 已挂 " + m.base.add(FN));
    setInterval(() => {
        try { if (fh) fh.flush(); } catch (e) { }
    }, 2000);
    setTimeout(() => {
        try { if (fh) { fh.write(`#TOTAL calls=${n} infoHit=${infoHit} ctxHit=${ctxHit}\n`); fh.flush(); } } catch (e) { }
        console.log(`[gen] done calls=${n} infoHit=${infoHit} ctxHit=${ctxHit}`);
    }, 12000);
}
attach();
setInterval(() => { }, 3000);
