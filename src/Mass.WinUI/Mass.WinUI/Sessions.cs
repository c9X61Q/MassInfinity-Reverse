using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Mass.Application.Desktop;
using Mass.Application.Mobile;
using Microsoft.UI.Xaml;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;

namespace Mass.WinUI;

public static class Sessions
{
	internal static Sessions? ViewAttribute;

	public static DesktopSession? DesktopUser
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00嘀(value);
		}
	}

	public static MobileSession? MobileUser
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[MemberNotNullWhen(true, "DesktopUser")]
	public static bool HadDesktopLogin()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[MemberNotNullWhen(true, "MobileUser")]
	public static bool HadMobileLogin()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateSequentialTester()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Sessions? ScanAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00䬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775742, new IntPtr(2737323017436L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00䰀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? _FF00_FF00_FF00_FF00_FF00䴀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775743, new IntPtr(2737323039276L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? _FF00_FF00_FF00_FF00_FF00一()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001a: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? _FF00_FF00_FF00_FF00_FF00伀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		_003CModule_003E obj = _003CModule_003E.CheckAccessibleAttribute();
		return (obj is Application) ? obj : null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? _FF00_FF00_FF00_FF00_FF00倀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775740, new IntPtr(2737323015356L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00儀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0058: Expected I, but got Obj
		//IL_0058: Expected I, but got Obj
		//IL_0067: Expected Obj, but got I
		//IL_006c->IL0026: Incompatible stack heights: 5 vs 1
		//IL_00b1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0077->IL0026: Incompatible stack heights: 5 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				return 1;
			case 2:
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
				_ = IEnumerator_object.Initialized;
				IEnumerator_object.Init();
				IEnumerator_object.Do_Abi_MoveNext_2(unchecked((nint)null), (byte*)unchecked((nint)null));
				_ = 0;
				if (IList_object.PatchAttribute == null)
				{
					_ = 0;
				}
				break;
			default:
				return 0;
			case 3:
				if (!IEnumerator_object.DecorateAutomatableAttribute())
				{
					obj2 = 2;
					break;
				}
				goto case 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00刀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775741, new IntPtr(2737323041356L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00匀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775738, new IntPtr(2737323035116L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00吀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0073: Expected I, but got Obj
		//IL_007f: Expected I, but got Obj
		//IL_007f: Expected I, but got Obj
		//IL_0093->IL0026: Incompatible stack heights: 3 vs 1
		//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009e->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				if (_003CModule_003E.CheckAccessibleAttribute() != null)
				{
					obj2 = 1;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 1;
					}
					break;
				}
				IEnumerator_object.Do_Abi_get_Current_0((nint)/*Error near IL_0078: Stack underflow*/, (nint*)(int)IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_0073: Stack underflow*/, (uint)/*Error near IL_0073: Stack underflow*/, (nint)/*Error near IL_0073: Stack underflow*/, (uint*)(nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute));
				IEnumerator_object.Do_Abi_get_HasCurrent_1(unchecked((nint)null), (byte*)unchecked((nint)null));
				_ = 0;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					_ = 0;
				}
				break;
			default:
				return 0;
			case 1:
				return 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00_FF00唀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775739, new IntPtr(2737323028876L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00_FF00嘀(object? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001a: Expected I, but got Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00_FF00圀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775736, new IntPtr(2737323036156L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? _FF00_FF00_FF00_FF00_FF00堀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775737, new IntPtr(2737323019516L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? _FF00_FF00_FF00_FF00_FF00夀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001a: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}
}
