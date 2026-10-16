using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Application.Netease;

namespace Mass.Application.Desktop.Models;

public class SessionContext<TSession, TContext> where TSession : NeteaseSession
{
	public readonly TSession Session;

	public readonly TContext Context;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe SessionContext(TSession session, TContext context)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778238, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
