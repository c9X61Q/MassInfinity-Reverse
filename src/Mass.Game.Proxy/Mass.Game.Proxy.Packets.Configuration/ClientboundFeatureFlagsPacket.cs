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

[PacketVersion(EnumProtocolVersion.V1211, 12)]
[PacketVersion(EnumProtocolVersion.V1206, 12)]
[PacketVersion(EnumProtocolVersion.V1218, 12)]
[PacketVersion(EnumProtocolVersion.V1219, 12)]
[Packet(EnumConnectionState.Configuration, EnumPacketDirection.Clientbound)]
public class ClientboundFeatureFlagsPacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	internal static ClientboundFeatureFlagsPacket ScanTokenizer;

	public List<string> FeatureFlags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_F800();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00ﴀ(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClientboundFeatureFlagsPacket(EnumProtocolVersion version)
	{
		//IL_003a: Expected I4, but got Obj
		//IL_0028->IL0031: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ClientboundFeatureFlagsPacket clientboundFeatureFlagsPacket = this;
		if (0 == 0)
		{
			clientboundFeatureFlagsPacket = (ClientboundFeatureFlagsPacket)0;
		}
		switch ((int)clientboundFeatureFlagsPacket)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_FF00_F600(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_FF00_F500(buffer);
	}

	public bool Handle(Connection connection)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool InitValue()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ClientboundFeatureFlagsPacket FormatPool()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_F400(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778335, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00_FF00_F500(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0048->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0072->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0057->IL0019: Incompatible stack heights: 0 vs 1
		//IL_007d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0062->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				_ = 3;
				break;
			case 2:
				obj = (object)/*Error near IL_004b: Stack underflow*/;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				if (false)
				{
					_ = 0;
				}
				break;
			case 3:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00_FF00_F600(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0057->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0072->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0047->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0062->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007d->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				_ = 3;
				break;
			default:
				if (2 == 0)
				{
					_ = 0;
				}
				break;
			case 3:
				return;
			case 1:
				obj = (object)/*Error near IL_0066: Stack underflow*/;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_F700(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778334, new IntPtr(2737368318348L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<string> _FF00_FF00_FF00_FF00_FF00_F800()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (List<string>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<string> _FF00_FF00_FF00_FF00_FF00豈()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778329, new IntPtr(2737368312108L), 15))(null, 0, new IntPtr(0L));
		return (List<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00切()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00ﬀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778328, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00ﰀ()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00ﴀ(List<string> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
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
			case 1:
				if (false)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FE00(List<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778331, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
