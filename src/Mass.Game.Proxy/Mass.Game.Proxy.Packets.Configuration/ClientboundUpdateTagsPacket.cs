using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Packets.Configuration;

[Packet(EnumConnectionState.Configuration, EnumPacketDirection.Clientbound)]
[PacketVersion(EnumProtocolVersion.V1206, 13)]
[PacketVersion(EnumProtocolVersion.V1211, 13)]
[PacketVersion(EnumProtocolVersion.V1218, 13)]
[PacketVersion(EnumProtocolVersion.V1219, 13)]
public class ClientboundUpdateTagsPacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	internal static ClientboundUpdateTagsPacket PresentRequester;

	public Dictionary<string, Dictionary<string, List<int>>> Tags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00褀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00輀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClientboundUpdateTagsPacket(EnumProtocolVersion version)
	{
		//IL_003a: Expected I4, but got Obj
		//IL_0028->IL0031: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ClientboundUpdateTagsPacket clientboundUpdateTagsPacket = this;
		if (0 == 0)
		{
			clientboundUpdateTagsPacket = (ClientboundUpdateTagsPacket)0;
		}
		switch ((int)clientboundUpdateTagsPacket)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_FF00蘀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_FF00蔀(buffer);
	}

	public bool Handle(Connection connection)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateCombinedClient()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ClientboundUpdateTagsPacket ReflectTransformableListener()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00萀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777961, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00_FF00蔀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0082->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0043->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0068->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				if (false)
				{
					_ = 0;
				}
				break;
			case 2:
				obj = (object)/*Error near IL_0051: Stack underflow*/;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			case 3:
				return;
			default:
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00_FF00蘀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_005e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0042->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0083->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0069->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008e->IL0019: Incompatible stack heights: 4 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				obj = (object)/*Error near IL_0036: Stack underflow*/;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 2:
				return;
			default:
				if (true)
				{
					_ = 3;
				}
				break;
			case 3:
				if (2 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00蜀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777960, new IntPtr(2737368302748L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Dictionary<string, Dictionary<string, List<int>>> _FF00_FF00_FF00_FF00_FF00蠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777963, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		return (Dictionary<string, Dictionary<string, List<int>>>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Dictionary<string, Dictionary<string, List<int>>> _FF00_FF00_FF00_FF00_FF00褀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (Dictionary<string, Dictionary<string, List<int>>>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Dictionary<string, Dictionary<string, List<int>>> _FF00_FF00_FF00_FF00_FF00言()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777962, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		return (Dictionary<string, Dictionary<string, List<int>>>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00謀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00谀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777957, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00贀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00踀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777956, new IntPtr(2737368318348L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00輀(Dictionary<string, Dictionary<string, List<int>>> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}
}
