using System;
using System.Buffers;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using System.Threading;
using DotNetty.Buffers;
using DotNetty.Transport.Channels;
using Mass.Application.Desktop;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Value;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Nbt;
using Mass.Game.Proxy.Network.Packet;
using Mass.Game.Proxy.Protocols;
using Mass.Game.Proxy.Protocols.Hyt;
using Mass.Game.Proxy.Protocols.Hyt.VexView;
using Mass.Game.Proxy.Protocols.OhMyGod;

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
		//IL_001b: Expected VT, but got I4
		//IL_0027: Expected Obj, but got Ref
		//IL_0033: Expected VT, but got Obj
		//IL_003f: Expected VT, but got Obj
		//IL_004b: Expected VT, but got Obj
		//IL_0056: Expected VT, but got Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)version;
		_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter = this;
		((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_0033: Stack underflow*/)._003Cpayload_003Ei__Field = (_003Cpayload_003Ej__TPar)this;
		((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_003f: Stack underflow*/)._003Cuser_id_003Ei__Field = (_003Cuser_id_003Ej__TPar)this;
		((_003C_003Ef__AnonymousType3<, >)/*Error near IL_004b: Stack underflow*/)._003Centry_003Ei__Field = (_003Centry_003Ej__TPar)this;
		((EqualityComparer<_00212>)/*Error near IL_0056: Stack underflow*/).Equals((_00212?)/*Error near IL_0056: Stack underflow*/, (_00212?)this);
		int num = 0;
		if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance == null)
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
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got Obj
		//IL_004e: Expected Obj, but got VT
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
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
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00蘀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_00e7: Expected I4, but got Obj
		//IL_030f: Expected Obj, but got I4
		//IL_0365: Expected Obj, but got I4
		//IL_0471: Expected I4, but got Obj
		//IL_0471: Expected Obj, but got Ref
		//IL_03ee: Expected Obj, but got I4
		//IL_03ee: Expected Obj, but got Ref
		//IL_0678: Expected Obj, but got Ref
		//IL_0337: Expected VT, but got I4
		//IL_033c: Expected VT, but got I4
		//IL_0345: Expected Obj, but got I4
		//IL_01bc: Expected Obj, but got I4
		//IL_01c1: Expected Obj, but got I4
		//IL_052d: Expected I4, but got Obj
		//IL_052d: Expected I4, but got Obj
		//IL_052d: Expected Obj, but got Ref
		//IL_0532: Expected Obj, but got I4
		//IL_0430: Expected Obj, but got I4
		//IL_0460: Expected Obj, but got I4
		//IL_0568: Expected I4, but got Obj
		//IL_0568: Expected Obj, but got Ref
		//IL_0507: Expected Obj, but got I4
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Invalid comparison between Unknown and I4
		//IL_041a: Expected Obj, but got I4
		//IL_041a: Expected Obj, but got Ref
		//IL_05ea: Expected Obj, but got Ref
		//IL_01a1: Expected Obj, but got Ref
		//IL_01d2: Expected VT, but got Obj
		//IL_0270: Expected Obj, but got I4
		//IL_0275: Expected VT, but got Obj
		//IL_0284: Expected Obj, but got I4
		//IL_0203: Expected Obj, but got I4
		//IL_0208: Expected Obj, but got VT
		//IL_0404: Expected Obj, but got I4
		//IL_0404: Expected Obj, but got Ref
		//IL_0234: Expected Obj, but got I4
		//IL_0239: Expected Obj, but got I4
		//IL_0242: Expected Obj, but got I4
		//IL_014c: Expected Obj, but got VT
		//IL_04eb: Expected Obj, but got F8
		//IL_0549: Expected Obj, but got Ref
		//IL_0557: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got VT
		//IL_018b: Expected Obj, but got VT
		//IL_012c: Expected Obj, but got I4
		//IL_05ba: Expected I4, but got Obj
		//IL_05bf: Expected Obj, but got Ref
		//IL_0667: Expected Obj, but got I4
		//IL_02d6: Expected Obj, but got I4
		//IL_0323->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0303->IL0026: Incompatible stack heights: 4 vs 2
		//IL_036a->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0228->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0485->IL0026: Incompatible stack heights: 1 vs 2
		//IL_03f8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03f8->IL0026: Incompatible stack types: I4 vs Ref
		//IL_0682->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0682->IL0026: Incompatible stack types: I4 vs Ref
		//IL_03a1->IL0026: Incompatible stack heights: 5 vs 2
		//IL_034a->IL0022: Incompatible stack heights: 2 vs 1
		//IL_01cb->IL0026: Incompatible stack heights: 5 vs 2
		//IL_053c->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0444->IL0026: Incompatible stack heights: 3 vs 2
		//IL_057c->IL0026: Incompatible stack heights: 1 vs 2
		//IL_03c1->IL0026: Incompatible stack heights: 3 vs 2
		//IL_05a7->IL0026: Incompatible stack heights: 3 vs 2
		//IL_051b->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0424->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0424->IL0026: Incompatible stack types: I4 vs Ref
		//IL_05f4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05f4->IL0026: Incompatible stack types: Obj vs Ref
		//IL_03e2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a6->IL0424: Incompatible stack heights: 0 vs 1
		//IL_04b0->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0644->IL0026: Incompatible stack heights: 3 vs 2
		//IL_01e1->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0289->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04d1->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0212->IL0026: Incompatible stack heights: 5 vs 2
		//IL_040e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_040e->IL0026: Incompatible stack types: I4 vs Ref
		//IL_0247->IL0022: Incompatible stack heights: 4 vs 1
		//IL_0151->IL0026: Incompatible stack heights: 4 vs 2
		//IL_032e->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0375->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0490->IL0026: Incompatible stack heights: 1 vs 2
		//IL_04f0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_055c->IL0022: Incompatible stack types: I4 vs Ref
		//IL_010c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0190->IL0026: Incompatible stack types: I4 vs Obj
		//IL_044f->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0587->IL0026: Incompatible stack heights: 1 vs 2
		//IL_03cc->IL0026: Incompatible stack heights: 3 vs 2
		//IL_038b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05b2->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0526->IL0026: Incompatible stack heights: 3 vs 2
		//IL_05d3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05d3->IL0026: Incompatible stack types: I4 vs Ref
		//IL_02ed->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01b0->IL0026: Incompatible stack heights: 1 vs 2
		//IL_04bb->IL0026: Incompatible stack heights: 5 vs 2
		//IL_064f->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0294->IL0026: Incompatible stack types: I4 vs Obj
		//IL_015c->IL0026: Incompatible stack heights: 4 vs 2
		//IL_04fb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0117->IL0026: Incompatible stack types: I4 vs Obj
		//IL_019b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0264->IL0026: Incompatible stack heights: 6 vs 2
		//IL_05de->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05de->IL0026: Incompatible stack types: I4 vs Ref
		ref readonly _003Caction_003Ej__TPar reference = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
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
				{
					if ((nint)obj != 763)
					{
						obj2 = 28;
						if ((int)((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
						{
							obj2 = 17;
						}
						continue;
					}
					((EntitySocks5)Unsafe.AsPointer(ref reference)).Deconstruct(out *(string*)this, out *(int*)P_0, out *(EntitySocks5Account?*)32767);
					bool flag4 = EntitySocks5.ReflectConcreteEvent();
					obj = 45;
					reference = ref *(flag4 ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
					break;
				}
				case 20:
					if ((nint)obj <= 340)
					{
						obj = 30;
						break;
					}
					if ((nint)obj == 757)
					{
						_ = ((EntitySocks5)this).Account__BackingField;
						_ = ((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DisableDecryptor()).entry;
						_ = 40;
						continue;
					}
					obj = 11;
					break;
				case 46:
					((_003C_003Ef__AnonymousType0<>)(object)P_0.ToString()).ToString();
					_ = 41;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
					{
						_ = 35;
					}
					continue;
				case 22:
					return;
				case 12:
					if ((nint)obj != 47)
					{
						obj2 = 25;
						if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType3<, >._003Centry_003Ei__Field)._003Csid_003Ei__Field == 0)
						{
							obj2 = 10;
						}
						continue;
					}
					goto IL_015d;
				case 34:
					if (((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref reference)).Equals(this))
					{
						_ = 16;
						continue;
					}
					goto case 18;
				case 16:
					((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)32767).GetHashCode()).ToString();
					_ = 33;
					continue;
				case 39:
					((EqualityComparer<_00212>)(object)this).GetHashCode((_00212)P_0);
					_003C_003Ef__AnonymousType1<, , >.ReflectModularWriter();
					_ = 43;
					continue;
				case 29:
					/*Error near IL_01e3: Member reference must be method, but was: Field*/;
				case 42:
					_ = ((_003C_003Ef__AnonymousType2<, , , >)((_003C_003Ef__AnonymousType2<, , , >)32767).context).user_id;
					_ = 29;
					continue;
				case 5:
					((_003C_003Ef__AnonymousType2<, , , >)P_0).Equals((object)EqualityComparer<_00213>.Default);
					_ = 44;
					continue;
				case 45:
					((_003C_003Ef__AnonymousType2<, , , >)((_003C_003Ef__AnonymousType2<, , , >)32767).GetHashCode()).ToString();
					obj = 13;
					break;
				case 15:
					return;
				case 40:
					((_003C_003Ef__AnonymousType3<, >)this)._002Ector((_003Centry_003Ej__TPar)P_0, ((_003C_003Ef__AnonymousType3<, >)32767).sid);
					obj2 = 31;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.GameVersion__BackingField).ModHashList__BackingField == null)
					{
						obj2 = 23;
					}
					continue;
				case 36:
					/*Error near IL_0296: Member reference must be method, but was: Field*/;
				default:
					/*Error near IL_02ac: Member reference must be method, but was: Field*/;
				case 38:
					return;
				case 30:
					if ((nint)obj != 5)
					{
						obj2 = 12;
						continue;
					}
					goto IL_015d;
				case 2:
					((RegexRunner)P_0).CheckTimeout();
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectSymbolicAuditor();
					_ = 26;
					continue;
				case 1:
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory)((ReadOnlySpan<char>*)P_0)->Length).CreateInstance();
					_ = 0;
					if (((GameProxy)GameProxy.Logger__BackingField)._pinger == null)
					{
						_ = 0;
					}
					continue;
				case 14:
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)this).TryMatchAtCurrentPosition((ReadOnlySpan<char>)((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)P_0).TryFindNextPossibleStartingPosition((ReadOnlySpan<char>)16));
					obj = 15;
					break;
				case 4:
					_ = (ReadOnlySpan<char>)(string?)P_0;
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.VerifyVerifier();
					_ = 28;
					if (((GameProxy)GameProxy.GameType__BackingField).GameId__BackingField == null)
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
					goto IL_015d;
				case 10:
					AppContext.GetData((string)P_0);
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.PatchWatcher();
					_ = 14;
					continue;
				case 24:
					((StringBuilder)P_0)._002Ector();
					_ = ((EntitySocks5Account)this).EqualityContract;
					_ = 1;
					if (((GameProxy)GameProxy.TransferServerAddress__BackingField).TransferServerPort__BackingField != 0)
					{
						_ = 10;
					}
					continue;
				case 33:
					((EntitySocks5Account)this).Password = ((EntitySocks5Account)P_0).Password;
					obj2 = 18;
					continue;
				case 8:
				{
					bool flag3 = ((EntitySocks5Account)Unsafe.AsPointer(ref reference)).PrintMembers((StringBuilder)((EqualityComparer<Type>)(object)this).GetHashCode((Type)P_0));
					obj2 = 36;
					reference = ref *(flag3 ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
					continue;
				}
				case 44:
				{
					bool flag2 = (EntitySocks5Account?)Unsafe.AsPointer(ref reference) == (EntitySocks5Account?)((EqualityComparer<string>)(object)this).GetHashCode((string)P_0);
					obj2 = 32;
					reference = ref *(flag2 ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
					continue;
				}
				case 31:
				{
					bool flag = ((EntitySocks5Account)Unsafe.AsPointer(ref reference)).Equals((Type?)(object)this == (Type?)P_0);
					obj2 = 2;
					reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
					continue;
				}
				case 18:
					((EntitySocks5Account)((EntitySocks5Account)this).Equals((EntitySocks5Account?)P_0))._003CClone_003E_0024();
					_ = 14;
					if (GameProxy._003C_003EO._003C0_003E__PluginChanged != null)
					{
						_ = 39;
					}
					continue;
				case 21:
					obj = GameProxy._003C_003EO._003C1_003E__OnConnectServer;
					obj = 20;
					break;
				case 6:
					((EntitySocks5)Unsafe.AsPointer(ref reference))._002Ector((string)(object)this, (int)P_0, (EntitySocks5Account?)(object)EqualityComparer<EntitySocks5Account>.Default);
					_ = 5;
					if (((GameProxy._003CListenAsync_003Ed__69)GameProxy._003CListenAsync_003Ed__69._003C_003Et__builder)._003C_003E4__this == null)
					{
						_ = 0;
					}
					continue;
				case 35:
					_ = ((EntitySocks5)(object)EqualityComparer<DesktopSession>.Default).Port;
					_ = 34;
					if (((CpsDetector)GameProxy._003CListenAsync_003Ed__69.CheckCentralResponder)._lock != null)
					{
						_ = 19;
					}
					continue;
				case 41:
					EntitySocks5.Parse((string?)(object)EqualityComparer<EnumGameVersion>.Default);
					_ = 35;
					continue;
				case 7:
					if (((EntitySocks5)this).ToString() != null)
					{
						obj2 = 8;
						if (((CpsDetector)CpsDetector._lastRightCps).OnCpsChange == null)
						{
							obj2 = 37;
						}
						continue;
					}
					goto case 9;
				case 27:
					((EntitySocks5)((EqualityComparer<SectionValue>)(object)this).GetHashCode((SectionValue)P_0)).GetHashCode();
					_ = 1;
					if (((OhMyGodHwid)OhMyGodEncryption.DecorateEfficientEmitter).Hwid__BackingField != null)
					{
						_ = 1;
					}
					continue;
				case 17:
					((EntitySocks5)/*Error near IL_0532: Stack underflow*/)._002Ector((EntitySocks5)((EqualityComparer<EnumGameType>)Unsafe.AsPointer(ref reference)).Equals((EnumGameType)this, (EnumGameType)P_0));
					_ = 4;
					continue;
				case 3:
					return;
				case 23:
					((EntityLaunchGameProxy)/*Error near IL_0568: Stack underflow*/)._002Ector((DesktopSession)/*Error near IL_0568: Stack underflow*/, (string)/*Error near IL_0568: Stack underflow*/, (EnumGameType)/*Error near IL_0568: Stack underflow*/, (EnumGameVersion)/*Error near IL_0568: Stack underflow*/, (string)Unsafe.AsPointer(ref reference), (string)(object)this, (string)P_0, (int)EntitySocks5.DecorateConnectedWrapper());
					_ = 9;
					if (OhMyGodProtocol.CheckGeneralAggregator == null)
					{
						_ = 5;
					}
					continue;
				case 26:
					_ = ((EntityLaunchGameProxy)(object)Delegate.Combine((Delegate?)(object)this, (Delegate?)P_0)).GameId;
					_ = 27;
					if (((HytMainMenu.Menu)HytMainMenu.Menu.Name).Description != null)
					{
						_ = 23;
					}
					continue;
				case 19:
					return;
				case 32:
				{
					((AsyncTaskMethodBuilder*)this)->Start<TStateMachine>(ref *(TStateMachine*)P_0);
					string name = ((EntityLaunchGameProxy)Unsafe.AsPointer(ref reference)).Name;
					obj2 = 7;
					reference = ref *(_003Caction_003Ej__TPar*)name;
					continue;
				}
				case 13:
					/*Error near IL_05f6: Member reference must be method, but was: Field*/;
				case 37:
					((EntityLaunchGameProxy)P_0).ServerPort = 32767;
					_ = ((EntityLaunchGameProxy)this).Socks5;
					_ = 2;
					if (VexViewCodec.OpenEmitter != null)
					{
						_ = 23;
					}
					continue;
				case 43:
					return;
				case 28:
					if (obj - 766 <= 1)
					{
						((EntityLaunchGameProxy)this).GameType = (EnumGameType)P_0;
						EnumGameVersion gameVersion = ((EntityLaunchGameProxy)Unsafe.AsPointer(ref reference)).GameVersion;
						obj2 = 42;
						reference = ref *(_003Caction_003Ej__TPar*)(uint)gameVersion;
						if (((HytMainMenu._003C_003Ec__DisplayClass2_1)(object)HytMainMenu._003C_003Ec__DisplayClass2_0.sendGermPacket).menu != null)
						{
							obj2 = 12;
							reference = ref *(_003Caction_003Ej__TPar*)(uint)gameVersion;
						}
						continue;
					}
					obj = 22;
					break;
				case 9:
					{
						((EntityLaunchGameProxy)this).Value = (SectionValue?)P_0;
						bool isGame = ((EntityLaunchGameProxy)Unsafe.AsPointer(ref reference)).IsGame;
						obj2 = 19;
						reference = ref *(isGame ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
						continue;
					}
					IL_015d:
					/*Error near IL_015f: Member reference must be method, but was: Field*/;
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
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
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
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got I4
		//IL_004e: Expected Obj, but got VT
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
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
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_004e: Expected Obj, but got VT
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
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
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got I4
		//IL_004e: Expected Obj, but got VT
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					obj2 = 0;
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
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
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
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (byte)(int)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
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
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got I4
		//IL_004f: Expected Obj, but got VT
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00錀(byte P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got I4
		//IL_004f: Expected Obj, but got VT
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					obj2 = 0;
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
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (byte)(int)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
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
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got I4
		//IL_004e: Expected Obj, but got VT
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
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
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (byte)(int)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
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
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got I8
		//IL_004f: Expected Obj, but got VT
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00鰀()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (byte)(int)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
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
		//IL_001b: Expected I8, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (long)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00鼀()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (uint)(int)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
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
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (byte)(int)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00ꈀ(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_00ef: Expected I4, but got Obj
		//IL_06f4: Expected Obj, but got I4
		//IL_0185: Expected VT, but got I4
		//IL_01c8: Expected Obj, but got VT
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Invalid comparison between Unknown and I4
		//IL_031d: Expected VT, but got Ref
		//IL_0387: Expected Obj, but got Ref
		//IL_0375: Expected VT, but got I4
		//IL_0667: Expected Obj, but got Ref
		//IL_0349: Expected VT, but got Obj
		//IL_0359: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got VT
		//IL_06b1: Expected Obj, but got I4
		//IL_05fa: Expected I4, but got Obj
		//IL_0604: Expected Obj, but got I4
		//IL_060e: Expected Obj, but got I4
		//IL_0624: Expected Obj, but got I4
		//IL_0679: Expected I4, but got Obj
		//IL_0680: Expected Obj, but got I4
		//IL_058e: Expected VT, but got Obj
		//IL_058e: Expected VT, but got Obj
		//IL_03d6: Expected Obj, but got I4
		//IL_03e0: Expected Obj, but got I4
		//IL_0534: Expected Obj, but got Ref
		//IL_00fb: Expected VT, but got Obj
		//IL_0100: Expected VT, but got Ref
		//IL_0159: Expected Obj, but got VT
		//IL_0169: Expected Obj, but got VT
		//IL_05e3: Expected I4, but got Obj
		//IL_041c: Expected I4, but got Obj
		//IL_041c: Expected Obj, but got Ref
		//IL_042c: Expected Obj, but got I
		//IL_0477: Expected I4, but got Obj
		//IL_0477: Expected Obj, but got Ref
		//IL_0566: Expected Obj, but got I4
		//IL_05a6: Expected Obj, but got Ref
		//IL_026b: Expected Obj, but got I4
		//IL_0491: Expected native int or pointer, but got Obj
		//IL_049b: Expected Obj, but got I4
		//IL_06ff->IL0026: Incompatible stack heights: 1 vs 2
		//IL_04d2->IL0026: Incompatible stack heights: 1 vs 2
		//IL_06e8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_046f->IL0026: Incompatible stack heights: 5 vs 2
		//IL_019a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01dd->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0332->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0397->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0380->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0672->IL0026: Incompatible stack heights: 1 vs 2
		//IL_035e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0127->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06c6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0458->IL0026: Incompatible stack heights: 1 vs 2
		//IL_062f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0695->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0599->IL0026: Incompatible stack heights: 1 vs 2
		//IL_03e5->IL0022: Incompatible stack heights: 2 vs 1
		//IL_0549->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0582->IL0026: Incompatible stack heights: 3 vs 2
		//IL_010b->IL0026: Incompatible stack heights: 1 vs 2
		//IL_016e->IL0026: Incompatible stack heights: 3 vs 2
		//IL_03c5->IL0026: Incompatible stack heights: 1 vs 2
		//IL_05f3->IL0026: Incompatible stack heights: 1 vs 2
		//IL_03ae->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0431->IL0026: Incompatible stack heights: 1 vs 2
		//IL_04f3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02ba->IL03c5: Incompatible stack heights: 0 vs 1
		//IL_01a5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0487->IL0026: Incompatible stack heights: 1 vs 2
		//IL_01e8->IL0026: Incompatible stack heights: 3 vs 2
		//IL_05bb->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0270->IL0026: Incompatible stack types: I4 vs Obj
		//IL_033d->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0311->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0369->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0405->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0132->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06d1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02af->IL0026: Incompatible stack heights: 6 vs 2
		//IL_05dc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06a0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_021f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0554->IL0026: Incompatible stack heights: 1 vs 2
		//IL_051d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0179->IL0026: Incompatible stack heights: 3 vs 2
		//IL_043c->IL0026: Incompatible stack heights: 1 vs 2
		//IL_04fe->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02c4->IL0026: Incompatible stack heights: 1 vs 2
		//IL_05c6->IL0026: Incompatible stack heights: 1 vs 2
		//IL_027b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04b0->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0650->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0410->IL0026: Incompatible stack types: I4 vs Obj
		//IL_022a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0528->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04bb->IL0026: Incompatible stack heights: 4 vs 2
		//IL_065b->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
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
					((_003C_003Ef__AnonymousType0<>)P_0)._002Ector((_003Caction_003Ej__TPar)this);
					((EqualityComparer<_00210>)/*Error near IL_0100: Stack underflow*/).GetHashCode((_00210)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
					_ = 13;
					continue;
				case 19:
					obj = _003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter;
					obj2 = 10;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field != 0)
					{
						obj2 = 18;
					}
					continue;
				case 42:
					_003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
					/*Error near IL_0139: Member reference must be method, but was: Field*/;
				case 41:
					_ = ((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)this).uuid).user_id;
					_ = 10;
					if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument == null)
					{
						_ = 3;
					}
					continue;
				case 4:
					((EqualityComparer<_00211>)P_0).GetHashCode((_00211)((_003C_003Ef__AnonymousType1<, , >)this).GetHashCode());
					obj2 = 39;
					if ((int)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout == 0)
					{
						obj2 = 18;
					}
					continue;
				case 28:
					_ = ((_003C_003Ef__AnonymousType2<, , , >)this).url;
					/*Error near IL_01ac: Member reference must be method, but was: Field*/;
				case 6:
					_ = ((_003C_003Ef__AnonymousType2<, , , >)((_003C_003Ef__AnonymousType2<, , , >)this).context).user_id;
					_ = 3;
					if (EntitySocks5Account.AttachElement != null)
					{
						_ = 1;
					}
					continue;
				case 13:
					((_003C_003Ef__AnonymousType2<, , , >)this).GetHashCode();
					/*Error near IL_01ef: Member reference must be method, but was: Field*/;
				case 31:
					if ((nint)obj != 340)
					{
						obj2 = 40;
						if (EntitySocks5.DecorateDynamicModule != null)
						{
							obj2 = 19;
						}
						continue;
					}
					goto IL_0470;
				case 7:
					if (obj - 766 > 1)
					{
						obj2 = 29;
						if (((EntityLaunchGameProxy)EntityLaunchGameProxy.GameType__BackingField).GameVersion__BackingField == EnumGameVersion.None)
						{
							obj2 = 29;
						}
						continue;
					}
					((EntityLaunchGameProxy)P_0).Session = (DesktopSession)(object)this;
					_ = ((EntityLaunchGameProxy)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).GameId;
					_ = 13;
					if (((HytMainMenu.Menu)HytMainMenu.Menu.Name).Description == null)
					{
						_ = 21;
					}
					continue;
				case 22:
					((_003C_003Ef__AnonymousType3<, >)this).GetHashCode();
					/*Error near IL_0282: Member reference must be method, but was: Field*/;
				case 8:
					return;
				case 48:
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0)this)._002Ector();
					if (Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field) == null)
					{
						_ = 26;
						continue;
					}
					goto case 33;
				case 34:
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0._002Ecctor();
					/*Error near IL_02da: Member reference must be method, but was: Field*/;
				case 14:
					if ((nint)obj != 5)
					{
						obj2 = 5;
						continue;
					}
					goto IL_0470;
				case 9:
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory)this)._002Ector();
					MemoryExtensions.IndexOfAnyExcept<T>((ReadOnlySpan<T>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (SearchValues<T>)P_0);
					_ = 11;
					if (GameProxy.OnlineClients != null)
					{
						_ = 5;
					}
					continue;
				case 17:
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)this)._002Ector();
					SearchValues.Create((ReadOnlySpan<char>)P_0);
					obj2 = 8;
					if (((GameProxy)GameProxy.GameType__BackingField).GameId__BackingField != null)
					{
						obj2 = 4;
					}
					continue;
				case 12:
					Type.GetTypeFromHandle((RuntimeTypeHandle)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.InstantiateVisitor());
					_ = 46;
					continue;
				case 11:
					((EntitySocks5Account)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((string)P_0, (string)(object)this);
					((StringBuilder)/*Error near IL_038c: Stack underflow*/).Append((string?)/*Error near IL_038c: Stack underflow*/);
					_ = 37;
					continue;
				case 45:
					((StringBuilder)P_0).Append((object?)((EntitySocks5Account)this).Username);
					obj2 = 35;
					continue;
				case 43:
					((EntitySocks5Account)P_0).Password = ((EntitySocks5Account)this).Password;
					_ = 15;
					continue;
				case 33:
					((EntitySocks5Account)(object)((EntitySocks5Account)this).ToString()).PrintMembers((StringBuilder)32767);
					obj = 43;
					break;
				case 18:
					if ((nint)obj > 340)
					{
						obj2 = 16;
						if (((GameProxy)GameProxy.WorkerGroup__BackingField).AcceptorGroup__BackingField == null)
						{
							obj2 = 3;
						}
						continue;
					}
					goto case 14;
				case 46:
					((string)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Split((char)(int)P_0, (StringSplitOptions)((EntitySocks5Account)this).GetHashCode());
					_ = 47;
					if (((GameProxy)GameProxy.ProxyPort__BackingField)._connection != null)
					{
						_ = 5;
					}
					continue;
				case 21:
					((EntitySocks5Account)P_0)._002Ector((EntitySocks5Account)(object)this);
					((EntitySocks5Account)/*Error near IL_044d: Stack underflow*/).Deconstruct(out Unsafe.As<_003Caction_003Ej__TPar, string>(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), out *(string*)32767);
					_ = 28;
					continue;
				case 3:
					EntitySocks5Account.ReflectScopePolicy();
					EntitySocks5Account.RunWriter();
					_ = 41;
					continue;
				case 29:
					return;
				case 10:
					return;
				case 36:
					return;
				case 1:
					((EntitySocks5)P_0).Account = (EntitySocks5Account?)(object)this;
					((EqualityComparer<EnumGameVersion>)/*Error near IL_04c7: Stack underflow*/).GetHashCode((EnumGameVersion)(uint)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
					_ = 22;
					continue;
				case 47:
					((EqualityComparer<EntitySocks5>)P_0).GetHashCode((EntitySocks5)(object)((EntitySocks5)this).ToString());
					obj2 = 9;
					if (CpsDetector.DecompressList == null)
					{
						obj2 = 7;
					}
					continue;
				case 39:
					if (((EntitySocks5)this).GetHashCode() != 0)
					{
						obj2 = 25;
						if (((OhMyGodHwid)OhMyGodEncryption.DecorateEfficientEmitter).Hwid__BackingField != null)
						{
							obj2 = 18;
						}
						continue;
					}
					goto case 3;
				case 35:
					((EqualityComparer<DesktopSession>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals((DesktopSession?)P_0, (DesktopSession?)(object)((EntitySocks5)this)._003CClone_003E_0024());
					_ = 0;
					if (OhMyGodHwid._003C_003EO._003C1_003E__GenerateRandomCpu != null)
					{
						_ = 0;
					}
					continue;
				case 5:
					if ((nint)obj != 47)
					{
						obj = 31;
						break;
					}
					goto IL_0470;
				case 37:
					((MultithreadEventLoopGroup)EntitySocks5.DecorateConnectedWrapper())._002Ector();
					_ = 48;
					continue;
				case 32:
					Interlocked.CompareExchange<T>(ref Unsafe.As<_003Caction_003Ej__TPar, T>(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (T)P_0, (T)((EntityLaunchGameProxy)this).EqualityContract);
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
					_003C_003Ef__AnonymousType3<, >.LoadCache();
					_ = 32767;
					_003C_003Ef__AnonymousType3<, >.DecorateIntegratedProgram();
					_ = 23;
					continue;
				case 44:
					((EntityLaunchGameProxy)P_0).GameType = (EnumGameType)this;
					Unsafe.As<_003Caction_003Ej__TPar, DefaultInterpolatedStringHandler>(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field).ToStringAndClear();
					_ = 45;
					continue;
				case 23:
					((EntityLaunchGameProxy)P_0).GameVersion = (EnumGameVersion)(int)this;
					_ = ((EntityLaunchGameProxy)32767).ModHashList;
					obj = 32;
					break;
				case 25:
					((EntityLaunchGameProxy)P_0).ModHashList = (string)(object)this;
					_ = ((EntityLaunchGameProxy)32767).Name;
					obj2 = 6;
					continue;
				case 40:
					return;
				case 16:
					if ((nint)obj == 757)
					{
						_ = ((EntitySocks5)this).Address;
						_ = ((EntitySocks5)((GameProxy._003CListenAsync_003Ed__69*)(nint)this)->port).Port;
						_ = 20;
						if (((CpsDetector)GameProxy._003CListenAsync_003Ed__69.CheckCentralResponder)._lock == null)
						{
							_ = 11;
						}
					}
					else
					{
						obj2 = 27;
						if ((int)((HytMainMenu._003C_003Ec__DisplayClass2_2)HytMainMenu._003C_003Ec__DisplayClass2_1.RunMapper).kvp != 0)
						{
							obj2 = 25;
						}
					}
					continue;
				case 15:
				case 26:
					((EntityLaunchGameProxy)P_0).ServerAddress = (string)(object)this;
					_ = ((EntityLaunchGameProxy)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).ServerPort;
					_ = 24;
					continue;
				case 30:
					((EntityLaunchGameProxy)P_0).ServerPort = (int)this;
					_ = ((EntityLaunchGameProxy)16).Socks5;
					obj2 = 7;
					if (VexViewCodec.OpenEmitter == null)
					{
						obj2 = 36;
					}
					continue;
				case 20:
					((EntityLaunchGameProxy)P_0).Value = (SectionValue?)(object)this;
					_ = ((EntityLaunchGameProxy)32767).IsGame;
					obj2 = 0;
					if (((VexViewPacket)VexViewPacket.PacketType__BackingField).PacketSubType__BackingField != null)
					{
						obj2 = 1;
					}
					continue;
				case 2:
					_ = ((IChannel)((EntityLaunchGameProxy)P_0).PrintMembers((StringBuilder)(object)this)).Pipeline;
					obj2 = 34;
					continue;
				default:
					{
						((IAsyncStateMachine)((EntityLaunchGameProxy?)P_0 == (EntityLaunchGameProxy?)(object)this)).MoveNext();
						_ = 4;
						continue;
					}
					IL_0470:
					((EntitySocks5)/*Error near IL_0477: Stack underflow*/)._002Ector((string)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (int)P_0, (EntitySocks5Account?)(object)this);
					((EqualityComparer<int>)/*Error near IL_047c: Stack underflow*/).Equals((int)/*Error near IL_047c: Stack underflow*/, (int)/*Error near IL_047c: Stack underflow*/);
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
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got I4
		//IL_004e: Expected Obj, but got VT
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					obj2 = 0;
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
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got I4
		//IL_004e: Expected Obj, but got VT
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
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
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (byte)(int)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
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
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (byte)(int)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
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
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (byte)(int)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00가(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got Obj
		//IL_004f: Expected Obj, but got VT
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					obj2 = 0;
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
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (Position)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
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
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
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
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got Obj
		//IL_004f: Expected Obj, but got VT
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
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
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (uint)(int)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00뜀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
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
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got Obj
		//IL_004f: Expected Obj, but got VT
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
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
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got I4
		//IL_004f: Expected Obj, but got VT
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
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
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got I4
		//IL_004e: Expected Obj, but got VT
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
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
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got Obj
		//IL_004f: Expected Obj, but got VT
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
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
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
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
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
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
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got I4
		//IL_004e: Expected Obj, but got VT
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}
}
