using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Minecraft;

namespace Mass.Game.Proxy.Protocols.Heypixel.Floodgate;

public static class Floodgate
{
	internal static Floodgate EncryptProxy;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void HandleFloodgate(Mass.Game.Proxy.Minecraft.Minecraft minecraft, Action<string, IByteBuffer> sender, IByteBuffer data)
	{
		_FF00_FF00_FF00_FF00관(minecraft, sender, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void SendFloodgate(Action<string, IByteBuffer> sender, ushort windowId, object buttonId)
	{
		_FF00_FF00_FF00_FF00넀(sender, windowId, buttonId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckSetEmitter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Floodgate DecorateEfficientRunner()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00鴀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778622, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00鸀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00鼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778617, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00ꀀ()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00ꄀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778616, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00_FF00관(object P_0, Action<string, IByteBuffer> P_1, object P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0092: Expected I4, but got Obj
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Invalid comparison between Obj and Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_02ae: Expected Obj, but got I4
		//IL_0126: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got I4
		//IL_0265->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0348->IL0019: Incompatible stack heights: 10 vs 1
		//IL_01eb->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0107->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0146->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0370->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0195->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00dc->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0360->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0207->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0283->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0238->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00f6->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0311->IL0019: Incompatible stack heights: 15 vs 1
		//IL_0178->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0229->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0353->IL0019: Incompatible stack heights: 10 vs 1
		//IL_01f6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0112->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0275->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01da->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0253->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0123->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0212->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01c6->IL0019: Incompatible stack heights: 9 vs 1
		//IL_00c0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0243->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00cb->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 25;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 6:
					if ((nint)obj != 1)
					{
						obj2 = 9;
						continue;
					}
					obj = obj;
					obj2 = 28;
					continue;
				case 22:
				case 23:
					if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
					{
						if (12 == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 4;
				case 14:
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 26:
					_ = 7;
					continue;
				case 5:
					if (21 == 0)
					{
						_ = 2;
					}
					continue;
				case 11:
					if (obj != null)
					{
						obj2 = 6;
						continue;
					}
					obj = obj;
					obj2 = 10;
					continue;
				case 17:
					obj = 0;
					obj = 23;
					break;
				case 7:
					obj = P_2;
					_ = 11;
					continue;
				default:
					obj2 = obj;
					obj = obj;
					if (true)
					{
						obj2 = 3;
					}
					continue;
				case 13:
					obj = P_2;
					obj2 = 26;
					continue;
				case 16:
					return;
				case 20:
					_ = ref obj;
					_ = 10;
					_ = 1;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					obj = obj;
					_ = 17;
					continue;
				case 10:
					if (obj == null)
					{
						obj2 = 20;
						continue;
					}
					goto case 2;
				case 4:
					if (27 == 0)
					{
						_ = 22;
					}
					continue;
				case 19:
					if (6 == 0)
					{
						_ = 14;
					}
					continue;
				case 1:
					if (obj != (object)(obj - 1))
					{
						obj2 = 8;
						continue;
					}
					goto case 15;
				case 25:
					obj = (object)/*Error near IL_022c: Stack underflow*/;
					if (2 != 0)
					{
						obj2 = 24;
					}
					continue;
				case 9:
					return;
				case 2:
					_ = 16;
					continue;
				case 27:
					return;
				case 24:
					_ = 13;
					continue;
				case 15:
					obj++;
					obj = 22;
					break;
				case 28:
					_ = ref obj;
					_ = 10;
					_ = 1;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					obj = obj;
					_ = 5;
					continue;
				case 3:
					_ = ref obj;
					_ = 12;
					_ = 1;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					if (false)
					{
						_ = 1;
					}
					continue;
				case 12:
				case 18:
					obj = (object)/*Error near IL_0356: Stack underflow*/;
					obj2 = 19;
					continue;
				case 21:
					return;
				case 8:
					obj2 = 15;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00글(object P_0, Action<string, IByteBuffer> P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778619, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void _FF00_FF00_FF00_FF00뀀(Action<string, IByteBuffer> P_0, ushort P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778618, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void _FF00_FF00_FF00_FF00넀(Action<string, IByteBuffer> P_0, ushort P_1, object P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0042->IL0019: Incompatible stack heights: 3 vs 1
		//IL_004d->IL0019: Incompatible stack heights: 3 vs 1
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
}
