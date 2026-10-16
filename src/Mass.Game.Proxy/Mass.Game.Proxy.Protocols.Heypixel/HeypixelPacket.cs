using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Common.Helpers;
using Mass.Game.Proxy.Protocols.Heypixel.Clientbound;
using Mass.Game.Proxy.Protocols.Heypixel.Serverbound;
using MsgPack;

namespace Mass.Game.Proxy.Protocols.Heypixel;

public abstract class HeypixelPacket
{
	private static readonly BiDictionary<int, Type> Packets;

	internal static HeypixelPacket CheckBasicWorker;

	protected HeypixelProtocol Protocol
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (HeypixelProtocol)_2100();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			က(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected HeypixelPacket(HeypixelProtocol protocol)
	{
		//IL_003a: Expected I4, but got Obj
		//IL_0028->IL0031: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		HeypixelPacket heypixelPacket = this;
		if (0 == 0)
		{
			heypixelPacket = (HeypixelPacket)0;
		}
		switch ((int)heypixelPacket)
		{
		case 0:
			break;
		}
	}

	static HeypixelPacket()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0091->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0143->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00b6->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0109->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0128->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0062->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00da->IL0012: Incompatible stack types: I4 vs Obj
		//IL_009c->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0114->IL0012: Incompatible stack types: I4 vs Obj
		//IL_006d->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00e5->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 0:
				return;
			case 6:
				RegisterPacket(114u, typeof(ClientboundSyncKeyPacket));
				obj2 = 0;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_0662d18a5af34da596af03e5c9747188 != 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				RegisterPacket(3u, typeof(ServerboundCpsPacket));
				obj2 = 3;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_2178df51e0904ba79c4c8361c94f54e5 == 0)
				{
					obj2 = 2;
				}
				break;
			case 3:
				RegisterPacket(5u, typeof(ServerboundUseItemPacket));
				obj2 = 2;
				break;
			case 7:
				RegisterPacket(2u, typeof(ServerboundTimestampPacket));
				obj2 = 1;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_228869e18032416d9510771ae703f1fc == 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
				RegisterPacket(1u, typeof(ServerboundReflectCheckPacket));
				obj2 = 0;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_2a1899bbfd66432b9701165f32836e5c == 0)
				{
					obj2 = 7;
				}
				break;
			case 5:
				Packets = new BiDictionary<int, Type>();
				obj2 = 4;
				break;
			case 2:
				RegisterPacket(101u, typeof(ClientboundReflectCheckPacket));
				obj2 = 6;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void RegisterPacket(uint id, object type)
	{
		ༀ(id, type);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint GetId(object type)
	{
		return ᰀ(type);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Handle(HeypixelProtocol protocol, IByteBuffer buffer)
	{
		return ᤀ(protocol, buffer) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object? Create(object protocol, uint id)
	{
		return _1800(protocol, id);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Read(Unpacker unpacker)
	{
		_0B00(unpacker);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Write(Packer packer)
	{
		_0700(packer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Handle()
	{
		ᜀ();
	}

	public virtual byte[] Encode(byte[] input)
	{
		return input;
	}

	public virtual byte[] Decode(byte[] input)
	{
		return input;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetId()
	{
		return (int)Ḁ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Send()
	{
		_1400();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateReadableProvider()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HeypixelPacket SetParameter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _0600(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778372, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _0700(object P_0)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_000a: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void ࠀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778375, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _0900()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _0B00(object P_0)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_000a: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _0C00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778374, new IntPtr(2737367946284L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _0D00()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void _0E00(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778369, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ༀ(uint P_0, object P_1)
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
	protected void က(object P_0)
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
	protected unsafe void ᄀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778368, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void ጀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778371, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _1400()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_003e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0066->IL006a: Incompatible stack heights: 1 vs 0
		//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
		//IL_010f->IL006a: Incompatible stack heights: 5 vs 0
		//IL_009e->IL006a: Incompatible stack heights: 1 vs 0
		//IL_00f3->IL006a: Incompatible stack heights: 2 vs 0
		//IL_00b9->IL006a: Incompatible stack heights: 2 vs 0
		//IL_00e0->IL006a: Incompatible stack heights: 1 vs 0
		//IL_00a9->IL006a: Incompatible stack heights: 1 vs 0
		//IL_00c4->IL006a: Incompatible stack heights: 2 vs 0
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
				obj = (object)/*Error near IL_0032: Stack underflow*/;
				if (false)
				{
					obj2 = 0;
				}
				continue;
			case 2:
				return;
			}
			obj = obj;
			if (4 == 0)
			{
				_ = 1;
			}
			while (true)
			{
				switch ((int)/*Error near IL_0087: Stack underflow*/)
				{
				case 3:
					obj = obj;
					if (true)
					{
						_ = 1;
					}
					break;
				case 5:
					if (false)
					{
						_ = 0;
					}
					break;
				default:
					obj = obj;
					if (3 == 0)
					{
						_ = 2;
					}
					break;
				case 4:
					obj = obj;
					_ = ref obj;
					_ = 5;
					break;
				case 1:
					_ = ((Array)obj).Length + 1;
					_ = 2;
					break;
				case 2:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void ᔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778370, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void ᜀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_000a: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _1800(object P_0, uint P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0066: Expected Obj, but got I4
		//IL_00dc->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00fb->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00e7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0106->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				return null;
			default:
			{
				int num = (int)P_1;
				((object[])1)[0] = P_0;
				obj = 1;
				if (false)
				{
					num = 0;
				}
				return num switch
				{
					_ => obj, 
				};
			}
			case 3:
				return null;
			case 1:
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				if (P_1 != 0)
				{
					if (1 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte ᤀ(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		//IL_0186: Expected Obj, but got I4
		//IL_0145: Expected I4, but got Obj
		//IL_00ae: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		//IL_0070: Expected I4, but got Obj
		//IL_018b->IL0015: Incompatible stack heights: 1 vs 0
		//IL_0137->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01b8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_019c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0057->IL005b: Incompatible stack types: I4 vs Obj
		//IL_0142->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0156->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01a7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0177->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a0->IL005b: Incompatible stack heights: 2 vs 1
		//IL_008f->IL005b: Incompatible stack types: I4 vs Obj
		//IL_00ab->IL005b: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 7:
				{
					obj = obj;
					object obj3 = 2;
					while (true)
					{
						switch ((int)obj3)
						{
						case 1:
							obj3 = obj;
							if (0 == 0)
							{
								obj3 = 0;
							}
							continue;
						case 2:
							if (1 == 0)
							{
								_ = 0;
							}
							continue;
						default:
							obj = 1;
							obj = 3;
							obj3 = obj;
							continue;
						case 3:
							break;
						}
						break;
					}
					goto case 8;
				}
				case 1:
					obj = P_1;
					if (false)
					{
						obj2 = 0;
					}
					continue;
				case 8:
					return (byte)(int)obj;
				case 3:
					if (obj != null)
					{
						obj2 = 6;
						continue;
					}
					goto case 5;
				case 5:
					return 0;
				case 6:
					obj2 = P_1;
					obj = P_0;
					if (2 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 4:
					obj = obj;
					if (true)
					{
						obj2 = 7;
					}
					continue;
				case 2:
					obj = obj;
					_ = 4;
					continue;
				}
				break;
			}
			obj = obj;
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte ᨀ(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778397, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _1B00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778396, new IntPtr(2737367946284L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint ᰀ(object P_0)
	{
		//IL_000b: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint ᴀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778399, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint Ḁ()
	{
		//IL_000b: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint ἀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778398, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe object _2000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778393, new IntPtr(2737367948364L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected object _2100()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}
}
