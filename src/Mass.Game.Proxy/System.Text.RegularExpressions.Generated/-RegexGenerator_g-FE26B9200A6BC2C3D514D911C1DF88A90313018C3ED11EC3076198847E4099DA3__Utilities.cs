using System.Buffers;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Text.RegularExpressions.Generated;

[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.13.2707")]
internal static class _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities
{
	internal static readonly TimeSpan s_defaultTimeout;

	internal static readonly bool s_hasTimeout;

	internal static readonly SearchValues<char> s_ascii_68FF03FEFFFF87FEFFFF07;

	private static object GuideMap;

	static _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_00a2: Expected Obj, but got VT
		//IL_0094: Expected Obj, but got I4
		//IL_0064->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00ee->IL0012: Incompatible stack types: I4 vs Obj
		//IL_010e->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00b6->IL0012: Incompatible stack types: I4 vs Obj
		//IL_011b->IL011b: Incompatible stack types: Obj vs VT
		//IL_006f->IL0012: Incompatible stack types: I4 vs Obj
		//IL_012a->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0119->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00c1->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 6;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				TimeSpan timeSpan;
				switch ((int)obj2)
				{
				default:
					return;
				case 2:
					s_ascii_68FF03FEFFFF87FEFFFF07 = SearchValues.Create((string?)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_E100());
					obj2 = 0;
					if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_bf02cbaf033d4b81a2d354214f5d3bba != 0)
					{
						obj2 = 0;
					}
					continue;
				case 0:
					return;
				case 5:
					if (obj is TimeSpan)
					{
						goto end_IL_0012;
					}
					goto case 4;
				case 7:
					obj = (TimeSpan)obj;
					obj2 = 1;
					if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_c9af4ee58aed4ee394c65f1bac8be6ce == 0)
					{
						obj2 = 1;
					}
					continue;
				case 4:
					timeSpan = Regex.InfiniteMatchTimeout;
					break;
				case 3:
					s_hasTimeout = s_defaultTimeout != Regex.InfiniteMatchTimeout;
					obj2 = 2;
					continue;
				case 6:
					obj = AppContext.GetData((string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_E200());
					obj2 = 5;
					if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_7ec04581b0454f299aa1a476459bfa8d != 0)
					{
						obj2 = 2;
					}
					continue;
				case 1:
					timeSpan = (TimeSpan)obj;
					break;
				}
				s_defaultTimeout = timeSpan;
				obj2 = 3;
				continue;
				end_IL_0012:
				break;
			}
			obj = 7;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool InstantiateVisitor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities PatchWatcher()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_E300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778673, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_E400()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_E500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778672, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_E600()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_E700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778675, new IntPtr(2737367925484L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
