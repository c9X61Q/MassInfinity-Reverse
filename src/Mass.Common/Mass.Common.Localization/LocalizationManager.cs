using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Common.Models;
using Serilog;

namespace Mass.Common.Localization;

public static class LocalizationManager
{
	[CompilerGenerated]
	private static object Culture__BackingField = CultureInfo.CurrentUICulture;

	[CompilerGenerated]
	private static Action<CultureInfo>? m_CultureChanged;

	private static object ReflectAdaptableSingleton;

	public static CultureInfo Culture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			_FF00爀(value);
		}
	}

	public static event Action<CultureInfo>? CultureChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00猀(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00礀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetCulture(CultureInfo culture)
	{
		_FF00渀(culture);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetCulture(string languageTag)
	{
		_FF00漀(languageTag);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EncryptConnection()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LocalizationManager ReflectBasicState()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00椀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778469, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00樀()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ApiResponseBase<>.ManageProvider;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00欀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778468, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00氀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778471, new IntPtr(2737337523164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00洀()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ApiResponseBase<>.ManageProvider == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00渀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0093: Expected Obj, but got VT
		//IL_0098->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00a3->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00be->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d9->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00e4->IL0026: Incompatible stack heights: 3 vs 1
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				/*Error near IL_0049: Member reference must be method, but was: Field*/;
			default:
				/*Error near IL_006e: Member reference must be method, but was: Field*/;
			case 4:
				return;
			case 1:
				ApiResponse.Create();
				_ = 0;
				if (((ErrorResponse)ApiResponseBase<>._003CThen_003Ed__10._003C_003Eu__1).Type__BackingField != null)
				{
					_ = 0;
				}
				break;
			case 2:
				if (ErrorResponse.Title__BackingField == null)
				{
					obj2 = 5;
					break;
				}
				_ = ((AsyncTaskMethodBuilder<_00210>*)P_0)->Task;
				_ = 1;
				if (((ErrorResponse)(object)ErrorResponse.Errors__BackingField).TraceId__BackingField == null)
				{
					_ = 4;
				}
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00漀(object P_0)
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
			/*Error near IL_0039: Member reference must be method, but was: Field*/;
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00瀀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778470, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void _FF00焀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778473, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void _FF00爀(object P_0)
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		ApiResponseBase<>.ManageProvider = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00猀(Action<CultureInfo> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00bd: Expected Obj, but got VT
		//IL_00cc: Expected Obj, but got I
		//IL_0085: Expected native int or pointer, but got Obj
		//IL_00d1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006c->IL0026: Incompatible stack heights: 2 vs 1
		//IL_008f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00dc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0077->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ad->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0102->IL0026: Incompatible stack types: I4 vs Obj
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				_ = ref ApiResponseBase<>.ManageProvider;
				obj = ((IEnumerable<KeyValuePair<string, List<string>>>)obj).Select((Func<KeyValuePair<string, List<string>>, string>)obj);
				_ = 2;
				if (((ApiResponseBase<>._003CThen_003Ed__10)ApiResponseBase<>._003CThen_003Ed__10._003C_003Et__builder).task != null)
				{
					_ = 1;
				}
				break;
			case 4:
				obj = obj;
				obj2 = 0;
				if ((int)((ApiResponseBase<>._003CThen_003Ed__10*)(nint)ApiResponseBase<>._003CThen_003Ed__10._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				if (obj == obj)
				{
					obj2 = 3;
					break;
				}
				goto case 4;
			case 3:
				return;
			default:
				((ApiResponseBase<_00210>)obj).Msg = (string)(object)P_0;
				obj = (object)(Span<string>)/*Error near IL_00b7: Stack underflow*/;
				obj2 = 0;
				if (((ErrorResponse)ErrorResponse.Status__BackingField).Errors__BackingField == null)
				{
					obj2 = 1;
				}
				break;
			case 5:
				obj = ErrorResponse.TraceId__BackingField;
				obj2 = 0;
				if (ErrorResponse._003C_003Ec._003C_003E9 == null)
				{
					obj2 = 4;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00琀(Action<CultureInfo> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778472, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00甀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778475, new IntPtr(2737337520044L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00瘀()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ApiResponseBase<>.ManageProvider;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00眀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778474, new IntPtr(2737337519004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00砀(Action<CultureInfo> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778477, new IntPtr(2737337520044L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00礀(Action<CultureInfo> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_007d: Expected native int or pointer, but got Obj
		//IL_00b6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0102->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006e->IL0026: Incompatible stack types: I4 vs Obj
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				obj = ApiResponseBase<>.ManageProvider;
				obj2 = 2;
				if ((int)((ApiResponseBase<>._003CThen_003Ed__10*)ApiResponseBase<>._003CThen_003Ed__10._003C_003E1__state)->_003C_003Et__builder != 0)
				{
					obj2 = 1;
				}
				break;
			case 4:
				return;
			case 2:
				obj = obj;
				obj2 = 3;
				if (((ApiResponseBase<>._003CThen_003Ed__10*)(nint)ApiResponseBase<>._003CThen_003Ed__10.task)->_003C_003E4__this == null)
				{
					obj2 = 5;
				}
				break;
			case 1:
				Unsafe.As<TaskAwaiter, ILogger>(ref ApiResponseBase<>._003CThen_003Ed__10._003C_003Eu__1).Warning<string>((string)obj, (string)obj);
				obj = (object)/*Error near IL_00a2: Stack underflow*/;
				obj2 = 0;
				if (((ErrorResponse)ErrorResponse.Title__BackingField).Status__BackingField != 0)
				{
					obj2 = 0;
				}
				break;
			case 5:
				/*Error near IL_00c4: Member reference must be method, but was: Field*/;
			default:
				if (obj == obj)
				{
					obj2 = 4;
					break;
				}
				goto case 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00稀(Action<CultureInfo> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778476, new IntPtr(2737337532524L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
