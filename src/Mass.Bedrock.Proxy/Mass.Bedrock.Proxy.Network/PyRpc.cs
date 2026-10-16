using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Bedrock.Proxy.Network.Minecraft.Enums;
using Mass.Bedrock.Proxy.Network.Packet;
using MessagePack;

namespace Mass.Bedrock.Proxy.Network;

public static class PyRpc
{
	private static readonly object Options;

	internal static PyRpc ReflectGlobalWorker;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static PyRpcPacketBase? AsPyRpc(EnumPacketDirection direction, byte[] data)
	{
		return (PyRpcPacketBase?)_FF00_FF00_FF00_FF00_FF00_FF00_FF00㨀(direction, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] Serialize(PyRpcPacketBase packet)
	{
		return (byte[])_FF00_FF00_FF00_FF00_FF00_FF00_FF00㼀(packet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static object Convert(object input)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 449, 1790778824, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778824, new IntPtr(2737337509644L), 15);
		}
		return ((delegate*<object, object>)obj)(input);
	}

	static PyRpc()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_001f: Expected I4, but got Obj
		//IL_004d->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0058->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				Options = MessagePackSerializerOptions.Standard.WithOldSpec((bool?)true);
				obj2 = 0;
				if (_003CModule_003E_007B516b6972_002D90a8_002D4ed4_002Da9b8_002D9c8a3a89ca13_007D.m_1d065322f6cc4334a6da9cd60aaa535f.m_a347bb6573554289957a566a8523b5a9 == 0)
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
	internal static bool DecorateDetachedProvider()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PyRpc CheckDetailedCalc()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㔀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778825, new IntPtr(2737337523164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㘀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778826, new IntPtr(2737337516924L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㠀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_005e: Expected I4, but got Obj
		//IL_00ea: Expected Obj, but got I4
		//IL_0073->IL0019: Incompatible stack heights: 0 vs 1
		//IL_008c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ff->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0165->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00de->IL0019: Incompatible stack types: I4 vs Obj
		//IL_011b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01bb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0193->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0183->IL0183: Incompatible stack heights: 2 vs 1
		//IL_010a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_014a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_019e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0155->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 4:
					obj = P_0;
					if (3 == 0)
					{
						obj2 = 3;
					}
					continue;
				case 9:
					obj = P_0;
					obj2 = 14;
					continue;
				case 2:
				case 6:
				case 8:
				case 15:
					return obj;
				case 1:
					if (obj != null)
					{
						obj2 = 7;
						continue;
					}
					goto case 9;
				default:
					goto end_IL_0019;
				case 12:
					obj = P_0;
					if (1 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 3:
					if (obj == null)
					{
						obj2 = 12;
						continue;
					}
					goto case 13;
				case 14:
					if (obj == null)
					{
						if (0 == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					break;
				case 13:
					obj = obj;
					obj2 = 15;
					continue;
				case 7:
				case 10:
				{
					object obj3 = obj;
					if (obj3 == null)
					{
						_ = null;
					}
					obj = obj3;
					if (6 == 0)
					{
						obj2 = 4;
					}
					continue;
				}
				case 5:
					break;
				}
				obj = obj ?? ((object)/*Error near IL_01ab: Stack underflow*/);
				obj2 = 8;
				continue;
				end_IL_0019:
				break;
			}
			obj = P_0;
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㤀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778827, new IntPtr(2737337532524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㨀(EnumPacketDirection P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0056: Expected I4, but got Obj
		//IL_0091: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I4
		//IL_00f2: Expected Obj, but got I4
		//IL_00ba->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00e0->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0127->IL0019: Incompatible stack types: I4 vs Obj
		//IL_013a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00f7->IL0015: Incompatible stack heights: 1 vs 0
		//IL_016b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00a7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0145->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0176->IL0019: Incompatible stack types: I4 vs Obj
		//IL_019c->IL0019: Incompatible stack heights: 3 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 13;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 12:
					if (obj == null)
					{
						obj2 = 9;
						continue;
					}
					goto case 1;
				case 3:
					return null;
				case 4:
					return obj;
				case 7:
					obj = ((object[])obj)[1];
					obj = 5;
					break;
				case 8:
					if (obj == null)
					{
						obj2 = 3;
					}
					else
					{
						_ = 10;
					}
					continue;
				case 6:
					obj = ((object[])obj)[0];
					if (2 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 13:
					_ = ref obj;
					obj = obj;
					obj = 12;
					break;
				default:
					return null;
				case 1:
					if (((Array)obj).Length < 2)
					{
						obj2 = 11;
						continue;
					}
					goto case 6;
				case 2:
					if (obj != null)
					{
						if (7 != 0)
						{
							obj2 = 3;
						}
						continue;
					}
					goto default;
				case 5:
					if (obj != null)
					{
						obj = obj;
						obj = 8;
						break;
					}
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 10:
					if (((Array)obj).Length > 2)
					{
						_ = ((object[])obj)[2];
					}
					else
						_ = null;
					_ = 4;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㬀(EnumPacketDirection P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778828, new IntPtr(2737337510684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00㰀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778829, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00㴀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㼀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2919, 1790778830, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778830, new IntPtr(2737337525244L), 15);
		}
		return ((delegate*<object, object>)obj)(P_0);
	}
}
