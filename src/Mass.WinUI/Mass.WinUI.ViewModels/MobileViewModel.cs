using System;
using System.CodeDom.Compiler;
using System.Collections;
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
using ABI.System;
using ABI.System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.WinUI.Animations;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Mobile.Entities.NetGame;
using Mass.Domain.Mobile.Entities.RentalGame;
using Mass.Domain.Value;
using Mass.WinUI.Controls;
using Mass.WinUI.Mass_WinUI_XamlTypeInfo;
using Mass.WinUI.Models;
using Mass.WinUI.Models.Messages;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Media.Animation;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
using WinRT.Mass_WinUIVtableClasses;
using WinUI.TableView;
using Windows.Foundation;
using Windows.Storage;

namespace Mass.WinUI.ViewModels;

[WinRTExposedType(typeof(Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
public class MobileViewModel : ObservableObject
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLaunchGame_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MobileViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object DecorateAdvancedVerifier;

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
		internal static bool ReflectConvertibleAnnotation()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckMixedComparator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00ࠀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778517, new IntPtr(2737336155372L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_0900()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_03de: Expected Obj, but got I4
			//IL_03de: Expected Obj, but got Ref
			//IL_039c: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I
			//IL_03c3: Expected Obj, but got Ref
			//IL_03d1: Expected Obj, but got I4
			//IL_0239: Expected Obj, but got Ref
			//IL_0170: Expected I, but got Obj
			//IL_0170: Expected I, but got Obj
			//IL_0172: Expected Obj, but got I4
			//IL_0281: Expected Obj, but got Ref
			//IL_00f0: Expected Obj, but got I4
			//IL_00f5: Expected Obj, but got I4
			//IL_00f5: Expected Obj, but got Ref
			//IL_01d2: Expected Obj, but got I4
			//IL_01d7: Expected Obj, but got Ref
			//IL_0116: Expected Obj, but got Ref
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Expected Obj, but got I4
			//IL_0229: Expected Obj, but got Ref
			//IL_0264: Expected I, but got Obj
			//IL_0270: Expected I, but got Obj
			//IL_0270: Expected I, but got Obj
			//IL_0182: Expected Obj, but got Ref
			//IL_018a: Expected Obj, but got Ref
			//IL_018a: Expected Obj, but got Ref
			//IL_0199: Expected Obj, but got I
			//IL_0297: Expected I, but got Obj
			//IL_02ef: Expected Obj, but got I4
			//IL_00e6: Expected Obj, but got I4
			//IL_00c2: Expected I4, but got Obj
			//IL_03f2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03b2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03d6->IL0022: Incompatible stack heights: 1 vs 0
			//IL_03fd->IL0026: Incompatible stack types: I4 vs Obj
			//IL_024f->IL0071: Incompatible stack types: I4 vs Obj
			//IL_006d->IL0071: Incompatible stack types: I4 vs Obj
			//IL_03bd->IL0026: Incompatible stack types: I4 vs Obj
			//IL_025a->IL0071: Incompatible stack types: I4 vs Obj
			//IL_0202->IL0139: Incompatible stack heights: 1 vs 0
			//IL_017c->IL0071: Incompatible stack types: I4 vs Obj
			//IL_00ff->IL0071: Incompatible stack types: I4 vs Obj
			//IL_01eb->IL0071: Incompatible stack types: I4 vs Obj
			//IL_0233->IL0071: Incompatible stack types: I4 vs Obj
			//IL_027a->IL0071: Incompatible stack heights: 2 vs 1
			//IL_019e->IL0071: Incompatible stack heights: 3 vs 1
			//IL_0216->IL0071: Incompatible stack heights: 2 vs 1
			//IL_0290->IL0071: Incompatible stack types: I4 vs Obj
			//IL_01f6->IL0071: Incompatible stack types: I4 vs Obj
			//IL_01a9->IL0071: Incompatible stack heights: 3 vs 1
			//IL_02ad->IL0071: Incompatible stack types: I4 vs Obj
			//IL_0221->IL0071: Incompatible stack heights: 2 vs 1
			//IL_02c3->IL02da: Incompatible stack heights: 2 vs 3
			//IL_02df->IL02df: Incompatible stack heights: 0 vs 1
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
					object obj3;
					switch ((int)obj2)
					{
					case 3:
						obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
						obj2 = 2;
						continue;
					case 4:
						return;
					case 1:
						if (obj != null)
						{
							obj3 = 2;
							goto IL_0071;
						}
						goto IL_0233;
					case 2:
						obj = __KnownINotifyPropertyChangingArgs.IsSkeleton;
						obj2 = 1;
						if (__KnownINotifyPropertyChangingArgs.ShowMaxPlayer == null)
						{
							obj2 = 0;
						}
						continue;
					case 5:
						goto end_IL_0026;
						IL_0071:
						while (true)
						{
							switch ((int)obj3)
							{
							case 1:
								return;
							case 13:
								if (obj == null)
								{
									obj = 15;
									goto IL_006d;
								}
								goto case 4;
							case 7:
								obj = 0;
								IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = 0;
								obj3 = 12;
								continue;
							default:
								_ = ref obj;
								/*Error near IL_0101: Member reference must be method, but was: Field*/;
							case 11:
								IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute = (object)default(Window);
								obj = 8;
								goto IL_006d;
							case 4:
							{
								object obj4 = obj;
								IEnumerator_object._002Ecctor();
								obj = IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0170: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)obj4, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)obj, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(IEnumerator_object.DecorateAutomatableAttribute() ? 1 : 0));
								obj3 = 6;
								continue;
							}
							case 16:
								_ = ref IReadOnlyList_object._initialized;
								((XamlUserType)(&obj)).BoxType<SortDirection>((object)Unsafe.AsPointer(ref this));
								_ = 0;
								if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
								{
									_ = 1;
								}
								continue;
							case 8:
								obj = -1;
								IEnumerable_object._initialized = -1;
								obj3 = 0;
								if (GlobalVtableLookup.CreateAttribute == null)
								{
									obj3 = 0;
								}
								continue;
							case 2:
								if (!IEnumerable_System_ComponentModel_INotifyPropertyChanged.Initialized)
								{
									goto end_IL_0026_2;
								}
								_ = 14;
								if (Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute == null)
								{
									_ = 8;
								}
								continue;
							case 12:
								Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute = obj;
								obj3 = 16;
								continue;
							case 17:
								break;
							case 15:
								IList_object.Do_Abi_IndexOf_3((nint)/*Error near IL_0270: Stack underflow*/, (nint)(int)IList_object.Do_Abi_GetView_2((nint)/*Error near IL_0269: Stack underflow*/, (nint*)(int)IList_object.Do_Abi_GetAt_0((nint)/*Error near IL_0264: Stack underflow*/, (uint)/*Error near IL_0264: Stack underflow*/, (nint*)(nint)Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute)), (uint*)unchecked((nint)null), (byte*)unchecked((nint)null));
								_ = 3;
								continue;
							case 6:
								IListMethods<object>.Abi_Append_7((IntPtr)/*Error near IL_0281: Stack underflow*/, (object)(&obj));
								if ((int)/*Error near IL_0286: Stack underflow*/ == 0)
								{
									obj3 = 7;
									continue;
								}
								goto default;
							case 14:
							case 18:
							{
								uint num = IList_object.Do_Abi_InsertAt_5((nint)/*Error near IL_0297: Stack underflow*/, (uint)/*Error near IL_0297: Stack underflow*/, (nint)obj);
								if (num == 0)
								{
									obj3 = 5;
									continue;
								}
								object checkOperationalModule;
								object val;
								if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute == null)
								{
									checkOperationalModule = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule;
									val = (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator = new IListMethods<object>((IntPtr)(nint)(delegate* unmanaged[Stdcall]<nint, uint>)(&IList_object.Do_Abi_RemoveAtEnd_8)));
								}
								((AsyncTaskMethodBuilder*)num)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<ContentDialogResult>*)checkOperationalModule, ref *(AccountViewModel._003CCreateAccount_003Ed__21*)val);
								goto IL_02df;
							}
							case 5:
								goto IL_02df;
							case 3:
							case 9:
							case 10:
								goto end_IL_0026_2;
								IL_006d:
								obj3 = obj;
								continue;
								IL_02df:
								obj = null as IDisposable;
								obj = 13;
								goto IL_006d;
							}
							break;
						}
						goto IL_0233;
						IL_0233:
						obj = Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute;
						obj3 = 4;
						if (Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute == null)
						{
							obj3 = 11;
						}
						goto IL_0071;
						end_IL_0026_2:
						break;
					}
					__KnownINotifyPropertyChangingArgs.Author = (PropertyChangingEventArgs)(-2);
					obj2 = 5;
					if (__KnownINotifyPropertyChangingArgs.Version == null)
					{
						obj2 = 2;
					}
					continue;
					end_IL_0026:
					break;
				}
				IReadOnlyListMethods<object>.Abi_IndexOf_2((IntPtr)/*Error near IL_03c8: Stack underflow*/, (object)/*Error near IL_03c8: Stack underflow*/, ref Unsafe.As<PropertyChangingEventArgs, uint>(ref __KnownINotifyPropertyChangingArgs.OnlinePlayers));
				obj = 4;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_0A00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778514, new IntPtr(2737336155372L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_0B00()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_0C00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778515, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_0D00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778512, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_0E00()
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00ༀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778513, new IntPtr(2737336168892L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00က(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00ᄀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778526, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRefreshNetGames_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MobileViewModel _003C_003E4__this;

		private TaskAwaiter<EntityNetGameItem[]> _003C_003Eu__1;

		internal static object CheckFlexibleBridge;

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
		internal static bool DecorateSegmentedCommand()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectCommonConsumer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00Ā()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778527, new IntPtr(2737336168892L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00Ȁ()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0087: Expected Obj, but got Ref
			//IL_008c: Expected Obj, but got Ref
			//IL_009b: Expected Obj, but got I
			//IL_00b1: Expected Obj, but got Ref
			//IL_00b3: Expected Obj, but got I
			//IL_0075: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got Ref
			//IL_0159: Expected I, but got Obj
			//IL_0160: Expected Obj, but got I4
			//IL_03ca: Expected Obj, but got Ref
			//IL_058f: Expected Obj, but got I
			//IL_0594: Expected I4, but got Obj
			//IL_0596: Expected Obj, but got I4
			//IL_059f: Expected Obj, but got I4
			//IL_041c: Expected Obj, but got Ref
			//IL_02bf: Expected I, but got Obj
			//IL_0266: Expected Obj, but got Ref
			//IL_037b: Expected Obj, but got I4
			//IL_0380: Expected Obj, but got I4
			//IL_0380: Expected Obj, but got Ref
			//IL_0325: Expected Obj, but got I4
			//IL_032a: Expected Obj, but got I4
			//IL_032a: Expected Obj, but got Ref
			//IL_02eb: Expected Obj, but got Ref
			//IL_0311: Expected Obj, but got Ref
			//IL_034f: Expected Obj, but got Ref
			//IL_0292: Expected I4, but got Obj
			//IL_02a8: Expected Obj, but got VT
			//IL_03b0: Expected I, but got Obj
			//IL_044a: Expected Obj, but got VT
			//IL_0438: Expected Obj, but got I
			//IL_0433: Unknown result type (might be due to invalid IL or missing references)
			//IL_0438: Unknown result type (might be due to invalid IL or missing references)
			//IL_043e: Expected Obj, but got Unknown
			//IL_00a0->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00bd->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0081->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ab->IL0026: Incompatible stack heights: 2 vs 1
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0152->IL00e8: Incompatible stack heights: 3 vs 1
			//IL_016a->IL00e8: Incompatible stack heights: 2 vs 1
			//IL_01cc->IL00e8: Incompatible stack heights: 2 vs 1
			//IL_01e8->IL00e8: Incompatible stack heights: 4 vs 1
			//IL_0573->IL058a: Incompatible stack heights: 4 vs 6
			//IL_01f3->IL00e8: Incompatible stack heights: 4 vs 1
			//IL_02d8->IL021e: Incompatible stack heights: 2 vs 1
			//IL_00e8->IL00e8: Incompatible stack heights: 4 vs 1
			//IL_043e->IL043e: Incompatible stack heights: 3 vs 2
			//IL_02e3->IL021e: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 4;
			object obj = awaiter;
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				case 5:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = -2;
					obj = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj = 0;
					}
					break;
				case 4:
					awaiter = IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute;
					obj = 3;
					break;
				default:
					MarshalInspectable<object>.FromAbiArray((object)Unsafe.AsPointer(ref IList_object._initialized));
					_ = 1;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
					{
						_ = 1;
					}
					break;
				case 3:
					awaiter = IReadOnlyList_System_IDisposable._initialized;
					obj = 2;
					break;
				case 2:
					if (awaiter != null)
					{
						num = 1;
						if (IReadOnlyList_object._initialized == 0)
						{
							num = 3;
						}
						goto IL_00e8;
					}
					goto IL_016a;
				case 1:
					return;
					IL_016a:
					num = 1;
					if (IEnumerable_object._initialized == 0)
					{
						num = 1;
					}
					goto IL_00e8;
					IL_00e8:
					while (true)
					{
						int num2;
						switch (num)
						{
						case 2:
						case 9:
							break;
						case 6:
							MarshalInterface<INotifyPropertyChanged>.FromAbi((IntPtr)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init());
							_ = 10;
							continue;
						case 7:
							((XamlUserType)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_IndexOf_2((nint)/*Error near IL_0159: Stack underflow*/, (nint)/*Error near IL_0159: Stack underflow*/, (uint*)/*Error near IL_0159: Stack underflow*/, (byte*)(nint)awaiter)).BoxType<EasingType>(awaiter);
							_ = 6;
							continue;
						default:
							goto IL_016a;
						case 3:
							if (!IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.MoveAttribute())
							{
								break;
							}
							num = 3;
							if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute == null)
							{
								num = 5;
							}
							continue;
						case 5:
						case 8:
							IListMethods<object>.Abi_GetAt_0((IntPtr)/*Error near IL_01c2: Stack underflow*/, IEnumerable_System_ComponentModel_INotifyPropertyChanged.Do_Abi_First_0((nint)/*Error near IL_01bd: Stack underflow*/, (nint*)(int)IEnumerable_System_ComponentModel_INotifyPropertyChanged.Init()));
							_ = 4;
							continue;
						case 10:
							_ = 0;
							IEnumerable_System_ComponentModel_INotifyPropertyChanged.DecorateSeparatedAttribute();
							_ = 0;
							if (Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute == null)
							{
								_ = 0;
							}
							continue;
						case 1:
							if (awaiter != null)
							{
								num2 = 4;
								if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute != null)
								{
									num2 = 2;
								}
								goto IL_021e;
							}
							goto IL_03c4;
						case 4:
							{
								_ = 0;
								_ = 6;
								_ = IDisposableMethods.IID;
								PropertyChangingEventArgs input4399Password;
								PropertyChangingEventArgs predicate;
								if (__KnownINotifyPropertyChangingArgs.InputCookie == null)
								{
									input4399Password = __KnownINotifyPropertyChangingArgs.Input4399Password;
									predicate = (__KnownINotifyPropertyChangingArgs.InputMobile = (PropertyChangingEventArgs)new IReadOnlyListMethods<IDisposable>());
								}
								awaiter = ((IEnumerable<EnumGameVersion>)input4399Password).Contains((EnumGameVersion)(int)((IEnumerable<DesktopGameModel>)(delegate*<bool>)(&Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.DecorateGeneralAttribute)).FirstOrDefault((Func<DesktopGameModel, bool>)(object)predicate));
								awaiter = 7;
								continue;
							}
							IL_03c4:
							awaiter = __KnownINotifyPropertyChangingArgs.IsLiked;
							num2 = 3;
							if (__KnownINotifyPropertyChangingArgs.PreviewImage != null)
							{
								num2 = 2;
							}
							goto IL_021e;
							IL_021e:
							while (true)
							{
								switch (num2)
								{
								case 2:
									break;
								case 3:
									Unsafe.As<object, ReadOnlySpan<char>>(ref Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute) = default;
									num2 = 3;
									if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance == null)
									{
										num2 = 7;
									}
									continue;
								case 11:
									((AsyncTaskMethodBuilder*)IList_object.Do_Abi_RemoveAt_6((nint)/*Error near IL_0292: Stack underflow*/, (uint)(int)awaiter))->Start(ref *(AccountViewModel._003CLoginRandom_003Ed__85*)awaiter);
									num2 = 0;
									if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout)
									{
										num2 = 1;
									}
									continue;
								case 1:
									IEnumeratorMethods<INotifyPropertyChanged>.Abi_MoveNext_2((IntPtr)(int)IList_object.Do_Abi_GetMany_10((nint)/*Error near IL_02bf: Stack underflow*/, (uint)/*Error near IL_02bf: Stack underflow*/, (uint)/*Error near IL_02bf: Stack underflow*/, (nint)/*Error near IL_02bf: Stack underflow*/, (uint*)(nint)awaiter));
									_ = 3;
									if (__KnownINotifyPropertyChangingArgs.Username == null)
									{
										_ = 13;
									}
									continue;
								case 8:
									__KnownINotifyPropertyChangingArgs.CreateAt = (PropertyChangingEventArgs)awaiter;
									num2 = 1;
									if (__KnownINotifyPropertyChangingArgs.Name == null)
									{
										num2 = 10;
									}
									continue;
								case 9:
									if (MarshalInterface<IDisposable>.FromManaged((IDisposable)(&awaiter)) == (IntPtr)0)
									{
										num2 = 6;
										continue;
									}
									goto default;
								case 7:
									awaiter = -1;
									__KnownINotifyPropertyChangingArgs.Message = (PropertyChangingEventArgs)(-1);
									num2 = 0;
									if (__KnownINotifyPropertyChangingArgs.Content == null)
									{
										num2 = 0;
									}
									continue;
								case 10:
									Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.IsSelected).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<string>*)(&awaiter), ref Unsafe.As<_003CRefreshNetGames_003Ed__17, AccountViewModel._003CLoginDesktop_003Ed__87>(ref this));
									num2 = 12;
									if (__KnownINotifyPropertyChangingArgs.ShowMaxPlayer != null)
									{
										num2 = 5;
									}
									continue;
								case 6:
									awaiter = 0;
									__KnownINotifyPropertyChangingArgs.OnlinePlayers = (PropertyChangingEventArgs)0;
									num2 = 7;
									if (__KnownINotifyPropertyChangingArgs.Author != null)
									{
										num2 = 8;
									}
									continue;
								case 13:
									((AsyncTaskMethodBuilder*)/*Error near IL_03ba: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<string>*)/*Error near IL_03ba: Stack underflow*/, ref *(AccountViewModel._003CRegisterRandom4399_003Ed__84*)IEnumeratorMethods<IDisposable>.Abi_GetMany_3((IntPtr)/*Error near IL_03b5: Stack underflow*/, ref *(IDisposable[]*)IReadOnlyList_System_IDisposable.Do_Abi_get_Size_1((nint)(int)IReadOnlyList_System_IDisposable.Do_Abi_GetMany_3((nint)/*Error near IL_03a9: Stack underflow*/, (uint)/*Error near IL_03a9: Stack underflow*/, (uint)/*Error near IL_03a9: Stack underflow*/, (nint)/*Error near IL_03a9: Stack underflow*/, (uint*)(int)IReadOnlyList_System_IDisposable.Do_Abi_IndexOf_2((nint)/*Error near IL_03a4: Stack underflow*/, (nint)/*Error near IL_03a4: Stack underflow*/, (uint*)/*Error near IL_03a4: Stack underflow*/, (byte*)/*Error near IL_03a4: Stack underflow*/)), (uint*)(nint)awaiter)));
									num2 = 2;
									continue;
								case 5:
									goto IL_03c4;
								case 4:
									awaiter = IEnumerableMethods<object>.Abi_First_0((IntPtr)(IEnumerableMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(int)IReadOnlyList_object.Do_Abi_GetAt_0((nint)/*Error near IL_03f0: Stack underflow*/, (uint)/*Error near IL_03f0: Stack underflow*/, (nint*)/*Error near IL_03f0: Stack underflow*/)) ? 1 : 0));
									num2 = 9;
									continue;
								case 12:
									return;
								default:
								{
									IntPtr intPtr = MarshalInterface<IEnumerator<object>>.FromManaged((IEnumerator<object>)(&awaiter));
									PropertyChangingEventArgs state = __KnownINotifyPropertyChangingArgs.State;
									if (state == null)
									{
										_ = __KnownINotifyPropertyChangingArgs.StateText;
										__KnownINotifyPropertyChangingArgs.Type = (PropertyChangingEventArgs)new ComWrappersSupport((Func<Type, ComWrappers.ComInterfaceEntry[]>)(delegate*<IReadOnlyList_object>)(&IReadOnlyList_object.DecorateControllableAttribute));
									}
									((AsyncTaskMethodBuilder*)/*Error near IL_0443: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<StorageFile>*)intPtr, ref *(ImportAccountViewModel._003CSelectFile_003Ed__45*)state);
									awaiter = WindowsRuntimeSystemExtensions.GetAwaiter<StorageFile>((IAsyncOperation<StorageFile>)/*Error near IL_0448: Stack underflow*/);
									num2 = 11;
									if (__KnownINotifyPropertyChangingArgs.Price == null)
									{
										num2 = 0;
									}
									continue;
								}
								}
								break;
							}
							break;
						}
						break;
					}
					goto case 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_0300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778524, new IntPtr(2737336154332L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00Ѐ()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00Ԁ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778525, new IntPtr(2737336182412L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_0600()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_0700(object P_0)
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
	private struct _003CRefreshRentalGames_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MobileViewModel _003C_003E4__this;

		private TaskAwaiter<EntityRentalGameItem[]> _003C_003Eu__1;

		internal static object CheckAdaptableStrategy;

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
		internal static bool DecoratePortableSorter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckBasicConfig()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_F300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778522, new IntPtr(2737336177212L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_F400()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0075: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got Ref
			//IL_009f: Expected Obj, but got Ref
			//IL_07b2: Expected Obj, but got Ref
			//IL_00c4: Expected Obj, but got I
			//IL_0675: Expected Obj, but got I4
			//IL_067e: Expected Obj, but got I4
			//IL_02ff: Expected Obj, but got Ref
			//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c7: Expected Obj, but got Unknown
			//IL_06cc: Expected Ref, but got Unknown
			//IL_06d1: Expected Ref, but got VT
			//IL_0206: Expected Obj, but got I4
			//IL_020b: Expected Obj, but got I4
			//IL_0295: Expected Obj, but got I4
			//IL_01e2: Expected Obj, but got Ref
			//IL_0446: Expected I, but got Obj
			//IL_03fe: Expected Obj, but got I4
			//IL_0403: Expected Obj, but got I4
			//IL_0403: Expected Obj, but got Ref
			//IL_03d2: Expected Obj, but got Ref
			//IL_042b: Expected Obj, but got I4
			//IL_02d5: Expected Obj, but got Ref
			//IL_045f: Expected Obj, but got I4
			//IL_0464: Expected Obj, but got I4
			//IL_0464: Expected Obj, but got Ref
			//IL_0385: Expected I, but got Obj
			//IL_02c0: Expected I, but got Obj
			//IL_02c5: Expected Obj, but got I4
			//IL_02e6: Expected Obj, but got I4
			//IL_02eb: Expected Obj, but got I4
			//IL_02eb: Expected Obj, but got Ref
			//IL_02f4: Expected Obj, but got I4
			//IL_048a: Expected Obj, but got Ref
			//IL_049b: Expected Obj, but got I4
			//IL_0324: Expected Obj, but got Ref
			//IL_04a7: Expected I, but got Obj
			//IL_01bd: Expected I, but got Obj
			//IL_01bd: Expected Obj, but got Ref
			//IL_0256: Expected Obj, but got Ref
			//IL_034f: Expected Obj, but got I4
			//IL_0354: Expected Obj, but got I4
			//IL_0354: Expected Obj, but got Ref
			//IL_01a1: Expected I4, but got Obj
			//IL_008e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ab->IL0026: Incompatible stack types: I4 vs Obj
			//IL_07c8->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0099->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_07d3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_05d8->IL00d8: Incompatible stack heights: 4 vs 1
			//IL_0635->IL00d8: Incompatible stack heights: 3 vs 1
			//IL_00d8->IL00d8: Incompatible stack heights: 2 vs 1
			//IL_030b->IL0124: Incompatible stack types: I4 vs Obj
			//IL_0120->IL0124: Incompatible stack types: I4 vs Obj
			//IL_06b0->IL06c7: Incompatible stack heights: 6 vs 8
			//IL_0221->IL0124: Incompatible stack types: I4 vs Obj
			//IL_029a->IL0373: Incompatible stack heights: 1 vs 0
			//IL_01ec->IL0124: Incompatible stack types: I4 vs Obj
			//IL_045a->IL0124: Incompatible stack types: I4 vs Obj
			//IL_0417->IL0124: Incompatible stack types: I4 vs Obj
			//IL_03ee->IL0124: Incompatible stack types: I4 vs Obj
			//IL_0435->IL0124: Incompatible stack types: I4 vs Obj
			//IL_02e1->IL0124: Incompatible stack types: I4 vs Obj
			//IL_027e->IL0124: Incompatible stack types: I4 vs Obj
			//IL_046e->IL0124: Incompatible stack types: I4 vs Obj
			//IL_03a0->IL0124: Incompatible stack types: I4 vs Obj
			//IL_02cf->IL0124: Incompatible stack types: I4 vs Obj
			//IL_031e->IL0124: Incompatible stack types: I4 vs Obj
			//IL_04a0->IL0120: Incompatible stack heights: 1 vs 0
			//IL_0334->IL0124: Incompatible stack types: I4 vs Obj
			//IL_01c7->IL0124: Incompatible stack types: I4 vs Obj
			//IL_0266->IL0124: Incompatible stack types: I4 vs Obj
			//IL_0368->IL0124: Incompatible stack types: I4 vs Obj
			//IL_022c->IL0124: Incompatible stack types: I4 vs Obj
			//IL_02ae->IL0124: Incompatible stack heights: 2 vs 1
			//IL_0484->IL0124: Incompatible stack types: I4 vs Obj
			//IL_0422->IL0124: Incompatible stack types: I4 vs Obj
			//IL_03cc->IL0124: Incompatible stack types: I4 vs Obj
			//IL_034a->IL0124: Incompatible stack types: I4 vs Obj
			//IL_03f9->IL0124: Incompatible stack types: I4 vs Obj
			//IL_0289->IL0124: Incompatible stack types: I4 vs Obj
			//IL_03ab->IL0124: Incompatible stack types: I4 vs Obj
			//IL_04e4->IL0124: Incompatible stack types: I4 vs Obj
			//IL_0373->IL0124: Incompatible stack types: I4 vs Obj
			//IL_02b9->IL0124: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 5;
			object obj = awaiter;
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				case 1:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = -2;
					obj = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj = 0;
					}
					break;
				default:
					*((int, nint)*)(nint)/*Error near IL_007a: Stack underflow*/ = ((int)/*Error near IL_007a: Stack underflow*/, (nint)Unsafe.AsPointer(ref IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute));
					obj = 2;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj = 1;
					}
					break;
				case 4:
					awaiter = IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute;
					obj = 3;
					break;
				case 2:
					return;
				case 3:
					if ((nuint)(nint)awaiter <= (nuint)1u)
					{
						num = 4;
						if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
						{
							num = 4;
						}
						goto IL_00d8;
					}
					goto IL_0635;
				case 5:
					{
						awaiter = __KnownINotifyPropertyChangingArgs.RentalGames;
						obj = 4;
						if (__KnownINotifyPropertyChangingArgs.Skins == null)
						{
							obj = 3;
						}
						break;
					}
					IL_00d8:
					while (true)
					{
						object obj3;
						switch (num)
						{
						case 1:
						case 10:
							break;
						case 6:
							if (awaiter != null)
							{
								obj3 = 9;
								goto IL_0124;
							}
							goto IL_02f9;
						default:
							IEnumerable_object.SaveAttribute();
							_ = IReadOnlyListMethods<INotifyPropertyChanged>.AbiToProjectionVftablePtr;
							_ = 5;
							continue;
						case 2:
						case 4:
							num = 0;
							if (__KnownINotifyPropertyChangingArgs.Input4399Username == null)
							{
								num = 6;
							}
							continue;
						case 3:
						case 9:
							((Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails)(object)GlobalVtableLookup.DecorateDetailedAttribute()).GetExposedInterfaces();
							_ = IEnumeratorMethods<object>.IID;
							_ = 8;
							continue;
						case 7:
							goto IL_0635;
						case 5:
							((Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails)1)._002Ector();
							awaiter = 2;
							continue;
						case 8:
							{
								object obj2 = awaiter;
								bool flag = Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.CheckCentralAttribute();
								Guid iID = IEnumeratorMethods<IDisposable>.IID;
								PropertyChangingEventArgs infoBarIsOpen;
								IAnimationObjectMethods val;
								if (__KnownINotifyPropertyChangingArgs.InfoBarSeverity == null)
								{
									infoBarIsOpen = __KnownINotifyPropertyChangingArgs.InfoBarIsOpen;
									val = (IAnimationObjectMethods)new IAnimationObjectMethods();
									__KnownINotifyPropertyChangingArgs.SelectedFileName = (PropertyChangingEventArgs)val;
								}
								((AsyncTaskMethodBuilder*)infoBarIsOpen)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(delegate*<bool>)(&Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.SortAttribute), ref *(DesktopViewModel._003CLaunchHeadlessShadowClient_003Ed__9*)val);
								((AsyncTaskMethodBuilder*)null)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)6, ref *(DesktopViewModel._003CLaunchShadowClient_003Ed__5*)iID);
								((AsyncTaskMethodBuilder*)/*Error near IL_06d6: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)obj2, ref *(flag ? ((DesktopViewModel._003COpenGameResourceFolder_003Ed__4*)1) : ((DesktopViewModel._003COpenGameResourceFolder_003Ed__4*)null)));
								num = 0;
								if (__KnownINotifyPropertyChangingArgs.ParsedAccounts != null)
								{
									num = 0;
								}
								continue;
							}
							IL_0124:
							while (true)
							{
								switch ((int)obj3)
								{
								case 22:
									break;
								case 1:
									return;
								case 29:
									return;
								case 26:
									IReadOnlyList_object._initialized = (nint)awaiter;
									obj3 = 23;
									continue;
								case 3:
									IReadOnlyList_object.ReflectLogicalAttribute = awaiter;
									obj3 = 11;
									continue;
								default:
									awaiter = MarshalInterface<INotifyPropertyChanged>.FromAbiArray((object)IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_0206: Stack underflow*/, (INotifyPropertyChanged)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_0200: Stack underflow*/, (uint)/*Error near IL_0200: Stack underflow*/, (nint*)/*Error near IL_0200: Stack underflow*/), ref *(uint*)null));
									obj3 = 2;
									if (IEnumerable_object._initialized != 0)
									{
										obj3 = 4;
									}
									continue;
								case 27:
									Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute = null;
									obj3 = 20;
									continue;
								case 14:
								case 21:
									awaiter = awaiter;
									obj3 = 25;
									if (Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute != null)
									{
										obj3 = 11;
									}
									continue;
								case 2:
									if (MarshalInterface<IReadOnlyList<object>>.FromManaged((IReadOnlyList<object>)IEnumerable_System_ComponentModel_INotifyPropertyChanged.DecorateSeparatedAttribute()) != (IntPtr)0)
									{
										_ = 0;
										if (Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute == null)
										{
											_ = 0;
										}
										continue;
									}
									goto case 16;
								case 17:
									IListMethods<object>.Abi_InsertAt_5((IntPtr)/*Error near IL_02c5: Stack underflow*/, (uint)/*Error near IL_02c5: Stack underflow*/, (object)IList_object.Do_Abi_GetAt_0((nint)/*Error near IL_02c0: Stack underflow*/, (uint)/*Error near IL_02c0: Stack underflow*/, (nint*)(nint)awaiter));
									obj3 = 5;
									continue;
								case 13:
									awaiter = Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute;
									obj3 = 27;
									continue;
								case 20:
									awaiter = -1;
									Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute = -1;
									awaiter = 18;
									goto IL_0120;
								case 19:
									goto IL_02f9;
								case 7:
								case 18:
									IListMethods<object>.Abi_Clear_9((IntPtr)(nint)(&awaiter));
									awaiter = (object)/*Error near IL_0314: Stack underflow*/;
									obj3 = 14;
									continue;
								case 24:
									_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule = null;
									obj3 = 28;
									continue;
								case 10:
									if (IListMethods<object>.Abi_get_Size_1((IntPtr)(nint)(&awaiter)) != 0)
									{
										obj3 = 7;
										continue;
									}
									goto case 15;
								case 28:
									awaiter = -1;
									_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator = -1;
									obj3 = 4;
									if (__KnownINotifyPropertyChangingArgs.UserId == null)
									{
										obj3 = 12;
									}
									continue;
								case 16:
									IList_object._002Ecctor();
									awaiter = IReadOnlyListMethods<IDisposable>.Abi_GetAt_0((IntPtr)/*Error near IL_038a: Stack underflow*/, IReadOnlyListMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0385: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)awaiter, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)(IList_object.AttachAttribute() ? 1 : 0), (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)null) ? 1u : 0u);
									obj3 = 7;
									if (__KnownINotifyPropertyChangingArgs.Message != null)
									{
										obj3 = 10;
									}
									continue;
								case 9:
									if ((nint)awaiter != 1)
									{
										obj3 = 2;
										continue;
									}
									goto case 13;
								case 11:
									Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.CharacterName).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CRefreshRentalGames_003Ed__22, AccountViewModel._003CLoginBedrock_003Ed__86>(ref this));
									obj3 = 1;
									if (__KnownINotifyPropertyChangingArgs.IsSkeleton == null)
									{
										obj3 = 0;
									}
									continue;
								case 8:
									awaiter = 0;
									__KnownINotifyPropertyChangingArgs.CanProxy = (PropertyChangingEventArgs)0;
									obj3 = 26;
									if (__KnownINotifyPropertyChangingArgs.OnlinePlayers != null)
									{
										obj3 = 13;
									}
									continue;
								case 6:
								case 12:
									awaiter = IReadOnlyListMethods<object>.Abi_IndexOf_2((IntPtr)/*Error near IL_0429: Stack underflow*/, (object)/*Error near IL_0429: Stack underflow*/, ref *(uint*)(&awaiter));
									obj3 = 21;
									continue;
								case 5:
									((AsyncTaskMethodBuilder*)/*Error near IL_0450: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)/*Error near IL_0450: Stack underflow*/, ref *(IEnumeratorMethods<IDisposable>.Abi_MoveNext_2((IntPtr)(int)IReadOnlyList_System_IDisposable.Do_Abi_GetMany_3((nint)/*Error near IL_0446: Stack underflow*/, (uint)/*Error near IL_0446: Stack underflow*/, (uint)/*Error near IL_0446: Stack underflow*/, (nint)(int)IReadOnlyList_System_IDisposable.Do_Abi_IndexOf_2((nint)/*Error near IL_043f: Stack underflow*/, (nint)/*Error near IL_043f: Stack underflow*/, (uint*)/*Error near IL_043f: Stack underflow*/, (byte*)(int)IReadOnlyList_System_IDisposable.Do_Abi_GetAt_0((nint)/*Error near IL_043a: Stack underflow*/, (uint)/*Error near IL_043a: Stack underflow*/, (nint*)/*Error near IL_043a: Stack underflow*/)), (uint*)(nint)awaiter)) ? ((AccountViewModel._003CLogoutAccount_003Ed__23*)1) : ((AccountViewModel._003CLogoutAccount_003Ed__23*)null)));
									obj3 = 22;
									continue;
								case 15:
									awaiter = 1;
									__KnownINotifyPropertyChangingArgs.BackgroundImageUrl = (PropertyChangingEventArgs)1;
									obj3 = 3;
									continue;
								case 4:
									if (IEnumeratorMethods<IDisposable>.Abi_get_HasCurrent_1((IntPtr)(nint)(&awaiter)))
									{
										obj3 = 6;
										continue;
									}
									goto case 8;
								case 23:
									_ = ref __KnownINotifyPropertyChangingArgs.Summary;
									((AsyncTaskMethodBuilder*)(&awaiter))->Start(ref Unsafe.As<_003CRefreshRentalGames_003Ed__22, ImportAccountViewModel._003CSelectFile_003Ed__45>(ref this));
									awaiter = 29;
									goto IL_0120;
								case 25:
									{
										((AsyncTaskMethodBuilder*)IReadOnlyList_object.Do_Abi_GetAt_0((nint)/*Error near IL_04a7: Stack underflow*/, (uint)/*Error near IL_04a7: Stack underflow*/, (nint*)(nint)awaiter))->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)awaiter, ref *(ImportAccountViewModel._003CPrimaryAsync_003Ed__46*)((IEnumerable<AccountModel>)((IEnumerable)(__KnownINotifyPropertyChangingArgs.Title ?? (__KnownINotifyPropertyChangingArgs.StateText = (PropertyChangingEventArgs)(object)new Func<Type, string>(__KnownINotifyPropertyChangingArgs.Executor, (nint)(delegate* unmanaged[Stdcall]<nint, uint*, uint>)(&IReadOnlyList_object.Do_Abi_get_Size_1))))).OfType<NeteaseAccount>()).ToList());
										obj3 = 17;
										continue;
									}
									IL_0120:
									obj3 = awaiter;
									continue;
								}
								break;
							}
							break;
							IL_02f9:
							awaiter = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance;
							obj3 = 24;
							goto IL_0124;
						}
						break;
					}
					goto case 1;
					IL_0635:
					if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.DecorateGeneralAttribute())
					{
						num = 3;
						goto IL_00d8;
					}
					goto case 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_F500()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778523, new IntPtr(2737336177212L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_F600()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_F700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778520, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_F800()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00豈(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778521, new IntPtr(2737336168892L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00切(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00ﬀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778598, new IntPtr(2737336154332L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSelectGame_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MobileGameModel gameModel;

		public MobileViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object ReflectReadableEmitter;

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
		internal static bool DecorateRemoteRunner()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateActiveClient()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_E500()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778599, new IntPtr(2737336179292L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_E600()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_045e: Expected Obj, but got I4
			//IL_045e: Expected Obj, but got Ref
			//IL_046e: Expected Obj, but got Ref
			//IL_0483: Expected Obj, but got Ref
			//IL_04aa: Expected Obj, but got Ref
			//IL_04b5: Expected Obj, but got I4
			//IL_0376: Expected Obj, but got Ref
			//IL_0380: Expected Obj, but got I4
			//IL_005f: Expected Obj, but got I
			//IL_01f9: Expected Obj, but got Ref
			//IL_0203: Expected I, but got Obj
			//IL_01c0: Expected Obj, but got I4
			//IL_01c5: Expected Obj, but got I4
			//IL_01c5: Expected Obj, but got Ref
			//IL_011b: Expected Obj, but got I4
			//IL_0120: Expected Obj, but got Ref
			//IL_0197: Expected Obj, but got Ref
			//IL_019c: Expected I, but got Obj
			//IL_01ab: Expected Obj, but got I
			//IL_024f: Expected Obj, but got Ref
			//IL_024f: Expected I4, but got Obj
			//IL_0169: Expected Obj, but got Ref
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_022c: Expected Obj, but got Ref
			//IL_00ef: Expected Obj, but got Ref
			//IL_00f7: Expected Obj, but got Ref
			//IL_0106: Expected Obj, but got I
			//IL_023c: Expected Obj, but got Ref
			//IL_0468->IL0026: Incompatible stack types: I4 vs Obj
			//IL_047d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0499->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0073: Incompatible stack heights: 1 vs 3
			//IL_04a4->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008c->IL0366: Incompatible stack heights: 2 vs 0
			//IL_006f->IL0073: Incompatible stack heights: 1 vs 3
			//IL_026d->IL039f: Incompatible stack heights: 0 vs 2
			//IL_0185->IL01bb: Incompatible stack heights: 0 vs 2
			//IL_01b0->IL00a7: Incompatible stack heights: 4 vs 3
			//IL_0259->IL00a7: Incompatible stack heights: 1 vs 3
			//IL_010b->IL00a7: Incompatible stack heights: 6 vs 3
			//IL_018f->IL00a7: Incompatible stack heights: 1 vs 3
			//IL_01bb->IL00a7: Incompatible stack heights: 4 vs 3
			//IL_0116->IL00a7: Incompatible stack heights: 6 vs 3
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
					uint num;
					SessionChangedMessage sessionChangedMessage;
					int num2;
					switch ((int)obj2)
					{
					case 1:
						if (obj == null)
						{
							_ = 0;
							if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute == null)
							{
								_ = 0;
							}
							goto IL_0073;
						}
						goto IL_0366;
					default:
						goto IL_0456;
					case 2:
						((Func<Type, string>)/*Error near IL_0473: Stack underflow*/)._002Ector((object)/*Error near IL_0473: Stack underflow*/, (nint)Unsafe.AsPointer(ref __KnownINotifyPropertyChangingArgs.LaunchTime));
						obj2 = 5;
						continue;
					case 3:
						obj = __KnownINotifyPropertyChangingArgs.StateText;
						obj2 = 1;
						if (__KnownINotifyPropertyChangingArgs.CloseText != null)
						{
							obj2 = 1;
						}
						continue;
					case 4:
						break;
					case 5:
						return;
						IL_0366:
						num = IEnumerator_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_0370: Stack underflow*/, (byte*)(int)IEnumerator_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Current_0((nint)/*Error near IL_036b: Stack underflow*/, (nint*)/*Error near IL_036b: Stack underflow*/));
						sessionChangedMessage = IMessengerExtensions.Send<SessionChangedMessage>((IMessenger)(object)__KnownINotifyPropertyChangingArgs.IsSkeleton, (SessionChangedMessage)IEnumerator_System_ComponentModel_INotifyPropertyChanged.DecorateDynamicAttribute());
						num2 = 4;
						if (__KnownINotifyPropertyChangingArgs.MaxPlayers != null)
						{
							num2 = 2;
						}
						goto IL_0073;
						IL_0456:
						__KnownINotifyPropertyChangingArgs.Executor = (PropertyChangingEventArgs)(-2);
						obj2 = 2;
						continue;
						IL_0073:
						while (true)
						{
							int num3;
							object reflectScheduledAttribute;
							switch (num2)
							{
							case 3:
								if (obj == null)
								{
									num3 = 3;
									goto IL_00a7;
								}
								goto IL_01f3;
							default:
								num2 = 3;
								continue;
							case 2:
								break;
							case 1:
								goto IL_0456;
								IL_00a7:
								while (true)
								{
									switch (num3)
									{
									default:
										return;
									case 10:
										_ = ref IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized;
										_ = ref obj;
										CastExtensions.As<NavigationView>((object)Unsafe.AsPointer(ref this));
										_ = 0;
										if (IList_object.PatchAttribute == null)
										{
											_ = 0;
										}
										continue;
									case 4:
										obj = -1;
										IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = -1;
										num3 = 7;
										if (IReadOnlyList_System_IDisposable._initialized != 0)
										{
											num3 = 4;
										}
										continue;
									case 8:
										IReadOnlyList_object.ReflectLogicalAttribute = (object)default(NavigationViewItemPresenter);
										num3 = 4;
										continue;
									case 5:
										if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)(int)num, (INotifyPropertyChanged)sessionChangedMessage, ref *(uint*)(&obj)))
										{
											_ = 12;
											continue;
										}
										goto case 1;
									case 6:
										IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)obj, (uint*)IEnumerable_System_IDisposable._initialized);
										_ = 2;
										if (IEnumerable_object.ReflectSetAttribute != null)
										{
											_ = 0;
										}
										continue;
									case 1:
										obj = 0;
										GlobalVtableLookup.CreateAttribute = 0;
										num3 = 9;
										if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute == null)
										{
											num3 = 9;
										}
										continue;
									case 0:
										return;
									case 11:
										break;
									case 9:
										Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute = obj;
										num3 = 10;
										continue;
									case 3:
									case 13:
										obj = Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute;
										num3 = 8;
										continue;
									case 7:
									case 12:
										IListMethods<object>.Abi_InsertAt_5((IntPtr)(int)num, (uint)(int)sessionChangedMessage, (object)(&obj));
										_ = 6;
										continue;
									case 2:
										goto IL_0456;
									}
									break;
								}
								goto IL_01f3;
								IL_01f3:
								reflectScheduledAttribute = Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute;
								IEnumerable_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
								obj = IListMethods<object>.Abi_GetView_2((IntPtr)reflectScheduledAttribute);
								num3 = 3;
								if (Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute == null)
								{
									num3 = 5;
								}
								goto IL_00a7;
							}
							break;
						}
						goto IL_0366;
					}
					break;
				}
				obj = __KnownINotifyPropertyChangingArgs.Type;
				obj = 3;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_E700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778596, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_E800()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_E900()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778597, new IntPtr(2737336154332L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_EA00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778594, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_EB00()
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
		internal unsafe static object _FF00_FF00_FF00_FF00_EC00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778595, new IntPtr(2737336181372L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_ED00(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_EE00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778592, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStartProxy_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MobileViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object CountProvider;

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
		internal static bool RestartCalc()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckScalableFinalizer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778593, new IntPtr(2737336185532L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_009e: Expected Obj, but got Ref
			//IL_0087: Expected Obj, but got Ref
			//IL_008c: Expected Obj, but got Ref
			//IL_0060: Expected Obj, but got Ref
			//IL_0071: Expected Obj, but got I
			//IL_004e: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I
			//IL_01fe: Expected I, but got Obj
			//IL_0235: Expected Obj, but got Ref
			//IL_023d: Expected Obj, but got Ref
			//IL_023d: Expected Obj, but got Ref
			//IL_01c9: Expected Obj, but got I4
			//IL_01ce: Expected Obj, but got I4
			//IL_01ce: Expected Obj, but got Ref
			//IL_019c: Expected Obj, but got Ref
			//IL_01b1: Expected Obj, but got I4
			//IL_01b6: Expected Obj, but got I4
			//IL_01b6: Expected Obj, but got Ref
			//IL_01bf: Expected Obj, but got I4
			//IL_0159: Expected I, but got Obj
			//IL_0159: Expected Obj, but got Ref
			//IL_0130: Expected Obj, but got Ref
			//IL_0141: Expected Obj, but got I
			//IL_0125: Expected I4, but got Obj
			//IL_00b2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0096->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0076->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d9->IL00e8: Incompatible stack types: I4 vs Obj
			//IL_00bd->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0081->IL0026: Incompatible stack types: I4 vs Obj
			//IL_020a->IL00e8: Incompatible stack heights: 4 vs 1
			//IL_0220->IL00e8: Incompatible stack heights: 2 vs 1
			//IL_0125->IL01ed: Incompatible stack heights: 0 vs 1
			//IL_00e4->IL00e8: Incompatible stack types: I4 vs Obj
			//IL_0251->IL00e8: Incompatible stack heights: 2 vs 1
			//IL_01e2->IL00e8: Incompatible stack types: I4 vs Obj
			//IL_01ac->IL00e8: Incompatible stack types: I4 vs Obj
			//IL_028d->IL00e8: Incompatible stack types: I4 vs Obj
			//IL_016d->IL00e8: Incompatible stack types: I4 vs Obj
			//IL_0146->IL00e8: Incompatible stack types: I4 vs Obj
			//IL_025c->IL00e8: Incompatible stack heights: 2 vs 1
			//IL_01ed->IL00e8: Incompatible stack types: I4 vs Obj
			//IL_0298->IL00e8: Incompatible stack types: I4 vs Obj
			//IL_0272->IL00e8: Incompatible stack types: I4 vs Obj
			//IL_0178->IL00e8: Incompatible stack types: I4 vs Obj
			//IL_0151->IL00e8: Incompatible stack types: I4 vs Obj
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				case 5:
					obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					obj2 = 4;
					continue;
				case 4:
					obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
					obj2 = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					MarshalInspectable<object>.FromAbiArray((object)Unsafe.AsPointer(ref IList_object._initialized));
					_ = 3;
					continue;
				case 1:
					break;
				default:
					if (obj == null)
					{
						obj3 = 4;
						if (IReadOnlyList_object._initialized == 0)
						{
							obj3 = 3;
						}
						goto IL_00e8;
					}
					goto IL_020a;
				case 3:
					return;
					IL_020a:
					if (IList_object.Init() == 0)
					{
						_ = 10;
						goto IL_00e8;
					}
					goto IL_01ed;
					IL_01ed:
					IEnumerable_System_ComponentModel_INotifyPropertyChanged.DecorateSeparatedAttribute();
					obj = MarshalInspectable<object>.FromAbi((IntPtr)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectMonoAttribute());
					_ = 11;
					goto IL_00e8;
					IL_00e8:
					while (true)
					{
						switch ((int)obj3)
						{
						case 4:
						case 13:
							obj = IReadOnlyList_object.ReflectLogicalAttribute;
							obj3 = 1;
							if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
							{
								obj3 = 6;
							}
							continue;
						case 12:
							IEnumerable_System_IDisposable._initialized = (nint)obj;
							obj3 = 1;
							if (IEnumerable_object._initialized == 0)
							{
								obj3 = 1;
							}
							continue;
						case 3:
							return;
						case 6:
							Unsafe.As<object, nint>(ref IEnumerable_object.ReflectSetAttribute) = default;
							obj3 = 5;
							continue;
						case 7:
							obj = 0;
							Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute = 0;
							obj = 12;
							obj3 = obj;
							continue;
						case 5:
							obj = -1;
							Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute = -1;
							obj3 = 9;
							if (Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute == null)
							{
								obj3 = 7;
							}
							continue;
						case 2:
							goto end_IL_00e8;
						case 8:
							goto IL_020a;
						case 1:
							Interlocked.CompareExchange(ref Unsafe.As<object, Action>(ref Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute), (Action)(&obj), (Action)Unsafe.AsPointer(ref this));
							_ = 1;
							if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute != null)
							{
								_ = 3;
							}
							continue;
						case 11:
							IListMethods<object>.Abi_RemoveAtEnd_8((IntPtr)(nint)(&obj));
							if ((int)/*Error near IL_0268: Stack underflow*/ == 0)
							{
								obj3 = 7;
								continue;
							}
							goto case 9;
						case 9:
							IListMethods<object>.Abi_Clear_9((IntPtr)(nint)(&obj));
							obj3 = 0;
							if ((int)_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout == 0)
							{
								obj3 = 0;
							}
							continue;
						}
						goto end_IL_0026;
						continue;
						end_IL_00e8:
						break;
					}
					goto IL_01ed;
					end_IL_0026:
					break;
				}
				IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = -2;
				obj2 = 1;
				if (IReadOnlyList_System_IDisposable._initialized != 0)
				{
					obj2 = 2;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778606, new IntPtr(2737336177212L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_E000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778607, new IntPtr(2737336179292L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_E100()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_E200(object P_0)
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

	private nint _isInternalUpdate;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand<MobileGameModel>? loadGameConfigurationCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<MobileGameModel>? selectGameCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? startProxyCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? launchGameCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? openGameResourceFolderCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? clearSelectedServiceCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? refreshNetGamesCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? refreshRentalGamesCommand;

	internal static MobileViewModel DecorateIterableSet;

	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	[NotifyPropertyChangedFor("HasSelectedGame")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public MobileGameModel? SelectedGame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (MobileGameModel?)_FF00_FF00茀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00焀(value);
		}
	}

	public bool HasSelectedGame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00紀() != 0;
		}
	}

	private ObservableCollection<ConfigValue>? SectionValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00言();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00蔀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public ObservableCollection<MobileGameModel> RentalGames
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00需();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00ꘀ(value);
		}
	}

	public int CurrentDisplayPage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00脀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00贀((uint)value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public ObservableCollection<MobileGameModel> NetGames
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00蜀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00缀(value);
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
			return (string)_FF00_FF00渀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00瘀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public bool SearchVisibility
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00砀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00蘀(value ? ((byte)1) : ((byte)0));
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand<MobileGameModel> LoadGameConfigurationCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00ꠀ();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand<MobileGameModel> SelectGameCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00ꀀ();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand StartProxyCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_FF00鴀();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand LaunchGameCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_FF00글();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand OpenGameResourceFolderCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IRelayCommand)_FF00_FF00뀀();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IRelayCommand ClearSelectedServiceCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IRelayCommand)_FF00_FF00_AB00();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand RefreshNetGamesCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_FF00稀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand RefreshRentalGamesCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_FF00ꈀ();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	public void LoadGameConfiguration(MobileGameModel gameModel)
	{
		_FF00_FF00ꐀ(gameModel);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CSelectGame_003Ed__6))]
	private object SelectGame(object gameModel)
	{
		return _FF00_FF00餀(gameModel);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CStartProxy_003Ed__7))]
	private object StartProxy()
	{
		return _FF00_FF00鄀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CLaunchGame_003Ed__8))]
	private object LaunchGame()
	{
		return _FF00_FF00踀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[MemberNotNullWhen(true, "SelectedGame")]
	private byte HadSelectedGame()
	{
		return _FF00_FF00꼀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	private void OpenGameResourceFolder()
	{
		_FF00_FF00鼀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	private void ClearSelectedService()
	{
		_FF00_FF00爀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStackPanelLoaded(StackPanel panel)
	{
		_FF00_FF00舀(panel);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshNetGames_003Ed__17))]
	[RelayCommand]
	private object RefreshNetGames()
	{
		return _FF00_FF00甀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshRentalGames_003Ed__22))]
	[RelayCommand]
	private object RefreshRentalGames()
	{
		return _FF00_FF00鬀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe MobileViewModel()
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
	private void Initialize()
	{
		_FF00_FF00销();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetDisplayPage(uint page)
	{
		_FF00_FF00蠀(page);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateIntegratedModel()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MobileViewModel CheckLocalCreator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00氀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778528, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00洀()
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
	internal unsafe object _FF00_FF00渀()
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
	internal unsafe object _FF00_FF00漀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778529, new IntPtr(2737336155372L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00瀀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778542, new IntPtr(2737336150172L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00焀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_00aa: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I
		//IL_00cb: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0057: Expected I, but got Obj
		//IL_0060: Expected Obj, but got I4
		//IL_00af->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0090->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00d0->IL007a: Incompatible stack heights: 2 vs 0
		//IL_010a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0065->IL0022: Incompatible stack heights: 1 vs 0
		//IL_007a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ba->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00e4->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0115->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ef->IL0026: Incompatible stack heights: 3 vs 1
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
				case 4:
					break;
				case 6:
					/*Error near IL_0070: Stack underflow*/((object[])(object)this, IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized);
					obj2 = 5;
					continue;
				case 5:
					return;
				case 1:
					MarshalInspectable<object>.FromAbiArray((object)IList_object._initialized);
					_ = 4;
					continue;
				default:
					MarshalInspectable<object>.FromManaged((object)this, (byte)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0);
					_ = 3;
					if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
					{
						_ = 6;
					}
					continue;
				case 2:
					IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)/*Error near IL_00bf: Stack underflow*/, (uint)/*Error near IL_00bf: Stack underflow*/);
					_ = IReadOnlyList_object.ReflectLogicalAttribute;
					if (MarshalInterface<INotifyPropertyChanged>.FromAbi((IntPtr)P_0) != null)
					{
						return;
					}
					_ = 1;
					if (IEnumerable_System_IDisposable._initialized == 0)
					{
						_ = 1;
					}
					continue;
				case 3:
					IEnumerable_System_IDisposable.CombineAttribute = P_0;
					obj2 = 0;
					if (IEnumerable_object.ReflectSetAttribute == null)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			}
			IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00爀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_007a: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I4
		//IL_00c3: Expected I4, but got VT
		//IL_00ce: Expected Obj, but got I4
		//IL_0050: Expected I, but got Obj
		//IL_0064: Expected Obj, but got I
		//IL_00d9->IL0026: Incompatible stack heights: 2 vs 1
		//IL_008e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0069->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0074->IL0026: Incompatible stack types: I4 vs Obj
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
				return;
			case 3:
				if (MarshalInspectable<object>.FromAbiArray((object)IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_007a: Stack underflow*/, (uint)/*Error near IL_007a: Stack underflow*/, (nint)/*Error near IL_007a: Stack underflow*/, (uint*)(nint)this)) != null)
				{
					obj2 = 2;
					break;
				}
				if (IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute()) != 0)
				{
					return;
				}
				obj2 = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					obj2 = 0;
				}
				break;
			case 4:
				return;
			case 1:
				return;
			default:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)(IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)/*Error near IL_00b9: Stack underflow*/) ? 1 : 0), (uint)(int)typeof(Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails).TypeHandle);
				((XamlUserType)1).BoxType<EasingMode>((object)new IReadOnlyList_System_ComponentModel_INotifyPropertyChanged());
				_ = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00猀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778543, new IntPtr(2737336164732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00琀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778540, new IntPtr(2737336148092L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00甀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17933, 1790778541, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778541, new IntPtr(2737336166812L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00瘀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_004b: Expected I, but got Obj
		//IL_00a0: Expected I, but got Obj
		//IL_0075: Expected I, but got Obj
		//IL_0075: Expected I4, but got Obj
		//IL_00d0: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I4
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b4->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00bf->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0094->IL0026: Incompatible stack types: I4 vs Obj
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
				default:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
					obj2 = 1;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 1;
					}
					continue;
				case 2:
					((ValueTuple<int, nint>*)/*Error near IL_0075: Stack underflow*/)->_002Ector((int)this, (nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute);
					obj2 = 0;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 0;
					}
					continue;
				case 4:
					return;
				case 1:
					IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute);
					_ = 0;
					if (IReadOnlyList_object._initialized == 0)
					{
						_ = 4;
					}
					continue;
				case 3:
					if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2(MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)/*Error near IL_00c4: Stack underflow*/), (INotifyPropertyChanged)IEnumerator_System_IDisposable._initialized, ref *(uint*)P_0))
					{
						return;
					}
					obj = 2;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00眀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778538, new IntPtr(2737336155372L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00砀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00礀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778539, new IntPtr(2737336173052L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00稀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17938, 1790778536, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778536, new IntPtr(2737336164732L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00笀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778537, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00簀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778550, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00紀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (_003CModule_003E.CheckAccessibleAttribute() != null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00縀(ObservableCollection<MobileGameModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778551, new IntPtr(2737336153292L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00缀(ObservableCollection<MobileGameModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0075: Expected I, but got Obj
		//IL_004f: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_00a5: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_00de->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0094->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00be->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c9->IL0026: Incompatible stack types: I4 vs Obj
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
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 1;
				}
				break;
			case 1:
				IList_object._initialized = (nint)P_0;
				obj2 = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
				if (IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00a5: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)MarshalInspectable<object>.FromManaged((object)/*Error near IL_0099: Stack underflow*/, (byte)/*Error near IL_0099: Stack underflow*/ != 0), (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)IReadOnlyList_System_IDisposable._initialized, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)P_0))
				{
					return;
				}
				obj2 = 3;
				if (IReadOnlyList_object.ReflectLogicalAttribute == null)
				{
					obj2 = 2;
				}
				break;
			default:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00d4: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
				_ = 2;
				break;
			case 2:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00耀(ObservableCollection<MobileGameModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778548, new IntPtr(2737336178252L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00脀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00舀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_007b: Expected I, but got Obj
		//IL_0087: Expected I, but got Obj
		//IL_0087: Expected I, but got Obj
		//IL_009b->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0066->IL0071: Incompatible stack heights: 1 vs 0
		//IL_00a6->IL0026: Incompatible stack heights: 3 vs 1
		//IL_005b->IL0026: Incompatible stack heights: 5 vs 1
		//IL_0070->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		while (true)
		{
			switch ((int)obj)
			{
			case 1:
				return;
			case 2:
				_003CModule_003E.CheckAccessibleAttribute();
				_ = IEnumerator_object.Initialized;
				_ = 4;
				continue;
			case 3:
				if (IEnumerator_object.Init() != 0)
				{
					_ = 2;
					continue;
				}
				break;
			case 4:
				return;
			}
			IEnumerator_object.Do_Abi_get_Current_0((nint)/*Error near IL_0080: Stack underflow*/, (nint*)(int)IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_007b: Stack underflow*/, (uint)/*Error near IL_007b: Stack underflow*/, (nint)/*Error near IL_007b: Stack underflow*/, (uint*)(nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute));
			IEnumerator_object.Do_Abi_get_HasCurrent_1(unchecked((nint)null), (byte*)unchecked((nint)null));
			_ = 1;
			if (IReadOnlyList_System_IDisposable._initialized != 0)
			{
				_ = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00茀()
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
	private unsafe void _FF00_FF00萀(ObservableCollection<ConfigValue> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778549, new IntPtr(2737336151212L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00蔀(ObservableCollection<ConfigValue> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected I, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
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
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00蘀(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_009a: Expected I, but got Obj
		//IL_00ab: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I
		//IL_0050: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I
		//IL_00a4->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00bf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0085->IL0044: Incompatible stack heights: 1 vs 0
		//IL_00ca->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_008f->IL0026: Incompatible stack heights: 2 vs 1
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
			case 2:
				return;
			case 3:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					_ = 0;
				}
				break;
			case 4:
				*((int, nint)*)(nint)/*Error near IL_0074: Stack underflow*/ = ((int)/*Error near IL_0074: Stack underflow*/, (nint)/*Error near IL_0074: Stack underflow*/);
				_ = IList_object.PatchAttribute;
				if (IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)(int)P_0) != null)
				{
					return;
				}
				_ = 3;
				break;
			default:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute);
				_ = 2;
				break;
			case 1:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
				obj2 = 0;
				if (IReadOnlyList_object.ReflectLogicalAttribute == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<MobileGameModel> _FF00_FF00蜀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<MobileGameModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00蠀(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_006d: Expected Obj, but got I4
		//IL_0092->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005b->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0077->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0066->IL0026: Incompatible stack heights: 4 vs 1
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
				_003CModule_003E.CheckAccessibleAttribute();
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					_ = 0;
				}
				break;
			case 3:
				IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute = 1;
				obj2 = 2;
				break;
			default:
				IList_object._initialized = 0;
				obj2 = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00褀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778546, new IntPtr(2737336160572L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe ObservableCollection<ConfigValue> _FF00_FF00言()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<ConfigValue>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe ObservableCollection<ConfigValue> _FF00_FF00謀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778547, new IntPtr(2737336177212L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<ConfigValue>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00谀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778544, new IntPtr(2737336168892L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00贀(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_005f: Expected I4, but got Obj
		//IL_0076: Expected Obj, but got I4
		//IL_00e3: Expected I, but got Obj
		//IL_00e9: Expected I4, but got Obj
		//IL_00e9: Expected Obj, but got I4
		//IL_0131: Expected I, but got Obj
		//IL_0137: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		//IL_0109: Expected Obj, but got I
		//IL_0081->IL0026: Incompatible stack heights: 4 vs 1
		//IL_016a->IL0026: Incompatible stack heights: 3 vs 1
		//IL_01b6->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00f3->IL0026: Incompatible stack heights: 2 vs 1
		//IL_014b->IL0026: Incompatible stack heights: 2 vs 1
		//IL_012b->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00d2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01c1->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0091->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0156->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00dd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0119->IL0026: Incompatible stack types: I4 vs Obj
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
				_ = ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
				CastExtensions.As<AppNavigationViewItem>((object)IEnumerator_object.Initialized);
				_ = 9;
				continue;
			case 10:
				if (P_0 != 0)
				{
					obj2 = 11;
					continue;
				}
				goto case 8;
			case 3:
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					obj2 = 0;
					if (IList_object.PatchAttribute != null)
					{
						obj2 = 2;
					}
					continue;
				}
				break;
			case 8:
				MarshalInspectable<object>.FromManaged((object)IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_00e3: Stack underflow*/, (byte*)(nint)this), (byte)(int)null != 0);
				_ = 4;
				continue;
			case 11:
				if (P_0 != 1)
				{
					obj2 = 1;
					if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
					{
						obj2 = 1;
					}
					continue;
				}
				goto case 12;
			case 5:
				return;
			case 2:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init();
				_ = 6;
				continue;
			case 12:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_0137: Stack underflow*/, (INotifyPropertyChanged)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_0131: Stack underflow*/, (uint)/*Error near IL_0131: Stack underflow*/, (nint*)(nint)this), ref *(uint*)null);
				_ = 0;
				if (IEnumerable_System_IDisposable.CombineAttribute == null)
				{
					_ = 0;
				}
				continue;
			case 6:
				_ = P_0 == 1;
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
				_ = 10;
				continue;
			case 9:
				return;
			case 7:
				break;
			}
			_ = ref Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute;
			((AsyncTaskMethodBuilder*)P_0)->Start(ref *(AccountViewModel._003CCreateAccount_003Ed__21*)IEnumerable_System_ComponentModel_INotifyPropertyChanged.Init());
			_ = 0;
			if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute != null)
			{
				_ = 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00踀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17958, 1790778545, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778545, new IntPtr(2737336174092L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00輀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778558, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00退()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778559, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00鄀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17961, 1790778556, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778556, new IntPtr(2737336156412L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00鈀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778557, new IntPtr(2737336153292L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00錀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00鐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778554, new IntPtr(2737336167852L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00销()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0044: Expected I, but got Obj
		//IL_0053: Expected Obj, but got I
		//IL_0058->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0063->IL0026: Incompatible stack heights: 3 vs 1
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
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)_003CModule_003E.CheckAccessibleAttribute(), ref *(object[]*)null);
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
	internal unsafe ObservableCollection<MobileGameModel> _FF00_FF00阀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778555, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<MobileGameModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<MobileGameModel> _FF00_FF00需()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<MobileGameModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00頀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778552, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00餀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17969, 1790778553, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778553, new IntPtr(2737336148092L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00騀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778502, new IntPtr(2737336167852L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00鬀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17971, 1790778503, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778503, new IntPtr(2737336178252L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00鰀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778500, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00鴀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17973, 1790778501, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778501, new IntPtr(2737336153292L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00鸀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778498, new IntPtr(2737336179292L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00鼀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0096: Expected I, but got Obj
		//IL_0071: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0085->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0090->IL0026: Incompatible stack heights: 2 vs 1
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
			case 0:
				return;
			case 2:
				IEnumerator_object.Do_Abi_MoveNext_2((nint)this, (byte*)(int)IEnumerator_object.Init());
				_ = 1;
				if (IList_object.PatchAttribute == null)
				{
					_ = 1;
				}
				break;
			case 3:
				if (IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_0096: Stack underflow*/, (byte*)(nint)this) == 0)
				{
					return;
				}
				obj2 = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<MobileGameModel> _FF00_FF00ꀀ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17976, 1790778499, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778499, new IntPtr(2737336150172L), 15);
		}
		return (IAsyncRelayCommand<MobileGameModel>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<MobileGameModel> _FF00_FF00ꄀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778496, new IntPtr(2737336168892L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<MobileGameModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00ꈀ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17978, 1790778497, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778497, new IntPtr(2737336149132L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00ꌀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778510, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00ꐀ(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_0062->IL0026: Incompatible stack heights: 5 vs 1
		//IL_0090->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006d->IL0026: Incompatible stack heights: 5 vs 1
		//IL_009b->IL0026: Incompatible stack heights: 2 vs 1
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
			case 1:
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
				_ = IEnumerator_object.Initialized;
				IEnumerator_object.Init();
				_ = 0;
				if (IList_object._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				MarshalInspectable<object>.FromManaged((object)/*Error near IL_007c: Stack underflow*/, (byte)IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_0077: Stack underflow*/, (byte*)(int)IEnumerator_object.Do_Abi_get_Current_0((nint)/*Error near IL_0072: Stack underflow*/, (nint*)/*Error near IL_0072: Stack underflow*/)) != 0);
				_ = 0;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00ꔀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778511, new IntPtr(2737336179292L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00ꘀ(ObservableCollection<MobileGameModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_009a: Expected I, but got Obj
		//IL_0084: Expected I, but got Obj
		//IL_00ca->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0026: Incompatible stack heights: 3 vs 1
		//IL_008e->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00b9->IL0026: Incompatible stack heights: 3 vs 1
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
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_0049: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0050: Member reference must be method, but was: Field*/;
			case 3:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
				_ = 4;
				break;
			case 4:
				return;
			case 1:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute);
				_ = 0;
				if (IReadOnlyList_object._initialized != 0)
				{
					_ = 0;
				}
				break;
			default:
				IReadOnlyList_object.ReflectLogicalAttribute = P_0;
				obj2 = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_A700(ObservableCollection<MobileGameModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778508, new IntPtr(2737336179292L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IRelayCommand<MobileGameModel> _FF00_FF00ꠀ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17984, 1790778509, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778509, new IntPtr(2737336151212L), 15);
		}
		return (IRelayCommand<MobileGameModel>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IRelayCommand<MobileGameModel> _FF00_FF00꤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778506, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
		return (IRelayCommand<MobileGameModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00ꨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778507, new IntPtr(2737336185532L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_AB00()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17987, 1790778504, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778504, new IntPtr(2737336160572L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00가()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778505, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00관()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778518, new IntPtr(2737336180332L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00글()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17990, 1790778519, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778519, new IntPtr(2737336161612L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe byte _FF00_FF00꼀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0079: Expected I, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_0068->IL0026: Incompatible stack heights: 5 vs 1
		//IL_0092->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0073->IL0026: Incompatible stack heights: 5 vs 1
		//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
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
			case 1:
				return 1;
			case 2:
				if (IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_0079: Stack underflow*/, (byte*)(nint)this) == 0)
				{
					_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					_ = IEnumerator_object.Initialized;
					IEnumerator_object.Init();
					IEnumerator_object.Do_Abi_MoveNext_2(unchecked((nint)null), (byte*)unchecked((nint)null));
					_ = 0;
					if (IList_object.PatchAttribute == null)
					{
						_ = 0;
					}
				}
				else
				{
					obj2 = 0;
					if (IReadOnlyList_System_IDisposable._initialized != 0)
					{
						obj2 = 1;
					}
				}
				break;
			default:
				return 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00뀀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17992, 1790778516, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778516, new IntPtr(2737336169932L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}
}
