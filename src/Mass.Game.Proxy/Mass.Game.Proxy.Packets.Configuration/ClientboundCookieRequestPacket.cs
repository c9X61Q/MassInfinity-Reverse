using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Network.Packet;
using Mass.Game.Proxy.Packets.Common;

namespace Mass.Game.Proxy.Packets.Configuration;

[Packet(EnumConnectionState.Configuration, EnumPacketDirection.Clientbound)]
[PacketVersion(EnumProtocolVersion.V1206, 0)]
[PacketVersion(EnumProtocolVersion.V1211, 0)]
[PacketVersion(EnumProtocolVersion.V1218, 0)]
[PacketVersion(EnumProtocolVersion.V1219, 0)]
public class ClientboundCookieRequestPacket : CookieRequestPacket
{
	internal static ClientboundCookieRequestPacket DecorateCustomFinder;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClientboundCookieRequestPacket(EnumProtocolVersion version)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		int num = (int)version;
		if (false)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectAdvancedAllocator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ClientboundCookieRequestPacket ReflectConvertibleQueue()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00㐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778361, new IntPtr(2737368312108L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00㔀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00㘀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00㜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778360, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
