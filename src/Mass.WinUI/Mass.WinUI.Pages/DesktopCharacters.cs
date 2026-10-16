using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using System.Threading;
using ABI.System.Collections.Generic;
using CommunityToolkit.WinUI.Controls;
using Mass.WinUI.Helpers;
using Mass.WinUI.Mass_WinUI_XamlTypeInfo;
using Mass.WinUI.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.Xaml.Interactivity;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.Pages;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mass_WinUI_Pages_MobileWinRTTypeDetails))]
public sealed class DesktopCharacters : CharacterPageBase, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object ShowTransitions;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object HideTransitions;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object segmentedControl;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object TargetImage;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object SoHeroElement;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object LaunchButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object ShadowButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object ViewportBehavior;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private nint _contentLoaded;

	private static object DecorateSortedChooser;

	protected override Image HeroImage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (Image)_FF00_FF00_FF00_FFFD();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe DesktopCharacters()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_005b: Expected I, but got Obj
		//IL_005b: Expected I, but got Obj
		//IL_006a: Expected Obj, but got I
		//IL_006f->IL0042: Incompatible stack types: I4 vs Obj
		//IL_007a->IL0042: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		_003CModule_003E obj = _003CModule_003E.CheckAccessibleAttribute();
		int num = 0;
		if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			uint num2 = IEnumerator_object.Do_Abi_MoveNext_2((nint)obj, (byte*)(nint)this);
			num = 1;
			obj = (_003CModule_003E)num2;
			if (IList_object.PatchAttribute == null)
			{
				num = 0;
				obj = (_003CModule_003E)num2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StackPanelLoaded(object sender, object e)
	{
		_FF00_FF00_FF00_FFFD(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		_FF00_FF00_FF00_E000();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		_FF00_FF00_FF00_E300((uint)connectionId, target);
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateCombinedSolver()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DesktopCharacters PushConverter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00혀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778685, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00휀()
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
	internal unsafe static object _FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778682, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FFFD(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_00ef: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I
		//IL_00b1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008f->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00cc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ff->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0125->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009a->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00d7->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 5:
				return;
			case 1:
				return;
			case 4:
				obj = MarshalInspectable<object>.FromAbiArray((object)this) as IEnumerable_System_IDisposable;
				obj2 = 3;
				break;
			case 6:
				if (obj != null)
				{
					IEnumerator_object.Init();
					_ = 3;
					if (IList_object._initialized == 0)
					{
						_ = 5;
					}
				}
				else
				{
					obj2 = 1;
					if (IReadOnlyList_System_IDisposable._initialized != 0)
					{
						obj2 = 1;
					}
				}
				break;
			case 2:
				return;
			default:
				obj = ((P_0 is DependencyObject) ? P_0 : null);
				obj2 = 6;
				if (IReadOnlyList_object.ReflectLogicalAttribute != null)
				{
					obj2 = 2;
				}
				break;
			case 3:
				if (obj == null)
				{
					return;
				}
				obj2 = 0;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FFFD(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778683, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FFFD()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe object _FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778680, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe object _FF00_FF00_FF00_FFFD()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe object _FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778681, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_E000()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_005f: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I4
		//IL_00c9->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d4->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00ac->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009a->IL0026: Incompatible stack types: I4 vs Obj
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
			case 4:
				obj = new IEnumeratorMethods<object>((IntPtr)/*Error near IL_004e: Stack underflow*/, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute());
				obj2 = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					obj2 = 0;
				}
				break;
			case 1:
				return;
			case 3:
				if (IList_object._initialized != 0)
				{
					obj2 = 0;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 2;
					}
				}
				else
				{
					IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute = 1;
					obj2 = 4;
				}
				break;
			case 2:
				return;
			default:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)0);
				_ = 1;
				if (IReadOnlyList_object._initialized != 0)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_E100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778630, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_E200(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778631, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_E300(uint P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0083: Expected I4, but got Obj
		//IL_00dd: Expected Obj, but got I
		//IL_01ee: Expected Obj, but got I
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected I, but got Unknown
		//IL_01fc: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I
		//IL_027e: Expected Obj, but got I4
		//IL_0142: Expected Obj, but got I
		//IL_00e2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0221->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0201->IL0022: Incompatible stack heights: 2 vs 0
		//IL_01c2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0288->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0147->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02e7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0168->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ed->IL0026: Incompatible stack types: I4 vs Obj
		//IL_022c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01cd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0152->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0118->IL0026: Incompatible stack types: I4 vs Obj
		//IL_024a->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 16;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 10:
					((AsyncVoidMethodBuilder*)/*Error near IL_008f: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)this, ref *(App._003CLogout_003Ed__15*)P_1);
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = (object)/*Error near IL_0094: Stack underflow*/;
					obj2 = 3;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
					{
						obj2 = 1;
					}
					continue;
				default:
					IList_object.PatchAttribute = CastExtensions.As<InvokeCommandAction>(P_1);
					obj2 = 12;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
					{
						obj2 = 3;
					}
					continue;
				case 15:
					switch (P_0)
					{
					case 19u:
						break;
					default:
						goto IL_010e;
					case 18u:
						goto IL_0152;
					case 15u:
						goto IL_018c;
					case 14u:
						goto end_IL_0026;
					case 17u:
						goto IL_0201;
					case 16u:
						goto end_IL_0026_2;
					}
					goto default;
				case 13:
					goto IL_0127;
				case 21:
					goto IL_0152;
				case 18:
					goto IL_018c;
				case 9:
					goto IL_01a2;
				case 8:
					goto end_IL_0026;
				case 1:
					goto IL_0201;
				case 16:
					switch (P_0)
					{
					case 4u:
						break;
					case 2u:
						goto IL_0127;
					case 3u:
						goto IL_01a2;
					default:
						goto IL_0240;
					}
					goto case 10;
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 11:
				case 12:
				case 14:
				case 17:
				case 20:
					Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute = 1;
					obj2 = 7;
					continue;
				case 7:
					return;
				case 19:
					break;
					IL_0240:
					obj2 = 15;
					continue;
					IL_01a2:
					Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute = Interlocked.CompareExchange(ref *(Func<InfoBarDelegate>*)/*Error near IL_01a9: Stack underflow*/, (Func<InfoBarDelegate>)(object)this, (Func<InfoBarDelegate>)P_1);
					obj2 = 3;
					if (Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute != null)
					{
						obj2 = 5;
					}
					continue;
					IL_010e:
					obj2 = 6;
					continue;
					IL_0127:
					IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = CastExtensions.As<Segmented>(P_1);
					obj2 = 20;
					if (IReadOnlyList_object.ReflectLogicalAttribute != null)
					{
						obj2 = 10;
					}
					continue;
					IL_0201:
					((AsyncTaskMethodBuilder*)this)->Start(ref *(AccountViewModel._003CExportAccounts_003Ed__26*)P_1);
					Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute = (object)/*Error near IL_020d: Stack underflow*/;
					obj2 = 3;
					if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute == null)
					{
						obj2 = 17;
					}
					continue;
					IL_018c:
					IEnumerable_object.ReflectSetAttribute = ((XamlUserType)(object)this).BoxType<double>(P_1);
					obj2 = 2;
					continue;
					IL_0152:
					IEnumerator_System_IDisposable.ReflectTransferableAttribute = ((XamlUserType)(object)this).BoxType<EasingMode>(P_1);
					obj2 = 11;
					continue;
					end_IL_0026_2:
					break;
				}
				((AsyncTaskMethodBuilder*)this)->Start(ref *(AccountViewModel._003CLoginDesktop_003Ed__87*)P_1);
				_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator = (object)/*Error near IL_02dd: Stack underflow*/;
				obj2 = 14;
				continue;
				end_IL_0026:
				break;
			}
			((AsyncTaskMethodBuilder*)/*Error near IL_01e2: Stack underflow*/)->Start(ref *(AccountViewModel._003CEditAccount_003Ed__22*)P_1);
			MarshalInspectable<object>.FromAbi(new MarshalInterface<IReadOnlyList<object>>((IReadOnlyList<object>)(delegate*<bool>)(&IEnumerable_System_ComponentModel_INotifyPropertyChanged.DecorateSeparatedAttribute)));
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_E400(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778628, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
