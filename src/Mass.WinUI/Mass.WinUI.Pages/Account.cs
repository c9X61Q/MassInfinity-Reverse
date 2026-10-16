using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using ABI.System.Collections.Generic;
using CommunityToolkit.WinUI.Animations;
using Mass.WinUI.Controls;
using Mass.WinUI.Mass_WinUI_XamlTypeInfo;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Navigation;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
using WinRT.Mass_WinUIVtableClasses;
using WinUI.TableView;

namespace Mass.WinUI.Pages;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mass_WinUI_Pages_MobileWinRTTypeDetails))]
public sealed class Account : Page, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object PageRoot;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object ShowTransitions;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object HideTransitions;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object RandomButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private nint _contentLoaded;

	private static object IncludeTemplate;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe Account()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_004a: Expected I, but got Obj
		//IL_0059: Expected Obj, but got I
		//IL_0070: Expected I, but got Obj
		//IL_005e->IL002d: Incompatible stack heights: 3 vs 2
		//IL_0069->IL002d: Incompatible stack heights: 3 vs 2
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		int num = ExceptionHelpers.GetHRForException((Exception)(object)this);
		int num2 = 2;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)1);
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 2:
				num = (int)IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_0070: Stack underflow*/, (uint)/*Error near IL_0070: Stack underflow*/, (nint)num, (uint*)(nint)this);
				num2 = 1;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnNavigatedTo(NavigationEventArgs e)
	{
		_FF00_FF00_FF00褀(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		_FF00_FF00_FF00輀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		_FF00_FF00_FF00鈀((uint)connectionId, target);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool InvokeAuditor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Account ResetDecider()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe void _FF00_FF00_FF00蠀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778768, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe void _FF00_FF00_FF00褀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0069: Expected I, but got Obj
		//IL_0073: Expected I, but got Obj
		//IL_0082: Expected Obj, but got I
		//IL_0087->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0057->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0092->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0062->IL0026: Incompatible stack heights: 3 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 2:
				ExceptionHelpers.GetHRForException((Exception)P_0);
				_ = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					_ = 1;
				}
				break;
			case 0:
				return;
			case 1:
				/*Error near IL_0069: Stack underflow*/((object[])/*Error near IL_0069: Stack underflow*/, (nint)this);
				IEnumerator_object.Do_Abi_get_Current_0((nint)/*Error near IL_0073: Stack underflow*/, (nint*)(nint)(IReadOnlyList_object)/*Error near IL_006a: Stack underflow*/);
				_ = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe void _FF00_FF00_FF00言(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778769, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00謀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00谀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778782, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00贀()
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
	internal unsafe void _FF00_FF00_FF00輀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00d9: Expected Obj, but got I
		//IL_0106->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00b3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0111->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0088->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00de->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00be->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e9->IL0026: Incompatible stack types: I4 vs Obj
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
			default:
				return;
			case 0:
				return;
			case 2:
				IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized = 1;
				obj2 = 5;
				if (IList_object._initialized != 0)
				{
					obj2 = 5;
				}
				break;
			case 5:
				obj = new IEnumeratorMethods<object>((IntPtr)(int)IEnumerator_object.Do_Abi_get_Current_0((nint)/*Error near IL_0098: Stack underflow*/, (nint*)/*Error near IL_0098: Stack underflow*/));
				obj2 = 0;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					obj2 = 1;
				}
				break;
			case 4:
				return;
			case 3:
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
				{
					return;
				}
				obj2 = 1;
				if (IReadOnlyList_object.ReflectLogicalAttribute == null)
				{
					obj2 = 2;
				}
				break;
			case 1:
				MarshalInterface<INotifyPropertyChanged>.FromAbi((IntPtr)0);
				_ = 4;
				if (IEnumerable_System_IDisposable._initialized == 0)
				{
					_ = 4;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00退()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778783, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00鄀(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778780, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00鈀(uint P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0057: Expected I4, but got Obj
		//IL_0172: Expected I, but got Obj
		//IL_00fe: Expected I, but got Obj
		//IL_0129: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_0186->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0112->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0133->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0088->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0191->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				switch (P_0)
				{
				case 1u:
					goto IL_00b6;
				case 2u:
					goto IL_00f2;
				case 4u:
					goto IL_011d;
				case 3u:
					goto end_IL_0026;
				}
				obj2 = 0;
				if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute != null)
				{
					obj2 = 0;
				}
				continue;
			case 2:
				return;
			case 10:
				goto IL_00b6;
			default:
				IList_object._initialized = 1;
				obj2 = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					obj2 = 2;
				}
				continue;
			case 6:
				goto IL_00f2;
			case 8:
				goto IL_011d;
			case 3:
				break;
				IL_00b6:
				IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute = CastExtensions.As<AppNavigationViewItem>(P_1);
				obj2 = 7;
				continue;
				IL_011d:
				IEnumerator_System_IDisposable._initialized = (nint)((XamlUserType)this).BoxType<SortDirection>(P_1);
				obj2 = 5;
				continue;
				IL_00f2:
				IReadOnlyList_System_IDisposable._initialized = (nint)CastExtensions.As<ImplicitAnimationSet>(P_1);
				obj2 = 2;
				if (IReadOnlyList_object._initialized != 0)
				{
					obj2 = 9;
				}
				continue;
				end_IL_0026:
				break;
			}
			IEnumerable_object._initialized = (nint)((XamlUserType)this).BoxType<DateTime>(P_1);
			obj2 = 0;
			if (GlobalVtableLookup.CreateAttribute != null)
			{
				obj2 = 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00錀(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778781, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
