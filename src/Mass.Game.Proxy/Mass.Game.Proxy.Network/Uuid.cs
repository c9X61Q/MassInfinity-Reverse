using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;

namespace Mass.Game.Proxy.Network;

public static class Uuid
{
	private static object ReflectAutomatedReporter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Guid ReadUuid(this IByteBuffer buffer, EnumProtocolVersion version)
	{
		return _FF00_FF00_FF00_FF00㨀(buffer, version);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IByteBuffer WriteUuid(this IByteBuffer buffer, Guid uuid, EnumProtocolVersion version)
	{
		return (IByteBuffer)_FF00_FF00_FF00_FF00㘀(buffer, uuid, version);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecoratePassiveChain()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Uuid DecorateExternalEnumerator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00㔀(object P_0, Guid P_1, EnumProtocolVersion P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776615, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00㘀(object P_0, Guid P_1, EnumProtocolVersion P_2)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0052: Expected VT, but got Ref
		//IL_005c: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got Ref
		//IL_0067->IL0026: Incompatible stack heights: 3 vs 2
		//IL_00e3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ee->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				((EqualityComparer<_00210>)(object)(*(RegexRunner*)P_0)/*cast due to constrained. prefix*/).GetHashCode((_00210)(&P_1));
				((_003C_003Ef__AnonymousType0<>)32767).GetHashCode();
				_ = 4;
				break;
			case 3:
			case 4:
				return P_0;
			case 1:
				((_003C_003Ef__AnonymousType0<>)(&P_1)).ToString();
				/*Error near IL_0071: Member reference must be method, but was: Field*/;
			case 2:
				if (P_2 >= EnumProtocolVersion.V1181)
				{
					obj2 = 1;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate != null)
					{
						obj2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00㜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776614, new IntPtr(2737368317308L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00㠀()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00㤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776609, new IntPtr(2737368320428L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Guid _FF00_FF00_FF00_FF00㨀(object P_0, EnumProtocolVersion P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0044: Expected VT, but got I4
		//IL_008c: Expected Obj, but got VT
		//IL_0091->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009c->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				((_003C_003Ef__AnonymousType0<>)P_0)._002Ector((_003Caction_003Ej__TPar)36);
				/*Error near IL_00aa: Member reference must be method, but was: Field*/;
			case 1:
				if (P_1 >= EnumProtocolVersion.V1181)
				{
					obj2 = 0;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 2;
			default:
				_ = 16;
				_003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
				_ = 0;
				/*Error near IL_00a5: Member reference must be method, but was: Field*/;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00㬀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}
}
