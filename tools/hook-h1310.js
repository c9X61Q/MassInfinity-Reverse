/*
 * hook-h1310.js — 观测真正的 VM 入口 0x180001310 的真实调用约定
 * 记录：rcx / rdx / r8 / r9 入参 → 返回值 → 返回值处前 32 字节
 */
const OUT = "C:\\mass\\dumper\\";
const H = 0x1310;
const rows = [];
let n = 0;
function ws(a, d) { try { const f = new File(OUT + a, "wb"); f.write(d); f.flush(); f.close(); } catch (e) { } }
function hex(p, l) { try { const b = p.readByteArray(l); if (b === null) return ""; const u = new Uint8Array(b); let s = ""; for (let i = 0; i < u.length; i++) s += u[i].toString(16).padStart(2, "0"); return s; } catch (e) { return "ERR"; } }
function attach() {
    const m = Process.findModuleByName("Mass.Runtime64.dll");
    if (m === null) { setTimeout(attach, 200); return; }
    const target = m.base.add(H);
    Interceptor.attach(target, {
        onEnter(a) {
            this.a1 = a[0]; this.a2 = a[1]; this.a3 = a[2]; this.a4 = a[3];
        },
        onLeave(rv) {
            if (n >= 300) return;
            n++;
            rows.push(`rcx=${this.a1} rdx=0x${this.a2.toInt32().toString(16)} r8=${this.a3} r9=0x${this.a4.toInt32().toString(16)} ret=${rv} retBytes=${hex(rv, 32)}`);
        }
    });
    console.log("[h1310] 已挂 " + target);
    setTimeout(() => {
        ws("h1310.tsv", "#" + rows.length + " 次调用\n" + rows.join("\n") + "\n");
        ws("h1310-ready.txt", "ok\n");
        console.log(`[h1310] done ${n}`);
    }, 15000);
}
attach();
setInterval(() => { }, 3000);
