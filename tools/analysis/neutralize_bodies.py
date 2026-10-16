#!/usr/bin/env python3
"""自驱动的成员体中和器
编译 → 取 error CS 的(文件,行) → 把包裹该行的成员体换成显式占位 → 重编，直到收敛。
目的：把"反编译残留导致不可编译"的文件变成"可编译 + 缺口显式标注"。
"""
import re,subprocess,sys,os,collections

MARK = 'throw new System.NotImplementedException("未还原（DNGuard HVM 保护 / 反编译残留）");'

def brace_match(t,i):
    d=0;k=i
    while k<len(t):
        if t[k]=='{':d+=1
        elif t[k]=='}':
            d-=1
            if d==0:return k
        k+=1
    return -1

def enclosing_body(t,pos):
    """从 pos 往前找最近的 '{'，其配对区间包含 pos，且该 '{' 前是 ')'（方法体）。"""
    cand=[]
    i=t.rfind('{',0,pos)
    while i>0:
        j=brace_match(t,i)
        if j>pos:
            pre=t[:i].rstrip()
            if pre.endswith(')') or pre.endswith(']'): cand.append((i,j))
        i=t.rfind('{',0,i)
        if len(cand)>40: break
    return cand[0] if cand else None

def expr_body(t,pos):
    """表达式体成员：签名后 '=>' 到 ';'"""
    st=t.rfind(';',0,pos); st=max(st,t.rfind('{',0,pos),t.rfind('}',0,pos))
    arrow=t.find('=>',st,pos)
    if arrow<0 or arrow>pos: return None
    semi=t.find(';',arrow)
    if semi<0 or semi<pos: return None
    return (arrow,semi)

def neutralize(path,line):
    t=open(path,encoding='utf-8',errors='replace').read()
    off=0
    for _ in range(line-1):
        n=t.find('\n',off)
        if n<0: break
        off=n+1
    b=enclosing_body(t,off)
    if b:
        i,j=b
        return t[:i+1]+'\n\t\t'+MARK+'\n\t'+t[j:], 'body'
    e=expr_body(t,off)
    if e:
        a,s=e
        return t[:a]+'=> '+MARK[:-1]+t[s:], 'expr'
    # 兜底：注释掉该行
    eol=t.find('\n',off)
    return t[:off]+'// [中和] '+t[off:eol]+t[eol:], 'line'

def build(d):
    r=subprocess.run(['dotnet','build','-v','q','--nologo'],cwd=d,capture_output=True,text=True,timeout=1800)
    errs=[]
    for m in re.finditer(r'^(.*?)\((\d+),(\d+)\): error CS\d+', r.stdout+r.stderr, re.M):
        errs.append((m.group(1),int(m.group(2))))
    nu = re.search(r'error NU\d+', r.stdout+r.stderr)
    return r.returncode, errs, bool(nu), (r.stdout+r.stderr)

if __name__=='__main__':
    d=sys.argv[1]; iters=int(sys.argv[2]) if len(sys.argv)>2 else 20
    stats=collections.Counter()
    for it in range(iters):
        rc,errs,nu,log=build(d)
        if nu:
            print(f"[{it}] NuGet 依赖错误，停止"); print(log[-1500:]); break
        if rc==0:
            print(f"[{it}] ✅ 编译通过（0 错误）"); break
        seen=set(); done=0
        for f,l in errs:
            key=(f,l)
            if key in seen or not os.path.exists(f): continue
            seen.add(key)
            t,kind=neutralize(f,l)
            open(f,'w',encoding='utf-8').write(t)
            stats[kind]+=1; done+=1
            if done>=4000: break
        print(f"[{it}] 错误 {len(errs)}，本轮中和 {done} 处  累计 {dict(stats)}")
        if done==0:
            print("无法再中和；剩余错误样本：")
            for f,l in errs[:6]: print(f"   {f}:{l}")
            break
