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
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using ABI.Microsoft.UI.Xaml;
using ABI.System.Collections;
using ABI.System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Mass.Domain.Desktop.Entities.Mods;
using Mass.Domain.Desktop.Interfaces;
using Mass.Domain.Desktop.Models;
using Mass.Domain.Desktop.ValueObjects;
using Mass.WinUI.Helpers;
using Mass.WinUI.Mass_WinUI_XamlTypeInfo;
using Mass.WinUI.Models;
using Mass.WinUI.Models.Messages;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
using WinRT.Mass_WinUIVtableClasses;
using WinUI.TableView;

namespace Mass.WinUI.ViewModels;

[WinRTExposedType(typeof(Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
public class GameResourceViewModel : ObservableObject, IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadCoreResources_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public GameResourceViewModel _003C_003E4__this;

		private object _003C_003E8__1;

		private IEnumerable<GameResourceModel> _003Cmodels_003E5__2;

		private TaskAwaiter<EntityGameModsHash> _003C_003Eu__1;

		private TaskAwaiter<EntityItemDownload> _003C_003Eu__2;

		internal static object DecorateControllableTracer;

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
		internal static bool ReflectTransferableResolver()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectResponsiveDecryptor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00舀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778310, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00茀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_07aa: Expected Obj, but got Ref
			//IL_07d1: Expected Obj, but got Ref
			//IL_07f8: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got Ref
			//IL_00d1: Expected I, but got Obj
			//IL_00d7: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I4
			//IL_0284: Expected Obj, but got Ref
			//IL_04c6: Expected Obj, but got Ref
			//IL_019e: Expected Obj, but got Ref
			//IL_01a3: Expected I4, but got Obj
			//IL_01a3: Expected I, but got Obj
			//IL_0547: Expected Obj, but got Ref
			//IL_054d: Expected Obj, but got Ref
			//IL_055d: Expected Obj, but got Ref
			//IL_056d: Expected Obj, but got I
			//IL_03f1: Expected Obj, but got Ref
			//IL_034a: Expected Obj, but got I4
			//IL_034f: Expected Obj, but got I4
			//IL_034f: Expected Obj, but got Ref
			//IL_0333: Expected Obj, but got Ref
			//IL_024c: Expected Obj, but got Ref
			//IL_0360: Expected Obj, but got Ref
			//IL_0297: Expected Obj, but got Ref
			//IL_031e: Expected Obj, but got I4
			//IL_0323: Expected Obj, but got I4
			//IL_0323: Expected Obj, but got Ref
			//IL_02e9: Expected Obj, but got Ref
			//IL_02eb: Expected Obj, but got VT
			//IL_02fa: Expected Obj, but got I4
			//IL_0222: Expected I, but got Obj
			//IL_03c3: Expected Obj, but got Ref
			//IL_03cb: Expected Obj, but got Ref
			//IL_03cb: Expected Obj, but got Ref
			//IL_0407: Expected Obj, but got I4
			//IL_040c: Expected Obj, but got I4
			//IL_040c: Expected Obj, but got Ref
			//IL_0437: Expected I, but got Obj
			//IL_0274: Expected Obj, but got I4
			//IL_0490: Expected Obj, but got Ref
			//IL_04b6: Expected Obj, but got Ref
			//IL_01ee: Expected Obj, but got Ref
			//IL_01fd: Expected Obj, but got I4
			//IL_0384: Expected Obj, but got I4
			//IL_0389: Expected Obj, but got I4
			//IL_0389: Expected Obj, but got Ref
			//IL_046d: Expected I, but got Obj
			//IL_047c: Expected Obj, but got I4
			//IL_0599: Expected Obj, but got I
			//IL_059e: Expected I4, but got Obj
			//IL_05a3: Expected Obj, but got I4
			//IL_0191: Expected I4, but got Obj
			//IL_07c0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_07e7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0807->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_07cb->IL0026: Incompatible stack types: I4 vs Obj
			//IL_07f2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0101->IL0110: Incompatible stack types: I4 vs Obj
			//IL_009c->IL009c: Incompatible stack heights: 3 vs 1
			//IL_0290->IL0110: Incompatible stack types: I4 vs Obj
			//IL_01e8->IL0110: Incompatible stack types: I4 vs Obj
			//IL_010c->IL0110: Incompatible stack types: I4 vs Obj
			//IL_04d6->IL0110: Incompatible stack types: I4 vs Obj
			//IL_01b2->IL0110: Incompatible stack heights: 3 vs 1
			//IL_0402->IL0110: Incompatible stack types: I4 vs Obj
			//IL_0359->IL0110: Incompatible stack types: I4 vs Obj
			//IL_0345->IL0110: Incompatible stack types: I4 vs Obj
			//IL_0260->IL0110: Incompatible stack types: I4 vs Obj
			//IL_0374->IL0110: Incompatible stack types: I4 vs Obj
			//IL_02ad->IL0110: Incompatible stack types: I4 vs Obj
			//IL_032d->IL0110: Incompatible stack types: I4 vs Obj
			//IL_02ff->IL0110: Incompatible stack types: I4 vs Obj
			//IL_0244->IL0110: Incompatible stack types: I4 vs Obj
			//IL_03d5->IL0110: Incompatible stack heights: 3 vs 1
			//IL_0420->IL0110: Incompatible stack types: I4 vs Obj
			//IL_027e->IL0110: Incompatible stack types: I4 vs Obj
			//IL_04a4->IL0110: Incompatible stack types: I4 vs Obj
			//IL_04c0->IL0110: Incompatible stack types: I4 vs Obj
			//IL_03b2->IL0110: Incompatible stack types: I4 vs Obj
			//IL_0393->IL0110: Incompatible stack types: I4 vs Obj
			//IL_0488->IL0110: Incompatible stack types: I4 vs Obj
			//IL_057d->IL0594: Incompatible stack heights: 6 vs 8
			//IL_026b->IL0110: Incompatible stack types: I4 vs Obj
			//IL_037f->IL0110: Incompatible stack types: I4 vs Obj
			//IL_02b8->IL0110: Incompatible stack types: I4 vs Obj
			//IL_030a->IL0110: Incompatible stack types: I4 vs Obj
			//IL_042b->IL0110: Incompatible stack types: I4 vs Obj
			//IL_02d8->IL0110: Incompatible stack types: I4 vs Obj
			//IL_0451->IL0110: Incompatible stack types: I4 vs Obj
			//IL_03eb->IL0110: Incompatible stack types: I4 vs Obj
			//IL_04af->IL0110: Incompatible stack types: I4 vs Obj
			//IL_03bd->IL0110: Incompatible stack types: I4 vs Obj
			//IL_05b7->IL0110: Incompatible stack heights: 5 vs 1
			//IL_02e3->IL0110: Incompatible stack types: I4 vs Obj
			//IL_045c->IL0110: Incompatible stack types: I4 vs Obj
			//IL_05c2->IL0110: Incompatible stack heights: 5 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 1;
			object obj = awaiter;
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				case 5:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = -2;
					obj = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj = 2;
					}
					break;
				case 3:
					return;
				case 4:
					if ((nuint)(nint)awaiter <= (nuint)1u)
					{
						num = 0;
						if (IList_object._initialized == 0)
						{
							num = 0;
						}
						goto IL_009c;
					}
					goto IL_0648;
				default:
					awaiter = __KnownINotifyPropertyChangingArgs.SearchText;
					obj = 4;
					if (__KnownINotifyPropertyChangingArgs.SearchVisibility != null)
					{
						obj = 3;
					}
					break;
				case 1:
					awaiter = __KnownINotifyPropertyChangingArgs.CoreResources;
					obj = 0;
					if (__KnownINotifyPropertyChangingArgs.Resources == null)
					{
						obj = 0;
					}
					break;
				case 2:
					{
						((ReadOnlySpan<char>*)/*Error near IL_07fd: Stack underflow*/)->Slice((int)Unsafe.AsPointer(ref __KnownINotifyPropertyChangingArgs.SelectedItem));
						_ = 3;
						break;
					}
					IL_0648:
					((Mass_WinUI_Pages_MobileWinRTTypeDetails)/*Error near IL_064d: Stack underflow*/)._002Ector();
					if ((int)/*Error near IL_0652: Stack underflow*/ != 0)
					{
						num = 0;
						if (__KnownINotifyPropertyChangingArgs.InputText != null)
						{
							num = 1;
						}
						goto IL_009c;
					}
					goto case 5;
					IL_009c:
					while (true)
					{
						object obj2;
						bool flag;
						Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails;
						switch (num)
						{
						case 4:
						case 8:
							break;
						case 3:
							IEnumerator_object.Do_Abi_get_Current_0((nint)/*Error near IL_00d1: Stack underflow*/, (nint*)(nint)awaiter);
							IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)null);
							awaiter = 8;
							continue;
						case 2:
							if (awaiter == null)
							{
								obj2 = 29;
								if (IReadOnlyList_System_IDisposable._initialized != 0)
								{
									obj2 = 18;
								}
								goto IL_0110;
							}
							goto IL_01d6;
						default:
							num = 2;
							continue;
						case 5:
							goto IL_0648;
						case 6:
							goto IL_06a4;
							IL_0110:
							while (true)
							{
								switch ((int)obj2)
								{
								case 6:
									return;
								case 25:
									return;
								case 2:
									new IReadOnlyListMethods<INotifyPropertyChanged>((IntPtr)awaiter, (uint)(int)IReadOnlyList_System_IDisposable.ReflectConnectedAttribute);
									IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init();
									_ = 9;
									continue;
								case 1:
									break;
								case 27:
									IEnumerable_System_IDisposable._initialized = unchecked((nint)null);
									awaiter = 12;
									obj2 = awaiter;
									continue;
								case 14:
									IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
									awaiter = IListMethods<object>.Abi_GetAt_0((IntPtr)/*Error near IL_0238: Stack underflow*/, IListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0233: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_0233: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)/*Error near IL_0233: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_0233: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_0233: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_0233: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int>)/*Error near IL_0233: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, int>)/*Error near IL_0233: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_0233: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_0233: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(IEnumerableMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)IEnumerable_object.ReflectSetAttribute) ? 1 : 0), (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, int>)MarshalInterface<IEnumerator<INotifyPropertyChanged>>.FromManaged((IEnumerator<INotifyPropertyChanged>)Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute)) ? 1u : 0u);
									obj2 = 20;
									continue;
								case 8:
									Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute = awaiter;
									obj2 = 15;
									if (Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute == null)
									{
										obj2 = 14;
									}
									continue;
								case 19:
									awaiter = IListMethods<object>.Abi_IndexOf_3((IntPtr)/*Error near IL_0272: Stack underflow*/, (object)/*Error near IL_0272: Stack underflow*/, ref *(uint*)(&awaiter));
									obj2 = 4;
									continue;
								case 11:
									goto IL_027e;
								case 10:
									IListMethods<object>.Abi_InsertAt_5((IntPtr)/*Error near IL_0297: Stack underflow*/, (uint)/*Error near IL_0297: Stack underflow*/, (object)(&awaiter));
									awaiter = (object)/*Error near IL_0299: Stack underflow*/;
									obj2 = 24;
									if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute != null)
									{
										obj2 = 13;
									}
									continue;
								case 17:
									IListMethods<object>.Abi_RemoveAtEnd_8((IntPtr)(nint)(&awaiter));
									if ((int)/*Error near IL_02c4: Stack underflow*/ == 0)
									{
										obj2 = 28;
										if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule == null)
										{
											obj2 = 24;
										}
										continue;
									}
									goto case 19;
								case 13:
								case 29:
									awaiter = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout;
									obj2 = 0;
									if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator != null)
									{
										obj2 = 0;
									}
									continue;
								case 12:
									awaiter = -1;
									__KnownINotifyPropertyChangingArgs.Notes = (PropertyChangingEventArgs)(-1);
									obj2 = 19;
									continue;
								case 7:
									Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.UserId).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<(bool, string)>*)(&awaiter), ref Unsafe.As<_003CLoadCoreResources_003Ed__36, AccountViewModel._003CEditAccount_003Ed__22>(ref this));
									obj2 = 25;
									continue;
								case 5:
									awaiter = -1;
									__KnownINotifyPropertyChangingArgs.CreateAt = (PropertyChangingEventArgs)(-1);
									obj2 = 10;
									continue;
								case 9:
									__KnownINotifyPropertyChangingArgs.LoginAt = null;
									obj2 = 14;
									if (__KnownINotifyPropertyChangingArgs.IsMyself != null)
									{
										obj2 = 22;
									}
									continue;
								case 28:
									awaiter = 1;
									__KnownINotifyPropertyChangingArgs.Message = (PropertyChangingEventArgs)1;
									obj2 = 8;
									continue;
								case 26:
									__KnownINotifyPropertyChangingArgs.Content = (PropertyChangingEventArgs)new IEnumerator_System_ComponentModel_INotifyPropertyChanged((nint)/*Error near IL_0399: Stack underflow*/, (uint)/*Error near IL_0399: Stack underflow*/, (nint)/*Error near IL_0399: Stack underflow*/, (uint*)Unsafe.AsPointer(ref this));
									obj2 = 30;
									if (__KnownINotifyPropertyChangingArgs.IsSkeleton == null)
									{
										obj2 = 19;
									}
									continue;
								case 15:
									_ = ref __KnownINotifyPropertyChangingArgs.CanProxy;
									IMessengerExtensions.Send<SessionChangedMessage>((IMessenger)(object)(&awaiter), (SessionChangedMessage)Unsafe.AsPointer(ref this));
									_ = 6;
									continue;
								case 20:
									if (IReadOnlyListMethods<object>.Abi_GetAt_0((IntPtr)/*Error near IL_03dc: Stack underflow*/, (uint)(&awaiter)) == null)
									{
										obj2 = 16;
										continue;
									}
									goto case 10;
								case 4:
									__KnownINotifyPropertyChangingArgs.Author = (PropertyChangingEventArgs)awaiter;
									obj2 = 3;
									continue;
								case 16:
									awaiter = 0;
									__KnownINotifyPropertyChangingArgs.Description = (PropertyChangingEventArgs)0;
									obj2 = 16;
									if (__KnownINotifyPropertyChangingArgs.ImageUrl == null)
									{
										obj2 = 21;
									}
									continue;
								case 18:
									if ((nint)IEnumeratorMethods<IDisposable>.Abi_get_Current_0((IntPtr)__KnownINotifyPropertyChangingArgs.Characters) == 2)
									{
										obj2 = 17;
										if (__KnownINotifyPropertyChangingArgs.Summary == null)
										{
											obj2 = 26;
										}
										continue;
									}
									goto case 2;
								case 30:
									((Func<Type, string>)/*Error near IL_047c: Stack underflow*/)._002Ector((object)IReadOnlyList_object.Init(), (nint)MarshalInterface<IEnumerator<object>>.FromManaged(IEnumerableMethods<object>.Abi_First_0((IntPtr)(IEnumerableMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)__KnownINotifyPropertyChangingArgs.SourceImage) ? 1 : 0))));
									awaiter = (object)/*Error near IL_047e: Stack underflow*/;
									obj2 = 17;
									continue;
								case 21:
									__KnownINotifyPropertyChangingArgs.StateText = (PropertyChangingEventArgs)awaiter;
									obj2 = 7;
									if (__KnownINotifyPropertyChangingArgs.CloseText == null)
									{
										obj2 = 1;
									}
									continue;
								case 23:
									__KnownINotifyPropertyChangingArgs.Type = null;
									obj2 = 2;
									continue;
								default:
									Unsafe.As<PropertyChangingEventArgs, TableViewCellSlot?>(ref __KnownINotifyPropertyChangingArgs.CanDelete) = null;
									obj2 = 5;
									continue;
								case 24:
									/*Error near IL_04d9: Member reference must be method, but was: Field*/;
								case 3:
								{
									_ = __KnownINotifyPropertyChangingArgs.Quantity;
									_ = __KnownINotifyPropertyChangingArgs.MobileAccounts;
									_ = IEnumerableMethods<INotifyPropertyChanged>.IID;
									PropertyChangingEventArgs currentDisplayPage = __KnownINotifyPropertyChangingArgs.CurrentDisplayPage;
									ObservableHelper.UpdateObservableCollection((IList<DesktopGameModel>)(delegate*<object, object>)(&GlobalVtableLookup.LookupRuntimeClassName), (List<DesktopGameModel>)(nint)new IEnumeratorMethods<INotifyPropertyChanged>());
									PropertyChangingEventArgs input4399Password;
									PropertyChangingEventArgs predicate;
									if (__KnownINotifyPropertyChangingArgs.InputCookie == null)
									{
										input4399Password = __KnownINotifyPropertyChangingArgs.Input4399Password;
										predicate = (__KnownINotifyPropertyChangingArgs.InputMobile = (PropertyChangingEventArgs)new IReadOnlyListMethods<IDisposable>());
									}
									__KnownINotifyPropertyChangingArgs.InfoBarMessage = (PropertyChangingEventArgs)((IEnumerable<EnumGameVersion>)input4399Password).Contains((EnumGameVersion)(int)((IEnumerable<DesktopGameModel>)(delegate*<bool>)(&Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.DecorateGeneralAttribute)).FirstOrDefault((Func<DesktopGameModel, bool>)(object)predicate));
									_ = 23;
									if (__KnownINotifyPropertyChangingArgs.InfoBarIsOpen == null)
									{
										_ = 13;
									}
									continue;
								}
								case 22:
									goto IL_06a4;
								}
								break;
							}
							goto IL_01d6;
							IL_06a4:
							flag = Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateInternalAttribute();
							mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails = Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.CheckExpandableAttribute();
							((Mass_WinUI_AppWinRTTypeDetails)awaiter).GetExposedInterfaces()._002Ector();
							((AsyncTaskMethodBuilder*)/*Error near IL_06bf: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(flag ? ((TaskAwaiter<PageModel<IDesktopSkin>>*)1) : ((TaskAwaiter<PageModel<IDesktopSkin>>*)null)), ref *(DesktopViewModel._003CRefreshSkin_003Ed__111*)mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails);
							num = 3;
							continue;
							IL_01d6:
							if ((nint)awaiter != 1)
							{
								obj2 = 14;
								goto IL_0110;
							}
							goto IL_027e;
							IL_027e:
							awaiter = Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute;
							obj2 = 27;
							goto IL_0110;
						}
						break;
					}
					goto case 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00萀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778311, new IntPtr(2737335803292L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00蔀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00蘀()
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00蜀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778308, new IntPtr(2737335814732L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00蠀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00褀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778309, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	private object _tag;

	private readonly object _watcher;

	private object _basePath;

	private object _currentPath;

	private object _modsPath;

	private object _resourcePacksPath;

	private object _shaderPacksPath;

	private object _allowPaths;

	private object _game;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? refreshCollectionCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? loadCoreResourcesCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? loadCollectionCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? openFolderCommand;

	internal static GameResourceViewModel DecorateCommonContainer;

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public ObservableCollection<GameResourceModel> CoreResources
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00쐀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00쬀(value);
		}
	}

	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public ObservableCollection<GameResourceModel> AllResources
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_ED00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00툀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public ObservableCollection<GameResourceModel> Resources
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00턀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00쌀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public bool IsDragging
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_E900() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00뼀(value ? ((byte)1) : ((byte)0));
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string SearchText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_E600();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00케(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public object? SelectedItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00뜀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00섀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand RefreshCollectionCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IRelayCommand)_FF00윀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand LoadCoreResourcesCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)this._FF00_FFFD();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand LoadCollectionCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IRelayCommand)_FF00_E700();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IRelayCommand OpenFolderCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IRelayCommand)_FF00묀();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe GameResourceViewModel()
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
	public void Initialize(IDesktopGame game)
	{
		_FF00_FFFD(game);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FileChanged(object sender, object args)
	{
		_FF00눀(sender, args);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		_FF00꼀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	private void RefreshCollection()
	{
		_FF00대();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CLoadCoreResources_003Ed__36))]
	private object LoadCoreResources()
	{
		return _FF00_FFFD();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	private void LoadCollection()
	{
		_FF00봀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	private void OpenFolder()
	{
		_FF00뤀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DragStatusChanged(byte isDragging)
	{
		_FF00저(isDragging);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FilesDropped(object files)
	{
		_FF00_E100(files);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ValidResource(object file)
	{
		_FF00_EB00(file);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnSelectedItemChanged(object? value)
	{
		_FF00촀(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateAdaptableConverter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GameResourceViewModel CheckPortableVerifier()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00글()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778268, new IntPtr(2737335824092L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00꼀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_006a: Expected Obj, but got I
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Ref, but got Unknown
		//IL_0091: Expected I4, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected I, but got Unknown
		//IL_012e: Expected Obj, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0163->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d1->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a5->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00f2->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0147->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0117->IL0026: Incompatible stack heights: 4 vs 1
		//IL_007a->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00b0->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0152->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0122->IL0026: Incompatible stack heights: 4 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)/*Error near IL_005b: Stack underflow*/, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					_ = 1;
				}
				break;
			case 3:
				_ = IList_object._initialized;
				MarshalInspectable<object>.FromManaged((object)this, (byte)(int)new IEnumeratorMethods<object>((IntPtr)(nint)(delegate* unmanaged[Stdcall]<nint, nint*, uint>)(&IEnumerator_object.Do_Abi_get_Current_0)) != 0);
				_ = 0;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
				{
					_ = 0;
				}
				break;
			case 2:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)IReadOnlyList_object._initialized, (INotifyPropertyChanged)this, ref *(uint*)new MarshalInterface<INotifyPropertyChanged>((IntPtr)(nint)(delegate*<byte>)(&IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init)));
				_ = 4;
				break;
			case 4:
				_ = IEnumerable_System_IDisposable._initialized;
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)new MarshalInterface<INotifyPropertyChanged>((INotifyPropertyChanged[])(object)this, (IntPtr)(nint)(delegate* unmanaged[Stdcall]<nint, uint*, uint>)(&IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1)));
				_ = 3;
				break;
			case 6:
				new IEnumerableMethods<INotifyPropertyChanged>((IntPtr)(nint)(delegate*<IReadOnlyList_System_ComponentModel_INotifyPropertyChanged>)(&IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.CheckSymbolicAttribute));
				IEnumerable_System_ComponentModel_INotifyPropertyChanged.Init();
				_ = 5;
				if (Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute == null)
				{
					_ = 5;
				}
				break;
			case 5:
				new MarshalInterface<IReadOnlyList<object>>((IReadOnlyList<object>)(delegate*<bool>)(&IEnumerable_System_ComponentModel_INotifyPropertyChanged.DecorateSeparatedAttribute));
				_ = IList_object.Initialized;
				_ = 2;
				if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute == null)
				{
					_ = 1;
				}
				break;
			case 7:
				return;
			case 1:
				IListMethods<object>.Abi_InsertAt_5((IntPtr)/*Error near IL_0159: Stack underflow*/, (uint)/*Error near IL_0159: Stack underflow*/, (object)this);
				obj2 = 7;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00뀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778269, new IntPtr(2737335806412L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00넀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778266, new IntPtr(2737335798092L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00눀(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0045: Expected I, but got Obj
		//IL_005e->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0069->IL0026: Incompatible stack heights: 3 vs 1
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
				new IEnumeratorMethods<object>((IntPtr)this, ref *(object[]*)(delegate*<_003CModule_003E>)(&_003CModule_003E.CheckAccessibleAttribute));
				IEnumerator_object.Init();
				_ = 0;
				if (IList_object._initialized == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00대()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_02e2: Expected I, but got Obj
		//IL_02e7: Expected Obj, but got I4
		//IL_02b9: Expected I, but got Obj
		//IL_02bb: Expected Obj, but got I4
		//IL_0053: Expected I, but got Obj
		//IL_0055: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I
		//IL_02a4: Expected I, but got Obj
		//IL_016a: Expected I, but got Obj
		//IL_0197: Expected Obj, but got I
		//IL_01e7: Expected Obj, but got I4
		//IL_01e7: Expected I, but got Obj
		//IL_00c1: Expected I, but got Obj
		//IL_00cc: Expected I, but got Obj
		//IL_00fe: Expected I4, but got Obj
		//IL_00fe: Expected I, but got Obj
		//IL_0138: Expected I, but got Obj
		//IL_02f1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02cf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0069->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02b3->IL0026: Incompatible stack heights: 2 vs 1
		//IL_02da->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0074->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f1->IL0088: Incompatible stack heights: 2 vs 1
		//IL_00d1->IL0163: Incompatible stack heights: 1 vs 0
		//IL_0103->IL01da: Incompatible stack heights: 1 vs 0
		//IL_0144->IL01da: Incompatible stack heights: 1 vs 0
		//IL_00e5->IL0088: Incompatible stack heights: 2 vs 1
		//IL_0117->IL0088: Incompatible stack heights: 2 vs 1
		//IL_0158->IL0088: Incompatible stack heights: 2 vs 1
		//IL_00f0->IL0088: Incompatible stack heights: 2 vs 1
		//IL_0122->IL0088: Incompatible stack heights: 2 vs 1
		//IL_0163->IL0088: Incompatible stack heights: 2 vs 1
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
			case 4:
				obj = IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute());
				obj2 = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					obj2 = 3;
				}
				break;
			case 3:
				while (true)
				{
					int num;
					if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)obj) == 0)
					{
						num = 8;
						if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute == null)
						{
							num = 9;
						}
						goto IL_0088;
					}
					goto IL_018e;
					IL_018e:
					obj = (nint)MarshalInterface<IEnumerator<INotifyPropertyChanged>>.FromManaged((IEnumerator<INotifyPropertyChanged>)obj);
					num = 2;
					if (Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute == null)
					{
						num = 2;
					}
					goto IL_0088;
					IL_0088:
					while (true)
					{
						switch (num)
						{
						case 2:
							IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_00c1: Stack underflow*/, (uint)/*Error near IL_00c1: Stack underflow*/, (nint)/*Error near IL_00c1: Stack underflow*/, (uint*)(nint)obj);
							if (IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute) == null)
							{
								_ = 4;
								if (IReadOnlyList_System_IDisposable._initialized != 0)
								{
									_ = 7;
								}
								continue;
							}
							break;
						case 4:
							if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)IEnumerator_object.LoadAttribute(), (uint)(int)obj) == null)
							{
								_ = 5;
								if (IEnumerator_System_IDisposable._initialized == 0)
								{
									_ = 8;
								}
								continue;
							}
							goto default;
						case 6:
							IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_IndexOf_2((nint)/*Error near IL_0138: Stack underflow*/, (nint)/*Error near IL_0138: Stack underflow*/, (uint*)/*Error near IL_0138: Stack underflow*/, (byte*)(nint)obj);
							if (MarshalInterface<INotifyPropertyChanged>.FromAbiArray(obj) == null)
							{
								_ = 0;
								if (IEnumerable_object._initialized == 0)
								{
									_ = 4;
								}
								continue;
							}
							goto default;
						case 5:
						case 8:
							break;
						case 3:
							goto IL_018e;
						default:
							IListMethods<object>.Abi_IndexOf_3((IntPtr)this, (object)IList_object.Initialized, ref *(uint*)obj);
							_ = 5;
							continue;
						case 7:
							if (obj == null)
							{
								num = 0;
								if (Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute == null)
								{
									num = 0;
								}
								continue;
							}
							goto case 6;
						case 9:
							return;
						}
						break;
					}
				}
			case 5:
				IEnumeratorMethods<INotifyPropertyChanged>.Abi_MoveNext_2((IntPtr)(int)IList_object.Do_Abi_GetMany_10((nint)/*Error near IL_02a4: Stack underflow*/, (uint)/*Error near IL_02a4: Stack underflow*/, (uint)/*Error near IL_02a4: Stack underflow*/, (nint)/*Error near IL_02a4: Stack underflow*/, (uint*)(nint)this));
				_ = 4;
				break;
			case 2:
				obj = IList_object.Do_Abi_get_Size_1((nint)/*Error near IL_02b9: Stack underflow*/, (uint*)(nint)this);
				obj2 = 1;
				if (__KnownINotifyPropertyChangingArgs.CreateAt != null)
				{
					obj2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				obj = !IReadOnlyListMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_02e2: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_02e2: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_02e2: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)obj);
				obj2 = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00됀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778267, new IntPtr(2737335823052L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00딀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778264, new IntPtr(2737335798092L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00똀()
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
	internal unsafe object _FF00뜀()
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
	internal unsafe object _FF00렀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778265, new IntPtr(2737335823052L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00뤀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
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
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)/*Error near IL_0043: Stack underflow*/, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
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
	internal unsafe object _FF00먀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778342, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00묀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17748, 1790778343, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778343, new IntPtr(2737335823052L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00봀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_007c: Expected I, but got Obj
		//IL_008c: Expected I, but got Obj
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00b8: Expected I, but got Obj
		//IL_00b8: Expected I, but got Obj
		//IL_004d: Expected I, but got Obj
		//IL_005c: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I
		//IL_012f: Expected Obj, but got I4
		//IL_013e: Expected I, but got Obj
		//IL_014d: Expected Obj, but got I4
		//IL_0124: Expected I, but got Obj
		//IL_00a6->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0061->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00b1->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00dc->IL00dc: Incompatible stack heights: 4 vs 3
		//IL_006c->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0103->IL0103: Incompatible stack heights: 4 vs 3
		//IL_0152->IL0026: Incompatible stack heights: 2 vs 1
		//IL_015d->IL0026: Incompatible stack heights: 2 vs 1
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
			case 0:
				return;
			case 3:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)_003CModule_003E.CheckAccessibleAttribute(), ref *(object[]*)null);
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 0;
				}
				break;
			case 1:
				((XamlUserType)/*Error near IL_0092: Stack underflow*/).BoxType<TimeSpan>((object)(/*Error near IL_008d: Stack underflow*/ - IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_008c: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)MarshalInspectable<object>.FromManaged((object)/*Error near IL_0081: Stack underflow*/, (byte)IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)(int)IEnumerator_object.Do_Abi_get_Current_0((nint)/*Error near IL_0076: Stack underflow*/, (nint*)(int)IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_0071: Stack underflow*/, (uint)/*Error near IL_0071: Stack underflow*/, (nint)/*Error near IL_0071: Stack underflow*/, (uint*)/*Error near IL_0071: Stack underflow*/)), (byte*)(nint)this) != 0), (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(IEnumerator_object.DecorateAutomatableAttribute() ? 1 : 0))));
				_ = 3;
				if (IEnumerator_System_IDisposable._initialized != 0)
				{
					_ = 0;
				}
				break;
			case 2:
			{
				uint num = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_IndexOf_2((nint)/*Error near IL_00b8: Stack underflow*/, (nint)/*Error near IL_00b8: Stack underflow*/, (uint*)(nint)this, (byte*)(nint)this);
				nint initialized = IEnumerable_System_IDisposable._initialized;
				object combineAttribute = IEnumerable_System_IDisposable.CombineAttribute;
				if (combineAttribute == null)
				{
					_ = null;
					GlobalVtableLookup.CreateAttribute = new IReadOnlyListMethods<INotifyPropertyChanged>((IntPtr)(nint)(delegate*<INotifyPropertyChanged[], IntPtr, void>)(&MarshalInterface<INotifyPropertyChanged>.CopyManagedArray));
				}
				IEnumerable<NeteaseAccount> enumerable = ((IEnumerable<NeteaseAccount>)initialized).Where((Func<NeteaseAccount, bool>)combineAttribute);
				object reflectVisibleAttribute = Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute;
				if (reflectVisibleAttribute == null)
				{
					_ = Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute;
					Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute = new IListMethods<object>((IntPtr)(nint)(delegate*<void>)(&IEnumerable_System_ComponentModel_INotifyPropertyChanged._002Ecctor));
				}
				((AsyncTaskMethodBuilder*)enumerable)->Start(ref *(AccountViewModel._003CLoginByHistory_003Ed__25*)reflectVisibleAttribute);
				object options = Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute ?? (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute = new IListMethods<object>((IntPtr)Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute, (uint)(delegate* unmanaged[Stdcall]<nint, nint*, uint>)(&IList_object.Do_Abi_GetView_2)));
				((AsyncTaskMethodBuilder*)/*Error near IL_0134: Stack underflow*/)->Start(ref *(AccountViewModel._003CRegisterRandom4399_003Ed__84*)JsonSerializer.Deserialize<object>((string)num, (JsonSerializerOptions?)options));
				IList_object.Do_Abi_RemoveAtEnd_8((nint)new IListMethods<object>((IntPtr)/*Error near IL_0139: Stack underflow*/, (uint)/*Error near IL_0139: Stack underflow*/, ref *(object[]*)/*Error near IL_0139: Stack underflow*/));
				_ = 1;
				if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator == null)
				{
					_ = 0;
				}
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00븀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778340, new IntPtr(2737335803292L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00뼀(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00ab: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I
		//IL_0085: Expected I, but got Obj
		//IL_00bf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0099->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00df->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ca->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a4->IL0026: Incompatible stack heights: 3 vs 1
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
			case 3:
				return;
			case 2:
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_004a: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0051: Member reference must be method, but was: Field*/;
			case 1:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
				_ = 0;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					_ = 0;
				}
				break;
			default:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
				obj2 = 2;
				if (IReadOnlyList_object.ReflectLogicalAttribute == null)
				{
					obj2 = 4;
				}
				break;
			case 4:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00d5: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00쀀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778341, new IntPtr(2737335806412L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00섀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_004f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I
		//IL_00d0: Expected I, but got Obj
		//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b4->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00d5->IL0059: Incompatible stack heights: 2 vs 0
		//IL_006b->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0095->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00bf->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00df->IL0026: Incompatible stack heights: 3 vs 1
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
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 5;
				break;
			case 1:
				return;
			case 5:
				_ = IEnumerator_object.Initialized;
				_ = 2;
				break;
			case 2:
				/*Error near IL_0076: Stack underflow*/((object[])(object)this, IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized);
				obj2 = 0;
				if (IList_object.PatchAttribute == null)
				{
					obj2 = 1;
				}
				break;
			case 3:
				MarshalInspectable<object>.FromManaged((object)this, (byte)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0);
				_ = 0;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
				{
					_ = 0;
				}
				break;
			case 4:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)/*Error near IL_00c4: Stack underflow*/, (uint)/*Error near IL_00c4: Stack underflow*/);
				_ = IReadOnlyList_object.ReflectLogicalAttribute;
				if (MarshalInterface<INotifyPropertyChanged>.FromAbi((IntPtr)P_0) != null)
				{
					return;
				}
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00숀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778338, new IntPtr(2737335799132L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00쌀(ObservableCollection<GameResourceModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_00dd: Expected Obj, but got I4
		//IL_0084: Expected I, but got Obj
		//IL_00be->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e2->IL0022: Incompatible stack heights: 1 vs 0
		//IL_0098->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00c9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a3->IL0026: Incompatible stack heights: 3 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 3:
					ExceptionHelpers.GetHRForException((Exception)/*Error near IL_0049: Stack underflow*/);
					_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
					/*Error near IL_0050: Member reference must be method, but was: Field*/;
				case 2:
					IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
					_ = 0;
					if (IReadOnlyList_System_IDisposable._initialized == 0)
					{
						_ = 0;
					}
					continue;
				default:
					IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
					obj2 = 1;
					if (IReadOnlyList_object.ReflectLogicalAttribute != null)
					{
						obj2 = 1;
					}
					continue;
				case 1:
					break;
				case 4:
					return;
				}
				break;
			}
			IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00d4: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<GameResourceModel> _FF00쐀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<GameResourceModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<GameResourceModel> _FF00씀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778339, new IntPtr(2737335812652L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<GameResourceModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00였()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778336, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00윀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17760, 1790778337, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778337, new IntPtr(2737335824092L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00저(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0056: Expected I4, but got Obj
		//IL_005b: Expected I, but got VT
		//IL_006a: Expected Obj, but got I
		//IL_006f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_007a->IL0026: Incompatible stack heights: 2 vs 1
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
				IEnumerator_object.Do_Abi_get_Current_0(__return_value__: (nint*)(nint)((int)new _003CModule_003E
				{
					JoinAttribute = this,
					_initialized = (int)P_0
				}, (nint)(delegate* unmanaged[Stdcall]<nint, byte*, uint>)(&IEnumerator_object.Do_Abi_MoveNext_2)), thisPtr: (nint)/*Error near IL_005b: Stack underflow*/);
				_ = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
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
	internal unsafe static byte _FF00준()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00쨀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778350, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00쬀(ObservableCollection<GameResourceModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0053: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_00b8: Expected I, but got Obj
		//IL_009d: Expected I, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I
		//IL_0067->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e7->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0072->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f2->IL0026: Incompatible stack heights: 3 vs 1
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
				_ = 4;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					_ = 4;
				}
				break;
			case 2:
				return;
			case 4:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 5;
				break;
			case 3:
				if (IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00b8: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)MarshalInspectable<object>.FromManaged((object)/*Error near IL_00ac: Stack underflow*/, (byte)/*Error near IL_00ac: Stack underflow*/ != 0), (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)IReadOnlyList_System_IDisposable._initialized, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)P_0))
				{
					obj2 = 2;
					break;
				}
				goto default;
			case 1:
				return;
			case 5:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 1;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00찀(ObservableCollection<GameResourceModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778351, new IntPtr(2737335820972L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00촀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_00d1: Expected I, but got Obj
		//IL_00d1: Expected I, but got Obj
		//IL_00fb: Expected I, but got Obj
		//IL_00e0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0105->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f6->IL00f6: Incompatible stack heights: 1 vs 2
		//IL_00bf->IL0026: Incompatible stack types: I4 vs Obj
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
				obj = P_0 as RegexRunner;
				obj2 = 3;
				break;
			case 6:
				_ = IEnumerator_object.Initialized;
				_ = null;
				/*Error near IL_0065: Member reference must be method, but was: Field*/;
			case 1:
				return;
			case 3:
				if (obj == null)
				{
					return;
				}
				obj2 = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				IReadOnlyList_object._initialized = (IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00d1: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)IReadOnlyList_System_IDisposable._initialized) ? 1 : 0);
				obj2 = 6;
				break;
			case 5:
				return;
			default:
			{
				INotifyPropertyChanged notifyPropertyChanged = MarshalInterface<INotifyPropertyChanged>.FromAbi(MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)obj));
				if (notifyPropertyChanged == null)
				{
				}
				IEnumerable_System_IDisposable._initialized = (nint)notifyPropertyChanged;
				obj2 = 2;
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00츀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778348, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00케(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00f7: Expected Obj, but got I
		//IL_00c2: Expected I4, but got Obj
		//IL_00c2: Expected I, but got Obj
		//IL_0089: Expected I, but got Obj
		//IL_00fc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d6->IL0026: Incompatible stack heights: 2 vs 1
		//IL_009d->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0107->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e1->IL0026: Incompatible stack heights: 2 vs 1
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
			case 5:
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_004d: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0054: Member reference must be method, but was: Field*/;
			case 2:
				return;
			case 4:
				return;
			case 3:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
				_ = 0;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 1:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)this, (uint)(int)IReadOnlyList_System_IDisposable.ReflectConnectedAttribute);
				_ = 2;
				if (IEnumerator_System_IDisposable._initialized != 0)
				{
					_ = 0;
				}
				break;
			default:
				IEnumerator_System_IDisposable.ReflectTransferableAttribute = P_0;
				obj2 = 1;
				if (IEnumerable_System_IDisposable.CombineAttribute == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00퀀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778349, new IntPtr(2737335798092L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<GameResourceModel> _FF00턀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<GameResourceModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00툀(ObservableCollection<GameResourceModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_009f: Expected I, but got Obj
		//IL_0079: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_004f: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I4
		//IL_00a9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008d->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c0->IL00a9: Incompatible stack heights: 2 vs 0
		//IL_0098->IL0026: Incompatible stack heights: 3 vs 1
		//IL_006e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ce->IL0022: Incompatible stack heights: 2 vs 0
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
				default:
					return;
				case 3:
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
					_ = 1;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						_ = 1;
					}
					continue;
				case 2:
					MarshalInspectable<object>.FromAbiArray((object)IList_object._initialized);
					_ = 0;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
					{
						_ = 0;
					}
					continue;
				case 1:
					IReadOnlyList_System_IDisposable._initialized = (nint)P_0;
					obj2 = 2;
					continue;
				case 0:
					return;
				case 4:
					IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_00af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_00af: Stack underflow*/);
					_ = IReadOnlyList_object._initialized;
					if (MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)P_0) != (IntPtr)0)
					{
						return;
					}
					obj = 3;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00팀(ObservableCollection<GameResourceModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778346, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FFFD(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_007f: Expected I4, but got Obj
		//IL_030c: Expected I, but got Obj
		//IL_030c: Expected Obj, but got I4
		//IL_021f: Expected Obj, but got I4
		//IL_025b: Expected I, but got Obj
		//IL_025b: Expected I, but got Obj
		//IL_0260: Expected Obj, but got I4
		//IL_0269: Expected Obj, but got I4
		//IL_01ef: Expected I, but got Obj
		//IL_01f4: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I
		//IL_01bd: Expected I4, but got Obj
		//IL_01bd: Expected I, but got Obj
		//IL_0324: Expected Obj, but got I4
		//IL_0325: Expected Obj, but got I4
		//IL_032d: Expected Obj, but got I4
		//IL_0335: Expected Obj, but got I4
		//IL_033d: Expected Obj, but got I4
		//IL_027a: Expected I, but got Obj
		//IL_027a: Expected I4, but got Obj
		//IL_0284: Expected Obj, but got I4
		//IL_023b: Expected I4, but got Obj
		//IL_023b: Expected I, but got Obj
		//IL_0240: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_00bf: Expected I, but got Obj
		//IL_036d: Expected Obj, but got I
		//IL_0377: Expected Obj, but got VT
		//IL_0316->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0229->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0208->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0170->IL0026: Incompatible stack heights: 3 vs 1
		//IL_02c9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a4->IL0026: Incompatible stack heights: 2 vs 1
		//IL_014f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ee->IL0026: Incompatible stack heights: 2 vs 1
		//IL_01dd->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0186->IL0026: Incompatible stack heights: 3 vs 1
		//IL_01c7->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0125->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02f5->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0114->IL0026: Incompatible stack heights: 3 vs 1
		//IL_028e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_024a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ce->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0213->IL0026: Incompatible stack heights: 3 vs 1
		//IL_02d4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00af->IL0026: Incompatible stack heights: 2 vs 1
		//IL_015a->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00f9->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0300->IL0026: Incompatible stack heights: 3 vs 1
		//IL_038b->IL0026: Incompatible stack heights: 5 vs 1
		//IL_0396->IL0026: Incompatible stack heights: 5 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 13;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 6:
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized, ref *(object[]*)1);
					_ = 9;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						_ = 6;
					}
					continue;
				case 20:
					MarshalInspectable<object>.FromManaged((object)/*Error near IL_00c4: Stack underflow*/, (byte)IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_00bf: Stack underflow*/, (byte*)(nint)MarshalInspectable<object>.FromAbiArray((object)IList_object._initialized)) != 0);
					_ = 17;
					continue;
				case 8:
					IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00da: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00da: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)IReadOnlyList_System_IDisposable._initialized, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)1);
					_ = 14;
					if (IReadOnlyList_object.ReflectLogicalAttribute == null)
					{
						_ = 20;
					}
					continue;
				case 15:
					_ = IEnumerator_System_IDisposable._initialized;
					MarshalInterface<INotifyPropertyChanged>.FromAbiArray(IEnumerator_System_IDisposable.ReflectTransferableAttribute);
					_ = 8;
					continue;
				case 13:
					IEnumerable_System_IDisposable.CombineAttribute = P_0;
					obj2 = 12;
					continue;
				case 7:
					Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute = IEnumerableMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.MoveAttribute() ? 1 : 0));
					_ = 1;
					if (Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute != null)
					{
						_ = 2;
					}
					continue;
				case 4:
					_ = Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute;
					IListMethods<object>.Abi_GetView_2((IntPtr)1);
					_ = 10;
					continue;
				case 10:
					_ = Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute;
					MarshalInspectable<object>.FromAbi((IntPtr)1);
					_ = 6;
					continue;
				case 17:
					IListMethods<object>.Abi_SetAt_4((IntPtr)/*Error near IL_0191: Stack underflow*/, (uint)/*Error near IL_0191: Stack underflow*/, Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute);
					IListMethods<object>.Abi_RemoveAt_6((IntPtr)/*Error near IL_019b: Stack underflow*/, IList_object.Do_Abi_GetView_2((nint)/*Error near IL_0196: Stack underflow*/, (nint*)/*Error near IL_0196: Stack underflow*/));
					obj2 = 14;
					continue;
				case 19:
					return;
				case 11:
					IListMethods<object>.Abi_GetMany_10((IntPtr)Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute, (uint)(int)this, ref *(object[]*)new IListMethods<object>((IntPtr)(nint)(delegate* unmanaged[Stdcall]<nint, uint, nint, uint>)(&IList_object.Do_Abi_InsertAt_5)));
					_ = 18;
					continue;
				case 9:
					_ = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout;
					IListMethods<object>.Abi_get_Size_1((IntPtr)1);
					_ = 5;
					continue;
				case 3:
					_ = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator;
					IEnumeratorMethods<INotifyPropertyChanged>.Abi_get_Current_0((IntPtr)(nint)new IEnumeratorMethods<INotifyPropertyChanged>((IntPtr)this, ref *(INotifyPropertyChanged[]*)(delegate* unmanaged[Stdcall]<nint, uint, nint, uint>)(&IList_object.Do_Abi_ReplaceAll_11)));
					_ = 0;
					if (__KnownINotifyPropertyChangingArgs.LoginAt != null)
					{
						_ = 0;
					}
					continue;
				case 1:
					_ = __KnownINotifyPropertyChangingArgs.Name;
					MarshalInterface<IDisposable>.FromManaged((IDisposable)1);
					_ = 11;
					continue;
				case 18:
					MarshalInterface<IDisposable>.CopyManagedArray((IDisposable[])/*Error near IL_0240: Stack underflow*/, (IntPtr)(nint)new IReadOnlyListMethods<IDisposable>((IntPtr)__KnownINotifyPropertyChangingArgs.Message, (uint)(int)this, ref *(IDisposable[]*)(delegate* unmanaged[Stdcall]<nint, uint, nint, uint*, uint>)(&IEnumerator_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3)));
					obj2 = 3;
					continue;
				case 2:
					break;
				case 16:
					__KnownINotifyPropertyChangingArgs.Version = (PropertyChangingEventArgs)IReadOnlyListMethods<object>.Abi_get_Size_1((IntPtr)(int)IReadOnlyList_System_IDisposable.Do_Abi_GetAt_0((nint)/*Error near IL_027a: Stack underflow*/, (uint)(int)this, (nint*)(nint)__KnownINotifyPropertyChangingArgs.MaxPlayers));
					obj2 = 7;
					continue;
				case 5:
					__KnownINotifyPropertyChangingArgs.Summary = (PropertyChangingEventArgs)(object)new IFrameworkElementOverridesMethods[3]
					{
						(IFrameworkElementOverridesMethods)__KnownINotifyPropertyChangingArgs.Characters,
						(IFrameworkElementOverridesMethods)__KnownINotifyPropertyChangingArgs.BackgroundImageUrl,
						(IFrameworkElementOverridesMethods)__KnownINotifyPropertyChangingArgs.IsLiked
					};
					obj2 = 7;
					if (__KnownINotifyPropertyChangingArgs.SourceImage == null)
					{
						obj2 = 15;
					}
					continue;
				case 14:
					_ = __KnownINotifyPropertyChangingArgs.Title;
					IEnumerableMethods<object>.Abi_First_0((IntPtr)19);
					_ = 0;
					if (__KnownINotifyPropertyChangingArgs.State == null)
					{
						_ = 1;
					}
					continue;
				default:
					((Func<Type, ComWrappers.ComInterfaceEntry[]>)this)._002Ector((object)IReadOnlyList_object.ReflectSimpleAttribute(), unchecked((nint)null));
					obj2 = 19;
					continue;
				case 12:
				{
					char[] array = new char[5];
					((object[])(object)this)[(object)array] = (string?)(object)array == (string?)0;
					((object[])/*Error near IL_032d: Stack underflow*/)[/*Error near IL_032d: Stack underflow*/] = IEnumerator_System_IDisposable.Do_Abi_MoveNext_2((nint)/*Error near IL_0325: Stack underflow*/, (byte*)1);
					((object[])/*Error near IL_0335: Stack underflow*/)[/*Error near IL_0335: Stack underflow*/] = IEnumerator_System_IDisposable.Do_Abi_GetMany_3((nint)/*Error near IL_0334: Stack underflow*/, (uint)/*Error near IL_0334: Stack underflow*/, (nint)/*Error near IL_032d: Stack underflow*/, (uint*)2);
					((object[])/*Error near IL_033d: Stack underflow*/)[/*Error near IL_033d: Stack underflow*/] = IEnumerator_System_IDisposable.Do_Abi_get_Current_0((nint)/*Error near IL_0335: Stack underflow*/, (nint*)3);
					/*Error near IL_033d: Stack underflow*/;
					_ = 4;
					if (IReadOnlyListMethods<object>.AbiToProjectionVftablePtr != (IntPtr)9)
					{
						/*Error near IL_034d: Member reference must be method, but was: Field*/;
					}
					IEnumerator_System_IDisposable.DecompressAttribute();
					((object[])(nint)IEnumerableMethods<object>.AbiToProjectionVftablePtr)[IListMethods.IID] = (nint)IListMethods.AbiToProjectionVftablePtr;
					__KnownINotifyPropertyChangingArgs.DisplayName = (PropertyChangingEventArgs)IEnumerableMethods.IID;
					_ = 14;
					if (__KnownINotifyPropertyChangingArgs.TotalCoins == null)
					{
						_ = 16;
					}
					continue;
				}
				}
				break;
			}
			__KnownINotifyPropertyChangingArgs.OnlinePlayers = (PropertyChangingEventArgs)IReadOnlyListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_025b: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)__KnownINotifyPropertyChangingArgs.IsSkeleton, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(IEnumerator_System_ComponentModel_INotifyPropertyChanged.DecorateDynamicAttribute() ? 1 : 0));
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778347, new IntPtr(2737335803292L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FFFD()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17782, 1790778344, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778344, new IntPtr(2737335819932L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778345, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FFFD()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17784, 1790778358, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778358, new IntPtr(2737335800172L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_E000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778359, new IntPtr(2737335818892L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_E100(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_004f: Expected I4, but got Obj
		//IL_01c6: Expected I, but got Obj
		//IL_01d1: Expected I, but got Obj
		//IL_01d1: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I4
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I
		//IL_00e8: Expected I, but got Obj
		//IL_00ed: Expected I4, but got Obj
		//IL_008f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01e5->IL0026: Incompatible stack heights: 2 vs 1
		//IL_009c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01b0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0201->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f0->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0073->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0106->IL00c7: Incompatible stack heights: 5 vs 3
		//IL_0111->IL00c7: Incompatible stack heights: 5 vs 3
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
			case 5:
			case 6:
				if ((nint)obj >= ((Array)obj).Length)
				{
					obj2 = 0;
					if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute == null)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
				obj = ((object[])obj)[obj];
				obj2 = 7;
				break;
			case 3:
				obj = 0;
				obj2 = 6;
				break;
			case 7:
			{
				IEnumerator_object.Init();
				int num = 0;
				if (IList_object._initialized != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
						IEnumeratorMethods<object>.Abi_get_HasCurrent_1(MarshalInspectable<object>.FromManaged(IList_object.PatchAttribute, (byte)(int)IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)obj) != 0));
						_ = 1;
						if (IReadOnlyList_object._initialized != 0)
						{
							_ = 0;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
				goto case 2;
			}
			case 4:
				obj = P_0;
				obj2 = 3;
				break;
			case 2:
				IList_object.Do_Abi_GetAt_0((nint)Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute, IListMethods<object>.Abi_IndexOf_3((IntPtr)(IEnumerable_System_ComponentModel_INotifyPropertyChanged.DecorateSeparatedAttribute() ? 1 : 0), (object)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectMonoAttribute(), ref *(uint*)MarshalInspectable<object>.FromAbi((IntPtr)obj)) ? 1u : 0u, (nint*)unchecked((nint)null));
				_ = 8;
				if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute == null)
				{
					_ = 8;
				}
				break;
			case 0:
				return;
			case 8:
				obj++;
				obj2 = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_E200(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778356, new IntPtr(2737335806412L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_E300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778357, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_E400()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0048: Expected I, but got Obj
		//IL_0057: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_005c->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0079->IL0067: Incompatible stack heights: 1 vs 0
		//IL_0067->IL0026: Incompatible stack heights: 3 vs 1
		//IL_008d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0098->IL0026: Incompatible stack heights: 2 vs 1
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
			case 1:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)_003CModule_003E.CheckAccessibleAttribute(), ref *(object[]*)null);
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 2:
				IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_006e: Stack underflow*/, (uint)/*Error near IL_006e: Stack underflow*/, (nint)/*Error near IL_006e: Stack underflow*/, (uint*)(nint)this);
				if (MarshalInspectable<object>.FromAbiArray((object)null) == null)
				{
					return;
				}
				_ = 1;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_E500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778354, new IntPtr(2737335814732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_E600()
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
	internal unsafe object _FF00_E700()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17792, 1790778355, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778355, new IntPtr(2737335820972L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_E800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778352, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_E900()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void _FF00_EB00(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0049: Expected Obj, but got I4
		//IL_01d0: Expected Obj, but got I4
		//IL_01d0: Expected I, but got Obj
		//IL_01ac: Expected I, but got Obj
		//IL_01e6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01bb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f1->IL0026: Incompatible stack types: I4 vs Obj
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
			{
				obj = ExceptionHelpers.GetHRForException((Exception)P_0);
				int num = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					num = 1;
				}
				switch (num)
				{
				case 1:
					break;
				case 0:
					break;
				}
				return;
			}
			case 3:
				if (IListMethods<object>.Abi_GetView_2((IntPtr)P_0) == null)
				{
					obj2 = 2;
					break;
				}
				obj2 = 0;
				if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute == null)
				{
					obj2 = 0;
				}
				break;
			case 1:
				return;
			case 2:
				throw new IListMethods<object>((IntPtr)Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute, IList_object.Initialized ? 1u : 0u, (object)IList_object.Init());
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void _FF00_EC00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778353, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<GameResourceModel> _FF00_ED00()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<GameResourceModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<GameResourceModel> _FF00_EE00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778366, new IntPtr(2737335814732L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<GameResourceModel>)/*Error near IL_0033: Stack underflow*/;
	}
}
