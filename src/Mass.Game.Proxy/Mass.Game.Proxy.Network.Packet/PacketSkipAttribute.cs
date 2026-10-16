using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Game.Proxy.Network.Packet;

[AttributeUsage(AttributeTargets.Class)]
public class PacketSkipAttribute : Attribute
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe PacketSkipAttribute()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777123, new IntPtr(2737368301708L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
