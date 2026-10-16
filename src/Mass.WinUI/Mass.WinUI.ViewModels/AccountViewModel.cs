using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using System.Threading;
using ABI.Microsoft.UI.Composition;
using ABI.Microsoft.UI.Xaml;
using ABI.Microsoft.UI.Xaml.Controls;
using ABI.Microsoft.UI.Xaml.Markup;
using ABI.System;
using ABI.System.Collections;
using ABI.System.Collections.Generic;
using ABI.System.Collections.Specialized;
using ABI.System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.WinUI.Animations;
using CommunityToolkit.WinUI.Controls;
using CommunityToolkit.WinUI.Converters;
using CommunityToolkit.WinUI.Media;
using DevWinUI;
using FluentIcons.WinUI;
using Mass.Application.Desktop;
using Mass.Application.Mobile;
using Mass.Application.Services;
using Mass.Domain.Entities.Mass;
using Mass.Domain.Mobile.Entities.RentalGame;
using Mass.WinUI.Controls;
using Mass.WinUI.Enums;
using Mass.WinUI.Helpers;
using Mass.WinUI.Mass_WinUI_XamlTypeInfo;
using Mass.WinUI.Models;
using Mass.WinUI.Models.Messages;
using Mass.WinUI.Pages;
using Matrix.Core.Managers;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.Windows.ApplicationModel.WindowsAppRuntime.Common;
using Microsoft.Windows.Foundation.UndockedRegFreeWinRTCS;
using Microsoft.Xaml.Interactivity;
using Serilog;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
using WinRT.Mass_WinUIVtableClasses;
using WinUI.TableView;
using Windows.Foundation;

namespace Mass.WinUI.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails))]
public class AccountViewModel : ObservableObject
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateAccount_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AccountViewModel _003C_003E4__this;

		private TaskAwaiter<ContentDialogResult> _003C_003Eu__1;

		internal static object? PrepareMap;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CheckGeneralElement()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? ReflectExtendedDriver()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_F000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777784, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_F100()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_004e: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I
			//IL_0075: Expected Obj, but got Ref
			//IL_0086: Expected Obj, but got I
			//IL_02f8: Expected Obj, but got Ref
			//IL_02e8: Expected Obj, but got I4
			//IL_02e8: Expected Obj, but got Ref
			//IL_0222: Expected Obj, but got Ref
			//IL_00ad: Expected Obj, but got I
			//IL_01d0: Expected Obj, but got I4
			//IL_01d5: Expected Obj, but got I4
			//IL_01d5: Expected Obj, but got Ref
			//IL_0101: Expected Obj, but got Ref
			//IL_0116: Expected Obj, but got I
			//IL_0152: Expected Obj, but got I4
			//IL_0157: Expected Obj, but got I4
			//IL_0157: Expected Obj, but got Ref
			//IL_0169: Expected I, but got Obj
			//IL_0169: Expected Obj, but got Ref
			//IL_020b: Expected I4, but got Obj
			//IL_0210: Expected Obj, but got I4
			//IL_0179: Expected Obj, but got Ref
			//IL_0181: Expected Obj, but got Ref
			//IL_0181: Expected Obj, but got Ref
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0311->IL0026: Incompatible stack heights: 2 vs 1
			//IL_02f2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
			//IL_031c->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0195->IL00c1: Incompatible stack heights: 2 vs 1
			//IL_01a0->IL00c1: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				default:
					obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					obj2 = 2;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 1;
					}
					break;
				case 1:
					obj = IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute;
					obj2 = 0;
					if (IList_object.PatchAttribute != null)
					{
						obj2 = 0;
					}
					break;
				case 2:
					if (obj != null)
					{
						num = 4;
						if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
						{
							num = 10;
						}
						goto IL_00c1;
					}
					goto IL_021c;
				case 3:
					return;
				case 5:
					goto IL_02e0;
				case 4:
					{
						IReadOnlyListMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_02fd: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_02fd: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_02fd: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)Unsafe.AsPointer(ref __KnownINotifyPropertyChangingArgs.CreateAt));
						_ = 0;
						if (__KnownINotifyPropertyChangingArgs.IsMyself != null)
						{
							_ = 3;
						}
						break;
					}
					IL_02e0:
					__KnownINotifyPropertyChangingArgs.Username = (PropertyChangingEventArgs)(-2);
					obj2 = 4;
					break;
					IL_021c:
					obj = Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute;
					num = 4;
					goto IL_00c1;
					IL_00c1:
					while (true)
					{
						switch (num)
						{
						default:
							return;
						case 4:
							IReadOnlyList_System_IDisposable._initialized = unchecked((nint)null);
							num = 1;
							if (IReadOnlyList_object.ReflectLogicalAttribute == null)
							{
								num = 1;
							}
							continue;
						case 3:
						case 6:
							MarshalInterface<INotifyPropertyChanged>.FromAbi((IntPtr)(nint)(&obj));
							num = 5;
							if (IEnumerable_System_IDisposable._initialized == 0)
							{
								num = 8;
							}
							continue;
						case 5:
							obj = 0;
							IEnumerable_System_IDisposable.CombineAttribute = 0;
							num = 7;
							continue;
						case 7:
							IEnumerable_object._initialized = (nint)obj;
							num = 11;
							continue;
						case 11:
							Interlocked.CompareExchange(ref Unsafe.As<object, Func<InfoBarDelegate>>(ref IEnumerable_object.ReflectSetAttribute), (Func<InfoBarDelegate>)(&obj), (Func<InfoBarDelegate>)Unsafe.AsPointer(ref this));
							_ = 0;
							if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute == null)
							{
								_ = 0;
							}
							continue;
						case 2:
							if (IListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_01a7: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_01a7: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)/*Error near IL_01a7: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_01a7: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_01a7: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_01a7: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int>)/*Error near IL_01a7: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, int>)/*Error near IL_01a7: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_01a7: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_01a7: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_01a7: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, int>)(&obj)))
							{
								num = 6;
								if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute == null)
								{
									num = 4;
								}
								continue;
							}
							goto case 5;
						case 1:
							obj = -1;
							Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute = -1;
							num = 3;
							continue;
						case 10:
							obj = Interlocked.CompareExchange(ref *(Action*)/*Error near IL_0210: Stack underflow*/, (Action)/*Error near IL_0210: Stack underflow*/, (Action)IList_object.Do_Abi_GetAt_0((nint)/*Error near IL_020b: Stack underflow*/, (uint)(int)obj, (nint*)null));
							num = 2;
							continue;
						case 9:
							break;
						case 0:
							return;
						case 8:
							goto IL_02e0;
						}
						break;
					}
					goto IL_021c;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_F200()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777785, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_F300()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00_F400()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777734, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00_F500()
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
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00_F600()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777735, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_F700(object? P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0054: Expected Obj, but got I
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)(nint)Unsafe.AsPointer(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized), ref *(object[]*)P_0);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_F800(object? P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777732, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEditAccount_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AccountModel accountModel;

		private TaskAwaiter<(bool IsConfirmed, string Text)> _003C_003Eu__1;

		internal static object? DecorateVisibleWriter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DecorateCentralDic()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? CheckStatelessObject()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_E900()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777733, new IntPtr(2737335729916L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_EA00()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Expected I4, but got Obj
			//IL_004b: Expected Obj, but got Ref
			//IL_004d: Expected Obj, but got I
			//IL_0074: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got Ref
			//IL_0084: Expected Obj, but got Ref
			//IL_0089: Expected Obj, but got Ref
			//IL_0098: Expected Obj, but got I
			//IL_02a6: Expected Obj, but got I4
			//IL_02a8: Expected Obj, but got I
			//IL_014f: Expected Obj, but got Ref
			//IL_0164: Expected Obj, but got I
			//IL_01a1: Expected Obj, but got Ref
			//IL_01a9: Expected Obj, but got Ref
			//IL_01a9: Expected Obj, but got Ref
			//IL_0246: Expected Obj, but got I4
			//IL_024b: Expected Obj, but got I4
			//IL_024b: Expected Obj, but got Ref
			//IL_013a: Expected Obj, but got Ref
			//IL_0112: Expected Obj, but got Ref
			//IL_0114: Expected Obj, but got I
			//IL_017c: Expected I, but got Obj
			//IL_017c: Expected Obj, but got Ref
			//IL_02db: Expected Obj, but got I4
			//IL_02e0: Expected Obj, but got I4
			//IL_02e0: Expected Obj, but got Ref
			//IL_0230: Expected Obj, but got Ref
			//IL_0237: Expected I, but got Obj
			//IL_0237: Expected I4, but got Obj
			//IL_0237: Expected I, but got Obj
			//IL_0061->IL0026: Incompatible stack types: I4 vs Obj
			//IL_007e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009d->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00ba->IL00be: Incompatible stack heights: 1 vs 5
			//IL_006c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a8->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0107->IL0279: Incompatible stack heights: 4 vs 0
			//IL_01bd->IL00be: Incompatible stack heights: 7 vs 5
			//IL_0241->IL00be: Incompatible stack types: I4 vs Obj
			//IL_01c8->IL00be: Incompatible stack heights: 7 vs 5
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				IList_object list_object;
				int num;
				switch ((int)obj2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					obj2 = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 1;
					}
					break;
				case 3:
					IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute = -2;
					obj2 = 4;
					break;
				case 4:
					MarshalInspectable<object>.FromAbiArray((object)Unsafe.AsPointer(ref IList_object._initialized));
					_ = 0;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
					{
						_ = 0;
					}
					break;
				case 1:
					{
						if (obj == null)
						{
							_ = 10;
							goto IL_00be;
						}
						goto IL_0279;
					}
					IL_0279:
					IList_object.Do_Abi_ReplaceAll_11((nint)/*Error near IL_0288: Stack underflow*/, (uint)/*Error near IL_0288: Stack underflow*/, (nint)(int)IList_object.Do_Abi_GetMany_10((nint)/*Error near IL_0283: Stack underflow*/, (uint)/*Error near IL_0283: Stack underflow*/, (uint)/*Error near IL_0283: Stack underflow*/, (nint)/*Error near IL_0283: Stack underflow*/, (uint*)(_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout ? 1 : 0)));
					_ = __KnownINotifyPropertyChangingArgs.UserId;
					IList_object._002Ecctor();
					IList_object.AttachAttribute();
					list_object = IList_object.ReflectScopeAttribute();
					obj = (nint)MarshalInterface<IDisposable>.FromManaged((IDisposable)IEnumerator_System_ComponentModel_INotifyPropertyChanged.Initialized);
					num = 7;
					if (__KnownINotifyPropertyChangingArgs.CharacterName != null)
					{
						num = 1;
					}
					goto IL_00be;
					IL_00be:
					while (true)
					{
						switch (num)
						{
						case 12:
							return;
						case 13:
						case 16:
							break;
						case 8:
						case 10:
							obj = IReadOnlyList_System_IDisposable._initialized;
							num = 0;
							if (IReadOnlyList_object._initialized == 0)
							{
								num = 0;
							}
							continue;
						case 7:
							if (MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)(&obj)) != (IntPtr)0)
							{
								num = 6;
								continue;
							}
							goto case 11;
						default:
							IEnumerator_System_IDisposable._initialized = unchecked((nint)null);
							num = 4;
							if (IEnumerable_System_IDisposable.CombineAttribute == null)
							{
								num = 1;
							}
							continue;
						case 9:
							IEnumerable_object._initialized = (nint)obj;
							num = 3;
							if (GlobalVtableLookup.CreateAttribute == null)
							{
								num = 3;
							}
							continue;
						case 3:
							_ = ref Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute;
							((IEnumerable<NeteaseAccount>)(&obj)).Select((Func<NeteaseAccount, AccountModel>)Unsafe.AsPointer(ref this));
							_ = 11;
							if (Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute == null)
							{
								_ = 12;
							}
							continue;
						case 1:
							if (obj != null)
							{
								num = 15;
								continue;
							}
							break;
						case 2:
						case 6:
							obj = (obj = MarshalInspectable<object>.FromAbi((IntPtr)(nint)(&obj)));
							num = 0;
							if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute == null)
							{
								num = 1;
							}
							continue;
						case 14:
						case 15:
						{
							uint num2 = IList_object.Do_Abi_InsertAt_5((nint)list_object, (uint)(int)Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute, (nint)obj);
							num = 13;
							list_object = (IList_object)num2;
							continue;
						}
						case 4:
							obj = -1;
							_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute = -1;
							num = 2;
							continue;
						case 5:
							goto IL_0279;
						case 11:
							obj = 0;
							__KnownINotifyPropertyChangingArgs.Content = (PropertyChangingEventArgs)0;
							num = 9;
							continue;
						}
						break;
					}
					goto case 3;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_EB00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777730, new IntPtr(2737335708076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_EC00()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00_ED00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777731, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00_EE00()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_EF00(object? P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0053: Expected Obj, but got I
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)(nint)Unsafe.AsPointer(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized), ref *(object[]*)P_0);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
					{
						_ = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CExportAccounts_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AccountViewModel _003C_003E4__this;

		private TaskAwaiter<string> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		internal static object? DecorateScheduledDecorator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CheckFilteredArgument()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? ReflectAutomatedSummarizer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777728, new IntPtr(2737335735116L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_E000()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_05f5: Expected Obj, but got Ref
			//IL_061e: Expected Obj, but got I4
			//IL_061e: Expected Obj, but got Ref
			//IL_0643: Expected Obj, but got Ref
			//IL_060a: Expected Obj, but got Ref
			//IL_00e6: Expected Obj, but got I
			//IL_008e: Expected I, but got Obj
			//IL_00a2: Expected Obj, but got I
			//IL_010d: Expected Obj, but got I
			//IL_03b2: Expected Obj, but got Ref
			//IL_0387: Expected Obj, but got Ref
			//IL_01a1: Expected Obj, but got I4
			//IL_01a6: Expected Obj, but got I4
			//IL_01a6: Expected Obj, but got Ref
			//IL_01b5: Expected Obj, but got I
			//IL_02e7: Expected Obj, but got Ref
			//IL_0270: Expected Obj, but got Ref
			//IL_022c: Expected Obj, but got I4
			//IL_0231: Expected Obj, but got I4
			//IL_0231: Expected Obj, but got Ref
			//IL_0359: Expected Obj, but got Ref
			//IL_0241: Expected Obj, but got Ref
			//IL_021d: Expected Obj, but got I4
			//IL_0344: Expected Obj, but got I4
			//IL_0349: Expected Obj, but got I4
			//IL_0349: Expected Obj, but got Ref
			//IL_0403: Expected I4, but got Obj
			//IL_0403: Expected I, but got Obj
			//IL_029a: Expected Obj, but got Ref
			//IL_036f: Expected Obj, but got Ref
			//IL_0330: Expected Obj, but got I4
			//IL_0335: Expected Obj, but got Ref
			//IL_0424: Expected I, but got Obj
			//IL_0424: Expected I, but got Obj
			//IL_028f: Expected Obj, but got I4
			//IL_043b: Expected Obj, but got I4
			//IL_0186: Expected I4, but got Obj
			//IL_0604->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0632->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0659->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0616->IL0026: Incompatible stack types: I4 vs Obj
			//IL_063d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0664->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0112->IL0121: Incompatible stack types: I4 vs Obj
			//IL_03c8->IL0121: Incompatible stack types: I4 vs Obj
			//IL_01d7->IL0121: Incompatible stack types: I4 vs Obj
			//IL_011d->IL0121: Incompatible stack types: I4 vs Obj
			//IL_03d3->IL0121: Incompatible stack types: I4 vs Obj
			//IL_03a1->IL0121: Incompatible stack types: I4 vs Obj
			//IL_01ba->IL0121: Incompatible stack types: I4 vs Obj
			//IL_02f1->IL0121: Incompatible stack types: I4 vs Obj
			//IL_027a->IL0121: Incompatible stack types: I4 vs Obj
			//IL_019c->IL0121: Incompatible stack heights: 2 vs 1
			//IL_023b->IL0121: Incompatible stack types: I4 vs Obj
			//IL_0369->IL0121: Incompatible stack types: I4 vs Obj
			//IL_025d->IL0121: Incompatible stack heights: 2 vs 1
			//IL_0227->IL0121: Incompatible stack types: I4 vs Obj
			//IL_0353->IL0121: Incompatible stack types: I4 vs Obj
			//IL_02b0->IL0121: Incompatible stack types: I4 vs Obj
			//IL_0381->IL0121: Incompatible stack types: I4 vs Obj
			//IL_033f->IL0121: Incompatible stack types: I4 vs Obj
			//IL_03ac->IL0121: Incompatible stack types: I4 vs Obj
			//IL_01c5->IL0121: Incompatible stack types: I4 vs Obj
			//IL_0268->IL0121: Incompatible stack heights: 2 vs 1
			//IL_0311->IL0121: Incompatible stack types: I4 vs Obj
			//IL_0413->IL042a: Incompatible stack heights: 2 vs 1
			//IL_02bb->IL0121: Incompatible stack types: I4 vs Obj
			//IL_031c->IL0121: Incompatible stack types: I4 vs Obj
			//IL_044f->IL0121: Incompatible stack types: I4 vs Obj
			//IL_045a->IL0121: Incompatible stack types: I4 vs Obj
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 3;
			object obj = awaiter;
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				case 5:
					return;
				case 4:
					if ((nuint)(nint)awaiter > (nuint)1u)
					{
						num = 2;
						goto IL_0060;
					}
					goto IL_00d6;
				default:
					_ = ref __KnownINotifyPropertyChangingArgs.MobileAccounts;
					_ = IEnumerableMethods<INotifyPropertyChanged>.IID;
					_ = 5;
					break;
				case 3:
					awaiter = __KnownINotifyPropertyChangingArgs.CurrentDisplayPage;
					obj = 2;
					break;
				case 1:
					goto IL_0616;
				case 2:
					{
						awaiter = __KnownINotifyPropertyChangingArgs.InputCookie;
						obj = 4;
						if (__KnownINotifyPropertyChangingArgs.Input163Password != null)
						{
							obj = 4;
						}
						break;
					}
					IL_0616:
					__KnownINotifyPropertyChangingArgs.SelectedIndex = (PropertyChangingEventArgs)(-2);
					obj = 0;
					if (__KnownINotifyPropertyChangingArgs.InputEmail == null)
					{
						obj = 0;
					}
					break;
					IL_0060:
					while (true)
					{
						object obj2;
						switch (num)
						{
						case 2:
							if (IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)awaiter, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute()) != 0)
							{
								num = 1;
								if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
								{
									num = 0;
								}
								continue;
							}
							goto IL_0616;
						case 5:
							if (awaiter == null)
							{
								obj2 = 3;
								if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
								{
									obj2 = 9;
								}
								goto IL_0121;
							}
							goto IL_01c5;
						case 3:
						case 4:
							goto IL_0616;
							IL_03ac:
							awaiter = __KnownINotifyPropertyChangingArgs.CharacterName;
							obj2 = 3;
							if (__KnownINotifyPropertyChangingArgs.IsSelected != null)
							{
								obj2 = 8;
							}
							goto IL_0121;
							IL_01c5:
							if ((nint)awaiter != 1)
							{
								obj2 = 17;
								goto IL_0121;
							}
							goto IL_03ac;
							IL_0121:
							while (true)
							{
								switch ((int)obj2)
								{
								case 15:
									return;
								case 22:
									return;
								case 3:
								case 6:
									IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)/*Error near IL_0192: Stack underflow*/, (uint)(&awaiter));
									_ = 19;
									continue;
								case 1:
									awaiter = 1;
									IReadOnlyList_object.ReflectLogicalAttribute = 1;
									obj2 = 5;
									if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
									{
										obj2 = 5;
									}
									continue;
								case 16:
									break;
								case 2:
								case 11:
									MarshalInterface<INotifyPropertyChanged>.CopyManagedArray((INotifyPropertyChanged[])/*Error near IL_0211: Stack underflow*/, (IntPtr)(nint)(&awaiter));
									awaiter = IEnumerableMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.MoveAttribute() ? 1 : 0));
									obj2 = 13;
									continue;
								case 7:
									awaiter = -1;
									Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute = -1;
									obj2 = 11;
									continue;
								case 10:
									_ = ref Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute;
									((AsyncTaskMethodBuilder*)(&awaiter))->Start(ref Unsafe.As<_003CExportAccounts_003Ed__26, _003CCreateAccount_003Ed__21>(ref this));
									_ = 17;
									if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute != null)
									{
										_ = 22;
									}
									continue;
								case 5:
									Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute = awaiter;
									obj2 = 21;
									continue;
								case 18:
									if (MarshalInspectable<object>.FromAbi((IntPtr)(nint)(&awaiter)) != null)
									{
										awaiter = 2;
										obj2 = awaiter;
										continue;
									}
									goto case 23;
								case 9:
								case 20:
									awaiter = Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute;
									obj2 = 0;
									if (Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute != null)
									{
										obj2 = 0;
									}
									continue;
								case 4:
									_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance = (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0)awaiter;
									obj2 = 10;
									continue;
								case 13:
									IListMethods<object>.Abi_Clear_9((IntPtr)(nint)(&awaiter));
									if ((int)/*Error near IL_02fd: Stack underflow*/ != 0)
									{
										obj2 = 1;
										if ((int)_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout == 0)
										{
											obj2 = 3;
										}
										continue;
									}
									goto case 1;
								case 23:
									awaiter = 0;
									_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout = false;
									obj2 = 4;
									continue;
								case 12:
									awaiter = -1;
									_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator = -1;
									obj2 = 6;
									continue;
								case 8:
									__KnownINotifyPropertyChangingArgs.Notes = null;
									obj2 = 12;
									continue;
								case 21:
									Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.Username).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<string>*)(&awaiter), ref this);
									obj2 = 15;
									continue;
								default:
									__KnownINotifyPropertyChangingArgs.LoginAt = null;
									obj2 = 7;
									if (__KnownINotifyPropertyChangingArgs.Message == null)
									{
										obj2 = 7;
									}
									continue;
								case 14:
									goto IL_03ac;
								case 17:
								{
									object obj3 = IReadOnlyListMethods<object>.Abi_GetAt_0((IntPtr)awaiter, (uint)(int)IEnumerator_System_ComponentModel_INotifyPropertyChanged.DecorateConcreteAttribute());
									PropertyChangingEventArgs val;
									if (__KnownINotifyPropertyChangingArgs.MaxPlayers == null)
									{
										val = (__KnownINotifyPropertyChangingArgs.ImageUrl = (PropertyChangingEventArgs)new IEnumeratorMethods<IDisposable, nint>((delegate* unmanaged[Stdcall]<IntPtr, nint*, int>)/*Error near IL_0424: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)obj3, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)__KnownINotifyPropertyChangingArgs.Author, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, uint*, int>)(delegate* unmanaged[Stdcall]<nint, nint, uint*, byte*, uint>)(&IReadOnlyList_System_IDisposable.Do_Abi_IndexOf_2)));
									}
									((AsyncTaskMethodBuilder*)/*Error near IL_042f: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)/*Error near IL_042f: Stack underflow*/, ref *(_003CLogoutAccount_003Ed__23*)val);
									awaiter = IEnumeratorMethods<IDisposable>.Abi_get_HasCurrent_1((IntPtr)(IReadOnlyList_System_IDisposable.StoreAttribute() ? 1 : 0));
									obj2 = 16;
									if (__KnownINotifyPropertyChangingArgs.PreviewImage == null)
									{
										obj2 = 18;
									}
									continue;
								}
								case 19:
									goto IL_0616;
								}
								break;
							}
							goto IL_01c5;
						}
						break;
					}
					goto IL_00d6;
					IL_00d6:
					num = 5;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
					{
						num = 5;
					}
					goto IL_0060;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_E100()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777729, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_E200()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_E300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777742, new IntPtr(2737335735116L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00_E400()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777743, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00_E500()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_E600(object? P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777740, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_E700(object? P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0054: Expected Obj, but got I
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)(nint)Unsafe.AsPointer(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized), ref *(object[]*)P_0);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_E800(object? P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777741, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CImportAccounts_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AccountViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object? DecoratePassiveProgram;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ReflectExternalTemplate()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? AdaptProgram()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00휀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777738, new IntPtr(2737335735116L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_02f5: Expected Obj, but got I4
			//IL_02f5: Expected Obj, but got Ref
			//IL_0305: Expected Obj, but got Ref
			//IL_02cb: Expected Obj, but got Ref
			//IL_02a1: Expected Obj, but got Ref
			//IL_02a6: Expected Obj, but got Ref
			//IL_02b5: Expected Obj, but got I4
			//IL_0155: Expected Obj, but got Ref
			//IL_0157: Expected Obj, but got I
			//IL_0160: Expected Obj, but got I4
			//IL_0097: Expected I4, but got Obj
			//IL_00b2: Expected Obj, but got Ref
			//IL_01d5: Expected Obj, but got I4
			//IL_01da: Expected Obj, but got I4
			//IL_01da: Expected Obj, but got Ref
			//IL_0115: Expected Obj, but got I4
			//IL_011a: Expected Obj, but got Ref
			//IL_01b1: Expected Obj, but got I4
			//IL_0140: Expected Obj, but got Ref
			//IL_00c4: Expected Obj, but got Ref
			//IL_00db: Expected I, but got Obj
			//IL_00db: Expected Obj, but got I4
			//IL_00ea: Expected Obj, but got I
			//IL_0100: Expected Obj, but got Ref
			//IL_018f: Expected Obj, but got Ref
			//IL_0197: Expected Obj, but got Ref
			//IL_0197: Expected Obj, but got Ref
			//IL_01a0: Expected Obj, but got I4
			//IL_02ff->IL0026: Incompatible stack types: I4 vs Obj
			//IL_031b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02e1->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02ba->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005a->IL005e: Incompatible stack types: I4 vs Obj
			//IL_0326->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02ec->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02c5->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00bc->IL005e: Incompatible stack heights: 2 vs 1
			//IL_01e4->IL005e: Incompatible stack types: I4 vs Obj
			//IL_012e->IL005e: Incompatible stack types: I4 vs Obj
			//IL_01c5->IL005e: Incompatible stack types: I4 vs Obj
			//IL_00ce->IL005e: Incompatible stack types: I4 vs Obj
			//IL_00ef->IL005e: Incompatible stack types: I4 vs Obj
			//IL_0110->IL005e: Incompatible stack types: I4 vs Obj
			//IL_01a5->IL005a: Incompatible stack heights: 2 vs 0
			//IL_0139->IL005e: Incompatible stack types: I4 vs Obj
			//IL_01d0->IL005e: Incompatible stack types: I4 vs Obj
			//IL_014f->IL005e: Incompatible stack types: I4 vs Obj
			//IL_00fa->IL005e: Incompatible stack types: I4 vs Obj
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				default:
					if (obj != null)
					{
						obj3 = 3;
						goto IL_005e;
					}
					goto IL_014f;
				case 4:
					IListMethods<object>.Abi_ReplaceAll_11((IntPtr)/*Error near IL_02a6: Stack underflow*/, (object[])Unsafe.AsPointer(ref _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule));
					obj2 = 2;
					if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator != null)
					{
						obj2 = 5;
					}
					break;
				case 3:
					obj = __KnownINotifyPropertyChangingArgs.Notes;
					obj2 = 2;
					if (__KnownINotifyPropertyChangingArgs.Username != null)
					{
						obj2 = 2;
					}
					break;
				case 5:
					return;
				case 1:
					goto IL_02ed;
				case 2:
					{
						obj = __KnownINotifyPropertyChangingArgs.LoginAt;
						obj2 = 0;
						if (__KnownINotifyPropertyChangingArgs.IsMyself != null)
						{
							obj2 = 0;
						}
						break;
					}
					IL_005a:
					obj3 = obj;
					goto IL_005e;
					IL_005e:
					while (true)
					{
						switch ((int)obj3)
						{
						case 9:
							return;
						default:
							ExceptionHelpers.GetHRForException((Exception)(&obj));
							_ = 7;
							continue;
						case 6:
							IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = obj;
							obj3 = 12;
							continue;
						case 7:
							obj((object[])IEnumerator_object.Init(), unchecked((nint)null));
							obj3 = 4;
							if (IList_object.PatchAttribute == null)
							{
								obj3 = 0;
							}
							continue;
						case 8:
							Unsafe.As<nint, @null>(ref IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized) = null;
							obj3 = 2;
							continue;
						case 2:
							obj = -1;
							IReadOnlyList_System_IDisposable._initialized = -1;
							obj3 = 0;
							if (IReadOnlyList_object._initialized != 0)
							{
								obj3 = 0;
							}
							continue;
						case 5:
							if (MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)(&obj)) != (IntPtr)0)
							{
								obj3 = 11;
								continue;
							}
							goto case 1;
						case 10:
							break;
						case 12:
							goto IL_0189;
						case 3:
							obj = IEnumerableMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.MoveAttribute() ? 1 : 0));
							obj3 = 4;
							if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute == null)
							{
								obj3 = 5;
							}
							continue;
						case 1:
							obj = 0;
							Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute = 0;
							obj3 = 6;
							continue;
						case 4:
							goto IL_02ed;
						}
						break;
					}
					goto IL_014f;
					IL_02ed:
					__KnownINotifyPropertyChangingArgs.CreateAt = (PropertyChangingEventArgs)(-2);
					obj2 = 4;
					break;
					IL_0189:
					_ = ref IEnumerable_System_IDisposable.CombineAttribute;
					((XamlUserType)(&obj)).BoxType<double>((object)Unsafe.AsPointer(ref this));
					obj = 9;
					goto IL_005a;
					IL_014f:
					obj = IEnumerator_System_IDisposable._initialized;
					obj = 8;
					goto IL_005a;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777739, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
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
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777736, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object? P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0054: Expected Obj, but got I
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)(nint)Unsafe.AsPointer(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized), ref *(object[]*)P_0);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
					{
						_ = 0;
					}
					break;
				}
			}
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoginBedrock_003Ed__86 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AccountViewModel _003C_003E4__this;

		public EnumAccountType type;

		private TaskAwaiter<string> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private static object? CheckVirtualDecider;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CheckIdentifiableList()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? InterruptDecider()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00케()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777737, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00퀀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0050: Expected Obj, but got Ref
			//IL_00b1: Expected Obj, but got Ref
			//IL_00b3: Expected Obj, but got I
			//IL_008a: Expected Obj, but got Ref
			//IL_009b: Expected Obj, but got I
			//IL_0060: Expected Obj, but got Ref
			//IL_011f: Expected Obj, but got Ref
			//IL_0124: Expected I, but got Obj
			//IL_0124: Expected I4, but got Obj
			//IL_0165: Expected I4, but got Obj
			//IL_09d1: Expected Obj, but got Ref
			//IL_0bb0: Expected Obj, but got Ref
			//IL_0a60: Expected Obj, but got Ref
			//IL_07a3: Expected Obj, but got Ref
			//IL_06d0: Expected Obj, but got Ref
			//IL_0852: Expected Obj, but got Ref
			//IL_081c: Expected Obj, but got Ref
			//IL_02df: Expected I, but got Obj
			//IL_02e6: Expected Obj, but got I
			//IL_031b: Expected Obj, but got Ref
			//IL_054c: Expected Obj, but got Ref
			//IL_0879: Expected Obj, but got Ref
			//IL_0946: Expected Obj, but got Ref
			//IL_042c: Expected I, but got Obj
			//IL_0431: Expected I, but got Obj
			//IL_0ad7: Expected Obj, but got Ref
			//IL_0366: Expected Obj, but got Ref
			//IL_0375: Expected Obj, but got I4
			//IL_0782: Expected Obj, but got Ref
			//IL_04e1: Expected I, but got Obj
			//IL_04e8: Expected Obj, but got I4
			//IL_0a86: Expected Obj, but got I4
			//IL_0a8b: Expected Obj, but got I4
			//IL_0a8b: Expected Obj, but got Ref
			//IL_0746: Expected Obj, but got I4
			//IL_074b: Expected Obj, but got I4
			//IL_074b: Expected Obj, but got Ref
			//IL_0a1c: Expected Obj, but got Ref
			//IL_0a2d: Expected Obj, but got I4
			//IL_0641: Expected Obj, but got Ref
			//IL_08c6: Expected Obj, but got I4
			//IL_08cb: Expected Obj, but got I4
			//IL_08cb: Expected Obj, but got Ref
			//IL_066e: Expected Obj, but got Ref
			//IL_046f: Expected Obj, but got I4
			//IL_07de: Expected Obj, but got Ref
			//IL_04b3: Expected Obj, but got I4
			//IL_04b8: Expected Obj, but got I4
			//IL_04b8: Expected Obj, but got Ref
			//IL_03ec: Expected I, but got Obj
			//IL_03ee: Expected Obj, but got I4
			//IL_03f7: Expected Obj, but got I4
			//IL_0401: Expected Obj, but got I4
			//IL_0406: Expected Obj, but got I4
			//IL_0406: Expected Obj, but got Ref
			//IL_0be7: Expected Obj, but got I4
			//IL_0bec: Expected Obj, but got I4
			//IL_0bec: Expected Obj, but got Ref
			//IL_09a7: Expected Obj, but got I4
			//IL_09ac: Expected Obj, but got I4
			//IL_09ac: Expected Obj, but got Ref
			//IL_0840: Expected Obj, but got Ref
			//IL_091f: Expected Obj, but got I4
			//IL_0968: Unknown result type (might be due to invalid IL or missing references)
			//IL_097e: Expected I4, but got Unknown
			//IL_07b4: Expected Obj, but got I4
			//IL_07b9: Expected Obj, but got I4
			//IL_07b9: Expected Obj, but got Ref
			//IL_08a2: Expected Obj, but got Ref
			//IL_03c1: Expected Obj, but got I4
			//IL_03c6: Expected Obj, but got I4
			//IL_03c6: Expected Obj, but got Ref
			//IL_03d5: Expected Obj, but got VT
			//IL_0b42: Expected Obj, but got Ref
			//IL_098e: Expected Obj, but got Ref
			//IL_099d: Expected Obj, but got I4
			//IL_030b: Expected I4, but got Obj
			//IL_05b9: Expected Obj, but got Ref
			//IL_0351: Expected I, but got Obj
			//IL_0356: Expected Obj, but got I4
			//IL_0ab2: Expected Obj, but got Ref
			//IL_0af2: Expected Obj, but got VT
			//IL_0bd8: Expected Obj, but got Ref
			//IL_050c: Expected Obj, but got I4
			//IL_0511: Expected Obj, but got I4
			//IL_0511: Expected Obj, but got Ref
			//IL_06f7: Expected Obj, but got Ref
			//IL_0702: Expected Obj, but got I4
			//IL_0a39: Expected Obj, but got Ref
			//IL_0b72: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c2: Expected Obj, but got I4
			//IL_02a8: Expected I4, but got Obj
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00bd->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ab->IL0026: Incompatible stack types: I4 vs Obj
			//IL_09e7->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0bc6->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0a76->IL0173: Incompatible stack types: I4 vs Obj
			//IL_07af->IL0173: Incompatible stack types: I4 vs Obj
			//IL_06e6->IL0173: Incompatible stack types: I4 vs Obj
			//IL_016f->IL0173: Incompatible stack types: I4 vs Obj
			//IL_09f2->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0bd1->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0a81->IL0173: Incompatible stack types: I4 vs Obj
			//IL_06f1->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0866->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0826->IL0173: Incompatible stack types: I4 vs Obj
			//IL_02f0->IL0173: Incompatible stack heights: 4 vs 1
			//IL_0335->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0566->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0883->IL0173: Incompatible stack types: I4 vs Obj
			//IL_095a->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0442->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0ae9->IL0173: Incompatible stack heights: 2 vs 1
			//IL_078e->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0771->IL0173: Incompatible stack heights: 4 vs 1
			//IL_04fc->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0a9f->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0755->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0713->IL04ae: Incompatible stack heights: 1 vs 0
			//IL_0b72->IL0173: Incompatible stack heights: 2 vs 1
			//IL_065d->IL0173: Incompatible stack heights: 2 vs 1
			//IL_08df->IL0173: Incompatible stack types: I4 vs Obj
			//IL_068a->IL0173: Incompatible stack heights: 2 vs 1
			//IL_0483->IL0173: Incompatible stack types: I4 vs Obj
			//IL_06bf->IL0173: Incompatible stack heights: 4 vs 1
			//IL_0b39->IL0173: Incompatible stack heights: 2 vs 1
			//IL_07f0->IL0173: Incompatible stack types: I4 vs Obj
			//IL_04cc->IL0173: Incompatible stack types: I4 vs Obj
			//IL_05d5->IL0b39: Incompatible stack heights: 1 vs 0
			//IL_041a->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0bf6->IL0173: Incompatible stack types: I4 vs Obj
			//IL_09c0->IL0173: Incompatible stack types: I4 vs Obj
			//IL_084a->IL0173: Incompatible stack heights: 3 vs 1
			//IL_0933->IL0173: Incompatible stack heights: 3 vs 1
			//IL_07cd->IL0173: Incompatible stack types: I4 vs Obj
			//IL_08b6->IL0173: Incompatible stack heights: 5 vs 1
			//IL_03da->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0b56->IL0173: Incompatible stack types: I4 vs Obj
			//IL_04ae->IL0173: Incompatible stack types: I4 vs Obj
			//IL_05c9->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0360->IL0173: Incompatible stack heights: 2 vs 1
			//IL_0ac6->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0afc->IL0173: Incompatible stack heights: 2 vs 1
			//IL_0be2->IL0173: Incompatible stack types: I4 vs Obj
			//IL_051b->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0a4f->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0b86->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0871->IL0173: Incompatible stack types: I4 vs Obj
			//IL_053b->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0340->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0571->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0965->IL0173: Incompatible stack types: I4 vs Obj
			//IL_077c->IL0173: Incompatible stack heights: 4 vs 1
			//IL_0507->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0aaa->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0727->IL0173: Incompatible stack heights: 2 vs 1
			//IL_0668->IL0173: Incompatible stack heights: 2 vs 1
			//IL_08ea->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0695->IL0173: Incompatible stack heights: 2 vs 1
			//IL_048e->IL0173: Incompatible stack types: I4 vs Obj
			//IL_06ca->IL0173: Incompatible stack heights: 4 vs 1
			//IL_04d7->IL0173: Incompatible stack types: I4 vs Obj
			//IL_05df->IL0173: Incompatible stack heights: 2 vs 1
			//IL_0425->IL0173: Incompatible stack types: I4 vs Obj
			//IL_09cb->IL0173: Incompatible stack types: I4 vs Obj
			//IL_093e->IL0173: Incompatible stack heights: 3 vs 1
			//IL_0988->IL0173: Incompatible stack types: I4 vs Obj
			//IL_07d8->IL0173: Incompatible stack types: I4 vs Obj
			//IL_08c1->IL0173: Incompatible stack heights: 5 vs 1
			//IL_03e5->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0b61->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0315->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0ad1->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0a5a->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0546->IL0173: Incompatible stack types: I4 vs Obj
			//IL_0732->IL0173: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 2;
			object obj = awaiter;
			while (true)
			{
				int num;
				object obj2;
				switch ((int)obj)
				{
				default:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = -2;
					obj = 4;
					break;
				case 4:
					_ = ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
					/*Error near IL_0060: Member reference must be method, but was: Field*/;
				case 2:
					awaiter = IList_object.PatchAttribute;
					obj = 1;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
					{
						obj = 0;
					}
					break;
				case 1:
					awaiter = IReadOnlyList_System_IDisposable._initialized;
					obj = 5;
					break;
				case 3:
					return;
				case 5:
					{
						if ((nuint)(nint)awaiter > (nuint)4u)
						{
							num = 2;
							goto IL_00d5;
						}
						goto IL_0d90;
					}
					IL_0d90:
					num = 4;
					if (__KnownINotifyPropertyChangedArgs.BackgroundImageUrl == null)
					{
						num = 0;
					}
					goto IL_00d5;
					IL_00d5:
					while (true)
					{
						switch (num)
						{
						case 2:
							if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_0124: Stack underflow*/, (uint)(int)awaiter, (nint*)(nint)IReadOnlyList_object.ReflectLogicalAttribute) != 0)
							{
								num = 1;
								if (IEnumerable_System_IDisposable._initialized == 0)
								{
									num = 3;
								}
								continue;
							}
							goto IL_0d90;
						case 4:
							goto IL_0148;
						case 1:
							goto IL_0d90;
						}
						break;
					}
					goto default;
					IL_0148:
					switch ((int)awaiter)
					{
					default:
						obj2 = 16;
						goto IL_0173;
					case 4:
						awaiter = __KnownINotifyPropertyChangingArgs.InputEmail;
						obj2 = 34;
						if (__KnownINotifyPropertyChangingArgs.Input4399Password == null)
						{
							obj2 = 58;
						}
						goto IL_0173;
					case 3:
						goto IL_079d;
					case 0:
						goto IL_09cb;
					case 2:
						goto IL_0a5a;
					case 1:
						goto IL_0baa;
						IL_0173:
						while (true)
						{
							object source;
							switch ((int)obj2)
							{
							case 66:
								break;
							case 29:
								return;
							case 30:
								return;
							case 45:
								return;
							case 52:
								return;
							case 54:
								return;
							case 75:
								if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_02b4: Stack underflow*/, (uint)/*Error near IL_02b4: Stack underflow*/, ref *(INotifyPropertyChanged[]*)(&awaiter)) == 0)
								{
									awaiter = 71;
									goto IL_016f;
								}
								goto case 31;
							case 3:
								MarshalInterface<INotifyPropertyChanged>.CopyManagedArray((INotifyPropertyChanged[])/*Error near IL_02cc: Stack underflow*/, (IntPtr)/*Error near IL_02cc: Stack underflow*/);
								IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.MoveAttribute();
								awaiter = (nint)MarshalInterface<IEnumerator<INotifyPropertyChanged>>.FromManaged(IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.CheckSymbolicAttribute()));
								_ = 40;
								continue;
							case 59:
								switch ((int)awaiter)
								{
								case 4:
									break;
								default:
									goto IL_030b;
								case 0:
									goto IL_03e5;
								case 3:
									goto IL_05df;
								case 1:
									goto IL_0826;
								case 2:
									goto IL_0883;
								}
								goto case 3;
							case 5:
								Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute = null;
								obj2 = 9;
								if (Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute == null)
								{
									obj2 = 41;
								}
								continue;
							case 62:
								Interlocked.CompareExchange(ref *(Action*)/*Error near IL_0356: Stack underflow*/, (Action)/*Error near IL_0356: Stack underflow*/, (Action)IList_object.Do_Abi_GetAt_0((nint)(IList_object.Initialized ? 1 : 0), (uint)IList_object.Init(), (nint*)(nint)awaiter));
								_ = 55;
								continue;
							case 15:
								Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute = null;
								awaiter = 19;
								goto IL_016f;
							case 53:
								awaiter = 1;
								_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule = 1;
								obj2 = 65;
								if (!_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout)
								{
									obj2 = 9;
								}
								continue;
							case 39:
								goto IL_03e5;
							case 41:
								awaiter = -1;
								__KnownINotifyPropertyChangingArgs.Notes = (PropertyChangingEventArgs)(-1);
								obj2 = 33;
								if (__KnownINotifyPropertyChangingArgs.Username == null)
								{
									obj2 = 73;
								}
								continue;
							case 10:
								awaiter = IReadOnlyListMethods<IDisposable>.Abi_GetAt_0((IntPtr)/*Error near IL_0436: Stack underflow*/, IReadOnlyListMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0431: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_0431: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_0431: Stack underflow*/, new IEnumeratorMethods<INotifyPropertyChanged>((IntPtr)awaiter) ? ((delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)1) : ((delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)null)) ? 1u : 0u);
								obj2 = 64;
								continue;
							case 31:
								awaiter = IReadOnlyListMethods<IDisposable>.Abi_IndexOf_2((IntPtr)/*Error near IL_046d: Stack underflow*/, (IDisposable)/*Error near IL_046d: Stack underflow*/, ref *(uint*)(&awaiter));
								obj2 = 0;
								if (__KnownINotifyPropertyChangingArgs.IsSelected != null)
								{
									obj2 = 0;
								}
								continue;
							case 57:
								goto IL_048e;
							case 38:
								awaiter = 0;
								__KnownINotifyPropertyChangingArgs.MaxPlayers = (PropertyChangingEventArgs)0;
								obj2 = 6;
								if (__KnownINotifyPropertyChangingArgs.Description != null)
								{
									obj2 = 7;
								}
								continue;
							case 18:
							{
								uint num2 = IReadOnlyList_System_IDisposable.Do_Abi_get_Size_1((nint)/*Error near IL_04e1: Stack underflow*/, (uint*)(nint)__KnownINotifyPropertyChangingArgs.Version);
								IReadOnlyList_System_IDisposable._002Ecctor();
								awaiter = num2;
								obj2 = 46;
								if (__KnownINotifyPropertyChangingArgs.IsLiked == null)
								{
									obj2 = 11;
								}
								continue;
							}
							case 71:
								awaiter = 2;
								__KnownINotifyPropertyChangingArgs.Summary = (PropertyChangingEventArgs)2;
								obj2 = 9;
								continue;
							case 4:
								if (IEnumerableMethods<IDisposable>.Abi_First_0((IntPtr)(nint)(&awaiter)) != null)
								{
									obj2 = 50;
									if (__KnownINotifyPropertyChangingArgs.Title == null)
									{
										obj2 = 23;
									}
									continue;
								}
								goto case 53;
							case 6:
								__KnownINotifyPropertyChangingArgs.Executor = null;
								obj2 = 19;
								if (__KnownINotifyPropertyChangingArgs.StateText == null)
								{
									obj2 = 26;
								}
								continue;
							case 60:
								__KnownINotifyPropertyChangingArgs.Type = null;
								obj2 = 43;
								continue;
							case 40:
								_ = ref awaiter;
								if ((int)IReadOnlyListMethods<object>.IID == 0)
								{
									_ = 42;
									continue;
								}
								goto case 56;
							case 68:
								goto IL_05df;
							case 25:
								_ = ref __KnownINotifyPropertyChangingArgs.Image;
								((AsyncTaskMethodBuilder*)(&awaiter))->Start(ref Unsafe.As<_003CLoginBedrock_003Ed__86, DesktopViewModel._003CLaunchShadowClient_003Ed__5>(ref this));
								_ = 1;
								if (__KnownINotifyPropertyChangingArgs.TotalCoins == null)
								{
									_ = 52;
								}
								continue;
							case 27:
								_ = ref __KnownINotifyPropertyChangingArgs.TotalPoints;
								((AsyncTaskMethodBuilder*)(&awaiter))->Start(ref Unsafe.As<_003CLoginBedrock_003Ed__86, DesktopViewModel._003CSelectGame_003Ed__34>(ref this));
								_ = 29;
								if (__KnownINotifyPropertyChangingArgs.Quantity != null)
								{
									_ = 21;
								}
								continue;
							case 32:
								goto IL_0695;
							case 61:
								goto end_IL_0173;
							case 35:
							case 37:
							case 55:
							case 72:
								awaiter = __KnownINotifyPropertyChangingArgs.Input163Password;
								awaiter = 59;
								goto IL_016f;
							case 23:
								_ = ref awaiter;
								if ((int)IReadOnlyListMethods<IDisposable>.IID != 0)
								{
									_ = 12;
									if (__KnownINotifyPropertyChangingArgs.InputVerifyCode != null)
									{
										_ = 2;
									}
									continue;
								}
								goto case 38;
							case 20:
								awaiter = -1;
								__KnownINotifyPropertyChangingArgs.VerifyCodeDelayText = (PropertyChangingEventArgs)(-1);
								obj2 = 70;
								continue;
							case 17:
								_ = null;
								Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ValidateAttribute();
								_ = 66;
								if (__KnownINotifyPropertyChangingArgs.InfoBarIsOpen != null)
								{
									_ = 3;
								}
								continue;
							case 16:
								awaiter = __KnownINotifyPropertyChangingArgs.IsDragging;
								obj2 = 47;
								continue;
							case 48:
								goto IL_079d;
							case 49:
								awaiter = 4;
								__KnownINotifyPropertyChangingArgs.SelectedFileName = (PropertyChangingEventArgs)4;
								obj2 = 0;
								if (__KnownINotifyPropertyChangingArgs.ParsedCount == null)
								{
									obj2 = 1;
								}
								continue;
							case 36:
								Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.ImportedCount).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CLoginBedrock_003Ed__86, DesktopViewModel._003CRefreshGame_003Ed__35>(ref this));
								obj2 = 54;
								continue;
							case 2:
								__KnownINotifyPropertyChangingArgs.InputText = (PropertyChangingEventArgs)awaiter;
								obj2 = 14;
								continue;
							case 44:
								goto IL_0826;
							case 1:
								__KnownINotifyPropertyChangingArgs.NetGames = (PropertyChangingEventArgs)awaiter;
								obj2 = 22;
								if (__KnownINotifyPropertyChangingArgs.FourLikeNetGames == null)
								{
									obj2 = 1;
								}
								continue;
							case 7:
								__KnownINotifyPropertyChangingArgs.NetGamesEmptyText = (PropertyChangingEventArgs)awaiter;
								obj2 = 36;
								continue;
							case 51:
								goto IL_0883;
							case 26:
								awaiter = -1;
								__KnownINotifyPropertyChangingArgs.SkinOwnedSelected = (PropertyChangingEventArgs)(-1);
								obj2 = 69;
								if (__KnownINotifyPropertyChangingArgs.PagesOfSkins == null)
								{
									obj2 = 42;
								}
								continue;
							case 64:
								_ = ref awaiter;
								/*Error near IL_08ec: Member reference must be method, but was: Field*/;
							case 46:
								((Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails)1)._002Ector();
								_ = 17;
								if (__KnownINotifyPropertyChangingArgs.CoreResources != null)
								{
									_ = 11;
								}
								continue;
							case 9:
								__KnownINotifyPropertyChangingArgs.AllResources = (PropertyChangingEventArgs)awaiter;
								obj2 = 16;
								if (__KnownINotifyPropertyChangingArgs.SelectedItem == null)
								{
									obj2 = 27;
								}
								continue;
							case 47:
								switch (awaiter - 1)
								{
								case 1:
									break;
								case 0:
									goto IL_048e;
								case 2:
								case 3:
									goto IL_0695;
								default:
									goto IL_097e;
								}
								goto case 62;
							case 58:
								__KnownINotifyPropertyChangingArgs.Balance = null;
								awaiter = 20;
								goto IL_016f;
							case 43:
								awaiter = -1;
								__KnownINotifyPropertyChangingArgs.NativeProtocolExpirationTimeText = (PropertyChangingEventArgs)(-1);
								obj2 = 7;
								if (__KnownINotifyPropertyChangingArgs.SelectedCategoryIndex == null)
								{
									obj2 = 56;
								}
								continue;
							case 11:
								goto IL_09cb;
							case 22:
								Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.CanMobileMenuInvoke).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CLoginBedrock_003Ed__86, InstanceViewModel._003COperation_003Ed__11>(ref this));
								awaiter = 45;
								goto IL_016f;
							case 12:
							case 73:
								Environment.SetEnvironmentVariable((string)/*Error near IL_0a39: Stack underflow*/, (string?)(&awaiter));
								awaiter = (object)/*Error near IL_0a3b: Stack underflow*/;
								obj2 = 33;
								if (__KnownINotifyPropertyChangingArgs.CanSelect == null)
								{
									obj2 = 22;
								}
								continue;
							case 63:
								goto IL_0a5a;
							case 19:
								awaiter = -1;
								__KnownINotifyPropertyChangingArgs.CurrentPage = (PropertyChangingEventArgs)(-1);
								obj2 = 31;
								if (__KnownINotifyPropertyChangingArgs.Products == null)
								{
									obj2 = 14;
								}
								continue;
							case 65:
								__KnownINotifyPropertyChangingArgs.ProductGroups = (PropertyChangingEventArgs)awaiter;
								obj2 = 8;
								if (__KnownINotifyPropertyChangingArgs.SelectedProductGroup != null)
								{
									obj2 = 25;
								}
								continue;
							case 14:
								_ = ref __KnownINotifyPropertyChangingArgs.SelectedTopUpTabIndex;
								((AsyncVoidMethodBuilder*)(&awaiter))->Start(ref Unsafe.As<_003CLoginBedrock_003Ed__86, MainContentViewModel._003C_003C_002Dctor_003Eb__1_1_003Ed>(ref this));
								_ = 30;
								continue;
							case 50:
							case 69:
								_ = ref awaiter;
								awaiter = AsyncVoidMethodBuilder.Create();
								_ = 21;
								continue;
							case 34:
								Microsoft.Windows.Foundation.UndockedRegFreeWinRTCS.AutoInitialize.CheckConcreteViewer();
								((AsyncTaskMethodBuilder*)Microsoft.Windows.Foundation.UndockedRegFreeWinRTCS.AutoInitialize.ReflectConnectedCalculator())->Start(ref *(MobileViewModel._003CSelectGame_003Ed__6*)awaiter);
								_ = 10;
								continue;
							case 56:
								MatrixEventManager.RegisterEvents();
								awaiter = (object)(&awaiter);
								obj2 = 5;
								if (__KnownINotifyPropertyChangingArgs.Order != null)
								{
									obj2 = 8;
								}
								continue;
							case 24:
								_ = ((App)awaiter).RootElement;
								_ = 18;
								continue;
							case 28:
							case 74:
								throw new ILogger((string)/*Error near IL_0b77: Stack underflow*/);
							default:
								awaiter = awaiter;
								obj2 = 34;
								continue;
							case 67:
								goto IL_0baa;
							case 70:
								((IAsyncStateMachine)(&awaiter)).MoveNext();
								obj2 = 24;
								continue;
							case 42:
								{
									awaiter = 3;
									__KnownINotifyPropertyChangedArgs.Notes = (PropertyChangedEventArgs)3;
									obj2 = 2;
									continue;
								}
								IL_03e5:
								awaiter = IList_object.Do_Abi_GetMany_10((nint)/*Error near IL_03ec: Stack underflow*/, (uint)/*Error near IL_03ec: Stack underflow*/, (uint)/*Error near IL_03ec: Stack underflow*/, (nint)/*Error near IL_03ec: Stack underflow*/, (uint*)(nint)awaiter);
								awaiter = 13;
								goto IL_016f;
								IL_097e:
								obj2 = 35;
								continue;
								IL_030b:
								obj2 = 28;
								continue;
								IL_048e:
								IEnumerator_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
								(IEnumerator_System_ComponentModel_INotifyPropertyChanged.DecorateDynamicAttribute() ? ((AsyncTaskMethodBuilder*)1) : ((AsyncTaskMethodBuilder*)null))->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<DesktopSession>*)awaiter, ref *(_003CLoginHistoryAccount_003Ed__24*)IEnumerator_System_ComponentModel_INotifyPropertyChanged.DecorateConcreteAttribute());
								obj2 = 37;
								continue;
								IL_0695:
								IEnumerable_object.SaveAttribute();
								IEnumerable_object.DecorateAttachedAttribute();
								source = awaiter;
								GlobalVtableLookup.InitializeGlobalVtableLookup();
								((IEnumerable<DesktopGameModel>)source).ToList();
								_ = 66;
								if (__KnownINotifyPropertyChangingArgs.Input4399Username == null)
								{
									_ = 72;
								}
								continue;
								IL_0883:
								_ = IApplicationOverridesMethods.IID;
								((Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails)awaiter)._002Ector();
								Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.ReflectCustomAttribute();
								_ = IXamlMetadataProviderMethods.AbiToProjectionVftablePtr;
								awaiter = (nint)IXamlMemberMethods.IID;
								_ = 2;
								if (__KnownINotifyPropertyChangingArgs.SkinAllSelected != null)
								{
									_ = 4;
								}
								continue;
								IL_016f:
								obj2 = awaiter;
								continue;
								IL_0826:
								((Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails)awaiter).GetExposedInterfaces();
								((Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails)awaiter)._002Ector();
								_ = IContentControlOverridesMethods.AbiToProjectionVftablePtr;
								awaiter = (nint)IComponentConnectorMethods.IID;
								_ = 23;
								continue;
								IL_05df:
								/*Error near IL_05df: Member reference must be method, but was: Field*/;
							}
							goto end_IL_014c;
							continue;
							end_IL_0173:
							break;
						}
						goto case 4;
						IL_0baa:
						awaiter = __KnownINotifyPropertyChangingArgs.Earnings;
						obj2 = 6;
						if (__KnownINotifyPropertyChangingArgs.RedeemOptions == null)
						{
							obj2 = 3;
						}
						goto IL_0173;
						IL_079d:
						awaiter = __KnownINotifyPropertyChangingArgs.Step;
						obj2 = 60;
						goto IL_0173;
						IL_0a5a:
						awaiter = __KnownINotifyPropertyChangingArgs.ShopDescription;
						obj2 = 4;
						if (__KnownINotifyPropertyChangingArgs.Code != null)
						{
							obj2 = 15;
						}
						goto IL_0173;
						IL_09cb:
						awaiter = __KnownINotifyPropertyChangingArgs.Instances;
						obj2 = 5;
						if (__KnownINotifyPropertyChangingArgs.InputPassword != null)
						{
							obj2 = 3;
						}
						goto IL_0173;
						end_IL_014c:
						break;
					}
					goto default;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00턀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777750, new IntPtr(2737335708076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00툀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00팀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777751, new IntPtr(2737335728876L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00퐀()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00픀(object? P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0054: Expected Obj, but got I
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)(nint)Unsafe.AsPointer(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized), ref *(object[]*)P_0);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00혀(object? P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777748, new IntPtr(2737335708076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoginByHistory_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AccountModel accountModel;

		public AccountViewModel _003C_003E4__this;

		private TaskAwaiter<ContentDialogResult> _003C_003Eu__1;

		internal static object? DecorateCustomizableContext;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ReflectInternalMapper()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? ReflectExpandablePolicy()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00씀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777749, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00였()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_007b: Expected Obj, but got Ref
			//IL_0870: Expected Obj, but got Ref
			//IL_00a0: Expected Obj, but got Ref
			//IL_004f: Expected Obj, but got Ref
			//IL_0063: Expected Obj, but got I
			//IL_0232: Expected Obj, but got Ref
			//IL_0237: Expected I, but got Obj
			//IL_0239: Expected Obj, but got I4
			//IL_02d7: Expected Obj, but got Ref
			//IL_021d: Expected Obj, but got I4
			//IL_0222: Expected Obj, but got I4
			//IL_0222: Expected Obj, but got Ref
			//IL_04dd: Expected I, but got Obj
			//IL_04df: Expected Obj, but got I4
			//IL_0558: Expected I, but got Obj
			//IL_01d8: Expected I4, but got Obj
			//IL_078f: Invalid comparison between Unknown and I4
			//IL_0649: Unknown result type (might be due to invalid IL or missing references)
			//IL_064b: Invalid comparison between Unknown and I4
			//IL_06b1: Expected Obj, but got Ref
			//IL_045d: Expected I, but got Obj
			//IL_0334: Expected I, but got Obj
			//IL_0334: Expected I, but got Obj
			//IL_052b: Expected Obj, but got I4
			//IL_0512: Expected Obj, but got I4
			//IL_0517: Expected Obj, but got I4
			//IL_0517: Expected Obj, but got Ref
			//IL_02b1: Expected Obj, but got Ref
			//IL_05cd: Expected I, but got Obj
			//IL_05cd: Expected I, but got Obj
			//IL_04cc: Expected I4, but got Obj
			//IL_04cc: Expected I, but got Obj
			//IL_0704: Expected Obj, but got I4
			//IL_0436: Expected I4, but got Obj
			//IL_01ee: Expected I, but got Obj
			//IL_01ee: Expected I, but got Obj
			//IL_0609: Expected Obj, but got I4
			//IL_04aa: Expected Obj, but got Ref
			//IL_04b4: Expected I, but got Obj
			//IL_0596: Expected Obj, but got Ref
			//IL_05a7: Expected Obj, but got I4
			//IL_0735: Expected Obj, but got I4
			//IL_03a7: Expected I, but got Obj
			//IL_03a7: Expected I, but got Obj
			//IL_01bc: Expected Obj, but got Ref
			//IL_01c6: Expected Obj, but got I4
			//IL_0394: Expected Obj, but got Ref
			//IL_008f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0886->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ac->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0068->IL0026: Incompatible stack heights: 2 vs 1
			//IL_009a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0891->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0073->IL0026: Incompatible stack heights: 2 vs 1
			//IL_032b->IL00c2: Incompatible stack heights: 3 vs 1
			//IL_030a->IL00c2: Incompatible stack heights: 3 vs 1
			//IL_056c->IL00c2: Incompatible stack heights: 3 vs 1
			//IL_0687->IL00c2: Incompatible stack heights: 4 vs 1
			//IL_05c4->IL00c2: Incompatible stack heights: 5 vs 1
			//IL_01e2->IL00c2: Incompatible stack heights: 2 vs 1
			//IL_026e->IL00c2: Incompatible stack heights: 4 vs 1
			//IL_0467->IL00c2: Incompatible stack heights: 2 vs 1
			//IL_034d->IL00c2: Incompatible stack heights: 2 vs 1
			//IL_0376->IL00c2: Incompatible stack heights: 5 vs 1
			//IL_053f->IL00c2: Incompatible stack heights: 3 vs 1
			//IL_05e6->IL00c2: Incompatible stack heights: 2 vs 1
			//IL_04d6->IL00c2: Incompatible stack heights: 2 vs 1
			//IL_0718->IL00c2: Incompatible stack heights: 3 vs 1
			//IL_020d->IL00c2: Incompatible stack heights: 3 vs 1
			//IL_0613->IL00c2: Incompatible stack heights: 2 vs 1
			//IL_04be->IL00c2: Incompatible stack heights: 4 vs 1
			//IL_073a->IL00be: Incompatible stack heights: 0 vs 1
			//IL_03c0->IL00c2: Incompatible stack heights: 2 vs 1
			//IL_01d0->IL00c2: Incompatible stack heights: 5 vs 1
			//IL_0290->IL00c2: Incompatible stack heights: 5 vs 1
			//IL_0577->IL00c2: Incompatible stack heights: 3 vs 1
			//IL_0358->IL00c2: Incompatible stack heights: 2 vs 1
			//IL_054a->IL00c2: Incompatible stack heights: 3 vs 1
			//IL_05f1->IL00c2: Incompatible stack heights: 2 vs 1
			//IL_0723->IL00c2: Incompatible stack heights: 3 vs 1
			//IL_0218->IL00c2: Incompatible stack heights: 3 vs 1
			//IL_00c2->IL00c2: Incompatible stack heights: 2 vs 1
			//IL_03cb->IL00c2: Incompatible stack heights: 2 vs 1
			//IL_029b->IL00c2: Incompatible stack heights: 5 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 1:
					return;
				case 5:
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)/*Error near IL_0054: Stack underflow*/, ref Unsafe.As<nint, object[]>(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized));
					_ = 1;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
					{
						_ = 0;
					}
					break;
				default:
					IList_object._initialized = -2;
					obj2 = 5;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 2;
					}
					break;
				case 3:
					obj = IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute;
					obj2 = 2;
					break;
				case 4:
					if (obj == null)
					{
						num = 18;
						goto IL_00c2;
					}
					goto IL_022c;
				case 2:
					{
						obj = __KnownINotifyPropertyChangingArgs.NetGamesEmptyText;
						obj2 = 4;
						if (__KnownINotifyPropertyChangingArgs.RentalGames != null)
						{
							obj2 = 3;
						}
						break;
					}
					IL_022c:
					obj = IEnumerable_System_ComponentModel_INotifyPropertyChanged.Do_Abi_First_0((nint)/*Error near IL_0237: Stack underflow*/, (nint*)(nint)Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute);
					num = 31;
					goto IL_00c2;
					IL_00c2:
					while (true)
					{
						switch (num)
						{
						case 34:
							return;
						case 22:
							break;
						case 48:
						case 49:
							IEnumerator_object.DecorateAutomatableAttribute();
							_ = IReadOnlyList_System_IDisposable.ReflectConnectedAttribute;
							MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Initialized);
							_ = 37;
							continue;
						case 13:
							IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_01d8: Stack underflow*/, (uint)(int)obj, (nint*)2);
							_ = 52;
							continue;
						case 39:
							IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)/*Error near IL_01f3: Stack underflow*/, (uint*)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_01ee: Stack underflow*/, (uint)/*Error near IL_01ee: Stack underflow*/, (uint)/*Error near IL_01ee: Stack underflow*/, (nint)obj, (uint*)(nint)IEnumerator_System_IDisposable.ReflectTransferableAttribute));
							_ = 0;
							IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
							_ = 36;
							if (GlobalVtableLookup.CreateAttribute == null)
							{
								_ = 15;
							}
							continue;
						case 3:
							obj = -1;
							Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute = -1;
							num = 32;
							continue;
						case 51:
							goto IL_022c;
						case 16:
							IEnumerable_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
							IEnumerable_System_ComponentModel_INotifyPropertyChanged.DecorateSeparatedAttribute();
							_ = 15;
							continue;
						case 52:
							IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectMonoAttribute();
							_ = IList_object.Initialized;
							_ = 35;
							if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute != null)
							{
								_ = 13;
							}
							continue;
						case 27:
						case 32:
							IListMethods<object>.Abi_InsertAt_5((IntPtr)/*Error near IL_02b1: Stack underflow*/, (uint)/*Error near IL_02b1: Stack underflow*/, (object)(&obj));
							num = 22;
							if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute == null)
							{
								num = 0;
							}
							continue;
						case 2:
						case 18:
							obj = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance;
							num = 4;
							if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule == null)
							{
								num = 19;
							}
							continue;
						case 5:
							goto IL_02f8;
						case 1:
							goto IL_0319;
						case 23:
							IList_object.Do_Abi_ReplaceAll_11((nint)/*Error near IL_0339: Stack underflow*/, (uint)/*Error near IL_0339: Stack underflow*/, (nint)(int)IList_object.Do_Abi_GetMany_10((nint)/*Error near IL_0334: Stack underflow*/, (uint)/*Error near IL_0334: Stack underflow*/, (uint)/*Error near IL_0334: Stack underflow*/, (nint)obj, (uint*)(nint)obj));
							_ = 18;
							if (__KnownINotifyPropertyChangingArgs.Username == null)
							{
								_ = 28;
							}
							continue;
						case 24:
							goto IL_0358;
						case 12:
							if (IReadOnlyListMethods<IDisposable>.Abi_GetAt_0((IntPtr)/*Error near IL_037d: Stack underflow*/, (uint)(&obj)) != null)
							{
								num = 27;
								continue;
							}
							goto case 29;
						case 50:
							__KnownINotifyPropertyChangingArgs.IsMyself = (PropertyChangingEventArgs)obj;
							num = 43;
							continue;
						case 47:
							IEnumerator_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_03ac: Stack underflow*/, (uint)/*Error near IL_03ac: Stack underflow*/, (nint)/*Error near IL_03ac: Stack underflow*/, (uint*)(int)IEnumerator_System_ComponentModel_INotifyPropertyChanged.Do_Abi_MoveNext_2((nint)obj, (byte*)(nint)obj));
							_ = 1;
							if (__KnownINotifyPropertyChangingArgs.IsSelected != null)
							{
								_ = 11;
							}
							continue;
						case 38:
							switch ((int)obj)
							{
							case 2:
								break;
							case 3:
								goto IL_02f8;
							case 4:
								goto IL_0319;
							case 1:
							case 5:
							case 6:
								goto IL_0358;
							default:
								goto IL_0436;
							case 0:
								goto IL_0455;
							}
							goto case 13;
						case 21:
							goto IL_0455;
						case 8:
							if ((nint)obj != 1)
							{
								num = 25;
								continue;
							}
							goto case 41;
						case 41:
							IReadOnlyList_System_IDisposable._002Ecctor();
							_ = __KnownINotifyPropertyChangingArgs.BackgroundImageUrl;
							IEnumerableMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)IReadOnlyList_System_IDisposable.VerifyAttribute());
							_ = 45;
							continue;
						case 35:
							IReadOnlyList_object.Do_Abi_GetAt_0((nint)obj, (uint)(int)obj, (nint*)(int)IReadOnlyList_object.Init());
							_ = 20;
							continue;
						case 6:
							obj = IReadOnlyList_object.Do_Abi_IndexOf_2((nint)/*Error near IL_04dd: Stack underflow*/, (nint)/*Error near IL_04dd: Stack underflow*/, (uint*)/*Error near IL_04dd: Stack underflow*/, (byte*)(nint)obj);
							num = 12;
							if (__KnownINotifyPropertyChangingArgs.LaunchTime == null)
							{
								num = 17;
							}
							continue;
						case 29:
							obj = 0;
							__KnownINotifyPropertyChangingArgs.State = (PropertyChangingEventArgs)0;
							num = 50;
							continue;
						case 10:
						case 28:
						case 44:
							_ = 1;
							obj = IReadOnlyList_object.ReflectSimpleAttribute();
							_ = 14;
							if (__KnownINotifyPropertyChangingArgs.CloseText == null)
							{
								_ = 6;
							}
							continue;
						case 7:
							IEnumerator_System_IDisposable.Do_Abi_MoveNext_2((nint)obj, (byte*)(int)IEnumerator_System_IDisposable.Init());
							_ = 2;
							if (__KnownINotifyPropertyChangingArgs.OrderId != null)
							{
								_ = 4;
							}
							continue;
						case 4:
						case 15:
						case 20:
						case 26:
						case 30:
						case 42:
						{
							uint num2 = IEnumerator_System_IDisposable.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_057c: Stack underflow*/, (byte*)/*Error near IL_057c: Stack underflow*/);
							IEnumerator_System_IDisposable._002Ecctor();
							if (num2 == 0)
							{
								num = 10;
								continue;
							}
							goto case 6;
						}
						case 43:
							_ = ref __KnownINotifyPropertyChangingArgs.OrderAt;
							((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CLoginByHistory_003Ed__25, DesktopViewModel._003CAddRandomCharacter_003Ed__1>(ref this));
							obj = 34;
							continue;
						case 11:
							_ = IEnumerable_System_IDisposable.Initialized;
							IEnumerable_System_IDisposable.Init();
							_ = 30;
							continue;
						case 33:
							IEnumerable_System_IDisposable.Do_Abi_First_0((nint)obj, (nint*)(nint)obj);
							IEnumerable_System_IDisposable._002Ecctor();
							_ = 26;
							if (__KnownINotifyPropertyChangingArgs.TotalCoins == null)
							{
								_ = 16;
							}
							continue;
						case 40:
							obj = IEnumerable_object.Initialized;
							_ = 46;
							continue;
						case 17:
							if (obj - 2 > 2)
							{
								num = 44;
								if (__KnownINotifyPropertyChangingArgs.DesktopAccounts == null)
								{
									num = 0;
								}
								continue;
							}
							goto case 39;
						case 9:
							IEnumerable_object.DecorateAttachedAttribute();
							GlobalVtableLookup.InitializeGlobalVtableLookup();
							_ = 7;
							continue;
						case 19:
							Unsafe.As<PropertyChangingEventArgs, DateTime?>(ref __KnownINotifyPropertyChangingArgs.Input4399Username) = null;
							num = 3;
							if (__KnownINotifyPropertyChangingArgs.Input4399Password != null)
							{
								num = 3;
							}
							continue;
						case 46:
							if (obj == null)
							{
								num = 48;
								if (__KnownINotifyPropertyChangingArgs.InputMobilePassword == null)
								{
									num = 44;
								}
								continue;
							}
							goto case 8;
						case 36:
							((Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails)5).GetExposedInterfaces();
							_ = 8;
							if (__KnownINotifyPropertyChangingArgs.VerifyCodeDelayText == null)
							{
								_ = 23;
							}
							continue;
						case 25:
						case 37:
						case 45:
							((AsyncTaskMethodBuilder*)/*Error near IL_072a: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<(bool, bool)>*)/*Error near IL_072a: Stack underflow*/, ref *(DesktopViewModel._003CAddCharacter_003Ed__0*)obj);
							obj = (object)/*Error near IL_072c: Stack underflow*/;
							obj = 12;
							continue;
						case 31:
							obj = ((Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails)obj).GetExposedInterfaces();
							num = 38;
							continue;
						default:
							__KnownINotifyPropertyChangingArgs.Step = (PropertyChangingEventArgs)obj;
							num = 40;
							continue;
						case 14:
							{
								((Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails)(object)((Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails)/*Error near IL_0789: Stack underflow*/).GetExposedInterfaces())._002Ector();
								if ((int)/*Error near IL_0794: Stack underflow*/ == 1)
								{
									num = 0;
									if (__KnownINotifyPropertyChangingArgs.ImportedCount != null)
									{
										num = 0;
									}
									continue;
								}
								goto case 25;
							}
							IL_0358:
							_ = !IList_object.AttachAttribute();
							IList_object.ReflectScopeAttribute();
							_ = 9;
							continue;
							IL_0319:
							IList_object.Do_Abi_Clear_9((nint)4);
							_ = 33;
							continue;
							IL_02f8:
							IList_object.Do_Abi_RemoveAtEnd_8((nint)3);
							_ = 47;
							continue;
							IL_0455:
							IReadOnlyList_System_IDisposable.Do_Abi_IndexOf_2((nint)/*Error near IL_045d: Stack underflow*/, (nint)/*Error near IL_045d: Stack underflow*/, (uint*)(nint)obj, (byte*)5);
							_ = 16;
							continue;
							IL_0436:
							num = 42;
							if (__KnownINotifyPropertyChangingArgs.Author == null)
							{
								num = 10;
							}
							continue;
						}
						break;
					}
					goto default;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00윀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777746, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00저()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00준()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777747, new IntPtr(2737335735116L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00쨀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777744, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00쬀()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00찀(object? P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0054: Expected Obj, but got I
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)(nint)Unsafe.AsPointer(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized), ref *(object[]*)P_0);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00촀(object? P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777745, new IntPtr(2737335735116L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoginDesktop_003Ed__87 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AccountViewModel _003C_003E4__this;

		public EnumAccountType type;

		private object _003Ccookies_003E5__2;

		private TaskAwaiter<string> _003C_003Eu__1;

		private TaskAwaiter<DesktopSession> _003C_003Eu__2;

		private static object? DecorateHiddenRequester;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MergePolicy()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? DecorateGenericEvent()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00밀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777758, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00봀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_155d: Expected Obj, but got Ref
			//IL_1521: Expected Obj, but got Ref
			//IL_1548: Expected Obj, but got Ref
			//IL_154d: Expected Obj, but got Ref
			//IL_14fc: Expected Obj, but got I4
			//IL_14fc: Expected Obj, but got Ref
			//IL_00d3: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_009a: Expected Obj, but got Ref
			//IL_009f: Expected I, but got Obj
			//IL_012c: Expected I4, but got Obj
			//IL_00b3: Expected Obj, but got I
			//IL_0f01: Expected Obj, but got Ref
			//IL_0c0a: Expected Obj, but got Ref
			//IL_04db: Expected Obj, but got Ref
			//IL_0c9e: Expected Obj, but got Ref
			//IL_0843: Expected Obj, but got Ref
			//IL_0acd: Expected Obj, but got Ref
			//IL_0cc2: Expected Obj, but got Ref
			//IL_0951: Expected Obj, but got Ref
			//IL_065e: Expected Obj, but got Ref
			//IL_0bbe: Expected Obj, but got I4
			//IL_0bc3: Expected Obj, but got I4
			//IL_0bc3: Expected Obj, but got Ref
			//IL_0d29: Expected Obj, but got Ref
			//IL_04c3: Expected Obj, but got Ref
			//IL_04cb: Expected Obj, but got Ref
			//IL_0b5b: Expected Obj, but got I4
			//IL_0b60: Expected Obj, but got I4
			//IL_0b60: Expected Obj, but got Ref
			//IL_069c: Expected Obj, but got Ref
			//IL_0cb0: Expected Obj, but got Ref
			//IL_048f: Expected VT, but got Obj
			//IL_048f: Expected Obj, but got Ref
			//IL_049e: Expected Obj, but got I4
			//IL_0f4a: Expected Obj, but got I4
			//IL_0f55: Expected Obj, but got Ref
			//IL_0fd3: Expected Obj, but got Ref
			//IL_05e9: Expected Obj, but got I4
			//IL_05ee: Expected Obj, but got I4
			//IL_05ee: Expected Obj, but got Ref
			//IL_0e01: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c4: Expected Obj, but got Ref
			//IL_03c6: Expected Obj, but got I
			//IL_0faf: Expected Obj, but got Ref
			//IL_0e58: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e6e: Expected I4, but got Unknown
			//IL_06b6: Expected Obj, but got I4
			//IL_06bd: Expected I, but got Obj
			//IL_06bd: Expected I, but got Obj
			//IL_06c3: Expected Obj, but got Ref
			//IL_06c8: Expected I, but got Obj
			//IL_06ca: Expected Obj, but got I4
			//IL_0746: Expected Obj, but got Ref
			//IL_0a3c: Expected Obj, but got I4
			//IL_0a41: Expected Obj, but got I4
			//IL_0a41: Expected Obj, but got Ref
			//IL_0a27: Expected Obj, but got Ref
			//IL_0e92: Expected Obj, but got I4
			//IL_0eab: Expected Obj, but got Ref
			//IL_0eb0: Expected I4, but got Obj
			//IL_0676: Expected Obj, but got Ref
			//IL_09cc: Expected Obj, but got I4
			//IL_09d1: Expected Obj, but got I4
			//IL_09d1: Expected Obj, but got Ref
			//IL_07ef: Expected Obj, but got Ref
			//IL_0714: Expected I, but got Obj
			//IL_0720: Expected Obj, but got VT
			//IL_1127: Unknown result type (might be due to invalid IL or missing references)
			//IL_11ba: Expected Obj, but got Ref
			//IL_0e7d: Expected Obj, but got I4
			//IL_0e82: Expected Obj, but got I4
			//IL_0e82: Expected Obj, but got Ref
			//IL_11d8: Expected Obj, but got I4
			//IL_119f: Expected Obj, but got Ref
			//IL_11aa: Expected Obj, but got I4
			//IL_1038: Expected Obj, but got I4
			//IL_104e: Expected Obj, but got I4
			//IL_0d7e: Expected Obj, but got Ref
			//IL_0b0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0455: Expected I, but got Obj
			//IL_045c: Expected I, but got Obj
			//IL_0461: Expected Obj, but got I4
			//IL_0513: Expected Obj, but got I4
			//IL_0518: Expected Obj, but got I4
			//IL_0518: Expected Obj, but got Ref
			//IL_0b3d: Expected Obj, but got Ref
			//IL_0436: Expected I, but got Obj
			//IL_0444: Expected Obj, but got I4
			//IL_0b05: Expected Obj, but got Ref
			//IL_0548: Expected Obj, but got Ref
			//IL_09f1: Expected Obj, but got Ref
			//IL_0c60: Expected Obj, but got I4
			//IL_0c65: Expected Obj, but got I4
			//IL_0c65: Expected Obj, but got Ref
			//IL_0f89: Expected I4, but got Obj
			//IL_0a6b: Expected Obj, but got VT
			//IL_0a74: Expected Obj, but got I4
			//IL_07c8: Expected Obj, but got Ref
			//IL_039f: Expected Obj, but got I4
			//IL_03ae: Expected Obj, but got I
			//IL_0c74: Expected Obj, but got I4
			//IL_0c79: Expected Obj, but got I4
			//IL_0c79: Expected Obj, but got Ref
			//IL_0533: Expected I, but got Obj
			//IL_055f: Expected Obj, but got I4
			//IL_0564: Expected Obj, but got I4
			//IL_0564: Expected Obj, but got Ref
			//IL_0da5: Expected Obj, but got Ref
			//IL_03e5: Expected Obj, but got Ref
			//IL_03ed: Expected Obj, but got Ref
			//IL_03ed: Expected Obj, but got Ref
			//IL_0c1e: Expected Obj, but got Ref
			//IL_08ba: Expected Obj, but got Ref
			//IL_0881: Expected Obj, but got I
			//IL_05a2: Expected Obj, but got Ref
			//IL_0a9d: Expected Obj, but got I4
			//IL_0ab6: Expected Obj, but got Ref
			//IL_0cfc: Expected Obj, but got Ref
			//IL_105e: Expected Obj, but got Ref
			//IL_1066: Expected Obj, but got Ref
			//IL_1066: Expected Obj, but got Ref
			//IL_1066: Expected Obj, but got Ref
			//IL_08ed: Expected I4, but got Obj
			//IL_10bd: Expected Obj, but got Ref
			//IL_0819: Expected Obj, but got I4
			//IL_081e: Expected Obj, but got I4
			//IL_081e: Expected Obj, but got Ref
			//IL_0414: Expected Obj, but got Ref
			//IL_041d: Expected Obj, but got I4
			//IL_0925: Expected Obj, but got I4
			//IL_092a: Expected Obj, but got I4
			//IL_092a: Expected Obj, but got Ref
			//IL_0ec2: Expected Obj, but got I4
			//IL_0ed5: Expected I4, but got Obj
			//IL_0eec: Expected Obj, but got I4
			//IL_0ef1: Expected Obj, but got I4
			//IL_0ef1: Expected Obj, but got Ref
			//IL_06ee: Expected Obj, but got I4
			//IL_06f3: Expected Obj, but got I4
			//IL_06f3: Expected Obj, but got Ref
			//IL_06fc: Expected Obj, but got I4
			//IL_0ae3: Expected VT, but got I4
			//IL_0af8: Expected Obj, but got I4
			//IL_086e: Expected Obj, but got Ref
			//IL_0621: Expected Obj, but got Ref
			//IL_0b1d: Expected Obj, but got Ref
			//IL_1214: Unknown result type (might be due to invalid IL or missing references)
			//IL_1219: Unknown result type (might be due to invalid IL or missing references)
			//IL_121f: Expected Obj, but got Unknown
			//IL_1274: Expected Obj, but got I4
			//IL_034f: Expected I4, but got Obj
			//IL_1227: Unknown result type (might be due to invalid IL or missing references)
			//IL_1239: Expected Obj, but got I
			//IL_12c7: Expected Obj, but got I4
			//IL_1573->IL0026: Incompatible stack types: I4 vs Obj
			//IL_1537->IL0026: Incompatible stack types: I4 vs Obj
			//IL_1557->IL0026: Incompatible stack types: I4 vs Obj
			//IL_1510->IL0026: Incompatible stack types: I4 vs Obj
			//IL_157e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_1542->IL0026: Incompatible stack types: I4 vs Obj
			//IL_151b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0f0d->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0c16->IL013a: Incompatible stack types: I4 vs Obj
			//IL_04f1->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0caa->IL013a: Incompatible stack types: I4 vs Obj
			//IL_084f->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0ad9->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0cd8->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0136->IL013a: Incompatible stack types: I4 vs Obj
			//IL_04fc->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0ce3->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0965->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0372->IL013a: Incompatible stack heights: 2 vs 1
			//IL_066e->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0bcd->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0d39->IL013a: Incompatible stack types: I4 vs Obj
			//IL_04d5->IL013a: Incompatible stack heights: 4 vs 1
			//IL_0b74->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0cbc->IL013a: Incompatible stack types: I4 vs Obj
			//IL_04a3->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0f66->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0fe3->IL013a: Incompatible stack types: I4 vs Obj
			//IL_118d->IL013a: Incompatible stack types: I4 vs Obj
			//IL_05f8->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0e1f->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0f39->IL013a: Incompatible stack types: I4 vs Obj
			//IL_03d0->IL013a: Incompatible stack types: I4 vs Obj
			//IL_06de->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0760->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0a4b->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0a37->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0ebc->IL013a: Incompatible stack types: I4 vs Obj
			//IL_068a->IL013a: Incompatible stack types: I4 vs Obj
			//IL_09db->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0809->IL013a: Incompatible stack types: I4 vs Obj
			//IL_072a->IL013a: Incompatible stack heights: 5 vs 1
			//IL_07a4->IL013a: Incompatible stack heights: 3 vs 1
			//IL_11d0->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0e8c->IL013a: Incompatible stack types: I4 vs Obj
			//IL_11ec->IL013a: Incompatible stack heights: 3 vs 1
			//IL_1058->IL013a: Incompatible stack heights: 5 vs 1
			//IL_08b4->IL013a: Incompatible stack heights: 3 vs 1
			//IL_0d94->IL013a: Incompatible stack types: I4 vs Obj
			//IL_047c->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0522->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0b47->IL013a: Incompatible stack types: I4 vs Obj
			//IL_09bc->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0b0f->IL013a: Incompatible stack types: I4 vs Obj
			//IL_055a->IL013a: Incompatible stack types: I4 vs Obj
			//IL_09fd->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0c6f->IL013a: Incompatible stack types: I4 vs Obj
			//IL_07de->IL013a: Incompatible stack types: I4 vs Obj
			//IL_03b3->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0c8d->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0736->IL0d77: Incompatible stack heights: 1 vs 0
			//IL_0542->IL013a: Incompatible stack types: I4 vs Obj
			//IL_101e->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0df4->IL013a: Incompatible stack heights: 5 vs 1
			//IL_0578->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0dc1->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0401->IL013a: Incompatible stack heights: 2 vs 1
			//IL_0c28->IL013a: Incompatible stack types: I4 vs Obj
			//IL_08ca->IL013a: Incompatible stack types: I4 vs Obj
			//IL_088b->IL013a: Incompatible stack heights: 2 vs 1
			//IL_05b1->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0d6c->IL013a: Incompatible stack heights: 3 vs 1
			//IL_0ac7->IL013a: Incompatible stack heights: 5 vs 1
			//IL_0920->IL013a: Incompatible stack heights: 5 vs 1
			//IL_0d18->IL013a: Incompatible stack types: I4 vs Obj
			//IL_107a->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0be0->IL013a: Incompatible stack types: I4 vs Obj
			//IL_10aa->IL013a: Incompatible stack heights: 3 vs 1
			//IL_10c7->IL013a: Incompatible stack types: I4 vs Obj
			//IL_050e->IL013a: Incompatible stack heights: 4 vs 1
			//IL_0832->IL013a: Incompatible stack types: I4 vs Obj
			//IL_093e->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0ee7->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0efb->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0878->IL013a: Incompatible stack heights: 4 vs 1
			//IL_1125->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0633->IL013a: Incompatible stack heights: 2 vs 1
			//IL_0970->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0b7f->IL013a: Incompatible stack types: I4 vs Obj
			//IL_06ab->IL013a: Incompatible stack types: I4 vs Obj
			//IL_04ae->IL013a: Incompatible stack types: I4 vs Obj
			//IL_1198->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0e2a->IL013a: Incompatible stack types: I4 vs Obj
			//IL_061b->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0f44->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0fbe->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0e78->IL013a: Incompatible stack types: I4 vs Obj
			//IL_06e9->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0b27->IL013a: Incompatible stack types: I4 vs Obj
			//IL_076b->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0695->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0814->IL013a: Incompatible stack types: I4 vs Obj
			//IL_113b->IL013a: Incompatible stack types: I4 vs Obj
			//IL_07af->IL013a: Incompatible stack heights: 3 vs 1
			//IL_11f7->IL013a: Incompatible stack heights: 3 vs 1
			//IL_0d9f->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0487->IL013a: Incompatible stack types: I4 vs Obj
			//IL_09c7->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0658->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0f9d->IL013a: Incompatible stack types: I4 vs Obj
			//IL_120c->IL121f: Incompatible stack heights: 1 vs 3
			//IL_07e9->IL013a: Incompatible stack types: I4 vs Obj
			//IL_03be->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0c98->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0740->IL013a: Incompatible stack heights: 2 vs 1
			//IL_0dff->IL013a: Incompatible stack heights: 5 vs 1
			//IL_0583->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0dcc->IL013a: Incompatible stack types: I4 vs Obj
			//IL_040c->IL013a: Incompatible stack heights: 2 vs 1
			//IL_0e4a->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0d77->IL013a: Incompatible stack heights: 3 vs 1
			//IL_10e7->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0d23->IL013a: Incompatible stack types: I4 vs Obj
			//IL_1085->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0901->IL013a: Incompatible stack types: I4 vs Obj
			//IL_10b5->IL013a: Incompatible stack heights: 3 vs 1
			//IL_083d->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0bae->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0949->IL013a: Incompatible stack types: I4 vs Obj
			//IL_12af->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0fa8->IL013a: Incompatible stack types: I4 vs Obj
			//IL_124d->IL013a: Incompatible stack heights: 5 vs 1
			//IL_1292->IL013a: Incompatible stack heights: 2 vs 1
			//IL_0e55->IL013a: Incompatible stack types: I4 vs Obj
			//IL_090c->IL013a: Incompatible stack types: I4 vs Obj
			//IL_0bb9->IL013a: Incompatible stack types: I4 vs Obj
			//IL_12cc->IL0136: Incompatible stack heights: 1 vs 0
			//IL_1258->IL013a: Incompatible stack heights: 5 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 1;
			object obj = awaiter;
			while (true)
			{
				int num;
				object obj2;
				switch ((int)obj)
				{
				case 4:
					if ((nuint)(nint)awaiter > (nuint)6u)
					{
						num = 0;
						if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute == null)
						{
							num = 1;
						}
						goto IL_0074;
					}
					goto IL_00c3;
				case 3:
					return;
				case 5:
					goto IL_14f4;
				case 1:
					awaiter = Microsoft.Windows.Foundation.UndockedRegFreeWinRTCS.AutoInitialize.ConvertAttribute;
					obj = 0;
					if (((App)App.Logger__BackingField).Window__BackingField == null)
					{
						obj = 0;
					}
					break;
				case 2:
					((ObservableCollection<ChatModel>)Unsafe.AsPointer(ref ((App)Unsafe.AsPointer(ref this))._contentLoaded))._002Ector();
					obj = 3;
					break;
				default:
					{
						awaiter = App.CheckAlphabeticDictionary;
						obj = 0;
						if ((int)((App._003CLogout_003Ed__15*)App._003CLogout_003Ed__15._003C_003E1__state)->_003C_003Et__builder == 0)
						{
							obj = 4;
						}
						break;
					}
					IL_00c3:
					num = 4;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
					{
						num = 4;
					}
					goto IL_0074;
					IL_14f4:
					__KnownINotifyPropertyChangedArgs.Customers = (PropertyChangedEventArgs)(-2);
					obj = 2;
					if (__KnownINotifyPropertyChangedArgs.DecorateLocalModel != null)
					{
						obj = 2;
					}
					break;
					IL_0074:
					while (true)
					{
						switch (num)
						{
						case 1:
							if (IEnumerator_object.Do_Abi_MoveNext_2((nint)awaiter, (byte*)IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized) != 0)
							{
								num = 3;
								if (IList_object.PatchAttribute != null)
								{
									num = 1;
								}
								continue;
							}
							break;
						case 4:
							goto IL_0107;
						case 2:
						case 3:
							goto IL_14f4;
						}
						break;
					}
					goto IL_00c3;
					IL_0107:
					switch ((int)awaiter)
					{
					default:
						obj2 = 74;
						goto IL_013a;
					case 2:
						awaiter = __KnownINotifyPropertyChangingArgs.Username;
						obj2 = 3;
						if (__KnownINotifyPropertyChangingArgs.LoginAt != null)
						{
							obj2 = 39;
						}
						goto IL_013a;
					case 4:
						goto IL_083d;
					case 5:
						goto IL_0ac7;
					case 1:
						goto IL_0c04;
					case 3:
						goto IL_0c98;
					case 6:
						goto IL_0cbc;
					case 0:
						goto IL_0efb;
						IL_013a:
						while (true)
						{
							byte b;
							_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0 obj3;
							VirtualizingLayout val;
							object obj4;
							Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails mass_WinUI_Controls_MobileGameCardWinRTTypeDetails;
							switch ((int)obj2)
							{
							case 19:
								return;
							case 2:
								_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Initialized;
								_ = 42;
								continue;
							case 26:
							case 75:
								awaiter = IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_039d: Stack underflow*/, (INotifyPropertyChanged)/*Error near IL_039d: Stack underflow*/, ref *(uint*)(&awaiter));
								obj2 = 30;
								if (IEnumerable_System_IDisposable.CombineAttribute != null)
								{
									obj2 = 1;
								}
								continue;
							case 24:
								awaiter = IEnumerable_object._initialized;
								obj2 = 70;
								continue;
							case 88:
								Interlocked.CompareExchange(ref Unsafe.As<object, Func<InfoBarDelegate>>(ref IEnumerable_object.ReflectSetAttribute), (Func<InfoBarDelegate>)(&awaiter), (Func<InfoBarDelegate>)Unsafe.AsPointer(ref this));
								_ = 44;
								if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute != null)
								{
									_ = 18;
								}
								continue;
							case 120:
								Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute = awaiter;
								awaiter = 88;
								goto IL_0136;
							case 63:
							case 81:
								IEnumerable_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
								(IEnumerable_System_ComponentModel_INotifyPropertyChanged.DecorateSeparatedAttribute() ? ((AsyncTaskMethodBuilder*)1) : ((AsyncTaskMethodBuilder*)null))->Start(ref *(_003CExportAccounts_003Ed__26*)MarshalInspectable<object>.FromAbi((IntPtr)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectMonoAttribute()));
								awaiter = 73;
								goto IL_0136;
							case 58:
								IListMethods<object>.Abi_SetAt_4((IntPtr)/*Error near IL_044e: Stack underflow*/, (uint)/*Error near IL_044e: Stack underflow*/, (object)/*Error near IL_044e: Stack underflow*/);
								IListMethods<object>.Abi_Append_7((IntPtr)/*Error near IL_0461: Stack underflow*/, (object)IList_object.Do_Abi_IndexOf_3((nint)/*Error near IL_045c: Stack underflow*/, (nint)/*Error near IL_045c: Stack underflow*/, (uint*)(int)IList_object.Do_Abi_GetView_2((nint)/*Error near IL_0455: Stack underflow*/, (nint*)(nint)awaiter), (byte*)(nint)awaiter));
								IListMethods<object>.Abi_RemoveAtEnd_8((IntPtr)/*Error near IL_0466: Stack underflow*/);
								awaiter = (object)/*Error near IL_0468: Stack underflow*/;
								obj2 = 16;
								if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule != null)
								{
									obj2 = 41;
								}
								continue;
							case 12:
								_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout = (TimeSpan)awaiter;
								obj2 = 62;
								if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator == null)
								{
									obj2 = 87;
								}
								continue;
							case 6:
								_ = ref __KnownINotifyPropertyChangingArgs.Notes;
								_ = ref awaiter;
								WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>((IAsyncOperation<ContentDialogResult>)(object)Unsafe.AsPointer(ref this));
								_ = 98;
								continue;
							case 50:
								break;
							case 114:
								_ = null;
								_ = IEnumerator_System_ComponentModel_INotifyPropertyChanged.Initialized;
								_ = 51;
								continue;
							case 59:
								awaiter = 2;
								__KnownINotifyPropertyChangingArgs.IsMyself = (PropertyChangingEventArgs)2;
								obj2 = 65;
								continue;
							case 79:
								((AsyncTaskMethodBuilder*)/*Error near IL_0538: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<ContentDialogResult>*)/*Error near IL_0538: Stack underflow*/, ref *(_003CLoginByHistory_003Ed__25*)IEnumerator_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Current_0((nint)(int)IEnumerator_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_052c: Stack underflow*/, (uint)/*Error near IL_052c: Stack underflow*/, (nint)/*Error near IL_052c: Stack underflow*/, (uint*)(int)IEnumerator_System_ComponentModel_INotifyPropertyChanged.Do_Abi_MoveNext_2((nint)/*Error near IL_0527: Stack underflow*/, (byte*)/*Error near IL_0527: Stack underflow*/)), (nint*)(nint)awaiter));
								obj2 = 104;
								continue;
							case 66:
								Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.IsSkeleton).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<DesktopSession>*)(&awaiter), ref this);
								obj2 = 103;
								continue;
							case 84:
								awaiter = 6;
								__KnownINotifyPropertyChangingArgs.ShowMaxPlayer = (PropertyChangingEventArgs)6;
								obj2 = 0;
								if (__KnownINotifyPropertyChangingArgs.MaxPlayers == null)
								{
									obj2 = 0;
								}
								continue;
							case 98:
								return;
							case 99:
								((AsyncTaskMethodBuilder*)/*Error near IL_05a7: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)IReadOnlyList_System_IDisposable.Do_Abi_IndexOf_2((nint)/*Error near IL_059c: Stack underflow*/, (nint)/*Error near IL_059c: Stack underflow*/, (uint*)/*Error near IL_059c: Stack underflow*/, (byte*)(int)IReadOnlyList_System_IDisposable.Do_Abi_GetAt_0((nint)/*Error near IL_0597: Stack underflow*/, (uint)/*Error near IL_0597: Stack underflow*/, (nint*)/*Error near IL_0597: Stack underflow*/)), ref *(_003CLoginRandom_003Ed__85*)__KnownINotifyPropertyChangingArgs.Version);
								obj2 = 43;
								continue;
							case 17:
								awaiter = -1;
								__KnownINotifyPropertyChangingArgs.IsLiked = (PropertyChangingEventArgs)(-1);
								obj2 = 52;
								continue;
							case 36:
								return;
							case 1:
							case 96:
								throw new IEnumerableMethods<IDisposable, nint>((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)/*Error near IL_060c: Stack underflow*/);
							case 22:
							case 46:
							case 48:
							case 72:
							case 107:
							case 117:
							case 122:
								awaiter = awaiter;
								obj2 = 101;
								continue;
							case 131:
								_ = ref __KnownINotifyPropertyChangingArgs.PreviewImage;
								((AsyncTaskMethodBuilder*)(&awaiter))->Start(ref Unsafe.As<_003CLoginDesktop_003Ed__87, ImportAccountViewModel._003CPrimaryAsync_003Ed__46>(ref this));
								_ = 86;
								continue;
							case 92:
								return;
							case 69:
								if (IEnumerableMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(&awaiter)))
								{
									obj2 = 14;
									continue;
								}
								goto case 47;
							case 3:
								__KnownINotifyPropertyChangingArgs.Executor = null;
								obj2 = 68;
								continue;
							case 37:
								__KnownINotifyPropertyChangingArgs.State = (PropertyChangingEventArgs)awaiter;
								obj2 = 2;
								if (__KnownINotifyPropertyChangingArgs.OperationText == null)
								{
									obj2 = 6;
								}
								continue;
							case 10:
								ComWrappersSupport.RegisterTypeComInterfaceEntriesLookup((Func<Type, ComWrappers.ComInterfaceEntry[]>)(&awaiter));
								if ((int)/*Error near IL_06a1: Stack underflow*/ != 0)
								{
									obj2 = 95;
									continue;
								}
								goto case 59;
							case 29:
								awaiter = IEnumerator_System_IDisposable.Do_Abi_get_HasCurrent_1((nint)(int)IEnumerator_System_IDisposable.Do_Abi_GetMany_3((nint)/*Error near IL_06bd: Stack underflow*/, 0u, (nint)((object)IEnumerator_System_IDisposable.Init()).ToString(), (uint*)(nint)awaiter), (byte*)(nint)__KnownINotifyPropertyChangingArgs.OrderId);
								obj2 = 112;
								if (__KnownINotifyPropertyChangingArgs.OrderAt == null)
								{
									obj2 = 122;
								}
								continue;
							case 126:
								awaiter = -1;
								__KnownINotifyPropertyChangingArgs.PayAt = (PropertyChangingEventArgs)(-1);
								awaiter = 75;
								goto IL_0136;
							case 40:
								goto IL_0701;
							case 77:
								_ = ref awaiter;
								if (INotifyCollectionChangedMethods.AbiToProjectionVftablePtr == (IntPtr)0)
								{
									_ = 76;
									continue;
								}
								goto case 56;
							case 31:
								__KnownINotifyPropertyChangingArgs.TotalPoints = null;
								obj2 = 112;
								if (__KnownINotifyPropertyChangingArgs.Quantity != null)
								{
									obj2 = 124;
								}
								continue;
							case 103:
								return;
							case 42:
								IEnumerable_object.SaveAttribute();
								_ = 41;
								if (__KnownINotifyPropertyChangingArgs.SelectedAccounts == null)
								{
									_ = 114;
								}
								continue;
							case 74:
								awaiter = __KnownINotifyPropertyChangingArgs.CurrentDisplayPage;
								obj2 = 28;
								if (__KnownINotifyPropertyChangingArgs.Input4399Username == null)
								{
									obj2 = 8;
								}
								continue;
							case 39:
								__KnownINotifyPropertyChangingArgs.InputEmail = null;
								obj2 = 116;
								if (__KnownINotifyPropertyChangingArgs.Input163Password != null)
								{
									obj2 = 22;
								}
								continue;
							case 116:
								awaiter = -1;
								__KnownINotifyPropertyChangingArgs.InputMobilePassword = (PropertyChangingEventArgs)(-1);
								obj2 = 67;
								if (__KnownINotifyPropertyChangingArgs.InputVerifyCode != null)
								{
									obj2 = 26;
								}
								continue;
							case 7:
								goto IL_083d;
							case 128:
								goto IL_084f;
							case 78:
							case 97:
								_ = ref awaiter;
								awaiter = (nint)IAnimationObjectMethods.AbiToProjectionVftablePtr;
								_ = 32;
								continue;
							case 55:
								goto IL_088b;
							case 91:
								__KnownINotifyPropertyChangingArgs.ParseErrorMessage = null;
								obj2 = 17;
								continue;
							case 110:
								switch ((int)awaiter)
								{
								case 4:
									break;
								case 3:
									goto IL_0701;
								case 2:
									goto IL_084f;
								default:
									goto IL_08ed;
								case 0:
									goto IL_0bcd;
								case 6:
									goto IL_0d39;
								case 1:
									goto IL_115f;
								case 5:
									goto IL_11f7;
								}
								goto case 58;
							case 106:
								_ = 1;
								Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateInternalAttribute();
								_ = 24;
								continue;
							case 121:
								awaiter = 3;
								__KnownINotifyPropertyChangingArgs.LanGamesEmptyText = (PropertyChangingEventArgs)3;
								obj2 = 4;
								if (__KnownINotifyPropertyChangingArgs.LikeNetGames != null)
								{
									obj2 = 90;
								}
								continue;
							default:
								__KnownINotifyPropertyChangingArgs.FourLikeNetGames = (PropertyChangingEventArgs)awaiter;
								obj2 = 131;
								if (__KnownINotifyPropertyChangingArgs.LikeNetGamesEmptyText == null)
								{
									obj2 = 23;
								}
								continue;
							case 64:
								goto IL_0992;
							case 38:
								awaiter = -1;
								__KnownINotifyPropertyChangingArgs.SkinOwnedSelected = (PropertyChangingEventArgs)(-1);
								obj2 = 97;
								continue;
							case 67:
							case 95:
								((Regex)(&awaiter))._002Ector();
								awaiter = (object)/*Error near IL_09f3: Stack underflow*/;
								obj2 = 62;
								continue;
							case 34:
								__KnownINotifyPropertyChangingArgs.SelectedPageOfSkin = null;
								obj2 = 126;
								continue;
							case 33:
								awaiter = -1;
								__KnownINotifyPropertyChangingArgs.LastSearchText = (PropertyChangingEventArgs)(-1);
								obj2 = 18;
								continue;
							case 73:
							{
								PropertyChangingEventArgs searchVisibility = __KnownINotifyPropertyChangingArgs.SearchVisibility;
								((Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails)(object)((Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails)(object)Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.DecorateReadableAttribute()).GetExposedInterfaces())._002Ector();
								((RegexRunner)(object)searchVisibility).CheckTimeout();
								awaiter = (object)((ReadOnlySpan<char>*)/*Error near IL_0a69: Stack underflow*/)->Slice((int)/*Error near IL_0a69: Stack underflow*/);
								awaiter = 106;
								goto IL_0136;
							}
							case 44:
								return;
							case 102:
								goto IL_0a97;
							case 27:
								goto IL_0ac7;
							case 127:
								goto IL_0ad9;
							case 65:
								__KnownINotifyPropertyChangingArgs.ShowTabs = (PropertyChangingEventArgs)awaiter;
								obj2 = 109;
								continue;
							case 45:
							case 57:
								throw new Application();
							case 30:
							case 32:
							case 62:
							case 82:
							case 115:
							case 119:
							case 130:
								__KnownINotifyPropertyChangingArgs.CanSelect = (PropertyChangingEventArgs)awaiter;
								obj2 = 99;
								continue;
							case 86:
								return;
							case 60:
								__KnownINotifyPropertyChangingArgs.ShopDescription = null;
								obj2 = 94;
								continue;
							case 8:
								awaiter = 5;
								__KnownINotifyPropertyChangingArgs.HasShopDescription = (PropertyChangingEventArgs)5;
								obj2 = 120;
								if (__KnownINotifyPropertyChangingArgs.CurrentPage != null)
								{
									obj2 = 51;
								}
								continue;
							case 118:
								((FrameworkElement)/*Error near IL_0b95: Stack underflow*/).RequestedTheme = (ElementTheme)(ref awaiter);
								if ((int)/*Error near IL_0b9a: Stack underflow*/ != 0)
								{
									obj2 = 78;
									if (__KnownINotifyPropertyChangingArgs.ProductGroups == null)
									{
										obj2 = 21;
									}
									continue;
								}
								goto case 4;
							case 4:
								awaiter = 0;
								__KnownINotifyPropertyChangingArgs.SelectedProductGroupIndex = (PropertyChangingEventArgs)0;
								obj2 = 37;
								continue;
							case 111:
								goto IL_0bcd;
							case 9:
								goto IL_0c04;
							case 90:
								__KnownINotifyPropertyChangingArgs.SelectedTopUpGroupIndex = (PropertyChangingEventArgs)awaiter;
								obj2 = 66;
								continue;
							case 68:
								awaiter = -1;
								__KnownINotifyPropertyChangingArgs.PayMethods = (PropertyChangingEventArgs)(-1);
								obj2 = 23;
								continue;
							case 76:
								awaiter = 4;
								__KnownINotifyPropertyChangingArgs.Orders = (PropertyChangingEventArgs)4;
								obj2 = 8;
								if (__KnownINotifyPropertyChangingArgs.InviteCode == null)
								{
									obj2 = 12;
								}
								continue;
							case 21:
								goto IL_0c98;
							case 11:
							case 53:
							case 85:
							case 104:
								awaiter = __KnownINotifyPropertyChangingArgs.CanRedeem;
								obj2 = 110;
								continue;
							case 49:
								goto IL_0cbc;
							case 108:
								Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.RedeemOptions).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityRentalGameItem[]>*)(&awaiter), ref Unsafe.As<_003CLoginDesktop_003Ed__87, MobileViewModel._003CRefreshRentalGames_003Ed__22>(ref this));
								obj2 = 36;
								if (__KnownINotifyPropertyChangedArgs.UserId == null)
								{
									obj2 = 8;
								}
								continue;
							case 5:
								__KnownINotifyPropertyChangedArgs.Username = null;
								obj2 = 38;
								continue;
							case 100:
								goto IL_0d39;
							case 56:
								((IAsyncStateMachine)/*Error near IL_0d7e: Stack underflow*/).SetStateMachine((IAsyncStateMachine)(&awaiter));
								awaiter = (object)/*Error near IL_0d80: Stack underflow*/;
								obj2 = 115;
								if (__KnownINotifyPropertyChangedArgs.ShowMaxPlayer != null)
								{
									obj2 = 87;
								}
								continue;
							case 87:
								Unsafe.As<PropertyChangedEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangedArgs.OnlinePlayers).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityMassShop>*)(&awaiter), ref Unsafe.As<_003CLoginDesktop_003Ed__87, PaymentViewModel._003CRefreshShopCollection_003Ed__93>(ref this));
								obj2 = 16;
								if (__KnownINotifyPropertyChangedArgs.Description == null)
								{
									obj2 = 19;
								}
								continue;
							case 83:
								MainContent.ReflectTransferableRole();
								_ = 0;
								XamlBindingHelper.ConvertValue((Type)awaiter, (object)new MainContent.IMainContent_Bindings());
								_ = 2;
								if (__KnownINotifyPropertyChangedArgs.IsLiked == null)
								{
									_ = 1;
								}
								continue;
							case 18:
								awaiter = (object)new Window();
								((MainContent.IMainContent_BindingsScopeConnector)/*Error near IL_0e0b: Stack underflow*/).Parent = (WeakReference)/*Error near IL_0e0b: Stack underflow*/;
								obj2 = 58;
								if (__KnownINotifyPropertyChangedArgs.Title == null)
								{
									obj2 = 129;
								}
								continue;
							case 93:
								((OverlappedPresenter)/*Error near IL_0e31: Stack underflow*/).IsMaximizable = (byte)(&awaiter) != 0;
								if ((int)/*Error near IL_0e36: Stack underflow*/ != 0)
								{
									obj2 = 7;
									if (__KnownINotifyPropertyChangedArgs.State == null)
									{
										obj2 = 26;
									}
									continue;
								}
								goto case 121;
							case 28:
								switch (awaiter - 1)
								{
								case 0:
									break;
								case 2:
								case 3:
									goto IL_0992;
								case 1:
									goto IL_0ad9;
								default:
									goto IL_0e6e;
								}
								goto case 79;
							case 47:
								awaiter = 1;
								__KnownINotifyPropertyChangedArgs.StateText = (PropertyChangedEventArgs)1;
								obj2 = 113;
								continue;
							case 35:
								goto IL_0e8c;
							case 123:
								goto IL_0ebc;
							case 124:
								awaiter = -1;
								__KnownINotifyPropertyChangedArgs.PayUrl = (PropertyChangedEventArgs)(-1);
								obj2 = 56;
								continue;
							case 20:
								goto IL_0efb;
							case 23:
							case 105:
								((FrameworkElement)/*Error near IL_0f23: Stack underflow*/).HorizontalAlignment = (HorizontalAlignment)(ref awaiter);
								awaiter = (object)/*Error near IL_0f25: Stack underflow*/;
								obj2 = 119;
								if (__KnownINotifyPropertyChangedArgs.TotalCoins != null)
								{
									obj2 = 36;
								}
								continue;
							case 13:
								goto IL_0f44;
							case 70:
								switch ((int)awaiter)
								{
								case 4:
									break;
								case 1:
									goto IL_088b;
								case 2:
									goto IL_0a97;
								case 3:
									goto IL_0e8c;
								case 6:
									goto IL_0ebc;
								case 0:
									goto IL_0f44;
								default:
									goto IL_0f89;
								case 5:
									goto IL_102d;
								}
								goto case 29;
							case 25:
								Application.Start((ApplicationInitializationCallback)(object)(&awaiter));
								if ((int)/*Error near IL_0fb4: Stack underflow*/ == 0)
								{
									obj2 = 84;
									continue;
								}
								goto case 18;
							case 15:
								__KnownINotifyPropertyChangedArgs.CurrentDisplayPage = null;
								obj2 = 33;
								continue;
							case 80:
								((MainWindow._003C_003Ec__DisplayClass1_0)awaiter)._003CSwitchToMainMode_003Eb__0();
								((Dictionary<string, IXamlType>)/*Error near IL_1014: Stack underflow*/).Add((string)/*Error near IL_1014: Stack underflow*/, (IXamlType)null);
								obj2 = 60;
								continue;
							case 54:
								goto IL_102d;
							case 109:
								((Settings)/*Error near IL_1066: Stack underflow*/).BindEnum<EnumAutoNavigateToInstanceAfterLaunchType>((ComboBox)(object)Unsafe.AsPointer(ref __KnownINotifyPropertyChangedArgs.InfoBarMessage), (string)(&awaiter), (Action<EnumAutoNavigateToInstanceAfterLaunchType>?)Unsafe.AsPointer(ref this));
								obj2 = 92;
								if (__KnownINotifyPropertyChangedArgs.IsDragging == null)
								{
									obj2 = 70;
								}
								continue;
							case 112:
								Program.DecorateAttachedDecryptor();
								Program.CheckGlobalError();
								((XamlControlsResources)awaiter)._002Ector();
								_ = 65;
								if (__KnownINotifyPropertyChangedArgs.ImportedCount != null)
								{
									_ = 83;
								}
								continue;
							case 113:
								__KnownINotifyPropertyChangedArgs.SkippedCount = (PropertyChangedEventArgs)awaiter;
								obj2 = 108;
								continue;
							case 101:
							{
								XamlTypeInfoProvider provider = ((XamlMetaDataProvider)(object)Program._003C_003Ec.PresentTester()).Provider;
								((EmptyCollectionToObjectConverter)awaiter)._002Ector();
								if (provider == null)
								{
									obj2 = 112;
									continue;
								}
								goto case 42;
							}
							case 129:
								((DoubleToObjectConverter)/*Error near IL_1110: Stack underflow*/)._002Ector();
								CastExtensions.As<SettingsCard>((object)new XamlMetaDataProvider());
								obj2 = 89;
								continue;
							case 41:
								awaiter = (object)new ImplicitAnimationSet();
								if ((int)/*Error near IL_1131: Stack underflow*/ != 0)
								{
									obj2 = 105;
									continue;
								}
								goto case 8;
							case 16:
								goto IL_115f;
							case 14:
							case 52:
								((Collection<AccountModel>)(&awaiter))._002Ector();
								awaiter = (object)/*Error near IL_11a1: Stack underflow*/;
								awaiter = 130;
								goto IL_0136;
							case 43:
								((SwitchPresenter)/*Error near IL_11b4: Stack underflow*/)._002Ector();
								((Case)__KnownINotifyPropertyChangedArgs.SelectedSkin)._002Ector();
								((Segmented)/*Error near IL_11c4: Stack underflow*/)._002Ector();
								awaiter = (object)/*Error near IL_11c6: Stack underflow*/;
								obj2 = 25;
								continue;
							case 51:
								((XamlTypeInfoProvider)0).Activate_15_EmptyObjectToObjectConverter();
								_ = 57;
								if (__KnownINotifyPropertyChangedArgs.LastSearchText == null)
								{
									_ = 80;
								}
								continue;
							case 71:
								goto IL_11f7;
							case 89:
							{
								PropertyChangedEventArgs inputUsername = __KnownINotifyPropertyChangedArgs.InputUsername;
								if (inputUsername == null)
								{
									awaiter = 61;
									goto IL_0136;
								}
								((XamlTypeInfoProvider)((XamlTypeInfoProvider)(object)inputUsername).Activate_91_TableViewTextColumn()).Activate_93_TableViewTemplateColumn();
								_ = 125;
								continue;
							}
							case 61:
							case 125:
							{
								PropertyChangedEventArgs canDesktopMenuInvoke = __KnownINotifyPropertyChangedArgs.CanDesktopMenuInvoke;
								if (canDesktopMenuInvoke == null)
								{
									obj2 = 81;
									continue;
								}
								((BehaviorCollection)canDesktopMenuInvoke)._002Ector();
								((XamlTypeInfoProvider)/*Error near IL_12be: Stack underflow*/).Activate_97_Collection();
								awaiter = 63;
								goto IL_0136;
							}
							case 94:
								goto end_IL_010b;
								IL_102d:
								((Dictionary<Type, IXamlType>)/*Error near IL_1038: Stack underflow*/).TryGetValue((Type)0, out *(IXamlType*)MainWindow._003C_003Ec__DisplayClass1_0.CheckControllableSolver());
								Sessions.DesktopUser = (DesktopSession?)awaiter;
								_ = Sessions.MobileUser;
								_ = 1;
								awaiter = Sessions.HadDesktopLogin();
								_ = 48;
								continue;
								IL_0f89:
								obj2 = 0;
								if (__KnownINotifyPropertyChangedArgs.MobileAccounts != null)
								{
									obj2 = 1;
								}
								continue;
								IL_0701:
								_ = IListMethods.IID;
								IEnumerable_System_IDisposable.Do_Abi_First_0((nint)(int)IEnumerable_System_IDisposable.Init(), (nint*)(nint)awaiter);
								_ = IEnumerableMethods.AbiToProjectionVftablePtr;
								awaiter = INotifyCollectionChangedMethods.IID;
								_ = 77;
								continue;
								IL_0f44:
								((MainWindow)/*Error near IL_0f4a: Stack underflow*/).AppWindowClosing((object)/*Error near IL_0f4a: Stack underflow*/, (object)0);
								((AppWindowTitleBar)/*Error near IL_0f4f: Stack underflow*/).PreferredTheme = (TitleBarTheme)/*Error near IL_0f4f: Stack underflow*/;
								awaiter = ((MainWindow)/*Error near IL_0f5a: Stack underflow*/).GetBindingConnector((int)/*Error near IL_0f5a: Stack underflow*/, (object)__KnownINotifyPropertyChangedArgs.CreatedAt);
								obj2 = 22;
								continue;
								IL_0ebc:
								((MainContent.MainContent_obj1_Bindings)/*Error near IL_0ece: Stack underflow*/).Loading((FrameworkElement)(object)((Window)((MainContent.MainContent_obj1_Bindings)/*Error near IL_0ec2: Stack underflow*/).SetDataRoot((object)0)).DispatcherQueue, awaiter);
								((MainContent.MainContent_obj1_Bindings)/*Error near IL_0ed5: Stack underflow*/).Update_((object)/*Error near IL_0ed5: Stack underflow*/, (uint)(int)awaiter);
								((MainContent.MainContent_obj1_Bindings)/*Error near IL_0edb: Stack underflow*/).Update_HamburgerView((object)/*Error near IL_0edb: Stack underflow*/, 0u);
								awaiter = (object)/*Error near IL_0edd: Stack underflow*/;
								obj2 = 107;
								continue;
								IL_0e8c:
								((MainContent.MainContent_obj1_Bindings)/*Error near IL_0e92: Stack underflow*/).Connect((int)/*Error near IL_0e92: Stack underflow*/, (object)0);
								((OverlappedPresenter)/*Error near IL_0e97: Stack underflow*/).IsMinimizable = (byte)/*Error near IL_0e97: Stack underflow*/ != 0;
								((MainContent.MainContent_obj1_Bindings)awaiter).Initialize();
								((MainContent.MainContent_obj1_Bindings)awaiter).Update();
								((MainContent.MainContent_obj1_Bindings)/*Error near IL_0eb0: Stack underflow*/).DisconnectUnloadedObject((int)__KnownINotifyPropertyChangedArgs.Id);
								awaiter = (object)/*Error near IL_0eb2: Stack underflow*/;
								obj2 = 117;
								continue;
								IL_0e6e:
								obj2 = 85;
								continue;
								IL_0136:
								obj2 = awaiter;
								continue;
								IL_0ad9:
								b = ((_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner)/*Error near IL_0ae3: Stack underflow*/).TryMatchAtCurrentPosition((ReadOnlySpan<char>)((_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner)/*Error near IL_0ade: Stack underflow*/).TryFindNextPossibleStartingPosition((ReadOnlySpan<char>)/*Error near IL_0ade: Stack underflow*/));
								((_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner)awaiter)._002Ector();
								((AsyncTaskMethodBuilder*)/*Error near IL_0aef: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)/*Error near IL_0aef: Stack underflow*/, ref *(InstanceViewModel._003COperation_003Ed__11*)b);
								awaiter = 53;
								goto IL_0136;
								IL_0a97:
								((_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0)0)._002Ector();
								char.IsAsciiLetterOrDigit((char)/*Error near IL_0aa2: Stack underflow*/);
								_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.CheckScalableAttribute();
								obj3 = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.CheckModularTransaction();
								((_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory)(object)__KnownINotifyPropertyChangingArgs.Instances)._002Ector();
								awaiter = obj3;
								_ = 72;
								continue;
								IL_0992:
								((Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails)/*Error near IL_0997: Stack underflow*/)._002Ector();
								(Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.ReflectCustomAttribute() ? ((AsyncTaskMethodBuilder*)1) : ((AsyncTaskMethodBuilder*)null))->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)awaiter, ref *(DesktopViewModel._003CSelectSkin_003Ed__112*)Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.CheckAdvancedAttribute());
								obj2 = 11;
								if (__KnownINotifyPropertyChangingArgs.SkinAllSelected == null)
								{
									obj2 = 2;
								}
								continue;
								IL_11f7:
								((NavigationViewItemPresenter)/*Error near IL_11fc: Stack underflow*/)._002Ector();
								if (__KnownINotifyPropertyChangedArgs.CoreResources == null)
								{
									_ = null;
									__ldftn(XamlTypeInfoProvider.Activate_20_DateTimeToStringFormatConverter);
									__KnownINotifyPropertyChangedArgs.SelectedItem = (PropertyChangedEventArgs)new ItemsRepeater();
								}
								val = new VirtualizingLayout();
								((FluentIcon)null)._002Ector();
								((AttachedCardShadow)val)._002Ector();
								awaiter = (object)__ldftn(XamlTypeInfoProvider.Activate_23_InverseBoolToVisibilityConverter);
								_ = 94;
								if (__KnownINotifyPropertyChangedArgs.Instances == null)
								{
									_ = 118;
								}
								continue;
								IL_115f:
								((XamlTypeInfoProvider)awaiter).InitTypeTables();
								((TableViewConditionalCellStyle)((XamlTypeInfoProvider)/*Error near IL_116d: Stack underflow*/).LookupTypeIndexByName(awaiter))._002Ector();
								((TableViewTextColumn)/*Error near IL_1177: Stack underflow*/)._002Ector();
								awaiter = (object)/*Error near IL_1179: Stack underflow*/;
								obj2 = 3;
								if (__KnownINotifyPropertyChangedArgs.CurrentSkinPage == null)
								{
									obj2 = 10;
								}
								continue;
								IL_0d39:
								_ = MassIrcService.Instance;
								((App)awaiter).GetXmlnsDefinitions();
								obj4 = awaiter;
								App._002Ecctor();
								MassService.Instance.Logout();
								awaiter = obj4;
								_ = 41;
								if (__KnownINotifyPropertyChangedArgs.IsSelected == null)
								{
									_ = 69;
								}
								continue;
								IL_0bcd:
								((Microsoft.Windows.ApplicationModel.WindowsAppRuntime.Common.AutoInitialize)awaiter)._002Ector();
								awaiter = (object)/*Error near IL_0bd6: Stack underflow*/;
								obj2 = 82;
								continue;
								IL_08ed:
								obj2 = 19;
								if (__KnownINotifyPropertyChangingArgs.HasSelectedGame == null)
								{
									obj2 = 45;
								}
								continue;
								IL_088b:
								((Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails)/*Error near IL_0890: Stack underflow*/)._002Ector();
								_ = IVisualElementMethods.AbiToProjectionVftablePtr;
								mass_WinUI_Controls_MobileGameCardWinRTTypeDetails = Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.DecorateOperationalAttribute();
								((Mass_WinUI_Pages_MobileWinRTTypeDetails)(object)((Mass_WinUI_Pages_MobileWinRTTypeDetails)awaiter).GetExposedInterfaces())._002Ector();
								awaiter = mass_WinUI_Controls_MobileGameCardWinRTTypeDetails;
								_ = 46;
								continue;
								IL_084f:
								_ = IEnumeratorMethods<IDisposable>.IID;
								((Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails)awaiter).GetExposedInterfaces();
								((Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails)awaiter)._002Ector();
								_ = IUIElementOverridesMethods.AbiToProjectionVftablePtr;
								awaiter = (nint)IAnimationObjectMethods.IID;
								_ = 93;
								continue;
							}
							break;
						}
						goto case 2;
						IL_0efb:
						awaiter = __KnownINotifyPropertyChangedArgs.Image;
						obj2 = 5;
						goto IL_013a;
						IL_0cbc:
						awaiter = __KnownINotifyPropertyChangingArgs.CustomerCount;
						obj2 = 15;
						if (__KnownINotifyPropertyChangingArgs.Customers == null)
						{
							obj2 = 11;
						}
						goto IL_013a;
						IL_0c98:
						awaiter = __KnownINotifyPropertyChangingArgs.InviteUrl;
						obj2 = 34;
						goto IL_013a;
						IL_0c04:
						awaiter = __KnownINotifyPropertyChangingArgs.TopUpGroups;
						obj2 = 91;
						goto IL_013a;
						IL_0ac7:
						awaiter = __KnownINotifyPropertyChangingArgs.InputPassword;
						obj2 = 3;
						goto IL_013a;
						IL_083d:
						awaiter = __KnownINotifyPropertyChangingArgs.VerifyCodeDelayText;
						obj2 = 31;
						goto IL_013a;
						end_IL_010b:
						break;
					}
					goto IL_14f4;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00븀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777759, new IntPtr(2737335735116L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00뼀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00쀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777756, new IntPtr(2737335702876L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00섀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777757, new IntPtr(2737335702876L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00숀()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00쌀(object? P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0053: Expected Obj, but got I
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)(nint)Unsafe.AsPointer(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized), ref *(object[]*)P_0);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00쐀(object? P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777754, new IntPtr(2737335735116L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoginHistoryAccount_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AccountModel accountModel;

		public AccountViewModel _003C_003E4__this;

		private nint _003CisOnline_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<DesktopSession> _003C_003Eu__2;

		internal static object? FilterModule;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DecorateCustomProcessor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? DecodeWrapper()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00글()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777755, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00꼀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_07be: Expected Obj, but got Ref
			//IL_07c3: Expected VT, but got Ref
			//IL_0799: Expected Obj, but got I4
			//IL_0799: Expected Obj, but got Ref
			//IL_0064: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I
			//IL_0059: Expected Obj, but got I4
			//IL_01b1: Expected Obj, but got Ref
			//IL_0087: Expected Obj, but got I
			//IL_0602: Expected Obj, but got Ref
			//IL_05d8: Expected Obj, but got I4
			//IL_05dd: Expected Obj, but got I4
			//IL_05dd: Expected Obj, but got Ref
			//IL_0107: Expected Obj, but got Ref
			//IL_06a2: Expected Obj, but got Ref
			//IL_0186: Expected I, but got Obj
			//IL_0136: Expected Obj, but got Ref
			//IL_0591: Expected Obj, but got Ref
			//IL_0591: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bd: Expected Obj, but got Ref
			//IL_05c9: Expected Obj, but got VT
			//IL_00fb: Expected Obj, but got I4
			//IL_05a6: Expected Obj, but got I4
			//IL_05ab: Expected Obj, but got I4
			//IL_05ab: Expected Obj, but got Ref
			//IL_0346: Expected Obj, but got Ref
			//IL_00ec: Expected I4, but got Obj
			//IL_039c: Expected Obj, but got Ref
			//IL_03a6: Expected I, but got Obj
			//IL_03a8: Expected Obj, but got I4
			//IL_023c: Expected Obj, but got I4
			//IL_0241: Expected Obj, but got I4
			//IL_0241: Expected Obj, but got Ref
			//IL_024a: Expected Obj, but got I4
			//IL_033b: Expected Obj, but got I4
			//IL_03e4: Expected Obj, but got Ref
			//IL_029d: Expected Obj, but got Ref
			//IL_0448: Expected Obj, but got Ref
			//IL_0255: Expected Obj, but got Ref
			//IL_025f: Expected I, but got Obj
			//IL_02b1: Expected Obj, but got I4
			//IL_02b6: Expected Obj, but got I4
			//IL_02b6: Expected Obj, but got Ref
			//IL_03cd: Expected Obj, but got Ref
			//IL_047b: Expected Obj, but got Ref
			//IL_02db: Expected Obj, but got Ref
			//IL_02f2: Expected Obj, but got VT
			//IL_0409: Expected Obj, but got Ref
			//IL_048a: Expected I, but got Obj
			//IL_0232: Expected I4, but got Obj
			//IL_0494: Expected I, but got Obj
			//IL_07d7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_07ad->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
			//IL_07e2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_07b8->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01bd->IL009b: Incompatible stack types: I4 vs Obj
			//IL_008c->IL009b: Incompatible stack types: I4 vs Obj
			//IL_0097->IL009b: Incompatible stack types: I4 vs Obj
			//IL_061e->IL009b: Incompatible stack types: I4 vs Obj
			//IL_05f1->IL009b: Incompatible stack types: I4 vs Obj
			//IL_0125->IL009b: Incompatible stack types: I4 vs Obj
			//IL_0644->IL009b: Incompatible stack heights: 3 vs 1
			//IL_06b6->IL009b: Incompatible stack types: I4 vs Obj
			//IL_01a0->IL009b: Incompatible stack heights: 3 vs 1
			//IL_05a1->IL009b: Incompatible stack types: I4 vs Obj
			//IL_05d3->IL009b: Incompatible stack heights: 3 vs 1
			//IL_05b5->IL009b: Incompatible stack types: I4 vs Obj
			//IL_0629->IL009b: Incompatible stack types: I4 vs Obj
			//IL_05fc->IL009b: Incompatible stack types: I4 vs Obj
			//IL_0130->IL009b: Incompatible stack types: I4 vs Obj
			//IL_064f->IL009b: Incompatible stack heights: 3 vs 1
			//IL_06c1->IL009b: Incompatible stack types: I4 vs Obj
			//IL_06e4->IL009b: Incompatible stack types: I4 vs Obj
			//IL_01ab->IL009b: Incompatible stack heights: 3 vs 1
			//IL_0145->IL009b: Incompatible stack types: I4 vs Obj
			//IL_066b->IL009b: Incompatible stack types: I4 vs Obj
			//IL_035c->IL01e9: Incompatible stack types: I4 vs Obj
			//IL_01da->IL01e9: Incompatible stack types: I4 vs Obj
			//IL_0174->IL009b: Incompatible stack types: I4 vs Obj
			//IL_06ef->IL009b: Incompatible stack types: I4 vs Obj
			//IL_0676->IL009b: Incompatible stack types: I4 vs Obj
			//IL_0367->IL01e9: Incompatible stack types: I4 vs Obj
			//IL_01e5->IL01e9: Incompatible stack types: I4 vs Obj
			//IL_017f->IL009b: Incompatible stack types: I4 vs Obj
			//IL_03bc->IL01e9: Incompatible stack types: I4 vs Obj
			//IL_038b->IL01e9: Incompatible stack types: I4 vs Obj
			//IL_03f8->IL01e9: Incompatible stack types: I4 vs Obj
			//IL_02ac->IL01e9: Incompatible stack heights: 2 vs 1
			//IL_0278->IL01e9: Incompatible stack heights: 3 vs 1
			//IL_02ca->IL01e9: Incompatible stack types: I4 vs Obj
			//IL_02f7->IL01e9: Incompatible stack heights: 2 vs 1
			//IL_0423->IL01e9: Incompatible stack types: I4 vs Obj
			//IL_03c7->IL01e9: Incompatible stack types: I4 vs Obj
			//IL_0396->IL01e9: Incompatible stack types: I4 vs Obj
			//IL_0403->IL01e9: Incompatible stack types: I4 vs Obj
			//IL_045c->IL0461: Incompatible stack types: I4 vs Obj
			//IL_0283->IL01e9: Incompatible stack heights: 3 vs 1
			//IL_02d5->IL01e9: Incompatible stack types: I4 vs Obj
			//IL_03dc->IL01e9: Incompatible stack types: I4 vs Obj
			//IL_0302->IL01e9: Incompatible stack heights: 2 vs 1
			//IL_0322->IL01e9: Incompatible stack types: I4 vs Obj
			//IL_042e->IL01e9: Incompatible stack types: I4 vs Obj
			//IL_0470->IL01e9: Incompatible stack heights: 3 vs 1
			//IL_04c2->IL01e9: Incompatible stack heights: 6 vs 1
			//IL_032d->IL01e9: Incompatible stack types: I4 vs Obj
			//IL_04cd->IL01e9: Incompatible stack heights: 6 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 3;
			while (true)
			{
				object obj = awaiter;
				while (true)
				{
					object obj2;
					switch ((int)obj)
					{
					case 3:
						break;
					case 2:
						awaiter = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
						obj = 4;
						continue;
					case 4:
						if (awaiter != null)
						{
							obj2 = 9;
							if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
							{
								obj2 = 12;
							}
							goto IL_009b;
						}
						goto IL_01ab;
					case 1:
						goto IL_0791;
					default:
						Regex.ValidateMatchTimeout((TimeSpan)Unsafe.AsPointer(ref __KnownINotifyPropertyChangingArgs.SelectedPageOfSkin));
						obj = 5;
						if (__KnownINotifyPropertyChangingArgs.SearchVisibility == null)
						{
							obj = 5;
						}
						continue;
					case 5:
						return;
						IL_009b:
						while (true)
						{
							object obj3;
							switch ((int)obj2)
							{
							case 16:
								awaiter = 14;
								obj2 = awaiter;
								continue;
							case 4:
								IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = (int)IEnumerator_object.Do_Abi_get_Current_0((nint)Unsafe.AsPointer(ref this), (nint*)IList_object._initialized);
								obj2 = 10;
								if (IReadOnlyList_System_IDisposable._initialized == 0)
								{
									obj2 = 8;
								}
								continue;
							case 10:
								if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
								{
									obj2 = 8;
									continue;
								}
								goto case 16;
							case 7:
								return;
							case 17:
								if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)/*Error near IL_015b: Stack underflow*/, (uint)(&awaiter)) == null)
								{
									obj2 = 2;
									if (IEnumerator_System_IDisposable._initialized == 0)
									{
										obj2 = 1;
									}
									continue;
								}
								goto case 5;
							case 9:
								IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_IndexOf_2((nint)/*Error near IL_0186: Stack underflow*/, (nint)/*Error near IL_0186: Stack underflow*/, (uint*)/*Error near IL_0186: Stack underflow*/, (byte*)(nint)awaiter);
								MarshalInterface<INotifyPropertyChanged>.FromAbiArray((object)null);
								_ = 0;
								if (IEnumerable_object._initialized == 0)
								{
									_ = 0;
								}
								continue;
							case 3:
								break;
							case 14:
								if ((nint)awaiter != 1)
								{
									obj3 = 0;
									if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute == null)
									{
										obj3 = 0;
									}
									goto IL_01e9;
								}
								goto IL_0340;
							case 13:
								__KnownINotifyPropertyChangingArgs.InputCookie = (PropertyChangingEventArgs)default(XmlnsDefinition);
								obj2 = 18;
								continue;
							case 18:
								awaiter = -1;
								__KnownINotifyPropertyChangingArgs.Input163Password = (PropertyChangingEventArgs)(-1);
								obj2 = 5;
								continue;
							case 15:
								((Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails)(object)__KnownINotifyPropertyChangingArgs.InputMobilePassword).GetExposedInterfaces();
								awaiter = IEnumerableMethods<IDisposable>.IID;
								_ = 17;
								continue;
							case 2:
								awaiter = 0;
								__KnownINotifyPropertyChangingArgs.VerifyCodeDelayText = (PropertyChangingEventArgs)0;
								obj2 = 6;
								if (__KnownINotifyPropertyChangingArgs.InfoBarSeverity == null)
								{
									obj2 = 2;
								}
								continue;
							case 1:
								Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.InfoBarIsOpen).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CLoginHistoryAccount_003Ed__24, DesktopViewModel._003CLaunchEchoClient_003Ed__7>(ref this));
								obj2 = 1;
								if (__KnownINotifyPropertyChangingArgs.SelectedFileName == null)
								{
									obj2 = 7;
								}
								continue;
							case 5:
								_ = ref awaiter;
								_ = IVisualElementMethods.IID;
								_ = 9;
								if (__KnownINotifyPropertyChangingArgs.ImportedCount == null)
								{
									_ = 11;
								}
								continue;
							case 12:
								if ((nint)awaiter != 1)
								{
									obj2 = 1;
									if (__KnownINotifyPropertyChangingArgs.ParsedAccounts == null)
									{
										obj2 = 4;
									}
									continue;
								}
								goto case 16;
							case 6:
								__KnownINotifyPropertyChangingArgs.SelectedGame = (PropertyChangingEventArgs)awaiter;
								obj2 = 1;
								if (__KnownINotifyPropertyChangingArgs.LanGames == null)
								{
									obj2 = 1;
								}
								continue;
							case 8:
								if (((Mass_WinUI_AppWinRTTypeDetails)(object)Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.CheckExpandableAttribute()).GetExposedInterfaces() != null)
								{
									obj2 = 3;
									if (__KnownINotifyPropertyChangingArgs.FourLikeNetGames == null)
									{
										obj2 = 15;
									}
									continue;
								}
								goto case 16;
							default:
								goto IL_0791;
								IL_0340:
								awaiter = __KnownINotifyPropertyChangingArgs.CreateAt;
								obj3 = 3;
								if (__KnownINotifyPropertyChangingArgs.Name == null)
								{
									obj3 = 16;
								}
								goto IL_01e9;
								IL_01e9:
								while (true)
								{
									switch ((int)obj3)
									{
									case 6:
										break;
									case 1:
										awaiter = -1;
										Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute = -1;
										awaiter = 5;
										goto IL_01e5;
									case 9:
									{
										object reflectScheduledAttribute = Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute;
										IEnumerable_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
										IListMethods<object>.Abi_GetView_2((IntPtr)reflectScheduledAttribute);
										IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectMonoAttribute();
										_ = 2;
										if (Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute != null)
										{
											_ = 2;
										}
										continue;
									}
									case 7:
										return;
									case 5:
										IListMethods<object>.Abi_SetAt_4((IntPtr)/*Error near IL_029d: Stack underflow*/, (uint)/*Error near IL_029d: Stack underflow*/, (object)(&awaiter));
										IList_object.Do_Abi_GetView_2((nint)/*Error near IL_02a2: Stack underflow*/, (nint*)/*Error near IL_02a2: Stack underflow*/);
										_ = 3;
										continue;
									case 10:
										awaiter = 1;
										Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute = 1;
										obj3 = 4;
										if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance != null)
										{
											obj3 = 4;
										}
										continue;
									case 14:
										_ = ref _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute;
										((AsyncTaskMethodBuilder*)(&awaiter))->Start(ref Unsafe.As<_003CLoginHistoryAccount_003Ed__24, _003CLoginRandom_003Ed__85>(ref this));
										_ = 0;
										if (!_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout)
										{
											_ = 7;
										}
										continue;
									case 15:
										if (!IEnumeratorMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, nint*, int>)/*Error near IL_0309: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)/*Error near IL_0309: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)/*Error near IL_0309: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, uint*, int>)(&awaiter)))
										{
											obj3 = 1;
											if (__KnownINotifyPropertyChangingArgs.UserId != null)
											{
												obj3 = 10;
											}
											continue;
										}
										goto case 5;
									case 2:
										IList_object._002Ecctor();
										awaiter = 8;
										goto IL_01e5;
									case 12:
										goto IL_0340;
									case 3:
										((AsyncTaskMethodBuilder*)/*Error near IL_0376: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<string>*)/*Error near IL_0376: Stack underflow*/, ref *(_003CLoginBedrock_003Ed__86*)new IEnumerator_System_ComponentModel_INotifyPropertyChanged((nint)/*Error near IL_0371: Stack underflow*/, (byte*)MarshalInterface<IDisposable>.FromManaged((IDisposable)/*Error near IL_036c: Stack underflow*/)));
										obj3 = 11;
										if (__KnownINotifyPropertyChangingArgs.IsSelected == null)
										{
											obj3 = 2;
										}
										continue;
									default:
										awaiter = IReadOnlyListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_03a6: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_03a6: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)__KnownINotifyPropertyChangingArgs.IsSkeleton, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(IEnumerator_System_ComponentModel_INotifyPropertyChanged.DecorateDynamicAttribute() ? 1 : 0));
										obj3 = 15;
										if (__KnownINotifyPropertyChangingArgs.MaxPlayers != null)
										{
											obj3 = 0;
										}
										continue;
									case 11:
										if (__KnownINotifyPropertyChangingArgs.Author == null)
										{
											obj3 = 9;
											continue;
										}
										goto case 8;
									case 4:
										__KnownINotifyPropertyChangingArgs.Description = (PropertyChangingEventArgs)awaiter;
										obj3 = 9;
										if (__KnownINotifyPropertyChangingArgs.ImageUrl != null)
										{
											obj3 = 14;
										}
										continue;
									case 16:
										__KnownINotifyPropertyChangingArgs.Characters = null;
										obj3 = 0;
										if (__KnownINotifyPropertyChangingArgs.Summary == null)
										{
											obj3 = 1;
										}
										continue;
									case 8:
									{
										IEnumerableMethods<object>.Abi_First_0((IntPtr)(int)IReadOnlyList_object.Do_Abi_IndexOf_2((nint)/*Error near IL_043d: Stack underflow*/, (nint)/*Error near IL_043d: Stack underflow*/, (uint*)/*Error near IL_043d: Stack underflow*/, (byte*)(int)IReadOnlyList_object.Do_Abi_GetAt_0((nint)/*Error near IL_0438: Stack underflow*/, (uint)/*Error near IL_0438: Stack underflow*/, (nint*)(int)IReadOnlyList_object.Init())));
										PropertyChangingEventArgs launchTime = __KnownINotifyPropertyChangingArgs.LaunchTime;
										IReadOnlyList_object._002Ecctor();
										((IEnumerable<AccountModel>)((launchTime != null) ? ((object)IReadOnlyList_object.DecorateControllableAttribute()) : ((object)(IEnumerable<AccountModel>)IReadOnlyList_object.ReflectSimpleAttribute()))).ToList();
										_ = 13;
										continue;
									}
									case 13:
										{
											PropertyChangingEventArgs type = __KnownINotifyPropertyChangingArgs.Type;
											IEnumerator_System_IDisposable.Do_Abi_get_HasCurrent_1(__return_value__: (byte*)(int)((__KnownINotifyPropertyChangingArgs.CanDelete != null) ? IEnumerator_System_IDisposable.Do_Abi_get_Current_0((nint)/*Error near IL_0494: Stack underflow*/, (nint*)(nint)type) : IEnumerator_System_IDisposable.Do_Abi_GetMany_3((nint)/*Error near IL_048a: Stack underflow*/, (uint)/*Error near IL_048a: Stack underflow*/, (nint)/*Error near IL_048a: Stack underflow*/, (uint*)(nint)type)), thisPtr: (nint)/*Error near IL_0499: Stack underflow*/);
											IEnumerator_System_IDisposable._002Ecctor();
											_ = IEnumerableMethods<object>.IID;
											_ = IEnumerableMethods<object>.AbiToProjectionVftablePtr;
											_ = null;
											_ = IEnumerable_System_IDisposable.Initialized;
											_ = 6;
											if (__KnownINotifyPropertyChangingArgs.Image != null)
											{
												_ = 2;
											}
											continue;
										}
										IL_01e5:
										obj3 = awaiter;
										continue;
									}
									break;
								}
								goto case 9;
							}
							break;
						}
						goto IL_01ab;
						IL_0791:
						__KnownINotifyPropertyChangingArgs.SelectedSkin = (PropertyChangingEventArgs)(-2);
						obj = 0;
						if (__KnownINotifyPropertyChangingArgs.HasSkins == null)
						{
							obj = 0;
						}
						continue;
						IL_01ab:
						awaiter = IEnumerable_object.ReflectSetAttribute;
						obj2 = 13;
						goto IL_009b;
					}
					break;
				}
				awaiter = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
				awaiter = 2;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00뀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777752, new IntPtr(2737335735116L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00넀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00눀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777753, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00대()
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
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00됀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777830, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00딀(object? P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0054: Expected Obj, but got I
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)(nint)Unsafe.AsPointer(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized), ref *(object[]*)P_0);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00똀(object? P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777831, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoginMobile_003Ed__88 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AccountViewModel _003C_003E4__this;

		public EnumAccountType type;

		private object _003Ccookies_003E5__2;

		private TaskAwaiter<string> _003C_003Eu__1;

		private TaskAwaiter<MobileSession> _003C_003Eu__2;

		internal static object? DecorateConvertibleConverter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BuildContainer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? AssessConverter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ꄀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777828, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ꈀ()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_004e: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got Ref
			//IL_0071: Expected Obj, but got I
			//IL_13fd: Expected Obj, but got I4
			//IL_13fd: Expected Obj, but got Ref
			//IL_0087: Expected Obj, but got Ref
			//IL_008c: Expected Obj, but got Ref
			//IL_009b: Expected Obj, but got I
			//IL_1350: Expected Obj, but got Ref
			//IL_00c3: Expected Obj, but got I
			//IL_0166: Expected I4, but got Obj
			//IL_0790: Expected Obj, but got Ref
			//IL_07ca: Expected Obj, but got Ref
			//IL_0aa8: Expected Obj, but got Ref
			//IL_0ab3: Expected Obj, but got I4
			//IL_04d5: Expected Obj, but got Ref
			//IL_04e0: Expected Obj, but got I4
			//IL_05a1: Expected Obj, but got Ref
			//IL_03cd: Expected Obj, but got Ref
			//IL_056d: Expected I4, but got Obj
			//IL_0406: Expected Obj, but got I4
			//IL_0406: Expected I4, but got Obj
			//IL_050e: Expected Obj, but got Ref
			//IL_0b0f: Expected Obj, but got Ref
			//IL_0b9d: Expected I4, but got Obj
			//IL_0464: Expected Obj, but got Ref
			//IL_0e68: Expected Obj, but got Ref
			//IL_05d2: Expected I, but got Obj
			//IL_05e0: Expected I, but got Obj
			//IL_05e0: Expected I, but got Obj
			//IL_05e6: Expected Obj, but got Ref
			//IL_05eb: Expected I, but got Obj
			//IL_05ed: Expected Obj, but got I4
			//IL_0724: Expected Obj, but got I4
			//IL_0729: Expected Obj, but got I4
			//IL_0729: Expected Obj, but got Ref
			//IL_0675: Expected Obj, but got Ref
			//IL_054f: Expected Obj, but got Ref
			//IL_10ce: Expected Obj, but got Ref
			//IL_0faa: Expected Obj, but got Ref
			//IL_0fb3: Expected Obj, but got I4
			//IL_0f3f: Expected Obj, but got I4
			//IL_0f44: Expected Obj, but got I4
			//IL_0f44: Expected Obj, but got Ref
			//IL_07f1: Expected Obj, but got Ref
			//IL_0528: Expected Obj, but got Ref
			//IL_0d22: Unknown result type (might be due to invalid IL or missing references)
			//IL_0953: Unknown result type (might be due to invalid IL or missing references)
			//IL_096d: Expected I4, but got Unknown
			//IL_1010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0364: Expected I, but got Obj
			//IL_0366: Expected Obj, but got I4
			//IL_0dc6: Expected Obj, but got I4
			//IL_0ddb: Expected Obj, but got I4
			//IL_0643: Expected Obj, but got Ref
			//IL_0b54: Expected Obj, but got Ref
			//IL_06f2: Expected I, but got Obj
			//IL_06f8: Expected Obj, but got Ref
			//IL_06ff: Expected Obj, but got I4
			//IL_0892: Expected Obj, but got Ref
			//IL_0c6c: Expected Obj, but got Ref
			//IL_0c73: Expected Obj, but got I4
			//IL_0b20: Expected Obj, but got I4
			//IL_0b25: Expected Obj, but got I4
			//IL_0b25: Expected Obj, but got Ref
			//IL_0d65: Expected Obj, but got I4
			//IL_0d6a: Expected Obj, but got I4
			//IL_0d6a: Expected Obj, but got Ref
			//IL_0660: Expected I, but got Obj
			//IL_0665: Expected Obj, but got I4
			//IL_0c01: Expected I4, but got Obj
			//IL_0f6a: Expected Obj, but got Ref
			//IL_09b9: Expected Obj, but got I4
			//IL_09fc: Expected Obj, but got Ref
			//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f1: Expected Obj, but got Ref
			//IL_0e0f: Expected Obj, but got Ref
			//IL_0fea: Expected Obj, but got I4
			//IL_0fef: Expected Obj, but got I4
			//IL_0fef: Expected Obj, but got Ref
			//IL_0438: Expected I4, but got Obj
			//IL_044c: Expected Obj, but got VT
			//IL_0a4b: Expected VT, but got Obj
			//IL_0a4b: Expected Obj, but got I4
			//IL_0a51: Expected Obj, but got Ref
			//IL_0a56: Expected VT, but got Obj
			//IL_0a58: Expected Obj, but got I4
			//IL_0e3a: Expected Obj, but got Ref
			//IL_0e42: Expected Obj, but got Ref
			//IL_0780: Expected Obj, but got I
			//IL_091d: Expected Obj, but got I4
			//IL_0922: Expected Obj, but got I4
			//IL_0922: Expected Obj, but got Ref
			//IL_04f9: Expected Obj, but got I4
			//IL_04fe: Expected Obj, but got I4
			//IL_04fe: Expected Obj, but got Ref
			//IL_05b3: Expected Obj, but got Ref
			//IL_05c2: Expected Obj, but got I4
			//IL_0381: Expected I, but got Obj
			//IL_0ea2: Expected Obj, but got Ref
			//IL_03a5: Expected Obj, but got I4
			//IL_03aa: Expected Obj, but got I4
			//IL_03aa: Expected Obj, but got Ref
			//IL_09a1: Expected Obj, but got Ref
			//IL_09a9: Expected Obj, but got Ref
			//IL_09a9: Expected Obj, but got Ref
			//IL_0f55: Expected Obj, but got Ref
			//IL_0c4c: Expected Obj, but got I4
			//IL_0c51: Expected Obj, but got I4
			//IL_0c51: Expected Obj, but got Ref
			//IL_0f16: Expected Obj, but got I4
			//IL_0f1b: Expected Obj, but got I4
			//IL_0f1b: Expected Obj, but got Ref
			//IL_048b: Expected Obj, but got Ref
			//IL_0494: Expected Obj, but got I4
			//IL_06b2: Expected Ref, but got VT
			//IL_0824: Expected Obj, but got I4
			//IL_0829: Expected Obj, but got I4
			//IL_0829: Expected Obj, but got Ref
			//IL_0b6b: Expected Obj, but got Ref
			//IL_0687: Expected Obj, but got Ref
			//IL_070f: Expected Obj, but got Ref
			//IL_0cfe: Expected Obj, but got I4
			//IL_0d03: Expected Obj, but got I4
			//IL_0d03: Expected Obj, but got Ref
			//IL_0a7d: Expected Obj, but got Ref
			//IL_0bce: Expected Obj, but got Ref
			//IL_10a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fdb: Expected I4, but got Obj
			//IL_0772: Expected Obj, but got I4
			//IL_0349: Expected I4, but got Obj
			//IL_0d30: Expected Obj, but got Ref
			//IL_094b: Expected Obj, but got I4
			//IL_1114: Unknown result type (might be due to invalid IL or missing references)
			//IL_1126: Expected Obj, but got I
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0076->IL0026: Incompatible stack types: I4 vs Obj
			//IL_1411->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a0->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0081->IL0026: Incompatible stack types: I4 vs Obj
			//IL_141c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ab->IL0026: Incompatible stack heights: 2 vs 1
			//IL_1364->IL00d7: Incompatible stack heights: 2 vs 1
			//IL_00f8->IL00fd: Incompatible stack heights: 0 vs 1
			//IL_07a6->IL0174: Incompatible stack types: I4 vs Obj
			//IL_07d6->IL0174: Incompatible stack types: I4 vs Obj
			//IL_05ad->IL0174: Incompatible stack types: I4 vs Obj
			//IL_03d9->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0170->IL0174: Incompatible stack types: I4 vs Obj
			//IL_07b1->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0581->IL0174: Incompatible stack heights: 4 vs 1
			//IL_041c->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0520->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0b1b->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0bbd->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0478->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0623->IL0174: Incompatible stack types: I4 vs Obj
			//IL_05f7->IL0174: Incompatible stack types: I4 vs Obj
			//IL_073d->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0681->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0559->IL0174: Incompatible stack types: I4 vs Obj
			//IL_10e4->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0f4e->IL0174: Incompatible stack types: I4 vs Obj
			//IL_08bd->IL0777: Incompatible stack heights: 1 vs 0
			//IL_07fb->IL0174: Incompatible stack types: I4 vs Obj
			//IL_053c->IL0174: Incompatible stack types: I4 vs Obj
			//IL_102b->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0370->IL0174: Incompatible stack types: I4 vs Obj
			//IL_064f->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0b63->IL0174: Incompatible stack heights: 2 vs 1
			//IL_0709->IL0174: Incompatible stack heights: 5 vs 1
			//IL_08a6->IL0174: Incompatible stack heights: 4 vs 1
			//IL_0c7d->IL0174: Incompatible stack heights: 4 vs 1
			//IL_0b39->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0ad5->IL0174: Incompatible stack heights: 2 vs 1
			//IL_0942->IL0370: Incompatible stack heights: 1 vs 0
			//IL_0d7e->IL0174: Incompatible stack types: I4 vs Obj
			//IL_066f->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0854->IL0eb1: Incompatible stack heights: 1 vs 0
			//IL_0f84->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0a18->IL0174: Incompatible stack heights: 2 vs 1
			//IL_0cf9->IL0174: Incompatible stack types: I4 vs Obj
			//IL_04ab->IL0174: Incompatible stack heights: 4 vs 1
			//IL_090d->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0e29->IL0174: Incompatible stack types: I4 vs Obj
			//IL_1003->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0d60->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0c3c->IL0174: Incompatible stack heights: 2 vs 1
			//IL_0451->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0a6c->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0e56->IL0174: Incompatible stack heights: 4 vs 1
			//IL_078a->IL0174: Incompatible stack heights: 2 vs 1
			//IL_0ca1->IL0174: Incompatible stack types: I4 vs Obj
			//IL_092c->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0508->IL0174: Incompatible stack types: I4 vs Obj
			//IL_109e->IL0174: Incompatible stack heights: 3 vs 1
			//IL_0395->IL0174: Incompatible stack heights: 3 vs 1
			//IL_03b4->IL0174: Incompatible stack types: I4 vs Obj
			//IL_09b3->IL0174: Incompatible stack heights: 3 vs 1
			//IL_0f64->IL0174: Incompatible stack heights: 3 vs 1
			//IL_0c5b->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0f2f->IL0174: Incompatible stack types: I4 vs Obj
			//IL_06c6->IL0174: Incompatible stack heights: 3 vs 1
			//IL_083d->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0ec4->IL0174: Incompatible stack heights: 2 vs 1
			//IL_0b7f->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0699->IL0174: Incompatible stack heights: 2 vs 1
			//IL_071f->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0d17->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0a97->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0bde->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0606->IL0174: Incompatible stack heights: 2 vs 1
			//IL_0afe->IL0174: Incompatible stack heights: 5 vs 1
			//IL_0ef7->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0777->IL0170: Incompatible stack heights: 6 vs 0
			//IL_058c->IL0174: Incompatible stack heights: 4 vs 1
			//IL_0427->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0bc8->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0483->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0e81->IL0174: Incompatible stack types: I4 vs Obj
			//IL_062e->IL0174: Incompatible stack types: I4 vs Obj
			//IL_07ea->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0748->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0d44->IL0174: Incompatible stack types: I4 vs Obj
			//IL_08c7->IL0174: Incompatible stack heights: 2 vs 1
			//IL_0547->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0981->IL0174: Incompatible stack types: I4 vs Obj
			//IL_1036->IL0174: Incompatible stack types: I4 vs Obj
			//IL_08b1->IL0174: Incompatible stack heights: 4 vs 1
			//IL_0b44->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0ae0->IL0174: Incompatible stack heights: 2 vs 1
			//IL_0950->IL0170: Incompatible stack heights: 1 vs 0
			//IL_0d89->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0c15->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0868->IL0174: Incompatible stack heights: 2 vs 1
			//IL_0f8f->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0a23->IL0174: Incompatible stack heights: 2 vs 1
			//IL_1162->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0918->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0e34->IL0174: Incompatible stack types: I4 vs Obj
			//IL_100e->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0c47->IL0174: Incompatible stack heights: 2 vs 1
			//IL_045c->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0a77->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0e61->IL0174: Incompatible stack heights: 4 vs 1
			//IL_0cac->IL0174: Incompatible stack types: I4 vs Obj
			//IL_03a0->IL0174: Incompatible stack heights: 3 vs 1
			//IL_0eb1->IL0174: Incompatible stack types: I4 vs Obj
			//IL_1194->IL0174: Incompatible stack heights: 2 vs 1
			//IL_09f6->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0f3a->IL0174: Incompatible stack types: I4 vs Obj
			//IL_06d1->IL0174: Incompatible stack heights: 3 vs 1
			//IL_0848->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0b8a->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0d22->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0aa2->IL0174: Incompatible stack types: I4 vs Obj
			//IL_10f9->IL110c: Incompatible stack heights: 1 vs 3
			//IL_10b4->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0b09->IL0174: Incompatible stack heights: 5 vs 1
			//IL_0f02->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0fe5->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0e8c->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0d4f->IL0174: Incompatible stack types: I4 vs Obj
			//IL_098c->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0c20->IL0174: Incompatible stack types: I4 vs Obj
			//IL_0873->IL0174: Incompatible stack heights: 2 vs 1
			//IL_117b->IL0174: Incompatible stack heights: 2 vs 1
			//IL_113a->IL0174: Incompatible stack heights: 5 vs 1
			//IL_1145->IL0174: Incompatible stack heights: 5 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 2;
			object obj = awaiter;
			while (true)
			{
				int num;
				object obj2;
				switch ((int)obj)
				{
				default:
					return;
				case 1:
					awaiter = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					obj = 4;
					continue;
				case 2:
					awaiter = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
					obj = 1;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						obj = 0;
					}
					continue;
				case 5:
					MarshalInspectable<object>.FromAbiArray((object)Unsafe.AsPointer(ref IList_object._initialized));
					_ = 0;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
					{
						_ = 0;
					}
					continue;
				case 4:
					if ((nuint)(nint)awaiter <= (nuint)5u)
					{
						num = 0;
						if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
						{
							num = 0;
						}
						goto IL_00d7;
					}
					goto IL_1348;
				case 3:
					break;
				case 0:
					return;
					IL_1348:
					if (((XamlTypeInfoProvider)(object)__KnownINotifyPropertyChangedArgs.CurrentPage).Activate_118_InfoBadge() != null)
					{
						break;
					}
					_ = 2;
					goto IL_00d7;
					IL_00d7:
					while (true)
					{
						switch (num)
						{
						case 4:
							break;
						default:
							num = 4;
							if (__KnownINotifyPropertyChangedArgs.Code == null)
							{
								num = 4;
							}
							continue;
						case 5:
							goto IL_1348;
						case 3:
						case 6:
							goto end_IL_0026;
						}
						break;
					}
					switch ((int)awaiter)
					{
					default:
						obj2 = 13;
						goto IL_0174;
					case 5:
						awaiter = Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute;
						obj2 = 49;
						goto IL_0174;
					case 3:
						goto IL_04cf;
					case 4:
						goto IL_059b;
					case 0:
						goto IL_078a;
					case 1:
						goto IL_07c4;
					case 2:
						goto IL_0aa2;
						IL_0174:
						while (true)
						{
							CaseCollection val;
							object key;
							MainWindow._003C_003Ec__DisplayClass0_0 obj3;
							Type? typeFromHandle;
							switch ((int)obj2)
							{
							case 30:
								awaiter = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_0364: Stack underflow*/, (uint)/*Error near IL_0364: Stack underflow*/, (uint)/*Error near IL_0364: Stack underflow*/, (nint)/*Error near IL_0364: Stack underflow*/, (uint*)(nint)awaiter);
								obj2 = 20;
								continue;
							case 82:
								IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)/*Error near IL_0375: Stack underflow*/, (uint*)/*Error near IL_0375: Stack underflow*/);
								IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
								IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)awaiter);
								_ = 0;
								if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute == null)
								{
									_ = 0;
								}
								continue;
							case 86:
								awaiter = 4;
								Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute = 4;
								obj2 = 94;
								continue;
							case 68:
								break;
							case 1:
								IListMethods<object>.Abi_SetAt_4((IntPtr)/*Error near IL_0406: Stack underflow*/, (uint)(int)Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute, (object)IListMethods<object>.Abi_IndexOf_3((IntPtr)(IEnumerable_System_ComponentModel_INotifyPropertyChanged.DecorateSeparatedAttribute() ? 1 : 0), (object)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectMonoAttribute(), ref *(IList_object.Initialized ? ((uint*)1) : ((uint*)null))));
								awaiter = (object)/*Error near IL_0408: Stack underflow*/;
								obj2 = 112;
								if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute == null)
								{
									obj2 = 53;
								}
								continue;
							case 69:
								((AsyncTaskMethodBuilder*)/*Error near IL_043d: Stack underflow*/)->Start(ref *(_003CLoginRandom_003Ed__85*)IList_object.Do_Abi_RemoveAt_6((nint)(int)IList_object.Do_Abi_InsertAt_5((nint)/*Error near IL_0431: Stack underflow*/, (uint)/*Error near IL_0431: Stack underflow*/, (nint)(int)IList_object.Do_Abi_SetAt_4((nint)/*Error near IL_042c: Stack underflow*/, (uint)/*Error near IL_042c: Stack underflow*/, (nint)/*Error near IL_042c: Stack underflow*/)), (uint)(int)awaiter));
								obj2 = 5;
								if (!_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout)
								{
									obj2 = 54;
								}
								continue;
							case 5:
								_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator = awaiter;
								obj2 = 5;
								if (__KnownINotifyPropertyChangingArgs.UserId != null)
								{
									obj2 = 55;
								}
								continue;
							case 94:
								goto IL_0483;
							case 60:
								_ = 1;
								IList_object.AttachAttribute();
								_ = 79;
								continue;
							case 110:
								goto IL_04cf;
							case 77:
								awaiter = -1;
								__KnownINotifyPropertyChangingArgs.Message = (PropertyChangingEventArgs)(-1);
								obj2 = 7;
								continue;
							case 2:
								Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.CharacterName).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CLoginMobile_003Ed__88, _003CLoginBedrock_003Ed__86>(ref this));
								obj2 = 15;
								continue;
							case 24:
								__KnownINotifyPropertyChangingArgs.IsSelected = (PropertyChangingEventArgs)awaiter;
								obj2 = 100;
								if (__KnownINotifyPropertyChangingArgs.CanProxy == null)
								{
									obj2 = 27;
								}
								continue;
							case 16:
								__KnownINotifyPropertyChangingArgs.ShowMaxPlayer = (PropertyChangingEventArgs)awaiter;
								obj2 = 2;
								continue;
							default:
								_ = IReadOnlyList_System_IDisposable.Initialized;
								IReadOnlyListMethods<object>.Abi_GetMany_3((IntPtr)0, (uint)(int)awaiter, ref *(object[]*)new IReadOnlyList_System_IDisposable());
								_ = 108;
								if (__KnownINotifyPropertyChangingArgs.Version == null)
								{
									_ = 40;
								}
								continue;
							case 27:
								goto IL_059b;
							case 81:
								goto IL_05ad;
							case 9:
								awaiter = IReadOnlyList_object.Do_Abi_GetMany_3((nint)/*Error near IL_05eb: Stack underflow*/, 1u, IEnumerableMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)IReadOnlyList_System_IDisposable.VerifyAttribute()) ? 1u : 0u, (nint)(int)IReadOnlyList_object.Do_Abi_GetAt_0((nint)awaiter, (uint)IReadOnlyList_object.Init(), (nint*)(nint)awaiter), (uint*)(nint)__KnownINotifyPropertyChangingArgs.Title);
								obj2 = 8;
								continue;
							case 108:
								IReadOnlyList_object.Do_Abi_get_Size_1((nint)/*Error near IL_05fc: Stack underflow*/, (uint*)/*Error near IL_05fc: Stack underflow*/);
								_ = 65;
								continue;
							case 7:
								((Func<Type, string>)/*Error near IL_060d: Stack underflow*/)._002Ector((object)/*Error near IL_060d: Stack underflow*/, (nint)(&awaiter));
								awaiter = (object)/*Error near IL_060f: Stack underflow*/;
								obj2 = 2;
								if (__KnownINotifyPropertyChangingArgs.OperationText != null)
								{
									obj2 = 83;
								}
								continue;
							case 40:
								return;
							case 12:
							case 34:
							case 50:
							case 54:
								goto IL_063d;
							case 46:
								goto IL_064f;
							case 13:
								awaiter = __KnownINotifyPropertyChangingArgs.Price;
								obj2 = 28;
								continue;
							case 100:
								_ = ref __KnownINotifyPropertyChangingArgs.Paid;
								((AsyncTaskMethodBuilder*)(&awaiter))->Start(ref Unsafe.As<_003CLoginMobile_003Ed__88, DesktopViewModel._003CAddCharacter_003Ed__0>(ref this));
								_ = 11;
								continue;
							case 33:
							case 95:
								IEnumerator_System_IDisposable.DecorateSortedAttribute();
								_ = IEnumerable_System_IDisposable.Initialized;
								((AsyncTaskMethodBuilder*)IEnumerable_System_IDisposable.Init())->Start(ref *(DesktopViewModel._003CLaunchShadowClient_003Ed__5*)IEnumerableMethods.IID);
								_ = 1;
								if (__KnownINotifyPropertyChangingArgs.TotalCoins == null)
								{
									_ = 1;
								}
								continue;
							case 78:
								return;
							case 36:
								goto IL_06e0;
							case 101:
								__KnownINotifyPropertyChangingArgs.MobileAccounts = null;
								obj2 = 21;
								continue;
							case 10:
								awaiter = 0;
								__KnownINotifyPropertyChangingArgs.CurrentDisplayPage = (PropertyChangingEventArgs)0;
								obj2 = 5;
								if (__KnownINotifyPropertyChangingArgs.Input4399Username != null)
								{
									obj2 = 5;
								}
								continue;
							case 115:
								goto IL_0748;
							case 73:
								_ = ref awaiter;
								awaiter = (nint)IReadOnlyListMethods<IDisposable>.AbiToProjectionVftablePtr;
								_ = 111;
								continue;
							case 67:
								goto IL_078a;
							case 80:
								return;
							case 74:
								goto IL_07c4;
							case 57:
							case 63:
								goto IL_07d6;
							case 8:
							case 18:
							case 56:
							case 97:
							case 105:
							case 107:
								awaiter = awaiter;
								obj2 = 44;
								continue;
							case 23:
								__KnownINotifyPropertyChangingArgs.IsDragging = null;
								obj2 = 37;
								continue;
							case 96:
								awaiter = 1;
								__KnownINotifyPropertyChangingArgs.HasSelectedFile = (PropertyChangingEventArgs)1;
								obj2 = 10;
								if (__KnownINotifyPropertyChangingArgs.ImportedCount != null)
								{
									obj2 = 19;
								}
								continue;
							case 48:
								_ = ref awaiter;
								if (IVisualElement2Methods.AbiToProjectionVftablePtr == (IntPtr)0)
								{
									_ = 15;
									if (__KnownINotifyPropertyChangingArgs.ParseErrorMessage == null)
									{
										_ = 64;
									}
									continue;
								}
								goto case 98;
							case 38:
								goto IL_0873;
							case 22:
								_ = ref awaiter;
								if ((nint)IPageOverridesMethods.IID == 0)
								{
									_ = 86;
									continue;
								}
								goto case 73;
							case 61:
								Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.RentalGames).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CLoginMobile_003Ed__88, DesktopViewModel._003CSelectGame_003Ed__34>(ref this));
								obj2 = 40;
								if (__KnownINotifyPropertyChangingArgs.SkinEmptyText == null)
								{
									obj2 = 23;
								}
								continue;
							case 76:
								awaiter = -1;
								__KnownINotifyPropertyChangingArgs.CurrentSkinPage = (PropertyChangingEventArgs)(-1);
								obj2 = 29;
								continue;
							case 44:
							{
								Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.BuildAttribute();
								Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails = Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.DecorateFlexibleAttribute();
								((Regex)awaiter)._002Ector();
								if (mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails == null)
								{
									goto case 82;
								}
								goto IL_0942;
							}
							case 28:
								switch (awaiter - 2)
								{
								case 4:
									break;
								case 3:
									goto IL_063d;
								case 1:
								case 2:
									goto IL_064f;
								default:
									goto IL_096d;
								case 0:
									goto IL_0dbc;
								}
								goto case 69;
							case 87:
								_ = ref __KnownINotifyPropertyChangingArgs.SelectedPageOfSkin;
								((IEnumerable<GameResourceModel>)(&awaiter)).Concat((IEnumerable<GameResourceModel>)Unsafe.AsPointer(ref this));
								_ = 78;
								continue;
							case 52:
								goto IL_09b3;
							case 14:
							case 90:
								goto IL_09de;
							case 55:
								_ = ref __KnownINotifyPropertyChangingArgs.Balance;
								((AsyncTaskMethodBuilder*)(&awaiter))->Start(ref Unsafe.As<_003CLoginMobile_003Ed__88, HomeViewModel._003CRefresh_003Ed__25>(ref this));
								_ = 80;
								if (__KnownINotifyPropertyChangingArgs.RegistrationTimeText == null)
								{
									_ = 24;
								}
								continue;
							case 71:
								goto IL_0a32;
							case 103:
								__KnownINotifyPropertyChangingArgs.ShowTabs = null;
								obj2 = 27;
								if (__KnownINotifyPropertyChangingArgs.ShopDescription == null)
								{
									obj2 = 77;
								}
								continue;
							case 89:
								goto IL_0aa2;
							case 42:
							case 51:
								_ = ref awaiter;
								awaiter = WeakReferenceMessenger.Default;
								_ = 40;
								if (__KnownINotifyPropertyChangingArgs.CustomCoinAmount != null)
								{
									_ = 43;
								}
								continue;
							case 112:
								_ = 1;
								__KnownINotifyPropertyChangedArgs.ReflectSymbolicCreator();
								_ = 2;
								if (__KnownINotifyPropertyChangingArgs.SelectedProductGroupIndex == null)
								{
									_ = 3;
								}
								continue;
							case 3:
								awaiter = __KnownINotifyPropertyChangingArgs.SelectedProductGroup;
								obj2 = 47;
								continue;
							case 41:
								awaiter = 2;
								__KnownINotifyPropertyChangingArgs.SelectedTopUpTabIndex = (PropertyChangingEventArgs)2;
								obj2 = 16;
								if (__KnownINotifyPropertyChangingArgs.TopUpGroups != null)
								{
									obj2 = 0;
								}
								continue;
							case 35:
								Microsoft.Windows.Foundation.UndockedRegFreeWinRTCS.AutoInitialize.CheckConcreteViewer();
								((AsyncTaskMethodBuilder*)Microsoft.Windows.Foundation.UndockedRegFreeWinRTCS.AutoInitialize.ReflectConnectedCalculator())->Start(ref *(MobileViewModel._003CStartProxy_003Ed__7*)__KnownINotifyPropertyChangingArgs.TopUpItems);
								_ = 17;
								continue;
							case 99:
								__KnownINotifyPropertyChangingArgs.Orders = (PropertyChangingEventArgs)awaiter;
								obj2 = 53;
								if (__KnownINotifyPropertyChangingArgs.InviteCode != null)
								{
									obj2 = 61;
								}
								continue;
							case 4:
								goto IL_0b8a;
							case 104:
								__KnownINotifyPropertyChangedArgs.Notes = null;
								obj2 = 45;
								continue;
							case 47:
								switch ((int)awaiter)
								{
								case 2:
									break;
								case 4:
									goto IL_06e0;
								case 5:
									goto IL_0748;
								case 1:
									goto IL_07d6;
								case 6:
									goto IL_09b3;
								case 3:
									goto IL_0a32;
								default:
									goto IL_0c01;
								case 0:
									goto IL_0c5b;
								}
								goto case 9;
							case 66:
								((App)awaiter).GetXamlType((string)null);
								_ = 60;
								if (__KnownINotifyPropertyChangedArgs.IsMyself != null)
								{
									_ = 45;
								}
								continue;
							case 92:
								awaiter = -1;
								__KnownINotifyPropertyChangedArgs.Message = (PropertyChangedEventArgs)(-1);
								obj2 = 73;
								continue;
							case 39:
								goto IL_0c5b;
							case 75:
								((AsyncVoidMethodBuilder*)/*Error near IL_0c82: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_0c82: Stack underflow*/);
								((IEnumerable<EntityMassHistoryOrder>)/*Error near IL_0c8c: Stack underflow*/).Select((Func<EntityMassHistoryOrder, HistoryOrderModel>)(object)new MainContent());
								obj2 = 41;
								if (__KnownINotifyPropertyChangedArgs.Author != null)
								{
									obj2 = 58;
								}
								continue;
							case 59:
								goto IL_0cd0;
							case 102:
								awaiter = -1;
								__KnownINotifyPropertyChangedArgs.PreviewImage = (PropertyChangedEventArgs)(-1);
								obj2 = 0;
								if (__KnownINotifyPropertyChangedArgs.Title != null)
								{
									obj2 = 88;
								}
								continue;
							case 26:
							case 31:
								goto IL_0d22;
							case 20:
							case 43:
							case 70:
							case 83:
							case 91:
							case 111:
								__KnownINotifyPropertyChangedArgs.LaunchTime = (PropertyChangedEventArgs)awaiter;
								obj2 = 35;
								if (__KnownINotifyPropertyChangedArgs.StateText != null)
								{
									obj2 = 24;
								}
								continue;
							case 25:
							case 65:
								((MainContent.MainContent_obj1_Bindings)/*Error near IL_0d56: Stack underflow*/).Connect((int)/*Error near IL_0d56: Stack underflow*/, awaiter);
								obj2 = 66;
								continue;
							case 45:
								awaiter = -1;
								__KnownINotifyPropertyChangedArgs.CloseText = (PropertyChangedEventArgs)(-1);
								obj2 = 10;
								if (__KnownINotifyPropertyChangedArgs.CanDelete != null)
								{
									obj2 = 42;
								}
								continue;
							case 15:
								return;
							case 11:
								return;
							case 32:
								goto IL_0dbc;
							case 85:
								_ = ref awaiter;
								/*Error near IL_0de2: Member reference must be method, but was: Field*/;
							case 62:
								__KnownINotifyPropertyChangedArgs.PayUrl = null;
								obj2 = 76;
								if (__KnownINotifyPropertyChangedArgs.JoinedAt != null)
								{
									obj2 = 67;
								}
								continue;
							case 72:
								_ = ref __KnownINotifyPropertyChangedArgs.TotalCoins;
								_ = ref awaiter;
								CastExtensions.As<LayoutTransformControl>((object)Unsafe.AsPointer(ref this));
								_ = 53;
								if (__KnownINotifyPropertyChangedArgs.CreatedAt != null)
								{
									_ = 18;
								}
								continue;
							case 6:
								((UIElementCollection)/*Error near IL_0e68: Stack underflow*/).Insert((int)/*Error near IL_0e68: Stack underflow*/, (UIElement)(object)(&awaiter));
								if ((int)/*Error near IL_0e6d: Stack underflow*/ == 0)
								{
									obj2 = 10;
									if (__KnownINotifyPropertyChangedArgs.MobileAccounts == null)
									{
										obj2 = 1;
									}
									continue;
								}
								goto case 29;
							case 84:
								Application.Start((ApplicationInitializationCallback)(object)(&awaiter));
								if ((int)/*Error near IL_0ea7: Stack underflow*/ == 0)
								{
									obj2 = 41;
									continue;
								}
								goto case 7;
							case 98:
								_ = ref awaiter;
								awaiter = DispatcherQueue.GetForCurrentThread();
								_ = 91;
								continue;
							case 113:
								goto IL_0ec4;
							case 93:
								awaiter = 5;
								__KnownINotifyPropertyChangedArgs.InputMobile = (PropertyChangedEventArgs)5;
								obj2 = 24;
								if (__KnownINotifyPropertyChangedArgs.VerifyCodeDelayText != null)
								{
									obj2 = 11;
								}
								continue;
							case 21:
								awaiter = -1;
								__KnownINotifyPropertyChangedArgs.InfoBarMessage = (PropertyChangedEventArgs)(-1);
								obj2 = 98;
								continue;
							case 88:
								string.IsNullOrEmpty((string?)(&awaiter));
								Sessions.ScanAttribute();
								_ = 75;
								continue;
							case 49:
								__KnownINotifyPropertyChangedArgs.IsDragging = null;
								obj2 = 98;
								if (__KnownINotifyPropertyChangedArgs.HasSelectedFile != null)
								{
									obj2 = 102;
								}
								continue;
							case 19:
								goto IL_0fa2;
							case 114:
								switch ((int)awaiter)
								{
								case 0:
									break;
								case 3:
									goto IL_0873;
								case 6:
									goto IL_0b8a;
								case 2:
									goto IL_0cd0;
								case 1:
									goto IL_0d22;
								case 4:
									goto IL_0ec4;
								default:
									goto IL_0fdb;
								case 5:
									goto IL_10e4;
								}
								goto case 30;
							case 64:
								awaiter = 3;
								__KnownINotifyPropertyChangedArgs.ImportedCount = (PropertyChangedEventArgs)3;
								obj2 = 99;
								if (__KnownINotifyPropertyChangedArgs.ParsedAccounts == null)
								{
									obj2 = 44;
								}
								continue;
							case 29:
								awaiter = (object)new CollectionVisibilityConverter();
								awaiter = (object)/*Error near IL_1017: Stack underflow*/;
								obj2 = 48;
								if (__KnownINotifyPropertyChangedArgs.SelectedGame != null)
								{
									obj2 = 70;
								}
								continue;
							case 53:
								return;
							case 79:
								XamlMetaDataProvider.DecorateDetailedUser();
								((NullToObjectConverter)null)._002Ector();
								_ = 23;
								continue;
							case 109:
								awaiter = (object)new ImplicitAnimationSet();
								if ((int)/*Error near IL_10aa: Stack underflow*/ == 0)
								{
									obj2 = 93;
									continue;
								}
								goto case 88;
							case 17:
								((OffsetAnimation)/*Error near IL_10c8: Stack underflow*/)._002Ector();
								((TableView)__KnownINotifyPropertyChangedArgs.NetGamesEmptyText)._002Ector();
								((TableViewColumnHeader)/*Error near IL_10d8: Stack underflow*/)._002Ector();
								awaiter = (object)/*Error near IL_10da: Stack underflow*/;
								obj2 = 109;
								continue;
							case 106:
								goto IL_10e4;
							case 58:
								goto IL_1145;
							case 37:
								goto end_IL_0149;
								IL_0873:
								_ = IControlOverridesMethods.IID;
								((Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails)awaiter).GetExposedInterfaces();
								((Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails)awaiter)._002Ector();
								_ = IContentControlOverridesMethods.AbiToProjectionVftablePtr;
								awaiter = (nint)IComponentConnectorMethods.IID;
								_ = 48;
								if (__KnownINotifyPropertyChangingArgs.LikeNetGames == null)
								{
									_ = 16;
								}
								continue;
								IL_10e4:
								((TableViewConditionalCellStyle)/*Error near IL_10e9: Stack underflow*/)._002Ector();
								if (__KnownINotifyPropertyChangedArgs.Skins == null)
								{
									_ = null;
									__ldftn(XamlTypeInfoProvider.Activate_4_LocalizationSource);
									__KnownINotifyPropertyChangedArgs.SkinAllSelected = (PropertyChangedEventArgs)(object)new ObservableCollection<AccountModel>();
								}
								val = new CaseCollection();
								((Case)null)._002Ector();
								((Segmented)val)._002Ector();
								awaiter = (object)__ldftn(XamlTypeInfoProvider.Activate_11_BoolNegationConverter);
								_ = 4;
								if (__KnownINotifyPropertyChangedArgs.SearchText == null)
								{
									_ = 6;
								}
								continue;
								IL_0fdb:
								obj2 = 31;
								continue;
								IL_0ec4:
								((DispatcherQueueSynchronizationContext)/*Error near IL_0ec9: Stack underflow*/)._002Ector((DispatcherQueue)/*Error near IL_0ec9: Stack underflow*/);
								key = awaiter;
								obj3 = MainWindow._003C_003Ec__DisplayClass0_0.CheckEditableCollection();
								((MainWindow._003C_003Ec__DisplayClass1_0)awaiter)._002Ector();
								((Dictionary<string, IXamlType>)/*Error near IL_0ee1: Stack underflow*/).Add((string)key, (IXamlType)(object)((IXamlType)obj3).FullName);
								awaiter = (object)/*Error near IL_0ee3: Stack underflow*/;
								obj2 = 22;
								if (__KnownINotifyPropertyChangedArgs.InputMobilePassword == null)
								{
									obj2 = 3;
								}
								continue;
								IL_07d6:
								throw new IUIElementOverridesMethods();
								IL_06e0:
								_ = 1;
								_ = IEnumerable_object.Initialized;
								IEnumerable_object.Do_Abi_First_0((nint)INotifyPropertyChangedMethods.AbiToProjectionVftablePtr, (nint*)(nint)awaiter);
								_ = __KnownINotifyPropertyChangingArgs.Quantity;
								awaiter = IEnumerable_object.SaveAttribute();
								_ = 105;
								continue;
								IL_0d22:
								throw new OverlappedPresenter((byte)/*Error near IL_0d27: Stack underflow*/ != 0);
								IL_0cd0:
								typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)/*Error near IL_0cd5: Stack underflow*/);
								((MainContent.IMainContent_Bindings)awaiter).Update();
								((MainContent.IMainContent_Bindings)awaiter).StopTracking();
								((Window)((UserControl)/*Error near IL_0ce8: Stack underflow*/ != (UserControl)(object)typeFromHandle))._002Ector();
								awaiter = (object)/*Error near IL_0cef: Stack underflow*/;
								obj2 = 84;
								continue;
								IL_0c5b:
								_ = 1;
								_ = ((TaskAwaiter*)App.CheckLogicalSynchronizer())->IsCompleted;
								_ = __KnownINotifyPropertyChangedArgs.IsSelected;
								awaiter = App._003CLogout_003Ed__15.ReplaceModel();
								_ = 97;
								continue;
								IL_0c01:
								obj2 = 63;
								if (__KnownINotifyPropertyChangedArgs.CreateAt == null)
								{
									obj2 = 39;
								}
								continue;
								IL_0b8a:
								((ILogger)/*Error near IL_0b8f: Stack underflow*/).Warning((string)/*Error near IL_0b8f: Stack underflow*/);
								((App)/*Error near IL_0b96: Stack underflow*/).SetAppRequestTheme((ElementTheme)awaiter);
								((App)/*Error near IL_0b9d: Stack underflow*/).SetAppRequestBackdrop((EnumBackdropType)awaiter);
								((Uri)/*Error near IL_0ba2: Stack underflow*/)._002Ector((string)/*Error near IL_0ba2: Stack underflow*/);
								awaiter = Log.Logger;
								obj2 = 85;
								if (__KnownINotifyPropertyChangingArgs.SerializeAttribute == null)
								{
									obj2 = 40;
								}
								continue;
								IL_064f:
								IMessengerExtensions.Register<ChatMessage>((IMessenger)/*Error near IL_0665: Stack underflow*/, (object)/*Error near IL_0665: Stack underflow*/, (MessageHandler<object, ChatMessage>)(object)IEnumerator_System_IDisposable.Do_Abi_GetMany_3((nint)/*Error near IL_0660: Stack underflow*/, (uint)/*Error near IL_0660: Stack underflow*/, (nint)(int)IEnumerator_System_IDisposable.Do_Abi_MoveNext_2((nint)/*Error near IL_0659: Stack underflow*/, (byte*)(int)IEnumerator_System_IDisposable.Init()), (uint*)(nint)awaiter));
								obj2 = 34;
								continue;
								IL_063d:
								awaiter = __KnownINotifyPropertyChangingArgs.CloseText;
								obj2 = 114;
								continue;
								IL_0a32:
								((RegexRunner)(object)_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.CheckModularTransaction())._002Ector();
								((_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory)awaiter)._002Ector();
								((_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner)1).Scan((ReadOnlySpan<char>)awaiter);
								awaiter = ((_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner)/*Error near IL_0a56: Stack underflow*/).TryMatchAtCurrentPosition((ReadOnlySpan<char>)__KnownINotifyPropertyChangingArgs.InputInviteCode);
								obj2 = 18;
								if (__KnownINotifyPropertyChangingArgs.IsLoading != null)
								{
									obj2 = 1;
								}
								continue;
								IL_09b3:
								((Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails)1)._002Ector();
								/*Error near IL_09b9: Member reference must be method, but was: Field*/;
								IL_096d:
								obj2 = 50;
								if (__KnownINotifyPropertyChangingArgs.HasSkins == null)
								{
									obj2 = 1;
								}
								continue;
							}
							break;
							IL_1145:
							PropertyChangedEventArgs lastSearchText = __KnownINotifyPropertyChangedArgs.LastSearchText;
							if (lastSearchText == null)
							{
								obj2 = 14;
								continue;
							}
							((XamlTypeInfoProvider)((XamlTypeInfoProvider)(object)lastSearchText).Activate_18_NullToVisibilityConverter()).Activate_19_NullToObjectConverter();
							_ = 90;
							continue;
							IL_09de:
							PropertyChangingEventArgs selectedItem = __KnownINotifyPropertyChangingArgs.SelectedItem;
							if (selectedItem == null)
							{
								obj2 = 33;
								continue;
							}
							((SymbolIcon)selectedItem)._002Ector();
							((XamlTypeInfoProvider)/*Error near IL_118a: Stack underflow*/).Activate_21_BoolToBrushConverter();
							_ = 95;
						}
						goto case 5;
						IL_0fa2:
						__KnownINotifyPropertyChangedArgs.ParsedCount = (PropertyChangedEventArgs)awaiter;
						awaiter = 72;
						goto IL_0170;
						IL_0aa2:
						awaiter = __KnownINotifyPropertyChangingArgs.HasShopDescription;
						awaiter = 103;
						goto IL_0170;
						IL_0dbc:
						((MainContent.MainContent_obj1_Bindings)/*Error near IL_0dc6: Stack underflow*/).Activated((object)/*Error near IL_0dc6: Stack underflow*/, (WindowActivatedEventArgs)(object)((MainContent.MainContent_obj1_Bindings)/*Error near IL_0dc1: Stack underflow*/).SetDataRoot((object)/*Error near IL_0dc1: Stack underflow*/));
						((MainContent.MainContent_obj1_Bindings)/*Error near IL_0dcd: Stack underflow*/).Loading((FrameworkElement)/*Error near IL_0dcd: Stack underflow*/, awaiter);
						((AsyncTaskMethodBuilder*)/*Error near IL_0dd2: Stack underflow*/)->Start(ref *(Desktop._003CLoadWebView2_003Ed__8*)/*Error near IL_0dd2: Stack underflow*/);
						awaiter = 12;
						goto IL_0170;
						IL_0942:
						awaiter = 25;
						goto IL_0170;
						IL_07c4:
						awaiter = __KnownINotifyPropertyChangingArgs.InfoBarSeverity;
						obj2 = 104;
						goto IL_0174;
						IL_078a:
						awaiter = __KnownINotifyPropertyChangingArgs.InputVerifyCode;
						obj2 = 62;
						if (__KnownINotifyPropertyChangingArgs.InfoBarMessage == null)
						{
							obj2 = 23;
						}
						goto IL_0174;
						IL_0748:
						_ = 1;
						GlobalVtableLookup.DecorateDetailedAttribute();
						_ = IDisposableMethods.AbiToProjectionVftablePtr;
						((Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails)awaiter)._002Ector();
						Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.DecorateGeneralAttribute();
						_ = 1;
						awaiter = Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.NewAttribute();
						awaiter = 56;
						goto IL_0170;
						IL_05ad:
						__KnownINotifyPropertyChangingArgs.Characters = null;
						awaiter = 92;
						goto IL_0170;
						IL_059b:
						awaiter = __KnownINotifyPropertyChangingArgs.ImageUrl;
						obj2 = 81;
						goto IL_0174;
						IL_04cf:
						awaiter = __KnownINotifyPropertyChangingArgs.IsMyself;
						awaiter = 101;
						goto IL_0170;
						IL_0483:
						__KnownINotifyPropertyChangingArgs.Username = (PropertyChangingEventArgs)awaiter;
						awaiter = 87;
						goto IL_0170;
						IL_0170:
						obj2 = awaiter;
						goto IL_0174;
						end_IL_0149:
						break;
					}
					break;
					end_IL_0026:
					break;
				}
				__KnownINotifyPropertyChangedArgs.SelectedTopUpGroupIndex = (PropertyChangedEventArgs)(-2);
				obj = 5;
				if (__KnownINotifyPropertyChangedArgs.TopUpItems != null)
				{
					obj = 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ꌀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777829, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00ꐀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777826, new IntPtr(2737335735116L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00ꔀ()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00ꘀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777827, new IntPtr(2737335735116L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00_A700()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ꠀ(object? P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0053: Expected Obj, but got I
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)(nint)Unsafe.AsPointer(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized), ref *(object[]*)P_0);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00꤀(object? P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777824, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoginRandom_003Ed__85 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AccountViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object? DecorateSegmentedComparator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ReflectCommonBridge()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? CheckAdaptableCommand()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00錀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777825, new IntPtr(2737335708076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00鐀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0076: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I
			//IL_00a0: Expected Obj, but got Ref
			//IL_0327: Expected Obj, but got I4
			//IL_0327: Expected Obj, but got Ref
			//IL_01bc: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_027b: Expected Obj, but got I
			//IL_027b: Expected I, but got Obj
			//IL_0286: Expected I, but got Obj
			//IL_0288: Expected Obj, but got I4
			//IL_0175: Expected Obj, but got Ref
			//IL_0233: Expected Obj, but got Ref
			//IL_0204: Expected Obj, but got I4
			//IL_025f: Expected Obj, but got I4
			//IL_0264: Expected Obj, but got I4
			//IL_0264: Expected Obj, but got Ref
			//IL_0194: Expected Obj, but got Ref
			//IL_01d0: Expected Obj, but got I4
			//IL_01d5: Expected Obj, but got I4
			//IL_01d5: Expected Obj, but got Ref
			//IL_0146: Expected Obj, but got Ref
			//IL_014e: Expected Obj, but got Ref
			//IL_014e: Expected Obj, but got Ref
			//IL_008f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ac->IL0026: Incompatible stack types: I4 vs Obj
			//IL_033b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0346->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0255->IL027b: Incompatible stack heights: 2 vs 1
			//IL_0162->IL00d7: Incompatible stack heights: 3 vs 1
			//IL_00d7->IL00d7: Incompatible stack heights: 2 vs 1
			//IL_016d->IL00d7: Incompatible stack heights: 3 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				int num;
				IListMethods<object> val;
				switch ((int)obj2)
				{
				case 3:
					obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					obj2 = 1;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 2;
					}
					continue;
				case 1:
					return;
				default:
					*((int, nint)*)(nint)/*Error near IL_007b: Stack underflow*/ = ((int)/*Error near IL_007b: Stack underflow*/, (nint)Unsafe.AsPointer(ref IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute));
					obj2 = 1;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 1;
					}
					continue;
				case 4:
					obj = IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute;
					obj2 = 3;
					continue;
				case 2:
					if (obj == null)
					{
						num = 9;
						if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
						{
							num = 10;
						}
						goto IL_00d7;
					}
					goto IL_01b5;
				case 5:
					break;
					IL_0243:
					new IListMethods<object>((IntPtr)(nint)(delegate* unmanaged[Stdcall]<nint, uint, nint, uint>)(&IList_object.Do_Abi_SetAt_4));
					goto IL_027b;
					IL_01b5:
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.Do_Abi_First_0((nint)/*Error near IL_01bc: Stack underflow*/, (nint*)(nint)obj) != 0)
					{
						num = 7;
						goto IL_00d7;
					}
					val = (IListMethods<object>)new IListMethods<object>((IntPtr)obj, (object[])(delegate* unmanaged[Stdcall]<nint, nint, uint>)(&IList_object.Do_Abi_Append_7));
					goto IL_027b;
					IL_027b:
					obj = IEnumeratorMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, nint*, int>)/*Error near IL_0286: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)/*Error near IL_0286: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)val, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, uint*, int>)(int)IListMethods<object>.Abi_get_Size_1((IntPtr)5));
					num = 2;
					goto IL_00d7;
					IL_00d7:
					while (true)
					{
						switch (num)
						{
						case 6:
							return;
						case 2:
							if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)/*Error near IL_011c: Stack underflow*/, (uint)(&obj)) == null)
							{
								num = 9;
								if (IEnumerator_System_IDisposable._initialized != 0)
								{
									num = 11;
								}
								continue;
							}
							goto case 4;
						case 12:
							_ = ref IEnumerator_System_IDisposable.ReflectTransferableAttribute;
							((XamlUserType)(&obj)).BoxType<EasingType>((object)Unsafe.AsPointer(ref this));
							_ = 4;
							if (IEnumerable_object._initialized == 0)
							{
								_ = 6;
							}
							continue;
						default:
							IEnumerable_object.ReflectSetAttribute = obj;
							num = 12;
							continue;
						case 8:
						case 10:
							obj = GlobalVtableLookup.CreateAttribute;
							num = 1;
							if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute != null)
							{
								num = 0;
							}
							continue;
						case 3:
							break;
						case 11:
							obj = 0;
							Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute = 0;
							num = 0;
							if (Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute != null)
							{
								num = 0;
							}
							continue;
						case 4:
							MarshalInspectable<object>.FromAbi((IntPtr)(nint)(&obj));
							obj = 9;
							continue;
						case 1:
							Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute = null;
							num = 5;
							continue;
						case 7:
							goto IL_0243;
						case 5:
							obj = -1;
							_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute = -1;
							num = 4;
							continue;
						case 9:
							goto end_IL_0026;
						}
						break;
					}
					goto IL_01b5;
					end_IL_0026:
					break;
				}
				__KnownINotifyPropertyChangingArgs.Message = (PropertyChangingEventArgs)(-2);
				obj2 = 0;
				if (__KnownINotifyPropertyChangingArgs.Content == null)
				{
					obj2 = 0;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00销()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777838, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00阀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00需()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777839, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00頀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777836, new IntPtr(2737335708076L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00餀()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00騀(object? P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0054: Expected Obj, but got I
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)(nint)Unsafe.AsPointer(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized), ref *(object[]*)P_0);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00鬀(object? P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777837, new IntPtr(2737335708076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLogoutAccount_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AccountModel accountModel;

		public AccountViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object? DecoratePortableConsumer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CheckBasicStrategy()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? CheckReadableSorter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00言()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777834, new IntPtr(2737335708076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00謀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0061: Expected Obj, but got Ref
			//IL_0311: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I
			//IL_02ec: Expected Obj, but got I4
			//IL_02ec: Expected Obj, but got Ref
			//IL_01ac: Expected Obj, but got Ref
			//IL_01b6: Expected I, but got Obj
			//IL_01c1: Expected Obj, but got I4
			//IL_00f1: Expected Obj, but got I
			//IL_0148: Expected Obj, but got Ref
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Expected Obj, but got I4
			//IL_0130: Expected Obj, but got Ref
			//IL_0138: Expected Obj, but got Ref
			//IL_0138: Expected Obj, but got Ref
			//IL_0223: Expected I, but got Obj
			//IL_0106: Expected Obj, but got I4
			//IL_010b: Expected Obj, but got Ref
			//IL_0178: Expected I, but got Obj
			//IL_0178: Expected Obj, but got Ref
			//IL_0161: Expected Obj, but got I4
			//IL_0166: Expected Obj, but got I4
			//IL_0166: Expected Obj, but got Ref
			//IL_01cc: Expected Obj, but got Ref
			//IL_0327->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0300->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0332->IL0026: Incompatible stack types: I4 vs Obj
			//IL_030b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008a->IL008a: Incompatible stack heights: 2 vs 1
			//IL_015c->IL0086: Incompatible stack heights: 0 vs 1
			//IL_0142->IL008a: Incompatible stack heights: 3 vs 1
			//IL_022d->IL008a: Incompatible stack heights: 4 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 4:
					obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					obj2 = 3;
					break;
				case 2:
					return;
				case 1:
					_ = ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
					/*Error near IL_0061: Member reference must be method, but was: Field*/;
				default:
					if (obj == null)
					{
						num = 5;
						goto IL_008a;
					}
					goto IL_01a6;
				case 5:
					goto IL_02e4;
				case 3:
					{
						obj = __KnownINotifyPropertyChangingArgs.CreateAt;
						obj2 = 0;
						if (__KnownINotifyPropertyChangingArgs.Name == null)
						{
							obj2 = 0;
						}
						break;
					}
					IL_01a6:
					_ = IEnumerable_object.ReflectSetAttribute;
					obj = IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.CheckSymbolicAttribute());
					obj = 9;
					goto IL_008a;
					IL_008a:
					while (true)
					{
						switch (num)
						{
						case 11:
							return;
						default:
							/*Error near IL_00e2: Stack underflow*/((object[])/*Error near IL_00e2: Stack underflow*/, (nint)(&obj));
							num = 3;
							if (IList_object.PatchAttribute != null)
							{
								num = 3;
							}
							continue;
						case 6:
							obj = -1;
							IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = -1;
							num = 0;
							if (IReadOnlyList_System_IDisposable._initialized == 0)
							{
								num = 0;
							}
							continue;
						case 2:
							_ = ref IReadOnlyList_System_IDisposable.ReflectConnectedAttribute;
							((XamlUserType)(&obj)).BoxType<TimeSpan>((object)Unsafe.AsPointer(ref this));
							_ = 11;
							continue;
						case 1:
							IReadOnlyList_object.ReflectLogicalAttribute = (object)default(NavigationViewItemPresenter);
							obj = 6;
							continue;
						case 12:
							obj = 0;
							IEnumerator_System_IDisposable.ReflectTransferableAttribute = 0;
							num = 7;
							continue;
						case 7:
							IEnumerable_System_IDisposable._initialized = (nint)obj;
							num = 2;
							if (IEnumerable_object._initialized == 0)
							{
								num = 2;
							}
							continue;
						case 4:
							break;
						case 5:
						case 13:
							obj = Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute;
							num = 1;
							if (Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute != null)
							{
								num = 1;
							}
							continue;
						case 9:
							if (IListMethods<object>.Abi_GetView_2((IntPtr)(nint)(&obj)) != null)
							{
								num = 8;
								continue;
							}
							goto case 12;
						case 3:
							IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectMonoAttribute();
							MarshalInspectable<object>.FromAbi((IntPtr)null);
							_ = 10;
							continue;
						case 10:
							goto IL_02e4;
						}
						break;
					}
					goto IL_01a6;
					IL_02e4:
					__KnownINotifyPropertyChangingArgs.Notes = (PropertyChangingEventArgs)(-2);
					obj2 = 1;
					if (__KnownINotifyPropertyChangingArgs.Username != null)
					{
						obj2 = 1;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00谀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777835, new IntPtr(2737335735116L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00贀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00踀()
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
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00輀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777832, new IntPtr(2737335735116L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00退(object? P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777833, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00鄀(object? P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0053: Expected Obj, but got I
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)(nint)Unsafe.AsPointer(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized), ref *(object[]*)P_0);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00鈀(object? P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777846, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRegisterRandom4399_003Ed__84 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AccountViewModel _003C_003E4__this;

		private TaskAwaiter<string> _003C_003Eu__1;

		internal static object? CheckRemoteConfig;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ReflectActiveEmitter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? ReflectJoinedRunner()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00茀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777847, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00萀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_04d8: Expected Obj, but got Ref
			//IL_04e3: Expected Obj, but got I4
			//IL_045f: Expected Obj, but got Ref
			//IL_005b: Expected Obj, but got I
			//IL_0486: Expected Obj, but got Ref
			//IL_04b3: Expected Obj, but got I4
			//IL_04b3: Expected Obj, but got Ref
			//IL_00a0: Expected Obj, but got I
			//IL_0279: Expected I4, but got Obj
			//IL_0279: Expected I, but got Obj
			//IL_027e: Expected Obj, but got I4
			//IL_027e: Expected I, but got Obj
			//IL_0280: Expected Obj, but got I4
			//IL_028f: Expected Obj, but got I4
			//IL_0260: Expected I, but got Obj
			//IL_01a5: Expected Obj, but got Ref
			//IL_01f8: Expected Obj, but got I4
			//IL_01fd: Expected Obj, but got I4
			//IL_01fd: Expected Obj, but got Ref
			//IL_01d1: Expected Obj, but got Ref
			//IL_0179: Expected Obj, but got Ref
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Expected Obj, but got I
			//IL_01e1: Expected Obj, but got Ref
			//IL_01e9: Expected Obj, but got Ref
			//IL_01e9: Expected Obj, but got Ref
			//IL_014f: Expected Obj, but got I4
			//IL_0154: Expected Obj, but got I4
			//IL_0154: Expected Obj, but got Ref
			//IL_0163: Expected Obj, but got I
			//IL_011a: Expected Obj, but got Ref
			//IL_011c: Expected Obj, but got I
			//IL_0475->IL0026: Incompatible stack types: I4 vs Obj
			//IL_049f->IL0026: Incompatible stack heights: 3 vs 1
			//IL_04c7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0480->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04aa->IL0026: Incompatible stack heights: 3 vs 1
			//IL_04d2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03cc->IL006f: Incompatible stack heights: 7 vs 1
			//IL_01f3->IL00b4: Incompatible stack heights: 3 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
						return;
					case 3:
					{
						int num = 0;
						if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute != null)
						{
							num = 0;
						}
						while (true)
						{
							int num2;
							bool flag;
							switch (num)
							{
							case 2:
								if (obj == null)
								{
									num2 = 11;
									if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
									{
										num2 = 5;
									}
									goto IL_00b4;
								}
								goto IL_0243;
							default:
								num = 2;
								if (__KnownINotifyPropertyChangingArgs.ImageUrl != null)
								{
									num = 1;
								}
								continue;
							case 1:
								goto IL_03ab;
							case 3:
								break;
								IL_0243:
								flag = IListMethods<object>.Abi_IndexOf_3((IntPtr)/*Error near IL_0248: Stack underflow*/, (object)/*Error near IL_0248: Stack underflow*/, ref *(uint*)/*Error near IL_0248: Stack underflow*/);
								IListMethods<object>.Abi_ReplaceAll_11((IntPtr)(Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute ?? (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute = new IListMethods<object>((IntPtr)null, (uint)(delegate* unmanaged[Stdcall]<nint, nint*, uint>)(&IList_object.Do_Abi_GetView_2)))), (object[])IListMethods<object>.Abi_GetMany_10((IntPtr)obj, (uint)(int)new IListMethods<object>((IntPtr)(nint)(delegate* unmanaged[Stdcall]<nint, uint, nint, uint>)(&IList_object.Do_Abi_InsertAt_5)), ref *(object[]*)null));
								obj = flag;
								num2 = 1;
								if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator == null)
								{
									num2 = 0;
								}
								goto IL_00b4;
								IL_00b4:
								while (true)
								{
									switch (num2)
									{
									case 11:
									case 12:
										obj = IList_object._initialized;
										num2 = 8;
										continue;
									case 7:
										return;
									case 10:
										obj = -1;
										IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute = -1;
										num2 = 6;
										if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
										{
											num2 = 3;
										}
										continue;
									case 8:
										IReadOnlyList_object._initialized = unchecked((nint)default(MarshalInterface<IReadOnlyList<object>>));
										num2 = 10;
										if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
										{
											num2 = 10;
										}
										continue;
									case 1:
										if (MarshalInterface<INotifyPropertyChanged>.FromAbiArray((object)(&obj)) != null)
										{
											num2 = 5;
											if (IEnumerable_object._initialized == 0)
											{
												num2 = 2;
											}
											continue;
										}
										goto case 2;
									case 4:
										IEnumerable_object.ReflectSetAttribute = obj;
										num2 = 9;
										continue;
									case 9:
										_ = ref GlobalVtableLookup.CreateAttribute;
										((IEnumerable<NeteaseAccount>)(&obj)).Where((Func<NeteaseAccount, bool>)Unsafe.AsPointer(ref this));
										_ = 7;
										continue;
									case 2:
										obj = 0;
										Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute = 0;
										num2 = 1;
										if (Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute == null)
										{
											num2 = 4;
										}
										continue;
									case 5:
									case 6:
										IListMethods<object>.Abi_GetView_2((IntPtr)(nint)(&obj));
										num2 = 0;
										if (Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute != null)
										{
											num2 = 0;
										}
										continue;
									case 3:
										break;
									default:
										goto IL_03ab;
									}
									break;
								}
								goto IL_0243;
								IL_03ab:
								_ = __KnownINotifyPropertyChangingArgs.Characters;
								IReadOnlyList_System_IDisposable.StoreAttribute();
								IReadOnlyList_System_IDisposable.VerifyAttribute();
								_ = 1;
								_ = IReadOnlyList_object.Initialized;
								_ = 3;
								continue;
							}
							break;
						}
						break;
					}
					case 2:
						obj = __KnownINotifyPropertyChangingArgs.OperationText;
						obj2 = 0;
						if (__KnownINotifyPropertyChangingArgs.Type == null)
						{
							obj2 = 1;
						}
						continue;
					case 4:
						_ = ref __KnownINotifyPropertyChangingArgs.CanDelete;
						_ = IReadOnlyListMethods<object>.IID;
						_ = 0;
						if (__KnownINotifyPropertyChangingArgs.Price == null)
						{
							_ = 0;
						}
						continue;
					case 0:
						return;
					case 5:
						break;
					case 1:
						goto end_IL_0026;
					}
					__KnownINotifyPropertyChangingArgs.Paid = (PropertyChangingEventArgs)(-2);
					obj2 = 0;
					if (__KnownINotifyPropertyChangingArgs.PayAt == null)
					{
						obj2 = 4;
					}
					continue;
					end_IL_0026:
					break;
				}
				obj = __KnownINotifyPropertyChangingArgs.Number;
				obj = 3;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00蔀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777844, new IntPtr(2737335708076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00蘀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00蜀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777845, new IntPtr(2737335708076L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00蠀()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00褀(object? P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0053: Expected Obj, but got I
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)(nint)Unsafe.AsPointer(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized), ref *(object[]*)P_0);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
					{
						_ = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSendVerifyCode_003Ed__78 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AccountViewModel _003C_003E4__this;

		private nint _003Cdelay_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		internal static object? ReflectLiteralClient;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ReflectScalableListener()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? DecorateModularSet()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00礀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777842, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00稀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0050: Expected Obj, but got Ref
			//IL_0077: Expected Obj, but got Ref
			//IL_008b: Expected Obj, but got I
			//IL_0060: Expected Obj, but got Ref
			//IL_006b: Expected Obj, but got I4
			//IL_00a1: Expected Obj, but got Ref
			//IL_00a3: Expected Obj, but got I
			//IL_048d: Expected Obj, but got Ref
			//IL_03cb: Expected Obj, but got I4
			//IL_041c: Expected Obj, but got Ref
			//IL_041c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0443: Expected Obj, but got Ref
			//IL_03a7: Expected Obj, but got I4
			//IL_03ac: Expected Obj, but got I4
			//IL_03ac: Expected Obj, but got Ref
			//IL_03b5: Expected Obj, but got I4
			//IL_0582: Expected I, but got Obj
			//IL_0582: Expected I, but got Obj
			//IL_0169: Expected Obj, but got I4
			//IL_016e: Expected Obj, but got Ref
			//IL_04f3: Expected Obj, but got Ref
			//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fa: Expected Obj, but got Unknown
			//IL_04fa: Expected Obj, but got Ref
			//IL_060c: Expected Obj, but got I4
			//IL_060c: Expected Obj, but got Ref
			//IL_04d9: Expected I, but got Obj
			//IL_04e7: Expected Obj, but got I4
			//IL_05d6: Expected Obj, but got Ref
			//IL_03f0: Expected Obj, but got I4
			//IL_0456: Expected I, but got Obj
			//IL_0460: Expected Obj, but got Ref
			//IL_0465: Expected Obj, but got Ref
			//IL_013f: Expected Obj, but got Ref
			//IL_0134: Expected I4, but got Obj
			//IL_02d6: Expected I, but got Obj
			//IL_0154: Expected Obj, but got I
			//IL_01f5: Expected Obj, but got I4
			//IL_01fa: Expected Obj, but got I4
			//IL_01fa: Expected Obj, but got Ref
			//IL_0304: Expected Obj, but got Ref
			//IL_0269: Expected Obj, but got Ref
			//IL_02f4: Expected Obj, but got Ref
			//IL_027d: Expected Obj, but got I4
			//IL_0282: Expected Obj, but got I4
			//IL_0282: Expected Obj, but got Ref
			//IL_022e: Expected Obj, but got Ref
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a3: Expected Obj, but got Ref
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0090->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ad->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00bf->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_04a3->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_04ae->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_042c->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_044d->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0604->IL00c3: Incompatible stack heights: 3 vs 1
			//IL_05a1->IL00c3: Incompatible stack heights: 3 vs 1
			//IL_0182->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0504->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0620->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_05f3->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_04ec->IL00bf: Incompatible stack heights: 1 vs 0
			//IL_05e8->IL00c3: Incompatible stack heights: 2 vs 1
			//IL_040b->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0487->IL00c3: Incompatible stack heights: 2 vs 1
			//IL_03e6->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_05ac->IL00c3: Incompatible stack heights: 3 vs 1
			//IL_018d->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_062b->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0416->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0159->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0543->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0164->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_029d->IL01b6: Incompatible stack heights: 2 vs 1
			//IL_02bf->IL01b6: Incompatible stack heights: 2 vs 1
			//IL_02ca->IL01b6: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					object obj3;
					switch ((int)obj2)
					{
					default:
						return;
					case 1:
						IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = -2;
						obj2 = 2;
						continue;
					case 3:
						break;
					case 0:
						return;
					case 2:
						/*Error near IL_007c: Stack underflow*/((object[])/*Error near IL_007c: Stack underflow*/, (nint)Unsafe.AsPointer(ref IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized));
						obj2 = 0;
						if (IList_object.PatchAttribute != null)
						{
							obj2 = 0;
						}
						continue;
					case 4:
						obj = IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized;
						obj2 = 3;
						continue;
					case 5:
						{
							if (obj == null)
							{
								obj3 = 14;
								goto IL_00c3;
							}
							goto IL_03ba;
						}
						IL_03ba:
						if ((nint)obj != 1)
						{
							obj = 26;
							goto IL_00bf;
						}
						goto IL_0487;
						IL_0487:
						obj = __KnownINotifyPropertyChangingArgs.Characters;
						obj3 = 1;
						if (__KnownINotifyPropertyChangingArgs.IsLiked == null)
						{
							obj3 = 0;
						}
						goto IL_00c3;
						IL_00c3:
						while (true)
						{
							int num;
							switch ((int)obj3)
							{
							case 8:
							case 10:
								break;
							case 16:
								return;
							case 23:
							case 25:
								if ((nint)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute > 0)
								{
									obj3 = 3;
									if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
									{
										obj3 = 7;
									}
									continue;
								}
								goto IL_04d2;
							case 11:
								obj = -1;
								IReadOnlyList_object._initialized = -1;
								obj3 = 1;
								if (IEnumerator_System_IDisposable._initialized != 0)
								{
									obj3 = 4;
								}
								continue;
							case 18:
								if (obj == null)
								{
									num = 8;
									goto IL_01b6;
								}
								goto IL_02ca;
							case 6:
								goto IL_03a2;
							default:
								goto IL_03ba;
							case 5:
								if (IReadOnlyListMethods<IDisposable>.Abi_GetAt_0((IntPtr)/*Error near IL_03d7: Stack underflow*/, (uint)(&obj)) != null)
								{
									obj3 = 2;
									continue;
								}
								goto IL_03a2;
							case 22:
								obj = MarshalInterface<IDisposable>.FromAbi(MarshalInterface<IDisposable>.FromManaged((IDisposable)1000));
								obj3 = 5;
								if (__KnownINotifyPropertyChangingArgs.Content != null)
								{
									obj3 = 5;
								}
								continue;
							case 1:
								__KnownINotifyPropertyChangingArgs.IsSelected = (PropertyChangingEventArgs)default(INotifyCollectionChangedMethods);
								obj3 = 11;
								continue;
							case 3:
								__KnownINotifyPropertyChangingArgs.CanProxy = (PropertyChangingEventArgs)obj;
								obj3 = 20;
								continue;
							case 7:
							case 24:
								obj = new IReadOnlyListMethods<object, nint>((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0456: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)obj, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)1, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)1);
								((ILogger)/*Error near IL_0465: Stack underflow*/).Information<string, string>((string)/*Error near IL_0465: Stack underflow*/, (string)(&obj), (string)(object)__KnownINotifyPropertyChangingArgs.OnlinePlayers);
								IReadOnlyList_System_IDisposable.Do_Abi_get_Size_1((nint)/*Error near IL_047d: Stack underflow*/, (uint*)(IEnumeratorMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, nint*, int>)/*Error near IL_0478: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)/*Error near IL_0478: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)(int)IReadOnlyListMethods<object>.Abi_get_Size_1((IntPtr)(int)IReadOnlyList_System_IDisposable.Do_Abi_GetAt_0((nint)/*Error near IL_046c: Stack underflow*/, (uint)/*Error near IL_046c: Stack underflow*/, (nint*)(&obj))), (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, uint*, int>)(&obj)) ? 1 : 0));
								_ = 12;
								continue;
							case 21:
								goto IL_0487;
							case 19:
								goto IL_04d2;
							case 12:
								__KnownINotifyPropertyChangingArgs.LaunchTime = (PropertyChangingEventArgs)(__KnownINotifyPropertyChangingArgs.Executor - 1);
								obj3 = 22;
								continue;
							case 26:
							{
								object obj4 = obj;
								ComWrappersSupport.RegisterTypeComInterfaceEntriesLookup((Func<Type, ComWrappers.ComInterfaceEntry[]>)(object)IReadOnlyList_object.DecorateControllableAttribute());
								if (obj4 == null)
								{
									obj3 = 13;
									continue;
								}
								goto case 9;
							}
							case 9:
								IEnumerator_System_IDisposable.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_0587: Stack underflow*/, (byte*)(int)IEnumerator_System_IDisposable.Do_Abi_get_Current_0((nint)obj, (nint*)(nint)__KnownINotifyPropertyChangingArgs.Id));
								_ = 2;
								IEnumerator_System_IDisposable._002Ecctor();
								_ = 10;
								if (__KnownINotifyPropertyChangingArgs.PayAt == null)
								{
									_ = 6;
								}
								continue;
							case 20:
								_ = ref __KnownINotifyPropertyChangingArgs.Image;
								((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CSendVerifyCode_003Ed__78, DesktopViewModel._003CLaunchShadowClient_003Ed__5>(ref this));
								_ = 16;
								continue;
							case 13:
							case 14:
							case 17:
								obj3 = 18;
								continue;
							case 2:
							case 4:
								_ = ref obj;
								_ = INotifyCollectionChangedMethods.IID;
								_ = 25;
								continue;
							case 15:
								goto IL_0604;
								IL_02ca:
								IListMethods<object>.Abi_SetAt_4((IntPtr)/*Error near IL_02cf: Stack underflow*/, (uint)/*Error near IL_02cf: Stack underflow*/, (object)/*Error near IL_02cf: Stack underflow*/);
								IListMethods<object>.Abi_RemoveAt_6((IntPtr)/*Error near IL_02db: Stack underflow*/, IList_object.Do_Abi_GetView_2((nint)/*Error near IL_02d6: Stack underflow*/, (nint*)(nint)obj));
								IListMethods<object>.Abi_Append_7((IntPtr)/*Error near IL_02e0: Stack underflow*/, (object)/*Error near IL_02e0: Stack underflow*/);
								obj = (object)/*Error near IL_02e2: Stack underflow*/;
								num = 4;
								goto IL_01b6;
								IL_01b6:
								while (true)
								{
									switch (num)
									{
									case 1:
										return;
									case 2:
										obj = 0;
										IEnumerator_System_IDisposable.ReflectTransferableAttribute = 0;
										num = 5;
										continue;
									case 9:
										IEnumerable_object._initialized = unchecked((nint)default(IEnumeratorMethods<, >));
										num = 7;
										continue;
									case 4:
										if (MarshalInterface<IEnumerator<INotifyPropertyChanged>>.FromManaged((IEnumerator<INotifyPropertyChanged>)(&obj)) == (IntPtr)0)
										{
											num = 2;
											continue;
										}
										goto case 6;
									case 7:
										obj = -1;
										Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute = -1;
										num = 6;
										continue;
									case 6:
										IListMethods<object>.Abi_GetAt_0((IntPtr)/*Error near IL_0293: Stack underflow*/, (uint)(&obj));
										_ = 11;
										continue;
									case 10:
										_ = ref Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute;
										((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CSendVerifyCode_003Ed__78, _003CLoginHistoryAccount_003Ed__24>(ref this));
										_ = 0;
										if (Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute == null)
										{
											_ = 1;
										}
										continue;
									case 5:
										_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance = (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0)obj;
										num = 10;
										continue;
									case 3:
									case 8:
										obj = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute;
										num = 6;
										if ((int)_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout == 0)
										{
											num = 9;
										}
										continue;
									case 11:
										goto IL_0604;
									}
									break;
								}
								goto IL_02ca;
								IL_0604:
								__KnownINotifyPropertyChangingArgs.TotalCoins = (PropertyChangingEventArgs)60;
								obj3 = 19;
								if (__KnownINotifyPropertyChangingArgs.Amount == null)
								{
									obj3 = 23;
								}
								continue;
							}
							break;
						}
						goto case 1;
						IL_03a2:
						obj = 1;
						__KnownINotifyPropertyChangingArgs.LoginAt = (PropertyChangingEventArgs)1;
						obj = 3;
						goto IL_00bf;
						IL_04d2:
						IReadOnlyList_object.Do_Abi_IndexOf_2((nint)/*Error near IL_04de: Stack underflow*/, (nint)/*Error near IL_04de: Stack underflow*/, (uint*)/*Error near IL_04de: Stack underflow*/, (byte*)(int)IReadOnlyList_object.Do_Abi_GetAt_0((nint)/*Error near IL_04d9: Stack underflow*/, (uint)/*Error near IL_04d9: Stack underflow*/, (nint*)(nint)obj));
						obj = 8;
						goto IL_00bf;
						IL_00bf:
						obj3 = obj;
						goto IL_00c3;
					}
					break;
				}
				obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				obj = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00笀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777843, new IntPtr(2737335735116L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00簀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00紀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777840, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00縀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777841, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00缀()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00耀(object? P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0054: Expected Obj, but got I
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)(nint)Unsafe.AsPointer(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized), ref *(object[]*)P_0);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00脀(object? P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777854, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[CompilerGenerated]
	private Func<InfoBarDelegate>? m_GetInfoBar;

	[CompilerGenerated]
	private object? m_RequestCloseDialog;

	private object? _historyAccount;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? refreshCollectionCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? refreshStatesCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? createAccountCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<AccountModel>? editAccountCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<AccountModel>? logoutAccountCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<AccountModel>? loginHistoryAccountCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? exportAccountsCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? deleteAccountsCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? importAccountsCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? sendVerifyCodeCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? registerRandom4399Command;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? loginRandomCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<EnumAccountType>? loginBedrockCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<EnumAccountType>? loginDesktopCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<EnumAccountType>? loginMobileCommand;

	private static object? PatchEvaluator;

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public ObservableCollection<AccountModel> DesktopAccounts
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _0700();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			刀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public ObservableCollection<AccountModel> MobileAccounts
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return က();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00_E900(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public List<AccountModel> SelectedAccounts
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 樀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			氀(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int CurrentDisplayPage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)栀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00윀((uint)value);
		}
	}

	public bool IsAnyLoginRunning
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FF00() != 0;
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int SelectedIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)㜀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			䰀((uint)value);
		}
	}

	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public string? Input4399Username
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string?)䴀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00_EC00(value);
		}
	}

	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public string? InputEmail
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string?)_FF00_FF00_FF00_FF00_FF00_FF00_FF00豈();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00ﴀ(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public string? InputCookie
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string?)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_F100();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00섀(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? Input4399Password
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string?)ᘀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_0D00(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public string? Input163Password
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string?)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_EF00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			䤀(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? InputMobilePassword
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string?)_2E00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00툀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public string? InputMobile
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string?)_3300();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00쬀(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? InputVerifyCode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string?)嘀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00퐀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public string? VerifyCodeDelayText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string?)挀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			䌀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public string? InfoBarMessage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string?)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_F700();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			this._FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD((object?)value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public InfoBarSeverity InfoBarSeverity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ጀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00_E000(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public bool InfoBarIsOpen
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return this._FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00쐀(value ? ((byte)1) : ((byte)0));
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IRelayCommand RefreshCollectionCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IRelayCommand)_2600();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand RefreshStatesCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IRelayCommand)ᨀ();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand CreateAccountCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)昀();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand<AccountModel> EditAccountCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F000();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<AccountModel> LogoutAccountCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _2400();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<AccountModel> LoginHistoryAccountCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 娀();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand ExportAccountsCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_F400();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand DeleteAccountsCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IRelayCommand)渀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand ImportAccountsCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_E300();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand SendVerifyCodeCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_FF00_FF00_FF00_FF00_FF00_FF00혀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand RegisterRandom4399Command
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)ᜀ();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand LoginRandomCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)开();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<EnumAccountType> LoginBedrockCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _0900();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<EnumAccountType> LoginDesktopCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return Ԁ();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<EnumAccountType> LoginMobileCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 崀();
		}
	}

	public event Func<InfoBarDelegate>? GetInfoBar
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			䜀(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00찀(value);
		}
	}

	public event Action? RequestCloseDialog
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			this._FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD((object?)value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00_E200(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe AccountViewModel()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = new ExceptionHelpers((Exception)(object)this);
		/*Error near IL_0025: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	private void RefreshCollection()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00_E700();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	private void RefreshStates()
	{
		㼀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CCreateAccount_003Ed__21))]
	private object CreateAccount()
	{
		return ᰀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEditAccount_003Ed__22))]
	[RelayCommand]
	private object EditAccount(object accountModel)
	{
		return Ȁ(accountModel);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLogoutAccount_003Ed__23))]
	[RelayCommand]
	private object LogoutAccount(object accountModel)
	{
		return 㰀(accountModel);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoginHistoryAccount_003Ed__24))]
	[RelayCommand]
	private object LoginHistoryAccount(object accountModel)
	{
		return 倀(accountModel);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoginByHistory_003Ed__25))]
	private object LoginByHistory(object accountModel)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD(accountModel);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CExportAccounts_003Ed__26))]
	private object ExportAccounts()
	{
		return 㬀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	private void DeleteAccounts()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00_E600();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CImportAccounts_003Ed__28))]
	private object ImportAccounts()
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F300();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnNavigatedTo()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00_ED00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static (string, string) Random4399Account()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CloseDialog()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00츀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RegisterLoginCommand()
	{
		_0B00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSendVerifyCode_003Ed__78))]
	[RelayCommand]
	private object SendVerifyCode()
	{
		return _2800();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InfoBar(object text, InfoBarSeverity severity = (InfoBarSeverity)0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		ሀ(text, severity);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InfoBar(object text, object url, InfoBarSeverity severity = (InfoBarSeverity)0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		堀(text, url, severity);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleNeedVerifyError(object e)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00ﬀ(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleError(object e)
	{
		㘀(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte CheckInput(EnumAccountType type)
	{
		return Ⰰ(type);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CRegisterRandom4399_003Ed__84))]
	private object RegisterRandom4399()
	{
		return 愀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoginRandom_003Ed__85))]
	[RelayCommand]
	private object LoginRandom()
	{
		return _3000();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoginBedrock_003Ed__86))]
	[RelayCommand]
	private object LoginBedrock(EnumAccountType type)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00_FF00퀀(type);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoginDesktop_003Ed__87))]
	[RelayCommand]
	private object LoginDesktop(EnumAccountType type)
	{
		return 䐀(type);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CLoginMobile_003Ed__88))]
	private object LoginMobile(EnumAccountType type)
	{
		return 㨀(type);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectInterruptibleProgram()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AccountViewModel? DecorateCustomizableTemplate()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00쀀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777365, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00섀(object? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got I
		//IL_0084: Expected I, but got Obj
		//IL_00d3->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00b4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0098->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00de->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00a3->IL0026: Incompatible stack heights: 3 vs 1
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
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_0049: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0050: Member reference must be method, but was: Field*/;
			case 4:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
				_ = 2;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					_ = 3;
				}
				break;
			case 2:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
				obj2 = 4;
				break;
			default:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 2;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
				{
					_ = 2;
				}
				break;
			case 3:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00숀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777362, new IntPtr(2737335728876L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00쌀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777363, new IntPtr(2737335700796L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00쐀(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00ab: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I
		//IL_00bf->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0081->IL006a: Incompatible stack heights: 1 vs 0
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00df->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ca->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0095->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a0->IL0026: Incompatible stack heights: 2 vs 1
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
			case 2:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (int)P_0;
				obj2 = 3;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					obj2 = 2;
				}
				break;
			case 4:
				return;
			case 1:
				/*Error near IL_0070: Stack underflow*/((object[])/*Error near IL_0070: Stack underflow*/, (nint)/*Error near IL_0070: Stack underflow*/);
				_ = IList_object._initialized;
				if (MarshalInspectable<object>.FromAbiArray((object)P_0) != null)
				{
					return;
				}
				_ = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
				{
					_ = 0;
				}
				break;
			default:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00ab: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00ab: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)IReadOnlyList_System_IDisposable._initialized);
				_ = 0;
				if (IReadOnlyList_object.ReflectLogicalAttribute != null)
				{
					_ = 2;
				}
				break;
			case 3:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00d5: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
				_ = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00씀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777360, new IntPtr(2737335708076L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00였(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777361, new IntPtr(2737335718476L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00윀(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00a0: Expected I, but got Obj
		//IL_00bb: Expected Obj, but got I4
		//IL_0076: Expected I, but got Obj
		//IL_0076: Expected I4, but got Obj
		//IL_00cf: Expected Obj, but got I
		//IL_00aa->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00c0->IL0044: Incompatible stack heights: 2 vs 0
		//IL_008a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0060->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d4->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0095->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00df->IL0026: Incompatible stack heights: 3 vs 1
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
			case 4:
				return;
			case 3:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (int)P_0;
				obj2 = 2;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 1;
				}
				break;
			case 2:
				((ValueTuple<int, nint>*)/*Error near IL_0076: Stack underflow*/)->_002Ector((int)this, (nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute);
				obj2 = 4;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 3;
				}
				break;
			default:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute);
				_ = 3;
				break;
			case 1:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_00af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_00af: Stack underflow*/);
				_ = IReadOnlyList_object._initialized;
				if (MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)P_0) != (IntPtr)0)
				{
					return;
				}
				_ = 0;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00저(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777374, new IntPtr(2737335718476L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00준(object? P_0, object? P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0079: Expected Obj, but got I
		//IL_007e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0057->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0089->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0062->IL0026: Incompatible stack heights: 4 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			case 1:
				_003CModule_003E.CheckAccessibleAttribute();
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				return;
			default:
				IEnumerator_object.Do_Abi_MoveNext_2((nint)this, (byte*)(nint)P_1);
				_ = 0;
				if (IList_object.PatchAttribute == null)
				{
					_ = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00쨀(object? P_0, object? P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777375, new IntPtr(2737335715356L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00쬀(object? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00b2: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_004f: Expected I, but got Obj
		//IL_0058: Expected Obj, but got I4
		//IL_0088: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_006e: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I4
		//IL_00c6->IL0026: Incompatible stack heights: 2 vs 1
		//IL_009c->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00d1->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a7->IL0026: Incompatible stack heights: 3 vs 1
		//IL_007d->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
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
					goto end_IL_0026;
				case 4:
					((Action<object[], nint>)IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)/*Error near IL_0062: Stack underflow*/, ref *(object[]*)/*Error near IL_0062: Stack underflow*/))((object[])IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized, (nint)P_0);
					if ((int)/*Error near IL_0073: Stack underflow*/ != 0)
					{
						obj2 = 3;
						continue;
					}
					break;
				case 2:
					MarshalInspectable<object>.FromAbiArray((object)IList_object._initialized);
					_ = 5;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
					{
						_ = 5;
					}
					continue;
				case 3:
					return;
				case 5:
					return;
				}
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00b2: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00b2: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)IReadOnlyList_System_IDisposable._initialized);
				_ = 0;
				if (IReadOnlyList_object.ReflectLogicalAttribute != null)
				{
					_ = 1;
				}
				continue;
				end_IL_0026:
				break;
			}
			IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00찀(Func<InfoBarDelegate?>? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I
		//IL_0102: Expected Obj, but got I4
		//IL_00e1: Expected Obj, but got I
		//IL_00be->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0060->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c9->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00e6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f1->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				default:
					return;
				case 4:
					obj = obj;
					obj2 = 0;
					if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute != null)
					{
						obj2 = 3;
					}
					continue;
				case 3:
					/*Error near IL_006e: Member reference must be method, but was: Field*/;
				case 1:
					_ = ref IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized;
					obj = CastExtensions.As<ImplicitAnimationSet>(obj);
					_ = 2;
					if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
					{
						_ = 2;
					}
					continue;
				case 2:
					if (obj == obj)
					{
						obj2 = 0;
						if (IReadOnlyList_object.ReflectLogicalAttribute == null)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 4;
				case 5:
					break;
				case 0:
					return;
				}
				break;
			}
			obj = IEnumerator_System_IDisposable._initialized;
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00촀(Func<InfoBarDelegate?>? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777372, new IntPtr(2737335719516L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00츀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_007e: Expected Obj, but got I
		//IL_0083->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
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
			default:
				return;
			case 2:
			{
				nint initialized = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
				if (initialized == 0)
				{
					obj2 = 1;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 1;
					}
					break;
				}
				/*Error near IL_006f: Stack underflow*/((object[])/*Error near IL_006f: Stack underflow*/, initialized);
				obj2 = 0;
				if (IList_object.PatchAttribute == null)
				{
					obj2 = 0;
				}
				break;
			}
			case 0:
				return;
			case 1:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00케()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777373, new IntPtr(2737335730956L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? _FF00_FF00_FF00_FF00_FF00_FF00_FF00퀀(EnumAccountType P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0050: Expected Obj, but got Ref
		//IL_0084: Expected Obj, but got Ref
		//IL_0093: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got Ref
		//IL_0076: Expected Obj, but got Ref
		//IL_00e7: Expected Obj, but got Ref
		//IL_00ee: Expected Obj, but got Ref
		//IL_00ee: Expected Obj, but got Ref
		//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0098->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f8->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e0->IL0026: Incompatible stack types: I4 vs Obj
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
			default:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 3;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 3;
				}
				break;
			case 4:
				*((int, nint)*)(nint)/*Error near IL_007b: Stack underflow*/ = ((int)/*Error near IL_007b: Stack underflow*/, (nint)Unsafe.AsPointer(ref IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute));
				return (object?)/*Error near IL_007c: Stack underflow*/;
			case 1:
				IList_object.PatchAttribute = this;
				obj2 = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
				{
					obj2 = 0;
				}
				break;
			case 3:
				IReadOnlyList_System_IDisposable._initialized = -1;
				obj2 = 5;
				break;
			case 2:
				IReadOnlyList_object._initialized = (IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00bc: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00bc: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_00bc: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(&obj)) ? 1 : 0);
				obj2 = 0;
				if (IEnumerator_System_IDisposable._initialized != 0)
				{
					obj2 = 1;
				}
				break;
			case 5:
				((XamlUserType)Unsafe.AsPointer(ref IEnumerator_System_IDisposable.ReflectTransferableAttribute)).BoxType<EasingType>((object)(&obj));
				_ = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? _FF00_FF00_FF00_FF00_FF00_FF00_FF00턀(EnumAccountType P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777370, new IntPtr(2737335724716L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00툀(object? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_0073: Expected I, but got Obj
		//IL_0073: Expected I4, but got Obj
		//IL_00a8: Expected Obj, but got I
		//IL_00ce->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ad->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b8->IL0026: Incompatible stack types: I4 vs Obj
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
			case 3:
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_004d: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0054: Member reference must be method, but was: Field*/;
			case 4:
				((ValueTuple<int, nint>*)/*Error near IL_0073: Stack underflow*/)->_002Ector((int)this, (nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute);
				obj2 = 1;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 1;
				}
				break;
			case 5:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute = P_0;
				obj2 = 4;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
				{
					obj2 = 4;
				}
				break;
			case 1:
				return;
			case 2:
				return;
			default:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00팀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777371, new IntPtr(2737335724716L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00퐀(object? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00af: Expected I, but got Obj
		//IL_00be: Expected Obj, but got I
		//IL_0073: Expected I, but got Obj
		//IL_0073: Expected I4, but got Obj
		//IL_0094: Expected Obj, but got I
		//IL_00c3->IL0026: Incompatible stack heights: 2 vs 1
		//IL_007d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0099->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ce->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a4->IL0026: Incompatible stack types: I4 vs Obj
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
			case 3:
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_0049: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0050: Member reference must be method, but was: Field*/;
			case 2:
				((ValueTuple<int, nint>*)/*Error near IL_0073: Stack underflow*/)->_002Ector((int)this, (nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute);
				obj2 = 4;
				break;
			case 0:
				return;
			case 4:
				IList_object.PatchAttribute = P_0;
				obj2 = 1;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
				{
					obj2 = 1;
				}
				break;
			case 1:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)IReadOnlyList_System_IDisposable._initialized);
				_ = 0;
				if (IReadOnlyList_object.ReflectLogicalAttribute == null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00픀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777368, new IntPtr(2737335714316L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _FF00_FF00_FF00_FF00_FF00_FF00_FF00혀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17265, 1790777369, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777369, new IntPtr(2737335733036L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00휀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777446, new IntPtr(2737335701836L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_006b: Expected I, but got Obj
		//IL_006b: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I4
		//IL_0050: Expected I, but got Obj
		//IL_00af: Expected I, but got Obj
		//IL_00be: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c3->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a4->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0084->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ce->IL0026: Incompatible stack heights: 2 vs 1
		//IL_008f->IL0026: Incompatible stack types: I4 vs Obj
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
			default:
				return;
			case 0:
				return;
			case 2:
				return;
			case 3:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 4;
				break;
			case 1:
				((Action<object[], nint>)IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)/*Error near IL_005f: Stack underflow*/, ref *(object[]*)/*Error near IL_005f: Stack underflow*/))((object[])IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized, (nint)P_0);
				if ((int)/*Error near IL_0070: Stack underflow*/ != 0)
				{
					obj2 = 0;
					if (IList_object.PatchAttribute == null)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 5;
			case 5:
				MarshalInspectable<object>.FromManaged((object)this, (byte)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0);
				_ = 3;
				break;
			case 4:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)IReadOnlyList_System_IDisposable._initialized);
				_ = 2;
				if (IReadOnlyList_object.ReflectLogicalAttribute != null)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777447, new IntPtr(2737335724716L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777444, new IntPtr(2737335718476L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777445, new IntPtr(2737335709116L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object? P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17272, 1790777442, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790777442, new IntPtr(2737335715356L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0050: Expected Obj, but got I
		//IL_00bb: Expected I4, but got Obj
		//IL_00bc: Expected Obj, but got I
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_00f9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a7->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00d6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0104->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b2->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00e1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0082->IL0026: Incompatible stack types: I4 vs Obj
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
				obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
				obj2 = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 0;
				}
				continue;
			case 5:
				if (obj == obj)
				{
					obj2 = 4;
					continue;
				}
				break;
			case 2:
				_ = ref IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute;
				obj = CastExtensions.As<InvokeCommandAction>(obj);
				_ = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					_ = 5;
				}
				continue;
			case 4:
				return;
			case 3:
				obj = (object)(Page)(object)(nint)MarshalInspectable<object>.FromManaged(obj, (byte)(int)P_0 != 0);
				obj2 = 0;
				if (IReadOnlyList_object._initialized != 0)
				{
					obj2 = 2;
				}
				continue;
			}
			obj = obj;
			obj2 = 0;
			if (IEnumerator_System_IDisposable._initialized != 0)
			{
				obj2 = 3;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777443, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E000(InfoBarSeverity P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0085: Expected I, but got Obj
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I
		//IL_0099->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00e9->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00bf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a4->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00f4->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ca->IL0026: Incompatible stack types: I4 vs Obj
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
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_0049: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0050: Member reference must be method, but was: Field*/;
			case 4:
				return;
			default:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
				_ = 3;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					_ = 3;
				}
				break;
			case 3:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
				obj2 = 2;
				if (IReadOnlyList_object.ReflectLogicalAttribute == null)
				{
					obj2 = 2;
				}
				break;
			case 2:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00d5: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
				_ = 1;
				if (IEnumerable_System_IDisposable.CombineAttribute == null)
				{
					_ = 4;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E100(InfoBarSeverity P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777440, new IntPtr(2737335718476L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E200(object? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I
		//IL_00a5: Expected I, but got Obj
		//IL_00a5: Expected I4, but got Obj
		//IL_00bb: Expected Obj, but got I
		//IL_006d->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00e7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0078->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00f2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cb->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					_ = ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					obj = CastExtensions.As<Frame>(obj);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
					{
						_ = 3;
					}
					continue;
				case 3:
					if (obj == obj)
					{
						obj2 = 5;
						continue;
					}
					break;
				case 1:
					break;
				case 4:
					*((int, nint)*)(nint)/*Error near IL_00a5: Stack underflow*/ = ((int)obj, (nint)P_0);
					obj = (MulticastDelegate)/*Error near IL_00a6: Stack underflow*/;
					obj2 = 0;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					obj = IReadOnlyList_System_IDisposable._initialized;
					obj2 = 1;
					if (IReadOnlyList_object._initialized == 0)
					{
						obj2 = 1;
					}
					continue;
				case 5:
					return;
				}
				break;
			}
			obj = obj;
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E300()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17278, 1790777441, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777441, new IntPtr(2737335723676L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777454, new IntPtr(2737335719516L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E600()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00c5: Expected I, but got Obj
		//IL_00c7: Expected Obj, but got I4
		//IL_004f: Expected I, but got Obj
		//IL_00a9: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I
		//IL_01b6: Expected Obj, but got I4
		//IL_0148: Expected I, but got Obj
		//IL_015c: Expected Obj, but got I
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_0132: Expected Obj, but got I4
		//IL_00ae->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0161->IL00d5: Incompatible stack heights: 2 vs 1
		//IL_017b->IL00d5: Incompatible stack heights: 2 vs 1
		//IL_0193->IL00d5: Incompatible stack heights: 3 vs 1
		//IL_00b9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0073->IL0026: Incompatible stack types: I4 vs Obj
		//IL_016c->IL00d5: Incompatible stack heights: 2 vs 1
		//IL_00d5->IL00d5: Incompatible stack heights: 3 vs 1
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
			default:
				return;
			case 4:
				if (IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute()) == 0)
				{
					return;
				}
				obj2 = 3;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				return;
			case 3:
				obj2 = 1;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
				{
					obj2 = 1;
				}
				break;
			case 1:
			{
				obj = IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00c5: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00c5: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(IEnumerator_object.DecorateAutomatableAttribute() ? 1 : 0));
				int num = 2;
				while (true)
				{
					switch (num)
					{
					case 3:
						return;
					case 5:
						obj++;
						num = 9;
						break;
					case 10:
						_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Initialized;
						MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)obj);
						obj = 4;
						break;
					case 4:
						IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_014d: Stack underflow*/, (uint)/*Error near IL_014d: Stack underflow*/, ref *(INotifyPropertyChanged[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_0148: Stack underflow*/, (uint)/*Error near IL_0148: Stack underflow*/, (uint)/*Error near IL_0148: Stack underflow*/, (nint)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_IndexOf_2((nint)/*Error near IL_0141: Stack underflow*/, (nint)/*Error near IL_0141: Stack underflow*/, (uint*)/*Error near IL_0141: Stack underflow*/, (byte*)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_013c: Stack underflow*/, (uint)/*Error near IL_013c: Stack underflow*/, (nint*)/*Error near IL_013c: Stack underflow*/)), (uint*)(nint)obj));
						_ = 5;
						if (IEnumerable_object.ReflectSetAttribute == null)
						{
							_ = 5;
						}
						break;
					case 6:
						IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.CheckSymbolicAttribute();
						_ = 3;
						break;
					case 8:
						_ = IEnumerable_System_ComponentModel_INotifyPropertyChanged.Initialized;
						MarshalInterface<IEnumerator<INotifyPropertyChanged>>.FromManaged((IEnumerator<INotifyPropertyChanged>)obj);
						_ = 10;
						break;
					case 1:
					case 7:
						obj = ((object[])obj)[obj];
						num = 8;
						break;
					case 2:
						obj = 0;
						num = 0;
						if (Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute != null)
						{
							num = 0;
						}
						break;
					default:
						if ((nint)obj < ((Array)obj).Length)
						{
							num = 1;
							if (Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute != null)
							{
								num = 1;
							}
							break;
						}
						goto case 6;
					}
				}
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E700()
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.ArgumentNullException: Value cannot be null. (Parameter 'source')
		//    at System.Linq.ThrowHelper.ThrowArgumentNullException(ExceptionArgument argument)
		//    at System.Linq.Enumerable.Skip[TSource](IEnumerable`1 source, Int32 count)
		//    at ICSharpCode.Decompiler.CSharp.ArgumentList.GetArgumentResolveResultsDirect(Int32 skipCount) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 124
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Probe() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 493
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Run() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 438
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.ForMethodReference(ExpressionBuilder expressionBuilder, IMethod method, IType targetType, TranslatedExpression target, Boolean requireTarget, ExpectedTargetDetails expectedTargetDetails, Boolean isExtensionMethodReference, Boolean castTargetUpFront) in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 131
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.DisambiguateDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1718
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1648
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildMethodReference(IMethod method, Boolean isVirtual) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1639
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitLdFtn(LdFtn inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 5058
		//    at ICSharpCode.Decompiler.IL.LdFtn.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 3175
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
		//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 461
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitNewObj(NewObj inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 538
		//    at ICSharpCode.Decompiler.IL.NewObj.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4578
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitStLoc(StLoc inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 855
		//    at ICSharpCode.Decompiler.IL.StLoc.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2590
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitStLoc(StLoc inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 129
		//    at ICSharpCode.Decompiler.IL.StLoc.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2586
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitIfInstruction(IfInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 162
		//    at ICSharpCode.Decompiler.IL.IfInstruction.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 1440
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertSwitchSectionBody(SwitchSection astSection, ILInstruction bodyInst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 334
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 280
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1338
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertAsBlock(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 87
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2435
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E800(ObservableCollection<AccountModel?>? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777455, new IntPtr(2737335728876L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E900(ObservableCollection<AccountModel?>? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_009f: Expected I, but got Obj
		//IL_0075: Expected I, but got Obj
		//IL_004f: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_00d0: Expected Obj, but got I
		//IL_00b3->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00be->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0094->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00df->IL0026: Incompatible stack types: I4 vs Obj
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
			default:
				return;
			case 3:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 2;
				}
				break;
			case 2:
				IList_object._initialized = (nint)P_0;
				obj2 = 1;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute);
				_ = 0;
				if (IReadOnlyList_object._initialized != 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 4:
				if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2(MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)/*Error near IL_00c4: Stack underflow*/), (INotifyPropertyChanged)IEnumerator_System_IDisposable._initialized, ref *(uint*)P_0))
				{
					return;
				}
				obj2 = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_EA00(ObservableCollection<AccountModel?>? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777452, new IntPtr(2737335711196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_EB00(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777453, new IntPtr(2737335728876L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_EC00(object? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00ac: Expected I, but got Obj
		//IL_00f2->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00dc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c0->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00cb->IL0026: Incompatible stack heights: 3 vs 1
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
			default:
				return;
			case 0:
				return;
			case 1:
				/*Error near IL_006c: Member reference must be method, but was: Field*/;
			case 5:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute);
				_ = 3;
				if (IReadOnlyList_object._initialized == 0)
				{
					_ = 2;
				}
				break;
			case 4:
				IReadOnlyList_object.ReflectLogicalAttribute = P_0;
				obj2 = 5;
				break;
			case 3:
				return;
			case 2:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00e8: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
				_ = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_ED00()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0045: Expected I, but got Obj
		//IL_0054: Expected Obj, but got I
		//IL_0059->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0064->IL0026: Incompatible stack heights: 3 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)_003CModule_003E.CheckAccessibleAttribute(), ref *(object[]*)null);
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_EE00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777450, new IntPtr(2737335718476L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _FF00_FF00_FF00_FF00_FF00_FF00_FF00_EF00()
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
	internal unsafe IAsyncRelayCommand<AccountModel?>? _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F000()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17291, 1790777451, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777451, new IntPtr(2737335725756L), 15);
		}
		return (IAsyncRelayCommand<AccountModel?>?)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F100()
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
	internal unsafe object? _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777448, new IntPtr(2737335714316L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F300()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17294, 1790777449, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777449, new IntPtr(2737335720556L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F400()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17295, 1790777462, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777462, new IntPtr(2737335703916L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777463, new IntPtr(2737335728876L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F600()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777460, new IntPtr(2737335722636L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F700()
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
	internal unsafe object? _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777461, new IntPtr(2737335726796L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _FF00_FF00_FF00_FF00_FF00_FF00_FF00豈()
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
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ﬀ(object? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_009c: Expected I4, but got Obj
		//IL_009c: Expected I, but got Obj
		//IL_00a7: Expected I4, but got Obj
		//IL_00d6: Expected I, but got Obj
		//IL_00c6: Expected Obj, but got I4
		//IL_0106: Expected I, but got Obj
		//IL_0106: Expected I, but got Obj
		//IL_010c: Expected I4, but got Obj
		//IL_0062: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I4
		//IL_0068: Expected I, but got Obj
		//IL_013d->IL0026: Incompatible stack heights: 5 vs 1
		//IL_00b1->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00d0->IL0026: Incompatible stack heights: 2 vs 1
		//IL_011c->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0148->IL0026: Incompatible stack heights: 5 vs 1
		//IL_007c->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00f4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ff->IL0026: Incompatible stack types: I4 vs Obj
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
				return;
			case 1:
				_ = IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute;
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)(IEnumerator_object.DecorateAutomatableAttribute() ? 1 : 0), (uint)(int)IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)IEnumerator_object.LoadAttribute(), (uint)(int)P_0), (nint*)MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)P_0));
				_ = 6;
				break;
			case 3:
				((XamlUserType)/*Error near IL_00c6: Stack underflow*/).BoxType<double>((object)IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_00c1: Stack underflow*/, IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_00bb: Stack underflow*/, (uint)/*Error near IL_00bb: Stack underflow*/, (uint)/*Error near IL_00bb: Stack underflow*/, (nint)/*Error near IL_00bb: Stack underflow*/, (uint*)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_IndexOf_2((nint)/*Error near IL_00b6: Stack underflow*/, (nint)/*Error near IL_00b6: Stack underflow*/, (uint*)/*Error near IL_00b6: Stack underflow*/, (byte*)/*Error near IL_00b6: Stack underflow*/)), ref *(INotifyPropertyChanged[]*)P_0));
				_ = 2;
				break;
			case 2:
				if (IEnumerableMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(int)IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)P_0)))
				{
					nint initialized = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					((Action<object[], nint>)IEnumerator_object.Initialized)((object[])IEnumerator_object.Init(), (nint)P_0);
					IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_0068: Stack underflow*/, (uint)/*Error near IL_0068: Stack underflow*/, initialized, (uint*)unchecked((nint)null));
					_ = 0;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						_ = 0;
					}
				}
				else
				{
					obj2 = 0;
					if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute == null)
					{
						obj2 = 1;
					}
				}
				break;
			case 6:
				IListMethods<object>.Abi_GetAt_0((IntPtr)(IListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0106: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_0106: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)/*Error near IL_0106: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_0106: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_0106: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_0106: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int>)/*Error near IL_0106: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, int>)/*Error near IL_0106: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_0106: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_0106: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, int>)P_0) ? 1 : 0), (uint)(int)P_0);
				_ = 3;
				IEnumerable_System_ComponentModel_INotifyPropertyChanged.DecorateSeparatedAttribute();
				_ = 4;
				break;
			default:
				MarshalInterface<IReadOnlyList<object>>.FromManaged((IReadOnlyList<object>)P_0);
				_ = 3;
				_ = IList_object.Initialized;
				_ = 5;
				if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute != null)
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
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ﰀ(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777458, new IntPtr(2737335719516L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ﴀ(object? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_009e: Expected I, but got Obj
		//IL_00cd: Expected Obj, but got I
		//IL_0088: Expected I, but got Obj
		//IL_00a8->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00d2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00dd->IL0026: Incompatible stack types: I4 vs Obj
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
			default:
				return;
			case 1:
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_004d: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0054: Member reference must be method, but was: Field*/;
			case 5:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
				_ = 3;
				break;
			case 0:
				return;
			case 4:
				return;
			case 2:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute);
				_ = 4;
				break;
			case 3:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
				obj2 = 2;
				if (IReadOnlyList_object.ReflectLogicalAttribute == null)
				{
					obj2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FE00(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777459, new IntPtr(2737335704956L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FF00()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0087: Expected I, but got Obj
		//IL_004f: Expected I, but got Obj
		//IL_00ca: Expected Obj, but got I4
		//IL_0079: Expected I, but got Obj
		//IL_007e: Expected Obj, but got I4
		//IL_007f: Expected I4, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I
		//IL_00cf->IL007f: Incompatible stack heights: 1 vs 0
		//IL_009b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e3->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0073->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ee->IL0026: Incompatible stack heights: 2 vs 1
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
			case 2:
				if (IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute()) != 0)
				{
					obj2 = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 1;
			case 4:
				return (byte)(int)MarshalInspectable<object>.FromAbiArray((object)IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_0079: Stack underflow*/, (uint)/*Error near IL_0079: Stack underflow*/, (nint)/*Error near IL_0079: Stack underflow*/, (uint*)(nint)this));
			default:
				return 1;
			case 1:
				if (MarshalInspectable<object>.FromManaged((object)/*Error near IL_008c: Stack underflow*/, (byte)IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_0087: Stack underflow*/, (byte*)(nint)this) != 0) == (IntPtr)0)
				{
					obj2 = 4;
					break;
				}
				goto default;
			case 3:
				if (MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Initialized) == (IntPtr)0)
				{
					_ = 2;
					if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
					{
						_ = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte Ā()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777456, new IntPtr(2737335702876L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? Ȁ(object? P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17308, 1790777457, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790777457, new IntPtr(2737335704956L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? _0300(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777470, new IntPtr(2737335718476L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? Ѐ()
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
	internal unsafe IAsyncRelayCommand<EnumAccountType>? Ԁ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17311, 1790777471, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777471, new IntPtr(2737335718476L), 15);
		}
		return (IAsyncRelayCommand<EnumAccountType>?)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<EnumAccountType>? _0600()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777468, new IntPtr(2737335719516L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<EnumAccountType>?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<AccountModel?>? _0700()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<AccountModel?>?)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<EnumAccountType>? ࠀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777469, new IntPtr(2737335713276L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<EnumAccountType>?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<EnumAccountType>? _0900()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17315, 1790777466, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777466, new IntPtr(2737335730956L), 15);
		}
		return (IAsyncRelayCommand<EnumAccountType>?)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<EnumAccountType>? _0A00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777467, new IntPtr(2737335705996L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<EnumAccountType>?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _0B00()
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.ArgumentNullException: Value cannot be null. (Parameter 'source')
		//    at System.Linq.ThrowHelper.ThrowArgumentNullException(ExceptionArgument argument)
		//    at System.Linq.Enumerable.Skip[TSource](IEnumerable`1 source, Int32 count)
		//    at ICSharpCode.Decompiler.CSharp.ArgumentList.GetArgumentResolveResultsDirect(Int32 skipCount) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 124
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Probe() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 493
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Run() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 438
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.ForMethodReference(ExpressionBuilder expressionBuilder, IMethod method, IType targetType, TranslatedExpression target, Boolean requireTarget, ExpectedTargetDetails expectedTargetDetails, Boolean isExtensionMethodReference, Boolean castTargetUpFront) in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 131
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.DisambiguateDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1718
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1648
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildMethodReference(IMethod method, Boolean isVirtual) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1639
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitLdFtn(LdFtn inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 5058
		//    at ICSharpCode.Decompiler.IL.LdFtn.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 3175
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Default(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 93
		//    at ICSharpCode.Decompiler.IL.ILVisitor`1.VisitLdFtn(LdFtn inst) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 7747
		//    at ICSharpCode.Decompiler.IL.LdFtn.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 3171
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertSwitchSectionBody(SwitchSection astSection, ILInstruction bodyInst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 334
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 280
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1338
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertAsBlock(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 87
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2435
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _0C00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777464, new IntPtr(2737335705996L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _0D00(object? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0078: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0099: Expected I, but got Obj
		//IL_007d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_009e->IL0049: Incompatible stack heights: 2 vs 0
		//IL_0088->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ce->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a8->IL0026: Incompatible stack heights: 3 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 0:
				return;
			case 4:
				return;
			case 3:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 2;
				break;
			case 1:
				/*Error near IL_0069: Stack underflow*/((object[])(object)this, IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized);
				obj2 = 0;
				if (IList_object.PatchAttribute != null)
				{
					obj2 = 0;
				}
				break;
			case 5:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)/*Error near IL_008d: Stack underflow*/);
				_ = IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute;
				if (IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)P_0))
				{
					_ = 4;
					break;
				}
				goto case 3;
			case 2:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
				obj2 = 1;
				if (IReadOnlyList_object.ReflectLogicalAttribute != null)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _0E00(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777465, new IntPtr(2737335707036L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<AccountModel?>? ༀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777414, new IntPtr(2737335726796L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<AccountModel?>?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<AccountModel?>? က()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<AccountModel?>?)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<AccountModel?>? ᄀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777415, new IntPtr(2737335728876L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<AccountModel?>?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void ሀ(object? P_0, InfoBarSeverity P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected I, but got Unknown
		//IL_007b: Expected I, but got Obj
		//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_009a->IL0026: Incompatible stack heights: 2 vs 1
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
			default:
				return;
			case 2:
				return;
			case 1:
			{
				nint initialized = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
				if (initialized == 0)
				{
					obj2 = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 0;
					}
					break;
				}
				/*Error near IL_0074: Stack underflow*/((object[])/*Error near IL_0074: Stack underflow*/, initialized);
				IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_007b: Stack underflow*/, (uint)/*Error near IL_007b: Stack underflow*/, (nint)P_0, (uint*)(nint)P_1);
				_ = 2;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					_ = 2;
				}
				break;
			}
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe InfoBarSeverity ጀ()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (InfoBarSeverity)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _1400(object? P_0, object? P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0044: Expected I, but got Obj
		//IL_0053: Expected Obj, but got I
		//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute());
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void ᔀ(object? P_0, object? P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777412, new IntPtr(2737335709116L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? ᘀ()
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
	internal unsafe object? ᜀ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17329, 1790777413, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777413, new IntPtr(2737335721596L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _1800(object? P_0, object? P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777410, new IntPtr(2737335726796L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void ᤀ(object? P_0, object? P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0044: Expected I, but got Obj
		//IL_0053: Expected Obj, but got I
		//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute());
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? ᨀ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17332, 1790777411, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777411, new IntPtr(2737335719516L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _1B00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777408, new IntPtr(2737335705996L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? ᰀ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17334, 1790777409, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777409, new IntPtr(2737335711196L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? ᴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777422, new IntPtr(2737335713276L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void Ḁ(object? P_0, object? P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777423, new IntPtr(2737335731996L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void ἀ(object? P_0, object? P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0079: Expected Obj, but got I
		//IL_0058->IL0026: Incompatible stack heights: 4 vs 1
		//IL_007e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0063->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0089->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			case 2:
				return;
			default:
				_003CModule_003E.CheckAccessibleAttribute();
				_ = 2;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 1:
				IEnumerator_object.Do_Abi_MoveNext_2((nint)this, (byte*)(nint)P_0);
				_ = 0;
				if (IList_object.PatchAttribute != null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static (string?, string?) _2100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777420, new IntPtr(2737335724716L), 15))(null, 0, new IntPtr(0L));
		return ((string?, string?))/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static (string?, string?) _2200()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)/*Error near IL_001e: Stack underflow*/, ref *(object[]*)ExceptionHelpers.GetHRForException((Exception)/*Error near IL_0019: Stack underflow*/));
		_ = 6;
		_ = 10;
		/*Error near IL_0021: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static (string?, string?) _2300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777421, new IntPtr(2737335705996L), 15))(null, 0, new IntPtr(0L));
		return ((string?, string?))/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<AccountModel?>? _2400()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17342, 1790777418, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777418, new IntPtr(2737335722636L), 15);
		}
		return (IAsyncRelayCommand<AccountModel?>?)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<AccountModel?>? _2500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777419, new IntPtr(2737335724716L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<AccountModel?>?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _2600()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17344, 1790777416, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777416, new IntPtr(2737335713276L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _2700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777417, new IntPtr(2737335724716L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? _2800()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17346, 1790777430, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777430, new IntPtr(2737335726796L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? _2900()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777431, new IntPtr(2737335724716L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe byte _2B00(EnumAccountType P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777428, new IntPtr(2737335724716L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe byte Ⰰ(EnumAccountType P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_00af: Expected I4, but got Obj
		//IL_0295: Expected I, but got VT
		//IL_029a: Expected I, but got Obj
		//IL_0241: Expected I, but got Obj
		//IL_0160: Expected I, but got Obj
		//IL_0105: Expected I, but got Obj
		//IL_011f: Expected Obj, but got I
		//IL_017f: Expected I, but got Obj
		//IL_0535: Expected I, but got Obj
		//IL_0535: Expected I, but got Obj
		//IL_03ec: Expected I, but got Obj
		//IL_01b7: Expected I4, but got Obj
		//IL_0231: Expected Obj, but got I4
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected I4, but got Unknown
		//IL_03a6: Expected Obj, but got I4
		//IL_02fd: Expected I, but got Obj
		//IL_04f1: Expected I, but got Obj
		//IL_04f1: Expected I, but got Obj
		//IL_02cc: Expected I, but got Obj
		//IL_0272: Expected I4, but got Obj
		//IL_013c: Expected Obj, but got I4
		//IL_020a: Expected I, but got Obj
		//IL_02e8: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I
		//IL_0285: Expected Obj, but got I4
		//IL_02b4->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0124->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0194->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0554->IL0026: Incompatible stack heights: 4 vs 1
		//IL_01f2->IL0026: Incompatible stack heights: 5 vs 1
		//IL_0350->IL0026: Incompatible stack heights: 7 vs 1
		//IL_023b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03b0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0506->IL0026: Incompatible stack heights: 4 vs 1
		//IL_059c->IL028a: Incompatible stack heights: 1 vs 0
		//IL_05f6->IL03a3: Incompatible stack heights: 1 vs 0
		//IL_02bf->IL0026: Incompatible stack heights: 2 vs 1
		//IL_025f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0174->IL0026: Incompatible stack types: I4 vs Obj
		//IL_012f->IL0026: Incompatible stack heights: 3 vs 1
		//IL_055f->IL0026: Incompatible stack heights: 4 vs 1
		//IL_01fd->IL0026: Incompatible stack heights: 5 vs 1
		//IL_035b->IL0026: Incompatible stack heights: 7 vs 1
		//IL_0141->IL03a3: Incompatible stack heights: 1 vs 0
		//IL_020f->IL01c8: Incompatible stack heights: 1 vs 0
		//IL_01c1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02ed->IL04e6: Incompatible stack heights: 1 vs 0
		//IL_05db->IL0026: Incompatible stack types: I4 vs Obj
		//IL_031b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05a6->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00cb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0600->IL0026: Incompatible stack heights: 2 vs 1
		//IL_026a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02db->IL0026: Incompatible stack types: I4 vs Obj
		//IL_014b->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0223->IL0026: Incompatible stack heights: 2 vs 1
		//IL_02f7->IL0026: Incompatible stack heights: 2 vs 1
		//IL_05e6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0326->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_022e->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 14;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 26:
					return 1;
				case 30:
					obj2 = 10;
					if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute != null)
					{
						obj2 = 0;
					}
					break;
				case 5:
					IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_010a: Stack underflow*/, (byte*)(int)IEnumerator_object.Do_Abi_get_Current_0((nint)this, (nint*)IList_object._initialized));
					_ = 2;
					IEnumerator_object._002Ecctor();
					_ = 15;
					if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
					{
						_ = 22;
					}
					break;
				case 22:
					return 1;
				case 4:
					if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_0165: Stack underflow*/, (INotifyPropertyChanged)/*Error near IL_0165: Stack underflow*/, ref *(uint*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_0160: Stack underflow*/, (uint)/*Error near IL_0160: Stack underflow*/, (nint*)(nint)this)))
					{
						obj2 = 25;
						break;
					}
					goto IL_01c3;
				case 7:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)this, (uint*)IEnumerable_System_IDisposable._initialized);
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
					_ = 2;
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.MoveAttribute();
					_ = 26;
					break;
				case 13:
					switch ((int)obj)
					{
					case 2:
						break;
					default:
						goto IL_01b7;
					case 3:
					case 4:
						goto IL_01ff;
					case 1:
						goto IL_026c;
					case 0:
						goto IL_02c1;
					case 5:
						goto IL_03a3;
					case 6:
						goto IL_05e6;
					}
					if (MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Initialized) != (IntPtr)0)
					{
						_ = 8;
						break;
					}
					goto IL_03a3;
				case 32:
					return 1;
				case 2:
				case 12:
				case 16:
				case 19:
				case 28:
					goto IL_01c3;
				case 9:
					_ = GlobalVtableLookup.CreateAttribute;
					_ = IEnumerable_System_ComponentModel_INotifyPropertyChanged.Initialized;
					IEnumerable_System_ComponentModel_INotifyPropertyChanged.Do_Abi_First_0((nint)(int)IEnumerable_System_ComponentModel_INotifyPropertyChanged.Init(), (nint*)2);
					_ = 15;
					if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute == null)
					{
						_ = 15;
					}
					break;
				case 27:
					return 1;
				case 14:
					obj = P_0;
					obj2 = 13;
					break;
				case 3:
					goto IL_023b;
				case 6:
					return 1;
				default:
					IList_object.Do_Abi_ReplaceAll_11((nint)/*Error near IL_02a0: Stack underflow*/, IList_object.Do_Abi_GetMany_10((nint)/*Error near IL_029a: Stack underflow*/, (uint)/*Error near IL_029a: Stack underflow*/, (uint)/*Error near IL_029a: Stack underflow*/, (nint)this, (uint*)(int)IList_object.Do_Abi_Clear_9((nint)_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout)), (nint)2);
					_ = 18;
					if (__KnownINotifyPropertyChangingArgs.Username != null)
					{
						_ = 21;
					}
					break;
				case 15:
					return 1;
				case 21:
					return 1;
				case 23:
					goto IL_02f7;
				case 11:
					_ = __KnownINotifyPropertyChangingArgs.IsSkeleton;
					IEnumerator_System_ComponentModel_INotifyPropertyChanged.DecorateDynamicAttribute();
					IEnumerator_System_ComponentModel_INotifyPropertyChanged.DecorateConcreteAttribute();
					_ = 2;
					_ = IReadOnlyList_System_IDisposable.Initialized;
					_ = 4;
					if (__KnownINotifyPropertyChangingArgs.Author != null)
					{
						_ = 6;
					}
					break;
				case 1:
				case 18:
				case 20:
					goto IL_03a3;
				case 10:
				{
					(IReadOnlyList_object.Initialized ? ((AsyncTaskMethodBuilder*)1) : ((AsyncTaskMethodBuilder*)null))->Start(ref *(ImportAccountViewModel._003CSelectFile_003Ed__45*)null);
					IReadOnlyList_object.Do_Abi_IndexOf_2((nint)/*Error near IL_03ec: Stack underflow*/, (nint)/*Error near IL_03ec: Stack underflow*/, (uint*)(nint)this, (byte*)MarshalInterface<IEnumerator<IDisposable>>.FromManaged((IEnumerator<IDisposable>)this));
					int num = 0;
					if (__KnownINotifyPropertyChangingArgs.LaunchTime == null)
					{
						num = 0;
					}
					switch (num)
					{
					}
					goto IL_03a3;
				}
				case 24:
					IEnumerable_System_IDisposable.Do_Abi_First_0((nint)this, (nint*)(nint)__KnownINotifyPropertyChangingArgs.PayUrl);
					IEnumerable_System_IDisposable._002Ecctor();
					_ = 2;
					IEnumerable_System_IDisposable.CheckTransformableAttribute();
					_ = 32;
					break;
				case 8:
					IEnumerable_object.Do_Abi_First_0((nint)this, (nint*)(nint)__KnownINotifyPropertyChangingArgs.Amount);
					IEnumerable_object._002Ecctor();
					_ = 2;
					IEnumerable_object.SaveAttribute();
					_ = 16;
					if (__KnownINotifyPropertyChangingArgs.SelectedAccounts == null)
					{
						_ = 27;
					}
					break;
				case 29:
					goto IL_058c;
				case 17:
					switch (obj - 1)
					{
					case 0:
						break;
					case 4:
						goto IL_01c3;
					case 1:
						goto IL_023b;
					case 3:
						goto IL_02dd;
					case 2:
						goto IL_02f7;
					case 5:
						goto IL_058c;
					default:
						goto IL_05c7;
					}
					goto case 4;
				case 31:
					goto IL_05e6;
					IL_05c7:
					obj2 = 2;
					if (__KnownINotifyPropertyChangingArgs.InputEmail == null)
					{
						obj2 = 2;
					}
					break;
					IL_02c1:
					if (!IReadOnlyListMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_02cc: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_02cc: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(IList_object.AttachAttribute() ? 1 : 0)))
					{
						obj2 = 30;
						break;
					}
					goto case 7;
					IL_02dd:
					if (MarshalInterface<IDisposable>.FromManaged((IDisposable)IEnumerator_System_ComponentModel_INotifyPropertyChanged.Initialized) == (IntPtr)0)
					{
						_ = 19;
						break;
					}
					goto case 24;
					IL_058c:
					GlobalVtableLookup.LookupVtableEntries((object)this);
					if ((int)IEnumeratorMethods<INotifyPropertyChanged>.IID == 0)
					{
						_ = 16;
						break;
					}
					goto default;
					IL_026c:
					if (IListMethods<object>.Abi_GetMany_10((IntPtr)/*Error near IL_0277: Stack underflow*/, (uint)/*Error near IL_0277: Stack underflow*/, ref *(object[]*)IList_object.Do_Abi_RemoveAt_6((nint)/*Error near IL_0272: Stack underflow*/, (uint)(int)this)) != 0)
					{
						goto end_IL_0026;
					}
					goto IL_03a3;
					IL_01ff:
					if (MarshalInspectable<object>.FromAbi((IntPtr)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectMonoAttribute()) == null)
					{
						_ = 0;
						if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute == null)
						{
							_ = 1;
						}
						break;
					}
					goto case 9;
					IL_01c3:
					return 0;
					IL_02f7:
					if (IReadOnlyListMethods<IDisposable>.Abi_IndexOf_2((IntPtr)/*Error near IL_0302: Stack underflow*/, (IDisposable)/*Error near IL_0302: Stack underflow*/, ref *(uint*)IEnumerator_System_ComponentModel_INotifyPropertyChanged.Do_Abi_MoveNext_2((nint)/*Error near IL_02fd: Stack underflow*/, (byte*)(nint)this)))
					{
						obj2 = 0;
						if (__KnownINotifyPropertyChangingArgs.IsSelected != null)
						{
							obj2 = 0;
						}
						break;
					}
					goto IL_01c3;
					IL_01b7:
					obj2 = 18;
					break;
					IL_023b:
					IListMethods<object>.Abi_RemoveAt_6((IntPtr)/*Error near IL_0246: Stack underflow*/, IList_object.Do_Abi_GetView_2((nint)/*Error near IL_0241: Stack underflow*/, (nint*)(nint)this));
					if ((int)/*Error near IL_024b: Stack underflow*/ == 0)
					{
						obj2 = 9;
						if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance != null)
						{
							obj2 = 12;
						}
						break;
					}
					goto default;
					IL_03a3:
					obj = P_0;
					obj2 = 17;
					break;
					IL_05e6:
					((Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails)this).GetExposedInterfaces();
					if ((int)IEnumeratorMethods<object>.IID != 0)
					{
						_ = 11;
						break;
					}
					goto IL_03a3;
				}
				continue;
				end_IL_0026:
				break;
			}
			obj = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe byte ⴀ(EnumAccountType P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777429, new IntPtr(2737335705996L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _2E00()
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
	internal unsafe object? _2F00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777426, new IntPtr(2737335712236L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? _3000()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17354, 1790777427, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777427, new IntPtr(2737335705996L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? _3100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777424, new IntPtr(2737335731996L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _3200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777425, new IntPtr(2737335724716L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _3300()
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
	internal unsafe object? 㐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777438, new IntPtr(2737335724716L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 㘀(object? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0055: Expected I, but got Obj
		//IL_0055: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I4
		//IL_005b: Expected I, but got Obj
		//IL_0082: Expected I4, but got Obj
		//IL_00b2: Expected I, but got Obj
		//IL_00c6: Expected Obj, but got I
		//IL_006f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_009c->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00cb->IL0026: Incompatible stack heights: 2 vs 1
		//IL_007a->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a7->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00d6->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 1:
			{
				nint initialized = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
				((Action<object[], nint>)IEnumerator_object.Initialized)((object[])IEnumerator_object.Init(), (nint)P_0);
				IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_005b: Stack underflow*/, (uint)/*Error near IL_005b: Stack underflow*/, initialized, (uint*)unchecked((nint)null));
				_ = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					_ = 0;
				}
				break;
			}
			case 0:
				return;
			case 2:
				MarshalInspectable<object>.FromManaged((object)this, (byte)(int)P_0 != 0);
				_ = 3;
				IEnumerator_object.DecorateAutomatableAttribute();
				_ = 1;
				if (IReadOnlyList_object._initialized != 0)
				{
					_ = 1;
				}
				break;
			case 3:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00b7: Stack underflow*/, (INotifyPropertyChanged)/*Error near IL_00b7: Stack underflow*/, ref *(uint*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_00b2: Stack underflow*/, (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init(), (nint*)(nint)P_0));
				_ = 1;
				if (IEnumerable_System_IDisposable.CombineAttribute == null)
				{
					_ = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint 㜀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint 㠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777439, new IntPtr(2737335712236L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? 㤀(EnumAccountType P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777436, new IntPtr(2737335701836L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? 㨀(EnumAccountType P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00e4: Expected Obj, but got Ref
		//IL_00ea: Expected Obj, but got I4
		//IL_0050: Expected I, but got Obj
		//IL_0050: Expected Obj, but got Ref
		//IL_0059: Expected Obj, but got I4
		//IL_0092: Expected Obj, but got Ref
		//IL_0097: Expected I, but got Obj
		//IL_0065: Expected Obj, but got Ref
		//IL_006c: Expected Obj, but got Ref
		//IL_00f2: Expected Obj, but got Ref
		//IL_00be: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got Ref
		//IL_00cd: Expected Obj, but got I
		//IL_00ab->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0080->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00fc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008b->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00dd->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				case 1:
					break;
				case 3:
					_ = ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
					CastExtensions.As<AppNavigationViewItem>((object)(&obj));
					_ = 0;
					if (IList_object._initialized == 0)
					{
						_ = 0;
					}
					continue;
				case 2:
					IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)MarshalInspectable<object>.FromAbiArray((object)(&obj));
					obj2 = 1;
					if (IReadOnlyList_System_IDisposable._initialized != 0)
					{
						obj2 = 1;
					}
					continue;
				case 5:
					IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
					obj2 = 4;
					if (IReadOnlyList_object.ReflectLogicalAttribute == null)
					{
						obj2 = 0;
					}
					continue;
				default:
					return IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00e9: Stack underflow*/, (INotifyPropertyChanged)/*Error near IL_00e9: Stack underflow*/, ref Unsafe.As<nint, uint>(ref IEnumerator_System_IDisposable._initialized));
				case 4:
					IEnumerable_System_IDisposable._initialized = -1;
					obj2 = 3;
					continue;
				}
				break;
			}
			IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)this;
			obj = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? 㬀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17365, 1790777437, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777437, new IntPtr(2737335731996L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? 㰀(object? P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17366, 1790777434, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790777434, new IntPtr(2737335701836L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? 㴀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777435, new IntPtr(2737335729916L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 㸀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777432, new IntPtr(2737335707036L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 㼀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_004f: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I
		//IL_0172: Expected I, but got Obj
		//IL_0174: Expected Obj, but got I4
		//IL_01d9: Expected I4, but got Obj
		//IL_00e1: Expected I4, but got Obj
		//IL_0204: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		//IL_00ca: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I4
		//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0188->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0193->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f2->IL01bc: Incompatible stack heights: 1 vs 3
		//IL_01cd->IL01d2: Incompatible stack heights: 2 vs 0
		//IL_01cd->IL01fd: Incompatible stack heights: 2 vs 0
		//IL_01fd->IL01bc: Incompatible stack heights: 1 vs 3
		//IL_00aa->IL00da: Incompatible stack heights: 1 vs 0
		//IL_00aa->IL00af: Incompatible stack heights: 1 vs 0
		//IL_0099->IL0099: Incompatible stack heights: 1 vs 2
		//IL_01d2->IL01d2: Incompatible stack heights: 2 vs 0
		//IL_00af->IL00da: Incompatible stack heights: 1 vs 0
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
				obj = IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute());
				obj2 = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					obj2 = 0;
				}
				continue;
			case 2:
				while (true)
				{
					if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)/*Error near IL_00e1: Stack underflow*/, (uint)(int)obj) == null)
					{
						obj = 2;
						goto IL_0099;
					}
					goto IL_00af;
					IL_0099:
					int num2;
					switch (num2)
					{
					case 1:
						break;
					default:
						continue;
					case 2:
						return;
					}
					goto IL_00af;
					IL_00af:
					IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)obj);
					IEnumerator_object._002Ecctor();
					num2 = 0;
					if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
					{
						num2 = 0;
					}
					goto IL_0099;
				}
			case 3:
				return;
			case 4:
				break;
			default:
				while (true)
				{
					if (IListMethods<object>.Abi_GetAt_0((IntPtr)/*Error near IL_01d9: Stack underflow*/, (uint)(int)obj) == null)
					{
						_ = 1;
						if (Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute != null)
						{
							_ = 1;
						}
						goto IL_01bc;
					}
					goto IL_01fd;
					IL_01fd:
					MarshalInspectable<object>.FromAbi((IntPtr)obj);
					IList_object.Init();
					int num = 0;
					if (Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute != null)
					{
						num = 0;
					}
					goto IL_01bc;
					IL_01bc:
					switch (num)
					{
					case 1:
						break;
					default:
						continue;
					case 2:
						goto IL_01fd;
					}
					break;
				}
				break;
			}
			IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
			obj = IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)this);
			obj2 = 2;
			if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute != null)
			{
				obj2 = 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 䀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777433, new IntPtr(2737335724716L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 䄀(object? P_0, object? P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0044: Expected I, but got Obj
		//IL_0053: Expected Obj, but got I
		//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute());
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 䈀(object? P_0, object? P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777766, new IntPtr(2737335724716L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 䌀(object? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00f7: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_0053: Expected I, but got Obj
		//IL_00fc->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ae->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0107->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00b9->IL0026: Incompatible stack types: I4 vs Obj
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
			default:
				return;
			case 5:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 4;
				break;
			case 1:
				/*Error near IL_005d: Member reference must be method, but was: Field*/;
			case 0:
				return;
			case 2:
				return;
			case 4:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute = P_0;
				obj2 = 3;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
				{
					obj2 = 0;
				}
				break;
			case 3:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00e8: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
				_ = 0;
				if (IEnumerable_System_IDisposable.CombineAttribute == null)
				{
					_ = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? 䐀(EnumAccountType P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00dd: Expected Obj, but got Ref
		//IL_0065: Expected Obj, but got Ref
		//IL_006c: Expected Obj, but got Ref
		//IL_007b: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got Ref
		//IL_0093: Expected I, but got Obj
		//IL_0093: Expected Obj, but got Ref
		//IL_004f: Expected Obj, but got Ref
		//IL_0054: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got Ref
		//IL_0080->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00af->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008b->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00d6->IL0026: Incompatible stack types: I4 vs Obj
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
			case 4:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = ExceptionHelpers.GetHRForException((Exception)(&obj));
				obj2 = 3;
				break;
			case 1:
				_ = ref IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized;
				CastExtensions.As<NavigationView>((object)(&obj));
				_ = 0;
				if (IList_object.PatchAttribute == null)
				{
					_ = 0;
				}
				break;
			case 3:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)this;
				obj2 = 2;
				break;
			case 2:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute = P_0;
				obj2 = 5;
				break;
			case 5:
				IReadOnlyList_System_IDisposable._initialized = -1;
				obj2 = 1;
				if (IReadOnlyList_object._initialized != 0)
				{
					obj2 = 1;
				}
				break;
			default:
				return MarshalInterface<INotifyPropertyChanged>.FromAbi((IntPtr)(nint)Unsafe.AsPointer(ref IReadOnlyList_object.ReflectLogicalAttribute));
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? 䔀(EnumAccountType P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777767, new IntPtr(2737335707036L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 䘀(Func<InfoBarDelegate?>? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777764, new IntPtr(2737335700796L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 䜀(Func<InfoBarDelegate?>? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00ad: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got VT
		//IL_0079: Expected Obj, but got I
		//IL_00e4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a4->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00ef->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0089->IL0026: Incompatible stack heights: 2 vs 1
		//IL_005b->IL0026: Incompatible stack types: I4 vs Obj
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
			case 5:
				if (obj == obj)
				{
					obj2 = 3;
					continue;
				}
				break;
			case 2:
				obj = ((int, nint))(object)ExceptionHelpers.GetHRForException((Exception)(object)P_0);
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					_ = 4;
				}
				continue;
			case 4:
				_ = ref IList_object._initialized;
				obj = CastExtensions.As<MainContent>(obj);
				_ = 5;
				continue;
			case 3:
				return;
			case 1:
				obj = IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized;
				obj2 = 0;
				if (IReadOnlyList_System_IDisposable._initialized != 0)
				{
					obj2 = 0;
				}
				continue;
			}
			obj = obj;
			obj2 = 2;
			if (IReadOnlyList_object._initialized == 0)
			{
				obj2 = 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 䠀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777765, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 䤀(object? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_009d: Expected I, but got Obj
		//IL_0081->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0096->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00d2->IL006c: Incompatible stack heights: 2 vs 0
		//IL_00b1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00dc->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00bc->IL0026: Incompatible stack types: I4 vs Obj
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
			case 3:
				return;
			default:
				/*Error near IL_0077: Stack underflow*/((object[])(object)this, IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized);
				obj2 = 5;
				break;
			case 1:
				MarshalInspectable<object>.FromAbiArray((object)IList_object._initialized);
				_ = 2;
				break;
			case 5:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 1;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					obj2 = 1;
				}
				break;
			case 4:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00c1: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00c1: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_00c1: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_00c1: Stack underflow*/);
				_ = IReadOnlyList_object._initialized;
				if (MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)P_0) != (IntPtr)0)
				{
					_ = 3;
					break;
				}
				goto default;
			case 2:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 䨀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777762, new IntPtr(2737335724716L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 䬀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777763, new IntPtr(2737335724716L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 䰀(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00cd: Expected Obj, but got I
		//IL_0082->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f2->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00d2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00dd->IL0026: Incompatible stack types: I4 vs Obj
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
			default:
				return;
			case 0:
				return;
			case 3:
				return;
			case 2:
				/*Error near IL_0078: Stack underflow*/((object[])(object)this, IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized);
				obj2 = 4;
				break;
			case 4:
				IList_object._initialized = (int)P_0;
				obj2 = 5;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 4;
				}
				break;
			case 1:
				if (IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00b9: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)MarshalInspectable<object>.FromManaged((object)/*Error near IL_00ad: Stack underflow*/, (byte)/*Error near IL_00ad: Stack underflow*/ != 0), (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)IReadOnlyList_System_IDisposable._initialized, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(int)P_0))
				{
					obj2 = 0;
					if (IReadOnlyList_object.ReflectLogicalAttribute == null)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 2;
			case 5:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00e8: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? 䴀()
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
	internal unsafe object? 一()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777760, new IntPtr(2737335724716L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 伀(object? P_0, object? P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0052: Expected Obj, but got I
		//IL_0057->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0062->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute());
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
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
	private unsafe object? 倀(object? P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17386, 1790777761, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790777761, new IntPtr(2737335707036L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? 儀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777774, new IntPtr(2737335714316L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 刀(ObservableCollection<AccountModel?>? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_004f: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_0094: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0083->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0099->IL00a3: Incompatible stack heights: 2 vs 0
		//IL_00bf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a3->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00ca->IL0026: Incompatible stack types: I4 vs Obj
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
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 1;
				}
				break;
			case 2:
				MarshalInspectable<object>.FromAbiArray((object)IList_object._initialized);
				_ = 4;
				break;
			case 3:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)/*Error near IL_0088: Stack underflow*/);
				_ = IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute;
				if (!IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)P_0))
				{
					_ = 2;
					break;
				}
				return;
			case 1:
				return;
			case 4:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
				obj2 = 0;
				if (IReadOnlyList_object.ReflectLogicalAttribute != null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 匀(ObservableCollection<AccountModel?>? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777775, new IntPtr(2737335708076L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 吀(object? P_0, object? P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0079: Expected Obj, but got I
		//IL_0058->IL0026: Incompatible stack heights: 4 vs 1
		//IL_007e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0063->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0089->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			case 2:
				return;
			default:
				_003CModule_003E.CheckAccessibleAttribute();
				_ = 2;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					_ = 1;
				}
				break;
			case 1:
				IEnumerator_object.Do_Abi_MoveNext_2((nint)this, (byte*)(nint)P_0);
				_ = 0;
				if (IList_object.PatchAttribute != null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 唀(object? P_0, object? P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777772, new IntPtr(2737335700796L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? 嘀()
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
	internal unsafe object? 圀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777773, new IntPtr(2737335709116L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 堀(object? P_0, object? P_1, InfoBarSeverity P_2)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected I, but got Unknown
		//IL_007c: Expected I, but got Obj
		//IL_007c: Expected I4, but got Obj
		//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0090->IL0026: Incompatible stack heights: 2 vs 1
		//IL_009b->IL0026: Incompatible stack heights: 2 vs 1
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
			default:
				return;
			case 0:
				return;
			case 2:
			{
				nint initialized = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
				if (initialized == 0)
				{
					obj2 = 1;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 0;
					}
					break;
				}
				/*Error near IL_0074: Stack underflow*/((object[])/*Error near IL_0074: Stack underflow*/, initialized);
				IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_007c: Stack underflow*/, (uint)(int)P_0, (nint)P_1, (uint*)(nint)P_2);
				_ = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					_ = 0;
				}
				break;
			}
			case 1:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<AccountModel?>? 夀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777770, new IntPtr(2737335712236L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<AccountModel?>?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<AccountModel?>? 娀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17396, 1790777771, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777771, new IntPtr(2737335700796L), 15);
		}
		return (IAsyncRelayCommand<AccountModel?>?)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte 嬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777768, new IntPtr(2737335724716L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte 尀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<EnumAccountType>? 崀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17399, 1790777769, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777769, new IntPtr(2737335712236L), 15);
		}
		return (IAsyncRelayCommand<EnumAccountType>?)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<EnumAccountType>? 帀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777782, new IntPtr(2737335714316L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<EnumAccountType>?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? 开()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17401, 1790777783, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777783, new IntPtr(2737335724716L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? 怀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777780, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? 愀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17403, 1790777781, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777781, new IntPtr(2737335709116L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? 戀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777778, new IntPtr(2737335708076L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? 挀()
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
	internal unsafe object? 搀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777779, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? 攀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777776, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? 昀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17408, 1790777777, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777777, new IntPtr(2737335714316L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint 最()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777790, new IntPtr(2737335708076L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint 栀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint 椀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777791, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<AccountModel?>? 樀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (List<AccountModel?>?)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<AccountModel?>? 欀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777788, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
		return (List<AccountModel?>?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 氀(List<AccountModel?>? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_004f: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_00e4: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_00aa: Expected I4, but got Obj
		//IL_00aa: Expected I, but got Obj
		//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00e9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008d->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00af->IL0098: Incompatible stack heights: 1 vs 0
		//IL_006e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00f4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0098->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00c3->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ce->IL0026: Incompatible stack heights: 2 vs 1
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
			default:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 1;
				}
				break;
			case 3:
				MarshalInspectable<object>.FromAbiArray((object)IList_object._initialized);
				_ = 2;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
				{
					_ = 1;
				}
				break;
			case 1:
				return;
			case 4:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)/*Error near IL_009e: Stack underflow*/);
				if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)IReadOnlyList_System_IDisposable.ReflectConnectedAttribute, (uint)(int)P_0) != null)
				{
					return;
				}
				_ = 1;
				if (IEnumerator_System_IDisposable._initialized != 0)
				{
					_ = 3;
				}
				break;
			case 2:
				IEnumerator_System_IDisposable.ReflectTransferableAttribute = P_0;
				obj2 = 0;
				if (IEnumerable_System_IDisposable.CombineAttribute == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 洀(List<AccountModel?>? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777789, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? 渀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17416, 1790777786, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777786, new IntPtr(2737335734076L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? 漀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777787, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}
}
