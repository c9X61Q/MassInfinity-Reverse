'use strict';
// ============================================================================
//  hook-native.js — 测「DNGuard 是否在 compileMethod 返回后原地覆写 JIT 机器码」
//
//  做法：挂 clrjit.dll + 0xed430（原始 compileMethod）
//    onEnter : 记下 nativeEntry / nativeSizeOfCode 两个出参指针 + 该方法的 IL 形态
//    onLeave : 立刻读 *nativeEntry 处的机器码 → 快照 A
//    之后    : 每秒复查同一地址 → 快照 B；A≠B 即「被覆写」
//
//  若大量方法被覆写 ⇒ 桩 IL 只是诱饵，真实实现是 DNGuard 写进去的机器码，
//  那就 dump 它（= 45,684 个方法的语义本体）。
// ============================================================================
const DIR = "C:\\mass\\dumper\\";
const OUT = DIR + "native-compare.tsv";     // 被覆写的行（含 A/B 全文）
const STAT = DIR + "native-stats.txt";
const SNAP = 128;                            // 每个方法快照字节数
const MAXREC = 40000;

let fh = null;
try { fh = new File(OUT, "w"); } catch (e) { }
function line(s) { try { if (fh) fh.write(s + "\n"); } catch (e) { } }
function flush() { try { if (fh) fh.flush(); } catch (e) { } }
line("#ftn\tne\tsz\tchanged\tkind\tilSize\tA\thex\tB\thex");

const H = "0123456789abcdef";
function hexof(u8) { let o = ""; for (let i = 0; i < u8.length; i++) { const b = u8[i]; o += H[b >> 4] + H[b & 15]; } return o; }
function readHex(p, n) {
  if (!p || p.isNull() || n <= 0) return "";
  let m = n;
  while (m > 0) { try { return hexof(new Uint8Array(p.readByteArray(m))); } catch (e) { m = (m >> 1) - 1; } }
  return "";
}

const recs = [];      // {ftn, ne, sz, A, kind, ilSize, done}
const stats = { calls: 0, recorded: 0, noNe: 0, changed: 0, err: 0, checks: 0 };

function kindOf(ilHex) {
  if (!ilHex) return "?";
  if (ilHex.indexOf("14161673") === 0) return "stubA";        // ldnull;ldc.i4.0;ldc.i4.0;newobj
  if (ilHex.length === 22) return "16B";
  return "len" + (ilHex.length / 2);
}

let clrjit = null, tries = 0, installed = false;
function findJit() {
  const m = Process.enumerateModules();
  for (let i = 0; i < m.length; i++) if (m[i].name.toLowerCase() === 'clrjit.dll') return m[i];
  return null;
}

function install() {
  if (installed) return;
  tries++;
  if (!clrjit) clrjit = findJit();
  if (!clrjit) { if (tries < 2400) setTimeout(install, 25); else line("#FAIL clrjit"); return; }

  const cm = clrjit.base.add(0xed430);
  line("#clrjit=" + clrjit.base);

  Interceptor.attach(cm, {
    onEnter(a) {
      stats.calls++;
      try {
        const info = a[2];
        const ftn = info.readPointer();
        const ilP = info.add(16).readPointer();
        const ilS = info.add(24).readU32();
        this.nePtr = a[4];
        this.szPtr = a[5];
        this.ftn = ftn;
        this.ilSize = ilS;
        this.kind = "?";
        if (ilP && !ilP.isNull() && ilS > 0 && ilS < 0x8000) this.kind = kindOf(readHex(ilP, Math.min(ilS, 8)));
      } catch (e) { this.nePtr = null; stats.err++; }
    },
    onLeave(retval) {
      try {
        if (!this.nePtr || this.nePtr.isNull()) return;
        const ne = this.nePtr.readPointer();
        if (!ne || ne.isNull()) { stats.noNe++; return; }
        const sz = this.szPtr ? this.szPtr.readU32() : 0;
        if (sz <= 0 || sz > 0x20000) { stats.noNe++; return; }
        if (recs.length >= MAXREC) return;
        const A = readHex(ne, Math.min(sz, SNAP));
        if (!A) return;
        recs.push({ ftn: this.ftn, ne: ne, sz: sz, A: A, kind: this.kind, ilSize: this.ilSize, done: false });
        stats.recorded++;
      } catch (e) { stats.err++; }
    }
  });
  installed = true; flush();
}

install();

setInterval(function () {
  if (!installed) return;
  stats.checks++;
  for (let i = 0; i < recs.length; i++) {
    const r = recs[i];
    if (r.done) continue;
    let B = "";
    try { B = readHex(r.ne, Math.min(r.sz, SNAP)); } catch (e) { r.done = true; continue; }
    if (B && B !== r.A) {
      r.done = true; stats.changed++;
      line(r.ftn + "\t" + r.ne + "\t" + r.sz + "\t1\t" + r.kind + "\t" + r.ilSize + "\t" + r.A + "\t" + B);
    }
  }
  flush();
  try {
    const f = new File(STAT, "w");
    f.write("calls=" + stats.calls + "\nrecorded=" + stats.recorded + "\nnoNe=" + stats.noNe +
            "\nchanged=" + stats.changed + "\nchecks=" + stats.checks + "\nerr=" + stats.err + "\n");
    f.flush(); f.close();
  } catch (e) { }
}, 1000);

// 结束：把所有记录（含未变的）也写一份统计
setTimeout(function () {
  let k = {};
  for (let i = 0; i < recs.length; i++) { const c = recs[i].kind; k[c] = (k[c] || 0) + 1; }
  let s = "#kindHist ";
  for (const key in k) s += key + "=" + k[key] + " ";
  line(s);
  line("#SUMMARY calls=" + stats.calls + " recorded=" + stats.recorded + " changed=" + stats.changed + " noNe=" + stats.noNe);
  flush();
}, 20000);

setInterval(function () { }, 3000);
