using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using Mass.Domain.Desktop.ValueObjects;

namespace Mass.Game.Proxy.Protocols.OhMyGod;

public static class OhMyGodEncryption
{
	private static object DecorateEfficientEmitter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string EncryptData(string input)
	{
		return (string)_FF00_FF00_FF00_FF00_FF00_FF00_0600(input);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object DesEncrypt(object key, object data)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00ࠀ(key, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object DesEncrypt(object key, object data)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 177, 1790778809, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778809, new IntPtr(2737367922364L), 15);
		}
		return ((delegate*<object, object, object>)obj)(key, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object ToBase32(this object? data)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 178, 1790778808, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778808, new IntPtr(2737367923404L), 15);
		}
		return ((delegate*<object, object>)obj)(data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectAttachedRunner()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static OhMyGodEncryption DecorateGlobalClient()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778811, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00Ā(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_009f: Expected I4, but got Obj
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_02cf: Expected Obj, but got I4
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_0235: Expected Obj, but got I4
		//IL_0296: Expected Obj, but got I4
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected Obj, but got Unknown
		//IL_01ee: Expected Obj, but got Ref
		//IL_017e: Expected VT, but got Obj
		//IL_017e: Expected VT, but got Ref
		//IL_017f: Expected Obj, but got I4
		//IL_013a: Expected Obj, but got I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_0105: Expected Obj, but got I4
		//IL_0354: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got VT
		//IL_0261->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02d9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0345->IL0177: Incompatible stack heights: 0 vs 1
		//IL_0337->IL0026: Incompatible stack types: I4 vs Obj
		//IL_030d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02ae->IL0026: Incompatible stack types: I4 vs Obj
		//IL_023f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0374->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0144->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0119->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0251->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0359->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0318->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0232->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0102->IL0026: Incompatible stack types: I4 vs Obj
		//IL_019b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0124->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0364->IL0026: Incompatible stack heights: 1 vs 2
		//IL_01a6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f2->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 22;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 26:
					obj = (obj << ((5 - obj) & 0x1F)) & 0x1F;
					obj2 = 16;
					continue;
				case 27:
					if (((Array)P_0).Length != 0)
					{
						obj2 = 1;
						if ((int)((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 20;
				case 22:
					if (P_0 == null)
					{
						obj2 = 21;
						continue;
					}
					goto case 27;
				case 28:
					obj = 0;
					obj2 = 2;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
					{
						obj2 = 8;
					}
					continue;
				case 14:
				case 25:
					obj = ((byte[])obj)[obj];
					obj2 = 13;
					continue;
				case 16:
					_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
					/*Error near IL_014d: Member reference must be method, but was: Field*/;
				case 24:
					return ((EqualityComparer<_00212>)/*Error near IL_017e: Stack underflow*/).Equals((_00212?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00212?)obj);
				case 2:
				case 23:
					if ((nint)obj < 5)
					{
						obj2 = 3;
						if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance == null)
						{
							obj2 = 3;
						}
						continue;
					}
					goto case 9;
				case 20:
				case 21:
					return (object)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field);
				case 1:
					_ = (((Array)P_0).Length * 8 + 4) / 5;
					/*Error near IL_01f7: Member reference must be method, but was: Field*/;
				case 8:
				case 12:
					if ((nint)obj < ((Array)obj).Length)
					{
						obj2 = 14;
						continue;
					}
					goto case 5;
				case 17:
					obj = 0;
					obj2 = 4;
					continue;
				case 5:
					if ((nint)obj > 0)
					{
						obj2 = 26;
						continue;
					}
					goto case 6;
				case 3:
					obj++;
					obj2 = 12;
					continue;
				default:
					_ = 61;
					/*Error near IL_0265: Member reference must be method, but was: Field*/;
				case 18:
					break;
				case 13:
					obj = (object)(obj << 8) | obj;
					obj2 = 19;
					continue;
				case 11:
					((_003C_003Ef__AnonymousType2<, , , >)obj).GetHashCode();
					/*Error near IL_02b7: Member reference must be method, but was: Field*/;
				case 4:
					obj = 0;
					obj2 = 18;
					continue;
				case 10:
					obj = (obj >> (obj & 0x1F)) & 0x1F;
					obj2 = 4;
					if (((EntityLaunchGameProxy)EntitySocks5.DecorateDynamicModule).Session__BackingField == null)
					{
						obj2 = 11;
					}
					continue;
				case 9:
					obj -= 5;
					obj2 = 10;
					continue;
				case 6:
				case 7:
					((Regex)obj)._002Ector();
					if ((nint)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field) % (nint)8 != 0)
					{
						_ = 0;
						if (((EntityLaunchGameProxy)EntityLaunchGameProxy.GameType__BackingField).GameVersion__BackingField != EnumGameVersion.None)
						{
							_ = 0;
						}
						continue;
					}
					goto case 24;
				case 19:
					obj += 8;
					obj2 = 2;
					continue;
				}
				break;
			}
			obj = P_0;
			obj = 28;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00Ȁ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778810, new IntPtr(2737367924444L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_0600(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 10222, 1790778805, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778805, new IntPtr(2737367924444L), 15);
		}
		return ((delegate*<object, object>)obj)(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_0700(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778804, new IntPtr(2737367928604L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00ࠀ(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 10224, 1790778807, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778807, new IntPtr(2737367926524L), 15);
		}
		return ((delegate*<object, object, object>)obj)(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_0900(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778806, new IntPtr(2737367927564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_0A00(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778801, new IntPtr(2737367927564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_0B00(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0045: Expected VT, but got Ref
		//IL_0047: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got VT
		//IL_006b: Expected Obj, but got Ref
		//IL_00dc: Expected VT, but got I4
		//IL_00dc: Expected VT, but got Obj
		//IL_00e5: Expected Obj, but got I4
		//IL_00f2: Expected VT, but got I4
		//IL_00cf: Expected I4, but got Obj
		//IL_005b->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00b6->IL00ba: Incompatible stack types: I4 vs Obj
		//IL_0066->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0106->IL00ba: Incompatible stack heights: 6 vs 5
		//IL_00ba->IL00ba: Incompatible stack types: I4 vs Obj
		//IL_0111->IL00ba: Incompatible stack heights: 6 vs 5
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				obj = ((EqualityComparer<_00210>)/*Error near IL_0045: Stack underflow*/).Equals((_00210?)/*Error near IL_0045: Stack underflow*/, (_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
				_ = 3;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					_ = 1;
				}
				break;
			case 1:
				string.Format((IFormatProvider?)/*Error near IL_006b: Stack underflow*/, (string)/*Error near IL_006b: Stack underflow*/, (object?[])Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
				/*Error near IL_006c: Member reference must be method, but was: Field*/;
			case 3:
			{
				EqualityComparer<_00211> equalityComparer = EqualityComparer<_00211>.Default;
				object obj3 = 2;
				while (true)
				{
					switch ((int)obj3)
					{
					case 1:
					{
						bool flag = equalityComparer.Equals((_00211?)obj, (_00211?)2);
						obj = 3;
						obj3 = obj;
						equalityComparer = (EqualityComparer<_00211>)flag;
						break;
					}
					case 2:
						((EqualityComparer<_00211>)obj).GetHashCode((_00211)2);
						_ = 1;
						if ((int)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout == 0)
						{
							_ = 1;
						}
						break;
					case 3:
						/*Error near IL_0113: Member reference must be method, but was: Field*/;
					default:
						_ = 0;
						_ = ((Array)P_1).Length;
						/*Error near IL_0141: Member reference must be method, but was: Field*/;
					}
				}
			}
			case 2:
				return obj;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_0C00(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778800, new IntPtr(2737367927564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_0D00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778803, new IntPtr(2737367927564L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_0E00()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00ༀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778802, new IntPtr(2737367927564L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00က()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778765, new IntPtr(2737367927564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00ᄀ()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}
}
