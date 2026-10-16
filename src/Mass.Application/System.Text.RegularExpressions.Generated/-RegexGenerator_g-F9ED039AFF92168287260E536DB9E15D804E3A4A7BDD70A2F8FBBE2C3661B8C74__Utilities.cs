using System.Buffers;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Text.RegularExpressions.Generated;

[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.13.2707")]
internal static class _003CRegexGenerator_g_003EF9ED039AFF92168287260E536DB9E15D804E3A4A7BDD70A2F8FBBE2C3661B8C74__Utilities
{
	internal static readonly TimeSpan s_defaultTimeout;

	internal static readonly bool s_hasTimeout;

	internal static readonly SearchValues<char> s_asciiHexDigits;

	internal static object ObserveAnnotation;

	static _003CRegexGenerator_g_003EF9ED039AFF92168287260E536DB9E15D804E3A4A7BDD70A2F8FBBE2C3661B8C74__Utilities()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_007e: Expected Obj, but got VT
		//IL_00ea->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00b0->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0088->IL0012: Incompatible stack types: I4 vs Obj
		//IL_011d->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0056->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00f5->IL0012: Incompatible stack types: I4 vs Obj
		//IL_012a->IL012a: Incompatible stack types: Obj vs VT
		//IL_00bb->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0139->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0128->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			TimeSpan timeSpan;
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				if (!(obj is TimeSpan))
				{
					obj2 = 5;
					continue;
				}
				goto case 7;
			case 0:
				return;
			case 5:
			case 6:
				timeSpan = Regex.InfiniteMatchTimeout;
				break;
			case 7:
				obj = (TimeSpan)obj;
				obj2 = 3;
				continue;
			case 4:
				s_hasTimeout = s_defaultTimeout != Regex.InfiniteMatchTimeout;
				obj2 = 8;
				if (_003CModule_003E_007Bc547b36a_002Df832_002D4783_002Dbff4_002D35ff9bad7e58_007D.m_a6edc9c6177f4d1d9742e13736eb3634.m_f7e42b7a624b4fbc9dee8f4ccb3eb28c == 0)
				{
					obj2 = 8;
				}
				continue;
			case 2:
				obj = AppContext.GetData((string)ZYXDNGuarder._FF00_FF00_FF00䠀());
				obj2 = 1;
				if (_003CModule_003E_007Bc547b36a_002Df832_002D4783_002Dbff4_002D35ff9bad7e58_007D.m_a6edc9c6177f4d1d9742e13736eb3634.m_02c825a8ea114de099b2800495f0ebc1 != 0)
				{
					obj2 = 1;
				}
				continue;
			case 8:
				s_asciiHexDigits = SearchValues.Create((string?)ZYXDNGuarder._FF00_FF00_FF00䤀());
				obj2 = 0;
				if (_003CModule_003E_007Bc547b36a_002Df832_002D4783_002Dbff4_002D35ff9bad7e58_007D.m_a6edc9c6177f4d1d9742e13736eb3634.m_2224af72d1e3426e87df53b463b1ef88 != 0)
				{
					obj2 = 0;
				}
				continue;
			case 3:
				timeSpan = (TimeSpan)obj;
				break;
			}
			s_defaultTimeout = timeSpan;
			obj2 = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckAdjustableEmitter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static _003CRegexGenerator_g_003EF9ED039AFF92168287260E536DB9E15D804E3A4A7BDD70A2F8FBBE2C3661B8C74__Utilities DecorateGenericRunner()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00䐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778425, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00䔀()
	{
		_ = ref _003C_003Ef__AnonymousType0<, , , , >._003Cusername_003Ei__Field;
		/*Error near IL_0006: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00䘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778424, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00䜀()
	{
		_ = ref _003C_003Ef__AnonymousType0<, , , , >._003Cusername_003Ei__Field;
		/*Error near IL_0006: Member reference must be method, but was: Field*/;
	}
}
