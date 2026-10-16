/*
 * hook-fixup.js — 验证「DNGuard 在 JIT 编译过程中当场修补 IL 缓冲区」
 *
 * 假设来源：我们 hook 在 clrjit+0xed430（真 JIT 的 compileMethod 入口），
 * 抓到的 IL 里含有**越界 token**（如 0x04800001，Field 表只有 2229 行），
 * 这种 IL 不可能被 CLR 编译。但目标程序正常运行 → 说明真实流程里这些
 * 操作数在 JIT 解析之前被修好了。
 *
 * 验证方法（不依赖任何猜测）：
 *   同一个 ILCode 缓冲区，onEnter 读一次快照，onLeave 再读一次。
 *   · 若字节变了 → DNGuard 在编译期间原地修好了它（I 号假设成立）
 *   · 若没变   → 修不了，说明 JIT 拿到的是别的缓冲区（另找）
 *
 * 产出：
 *   fixup-report.txt   —— 每条样本的 before/after 摘要
 *   fixup-before.bin   —— 样本方法的原始 IL（进入时）
 *   fixup-after.bin    —— 同一条 IL（返回后）
 *   fixup-ready.txt    —— 完成标记
 */
const OUT = "C:\\mass\\dumper\\";
const CLRJIT_OFF = 0xed430;
const MAXSAMPLES = 40;

function ws(name, data) {
    try { const f = new File(OUT + name, "wb"); f.write(data); f.flush(); f.close(); }
    catch (e) { console.log("write " + name + " failed: " + e); }
}
function hx(buf) {
    const b = new Uint8Array(buf); let s = "";
    for (let i = 0; i < b.length; i++) s += b[i].toString(16).padStart(2, "0");
    return s;
}
function diffCount(a, b) {
    const x = new Uint8Array(a), y = new Uint8Array(b);
    if (x.length !== y.length) return -1;
    let d = 0;
    for (let i = 0; i < x.length; i++) if (x[i] !== y[i]) d++;
    return d;
}

let calls = 0, changed = 0, same = 0, unreadable = 0, taken = 0;
const report = ["# ftn ilSize same? first-diff-offset diffBytes before[0:48] after[0:48]"];
const befores = [], afters = [];
const pending = new Map();   // ftn -> {ilP, ilS, snap}

function attach() {
    const mod = Process.findModuleByName("clrjit.dll");
    if (mod === null) { setTimeout(attach, 200); return; }
    Interceptor.attach(mod.base.add(CLRJIT_OFF), {
        onEnter(args) {
            calls++;
            const info = args[2];
            if (info.isNull()) return;
            try {
                const ftn = info.readPointer();
                const ilP = info.add(16).readPointer();
                const ilS = info.add(24).readU32();
                const cbSig = info.add(0xf8).readU32();      // locals.cbSig（我们实测恒为 0）
                if (ilP.isNull() || ilS === 0 || ilS > 1 << 20) return;
                const buf = ilP.readByteArray(ilS);
                if (buf === null) return;
                this.key = ftn.toString() + "#" + ilS;
                this.ilP = ilP; this.ilS = ilS;
                this.snap = buf;
                this.cbSig = cbSig;
                pending.set(this.key, this);
            } catch (e) { }
        },
        onLeave(retval) {
            if (!this.key) return;
            pending.delete(this.key);
            try {
                const after = this.ilP.readByteArray(this.ilS);
                if (after === null) { unreadable++; return; }
                const d = diffCount(this.snap, after);
                if (d === 0) { same++; return; }
                changed++;
                if (taken < MAXSAMPLES) {
                    taken++;
                    const b = new Uint8Array(this.snap), a = new Uint8Array(after);
                    let first = -1;
                    for (let i = 0; i < b.length; i++) if (b[i] !== a[i]) { first = i; break; }
                    const hb = [], ha = [];
                    for (let i = 0; i < Math.min(48, b.length); i++) { hb.push(b[i].toString(16).padStart(2, "0")); ha.push(a[i].toString(16).padStart(2, "0")); }
                    report.push(`${this.key} ${this.ilS} CHANGED first=${first} bytes=${d} cbSig=${this.cbSig} before=${hb.join("")} after=${ha.join("")}`);
                    befores.push(hx(this.snap) + "\n");
                    afters.push(hx(after) + "\n");
                }
            } catch (e) { }
        }
    });
    console.log("[fixup] hook 就绪 @ " + mod.base.add(CLRJIT_OFF));

    setTimeout(() => {
        ws("fixup-report.txt", report.join("\n") + "\n");
        ws("fixup-before.bin", befores.join(""));
        ws("fixup-after.bin", afters.join(""));
        ws("fixup-stats.txt", `calls=${calls} changed=${changed} same=${same} unreadable=${unreadable} samples=${taken}\n`);
        ws("fixup-ready.txt", "ok\n");
        console.log(`[fixup] 完成 calls=${calls} changed=${changed} same=${same} unreadable=${unreadable}`);
    }, 14000);
}
attach();
setInterval(() => { }, 3000);
