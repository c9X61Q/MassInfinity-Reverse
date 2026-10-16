using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Packets.Status;

[PacketAllVersion(0)]
[Packet(EnumConnectionState.Status, EnumPacketDirection.Serverbound)]
public class ServerboundStatusRequestPacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	internal static ServerboundStatusRequestPacket DecorateGeneralTransmitter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerboundStatusRequestPacket(EnumProtocolVersion version)
	{
		//IL_003a: Expected I4, but got Obj
		//IL_0028->IL0031: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ServerboundStatusRequestPacket serverboundStatusRequestPacket = this;
		if (0 == 0)
		{
			serverboundStatusRequestPacket = (ServerboundStatusRequestPacket)0;
		}
		switch ((int)serverboundStatusRequestPacket)
		{
		case 0:
			break;
		}
	}

	public void Read(IByteBuffer buffer)
	{
	}

	public void Write(IByteBuffer buffer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Handle(Connection connection)
	{
		return _FF00_FF00_FF00쨀(connection) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NewBridge()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerboundStatusRequestPacket CheckCommand()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed byte _FF00_FF00_FF00준(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779052, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed byte _FF00_FF00_FF00쨀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0041->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0099->IL0019: Incompatible stack heights: 15 vs 1
		//IL_004c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a4->IL0019: Incompatible stack heights: 15 vs 1
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
				return 1;
			case 1:
				obj = P_0;
				if (false)
				{
					obj2 = 0;
				}
				continue;
			}
			_ = 1;
			_ = 1;
			_ = obj != null;
			if (2 == 0)
			{
				_ = 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed byte _FF00_FF00_FF00쬀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779055, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00찀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00촀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779054, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00츀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00케()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779049, new IntPtr(2737368312108L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
