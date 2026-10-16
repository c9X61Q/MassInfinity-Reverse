using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Protocols.Germ.Clientbound;
using Mass.Game.Proxy.Protocols.Germ.Serverbound;

namespace Mass.Game.Proxy.Protocols.Germ;

public static class GermPacketCodec
{
	private static readonly Dictionary<int, Type> ClientboundPackets;

	private static readonly Dictionary<Type, int> ServerboundPackets;

	internal static GermPacketCodec ReflectFlexibleFinder;

	static GermPacketCodec()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_006b: Expected I4, but got Obj
		//IL_008b->IL0012: Incompatible stack types: I4 vs Obj
		//IL_02c4->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00a6->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0312->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0118->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0244->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00f0->IL0012: Incompatible stack types: I4 vs Obj
		//IL_015b->IL0012: Incompatible stack types: I4 vs Obj
		//IL_01ef->IL0012: Incompatible stack types: I4 vs Obj
		//IL_019b->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00c1->IL0012: Incompatible stack types: I4 vs Obj
		//IL_021e->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0180->IL0012: Incompatible stack types: I4 vs Obj
		//IL_02a9->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00dc->IL0012: Incompatible stack types: I4 vs Obj
		//IL_02e8->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0269->IL0012: Incompatible stack types: I4 vs Obj
		//IL_01c0->IL0012: Incompatible stack types: I4 vs Obj
		//IL_028f->IL0012: Incompatible stack types: I4 vs Obj
		//IL_013d->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0123->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0166->IL0012: Incompatible stack types: I4 vs Obj
		//IL_01fa->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0229->IL0012: Incompatible stack types: I4 vs Obj
		//IL_02f3->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0274->IL0012: Incompatible stack types: I4 vs Obj
		//IL_01cb->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 7;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				RegisterServerboundPacket(12u, typeof(GermGuiClickDown));
				obj2 = 2;
				break;
			case 2:
				RegisterServerboundPacket(11u, typeof(GermGuiClose));
				obj2 = 16;
				break;
			case 11:
				RegisterClientboundPacket(37u, typeof(OhMyGodClientLinkRequest));
				obj2 = 20;
				break;
			case 15:
				RegisterClientboundPacket(73u, typeof(HytGermGuiContent));
				obj2 = 3;
				break;
			case 6:
				ServerboundPackets = new Dictionary<Type, int>();
				obj2 = 8;
				break;
			case 4:
				RegisterClientboundPacket(731u, typeof(HytPacket731));
				obj2 = 1;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_05ab543e742f4f87b8b35434ea962289 == 0)
				{
					obj2 = 5;
				}
				break;
			case 20:
				RegisterClientboundPacket(6u, typeof(OhMyGodMenuOpen));
				obj2 = 18;
				break;
			case 7:
				ClientboundPackets = new Dictionary<int, Type>();
				obj2 = 6;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_35c5cd2f2c1a4570a729d36fd22fd1db == 0)
				{
					obj2 = 2;
				}
				break;
			case 13:
				RegisterClientboundPacket(uint.MaxValue, typeof(GermWrappedPacket));
				obj2 = 19;
				break;
			case 10:
				RegisterServerboundPacket(16u, typeof(HytClientLink));
				obj2 = 17;
				break;
			case 18:
				RegisterServerboundPacket(13u, typeof(GermGuiClick));
				obj2 = 0;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_1aea81acd9574f0fafbfe2b274331bd6 == 0)
				{
					obj2 = 0;
				}
				break;
			case 8:
				RegisterClientboundPacket(3u, typeof(GermGuiContent));
				obj2 = 12;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_7ec04581b0454f299aa1a476459bfa8d == 0)
				{
					obj2 = 13;
				}
				break;
			case 12:
				RegisterServerboundPacket(2u, typeof(GermGuiScript));
				obj2 = 14;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_15890585ab974040b682b0d7c39c6c41 == 0)
				{
					obj2 = 13;
				}
				break;
			case 5:
				RegisterClientboundPacket(76u, typeof(HytPartyOpen));
				obj2 = 11;
				break;
			case 17:
				RegisterServerboundPacket(26u, typeof(HytGermGuiScript));
				obj2 = 1;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_e198027ef2d34f51a1195154aa7ad54b != 0)
				{
					obj2 = 1;
				}
				break;
			case 19:
				RegisterClientboundPacket(72u, typeof(HytClientLinkRequest));
				obj2 = 15;
				break;
			case 14:
				RegisterServerboundPacket(3u, typeof(GermKeyInput));
				obj2 = 10;
				break;
			case 1:
				RegisterServerboundPacket(16u, typeof(OhMyGodClientLink));
				obj2 = 9;
				break;
			case 16:
				RegisterServerboundPacket(4u, typeof(GermGuiOpen));
				obj2 = 7;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_576becf6ad7a473ca20a5e0701462216 == 0)
				{
					obj2 = 12;
				}
				break;
			case 9:
				return;
			case 3:
				RegisterClientboundPacket(714u, typeof(HytPacket714));
				obj2 = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void RegisterClientboundPacket(uint id, object type)
	{
		_FF00_2300(id, type);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void RegisterServerboundPacket(uint id, object type)
	{
		_FF00_1B00(id, type);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GermPacket? ReadGermPacket(this IByteBuffer buffer)
	{
		return (GermPacket?)_FF00_2200(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IByteBuffer WriteGermPacket(this IByteBuffer buffer, GermPacket packet)
	{
		return (IByteBuffer)_FF00ᴀ(buffer, packet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateSegmentedAllocator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GermPacketCodec CombineMapper()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_1800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779245, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00ᤀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00ᨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779244, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void _FF00_1B00(uint P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
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
	internal unsafe static object _FF00ᰀ(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779247, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00ᴀ(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 11010, 1790779246, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779246, new IntPtr(2737367947324L), 15);
		}
		return ((delegate*<object, object, object>)obj)(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00Ḁ(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779241, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00ἀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779240, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_2000()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_2100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779243, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_2200(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 11015, 1790779242, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779242, new IntPtr(2737367942124L), 15);
		}
		return ((delegate*<object, object>)obj)(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void _FF00_2300(uint P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
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
	private unsafe static void _FF00_2400(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779237, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
