using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Mass.Common.Localization;
using Mass.Common.Models;

namespace Mass.Common.Helpers;

public static class ConsoleHelper
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct CONSOLE_FONT_INFO_EX
	{
		public uint cbSize;

		public uint nFont;

		public COORD dwFontSize;

		public int FontFamily;

		public int FontWeight;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string FaceName;
	}

	private struct COORD
	{
		public short X;

		public short Y;
	}

	internal static ConsoleHelper DecorateIntegratedDecryptor;

	[DllImport("kernel32.dll")]
	private static extern nint GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern int SetWindowLongPtr(nint hWnd, int nIndex, int dwNewLong);

	[DllImport("user32.dll")]
	private static extern int GetWindowLongPtr(nint hWnd, int nIndex);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern nint GetStdHandle(int hConsoleHandle);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool GetCurrentConsoleFontEx(nint hConsoleOutput, bool bMaximumWindow, ref CONSOLE_FONT_INFO_EX lpConsoleCurrentFontEx);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool SetCurrentConsoleFontEx(nint hConsoleOutput, bool bMaximumWindow, ref CONSOLE_FONT_INFO_EX lpConsoleCurrentFontEx);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool GetConsoleMode(nint hConsoleHandle, out uint mode);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool SetConsoleMode(nint hConsoleHandle, uint mode);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DisabledSizeMode()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetFontSize(short x = 8, short y = 16)
	{
		_FF00㐀((ushort)x, (ushort)y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DisableQuickEditMode()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetSize(int width = 160, int height = 40)
	{
		_FF00_3000((uint)width, (uint)height);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetTitle(string title)
	{
		_FF00㴀(title);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Init(bool isDevelopment = false)
	{
		_FF00㬀(isDevelopment ? ((byte)1) : ((byte)0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckLocalError()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ConsoleHelper ChangeCollection()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_2F00(uint P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778462, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_3000(uint P_0, uint P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0050: Expected native int or pointer, but got Obj
		//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
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
			case 4:
				return;
			case 1:
				_ = ApiResponseBase<>._003CThen_003Ed__10._003C_003Et__builder;
				/*Error near IL_006a: Member reference must be method, but was: Field*/;
			case 3:
				return;
			case 2:
				/*Error near IL_00be: Member reference must be method, but was: Field*/;
			}
			obj2 = 2;
			if (((ApiResponseBase<>._003CThen_003Ed__10*)(nint)ApiResponseBase<>.ManageProvider)->_003C_003E1__state == 0)
			{
				obj2 = 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_3100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778433, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_3200()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0049: Expected Obj, but got I4
		//IL_0051: Expected Obj, but got Ref
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_006b: Expected native int or pointer, but got Obj
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		switch ((int)obj)
		{
		case 0:
			break;
		case 1:
		{
			((SecureCallbackMethodAttribute)(-10))._002Ector();
			/*Error near IL_0049: Stack underflow*/;
			((NonSecureAttribute)(&obj))._002Ector();
			obj &= -65;
			((NonHVMProxyAttribute)obj)._002Ector();
			int num = 0;
			if (((ApiResponseBase<>._003CThen_003Ed__10*)(nint)ApiResponseBase<>._003CThen_003Ed__10.task)->_003C_003E4__this != null)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
			break;
		}
		case 3:
			_ = ErrorResponse.Errors__BackingField;
			/*Error near IL_00f2: Member reference must be method, but was: Field*/;
		case 2:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_3300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778432, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00㐀(ushort P_0, ushort P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0057: Expected I4, but got Obj
		//IL_00fb: Expected VT, but got Obj
		//IL_0100: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got Ref
		//IL_0129: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I
		//IL_01b3: Expected Obj, but got Ref
		//IL_0077: Expected VT, but got I4
		//IL_0088: Expected native int or pointer, but got Obj
		//IL_0114->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0134->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01c8->IL0026: Incompatible stack heights: 2 vs 1
		//IL_018a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0150->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a9->IL0026: Incompatible stack heights: 2 vs 1
		//IL_016e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01d3->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0195->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f2->IL0026: Incompatible stack types: I4 vs Obj
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 7;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 5:
				return;
			case 4:
				if ((nint)((ErrorResponse)((ErrorResponse)obj).Status__BackingField).Errors__BackingField == (int)P_1)
				{
					obj2 = 5;
					if (ErrorResponse.FlushFilter == null)
					{
						obj2 = 1;
					}
					break;
				}
				goto IL_005d;
			case 1:
				ErrorResponse._003C_003Ec._003C_003E9__22_0 = (Func<KeyValuePair<string, List<string>>, string>)Marshal.SizeOf((CONSOLE_FONT_INFO_EX)obj);
				obj2 = 9;
				if (LocalizationManager.Culture__BackingField != null)
				{
					obj2 = 8;
				}
				break;
			case 3:
				((ApiResponseBase<>)obj).Error((string)0, (int)(&obj));
				obj2 = 8;
				break;
			case 2:
				if ((nint)((ResourceLocalizer)LocalizationManager.ReflectAdaptableSingleton)._003CresourceManager_003EP == (int)P_0)
				{
					obj2 = 4;
					break;
				}
				goto IL_005d;
			case 7:
				((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_015f: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_015f: Stack underflow*/, ref *(((TaskAwaiter*)ResourceLocalizer.InitAuthorizer)->IsCompleted ? ((TStateMachine*)1) : ((TStateMachine*)null)));
				if ((int)/*Error near IL_0164: Stack underflow*/ != 0)
				{
					return;
				}
				obj2 = 6;
				break;
			case 10:
				*(FileHelper._003CReadAllBytesAsync_003Ed__11*)(&obj) = default;
				obj2 = 1;
				if (AssemblyHelper.Directory__BackingField != null)
				{
					obj2 = 1;
				}
				break;
			case 0:
				return;
			case 6:
				_ = -11;
				obj = ApiResponseBase<>._003CThen_003Ed__10.CheckOrderedMap();
				_ = 10;
				break;
			case 9:
				_ = 0;
				((ErrorResponse)(&obj))._002Ector();
				_ = 2;
				if (BiDictionary<, >.ExecuteViewer != null)
				{
					_ = 1;
				}
				break;
			case 8:
				return;
				IL_005d:
				obj = new NonSecureAttribute
				{
					_003C_003E1__state = P_0,
					_003C_003Et__builder = (AsyncTaskMethodBuilder<TSelf>)P_1
				};
				((ApiResponseBase<>._003CThen_003Ed__10*)(&obj))->task = (Task)obj;
				obj2 = 2;
				if ((int)((ApiResponseBase<>._003CThen_003Ed__10*)(nint)ApiResponseBase<>._003CThen_003Ed__10._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					obj2 = 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00㔀(ushort P_0, ushort P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778435, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00㘀()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0056: Expected VT, but got Obj
		//IL_006a: Expected native int or pointer, but got Obj
		//IL_00ca: Expected VT, but got I4
		//IL_00db: Expected VT, but got I4
		//IL_004c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0074->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007f->IL0026: Incompatible stack types: I4 vs Obj
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
			default:
				return;
			case 1:
				return;
			case 2:
				((ApiResponse<_00210>)/*Error near IL_0056: Stack underflow*/).Data = (_00210?)ApiResponseBase<>.ManageProvider;
				((ApiResponseBase<ApiResponse<_00210>>)/*Error near IL_005b: Stack underflow*/)._002Ector();
				if ((int)/*Error near IL_0060: Stack underflow*/ == 0)
				{
					obj2 = 3;
					break;
				}
				obj2 = 1;
				if (((ApiResponseBase<>._003CThen_003Ed__10*)(nint)ApiResponseBase<>._003CThen_003Ed__10.task)->_003C_003E4__this == null)
				{
					obj2 = 1;
				}
				break;
			case 0:
				return;
			case 3:
			{
				obj = ApiResponse.Create<T>();
				int num = 1;
				if (((ErrorResponse)ErrorResponse.Type__BackingField).Title__BackingField != null)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 0:
						return;
					case 1:
					{
						object obj3 = obj;
						((ApiResponse<>)obj).Data = (T?)(-16);
						((ApiResponse<>)obj3).SetData((T)(-262160 & -65537));
						num = 0;
						if (ErrorResponse.FlushFilter != null)
						{
							num = 0;
						}
						break;
					}
					}
				}
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00㜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778434, new IntPtr(2737337532524L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00㠀()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ApiResponseBase<>.ManageProvider == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00㨀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778437, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00㬀(byte P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_0078: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got VT
		//IL_005c: Expected VT, but got Obj
		//IL_00bc: Expected Obj, but got I4
		//IL_00df->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0082->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a2->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00ea->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ad->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0113->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011e->IL0026: Incompatible stack heights: 2 vs 1
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
				case 1:
					return;
				case 2:
					return;
				case 3:
					((ApiResponse<_00210>)/*Error near IL_005c: Stack underflow*/).Data = (_00210?)ApiResponseBase<>.ManageProvider;
					((ApiResponseBase<ApiResponse<_00210>>)/*Error near IL_0061: Stack underflow*/)._002Ector();
					if ((int)/*Error near IL_0066: Stack underflow*/ != 0)
					{
						obj2 = 6;
						break;
					}
					_ = ((ApiResponseBase<>)/*Error near IL_00ff: Stack underflow*/).Code;
					_ = 5;
					if (ErrorResponse._003C_003Ec._003C_003E9__22_0 == null)
					{
						_ = 0;
					}
					break;
				case 5:
					_ = 8;
					((NonDVMAttribute)16)._002Ector();
					_ = 7;
					break;
				case 7:
					_ = 160;
					_ = 40;
					ApiResponse.Create();
					_ = 0;
					if (((ErrorResponse)ApiResponseBase<>._003CThen_003Ed__10._003C_003Eu__1).Type__BackingField != null)
					{
						_ = 0;
					}
					break;
				case 4:
					if (P_0 != 0)
					{
						return;
					}
					goto end_IL_0026;
				default:
					((ApiResponse<>)/*Error near IL_00cb: Stack underflow*/).Data = ((ApiResponse<>)/*Error near IL_00c6: Stack underflow*/).Data;
					obj2 = 0;
					if (((ErrorResponse)(object)ErrorResponse.Errors__BackingField).TraceId__BackingField == null)
					{
						obj2 = 1;
					}
					break;
				case 6:
					return;
				}
				continue;
				end_IL_0026:
				break;
			}
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00㰀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778436, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00㴀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00cc: Expected Obj, but got VT
		//IL_0101->IL0026: Incompatible stack types: I4 vs Obj
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
			default:
				return;
			case 3:
				/*Error near IL_0046: Member reference must be method, but was: Field*/;
			case 2:
				((ApiResponseBase<_00210>)/*Error near IL_00cc: Stack underflow*/).Msg = (string)ApiResponseBase<>._003CThen_003Ed__10._003C_003Eu__1;
				/*Error near IL_00cc: Member reference must be method, but was: Field*/;
			case 0:
				return;
			case 1:
				break;
			case 4:
				return;
			}
			obj2 = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00㸀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778439, new IntPtr(2737337532524L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00㼀()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ApiResponseBase<>.ManageProvider;
	}
}
