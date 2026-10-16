using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Packets.Play;

[Packet(EnumConnectionState.Play, EnumPacketDirection.Clientbound)]
[PacketVersion(EnumProtocolVersion.V1211, 46)]
[PacketVersion(EnumProtocolVersion.V1710, 21)]
[PacketVersion(EnumProtocolVersion.V1181, 41)]
[PacketVersion(EnumProtocolVersion.V1206, 46)]
[PacketVersion(EnumProtocolVersion.V1201, 43)]
[PacketVersion(EnumProtocolVersion.V1122, 38)]
[PacketVersion(EnumProtocolVersion.V189, 21)]
public class ClientboundEntityPositionPacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	private static object CheckCustomEncryptor;

	public int EntityId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)this._FF00_FF00_FFFD();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_EA00((uint)value);
		}
	}

	public short DeltaX
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (short)this._FF00_FF00_FFFD();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_E000((ushort)value);
		}
	}

	public short DeltaY
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (short)_FF00_FF00_EE00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_E300((ushort)value);
		}
	}

	public short DeltaZ
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (short)this._FF00_FF00_FFFD();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_E600((ushort)value);
		}
	}

	public bool OnGround
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_EC00() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_E100(value ? ((byte)1) : ((byte)0));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClientboundEntityPositionPacket(EnumProtocolVersion version)
	{
		//IL_003a: Expected I4, but got Obj
		//IL_0028->IL0031: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ClientboundEntityPositionPacket clientboundEntityPositionPacket = this;
		if (0 == 0)
		{
			clientboundEntityPositionPacket = (ClientboundEntityPositionPacket)0;
		}
		switch ((int)clientboundEntityPositionPacket)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(IByteBuffer buffer)
	{
		_FF00_FF00혀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_FF00_FF00팀(buffer);
	}

	public bool Handle(Connection connection)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckAdvancedController()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ClientboundEntityPositionPacket ReflectConvertibleFinder()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00툀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777635, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00팀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_005e: Expected I4, but got Obj
		//IL_010b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_011a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01d5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c1->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0091->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00fc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0136->IL0019: Incompatible stack types: I4 vs Obj
		//IL_016e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0152->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ad->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00cc->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 13:
				obj2 = P_0;
				if (2 != 0)
				{
					obj2 = 1;
				}
				break;
			case 2:
			case 11:
				if ((nint)this <= 5)
				{
					return;
				}
				obj2 = 8;
				break;
			case 15:
				obj2 = P_0;
				if (10 == 0)
				{
					obj2 = 8;
				}
				break;
			case 1:
				if ((nint)this > 5)
				{
					if (false)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 12;
			case 4:
				return;
			case 7:
			case 14:
				if ((nint)this > 47)
				{
					obj2 = 3;
					break;
				}
				goto case 15;
			case 5:
				obj2 = P_0;
				if (11 != 0)
				{
					obj2 = 8;
				}
				break;
			case 10:
				_ = 5;
				break;
			case 12:
				_ = 14;
				break;
			case 6:
				obj2 = P_0;
				if (6 != 0)
				{
					obj2 = 13;
				}
				break;
			case 3:
			case 9:
				obj2 = P_0;
				if (6 == 0)
				{
					obj2 = 3;
				}
				break;
			case 8:
				obj2 = P_0;
				if (3 == 0)
				{
					obj2 = 4;
				}
				break;
			default:
				obj2 = P_0;
				if (7 == 0)
				{
					obj2 = 7;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00퐀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777634, new IntPtr(2737368332908L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00픀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777661, new IntPtr(2737368319388L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00혀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0066: Expected I4, but got Obj
		//IL_00a6: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I4
		//IL_0079->IL0019: Incompatible stack heights: 3 vs 1
		//IL_016d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ea->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00ab->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0136->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00bd->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0099->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01ce->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01a4->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0178->IL0019: Incompatible stack heights: 2 vs 1
		//IL_011b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0141->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d1->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01d9->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01af->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0126->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00dc->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 14;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					_ = 3;
					continue;
				case 9:
				case 16:
					if ((nint)this <= 5)
					{
						obj2 = 6;
						continue;
					}
					goto case 1;
				case 12:
					_ = 17;
					continue;
				case 4:
					obj = 16;
					break;
				case 10:
					obj = 12;
					break;
				case 14:
					if ((nint)this <= 5)
					{
						if (true)
						{
							obj2 = 13;
						}
						continue;
					}
					goto case 15;
				case 2:
				case 11:
					_ = 5;
					continue;
				case 3:
				case 8:
					if ((nint)this > 47)
					{
						if (8 == 0)
						{
							obj2 = 11;
						}
						continue;
					}
					goto case 10;
				case 5:
					if (true)
					{
						_ = 4;
					}
					continue;
				case 6:
					return;
				case 1:
					if (3 == 0)
					{
						_ = 7;
					}
					continue;
				case 17:
					if (8 == 0)
					{
						_ = 9;
					}
					continue;
				case 15:
					if (7 == 0)
					{
						_ = 8;
					}
					continue;
				case 7:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00휀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777660, new IntPtr(2737368312108L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ushort _FF00_FF00_FFFD()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ushort)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ushort _FF00_FF00_FFFD()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ushort)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ushort _FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777663, new IntPtr(2737368312108L), 15))(null, 0, new IntPtr(0L));
		return (ushort)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FFFD()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777662, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777657, new IntPtr(2737368321468L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FFFD()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777656, new IntPtr(2737368320428L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_E000(ushort P_0)
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_E100(byte P_0)
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
				if (false)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_E200(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777659, new IntPtr(2737368332908L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_E300(ushort P_0)
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_E400(ushort P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777658, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_E500(ushort P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777653, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_E600(ushort P_0)
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
				if (false)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_E700(ushort P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777652, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_E800()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_E900()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777655, new IntPtr(2737368332908L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_EA00(uint P_0)
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
	internal unsafe void _FF00_FF00_EB00(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777654, new IntPtr(2737368332908L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_EC00()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_ED00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777649, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ushort _FF00_FF00_EE00()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ushort)(int)this;
	}
}
