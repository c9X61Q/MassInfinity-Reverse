using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using ABI.Microsoft.UI.Xaml;
using ABI.System.Collections.Generic;
using ABI.System.Collections.Specialized;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using Mass.WinUI.Mass_WinUI_XamlTypeInfo;
using Mass.WinUI.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.Web.WebView2.Core;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.Pages;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mass_WinUI_Pages_MobileWinRTTypeDetails))]
public sealed class Home : Page, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadWebView2_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Home _003C_003E4__this;

		private TaskAwaiter<CoreWebView2Environment> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<string> _003C_003Eu__3;

		private static object CheckSegmentedConsumer;

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
		internal static bool DecorateCommonStrategy()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateAdaptableSorter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_3300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778634, new IntPtr(2737336163692L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00㐀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0840: Expected Obj, but got I4
			//IL_0840: Expected Obj, but got Ref
			//IL_0061: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I
			//IL_082c: Expected Obj, but got Ref
			//IL_00f8: Expected I4, but got Obj
			//IL_0311: Expected Obj, but got Ref
			//IL_0313: Expected Obj, but got VT
			//IL_0272: Expected Obj, but got Ref
			//IL_01f5: Expected Obj, but got Ref
			//IL_01f7: Expected Obj, but got I
			//IL_01c7: Expected Obj, but got Ref
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0563: Expected Obj, but got I4
			//IL_0568: Expected Obj, but got I4
			//IL_0568: Expected Obj, but got Ref
			//IL_047a: Expected Obj, but got I4
			//IL_024c: Expected I, but got Obj
			//IL_0253: Expected Obj, but got I
			//IL_02d1: Expected Obj, but got Ref
			//IL_0337: Expected I, but got Obj
			//IL_033e: Expected I, but got Obj
			//IL_033e: Expected I, but got Obj
			//IL_0355: Expected Obj, but got I4
			//IL_05bb: Expected I, but got Obj
			//IL_03e5: Expected Obj, but got Ref
			//IL_044d: Expected Obj, but got Ref
			//IL_041f: Expected Obj, but got Ref
			//IL_03bb: Expected Obj, but got I4
			//IL_03c0: Expected Obj, but got I4
			//IL_03c0: Expected Obj, but got Ref
			//IL_0437: Expected Obj, but got Ref
			//IL_029f: Expected I, but got Obj
			//IL_02ab: Expected I4, but got Obj
			//IL_0385: Expected Obj, but got I4
			//IL_04eb: Expected Obj, but got I4
			//IL_04f0: Expected Obj, but got I4
			//IL_04f0: Expected Obj, but got Ref
			//IL_04c2: Expected Obj, but got I4
			//IL_04c7: Expected Obj, but got I4
			//IL_04c7: Expected Obj, but got Ref
			//IL_0517: Expected Obj, but got Ref
			//IL_022b: Expected Obj, but got I4
			//IL_0230: Expected Obj, but got I4
			//IL_0230: Expected Obj, but got Ref
			//IL_0239: Expected Obj, but got I4
			//IL_0397: Expected Obj, but got Ref
			//IL_053f: Expected Obj, but got I
			//IL_0467: Expected Obj, but got Ref
			//IL_0578: Expected Obj, but got Ref
			//IL_0589: Expected Obj, but got I4
			//IL_05ff: Expected Obj, but got I4
			//IL_0604: Expected Obj, but got I4
			//IL_0604: Expected Obj, but got Ref
			//IL_01bc: Expected I4, but got Obj
			//IL_0854->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0838->IL0026: Incompatible stack types: I4 vs Obj
			//IL_085f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_031d->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0288->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0201->IL011b: Incompatible stack types: I4 vs Obj
			//IL_010c->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0293->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0117->IL011b: Incompatible stack types: I4 vs Obj
			//IL_01d7->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0572->IL011b: Incompatible stack types: I4 vs Obj
			//IL_048e->IL011b: Incompatible stack types: I4 vs Obj
			//IL_025d->IL011b: Incompatible stack heights: 2 vs 1
			//IL_0369->IL011b: Incompatible stack heights: 2 vs 1
			//IL_05cf->IL011b: Incompatible stack heights: 3 vs 1
			//IL_03ff->IL011b: Incompatible stack types: I4 vs Obj
			//IL_045f->IL011b: Incompatible stack heights: 2 vs 1
			//IL_0431->IL011b: Incompatible stack types: I4 vs Obj
			//IL_03d4->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0447->IL011b: Incompatible stack types: I4 vs Obj
			//IL_05a9->IL011b: Incompatible stack heights: 3 vs 1
			//IL_02bf->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0217->IL011b: Incompatible stack types: I4 vs Obj
			//IL_038f->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0504->IL011b: Incompatible stack types: I4 vs Obj
			//IL_04db->IL011b: Incompatible stack types: I4 vs Obj
			//IL_052b->IL011b: Incompatible stack types: I4 vs Obj
			//IL_03ab->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0553->IL011b: Incompatible stack heights: 2 vs 1
			//IL_0471->IL011b: Incompatible stack types: I4 vs Obj
			//IL_058e->IL0117: Incompatible stack heights: 1 vs 0
			//IL_05db->IL0226: Incompatible stack heights: 1 vs 0
			//IL_0618->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0499->IL011b: Incompatible stack types: I4 vs Obj
			//IL_02e0->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0374->IL011b: Incompatible stack heights: 2 vs 1
			//IL_0300->IL011b: Incompatible stack types: I4 vs Obj
			//IL_040a->IL011b: Incompatible stack types: I4 vs Obj
			//IL_066a->IL011b: Incompatible stack heights: 5 vs 1
			//IL_0651->IL0651: Incompatible stack heights: 5 vs 3
			//IL_03df->IL011b: Incompatible stack types: I4 vs Obj
			//IL_05b4->IL011b: Incompatible stack heights: 3 vs 1
			//IL_02ca->IL011b: Incompatible stack types: I4 vs Obj
			//IL_050f->IL011b: Incompatible stack types: I4 vs Obj
			//IL_04e6->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0536->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0695->IL011b: Incompatible stack heights: 4 vs 1
			//IL_01ef->IL011b: Incompatible stack types: I4 vs Obj
			//IL_03b6->IL011b: Incompatible stack types: I4 vs Obj
			//IL_055e->IL011b: Incompatible stack heights: 2 vs 1
			//IL_05ef->IL011b: Incompatible stack heights: 2 vs 1
			//IL_0623->IL011b: Incompatible stack types: I4 vs Obj
			//IL_030b->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0675->IL011b: Incompatible stack heights: 5 vs 1
			//IL_06a0->IL011b: Incompatible stack heights: 4 vs 1
			//IL_05fa->IL011b: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 4;
			object obj = awaiter;
			while (true)
			{
				switch ((int)obj)
				{
				case 3:
					awaiter = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					obj = 5;
					continue;
				case 1:
					return;
				case 2:
					_ = ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
					/*Error near IL_0061: Member reference must be method, but was: Field*/;
				case 5:
				{
					_ = 2;
					int num = 1;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						num = 1;
					}
					while (true)
					{
						switch (num)
						{
						case 1:
							num = 2;
							if (IReadOnlyList_System_IDisposable._initialized != 0)
							{
								num = 0;
							}
							continue;
						case 2:
						{
							object obj2;
							switch ((int)awaiter)
							{
							default:
								obj2 = 5;
								if (IReadOnlyList_object._initialized != 0)
								{
									obj2 = 18;
								}
								goto IL_011b;
							case 2:
								awaiter = IEnumerable_System_IDisposable._initialized;
								obj2 = 9;
								goto IL_011b;
							case 1:
								goto IL_026c;
							case 0:
								goto IL_030b;
								IL_011b:
								while (true)
								{
									switch ((int)obj2)
									{
									case 7:
										return;
									case 13:
										return;
									case 38:
										return;
									default:
										IReadOnlyList_object.ReflectLogicalAttribute = (object)default(NavigationViewItemPresenter);
										obj2 = 37;
										continue;
									case 31:
										break;
									case 25:
										goto end_IL_011b;
									case 18:
										MarshalInterface<INotifyPropertyChanged>.CopyManagedArray((INotifyPropertyChanged[])/*Error near IL_020b: Stack underflow*/, (IntPtr)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)/*Error near IL_0206: Stack underflow*/, (uint*)/*Error near IL_0206: Stack underflow*/));
										awaiter = (object)/*Error near IL_020d: Stack underflow*/;
										obj2 = 36;
										continue;
									case 30:
										awaiter = 0;
										IEnumerable_object.ReflectSetAttribute = 0;
										awaiter = 27;
										goto IL_0117;
									case 3:
										_ = GlobalVtableLookup.CreateAttribute;
										awaiter = (nint)MarshalInterface<IEnumerator<INotifyPropertyChanged>>.FromManaged(IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)awaiter));
										_ = 8;
										continue;
									case 28:
										goto IL_026c;
									case 17:
										IListMethods<object>.Abi_SetAt_4((IntPtr)/*Error near IL_02ab: Stack underflow*/, (uint)(int)MarshalInspectable<object>.FromAbi((IntPtr)Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute), Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute);
										obj2 = 23;
										if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute == null)
										{
											obj2 = 13;
										}
										continue;
									case 4:
										IListMethods<object>.Abi_Append_7((IntPtr)/*Error near IL_02d1: Stack underflow*/, (object)(&awaiter));
										if ((int)/*Error near IL_02d6: Stack underflow*/ != 0)
										{
											obj2 = 22;
											continue;
										}
										goto case 24;
									case 8:
										IListMethods<object>.Abi_RemoveAtEnd_8((IntPtr)(nint)(&awaiter));
										if ((int)/*Error near IL_02ec: Stack underflow*/ == 0)
										{
											obj2 = 11;
											if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule == null)
											{
												obj2 = 14;
											}
											continue;
										}
										goto case 16;
									case 29:
										goto IL_030b;
									case 5:
									{
										IListMethods<object> val = (IListMethods<object>)new IListMethods<object>((IntPtr)awaiter);
										bool flag = IEnumeratorMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, nint*, int>)/*Error near IL_033e: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)val, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)val, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, uint*, int>)3);
										bool flag2 = IEnumeratorMethods<INotifyPropertyChanged>.Abi_MoveNext_2((IntPtr)3);
										__KnownINotifyPropertyChangingArgs.CreateAt = (PropertyChangingEventArgs)IEnumeratorMethods<INotifyPropertyChanged>.Abi_get_Current_0((IntPtr)(int)IEnumeratorMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)(flag2 ? 1 : 0), ref *(flag2 ? ((INotifyPropertyChanged[]*)1) : ((INotifyPropertyChanged[]*)null))));
										_ = 3;
										if (__KnownINotifyPropertyChangingArgs.Name != null)
										{
											_ = 3;
										}
										continue;
									}
									case 23:
										awaiter = IReadOnlyListMethods<IDisposable>.Abi_IndexOf_2((IntPtr)/*Error near IL_0383: Stack underflow*/, (IDisposable)/*Error near IL_0383: Stack underflow*/, ref *(uint*)MarshalInterface<IDisposable>.FromAbi(MarshalInterface<IDisposable>.FromManaged((IDisposable)/*Error near IL_0379: Stack underflow*/)));
										obj2 = 4;
										continue;
									case 32:
										__KnownINotifyPropertyChangingArgs.Content = (PropertyChangingEventArgs)awaiter;
										obj2 = 25;
										if (__KnownINotifyPropertyChangingArgs.IsSkeleton == null)
										{
											obj2 = 35;
										}
										continue;
									case 14:
										awaiter = 1;
										__KnownINotifyPropertyChangingArgs.CanProxy = (PropertyChangingEventArgs)1;
										obj2 = 32;
										if (__KnownINotifyPropertyChangingArgs.OnlinePlayers == null)
										{
											obj2 = 26;
										}
										continue;
									case 9:
										__KnownINotifyPropertyChangingArgs.MaxPlayers = null;
										obj2 = 1;
										if (__KnownINotifyPropertyChangingArgs.Version != null)
										{
											obj2 = 1;
										}
										continue;
									case 12:
										Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.ImageUrl).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CLoadWebView2_003Ed__2, AccountViewModel._003CLogoutAccount_003Ed__23>(ref this));
										obj2 = 7;
										continue;
									case 15:
										__KnownINotifyPropertyChangingArgs.BackgroundImageUrl = null;
										obj2 = 26;
										continue;
									case 11:
										_ = ref __KnownINotifyPropertyChangingArgs.Summary;
										((AsyncTaskMethodBuilder*)(&awaiter))->Start(ref Unsafe.As<_003CLoadWebView2_003Ed__2, ImportAccountViewModel._003CSelectFile_003Ed__45>(ref this));
										_ = 38;
										continue;
									case 34:
										__KnownINotifyPropertyChangingArgs.SourceImage = (PropertyChangingEventArgs)awaiter;
										obj2 = 12;
										continue;
									case 2:
									case 22:
										awaiter = IEnumerableMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(&awaiter));
										obj2 = 31;
										if (__KnownINotifyPropertyChangingArgs.LaunchTime != null)
										{
											obj2 = 17;
										}
										continue;
									case 26:
										awaiter = -1;
										__KnownINotifyPropertyChangingArgs.OperationText = (PropertyChangingEventArgs)(-1);
										obj2 = 33;
										if (__KnownINotifyPropertyChangingArgs.Type != null)
										{
											obj2 = 21;
										}
										continue;
									case 24:
										awaiter = 2;
										__KnownINotifyPropertyChangingArgs.CanDelete = (PropertyChangingEventArgs)2;
										obj2 = 34;
										if (__KnownINotifyPropertyChangingArgs.OrderId == null)
										{
											obj2 = 5;
										}
										continue;
									case 27:
										__KnownINotifyPropertyChangingArgs.Price = (PropertyChangingEventArgs)awaiter;
										obj2 = 11;
										if (__KnownINotifyPropertyChangingArgs.OrderAt == null)
										{
											obj2 = 4;
										}
										continue;
									case 21:
									case 33:
										_ = ref awaiter;
										awaiter = (nint)IEnumerableMethods<object>.AbiToProjectionVftablePtr;
										_ = 3;
										if (__KnownINotifyPropertyChangingArgs.PayUrl == null)
										{
											_ = 5;
										}
										continue;
									case 1:
										awaiter = -1;
										__KnownINotifyPropertyChangingArgs.Image = (PropertyChangingEventArgs)(-1);
										obj2 = 2;
										continue;
									case 35:
										_ = ref __KnownINotifyPropertyChangingArgs.DisplayName;
										((AsyncTaskMethodBuilder*)(&awaiter))->Start(ref Unsafe.As<_003CLoadWebView2_003Ed__2, DesktopViewModel._003CLaunchEchoClient_003Ed__7>(ref this));
										awaiter = 13;
										goto IL_0117;
									case 16:
										_ = ref awaiter;
										_ = INotifyCollectionChangedMethods.AbiToProjectionVftablePtr;
										_ = 10;
										if (__KnownINotifyPropertyChangingArgs.Amount != null)
										{
											_ = 1;
										}
										continue;
									case 6:
										IEnumerable_object.Do_Abi_First_0((nint)/*Error near IL_05bb: Stack underflow*/, (nint*)(nint)awaiter);
										IEnumerable_object._002Ecctor();
										IEnumerable_object.SaveAttribute();
										_ = 17;
										continue;
									case 36:
										_ = ref awaiter;
										if (IReadOnlyListMethods<INotifyPropertyChanged>.AbiToProjectionVftablePtr != (IntPtr)0)
										{
											_ = 21;
											if (__KnownINotifyPropertyChangingArgs.CurrentDisplayPage == null)
											{
												_ = 12;
											}
											continue;
										}
										goto case 30;
									case 37:
										awaiter = -1;
										__KnownINotifyPropertyChangingArgs.SelectedIndex = (PropertyChangingEventArgs)(-1);
										obj2 = 5;
										if (__KnownINotifyPropertyChangingArgs.InputEmail != null)
										{
											obj2 = 16;
										}
										continue;
									case 10:
										_ = __KnownINotifyPropertyChangingArgs.InputCookie;
										_ = IEnumeratorMethods<object>.IID;
										if (__KnownINotifyPropertyChangingArgs.Input163Password == null)
										{
											_ = __KnownINotifyPropertyChangingArgs.InputMobilePassword;
											__ldftn(Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.GetExposedInterfaces);
											__KnownINotifyPropertyChangingArgs.VerifyCodeDelayText = (PropertyChangingEventArgs)new IEnumerableMethods<IDisposable>();
										}
										_ = IEnumeratorMethods<IDisposable>.IID;
										_ = 6;
										if (__KnownINotifyPropertyChangingArgs.InfoBarIsOpen == null)
										{
											_ = 6;
										}
										continue;
									case 19:
									case 20:
										goto end_IL_00e7;
										IL_0117:
										obj2 = awaiter;
										continue;
									}
									if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
									{
										obj2 = 19;
										continue;
									}
									_ = IUIElementOverridesMethods.AbiToProjectionVftablePtr;
									_ = 20;
									if (__KnownINotifyPropertyChangingArgs.SelectedFileName != null)
									{
										_ = 7;
									}
									continue;
									end_IL_011b:
									break;
								}
								goto case 2;
								IL_030b:
								awaiter = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout;
								obj2 = 15;
								goto IL_011b;
								IL_026c:
								awaiter = Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute;
								obj2 = 0;
								if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute == null)
								{
									obj2 = 0;
								}
								goto IL_011b;
								end_IL_00e7:
								break;
							}
							break;
						}
						}
						break;
					}
					break;
				}
				case 4:
					awaiter = __KnownINotifyPropertyChangingArgs.SearchText;
					obj = 3;
					continue;
				}
				__KnownINotifyPropertyChangingArgs.LastSearchText = (PropertyChangingEventArgs)(-2);
				obj = 0;
				if (__KnownINotifyPropertyChangingArgs.CoreResources != null)
				{
					obj = 2;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00㔀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778635, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00㘀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00㜀()
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
		internal unsafe static object _FF00_FF00_FF00_FF00㠀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778632, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00㤀(object P_0)
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
	}

	private object? _webView2;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object WebViewGrid;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private nint _contentLoaded;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? loadWebView2Command;

	private static object DecorateSequentialTracer;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand LoadWebView2Command
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_FF00_FF00_E900();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe Home()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_00a9: Expected Obj, but got I
		//IL_00f1: Expected I4, but got Obj
		//IL_00f1: Expected I, but got Obj
		//IL_00f6: Expected Obj, but got I4
		//IL_006e: Expected I, but got Obj
		//IL_0074: Expected I, but got Obj
		//IL_00d5: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I4
		//IL_011a: Expected I, but got Obj
		//IL_011f: Expected I, but got Obj
		//IL_0133: Expected Obj, but got I4
		//IL_0133: Expected I, but got Obj
		//IL_0139: Expected I4, but got Obj
		//IL_0139: Expected I, but got Obj
		//IL_00a9: Expected Obj, but got I
		//IL_00f1: Expected I4, but got Obj
		//IL_00f1: Expected I, but got Obj
		//IL_00f6: Expected Obj, but got I4
		//IL_006e: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0074: Expected I, but got Obj
		//IL_00d5: Expected I, but got Obj
		//IL_00d5: Expected I4, but got Obj
		//IL_0114: Expected Obj, but got I4
		//IL_011a: Expected I, but got Obj
		//IL_011f: Expected I, but got Obj
		//IL_0133: Expected Obj, but got I4
		//IL_0133: Expected I, but got Obj
		//IL_0139: Expected I4, but got Obj
		//IL_0139: Expected I, but got Obj
		//IL_013e: Expected I, but got Obj
		//IL_00be: Expected I4, but got Obj
		//IL_002e->IL0042: Incompatible stack types: I4 vs Obj
		//IL_0039->IL0042: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0042: Incompatible stack heights: 3 vs 2
		//IL_0088->IL0042: Incompatible stack heights: 1 vs 2
		//IL_00df->IL0042: Incompatible stack types: I4 vs Obj
		//IL_0152->IL0042: Incompatible stack types: I4 vs Obj
		//IL_00c4->IL00ce: Incompatible stack heights: 0 vs 1
		//IL_00b9->IL0042: Incompatible stack heights: 3 vs 2
		//IL_0093->IL0042: Incompatible stack heights: 1 vs 2
		//IL_00ce->IL0042: Incompatible stack heights: 1 vs 2
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		int hRForException = ExceptionHelpers.GetHRForException((Exception)(object)this);
		int num = 2;
		object obj = hRForException;
		if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
		{
			num = 3;
			obj = hRForException;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				((ValueTuple<int, nint>*)/*Error near IL_0074: Stack underflow*/)->_002Ector((int)IEnumerator_object.Do_Abi_MoveNext_2((nint)obj, (byte*)(nint)this), unchecked((nint)null));
				_ = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					_ = 0;
				}
				break;
			default:
				MarshalInspectable<object>.FromManaged((object)this, true);
				_ = 1;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
				{
					_ = 1;
				}
				break;
			case 5:
				if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)/*Error near IL_00be: Stack underflow*/, (uint)(int)obj) != null)
				{
					_ = 4;
					break;
				}
				return;
			case 6:
				return;
			case 3:
			{
				uint num3 = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_00d5: Stack underflow*/, (uint)(int)obj, (nint*)(nint)this);
				num = 2;
				obj = num3;
				break;
			}
			case 1:
				obj = ((XamlUserType)IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00e4: Stack underflow*/, (INotifyPropertyChanged)/*Error near IL_00e4: Stack underflow*/, ref *(uint*)obj)).BoxType<double>(new IReadOnlyListMethods<INotifyPropertyChanged>((IntPtr)this, (uint)(int)this, ref *(INotifyPropertyChanged[]*)(delegate* unmanaged[Stdcall]<nint, uint, uint, nint, uint*, uint>)(&IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3)));
				num = 5;
				break;
			case 4:
			{
				object reflectSetAttribute = IEnumerable_object.ReflectSetAttribute;
				IReadOnlyList<object> readOnlyList = IListMethods<object>.Abi_GetView_2((IntPtr)IListMethods<object>.Abi_GetAt_0((IntPtr)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.CheckSymbolicAttribute(), (uint)(nint)MarshalInterface<IEnumerator<INotifyPropertyChanged>>.FromManaged((IEnumerator<INotifyPropertyChanged>)IEnumerable_System_ComponentModel_INotifyPropertyChanged.Initialized)));
				IListMethods<object>.Abi_SetAt_4((IntPtr)Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute, IList_object.Initialized ? 1u : 0u, (object)IList_object.Init());
				IListMethods<object>.Abi_RemoveAt_6((IntPtr)reflectSetAttribute, (uint)(int)readOnlyList);
				IListMethods<object>.Abi_RemoveAtEnd_8((IntPtr)(int)IList_object.Do_Abi_SetAt_4((nint)/*Error near IL_013e: Stack underflow*/, (uint)/*Error near IL_013e: Stack underflow*/, (nint)obj));
				uint num2 = IList_object.Do_Abi_RemoveAt_6((nint)/*Error near IL_0148: Stack underflow*/, (uint)/*Error near IL_0148: Stack underflow*/);
				num = 6;
				obj = num2;
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CLoadWebView2_003Ed__2))]
	private object LoadWebView2()
	{
		return _FF00_FF00_FF00_E700();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPreferredColorScheme(ElementTheme theme)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_FF00_FF00_FF00_EE00(theme);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	public void InitializeComponent()
	{
		_FF00_FF00_FF00_F100();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	public void Connect(int connectionId, object target)
	{
		_FF00_FF00_FF00_ED00((uint)connectionId, target);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateSetResolver()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Home CheckEfficientDecryptor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_E500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778629, new IntPtr(2737336192812L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_E600()
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
	private unsafe object _FF00_FF00_FF00_E700()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18302, 1790778626, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778626, new IntPtr(2737336191772L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_E800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778627, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_E900()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18304, 1790778624, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778624, new IntPtr(2737336192812L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_EA00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778625, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_EB00()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_EC00(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778638, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_ED00(uint P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0099: Expected I, but got Obj
		//IL_00ad->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0082->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0066->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008d->IL0026: Incompatible stack types: I4 vs Obj
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
			case 3:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = 1;
				obj2 = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				if (P_0 == 2)
				{
					obj2 = 1;
					if (IList_object._initialized != 0)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 3;
			case 1:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)CastExtensions.As<MainContent>(P_1);
				obj2 = 3;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_EE00(ElementTheme P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_005f: Expected I4, but got Obj
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Invalid comparison between Unknown and I4
		//IL_013d: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_00bc: Expected Obj, but got I4
		//IL_00f5: Expected I, but got Obj
		//IL_00f5: Expected I4, but got Obj
		//IL_01aa: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I
		//IL_0158->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0109->IL0026: Incompatible stack types: I4 vs Obj
		//IL_012b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0163->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0114->IL0026: Incompatible stack types: I4 vs Obj
		//IL_018e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0136->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ec->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0199->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 11;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 6:
					if ((int)P_0 != 2)
					{
						obj2 = 9;
						if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute == null)
						{
							obj2 = 2;
						}
						continue;
					}
					goto case 12;
				case 2:
					obj = 1;
					obj2 = 4;
					continue;
				case 7:
				case 9:
					obj = 0;
					obj2 = 8;
					continue;
				default:
					if ((int)P_0 != 1)
					{
						obj2 = 1;
						if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
						{
							obj2 = 6;
						}
						continue;
					}
					goto case 2;
				case 4:
				case 5:
				case 8:
					((ValueTuple<int, nint>*)/*Error near IL_00f5: Stack underflow*/)->_002Ector((int)obj, (nint)obj);
					obj2 = 3;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 3;
					}
					continue;
				case 12:
					obj = 2;
					obj2 = 2;
					if (IReadOnlyList_System_IDisposable._initialized == 0)
					{
						obj2 = 5;
					}
					continue;
				case 1:
					obj = IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)/*Error near IL_0142: Stack underflow*/, IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_013d: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_013d: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_013d: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)obj) ? 1u : 0u);
					obj2 = 0;
					if (IEnumerator_System_IDisposable._initialized != 0)
					{
						obj2 = 0;
					}
					continue;
				case 3:
					return;
				case 10:
					if (obj == null)
					{
						return;
					}
					obj2 = 1;
					if (IEnumerable_System_IDisposable._initialized == 0)
					{
						obj2 = 0;
					}
					continue;
				case 11:
					break;
				}
				break;
			}
			obj = IEnumerable_System_IDisposable.CombineAttribute;
			obj = 10;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_F000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778639, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_F100()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_008e: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a2->IL0026: Incompatible stack heights: 4 vs 1
		//IL_007a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ad->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
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
				obj = new IEnumeratorMethods<object>((IntPtr)/*Error near IL_0052: Stack underflow*/, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute());
				obj2 = 4;
				break;
			case 5:
				return;
			case 2:
				IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized = 1;
				obj2 = 0;
				if (IList_object._initialized == 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
				MarshalInspectable<object>.FromAbiArray((object)0);
				_ = 1;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
				{
					_ = 1;
				}
				break;
			case 1:
				return;
			case 3:
				if (IReadOnlyList_System_IDisposable._initialized != 0)
				{
					return;
				}
				obj2 = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_F500(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778636, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_F600(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0063: Expected I4, but got Obj
		//IL_0179: Expected Obj, but got I4
		//IL_013a: Expected Obj, but got I4
		//IL_0143: Expected Obj, but got I4
		//IL_00a5: Expected I, but got Obj
		//IL_00ac: Expected I, but got Obj
		//IL_00b1: Expected Obj, but got I4
		//IL_00b6: Expected I, but got Obj
		//IL_00ff: Expected Obj, but got I
		//IL_01b4: Expected Obj, but got I4
		//IL_0150: Expected I, but got Obj
		//IL_0150: Expected I, but got Obj
		//IL_0183->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0104->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01c8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01d3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00dd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_015f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_01a2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0171->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ad->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 10;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 5:
					return;
				case 12:
					obj = _003CModule_003E.CheckAccessibleAttribute();
					obj2 = 2;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 1;
					}
					continue;
				case 1:
				case 2:
				case 4:
					IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)MarshalInspectable<object>.FromAbiArray((object)IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_00ac: Stack underflow*/, (uint)/*Error near IL_00ac: Stack underflow*/, (nint)(int)IEnumerator_object.Do_Abi_MoveNext_2((nint)/*Error near IL_00a5: Stack underflow*/, (byte*)(nint)obj), (uint*)(nint)obj)));
					obj2 = 5;
					continue;
				case 8:
					if ((nint)obj != 1)
					{
						obj2 = 11;
						if (IReadOnlyList_System_IDisposable._initialized != 0)
						{
							obj2 = 6;
						}
						continue;
					}
					break;
				case 6:
					obj = IReadOnlyList_System_IDisposable.ReflectConnectedAttribute;
					obj2 = 0;
					if (IReadOnlyList_object.ReflectLogicalAttribute == null)
					{
						obj2 = 0;
					}
					continue;
				case 3:
				case 13:
					goto end_IL_0026;
				case 9:
					return;
				case 11:
					if ((nint)obj != 2)
					{
						obj2 = 13;
						continue;
					}
					goto case 12;
				default:
					obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.MoveAttribute();
					_ = 8;
					continue;
				case 10:
					if (GlobalVtableLookup.CreateAttribute != null)
					{
						IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)this, (uint*)(nint)P_1);
						IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
						_ = 6;
						continue;
					}
					obj2 = 9;
					if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute == null)
					{
						obj2 = 7;
					}
					continue;
				case 7:
					break;
				}
				obj = IEnumerable_System_ComponentModel_INotifyPropertyChanged.Do_Abi_First_0((nint)/*Error near IL_01b2: Stack underflow*/, (nint*)/*Error near IL_01b2: Stack underflow*/);
				obj2 = 1;
				if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute == null)
				{
					obj2 = 0;
				}
				continue;
				end_IL_0026:
				break;
			}
			obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_0138: Stack underflow*/, (uint)/*Error near IL_0138: Stack underflow*/, (uint)/*Error near IL_0138: Stack underflow*/, (nint)/*Error near IL_0138: Stack underflow*/, (uint*)/*Error near IL_0138: Stack underflow*/);
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_F700(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778637, new IntPtr(2737336163692L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
