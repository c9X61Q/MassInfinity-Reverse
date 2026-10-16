using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using System.Threading;
using DotNetty.Buffers;
using DotNetty.Codecs;
using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels;
using Mass.Game.Proxy.Enums;

namespace Mass.Game.Proxy.Network;

public static class ByteArray
{
	private static object DecorateLocalPolicy;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] ReadAsBytes(this IByteBuffer buffer, int length)
	{
		return (byte[])_FF00_FF00_FF00_FF00脀(buffer, (uint)length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] ReadAsBytes(this IByteBuffer buffer, EnumProtocolVersion version)
	{
		return (byte[])_FF00_FF00_FF00_FF00簀(buffer, version);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IByteBuffer WriteAsBytes(this IByteBuffer buffer, byte[] input, EnumProtocolVersion version)
	{
		return (IByteBuffer)_FF00_FF00_FF00_FF00蘀(buffer, input, version);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IByteBuffer ReadAsBuffer(this IByteBuffer buffer)
	{
		return (IByteBuffer)_FF00_FF00_FF00_FF00缀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectSymbolicRequester()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ByteArray StopStack()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00笀(object P_0, EnumProtocolVersion P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778053, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00簀(object P_0, EnumProtocolVersion P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0074: Expected Obj, but got I4
		//IL_007e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008f->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				obj = ((_003C_003Ef__AnonymousType0<>)P_0).GetHashCode();
				obj2 = 3;
				continue;
			case 5:
				if (P_1 > EnumProtocolVersion.V1710)
				{
					obj2 = 4;
					continue;
				}
				break;
			case 2:
			case 3:
				return _003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
			case 1:
				break;
			}
			break;
		}
		/*Error near IL_00bd: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00紀(object P_0, EnumProtocolVersion P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778052, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00縀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778055, new IntPtr(2737368305868L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00缀(object P_0)
	{
		//IL_001b: Expected VT, but got Obj
		//IL_001b: Expected VT, but got Obj
		//IL_001b: Expected Obj, but got Ref
		//IL_0020: Expected VT, but got I4
		//IL_0021: Expected Obj, but got I4
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((EqualityComparer<_00210>)/*Error near IL_0020: Stack underflow*/).GetHashCode((_00210)((EqualityComparer<_00210>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals((_00210?)P_0, (_00210?)P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00耀(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778054, new IntPtr(2737368302748L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00脀(object P_0, uint P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0057: Expected I4, but got Obj
		//IL_0106: Expected Obj, but got Ref
		//IL_0106: Expected Obj, but got Ref
		//IL_00f9: Expected Obj, but got I4
		//IL_012e: Expected Obj, but got Ref
		//IL_0176: Expected Obj, but got Ref
		//IL_011a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011a->IL0026: Incompatible stack types: Obj vs Ref
		//IL_00fe->IL0022: Incompatible stack heights: 2 vs 1
		//IL_0142->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0142->IL0026: Incompatible stack types: Obj vs Ref
		//IL_0185->IL0026: Incompatible stack heights: 4 vs 2
		//IL_016f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0125->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0125->IL0026: Incompatible stack types: Obj vs Ref
		//IL_009c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_014d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_014d->IL0026: Incompatible stack types: Obj vs Ref
		//IL_00a7->IL0026: Incompatible stack types: I4 vs Obj
		ref readonly _003Caction_003Ej__TPar reference = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 5;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 4:
					if ((int)P_1 <= (nint)obj)
					{
						obj2 = 1;
						if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 9;
				case 9:
					_ = ref obj;
					_ = 47;
					_ = 2;
					/*Error near IL_00ac: Member reference must be method, but was: Field*/;
				case 6:
					_ = ref obj;
					_003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
					/*Error near IL_00c2: Member reference must be method, but was: Field*/;
				case 8:
					/*Error near IL_00d4: Member reference must be method, but was: Field*/;
				case 5:
					break;
				case 3:
				{
					ServerBootstrap val = ((AbstractBootstrap<ServerBootstrap, IServerChannel>)(object)Unsafe.AsPointer(ref reference)).Option<int>((ChannelOption<int>)(object)(&obj), (int)P_1);
					obj2 = 10;
					reference = ref *(_003Caction_003Ej__TPar*)val;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance == null)
					{
						obj2 = 2;
						reference = ref *(_003Caction_003Ej__TPar*)val;
					}
					continue;
				}
				case 7:
				{
					Action<double, double> action = Interlocked.CompareExchange(ref Unsafe.As<_003Caction_003Ej__TPar, Action<double, double>>(ref reference), (Action<double, double>)(&obj), (Action<double, double>)obj);
					obj2 = 0;
					reference = ref *(_003Caction_003Ej__TPar*)action;
					if ((int)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout != 0)
					{
						obj2 = 0;
						reference = ref *(_003Caction_003Ej__TPar*)action;
					}
					continue;
				}
				case 2:
					return obj;
				default:
					_ = ref obj;
					/*Error near IL_0152: Member reference must be method, but was: Field*/;
				case 1:
					obj = new MessageToByteEncoder<>[P_1];
					obj2 = 8;
					continue;
				case 10:
					_ = ((_003C_003Ef__AnonymousType2<, , , >)(&obj)).user_id;
					_ = EqualityComparer<_00213>.Default;
					_ = 7;
					continue;
				}
				break;
			}
			obj = EqualityComparer<_00212>.Default;
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00舀(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778049, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00茀()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00萀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00蔀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778048, new IntPtr(2737368320428L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00蘀(object P_0, object P_1, EnumProtocolVersion P_2)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_008e: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got Ref
		//IL_009e: Expected Obj, but got VT
		//IL_0055: Expected VT, but got I4
		//IL_00a3->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0060->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00ae->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00d5->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 6;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
			case 5:
				((_003C_003Ef__AnonymousType0<>)P_0)._002Ector((_003Caction_003Ej__TPar)((Array)P_1).Length);
				_ = 2;
				break;
			default:
				string.Format((IFormatProvider?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (string)P_0, (object?[])(short)((Array)P_1).Length);
				_ = 4;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
				{
					_ = 0;
				}
				break;
			case 2:
			case 4:
				/*Error near IL_00b0: Member reference must be method, but was: Field*/;
			case 6:
				if (P_2 > EnumProtocolVersion.V1710)
				{
					obj2 = 5;
					break;
				}
				goto default;
			case 3:
				return P_0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00蜀(object P_0, object P_1, EnumProtocolVersion P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778051, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
