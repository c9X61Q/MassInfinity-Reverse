using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Network.Packet;
using Mass.Game.Proxy.Packets.Common;

namespace Mass.Game.Proxy.Packets.Login;

[PacketVersion(EnumProtocolVersion.V1206, 5)]
[PacketVersion(EnumProtocolVersion.V1211, 5)]
[PacketVersion(EnumProtocolVersion.V1218, 5)]
[PacketVersion(EnumProtocolVersion.V1219, 5)]
[Packet(EnumConnectionState.Login, EnumPacketDirection.Clientbound)]
public class ClientboundCookieRequestPacket : CookieRequestPacket
{
	private static object CheckAlphabeticComparator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClientboundCookieRequestPacket(EnumProtocolVersion version)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		int num = (int)version;
		if (0 == 0)
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
	internal static bool CheckEditableBridge()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ClientboundCookieRequestPacket CheckLogicalCommand()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_2B00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778116, new IntPtr(2737368332908L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00Ⰰ()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00ⴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778119, new IntPtr(2737368315228L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_2E00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_2F00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778118, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
