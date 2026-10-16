/*
 * hook-emit.js — 通过发射原语的「返回地址」定位主生成器
 * 同时把每个方法的生成过程按 (asm, opcode, token) 记录成流，便于核对。
 */
const OUT = "C:\\mass\\dumper\\";
const EMIT_OP = 0x1d9f0;      // emit(opcode)
const EMIT_TOK = 0x1d830;     // emit(opcode, token)
const calls = new Map();      // retAddr -> count
let nOp = 0, nTok = 0;
let fh = null, fh2 = null;
function open() {
    try { fh = new File(OUT + "emit-callers.tsv", "wb"); fh.write("#retAddr count\n"); fh.flush(); } catch (e) { }
    try { fh2 = new File(OUT + "emit-stream.tsv", "wb"); fh2.write("#which opcode arg0 arg1 asm\n"); fh2.flush(); } catch (e) { }
}
function attach() {
    const m = Process.findModuleByName("Mass.Runtime64.dll");
    if (m === null) { setTimeout(attach, 200); return; }
    open();
    const rec = (ra, tag, op, a0, a1) => {
        const k = ra.toString();
        calls.set(k, (calls.get(k) || 0) + 1);
        try { if (fh2 && nOp + nTok < 40000) fh2.write(`${tag} ${op} ${a0} ${a1} ${ra}\n`); } catch (e) { }
    };
    Interceptor.attach(m.base.add(EMIT_OP), {
        onEnter(a) { nOp++; rec(this.returnAddress, 'OP', a[1].toInt32(), a[0], 0); }
    });
    Interceptor.attach(m.base.add(EMIT_TOK), {
        onEnter(a) { nTok++; rec(this.returnAddress, 'TOK', a[1].toInt32(), a[0], a[2].toInt32()); }
    });
    console.log("[emit] 已挂");
    setInterval(() => {
        try { if (fh2) fh2.flush(); } catch (e) { }
    }, 2000);
    setTimeout(() => {
        try {
            const arr = Array.from(calls.entries()).sort((a, b) => b[1] - a[1]);
            if (fh) { for (const [k, v] of arr) fh.write(`${k} ${v}\n`); fh.write(`#nOp=${nOp} nTok=${nTok} distinctCallers=${arr.length}\n`); fh.flush(); }
        } catch (e) { }
        try { if (fh2) fh2.flush(); } catch (e) { }
        console.log(`[emit] done nOp=${nOp} nTok=${nTok} callers=${calls.size}`);
    }, 12000);
}
attach();
setInterval(() => { }, 3000);
