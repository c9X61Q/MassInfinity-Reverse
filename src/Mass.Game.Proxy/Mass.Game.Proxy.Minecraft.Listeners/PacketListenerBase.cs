using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Application.Plugin;

namespace Mass.Game.Proxy.Minecraft.Listeners;

public abstract class PacketListenerBase : IPlugin
{
	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe PacketListenerBase()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790787191, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
