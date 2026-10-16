using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Network;

public static class VarLong
{
	internal static VarLong ReflectInterruptibleFactory;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static long ReadVarLong(this IByteBuffer buffer)
	{
		return _FF00_FF00_FF00_FF00_2100(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IByteBuffer WriteVarLong(this IByteBuffer buffer, long input)
	{
		return (IByteBuffer)_FF00_FF00_FF00_FF00Ḁ(buffer, input);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckCustomizableCompressor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static VarLong CheckInternalResponder()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00ᴀ(object P_0, long P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776632, new IntPtr(2737368317308L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00Ḁ(object P_0, long P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_011e: Expected VT, but got I4
		//IL_011e: Expected VT, but got Obj
		//IL_011e: Expected Obj, but got Ref
		//IL_00fb: Expected Obj, but got VT
		//IL_0078: Expected Obj, but got I4
		//IL_0088: Expected Obj, but got VT
		//IL_0129->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0100->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008d->IL0026: Incompatible stack heights: 3 vs 2
		//IL_010b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0098->IL0026: Incompatible stack heights: 3 vs 2
		//IL_00dc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e7->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				((object)P_1).ToString();
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field != 0)
				{
					_ = 0;
				}
				break;
			default:
				return P_0;
			case 2:
			case 6:
				if ((P_1 & -128) != 0L)
				{
					obj2 = 5;
					if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field == 0)
					{
						obj2 = 5;
					}
					break;
				}
				goto case 4;
			case 3:
				P_1 >>>= 7;
				obj2 = 5;
				if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument != null)
				{
					obj2 = 6;
				}
				break;
			case 1:
			case 5:
				((EqualityComparer<_00211>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals((_00211?)P_0, (_00211?)((P_1 & 0x7F) | 0x80));
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00ἀ()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static long _FF00_FF00_FF00_FF00_2100(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0118: Expected VT, but got Obj
		//IL_0118: Expected VT, but got Ref
		//IL_011a: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got VT
		//IL_00f2: Expected Obj, but got I8
		//IL_00ff: Expected I8, but got Obj
		//IL_0072->IL0026: Incompatible stack types: I4 vs Obj
		//IL_012e->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0139->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0094->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0112->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ee->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
			{
				object obj3 = obj;
				long num = obj & 0x7F;
				object obj4 = obj;
				obj = obj4 + 1;
				obj = obj3 | (num << obj4 * 7);
				obj2 = 7;
				continue;
			}
			case 2:
				obj = 0;
				obj2 = 1;
				if ((int)((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
				{
					obj2 = 1;
				}
				continue;
			case 5:
				_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
				/*Error near IL_00bd: Member reference must be method, but was: Field*/;
			case 4:
				if ((int)((_003C_003Ef__AnonymousType1<, , >)obj).name == 0)
				{
					obj2 = 0;
					if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field == 0)
					{
						obj2 = 6;
					}
					continue;
				}
				break;
			case 3:
				obj = 0;
				obj2 = 2;
				continue;
			case 6:
				return (long)obj;
			case 7:
				if ((nint)obj <= 10)
				{
					obj2 = 4;
					continue;
				}
				goto case 5;
			case 1:
				break;
			}
			obj = ((EqualityComparer<_00212>)/*Error near IL_0118: Stack underflow*/).Equals((_00212?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00212?)P_0);
			_ = 0;
			if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance != null)
			{
				_ = 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_2200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776635, new IntPtr(2737368315228L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_2300()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}
}
