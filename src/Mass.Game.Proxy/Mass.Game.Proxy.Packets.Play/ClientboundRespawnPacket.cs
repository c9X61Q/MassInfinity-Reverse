using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Nbt;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Packets.Play;

[PacketVersion(EnumProtocolVersion.V189, 7)]
[PacketVersion(EnumProtocolVersion.V1122, 53)]
[PacketVersion(EnumProtocolVersion.V1181, 61)]
[PacketVersion(EnumProtocolVersion.V1201, 65)]
[PacketVersion(EnumProtocolVersion.V1206, 71)]
[PacketVersion(EnumProtocolVersion.V1211, 71)]
[Packet(EnumConnectionState.Play, EnumPacketDirection.Clientbound)]
[PacketVersion(EnumProtocolVersion.V1710, 7)]
public class ClientboundRespawnPacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	internal static ClientboundRespawnPacket DeleteSubscriber;

	public int Dimension
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00똀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00뼀((uint)value);
		}
	}

	public byte Difficulty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00ꄀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00鈀(value);
		}
	}

	public byte Gamemode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00鰀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00밀(value);
		}
	}

	public string LevelType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00蔀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00茀(value);
		}
	}

	public NbtTag? NbtDimension
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (NbtTag?)_FF00쐀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00됀(value);
		}
	}

	public string DimensionName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00넀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00쀀(value);
		}
	}

	public long HashedSeed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00鸀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00鬀(value);
		}
	}

	public byte PreviousGamemode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00餀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00錀(value);
		}
	}

	public bool IsDebug
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00阀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00ꔀ(value ? ((byte)1) : ((byte)0));
		}
	}

	public bool IsFlat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_A700() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00윀(value ? ((byte)1) : ((byte)0));
		}
	}

	public bool CopyMetadata
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00退() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00謀(value ? ((byte)1) : ((byte)0));
		}
	}

	public string DimensionType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00褀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00가(value);
		}
	}

	public byte DataKept
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00꤀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00ꐀ(value);
		}
	}

	public bool HasDeathLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_AB00() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00頀(value ? ((byte)1) : ((byte)0));
		}
	}

	public string DeathDimensionName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00뜀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00먀(value);
		}
	}

	public Position DeathLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00꼀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00谀(value);
		}
	}

	public int PortalCooldown
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00鼀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00贀((uint)value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClientboundRespawnPacket(EnumProtocolVersion version)
	{
		//IL_005a: Expected I4, but got Obj
		//IL_0048->IL0051: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ClientboundRespawnPacket clientboundRespawnPacket = this;
		if (0 == 0)
		{
			clientboundRespawnPacket = (ClientboundRespawnPacket)0;
		}
		switch ((int)clientboundRespawnPacket)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(IByteBuffer buffer)
	{
		_FF00蘀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_FF00ꈀ(buffer);
	}

	public bool Handle(Connection connection)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectVisualEvent()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ClientboundRespawnPacket CheckScopeWrapper()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00舀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777836, new IntPtr(2737368332908L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00茀(object P_0)
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
				if (0 == 0)
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
	internal unsafe object _FF00萀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777839, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00蔀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00蘀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_00da: Expected I4, but got Obj
		//IL_0290: Expected Obj, but got I4
		//IL_034f: Expected Obj, but got I4
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Invalid comparison between Unknown and I4
		//IL_01d9: Expected Obj, but got I4
		//IL_03f2: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I4
		//IL_04aa: Expected Obj, but got I4
		//IL_0241: Expected Obj, but got I4
		//IL_022b->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0276->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0266->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02a5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01c7->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0364->IL0019: Incompatible stack heights: 2 vs 1
		//IL_030b->IL0019: Incompatible stack heights: 3 vs 1
		//IL_04bd->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02d4->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0467->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0295->IL0015: Incompatible stack heights: 3 vs 0
		//IL_018a->IL0019: Incompatible stack heights: 4 vs 1
		//IL_03df->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0337->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0407->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02e4->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0422->IL0019: Incompatible stack heights: 2 vs 1
		//IL_03c6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01a6->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0327->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0457->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02fd->IL0019: Incompatible stack heights: 3 vs 1
		//IL_037f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_021d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0487->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0198->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0204->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0398->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01b9->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0319->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01de->IL0015: Incompatible stack heights: 3 vs 0
		//IL_012c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0281->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02b0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_036f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_03ab->IL0019: Incompatible stack heights: 0 vs 1
		//IL_03f7->IL0015: Incompatible stack heights: 3 vs 0
		//IL_00f7->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0146->IL0019: Incompatible stack heights: 3 vs 1
		//IL_015b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0472->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0342->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0412->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02ef->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02c6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_042d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_03d1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_043e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0258->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0177->IL0019: Incompatible stack types: I4 vs Obj
		//IL_038a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0492->IL0019: Incompatible stack heights: 3 vs 1
		//IL_020f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0137->IL0019: Incompatible stack heights: 2 vs 1
		//IL_03b6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0102->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0166->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01ef->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0449->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 21;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 11:
					if ((nint)obj != 763)
					{
						if (28 == 0)
						{
							obj2 = 17;
						}
						continue;
					}
					_ = 32767;
					obj = 45;
					break;
				case 20:
					if ((nint)obj <= 340)
					{
						obj = 30;
						break;
					}
					if ((nint)obj == 757)
					{
						_ = 40;
						continue;
					}
					obj = 11;
					break;
				case 46:
					if (41 == 0)
					{
						_ = 35;
					}
					continue;
				case 22:
					return;
				case 12:
					if ((nint)obj != 47)
					{
						if (25 == 0)
						{
							obj2 = 10;
						}
						continue;
					}
					goto IL_0138;
				case 34:
					if (this != null)
					{
						obj2 = 16;
						continue;
					}
					goto case 18;
				case 16:
					_ = 32767;
					_ = 33;
					continue;
				case 39:
					_ = 43;
					continue;
				case 29:
					_ = 17;
					continue;
				case 42:
					_ = 32767;
					_ = 29;
					continue;
				case 5:
					_ = 44;
					continue;
				case 45:
					_ = 32767;
					obj = 13;
					break;
				case 15:
					return;
				case 40:
					_ = 32767;
					if (31 == 0)
					{
						_ = 23;
					}
					continue;
				case 36:
					_ = 6;
					continue;
				default:
					_ = 3;
					continue;
				case 38:
					return;
				case 30:
					if ((nint)obj != 5)
					{
						obj2 = 12;
						continue;
					}
					goto IL_0138;
				case 2:
					_ = 26;
					continue;
				case 1:
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 14:
					_ = 16;
					obj = 15;
					break;
				case 4:
					if (28 == 0)
					{
						_ = 46;
					}
					continue;
				case 25:
					if ((nint)obj != 340)
					{
						obj2 = 38;
						continue;
					}
					goto IL_0138;
				case 10:
					_ = 14;
					continue;
				case 24:
					if (true)
					{
						_ = 10;
					}
					continue;
				case 33:
					_ = 18;
					continue;
				case 8:
					_ = 36;
					continue;
				case 44:
					_ = 32;
					continue;
				case 31:
					_ = 2;
					continue;
				case 18:
					if (14 != 0)
					{
						_ = 39;
					}
					continue;
				case 21:
					obj = this;
					obj = 20;
					break;
				case 6:
					if (5 == 0)
					{
						_ = 0;
					}
					continue;
				case 35:
					if (34 != 0)
					{
						_ = 19;
					}
					continue;
				case 41:
					_ = 35;
					continue;
				case 7:
					if (this != null)
					{
						if (8 == 0)
						{
							obj2 = 37;
						}
						continue;
					}
					goto case 9;
				case 27:
					if (true)
					{
						_ = 1;
					}
					continue;
				case 17:
					_ = 4;
					continue;
				case 3:
					return;
				case 23:
					if (9 == 0)
					{
						_ = 5;
					}
					continue;
				case 26:
					if (27 != 0)
					{
						_ = 23;
					}
					continue;
				case 19:
					return;
				case 32:
					_ = 7;
					continue;
				case 13:
					if (8 == 0)
					{
						_ = 8;
					}
					continue;
				case 37:
					_ = 32767;
					if (2 != 0)
					{
						_ = 23;
					}
					continue;
				case 43:
					return;
				case 28:
					if (obj - 766 <= 1)
					{
						if (42 != 0)
						{
							_ = 12;
						}
						continue;
					}
					obj = 22;
					break;
				case 9:
					{
						_ = 19;
						continue;
					}
					IL_0138:
					_ = 24;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00蜀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777838, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00蠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777833, new IntPtr(2737368312108L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00褀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00言()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777832, new IntPtr(2737368321468L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00謀(byte P_0)
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
				if (0 == 0)
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
	internal void _FF00谀(Position P_0)
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
				if (0 == 0)
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
	internal void _FF00贀(uint P_0)
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
	internal static byte _FF00踀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00輀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777835, new IntPtr(2737368329788L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00退()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00鄀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777834, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00鈀(byte P_0)
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
	internal void _FF00錀(byte P_0)
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
	internal unsafe void _FF00鐀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777829, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00销()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777828, new IntPtr(2737368312108L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00阀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00需()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777831, new IntPtr(2737368322508L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00頀(byte P_0)
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
				if (0 == 0)
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
	internal byte _FF00餀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00騀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777830, new IntPtr(2737368326668L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00鬀(long P_0)
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
	internal byte _FF00鰀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00鴀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777825, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal long _FF00鸀()
	{
		//IL_000a: Expected I8, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (long)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00鼀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00ꀀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777824, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00ꄀ()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00ꈀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_00e2: Expected I4, but got Obj
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Invalid comparison between Unknown and I4
		//IL_0479: Expected Obj, but got I4
		//IL_02f3: Expected Obj, but got I4
		//IL_011f: Expected Obj, but got I4
		//IL_0401: Expected Obj, but got I4
		//IL_0522->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0399->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0513->IL0019: Incompatible stack heights: 2 vs 1
		//IL_035a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02c2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02b3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0196->IL0019: Incompatible stack heights: 2 vs 1
		//IL_04c5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0106->IL0019: Incompatible stack heights: 0 vs 1
		//IL_04f9->IL0019: Incompatible stack heights: 2 vs 1
		//IL_034b->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0209->IL0019: Incompatible stack heights: 2 vs 1
		//IL_047e->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0492->IL0019: Incompatible stack heights: 3 vs 1
		//IL_016b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_04d8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0424->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02f8->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0415->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00f6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0124->IL0015: Incompatible stack heights: 1 vs 0
		//IL_02e0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0466->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02d1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_015c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_036a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0187->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01ef->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0288->IL0019: Incompatible stack types: I4 vs Obj
		//IL_026c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02a4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0310->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0111->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0504->IL0019: Incompatible stack heights: 2 vs 1
		//IL_021e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0457->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04e3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01ae->IL0019: Incompatible stack heights: 0 vs 1
		//IL_025a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03ef->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03c8->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0140->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0337->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03b5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_022f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0441->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01fa->IL0019: Incompatible stack types: I4 vs Obj
		//IL_037f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_04ab->IL0019: Incompatible stack heights: 0 vs 1
		//IL_031b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01b9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03d3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_038a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_04b6->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 19;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 38:
					_ = 13;
					continue;
				case 19:
					obj = this;
					if (10 != 0)
					{
						obj2 = 18;
					}
					continue;
				case 42:
					obj = 38;
					break;
				case 41:
					obj2 = P_0;
					if (10 == 0)
					{
						obj2 = 3;
					}
					continue;
				case 4:
					obj2 = P_0;
					if (39 == 0)
					{
						obj2 = 18;
					}
					continue;
				case 28:
					_ = 44;
					continue;
				case 6:
					obj2 = P_0;
					if (3 != 0)
					{
						obj2 = 1;
					}
					continue;
				case 13:
					_ = 17;
					continue;
				case 31:
					if ((nint)obj != 340)
					{
						if (40 != 0)
						{
							obj2 = 19;
						}
						continue;
					}
					goto IL_035b;
				case 7:
					if (obj - 766 > 1)
					{
						if (29 == 0)
						{
							obj2 = 29;
						}
						continue;
					}
					obj2 = P_0;
					if (13 == 0)
					{
						obj2 = 21;
					}
					continue;
				case 22:
					_ = 42;
					continue;
				case 8:
					return;
				case 48:
					if (this == null)
					{
						obj2 = 26;
						continue;
					}
					goto case 33;
				case 34:
					obj2 = P_0;
					if (30 == 0)
					{
						obj2 = 27;
					}
					continue;
				case 14:
					if ((nint)obj != 5)
					{
						obj2 = 5;
						continue;
					}
					goto IL_035b;
				case 9:
					obj2 = P_0;
					if (11 != 0)
					{
						obj2 = 5;
					}
					continue;
				case 17:
					obj2 = P_0;
					if (8 != 0)
					{
						obj2 = 4;
					}
					continue;
				case 12:
					_ = 46;
					continue;
				case 11:
					_ = 37;
					continue;
				case 45:
					_ = 35;
					continue;
				case 43:
					_ = 15;
					continue;
				case 33:
					_ = 32767;
					obj = 43;
					break;
				case 18:
					if ((nint)obj > 340)
					{
						if (16 == 0)
						{
							obj2 = 3;
						}
						continue;
					}
					goto case 14;
				case 46:
					obj2 = P_0;
					if (47 != 0)
					{
						obj2 = 5;
					}
					continue;
				case 21:
					_ = 32767;
					_ = 28;
					continue;
				case 3:
					_ = 41;
					continue;
				case 29:
					return;
				case 10:
					return;
				case 36:
					return;
				case 1:
					_ = 22;
					continue;
				case 47:
					obj2 = P_0;
					if (9 == 0)
					{
						obj2 = 7;
					}
					continue;
				case 39:
					if (this != null)
					{
						if (25 != 0)
						{
							obj2 = 18;
						}
						continue;
					}
					goto case 3;
				case 35:
					obj2 = P_0;
					if (false)
					{
						obj2 = 0;
					}
					continue;
				case 5:
					if ((nint)obj != 47)
					{
						obj = 31;
						break;
					}
					goto IL_035b;
				case 37:
					_ = 48;
					continue;
				case 32:
					_ = 12;
					continue;
				case 24:
					return;
				case 27:
					if ((nint)obj != 763)
					{
						obj2 = 7;
						continue;
					}
					_ = 32767;
					_ = 23;
					continue;
				case 44:
					_ = 45;
					continue;
				case 23:
					_ = 32767;
					obj = 32;
					break;
				case 25:
					_ = 32767;
					_ = 6;
					continue;
				case 40:
					return;
				case 16:
					if ((nint)obj == 757)
					{
						if (20 == 0)
						{
							_ = 11;
						}
					}
					else if (27 != 0)
					{
						obj2 = 25;
					}
					continue;
				case 15:
				case 26:
					_ = 24;
					continue;
				case 30:
					_ = 16;
					if (7 == 0)
					{
						_ = 36;
					}
					continue;
				case 20:
					_ = 32767;
					if (false)
					{
						_ = 1;
					}
					continue;
				case 2:
					_ = 34;
					continue;
				default:
					{
						_ = 4;
						continue;
					}
					IL_035b:
					_ = 2;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00ꌀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777827, new IntPtr(2737368330828L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00ꐀ(byte P_0)
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
	internal void _FF00ꔀ(byte P_0)
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
				if (0 == 0)
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
	internal unsafe void _FF00ꘀ(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777826, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_A700()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00ꠀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777853, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00꤀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00ꨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777852, new IntPtr(2737368317308L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_AB00()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00가(object P_0)
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
	internal unsafe void _FF00관(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777855, new IntPtr(2737368315228L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Position _FF00글()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777854, new IntPtr(2737368317308L), 15))(null, 0, new IntPtr(0L));
		return (Position)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Position _FF00꼀()
	{
		//IL_000a: Expected VT, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (Position)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00뀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777849, new IntPtr(2737368332908L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00넀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00눀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777848, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00대(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777851, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00됀(object P_0)
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
	internal unsafe uint _FF00딀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777850, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00똀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00뜀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00렀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777845, new IntPtr(2737368302748L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00뤀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777844, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00먀(object P_0)
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
	internal unsafe void _FF00묀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777847, new IntPtr(2737368312108L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00밀(byte P_0)
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
	internal unsafe void _FF00봀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777846, new IntPtr(2737368322508L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00븀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777841, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00뼀(uint P_0)
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
				if (0 == 0)
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
	internal void _FF00쀀(object P_0)
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
	internal unsafe void _FF00섀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777840, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00숀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00쌀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777843, new IntPtr(2737368332908L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00쐀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00씀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777842, new IntPtr(2737368315228L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00였(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777805, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00윀(byte P_0)
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
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}
}
