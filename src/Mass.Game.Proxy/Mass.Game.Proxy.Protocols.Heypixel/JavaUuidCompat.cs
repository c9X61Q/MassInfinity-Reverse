using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;

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
	internal static Guid _FF00_FF00_FF00_FF00_FF00_0300()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_020f: Expected VT, but got Obj
		//IL_012c: Expected Obj, but got I4
		//IL_0081: Expected VT, but got Obj
		//IL_0104: Expected Obj, but got VT
		//IL_00c3: Expected Obj, but got VT
		//IL_0075: Expected I4, but got Obj
		//IL_0050->IL0054: Incompatible stack types: I4 vs Obj
		//IL_0097->IL0054: Incompatible stack types: I4 vs Obj
		//IL_0109->IL0054: Incompatible stack heights: 5 vs 2
		//IL_0154->IL0054: Incompatible stack types: I4 vs Obj
		//IL_00c8->IL0054: Incompatible stack types: I4 vs Obj
		//IL_00ec->IL0054: Incompatible stack types: I4 vs Obj
		//IL_0164->IL020c: Incompatible stack heights: 0 vs 1
		//IL_00a2->IL0054: Incompatible stack types: I4 vs Obj
		//IL_0114->IL0054: Incompatible stack heights: 5 vs 2
		//IL_015f->IL0054: Incompatible stack types: I4 vs Obj
		//IL_00d3->IL0054: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		default:
		{
			obj = new RegexRunner[16];
			object obj2 = 2;
			while (true)
			{
				switch ((int)obj2)
				{
				case 1:
					obj = new EqualityComparer<_00210>((_00210)obj);
					obj2 = 4;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
					{
						obj2 = 6;
					}
					continue;
				case 4:
				{
					ref string reference2 = ref ((string[])obj)[8];
					Unsafe.As<string, byte>(ref reference2) = (byte)(Unsafe.As<string, byte>(ref reference2) | 0x80);
					obj2 = 0;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
					{
						obj2 = 1;
					}
					continue;
				}
				case 5:
				{
					ref Attribute reference4 = ref ((Attribute[])obj)[8];
					Unsafe.As<Attribute, byte>(ref reference4) = (byte)(Unsafe.As<Attribute, byte>(ref reference4) & 0x3F);
					obj2 = 4;
					continue;
				}
				case 2:
					_ = EqualityComparer<_00212>.Default;
					_ = 3;
					if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument == null)
					{
						_ = 2;
					}
					continue;
				default:
				{
					ref bool reference3 = ref ((bool[])obj)[6];
					reference3 = (byte)((reference3 ? 1u : 0u) | 0x40u) != 0;
					obj = 5;
					obj2 = obj;
					continue;
				}
				case 3:
				{
					ref Color reference = ref ((Color[])obj)[6];
					Unsafe.As<Color, byte>(ref reference) = (byte)(Unsafe.As<Color, byte>(ref reference) & 0xF);
					obj2 = 0;
					if ((int)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout == 0)
					{
						obj2 = 0;
					}
					continue;
				}
				case 6:
					break;
				}
				break;
			}
			break;
		}
		case 1:
			/*Error near IL_01e6: Member reference must be method, but was: Field*/;
		case 2:
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
	internal unsafe static Guid _FF00_FF00_FF00_FF00_FF00_0600(object P_0)
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001a: Expected Obj, but got Ref
		//IL_0020: Expected VT, but got I4
		//IL_0022: Expected Obj, but got I4
		//IL_002e: Expected Obj, but got I4
		//IL_0033: Expected Obj, but got I4
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)P_0);
		int hashCode = ((EqualityComparer<_00210>)/*Error near IL_0020: Stack underflow*/).GetHashCode((_00210)0);
		if (((Array)hashCode).Length != 2)
		{
			throw new string((IFormatProvider?)/*Error near IL_0033: Stack underflow*/, (string)/*Error near IL_0033: Stack underflow*/, (object?[])((_003C_003Ef__AnonymousType0<>)hashCode).GetHashCode());
		}
		_ = ((object[])hashCode)[0];
		/*Error near IL_0037: Member reference must be method, but was: Field*/;
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
		//IL_0049: Expected VT, but got I4
		//IL_0049: Expected VT, but got I4
		//IL_004a: Expected VT, but got Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
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
		return (Guid)new EqualityComparer<_00210>((_00210?)(byte)(P_1 >> 8), (_00210?)(byte)P_1);
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
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0072: Expected Obj, but got Ref
		//IL_0072: Expected Obj, but got Ref
		//IL_0082: Expected Obj, but got VT
		//IL_0048: Expected VT, but got I4
		//IL_0048: Expected VT, but got I
		//IL_0059: Expected Obj, but got VT
		//IL_0087->IL0026: Incompatible stack heights: 1 vs 2
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0069->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				obj = new EqualityComparer<_00210>((_00210?)stackalloc byte[16], (_00210?)16);
				obj2 = 1;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
				}
				break;
			case 1:
				string.Format((IFormatProvider?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (string)(&P_0), (object?[])obj);
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
				{
					_ = 0;
				}
				break;
			default:
				_ = ref obj;
				_ = 3;
				/*Error near IL_0095: Member reference must be method, but was: Field*/;
			}
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
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_0E00()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00ༀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778448, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
