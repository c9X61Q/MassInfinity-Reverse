using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Game.Proxy.Protocols.Heypixel;

public static class JavaUuidCompat
{
	private static object ReflectIterableProgram;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Guid FromFormat(string formated)
	{
		return _FF00_FF00_FF00_FF00_FF00_0600(formated);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Guid FromLongs(long mostSigBits, long leastSigBits)
	{
		return _FF00_FF00_FF00_FF00_FF00ࠀ(mostSigBits, leastSigBits);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static (long mostSigBits, long leastSigBits) ToLongs(Guid guid)
	{
		return _FF00_FF00_FF00_FF00_FF00_0B00(guid);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Guid Random()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectIntegratedTemplate()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static JavaUuidCompat AwakeSender()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Guid _FF00_FF00_FF00_FF00_FF00Ȁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778458, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		return (Guid)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Guid _FF00_FF00_FF00_FF00_FF00_0300()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0035: Expected Obj, but got I4
		//IL_019e: Expected VT, but got Obj
		//IL_00ef: Expected Obj, but got I4
		//IL_0064: Expected I4, but got Obj
		//IL_003f->IL0043: Incompatible stack types: I4 vs Obj
		//IL_0190->IL0019: Incompatible stack heights: 0 vs 1
		//IL_019b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007a->IL0043: Incompatible stack heights: 0 vs 1
		//IL_00d0->IL0043: Incompatible stack heights: 2 vs 1
		//IL_00bf->IL0043: Incompatible stack heights: 2 vs 1
		//IL_0043->IL0043: Incompatible stack heights: 2 vs 1
		//IL_0085->IL0043: Incompatible stack types: I4 vs Obj
		//IL_00db->IL0043: Incompatible stack heights: 2 vs 1
		//IL_0116->IL0043: Incompatible stack types: I4 vs Obj
		//IL_00aa->IL0043: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
			{
				obj = 16;
				object obj3 = 2;
				while (true)
				{
					switch ((int)obj3)
					{
					case 1:
						obj = obj;
						if (4 == 0)
						{
							obj3 = 6;
						}
						continue;
					case 4:
						obj3 = obj;
						*(byte*)8 = (byte)(*(byte*)8 | 0x80);
						if (0 == 0)
						{
							obj3 = 1;
						}
						continue;
					case 5:
						*(byte*)8 = (byte)(*(byte*)8 & 0x3F);
						_ = 4;
						continue;
					case 2:
						if (3 == 0)
						{
							_ = 2;
						}
						continue;
					default:
						*(byte*)6 = (byte)(*(byte*)6 | 0x40);
						obj = 5;
						continue;
					case 3:
						obj3 = obj;
						*(byte*)6 = (byte)(*(byte*)6 & 0xF);
						if (0 == 0)
						{
							obj3 = 0;
						}
						continue;
					case 6:
						break;
					}
					break;
				}
				break;
			}
			case 1:
				obj = (object)/*Error near IL_0184: Stack underflow*/;
				if (0 == 0)
				{
					obj2 = 0;
				}
				continue;
			case 2:
				break;
			}
			break;
		}
		return (Guid)obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Guid _FF00_FF00_FF00_FF00_FF00Ѐ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778453, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		return (Guid)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Guid _FF00_FF00_FF00_FF00_FF00_0600(object P_0)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0024: Expected VT, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		if (((Array)0).Length != 2)
		{
			throw 0;
		}
		object obj = ((object[])0)[0];
		_ = ((object[])0)[1];
		return (Guid)obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Guid _FF00_FF00_FF00_FF00_FF00_0700(long P_0, long P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778452, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
		return (Guid)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Guid _FF00_FF00_FF00_FF00_FF00ࠀ(long P_0, long P_1)
	{
		//IL_0039: Expected VT, but got I4
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = P_0 >> 32;
		_ = (short)(P_0 >> 16);
		_ = (short)P_0;
		_ = (byte)(P_1 >> 56);
		_ = (byte)(P_1 >> 48);
		_ = (byte)(P_1 >> 40);
		_ = (byte)(P_1 >> 32);
		_ = (byte)(P_1 >> 24);
		_ = (byte)(P_1 >> 16);
		_ = (byte)(P_1 >> 8);
		return (Guid)(byte)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Guid _FF00_FF00_FF00_FF00_FF00_0900(long P_0, long P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778455, new IntPtr(2737367948364L), 15))(null, 0, new IntPtr(0L));
		return (Guid)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static (long, long) _FF00_FF00_FF00_FF00_FF00_0A00(Guid P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778454, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		return ((long, long))/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static (long, long) _FF00_FF00_FF00_FF00_FF00_0B00(Guid P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_010c: Expected Obj, but got I8
		//IL_0110: Expected VT, but got Obj
		//IL_0039: Expected Obj, but got I4
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_0045->IL0019: Incompatible stack types: I vs Ref
		//IL_006d->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0050->IL0019: Incompatible stack types: I4 vs Ref
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		ref Guid reference = ref *(Guid*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			case 2u:
			{
				byte* ptr = stackalloc byte[16];
				obj = 16;
				reference = ref *(Guid*)ptr;
				if (1 == 0)
				{
					reference = ref *(Guid*)null;
				}
				continue;
			}
			case 1u:
				reference = ref P_0;
				if (0 == 0)
				{
					reference = ref *(Guid*)null;
				}
				continue;
			}
			_ = ref obj;
			_ = (ulong)(*(byte*)3) << 56;
			_ = (ulong)(nint)(&obj) | ((ulong)(*(byte*)2) << 48);
			_ = (ulong)(nint)(&obj) | ((ulong)(*(byte*)1) << 40);
			_ = (ulong)(nint)(&obj) | ((ulong)(*(byte*)null) << 32);
			_ = (ulong)(nint)(&obj) | ((ulong)(*(byte*)5) << 24);
			_ = (ulong)(nint)(&obj) | ((ulong)(*(byte*)4) << 16);
			_ = (ulong)(nint)(&obj) | ((ulong)(*(byte*)7) << 8);
			_ = (ulong)(nint)(&obj) | (ulong)(*(byte*)6);
			_ = ref obj;
			_ = (ulong)(*(byte*)8) << 56;
			_ = (ulong)(nint)(&obj) | ((ulong)(*(byte*)9) << 48);
			_ = (ulong)(nint)(&obj) | ((ulong)(*(byte*)10) << 40);
			_ = (ulong)(nint)(&obj) | ((ulong)(*(byte*)11) << 32);
			_ = (ulong)(nint)(&obj) | ((ulong)(*(byte*)12) << 24);
			_ = (ulong)(nint)(&obj) | ((ulong)(*(byte*)13) << 16);
			_ = (ulong)(nint)(&obj) | ((ulong)(*(byte*)14) << 8);
			obj = (long)(nint)(&obj) | (long)(*(byte*)15);
			return ((long, long))obj;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static (long, long) _FF00_FF00_FF00_FF00_FF00_0C00(Guid P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778449, new IntPtr(2737367941084L), 15))(null, 0, new IntPtr(0L));
		return ((long, long))/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_0D00()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_0E00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00ༀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778448, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
