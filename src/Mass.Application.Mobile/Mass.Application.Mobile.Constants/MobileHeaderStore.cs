using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Application.Mobile.Constants;

public class MobileHeaderStore
{
	public const string UserAgent = "";

	public const string DefaultUserAgent = "";

	public const string DefaultNeteaseVersion = "";

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe MobileHeaderStore()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778796, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
