'use strict';
// ============================================================================
//  hook-dump.js — DNGuard HVM 全量 IL 提取（唯键：MethodDesc）+ 结构实证采样
// ----------------------------------------------------------------------------
//  hook 点：clrjit.dll + 0xed430（原始 ICorJitCompiler::compileMethod）。
//  保护器把 vtable[0] 改写到自己那边，但仍把解密后的原始 IL 转发给真 JIT，
//  所以 hook 这里不触发反篡改，且能拿到全部真实 IL。
//
//  身份：MethodDesc*（info+0x00）→ 与 MassDumper 写的 map.txt 离线 join。
//
//  本轮额外做两件事（元数据被 DNGuard 抹掉，只能从运行时结构拿）：
//    ① 全量落 CORINFO_METHOD_INFO 的 0x30..0x110 窗口（448 hex/条）
//       → 离线用「IL 里实际用到的最大局部变量序号」做自我校准，搜出
//         locals.pSig / locals.cbSig 的真实偏移，而不是照布局读
//    ② 一次性探针：扫 ICorJitInfo 代理对象 comp 的前 0x800 字节，
//       找落在 coreclr.dll 里的指针（= 被包装的真 ICorJitInfo）
//       → 拿到就跑 <https://.../inner> 的真实 vtable，getMethodName/getEHinfo 全通
//
//  产物 il-all.tsv：
//    ftn | ilSize | maxStack | eh | il | pre(96B) | post(2048B if eh) | struct | full
// ============================================================================

const DIR = "C:\\mass\\dumper\\";
const OUT = DIR + "il-all.tsv";
const PROBE = DIR + "probe2.txt";
const READY = DIR + "hook.ready";
const DONE = DIR + "done.txt";
const STATS = DIR + "stats.txt";
const CM_RVA = 0xed430;

const W_LO = 0x30, W_HI = 0x110;        // 结构窗口（args 起点 → 结构末尾）
const FULL_LIMIT = 200;                 // 前 N 条额外落 0x00..0x200 全窗口

let fh = null;
try { fh = new File(OUT, "w"); } catch (e) {}
function line(s) { try { if (fh) fh.write(s + "\n"); } catch (e) {} }
function flush() { try { if (fh) fh.flush(); } catch (e) {} }
line("#ftn\tilSize\tmaxStack\teh\til\tpre\tpost\tstruct\tfull\tcalib");

function pfline(s) {
  try { const f = new File(PROBE, "a"); f.write(s + "\n"); f.flush(); f.close(); } catch (e) {}
}

const HEX = "0123456789abcdef";
function hexof(u8) { let o = ""; for (let i = 0; i < u8.length; i++) { const b = u8[i]; o += HEX[b >> 4] + HEX[b & 15]; } return o; }
function readHex(p, n, cap) {
  if (!p || p.isNull() || n <= 0) return "";
  let m = (cap && n > cap) ? cap : n;
  while (m > 0) { try { return hexof(new Uint8Array(p.readByteArray(m))); } catch (e) { m = (m >> 1) - 1; } }
  return "";
}
function readPtr(p) { try { const v = p.readPointer(); return (v && !v.isNull()) ? v : null; } catch (e) { return null; } }
function rdU32(p) { try { return p.readU32(); } catch (e) { return -1; } }

// ---- 枚举式 offset 校准扫描 ----
// 对 (locals基址 O, pSig相对偏移 P) 全枚举：读 info+O+P 当指针、info+O+P+8 当长度，
// 长度合理且指向的字节以 0x07(LOCAL_SIG) 开头 → 记为候选。
// 离线再用「IL 里实际用到的最大局部变量序号」把正确偏移选出来。
function calibScan(info) {
  const out = [];
  for (let O = 0x30; O < 0x110; O += 8) {
    for (let P = 0; P < 0x70; P += 4) {
      const pSig = readPtr(info.add(O + P));
      if (pSig === null) continue;
      const cb = rdU32(info.add(O + P + 8));
      if (cb < 2 || cb > 4096) continue;
      if (readHex(pSig, 1, 1) !== "07") continue;
      const blob = readHex(pSig, cb, 128);
      if (blob.length < 4) continue;
      out.push(O.toString(16) + "." + P.toString(16) + "." + cb + "." + blob);
      if (out.length >= 8) return out.join(";");
    }
  }
  return out.join(";");
}

// ---- 一次性 inner 探针 ----
let probeDone = false;
function probeComp(comp, ftn) {
  if (probeDone) return;
  probeDone = true;
  pfline("#=== ICorJitInfo 代理 (comp=" + comp + ") 内层指针探针 ===");
  let vt = null;
  try { vt = comp.readPointer(); } catch (e) {}
  pfline("#comp.vtable = " + vt);
  if (vt) {
    const vm = Process.findModuleByAddress(vt);
    pfline("#vtable 落在 " + (vm ? vm.name + "+0x" + vt.sub(vm.base).toString(16) : "未知"));
  }
  for (let off = 0; off < 0x800; off += 8) {
    let P = null;
    try { P = comp.add(off).readPointer(); } catch (e) { continue; }
    if (!P || P.isNull()) continue;
    const m = Process.findModuleByAddress(P);
    if (m) pfline("comp+0x" + off.toString(16) + " = " + P + "  → " + m.name + "+0x" + P.sub(m.base).toString(16));
    // 一级解引用：找 vtable（首项指向 coreclr）
    let Q = null;
    try { Q = P.readPointer(); } catch (e) { continue; }
    if (Q && !Q.isNull()) {
      const m2 = Process.findModuleByAddress(Q);
      if (m2) pfline("   [" + P + "] = " + Q + "  → " + m2.name + "+0x" + Q.sub(m2.base).toString(16));
    }
    // 二级：把 P 当成对象，看它的 vtable 各项落点（只报第一项）
  }
  pfline("#--- 模块一览 ---");
  try {
    Process.enumerateModules().forEach(function (m) {
      const n = m.name.toLowerCase();
      if (n.indexOf("coreclr") >= 0 || n.indexOf("clrjit") >= 0 || n.indexOf("mass") >= 0) {
        pfline("#  " + m.name + " base=" + m.base + " size=0x" + m.size.toString(16));
      }
    });
  } catch (e) {}
  pfline("#=== 探针结束 ===");
}

const stats = { calls: 0, captured: 0, skipped: 0, err: 0 };
function writeStats() {
  try {
    let mods = "?";
    try {
      const ms = Process.enumerateModules();
      let hasJit = false, hasProt = false;
      for (let i = 0; i < ms.length; i++) {
        const n = ms[i].name.toLowerCase();
        if (n === "clrjit.dll") hasJit = true;
        if (n.indexOf("mass.runtime") >= 0) hasProt = true;
      }
      mods = "clrjit=" + hasJit + " MassRuntime=" + hasProt + " modules=" + ms.length;
    } catch (e) { mods = "enumERR"; }
    const f = new File(STATS, "w");
    f.write("calls=" + stats.calls + "\ncaptured=" + stats.captured + "\nskipped=" + stats.skipped +
            "\nerr=" + stats.err + "\n" + mods + "\n");
    f.flush(); f.close();
  } catch (e) {}
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
  if (!clrjit) {
    if (tries < 2400) setTimeout(install, 25);
    else { line("#FAIL clrjit 未加载"); flush(); }
    return;
  }
  const cm = clrjit.base.add(CM_RVA);
  line("#clrjit=" + clrjit.base + " compileMethod=" + cm);

  Interceptor.attach(cm, {
    onEnter(a) {
      stats.calls++;
      try {
        const comp = a[1], info = a[2];
        probeComp(comp, info.readPointer());

        const ftn = info.readPointer();
        const ilP = info.add(16).readPointer();
        const ilS = info.add(24).readU32();
        const ms = info.add(28).readU32();
        const eh = info.add(32).readU32();
        if (!ilP || ilP.isNull() || ilS <= 0 || ilS > 0x8000000) { stats.skipped++; return; }

        const ilHex = readHex(ilP, ilS);
        const preHex = readHex(ilP.sub(96), 96);
        const postHex = readHex(ilP.add(ilS), eh > 0 ? 2048 : 64);
        const structHex = readHex(info.add(W_LO), W_HI - W_LO);
        const fullHex = stats.captured < FULL_LIMIT ? readHex(info, 0x200) : "";
        const calib = ((stats.captured & 15) === 0) ? calibScan(info) : "";

        line(ftn + "\t" + ilS + "\t" + ms + "\t" + eh + "\t" + ilHex + "\t" + preHex + "\t" +
             postHex + "\t" + structHex + "\t" + fullHex + "\t" + calib);
        stats.captured++;
      } catch (e) { stats.err++; }
      if ((stats.calls & 255) === 0) flush();
    }
  });

  installed = true;
  flush();
  try { const r = new File(READY, "w"); r.write("1"); r.flush(); r.close(); } catch (e) {}
}

install();

const timer = setInterval(function () {
  flush();
  writeStats();
  let done = false;
  try { done = File.exists(DONE); } catch (e) {}
  if (done && installed) {
    clearInterval(timer);
    flush();
    line("#SUMMARY calls=" + stats.calls + " captured=" + stats.captured + " skipped=" + stats.skipped + " err=" + stats.err);
    flush();
    try { if (fh) fh.close(); } catch (e) {}
    try { Interceptor.detachAll(); } catch (e) {}
  }
}, 500);

setInterval(function () {}, 3000);
