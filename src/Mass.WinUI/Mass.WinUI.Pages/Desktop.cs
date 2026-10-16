using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using ABI.Microsoft.UI.Xaml.Controls;
using ABI.Microsoft.UI.Xaml.Markup;
using ABI.System;
using ABI.System.Collections;
using ABI.System.Collections.Generic;
using ABI.System.Collections.Specialized;
using ABI.System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using Mass.Application.Mobile;
using Mass.WinUI.Mass_WinUI_XamlTypeInfo;
using Mass.WinUI.Models;
using Mass.WinUI.ViewModels;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.Web.WebView2.Core;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
using WinRT.Mass_WinUIVtableClasses;
using Windows.Foundation;

namespace Mass.WinUI.Pages;

[WinRTExposedType(typeof(Mass_WinUI_Pages_MobileWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class Desktop : Page, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGridViewItemClick_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Desktop _003C_003E4__this;

		public ItemClickEventArgs e;

		private object _003Cskin_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		internal static object IncludeContext;

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
		internal static bool InvokeMapper()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateExpandableEvent()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00唀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778844, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00嘀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_0717: Expected Obj, but got Ref
			//IL_0092: Expected Obj, but got Ref
			//IL_00a3: Expected Obj, but got I
			//IL_00b9: Expected Obj, but got Ref
			//IL_00bb: Expected Obj, but got I
			//IL_0054: Expected Obj, but got Ref
			//IL_0079: Expected Obj, but got Ref
			//IL_0087: Expected Obj, but got I4
			//IL_00d7: Expected Obj, but got I4
			//IL_03e6: Expected Obj, but got Ref
			//IL_018d: Expected I4, but got Obj
			//IL_024d: Expected Obj, but got I4
			//IL_0252: Expected Obj, but got I4
			//IL_0252: Expected Obj, but got Ref
			//IL_01ea: Expected Obj, but got I4
			//IL_01ef: Expected Obj, but got I4
			//IL_01ef: Expected Obj, but got Ref
			//IL_01fe: Expected Obj, but got I
			//IL_04bd: Expected Obj, but got Ref
			//IL_0229: Expected Obj, but got Ref
			//IL_05cd: Expected Obj, but got VT
			//IL_03d2: Expected Obj, but got Ref
			//IL_03db: Expected Obj, but got I4
			//IL_0334: Expected Obj, but got Ref
			//IL_0339: Expected I, but got Obj
			//IL_0339: Expected I4, but got Obj
			//IL_0490: Expected Obj, but got Ref
			//IL_0498: Expected Obj, but got Ref
			//IL_03a1: Expected Obj, but got Ref
			//IL_02b9: Expected Obj, but got Ref
			//IL_0198: Expected Obj, but got Ref
			//IL_019d: Expected I4, but got Obj
			//IL_04d2: Expected Obj, but got I4
			//IL_04d7: Expected Obj, but got I4
			//IL_04d7: Expected Obj, but got Ref
			//IL_04e9: Expected Obj, but got Ref
			//IL_04f3: Expected Obj, but got I4
			//IL_02a7: Expected Obj, but got I4
			//IL_0427: Expected Obj, but got Ref
			//IL_057b: Expected Obj, but got I4
			//IL_0580: Expected Obj, but got I4
			//IL_0580: Expected Obj, but got Ref
			//IL_0454: Expected Obj, but got Ref
			//IL_0357: Expected Obj, but got Ref
			//IL_0466: Expected Obj, but got Ref
			//IL_072b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a8->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c5->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0736->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00b3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0073->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03f2->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_02f0->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_0266->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_031c->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_01d6->IL00e0: Incompatible stack heights: 2 vs 1
			//IL_05c1->IL00e0: Incompatible stack heights: 3 vs 1
			//IL_0203->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_051a->IL02ff: Incompatible stack heights: 1 vs 0
			//IL_04cd->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_023d->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_0552->IL00e0: Incompatible stack heights: 3 vs 1
			//IL_05e3->IL00e0: Incompatible stack heights: 2 vs 1
			//IL_034f->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_04ac->IL00e0: Incompatible stack heights: 4 vs 1
			//IL_03a6->IL04e1: Incompatible stack heights: 1 vs 0
			//IL_02d3->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_01b3->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_04e1->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_04ff->IL00e0: Incompatible stack heights: 3 vs 1
			//IL_02b3->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_0443->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_0421->IL00e0: Incompatible stack heights: 2 vs 1
			//IL_0594->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_0460->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_061b->IL00e0: Incompatible stack heights: 5 vs 1
			//IL_0361->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_0271->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_0327->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_020e->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_052e->IL00e0: Incompatible stack heights: 2 vs 1
			//IL_0408->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_0248->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_05b0->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_0635->IL0635: Incompatible stack heights: 2 vs 1
			//IL_0289->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_05ee->IL00e0: Incompatible stack heights: 2 vs 1
			//IL_04b7->IL00e0: Incompatible stack heights: 4 vs 1
			//IL_03ba->IL00e0: Incompatible stack heights: 2 vs 1
			//IL_02de->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_01be->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_044e->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_059f->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_047f->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_0539->IL00e0: Incompatible stack heights: 2 vs 1
			//IL_03c5->IL00e0: Incompatible stack heights: 2 vs 1
			//IL_064e->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_048a->IL00e0: Incompatible stack types: I4 vs Obj
			//IL_0659->IL00e0: Incompatible stack types: I4 vs Obj
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
					case 4:
						IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = -2;
						obj = 0;
						if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
						{
							obj = 0;
						}
						continue;
					case 5:
						break;
					case 2:
						awaiter = IList_object.PatchAttribute;
						obj = 0;
						if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
						{
							obj = 1;
						}
						continue;
					case 3:
						awaiter = IReadOnlyList_System_IDisposable._initialized;
						obj = 2;
						continue;
					case 6:
						return;
					case 1:
						if (awaiter == null)
						{
							awaiter = 13;
							goto IL_00dc;
						}
						goto IL_02de;
					default:
						{
							__KnownINotifyPropertyChangingArgs.SelectedFileName = null;
							obj = 3;
							if (__KnownINotifyPropertyChangingArgs.ParsedCount == null)
							{
								obj = 5;
							}
							continue;
						}
						IL_02de:
						if ((nint)awaiter != 1)
						{
							obj2 = 17;
							goto IL_00e0;
						}
						goto IL_03e0;
						IL_03e0:
						awaiter = __KnownINotifyPropertyChangingArgs.CanProxy;
						obj2 = 26;
						goto IL_00e0;
						IL_00e0:
						while (true)
						{
							switch ((int)obj2)
							{
							case 14:
							case 19:
							case 20:
							case 22:
							case 29:
								break;
							case 27:
								return;
							case 33:
								return;
							case 4:
							case 28:
								awaiter = IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)/*Error near IL_019d: Stack underflow*/, (uint)(int)IReadOnlyList_System_IDisposable.ReflectConnectedAttribute);
								obj2 = 4;
								if (IEnumerator_System_IDisposable._initialized == 0)
								{
									obj2 = 18;
								}
								continue;
							case 3:
								IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_IndexOf_2((nint)/*Error near IL_01c3: Stack underflow*/, (nint)/*Error near IL_01c3: Stack underflow*/, (uint*)/*Error near IL_01c3: Stack underflow*/, (byte*)/*Error near IL_01c3: Stack underflow*/);
								awaiter = MarshalInterface<INotifyPropertyChanged>.FromAbiArray(awaiter);
								_ = 39;
								continue;
							case 6:
								awaiter = 0;
								IEnumerable_System_IDisposable.CombineAttribute = 0;
								obj2 = 3;
								if (IEnumerable_object.ReflectSetAttribute == null)
								{
									obj2 = 11;
								}
								continue;
							case 11:
								GlobalVtableLookup.CreateAttribute = awaiter;
								obj2 = 24;
								if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute != null)
								{
									obj2 = 2;
								}
								continue;
							default:
								awaiter = -1;
								Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute = -1;
								obj2 = 0;
								if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute == null)
								{
									obj2 = 2;
								}
								continue;
							case 15:
								if (Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute == null)
								{
									obj2 = 35;
									continue;
								}
								_ = IDisposableMethods.IID;
								goto IL_0635;
							case 32:
								IListMethods<object>.Abi_SetAt_4((IntPtr)/*Error near IL_02a7: Stack underflow*/, IList_object.Initialized ? 1u : 0u, (object)IList_object.Init());
								awaiter = (object)/*Error near IL_02a9: Stack underflow*/;
								obj2 = 21;
								continue;
							case 26:
								Unsafe.As<object, ReadOnlySpan<char>>(ref Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute) = default;
								obj2 = 0;
								if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance == null)
								{
									obj2 = 0;
								}
								continue;
							case 7:
								goto IL_02de;
							case 2:
								IListMethods<object>.Abi_Clear_9((IntPtr)(nint)(&awaiter));
								awaiter = (object)/*Error near IL_0308: Stack underflow*/;
								obj2 = 3;
								if ((int)_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout != 0)
								{
									obj2 = 3;
								}
								continue;
							case 21:
								awaiter = IEnumeratorMethods<INotifyPropertyChanged>.Abi_get_Current_0((IntPtr)(int)IEnumeratorMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_033e: Stack underflow*/, ref *(INotifyPropertyChanged[]*)IList_object.Do_Abi_ReplaceAll_11((nint)(int)IList_object.Do_Abi_Clear_9((nint)/*Error near IL_032c: Stack underflow*/), (uint)(int)awaiter, (nint)_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator)));
								obj2 = 8;
								continue;
							case 40:
								__KnownINotifyPropertyChangingArgs.CreateAt = (PropertyChangingEventArgs)awaiter;
								obj2 = 34;
								continue;
							case 25:
								if ((int)IEnumerator_System_ComponentModel_INotifyPropertyChanged.Init() == (nint)__KnownINotifyPropertyChangingArgs.Message)
								{
									_ = 8;
									if (__KnownINotifyPropertyChangingArgs.Content != null)
									{
										_ = 14;
									}
									continue;
								}
								goto case 31;
							case 18:
								goto IL_03c5;
							case 1:
								goto IL_03e0;
							case 9:
								if (IReadOnlyListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_03f9: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_03f9: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_03f9: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(&awaiter)))
								{
									obj2 = 23;
									continue;
								}
								goto case 6;
							case 36:
								IReadOnlyListMethods<object>.Abi_GetMany_3((IntPtr)/*Error near IL_0417: Stack underflow*/, IReadOnlyList_System_IDisposable.Initialized ? 1u : 0u, ref *(object[]*)IReadOnlyList_System_IDisposable.Init());
								_ = 19;
								continue;
							case 34:
								Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.Description).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<MobileSession>*)(&awaiter), ref Unsafe.As<_003CGridViewItemClick_003Ed__5, AccountViewModel._003CLoginMobile_003Ed__88>(ref this));
								obj2 = 27;
								if (__KnownINotifyPropertyChangingArgs.Characters == null)
								{
									obj2 = 14;
								}
								continue;
							case 13:
							case 38:
								awaiter = __KnownINotifyPropertyChangingArgs.BackgroundImageUrl;
								obj2 = 10;
								continue;
							case 41:
								if (__KnownINotifyPropertyChangingArgs.IsLiked == null)
								{
									obj2 = 6;
									if (__KnownINotifyPropertyChangingArgs.PreviewImage == null)
									{
										obj2 = 16;
									}
									continue;
								}
								goto case 25;
							case 24:
								_ = ref __KnownINotifyPropertyChangingArgs.SourceImage;
								_ = ref awaiter;
								((IEnumerable<NeteaseAccount>)Unsafe.AsPointer(ref this)).ToList();
								_ = 33;
								if (__KnownINotifyPropertyChangingArgs.LaunchTime == null)
								{
									_ = 20;
								}
								continue;
							case 10:
								Unsafe.As<PropertyChangingEventArgs, TimeSpan>(ref __KnownINotifyPropertyChangingArgs.State) = default;
								obj2 = 30;
								continue;
							case 30:
								awaiter = -1;
								__KnownINotifyPropertyChangingArgs.OperationText = (PropertyChangingEventArgs)(-1);
								obj2 = 5;
								continue;
							case 31:
								_ = __KnownINotifyPropertyChangingArgs.CloseText;
								awaiter = ((object)IEnumerator_System_IDisposable.Init()).ToString();
								_ = 9;
								continue;
							case 8:
								_ = ref awaiter;
								if ((int)IReadOnlyListMethods<object>.IID == 0)
								{
									_ = 23;
									if (__KnownINotifyPropertyChangingArgs.Price == null)
									{
										_ = 37;
									}
									continue;
								}
								goto case 2;
							case 16:
								IEnumerator_System_IDisposable._002Ecctor();
								IEnumerator_System_IDisposable.DecompressAttribute();
								_ = IEnumerableMethods<object>.AbiToProjectionVftablePtr;
								_ = 29;
								continue;
							case 37:
								awaiter = 1;
								__KnownINotifyPropertyChangingArgs.Image = (PropertyChangingEventArgs)1;
								obj2 = 20;
								if (__KnownINotifyPropertyChangingArgs.JoinedAt != null)
								{
									obj2 = 40;
								}
								continue;
							case 12:
								if (awaiter != null)
								{
									obj2 = 4;
									continue;
								}
								goto case 36;
							case 5:
							case 23:
								_ = ref awaiter;
								_ = INotifyCollectionChangedMethods.AbiToProjectionVftablePtr;
								_ = 15;
								continue;
							case 17:
								awaiter = INotifyPropertyChangedMethods.IID as DesktopViewModel;
								_ = 1;
								if (__KnownINotifyPropertyChangingArgs.Quantity != null)
								{
									_ = 12;
								}
								continue;
							case 39:
								_ = __KnownINotifyPropertyChangingArgs.DesktopAccounts;
								_ = IReadOnlyListMethods<INotifyPropertyChanged>.AbiToProjectionVftablePtr;
								GlobalVtableLookup.InitializeGlobalVtableLookup();
								GlobalVtableLookup.LookupVtableEntries(awaiter);
								_ = IEnumeratorMethods<INotifyPropertyChanged>.IID;
								_ = IEnumeratorMethods<INotifyPropertyChanged>.AbiToProjectionVftablePtr;
								_ = 22;
								continue;
							case 35:
								{
									goto IL_0635;
								}
								IL_0635:
								if (null == null)
								{
									obj2 = 0;
									if (__KnownINotifyPropertyChangingArgs.Input4399Password != null)
									{
										obj2 = 20;
									}
									continue;
								}
								goto case 32;
							}
							break;
						}
						goto case 4;
						IL_03c5:
						__KnownINotifyPropertyChangingArgs.IsSkeleton = (PropertyChangingEventArgs)(object)(awaiter as Mass.WinUI.Mass_WinUI_XamlTypeInfo.Activator);
						awaiter = 41;
						goto IL_00dc;
						IL_00dc:
						obj2 = awaiter;
						goto IL_00e0;
					}
					break;
				}
				*((int, nint)*)(nint)/*Error near IL_007e: Stack underflow*/ = ((int)/*Error near IL_007e: Stack underflow*/, (nint)Unsafe.AsPointer(ref IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute));
				awaiter = 6;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00圀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778845, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00堀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00夀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778842, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00娀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778843, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00嬀()
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
		internal unsafe static object _FF00_FF00_FF00_FF00尀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778840, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00崀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778841, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00帀(object P_0)
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
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadWebView2_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Desktop _003C_003E4__this;

		private TaskAwaiter<CoreWebView2Environment> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private static object DecorateHiddenWrapper;

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
		internal static bool DecorateAdjustableProcessor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WriteEvent()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00䠀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778662, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00䤀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_04c2: Expected Obj, but got Ref
			//IL_04fe: Expected Obj, but got Ref
			//IL_04e9: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got Ref
			//IL_0213: Expected Obj, but got Ref
			//IL_034a: Expected Obj, but got I4
			//IL_01fe: Expected Obj, but got I4
			//IL_0203: Expected Obj, but got I4
			//IL_0203: Expected Obj, but got Ref
			//IL_0375: Expected I, but got Obj
			//IL_0382: Expected Obj, but got I4
			//IL_01e8: Expected I4, but got Obj
			//IL_01e8: Expected I, but got Obj
			//IL_01ed: Expected I, but got Obj
			//IL_0411: Expected Obj, but got Ref
			//IL_02f4: Expected Obj, but got Ref
			//IL_032f: Expected Obj, but got Ref
			//IL_0103: Expected I, but got Obj
			//IL_0108: Expected I, but got Obj
			//IL_03e1: Expected Obj, but got Ref
			//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0420: Expected Obj, but got I4
			//IL_0425: Expected Obj, but got I4
			//IL_0425: Expected Obj, but got Ref
			//IL_03a6: Expected Obj, but got I4
			//IL_03ab: Expected Obj, but got I4
			//IL_03ab: Expected Obj, but got Ref
			//IL_01bb: Expected I, but got Obj
			//IL_03f7: Expected Obj, but got Ref
			//IL_0169: Expected Obj, but got Ref
			//IL_0172: Expected Obj, but got I4
			//IL_031a: Expected Obj, but got I4
			//IL_031f: Expected Obj, but got I4
			//IL_031f: Expected Obj, but got Ref
			//IL_0264: Expected I, but got Obj
			//IL_0272: Expected Obj, but got I4
			//IL_012d: Expected Obj, but got Ref
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Expected I4, but got Obj
			//IL_04d8->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0514->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04f8->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04e3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_051f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0229->IL0086: Incompatible stack types: I4 vs Obj
			//IL_0082->IL0086: Incompatible stack types: I4 vs Obj
			//IL_0234->IL0086: Incompatible stack types: I4 vs Obj
			//IL_035e->IL0086: Incompatible stack types: I4 vs Obj
			//IL_020d->IL0086: Incompatible stack types: I4 vs Obj
			//IL_0396->IL0086: Incompatible stack heights: 2 vs 1
			//IL_01f9->IL0086: Incompatible stack types: I4 vs Obj
			//IL_041b->IL0086: Incompatible stack types: I4 vs Obj
			//IL_030a->IL0086: Incompatible stack types: I4 vs Obj
			//IL_0341->IL0086: Incompatible stack types: I4 vs Obj
			//IL_03db->IL0086: Incompatible stack heights: 2 vs 1
			//IL_02ee->IL0086: Incompatible stack types: I4 vs Obj
			//IL_011c->IL0086: Incompatible stack types: I4 vs Obj
			//IL_03f1->IL0086: Incompatible stack types: I4 vs Obj
			//IL_042f->IL0086: Incompatible stack types: I4 vs Obj
			//IL_03bf->IL0086: Incompatible stack types: I4 vs Obj
			//IL_01cf->IL0086: Incompatible stack heights: 4 vs 1
			//IL_0409->IL0086: Incompatible stack heights: 2 vs 1
			//IL_0329->IL0086: Incompatible stack types: I4 vs Obj
			//IL_013d->IL0086: Incompatible stack types: I4 vs Obj
			//IL_0369->IL0086: Incompatible stack types: I4 vs Obj
			//IL_03a1->IL0086: Incompatible stack heights: 2 vs 1
			//IL_02ad->IL0086: Incompatible stack types: I4 vs Obj
			//IL_0315->IL0086: Incompatible stack types: I4 vs Obj
			//IL_0197->IL0086: Incompatible stack types: I4 vs Obj
			//IL_0127->IL0086: Incompatible stack types: I4 vs Obj
			//IL_02cd->IL0086: Incompatible stack types: I4 vs Obj
			//IL_03ca->IL0086: Incompatible stack types: I4 vs Obj
			//IL_01da->IL0086: Incompatible stack heights: 4 vs 1
			//IL_01a2->IL0086: Incompatible stack types: I4 vs Obj
			//IL_02d8->IL0086: Incompatible stack types: I4 vs Obj
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 1;
			object obj = awaiter;
			while (true)
			{
				object obj2;
				switch ((int)obj)
				{
				case 3:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = -2;
					obj = 2;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj = 0;
					}
					break;
				case 4:
					return;
				case 5:
					if (awaiter != null)
					{
						obj2 = 5;
						goto IL_0086;
					}
					goto IL_020d;
				default:
					awaiter = __KnownINotifyPropertyChangingArgs.Id;
					obj = 5;
					if (__KnownINotifyPropertyChangingArgs.Price == null)
					{
						obj = 3;
					}
					break;
				case 2:
					_ = ref __KnownINotifyPropertyChangingArgs.Paid;
					_ = IEnumerableMethods<object>.IID;
					_ = 4;
					break;
				case 1:
					{
						awaiter = __KnownINotifyPropertyChangingArgs.PayAt;
						obj = 0;
						if (__KnownINotifyPropertyChangingArgs.PayUrl == null)
						{
							obj = 0;
						}
						break;
					}
					IL_020d:
					awaiter = Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute;
					obj2 = 2;
					if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute == null)
					{
						obj2 = 26;
					}
					goto IL_0086;
					IL_0086:
					while (true)
					{
						switch ((int)obj2)
						{
						case 16:
							break;
						case 6:
							return;
						case 13:
							return;
						case 14:
							IList_object._initialized = (nint)new Action<object[], nint>((object[])/*Error near IL_0103: Stack underflow*/, (nint)awaiter);
							obj2 = 3;
							if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
							{
								obj2 = 20;
							}
							continue;
						case 26:
							IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute = default(MarshalInterface<IEnumerator<INotifyPropertyChanged>>);
							obj2 = 19;
							continue;
						case 22:
							IReadOnlyList_object.ReflectLogicalAttribute = awaiter;
							awaiter = 21;
							goto IL_0082;
						case 12:
							if (MarshalInterface<INotifyPropertyChanged>.FromAbi((IntPtr)(nint)(&awaiter)) == null)
							{
								obj2 = 18;
								if (IEnumerable_System_IDisposable._initialized == 0)
								{
									obj2 = 3;
								}
								continue;
							}
							goto case 9;
						case 20:
							_ = IEnumerable_System_IDisposable.CombineAttribute;
							IEnumerableMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)new IReadOnlyListMethods<INotifyPropertyChanged>((IntPtr)(nint)(delegate*<void>)(&IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor)));
							_ = 3;
							if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute == null)
							{
								_ = 0;
							}
							continue;
						case 3:
							awaiter = IListMethods<object>.Abi_GetView_2((IntPtr)IListMethods<object>.Abi_GetAt_0((IntPtr)Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute, (uint)(int)awaiter));
							obj2 = 12;
							continue;
						case 1:
							awaiter = 0;
							Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute = 0;
							obj2 = 22;
							continue;
						case 24:
							goto IL_020d;
						case 25:
							IListMethods<object>.Abi_RemoveAtEnd_8((IntPtr)Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute);
							IListMethods<object>.Abi_Clear_9((IntPtr)/*Error near IL_0269: Stack underflow*/);
							awaiter = 2;
							goto IL_0082;
						case 5:
							if ((nint)awaiter != 1)
							{
								obj2 = 11;
								continue;
							}
							goto case 7;
						case 17:
							if (IListMethods<object>.Abi_get_Size_1((IntPtr)(nint)(&awaiter)) != 0)
							{
								obj2 = 10;
								if (__KnownINotifyPropertyChangingArgs.Notes == null)
								{
									obj2 = 0;
								}
								continue;
							}
							goto case 1;
						case 11:
							awaiter = IEnumeratorMethods<INotifyPropertyChanged>.Abi_get_Current_0((IntPtr)(int)IList_object.Do_Abi_get_Size_1((nint)/*Error near IL_02dd: Stack underflow*/, (uint*)/*Error near IL_02dd: Stack underflow*/));
							obj2 = 17;
							continue;
						case 7:
							awaiter = __KnownINotifyPropertyChangingArgs.CreateAt;
							obj2 = 15;
							if (__KnownINotifyPropertyChangingArgs.Name == null)
							{
								obj2 = 10;
							}
							continue;
						case 23:
							awaiter = -1;
							__KnownINotifyPropertyChangingArgs.IsMyself = (PropertyChangingEventArgs)(-1);
							obj2 = 9;
							continue;
						case 8:
							Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.Message).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<string>*)(&awaiter), ref Unsafe.As<_003CLoadWebView2_003Ed__8, AccountViewModel._003CLoginBedrock_003Ed__86>(ref this));
							obj2 = 6;
							continue;
						default:
							awaiter = IReadOnlyListMethods<IDisposable>.Abi_GetMany_3((IntPtr)/*Error near IL_0348: Stack underflow*/, (uint)/*Error near IL_0348: Stack underflow*/, ref *(IDisposable[]*)(&awaiter));
							obj2 = 12;
							if (__KnownINotifyPropertyChangingArgs.IsSkeleton == null)
							{
								obj2 = 14;
							}
							continue;
						case 2:
							IReadOnlyListMethods<object>.Abi_IndexOf_2((IntPtr)(IReadOnlyListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0375: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_0375: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_0375: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)__KnownINotifyPropertyChangingArgs.CanProxy) ? 1 : 0), (object)0, ref *(uint*)__KnownINotifyPropertyChangingArgs.OnlinePlayers);
							_ = 16;
							if (__KnownINotifyPropertyChangingArgs.Description == null)
							{
								_ = 12;
							}
							continue;
						case 19:
							awaiter = -1;
							__KnownINotifyPropertyChangingArgs.Version = (PropertyChangingEventArgs)(-1);
							obj2 = 0;
							if (__KnownINotifyPropertyChangingArgs.Characters == null)
							{
								obj2 = 0;
							}
							continue;
						case 9:
							IEnumeratorMethods<IDisposable>.Abi_get_Current_0((IntPtr)(nint)(&awaiter));
							_ = 25;
							continue;
						case 15:
							__KnownINotifyPropertyChangingArgs.IsLiked = (PropertyChangingEventArgs)default(IWinRTExposedTypeDetails);
							obj2 = 23;
							continue;
						case 21:
							_ = ref __KnownINotifyPropertyChangingArgs.PreviewImage;
							((AsyncTaskMethodBuilder*)(&awaiter))->Start(ref Unsafe.As<_003CLoadWebView2_003Ed__8, ImportAccountViewModel._003CPrimaryAsync_003Ed__46>(ref this));
							_ = 13;
							continue;
						case 4:
							__KnownINotifyPropertyChangingArgs.Title = (PropertyChangingEventArgs)awaiter;
							obj2 = 8;
							continue;
						case 18:
							{
								awaiter = 1;
								__KnownINotifyPropertyChangingArgs.Executor = (PropertyChangingEventArgs)1;
								obj2 = 4;
								continue;
							}
							IL_0082:
							obj2 = awaiter;
							continue;
						}
						break;
					}
					goto case 3;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00䨀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778663, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00䬀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00䰀()
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
		internal unsafe static object _FF00_FF00_FF00_FF00䴀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778660, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00一(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00伀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778661, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CWebView2Loaded_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		private object _003Cwv_003E5__2;

		private object _003CbaseDic_003E5__3;

		private TaskAwaiter<CoreWebView2Environment> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private static object ReflectRandomConverter;

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
		internal static bool PlanProcessor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectAdvancedAnnotation()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00㼀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778658, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00䀀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_076c: Expected Obj, but got Ref
			//IL_0781: Expected Obj, but got Ref
			//IL_0054: Expected I, but got Obj
			//IL_0054: Expected Obj, but got Ref
			//IL_007b: Expected Obj, but got I4
			//IL_007b: Expected Obj, but got Ref
			//IL_0747: Expected Obj, but got Ref
			//IL_009c: Expected Obj, but got I
			//IL_0494: Expected Obj, but got Ref
			//IL_0533: Expected Obj, but got I4
			//IL_05bb: Expected Obj, but got Ref
			//IL_05c5: Expected Obj, but got VT
			//IL_0609: Expected Obj, but got Ref
			//IL_0448: Expected Obj, but got Ref
			//IL_0448: Unknown result type (might be due to invalid IL or missing references)
			//IL_0245: Expected Obj, but got Ref
			//IL_0361: Expected Obj, but got Ref
			//IL_05e4: Expected Obj, but got I
			//IL_025b: Expected Obj, but got Ref
			//IL_0224: Expected Obj, but got Ref
			//IL_0235: Expected Obj, but got I4
			//IL_03c7: Expected I, but got Obj
			//IL_019e: Expected Obj, but got I4
			//IL_01a3: Expected Obj, but got Ref
			//IL_0474: Expected Obj, but got Ref
			//IL_0479: Expected I, but got Obj
			//IL_0484: Expected Obj, but got I4
			//IL_03fd: Expected Obj, but got Ref
			//IL_0402: Expected I, but got Obj
			//IL_0650: Expected Obj, but got Ref
			//IL_0347: Expected Obj, but got Ref
			//IL_0351: Expected Obj, but got Ref
			//IL_04f8: Expected Obj, but got Ref
			//IL_0502: Expected I, but got Obj
			//IL_063e: Expected Obj, but got Ref
			//IL_04ba: Expected Obj, but got I4
			//IL_04bf: Expected Obj, but got I4
			//IL_04bf: Expected Obj, but got Ref
			//IL_039e: Expected Obj, but got Ref
			//IL_0554: Expected Obj, but got Ref
			//IL_0562: Expected Obj, but got I
			//IL_02fb: Expected Obj, but got Ref
			//IL_0303: Expected Obj, but got Ref
			//IL_04e3: Expected Obj, but got I4
			//IL_04e8: Expected Obj, but got I4
			//IL_04e8: Expected Obj, but got Ref
			//IL_0288: Expected Obj, but got Ref
			//IL_028d: Expected I, but got Obj
			//IL_0298: Expected Obj, but got Ref
			//IL_029d: Expected I, but got Obj
			//IL_02a2: Expected I, but got Obj
			//IL_02a7: Expected Obj, but got I4
			//IL_01b5: Expected Obj, but got Ref
			//IL_01be: Expected Obj, but got I4
			//IL_0378: Expected Obj, but got Ref
			//IL_0436: Expected Obj, but got I4
			//IL_0438: Expected Obj, but got I
			//IL_02d1: Expected Obj, but got I4
			//IL_02d6: Expected VT, but got I4
			//IL_02d6: Expected Obj, but got Ref
			//IL_02e5: Expected Obj, but got I4
			//IL_0161: Expected I4, but got Obj
			//IL_077b->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0797->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
			//IL_075b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a1->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_07a2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0073->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0766->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04aa->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_00ac->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_04b5->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_05d7->IL00b0: Incompatible stack heights: 6 vs 1
			//IL_062d->IL00b0: Incompatible stack heights: 6 vs 1
			//IL_03f7->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_0458->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0544->IL0199: Incompatible stack heights: 1 vs 0
			//IL_0255->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_05f8->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_0277->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_023f->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_03db->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_01ad->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_048e->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_0421->IL00b0: Incompatible stack heights: 3 vs 1
			//IL_046e->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_035b->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0511->IL00b0: Incompatible stack heights: 3 vs 1
			//IL_064a->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_04d3->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_03b4->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0576->IL00b0: Incompatible stack heights: 4 vs 1
			//IL_030d->IL00b0: Incompatible stack heights: 4 vs 1
			//IL_04f2->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_02c1->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_038c->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0442->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_02ea->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_058d->IL04de: Incompatible stack heights: 1 vs 0
			//IL_0638->IL00b0: Incompatible stack heights: 6 vs 1
			//IL_054e->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_0370->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0603->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_0282->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_03e6->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_042c->IL00b0: Incompatible stack heights: 3 vs 1
			//IL_0669->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_04de->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0522->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_03bf->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0581->IL00b0: Incompatible stack heights: 4 vs 1
			//IL_02cc->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0397->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_02f5->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0597->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_0674->IL00b0: Incompatible stack types: I4 vs Obj
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				case 3:
					return;
				case 4:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = unchecked((nint)null);
					obj2 = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 0;
					}
					break;
				case 5:
					IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute = -2;
					obj2 = 6;
					break;
				case 1:
					if (obj == null)
					{
						obj3 = 13;
						if (IList_object.PatchAttribute == null)
						{
							obj3 = 21;
						}
						goto IL_00b0;
					}
					goto IL_0522;
				case 6:
					__KnownINotifyPropertyChangingArgs.LanGamesEmptyText = null;
					obj2 = 4;
					if (__KnownINotifyPropertyChangingArgs.LikeNetGames != null)
					{
						obj2 = 1;
					}
					break;
				default:
					_ = ref __KnownINotifyPropertyChangingArgs.FourLikeNetGames;
					_ = IPageOverridesMethods.AbiToProjectionVftablePtr;
					_ = 3;
					break;
				case 2:
					{
						obj = __KnownINotifyPropertyChangingArgs.LikeNetGamesEmptyText;
						obj2 = 0;
						if (__KnownINotifyPropertyChangingArgs.RentalGamesEmptyText != null)
						{
							obj2 = 1;
						}
						break;
					}
					IL_00b0:
					while (true)
					{
						switch ((int)obj3)
						{
						case 7:
							return;
						case 20:
							return;
						case 4:
						case 34:
						case 40:
						case 42:
							break;
						case 15:
							obj = 0;
							IReadOnlyList_System_IDisposable._initialized = 0;
							obj3 = 36;
							continue;
						case 35:
							goto IL_01ad;
						case 12:
						{
							uint num = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)/*Error near IL_0229: Stack underflow*/, (uint*)IEnumerable_System_IDisposable._initialized);
							IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
							obj = IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)(int)num);
							obj3 = 14;
							continue;
						}
						case 8:
							GlobalVtableLookup.CreateAttribute = null;
							obj3 = 26;
							continue;
						case 11:
							_ = ref Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute;
							((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CWebView2Loaded_003Ed__9, AccountViewModel._003CCreateAccount_003Ed__21>(ref this));
							_ = 5;
							if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute != null)
							{
								_ = 7;
							}
							continue;
						case 32:
							IListMethods<object>.Abi_Append_7((IntPtr)/*Error near IL_02a7: Stack underflow*/, (object)IList_object.Do_Abi_IndexOf_3((nint)/*Error near IL_02a2: Stack underflow*/, (nint)/*Error near IL_02a2: Stack underflow*/, (uint*)(nint)MarshalInspectable<object>.FromAbi((IntPtr)Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute), (byte*)(int)IList_object.Do_Abi_GetView_2((nint)(int)IList_object.Init(), (nint*)(nint)Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute)));
							IListMethods<object>.Abi_RemoveAtEnd_8((IntPtr)1);
							obj3 = 9;
							if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule == null)
							{
								obj3 = 17;
							}
							continue;
						case 39:
							obj = -1;
							_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout = (TimeSpan)(-1);
							obj3 = 1;
							if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator != null)
							{
								obj3 = 3;
							}
							continue;
						case 30:
							_ = ref __KnownINotifyPropertyChangingArgs.Notes;
							_ = ref obj;
							WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>((IAsyncOperation<ContentDialogResult>)(object)Unsafe.AsPointer(ref this));
							_ = 20;
							continue;
						case 23:
						{
							PropertyChangingEventArgs loginAt = __KnownINotifyPropertyChangingArgs.LoginAt;
							__KnownINotifyPropertyChangingArgs.IsMyself = ((loginAt is ComWrappersSupport) ? loginAt : null);
							obj3 = 18;
							continue;
						}
						case 9:
							if (__KnownINotifyPropertyChangingArgs.Message == null)
							{
								obj3 = 4;
								continue;
							}
							goto case 37;
						case 36:
							__KnownINotifyPropertyChangingArgs.CharacterName = (PropertyChangingEventArgs)obj;
							obj3 = 30;
							if (__KnownINotifyPropertyChangingArgs.IsSelected == null)
							{
								obj3 = 2;
							}
							continue;
						case 19:
						case 28:
							obj = MarshalInterface<IDisposable>.FromAbiArray((object)(&obj));
							obj3 = 9;
							if (__KnownINotifyPropertyChangingArgs.ShowMaxPlayer != null)
							{
								obj3 = 29;
							}
							continue;
						case 14:
							IReadOnlyListMethods<object>.Abi_GetAt_0((IntPtr)obj, 1u);
							_ = 1;
							if (__KnownINotifyPropertyChangingArgs.Author == null)
							{
								_ = 0;
							}
							continue;
						case 3:
						case 38:
							IReadOnlyListMethods<object>.Abi_get_Size_1((IntPtr)(nint)(&obj));
							_ = 12;
							continue;
						case 17:
							IEnumeratorMethods<IDisposable>.Abi_GetMany_3((IntPtr)/*Error near IL_0407: Stack underflow*/, ref *(IEnumeratorMethods<IDisposable>.Abi_MoveNext_2((IntPtr)__KnownINotifyPropertyChangingArgs.Version) ? ((IDisposable[]*)1) : ((IDisposable[]*)null)));
							IEnumeratorMethods<IDisposable>.Abi_get_Current_0((IntPtr)0);
							_ = 15;
							if (__KnownINotifyPropertyChangingArgs.Summary == null)
							{
								_ = 16;
							}
							continue;
						case 37:
							obj = (nint)MarshalInterface<IEnumerator<IDisposable>>.FromManaged((IEnumerator<IDisposable>)IReadOnlyList_object.Init());
							obj3 = 6;
							continue;
						case 5:
							__KnownINotifyPropertyChangingArgs.Title = (PropertyChangingEventArgs)default(IXamlMemberMethods);
							obj3 = 39;
							continue;
						case 13:
						case 22:
							((Func<Type, string>)/*Error near IL_0462: Stack underflow*/)._002Ector((object)/*Error near IL_0462: Stack underflow*/, (nint)MarshalInterface<IEnumerator<object>>.FromManaged((IEnumerator<object>)/*Error near IL_045d: Stack underflow*/));
							obj = (object)/*Error near IL_0464: Stack underflow*/;
							obj3 = 27;
							continue;
						case 16:
							((Func<Type, ComWrappers.ComInterfaceEntry[]>)/*Error near IL_0479: Stack underflow*/)._002Ector((object)/*Error near IL_0479: Stack underflow*/, (nint)__KnownINotifyPropertyChangingArgs.StateText);
							ComWrappersSupport.RegisterTypeComInterfaceEntriesLookup((Func<Type, ComWrappers.ComInterfaceEntry[]>)/*Error near IL_047e: Stack underflow*/);
							_ = (string?)/*Error near IL_0484: Stack underflow*/ == (string?)0;
							_ = 2;
							continue;
						case 33:
							goto IL_048e;
						case 26:
							obj = -1;
							__KnownINotifyPropertyChangingArgs.Price = (PropertyChangingEventArgs)(-1);
							obj3 = 11;
							if (__KnownINotifyPropertyChangingArgs.OrderAt == null)
							{
								obj3 = 28;
							}
							continue;
						case 31:
							obj = 1;
							__KnownINotifyPropertyChangingArgs.PayAt = (PropertyChangingEventArgs)1;
							obj3 = 35;
							continue;
						case 24:
							IEnumerable_System_IDisposable.Do_Abi_First_0((nint)__KnownINotifyPropertyChangingArgs.Number, (nint*)IListMethods.AbiToProjectionVftablePtr);
							_ = IEnumerableMethods.AbiToProjectionVftablePtr;
							_ = 40;
							continue;
						case 27:
							if (obj == null)
							{
								obj3 = 34;
								continue;
							}
							goto case 10;
						default:
							goto IL_0522;
						case 6:
							_ = ref obj;
							if ((int)INotifyCollectionChangedMethods.IID != 0)
							{
								_ = 19;
								continue;
							}
							goto case 15;
						case 29:
							_ = __KnownINotifyPropertyChangingArgs.TotalCoins;
							_ = INotifyPropertyChangedMethods.IID;
							obj = (nint)INotifyPropertyChangedMethods.AbiToProjectionVftablePtr;
							_ = 12;
							if (__KnownINotifyPropertyChangingArgs.Quantity != null)
							{
								_ = 41;
							}
							continue;
						case 41:
							_ = ref obj;
							if ((int)IReadOnlyListMethods<INotifyPropertyChanged>.IID != 0)
							{
								_ = 38;
								continue;
							}
							goto case 31;
						case 1:
							_ = __KnownINotifyPropertyChangingArgs.MobileAccounts;
							GlobalVtableLookup.LookupVtableEntries((object)IEnumerableMethods<INotifyPropertyChanged>.IID);
							_ = 1;
							_ = IEnumeratorMethods<INotifyPropertyChanged>.IID;
							_ = 32;
							continue;
						case 10:
							__KnownINotifyPropertyChangingArgs.InputEmail = (PropertyChangingEventArgs)(nint)IEnumeratorMethods<INotifyPropertyChanged>.AbiToProjectionVftablePtr;
							_ = 8;
							if (__KnownINotifyPropertyChangingArgs.Input4399Password == null)
							{
								_ = 9;
							}
							continue;
						case 2:
							_ = __KnownINotifyPropertyChangingArgs.Input163Password;
							_ = IReadOnlyListMethods<IDisposable>.IID;
							_ = IReadOnlyListMethods<IDisposable>.AbiToProjectionVftablePtr;
							_ = 0;
							_ = IEnumerableMethods<IDisposable>.IID;
							_ = 4;
							if (__KnownINotifyPropertyChangingArgs.InfoBarMessage == null)
							{
								_ = 24;
							}
							continue;
						case 21:
						case 25:
							obj = __KnownINotifyPropertyChangingArgs.InfoBarSeverity;
							obj3 = 8;
							continue;
						case 18:
							if (__KnownINotifyPropertyChangingArgs.InfoBarIsOpen == null)
							{
								break;
							}
							obj3 = 13;
							if (__KnownINotifyPropertyChangingArgs.Step != null)
							{
								obj3 = 13;
							}
							continue;
						}
						break;
					}
					goto case 5;
					IL_01ad:
					IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = obj;
					obj = 11;
					goto IL_00ac;
					IL_00ac:
					obj3 = obj;
					goto IL_00b0;
					IL_0522:
					if ((nint)obj != 1)
					{
						obj = 23;
						goto IL_00ac;
					}
					goto IL_048e;
					IL_048e:
					obj = __KnownINotifyPropertyChangingArgs.CanDelete;
					obj3 = 2;
					if (__KnownINotifyPropertyChangingArgs.OrderId == null)
					{
						obj3 = 5;
					}
					goto IL_00b0;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00䄀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778659, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00䈀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778656, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00䌀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00䐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778657, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00䔀()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00䘀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00䜀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778670, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	private object? _webView2;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object ShowTransitions;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object HideTransitions;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object RootScroller;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object WebViewGrid;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object SkinPageControl;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object bindThelper;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object SearchBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object RefreshGame;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object tokenViewLayout;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object RentalGameRefresh;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object LanGameRefresh;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private nint _contentLoaded;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? loadWebView2Command;

	private static object EnableModule;

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand LoadWebView2Command
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_FF00_FF00턀();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe Desktop()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_00ad: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I4
		//IL_0094: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0074: Expected I, but got Obj
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected I, but got Unknown
		//IL_00d0: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0099->IL0042: Incompatible stack heights: 1 vs 2
		//IL_007e->IL0042: Incompatible stack heights: 1 vs 2
		//IL_0123->IL0042: Incompatible stack heights: 4 vs 2
		//IL_00d5->IL0042: Incompatible stack heights: 4 vs 2
		//IL_00fd->IL0042: Incompatible stack heights: 3 vs 2
		//IL_0042->IL0042: Incompatible stack heights: 4 vs 2
		//IL_00a4->IL0042: Incompatible stack heights: 1 vs 2
		//IL_012e->IL0042: Incompatible stack heights: 4 vs 2
		//IL_00e0->IL0042: Incompatible stack heights: 4 vs 2
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		int hRForException = ExceptionHelpers.GetHRForException((Exception)(object)this);
		int num = 5;
		if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
		{
			num = 5;
		}
		object obj = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				((ValueTuple<int, nint>*)/*Error near IL_0074: Stack underflow*/)->_002Ector((int)IEnumerator_object.Do_Abi_MoveNext_2((nint)hRForException, (byte*)(nint)this), unchecked((nint)null));
				_ = 4;
				break;
			case 1:
				obj = new IEnumerator_object((nint)/*Error near IL_0083: Stack underflow*/, (nint*)hRForException);
				_ = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
				{
					_ = 0;
				}
				break;
			case 3:
				return;
			default:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)obj);
				obj = 6;
				break;
			case 5:
				IEnumerator_object.LoadAttribute();
				_ = 1;
				if (IReadOnlyList_object.ReflectLogicalAttribute == null)
				{
					_ = 0;
				}
				break;
			case 6:
				MarshalInterface<INotifyPropertyChanged>.FromAbiArray((object)new IReadOnlyListMethods<INotifyPropertyChanged>((IntPtr)obj, (INotifyPropertyChanged)(object)this, ref *(uint*)(delegate* unmanaged[Stdcall]<nint, uint, nint*, uint>)(&IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0)));
				_ = 2;
				break;
			case 4:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)new MarshalInterface<INotifyPropertyChanged>((INotifyPropertyChanged[])(object)this, (IntPtr)(nint)(delegate* unmanaged[Stdcall]<nint, uint*, uint>)(&IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1)));
				_ = 1;
				if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute == null)
				{
					_ = 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DesktopUnloaded(object sender, object e)
	{
		_FF00_FF00_FF00묀(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ViewModelPropertyChanged(object? sender, object e)
	{
		_FF00_FF00_FF00퀀(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GridViewLoaded(object sender, object e)
	{
		_FF00_FF00_FF00섀(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AutoSuggestBoxQuerySubmitted(object sender, object args)
	{
		_FF00_FF00_FF00씀(sender, args);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGridViewItemClick_003Ed__5))]
	private void GridViewItemClick(object sender, object e)
	{
		_FF00_FF00_FF00윀(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GridLoaded(object sender, object e)
	{
		_FF00_FF00_FF00븀(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoadWebView2_003Ed__8))]
	[RelayCommand]
	private object LoadWebView2()
	{
		return _FF00_FF00_FF00쌀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWebView2Loaded_003Ed__9))]
	private void WebView2Loaded(object sender, object e)
	{
		_FF00_FF00_FF00됀(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SkinCardPointerEntered(object sender, object e)
	{
		_FF00_FF00_FF00렀(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SkinCardPointerExited(object sender, object e)
	{
		_FF00_FF00_FF00쨀(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void AnimateSkinCardScale(object fe, double target, uint durationMs)
	{
		_FF00_FF00_FF00케(fe, target, durationMs);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameCardTapped(object sender, object e)
	{
		_FF00_FF00_FF00봀(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		_FF00_FF00_FF00퐀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	public void Connect(int connectionId, object target)
	{
		_FF00_FF00_FF00준((uint)connectionId, target);
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BuildEvent()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Desktop CheckResponsiveProfile()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00대(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778816, new IntPtr(2737336163692L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00됀(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00a5: Expected I, but got Obj
		//IL_00a5: Expected Obj, but got Ref
		//IL_004c: Expected Obj, but got Ref
		//IL_0051: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got Ref
		//IL_0077: Expected Obj, but got Ref
		//IL_007e: Expected Obj, but got Ref
		//IL_008d: Expected Obj, but got I
		//IL_00b9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00c4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0026: Incompatible stack heights: 3 vs 1
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
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = ExceptionHelpers.GetHRForException((Exception)(&obj));
				obj2 = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					obj2 = 0;
				}
				break;
			case 4:
				_ = ref IList_object._initialized;
				CastExtensions.As<MainContent>((object)(&obj));
				_ = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
				{
					_ = 0;
				}
				break;
			case 1:
				IReadOnlyList_System_IDisposable._initialized = (nint)P_0;
				obj2 = 3;
				if (IReadOnlyList_object._initialized == 0)
				{
					obj2 = 3;
				}
				break;
			case 3:
				IReadOnlyList_object.ReflectLogicalAttribute = -1;
				obj2 = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00딀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778817, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00똀()
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
	private unsafe void _FF00_FF00_FF00뜀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778830, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00렀(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_008e: Expected I, but got F8
		//IL_009d: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		//IL_00a2->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0079->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ad->IL0026: Incompatible stack heights: 3 vs 1
		//IL_005c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
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
				if (obj == null)
				{
					return;
				}
				obj2 = 1;
				if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute != null)
				{
					obj2 = 1;
				}
				break;
			case 3:
				obj = P_0 as ValueType;
				obj2 = 2;
				break;
			case 1:
				IEnumerator_object.Do_Abi_MoveNext_2((nint)1, (byte*)250);
				_ = 0;
				if (IList_object.PatchAttribute == null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00뤀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778831, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00먀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778828, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00묀(object P_0, object P_1)
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
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
		//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 461
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitCall(Call inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2530
		//    at ICSharpCode.Decompiler.IL.Call.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2192
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Default(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 93
		//    at ICSharpCode.Decompiler.IL.ILVisitor`1.VisitCall(Call inst) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 7663
		//    at ICSharpCode.Decompiler.IL.Call.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2188
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
	private unsafe void _FF00_FF00_FF00밀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778829, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00봀(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_004f: Expected I4, but got Obj
		//IL_00bc: Expected I4, but got VT
		//IL_00c7: Expected Obj, but got I4
		//IL_0193: Expected I, but got Obj
		//IL_019a: Expected I, but got Obj
		//IL_0082: Expected I, but got Obj
		//IL_0089: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I
		//IL_0165: Expected I, but got Obj
		//IL_0135: Expected Obj, but got I4
		//IL_013a: Expected I, but got Obj
		//IL_013a: Expected I, but got Obj
		//IL_013f: Expected I4, but got Obj
		//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00dc->IL0026: Incompatible stack heights: 2 vs 1
		//IL_01a9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a2->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0180->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0113->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e7->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ad->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0153->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00f8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_018b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_015e->IL0026: Incompatible stack heights: 2 vs 1
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
				obj = P_0 as IEnumerable_System_ComponentModel_INotifyPropertyChanged;
				obj2 = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 0;
				}
				break;
			case 7:
				MarshalInspectable<object>.FromAbiArray((object)IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_0089: Stack underflow*/, (uint)/*Error near IL_0089: Stack underflow*/, (nint)(int)IEnumerator_object.Do_Abi_MoveNext_2((nint)/*Error near IL_0082: Stack underflow*/, (byte*)(nint)obj), (uint*)(nint)obj));
				_ = 2;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
				{
					_ = 4;
				}
				break;
			case 3:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)(IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)/*Error near IL_00b2: Stack underflow*/) ? 1 : 0), (uint)(int)typeof(Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails).TypeHandle);
				((XamlUserType)1).BoxType<EasingMode>((object)new IReadOnlyList_System_ComponentModel_INotifyPropertyChanged());
				_ = 0;
				if (IEnumerable_System_IDisposable._initialized != 0)
				{
					_ = 0;
				}
				break;
			case 8:
				if (obj == null)
				{
					obj2 = 6;
					break;
				}
				IListMethods<object>.Abi_GetAt_0((IntPtr)/*Error near IL_013f: Stack underflow*/, (uint)(new IListMethods<object, nint>((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_013a: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_013a: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)/*Error near IL_013a: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_013a: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_013a: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_013a: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int>)/*Error near IL_013a: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, int>)/*Error near IL_013a: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)(int)IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)/*Error near IL_0124: Stack underflow*/), (delegate* unmanaged[Stdcall]<IntPtr, int>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.CheckSymbolicAttribute(), (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)obj, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, int>)MarshalInterface<IEnumerator<INotifyPropertyChanged>>.FromManaged((IEnumerator<INotifyPropertyChanged>)IEnumerable_System_ComponentModel_INotifyPropertyChanged.Initialized)) ? 1 : 0));
				_ = 7;
				if (Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute == null)
				{
					_ = 5;
				}
				break;
			case 1:
				if (obj == null)
				{
					obj2 = 5;
					if (IEnumerable_object._initialized == 0)
					{
						obj2 = 0;
					}
					break;
				}
				obj = MarshalInspectable<object>.FromAbi((IntPtr)this) as __KnownINotifyPropertyChangedArgs;
				obj2 = 8;
				if (Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute != null)
				{
					obj2 = 4;
				}
				break;
			case 6:
				return;
			case 5:
				return;
			case 0:
				return;
			case 4:
				IListMethods<object>.Abi_RemoveAtEnd_8((IntPtr)(int)IList_object.Do_Abi_SetAt_4((nint)/*Error near IL_019a: Stack underflow*/, IList_object.Do_Abi_IndexOf_3((nint)/*Error near IL_0193: Stack underflow*/, (nint)/*Error near IL_0193: Stack underflow*/, (uint*)/*Error near IL_0193: Stack underflow*/, (byte*)(nint)obj), (nint)obj));
				obj2 = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00븀(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_0121: Expected Obj, but got I
		//IL_0149: Expected I, but got Obj
		//IL_0059: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I4
		//IL_00a8: Expected I, but got Obj
		//IL_00a8: Expected I, but got Obj
		//IL_0126->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0153->IL0026: Incompatible stack heights: 4 vs 1
		//IL_006d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0131->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00bc->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0078->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c7->IL0026: Incompatible stack heights: 3 vs 1
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
				case 7:
					return;
				case 4:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)this;
					obj2 = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 0;
					}
					break;
				case 5:
					obj = new IEnumerator_object((nint)/*Error near IL_007d: Stack underflow*/, (byte*)/*Error near IL_007d: Stack underflow*/);
					obj2 = 1;
					if (IList_object.PatchAttribute == null)
					{
						obj2 = 4;
					}
					break;
				case 6:
					return;
				case 3:
					IEnumerator_object.Do_Abi_get_HasCurrent_1(unchecked((nint)null), (byte*)unchecked((nint)null));
					_ = 0;
					if (IReadOnlyList_System_IDisposable._initialized != 0)
					{
						_ = 1;
					}
					break;
				case 2:
					if (IReadOnlyList_object.ReflectLogicalAttribute == null)
					{
						return;
					}
					goto end_IL_0026;
				default:
					IEnumerator_System_IDisposable.ReflectTransferableAttribute = ((P_0 is NavigationViewItemPresenter) ? P_0 : null);
					obj2 = 2;
					if (IEnumerable_System_IDisposable.CombineAttribute == null)
					{
						obj2 = 2;
					}
					break;
				case 1:
					_ = IEnumerable_object._initialized;
					IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0(new IEnumerableMethods<INotifyPropertyChanged, nint>((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(delegate*<bool>)(&IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.MoveAttribute)) ? ((IntPtr)1) : ((IntPtr)0));
					_ = 7;
					break;
				}
				continue;
				end_IL_0026:
				break;
			}
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00뼀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00쀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778826, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00섀(object P_0, object P_1)
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
	private unsafe void _FF00_FF00_FF00숀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778827, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00쌀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18266, 1790778824, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778824, new IntPtr(2737336193852L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00쐀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778825, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00씀(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_007f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005d->IL0026: Incompatible stack heights: 4 vs 1
		//IL_009b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0068->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00a6->IL0026: Incompatible stack types: I4 vs Obj
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
			case 1:
				return;
			case 3:
				/*Error near IL_006e: Stack underflow*/((object[])/*Error near IL_006e: Stack underflow*/, (nint)this);
				obj = /*Error near IL_0073: Stack underflow*/as IReadOnlyList_object;
				obj2 = 2;
				break;
			case 0:
				return;
			case 2:
				if (obj != null)
				{
					_003CModule_003E.CheckAccessibleAttribute();
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						_ = 0;
					}
				}
				else
				{
					obj2 = 1;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 0;
					}
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00였(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778838, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00윀(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0094: Expected I, but got Obj
		//IL_0094: Expected Obj, but got Ref
		//IL_004f: Expected Obj, but got Ref
		//IL_0056: Expected Obj, but got Ref
		//IL_0065: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got Ref
		//IL_00b8: Expected I, but got Obj
		//IL_00b8: Expected Obj, but got Ref
		//IL_009e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006a->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00b0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0075->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00d7->IL0026: Incompatible stack types: I4 vs Obj
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
			case 2:
				_ = ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
				CastExtensions.As<Frame>((object)(&obj));
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 1;
				}
				break;
			case 5:
				*((int, nint)*)(nint)/*Error near IL_007c: Stack underflow*/ = ((int)/*Error near IL_007c: Stack underflow*/, (nint)(&obj));
				IList_object.PatchAttribute = (object)/*Error near IL_0081: Stack underflow*/;
				obj2 = 4;
				break;
			case 1:
				return;
			default:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_1;
				obj2 = 3;
				break;
			case 3:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute = -1;
				obj2 = 2;
				break;
			case 4:
				IReadOnlyList_System_IDisposable._initialized = (nint)this;
				obj2 = 0;
				if (IReadOnlyList_object._initialized != 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00저(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778839, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00준(uint P_0, object P_1)
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
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.TranslateTarget(ILInstruction target, Boolean nonVirtualInvocation, Boolean memberStatic, IType memberDeclaringType, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2936
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 437
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitCallVirt(CallVirt inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2535
		//    at ICSharpCode.Decompiler.IL.CallVirt.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2215
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Default(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 93
		//    at ICSharpCode.Decompiler.IL.ILVisitor`1.VisitCallVirt(CallVirt inst) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 7667
		//    at ICSharpCode.Decompiler.IL.CallVirt.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2211
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 307
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
	private unsafe void _FF00_FF00_FF00쨀(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_0091->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006a->IL0026: Incompatible stack heights: 5 vs 1
		//IL_00ad->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0075->IL0026: Incompatible stack heights: 5 vs 1
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
			case 3:
				_ = 1.0;
				_ = 350;
				_003CModule_003E.CheckAccessibleAttribute();
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				obj = ((P_0 is UserControl) ? P_0 : null);
				obj2 = 1;
				if (IList_object.PatchAttribute == null)
				{
					obj2 = 0;
				}
				break;
			case 1:
				if (obj == null)
				{
					return;
				}
				obj2 = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00쬀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778836, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void _FF00_FF00_FF00츀(object P_0, double P_1, uint P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778837, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void _FF00_FF00_FF00케(object P_0, double P_1, uint P_2)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0053: Expected I4, but got Obj
		//IL_01fd: Expected I, but got F8
		//IL_01fd: Expected I, but got Obj
		//IL_01fd: Expected I, but got Obj
		//IL_020c: Expected I4, but got F8
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected I, but got Unknown
		//IL_0066: Expected Obj, but got I4
		//IL_016a: Expected I, but got Obj
		//IL_01c5: Expected I, but got F8
		//IL_01c5: Expected I, but got F8
		//IL_01c5: Expected I, but got Obj
		//IL_01ca: Expected I, but got Obj
		//IL_018c: Expected Ref, but got F8
		//IL_018e: Expected Obj, but got I4
		//IL_019d: Expected Obj, but got VT
		//IL_00b6: Expected I4, but got Obj
		//IL_00bd: Expected I, but got F8
		//IL_00c2: Expected I, but got Obj
		//IL_00c2: Expected I, but got Obj
		//IL_00c2: Expected I, but got Obj
		//IL_00ca: Expected I4, but got Obj
		//IL_00d7: Expected I, but got Obj
		//IL_00de: Expected I, but got Obj
		//IL_00e0: Expected Obj, but got I4
		//IL_00f0: Expected I, but got Obj
		//IL_00f0: Expected I, but got Obj
		//IL_0101: Expected I, but got F8
		//IL_0106: Expected I, but got Obj
		//IL_0113: Expected I, but got Obj
		//IL_0113: Expected I, but got Obj
		//IL_0113: Expected I, but got Obj
		//IL_0113: Expected I, but got Obj
		//IL_011b: Expected I4, but got Obj
		//IL_013f: Expected Obj, but got I4
		//IL_013f: Expected I, but got Obj
		//IL_0146: Expected I4, but got Obj
		//IL_0146: Expected I, but got Obj
		//IL_0222->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0070->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0174->IL0026: Incompatible stack heights: 2 vs 1
		//IL_01de->IL0026: Incompatible stack heights: 2 vs 1
		//IL_01a2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0162->IL0026: Incompatible stack types: I4 vs Obj
		//IL_022d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_01e9->IL0026: Incompatible stack heights: 2 vs 1
		//IL_01ad->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0185->IL0026: Incompatible stack types: I4 vs Obj
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
			case 1:
				obj = IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)new ExceptionHelpers((Exception)/*Error near IL_005d: Stack underflow*/), ref *(object[]*)null);
				_ = 7;
				continue;
			case 8:
				return;
			case 3:
				/*Error near IL_0072: Member reference must be method, but was: Field*/;
			case 7:
			{
				MarshalInspectable<object> val = (MarshalInspectable<object>)(nint)new MarshalInspectable<object>((object)/*Error near IL_00b6: Stack underflow*/, (byte)(int)new IEnumeratorMethods<object>((IntPtr)/*Error near IL_00b1: Stack underflow*/) != 0);
				bool flag = IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00c2: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)val, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)val, new IEnumeratorMethods<object>((IntPtr)P_1) ? ((delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)1) : ((delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)null));
				IntPtr intPtr = MarshalInterface<INotifyPropertyChanged>.FromManaged(IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)(flag ? 1 : 0), (uint)(int)obj));
				INotifyPropertyChanged notifyPropertyChanged = MarshalInterface<INotifyPropertyChanged>.FromAbi((IntPtr)obj);
				obj = IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)notifyPropertyChanged, notifyPropertyChanged, ref *(uint*)1);
				MarshalInterface<INotifyPropertyChanged>.CopyManagedArray((INotifyPropertyChanged[])obj, (IntPtr)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)MarshalInterface<INotifyPropertyChanged>.FromAbiArray(obj), (uint*)(nint)obj));
				IReadOnlyListMethods<INotifyPropertyChanged> val2 = (IReadOnlyListMethods<INotifyPropertyChanged>)new IReadOnlyListMethods<INotifyPropertyChanged>(intPtr);
				IEnumerator<INotifyPropertyChanged> enumerator = IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0(new IEnumerableMethods<INotifyPropertyChanged, nint>((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)P_1) ? ((IntPtr)1) : ((IntPtr)0));
				bool flag2 = IListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0113: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_0113: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)/*Error near IL_0113: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_0113: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_0113: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)(flag ? 1 : 0), (delegate* unmanaged[Stdcall]<IntPtr, uint, int>)intPtr, (delegate* unmanaged[Stdcall]<IntPtr, nint, int>)val2, (delegate* unmanaged[Stdcall]<IntPtr, int>)val2, (delegate* unmanaged[Stdcall]<IntPtr, int>)enumerator, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)enumerator, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, int>)MarshalInterface<IEnumerator<INotifyPropertyChanged>>.FromManaged((IEnumerator<INotifyPropertyChanged>)obj));
				object obj3 = IListMethods<object>.Abi_GetAt_0((IntPtr)(flag2 ? 1 : 0), (uint)(int)obj);
				obj = IListMethods<object>.Abi_GetView_2((IntPtr)1);
				object obj4 = obj;
				bool flag3 = IListMethods<object>.Abi_IndexOf_3(MarshalInterface<IReadOnlyList<object>>.FromManaged((IReadOnlyList<object>)obj), obj, ref *(IList_object.Initialized ? ((uint*)1) : ((uint*)null)));
				IListMethods<object>.Abi_SetAt_4((IntPtr)obj4, flag3 ? 1u : 0u, (object)flag3);
				IListMethods<object>.Abi_InsertAt_5((IntPtr)obj3, (uint)(int)obj3, obj);
				IListMethods<object>.Abi_RemoveAt_6((IntPtr)(flag2 ? 1 : 0), flag2 ? 1u : 0u);
				IListMethods<object>.Abi_Append_7((IntPtr)/*Error near IL_0153: Stack underflow*/, obj);
				IListMethods<object>.Abi_RemoveAtEnd_8((IntPtr)/*Error near IL_0158: Stack underflow*/);
				obj2 = 8;
				continue;
			}
			case 2:
				IListMethods<object>.Abi_Clear_9((IntPtr)obj);
				_ = 5;
				continue;
			case 9:
				if (obj != null)
				{
					obj2 = 6;
					continue;
				}
				break;
			case 5:
			case 6:
				obj = IListMethods<object>.Abi_GetMany_10((IntPtr)/*Error near IL_018c: Stack underflow*/, (uint)/*Error near IL_018c: Stack underflow*/, ref *(object[]*)(double)(int)P_2);
				obj2 = 1;
				if (!_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout)
				{
					obj2 = 1;
				}
				continue;
			case 4:
				IEnumeratorMethods<INotifyPropertyChanged>.Abi_MoveNext_2(new IEnumeratorMethods<INotifyPropertyChanged, nint>((delegate* unmanaged[Stdcall]<IntPtr, nint*, int>)/*Error near IL_01c5: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)P_0, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)0.5, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, uint*, int>)0.5) ? ((IntPtr)1) : ((IntPtr)0));
				_ = 1;
				if (__KnownINotifyPropertyChangingArgs.Username == null)
				{
					_ = 3;
				}
				continue;
			}
			IEnumeratorMethods<INotifyPropertyChanged> val3 = (IEnumeratorMethods<INotifyPropertyChanged>)new IEnumeratorMethods<INotifyPropertyChanged>((IntPtr)/*Error near IL_01ee: Stack underflow*/);
			obj = IReadOnlyListMethods<IDisposable>.Abi_GetAt_0((IntPtr)(IReadOnlyListMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_01fd: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)val3, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)val3, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)1.0) ? 1 : 0), 1u);
			_ = 2;
			if (__KnownINotifyPropertyChangingArgs.Message == null)
			{
				_ = 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00퀀(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_007c: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I4
		//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0138->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0105->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0110->IL0026: Incompatible stack heights: 3 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
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
			case 4:
				return;
			case 7:
				ExceptionHelpers.GetHRForException((Exception)P_1);
				_ = IEnumerator_object.Initialized;
				/*Error near IL_005c: Member reference must be method, but was: Field*/;
			case 0:
				return;
			case 3:
				obj = IEnumerator_object.Do_Abi_MoveNext_2((nint)/*Error near IL_007c: Stack underflow*/, (byte*)(nint)obj) == 5;
				obj2 = 2;
				break;
			case 6:
				return;
			case 5:
				if (obj == null)
				{
					return;
				}
				obj2 = 3;
				break;
			case 2:
				_ = IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute;
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)((obj != null) ? 1 : 2));
				_ = 1;
				if (IReadOnlyList_object._initialized != 0)
				{
					_ = 0;
				}
				break;
			case 1:
				_ = IReadOnlyList_object.ReflectLogicalAttribute;
				MarshalInterface<INotifyPropertyChanged>.FromAbi((IntPtr)((obj != null) ? 2 : 0));
				_ = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00턀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18280, 1790778834, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778834, new IntPtr(2737336190732L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00툀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778835, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00퐀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00dd: Expected I, but got Obj
		//IL_0087: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I4
		//IL_00f1->IL0026: Incompatible stack heights: 3 vs 1
		//IL_008c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fc->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00d4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0097->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c1->IL0026: Incompatible stack types: I4 vs Obj
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
			case 4:
				obj = new Action<object[], nint>((object[])/*Error near IL_0076: Stack underflow*/, (nint)(int)IEnumerator_object.Init());
				obj2 = 0;
				if (IList_object.PatchAttribute == null)
				{
					obj2 = 0;
				}
				break;
			case 2:
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					return;
				}
				obj2 = 1;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					obj2 = 1;
				}
				break;
			case 3:
				return;
			case 5:
				return;
			case 1:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = 1;
				obj2 = 4;
				break;
			default:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)obj, 0u);
				_ = 3;
				if (IEnumerator_System_IDisposable._initialized == 0)
				{
					_ = 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00픀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778832, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
