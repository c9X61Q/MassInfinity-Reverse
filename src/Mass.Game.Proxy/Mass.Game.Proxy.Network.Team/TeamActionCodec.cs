using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DotNetty.Buffers;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Game.Proxy.Enums;

namespace Mass.Game.Proxy.Network.Team;

public static class TeamActionCodec
{
	internal static TeamActionCodec ReflectReadableConnection;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TeamActionBase ReadTeamAction(this IByteBuffer buffer, EnumProtocolVersion version)
	{
		return (TeamActionBase)_FF00_FF00_FF00_FF00_0D00(buffer, version);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteTeamAction(this IByteBuffer buffer, TeamActionBase action)
	{
		_FF00_FF00_FF00_FF00_0900(buffer, action);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckRemoteAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TeamActionCodec CreateAnnotation()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00ࠀ(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776680, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00_0900(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0047: Expected VT, but got Obj
		//IL_0051: Expected Obj, but got I4
		//IL_0051: Expected Obj, but got Ref
		//IL_0066->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00a4->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0071->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00af->IL0026: Incompatible stack heights: 4 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			case 1:
				((_003C_003Ef__AnonymousType0<>)P_0)._002Ector((_003Caction_003Ej__TPar)P_1);
				((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals(32767);
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field != 0)
				{
					_ = 0;
				}
				break;
			default:
				_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
				/*Error near IL_0078: Member reference must be method, but was: Field*/;
			case 2:
				return;
			case 3:
				_ = ((_003C_003Ef__AnonymousType1<, , >)P_0).name;
				_ = 2;
				if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field == 0)
				{
					_ = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_0A00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776683, new IntPtr(2737368320428L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_0B00()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_0C00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776682, new IntPtr(2737368317308L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_0D00(object P_0, EnumProtocolVersion P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0067: Expected I4, but got Obj
		//IL_013b: Expected Obj, but got VT
		//IL_0089: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I4
		//IL_00c1: Expected Obj, but got VT
		//IL_0072: Expected VT, but got I4
		//IL_021d: Expected I4, but got Obj
		//IL_00f8: Expected VT, but got Obj
		//IL_0100: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I4
		//IL_0140->IL0026: Incompatible stack heights: 3 vs 2
		//IL_009f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a8->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0167->IL0026: Incompatible stack heights: 3 vs 2
		//IL_00c6->IL0026: Incompatible stack heights: 3 vs 2
		//IL_007e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_014b->IL0026: Incompatible stack heights: 3 vs 2
		//IL_00aa->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0172->IL0026: Incompatible stack heights: 3 vs 2
		//IL_00d1->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0231->IL0026: Incompatible stack types: I4 vs Obj
		//IL_023c->IL0026: Incompatible stack types: I4 vs Obj
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
			case 11:
				obj = new
				{
					action = (_003Caction_003Ej__TPar)P_1
				};
				obj2 = 9;
				break;
			case 2:
				obj = ((_003C_003Ef__AnonymousType0<>)P_0).Equals((object)32767);
				obj2 = 1;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field != 0)
				{
					obj2 = 1;
				}
				break;
			case 5:
				goto IL_00aa;
			case 12:
			case 14:
				/*Error near IL_00e0: Member reference must be method, but was: Field*/;
			case 6:
			case 7:
			case 8:
			case 9:
			case 10:
			{
				object obj3 = obj;
				_003Cuser_id_003Ej__TPar user_id = ((_003C_003Ef__AnonymousType1<, , >)obj).user_id;
				((_003C_003Ef__AnonymousType1<, , >)obj3)._002Ector((_003Cname_003Ej__TPar)user_id, (_003Cuuid_003Ej__TPar)user_id, (_003Cuser_id_003Ej__TPar)obj);
				return ((_003C_003Ef__AnonymousType1<, , >)obj3).Equals(P_0);
			}
			default:
				goto IL_0124;
			case 4:
				goto IL_014b;
			case 3:
				goto IL_0196;
			case 1:
				/*Error near IL_01cd: Member reference must be method, but was: Field*/;
			case 13:
				{
					switch ((int)obj)
					{
					case 4:
						break;
					case 3:
						goto IL_00aa;
					case 2:
						goto IL_0124;
					case 1:
						goto IL_014b;
					case 0:
						goto IL_0196;
					default:
						goto IL_021d;
					}
					goto case 11;
				}
				IL_021d:
				obj2 = 14;
				if (((EntityLaunchGameProxy)EntityLaunchGameProxy.GameType__BackingField).GameVersion__BackingField == EnumGameVersion.None)
				{
					obj2 = 4;
				}
				break;
				IL_00aa:
				obj = new { };
				_ = 6;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field != 0)
				{
					_ = 7;
				}
				break;
				IL_0196:
				obj = new { };
				_ = 10;
				break;
				IL_014b:
				obj = new { };
				_ = 6;
				if (((EntitySocks5Account)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.GuideMap).Username__BackingField == null)
				{
					_ = 2;
				}
				break;
				IL_0124:
				obj = new { };
				_ = 4;
				if (!_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout)
				{
					_ = 8;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_0E00()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}
}
