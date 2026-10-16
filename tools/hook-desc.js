/*
 * hook-desc.js — 直接读「上下文对象 +0xD8 / +0xE0」里的描述符表内容
 *
 * 已由静态代码证实（0x180017088 起）：
 *   mov 0xd8(%rbx),%rax ; mov 0x10(%rax),%ecx ; and 0xf / shr 4 ; TABLE[...] | ... ; emit
 * 其中 rbx = sub_180016ed0 的第 1 个参数（上下文对象）。
 * 本脚本在入口直接把这两张表的内容 dump 出来。
 */
const OUT = "C:\\mass\\dumper\\";
const FN = 0x16ed0;
const LEN = 0x100;
const rows = [];
let n = 0;
let fh = null;
function open() { try { fh = new File(OUT + "desc.tsv", "wb"); fh.write("#ctx proxy descA descAHex descB descBHex extra\n"); fh.flush(); } catch (e) { } }
function app(line) { try { if (fh) { fh.write(line + "\n"); fh.flush(); } } catch (e) { } }
function ws(a, d) { try { const f = new File(OUT + a, "wb"); f.write(d); f.flush(); f.close(); } catch (e) { } }
function hex(p, l) { try { const b = p.readByteArray(l); if (b === null) return ""; const u = new Uint8Array(b); let s = ""; for (let i = 0; i < u.length; i++) s += u[i].toString(16).padStart(2, "0"); return s; } catch (e) { return ""; } }
function attach() {
    const m = Process.findModuleByName("Mass.Runtime64.dll");
    if (m === null) { setTimeout(attach, 200); return; }
    Interceptor.attach(m.base.add(FN), {
        onEnter(a) {
            if (n >= 800) return;
            n++;
            const ctx = a[0], proxy = a[1];
            let tA = "0", hA = "", tB = "0", hB = "";
            try {
                const pA = ctx.add(0xd8).readPointer();
                if (!pA.isNull()) { tA = pA.toString(); hA = hex(pA, LEN); }
                const pB = ctx.add(0xe0).readPointer();
                if (!pB.isNull()) { tB = pB.toString(); hB = hex(pB, LEN); }
            } catch (e) { }
            let extra = "";
            try { extra = hex(ctx.add(0x180), 16) + "|" + hex(proxy.add(0x100), 8); } catch (e) { }
            app(`${ctx} ${proxy} ${tA} ${hA} ${tB} ${hB} ${extra}`);
        }
    });
    open();
    console.log("[desc] 已挂 " + m.base.add(FN));
    setTimeout(() => {
        ws("desc.tsv", "#ctx proxy descA descAHex descB descBHex extra\n" + rows.join("\n") + "\n");
        ws("desc-ready.txt", "ok\n");
        console.log(`[desc] done ${n}`);
    }, 12000);
}
attach();
setInterval(() => { }, 3000);
