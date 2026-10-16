using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Network;

public static class VarInt
{
	internal static VarInt DecorateOperationalParameter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetByteSize(int input)
	{
		return (int)_FF00_FF00_FF00_FF00_2B00((uint)input);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HasContinuationBit(byte input)
	{
		return _FF00_FF00_FF00_FF00_2900(input) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ReadVarInt(this IByteBuffer buffer)
	{
		return (int)_FF00_FF00_FF00_FF00_2F00(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ReadVarInt(byte[] buffer)
	{
		return (int)_FF00_FF00_FF00_FF00_3100(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IByteBuffer WriteVarInt(this IByteBuffer buffer, int input)
	{
		return (IByteBuffer)_FF00_FF00_FF00_FF00_2500(buffer, (uint)input);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckVirtualGateway()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static VarInt ReflectIdentifiableProfiler()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_2400(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776608, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_2500(object P_0, uint P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_0060: Expected Obj, but got VT
		//IL_0077: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got VT
		//IL_00f4: Expected Obj, but got VT
		//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008c->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0097->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0104->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
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
				P_1 >>= 7;
				obj2 = 3;
				if ((int)((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field)._003Cuser_id_003Ei__Field != 0)
				{
					obj2 = 1;
				}
				break;
			case 4:
				((object)P_1).ToString();
				_ = 2;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field != 0)
				{
					_ = 1;
				}
				break;
			case 2:
				return P_0;
			default:
				_ = (P_1 & 0x7F) | 0x80;
				/*Error near IL_00a4: Member reference must be method, but was: Field*/;
			case 3:
			case 6:
				if ((P_1 & 0xFFFFFF80u) != 0)
				{
					obj2 = 0;
					if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType3<, >._003Centry_003Ei__Field)._003Csid_003Ei__Field == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_2600(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776611, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_2700()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_2800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776610, new IntPtr(2737368320428L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_2900(byte P_0)
	{
		return ((P_0 & 0x80) == 128) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_2A00(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776637, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint _FF00_FF00_FF00_FF00_2B00(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0061: Expected Obj, but got I4
		//IL_0070: Expected Obj, but got VT
		//IL_0083: Expected I4, but got Obj
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_00d8: Expected Obj, but got VT
		//IL_0075->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0080->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00dd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e8->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 2;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if ((nint)obj < 5)
					{
						break;
					}
					goto end_IL_0026;
				case 2:
					obj = 1;
					obj2 = 1;
					if ((int)((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
					{
						obj2 = 1;
					}
					continue;
				case 4:
					return (uint)(int)obj;
				case 3:
					return 5u;
				case 5:
					break;
				}
				if ((P_0 & (uint)(-1 << obj * 7)) != 0)
				{
					obj++;
					obj2 = 0;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field != 0)
					{
						obj2 = 0;
					}
				}
				else
				{
					obj2 = 1;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
					{
						obj2 = 4;
					}
				}
				continue;
				end_IL_0026:
				break;
			}
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00Ⰰ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776636, new IntPtr(2737368318348L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00_2E00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776639, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00_2F00(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_00f6: Expected VT, but got Obj
		//IL_00f6: Expected VT, but got Ref
		//IL_00f8: Expected Obj, but got I4
		//IL_00ba: Expected I4, but got Obj
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0076: Expected Obj, but got VT
		//IL_011a: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I4
		//IL_010c->IL0026: Incompatible stack heights: 1 vs 2
		//IL_007b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0124->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ac->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0136->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0117->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0086->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f0->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 7;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
			{
				object obj3 = obj;
				_003F val = obj & 0x7F;
				object obj4 = obj;
				obj = obj4 + 1;
				obj = obj3 | (val << ((obj4 * 7) & 0x1F));
				obj2 = 1;
				if ((int)((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
				{
					obj2 = 0;
				}
				break;
			}
			case 7:
				obj = 0;
				obj2 = 4;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field != 0)
				{
					obj2 = 6;
				}
				break;
			case 3:
				return (uint)(int)obj;
			case 5:
				_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
				/*Error near IL_00bf: Member reference must be method, but was: Field*/;
			default:
				obj = ((EqualityComparer<_00212>)/*Error near IL_00f6: Stack underflow*/).Equals((_00212?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00212?)P_0);
				_ = 0;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance == null)
				{
					_ = 4;
				}
				break;
			case 6:
				obj = 0;
				obj2 = 2;
				break;
			case 1:
				if ((nint)obj <= 5)
				{
					if ((int)((_003C_003Ef__AnonymousType1<, , >)obj).name != 0)
					{
						obj2 = 0;
						if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field == 0)
						{
							obj2 = 0;
						}
						break;
					}
					goto case 3;
				}
				obj2 = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00_3000(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776638, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00_3100(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0057: Expected I4, but got Obj
		//IL_00d2: Expected Obj, but got I4
		//IL_00e1: Expected Obj, but got VT
		//IL_0131: Expected VT, but got Ref
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_0086: Expected Obj, but got I4
		//IL_0186: Expected Obj, but got I4
		//IL_0118: Expected I4, but got Obj
		//IL_0073: Expected Obj, but got VT
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_00b6: Expected Obj, but got I4
		//IL_00e6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0183->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0190->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0078->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_012c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0083->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0157->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0162->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 6;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				if ((nint)obj <= 5)
				{
					obj2 = 8;
					if ((int)((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field)._003Cuser_id_003Ei__Field != 0)
					{
						obj2 = 4;
					}
					break;
				}
				goto case 1;
			case 5:
				obj = 0;
				obj2 = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				/*Error near IL_00a5: Member reference must be method, but was: Field*/;
			case 9:
			{
				object obj5 = obj;
				obj = obj5 + 1;
				obj = ((byte[])P_0)[obj5];
				obj2 = 4;
				break;
			}
			default:
				obj = 0;
				obj2 = 4;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
				{
					obj2 = 10;
				}
				break;
			case 7:
				return (uint)(int)obj;
			case 10:
				if ((nint)obj < ((Array)P_0).Length)
				{
					obj2 = 9;
					break;
				}
				goto case 3;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_0131: Stack underflow*/)._002Ector((_003Cname_003Ej__TPar)/*Error near IL_0131: Stack underflow*/, (_003Cuuid_003Ej__TPar)/*Error near IL_0131: Stack underflow*/, (_003Cuser_id_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
				throw new EqualityComparer<_00211>();
			case 8:
				if (((_003C_003Ef__AnonymousType1<, , >)obj).GetHashCode() == 0)
				{
					obj2 = 4;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.StoreConverter == null)
					{
						obj2 = 7;
					}
					break;
				}
				goto case 10;
			case 4:
			{
				object obj3 = obj;
				_003F val = obj & 0x7F;
				object obj4 = obj;
				obj = obj4 + 1;
				obj = obj3 | (val << ((obj4 * 7) & 0x1F));
				obj2 = 2;
				break;
			}
			case 6:
				obj = 0;
				obj2 = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_3200()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_3300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776633, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
