using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Protocols.Hyt;
using Mass.Game.Proxy.Protocols.OhMyGod;

namespace Mass.Game.Proxy.Protocols.FakeForge.FmlHandshake;

public static class FmlHandshakeMessageCodec
{
	internal static FmlHandshakeMessageCodec CheckHiddenProfiler;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static FmlHandshakeMessage ReadFmlHandshakeMessage(this IByteBuffer buffer, EnumProtocolVersion version)
	{
		return (FmlHandshakeMessage)_FF00_FF00_FF00_FF00ⴀ(buffer, version);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IByteBuffer WriteFmlHandshakeMessage(this IByteBuffer buffer, FmlHandshakeMessage message, EnumProtocolVersion version)
	{
		return (IByteBuffer)_FF00_FF00_FF00_FF00_3000(buffer, message, version);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectAdjustableFactory()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FmlHandshakeMessageCodec DecorateGenericCompressor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_2500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779377, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_2600()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_2700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779376, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_2800()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_2900()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779379, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00Ⰰ(object P_0, EnumProtocolVersion P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779378, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00ⴀ(object P_0, EnumProtocolVersion P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0073: Expected I4, but got Obj
		//IL_017a: Expected Obj, but got Ref
		//IL_0181: Expected I4, but got Obj
		//IL_018b: Expected VT, but got I4
		//IL_018b: Expected Obj, but got I4
		//IL_01bc: Expected VT, but got Ref
		//IL_0147: Expected I4, but got Obj
		//IL_027e: Expected Obj, but got I4
		//IL_01b7: Expected Obj, but got VT
		//IL_0120: Expected Obj, but got VT
		//IL_026d: Expected VT, but got Ref
		//IL_0156: Expected Obj, but got VT
		//IL_020e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0105->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01fd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01c8->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0283->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0125->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0268->IL0026: Incompatible stack types: I4 vs Obj
		//IL_026d->IL026d: Incompatible stack heights: 1 vs 2
		//IL_00e5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_015b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_028e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0130->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0166->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 16;
		object obj2 = obj;
		while (true)
		{
			_003C_003Ef__AnonymousType0<> anon;
			switch ((int)obj2)
			{
			default:
				anon = (_003C_003Ef__AnonymousType0<>)new { };
				break;
			case 9:
				if ((nint)obj != 254)
				{
					obj2 = 3;
					continue;
				}
				goto case 14;
			case 10:
				obj = new { };
				obj2 = 8;
				continue;
			case 3:
				if ((nint)obj != 255)
				{
					obj2 = 17;
					if (_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic == null)
					{
						obj2 = 16;
					}
					continue;
				}
				goto case 13;
			case 15:
				switch ((int)obj)
				{
				case 2:
					break;
				default:
					goto IL_0147;
				case 1:
					goto IL_0175;
				case 0:
					goto IL_01fd;
				case 3:
					goto IL_0257;
				}
				goto case 10;
			case 1:
			case 17:
				goto IL_0175;
			case 2:
			case 6:
			case 8:
			case 11:
			case 12:
				return ((_003C_003Ef__AnonymousType2<, , , >)P_0).user_id;
			case 14:
				obj = new
				{
					url = (_003Curl_003Ej__TPar)/*Error near IL_01bc: Stack underflow*/,
					payload = (_003Cpayload_003Ej__TPar)/*Error near IL_01bc: Stack underflow*/,
					context = (_003Ccontext_003Ej__TPar)/*Error near IL_01bc: Stack underflow*/,
					user_id = (_003Cuser_id_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)
				};
				_ = 11;
				continue;
			case 13:
				obj = new { };
				obj2 = 12;
				continue;
			case 7:
				goto IL_01fd;
			case 16:
				/*Error near IL_020f: Member reference must be method, but was: Field*/;
			case 4:
				goto IL_0257;
			case 5:
				{
					_ = new
					{
						entry = (_003Centry_003Ej__TPar)/*Error near IL_026d: Stack underflow*/,
						sid = (_003Csid_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)
					};
					break;
				}
				IL_0257:
				if (P_1 > EnumProtocolVersion.V1710)
				{
					obj2 = 5;
					continue;
				}
				goto default;
				IL_01fd:
				obj = new { };
				obj2 = 6;
				continue;
				IL_0175:
				((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_017a: Stack underflow*/).Equals((object)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
				_ = (object)((byte)(int)obj != 0);
				_ = ref obj;
				((EqualityComparer<_00211>)28).GetHashCode((_00211)1);
				_ = ref obj;
				_003C_003Ef__AnonymousType1<, , >.ReflectScalableStack();
				/*Error near IL_0192: Member reference must be method, but was: Field*/;
				IL_0147:
				obj2 = 9;
				if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType3<, >._003Centry_003Ei__Field)._003Csid_003Ei__Field != 0)
				{
					obj2 = 5;
				}
				continue;
			}
			obj = anon;
			obj2 = 2;
			if (((EntityLaunchGameProxy)EntityLaunchGameProxy.GameVersion__BackingField).ModHashList__BackingField != null)
			{
				obj2 = 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_2E00(object P_0, EnumProtocolVersion P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779341, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_3000(object P_0, object P_1, EnumProtocolVersion P_2)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0087: Expected I4, but got Obj
		//IL_028d: Expected Obj, but got I4
		//IL_02f1: Expected Obj, but got I4
		//IL_01b9: Expected Obj, but got Ref
		//IL_0147: Expected Obj, but got I4
		//IL_0156: Expected Obj, but got VT
		//IL_02e4: Expected Obj, but got I4
		//IL_0094: Expected VT, but got Obj
		//IL_0094: Expected VT, but got Obj
		//IL_0094: Expected Obj, but got Ref
		//IL_0243: Expected Obj, but got I4
		//IL_02a1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02fb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02c7->IL0026: Incompatible stack heights: 5 vs 2
		//IL_015b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02ee->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009f->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0257->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ed->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02ac->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0111->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01b4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_017b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_020d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02d2->IL0026: Incompatible stack heights: 5 vs 2
		//IL_00be->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0166->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0262->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c9->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 12;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 20:
				((EqualityComparer<_00210>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals((_00210?)P_0, (_00210?)obj);
				_ = 13;
				break;
			case 14:
				if (P_1 is _003C_003Ef__AnonymousType3<, >)
				{
					obj2 = 1;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field != 0)
					{
						obj2 = 4;
					}
					break;
				}
				goto case 8;
			case 2:
				if (P_1 is EntitySocks5Account)
				{
					obj2 = 6;
					break;
				}
				goto case 14;
			case 15:
			case 22:
				obj = 3;
				obj2 = 5;
				if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument != null)
				{
					obj2 = 5;
				}
				break;
			case 11:
				if (!(P_1 is GameProxy._003CListenAsync_003Ed__69))
				{
					obj2 = 10;
					break;
				}
				goto case 19;
			case 10:
				if (P_1 is OhMyGodEncryption)
				{
					obj2 = 22;
					break;
				}
				goto case 2;
			case 8:
			case 9:
				_ = ((_003C_003Ef__AnonymousType2<, , , >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).url;
				_ = ((_003C_003Ef__AnonymousType2<, , , >)P_1).payload;
				/*Error near IL_01c0: Member reference must be method, but was: Field*/;
			default:
				obj = obj;
				obj2 = 20;
				if (((EntitySocks5)EntitySocks5.Address__BackingField).Port__BackingField != 0)
				{
					obj2 = 19;
				}
				break;
			case 12:
				if (!(P_1 is HytProtocol))
				{
					obj2 = 11;
					break;
				}
				goto case 21;
			case 21:
				obj = 1;
				obj2 = 6;
				if (((EntityLaunchGameProxy)EntityLaunchGameProxy.GameId__BackingField).GameType__BackingField != 0)
				{
					obj2 = 18;
				}
				break;
			case 1:
			case 6:
				obj = 255;
				obj2 = 0;
				if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Name__BackingField).ServerAddress__BackingField != null)
				{
					obj2 = 0;
				}
				break;
			case 13:
				_003C_003Ef__AnonymousType3<, >.DecorateIntegratedProgram();
				_ = 10;
				if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Socks5__BackingField).Value__BackingField == null)
				{
					_ = 16;
				}
				break;
			case 19:
				obj = 2;
				obj2 = 17;
				break;
			case 4:
			case 7:
				obj = 3;
				obj2 = 3;
				break;
			case 16:
				return P_0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_3100(object P_0, object P_1, EnumProtocolVersion P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779340, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
