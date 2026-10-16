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
using System.Threading;
using System.Threading.Tasks;
using ABI.Microsoft.UI.Composition;
using ABI.Microsoft.UI.Xaml;
using ABI.Microsoft.UI.Xaml.Controls;
using ABI.Microsoft.UI.Xaml.Markup;
using ABI.System.Collections;
using ABI.System.Collections.Generic;
using ABI.System.Collections.Specialized;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.WinUI.Animations;
using CommunityToolkit.WinUI.Controls;
using Mass.Application.Services;
using Mass.Domain.Desktop.Entities.LanGame;
using Mass.Domain.Desktop.Entities.NetGame;
using Mass.Domain.Desktop.Entities.RentalGame;
using Mass.Domain.Desktop.Interfaces;
using Mass.Domain.Desktop.Models;
using Mass.Domain.Value;
using Mass.Game.Proxy;
using Mass.WinUI.Controls;
using Mass.WinUI.Helpers;
using Mass.WinUI.Mass_WinUI_XamlTypeInfo;
using Mass.WinUI.Models;
using Mass.WinUI.Models.Messages;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.Windows.Foundation.UndockedRegFreeWinRTCS;
using Microsoft.Xaml.Interactivity;
using Serilog;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
using WinRT.Mass_WinUIVtableClasses;
using Windows.Foundation;

namespace Mass.WinUI.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails))]
public class DesktopViewModel : ObservableObject, IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddCharacter_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopViewModel _003C_003E4__this;

		private TaskAwaiter<(bool IsConfirmed, string Text)> _003C_003Eu__1;

		private TaskAwaiter<(bool isSuccess, bool needRetry)> _003C_003Eu__2;

		internal static object ExecuteProject;

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
		internal static bool CheckExtendedWriter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateVisibleDic()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_2800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777860, new IntPtr(2737335812652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_2900()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_04cb: Expected Obj, but got I4
			//IL_04cb: Expected Obj, but got Ref
			//IL_0517: Expected Obj, but got Ref
			//IL_0542: Expected Obj, but got Ref
			//IL_04f0: Expected Obj, but got Ref
			//IL_005f: Expected Obj, but got I
			//IL_0228: Expected Obj, but got Ref
			//IL_01ec: Expected Obj, but got Ref
			//IL_00f6: Expected Obj, but got I4
			//IL_00fb: Expected Obj, but got Ref
			//IL_010b: Expected Obj, but got Ref
			//IL_0113: Expected Obj, but got Ref
			//IL_015a: Expected I, but got Obj
			//IL_015a: Expected I, but got Obj
			//IL_015c: Expected Obj, but got I4
			//IL_016b: Expected Obj, but got I
			//IL_02ac: Expected Obj, but got Ref
			//IL_03cb: Expected Obj, but got I4
			//IL_03d0: Expected Obj, but got I4
			//IL_03d0: Expected Obj, but got Ref
			//IL_0255: Expected I4, but got Obj
			//IL_025f: Expected I, but got Obj
			//IL_0275: Expected Obj, but got I4
			//IL_0398: Expected Obj, but got Ref
			//IL_01ac: Expected Obj, but got Ref
			//IL_01b4: Expected Obj, but got Ref
			//IL_01b4: Expected Obj, but got Ref
			//IL_0285: Expected Obj, but got Ref
			//IL_0287: Expected Obj, but got VT
			//IL_0296: Expected Obj, but got I4
			//IL_0358: Expected Obj, but got I4
			//IL_035b: Expected Obj, but got I4
			//IL_0412: Expected Obj, but got I4
			//IL_0417: Expected Obj, but got I4
			//IL_0417: Expected Obj, but got Ref
			//IL_02e5: Expected Obj, but got I4
			//IL_02ea: Expected Obj, but got I4
			//IL_02ea: Expected Obj, but got Ref
			//IL_0123: Expected Obj, but got Ref
			//IL_0132: Expected Obj, but got I4
			//IL_01c6: Expected Obj, but got Ref
			//IL_00ec: Expected I4, but got Obj
			//IL_04df->IL0026: Incompatible stack types: I4 vs Obj
			//IL_054e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0506->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04ea->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0511->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0234->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0246->IL0073: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0105->IL0073: Incompatible stack types: I4 vs Obj
			//IL_011d->IL0073: Incompatible stack heights: 4 vs 1
			//IL_0170->IL0073: Incompatible stack types: I4 vs Obj
			//IL_02bc->IL0073: Incompatible stack types: I4 vs Obj
			//IL_03da->IL0073: Incompatible stack types: I4 vs Obj
			//IL_027f->IL0073: Incompatible stack types: I4 vs Obj
			//IL_03ac->IL0073: Incompatible stack types: I4 vs Obj
			//IL_01be->IL0073: Incompatible stack heights: 3 vs 1
			//IL_029b->IL0073: Incompatible stack types: I4 vs Obj
			//IL_036f->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0421->IL0073: Incompatible stack types: I4 vs Obj
			//IL_02f4->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0222->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0386->IL0246: Incompatible stack heights: 1 vs 0
			//IL_01da->IL0073: Incompatible stack types: I4 vs Obj
			//IL_019b->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0205->IL0073: Incompatible stack types: I4 vs Obj
			//IL_017b->IL0073: Incompatible stack types: I4 vs Obj
			//IL_03b7->IL0073: Incompatible stack types: I4 vs Obj
			//IL_02a6->IL0073: Incompatible stack types: I4 vs Obj
			//IL_037a->IL0073: Incompatible stack types: I4 vs Obj
			//IL_030f->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0390->IL0073: Incompatible stack heights: 2 vs 1
			//IL_01e5->IL0073: Incompatible stack types: I4 vs Obj
			//IL_01a6->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0210->IL0073: Incompatible stack types: I4 vs Obj
			//IL_031a->IL0073: Incompatible stack types: I4 vs Obj
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
				case 2:
					if (obj == null)
					{
						obj3 = 0;
						if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute == null)
						{
							obj3 = 0;
						}
						goto IL_0073;
					}
					goto IL_0234;
				default:
					goto IL_04c3;
				case 5:
					obj = __KnownINotifyPropertyChangingArgs.CanDelete;
					obj2 = 4;
					if (__KnownINotifyPropertyChangingArgs.OrderId != null)
					{
						obj2 = 0;
					}
					break;
				case 1:
					_ = ref __KnownINotifyPropertyChangingArgs.Price;
					/*Error near IL_0517: Member reference must be method, but was: Field*/;
				case 3:
					return;
				case 4:
					{
						obj = __KnownINotifyPropertyChangingArgs.Number;
						obj2 = 2;
						break;
					}
					IL_04c3:
					__KnownINotifyPropertyChangingArgs.OperationText = (PropertyChangingEventArgs)(-2);
					obj2 = 0;
					if (__KnownINotifyPropertyChangingArgs.Type == null)
					{
						obj2 = 1;
					}
					break;
					IL_0222:
					obj = Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute;
					obj3 = 6;
					goto IL_0073;
					IL_0073:
					while (true)
					{
						switch ((int)obj3)
						{
						case 3:
							obj = 0;
							IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized = 0;
							obj3 = 25;
							continue;
						case 4:
							_ = ref IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute;
							_ = ref obj;
							CastExtensions.As<InvokeCommandAction>((object)Unsafe.AsPointer(ref this));
							_ = 21;
							continue;
						case 18:
							IList_object.PatchAttribute = null;
							obj = 17;
							obj3 = obj;
							continue;
						case 5:
						{
							object obj4 = obj;
							IEnumerator_object._002Ecctor();
							obj = IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)obj4, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)obj, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)1, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(IEnumerator_object.DecorateAutomatableAttribute() ? 1 : 0));
							obj3 = 1;
							if (IReadOnlyList_object.ReflectLogicalAttribute != null)
							{
								obj3 = 1;
							}
							continue;
						}
						case 1:
							if (MarshalInterface<INotifyPropertyChanged>.FromAbi((IntPtr)(nint)(&obj)) != null)
							{
								obj3 = 12;
								if (IEnumerable_System_IDisposable._initialized != 0)
								{
									obj3 = 28;
								}
								continue;
							}
							goto case 15;
						case 11:
							_ = ref IEnumerable_System_IDisposable.CombineAttribute;
							((XamlUserType)(&obj)).BoxType<double>((object)Unsafe.AsPointer(ref this));
							_ = 24;
							continue;
						case 25:
							IEnumerable_object.ReflectSetAttribute = obj;
							obj3 = 11;
							if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute != null)
							{
								obj3 = 6;
							}
							continue;
						case 2:
							if (MarshalInterface<IEnumerator<INotifyPropertyChanged>>.FromManaged((IEnumerator<INotifyPropertyChanged>)(&obj)) != (IntPtr)0)
							{
								obj3 = 6;
								if (Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute != null)
								{
									obj3 = 22;
								}
								continue;
							}
							goto case 3;
						case 19:
						case 28:
							IListMethods<object>.Abi_GetView_2((IntPtr)(nint)(&obj));
							obj3 = 26;
							continue;
						case 16:
							break;
						case 27:
							goto IL_0234;
						case 8:
							obj = IListMethods<object>.Abi_GetMany_10((IntPtr)/*Error near IL_0273: Stack underflow*/, (uint)/*Error near IL_0273: Stack underflow*/, ref *(object[]*)IList_object.Do_Abi_RemoveAt_6((nint)/*Error near IL_026e: Stack underflow*/, IList_object.Do_Abi_InsertAt_5((nint)/*Error near IL_0269: Stack underflow*/, (uint)/*Error near IL_0269: Stack underflow*/, (nint)(int)IList_object.Do_Abi_SetAt_4((nint)/*Error near IL_0264: Stack underflow*/, (uint)/*Error near IL_0264: Stack underflow*/, (nint)(int)IList_object.Do_Abi_IndexOf_3((nint)/*Error near IL_025f: Stack underflow*/, (nint)/*Error near IL_025f: Stack underflow*/, (uint*)(int)IList_object.Do_Abi_GetAt_0((nint)/*Error near IL_0255: Stack underflow*/, (uint)(int)Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute, (nint*)(int)IList_object.Init()), (byte*)(nint)Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute)))));
							obj3 = 2;
							continue;
						default:
							obj = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout;
							obj3 = 18;
							if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator == null)
							{
								obj3 = 18;
							}
							continue;
						case 6:
							__KnownINotifyPropertyChangingArgs.Notes = null;
							obj3 = 7;
							continue;
						case 24:
							return;
						case 17:
							obj = -1;
							__KnownINotifyPropertyChangingArgs.LoginAt = (PropertyChangingEventArgs)(-1);
							obj3 = 14;
							continue;
						case 20:
							if (obj == null)
							{
								obj3 = 12;
								if (__KnownINotifyPropertyChangingArgs.IsMyself != null)
								{
									obj3 = 11;
								}
								continue;
							}
							goto case 5;
						case 14:
						case 22:
						{
							uint num = IReadOnlyListMethods<IDisposable>.Abi_GetMany_3((IntPtr)/*Error near IL_0354: Stack underflow*/, (uint)/*Error near IL_0354: Stack underflow*/, ref *(IDisposable[]*)(&obj));
							obj = num;
							obj = num;
							obj3 = 20;
							if (__KnownINotifyPropertyChangingArgs.ShowMaxPlayer == null)
							{
								obj3 = 9;
							}
							continue;
						}
						case 23:
							if (!IReadOnlyList_System_IDisposable.Initialized)
							{
								_ = 10;
								continue;
							}
							goto case 8;
						case 9:
							__KnownINotifyPropertyChangingArgs.MaxPlayers = (PropertyChangingEventArgs)obj;
							obj3 = 2;
							if (__KnownINotifyPropertyChangingArgs.Description == null)
							{
								obj3 = 4;
							}
							continue;
						case 21:
							return;
						case 7:
							obj = -1;
							__KnownINotifyPropertyChangingArgs.Version = (PropertyChangingEventArgs)(-1);
							obj3 = 19;
							continue;
						case 15:
							obj = 1;
							__KnownINotifyPropertyChangingArgs.BackgroundImageUrl = (PropertyChangingEventArgs)1;
							obj3 = 9;
							continue;
						case 10:
						case 12:
						case 26:
							goto IL_04c3;
						}
						break;
					}
					goto IL_0222;
					IL_0234:
					if ((nint)obj != 1)
					{
						obj3 = 23;
						goto IL_0073;
					}
					goto IL_0222;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_2A00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777861, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_2B00()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00Ⰰ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777858, new IntPtr(2737335820972L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00ⴀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777859, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_2E00()
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_2F00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777856, new IntPtr(2737335812652L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_3000(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777857, new IntPtr(2737335818892L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_3100(object P_0)
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
	private struct _003CAddRandomCharacter_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopViewModel _003C_003E4__this;

		private TaskAwaiter<string?> _003C_003Eu__1;

		internal static object ReflectCentralObject;

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
		internal static bool ReflectStatelessDecorator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LoadManager()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_2100()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777870, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_2200()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0075: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I
			//IL_009f: Expected Obj, but got Ref
			//IL_00b3: Expected Obj, but got Ref
			//IL_01ab: Expected Obj, but got Ref
			//IL_016e: Expected Obj, but got Ref
			//IL_0152: Expected I, but got Obj
			//IL_015e: Expected Obj, but got I4
			//IL_01d2: Expected Obj, but got Ref
			//IL_01e9: Expected Obj, but got I4
			//IL_01ee: Expected Obj, but got I4
			//IL_01ee: Expected Obj, but got Ref
			//IL_0212: Expected Obj, but got I4
			//IL_0217: Expected Obj, but got I4
			//IL_0217: Expected Obj, but got Ref
			//IL_0254: Expected Obj, but got Ref
			//IL_025d: Expected Obj, but got I4
			//IL_0269: Expected I, but got Obj
			//IL_0122: Expected I4, but got Obj
			//IL_008e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ab->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01c1->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_00e5->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_0099->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01cc->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_017e->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_0168->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_01e4->IL00e9: Incompatible stack heights: 2 vs 1
			//IL_0202->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_022b->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_019a->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_024c->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_020d->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_0236->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_01a5->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_0278->IL00e9: Incompatible stack types: I4 vs Obj
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
				case 2:
					obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					obj2 = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 0;
					}
					continue;
				case 1:
					*((int, nint)*)(nint)/*Error near IL_007a: Stack underflow*/ = ((int)/*Error near IL_007a: Stack underflow*/, (nint)Unsafe.AsPointer(ref IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute));
					obj2 = 4;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 2;
					}
					continue;
				case 3:
					obj = IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute;
					obj2 = 2;
					continue;
				case 5:
					break;
				case 4:
					return;
				default:
					{
						if (obj != null)
						{
							obj3 = 12;
							goto IL_00e9;
						}
						goto IL_01a5;
					}
					IL_01a5:
					obj = Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute;
					obj3 = 1;
					if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute == null)
					{
						obj3 = 0;
					}
					goto IL_00e9;
					IL_00e9:
					while (true)
					{
						switch ((int)obj3)
						{
						case 7:
							return;
						case 2:
							obj = IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_015c: Stack underflow*/, (uint)/*Error near IL_015c: Stack underflow*/, ref *(INotifyPropertyChanged[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_0157: Stack underflow*/, (uint)/*Error near IL_0157: Stack underflow*/, (uint)/*Error near IL_0157: Stack underflow*/, (nint)/*Error near IL_0157: Stack underflow*/, (uint*)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_IndexOf_2((nint)/*Error near IL_0152: Stack underflow*/, (nint)/*Error near IL_0152: Stack underflow*/, (uint*)/*Error near IL_0152: Stack underflow*/, (byte*)(nint)obj)));
							obj3 = 4;
							continue;
						case 1:
							IEnumerable_object._initialized = unchecked((nint)null);
							obj3 = 5;
							continue;
						case 11:
							IEnumerableMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(&obj));
							obj3 = 0;
							if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute != null)
							{
								obj3 = 0;
							}
							continue;
						case 10:
							goto end_IL_00e9;
						case 3:
							_ = ref Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute;
							((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CAddRandomCharacter_003Ed__1, AccountViewModel._003CLoginByHistory_003Ed__25>(ref this));
							_ = 7;
							continue;
						case 5:
							obj = -1;
							Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute = -1;
							obj3 = 11;
							if (Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute == null)
							{
								obj3 = 7;
							}
							continue;
						case 8:
							obj = 0;
							Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute = 0;
							obj3 = 1;
							if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance == null)
							{
								obj3 = 9;
							}
							continue;
						case 4:
							IListMethods<object>.Abi_Clear_9((IntPtr)(nint)(&obj));
							if ((int)/*Error near IL_0242: Stack underflow*/ == 0)
							{
								obj3 = 8;
								continue;
							}
							goto case 11;
						case 9:
							_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule = obj;
							obj = 3;
							obj3 = obj;
							continue;
						case 12:
							if (IList_object.Do_Abi_RemoveAtEnd_8((nint)obj) == 0)
							{
								obj3 = 6;
								continue;
							}
							goto case 2;
						}
						goto end_IL_0026;
						continue;
						end_IL_00e9:
						break;
					}
					goto IL_01a5;
					end_IL_0026:
					break;
				}
				IReadOnlyList_System_IDisposable._initialized = -2;
				obj2 = 0;
				if (IReadOnlyList_object._initialized == 0)
				{
					obj2 = 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_2300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777871, new IntPtr(2737335812652L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_2400()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_2500()
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_2600()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777868, new IntPtr(2737335798092L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_2700(object P_0)
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLaunchEchoClient_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object ReflectFilteredSummarizer;

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
		internal static bool DecorateAutomatedProgram()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectPassiveTemplate()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ᨀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777869, new IntPtr(2737335812652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_1B00()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0051: Expected Obj, but got Ref
			//IL_005a: Expected Obj, but got I4
			//IL_03d2: Expected Obj, but got Ref
			//IL_008c: Expected Obj, but got Ref
			//IL_008e: Expected Obj, but got I
			//IL_0065: Expected Obj, but got Ref
			//IL_0076: Expected Obj, but got I
			//IL_0179: Expected Obj, but got Ref
			//IL_018a: Expected Obj, but got I
			//IL_02a9: Expected I, but got Obj
			//IL_02b1: Expected I, but got Obj
			//IL_02b8: Expected Obj, but got I4
			//IL_02c7: Expected Obj, but got VT
			//IL_026f: Expected Obj, but got I4
			//IL_0274: Expected Obj, but got I4
			//IL_0274: Expected Obj, but got Ref
			//IL_01b9: Expected Obj, but got Ref
			//IL_0247: Expected Obj, but got Ref
			//IL_0247: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected Obj, but got I
			//IL_0232: Expected Obj, but got I4
			//IL_0237: Expected Obj, but got I4
			//IL_0237: Expected Obj, but got Ref
			//IL_01a0: Expected Obj, but got Ref
			//IL_01a8: Expected Obj, but got Ref
			//IL_01a8: Expected Obj, but got Ref
			//IL_0154: Expected I, but got Obj
			//IL_0154: Expected Obj, but got Ref
			//IL_03eb->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00a2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_007b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03f6->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00ad->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0086->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01fc->IL01dd: Incompatible stack heights: 1 vs 0
			//IL_0141->IL00d8: Incompatible stack heights: 2 vs 1
			//IL_01b2->IL00d8: Incompatible stack heights: 3 vs 1
			//IL_0206->IL00d8: Incompatible stack heights: 2 vs 1
			//IL_014c->IL00d8: Incompatible stack heights: 2 vs 1
			//IL_022d->IL00d8: Incompatible stack heights: 2 vs 1
			//IL_0304->IL0304: Incompatible stack heights: 0 vs 1
			//IL_02ff->IL02ff: Incompatible stack heights: 4 vs 3
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
					int num;
					switch ((int)obj2)
					{
					case 1:
						return;
					case 5:
						obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
						obj2 = 4;
						if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
						{
							obj2 = 1;
						}
						continue;
					case 4:
						obj = IList_object._initialized;
						obj2 = 2;
						if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
						{
							obj2 = 1;
						}
						continue;
					case 2:
						if (obj != null)
						{
							num = 1;
							if (IReadOnlyList_System_IDisposable._initialized == 0)
							{
								num = 0;
							}
							goto IL_00d8;
						}
						goto IL_0173;
					case 3:
						{
							IEnumeratorMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, nint*, int>)/*Error near IL_03d7: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)/*Error near IL_03d7: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)/*Error near IL_03d7: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, uint*, int>)Unsafe.AsPointer(ref __KnownINotifyPropertyChangingArgs.Description));
							_ = 0;
							if (__KnownINotifyPropertyChangingArgs.Characters != null)
							{
								_ = 1;
							}
							continue;
						}
						IL_00d8:
						while (true)
						{
							switch (num)
							{
							case 11:
								return;
							case 9:
							case 12:
								break;
							case 3:
							case 8:
								IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_012d: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_012d: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_012d: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(&obj));
								_ = 6;
								if (IReadOnlyList_object.ReflectLogicalAttribute == null)
								{
									_ = 12;
								}
								continue;
							case 15:
								IEnumerator_System_IDisposable._initialized = (nint)obj;
								num = 11;
								if (IEnumerable_System_IDisposable._initialized == 0)
								{
									num = 14;
								}
								continue;
							case 2:
								goto end_IL_00d8;
							case 14:
								_ = ref GlobalVtableLookup.CreateAttribute;
								((IEnumerable<NeteaseAccount>)(&obj)).Where((Func<NeteaseAccount, bool>)Unsafe.AsPointer(ref this));
								_ = 11;
								continue;
							case 5:
								if (MarshalInterface<IEnumerator<INotifyPropertyChanged>>.FromManaged((IEnumerator<INotifyPropertyChanged>)(&obj)) != (IntPtr)0)
								{
									num = 2;
									if (Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute == null)
									{
										num = 3;
									}
									continue;
								}
								goto case 4;
							case 1:
								if (!IEnumerable_System_ComponentModel_INotifyPropertyChanged.DecorateSeparatedAttribute())
								{
									break;
								}
								_ = 7;
								continue;
							case 7:
							case 13:
							{
								object obj3 = obj;
								IEnumerable_System_ComponentModel_INotifyPropertyChanged enumerable_System_ComponentModel_INotifyPropertyChanged = IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectMonoAttribute();
								if (enumerable_System_ComponentModel_INotifyPropertyChanged == null)
								{
									_ = 16;
									continue;
								}
								object decorateGroupedGenerator = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator;
								if (decorateGroupedGenerator == null)
								{
									_ = __KnownINotifyPropertyChangingArgs.Notes;
									__KnownINotifyPropertyChangingArgs.CreateAt = (PropertyChangingEventArgs)new IEnumeratorMethods<INotifyPropertyChanged>((IntPtr)(nint)(delegate* unmanaged[Stdcall]<nint, uint*, uint>)(&IList_object.Do_Abi_get_Size_1));
								}
								((AsyncTaskMethodBuilder*)obj3)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)enumerable_System_ComponentModel_INotifyPropertyChanged, ref *(AccountViewModel._003CExportAccounts_003Ed__26*)decorateGroupedGenerator);
								goto IL_0304;
							}
							case 10:
								obj = -1;
								Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute = -1;
								num = 8;
								continue;
							case 6:
								Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute = (object)default(MarshalInspectable<>);
								num = 10;
								continue;
							case 4:
								obj = 0;
								Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute = 0;
								num = 5;
								if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute != null)
								{
									num = 15;
								}
								continue;
							default:
								obj = IListMethods<object>.Abi_GetMany_10((IntPtr)/*Error near IL_02b6: Stack underflow*/, IList_object.Do_Abi_InsertAt_5((nint)/*Error near IL_02a9: Stack underflow*/, (uint)/*Error near IL_02a9: Stack underflow*/, (nint)obj), ref *(object[]*)IList_object.Do_Abi_RemoveAt_6((nint)obj, 2u));
								num = 5;
								if (!_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout)
								{
									num = 3;
								}
								continue;
							case 16:
								{
									goto IL_0304;
								}
								IL_0304:
								obj = ((null is ComWrappersSupport) ? null : null);
								num = 0;
								if (__KnownINotifyPropertyChangingArgs.Message == null)
								{
									num = 0;
								}
								continue;
							}
							goto end_IL_0026;
							continue;
							end_IL_00d8:
							break;
						}
						goto IL_0173;
						IL_0173:
						obj = IEnumerable_System_IDisposable.CombineAttribute;
						num = 6;
						if (IEnumerable_object.ReflectSetAttribute == null)
						{
							num = 2;
						}
						goto IL_00d8;
					}
					break;
					continue;
					end_IL_0026:
					break;
				}
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = -2;
				obj = 3;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00ᰀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777866, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00ᴀ()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00Ḁ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777867, new IntPtr(2737335798092L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00ἀ()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_2000(object P_0)
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
	private struct _003CLaunchGame_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object CustomizePredicate;

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
		internal static bool CheckOperationalDecider()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object InstantiateAdapter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ᄀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777864, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ሀ()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0066: Expected Obj, but got I4
			//IL_0066: Expected Obj, but got Ref
			//IL_0077: Expected Obj, but got Ref
			//IL_008c: Expected Obj, but got Ref
			//IL_008e: Expected Obj, but got I
			//IL_004e: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I
			//IL_0059: Expected Obj, but got I4
			//IL_02aa: Expected I4, but got Obj
			//IL_0225: Expected Obj, but got Ref
			//IL_028f: Expected Obj, but got I4
			//IL_012e: Expected Obj, but got I4
			//IL_0133: Expected Obj, but got I4
			//IL_0133: Expected Obj, but got Ref
			//IL_020d: Expected Obj, but got Ref
			//IL_0307: Expected I, but got Obj
			//IL_01af: Expected I, but got Obj
			//IL_01bd: Expected I, but got Obj
			//IL_01bf: Expected Obj, but got I4
			//IL_025e: Expected Obj, but got Ref
			//IL_01e0: Expected Obj, but got Ref
			//IL_01e8: Expected Obj, but got Ref
			//IL_01e8: Expected Obj, but got Ref
			//IL_0197: Expected I, but got Obj
			//IL_0234: Expected Obj, but got I4
			//IL_0239: Expected Obj, but got I4
			//IL_0239: Expected Obj, but got Ref
			//IL_02fb: Expected Obj, but got I4
			//IL_0124: Expected I4, but got Obj
			//IL_033f: Expected I, but got Obj
			//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0086->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00bf->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_00ad->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02b9->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_022f->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_013d->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_021d->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_01c9->IL00c3: Incompatible stack heights: 3 vs 1
			//IL_015d->IL00c3: Incompatible stack heights: 7 vs 1
			//IL_0274->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_01fc->IL00c3: Incompatible stack heights: 3 vs 1
			//IL_024d->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_01da->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_035b->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_03a8->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_031d->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_027f->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0207->IL00c3: Incompatible stack heights: 3 vs 1
			//IL_01a8->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0258->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_03b3->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_032e->IL0345: Incompatible stack types: I4 vs Obj
			//IL_0371->IL0388: Incompatible stack heights: 2 vs 1
			//IL_034a->IL034a: Incompatible stack heights: 0 vs 1
			//IL_038d->IL038d: Incompatible stack heights: 0 vs 1
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
					object obj3;
					switch ((int)obj2)
					{
					case 5:
						break;
					case 1:
						IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = -2;
						obj2 = 3;
						continue;
					case 2:
						return;
					case 3:
						/*Error near IL_007c: Stack underflow*/((object[])/*Error near IL_007c: Stack underflow*/, (nint)Unsafe.AsPointer(ref IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized));
						obj2 = 2;
						continue;
					case 4:
						obj = IList_object._initialized;
						obj2 = 0;
						if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
						{
							obj2 = 0;
						}
						continue;
					default:
						{
							if (obj == null)
							{
								obj3 = 19;
								goto IL_00c3;
							}
							goto IL_02a3;
						}
						IL_02a3:
						if (IList_object.Do_Abi_RemoveAt_6((nint)/*Error near IL_02aa: Stack underflow*/, (uint)(int)obj) == 0)
						{
							goto case 1;
						}
						obj3 = 15;
						goto IL_00c3;
						IL_00c3:
						while (true)
						{
							switch ((int)obj3)
							{
							case 3:
							case 5:
							case 12:
								break;
							case 1:
								return;
							case 7:
								obj = -1;
								IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute = -1;
								obj3 = 4;
								continue;
							case 16:
								_ = IReadOnlyList_System_IDisposable._initialized;
								IEnumerator_object.LoadAttribute();
								_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Initialized;
								_ = null;
								_ = null;
								IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init();
								_ = 12;
								continue;
							case 21:
							{
								uint num2 = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_0197: Stack underflow*/, (uint)/*Error near IL_0197: Stack underflow*/, (uint)/*Error near IL_0197: Stack underflow*/, (nint)/*Error near IL_0197: Stack underflow*/, (uint*)(nint)obj);
								if (num2 == 0)
								{
									obj3 = 9;
									continue;
								}
								PropertyChangingEventArgs val2;
								if (__KnownINotifyPropertyChangingArgs.Name == null)
								{
									val2 = (__KnownINotifyPropertyChangingArgs.Content = (PropertyChangingEventArgs)new IReadOnlyListMethods<IDisposable>((IntPtr)(int)num2, (IDisposable)__KnownINotifyPropertyChangingArgs.IsMyself, ref *(uint*)(delegate* unmanaged[Stdcall]<nint, byte*, uint>)(&IEnumerator_System_ComponentModel_INotifyPropertyChanged.Do_Abi_MoveNext_2)));
								}
								((AsyncTaskMethodBuilder*)/*Error near IL_038d: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<ContentDialogResult>*)/*Error near IL_038d: Stack underflow*/, ref *(AccountViewModel._003CLoginByHistory_003Ed__25*)val2);
								goto IL_038d;
							}
							case 13:
							{
								IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)/*Error near IL_01af: Stack underflow*/, (uint*)(nint)obj);
								object obj4 = obj;
								IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
								obj = IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)obj4);
								_ = 14;
								continue;
							}
							case 2:
								if (obj == null)
								{
									obj3 = 16;
									continue;
								}
								goto case 21;
							case 20:
								_ = ref GlobalVtableLookup.CreateAttribute;
								((IEnumerable<NeteaseAccount>)(&obj)).Where((Func<NeteaseAccount, bool>)Unsafe.AsPointer(ref this));
								_ = 0;
								if (Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute == null)
								{
									_ = 1;
								}
								continue;
							case 10:
								Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute = null;
								obj3 = 7;
								continue;
							default:
								Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute = obj;
								obj3 = 20;
								continue;
							case 22:
								obj = 0;
								Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute = 0;
								obj3 = 0;
								if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute == null)
								{
									obj3 = 0;
								}
								continue;
							case 18:
							case 19:
								obj = Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute;
								obj3 = 10;
								if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute == null)
								{
									obj3 = 6;
								}
								continue;
							case 4:
							case 17:
								IListMethods<object>.Abi_RemoveAtEnd_8((IntPtr)(nint)(&obj));
								obj = 5;
								goto IL_00bf;
							case 6:
								goto IL_02a3;
							case 14:
								if (IListMethods<object>.Abi_GetMany_10((IntPtr)/*Error near IL_02ed: Stack underflow*/, (uint)/*Error near IL_02ed: Stack underflow*/, ref *(object[]*)(&obj)) != 0)
								{
									obj = 17;
									goto IL_00bf;
								}
								goto case 22;
							case 11:
							case 15:
							{
								uint num = IList_object.Do_Abi_RemoveAtEnd_8((nint)obj);
								if (num == 0)
								{
									obj3 = 8;
									continue;
								}
								bool s_hasTimeout = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout;
								IEnumeratorMethods<INotifyPropertyChanged> val = (IEnumeratorMethods<INotifyPropertyChanged>)(object)s_hasTimeout;
								if (!s_hasTimeout)
								{
									val = (IEnumeratorMethods<INotifyPropertyChanged>)(object)(__KnownINotifyPropertyChangingArgs.Username = (PropertyChangingEventArgs)new IEnumeratorMethods<INotifyPropertyChanged>((IntPtr)_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator, ref *(INotifyPropertyChanged[]*)(delegate* unmanaged[Stdcall]<nint, uint, nint, uint>)(&IList_object.Do_Abi_ReplaceAll_11)));
								}
								((AsyncTaskMethodBuilder*)/*Error near IL_034a: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<string>*)num, ref *(AccountViewModel._003CExportAccounts_003Ed__26*)val);
								goto IL_034a;
							}
							case 8:
								goto IL_034a;
							case 9:
								{
									goto IL_038d;
								}
								IL_034a:
								obj = null as string;
								obj3 = 2;
								continue;
								IL_038d:
								obj = ((null is INotifyCollectionChangedMethods) ? null : null);
								obj3 = 4;
								if (__KnownINotifyPropertyChangingArgs.ShowMaxPlayer == null)
								{
									obj3 = 13;
								}
								continue;
								IL_00bf:
								obj3 = obj;
								continue;
							}
							break;
						}
						goto case 1;
					}
					break;
				}
				obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
				obj = 4;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ጀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777865, new IntPtr(2737335801212L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_1400()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00ᔀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777878, new IntPtr(2737335806412L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00ᘀ()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ᜀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777879, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_1800(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ᤀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777876, new IntPtr(2737335824092L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLaunchHeadlessShadowClient_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object CheckIdentifiableRecord;

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
		internal static bool AttachViewer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AddCalculator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_0700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777877, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ࠀ()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_033e: Expected Obj, but got Ref
			//IL_0060: Expected Obj, but got Ref
			//IL_0071: Expected Obj, but got I
			//IL_0050: Expected Obj, but got Ref
			//IL_0314: Expected Obj, but got Ref
			//IL_021d: Expected Obj, but got Ref
			//IL_00fa: Expected Obj, but got I4
			//IL_00ff: Expected Obj, but got Ref
			//IL_0177: Expected Obj, but got Ref
			//IL_01d3: Expected Obj, but got I4
			//IL_01d8: Expected Obj, but got I4
			//IL_01d8: Expected Obj, but got Ref
			//IL_0188: Expected I, but got Obj
			//IL_01a0: Expected I, but got Obj
			//IL_01af: Expected Obj, but got I4
			//IL_00e3: Expected Obj, but got Ref
			//IL_00eb: Expected Obj, but got Ref
			//IL_0134: Expected Obj, but got Ref
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Expected Obj, but got I
			//IL_0250: Expected Obj, but got I
			//IL_0250: Expected I4, but got Obj
			//IL_0354->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0076->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_032d->IL0026: Incompatible stack heights: 2 vs 1
			//IL_035f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0081->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0338->IL0026: Incompatible stack heights: 2 vs 1
			//IL_020c->IL0097: Incompatible stack heights: 2 vs 1
			//IL_01c3->IL0097: Incompatible stack heights: 3 vs 1
			//IL_00f5->IL0097: Incompatible stack heights: 4 vs 1
			//IL_0217->IL0097: Incompatible stack heights: 2 vs 1
			//IL_01ce->IL0097: Incompatible stack heights: 3 vs 1
			//IL_023f->IL0256: Incompatible stack heights: 2 vs 1
			//IL_025b->IL025b: Incompatible stack heights: 0 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 4:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = -2;
					obj2 = 5;
					break;
				case 2:
					obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
					obj2 = 1;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
					{
						obj2 = 1;
					}
					break;
				default:
					if (obj != null)
					{
						num = 9;
						goto IL_0097;
					}
					goto IL_0217;
				case 5:
					IReadOnlyListMethods<IDisposable>.Abi_GetAt_0((IntPtr)/*Error near IL_0319: Stack underflow*/, (uint)Unsafe.AsPointer(ref __KnownINotifyPropertyChangingArgs.LoginAt));
					_ = 0;
					if (__KnownINotifyPropertyChangingArgs.Message != null)
					{
						_ = 3;
					}
					break;
				case 1:
					obj = __KnownINotifyPropertyChangingArgs.CharacterName;
					obj2 = 0;
					if (__KnownINotifyPropertyChangingArgs.IsSelected == null)
					{
						obj2 = 0;
					}
					break;
				case 3:
					return;
					IL_0097:
					while (true)
					{
						switch (num)
						{
						case 13:
							_ = ref IList_object._initialized;
							_ = ref obj;
							CastExtensions.As<MainContent>((object)Unsafe.AsPointer(ref this));
							_ = 3;
							continue;
						case 1:
							obj = -1;
							IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = -1;
							num = 2;
							continue;
						case 3:
							return;
						case 9:
						{
							object obj3 = obj;
							IEnumerator_object._002Ecctor();
							if (obj3 == null)
							{
								num = 4;
								continue;
							}
							goto case 10;
						}
						case 14:
							IReadOnlyList_System_IDisposable._initialized = unchecked((nint)default(DependencyObject));
							num = 1;
							if (IReadOnlyList_object.ReflectLogicalAttribute != null)
							{
								num = 1;
							}
							continue;
						case 11:
							if (MarshalInterface<INotifyPropertyChanged>.FromAbi((IntPtr)(nint)(&obj)) == null)
							{
								num = 6;
								continue;
							}
							goto case 2;
						case 5:
							IEnumerator_System_IDisposable.ReflectTransferableAttribute = obj;
							num = 13;
							continue;
						case 10:
						{
							uint num2 = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_0188: Stack underflow*/, (uint)/*Error near IL_0188: Stack underflow*/, (uint)/*Error near IL_0188: Stack underflow*/, (nint)/*Error near IL_0188: Stack underflow*/, (uint*)(nint)obj);
							if (num2 == 0)
							{
								num = 7;
								continue;
							}
							object val;
							if (Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute == null)
							{
								val = (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute = new IListMethods<object>((IntPtr)(int)num2, (uint)(int)Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute, (object)(delegate* unmanaged[Stdcall]<nint, uint, nint*, uint>)(&IList_object.Do_Abi_GetAt_0)));
							}
							((ILogger)/*Error near IL_025b: Stack underflow*/).Warning<string>((string)/*Error near IL_025b: Stack underflow*/, (string)val);
							goto IL_025b;
						}
						case 12:
							IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)/*Error near IL_01a0: Stack underflow*/, (uint*)(nint)obj);
							IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
							obj = IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)1);
							_ = 11;
							if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute == null)
							{
								_ = 10;
							}
							continue;
						case 6:
							obj = 0;
							Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute = 0;
							num = 5;
							continue;
						case 2:
							IListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_01f8: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_01f8: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)/*Error near IL_01f8: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_01f8: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_01f8: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_01f8: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int>)/*Error near IL_01f8: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, int>)/*Error near IL_01f8: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_01f8: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_01f8: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_01f8: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, int>)(&obj));
							_ = 0;
							if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute == null)
							{
								_ = 0;
							}
							continue;
						case 8:
							goto IL_0217;
						case 7:
							{
								goto IL_025b;
							}
							IL_025b:
							obj = ((null is MarshalInterface<>) ? null : null);
							num = 12;
							continue;
						}
						break;
					}
					goto case 4;
					IL_0217:
					obj = Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute;
					num = 14;
					goto IL_0097;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_0900()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777874, new IntPtr(2737335824092L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_0A00()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_0B00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777875, new IntPtr(2737335812652L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_0C00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777872, new IntPtr(2737335823052L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_0D00()
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_0E00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777873, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ༀ(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00က(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777886, new IntPtr(2737335806412L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLaunchShadowClient_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object ReflectInternalPolicy;

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
		internal static bool ParseMonitor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectHiddenModule()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777887, new IntPtr(2737335819932L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00Ā()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_00a1: Expected Obj, but got I4
			//IL_00a1: Expected Obj, but got Ref
			//IL_00b0: Expected Obj, but got I
			//IL_0075: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got Ref
			//IL_00c8: Expected Obj, but got I
			//IL_02c0: Expected I, but got Obj
			//IL_02c0: Expected I4, but got Obj
			//IL_013b: Expected Obj, but got Ref
			//IL_014a: Expected Obj, but got I
			//IL_0291: Expected I, but got Obj
			//IL_029e: Expected I, but got Obj
			//IL_02a0: Expected Obj, but got I4
			//IL_01d2: Expected Obj, but got Ref
			//IL_0189: Expected Obj, but got Ref
			//IL_0194: Expected Obj, but got I4
			//IL_01ff: Expected Obj, but got Ref
			//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Expected Obj, but got I4
			//IL_0164: Expected Obj, but got Ref
			//IL_023f: Expected Obj, but got I4
			//IL_0244: Expected Obj, but got I4
			//IL_0244: Expected Obj, but got Ref
			//IL_02f8: Expected I, but got Obj
			//IL_012e: Expected I4, but got Obj
			//IL_00b5->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00e5->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_0099->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_022f->IL00e9: Incompatible stack heights: 2 vs 1
			//IL_012e->IL02b9: Incompatible stack heights: 0 vs 1
			//IL_02d6->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_023a->IL00e9: Incompatible stack heights: 2 vs 1
			//IL_014f->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_02aa->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_01ee->IL00e9: Incompatible stack heights: 2 vs 1
			//IL_020f->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_0274->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_0178->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_0258->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_015a->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_01f9->IL00e9: Incompatible stack heights: 2 vs 1
			//IL_028a->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_031e->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_0183->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_0263->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_0303->IL0303: Incompatible stack heights: 0 vs 1
			//IL_02fe->IL02fe: Incompatible stack heights: 1 vs 2
			//IL_0329->IL00e9: Incompatible stack types: I4 vs Obj
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				object obj4;
				uint num;
				PropertyChangingEventArgs userId;
				switch ((int)obj2)
				{
				case 4:
					obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					obj2 = 1;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 2;
					}
					break;
				case 3:
					*((int, nint)*)(nint)/*Error near IL_007a: Stack underflow*/ = ((int)/*Error near IL_007a: Stack underflow*/, (nint)Unsafe.AsPointer(ref IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute));
					obj2 = 1;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 1;
					}
					break;
				default:
					IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute = -2;
					obj2 = 3;
					if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
					{
						obj2 = 3;
					}
					break;
				case 5:
					obj = IReadOnlyList_object._initialized;
					obj2 = 4;
					break;
				case 1:
					return;
				case 2:
					{
						if (obj == null)
						{
							obj3 = 12;
							goto IL_00e9;
						}
						goto IL_020f;
					}
					IL_00e9:
					while (true)
					{
						switch ((int)obj3)
						{
						case 8:
						case 11:
							break;
						case 15:
							return;
						default:
							IReadOnlyList_object.ReflectLogicalAttribute = obj;
							obj3 = 2;
							if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
							{
								obj3 = 0;
							}
							continue;
						case 10:
							obj = -1;
							IEnumerable_System_IDisposable._initialized = -1;
							obj3 = 7;
							if (IEnumerable_object._initialized == 0)
							{
								obj3 = 6;
							}
							continue;
						case 3:
						case 12:
							obj = IEnumerable_object.ReflectSetAttribute;
							obj = 4;
							obj3 = obj;
							continue;
						case 2:
							_ = ref Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute;
							((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CLaunchShadowClient_003Ed__5, AccountViewModel._003CCreateAccount_003Ed__21>(ref this));
							_ = 14;
							if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute != null)
							{
								_ = 15;
							}
							continue;
						case 4:
							Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute = (object)default(Marshaler<>);
							obj3 = 10;
							continue;
						case 13:
							goto IL_020f;
						case 14:
							obj = 0;
							Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute = 0;
							obj3 = 0;
							if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance == null)
							{
								obj3 = 0;
							}
							continue;
						case 7:
							IListMethods<object>.Abi_Clear_9((IntPtr)(nint)(&obj));
							obj3 = 11;
							continue;
						case 6:
							if (IListMethods<object>.Abi_GetMany_10((IntPtr)/*Error near IL_027b: Stack underflow*/, (uint)/*Error near IL_027b: Stack underflow*/, ref *(object[]*)(&obj)) == 0)
							{
								obj3 = 14;
								continue;
							}
							goto case 7;
						case 1:
							obj = IEnumeratorMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, nint*, int>)/*Error near IL_029e: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)(int)IList_object.Do_Abi_RemoveAtEnd_8((nint)obj), (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)obj, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, uint*, int>)(int)IList_object.Do_Abi_Clear_9((nint)0));
							obj3 = 6;
							continue;
						case 5:
							goto IL_02b9;
						case 9:
							goto IL_02d6;
						}
						break;
					}
					goto default;
					IL_020f:
					obj4 = obj;
					if (IList_object.Init() == 0)
					{
						_ = 8;
						if (Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute != null)
						{
							_ = 7;
						}
						goto IL_00e9;
					}
					goto IL_02b9;
					IL_02d6:
					goto IL_0303;
					IL_0303:
					obj = null as ComWrappers;
					obj3 = 0;
					if (__KnownINotifyPropertyChangingArgs.Content == null)
					{
						obj3 = 1;
					}
					goto IL_00e9;
					IL_02b9:
					num = IList_object.Do_Abi_ReplaceAll_11((nint)/*Error near IL_02c0: Stack underflow*/, (uint)(int)obj4, (nint)obj);
					if (num == 0)
					{
						obj3 = 9;
						goto IL_00e9;
					}
					userId = __KnownINotifyPropertyChangingArgs.UserId;
					if (userId == null)
					{
						__KnownINotifyPropertyChangingArgs.Name = (PropertyChangingEventArgs)new IReadOnlyListMethods<IDisposable, nint>((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_02f8: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)(int)num, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)__KnownINotifyPropertyChangingArgs.Username, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(delegate*<bool>)(&IList_object.AttachAttribute));
					}
					((AsyncTaskMethodBuilder*)/*Error near IL_0303: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)num, ref *(AccountViewModel._003CImportAccounts_003Ed__28*)userId);
					goto IL_0303;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00Ȁ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777884, new IntPtr(2737335815772L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_0300()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00Ѐ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777885, new IntPtr(2737335823052L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00Ԁ()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_0600(object P_0)
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COpenGameResourceFolder_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object CheckAdjustableEvent;

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
		internal static bool CheckGenericWrapper()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateRandomProcessor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_F700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777882, new IntPtr(2737335813692L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_F800()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0076: Expected Obj, but got Ref
			//IL_036c: Expected Obj, but got Ref
			//IL_035a: Expected Obj, but got Ref
			//IL_0051: Expected Obj, but got Ref
			//IL_0270: Expected Obj, but got I4
			//IL_0275: Expected VT, but got I4
			//IL_0275: Expected Obj, but got Ref
			//IL_0284: Expected Obj, but got I4
			//IL_023b: Expected Obj, but got Ref
			//IL_0200: Expected Obj, but got I4
			//IL_0200: Expected I, but got Obj
			//IL_0129: Expected Obj, but got Ref
			//IL_0132: Expected Obj, but got I4
			//IL_00fc: Expected Obj, but got Ref
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Expected Obj, but got Ref
			//IL_0145: Expected Obj, but got Ref
			//IL_0145: Expected Obj, but got Ref
			//IL_0154: Expected Obj, but got I
			//IL_0226: Expected Obj, but got I4
			//IL_022b: Expected Obj, but got I4
			//IL_022b: Expected Obj, but got Ref
			//IL_00f1: Expected I4, but got Obj
			//IL_008f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0382->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0366->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ac->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_009a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_038d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01aa->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_00f1->IL0294: Incompatible stack heights: 0 vs 1
			//IL_01b5->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_0289->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0247->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0216->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_017f->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0116->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0159->IL00b0: Incompatible stack heights: 3 vs 1
			//IL_0235->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0294->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0221->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_018a->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0121->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_01d5->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0164->IL00b0: Incompatible stack heights: 3 vs 1
			//IL_01e0->IL00b0: Incompatible stack types: I4 vs Obj
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
				case 4:
					return;
				case 5:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = -2;
					obj2 = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 1;
					}
					break;
				case 1:
					*((int, nint)*)(nint)/*Error near IL_007b: Stack underflow*/ = ((int)/*Error near IL_007b: Stack underflow*/, (nint)Unsafe.AsPointer(ref IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute));
					obj2 = 3;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 4;
					}
					break;
				default:
					if (obj == null)
					{
						obj3 = 5;
						goto IL_00b0;
					}
					goto IL_018a;
				case 3:
					obj = __KnownINotifyPropertyChangingArgs.Content;
					obj2 = 2;
					break;
				case 2:
					{
						obj = __KnownINotifyPropertyChangingArgs.IsSelected;
						obj2 = 0;
						if (__KnownINotifyPropertyChangingArgs.CanProxy == null)
						{
							obj2 = 0;
						}
						break;
					}
					IL_00b0:
					while (true)
					{
						switch ((int)obj3)
						{
						case 1:
							return;
						case 4:
						case 7:
							break;
						case 11:
							IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute = (object)default(Page);
							obj3 = 14;
							if (IReadOnlyList_object._initialized != 0)
							{
								obj3 = 10;
							}
							continue;
						case 10:
							IReadOnlyList_object.ReflectLogicalAttribute = obj;
							obj = 13;
							obj3 = obj;
							continue;
						case 13:
							_ = ref IEnumerator_System_IDisposable._initialized;
							((XamlUserType)(&obj)).BoxType<int>((object)Unsafe.AsPointer(ref this));
							_ = 1;
							if (IEnumerable_System_IDisposable.CombineAttribute == null)
							{
								_ = 1;
							}
							continue;
						case 9:
							MarshalInterface<INotifyPropertyChanged>.CopyManagedArray((INotifyPropertyChanged[])/*Error near IL_016b: Stack underflow*/, (IntPtr)(nint)(&obj));
							obj3 = 7;
							if (GlobalVtableLookup.CreateAttribute != null)
							{
								obj3 = 7;
							}
							continue;
						case 8:
							goto IL_018a;
						case 12:
							if (IListMethods<object>.Abi_GetAt_0((IntPtr)/*Error near IL_01bc: Stack underflow*/, (uint)(&obj)) == null)
							{
								obj3 = 0;
								if (Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute == null)
								{
									obj3 = 0;
								}
								continue;
							}
							goto case 9;
						case 3:
						case 6:
							IListMethods<object>.Abi_SetAt_4((IntPtr)obj, IList_object.Initialized ? 1u : 0u, (object)IList_object.Init());
							obj = (object)/*Error near IL_0202: Stack underflow*/;
							obj3 = 3;
							if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute != null)
							{
								obj3 = 12;
							}
							continue;
						case 14:
							obj = -1;
							Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute = -1;
							obj3 = 9;
							continue;
						case 2:
						case 5:
							obj = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance;
							obj3 = 11;
							continue;
						default:
							obj = 0;
							_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout = (TimeSpan)0;
							obj3 = 10;
							if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator == null)
							{
								obj3 = 10;
							}
							continue;
						}
						break;
					}
					goto case 5;
					IL_018a:
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.Initialized)
					{
						_ = 4;
						if (Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute == null)
						{
							_ = 6;
						}
						goto IL_00b0;
					}
					goto case 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00豈()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777883, new IntPtr(2737335798092L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00切()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00ﬀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777880, new IntPtr(2737335801212L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00ﰀ()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00ﴀ(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FE00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777881, new IntPtr(2737335814732L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRefreshGame_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object DecorateCustomContainer;

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
		internal static bool DecorateAdvancedConverter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectConvertibleVerifier()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_ED00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777958, new IntPtr(2737335806412L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_EE00()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_04cd: Expected Obj, but got Ref
			//IL_04ba: Expected Obj, but got Ref
			//IL_0493: Expected Obj, but got Ref
			//IL_046e: Expected Obj, but got I4
			//IL_046e: Expected Obj, but got Ref
			//IL_0325: Expected Obj, but got Ref
			//IL_0327: Expected Obj, but got VT
			//IL_0336: Expected Obj, but got I4
			//IL_005f: Expected Obj, but got I
			//IL_0234: Expected Obj, but got Ref
			//IL_0234: Unknown result type (might be due to invalid IL or missing references)
			//IL_034c: Expected Obj, but got Ref
			//IL_0354: Expected Obj, but got Ref
			//IL_03a2: Expected Obj, but got Ref
			//IL_020d: Expected I, but got Obj
			//IL_020f: Expected Obj, but got I4
			//IL_024a: Expected Obj, but got Ref
			//IL_01a1: Expected Obj, but got I4
			//IL_01a6: Expected Obj, but got I4
			//IL_01a6: Expected Obj, but got Ref
			//IL_01b5: Expected Obj, but got I
			//IL_013e: Expected Obj, but got Ref
			//IL_0378: Expected Obj, but got I4
			//IL_037d: Expected Obj, but got I4
			//IL_037d: Expected Obj, but got Ref
			//IL_01cb: Expected Obj, but got Ref
			//IL_01d3: Expected Obj, but got Ref
			//IL_01d3: Expected Obj, but got Ref
			//IL_02eb: Expected Obj, but got I4
			//IL_02f0: Expected Obj, but got I4
			//IL_02f0: Expected Obj, but got Ref
			//IL_03cf: Expected Obj, but got Ref
			//IL_0162: Expected Obj, but got I4
			//IL_0167: Expected Obj, but got I4
			//IL_0167: Expected Obj, but got Ref
			//IL_0176: Expected Obj, but got I
			//IL_01ea: Expected I, but got Obj
			//IL_01f1: Expected Obj, but got I4
			//IL_0158: Expected Obj, but got I4
			//IL_011b: Expected I, but got Obj
			//IL_011d: Expected Obj, but got I4
			//IL_02e1: Expected Obj, but got I4
			//IL_0104: Expected Obj, but got I
			//IL_04e6->IL0026: Incompatible stack heights: 2 vs 1
			//IL_04c6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04a9->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0482->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04f1->IL0026: Incompatible stack heights: 2 vs 1
			//IL_04b4->IL0026: Incompatible stack types: I4 vs Obj
			//IL_048d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0368->IL0073: Incompatible stack heights: 4 vs 1
			//IL_01dd->IL0073: Incompatible stack heights: 3 vs 1
			//IL_01fb->IL0073: Incompatible stack heights: 2 vs 1
			//IL_0373->IL0073: Incompatible stack heights: 4 vs 1
			//IL_02e6->IL006f: Incompatible stack heights: 0 vs 1
			//IL_0073->IL0073: Incompatible stack heights: 2 vs 1
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
				case 5:
					if (obj != null)
					{
						num = 0;
						if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute == null)
						{
							num = 0;
						}
						goto IL_0073;
					}
					goto IL_031f;
				case 4:
					goto IL_0466;
				case 3:
					obj = __KnownINotifyPropertyChangingArgs.IsLiked;
					obj2 = 2;
					if (__KnownINotifyPropertyChangingArgs.PreviewImage == null)
					{
						obj2 = 2;
					}
					break;
				case 2:
					obj = __KnownINotifyPropertyChangingArgs.SourceImage;
					obj2 = 5;
					break;
				case 1:
					return;
				default:
					{
						IEnumerableMethods<object>.Abi_First_0((IntPtr)(nint)Unsafe.AsPointer(ref __KnownINotifyPropertyChangingArgs.Title));
						_ = 1;
						if (__KnownINotifyPropertyChangingArgs.State == null)
						{
							_ = 0;
						}
						break;
					}
					IL_0073:
					while (true)
					{
						switch (num)
						{
						case 14:
							if ((nint)obj != 3)
							{
								num = 6;
								if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
								{
									num = 3;
								}
								continue;
							}
							goto case 24;
						case 27:
							obj = IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_011b: Stack underflow*/, (uint)/*Error near IL_011b: Stack underflow*/, (nint)/*Error near IL_011b: Stack underflow*/, (uint*)(nint)obj);
							num = 14;
							continue;
						case 16:
							IList_object.PatchAttribute = obj;
							num = 2;
							continue;
						case 25:
						case 26:
							IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)(nint)(&obj));
							obj = 7;
							continue;
						case 21:
							obj = 1;
							IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute = 1;
							num = 4;
							if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
							{
								num = 16;
							}
							continue;
						case 9:
							if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)/*Error near IL_018d: Stack underflow*/, (uint)(&obj)) != null)
							{
								num = 26;
								continue;
							}
							goto case 19;
						case 15:
							obj = -1;
							IReadOnlyList_object.ReflectLogicalAttribute = -1;
							num = 11;
							if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
							{
								num = 25;
							}
							continue;
						case 18:
							_ = ref IEnumerable_System_IDisposable._initialized;
							((XamlUserType)(&obj)).BoxType<DateTime>((object)Unsafe.AsPointer(ref this));
							_ = 13;
							continue;
						case 24:
							IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
							obj = IEnumerableMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(int)IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)null));
							_ = 9;
							continue;
						case 4:
							obj = IListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_020d: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_020d: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)/*Error near IL_020d: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_020d: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_020d: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_020d: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int>)/*Error near IL_020d: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, int>)/*Error near IL_020d: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_020d: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)obj, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(IEnumerable_System_ComponentModel_INotifyPropertyChanged.Initialized ? 1 : 0), (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, int>)MarshalInterface<IEnumerator<INotifyPropertyChanged>>.FromManaged((IEnumerator<INotifyPropertyChanged>)null));
							num = 6;
							if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute == null)
							{
								num = 11;
							}
							continue;
						case 1:
							Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute = (object)default(Marshaler<>);
							num = 15;
							continue;
						case 5:
							obj = Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute;
							num = 3;
							if (Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute == null)
							{
								num = 3;
							}
							continue;
						case 22:
							IListMethods<object>.Abi_RemoveAt_6((IntPtr)/*Error near IL_0272: Stack underflow*/, (uint)(&obj));
							num = 8;
							continue;
						case 13:
							return;
						case 23:
							return;
						default:
							if ((nint)obj != 1)
							{
								num = 27;
								continue;
							}
							goto case 5;
						case 6:
							if ((nint)obj != 4)
							{
								obj = 10;
								continue;
							}
							goto case 4;
						case 19:
							obj = 0;
							_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute = 0;
							num = 20;
							continue;
						case 11:
							if (IListMethods<object>.Abi_GetMany_10((IntPtr)/*Error near IL_0310: Stack underflow*/, (uint)/*Error near IL_0310: Stack underflow*/, ref *(object[]*)(&obj)) == 0)
							{
								num = 21;
								continue;
							}
							goto case 22;
						case 12:
							break;
						case 2:
							_ = ref __KnownINotifyPropertyChangingArgs.Notes;
							_ = ref obj;
							WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>((IAsyncOperation<ContentDialogResult>)(object)Unsafe.AsPointer(ref this));
							_ = 23;
							if (__KnownINotifyPropertyChangingArgs.CreateAt == null)
							{
								_ = 23;
							}
							continue;
						case 17:
							obj = -1;
							__KnownINotifyPropertyChangingArgs.LoginAt = (PropertyChangingEventArgs)(-1);
							num = 12;
							if (__KnownINotifyPropertyChangingArgs.IsMyself == null)
							{
								num = 22;
							}
							continue;
						case 3:
							Unsafe.As<PropertyChangingEventArgs, Guid>(ref __KnownINotifyPropertyChangingArgs.Message) = default;
							num = 17;
							if (__KnownINotifyPropertyChangingArgs.IsSelected == null)
							{
								num = 1;
							}
							continue;
						case 20:
							__KnownINotifyPropertyChangingArgs.IsSkeleton = (PropertyChangingEventArgs)obj;
							num = 18;
							continue;
						case 7:
						case 8:
						case 10:
							goto IL_0466;
						}
						break;
					}
					goto IL_031f;
					IL_031f:
					obj = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout;
					num = 1;
					if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator != null)
					{
						num = 1;
					}
					goto IL_0073;
					IL_0466:
					__KnownINotifyPropertyChangingArgs.ImageUrl = (PropertyChangingEventArgs)(-2);
					obj2 = 0;
					if (__KnownINotifyPropertyChangingArgs.BackgroundImageUrl == null)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_EF00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777959, new IntPtr(2737335806412L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_F000()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_F100()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777956, new IntPtr(2737335812652L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_F200()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777957, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_F300()
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_F400()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777954, new IntPtr(2737335806412L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_F500(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777955, new IntPtr(2737335798092L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_F600(object P_0)
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRefreshLanGame_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopViewModel _003C_003E4__this;

		private TaskAwaiter<EntityLanGameRoom[]> _003C_003Eu__1;

		private static object CheckMixedAnnotation;

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
		internal static bool CheckFlexibleComparator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectSegmentedBridge()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_E500()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777952, new IntPtr(2737335800172L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_E600()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_004e: Expected Obj, but got Ref
			//IL_00b2: Expected Obj, but got Ref
			//IL_00b4: Expected Obj, but got I
			//IL_0063: Expected Obj, but got Ref
			//IL_0065: Expected Obj, but got I
			//IL_008d: Expected Obj, but got I4
			//IL_008d: Expected Obj, but got Ref
			//IL_009c: Expected Obj, but got I
			//IL_0172: Expected I, but got Obj
			//IL_0155: Expected I, but got Obj
			//IL_015c: Expected Obj, but got I4
			//IL_0188: Expected I, but got Obj
			//IL_013e: Expected Obj, but got I
			//IL_06d3: Expected Obj, but got I
			//IL_06d8: Expected Obj, but got I4
			//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ce: Expected Obj, but got Unknown
			//IL_02f5: Expected Obj, but got Ref
			//IL_02f7: Expected Obj, but got I4
			//IL_0745: Expected Obj, but got Ref
			//IL_04b4: Expected Obj, but got I4
			//IL_04b9: Expected Obj, but got I4
			//IL_04b9: Expected Obj, but got Ref
			//IL_04c2: Expected Obj, but got I4
			//IL_031b: Expected Obj, but got I4
			//IL_0320: Expected Obj, but got I4
			//IL_0320: Expected Obj, but got Ref
			//IL_0415: Expected Obj, but got I4
			//IL_041a: Expected Obj, but got I4
			//IL_041a: Expected Obj, but got Ref
			//IL_0400: Expected Obj, but got Ref
			//IL_02e3: Expected Obj, but got I4
			//IL_03a2: Expected Obj, but got Ref
			//IL_0285: Expected Obj, but got Ref
			//IL_045e: Expected Obj, but got I4
			//IL_0336: Expected I, but got Obj
			//IL_02c0: Expected Obj, but got Ref
			//IL_02c8: Expected Obj, but got Ref
			//IL_02c8: Expected Obj, but got Ref
			//IL_04ce: Expected I, but got Obj
			//IL_04d5: Expected Obj, but got I4
			//IL_0351: Expected Obj, but got I4
			//IL_050b: Expected Obj, but got Ref
			//IL_042b: Expected I, but got Obj
			//IL_051d: Expected Obj, but got Ref
			//IL_0525: Expected Obj, but got Ref
			//IL_0525: Expected Obj, but got Ref
			//IL_0525: Expected Obj, but got Ref
			//IL_0392: Expected Obj, but got Ref
			//IL_037a: Expected Obj, but got Ref
			//IL_046d: Expected Obj, but got I4
			//IL_0472: Expected Obj, but got I4
			//IL_0472: Expected Obj, but got Ref
			//IL_0254: Expected I4, but got Obj
			//IL_005d->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00be->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0079->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a1->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0084->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ac->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0699->IL00ea: Incompatible stack heights: 3 vs 1
			//IL_017c->IL00ea: Incompatible stack heights: 2 vs 1
			//IL_0166->IL00ea: Incompatible stack heights: 2 vs 1
			//IL_018d->IL0127: Incompatible stack heights: 1 vs 0
			//IL_0143->IL00ea: Incompatible stack heights: 4 vs 1
			//IL_06ee->IL00ea: Incompatible stack heights: 2 vs 1
			//IL_06ce->IL06ce: Incompatible stack heights: 6 vs 4
			//IL_06a4->IL00ea: Incompatible stack heights: 3 vs 1
			//IL_030b->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_01c8->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_01a1->IL00ea: Incompatible stack heights: 2 vs 1
			//IL_014e->IL00ea: Incompatible stack heights: 4 vs 1
			//IL_06f9->IL00ea: Incompatible stack heights: 2 vs 1
			//IL_0316->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_01d3->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_01ac->IL00ea: Incompatible stack heights: 2 vs 1
			//IL_0759->IL00ea: Incompatible stack heights: 8 vs 1
			//IL_0740->IL0740: Incompatible stack heights: 6 vs 7
			//IL_032a->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_0424->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_0410->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_02ef->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_03b8->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_0299->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_0468->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_0340->IL01d7: Incompatible stack heights: 2 vs 1
			//IL_02d2->IL01d7: Incompatible stack heights: 3 vs 1
			//IL_04df->IL01d7: Incompatible stack heights: 2 vs 1
			//IL_0504->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_0362->IL01d7: Incompatible stack heights: 3 vs 1
			//IL_0517->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_052f->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_039c->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_038a->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_047c->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_0764->IL00ea: Incompatible stack heights: 8 vs 1
			//IL_03c3->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_0455->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_02a4->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_02ba->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_043f->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_0541->IL0558: Incompatible stack heights: 2 vs 4
			//IL_0374->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_0578->IL01d7: Incompatible stack types: I4 vs Obj
			//IL_0583->IL01d7: Incompatible stack types: I4 vs Obj
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				default:
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)/*Error near IL_0053: Stack underflow*/, ref Unsafe.As<nint, object[]>(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized));
					_ = 4;
					break;
				case 2:
					obj = IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized;
					obj2 = 0;
					if (IList_object._initialized == 0)
					{
						obj2 = 1;
					}
					break;
				case 4:
					return;
				case 3:
					IList_object.PatchAttribute = -2;
					obj2 = 0;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
					{
						obj2 = 0;
					}
					break;
				case 1:
					obj = IReadOnlyList_System_IDisposable._initialized;
					obj2 = 5;
					break;
				case 5:
					{
						if ((nuint)(nint)obj > (nuint)1u)
						{
							num = 2;
							if (IReadOnlyList_object._initialized == 0)
							{
								num = 0;
							}
							goto IL_00ea;
						}
						goto IL_011c;
					}
					IL_011c:
					num = 4;
					goto IL_00ea;
					IL_00ea:
					while (true)
					{
						object obj3;
						switch (num)
						{
						case 5:
							goto IL_011c;
						case 8:
							_ = 1;
							IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init();
							_ = 0;
							if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
							{
								_ = 0;
							}
							continue;
						case 6:
							((XamlUserType)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_0155: Stack underflow*/, (uint)/*Error near IL_0155: Stack underflow*/, (uint)/*Error near IL_0155: Stack underflow*/, (nint)/*Error near IL_0155: Stack underflow*/, (uint*)(nint)obj)).BoxType<DateTime>(obj);
							_ = 3;
							continue;
						case 3:
						{
							object obj4 = obj;
							IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
							IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)obj4);
							_ = 5;
							continue;
						}
						case 7:
							if (IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.CheckSymbolicAttribute()) == null)
							{
								_ = 9;
								if (Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute != null)
								{
									_ = 4;
								}
								continue;
							}
							goto case 8;
						case 4:
							if (obj != null)
							{
								obj3 = 20;
								if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute == null)
								{
									obj3 = 28;
								}
								goto IL_01d7;
							}
							goto IL_02ef;
						case 2:
							((Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails)(object)Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ValidateAttribute()).GetExposedInterfaces();
							_ = IUIElementOverridesMethods.IID;
							_ = 1;
							if (__KnownINotifyPropertyChangingArgs.Step == null)
							{
								_ = 0;
							}
							continue;
						case 1:
						{
							_ = 0;
							IntPtr abiToProjectionVftablePtr = IAnimationObjectMethods.AbiToProjectionVftablePtr;
							PropertyChangingEventArgs hasSelectedFile = __KnownINotifyPropertyChangingArgs.HasSelectedFile;
							if (hasSelectedFile == null)
							{
								_ = __KnownINotifyPropertyChangingArgs.ParsedCount;
								_ = (delegate*<Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails>)(&Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.DecorateOperationalAttribute);
								__KnownINotifyPropertyChangingArgs.ParsedAccounts = (PropertyChangingEventArgs)(nint)new IVisualElement2Methods();
							}
							obj = ((IEnumerable<int>)11).Select((Func<int, DesktopGameModel>)(object)((IEnumerable<EntityLanGameRoom>)(nint)abiToProjectionVftablePtr).Select((Func<EntityLanGameRoom, DesktopGameModel>)(object)hasSelectedFile));
							_ = 6;
							if (__KnownINotifyPropertyChangingArgs.HasSelectedGame == null)
							{
								_ = 3;
							}
							continue;
						}
						case 9:
							{
								Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateInternalAttribute();
								ref Guid iID;
								if ((nint)IComponentConnectorMethods.IID == 0)
								{
									((Mass_WinUI_AppWinRTTypeDetails)(object)__KnownINotifyPropertyChangingArgs.NetGames)._002Ector();
									Mass_WinUI_AppWinRTTypeDetails.DecorateAdjustableAttribute();
									Mass_WinUI_AppWinRTTypeDetails.DecorateGenericAttribute();
									iID = IApplicationOverridesMethods.IID;
								}
								else
								{
									_ = __KnownINotifyPropertyChangingArgs.RentalGames;
									Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.ReflectCustomAttribute();
									Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.CheckAdvancedAttribute();
								}
								((Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails)(nint)iID).GetExposedInterfaces();
								_ = 6;
								if (__KnownINotifyPropertyChangingArgs.SkinAllSelected == null)
								{
									_ = 8;
								}
								continue;
							}
							IL_02ef:
							obj = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout;
							obj3 = 4;
							if (__KnownINotifyPropertyChangingArgs.Notes != null)
							{
								obj3 = 4;
							}
							goto IL_01d7;
							IL_01d7:
							while (true)
							{
								switch ((int)obj3)
								{
								case 12:
									return;
								case 18:
									return;
								case 25:
									break;
								case 8:
									Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute = obj;
									obj3 = 8;
									if (Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute == null)
									{
										obj3 = 13;
									}
									continue;
								case 16:
									IListMethods<object>.Abi_RemoveAt_6((IntPtr)/*Error near IL_02ab: Stack underflow*/, (uint)(&obj));
									if ((int)/*Error near IL_02b0: Stack underflow*/ != 0)
									{
										obj3 = 2;
										continue;
									}
									goto default;
								case 13:
									_ = ref Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute;
									JsonSerializer.Deserialize<object>((string)(&obj), (JsonSerializerOptions?)Unsafe.AsPointer(ref this));
									_ = 12;
									continue;
								case 5:
									IListMethods<object>.Abi_Clear_9((IntPtr)/*Error near IL_02d7: Stack underflow*/);
									IListMethods<object>.Abi_ReplaceAll_11((IntPtr)/*Error near IL_02e3: Stack underflow*/, (object[])IListMethods<object>.Abi_GetMany_10((IntPtr)/*Error near IL_02de: Stack underflow*/, (uint)/*Error near IL_02de: Stack underflow*/, ref *(object[]*)50));
									obj = (object)/*Error near IL_02e5: Stack underflow*/;
									obj3 = 7;
									continue;
								case 19:
									goto IL_02ef;
								case 1:
									obj = 0;
									__KnownINotifyPropertyChangingArgs.UserId = (PropertyChangingEventArgs)0;
									obj3 = 8;
									continue;
								case 10:
								{
									object obj6 = obj;
									IList_object._002Ecctor();
									IEnumeratorMethods<INotifyPropertyChanged>.Abi_get_HasCurrent_1((IntPtr)obj6);
									_ = 17;
									continue;
								}
								case 20:
									IReadOnlyListMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0345: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_0345: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_0345: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_0345: Stack underflow*/);
									obj = MarshalInterface<IDisposable>.FromAbi(MarshalInterface<IDisposable>.FromManaged((IDisposable)IEnumerator_System_ComponentModel_INotifyPropertyChanged.Initialized));
									_ = 16;
									continue;
								case 28:
									if ((nint)obj != 1)
									{
										obj3 = 22;
										continue;
									}
									goto case 6;
								case 26:
									__KnownINotifyPropertyChangingArgs.CharacterName = null;
									obj3 = 29;
									continue;
								case 24:
									__KnownINotifyPropertyChangingArgs.IsSelected = (PropertyChangingEventArgs)obj;
									obj3 = 23;
									continue;
								case 6:
									obj = __KnownINotifyPropertyChangingArgs.IsSkeleton;
									obj3 = 26;
									if (__KnownINotifyPropertyChangingArgs.ShowMaxPlayer != null)
									{
										obj3 = 10;
									}
									continue;
								case 4:
									__KnownINotifyPropertyChangingArgs.Author = null;
									obj3 = 3;
									continue;
								case 3:
									obj = -1;
									__KnownINotifyPropertyChangingArgs.Version = (PropertyChangingEventArgs)(-1);
									obj3 = 9;
									continue;
								case 22:
									if (IEnumeratorMethods<IDisposable>.Abi_GetMany_3((IntPtr)/*Error near IL_0430: Stack underflow*/, ref *(IDisposable[]*)IReadOnlyList_System_IDisposable.Do_Abi_get_Size_1((nint)/*Error near IL_042b: Stack underflow*/, (uint*)(nint)obj)) != 0)
									{
										obj3 = 5;
										continue;
									}
									goto case 20;
								case 7:
									if (IEnumeratorMethods<IDisposable>.Abi_get_Current_0((IntPtr)(nint)(&obj)) != null)
									{
										obj3 = 11;
										continue;
									}
									goto case 1;
								case 9:
								case 11:
									obj = IEnumeratorMethods<IDisposable>.Abi_get_HasCurrent_1((IntPtr)(nint)(&obj));
									obj3 = 14;
									continue;
								case 29:
									obj = -1;
									__KnownINotifyPropertyChangingArgs.Summary = (PropertyChangingEventArgs)(-1);
									obj3 = 21;
									continue;
								default:
									obj = 1;
									__KnownINotifyPropertyChangingArgs.Title = (PropertyChangingEventArgs)1;
									obj = 24;
									obj3 = obj;
									continue;
								case 15:
									((IEnumerable<string>)IReadOnlyList_object.Do_Abi_GetMany_3((nint)/*Error near IL_04ce: Stack underflow*/, (uint)/*Error near IL_04ce: Stack underflow*/, (uint)/*Error near IL_04ce: Stack underflow*/, (nint)/*Error near IL_04ce: Stack underflow*/, (uint*)(nint)obj)).FirstOrDefault((Func<string, bool>)obj);
									_ = 10;
									continue;
								case 17:
								{
									IReadOnlyList_object._002Ecctor();
									bool flag = IReadOnlyList_object.ReflectSimpleAttribute();
									object obj7 = obj;
									ComWrappersSupport.RegisterTypeComInterfaceEntriesLookup((Func<Type, ComWrappers.ComInterfaceEntry[]>)(object)IReadOnlyList_object.DecorateControllableAttribute());
									((AsyncTaskMethodBuilder*)/*Error near IL_04fa: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(flag ? ((TaskAwaiter*)1) : ((TaskAwaiter*)null)), ref *(ImportAccountViewModel._003CPrimaryAsync_003Ed__46*)obj7);
									obj3 = 25;
									continue;
								}
								case 2:
								case 21:
									obj = ((object)(&obj)).ToString();
									obj3 = 27;
									continue;
								case 23:
									IMessengerExtensions.Register<ChatMessage>((IMessenger)(object)Unsafe.AsPointer(ref __KnownINotifyPropertyChangingArgs.Id), (object)(&obj), (MessageHandler<object, ChatMessage>)(object)Unsafe.AsPointer(ref this));
									obj3 = 18;
									continue;
								case 14:
								case 27:
								{
									object obj5 = obj;
									PropertyChangingEventArgs paid;
									PropertyChangingEventArgs val;
									if (__KnownINotifyPropertyChangingArgs.Price == null)
									{
										paid = __KnownINotifyPropertyChangingArgs.Paid;
										val = (__KnownINotifyPropertyChangingArgs.Number = (PropertyChangingEventArgs)(nint)new IEnumerableMethods<object>());
									}
									((AsyncTaskMethodBuilder*)(delegate*<bool>)(&IEnumerator_System_IDisposable.DecompressAttribute))->Start(ref *(_003CLaunchGame_003Ed__3*)val);
									((AsyncTaskMethodBuilder*)obj5)->Start(ref *(_003COpenGameResourceFolder_003Ed__4*)paid);
									obj = (object)/*Error near IL_0564: Stack underflow*/;
									obj3 = 11;
									if (__KnownINotifyPropertyChangingArgs.JoinedAt == null)
									{
										obj3 = 15;
									}
									continue;
								}
								}
								break;
							}
							goto case 7;
						}
						break;
					}
					goto case 3;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_E700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777953, new IntPtr(2737335806412L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_E800()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_E900()
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_EA00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777966, new IntPtr(2737335818892L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_EB00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777967, new IntPtr(2737335820972L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_EC00(object P_0)
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
	private struct _003CRefreshNetGames_003Ed__67 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopViewModel _003C_003E4__this;

		private object _003C_003E8__1;

		private TaskAwaiter<EntityNetGameItem[]> _003C_003Eu__1;

		private static object DecorateCommonCommand;

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
		internal static bool ReflectAdaptableConsumer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectPortableStrategy()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777964, new IntPtr(2737335800172L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FFFD()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777965, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777962, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FFFD()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FFFD(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_E000(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777963, new IntPtr(2737335803292L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRefreshRentalGame_003Ed__79 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopViewModel _003C_003E4__this;

		private TaskAwaiter<EntityRentalGameItem[]> _003C_003Eu__1;

		private static object ArrangeCache;

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
		internal static bool DecorateReadableConfig()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectRemoteEmitter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00쬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777960, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00찀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0640: Expected Obj, but got I4
			//IL_0640: Expected Obj, but got Ref
			//IL_0665: Expected Obj, but got Ref
			//IL_05ec: Expected Obj, but got Ref
			//IL_0614: Expected Obj, but got Ref
			//IL_044d: Expected Obj, but got I4
			//IL_03f2: Expected Obj, but got I4
			//IL_0474: Expected I, but got Obj
			//IL_0418: Expected I, but got Obj
			//IL_0418: Expected I, but got Obj
			//IL_019f: Expected Obj, but got Ref
			//IL_01a1: Expected Obj, but got I
			//IL_04cd: Expected Obj, but got I4
			//IL_04cd: Expected Obj, but got I4
			//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c3: Expected Obj, but got Unknown
			//IL_0127: Expected I, but got Obj
			//IL_0127: Expected Obj, but got Ref
			//IL_0267: Expected Obj, but got I4
			//IL_026c: Expected Obj, but got I4
			//IL_026c: Expected Obj, but got Ref
			//IL_0138: Expected I, but got Obj
			//IL_0138: Expected I, but got Obj
			//IL_01d3: Expected Obj, but got Ref
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Expected Obj, but got I4
			//IL_0215: Expected I, but got Obj
			//IL_0226: Expected Obj, but got I4
			//IL_0234: Expected Obj, but got I4
			//IL_014e: Expected Obj, but got Ref
			//IL_0172: Expected Obj, but got Ref
			//IL_017a: Expected Obj, but got Ref
			//IL_0189: Expected Obj, but got I
			//IL_01b7: Expected I, but got Obj
			//IL_01b7: Expected I, but got Obj
			//IL_01bc: Expected Obj, but got I4
			//IL_01c1: Expected Obj, but got I4
			//IL_023e: Expected Obj, but got I4
			//IL_0243: Expected Obj, but got I4
			//IL_0243: Expected Obj, but got Ref
			//IL_02b3: Expected I, but got VT
			//IL_02b3: Expected I, but got Obj
			//IL_02c3: Expected Ref, but got VT
			//IL_0654->IL0026: Incompatible stack types: I4 vs Obj
			//IL_067b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0602->IL0026: Incompatible stack types: I4 vs Obj
			//IL_062d->IL0026: Incompatible stack heights: 3 vs 1
			//IL_005a->IL005e: Incompatible stack heights: 1 vs 3
			//IL_065f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0686->IL0026: Incompatible stack types: I4 vs Obj
			//IL_060d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0638->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0093->IL043e: Incompatible stack heights: 2 vs 0
			//IL_0406->IL005e: Incompatible stack heights: 5 vs 3
			//IL_047e->IL005e: Incompatible stack heights: 4 vs 3
			//IL_0433->IL005e: Incompatible stack heights: 1 vs 3
			//IL_048f->IL04ee: Incompatible stack heights: 3 vs 2
			//IL_0411->IL005e: Incompatible stack heights: 5 vs 3
			//IL_04c3->IL04c3: Incompatible stack heights: 8 vs 6
			//IL_043e->IL005e: Incompatible stack heights: 1 vs 3
			//IL_0499->IL005e: Incompatible stack heights: 4 vs 3
			//IL_0544->IL005e: Incompatible stack heights: 9 vs 3
			//IL_0535->IL0535: Incompatible stack heights: 4 vs 7
			//IL_0147->IL00dd: Incompatible stack heights: 1 vs 3
			//IL_0205->IL00dd: Incompatible stack heights: 4 vs 3
			//IL_02d4->IL047e: Incompatible stack heights: 0 vs 2
			//IL_018e->IL00dd: Incompatible stack heights: 6 vs 3
			//IL_01cd->IL00dd: Incompatible stack heights: 1 vs 3
			//IL_02a2->IL02b9: Incompatible stack heights: 3 vs 1
			//IL_0210->IL00dd: Incompatible stack heights: 4 vs 3
			//IL_00dd->IL00dd: Incompatible stack heights: 2 vs 3
			//IL_0199->IL00dd: Incompatible stack heights: 6 vs 3
			//IL_02cf->IL00dd: Incompatible stack heights: 1 vs 3
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				int num;
				bool initialized;
				string? text;
				switch ((int)obj2)
				{
				default:
					if (obj == null)
					{
						_ = 9;
						goto IL_005e;
					}
					goto IL_043e;
				case 4:
					obj = __KnownINotifyPropertyChangingArgs.SelectedFileName;
					obj2 = 3;
					if (__KnownINotifyPropertyChangingArgs.ParsedCount == null)
					{
						obj2 = 0;
					}
					break;
				case 1:
					return;
				case 5:
					_ = ref __KnownINotifyPropertyChangingArgs.ImportedCount;
					_ = IVisualElement2Methods.AbiToProjectionVftablePtr;
					_ = 1;
					if (__KnownINotifyPropertyChangingArgs.ParseErrorMessage != null)
					{
						_ = 1;
					}
					break;
				case 2:
					goto IL_0638;
				case 3:
					{
						obj = __KnownINotifyPropertyChangingArgs.LanGames;
						obj2 = 0;
						if (__KnownINotifyPropertyChangingArgs.NetGames != null)
						{
							obj2 = 0;
						}
						break;
					}
					IL_005e:
					while (true)
					{
						int num2;
						switch (num)
						{
						default:
							num = 2;
							continue;
						case 2:
							if (obj != null)
							{
								num2 = 12;
								goto IL_00dd;
							}
							goto IL_0199;
						case 1:
							MarshalInterface<IEnumerator<IDisposable>>.FromManaged((IEnumerator<IDisposable>)IReadOnlyList_object.Init());
							_ = 0;
							if (__KnownINotifyPropertyChangingArgs.Executor == null)
							{
								_ = 0;
							}
							continue;
						case 8:
							(initialized ? ((AsyncTaskMethodBuilder*)1) : ((AsyncTaskMethodBuilder*)null))->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<string[]>*)IReadOnlyList_object.Do_Abi_get_Size_1((nint)text, (uint*)(nint)obj), ref *(ImportAccountViewModel._003CParseFile_003Ed__48*)obj);
							_ = 0;
							if (__KnownINotifyPropertyChangingArgs.OperationText == null)
							{
								_ = 1;
							}
							continue;
						case 5:
							break;
						case 3:
						case 6:
							IEnumerator_System_IDisposable.Do_Abi_get_HasCurrent_1((nint)obj, (byte*)1);
							_ = 10;
							continue;
						case 11:
							goto IL_047e;
						case 7:
						{
							IntPtr abiToProjectionVftablePtr = IEnumerableMethods<object>.AbiToProjectionVftablePtr;
							PropertyChangingEventArgs number = __KnownINotifyPropertyChangingArgs.Number;
							if (number == null)
							{
								_ = __KnownINotifyPropertyChangingArgs.PayUrl;
								_ = (delegate* unmanaged[Stdcall]<nint, nint*, uint>)(&IEnumerable_System_IDisposable.Do_Abi_First_0);
								__KnownINotifyPropertyChangingArgs.JoinedAt = (PropertyChangingEventArgs)(nint)new IEnumerableMethods();
							}
							((AsyncTaskMethodBuilder*)abiToProjectionVftablePtr)->Start(ref *(_003CLaunchHeadlessShadowClient_003Ed__9*)number);
							obj = IMessengerExtensions.Send<NavigationMessage>((IMessenger)(object)0, (NavigationMessage)10);
							num = 4;
							if (__KnownINotifyPropertyChangingArgs.CreatedAt != null)
							{
								num = 8;
							}
							continue;
						}
						case 4:
							IEnumerable_object._002Ecctor();
							if ((int)IReadOnlyListMethods<INotifyPropertyChanged>.IID == 0)
							{
								PropertyChangingEventArgs mobileAccounts = __KnownINotifyPropertyChangingArgs.MobileAccounts;
								GlobalVtableLookup.InitializeGlobalVtableLookup();
								GlobalVtableLookup.LookupVtableEntries((object)mobileAccounts);
								GlobalVtableLookup.LookupRuntimeClassName(obj);
								_ = IEnumeratorMethods<INotifyPropertyChanged>.AbiToProjectionVftablePtr;
							}
							else
							{
								((Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails)(object)((Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails)(object)__KnownINotifyPropertyChangingArgs.InputEmail).GetExposedInterfaces())._002Ector();
							}
							Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.DecorateGeneralAttribute();
							_ = 3;
							continue;
						case 10:
							goto IL_0638;
							IL_0199:
							obj = IReadOnlyList_object._initialized;
							num2 = 6;
							goto IL_00dd;
							IL_00dd:
							while (true)
							{
								switch (num2)
								{
								case 1:
									IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)obj;
									num2 = 11;
									continue;
								case 4:
									*(ValueTuple<int, nint>*)(nint)/*Error near IL_013d: Stack underflow*/ = (initialized ? 1 : 0, (int)IEnumerator_object.Do_Abi_MoveNext_2((nint)text, (byte*)(nint)obj));
									_ = 9;
									continue;
								case 10:
									if (MarshalInspectable<object>.FromAbiArray((object)(&obj)) == null)
									{
										num2 = 2;
										continue;
									}
									goto default;
								case 5:
									return;
								case 11:
									_ = ref IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized;
									_ = ref obj;
									CastExtensions.As<ImplicitAnimationSet>((object)Unsafe.AsPointer(ref this));
									_ = 4;
									if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
									{
										_ = 5;
									}
									continue;
								case 3:
									break;
								case 12:
									obj = MarshalInterface<INotifyPropertyChanged>.FromAbiArray((object)IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_01bc: Stack underflow*/, (INotifyPropertyChanged)initialized, ref *(uint*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)text, (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init(), (nint*)(nint)obj)));
									_ = 10;
									continue;
								case 6:
									IEnumerable_System_IDisposable.CombineAttribute = default(MarshalInterface<IDisposable>);
									num2 = 13;
									continue;
								case 7:
									Interlocked.CompareExchange(ref *(Func<InfoBarDelegate>*)obj, (Func<InfoBarDelegate>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.MoveAttribute(), (Func<InfoBarDelegate>)obj);
									_ = 4;
									if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute == null)
									{
										_ = 3;
									}
									continue;
								case 9:
									IEnumerable_System_ComponentModel_INotifyPropertyChanged.Do_Abi_First_0((nint)(initialized ? 1 : 0), (nint*)(nint)text);
									IEnumerable_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
									((AsyncTaskMethodBuilder*)obj)->Start(ref *(AccountViewModel._003CLoginByHistory_003Ed__25*)MarshalInterface<IReadOnlyList<object>>.FromManaged((IReadOnlyList<object>)IEnumerable_System_ComponentModel_INotifyPropertyChanged.DecorateSeparatedAttribute()));
									obj = 8;
									continue;
								case 13:
									obj = -1;
									Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute = -1;
									num2 = 0;
									if (Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute != null)
									{
										num2 = 0;
									}
									continue;
								case 2:
									obj = 0;
									Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute = 0;
									num2 = 1;
									if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance != null)
									{
										num2 = 1;
									}
									continue;
								default:
								{
									IListMethods<object>.Abi_Clear_9((IntPtr)(nint)(&obj));
									PropertyChangingEventArgs val;
									if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule == null)
									{
										val = (__KnownINotifyPropertyChangingArgs.Notes = (PropertyChangingEventArgs)new IEnumeratorMethods<INotifyPropertyChanged, nint>((delegate* unmanaged[Stdcall]<IntPtr, nint*, int>)(initialized ? 1 : 0), (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)text, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, uint*, int>)(delegate* unmanaged[Stdcall]<nint, uint>)(&IList_object.Do_Abi_Clear_9)));
									}
									((AsyncTaskMethodBuilder*)/*Error near IL_02c3: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<(bool, string)>*)/*Error near IL_02c3: Stack underflow*/, ref *(AccountViewModel._003CEditAccount_003Ed__22*)WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>((IAsyncOperation<ContentDialogResult>)(object)val));
									obj = (object)/*Error near IL_02c5: Stack underflow*/;
									_ = 7;
									continue;
								}
								case 8:
									goto IL_047e;
								}
								break;
							}
							goto IL_0199;
							IL_047e:
							IEnumerator_System_IDisposable._002Ecctor();
							if ((int)IEnumerableMethods<object>.IID != 0)
							{
								_ = 6;
								continue;
							}
							goto case 4;
						}
						break;
					}
					goto IL_043e;
					IL_043e:
					initialized = IEnumerator_System_IDisposable.Initialized;
					text = ((object)IEnumerator_System_IDisposable.Init()).ToString();
					num = 3;
					if (__KnownINotifyPropertyChangingArgs.OrderId == null)
					{
						num = 7;
					}
					goto IL_005e;
					IL_0638:
					__KnownINotifyPropertyChangingArgs.InputText = (PropertyChangingEventArgs)(-2);
					obj2 = 4;
					if (__KnownINotifyPropertyChangingArgs.HasSelectedGame == null)
					{
						obj2 = 5;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00촀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777961, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00츀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00케()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777974, new IntPtr(2737335815772L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00퀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777975, new IntPtr(2737335818892L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00턀()
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00툀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777972, new IntPtr(2737335818892L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00팀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777973, new IntPtr(2737335798092L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00퐀(object P_0)
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
	private struct _003CRefreshSkin_003Ed__111 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopViewModel _003C_003E4__this;

		private nint _003CcurrentSelect_003E5__2;

		private TaskAwaiter<PageModel<IDesktopSkin>> _003C_003Eu__1;

		internal static object CheckActiveRunner;

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
		internal static bool CheckJoinedClient()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectLiteralListener()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00쀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777970, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00섀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_009e: Expected Obj, but got Ref
			//IL_0075: Expected Obj, but got Ref
			//IL_0086: Expected Obj, but got I
			//IL_004e: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I
			//IL_0b45: Expected Obj, but got Ref
			//IL_0129: Expected I, but got Obj
			//IL_012e: Expected Obj, but got I4
			//IL_018a: Expected I, but got Obj
			//IL_018a: Expected I, but got Obj
			//IL_013f: Expected I, but got Obj
			//IL_013f: Expected I, but got Obj
			//IL_0153: Expected Obj, but got I
			//IL_01c2: Expected I4, but got Obj
			//IL_0727: Expected Obj, but got Ref
			//IL_0313: Expected Obj, but got Ref
			//IL_031e: Expected Obj, but got I4
			//IL_0446: Expected Obj, but got Ref
			//IL_04dd: Expected I, but got Obj
			//IL_04e4: Expected I, but got Obj
			//IL_04ea: Expected Obj, but got Ref
			//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f1: Expected Obj, but got Unknown
			//IL_04f6: Expected Obj, but got I4
			//IL_06d1: Expected Obj, but got I4
			//IL_06d6: Expected Obj, but got I4
			//IL_06d6: Expected Obj, but got Ref
			//IL_0812: Expected Obj, but got Ref
			//IL_081a: Expected Obj, but got Ref
			//IL_0459: Expected I, but got Obj
			//IL_045b: Expected Obj, but got I4
			//IL_0738: Expected Obj, but got I4
			//IL_073d: Expected Obj, but got I4
			//IL_073d: Expected Obj, but got Ref
			//IL_034f: Expected I4, but got Obj
			//IL_034f: Expected Obj, but got Ref
			//IL_03cf: Expected Obj, but got I4
			//IL_03d4: Expected Obj, but got I4
			//IL_03d4: Expected Obj, but got Ref
			//IL_047c: Expected Obj, but got I4
			//IL_0481: Expected Obj, but got I4
			//IL_0481: Expected Obj, but got Ref
			//IL_02ef: Expected I, but got Obj
			//IL_02f5: Expected Obj, but got Ref
			//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fc: Expected Obj, but got Unknown
			//IL_0509: Expected Obj, but got Ref
			//IL_082c: Expected Obj, but got Ref
			//IL_066b: Expected Obj, but got Ref
			//IL_039d: Expected Obj, but got Ref
			//IL_039e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a4: Expected I4, but got Unknown
			//IL_03ab: Expected Obj, but got I
			//IL_0702: Expected Obj, but got I4
			//IL_0771: Expected Obj, but got Ref
			//IL_0778: Invalid comparison between Obj and Ref
			//IL_0588: Expected Obj, but got Ref
			//IL_06a7: Expected Obj, but got Ref
			//IL_05fb: Expected Obj, but got Ref
			//IL_0930: Expected I4, but got Obj
			//IL_0930: Expected I4, but got Obj
			//IL_08c4: Expected Obj, but got I4
			//IL_08c9: Expected Obj, but got I4
			//IL_08c9: Expected Obj, but got Ref
			//IL_046d: Expected Obj, but got Ref
			//IL_088a: Expected Obj, but got I
			//IL_03f8: Expected Obj, but got I4
			//IL_03fd: Expected Obj, but got I4
			//IL_03fd: Expected Obj, but got Ref
			//IL_02c3: Expected Obj, but got Ref
			//IL_02a9: Expected I4, but got Obj
			//IL_094c: Expected VT, but got I
			//IL_094c: Expected VT, but got Obj
			//IL_0952: Expected Obj, but got VT
			//IL_0957: Expected Ref, but got VT
			//IL_00a8->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0b5e->IL0026: Incompatible stack heights: 3 vs 1
			//IL_00c5->IL00d4: Incompatible stack heights: 1 vs 2
			//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0b69->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0101->IL0118: Incompatible stack heights: 1 vs 0
			//IL_00d0->IL00d4: Incompatible stack heights: 1 vs 2
			//IL_018f->IL0163: Incompatible stack heights: 0 vs 1
			//IL_0158->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_017e->IL00d4: Incompatible stack heights: 6 vs 2
			//IL_0118->IL00d4: Incompatible stack heights: 5 vs 2
			//IL_01a3->IL00d4: Incompatible stack heights: 1 vs 2
			//IL_0163->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_0733->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_0452->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_01cc->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_01ae->IL00d4: Incompatible stack heights: 1 vs 2
			//IL_0ab2->IL00d4: Incompatible stack heights: 1 vs 2
			//IL_0a80->IL0aa3: Incompatible stack heights: 4 vs 1
			//IL_0a94->IL0aa3: Incompatible stack heights: 0 vs 1
			//IL_0502->IL01d0: Incompatible stack heights: 1 vs 2
			//IL_0847->IL0392: Incompatible stack heights: 3 vs 1
			//IL_06ea->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_0665->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_0824->IL01d0: Incompatible stack heights: 1 vs 2
			//IL_0536->IL02ea: Incompatible stack heights: 2 vs 1
			//IL_0465->IL01d0: Incompatible stack heights: 1 vs 2
			//IL_05d1->IL01d0: Incompatible stack heights: 4 vs 2
			//IL_091e->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_0747->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_0363->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_03e8->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_048b->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_030d->IL01d0: Incompatible stack heights: 1 vs 2
			//IL_051f->IL01d0: Incompatible stack heights: 1 vs 2
			//IL_05bb->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_0836->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_0687->IL01d0: Incompatible stack heights: 3 vs 2
			//IL_03bf->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_0716->IL01d0: Incompatible stack heights: 3 vs 2
			//IL_0638->IL079c: Incompatible stack heights: 4 vs 1
			//IL_077d->IL087c: Incompatible stack heights: 2 vs 1
			//IL_0872->IL06cc: Incompatible stack heights: 2 vs 1
			//IL_05a2->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_0968->IL0138: Incompatible stack heights: 0 vs 1
			//IL_06c1->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_0615->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_093b->IL0952: Incompatible stack types: Obj vs VT
			//IL_08dd->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_07ae->IL01d0: Incompatible stack heights: 5 vs 2
			//IL_0477->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_07ea->IL01d0: Incompatible stack heights: 1 vs 2
			//IL_0894->IL01d0: Incompatible stack heights: 5 vs 2
			//IL_04b7->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_0411->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_02df->IL01d0: Incompatible stack heights: 3 vs 2
			//IL_085b->IL01d0: Incompatible stack heights: 4 vs 2
			//IL_06f5->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_054a->IL01d0: Incompatible stack heights: 3 vs 2
			//IL_0929->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_036e->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_03f3->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_052a->IL01d0: Incompatible stack heights: 1 vs 2
			//IL_0692->IL01d0: Incompatible stack heights: 3 vs 2
			//IL_03ca->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_0721->IL01d0: Incompatible stack heights: 3 vs 2
			//IL_064c->IL01d0: Incompatible stack heights: 5 vs 2
			//IL_0791->IL01d0: Incompatible stack heights: 3 vs 2
			//IL_087c->IL01d0: Incompatible stack heights: 3 vs 2
			//IL_05ad->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_06cc->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_0620->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_0963->IL01d0: Incompatible stack heights: 1 vs 2
			//IL_08e8->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_04c2->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_041c->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_02ea->IL01d0: Incompatible stack heights: 3 vs 2
			//IL_04d8->IL01d0: Incompatible stack types: I4 vs Obj
			//IL_0866->IL01d0: Incompatible stack heights: 4 vs 2
			//IL_0555->IL01d0: Incompatible stack heights: 3 vs 2
			//IL_0657->IL01d0: Incompatible stack heights: 5 vs 2
			//IL_079c->IL01d0: Incompatible stack heights: 3 vs 2
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				int num;
				switch ((int)obj2)
				{
				case 4:
					obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					obj2 = 3;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 0;
					}
					break;
				case 3:
					obj = IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute;
					obj2 = 0;
					if (IList_object.PatchAttribute == null)
					{
						obj2 = 0;
					}
					break;
				case 2:
					IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = -2;
					obj2 = 5;
					break;
				default:
					if ((nuint)(nint)obj <= (nuint)2u)
					{
						_ = 1;
						if (IReadOnlyList_System_IDisposable._initialized != 0)
						{
							_ = 0;
						}
						goto IL_00d4;
					}
					goto IL_0118;
				case 5:
					_ = ref __KnownINotifyPropertyChangedArgs.IsMyself;
					_ = MassService.Instance;
					_ = 1;
					if (__KnownINotifyPropertyChangedArgs.Content == null)
					{
						_ = 1;
					}
					break;
				case 1:
					return;
					IL_0118:
					obj3 = ((XamlUserType)/*Error near IL_012e: Stack underflow*/).BoxType<int>((object)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)(IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Initialized ? 1 : 0), (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init(), (nint*)(nint)obj));
					num = 6;
					goto IL_00d4;
					IL_00d4:
					while (true)
					{
						switch (num)
						{
						case 3:
							break;
						case 6:
							_ = null;
							IEnumerator_object.LoadAttribute();
							_ = 8;
							continue;
						case 9:
							goto IL_0118;
						case 2:
							goto IL_0138;
						case 5:
							_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.CheckSymbolicAttribute() == null;
							_ = IEnumerable_System_ComponentModel_INotifyPropertyChanged.Initialized;
							_ = 3;
							continue;
						default:
							if (!IListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_018a: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_018a: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)/*Error near IL_018a: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_018a: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_018a: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_018a: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int>)/*Error near IL_018a: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, int>)/*Error near IL_018a: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_018a: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)obj3, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)obj, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, int>)(int)IEnumerable_System_ComponentModel_INotifyPropertyChanged.Init()))
							{
								_ = 4;
								if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute == null)
								{
									_ = 2;
								}
								continue;
							}
							goto case 5;
						case 7:
							goto IL_01ae;
						case 1:
						case 8:
							num = 7;
							continue;
						case 4:
						{
							object obj4 = obj;
							object obj5 = obj;
							AutoInitialize.AccessWindowsAppSDK();
							if (obj5 != null)
							{
								((AutoInitialize)obj)._002Ector();
								((AsyncVoidMethodBuilder*)obj3)->Start<TStateMachine>(ref *(TStateMachine*)obj4);
								if ((int)/*Error near IL_0a5b: Stack underflow*/ == 0)
								{
									_ = __KnownINotifyPropertyChangingArgs.SelectedTopUpGroup;
									_ = App.Logger;
									_ = App.Current;
									_ = ((App)obj).Window;
									GameProxy.RegisterEvents();
								}
								else
								{
									((App)(object)__KnownINotifyPropertyChangingArgs.InviteCode)._002Ector();
									((App)/*Error near IL_0a8f: Stack underflow*/).SetAppRequestTheme((ElementTheme)/*Error near IL_0a8f: Stack underflow*/);
								}
							}
							else
							{
								((App)(object)__KnownINotifyPropertyChangingArgs.CustomerCount).ShowMainWindow();
								((App)obj4).Logout();
							}
							((App)obj3).ShowLoginWindow();
							_ = 5;
							continue;
						}
						}
						break;
						IL_01ae:
						object obj6;
						switch ((int)obj)
						{
						default:
							obj6 = 27;
							goto IL_01d0;
						case 1:
							obj = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute;
							obj = 34;
							obj6 = obj;
							goto IL_01d0;
						case 2:
							goto IL_0440;
						case 0:
							goto IL_0721;
							IL_01d0:
							while (true)
							{
								switch ((int)obj6)
								{
								case 31:
									break;
								case 51:
									_ = ref Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute;
									((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CRefreshSkin_003Ed__111, AccountViewModel._003CLoginByHistory_003Ed__25>(ref this));
									_ = 42;
									if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute == null)
									{
										_ = 34;
									}
									continue;
								case 19:
									IListMethods<object>.Abi_Append_7((IntPtr)(int)IList_object.Do_Abi_GetView_2((nint)/*Error near IL_02ef: Stack underflow*/, (nint*)(nint)obj3), (object)(Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute + 1));
									IListMethods<object>.Abi_RemoveAtEnd_8((IntPtr)/*Error near IL_0301: Stack underflow*/);
									obj = (object)/*Error near IL_0303: Stack underflow*/;
									_ = 29;
									continue;
								case 16:
									goto end_IL_01d0;
								case 14:
									_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout = (byte)(int)obj != 0;
									obj6 = 6;
									if (__KnownINotifyPropertyChangingArgs.Notes != null)
									{
										obj6 = 5;
									}
									continue;
								case 25:
									obj = (nint)MarshalInterface<IDisposable>.FromManaged(IReadOnlyListMethods<IDisposable>.Abi_GetAt_0((IntPtr)(IList_object.AttachAttribute() ? 1 : 0), (uint)(__KnownINotifyPropertyChangingArgs.LoginAt + 1)));
									obj6 = 52;
									if (__KnownINotifyPropertyChangingArgs.CharacterName == null)
									{
										obj6 = 37;
									}
									continue;
								case 17:
									obj = -1;
									__KnownINotifyPropertyChangingArgs.Content = (PropertyChangingEventArgs)(-1);
									obj6 = 2;
									if (__KnownINotifyPropertyChangingArgs.IsSkeleton == null)
									{
										obj6 = 9;
									}
									continue;
								case 48:
									obj = 1;
									__KnownINotifyPropertyChangingArgs.CanProxy = (PropertyChangingEventArgs)1;
									obj6 = 23;
									if (__KnownINotifyPropertyChangingArgs.OnlinePlayers == null)
									{
										obj6 = 6;
									}
									continue;
								case 42:
									return;
								case 50:
									goto IL_0440;
								case 5:
								case 9:
									obj = IEnumeratorMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, nint*, int>)/*Error near IL_0459: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)/*Error near IL_0459: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)obj3, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, uint*, int>)(&obj));
									_ = 21;
									continue;
								case 39:
									__KnownINotifyPropertyChangingArgs.ImageUrl = (PropertyChangingEventArgs)obj;
									obj6 = 24;
									continue;
								case 18:
									obj = 0;
									__KnownINotifyPropertyChangingArgs.Characters = (PropertyChangingEventArgs)0;
									obj6 = 39;
									continue;
								case 32:
									return;
								case 45:
								case 49:
									obj = IEnumeratorMethods<IDisposable>.Abi_get_Current_0((IntPtr)(nint)(&obj));
									obj6 = 0;
									if (__KnownINotifyPropertyChangingArgs.Summary == null)
									{
										obj6 = 0;
									}
									continue;
								case 52:
									if (IEnumerableMethods<IDisposable>.Abi_First_0((IntPtr)(nint)(&obj)) != null)
									{
										obj6 = 49;
										continue;
									}
									goto case 18;
								case 1:
								case 11:
									((Func<Type, string>)/*Error near IL_04f6: Stack underflow*/)._002Ector((object)IReadOnlyList_object.Do_Abi_IndexOf_2((nint)/*Error near IL_04e4: Stack underflow*/, (nint)/*Error near IL_04e4: Stack underflow*/, (uint*)(int)IReadOnlyList_object.Do_Abi_GetAt_0((nint)/*Error near IL_04dd: Stack underflow*/, (uint)/*Error near IL_04dd: Stack underflow*/, (nint*)(nint)obj3), (byte*)(nint)obj), (nint)MarshalInterface<IEnumerator<object>>.FromManaged((IEnumerator<object>)(__KnownINotifyPropertyChangingArgs.Executor + 1)));
									obj = (object)/*Error near IL_04f8: Stack underflow*/;
									_ = 40;
									continue;
								case 20:
								case 41:
									ComWrappersSupport.RegisterTypeRuntimeClassNameLookup((Func<Type, string>)(&obj));
									obj = obj3;
									_ = 4;
									if (__KnownINotifyPropertyChangingArgs.CloseText == null)
									{
										_ = 2;
									}
									continue;
								case 7:
									if (IEnumerator_System_IDisposable.Init() == 0)
									{
										_ = 2;
										if (__KnownINotifyPropertyChangingArgs.Id == null)
										{
											_ = 2;
										}
										continue;
									}
									goto case 19;
								case 8:
								case 46:
									/*Error near IL_0559: Member reference must be method, but was: Field*/;
								case 30:
									__KnownINotifyPropertyChangingArgs.PayAt = null;
									obj6 = 17;
									if (__KnownINotifyPropertyChangingArgs.Image != null)
									{
										obj6 = 3;
									}
									continue;
								case 21:
								case 37:
									obj = obj;
									obj6 = 35;
									continue;
								case 10:
									IEnumerable_System_IDisposable._002Ecctor();
									_ = INotifyCollectionChangedMethods.IID;
									_ = 43;
									continue;
								case 34:
									__KnownINotifyPropertyChangingArgs.Amount = null;
									obj6 = 36;
									if (__KnownINotifyPropertyChangingArgs.DesktopAccounts != null)
									{
										obj6 = 33;
									}
									continue;
								case 27:
									IEnumerable_object.DecorateAttachedAttribute();
									GlobalVtableLookup.InitializeGlobalVtableLookup();
									if (IEnumerableMethods<INotifyPropertyChanged>.AbiToProjectionVftablePtr == (IntPtr)0)
									{
										_ = 15;
										if (__KnownINotifyPropertyChangingArgs.Input4399Username != null)
										{
											_ = 1;
										}
										continue;
									}
									goto case 38;
								default:
									obj = obj;
									obj6 = 37;
									continue;
								case 24:
									_ = ref __KnownINotifyPropertyChangingArgs.InputEmail;
									((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CRefreshSkin_003Ed__111, _003CRefreshRentalGame_003Ed__79>(ref this));
									_ = 16;
									if (__KnownINotifyPropertyChangingArgs.Input163Password == null)
									{
										_ = 32;
									}
									continue;
								case 33:
									__KnownINotifyPropertyChangingArgs.InputMobilePassword = null;
									obj6 = 7;
									if (__KnownINotifyPropertyChangingArgs.VerifyCodeDelayText != null)
									{
										obj6 = 13;
									}
									continue;
								case 3:
									obj = 2;
									__KnownINotifyPropertyChangingArgs.InfoBarMessage = (PropertyChangingEventArgs)2;
									obj6 = 14;
									if (__KnownINotifyPropertyChangingArgs.InfoBarIsOpen != null)
									{
										obj6 = 13;
									}
									continue;
								case 15:
								case 26:
									__KnownINotifyPropertyChangingArgs.Step = (PropertyChangingEventArgs)Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.SortAttribute();
									_ = 0;
									if (__KnownINotifyPropertyChangingArgs.HasSelectedFile == null)
									{
										_ = 7;
									}
									continue;
								case 22:
									goto IL_0721;
								case 13:
									obj = -1;
									__KnownINotifyPropertyChangingArgs.ImportedCount = (PropertyChangingEventArgs)(-1);
									obj6 = 45;
									continue;
								case 47:
									return;
								case 28:
									_ = __KnownINotifyPropertyChangingArgs.ParseErrorMessage;
									if (!Unsafe.IsAddressGreaterThan(ref *(byte*)obj, ref *(byte*)IControlOverridesMethods.IID))
									{
										_ = 45;
										if (__KnownINotifyPropertyChangingArgs.HasSelectedGame == null)
										{
											_ = 46;
										}
										continue;
									}
									goto case 44;
								case 38:
									_ = 0;
									Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateInternalAttribute();
									_ = 26;
									continue;
								case 43:
									((Mass_WinUI_AppWinRTTypeDetails)obj)._002Ector();
									((AsyncTaskMethodBuilder*)/*Error near IL_07e0: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<PageModel<IDesktopSkin>>*)obj3, ref *(_003CRefreshSkin_003Ed__111*)obj);
									_ = 28;
									continue;
								case 6:
									((ILogger)obj3).Debug<int, int>((string)Unsafe.AsPointer(ref __KnownINotifyPropertyChangingArgs.NetGamesEmptyText), (int)(&obj), (int)Unsafe.AsPointer(ref this));
									_ = 47;
									continue;
								case 23:
									__KnownINotifyPropertyChangingArgs.RentalGames = (PropertyChangingEventArgs)obj;
									obj6 = 51;
									continue;
								case 2:
									Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.ReflectCustomAttribute();
									if (IXamlMetadataProviderMethods.AbiToProjectionVftablePtr == (IntPtr)0)
									{
										_ = 7;
										if (__KnownINotifyPropertyChangingArgs.CurrentSkinPage == null)
										{
											_ = 11;
										}
										continue;
									}
									goto case 25;
								case 29:
									_ = ref obj;
									if ((nint)IXamlTypeMethods.IID != 0)
									{
										_ = 5;
										continue;
									}
									goto case 3;
								case 44:
									((Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails)(nint)IXamlTypeMethods.AbiToProjectionVftablePtr).GetExposedInterfaces();
									_ = 8;
									continue;
								case 40:
									_ = ref obj;
									/*Error near IL_0896: Member reference must be method, but was: Field*/;
								case 36:
									obj = -1;
									__KnownINotifyPropertyChangingArgs.SearchText = (PropertyChangingEventArgs)(-1);
									obj6 = 12;
									if (__KnownINotifyPropertyChangingArgs.SearchVisibility == null)
									{
										obj6 = 20;
									}
									continue;
								case 12:
								{
									ComWrappers.ComInterfaceEntry[] exposedInterfaces = ((Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails)(object)Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.DecorateReadableAttribute()).GetExposedInterfaces();
									((Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails)obj)._002Ector();
									((RegexRunner)(object)exposedInterfaces).CheckTimeout();
									((AsyncTaskMethodBuilder*)obj)->Start(ref *(HomeViewModel._003CRefresh_003Ed__25*)Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.CheckJoinedAttribute());
									obj6 = 31;
									if (__KnownINotifyPropertyChangingArgs.RegistrationTimeText == null)
									{
										obj6 = 0;
									}
									continue;
								}
								case 35:
								{
									((RegexRunner)/*Error near IL_0930: Stack underflow*/).Capture((int)/*Error near IL_0930: Stack underflow*/, (int)obj3, (int)obj);
									PropertyChangingEventArgs instances = __KnownINotifyPropertyChangingArgs.Instances;
									TimeSpan timeSpan = (TimeSpan)instances;
									if (instances == null)
									{
										timeSpan = (TimeSpan)new TimeSpan((TimeSpan)__KnownINotifyPropertyChangingArgs.InputUsername, (TimeSpan)__ldftn(_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.Scan));
										__KnownINotifyPropertyChangingArgs.CanDesktopMenuInvoke = (PropertyChangingEventArgs)timeSpan;
									}
									((AsyncTaskMethodBuilder*)/*Error near IL_0957: Stack underflow*/)->Start(ref *(InstanceViewModel._003COperation_003Ed__11*)timeSpan);
									obj = (object)/*Error near IL_0959: Stack underflow*/;
									_ = 10;
									continue;
								}
								}
								goto end_IL_01b1;
								continue;
								end_IL_01d0:
								break;
							}
							goto case 1;
							IL_0721:
							obj = __KnownINotifyPropertyChangingArgs.ParsedCount;
							obj6 = 33;
							goto IL_01d0;
							IL_0440:
							obj = __KnownINotifyPropertyChangingArgs.Description;
							obj6 = 30;
							goto IL_01d0;
							end_IL_01b1:
							break;
						}
						goto IL_0138;
						IL_0138:
						uint num2 = IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_0144: Stack underflow*/, (uint)/*Error near IL_0144: Stack underflow*/, ref *(INotifyPropertyChanged[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_013f: Stack underflow*/, (uint)/*Error near IL_013f: Stack underflow*/, (uint)/*Error near IL_013f: Stack underflow*/, (nint)obj3, (uint*)(nint)obj));
						num = 0;
						obj3 = num2;
						if (IEnumerable_object.ReflectSetAttribute != null)
						{
							num = 0;
							obj3 = num2;
						}
					}
					goto case 2;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00숀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777971, new IntPtr(2737335819932L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00쌀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00쐀()
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00씀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777968, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00였(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00윀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777969, new IntPtr(2737335801212L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSelectGame_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopGameModel gameModel;

		public DesktopViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object CheckScalableTracker;

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
		internal static bool ReflectModularModel()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectGroupedCreator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00대()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777982, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00됀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_067b: Expected Obj, but got I4
			//IL_067b: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I
			//IL_009f: Expected Obj, but got Ref
			//IL_0075: Expected Obj, but got Ref
			//IL_05a8: Expected Obj, but got Ref
			//IL_01c4: Expected Obj, but got Ref
			//IL_01d5: Expected Obj, but got I
			//IL_0176: Expected Obj, but got Ref
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Expected Obj, but got I
			//IL_0280: Expected Obj, but got Ref
			//IL_0289: Expected Obj, but got I4
			//IL_0365: Expected Obj, but got Ref
			//IL_036f: Expected Obj, but got I4
			//IL_0371: Expected Obj, but got I
			//IL_030c: Expected Obj, but got Ref
			//IL_0323: Expected Obj, but got I4
			//IL_0328: Expected Obj, but got I4
			//IL_0328: Expected Obj, but got Ref
			//IL_0237: Expected Obj, but got Ref
			//IL_0241: Expected I, but got Obj
			//IL_0243: Expected Obj, but got I4
			//IL_024c: Expected Obj, but got I4
			//IL_02d3: Expected Obj, but got Ref
			//IL_02a9: Expected Obj, but got I4
			//IL_02ae: Expected Obj, but got I4
			//IL_02ae: Expected Obj, but got Ref
			//IL_0294: Expected Obj, but got Ref
			//IL_0294: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a4: Expected Obj, but got I4
			//IL_03a9: Expected Obj, but got I4
			//IL_03a9: Expected Obj, but got Ref
			//IL_01a0: Expected Obj, but got I4
			//IL_01a5: Expected Obj, but got Ref
			//IL_03df: Expected Obj, but got Ref
			//IL_0259: Expected Obj, but got Ref
			//IL_0338: Expected Obj, but got Ref
			//IL_0340: Expected Obj, but got Ref
			//IL_016b: Expected I4, but got Obj
			//IL_068f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ab->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_069a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0099->IL0026: Incompatible stack types: I4 vs Obj
			//IL_05c6->IL00c2: Incompatible stack heights: 3 vs 1
			//IL_05d1->IL00c2: Incompatible stack heights: 3 vs 1
			//IL_00fa->IL00fe: Incompatible stack types: I4 vs Obj
			//IL_01da->IL00fe: Incompatible stack types: I4 vs Obj
			//IL_021b->IL00fe: Incompatible stack types: I4 vs Obj
			//IL_01e5->IL00fe: Incompatible stack types: I4 vs Obj
			//IL_0190->IL00fe: Incompatible stack types: I4 vs Obj
			//IL_0385->IL00fe: Incompatible stack heights: 2 vs 1
			//IL_031e->IL00fe: Incompatible stack heights: 2 vs 1
			//IL_0332->IL00fe: Incompatible stack types: I4 vs Obj
			//IL_02df->IL00fe: Incompatible stack types: I4 vs Obj
			//IL_0306->IL00fe: Incompatible stack heights: 2 vs 1
			//IL_042d->IL00fe: Incompatible stack heights: 2 vs 1
			//IL_02c2->IL00fe: Incompatible stack types: I4 vs Obj
			//IL_02a4->IL00fe: Incompatible stack types: I4 vs Obj
			//IL_03bd->IL00fe: Incompatible stack types: I4 vs Obj
			//IL_01af->IL00fe: Incompatible stack types: I4 vs Obj
			//IL_03ee->IL00fe: Incompatible stack heights: 4 vs 1
			//IL_026d->IL00fe: Incompatible stack types: I4 vs Obj
			//IL_0354->IL00fe: Incompatible stack heights: 4 vs 1
			//IL_019b->IL00fe: Incompatible stack types: I4 vs Obj
			//IL_0390->IL00fe: Incompatible stack heights: 2 vs 1
			//IL_02f5->IL00fe: Incompatible stack types: I4 vs Obj
			//IL_0438->IL00fe: Incompatible stack heights: 2 vs 1
			//IL_02cd->IL00fe: Incompatible stack types: I4 vs Obj
			//IL_03c8->IL00fe: Incompatible stack types: I4 vs Obj
			//IL_0231->IL00fe: Incompatible stack types: I4 vs Obj
			//IL_0278->IL00fe: Incompatible stack types: I4 vs Obj
			//IL_035f->IL00fe: Incompatible stack heights: 4 vs 1
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
				case 3:
					obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					obj2 = 2;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 2;
					}
					continue;
				case 5:
					*((int, nint)*)(nint)/*Error near IL_007a: Stack underflow*/ = ((int)/*Error near IL_007a: Stack underflow*/, (nint)Unsafe.AsPointer(ref IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute));
					obj2 = 1;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 0;
					}
					continue;
				case 4:
					obj = IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute;
					obj2 = 3;
					continue;
				case 2:
					if ((nuint)(nint)obj > (nuint)1u)
					{
						num = 5;
						goto IL_00c2;
					}
					goto IL_051c;
				case 1:
					return;
					IL_051c:
					num = 3;
					goto IL_00c2;
					IL_00c2:
					while (true)
					{
						object obj3;
						switch (num)
						{
						case 3:
							if (obj == null)
							{
								obj3 = 12;
								goto IL_00fe;
							}
							goto IL_0209;
						case 2:
							break;
						case 5:
							if (IEnumerator_System_IDisposable.DecorateSortedAttribute() == null)
							{
								goto end_IL_0026;
							}
							num = 2;
							if (__KnownINotifyPropertyChangingArgs.PayUrl != null)
							{
								num = 4;
							}
							continue;
						default:
							IEnumerable_System_IDisposable.Do_Abi_First_0((nint)/*Error near IL_059d: Stack underflow*/, (nint*)/*Error near IL_059d: Stack underflow*/);
							IEnumerable_System_IDisposable._002Ecctor();
							IMessengerExtensions.Send<NavigationMessage>((IMessenger)(object)__KnownINotifyPropertyChangingArgs.JoinedAt, (NavigationMessage)(object)IEnumerable_System_IDisposable.ReflectSequentialAttribute());
							_ = 2;
							if (__KnownINotifyPropertyChangingArgs.CreatedAt == null)
							{
								_ = 2;
							}
							continue;
						case 1:
						case 6:
							goto end_IL_0026;
							IL_01be:
							obj = IEnumerator_System_IDisposable.ReflectTransferableAttribute;
							obj3 = 0;
							if (IEnumerable_System_IDisposable.CombineAttribute != null)
							{
								obj3 = 0;
							}
							goto IL_00fe;
							IL_0209:
							if ((nint)obj != 1)
							{
								obj3 = 20;
								goto IL_00fe;
							}
							goto IL_01be;
							IL_00fe:
							while (true)
							{
								switch ((int)obj3)
								{
								default:
									IReadOnlyList_System_IDisposable._initialized = unchecked((nint)default(DependencyObject));
									obj3 = 6;
									if (IReadOnlyList_object.ReflectLogicalAttribute == null)
									{
										obj3 = 6;
									}
									continue;
								case 19:
									obj = 0;
									IEnumerator_System_IDisposable._initialized = 0;
									obj3 = 23;
									continue;
								case 15:
									break;
								case 24:
									goto IL_0209;
								case 21:
									if (IEnumerableMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(&obj)))
									{
										obj3 = 5;
										continue;
									}
									goto case 19;
								case 7:
									obj = IListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0241: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_0241: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)/*Error near IL_0241: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_0241: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_0241: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_0241: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int>)/*Error near IL_0241: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, int>)/*Error near IL_0241: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_0241: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_0241: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, int>)(int)IEnumerable_System_ComponentModel_INotifyPropertyChanged.Init());
									obj = 21;
									goto IL_00fa;
								case 23:
									Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute = obj;
									obj3 = 1;
									if (Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute != null)
									{
										obj3 = 4;
									}
									continue;
								case 1:
									Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute = obj;
									obj = 25;
									goto IL_00fa;
								case 17:
									Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute = (object)default(MarshalInspectable<>);
									obj3 = 18;
									continue;
								case 16:
									obj = 1;
									Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute = 1;
									obj3 = 1;
									if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute != null)
									{
										obj3 = 1;
									}
									continue;
								case 9:
								case 12:
									obj = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance;
									obj3 = 17;
									continue;
								case 10:
									IListMethods<object>.Abi_Clear_9((IntPtr)(nint)(&obj));
									if ((int)/*Error near IL_02eb: Stack underflow*/ != 0)
									{
										obj3 = 22;
										continue;
									}
									goto case 16;
								case 11:
								case 22:
									IListMethods<object>.Abi_GetMany_10((IntPtr)/*Error near IL_02fc: Stack underflow*/, (uint)/*Error near IL_02fc: Stack underflow*/, ref *(object[]*)(&obj));
									_ = 14;
									continue;
								case 4:
									_ = ref _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout;
									((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CSelectGame_003Ed__34, AccountViewModel._003CLoginDesktop_003Ed__87>(ref this));
									_ = 8;
									continue;
								case 6:
									obj = -1;
									_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator = -1;
									obj3 = 11;
									continue;
								case 25:
									_ = ref __KnownINotifyPropertyChangingArgs.Notes;
									_ = ref obj;
									WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>((IAsyncOperation<ContentDialogResult>)(object)Unsafe.AsPointer(ref this));
									_ = 1;
									if (__KnownINotifyPropertyChangingArgs.CreateAt == null)
									{
										_ = 2;
									}
									continue;
								case 3:
									_ = __KnownINotifyPropertyChangingArgs.LoginAt;
									obj = (nint)MarshalInterface<IDisposable>.FromManaged((IDisposable)IEnumerator_System_ComponentModel_INotifyPropertyChanged.Initialized);
									_ = 10;
									if (__KnownINotifyPropertyChangingArgs.CharacterName != null)
									{
										_ = 3;
									}
									continue;
								case 18:
									obj = -1;
									__KnownINotifyPropertyChangingArgs.Content = (PropertyChangingEventArgs)(-1);
									obj3 = 9;
									if (__KnownINotifyPropertyChangingArgs.IsSkeleton != null)
									{
										obj3 = 13;
									}
									continue;
								case 8:
									return;
								case 20:
									_ = __KnownINotifyPropertyChangingArgs.CanProxy;
									IEnumerator_System_ComponentModel_INotifyPropertyChanged.DecorateConcreteAttribute();
									_ = 7;
									continue;
								case 2:
									return;
								case 5:
								case 13:
									IReadOnlyListMethods<object>.Abi_GetMany_3((IntPtr)/*Error near IL_0419: Stack underflow*/, (uint)/*Error near IL_0419: Stack underflow*/, ref *(object[]*)(&obj));
									_ = 3;
									if (__KnownINotifyPropertyChangingArgs.Version == null)
									{
										_ = 1;
									}
									continue;
								case 14:
									goto end_IL_0026;
									IL_00fa:
									obj3 = obj;
									continue;
								}
								break;
							}
							goto IL_01be;
						}
						break;
					}
					goto IL_051c;
					end_IL_0026:
					break;
				}
				__KnownINotifyPropertyChangingArgs.Input4399Password = (PropertyChangingEventArgs)(-2);
				obj2 = 5;
				if (__KnownINotifyPropertyChangingArgs.InputMobilePassword == null)
				{
					obj2 = 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00딀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777983, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00똀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777980, new IntPtr(2737335806412L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00뜀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00렀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777981, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00뤀()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00먀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00묀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777978, new IntPtr(2737335818892L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSelectSkin_003Ed__112 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopSkinModel skinModel;

		public DesktopViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object CheckAccessibleManager;

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
		internal static bool DecorateIsolatedEngine()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckAutomatableCompiler()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00꤀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777979, new IntPtr(2737335824092L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00ꨀ()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0075: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I
			//IL_008a: Expected Obj, but got Ref
			//IL_009b: Expected Obj, but got I
			//IL_00b3: Expected Obj, but got Ref
			//IL_0258: Expected Obj, but got Ref
			//IL_022e: Expected Obj, but got Ref
			//IL_01b2: Expected Obj, but got I4
			//IL_01b7: Expected Obj, but got I4
			//IL_01b7: Expected Obj, but got Ref
			//IL_0182: Expected Obj, but got Ref
			//IL_018c: Expected I, but got Obj
			//IL_0143: Expected Obj, but got Ref
			//IL_0200: Expected Obj, but got Ref
			//IL_0208: Expected Obj, but got Ref
			//IL_0208: Expected Obj, but got Ref
			//IL_012e: Expected Obj, but got Ref
			//IL_0133: Expected I, but got Obj
			//IL_0133: Expected I4, but got Obj
			//IL_0158: Expected Obj, but got I4
			//IL_015d: Expected Obj, but got I4
			//IL_015d: Expected Obj, but got Ref
			//IL_0166: Expected Obj, but got I4
			//IL_01d1: Expected Obj, but got Ref
			//IL_026c: Expected Obj, but got Ref
			//IL_0242: Expected Obj, but got I4
			//IL_0121: Expected I4, but got Obj
			//IL_0084->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ab->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0264->IL00e8: Incompatible stack types: I4 vs Obj
			//IL_00e4->IL00e8: Incompatible stack types: I4 vs Obj
			//IL_00d2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01c1->IL00e8: Incompatible stack types: I4 vs Obj
			//IL_01a2->IL00e8: Incompatible stack heights: 2 vs 1
			//IL_017c->IL00e8: Incompatible stack types: I4 vs Obj
			//IL_0153->IL00e8: Incompatible stack types: I4 vs Obj
			//IL_021c->IL00e8: Incompatible stack heights: 3 vs 1
			//IL_013d->IL00e8: Incompatible stack heights: 2 vs 1
			//IL_01ef->IL00e8: Incompatible stack heights: 3 vs 1
			//IL_0280->IL00e8: Incompatible stack types: I4 vs Obj
			//IL_0247->IL00e8: Incompatible stack types: I4 vs Obj
			//IL_01ad->IL00e8: Incompatible stack heights: 2 vs 1
			//IL_0227->IL00e8: Incompatible stack heights: 3 vs 1
			//IL_01fa->IL00e8: Incompatible stack heights: 3 vs 1
			//IL_028b->IL00e8: Incompatible stack types: I4 vs Obj
			//IL_0252->IL00e8: Incompatible stack types: I4 vs Obj
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
				case 1:
					obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					obj2 = 3;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 0;
					}
					continue;
				default:
					*((int, nint)*)(nint)/*Error near IL_007a: Stack underflow*/ = ((int)/*Error near IL_007a: Stack underflow*/, (nint)Unsafe.AsPointer(ref IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute));
					obj2 = 4;
					continue;
				case 2:
					obj = IList_object.PatchAttribute;
					obj2 = 0;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
					{
						obj2 = 1;
					}
					continue;
				case 5:
					break;
				case 3:
					if (obj != null)
					{
						obj3 = 11;
						goto IL_00e8;
					}
					goto IL_0252;
				case 4:
					return;
					IL_0252:
					obj = __KnownINotifyPropertyChangingArgs.Notes;
					obj3 = 5;
					goto IL_00e8;
					IL_00e8:
					while (true)
					{
						switch ((int)obj3)
						{
						case 7:
							break;
						case 9:
							IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_0133: Stack underflow*/, (uint)(int)obj, (nint*)(nint)IReadOnlyList_object.ReflectLogicalAttribute);
							_ = 2;
							continue;
						case 5:
							Unsafe.As<object, void>(ref IEnumerator_System_IDisposable.ReflectTransferableAttribute) = default;
							obj3 = 10;
							continue;
						case 10:
							obj = -1;
							IEnumerable_System_IDisposable.CombineAttribute = -1;
							obj = 4;
							obj3 = obj;
							continue;
						case 4:
							MarshalInterface<INotifyPropertyChanged>.CopyManagedArray((INotifyPropertyChanged[])/*Error near IL_0172: Stack underflow*/, (IntPtr)(nint)(&obj));
							obj3 = 7;
							continue;
						case 2:
							_ = IEnumerable_object.ReflectSetAttribute;
							obj = IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.CheckSymbolicAttribute());
							_ = 0;
							if (Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute == null)
							{
								_ = 0;
							}
							continue;
						case 1:
							obj = 0;
							Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute = 0;
							obj3 = 12;
							continue;
						case 11:
							IEnumerable_System_ComponentModel_INotifyPropertyChanged.DecorateSeparatedAttribute();
							IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectMonoAttribute();
							((AsyncTaskMethodBuilder*)Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute)->Start(ref *(AccountViewModel._003CImportAccounts_003Ed__28*)IList_object.Init());
							_ = 9;
							if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute != null)
							{
								_ = 9;
							}
							continue;
						case 8:
							_ = ref Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute;
							JsonSerializer.Deserialize<object>((string)(&obj), (JsonSerializerOptions?)Unsafe.AsPointer(ref this));
							_ = 3;
							if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule == null)
							{
								_ = 2;
							}
							continue;
						default:
							IListMethods<object>.Abi_ReplaceAll_11((IntPtr)/*Error near IL_022e: Stack underflow*/, (object[])(&obj));
							if ((int)/*Error near IL_0233: Stack underflow*/ == 0)
							{
								obj3 = 1;
								if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator == null)
								{
									obj3 = 1;
								}
								continue;
							}
							goto case 4;
						case 6:
							goto end_IL_00e8;
						case 12:
							__KnownINotifyPropertyChangingArgs.UserId = (PropertyChangingEventArgs)obj;
							obj3 = 8;
							if (__KnownINotifyPropertyChangingArgs.CreateAt != null)
							{
								obj3 = 5;
							}
							continue;
						case 3:
							return;
						}
						goto end_IL_0026;
						continue;
						end_IL_00e8:
						break;
					}
					goto IL_0252;
					end_IL_0026:
					break;
				}
				IReadOnlyList_System_IDisposable._initialized = -2;
				obj2 = 0;
				if (IReadOnlyList_object._initialized != 0)
				{
					obj2 = 0;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_AB00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777976, new IntPtr(2737335812652L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00가()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00관()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777977, new IntPtr(2737335823052L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00글()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777926, new IntPtr(2737335806412L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00꼀()
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00뀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777927, new IntPtr(2737335818892L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00넀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777924, new IntPtr(2737335820972L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00눀(object P_0)
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
	private struct _003CSetSkin_003Ed__113 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopSkinModel skinModel;

		private TaskAwaiter _003C_003Eu__1;

		internal static object EvaluateObject;

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
		internal static bool ReflectIntegratedPredicate()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckLocalStub()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00ꀀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777925, new IntPtr(2737335806412L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00ꄀ()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Expected I4, but got Obj
			//IL_004c: Expected Obj, but got Ref
			//IL_0380: Expected Obj, but got Ref
			//IL_0355: Expected Obj, but got Ref
			//IL_0289: Expected Obj, but got Ref
			//IL_0175: Expected Obj, but got I4
			//IL_017a: Expected Obj, but got I4
			//IL_017a: Expected Obj, but got Ref
			//IL_0183: Expected Obj, but got I4
			//IL_00d1: Expected Obj, but got Ref
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected Obj, but got Ref
			//IL_022a: Expected Obj, but got Ref
			//IL_00e7: Expected Obj, but got Ref
			//IL_00ec: Expected I, but got Obj
			//IL_00f3: Expected Obj, but got I
			//IL_0102: Expected Obj, but got I
			//IL_01b1: Expected Obj, but got I4
			//IL_01b6: Expected Obj, but got I4
			//IL_01b6: Expected Obj, but got Ref
			//IL_024f: Expected Obj, but got Ref
			//IL_025a: Expected Obj, but got I4
			//IL_00c6: Expected I4, but got Obj
			//IL_0056->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0396->IL0026: Incompatible stack types: I4 vs Obj
			//IL_036e->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0072->IL0081: Incompatible stack types: I4 vs Obj
			//IL_03a1->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0379->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0298->IL0081: Incompatible stack types: I4 vs Obj
			//IL_007d->IL0081: Incompatible stack types: I4 vs Obj
			//IL_0222->IL0081: Incompatible stack heights: 2 vs 1
			//IL_00e1->IL0081: Incompatible stack types: I4 vs Obj
			//IL_01ed->IL0081: Incompatible stack heights: 2 vs 1
			//IL_023e->IL0081: Incompatible stack types: I4 vs Obj
			//IL_0107->IL0081: Incompatible stack types: I4 vs Obj
			//IL_01ca->IL0081: Incompatible stack types: I4 vs Obj
			//IL_0141->IL0081: Incompatible stack types: I4 vs Obj
			//IL_0249->IL0081: Incompatible stack types: I4 vs Obj
			//IL_0112->IL0081: Incompatible stack types: I4 vs Obj
			//IL_01d5->IL0081: Incompatible stack types: I4 vs Obj
			//IL_014c->IL0081: Incompatible stack types: I4 vs Obj
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
				default:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = -2;
					obj2 = 3;
					break;
				case 1:
					if (obj == null)
					{
						obj3 = 1;
						if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
						{
							obj3 = 2;
						}
						goto IL_0081;
					}
					goto IL_0283;
				case 3:
					IReadOnlyListMethods<IDisposable>.Abi_IndexOf_2((IntPtr)/*Error near IL_035a: Stack underflow*/, (IDisposable)/*Error near IL_035a: Stack underflow*/, ref Unsafe.As<PropertyChangingEventArgs, uint>(ref __KnownINotifyPropertyChangingArgs.Message));
					_ = 4;
					if (__KnownINotifyPropertyChangingArgs.IsSelected == null)
					{
						_ = 1;
					}
					break;
				case 4:
					return;
				case 2:
					{
						obj = __KnownINotifyPropertyChangingArgs.IsSkeleton;
						obj2 = 0;
						if (__KnownINotifyPropertyChangingArgs.ShowMaxPlayer != null)
						{
							obj2 = 1;
						}
						break;
					}
					IL_0081:
					while (true)
					{
						switch ((int)obj3)
						{
						case 3:
						case 11:
							break;
						case 7:
							IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute = (object)default(Window);
							obj3 = 13;
							continue;
						case 12:
						case 14:
							obj = (nint)MarshalInspectable<object>.FromManaged((object)/*Error near IL_00f1: Stack underflow*/, (byte)IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_00ec: Stack underflow*/, (byte*)(nint)IList_object.PatchAttribute) != 0);
							obj3 = 3;
							if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
							{
								obj3 = 5;
							}
							continue;
						case 5:
							if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)/*Error near IL_0128: Stack underflow*/, (uint)(&obj)) != null)
							{
								obj3 = 9;
								if (IEnumerator_System_IDisposable._initialized != 0)
								{
									obj3 = 3;
								}
								continue;
							}
							goto case 6;
						case 6:
							obj = 0;
							IEnumerable_System_IDisposable.CombineAttribute = 0;
							obj = 10;
							goto IL_007d;
						case 4:
							return;
						case 13:
							obj = -1;
							GlobalVtableLookup.CreateAttribute = -1;
							obj3 = 0;
							if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute != null)
							{
								obj3 = 1;
							}
							continue;
						case 8:
							_ = ref Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute;
							((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CSetSkin_003Ed__113, AccountViewModel._003CEditAccount_003Ed__22>(ref this));
							_ = 4;
							continue;
						case 1:
						case 9:
							MarshalInspectable<object>.FromAbi((IntPtr)(nint)(&obj));
							_ = 11;
							continue;
						case 10:
							Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute = obj;
							obj3 = 8;
							if (Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute == null)
							{
								obj3 = 8;
							}
							continue;
						case 2:
						case 15:
							obj = Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute;
							obj = 7;
							goto IL_007d;
						default:
							goto IL_0283;
							IL_007d:
							obj3 = obj;
							continue;
						}
						break;
					}
					goto default;
					IL_0283:
					if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute == null)
					{
						goto default;
					}
					obj3 = 14;
					goto IL_0081;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00ꈀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777922, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00ꌀ()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00ꐀ()
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00ꔀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777923, new IntPtr(2737335812652L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00ꘀ(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_A700(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777920, new IntPtr(2737335798092L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStartProxy_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object UpdateSummarizer;

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
		internal static bool OpenProgram()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateSeparatedViewer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00頀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777921, new IntPtr(2737335813692L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00餀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_007a: Expected Obj, but got Ref
			//IL_0083: Expected Obj, but got I4
			//IL_004e: Expected Obj, but got Ref
			//IL_0062: Expected Obj, but got I
			//IL_00b5: Expected Obj, but got Ref
			//IL_00b7: Expected Obj, but got I
			//IL_008e: Expected Obj, but got Ref
			//IL_009f: Expected Obj, but got I
			//IL_0167: Expected I, but got Obj
			//IL_0167: Expected I4, but got Obj
			//IL_01a9: Expected Obj, but got Ref
			//IL_01b1: Expected Obj, but got Ref
			//IL_01b1: Expected Obj, but got Ref
			//IL_01e7: Expected Obj, but got Ref
			//IL_0193: Expected Obj, but got Ref
			//IL_0247: Expected I, but got Obj
			//IL_024e: Expected I, but got Obj
			//IL_0253: Expected Obj, but got I4
			//IL_01f6: Expected Obj, but got I4
			//IL_01fb: Expected Obj, but got I4
			//IL_01fb: Expected Obj, but got Ref
			//IL_0289: Expected Obj, but got I4
			//IL_028e: Expected Obj, but got I4
			//IL_028e: Expected Obj, but got Ref
			//IL_02c2: Expected Obj, but got Ref
			//IL_02c4: Expected Obj, but got I4
			//IL_0305: Expected I, but got Obj
			//IL_0067->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00cb->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a4->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0072->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00d6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00af->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0151->IL00ed: Incompatible stack heights: 2 vs 1
			//IL_0136->IL0160: Incompatible stack heights: 0 vs 1
			//IL_01c5->IL00ed: Incompatible stack heights: 2 vs 1
			//IL_0235->IL00ed: Incompatible stack heights: 2 vs 1
			//IL_0310->IL0310: Incompatible stack heights: 0 vs 1
			//IL_030b->IL030b: Incompatible stack heights: 1 vs 2
			//IL_01d0->IL00ed: Incompatible stack heights: 2 vs 1
			//IL_0240->IL00ed: Incompatible stack heights: 2 vs 1
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
					int num;
					object obj3;
					uint num2;
					PropertyChangingEventArgs userId;
					switch ((int)obj2)
					{
					default:
						return;
					case 3:
						IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)/*Error near IL_0053: Stack underflow*/, ref Unsafe.As<nint, object[]>(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized));
						_ = 0;
						if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
						{
							_ = 0;
						}
						continue;
					case 2:
						break;
					case 5:
						obj = IList_object.PatchAttribute;
						obj2 = 4;
						if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
						{
							obj2 = 3;
						}
						continue;
					case 4:
						obj = IReadOnlyList_System_IDisposable._initialized;
						obj2 = 0;
						if (IReadOnlyList_object._initialized == 0)
						{
							obj2 = 1;
						}
						continue;
					case 0:
						return;
					case 1:
						{
							if (obj == null)
							{
								num = 4;
								goto IL_00ed;
							}
							goto IL_013b;
						}
						IL_013b:
						obj3 = obj;
						if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init() == 0)
						{
							_ = 3;
							goto IL_00ed;
						}
						goto IL_0160;
						IL_0310:
						obj = null as ComWrappers;
						num = 8;
						goto IL_00ed;
						IL_0160:
						num2 = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_0167: Stack underflow*/, (uint)(int)obj3, (nint*)(nint)obj);
						if (num2 == 0)
						{
							num = 0;
							if (IEnumerable_System_IDisposable._initialized != 0)
							{
								num = 0;
							}
							goto IL_00ed;
						}
						userId = __KnownINotifyPropertyChangingArgs.UserId;
						if (userId == null)
						{
							__KnownINotifyPropertyChangingArgs.Name = (PropertyChangingEventArgs)new IReadOnlyListMethods<IDisposable, nint>((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0305: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)(int)num2, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)__KnownINotifyPropertyChangingArgs.Username, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(delegate*<bool>)(&IList_object.AttachAttribute));
						}
						((AsyncTaskMethodBuilder*)/*Error near IL_0310: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)num2, ref *(AccountViewModel._003CImportAccounts_003Ed__28*)userId);
						goto IL_0310;
						IL_00ed:
						while (true)
						{
							switch (num)
							{
							case 1:
							case 3:
								break;
							case 11:
								return;
							case 5:
								goto end_IL_00ed;
							case 12:
								goto IL_0160;
							case 7:
								Unsafe.As<object, bool>(ref IEnumerable_System_IDisposable.CombineAttribute) = default;
								num = 15;
								continue;
							case 2:
								Interlocked.CompareExchange(ref Unsafe.As<object, Func<InfoBarDelegate>>(ref IEnumerable_object.ReflectSetAttribute), (Func<InfoBarDelegate>)(&obj), (Func<InfoBarDelegate>)Unsafe.AsPointer(ref this));
								_ = 2;
								if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute == null)
								{
									_ = 11;
								}
								continue;
							case 6:
								Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute = obj;
								num = 2;
								continue;
							case 10:
								obj = 0;
								Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute = 0;
								num = 6;
								if (Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute == null)
								{
									num = 4;
								}
								continue;
							case 9:
							case 13:
								MarshalInspectable<object>.FromAbi((IntPtr)(nint)(&obj));
								_ = 1;
								if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute == null)
								{
									_ = 0;
								}
								continue;
							case 8:
								IListMethods<object>.Abi_Append_7((IntPtr)/*Error near IL_0253: Stack underflow*/, (object)IList_object.Do_Abi_IndexOf_3((nint)/*Error near IL_024e: Stack underflow*/, (nint)/*Error near IL_024e: Stack underflow*/, (uint*)(int)IList_object.Do_Abi_GetView_2((nint)/*Error near IL_0247: Stack underflow*/, (nint*)(nint)obj), (byte*)(nint)obj));
								obj = (object)/*Error near IL_0255: Stack underflow*/;
								num = 14;
								continue;
							case 14:
								IListMethods<object>.Abi_RemoveAtEnd_8((IntPtr)(nint)(&obj));
								if ((int)/*Error near IL_026b: Stack underflow*/ != 0)
								{
									num = 13;
									continue;
								}
								goto case 10;
							case 15:
								obj = -1;
								_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute = -1;
								num = 9;
								continue;
							case 4:
							case 16:
								obj = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout;
								num = 7;
								if (__KnownINotifyPropertyChangingArgs.Notes == null)
								{
									num = 3;
								}
								continue;
							default:
								goto IL_02e3;
							}
							goto end_IL_0026;
							continue;
							end_IL_00ed:
							break;
						}
						goto IL_013b;
						IL_02e3:
						goto IL_0310;
					}
					break;
					continue;
					end_IL_0026:
					break;
				}
				IList_object._initialized = -2;
				obj = 3;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00騀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777934, new IntPtr(2737335823052L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00鬀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00鰀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777935, new IntPtr(2737335814732L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00鴀()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00鸀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00鼀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777932, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? addCharacterCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? addRandomCharacterCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? startProxyCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? launchGameCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? openGameResourceFolderCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? launchShadowClientCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? launchEchoClientCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? launchHeadlessShadowClientCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? clearSelectedServiceCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand<DesktopGameModel>? loadGameConfigurationCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<DesktopGameModel>? selectGameCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? refreshGameCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? refreshLanGameCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? refreshNetGamesCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? refreshRentalGameCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? refreshSkinCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<DesktopSkinModel>? selectSkinCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<DesktopSkinModel?>? setSkinCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand<AutoSuggestBoxQuerySubmittedEventArgs>? searchCommand;

	private static object CheckMixedEvent;

	private ObservableCollection<ConfigValue>? SectionValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00鸀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00Ḁ(value);
		}
	}

	public bool IsShadowClientEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 휀() != 0;
		}
	}

	public bool IsShadowClientMaintenance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00䔀() != 0;
		}
	}

	public bool IsEnderClientEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_3300() != 0;
		}
	}

	public bool IsEnderClientMaintenance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _E600() != 0;
		}
	}

	public bool IsEchoClientEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00嘀() != 0;
		}
	}

	public bool IsEchoClientMaintenance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00言() != 0;
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[NotifyPropertyChangedFor("HasSelectedGame")]
	[ObservableProperty]
	public DesktopGameModel? SelectedGame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (DesktopGameModel?)_FF00紀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FFFD(value);
		}
	}

	public bool HasSelectedGame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return this._FFFD() != 0;
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public ObservableCollection<DesktopGameModel> LanGames
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 豈();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00洀(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public string LanGamesEmptyText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00开();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_A700(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[NotifyPropertyChangedFor("FourLikeNetGames")]
	[NotifyPropertyChangedFor("LikeNetGames")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public ObservableCollection<DesktopGameModel> NetGames
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00㐀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_0C00(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public ObservableCollection<DesktopGameModel> LikeNetGames
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00伀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_2300(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public ObservableCollection<DesktopGameModel> FourLikeNetGames
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00䤀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00ᘀ(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public string NetGamesEmptyText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00鈀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00가(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public string LikeNetGamesEmptyText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00缀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			턀(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public ObservableCollection<DesktopGameModel> RentalGames
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _E300();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00餀(value);
		}
	}

	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public string RentalGamesEmptyText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00戀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00ꐀ(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ObservableCollection<DesktopSkinModel> Skins
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _F600();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00儀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public string SkinEmptyText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)this._FFFD();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00笀(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public int CurrentSkinPage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00䄀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00㬀((uint)value);
		}
	}

	public bool SkinOwnedSelected
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00䜀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00萀(value ? ((byte)1) : ((byte)0));
		}
	}

	[ObservableProperty]
	[NotifyPropertyChangedFor("SkinOwnedSelected")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool SkinAllSelected
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00䈀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00䰀(value ? ((byte)1) : ((byte)0));
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public DesktopSkinModel? SelectedSkin
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (DesktopSkinModel?)_FF00_0E00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_2800(value);
		}
	}

	[ObservableProperty]
	[NotifyPropertyChangedFor("HasSkins")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int PagesOfSkins
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_0A00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_F400((uint)value);
		}
	}

	public bool HasSkins
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00贀() != 0;
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public int SelectedPageOfSkin
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00帀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FFFD((uint)value);
		}
	}

	public int CurrentDisplayPage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00㨀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00稀((uint)value);
		}
	}

	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public string SearchText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_EC00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_EE00(value);
		}
	}

	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public string LastSearchText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00ᤀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00阀(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public bool SearchVisibility
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_3000() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00娀(value ? ((byte)1) : ((byte)0));
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand AddCharacterCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00က();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand AddRandomCharacterCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)this._FFFD();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand StartProxyCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00騀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand LaunchGameCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00鐀();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand OpenGameResourceFolderCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00㸀();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand LaunchShadowClientCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_F300();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand LaunchEchoClientCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_0300();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand LaunchHeadlessShadowClientCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00吀();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IRelayCommand ClearSelectedServiceCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IRelayCommand)_FF00ꘀ();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand<DesktopGameModel> LoadGameConfigurationCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 팀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<DesktopGameModel> SelectGameCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_2B00();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand RefreshGameCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_2E00();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand RefreshLanGameCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)픀();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand RefreshNetGamesCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00鰀();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand RefreshRentalGameCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00䬀();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand RefreshSkinCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00㠀();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand<DesktopSkinModel> SelectSkinCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00蠀();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand<DesktopSkinModel?> SetSkinCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00䐀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand<AutoSuggestBoxQuerySubmittedEventArgs> SearchCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00礀();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddCharacter_003Ed__0))]
	[RelayCommand]
	private object AddCharacter()
	{
		return _FF00Ȁ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CAddRandomCharacter_003Ed__1))]
	private object AddRandomCharacter()
	{
		return _FF00謀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CStartProxy_003Ed__2))]
	[RelayCommand]
	private object StartProxy()
	{
		return _FF00甀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CLaunchGame_003Ed__3))]
	private object LaunchGame()
	{
		return _FF00搀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COpenGameResourceFolder_003Ed__4))]
	[RelayCommand]
	private object OpenGameResourceFolder()
	{
		return _FF00脀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand(CanExecute = "GetCanLaunchShadowClient")]
	[AsyncStateMachine(typeof(_003CLaunchShadowClient_003Ed__5))]
	private object LaunchShadowClient()
	{
		return _FF00ጀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte GetCanLaunchShadowClient()
	{
		return ﬀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLaunchEchoClient_003Ed__7))]
	[RelayCommand(CanExecute = "GetCanLaunchEchoClient")]
	private object LaunchEchoClient()
	{
		return _FF00_0700();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte GetCanLaunchEchoClient()
	{
		return _FF00蜀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand(CanExecute = "GetCanLaunchEnderClient")]
	[AsyncStateMachine(typeof(_003CLaunchHeadlessShadowClient_003Ed__9))]
	private object LaunchHeadlessShadowClient()
	{
		return _FF00漀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte GetCanLaunchEnderClient()
	{
		return _FF00ꨀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStackPanelLoaded(StackPanel panel)
	{
		_FF00眀(panel);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[MemberNotNullWhen(true, "SelectedGame")]
	private byte HadSelectedGame()
	{
		return _FFFD();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	private void ClearSelectedService()
	{
		_FF00蘀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	public void LoadGameConfiguration(DesktopGameModel gameModel)
	{
		_FF00ꈀ(gameModel);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSelectGame_003Ed__34))]
	[RelayCommand]
	public Task SelectGame(DesktopGameModel gameModel)
	{
		return (Task)_FF00焀(gameModel);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshGame_003Ed__35))]
	[RelayCommand]
	public Task RefreshGame()
	{
		return (Task)_FF00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshLanGame_003Ed__46))]
	[RelayCommand]
	private object RefreshLanGame()
	{
		return _FF00㰀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CRefreshNetGames_003Ed__67))]
	private object RefreshNetGames()
	{
		return _FF00最();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateLikeNetGames(byte save = 0)
	{
		_EA00(save);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NetGamesCollectionChanged(object? sender, object e)
	{
		_FF00夀(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ItemPropertyChanged(object? sender, object e)
	{
		_F100(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CRefreshRentalGame_003Ed__79))]
	private object RefreshRentalGame()
	{
		return _E100();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshSkin_003Ed__111))]
	[RelayCommand]
	private object RefreshSkin()
	{
		return _FF00_2000();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSelectSkin_003Ed__112))]
	[RelayCommand]
	public Task SelectSkin(DesktopSkinModel skinModel)
	{
		return (Task)_FF00尀(skinModel);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetSkin_003Ed__113))]
	[RelayCommand]
	public Task SetSkin(DesktopSkinModel? skinModel)
	{
		return (Task)_FF00樀(skinModel);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe DesktopViewModel()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0036: Expected I, but got Obj
		//IL_003b: Expected Obj, but got VT
		//IL_0046: Expected I, but got Obj
		//IL_0056: Expected I, but got Obj
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_009a: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I4
		//IL_0126: Expected I, but got Obj
		//IL_013a->IL010e: Incompatible stack heights: 2 vs 1
		//IL_0145->IL010e: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = new ExceptionHelpers((Exception)(object)this);
		IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute = this;
		IList_object.PatchAttribute = ((int)/*Error near IL_0036: Stack underflow*/, (nint)this);
		IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute = new IEnumeratorMethods<object>((IntPtr)this);
		IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = new IEnumeratorMethods<object>((IntPtr)this);
		IReadOnlyList_object.ReflectLogicalAttribute = this;
		IEnumerator_System_IDisposable.ReflectTransferableAttribute = this;
		IEnumerable_System_IDisposable.CombineAttribute = new MarshalInterface<INotifyPropertyChanged>((object)this);
		IEnumerable_object.ReflectSetAttribute = this;
		Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute = new IEnumerableMethods<INotifyPropertyChanged, nint>((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)this);
		Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute = this;
		Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute = 1;
		Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute = 1;
		Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute = this;
		Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute = this;
		IListMethods<object>.Abi_InsertAt_5((IntPtr)/*Error near IL_00e6: Stack underflow*/, (uint)/*Error near IL_00e6: Stack underflow*/, (object)this);
		int num = 1;
		if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute == null)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				IList_object.Do_Abi_InsertAt_5((nint)/*Error near IL_0126: Stack underflow*/, (uint)/*Error near IL_0126: Stack underflow*/, (nint)this);
				_ = 0;
				if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule != null)
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
	public void Dispose()
	{
		ﰀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Initialize()
	{
		ﴀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Clear()
	{
		_FF00怀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	public void OnSearch(AutoSuggestBoxQuerySubmittedEventArgs args)
	{
		_FF00㘀(args);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnSkinAllSelectedChanged(byte oldValue, byte newValue)
	{
		_FF00_1B00(oldValue, newValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnSelectedPageOfSkinChanged(uint oldValue, uint newValue)
	{
		_FF00_0600(oldValue, newValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectFlexibleWrapper()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DesktopViewModel PresentProfile()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 퀀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778029, new IntPtr(2737335740316L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 턀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0053: Expected I, but got Obj
		//IL_0083: Expected I, but got Obj
		//IL_00cc: Expected Obj, but got I
		//IL_005d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0072->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0088->IL005d: Incompatible stack heights: 1 vs 0
		//IL_00d1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00dc->IL0026: Incompatible stack types: I4 vs Obj
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
				_ = 5;
				break;
			case 1:
				/*Error near IL_0068: Stack underflow*/((object[])(object)this, IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized);
				obj2 = 4;
				break;
			case 3:
				*((int, nint)*)(nint)/*Error near IL_0077: Stack underflow*/ = ((int)/*Error near IL_0077: Stack underflow*/, (nint)/*Error near IL_0077: Stack underflow*/);
				_ = IList_object.PatchAttribute;
				if (IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)P_0) != null)
				{
					_ = 2;
					break;
				}
				goto case 1;
			case 2:
				return;
			case 4:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
				obj2 = 0;
				if (IReadOnlyList_object.ReflectLogicalAttribute == null)
				{
					obj2 = 0;
				}
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 툀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778026, new IntPtr(2737335740316L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IRelayCommand<DesktopGameModel> 팀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17517, 1790778027, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778027, new IntPtr(2737335740316L), 15);
		}
		return (IRelayCommand<DesktopGameModel>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IRelayCommand<DesktopGameModel> 퐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778024, new IntPtr(2737335708076L), 15))(null, 0, new IntPtr(0L));
		return (IRelayCommand<DesktopGameModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 픀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17519, 1790778025, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778025, new IntPtr(2737335708076L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 혀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778038, new IntPtr(2737335741356L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte 휀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0059: Expected Obj, but got I
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0069->IL0026: Incompatible stack types: I4 vs Obj
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
			{
				int hRForException = ExceptionHelpers.GetHRForException((Exception)/*Error near IL_003d: Stack underflow*/);
				if (hRForException != 0)
				{
					*(ValueTuple<int, nint>*)(nint)/*Error near IL_0070: Stack underflow*/ = ((int)/*Error near IL_0070: Stack underflow*/, hRForException);
					return (byte)/*Error near IL_0071: Stack underflow*/;
				}
				obj2 = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					obj2 = 0;
				}
				break;
			}
			default:
				return 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778039, new IntPtr(2737335754876L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778036, new IntPtr(2737335741356L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FFFD()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17524, 1790778037, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778037, new IntPtr(2737335741356L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe byte _FFFD()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_006c: Expected I, but got Obj
		//IL_0073: Expected I, but got Obj
		//IL_0073: Expected I, but got Obj
		//IL_0056: Expected Obj, but got I4
		//IL_004d->IL005b: Incompatible stack heights: 1 vs 0
		//IL_0087->IL0026: Incompatible stack heights: 2 vs 1
		//IL_005b->IL0022: Incompatible stack heights: 1 vs 0
		//IL_0092->IL0026: Incompatible stack heights: 2 vs 1
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
					return 0;
				case 3:
					if (_003CModule_003E.CheckAccessibleAttribute() == null)
					{
						goto end_IL_0026;
					}
					goto case 1;
				case 1:
					return 1;
				case 2:
					IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_0073: Stack underflow*/, IEnumerator_object.Do_Abi_MoveNext_2((nint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute, (byte*)(int)IEnumerator_object.Init()), unchecked((nint)null), (uint*)unchecked((nint)null));
					_ = 0;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						_ = 0;
					}
					break;
				}
				continue;
				end_IL_0026:
				break;
			}
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FFFD()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (_003CModule_003E.CheckAccessibleAttribute() != null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FFFD(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_0102: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I
		//IL_0057: Expected I, but got Obj
		//IL_0066: Expected Obj, but got I
		//IL_010c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008c->IL00d3: Incompatible stack heights: 1 vs 0
		//IL_00be->IL0026: Incompatible stack heights: 5 vs 1
		//IL_00d3->IL0026: Incompatible stack heights: 3 vs 1
		//IL_006b->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00fb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a0->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0076->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ab->IL0026: Incompatible stack heights: 2 vs 1
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
			case 6:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 0;
				}
				break;
			case 2:
				*((int, nint)*)(nint)/*Error near IL_007b: Stack underflow*/ = ((int)/*Error near IL_007b: Stack underflow*/, (nint)/*Error near IL_007b: Stack underflow*/);
				_ = IList_object.PatchAttribute;
				if (IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)(int)P_0) == null)
				{
					_ = 1;
					if (IReadOnlyList_System_IDisposable._initialized != 0)
					{
						_ = 1;
					}
					break;
				}
				return;
			case 4:
				IEnumerator_object.LoadAttribute();
				_ = 5;
				break;
			case 5:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 3;
				break;
			case 3:
				return;
			case 1:
				obj = IEnumerator_System_IDisposable._initialized;
				obj2 = 3;
				if (IEnumerable_System_IDisposable._initialized == 0)
				{
					obj2 = 6;
				}
				break;
			default:
				IEnumerable_System_IDisposable.CombineAttribute = P_0;
				obj2 = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FFFD()
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
	internal unsafe void _FFFD(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_00f6: Expected I4, but got Obj
		//IL_008d: Expected I, but got Obj
		//IL_00a2: Expected I, but got Obj
		//IL_00ab: Expected Obj, but got I4
		//IL_00bb: Expected I4, but got Obj
		//IL_00bb: Expected I, but got Obj
		//IL_00eb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0100->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0097->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00b0->IL0022: Incompatible stack heights: 2 vs 0
		//IL_00cf->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00da->IL0026: Incompatible stack heights: 2 vs 1
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
				case 5:
					return;
				case 2:
					ExceptionHelpers.GetHRForException((Exception)/*Error near IL_0052: Stack underflow*/);
					_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
					/*Error near IL_0059: Member reference must be method, but was: Field*/;
				case 3:
					IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
					_ = 4;
					continue;
				case 4:
					break;
				case 6:
					IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)this, (uint)(int)IReadOnlyList_System_IDisposable.ReflectConnectedAttribute);
					_ = 0;
					if (IEnumerator_System_IDisposable._initialized == 0)
					{
						_ = 0;
					}
					continue;
				default:
					IEnumerator_System_IDisposable.ReflectTransferableAttribute = P_0;
					obj2 = 3;
					continue;
				case 1:
					IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_00f6: Stack underflow*/, (uint)(int)this, ref *(INotifyPropertyChanged[]*)IEnumerable_System_IDisposable._initialized);
					_ = 6;
					continue;
				}
				break;
			}
			IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute);
			obj = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _E000(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778034, new IntPtr(2737335742396L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _E100()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17531, 1790778035, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778035, new IntPtr(2737335742396L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _E200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778032, new IntPtr(2737335751756L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<DesktopGameModel> _E300()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<DesktopGameModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<DesktopGameModel> _E400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778033, new IntPtr(2737335745516L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<DesktopGameModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _E500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778046, new IntPtr(2737335751756L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _E600()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0059: Expected Obj, but got I
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0069->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0074->IL0074: Incompatible stack heights: 0 vs 1
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
			{
				int hRForException = ExceptionHelpers.GetHRForException((Exception)/*Error near IL_003d: Stack underflow*/);
				if (hRForException == 0)
				{
					obj2 = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						obj2 = 0;
					}
					continue;
				}
				*(ValueTuple<int, nint>*)(nint)/*Error near IL_0074: Stack underflow*/ = ((int)/*Error near IL_0074: Stack underflow*/, hRForException);
				break;
			}
			default:
				break;
			}
			break;
		}
		return (1 == 0) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _E700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778047, new IntPtr(2737335745516L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _EA00(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0063: Expected I4, but got Obj
		//IL_00cd: Expected I, but got Obj
		//IL_00d7: Expected Obj, but got I4
		//IL_01d8: Expected I, but got Obj
		//IL_0189: Expected I, but got Obj
		//IL_018e: Expected Obj, but got I4
		//IL_008d: Expected I4, but got Obj
		//IL_0092: Expected Obj, but got VT
		//IL_00ad: Expected Obj, but got I
		//IL_013a: Expected I, but got Obj
		//IL_0240: Expected I, but got Obj
		//IL_0240: Expected I, but got Obj
		//IL_0259: Expected I, but got Obj
		//IL_0269: Expected I, but got Obj
		//IL_028b: Expected Obj, but got I4
		//IL_027d: Expected I4, but got Obj
		//IL_0115->IL0239: Incompatible stack heights: 1 vs 0
		//IL_0239->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0077->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00e1->IL0026: Incompatible stack heights: 2 vs 1
		//IL_01fe->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b2->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0222->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0153->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0129->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0209->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0178->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ad->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00bd->IL0026: Incompatible stack heights: 3 vs 1
		//IL_015e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0134->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0183->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0290->IL0022: Incompatible stack heights: 1 vs 0
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 9;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 2:
					_003CModule_003E.CheckAccessibleAttribute();
					_ = 6;
					continue;
				case 8:
					_ = IEnumerator_object.Initialized;
					IEnumerator_object.Init();
					obj = CastExtensions.As<ImplicitAnimationSet>((object)CastExtensions.As<NotificationPanel>((object)CastExtensions.As<MainContent>((object)((int)this, (nint)(delegate* unmanaged[Stdcall]<nint, byte*, uint>)(&IEnumerator_object.Do_Abi_MoveNext_2)))));
					_ = 1;
					if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
					{
						_ = 1;
					}
					continue;
				case 3:
				case 11:
					((XamlUserType)/*Error near IL_00d7: Stack underflow*/).BoxType<EasingType>((object)IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00d2: Stack underflow*/, (INotifyPropertyChanged)/*Error near IL_00d2: Stack underflow*/, ref *(uint*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)(IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Initialized ? 1 : 0), (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init(), (nint*)(nint)this)));
					_ = 5;
					continue;
				default:
					if (IEnumerableMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.MoveAttribute() ? 1 : 0)))
					{
						_ = 7;
						if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute == null)
						{
							_ = 11;
						}
						continue;
					}
					break;
				case 10:
					IListMethods<object>.Abi_GetAt_0((IntPtr)/*Error near IL_013f: Stack underflow*/, IEnumerable_System_ComponentModel_INotifyPropertyChanged.Do_Abi_First_0((nint)/*Error near IL_013a: Stack underflow*/, (nint*)(nint)this));
					_ = 6;
					if (Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute == null)
					{
						_ = 7;
					}
					continue;
				case 5:
					if (P_0 == 0)
					{
						obj2 = 13;
						if (Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute == null)
						{
							obj2 = 6;
						}
						continue;
					}
					goto case 2;
				case 7:
					IListMethods<object>.Abi_InsertAt_5((IntPtr)/*Error near IL_018e: Stack underflow*/, (uint)/*Error near IL_018e: Stack underflow*/, (object)IList_object.Do_Abi_GetAt_0((nint)/*Error near IL_0189: Stack underflow*/, (uint)/*Error near IL_0189: Stack underflow*/, (nint*)(nint)this));
					obj2 = 0;
					if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute != null)
					{
						obj2 = 0;
					}
					continue;
				case 6:
					return;
				case 13:
					return;
				case 4:
				{
					uint num = IList_object.Do_Abi_Append_7((nint)/*Error near IL_01d8: Stack underflow*/, (nint)this);
					((AsyncTaskMethodBuilder*)obj)->Start(ref *(AccountViewModel._003CLoginBedrock_003Ed__86*)4);
					((AsyncTaskMethodBuilder*)/*Error near IL_01e5: Stack underflow*/)->Start(ref *(AccountViewModel._003CLoginDesktop_003Ed__87*)num);
					((AsyncTaskMethodBuilder*)/*Error near IL_01ea: Stack underflow*/)->Start(ref *(AccountViewModel._003CLoginMobile_003Ed__88*)/*Error near IL_01ea: Stack underflow*/);
					obj2 = 4;
					if (__KnownINotifyPropertyChangingArgs.UserId == null)
					{
						obj2 = 10;
					}
					continue;
				}
				case 9:
					IList_object._002Ecctor();
					IReadOnlyListMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0218: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_0218: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_0218: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(IList_object.AttachAttribute() ? 1 : 0));
					_ = 8;
					continue;
				case 1:
					((AsyncTaskMethodBuilder*)this)->AwaitUnsafeOnCompleted(ref *(IEnumerator_System_ComponentModel_INotifyPropertyChanged.Initialized ? ((TaskAwaiter*)1) : ((TaskAwaiter*)null)), ref *(AccountViewModel._003CImportAccounts_003Ed__28*)obj);
					obj2 = 4;
					continue;
				case 12:
					break;
				}
				break;
			}
			int num3;
			if (!IReadOnlyListMethods<IDisposable>.Abi_IndexOf_2((IntPtr)/*Error near IL_0245: Stack underflow*/, (IDisposable)/*Error near IL_0245: Stack underflow*/, ref *(uint*)IEnumerator_System_ComponentModel_INotifyPropertyChanged.Do_Abi_MoveNext_2((nint)this, (byte*)(nint)this)))
			{
				uint num2 = IEnumerator_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_0259: Stack underflow*/, (byte*)(nint)__KnownINotifyPropertyChangingArgs.Content);
				IEnumerator_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
				num3 = (IReadOnlyListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0269: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)(int)num2, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(IEnumerator_System_ComponentModel_INotifyPropertyChanged.DecorateDynamicAttribute() ? 1 : 0)) ? 1 : 0);
			}
			else
			{
				num3 = (int)IReadOnlyList_System_IDisposable.Do_Abi_GetAt_0((nint)/*Error near IL_027d: Stack underflow*/, (uint)(int)__KnownINotifyPropertyChangingArgs.OnlinePlayers, (nint*)(int)IReadOnlyList_System_IDisposable.Init());
			}
			IReadOnlyList_System_IDisposable.Do_Abi_IndexOf_2((nint)/*Error near IL_0282: Stack underflow*/, (nint)/*Error near IL_0282: Stack underflow*/, (uint*)/*Error near IL_0282: Stack underflow*/, (byte*)num3);
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _EB00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778044, new IntPtr(2737335743436L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _EC00()
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
	internal unsafe object _ED00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778045, new IntPtr(2737335744476L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _EE00(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_0066: Expected I, but got Obj
		//IL_0066: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I
		//IL_004b: Expected I, but got Obj
		//IL_007a: Expected Obj, but got I
		//IL_00ca->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00a9->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0055->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b4->IL0026: Incompatible stack heights: 2 vs 1
		//IL_008a->IL0026: Incompatible stack types: I4 vs Obj
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
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 3;
				break;
			case 2:
				((Action<object[], nint>)IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)/*Error near IL_005a: Stack underflow*/, ref *(object[]*)/*Error near IL_005a: Stack underflow*/))((object[])IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized, (nint)P_0);
				if ((int)/*Error near IL_006b: Stack underflow*/ != 0)
				{
					return;
				}
				obj2 = 0;
				if (IList_object.PatchAttribute == null)
				{
					obj2 = 1;
				}
				break;
			case 3:
				MarshalInspectable<object>.FromManaged((object)this, (byte)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0);
				_ = 0;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 1:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _EF00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778042, new IntPtr(2737335753836L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _F000(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778043, new IntPtr(2737335751756L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _F100(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 1:
			ExceptionHelpers.GetHRForException((Exception)P_1);
			_ = IEnumerator_object.Initialized;
			/*Error near IL_0047: Member reference must be method, but was: Field*/;
		case 0:
			break;
		case 2:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _F200(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778040, new IntPtr(2737335743436L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _F300()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17549, 1790778041, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778041, new IntPtr(2737335752796L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _F400(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_00cb: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got I
		//IL_00a5: Expected I, but got Obj
		//IL_005b: Expected I, but got Obj
		//IL_006a: Expected Obj, but got I
		//IL_00f6: Expected I4, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0120: Expected I, but got Obj
		//IL_00df->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b9->IL0026: Incompatible stack heights: 3 vs 1
		//IL_006f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_010a->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0134->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0090->IL0050: Incompatible stack heights: 1 vs 0
		//IL_00ea->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c4->IL0026: Incompatible stack heights: 3 vs 1
		//IL_007a->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0115->IL0026: Incompatible stack heights: 2 vs 1
		//IL_013f->IL0026: Incompatible stack heights: 3 vs 1
		//IL_009a->IL0026: Incompatible stack heights: 2 vs 1
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
			case 3:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 3;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					_ = 4;
				}
				break;
			case 7:
				*((int, nint)*)(nint)/*Error near IL_007f: Stack underflow*/ = ((int)/*Error near IL_007f: Stack underflow*/, (nint)/*Error near IL_007f: Stack underflow*/);
				_ = IList_object.PatchAttribute;
				if (IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)(int)P_0) != null)
				{
					_ = 6;
					break;
				}
				goto case 3;
			case 1:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute);
				_ = 2;
				if (IReadOnlyList_object._initialized != 0)
				{
					_ = 1;
				}
				break;
			default:
				IReadOnlyList_object.ReflectLogicalAttribute = P_0;
				obj2 = 0;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
				{
					obj2 = 5;
				}
				break;
			case 2:
				return;
			case 6:
				return;
			case 4:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_00f6: Stack underflow*/, (uint)(int)this, ref *(INotifyPropertyChanged[]*)IEnumerable_System_IDisposable._initialized);
				_ = 0;
				if (IEnumerable_object.ReflectSetAttribute == null)
				{
					_ = 0;
				}
				break;
			case 5:
				IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)GlobalVtableLookup.CreateAttribute);
				_ = 0;
				if (Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute == null)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _F500(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777990, new IntPtr(2737335749676L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<DesktopSkinModel> _F600()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<DesktopSkinModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<DesktopSkinModel> _F700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777991, new IntPtr(2737335756956L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<DesktopSkinModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<DesktopGameModel> _F800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777988, new IntPtr(2737335743436L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<DesktopGameModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<DesktopGameModel> 豈()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<DesktopGameModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<DesktopGameModel> 切()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777989, new IntPtr(2737335743436L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<DesktopGameModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe byte ﬀ()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected I4, but got Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)_003CModule_003E.CheckAccessibleAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void ﰀ()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0068: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_007c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0057->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0062->IL0026: Incompatible stack heights: 3 vs 1
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
				return;
			case 1:
				_003CModule_003E.CheckAccessibleAttribute();
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					_ = 0;
				}
				break;
			default:
				/*Error near IL_0068: Stack underflow*/((object[])/*Error near IL_0068: Stack underflow*/, (nint)this);
				obj2 = 0;
				if (IList_object.PatchAttribute != null)
				{
					obj2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void ﴀ()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0048: Expected I, but got Obj
		//IL_0057: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_007f: Expected I4, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_005c->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0093->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0067->IL0026: Incompatible stack heights: 3 vs 1
		//IL_009e->IL0026: Incompatible stack heights: 3 vs 1
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
				MarshalInspectable<object>.FromManaged((object)this, (byte)(int)new IEnumeratorMethods<object>((IntPtr)(nint)(delegate* unmanaged[Stdcall]<nint, nint*, uint>)(&IEnumerator_object.Do_Abi_get_Current_0)) != 0);
				_ = 1;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FE00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777986, new IntPtr(2737335746556L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17561, 1790777987, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777987, new IntPtr(2737335753836L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00Ā()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777984, new IntPtr(2737335743436L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00Ȁ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17563, 1790777985, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777985, new IntPtr(2737335761116L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_0300()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17564, 1790777998, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777998, new IntPtr(2737335743436L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00Ѐ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777999, new IntPtr(2737335754876L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00Ԁ(uint P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777996, new IntPtr(2737335744476L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_0600(uint P_0, uint P_1)
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
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_0700()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17568, 1790777997, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777997, new IntPtr(2737335744476L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00ࠀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777994, new IntPtr(2737335757996L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_0900()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777995, new IntPtr(2737335748636L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_0A00()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_0B00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777992, new IntPtr(2737335754876L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_0C00(ObservableCollection<DesktopGameModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0053: Expected I4, but got Obj
		//IL_0063: Expected I, but got Obj
		//IL_0100: Expected Obj, but got I
		//IL_00c7: Expected I, but got Obj
		//IL_0121: Expected I, but got Obj
		//IL_00dc: Expected Obj, but got I
		//IL_0155: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I
		//IL_0165: Expected I, but got Obj
		//IL_006d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0105->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00d1->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0126->IL00d1: Incompatible stack heights: 1 vs 0
		//IL_00e6->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00b1->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0179->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0110->IL0026: Incompatible stack heights: 2 vs 1
		//IL_013a->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00bc->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0184->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0145->IL0026: Incompatible stack heights: 2 vs 1
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
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
					_ = 3;
					continue;
				case 4:
					return;
				case 3:
					return;
				case 8:
					MarshalInspectable<object>.FromAbiArray((object)IList_object._initialized);
					_ = 7;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
					{
						_ = 4;
					}
					continue;
				case 2:
					IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00c7: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00c7: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)IReadOnlyList_System_IDisposable._initialized);
					_ = 8;
					continue;
				case 6:
					MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
					_ = 2;
					continue;
				case 1:
					IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00f1: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
					_ = 0;
					if (IEnumerable_System_IDisposable.CombineAttribute == null)
					{
						_ = 0;
					}
					continue;
				case 5:
					MarshalInterface<INotifyPropertyChanged>.CopyManagedArray((INotifyPropertyChanged[])/*Error near IL_0115: Stack underflow*/, (IntPtr)/*Error near IL_0115: Stack underflow*/);
					_ = IEnumerable_object.ReflectSetAttribute;
					if (IEnumerableMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)P_0))
					{
						_ = 4;
						if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute == null)
						{
							_ = 4;
						}
						continue;
					}
					goto case 6;
				case 7:
					break;
				case 9:
					IListMethods<object>.Abi_GetView_2((IntPtr)Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute);
					_ = 1;
					if (Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute == null)
					{
						_ = 1;
					}
					continue;
				}
				break;
			}
			Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute = P_0;
			obj = 9;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_0D00(ObservableCollection<DesktopGameModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777993, new IntPtr(2737335745516L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_0E00()
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
	internal unsafe object _FF00ༀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778006, new IntPtr(2737335745516L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00က()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17577, 1790778007, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778007, new IntPtr(2737335748636L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00ᄀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778004, new IntPtr(2737335745516L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00ሀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778005, new IntPtr(2737335745516L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00ጀ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17580, 1790778002, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778002, new IntPtr(2737335760076L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_1400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778003, new IntPtr(2737335745516L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ᔀ(ObservableCollection<DesktopGameModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778000, new IntPtr(2737335745516L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ᘀ(ObservableCollection<DesktopGameModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0053: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I
		//IL_0083: Expected I, but got Obj
		//IL_0067->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ad->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0088->IL0048: Incompatible stack heights: 1 vs 0
		//IL_00f1->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0072->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00b8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0026: Incompatible stack heights: 2 vs 1
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
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					_ = 1;
				}
				break;
			case 3:
				*((int, nint)*)(nint)/*Error near IL_0077: Stack underflow*/ = ((int)/*Error near IL_0077: Stack underflow*/, (nint)/*Error near IL_0077: Stack underflow*/);
				_ = IList_object.PatchAttribute;
				if (IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)P_0) != null)
				{
					_ = 2;
					break;
				}
				goto default;
			case 1:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute = P_0;
				obj2 = 4;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
				{
					obj2 = 0;
				}
				break;
			case 2:
				return;
			case 4:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00e7: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
				_ = 5;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ᜀ(ObservableCollection<DesktopGameModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778001, new IntPtr(2737335745516L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_1800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778014, new IntPtr(2737335745516L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00ᤀ()
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
	internal unsafe object _FF00ᨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778015, new IntPtr(2737335746556L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_1B00(byte P_0, byte P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0048: Expected I, but got Obj
		//IL_0057: Expected Obj, but got I
		//IL_0071: Expected I, but got Obj
		//IL_005c->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0085->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0067->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0090->IL0026: Incompatible stack heights: 2 vs 1
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
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)_003CModule_003E.CheckAccessibleAttribute(), ref *(object[]*)null);
				_ = 2;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 1;
				}
				break;
			case 1:
				IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_0071: Stack underflow*/, (uint)/*Error near IL_0071: Stack underflow*/, (nint)this, (uint*)((P_1 == 0) ? 1 : 0));
				_ = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00ᰀ(byte P_0, byte P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778012, new IntPtr(2737335756956L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00ᴀ(ObservableCollection<ConfigValue> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778013, new IntPtr(2737335745516L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00Ḁ(ObservableCollection<ConfigValue> P_0)
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
	private unsafe object _FF00ἀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778010, new IntPtr(2737335745516L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_2000()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17593, 1790778011, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778011, new IntPtr(2737335745516L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_2100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778008, new IntPtr(2737335756956L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_2200(ObservableCollection<DesktopGameModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778009, new IntPtr(2737335754876L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_2300(ObservableCollection<DesktopGameModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_009d: Expected I, but got Obj
		//IL_00f6: Expected Obj, but got I
		//IL_0073: Expected I, but got Obj
		//IL_00b1->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00fb->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00d2->IL0092: Incompatible stack heights: 2 vs 0
		//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00bc->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0106->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00dc->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0092->IL0026: Incompatible stack types: I4 vs Obj
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
			case 5:
				IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 1;
				if (IList_object._initialized == 0)
				{
					obj2 = 1;
				}
				break;
			default:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
				_ = 5;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					_ = 4;
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
			case 1:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00e7: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
				_ = 2;
				if (IEnumerable_System_IDisposable.CombineAttribute != null)
				{
					_ = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_2400(ObservableCollection<DesktopGameModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778086, new IntPtr(2737335757996L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_2500(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778087, new IntPtr(2737335756956L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_2600(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17599, 1790778084, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778084, new IntPtr(2737335754876L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_2700(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778085, new IntPtr(2737335746556L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_2800(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0079: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_00a9: Expected I4, but got Obj
		//IL_00a9: Expected I, but got Obj
		//IL_004f: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_00de->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008d->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00ae->IL00de: Incompatible stack heights: 1 vs 0
		//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0098->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00c2->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00cd->IL0026: Incompatible stack heights: 2 vs 1
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
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 1;
				}
				break;
			case 2:
				MarshalInspectable<object>.FromAbiArray((object)IList_object._initialized);
				_ = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
				{
					_ = 0;
				}
				break;
			case 3:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)/*Error near IL_009d: Stack underflow*/);
				if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)IReadOnlyList_System_IDisposable.ReflectConnectedAttribute, (uint)(int)P_0) == null)
				{
					_ = 0;
					if (IEnumerator_System_IDisposable._initialized == 0)
					{
						_ = 2;
					}
					break;
				}
				return;
			default:
				IEnumerator_System_IDisposable.ReflectTransferableAttribute = P_0;
				obj2 = 4;
				break;
			case 1:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_2900(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778082, new IntPtr(2737335755916L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<DesktopGameModel> _FF00_2A00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778083, new IntPtr(2737335759036L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<DesktopGameModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<DesktopGameModel> _FF00_2B00()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17604, 1790778080, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778080, new IntPtr(2737335757996L), 15);
		}
		return (IAsyncRelayCommand<DesktopGameModel>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<DesktopGameModel> _FF00Ⰰ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778081, new IntPtr(2737335746556L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<DesktopGameModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00ⴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778094, new IntPtr(2737335746556L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_2E00()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17607, 1790778095, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778095, new IntPtr(2737335759036L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_2F00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778092, new IntPtr(2737335755916L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_3000()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_3100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778093, new IntPtr(2737335746556L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_3200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778090, new IntPtr(2737335746556L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_3300()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0059: Expected Obj, but got I
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0069->IL0026: Incompatible stack types: I4 vs Obj
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
			{
				int hRForException = ExceptionHelpers.GetHRForException((Exception)/*Error near IL_003d: Stack underflow*/);
				if (hRForException != 0)
				{
					*(ValueTuple<int, nint>*)(nint)/*Error near IL_0070: Stack underflow*/ = ((int)/*Error near IL_0070: Stack underflow*/, hRForException);
					return (byte)/*Error near IL_0071: Stack underflow*/;
				}
				obj2 = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					obj2 = 0;
				}
				break;
			}
			default:
				return 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<DesktopGameModel> _FF00㐀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<DesktopGameModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00㔀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778091, new IntPtr(2737335746556L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00㘀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_005b: Expected I4, but got Obj
		//IL_00be: Expected I, but got Obj
		//IL_0126: Expected I, but got Obj
		//IL_010c: Expected I4, but got Obj
		//IL_0136: Expected I, but got Obj
		//IL_008d: Expected I, but got Obj
		//IL_0093: Expected I, but got Obj
		//IL_0115: Expected Obj, but got I4
		//IL_01bd->IL0026: Incompatible stack heights: 5 vs 1
		//IL_00d2->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0130->IL0026: Incompatible stack heights: 4 vs 1
		//IL_007c->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0146->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00a7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01c8->IL0026: Incompatible stack heights: 5 vs 1
		//IL_00dd->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0087->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00b2->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 8;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 8:
					obj = _003CModule_003E.CheckAccessibleAttribute();
					_ = 7;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						_ = 7;
					}
					break;
				case 10:
					((ValueTuple<int, nint>*)/*Error near IL_0093: Stack underflow*/)->_002Ector((int)IEnumerator_object.Do_Abi_MoveNext_2((nint)/*Error near IL_008d: Stack underflow*/, (byte*)(nint)this), unchecked((nint)null));
					obj2 = 1;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 2;
					}
					break;
				case 5:
					goto IL_00b2;
				case 1:
					return;
				case 7:
					switch ((int)obj)
					{
					case 0:
					case 1:
					case 2:
						break;
					case 5:
						goto IL_00b2;
					default:
						goto end_IL_0026;
					case 4:
						goto IL_011a;
					case 3:
						goto IL_0130;
					}
					goto case 10;
				case 6:
					goto IL_011a;
				case 9:
					goto IL_0130;
				default:
					{
						_ = IEnumerable_System_ComponentModel_INotifyPropertyChanged.Initialized;
						IEnumerable_System_ComponentModel_INotifyPropertyChanged.Init();
						_ = 1;
						if (Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute != null)
						{
							_ = 0;
						}
						break;
					}
					IL_0130:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_IndexOf_2((nint)/*Error near IL_0136: Stack underflow*/, (nint)/*Error near IL_0136: Stack underflow*/, (uint*)/*Error near IL_0136: Stack underflow*/, (byte*)(nint)this);
					MarshalInterface<INotifyPropertyChanged>.FromAbiArray((object)null);
					_ = 3;
					break;
					IL_011a:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init();
					MarshalInterface<INotifyPropertyChanged>.FromAbi((IntPtr)null);
					_ = 4;
					break;
					IL_00b2:
					IEnumerator_object._002Ecctor();
					IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)null);
					_ = 0;
					if (IReadOnlyList_object._initialized == 0)
					{
						_ = 0;
					}
					break;
				}
				continue;
				end_IL_0026:
				break;
			}
			obj = 11;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00㜀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778088, new IntPtr(2737335750716L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00㠀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17617, 1790778089, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778089, new IntPtr(2737335747596L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00㤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778102, new IntPtr(2737335746556L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00㨀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00㬀(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00ab: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_0050: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_00bf->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0075->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005a->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0096->IL0044: Incompatible stack heights: 1 vs 0
		//IL_00ca->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0080->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a0->IL0026: Incompatible stack heights: 2 vs 1
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
			case 0:
				return;
			case 3:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 2;
				break;
			case 2:
				IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized = (int)P_0;
				obj2 = 1;
				if (IList_object._initialized == 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
				MarshalInspectable<object>.FromAbiArray((object)/*Error near IL_0085: Stack underflow*/);
				if (MarshalInspectable<object>.FromManaged((object)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized, (byte)P_0 != 0) != (IntPtr)0)
				{
					return;
				}
				_ = 3;
				break;
			case 1:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00ab: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00ab: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)IReadOnlyList_System_IDisposable._initialized);
				_ = 0;
				if (IReadOnlyList_object.ReflectLogicalAttribute != null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00㰀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17621, 1790778103, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778103, new IntPtr(2737335750716L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00㴀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778100, new IntPtr(2737335746556L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00㸀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17623, 1790778101, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778101, new IntPtr(2737335755916L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00㼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778098, new IntPtr(2737335746556L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00䀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778099, new IntPtr(2737335762156L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00䄀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00䈀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<DesktopSkinModel> _FF00䌀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778096, new IntPtr(2737335746556L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<DesktopSkinModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<DesktopSkinModel> _FF00䐀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17629, 1790778097, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778097, new IntPtr(2737335756956L), 15);
		}
		return (IAsyncRelayCommand<DesktopSkinModel>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00䔀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0054: Expected Obj, but got I
		//IL_006f->IL006f: Incompatible stack heights: 0 vs 1
		//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
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
			{
				int hRForException = ExceptionHelpers.GetHRForException((Exception)/*Error near IL_003d: Stack underflow*/);
				if (hRForException == 0)
				{
					obj2 = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
					{
						obj2 = 0;
					}
					continue;
				}
				*(ValueTuple<int, nint>*)(nint)/*Error near IL_006f: Stack underflow*/ = ((int)/*Error near IL_006f: Stack underflow*/, hRForException);
				break;
			}
			default:
				break;
			}
			break;
		}
		return (1 == 0) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00䘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778110, new IntPtr(2737335762156L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00䜀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (_003CModule_003E.CheckAccessibleAttribute() == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00䠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778111, new IntPtr(2737335746556L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<DesktopGameModel> _FF00䤀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<DesktopGameModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<DesktopGameModel> _FF00䨀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778108, new IntPtr(2737335749676L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<DesktopGameModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00䬀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17636, 1790778109, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778109, new IntPtr(2737335749676L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00䰀(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0053: Expected I4, but got Obj
		//IL_0147: Expected I, but got Obj
		//IL_00d0: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I4
		//IL_011f->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00f6->IL012a: Incompatible stack heights: 2 vs 0
		//IL_015b->IL0026: Incompatible stack heights: 3 vs 1
		//IL_013c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d5->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006b->IL0026: Incompatible stack heights: 5 vs 1
		//IL_00b6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_012a->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0100->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0166->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00e0->IL0026: Incompatible stack heights: 2 vs 1
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
			case 8:
				_003CModule_003E.CheckAccessibleAttribute();
				_ = 4;
				break;
			case 5:
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0071: Member reference must be method, but was: Field*/;
			case 0:
				return;
			case 2:
				return;
			case 9:
				IList_object.PatchAttribute = P_0;
				obj2 = 8;
				break;
			case 7:
				MarshalInspectable<object>.FromManaged((object)this, (byte)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0);
				_ = 5;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
				{
					_ = 1;
				}
				break;
			case 3:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)/*Error near IL_00e5: Stack underflow*/, (uint)/*Error near IL_00e5: Stack underflow*/);
				_ = IReadOnlyList_object.ReflectLogicalAttribute;
				if (MarshalInterface<INotifyPropertyChanged>.FromAbi((IntPtr)(int)P_0) != null)
				{
					_ = 2;
					break;
				}
				goto case 6;
			case 1:
				MarshalInterface<INotifyPropertyChanged>.FromAbiArray(IEnumerator_System_IDisposable.ReflectTransferableAttribute);
				_ = 0;
				if (IEnumerable_object._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 6:
				obj = IEnumerable_object.ReflectSetAttribute;
				obj2 = 7;
				break;
			case 4:
				IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)GlobalVtableLookup.CreateAttribute);
				_ = 1;
				if (Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute != null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00䴀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778106, new IntPtr(2737335746556L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<DesktopGameModel> _FF00一()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778107, new IntPtr(2737335762156L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<DesktopGameModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<DesktopGameModel> _FF00伀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<DesktopGameModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<DesktopGameModel> _FF00倀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778104, new IntPtr(2737335746556L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<DesktopGameModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00儀(ObservableCollection<DesktopSkinModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0053: Expected I, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_00b8: Expected Obj, but got I
		//IL_005d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00dd->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00bd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c8->IL0026: Incompatible stack types: I4 vs Obj
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
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 4;
				break;
			case 1:
				/*Error near IL_005d: Member reference must be method, but was: Field*/;
			case 0:
				return;
			case 4:
				return;
			case 5:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute = P_0;
				obj2 = 2;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
				{
					obj2 = 0;
				}
				break;
			case 3:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00刀(ObservableCollection<DesktopSkinModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778105, new IntPtr(2737335762156L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00匀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778054, new IntPtr(2737335746556L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00吀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17645, 1790778055, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778055, new IntPtr(2737335751756L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00唀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778052, new IntPtr(2737335746556L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00嘀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0059: Expected Obj, but got I
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0069->IL0026: Incompatible stack types: I4 vs Obj
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
			{
				int hRForException = ExceptionHelpers.GetHRForException((Exception)/*Error near IL_003d: Stack underflow*/);
				if (hRForException != 0)
				{
					*(ValueTuple<int, nint>*)(nint)/*Error near IL_0070: Stack underflow*/ = ((int)/*Error near IL_0070: Stack underflow*/, hRForException);
					return (byte)/*Error near IL_0071: Stack underflow*/;
				}
				obj2 = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					obj2 = 0;
				}
				break;
			}
			default:
				return 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00圀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778053, new IntPtr(2737335762156L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00堀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778050, new IntPtr(2737335762156L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00夀(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_0082: Expected I, but got Obj
		//IL_0096: Expected Obj, but got I
		//IL_0280: Expected I, but got Obj
		//IL_00d8: Expected I, but got Obj
		//IL_025a: Expected I, but got Obj
		//IL_0103: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Ref, but got Unknown
		//IL_0119: Expected I, but got Obj
		//IL_0128: Expected Obj, but got I
		//IL_0359->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0061->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0299->IL0227: Incompatible stack heights: 1 vs 3
		//IL_00f1->IL00bb: Incompatible stack heights: 1 vs 2
		//IL_0238->IL0279: Incompatible stack heights: 2 vs 0
		//IL_0238->IL023d: Incompatible stack heights: 2 vs 0
		//IL_02a4->IL0227: Incompatible stack heights: 1 vs 3
		//IL_00cc->IL00d1: Incompatible stack heights: 1 vs 0
		//IL_00cc->IL00fc: Incompatible stack heights: 1 vs 0
		//IL_00fc->IL00bb: Incompatible stack heights: 1 vs 2
		//IL_023d->IL0279: Incompatible stack heights: 2 vs 0
		//IL_00d1->IL00d1: Incompatible stack heights: 1 vs 0
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
				if (ExceptionHelpers.GetHRForException((Exception)P_1) == 0)
				{
					return;
				}
				obj2 = 6;
				break;
			case 6:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)/*Error near IL_0067: Stack underflow*/, ref *(object[]*)P_1);
				/*Error near IL_0067: Member reference must be method, but was: Field*/;
			case 1:
				/*Error near IL_0082: Stack underflow*/((object[])/*Error near IL_0082: Stack underflow*/, (nint)P_1);
				if ((int)/*Error near IL_0087: Stack underflow*/ != 0)
				{
					obj2 = 0;
					if (IList_object.PatchAttribute == null)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 5;
			case 2:
				return;
			case 4:
				while (true)
				{
					if (IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)obj) == null)
					{
						_ = 1;
						if (IReadOnlyList_System_IDisposable._initialized == 0)
						{
							_ = 1;
						}
						goto IL_00bb;
					}
					goto IL_00fc;
					IL_00fc:
					IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)(Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails)(object)IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0103: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_0103: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_0103: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)obj), (INotifyPropertyChanged)this, ref *(uint*)new MarshalInterface<INotifyPropertyChanged>((IntPtr)(nint)(delegate*<byte>)(&IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init)));
					int num2 = 0;
					if (IEnumerable_System_IDisposable.CombineAttribute != null)
					{
						num2 = 0;
					}
					goto IL_00bb;
					IL_00bb:
					switch (num2)
					{
					case 1:
						break;
					default:
						continue;
					case 2:
						goto IL_00fc;
					}
					break;
				}
				goto case 5;
			case 3:
				while (true)
				{
					if (IListMethods<object>.Abi_get_Size_1((IntPtr)obj) == 0)
					{
						_ = 0;
						if (__KnownINotifyPropertyChangingArgs.Notes == null)
						{
							_ = 1;
						}
						goto IL_0227;
					}
					goto IL_023d;
					IL_023d:
					IListMethods<object>.Abi_InsertAt_5((IntPtr)/*Error near IL_0244: Stack underflow*/, (uint)/*Error near IL_0244: Stack underflow*/, obj);
					_ = (AutoInitialize)/*Error near IL_0245: Stack underflow*/;
					IListMethods<object>.Abi_Clear_9((IntPtr)new IListMethods<object>((IntPtr)(nint)(delegate* unmanaged[Stdcall]<nint, uint, nint, uint>)(&IList_object.Do_Abi_SetAt_4)));
					int num = 0;
					if ((int)_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout != 0)
					{
						num = 0;
					}
					goto IL_0227;
					IL_0227:
					switch (num)
					{
					case 1:
						return;
					case 2:
						break;
					default:
						continue;
					}
					goto IL_023d;
				}
			default:
				MarshalInterface<IDisposable>.CopyManagedArray((IDisposable[])/*Error near IL_034d: Stack underflow*/, (IntPtr)(int)IReadOnlyListMethods<IDisposable>.Abi_GetMany_3((IntPtr)/*Error near IL_0348: Stack underflow*/, (uint)/*Error near IL_0348: Stack underflow*/, ref *(IDisposable[]*)P_1));
				obj = (object)/*Error near IL_034f: Stack underflow*/;
				obj2 = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00娀(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I
		//IL_0098: Expected I, but got Obj
		//IL_00e7->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00bd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a2->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00f2->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00c8->IL0026: Incompatible stack types: I4 vs Obj
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
				/*Error near IL_006c: Member reference must be method, but was: Field*/;
			case 5:
				return;
			case 4:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
				_ = 5;
				break;
			case 1:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute = P_0;
				obj2 = 4;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
				{
					obj2 = 0;
				}
				break;
			default:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 0;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00嬀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778051, new IntPtr(2737335762156L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00尀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17653, 1790778048, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778048, new IntPtr(2737335746556L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00崀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778049, new IntPtr(2737335762156L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00帀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00开()
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
	private void _FF00怀()
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
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1338
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertAsBlock(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 87
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2435
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00愀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778062, new IntPtr(2737335762156L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00戀()
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
	private unsafe object _FF00挀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778063, new IntPtr(2737335762156L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00搀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17661, 1790778060, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778060, new IntPtr(2737335762156L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00攀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778061, new IntPtr(2737335826172L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00昀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778058, new IntPtr(2737335799132L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00最()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17664, 1790778059, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778059, new IntPtr(2737335810572L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00栀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778056, new IntPtr(2737335805372L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00椀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778057, new IntPtr(2737335811612L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00樀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17667, 1790778070, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778070, new IntPtr(2737335797052L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00欀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778071, new IntPtr(2737335805372L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00氀(ObservableCollection<DesktopGameModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778068, new IntPtr(2737335819932L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00洀(ObservableCollection<DesktopGameModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_007f: Expected I, but got Obj
		//IL_004f: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_00b4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d4->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0084->IL00b4: Incompatible stack heights: 1 vs 0
		//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00df->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0098->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a3->IL0026: Incompatible stack heights: 2 vs 1
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
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 3;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 4;
				}
				break;
			case 2:
				*((int, nint)*)(nint)/*Error near IL_0073: Stack underflow*/ = ((int)/*Error near IL_0073: Stack underflow*/, (nint)/*Error near IL_0073: Stack underflow*/);
				_ = IList_object.PatchAttribute;
				if (IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)P_0) == null)
				{
					_ = 1;
					if (IReadOnlyList_System_IDisposable._initialized == 0)
					{
						_ = 0;
					}
					break;
				}
				return;
			default:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
				obj2 = 3;
				break;
			case 4:
				return;
			case 1:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 0;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00渀(ObservableCollection<DesktopGameModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778069, new IntPtr(2737335819932L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00漀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17672, 1790778066, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778066, new IntPtr(2737335808492L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00瀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778067, new IntPtr(2737335805372L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00焀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17674, 1790778064, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778064, new IntPtr(2737335826172L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00爀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00猀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778065, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00琀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778078, new IntPtr(2737335804332L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00甀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17678, 1790778079, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778079, new IntPtr(2737335807452L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00瘀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778076, new IntPtr(2737335800172L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00眀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_005b: Expected I, but got Obj
		//IL_005b: Expected I, but got Obj
		//IL_006a: Expected Obj, but got I
		//IL_0081: Expected I, but got Obj
		//IL_0096: Expected Obj, but got I
		//IL_00b1->IL0045: Incompatible stack heights: 1 vs 0
		//IL_006f->IL0026: Incompatible stack heights: 5 vs 1
		//IL_009b->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00bb->IL0026: Incompatible stack heights: 2 vs 1
		//IL_007a->IL0026: Incompatible stack heights: 5 vs 1
		//IL_00a6->IL0026: Incompatible stack heights: 3 vs 1
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
				return;
			case 4:
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
			case 0:
				return;
			case 2:
				IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_0081: Stack underflow*/, (byte*)(nint)this);
				IEnumerator_object._002Ecctor();
				_ = 1;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
				{
					_ = 1;
				}
				break;
			case 3:
				if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Initialized)
				{
					_ = 2;
					break;
				}
				goto case 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00砀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778077, new IntPtr(2737335798092L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IRelayCommand<AutoSuggestBoxQuerySubmittedEventArgs> _FF00礀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17682, 1790778074, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778074, new IntPtr(2737335817852L), 15);
		}
		return (IRelayCommand<AutoSuggestBoxQuerySubmittedEventArgs>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00稀(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_005f: Expected I4, but got Obj
		//IL_0111: Expected I4, but got Obj
		//IL_0116: Expected Obj, but got I4
		//IL_0126: Expected Obj, but got I
		//IL_00e4: Expected I4, but got Obj
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected I, but got Obj
		//IL_00ca: Expected I, but got Obj
		//IL_00d3: Expected Obj, but got I4
		//IL_008f->IL0026: Incompatible stack heights: 7 vs 1
		//IL_0151->IL0026: Incompatible stack heights: 4 vs 1
		//IL_012b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ee->IL0026: Incompatible stack heights: 3 vs 1
		//IL_01b4->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0104->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00d8->IL0022: Incompatible stack heights: 2 vs 0
		//IL_01e6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009a->IL0026: Incompatible stack heights: 7 vs 1
		//IL_015c->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0136->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f1->IL0026: Incompatible stack types: I4 vs Obj
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
				case 5:
					return;
				case 1:
					obj = _003CModule_003E.CheckAccessibleAttribute();
					_ = IEnumerator_object.Initialized;
					IEnumerator_object.Init();
					_ = 0;
					if (IList_object._initialized == 0)
					{
						_ = 0;
					}
					continue;
				case 10:
					break;
				case 4:
					goto IL_00d8;
				case 9:
					goto IL_00ee;
				case 3:
				case 7:
				case 8:
				case 11:
				case 12:
					((XamlUserType)/*Error near IL_0116: Stack underflow*/).BoxType<DateTime>((object)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_0111: Stack underflow*/, (uint)/*Error near IL_0111: Stack underflow*/, (uint)(int)this, (nint)Unsafe.AsPointer(ref IEnumerator_System_IDisposable.ReflectTransferableAttribute), (uint*)(int)P_0));
					obj2 = 5;
					if (IEnumerable_object.ReflectSetAttribute == null)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					_ = 0;
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.CheckSymbolicAttribute();
					_ = 1;
					if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute != null)
					{
						_ = 1;
					}
					continue;
				case 6:
					goto IL_019e;
				default:
					{
						switch (P_0)
						{
						case 0u:
						case 1u:
						case 2u:
							break;
						case 3u:
							goto IL_00d8;
						case 4u:
							goto IL_00ee;
						case 5u:
							goto IL_019e;
						default:
							goto IL_01d2;
						}
						break;
					}
					IL_01d2:
					obj2 = 11;
					if (Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute == null)
					{
						obj2 = 0;
					}
					continue;
					IL_00ee:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init();
					MarshalInterface<INotifyPropertyChanged>.FromAbi((IntPtr)null);
					_ = 8;
					continue;
					IL_019e:
					IEnumerable_System_ComponentModel_INotifyPropertyChanged.DecorateSeparatedAttribute();
					MarshalInterface<IReadOnlyList<object>>.FromManaged((IReadOnlyList<object>)null);
					_ = 3;
					continue;
					IL_00d8:
					IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)IEnumerator_object.LoadAttribute(), (uint)(int)null);
					_ = 12;
					continue;
				}
				break;
			}
			IEnumerator_object._002Ecctor();
			IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)null);
			obj = 7;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00笀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_0085: Expected I, but got Obj
		//IL_00df->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00bf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0099->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00ca->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a4->IL0026: Incompatible stack heights: 3 vs 1
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
			case 3:
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_004a: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0051: Member reference must be method, but was: Field*/;
			case 2:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
				_ = 1;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					_ = 1;
				}
				break;
			case 1:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
				obj2 = 0;
				if (IReadOnlyList_object.ReflectLogicalAttribute != null)
				{
					obj2 = 0;
				}
				break;
			default:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00d5: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
				_ = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00簀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778075, new IntPtr(2737335803292L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00紀()
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
	internal unsafe object _FF00縀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778072, new IntPtr(2737335805372L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00缀()
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
	internal unsafe object _FF00耀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778073, new IntPtr(2737335819932L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00脀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17690, 1790777894, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777894, new IntPtr(2737335816812L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00舀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777895, new IntPtr(2737335819932L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00茀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777892, new IntPtr(2737335823052L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00萀(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0057->IL0026: Incompatible stack heights: 4 vs 1
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
			default:
				return;
			case 0:
				return;
			case 1:
				_ = P_0 == 0;
				_003CModule_003E.CheckAccessibleAttribute();
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00蔀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777893, new IntPtr(2737335818892L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00蘀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_004f: Expected I, but got Obj
		//IL_00a9: Expected I4, but got Obj
		//IL_00a9: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_0083: Expected I, but got VT
		//IL_0098: Expected Obj, but got I4
		//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0022: Incompatible stack heights: 2 vs 0
		//IL_00b8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0073->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 1:
					if (IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute()) == 0)
					{
						obj2 = 0;
						if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
						{
							obj2 = 0;
						}
						continue;
					}
					return;
				case 3:
					return;
				case 2:
					return;
				case 4:
					return;
				}
				if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)this, (uint)(int)IEnumerator_object.LoadAttribute()) == null)
				{
					break;
				}
				obj2 = 3;
			}
			*((int, nint)*)(nint)/*Error near IL_0079: Stack underflow*/ = ((int)/*Error near IL_0079: Stack underflow*/, (nint)/*Error near IL_0079: Stack underflow*/);
			IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)typeof(IEnumerator_System_IDisposable).TypeHandle);
			_ = 1;
			CastExtensions.As<Segmented>((object)new IEnumerator_object());
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe byte _FF00蜀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected I4, but got Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)_003CModule_003E.CheckAccessibleAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<DesktopSkinModel> _FF00蠀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17697, 1790777890, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777890, new IntPtr(2737335825132L), 15);
		}
		return (IAsyncRelayCommand<DesktopSkinModel>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<DesktopSkinModel> _FF00褀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777891, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<DesktopSkinModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00言()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0054: Expected Obj, but got I
		//IL_006f->IL006f: Incompatible stack heights: 0 vs 1
		//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
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
			{
				int hRForException = ExceptionHelpers.GetHRForException((Exception)/*Error near IL_003d: Stack underflow*/);
				if (hRForException == 0)
				{
					obj2 = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						obj2 = 0;
					}
					continue;
				}
				*(ValueTuple<int, nint>*)(nint)/*Error near IL_006f: Stack underflow*/ = ((int)/*Error near IL_006f: Stack underflow*/, hRForException);
				break;
			}
			default:
				break;
			}
			break;
		}
		return (1 == 0) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00謀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17700, 1790777888, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777888, new IntPtr(2737335811612L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00谀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777889, new IntPtr(2737335812652L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00贀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((nint)_003CModule_003E.CheckAccessibleAttribute() > 0) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00踀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777902, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00輀()
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
	internal unsafe static object _FF00退()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777903, new IntPtr(2737335798092L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00鄀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777900, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00鈀()
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
	internal unsafe object _FF00錀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777901, new IntPtr(2737335815772L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00鐀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17709, 1790777898, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777898, new IntPtr(2737335804332L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00销()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777899, new IntPtr(2737335813692L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00阀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_00a3: Expected I4, but got Obj
		//IL_00a3: Expected Obj, but got I
		//IL_0088: Expected I, but got Obj
		//IL_0088: Expected I4, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_00e7->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0072->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a8->IL007d: Incompatible stack heights: 1 vs 0
		//IL_0092->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f2->IL0026: Incompatible stack heights: 3 vs 1
		//IL_007d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00bc->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c7->IL0026: Incompatible stack heights: 2 vs 1
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
			case 2:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					obj2 = 0;
				}
				break;
			case 5:
				((ValueTuple<int, nint>*)/*Error near IL_0088: Stack underflow*/)->_002Ector((int)this, (nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute);
				obj2 = 2;
				break;
			case 4:
				MarshalInspectable<object>.FromAbiArray((object)/*Error near IL_0097: Stack underflow*/);
				if (MarshalInspectable<object>.FromManaged((object)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized, (byte)(int)P_0 != 0) != (IntPtr)0)
				{
					_ = 3;
					if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
					{
						_ = 3;
					}
					break;
				}
				goto case 5;
			case 1:
				return;
			default:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 1;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00需(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777896, new IntPtr(2737335814732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe byte _FF00頀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_00f8: Expected I, but got Obj
		//IL_009f: Expected I, but got Obj
		//IL_00aa: Expected I, but got Obj
		//IL_010c: Expected I, but got Obj
		//IL_010c: Expected I, but got Obj
		//IL_00af->IL00ec: Incompatible stack heights: 1 vs 0
		//IL_00b9->IL0026: Incompatible stack heights: 2 vs 1
		//IL_012a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0135->IL0026: Incompatible stack types: I4 vs Obj
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
			case 6:
				ExceptionHelpers.GetHRForException((Exception)P_0);
				_ = IEnumerator_object.Initialized;
				/*Error near IL_0058: Member reference must be method, but was: Field*/;
			case 2:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)MarshalInspectable<object>.FromAbiArray(P_0));
				IEnumerator_object._002Ecctor();
				if (IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)this))
				{
					_ = 3;
					break;
				}
				goto default;
			default:
				return IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00fd: Stack underflow*/, (INotifyPropertyChanged)/*Error near IL_00fd: Stack underflow*/, ref *(uint*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_00f8: Stack underflow*/, (uint)(nint)MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)P_0), (nint*)(nint)this)) ? ((byte)1) : ((byte)0);
			case 1:
			case 3:
			case 5:
				return 1;
			case 4:
				MarshalInterface<INotifyPropertyChanged>.CopyManagedArray((INotifyPropertyChanged[])/*Error near IL_0111: Stack underflow*/, (IntPtr)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)MarshalInterface<INotifyPropertyChanged>.FromAbiArray(P_0), (uint*)(nint)this));
				if ((int)/*Error near IL_0116: Stack underflow*/ != 0)
				{
					obj2 = 1;
					if (GlobalVtableLookup.CreateAttribute == null)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00餀(ObservableCollection<DesktopGameModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0098: Expected I4, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I
		//IL_004f: Expected I, but got Obj
		//IL_0058: Expected Obj, but got I4
		//IL_00ac: Expected Obj, but got I
		//IL_009d->IL00cb: Incompatible stack heights: 1 vs 0
		//IL_00e0->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00b1->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00bc->IL0026: Incompatible stack heights: 2 vs 1
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
				case 4:
					goto end_IL_0026;
				case 5:
					_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
					/*Error near IL_0063: Member reference must be method, but was: Field*/;
				case 2:
					MarshalInspectable<object>.FromAbiArray((object)/*Error near IL_008c: Stack underflow*/);
					if (MarshalInspectable<object>.FromManaged((object)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized, (byte)(int)P_0 != 0) != (IntPtr)0)
					{
						_ = 1;
						if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
						{
							_ = 1;
						}
						continue;
					}
					break;
				case 1:
					return;
				case 3:
					break;
				case 0:
					return;
				}
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 4;
				continue;
				end_IL_0026:
				break;
			}
			IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
			obj = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00騀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17715, 1790777897, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777897, new IntPtr(2737335805372L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00鬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777910, new IntPtr(2737335823052L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00鰀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17717, 1790777911, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777911, new IntPtr(2737335827212L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00鴀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777908, new IntPtr(2737335800172L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe ObservableCollection<ConfigValue> _FF00鸀()
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
	private unsafe ObservableCollection<ConfigValue> _FF00鼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777909, new IntPtr(2737335822012L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<ConfigValue>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ꄀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777906, new IntPtr(2737335798092L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ꈀ(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_0061->IL0026: Incompatible stack heights: 6 vs 1
		//IL_0090->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006c->IL0026: Incompatible stack heights: 6 vs 1
		//IL_009b->IL0026: Incompatible stack heights: 2 vs 1
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
			case 1:
				MarshalInspectable<object>.FromManaged((object)/*Error near IL_007c: Stack underflow*/, (byte)IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_0077: Stack underflow*/, (byte*)(int)IEnumerator_object.Do_Abi_get_Current_0((nint)/*Error near IL_0072: Stack underflow*/, (nint*)/*Error near IL_0072: Stack underflow*/)) != 0);
				_ = 0;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
				{
					_ = 0;
				}
				continue;
			}
			_003CModule_003E.CheckAccessibleAttribute();
			_ = IEnumerator_object.Initialized;
			IEnumerator_object.Init();
			_ = 2;
			if (IList_object._initialized == 0)
			{
				_ = 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ꌀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777907, new IntPtr(2737335813692L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ꐀ(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_008f: Expected I, but got Obj
		//IL_0053: Expected I, but got Obj
		//IL_0064: Expected I, but got Obj
		//IL_00e3: Expected Obj, but got I
		//IL_00a3->IL0026: Incompatible stack heights: 3 vs 1
		//IL_005d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0078->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0083->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f2->IL0026: Incompatible stack types: I4 vs Obj
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
			case 2:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 3;
				break;
			case 3:
				IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 1;
				if (IList_object._initialized == 0)
				{
					obj2 = 1;
				}
				break;
			case 0:
				return;
			case 4:
				return;
			case 1:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
				_ = 0;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 5:
				if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2(MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)/*Error near IL_00d7: Stack underflow*/), (INotifyPropertyChanged)IEnumerator_System_IDisposable._initialized, ref *(uint*)P_0))
				{
					obj2 = 4;
					break;
				}
				goto case 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ꔀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777904, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00ꘀ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17727, 1790777905, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777905, new IntPtr(2737335822012L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_A700(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_004f: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_0080: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_00b5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0085->IL006e: Incompatible stack heights: 1 vs 0
		//IL_00ca->IL0026: Incompatible stack heights: 3 vs 1
		//IL_006e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0099->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a4->IL0026: Incompatible stack heights: 2 vs 1
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
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					_ = 0;
				}
				break;
			case 4:
				return;
			case 2:
				*((int, nint)*)(nint)/*Error near IL_0074: Stack underflow*/ = ((int)/*Error near IL_0074: Stack underflow*/, (nint)/*Error near IL_0074: Stack underflow*/);
				_ = IList_object.PatchAttribute;
				if (IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)P_0) != null)
				{
					return;
				}
				_ = 1;
				if (IReadOnlyList_System_IDisposable._initialized != 0)
				{
					_ = 1;
				}
				break;
			default:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
				obj2 = 3;
				break;
			case 3:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ꠀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777918, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe byte _FF00꤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777919, new IntPtr(2737335806412L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe byte _FF00ꨀ()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected I4, but got Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)_003CModule_003E.CheckAccessibleAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe byte _FF00_AB00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777916, new IntPtr(2737335823052L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00가(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00c8: Expected I, but got Obj
		//IL_007e: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		//IL_0053: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I
		//IL_00dc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0067->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00e7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0111->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0072->IL0026: Incompatible stack heights: 2 vs 1
		//IL_011c->IL0026: Incompatible stack types: I4 vs Obj
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
			case 5:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 0;
				}
				break;
			case 1:
				return;
			case 2:
				return;
			case 4:
				MarshalInspectable<object>.FromAbiArray((object)IList_object._initialized);
				_ = 1;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
				{
					_ = 1;
				}
				break;
			default:
				IReadOnlyList_object._initialized = (nint)P_0;
				obj2 = 4;
				if (IEnumerator_System_IDisposable._initialized == 0)
				{
					obj2 = 2;
				}
				break;
			case 3:
				if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)(IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00ec: Stack underflow*/, (INotifyPropertyChanged)/*Error near IL_00ec: Stack underflow*/, ref *(uint*)/*Error near IL_00ec: Stack underflow*/) ? 1 : 0), (uint)IEnumerable_System_IDisposable._initialized, ref *(INotifyPropertyChanged[]*)P_0) != 0)
				{
					obj2 = 1;
					if (IEnumerable_object.ReflectSetAttribute != null)
					{
						obj2 = 2;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00관(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777917, new IntPtr(2737335806412L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
