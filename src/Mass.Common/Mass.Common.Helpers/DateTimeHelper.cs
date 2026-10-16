using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Mass.Common.Models;

namespace Mass.Common.Helpers;

public static class DateTimeHelper
{
	internal static DateTimeHelper DecorateOrderedTransformer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool AlmostEqual(DateTime a, DateTime b, TimeSpan? tolerance = null)
	{
		return _FF00Ḁ(a, b, tolerance) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TimeSpan Parse(string s)
	{
		return _FF00ᨀ(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachTracer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTimeHelper DecorateScopeVisitor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00ༀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778446, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00က()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ApiResponseBase<>.ManageProvider == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static TimeSpan _FF00ᨀ(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0079: Expected Obj, but got I8
		//IL_00aa: Expected VT, but got Obj
		//IL_008a: Expected I4, but got Obj
		//IL_008b: Expected VT, but got Obj
		//IL_0060: Expected native int or pointer, but got Obj
		//IL_01aa: Expected I4, but got Obj
		//IL_01ba: Expected Obj, but got VT
		//IL_01c9: Expected Obj, but got I4
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_0083->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0075->IL0026: Incompatible stack types: I4 vs Obj
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				((SecureCallbackMethodAttribute)P_0)._002Ector();
				((ApiResponse<_00210>)/*Error near IL_004f: Stack underflow*/).Data = (_00210?)/*Error near IL_004f: Stack underflow*/;
				((ApiResponseBase<ApiResponse<_00210>>)/*Error near IL_0054: Stack underflow*/)._002Ector();
				obj = (object)/*Error near IL_0056: Stack underflow*/;
				obj2 = 0;
				if (((ApiResponseBase<>._003CThen_003Ed__10*)(nint)ApiResponseBase<>._003CThen_003Ed__10.task)->_003C_003E4__this != null)
				{
					obj2 = 0;
				}
				break;
			case 1:
				obj = 0;
				obj2 = 4;
				break;
			case 3:
				return (TimeSpan)new ApiResponseBase<_00210>((int)obj);
			case 2:
			{
				_ = ((ApiResponse<>)new ApiResponseBase<_00210>((string)/*Error near IL_0090: Stack underflow*/)).Data;
				Task<_00210> task = ((AsyncTaskMethodBuilder<_00210>*)864000000000L)->Task;
				((ApiResponse<>)(object)task).SetData((T)task);
				_ = 864000000000L;
				/*Error near IL_00b3: Member reference must be method, but was: Field*/;
			}
			default:
				while (true)
				{
					IL_0176:
					((IAsyncStateMachine)/*Error near IL_017d: Stack underflow*/).SetStateMachine((IAsyncStateMachine)obj);
					int num;
					if ((int)/*Error near IL_0182: Stack underflow*/ == 0)
					{
						num = 0;
						if (((BiDictionary<, >)(object)BiDictionary<, >._forward)._reverse != null)
						{
							num = 0;
						}
						goto IL_015c;
					}
					goto IL_01f6;
					IL_01f6:
					obj = (IEnumerable)((KeyValuePair<string, List<string>>*)obj)->Value;
					num = 0;
					if (CryptoJsAes.CustomizeProfile != null)
					{
						num = 1;
					}
					goto IL_015c;
					IL_015c:
					while (true)
					{
						switch (num)
						{
						case 2:
							goto IL_0176;
						case 1:
							((List<string>)obj)._002Ector((int)obj);
							CollectionsMarshal.SetCount<T>((List<T>)/*Error near IL_01b0: Stack underflow*/, 1);
							((ErrorResponse)/*Error near IL_01ba: Stack underflow*/).Title = (string)CollectionsMarshal.AsSpan<T>((List<T>?)/*Error near IL_01b5: Stack underflow*/);
							((Dictionary<string, List<string>>)/*Error near IL_01c3: Stack underflow*/).Add((string)obj, (List<string>)obj);
							((Func<KeyValuePair<string, List<string>>, string>)/*Error near IL_01ce: Stack underflow*/)._002Ector((object)/*Error near IL_01ce: Stack underflow*/, (nint)((Dictionary<string, List<string>>)2).Count);
							obj = /*Error near IL_01d5: Stack underflow*/+ /*Error near IL_01d4: Stack underflow*/* Enumerable.Select<TSource, TResult>((IEnumerable<TSource>)/*Error near IL_01d3: Stack underflow*/, (Func<TSource, TResult>)/*Error near IL_01d3: Stack underflow*/);
							num = 2;
							if (((ConsoleHelper.CONSOLE_FONT_INFO_EX*)ConsoleHelper.CONSOLE_FONT_INFO_EX.FontWeight)->FaceName == null)
							{
								num = 2;
							}
							continue;
						case 3:
							goto IL_01f6;
						}
						break;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static TimeSpan _FF00_1B00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778417, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		return (TimeSpan)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00ᰀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778416, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00ᴀ()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ApiResponseBase<>.ManageProvider;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00Ḁ(DateTime P_0, DateTime P_1, TimeSpan? P_2)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 1:
			/*Error near IL_003a: Member reference must be method, but was: Field*/;
		default:
			_ = ref obj;
			/*Error near IL_0062: Member reference must be method, but was: Field*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static long _FF00_2000(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_009f: Expected I4, but got Obj
		//IL_0230: Expected Obj, but got I8
		//IL_011f: Expected I8, but got Obj
		//IL_0303: Expected Obj, but got I8
		//IL_021a: Expected I8, but got Obj
		//IL_021e: Expected Obj, but got I8
		//IL_0227: Expected Obj, but got I4
		//IL_0326: Expected Obj, but got I8
		//IL_032f: Expected Obj, but got I4
		//IL_00d8: Invalid comparison between Unknown and Obj
		//IL_0173: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I8
		//IL_01ba: Expected Obj, but got I8
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got Unknown
		//IL_0107: Expected native int or pointer, but got Obj
		//IL_00ba: Expected native int or pointer, but got Obj
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected Obj, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected Obj, but got Unknown
		//IL_01b6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_023a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_027a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0317->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0165->IL0026: Incompatible stack types: I4 vs Obj
		//IL_017d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ce->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02e8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0322->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0143->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02fe->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0170->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0396->IL0396: Incompatible stack types: I8 vs Obj
		//IL_02be->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0111->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01d9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_035c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_034b->IL034b: Incompatible stack types: I8 vs Obj
		//IL_03aa->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02c9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0384->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0373->IL0373: Incompatible stack types: I8 vs Obj
		//IL_00cf->IL0026: Incompatible stack types: I4 vs Obj
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 27:
					if ((nint)obj == 30334)
					{
						obj2 = 20;
						if (((ApiResponseBase<>._003CThen_003Ed__10*)(nint)ApiResponseBase<>.ManageProvider)->_003C_003E1__state == 0)
						{
							obj2 = 25;
						}
						continue;
					}
					goto case 8;
				case 13:
				case 19:
				{
					object obj3 = obj;
					((ApiResponseBase<ApiResponse<_00210>>)obj)._002Ector();
					if (Unsafe.As<_003F, UIntPtr>(ref /*Error near IL_00dd: Stack underflow*/) < Unsafe.As<object, UIntPtr>(ref obj3))
					{
						obj2 = 22;
						continue;
					}
					goto case 7;
				}
				case 21:
					obj = 0;
					obj2 = 26;
					continue;
				case 23:
					if ((nint)obj >= 0)
					{
						obj2 = 5;
						if (((ApiResponseBase<>._003CThen_003Ed__10*)(nint)ApiResponseBase<>._003CThen_003Ed__10.task)->_003C_003E4__this == null)
						{
							obj2 = 6;
						}
						continue;
					}
					goto case 12;
				case 3:
					return (long)obj;
				case 8:
					if ((nint)obj == 21315)
					{
						obj2 = 15;
						continue;
					}
					goto case 9;
				case 14:
					((ApiResponseBase<_00210>)(object)ApiResponse.Create<T>()).Msg = (string)obj;
					obj = (object)/*Error near IL_0151: Stack underflow*/;
					obj2 = 18;
					if (((ErrorResponse)ErrorResponse.Title__BackingField).Status__BackingField != 0)
					{
						obj2 = 1;
					}
					continue;
				case 20:
					obj = 0;
					obj2 = 13;
					continue;
				default:
					((AsyncTaskMethodBuilder<_00210>*)obj)->Start<TStateMachine>(ref *(TStateMachine*)obj);
					obj = (object)/*Error near IL_01ac: Stack underflow*/;
					obj2 = 14;
					continue;
				case 24:
					obj = 0;
					obj2 = 4;
					if (ErrorResponse._003C_003Ec._003C_003E9__22_0 != null)
					{
						obj2 = 5;
					}
					continue;
				case 4:
					_ = ref obj;
					/*Error near IL_0200: Member reference must be method, but was: Field*/;
				case 7:
					return (long)(obj + obj);
				case 11:
					obj = 0;
					obj = 9;
					break;
				case 1:
					obj = 2;
					obj2 = 16;
					continue;
				case 5:
					obj = P_0;
					obj2 = 20;
					continue;
				case 18:
					if ((nint)obj == 20004)
					{
						obj2 = 1;
						if (AssemblyHelper.Name__BackingField != null)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 23;
				case 9:
				case 10:
				case 16:
				case 26:
				case 28:
					obj++;
					obj2 = 19;
					continue;
				case 12:
					if ((nint)obj == 21313)
					{
						obj2 = 2;
						continue;
					}
					goto case 27;
				case 6:
					obj = (long)obj;
					obj2 = 23;
					if (AssemblyHelper.Directory__BackingField == null)
					{
						obj2 = 28;
					}
					continue;
				case 17:
					obj = 0;
					obj = 10;
					break;
				case 2:
					obj += ((obj == null) ? ((object)1) : obj) * 10;
					obj2 = 11;
					continue;
				case 25:
					obj += ((obj == null) ? ((object)1) : obj) * 100;
					obj2 = 17;
					continue;
				case 15:
					obj += ((obj != null) ? obj : ((object)1)) * 1000;
					obj2 = 21;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static long _FF00_2100(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778419, new IntPtr(2737337520044L), 15))(null, 0, new IntPtr(0L));
		return (long)/*Error near IL_0033: Stack underflow*/;
	}
}
