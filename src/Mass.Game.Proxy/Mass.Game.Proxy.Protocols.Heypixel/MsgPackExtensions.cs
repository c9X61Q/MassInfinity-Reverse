using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using Mass.Application.Event;
using Mass.Game.Proxy.Minecraft.Events;
using MsgPack;

namespace Mass.Game.Proxy.Protocols.Heypixel;

public static class MsgPackExtensions
{
	private static object ReflectMonoContext;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ReadString(this Unpacker unpacker)
	{
		return (string)_FF00_FF00_FF00_FF00쀀(unpacker);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Guid ReadGuid(this Unpacker unpacker, bool encrypt = false)
	{
		return MsgPackExtensions._FF00_FF00_FF00_FF00_FFFD((object)unpacker, encrypt ? ((byte)1) : ((byte)0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static long ReadInt64(this Unpacker unpacker)
	{
		return _FF00_FF00_FF00_FF00툀(unpacker);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ReadInt32(this Unpacker unpacker)
	{
		return (int)_FF00_FF00_FF00_FF00뼀(unpacker);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteString(this Packer packer, string value)
	{
		_FF00_FF00_FF00_FF00묀(packer, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteEncrypted(this Packer packer, Guid password, string value)
	{
		_FF00_FF00_FF00_FF00팀(packer, password, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteGuid(this Packer packer, Guid value, bool encrypt = false)
	{
		_FF00_FF00_FF00_FF00쬀(packer, value, encrypt ? ((byte)1) : ((byte)0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteInt64(this Packer packer, long value)
	{
		_FF00_FF00_FF00_FF00준(packer, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteUInt64(this Packer packer, ulong value)
	{
		MsgPackExtensions._FF00_FF00_FF00_FF00_FFFD((object)packer, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteUInt16(this Packer packer, ushort value)
	{
		_FF00_FF00_FF00_FF00픀(packer, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteDouble(this Packer packer, double value)
	{
		_FF00_FF00_FF00_FF00숀(packer, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteFloat(this Packer packer, float value)
	{
		_FF00_FF00_FF00_FF00씀(packer, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteBool(this Packer packer, bool value)
	{
		_FF00_FF00_FF00_FF00봀(packer, value ? ((byte)1) : ((byte)0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteUInt32(this Packer packer, uint value)
	{
		_FF00_FF00_FF00_FF00휀(packer, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteInt32(this Packer packer, int value)
	{
		_FF00_FF00_FF00_FF00퀀(packer, (uint)value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteByte(this Packer packer, byte value)
	{
		_FF00_FF00_FF00_FF00촀(packer, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteArrayLength(this Packer packer, int length)
	{
		_FF00_FF00_FF00_FF00윀(packer, (uint)length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteArray<T>(this Packer packer, T[] value)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteDictionary<TKey, TValue>(this Packer packer, Dictionary<TKey, TValue> value) where TKey : notnull
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateOrderedMapper()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MsgPackExtensions ReflectVisualPolicy()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00먀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778544, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00묀(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected I4, but got Obj
		//IL_004f: Expected Obj, but got VT
		//IL_0054->IL0026: Incompatible stack heights: 1 vs 2
		//IL_005f->IL0026: Incompatible stack heights: 1 vs 2
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 1:
				((DefaultInterpolatedStringHandler*)P_0)->AppendFormatted((int)P_1);
				_ = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00밀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778547, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00봀(object P_0, byte P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got I4
		//IL_0040: Expected VT, but got Obj
		//IL_0040: Expected Obj, but got Ref
		//IL_0050: Expected Obj, but got VT
		//IL_0055->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0060->IL0026: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				((EqualityComparer<_00210>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals((_00210?)P_0, (_00210?)P_1);
				_ = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00븀(object P_0, byte P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778546, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00뼀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_004e: Expected VT, but got Obj
		//IL_004e: Expected Obj, but got Ref
		//IL_0050: Expected Obj, but got I4
		//IL_0047: Expected VT, but got Ref
		//IL_0047: Expected VT, but got Ref
		//IL_0064->IL0026: Incompatible stack heights: 1 vs 2
		//IL_006f->IL0026: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				return ((EqualityComparer<_00210>)/*Error near IL_0047: Stack underflow*/).Equals((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)(&obj)) ? 1u : 0u;
			case 1:
				obj = ((EqualityComparer<_00210>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).GetHashCode((_00210)P_0);
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field != 0)
				{
					_ = 0;
				}
				break;
			default:
				_ = ref obj;
				/*Error near IL_0072: Member reference must be method, but was: Field*/;
			case 2:
				/*Error near IL_00a1: Member reference must be method, but was: Field*/;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00쀀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 9898, 1790778509, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778509, new IntPtr(2737367941084L), 15);
		}
		return ((delegate*<object, object>)obj)(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00섀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778508, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00숀(object P_0, double P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got F8
		//IL_0040: Expected VT, but got Obj
		//IL_0040: Expected Obj, but got Ref
		//IL_0050: Expected Obj, but got VT
		//IL_0055->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0060->IL0026: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				((EqualityComparer<_00210>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals((_00210?)P_0, (_00210?)P_1);
				_ = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00쌀(object P_0, double P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778511, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00쐀(object P_0, float P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778510, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00씀(object P_0, float P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got F4
		//IL_0040: Expected VT, but got Obj
		//IL_0040: Expected Obj, but got Ref
		//IL_0050: Expected Obj, but got VT
		//IL_0055->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0060->IL0026: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				((EqualityComparer<_00210>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals((_00210?)P_0, (_00210?)P_1);
				_ = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00였(object P_0, float P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778505, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00윀(object P_0, uint P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got I4
		//IL_003f: Expected VT, but got Obj
		//IL_003f: Expected Obj, but got Ref
		//IL_004f: Expected Obj, but got VT
		//IL_0054->IL0026: Incompatible stack heights: 1 vs 2
		//IL_005f->IL0026: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 1:
				((EqualityComparer<_00210>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals((_00210?)P_0, (_00210?)P_1);
				_ = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00저(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778504, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00준(object P_0, long P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got I8
		//IL_0040: Expected VT, but got Obj
		//IL_0040: Expected Obj, but got Ref
		//IL_0050: Expected Obj, but got VT
		//IL_0055->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0060->IL0026: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				((EqualityComparer<_00210>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals((_00210?)P_0, (_00210?)P_1);
				_ = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00쬀(object P_0, Guid P_1, byte P_2)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_004e: Expected VT, but got I4
		//IL_004e: Expected VT, but got I4
		//IL_004e: Expected Obj, but got Ref
		//IL_005e: Expected Obj, but got Ref
		//IL_0063: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_006c: Expected I4, but got Obj
		//IL_006c: Expected Obj, but got Ref
		//IL_00ae: Expected VT, but got Ref
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00c9->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00d4->IL0026: Incompatible stack heights: 1 vs 2
		//IL_009c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a7->IL0026: Incompatible stack types: I4 vs Obj
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
				bool flag = ((EqualityComparer<_00210>)(&obj)).Equals((_00210?)3, (_00210?)2);
				((AsyncTaskMethodBuilder*)(&obj))->Start(ref *(GameProxy._003CListenAsync_003Ed__69*)obj);
				((EventBus)(object)string.Format((IFormatProvider?)P_0, (string)flag, (object?[])((_003C_003Ef__AnonymousType0<>)(&obj)).GetHashCode())).Register((Action<EventConnectServer>)(&obj), (int)obj);
				_ = ref obj;
				/*Error near IL_006e: Member reference must be method, but was: Field*/;
			}
			case 3:
				if (P_2 == 0)
				{
					_ = ref P_1;
					_003C_003Ef__AnonymousType1<, , >.ReflectModularWriter();
					/*Error near IL_00dd: Member reference must be method, but was: Field*/;
				}
				obj2 = 2;
				if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field != 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				return;
			case 2:
				((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_00ae: Stack underflow*/)._002Ector((_003Cname_003Ej__TPar)/*Error near IL_00ae: Stack underflow*/, (_003Cuuid_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_003Cuser_id_003Ej__TPar)P_1);
				obj = (object)/*Error near IL_00ae: Stack underflow*/;
				obj = (object)/*Error near IL_00b5: Stack underflow*/;
				_ = 0;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.StoreConverter != null)
				{
					_ = 0;
				}
				break;
			case 4:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00찀(object P_0, byte P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778507, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00촀(object P_0, byte P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got I4
		//IL_0040: Expected VT, but got Obj
		//IL_0040: Expected Obj, but got Ref
		//IL_0050: Expected Obj, but got VT
		//IL_0055->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0060->IL0026: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				((EqualityComparer<_00210>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals((_00210?)P_0, (_00210?)P_1);
				_ = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00츀(object P_0, byte P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778506, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00케()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00퀀(object P_0, uint P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got I4
		//IL_003f: Expected VT, but got Obj
		//IL_003f: Expected Obj, but got Ref
		//IL_004f: Expected Obj, but got VT
		//IL_0054->IL0026: Incompatible stack heights: 1 vs 2
		//IL_005f->IL0026: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 1:
				((EqualityComparer<_00210>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals((_00210?)P_0, (_00210?)P_1);
				_ = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00턀(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778501, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static long _FF00_FF00_FF00_FF00툀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_004e: Expected VT, but got Obj
		//IL_004e: Expected Obj, but got Ref
		//IL_0050: Expected Obj, but got I4
		//IL_0047: Expected VT, but got Ref
		//IL_0047: Expected VT, but got Ref
		//IL_0048: Expected I8, but got I4
		//IL_0064->IL0026: Incompatible stack heights: 1 vs 2
		//IL_006f->IL0026: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				return ((EqualityComparer<_00210>)/*Error near IL_0047: Stack underflow*/).Equals((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)(&obj)) ? 1 : 0;
			case 1:
				obj = ((EqualityComparer<_00210>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).GetHashCode((_00210)P_0);
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
				{
					_ = 0;
				}
				break;
			default:
				_ = ref obj;
				/*Error near IL_0072: Member reference must be method, but was: Field*/;
			case 2:
				/*Error near IL_00a1: Member reference must be method, but was: Field*/;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00팀(object P_0, Guid P_1, object P_2)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got Obj
		//IL_0040: Expected Obj, but got VT
		//IL_005a->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0065->IL0026: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 1:
				((_003C_003Ef__AnonymousType0<>)P_1)._002Ector((_003Caction_003Ej__TPar)P_2);
				Unsafe.As<_003Caction_003Ej__TPar, AsyncTaskMethodBuilder>(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field).Start(ref *(GameProxy._003CListenAsync_003Ed__69*)P_0);
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00퐀(object P_0, Guid P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778500, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00픀(object P_0, ushort P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got I4
		//IL_0040: Expected VT, but got Obj
		//IL_0040: Expected Obj, but got Ref
		//IL_0050: Expected Obj, but got VT
		//IL_0055->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0060->IL0026: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				((EqualityComparer<_00210>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals((_00210?)P_0, (_00210?)P_1);
				_ = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00혀(object P_0, ushort P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778503, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00휀(object P_0, uint P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got I4
		//IL_0040: Expected VT, but got Obj
		//IL_0040: Expected Obj, but got Ref
		//IL_0050: Expected Obj, but got VT
		//IL_0055->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0060->IL0026: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				((EqualityComparer<_00210>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals((_00210?)P_0, (_00210?)P_1);
				_ = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Guid _FF00_FF00_FF00_FF00_FFFD(object P_0, byte P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778502, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (Guid)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Guid _FF00_FF00_FF00_FF00_FFFD(object P_0, byte P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003e: Expected VT, but got Obj
		//IL_003e: Expected Obj, but got Ref
		//IL_0044: Expected VT, but got I4
		//IL_004f: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got Ref
		//IL_0050: Expected VT, but got Obj
		//IL_0065: Expected Obj, but got VT
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0075->IL0026: Incompatible stack types: I4 vs Obj
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
				((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)P_0);
				return (Guid)((_003C_003Ef__AnonymousType0<>)/*Error near IL_0043: Stack underflow*/).Equals((object)/*Error near IL_0043: Stack underflow*/);
			case 1:
				if (P_1 == 0)
				{
					return (Guid)string.Format((IFormatProvider?)/*Error near IL_004f: Stack underflow*/, (string)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (object?[])((_003C_003Ef__AnonymousType0<>)P_0).GetHashCode());
				}
				obj2 = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778497, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00_FFFD(object P_0, ulong P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778496, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00_FFFD(object P_0, ulong P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got I8
		//IL_0040: Expected VT, but got Obj
		//IL_0040: Expected Obj, but got Ref
		//IL_0050: Expected Obj, but got VT
		//IL_0055->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0060->IL0026: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				((EqualityComparer<_00210>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals((_00210?)P_0, (_00210?)P_1);
				_ = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					_ = 0;
				}
				break;
			}
		}
	}
}
