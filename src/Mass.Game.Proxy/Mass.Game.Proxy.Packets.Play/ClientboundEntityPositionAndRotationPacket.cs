using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Packets.Play;

[PacketVersion(EnumProtocolVersion.V1206, 47)]
[PacketVersion(EnumProtocolVersion.V1122, 39)]
[Packet(EnumConnectionState.Play, EnumPacketDirection.Clientbound)]
[PacketVersion(EnumProtocolVersion.V1710, 23)]
[PacketVersion(EnumProtocolVersion.V1181, 42)]
[PacketVersion(EnumProtocolVersion.V1201, 44)]
[PacketVersion(EnumProtocolVersion.V189, 23)]
[PacketVersion(EnumProtocolVersion.V1211, 47)]
public class ClientboundEntityPositionAndRotationPacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	internal static ClientboundEntityPositionAndRotationPacket MergeAnalyzer;

	public int EntityId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00က();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_0E00((uint)value);
		}
	}

	public short DeltaX
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (short)_FF00_FF00_F700();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_F000((ushort)value);
		}
	}

	public short DeltaY
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (short)_FF00_FF00_FF00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00ᄀ((ushort)value);
		}
	}

	public short DeltaZ
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (short)_FF00_FF00_FE00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_0B00((ushort)value);
		}
	}

	public byte Yaw
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_F800();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00ࠀ(value);
		}
	}

	public byte Pitch
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_F400();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00ጀ(value);
		}
	}

	public bool OnGround
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_F200() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00ﬀ(value ? ((byte)1) : ((byte)0));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClientboundEntityPositionAndRotationPacket(EnumProtocolVersion version)
	{
		//IL_003a: Expected I4, but got Obj
		//IL_0028->IL0031: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ClientboundEntityPositionAndRotationPacket clientboundEntityPositionAndRotationPacket = this;
		if (false)
		{
			clientboundEntityPositionAndRotationPacket = (ClientboundEntityPositionAndRotationPacket)0;
		}
		switch ((int)clientboundEntityPositionAndRotationPacket)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(IByteBuffer buffer)
	{
		_FF00_FF00ﴀ(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_0300(buffer);
	}

	public bool Handle(Connection connection)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateGenericResponder()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ClientboundEntityPositionAndRotationPacket ReflectRandomStream()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_EF00(ushort P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779089, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_F000(ushort P_0)
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
	internal unsafe void _FF00_FF00_F100(ushort P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779088, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_F200()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_F300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779091, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_F400()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_F500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779090, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ushort _FF00_FF00_F600()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777645, new IntPtr(2737368330828L), 15))(null, 0, new IntPtr(0L));
		return (ushort)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ushort _FF00_FF00_F700()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ushort)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_F800()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00豈()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777644, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00切(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777647, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00ﬀ(byte P_0)
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
	internal unsafe void _FF00_FF00ﰀ(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777646, new IntPtr(2737368301708L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00ﴀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0066: Expected I4, but got Obj
		//IL_00ee->IL0019: Incompatible stack heights: 3 vs 1
		//IL_018a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0163->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_017c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_008c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00fc->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00c4->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01d2->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0128->IL0019: Incompatible stack heights: 2 vs 1
		//IL_019a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0148->IL0019: Incompatible stack heights: 0 vs 1
		//IL_016e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01b9->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0133->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01a5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0153->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01c4->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 10;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 10:
				if ((nint)this > 5)
				{
					obj2 = 9;
					break;
				}
				goto case 16;
			case 4:
				return;
			case 9:
				_ = 3;
				break;
			case 7:
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 5:
			case 13:
				_ = 6;
				break;
			case 1:
				_ = 13;
				break;
			case 12:
				_ = 17;
				break;
			case 16:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			default:
				if ((nint)this > 47)
				{
					if (10 == 0)
					{
						obj2 = 15;
					}
					break;
				}
				goto case 12;
			case 6:
				if (11 != 0)
				{
					_ = 8;
				}
				break;
			case 8:
				_ = 5;
				break;
			case 2:
			case 15:
				_ = 7;
				break;
			case 17:
				if (8 == 0)
				{
					_ = 8;
				}
				break;
			case 11:
				if ((nint)this <= 5)
				{
					return;
				}
				if (14 == 0)
				{
					obj2 = 1;
				}
				break;
			case 14:
				_ = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ushort _FF00_FF00_FE00()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ushort)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ushort _FF00_FF00_FF00()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ushort)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ushort _FF00_FF00_FF00Ā()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777641, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		return (ushort)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00Ȁ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777640, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_0300(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0066: Expected I4, but got Obj
		//IL_0183->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0089->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00fb->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0159->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01ea->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ec->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0129->IL0019: Incompatible stack types: I4 vs Obj
		//IL_010d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01b2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_019f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0145->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01ce->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0164->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 7;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
			case 13:
				_ = 4;
				continue;
			case 6:
			case 11:
				_ = 8;
				continue;
			case 9:
				obj2 = P_0;
				if (12 != 0)
				{
					obj2 = 0;
				}
				continue;
			case 4:
				obj2 = P_0;
				if (false)
				{
					obj2 = 0;
				}
				continue;
			case 12:
				_ = 2;
				continue;
			case 7:
				if ((nint)this <= 5)
				{
					obj2 = 6;
					continue;
				}
				break;
			case 5:
				obj2 = P_0;
				if (15 != 0)
				{
					obj2 = 14;
				}
				continue;
			case 14:
				obj2 = P_0;
				if (3 == 0)
				{
					obj2 = 5;
				}
				continue;
			default:
				if ((nint)this > 5)
				{
					if (0 == 0)
					{
						obj2 = 1;
					}
					continue;
				}
				return;
			case 17:
				return;
			case 1:
				_ = 17;
				continue;
			case 10:
				obj2 = P_0;
				if (2 == 0)
				{
					obj2 = 9;
				}
				continue;
			case 8:
			case 16:
				if ((nint)this <= 47)
				{
					obj2 = 10;
					continue;
				}
				goto case 14;
			case 15:
				obj2 = P_0;
				if (13 == 0)
				{
					obj2 = 5;
				}
				continue;
			case 3:
				break;
			}
			obj2 = P_0;
			if (13 == 0)
			{
				obj2 = 16;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00Ѐ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777643, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00Ԁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777642, new IntPtr(2737368329788L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_0600()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_0700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777637, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00ࠀ(byte P_0)
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
	internal unsafe void _FF00_FF00_FF00_0900(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777636, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_0A00(ushort P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777639, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_0B00(ushort P_0)
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
	internal static object _FF00_FF00_FF00_0C00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_0D00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777638, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_0E00(uint P_0)
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
	internal unsafe uint _FF00_FF00_FF00ༀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777633, new IntPtr(2737368315228L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00က()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00ᄀ(ushort P_0)
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
	internal unsafe void _FF00_FF00_FF00ሀ(ushort P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777632, new IntPtr(2737368312108L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00ጀ(byte P_0)
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
}
