using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Application.Event;

[AttributeUsage(AttributeTargets.Method)]
public class SubscribeEventAttribute : Attribute
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe SubscribeEventAttribute()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777840, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
