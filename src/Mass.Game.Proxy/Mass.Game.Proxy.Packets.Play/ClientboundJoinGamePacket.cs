using System;
using System.Collections.Generic;
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

[PacketVersion(EnumProtocolVersion.V1206, 43)]
[PacketVersion(EnumProtocolVersion.V189, 1)]
[PacketVersion(EnumProtocolVersion.V1710, 1)]
[PacketVersion(EnumProtocolVersion.V1122, 35)]
[PacketVersion(EnumProtocolVersion.V1181, 38)]
[Packet(EnumConnectionState.Play, EnumPacketDirection.Clientbound)]
[PacketVersion(EnumProtocolVersion.V1211, 43)]
[PacketVersion(EnumProtocolVersion.V1201, 40)]
public class ClientboundJoinGamePacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	private static object DecorateBasicTree;

	public int EntityId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00萀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00頀((uint)value);
		}
	}

	public byte Gamemode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00耀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00阀(value);
		}
	}

	public int Dimension
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00ꌀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00退((uint)value);
		}
	}

	public byte Difficulty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00䐀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00鰀(value);
		}
	}

	public int MaxPlayers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00嘀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00䨀((uint)value);
		}
	}

	public string LevelType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00褀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00謀(value);
		}
	}

	public bool ReducedDebugInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00吀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00蔀(value ? ((byte)1) : ((byte)0));
		}
	}

	public bool IsHardcore
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00挀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00怀(value ? ((byte)1) : ((byte)0));
		}
	}

	public byte PreviousGamemode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00ꐀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00嬀(value);
		}
	}

	public List<string> DimensionNames
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00鼀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00紀(value);
		}
	}

	public NbtTag? NbtDimensionCodec
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (NbtTag?)_FF00_FF00㸀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00洀(value);
		}
	}

	public NbtTag? NbtDimension
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (NbtTag?)_FF00_FF00琀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00蜀(value);
		}
	}

	public string DimensionName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00䜀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00ꄀ(value);
		}
	}

	public long HashedSeed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00䀀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00稀(value);
		}
	}

	public int ViewDistance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00茀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00䬀((uint)value);
		}
	}

	public int SimulationDistance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00鈀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00䠀((uint)value);
		}
	}

	public bool EnableRespawnScreen
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00夀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00鐀(value ? ((byte)1) : ((byte)0));
		}
	}

	public bool IsDebug
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00瀀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00昀(value ? ((byte)1) : ((byte)0));
		}
	}

	public bool IsFlat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00漀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00谀(value ? ((byte)1) : ((byte)0));
		}
	}

	public NbtTag? RegistryCodec
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (NbtTag?)_FF00_FF00刀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00礀(value);
		}
	}

	public string DimensionType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00樀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00眀(value);
		}
	}

	public bool HasDeathLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00蠀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00欀(value ? ((byte)1) : ((byte)0));
		}
	}

	public string DeathDimensionName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00䔀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00瘀(value);
		}
	}

	public Position DeathLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00䌀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00椀(value);
		}
	}

	public int PortalCooldown
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00踀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00栀((uint)value);
		}
	}

	public bool DoLimitedCrafting
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00焀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00伀(value ? ((byte)1) : ((byte)0));
		}
	}

	public bool EnforcesSecureChat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00崀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00䴀(value ? ((byte)1) : ((byte)0));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClientboundJoinGamePacket(EnumProtocolVersion version)
	{
		//IL_0062: Expected I4, but got Obj
		//IL_0050->IL0059: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ClientboundJoinGamePacket clientboundJoinGamePacket = this;
		if (0 == 0)
		{
			clientboundJoinGamePacket = (ClientboundJoinGamePacket)0;
		}
		switch ((int)clientboundJoinGamePacket)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(IByteBuffer buffer)
	{
		_FF00_FF00錀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_FF00_FF00䈀(buffer);
	}

	public bool Handle(Connection connection)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateReadableFilter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ClientboundJoinGamePacket SetProfiler()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00㴀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777627, new IntPtr(2737368319388L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00㸀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00㼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777626, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal long _FF00_FF00䀀()
	{
		//IL_000a: Expected I8, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (long)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe long _FF00_FF00䄀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777621, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (long)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00䈀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_019e: Expected I4, but got Obj
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Invalid comparison between Unknown and I4
		//IL_01e9: Expected Obj, but got I4
		//IL_0297: Expected Obj, but got I4
		//IL_0415: Expected Obj, but got I4
		//IL_098f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_051a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0489->IL0019: Incompatible stack heights: 2 vs 1
		//IL_079e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0881->IL0019: Incompatible stack heights: 2 vs 1
		//IL_09c2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_09b1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_06c6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_08bb->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0507->IL0019: Incompatible stack heights: 2 vs 1
		//IL_08aa->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0782->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0597->IL0019: Incompatible stack heights: 2 vs 1
		//IL_025e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0705->IL0019: Incompatible stack heights: 3 vs 1
		//IL_049a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02cb->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0716->IL0019: Incompatible stack heights: 2 vs 1
		//IL_054d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0224->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0467->IL0019: Incompatible stack heights: 2 vs 1
		//IL_06ae->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0342->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01ee->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0727->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0669->IL0019: Incompatible stack heights: 2 vs 1
		//IL_05b3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_03cc->IL0019: Incompatible stack heights: 0 vs 1
		//IL_092c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_04cd->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0811->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0213->IL0019: Incompatible stack heights: 3 vs 1
		//IL_036f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_08cc->IL0019: Incompatible stack heights: 2 vs 1
		//IL_07de->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0528->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0899->IL0019: Incompatible stack types: I4 vs Obj
		//IL_056f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_039e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0580->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0979->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0a14->IL0019: Incompatible stack heights: 3 vs 1
		//IL_055e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0246->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0235->IL0019: Incompatible stack heights: 2 vs 1
		//IL_035e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02dc->IL0019: Incompatible stack heights: 2 vs 1
		//IL_08fb->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0478->IL0019: Incompatible stack heights: 2 vs 1
		//IL_029c->IL0015: Incompatible stack heights: 1 vs 0
		//IL_0869->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0400->IL0019: Incompatible stack heights: 2 vs 1
		//IL_07af->IL0019: Incompatible stack heights: 2 vs 1
		//IL_05fd->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0658->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0287->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0754->IL0019: Incompatible stack types: I4 vs Obj
		//IL_088c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_06d1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_03ef->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0629->IL0019: Incompatible stack heights: 2 vs 1
		//IL_069d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0438->IL0019: Incompatible stack types: I4 vs Obj
		//IL_078d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_05a2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0269->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0456->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04b8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_053a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0968->IL0019: Incompatible stack types: I4 vs Obj
		//IL_083a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02ba->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0647->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0318->IL0019: Incompatible stack types: I4 vs Obj
		//IL_034d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0955->IL0019: Incompatible stack types: I4 vs Obj
		//IL_07cd->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03d7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0937->IL0019: Incompatible stack heights: 2 vs 1
		//IL_04d8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_081c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_03bc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02fa->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0858->IL0019: Incompatible stack types: I4 vs Obj
		//IL_08ea->IL0019: Incompatible stack types: I4 vs Obj
		//IL_032a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_06ef->IL0019: Incompatible stack types: I4 vs Obj
		//IL_076a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0914->IL0019: Incompatible stack types: I4 vs Obj
		//IL_067c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_09e0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0a32->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04f6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01b5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_05d1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_038d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0608->IL0019: Incompatible stack heights: 2 vs 1
		//IL_09a0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01d4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_09ff->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0687->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 62;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 21:
					return;
				case 87:
					_ = 83;
					continue;
				case 63:
					return;
				case 40:
					_ = 32767;
					obj = 39;
					break;
				case 52:
					_ = 32767;
					_ = 8;
					continue;
				case 32:
					_ = 72;
					continue;
				case 78:
					_ = 89;
					continue;
				case 77:
					_ = 95;
					continue;
				case 20:
					_ = 32767;
					if (3 == 0)
					{
						_ = 2;
					}
					continue;
				case 2:
					obj2 = obj;
					if (35 != 0)
					{
						obj2 = 21;
					}
					continue;
				case 86:
					obj = 7;
					break;
				case 34:
					obj2 = obj;
					if (21 != 0)
					{
						obj2 = 28;
					}
					continue;
				case 28:
					_ = 90;
					continue;
				case 80:
					_ = 79;
					continue;
				case 54:
					obj2 = obj;
					if (2 != 0)
					{
						obj2 = 5;
					}
					continue;
				case 37:
					obj2 = obj;
					if (23 != 0)
					{
						obj2 = 31;
					}
					continue;
				case 64:
					if ((nint)obj != 5)
					{
						obj2 = 26;
						continue;
					}
					goto case 23;
				case 39:
					_ = 32767;
					if (41 != 0)
					{
						_ = 45;
					}
					continue;
				case 79:
					_ = 67;
					continue;
				case 56:
					_ = 41;
					continue;
				case 92:
					obj2 = obj;
					if (71 != 0)
					{
						obj2 = 2;
					}
					continue;
				case 67:
					_ = 91;
					continue;
				case 51:
					obj2 = obj;
					if (20 == 0)
					{
						obj2 = 54;
					}
					continue;
				case 47:
					obj = this;
					if (66 == 0)
					{
						obj2 = 69;
					}
					continue;
				case 10:
					if (obj - 766 <= 1)
					{
						obj2 = 87;
						continue;
					}
					goto case 11;
				case 89:
					_ = 68;
					continue;
				case 53:
				case 66:
					if ((nint)obj == 757)
					{
						obj2 = obj;
						if (17 != 0)
						{
							obj2 = 59;
						}
						continue;
					}
					obj = 15;
					break;
				case 16:
					obj2 = obj;
					if (2 == 0)
					{
						obj2 = 44;
					}
					continue;
				case 22:
					obj2 = obj;
					if (14 != 0)
					{
						obj2 = 0;
					}
					continue;
				case 33:
					_ = 75;
					continue;
				case 85:
					_ = 38;
					continue;
				case 3:
					_ = 4;
					continue;
				case 27:
					_ = 63;
					continue;
				case 23:
					obj2 = obj;
					if (57 == 0)
					{
						obj2 = 22;
					}
					continue;
				case 49:
					if (30 == 0)
					{
						_ = 30;
					}
					continue;
				case 83:
					obj2 = obj;
					if (4 == 0)
					{
						obj2 = 50;
					}
					continue;
				case 13:
					_ = 25;
					continue;
				case 1:
					_ = 9;
					continue;
				case 61:
					_ = 93;
					continue;
				case 76:
					return;
				case 30:
					_ = 52;
					continue;
				case 75:
					_ = 51;
					continue;
				case 65:
					_ = 19;
					continue;
				case 71:
					_ = 2;
					continue;
				case 19:
					if (true)
					{
						_ = 1;
					}
					continue;
				case 45:
					_ = 34;
					continue;
				case 91:
					obj2 = obj;
					if (77 == 0)
					{
						obj2 = 2;
					}
					continue;
				case 93:
					if (47 != 0)
					{
						_ = 44;
					}
					continue;
				case 43:
					return;
				case 35:
					obj2 = obj;
					if (40 != 0)
					{
						obj2 = 14;
					}
					continue;
				case 94:
					_ = 13;
					continue;
				case 42:
					_ = 78;
					continue;
				case 73:
					if (this != null)
					{
						if (10 != 0)
						{
							obj2 = 17;
						}
						continue;
					}
					goto case 86;
				case 15:
					if ((nint)obj != 763)
					{
						obj2 = 10;
					}
					else
					{
						_ = 88;
					}
					continue;
				case 38:
					_ = 43;
					continue;
				case 9:
					_ = 32767;
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 68:
					obj2 = obj;
					if (80 == 0)
					{
						obj2 = 69;
					}
					continue;
				case 25:
					_ = 32767;
					_ = 27;
					continue;
				case 29:
					_ = 32;
					continue;
				case 41:
					_ = 94;
					continue;
				case 4:
				case 24:
					obj2 = obj;
					if (21 != 0)
					{
						obj2 = 21;
					}
					continue;
				case 69:
					if ((nint)obj > 340)
					{
						obj2 = 53;
						continue;
					}
					goto case 64;
				case 17:
					_ = 32767;
					if (84 != 0)
					{
						_ = 34;
					}
					continue;
				case 5:
					_ = 85;
					continue;
				case 90:
					_ = 37;
					continue;
				case 46:
					obj2 = obj;
					if (17 == 0)
					{
						obj2 = 74;
					}
					continue;
				case 59:
					_ = 82;
					continue;
				case 50:
					if (22 != 0)
					{
						_ = 22;
					}
					continue;
				case 31:
					obj2 = obj;
					if (23 != 0)
					{
						obj2 = 73;
					}
					continue;
				case 55:
					obj2 = obj;
					if (40 != 0)
					{
						obj2 = 65;
					}
					continue;
				case 88:
					_ = 55;
					continue;
				case 6:
					_ = 32767;
					if (31 == 0)
					{
						_ = 76;
					}
					continue;
				case 62:
					obj = (object)/*Error near IL_088f: Stack underflow*/;
					obj2 = 61;
					continue;
				case 14:
					_ = 92;
					continue;
				case 12:
					_ = 48;
					continue;
				case 58:
					_ = 12;
					continue;
				case 57:
					obj2 = obj;
					if (21 != 0)
					{
						obj2 = 29;
					}
					continue;
				case 84:
					_ = 86;
					continue;
				case 60:
					return;
				case 11:
				case 18:
					throw /*Error near IL_08fe: Stack underflow*/;
				case 70:
					if ((nint)obj != 340)
					{
						obj2 = 11;
						continue;
					}
					obj2 = obj;
					if (48 == 0)
					{
						obj2 = 56;
					}
					continue;
				case 48:
					_ = 32767;
					if (0 == 0)
					{
						_ = 81;
					}
					continue;
				case 44:
					obj2 = obj;
					if (58 == 0)
					{
						obj2 = 55;
					}
					continue;
				case 26:
					if ((nint)obj != 47)
					{
						obj2 = 70;
					}
					else
					{
						_ = 16;
					}
					continue;
				case 72:
					_ = 6;
					continue;
				default:
					_ = 32767;
					_ = 42;
					continue;
				case 95:
					if (this == null)
					{
						obj2 = 24;
						continue;
					}
					goto case 20;
				case 8:
					_ = 33;
					continue;
				case 7:
					_ = 60;
					continue;
				case 81:
					obj2 = obj;
					if (32 == 0)
					{
						obj2 = 36;
					}
					continue;
				case 36:
					return;
				case 74:
					_ = 49;
					continue;
				case 82:
					obj2 = obj;
					if (22 != 0)
					{
						obj2 = 46;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Position _FF00_FF00䌀()
	{
		//IL_000a: Expected VT, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (Position)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00䐀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00䔀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00䘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777620, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00䜀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00䠀(uint P_0)
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
	internal unsafe void _FF00_FF00䤀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777623, new IntPtr(2737368317308L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00䨀(uint P_0)
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
	internal void _FF00_FF00䬀(uint P_0)
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
	internal unsafe void _FF00_FF00䰀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777622, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00䴀(byte P_0)
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
	internal unsafe void _FF00_FF00一(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777617, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00伀(byte P_0)
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
	internal unsafe void _FF00_FF00倀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777616, new IntPtr(2737368319388L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00儀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777619, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00刀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00匀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777618, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00吀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00唀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777709, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00嘀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00圀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777708, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00堀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777711, new IntPtr(2737368302748L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00夀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00娀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777710, new IntPtr(2737368302748L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00嬀(byte P_0)
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
	internal unsafe void _FF00_FF00尀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777705, new IntPtr(2737368322508L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00崀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00帀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777704, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00开(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777707, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00怀(byte P_0)
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
	internal unsafe void _FF00_FF00愀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777706, new IntPtr(2737368320428L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00戀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777701, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00挀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00搀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777700, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00攀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777703, new IntPtr(2737368312108L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00昀(byte P_0)
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
	internal unsafe void _FF00_FF00最(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777702, new IntPtr(2737368317308L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00栀(uint P_0)
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
	internal void _FF00_FF00椀(Position P_0)
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
	internal object _FF00_FF00樀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00欀(byte P_0)
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
	internal unsafe void _FF00_FF00氀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777697, new IntPtr(2737368305868L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00洀(object P_0)
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
	internal unsafe byte _FF00_FF00渀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777696, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00漀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00瀀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00焀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00爀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00猀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777699, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00琀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00甀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777698, new IntPtr(2737368308988L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00瘀(object P_0)
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
	internal void _FF00_FF00眀(object P_0)
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
	internal unsafe void _FF00_FF00砀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777725, new IntPtr(2737368301708L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00礀(object P_0)
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
	internal void _FF00_FF00稀(long P_0)
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
	internal unsafe void _FF00_FF00笀(long P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777724, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00簀(List<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777727, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00紀(List<string> P_0)
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
	internal unsafe void _FF00_FF00縀(List<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777726, new IntPtr(2737368326668L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00缀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777721, new IntPtr(2737368330828L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00耀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00脀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777720, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00舀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777723, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00茀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00萀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00蔀(byte P_0)
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
	internal unsafe void _FF00_FF00蘀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777722, new IntPtr(2737368302748L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00蜀(object P_0)
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
	internal byte _FF00_FF00蠀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00褀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00言()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777717, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00謀(object P_0)
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
	internal void _FF00_FF00谀(byte P_0)
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
	internal unsafe void _FF00_FF00贀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777716, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00踀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00輀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777719, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00退(uint P_0)
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
	internal unsafe void _FF00_FF00鄀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777718, new IntPtr(2737368315228L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00鈀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00錀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0196: Expected I4, but got Obj
		//IL_02ce: Expected Obj, but got I4
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Invalid comparison between Unknown and I4
		//IL_039d: Expected Obj, but got I4
		//IL_0857: Expected Obj, but got I4
		//IL_05aa: Expected Obj, but got I4
		//IL_0876: Expected Obj, but got I4
		//IL_03b2->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02d3->IL0015: Incompatible stack heights: 2 vs 0
		//IL_05d4->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0653->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0527->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0618->IL0019: Incompatible stack heights: 2 vs 1
		//IL_059b->IL0019: Incompatible stack heights: 4 vs 1
		//IL_04c1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0710->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0848->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0663->IL0019: Incompatible stack heights: 3 vs 1
		//IL_03d8->IL0019: Incompatible stack heights: 3 vs 1
		//IL_08aa->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0838->IL0019: Incompatible stack heights: 3 vs 1
		//IL_079f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0606->IL0019: Incompatible stack heights: 3 vs 1
		//IL_06d0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_06be->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0329->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0643->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0245->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0774->IL0019: Incompatible stack heights: 2 vs 1
		//IL_088d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0468->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0740->IL0019: Incompatible stack heights: 3 vs 1
		//IL_06a0->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0700->IL0019: Incompatible stack heights: 3 vs 1
		//IL_047d->IL0019: Incompatible stack heights: 4 vs 1
		//IL_02f4->IL0019: Incompatible stack heights: 3 vs 1
		//IL_08f3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0517->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0314->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0231->IL0019: Incompatible stack heights: 3 vs 1
		//IL_048d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_07fb->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0257->IL0019: Incompatible stack heights: 2 vs 1
		//IL_05e6->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0633->IL0019: Incompatible stack heights: 3 vs 1
		//IL_06b0->IL0019: Incompatible stack heights: 3 vs 1
		//IL_05f6->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0570->IL0019: Incompatible stack heights: 3 vs 1
		//IL_028f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_03a2->IL0015: Incompatible stack heights: 3 vs 0
		//IL_090e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0816->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0211->IL0019: Incompatible stack heights: 3 vs 1
		//IL_06f0->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0221->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0828->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0360->IL0019: Incompatible stack heights: 3 vs 1
		//IL_04e0->IL0019: Incompatible stack heights: 4 vs 1
		//IL_042d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0757->IL0019: Incompatible stack heights: 3 vs 1
		//IL_03ed->IL0019: Incompatible stack heights: 4 vs 1
		//IL_085c->IL0015: Incompatible stack heights: 2 vs 0
		//IL_078f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0505->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0274->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0675->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0412->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0720->IL0019: Incompatible stack heights: 3 vs 1
		//IL_08c7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02ad->IL0019: Incompatible stack heights: 3 vs 1
		//IL_05af->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0555->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0304->IL0019: Incompatible stack heights: 3 vs 1
		//IL_029d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_043c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_04a4->IL0019: Incompatible stack heights: 3 vs 1
		//IL_05c4->IL0019: Incompatible stack heights: 4 vs 1
		//IL_01ad->IL0019: Incompatible stack heights: 2 vs 1
		//IL_07cb->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0690->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0201->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0730->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0623->IL0019: Incompatible stack heights: 2 vs 1
		//IL_04cc->IL0019: Incompatible stack heights: 2 vs 1
		//IL_08b5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_033a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_06db->IL0019: Incompatible stack heights: 2 vs 1
		//IL_07de->IL0019: Incompatible stack heights: 0 vs 1
		//IL_077f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0898->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01f1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02bf->IL0019: Incompatible stack types: I4 vs Obj
		//IL_08fe->IL0019: Incompatible stack heights: 2 vs 1
		//IL_04f1->IL0019: Incompatible stack heights: 3 vs 1
		//IL_03c8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_037e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01d0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_091f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0400->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0806->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0262->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02e4->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0458->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0586->IL0019: Incompatible stack types: I4 vs Obj
		//IL_036b->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0762->IL0019: Incompatible stack heights: 3 vs 1
		//IL_027f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0680->IL0019: Incompatible stack heights: 2 vs 1
		//IL_041d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_08d2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0560->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0447->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04af->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01b8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_07e9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0389->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01db->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 85;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 88:
					if (3 == 0)
					{
						_ = 2;
					}
					continue;
				case 43:
					if ((nint)obj != 763)
					{
						if (16 != 0)
						{
							obj2 = 27;
						}
					}
					else if (5 != 0)
					{
						_ = 55;
					}
					continue;
				case 30:
					if ((nint)obj <= 340)
					{
						obj2 = 32;
						continue;
					}
					goto case 65;
				case 91:
					_ = 92;
					continue;
				case 60:
					_ = 15;
					continue;
				case 62:
					_ = 91;
					continue;
				case 46:
					_ = 10;
					continue;
				case 22:
					_ = 63;
					continue;
				case 49:
					if (21 == 0)
					{
						_ = 7;
					}
					continue;
				case 74:
					if (21 == 0)
					{
						_ = 28;
					}
					continue;
				case 56:
					_ = 77;
					continue;
				case 84:
					_ = 19;
					continue;
				case 79:
					_ = 76;
					continue;
				case 32:
					if ((nint)obj != 5)
					{
						obj2 = 44;
						continue;
					}
					goto case 18;
				case 1:
					obj = 67;
					break;
				case 82:
					return;
				case 64:
					_ = 2;
					continue;
				case 35:
					_ = 59;
					continue;
				case 83:
					_ = 23;
					continue;
				case 40:
					_ = 8;
					continue;
				case 20:
					_ = 32767;
					_ = 93;
					continue;
				case 16:
					if (this != null)
					{
						obj2 = 57;
						continue;
					}
					goto case 81;
				case 66:
					_ = 32767;
					if (8 == 0)
					{
						_ = 11;
					}
					continue;
				case 54:
					return;
				case 57:
					_ = 32767;
					obj = 89;
					break;
				default:
					_ = 24;
					continue;
				case 42:
					if ((nint)obj != 340)
					{
						obj2 = 41;
					}
					else
					{
						_ = 79;
					}
					continue;
				case 12:
					_ = 61;
					continue;
				case 70:
					_ = 32767;
					_ = 47;
					continue;
				case 44:
					if ((nint)obj != 47)
					{
						obj2 = 42;
					}
					else
					{
						_ = 60;
					}
					continue;
				case 76:
					if (22 == 0)
					{
						_ = 74;
					}
					continue;
				case 68:
					_ = 7;
					continue;
				case 85:
					obj = (object)/*Error near IL_0430: Stack underflow*/;
					if (69 == 0)
					{
						obj2 = 84;
					}
					continue;
				case 39:
					return;
				case 26:
					_ = 16;
					continue;
				case 34:
					_ = 32767;
					_ = 14;
					continue;
				case 47:
					_ = 80;
					continue;
				case 86:
					_ = 32767;
					if (40 == 0)
					{
						_ = 66;
					}
					continue;
				case 7:
					if (0 == 0)
					{
						_ = 1;
					}
					continue;
				case 67:
					_ = 38;
					continue;
				case 29:
					return;
				case 73:
					_ = 51;
					continue;
				case 38:
					_ = 50;
					continue;
				case 4:
					_ = 48;
					continue;
				case 81:
					if (82 == 0)
					{
						_ = 15;
					}
					continue;
				case 55:
					_ = 56;
					continue;
				case 65:
					if ((nint)obj != 757)
					{
						obj2 = 43;
					}
					else
					{
						_ = 68;
					}
					continue;
				case 6:
					_ = 32767;
					_ = 72;
					continue;
				case 45:
				case 80:
					obj = 46;
					break;
				case 87:
					_ = 32767;
					_ = 53;
					continue;
				case 2:
					_ = 73;
					continue;
				case 50:
					_ = 69;
					continue;
				case 53:
					_ = 39;
					continue;
				case 17:
					_ = 13;
					continue;
				case 5:
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 51:
					_ = 75;
					continue;
				case 21:
					_ = 25;
					continue;
				case 3:
					_ = 20;
					continue;
				case 11:
					_ = 4;
					continue;
				case 75:
					if (7 == 0)
					{
						_ = 35;
					}
					continue;
				case 90:
					_ = 54;
					continue;
				case 31:
					_ = 83;
					continue;
				case 52:
					_ = 17;
					continue;
				case 19:
					obj = this;
					obj2 = 30;
					continue;
				case 18:
					if (14 == 0)
					{
						_ = 40;
					}
					continue;
				case 61:
					_ = 32767;
					_ = 34;
					continue;
				case 33:
					_ = 9;
					continue;
				case 8:
					_ = 88;
					continue;
				case 77:
					_ = 22;
					continue;
				case 92:
					_ = 36;
					continue;
				case 28:
					_ = 87;
					continue;
				case 69:
					_ = 32767;
					if (5 == 0)
					{
						_ = 3;
					}
					continue;
				case 24:
					if (62 == 0)
					{
						_ = 8;
					}
					continue;
				case 72:
					_ = 29;
					continue;
				case 15:
					_ = 33;
					continue;
				case 89:
					_ = 81;
					continue;
				case 23:
					if (this == null)
					{
						if (9 == 0)
						{
							obj2 = 45;
						}
						continue;
					}
					goto case 70;
				case 48:
					if (49 == 0)
					{
						_ = 27;
					}
					continue;
				case 59:
					_ = 58;
					continue;
				case 63:
					_ = 86;
					continue;
				case 14:
					_ = 52;
					continue;
				case 9:
					_ = 6;
					continue;
				case 71:
					obj = 78;
					break;
				case 10:
					return;
				case 37:
				case 41:
					throw /*Error near IL_085f: Stack underflow*/;
				case 27:
					if (obj - 766 > 1)
					{
						goto case 37;
					}
					obj = 64;
					break;
				case 25:
					if (63 != 0)
					{
						_ = 71;
					}
					continue;
				case 13:
					if (31 == 0)
					{
						_ = 28;
					}
					continue;
				case 78:
					if (26 == 0)
					{
						_ = 22;
					}
					continue;
				case 36:
					if (40 == 0)
					{
						_ = 90;
					}
					continue;
				case 58:
					_ = 12;
					continue;
				case 93:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00鐀(byte P_0)
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
	internal unsafe void _FF00_FF00销(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777713, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00阀(byte P_0)
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
	internal unsafe void _FF00_FF00需(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777712, new IntPtr(2737368302748L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00頀(uint P_0)
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
	internal unsafe void _FF00_FF00餀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777715, new IntPtr(2737368322508L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00騀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00鬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777714, new IntPtr(2737368317308L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00鰀(byte P_0)
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
	internal unsafe void _FF00_FF00鴀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777677, new IntPtr(2737368317308L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<string> _FF00_FF00鸀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777676, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		return (List<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<string> _FF00_FF00鼀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (List<string>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00ꀀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777679, new IntPtr(2737368312108L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00ꄀ(object P_0)
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
	internal unsafe void _FF00_FF00ꈀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777678, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00ꌀ()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00ꐀ()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}
}
