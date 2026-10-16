using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Game.Proxy.Protocols.OhMyGod;

public class OhMyGodHwid
{
	internal static OhMyGodHwid ControlProcessor;

	public string Hwid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_E900();
		}
	}

	public string HwidMd5
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)this._FF00_FF00_FF00_FF00_FF00_FFFD();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object GenerateMd5(object input)
	{
		return _FF00_FF00_FF00_FF00_FF00_EE00(input);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object GenerateRandomMacBytes(uint byteCount)
	{
		return _FF00_FF00_FF00_FF00_FF00_F800(byteCount);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object GenerateRandomMac()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object GenerateRandomDiskStoreInfo()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object GenerateRandomCpu()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object GenerateHwid()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object EncryptOrFallback(Func<string> factory, object fallback)
	{
		return _FF00_FF00_FF00_FF00_FF00_E100(factory, fallback);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OhMyGodHwid()
	{
		//IL_0046: Expected I4, but got Obj
		//IL_0034->IL003d: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = 32;
		OhMyGodHwid ohMyGodHwid = this;
		if (false)
		{
			ohMyGodHwid = (OhMyGodHwid)0;
		}
		switch ((int)ohMyGodHwid)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectDetailedTracker()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static OhMyGodHwid DecorateDividedFinalizer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778764, new IntPtr(2737367927564L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778767, new IntPtr(2737367927564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_E000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778766, new IntPtr(2737367927564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_E100(Func<string> P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 10186, 1790778761, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778761, new IntPtr(2737367927564L), 15);
		}
		return ((delegate*<object, object, object>)obj)(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_E200(Func<string> P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778760, new IntPtr(2737367928604L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_E700()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0057: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 10192, 1790778763, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778763, new IntPtr(2737367928604L), 15);
		}
		return ((delegate*<object>)obj)();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_E800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778762, new IntPtr(2737367929644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_E900()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_EA00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778757, new IntPtr(2737367929644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_EC00()
	{
		//IL_000b: Expected Obj, but got I4
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return 4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_ED00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778756, new IntPtr(2737367929644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_EE00(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 10199, 1790778759, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778759, new IntPtr(2737367929644L), 15);
		}
		return ((delegate*<object, object>)obj)(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_F100()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0057: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 10202, 1790778758, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778758, new IntPtr(2737367897404L), 15);
		}
		return ((delegate*<object>)obj)();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_F200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778753, new IntPtr(2737367930684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_F400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778752, new IntPtr(2737367930684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_F500()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0057: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 10206, 1790778755, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778755, new IntPtr(2737367949404L), 15);
		}
		return ((delegate*<object>)obj)();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_F600()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778754, new IntPtr(2737367932764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_F800(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_005a: Expected I4, but got Obj
		//IL_0100: Expected Obj, but got I4
		//IL_0195: Expected Obj, but got I4
		//IL_019e: Expected Obj, but got I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0171: Invalid comparison between Obj and Ref
		//IL_00c5: Expected Obj, but got I4
		//IL_00c2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_010c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_015a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0077->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0136->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d1->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0117->IL0019: Incompatible stack types: I4 vs Obj
		//IL_016c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00fd->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0182->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00dc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_018d->IL0019: Incompatible stack types: I4 vs Obj
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
				case 9:
					_ = ref obj;
					*(byte*)null = (byte)(*(byte*)null & 0xFE);
					_ = 8;
					continue;
				case 7:
					obj2 = obj;
					if (9 != 0)
					{
						obj2 = 6;
					}
					continue;
				default:
					_ = stackalloc byte[(int)(nuint)obj];
					obj = obj;
					_ = 7;
					continue;
				case 14:
					obj = 0;
					if (12 != 0)
					{
						obj2 = 9;
					}
					continue;
				case 6:
					return obj;
				case 5:
					obj2 = obj;
					_ = 58;
					if (true)
					{
						obj2 = 4;
					}
					continue;
				case 1:
					obj = P_0;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 10:
					obj++;
					obj2 = 13;
					continue;
				case 4:
				case 11:
					_ = ref obj;
					_ = 10;
					continue;
				case 2:
				case 3:
					if ((nint)obj <= 0)
					{
						obj2 = 11;
						continue;
					}
					goto case 5;
				case 12:
				case 13:
					if (Unsafe.IsAddressLessThan(ref *(byte*)obj, ref *(byte*)(&obj)))
					{
						if (2 != 0)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 6;
				case 8:
					break;
				}
				break;
			}
			obj = P_0 * 3 - 1;
			obj = 14;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00豈(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778781, new IntPtr(2737367930684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00ﴀ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0057: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 10214, 1790778780, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778780, new IntPtr(2737367930684L), 15);
		}
		return ((delegate*<object>)obj)();
	}
}
