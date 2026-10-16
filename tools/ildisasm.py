#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Mass Infinity (NetEase MC launcher) — DNGuard IL dump 反汇编器
读取 Frida 从 clrjit!compileMethod 捕获的原始 IL，反汇编为可读形式。

用法:
  python3 ildisasm.py il-final.txt                 # 统计概览
  python3 ildisasm.py il-final.txt --scope 0x...   # 某模块的全部方法
  python3 ildisasm.py il-final.txt --min 4096      # 只列大方法
  python3 ildisasm.py il-final.txt --method 1234   # 反汇编第 N 个方法
"""
import sys, collections, struct, argparse

# ---------- IL 操作码表 ----------
OP1 = {
0x00:'nop',0x01:'break',0x02:'ldarg.0',0x03:'ldarg.1',0x04:'ldarg.2',0x05:'ldarg.3',
0x06:'ldloc.0',0x07:'ldloc.1',0x08:'ldloc.2',0x09:'ldloc.3',0x0a:'stloc.0',0x0b:'stloc.1',
0x0c:'stloc.2',0x0d:'stloc.3',0x0e:'ldarg.s',0x0f:'ldarga.s',0x10:'starg.s',0x11:'ldloc.s',
0x12:'ldloca.s',0x13:'stloc.s',0x14:'ldnull',0x15:'ldc.i4.m1',0x16:'ldc.i4.0',0x17:'ldc.i4.1',
0x18:'ldc.i4.2',0x19:'ldc.i4.3',0x1a:'ldc.i4.4',0x1b:'ldc.i4.5',0x1c:'ldc.i4.6',0x1d:'ldc.i4.7',
0x1e:'ldc.i4.8',0x1f:'ldc.i4.s',0x20:'ldc.i4',0x21:'ldc.i8',0x22:'ldc.r4',0x23:'ldc.r8',
0x25:'dup',0x26:'pop',0x27:'jmp',0x28:'call',0x29:'calli',0x2a:'ret',0x2b:'br.s',0x2c:'brfalse.s',
0x2d:'brtrue.s',0x2e:'beq.s',0x2f:'bge.s',0x30:'bgt.s',0x31:'ble.s',0x32:'blt.s',0x33:'bne.un.s',
0x34:'bge.un.s',0x35:'bgt.un.s',0x36:'ble.un.s',0x37:'blt.un.s',0x38:'br',0x39:'brfalse',
0x3a:'brtrue',0x3b:'beq',0x3c:'bge',0x3d:'bgt',0x3e:'ble',0x3f:'blt',0x40:'bne.un',0x41:'bge.un',
0x42:'bgt.un',0x43:'ble.un',0x44:'blt.un',0x45:'switch',0x46:'ldind.i1',0x47:'ldind.u1',
0x48:'ldind.i2',0x49:'ldind.u2',0x4a:'ldind.i4',0x4b:'ldind.u4',0x4c:'ldind.i8',0x4d:'ldind.i',
0x4e:'ldind.r4',0x4f:'ldind.r8',0x50:'ldind.ref',0x51:'stind.ref',0x52:'stind.i1',0x53:'stind.i2',
0x54:'stind.i4',0x55:'stind.i8',0x56:'stind.r4',0x57:'stind.r8',0x58:'add',0x59:'sub',0x5a:'mul',
0x5b:'div',0x5c:'div.un',0x5d:'rem',0x5e:'rem.un',0x5f:'and',0x60:'or',0x61:'xor',0x62:'shl',
0x63:'shr',0x64:'shr.un',0x65:'neg',0x66:'not',0x67:'conv.i1',0x68:'conv.i2',0x69:'conv.i4',
0x6a:'conv.i8',0x6b:'conv.r4',0x6c:'conv.r8',0x6d:'conv.u4',0x6e:'conv.u8',0x6f:'callvirt',
0x70:'cpobj',0x71:'ldobj',0x72:'ldstr',0x73:'newobj',0x74:'castclass',0x75:'isinst',0x76:'conv.r.un',
0x79:'unbox',0x7a:'throw',0x7b:'ldfld',0x7c:'ldflda',0x7d:'stfld',0x7e:'ldsfld',0x7f:'ldsflda',
0x80:'stsfld',0x81:'stobj',0x82:'conv.ovf.i1.un',0x83:'conv.ovf.i2.un',0x84:'conv.ovf.i4.un',
0x85:'conv.ovf.i8.un',0x86:'conv.ovf.u1.un',0x87:'conv.ovf.u2.un',0x88:'conv.ovf.u4.un',
0x89:'conv.ovf.u8.un',0x8a:'conv.ovf.i.un',0x8b:'conv.ovf.u.un',0x8c:'box',0x8d:'newarr',
0x8e:'ldlen',0x8f:'ldelema',0x90:'ldelem.i1',0x91:'ldelem.u1',0x92:'ldelem.i2',0x93:'ldelem.u2',
0x94:'ldelem.i4',0x95:'ldelem.u4',0x96:'ldelem.i8',0x97:'ldelem.i',0x98:'ldelem.r4',0x99:'ldelem.r8',
0x9a:'ldelem.ref',0x9b:'stelem.i',0x9c:'stelem.i1',0x9d:'stelem.i2',0x9e:'stelem.i4',
0x9f:'stelem.i8',0xa0:'stelem.r4',0xa1:'stelem.r8',0xa2:'stelem.ref',0xa3:'ldelem',
0xa4:'stelem',0xa5:'unbox.any',0xb3:'conv.ovf.i1',0xb4:'conv.ovf.u1',0xb5:'conv.ovf.i2',
0xb6:'conv.ovf.u2',0xb7:'conv.ovf.i4',0xb8:'conv.ovf.u4',0xb9:'conv.ovf.i8',0xba:'conv.ovf.u8',
0xc2:'refanyval',0xc3:'ckfinite',0xc6:'mkrefany',0xd0:'ldtoken',0xd1:'conv.u2',0xd2:'conv.u1',
0xd3:'conv.i',0xd4:'conv.ovf.i',0xd5:'conv.ovf.u',0xd6:'add.ovf',0xd7:'add.ovf.un',0xd8:'mul.ovf',
0xd9:'mul.ovf.un',0xda:'sub.ovf',0xdb:'sub.ovf.un',0xdc:'endfinally',0xdd:'leave',0xde:'leave.s',
0xdf:'stind.i',0xe0:'conv.u',
}
OP2 = {
0x00:'arglist',0x01:'ceq',0x02:'cgt',0x03:'cgt.un',0x04:'clt',0x05:'clt.un',0x06:'ldftn',0x07:'ldvirtftn',0x08:'jmp',
0x07:'ldvirtftn',0x09:'ldarg',0x0a:'ldarga',0x0b:'starg',0x0c:'ldloc',0x0d:'ldloca',0x0e:'stloc',
0x0f:'localloc',0x11:'endfilter',0x12:'unaligned.',0x13:'volatile.',0x14:'tail.',0x15:'initobj',
0x16:'constrained.',0x17:'cpblk',0x18:'initblk',0x19:'no.',0x1a:'rethrow',0x1c:'sizeof',
0x1d:'refanytype',0x1e:'readonly.',
}
# 带 token 操作数
TOK = {0x28,0x6f,0x73,0x7b,0x7c,0x7d,0x7e,0x7f,0x80,0x81,0x8c,0x8d,0x8f,0xa3,0xa4,0xa5,0x70,0x71,0x74,0x75,0x79,0xd0,0xc6,0xc2}
# 带 int8 操作数
S1 = {0x0e,0x0f,0x10,0x11,0x12,0x13,0x1f}
# 带 int32 操作数
S4 = {0x20,0x22}
# 带 int64
S8 = {0x21,0x23}
# 短分支
BR1 = {0x2b,0x2c,0x2d,0x2e,0x2f,0x30,0x31,0x32,0x33,0x34,0x35,0x36,0x37,0xde}
# 长分支
BR4 = {0x38,0x39,0x3a,0x3b,0x3c,0x3d,0x3e,0x3f,0x40,0x41,0x42,0x43,0x44,0xdd}

TKNAME = {(0x70,):'str',(0x0a,):'MemberRef',(0x06,):'MethodDef',(0x04,):'FieldDef',
          (0x01,):'TypeRef',(0x02,):'TypeDef',(0x1b,):'TypeSpec',(0x0b,):'StandAloneSig',
          (0x11,):'AssemblyRef',(0x0c,):'CustomAttribute',(0x2b,):'MethodSpec'}

def tokdesc(t):
    tab = t >> 24
    rid = t & 0x00FFFFFF
    names = {0x70:'#US',0x0a:'MemberRef',0x06:'MethodDef',0x04:'FieldDef',0x01:'TypeRef',
             0x02:'TypeDef',0x1b:'TypeSpec',0x0b:'Sig',0x11:'AsmRef',0x0c:'CustomAttr',
             0x2b:'MethodSpec',0x08:'String?'}
    return f"{names.get(tab, hex(tab))}:{rid}"

def disasm(il, indent="    ", maxops=None):
    out=[]; i=0; n=0
    while i < len(il):
        if maxops and n >= maxops:
            out.append(f"{indent}... ({len(il)-i} 字节省略)"); break
        start=i
        op=il[i]; i+=1
        extra=""; opsz=1
        if op == 0xfe:
            if i>=len(il): break
            op2=il[i]; i+=1
            nm=OP2.get(op2, f'fe{op2:02x}')
            # ---- 前缀指令的操作数宽度（关键：错了会导致整段错位）----
            if op2 in (0x09,0x0a,0x0b,0x0c,0x0d,0x0e):      # ldarg/ldarga/starg/ldloc/ldloca/stloc <u16>
                if i+2<=len(il):
                    v=struct.unpack('<H',il[i:i+2])[0]; extra=f" {v}"; i+=2
            elif op2 == 0x12:                                  # unaligned. <u8>
                if i<len(il): extra=f" {il[i]}"; i+=1
            elif op2 in (0x13,0x14,0x1e):                      # volatile. / tail. / readonly.  无操作数
                extra=""
            elif op2 == 0x19:                                  # no. <u8>
                if i<len(il): extra=f" {il[i]}"; i+=1
            elif op2 in (0x15,0x16,0x1c):                      # initobj/constrained./sizeof <token>
                if i+4<=len(il): extra=f" {tokdesc(struct.unpack('<I',il[i:i+4])[0])}"; i+=4
        else:
            nm=OP1.get(op, f'0x{op:02x}')
            if op in TOK:
                if i+4<=len(il):
                    t=struct.unpack('<I',il[i:i+4])[0]
                    extra=f" {tokdesc(t)}"; i+=4
            elif op in S1:
                if i<len(il): extra=f" {il[i] if il[i]<128 else il[i]-256}"; i+=1
            elif op in S4:
                if i+4<=len(il): extra=f" {struct.unpack('<i',il[i:i+4])[0]}"; i+=4
            elif op in S8:
                if i+8<=len(il): extra=f" {struct.unpack('<q',il[i:i+8])[0]}"; i+=8
            elif op in BR1:
                if i<len(il):
                    d=struct.unpack('<b',il[i:i+1])[0]; i+=1
                    extra=f" -> IL_{i+d:04x}"
            elif op in BR4:
                if i+4<=len(il):
                    d=struct.unpack('<i',il[i:i+4])[0]; i+=4
                    extra=f" -> IL_{i+d:04x}"
            elif op == 0x45:
                if i+4<=len(il):
                    k=struct.unpack('<I',il[i:i+4])[0]; i+=4
                    tg=[]; base=i
                    # 关键：必须消费全部 k 个目标，否则整段错位
                    for j in range(k):
                        if i+4<=len(il):
                            d=struct.unpack('<i',il[i:i+4])[0]; i+=4
                            if j < 8:
                                tg.append(f"IL_{base + j*4 + 4 + d:04x}")
                    extra=(f" [{', '.join(tg)}{'...' if k>8 else ''}] n={k}"
                           if k else " []")
        out.append(f"{indent}IL_{start:04x}: {nm}{extra}")
        n+=1
    return out

def load(path):
    rows=[]
    for line in open(path, errors='replace'):
        if line.startswith('#'): continue
        p=line.rstrip('\n').split('|')
        if len(p)>=6:
            try: rows.append({'ftn':p[0],'scope':p[1],'size':int(p[2]),
                              'stack':int(p[3]),'eh':int(p[4]),'hex':p[5]})
            except: pass
    return rows

def main():
    ap=argparse.ArgumentParser()
    ap.add_argument('file')
    ap.add_argument('--scope', default=None)
    ap.add_argument('--min', type=int, default=0)
    ap.add_argument('--method', type=int, default=None)
    ap.add_argument('--top', type=int, default=20)
    ap.add_argument('--ops', type=int, default=120)
    a=ap.parse_args()
    rows=load(a.file)
    if a.method is not None:
        r=rows[a.method]
        il=bytes.fromhex(r['hex'])
        print(f"# 方法 #{a.method}  ftn={r['ftn']}  scope={r['scope']}")
        print(f"# ILSize={r['size']}  maxStack={r['stack']}  EH={r['eh']}")
        print("\n".join(disasm(il, "", a.ops)))
        return
    if a.scope:
        sel=[r for r in rows if r['scope']==a.scope and r['size']>=a.min]
        sel.sort(key=lambda r:-r['size'])
        print(f"# scope {a.scope} 共 {len(sel)} 个方法 (>= {a.min} B)\n")
        for k,r in enumerate(sel[:a.top]):
            print(f"--- [{k}] ILSize={r['size']:,} maxStack={r['stack']} ---")
            print("\n".join(disasm(bytes.fromhex(r['hex']), "    ", 60)))
            print()
        return
    print(f"总方法数: {len(rows):,}")
    print(f"IL 总字节: {sum(r['size'] for r in rows):,}")
    sc=collections.Counter(r['scope'] for r in rows)
    print(f"模块数: {len(sc)}")
    print("\n=== 最大的方法（按 IL 大小）===")
    for r in sorted(rows, key=lambda r:-r['size'])[:a.top]:
        print(f"  IL={r['size']:>8,} B  stack={r['stack']}  EH={r['eh']}  scope={r['scope']}")
    print("\n=== 各模块方法数（前 15）===")
    for k,v in sc.most_common(15):
        tot=sum(r['size'] for r in rows if r['scope']==k)
        print(f"  {k}: {v:5d} 方法, {tot:>10,} B")

if __name__=='__main__':
    main()
