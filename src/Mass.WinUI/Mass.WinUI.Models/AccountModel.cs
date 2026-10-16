using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using System.Threading;
using System.Threading.Tasks;
using ABI.System.Collections;
using ABI.System.Collections.Generic;
using ABI.System.Collections.Specialized;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Messaging;
using Mass.Application.Desktop;
using Mass.WinUI.Enums;
using Mass.WinUI.Helpers;
using Mass.WinUI.Models.Messages;
using Mass.WinUI.ViewModels;
using Microsoft.UI.Xaml.Controls;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.Models;

[WinRTExposedType(typeof(Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
public class AccountModel : ObservableObject
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLogin_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<DesktopSession> _003C_003Et__builder;

		public AccountModel _003C_003E4__this;

		private TaskAwaiter<DesktopSession> _003C_003Eu__1;

		private static object CountCalc;

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
		internal static bool CheckDetailedWriter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateDividedDic()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00관()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779092, new IntPtr(2737336208412L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00글()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0062: Expected Obj, but got I4
			//IL_0062: Expected Obj, but got Ref
			//IL_0071: Expected Obj, but got I
			//IL_0087: Expected Obj, but got Ref
			//IL_009d: Expected Obj, but got I
			//IL_03c7: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I
			//IL_028c: Expected Obj, but got Ref
			//IL_028e: Expected Obj, but got I4
			//IL_00c4: Expected Obj, but got I
			//IL_0226: Expected Obj, but got I4
			//IL_022b: Expected Obj, but got I4
			//IL_022b: Expected Obj, but got Ref
			//IL_0250: Expected Obj, but got Ref
			//IL_01ac: Expected Obj, but got Ref
			//IL_0191: Expected Obj, but got I4
			//IL_0196: Expected Obj, but got I4
			//IL_0196: Expected Obj, but got Ref
			//IL_019f: Expected Obj, but got I4
			//IL_02c3: Expected I, but got Obj
			//IL_01d1: Expected Obj, but got Ref
			//IL_011d: Expected I4, but got Obj
			//IL_0076->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a2->IL0026: Incompatible stack heights: 3 vs 1
			//IL_03dd->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0081->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ad->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0298->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_00c9->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_03e8->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d4->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_023f->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_014e->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_0262->IL00d8: Incompatible stack heights: 2 vs 1
			//IL_01c0->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_01eb->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_0202->IL016f: Incompatible stack heights: 1 vs 0
			//IL_018c->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_024a->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_0159->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_01cb->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_016f->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_02e3->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_01f6->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_0216->IL00d8: Incompatible stack heights: 2 vs 1
			//IL_02ff->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_0221->IL00d8: Incompatible stack heights: 2 vs 1
			//IL_030a->IL00d8: Incompatible stack types: I4 vs Obj
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
					break;
				default:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = -2;
					obj2 = 1;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						obj2 = 1;
					}
					break;
				case 1:
					_ = ref IList_object._initialized;
					MarshalInspectable<object>.FromAbiArray(obj);
					_ = 3;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
					{
						_ = 2;
					}
					break;
				case 2:
					if (obj != null)
					{
						obj3 = 4;
						if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
						{
							obj3 = 14;
						}
						goto IL_00d8;
					}
					goto IL_0286;
				case 4:
					obj = __KnownINotifyPropertyChangingArgs.Version;
					obj2 = 2;
					if (__KnownINotifyPropertyChangingArgs.Characters == null)
					{
						obj2 = 1;
					}
					break;
				case 3:
					return;
					IL_0286:
					obj = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout;
					obj3 = 12;
					goto IL_00d8;
					IL_00d8:
					while (true)
					{
						switch ((int)obj3)
						{
						case 1:
						case 11:
							break;
						case 2:
						case 6:
							obj = IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)/*Error near IL_0138: Stack underflow*/, (uint)(&obj));
							obj3 = 11;
							if (IEnumerator_System_IDisposable._initialized == 0)
							{
								obj3 = 8;
							}
							continue;
						case 7:
							if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_0160: Stack underflow*/, (INotifyPropertyChanged)/*Error near IL_0160: Stack underflow*/, ref *(uint*)(&obj)))
							{
								obj3 = 6;
								continue;
							}
							goto case 8;
						case 15:
							MarshalInterface<INotifyPropertyChanged>.CopyManagedArray((INotifyPropertyChanged[])/*Error near IL_0180: Stack underflow*/, (IntPtr)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)/*Error near IL_017b: Stack underflow*/, (uint*)IEnumerable_System_IDisposable._initialized));
							obj = (object)/*Error near IL_0182: Stack underflow*/;
							obj3 = 7;
							continue;
						case 8:
							obj = 0;
							IEnumerable_object.ReflectSetAttribute = 0;
							obj = 4;
							obj3 = obj;
							continue;
						case 4:
							GlobalVtableLookup.CreateAttribute = obj;
							obj3 = 0;
							if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute == null)
							{
								obj3 = 3;
							}
							continue;
						case 12:
							Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute = null;
							obj3 = 0;
							if (Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute != null)
							{
								obj3 = 0;
							}
							continue;
						case 14:
							if (IList_object.Initialized)
							{
								_ = 3;
								if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute != null)
								{
									_ = 10;
								}
								continue;
							}
							goto case 15;
						default:
							obj = -1;
							Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute = -1;
							obj3 = 2;
							if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute == null)
							{
								obj3 = 1;
							}
							continue;
						case 3:
							_ = ref _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance;
							((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CLogin_003Ed__39, AccountViewModel._003CRegisterRandom4399_003Ed__84>(ref this));
							_ = 5;
							continue;
						case 5:
							return;
						case 13:
							goto IL_0286;
						case 10:
							goto IL_02bc;
						case 9:
							throw new IReadOnlyListMethods<IDisposable, nint>((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_02e8: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_02e8: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_02e8: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_02e8: Stack underflow*/);
						}
						break;
						IL_02bc:
						Type obj4 = IEnumeratorMethods<INotifyPropertyChanged>.Abi_get_Current_0((IntPtr)(int)IList_object.Do_Abi_get_Size_1((nint)/*Error near IL_02c3: Stack underflow*/, (uint*)(nint)obj)) as Type;
						if ((object)obj4 == null)
						{
							obj3 = 9;
							continue;
						}
						obj = obj4;
						obj3 = 1;
						if (__KnownINotifyPropertyChangingArgs.IsMyself == null)
						{
							obj3 = 1;
						}
					}
					goto default;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00꼀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779093, new IntPtr(2737336204252L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00뀀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00넀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779090, new IntPtr(2737336198012L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00눀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779091, new IntPtr(2737336209452L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00대()
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
		private unsafe sealed void _FF00_FF00_FF00됀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00딀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779088, new IntPtr(2737336198012L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLogout_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AccountModel _003C_003E4__this;

		private object _003C_003E8__1;

		private TaskAwaiter _003C_003Eu__1;

		internal static object CheckGeneralObject;

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
		internal static bool CheckExtendedDecorator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectVisibleArgument()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00ꐀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779089, new IntPtr(2737336198012L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00ꔀ()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_07a3: Expected Obj, but got Ref
			//IL_07a8: Expected Obj, but got Ref
			//IL_0053: Expected I, but got Obj
			//IL_0053: Expected Obj, but got Ref
			//IL_0743: Expected Obj, but got Ref
			//IL_076a: Expected Obj, but got Ref
			//IL_077e: Expected Obj, but got I4
			//IL_077e: Expected Obj, but got Ref
			//IL_0677: Expected Obj, but got Ref
			//IL_00f5: Expected Obj, but got I4
			//IL_0119: Expected Obj, but got I
			//IL_0510: Expected Obj, but got Ref
			//IL_0517: Expected I, but got Obj
			//IL_0517: Expected I, but got Obj
			//IL_0521: Expected Obj, but got I
			//IL_0526: Expected Obj, but got I4
			//IL_04eb: Expected Obj, but got Ref
			//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fb: Expected Obj, but got Unknown
			//IL_04fb: Expected Obj, but got I
			//IL_05e7: Expected Obj, but got Ref
			//IL_02ec: Expected Obj, but got Ref
			//IL_013a: Expected Obj, but got I4
			//IL_00e6: Expected I4, but got Obj
			//IL_02c2: Expected Obj, but got I4
			//IL_02c7: Expected Obj, but got I4
			//IL_02c7: Expected Obj, but got Ref
			//IL_02d6: Expected Obj, but got VT
			//IL_02af: Expected Obj, but got Ref
			//IL_02b8: Expected Obj, but got I4
			//IL_039c: Expected Obj, but got Ref
			//IL_01af: Expected Obj, but got I4
			//IL_01b6: Expected I, but got Obj
			//IL_03e5: Expected Obj, but got Ref
			//IL_03ef: Expected I, but got Obj
			//IL_03fa: Expected I, but got Obj
			//IL_03fa: Expected I4, but got Obj
			//IL_0280: Expected Obj, but got Ref
			//IL_0350: Expected Obj, but got I4
			//IL_0355: Expected Obj, but got I4
			//IL_0355: Expected Obj, but got Ref
			//IL_01ef: Expected Obj, but got Ref
			//IL_0239: Expected Obj, but got Ref
			//IL_0243: Expected I, but got Obj
			//IL_024a: Expected Obj, but got I
			//IL_0214: Expected Obj, but got I4
			//IL_01a0: Expected I4, but got Obj
			//IL_0391: Expected Obj, but got I4
			//IL_07b2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0759->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0776->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0792->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0072->IL0026: Incompatible stack types: I4 vs Obj
			//IL_068b->IL009d: Incompatible stack types: I4 vs Obj
			//IL_008e->IL009d: Incompatible stack types: I4 vs Obj
			//IL_0764->IL0026: Incompatible stack types: I4 vs Obj
			//IL_079d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0696->IL009d: Incompatible stack types: I4 vs Obj
			//IL_0099->IL009d: Incompatible stack types: I4 vs Obj
			//IL_0575->IL050a: Incompatible stack heights: 1 vs 0
			//IL_05c7->IL009d: Incompatible stack heights: 4 vs 1
			//IL_011e->IL009d: Incompatible stack heights: 3 vs 1
			//IL_062a->IL009d: Incompatible stack heights: 2 vs 1
			//IL_053a->IL009d: Incompatible stack types: I4 vs Obj
			//IL_0500->IL05a3: Incompatible stack heights: 2 vs 0
			//IL_057f->IL009d: Incompatible stack heights: 2 vs 1
			//IL_02f8->IL0143: Incompatible stack types: I4 vs Obj
			//IL_05d2->IL009d: Incompatible stack heights: 4 vs 1
			//IL_0129->IL009d: Incompatible stack heights: 3 vs 1
			//IL_0545->IL009d: Incompatible stack types: I4 vs Obj
			//IL_050a->IL009d: Incompatible stack heights: 3 vs 1
			//IL_0605->IL009d: Incompatible stack types: I4 vs Obj
			//IL_0610->IL009d: Incompatible stack types: I4 vs Obj
			//IL_02db->IL0143: Incompatible stack types: I4 vs Obj
			//IL_031c->IL0143: Incompatible stack types: I4 vs Obj
			//IL_026f->IL0143: Incompatible stack heights: 2 vs 1
			//IL_03b6->IL0143: Incompatible stack types: I4 vs Obj
			//IL_0404->IL0143: Incompatible stack heights: 2 vs 1
			//IL_037e->IL0143: Incompatible stack heights: 3 vs 1
			//IL_042d->IL0143: Incompatible stack heights: 3 vs 1
			//IL_029c->IL0143: Incompatible stack heights: 2 vs 1
			//IL_035f->IL0143: Incompatible stack types: I4 vs Obj
			//IL_0254->IL0143: Incompatible stack types: I4 vs Obj
			//IL_0228->IL0143: Incompatible stack heights: 2 vs 1
			//IL_02e6->IL0143: Incompatible stack types: I4 vs Obj
			//IL_0327->IL0143: Incompatible stack types: I4 vs Obj
			//IL_027a->IL0143: Incompatible stack heights: 2 vs 1
			//IL_03c1->IL0143: Incompatible stack types: I4 vs Obj
			//IL_01ca->IL0143: Incompatible stack types: I4 vs Obj
			//IL_03d5->IL0143: Incompatible stack types: I4 vs Obj
			//IL_02a7->IL0143: Incompatible stack heights: 2 vs 1
			//IL_01fe->IL0143: Incompatible stack types: I4 vs Obj
			//IL_0233->IL0143: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				case 1:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = unchecked((nint)null);
					obj2 = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 0;
					}
					break;
				case 2:
					if (obj == null)
					{
						obj3 = 3;
						if (IList_object._initialized == 0)
						{
							obj3 = 6;
						}
						goto IL_009d;
					}
					goto IL_066c;
				case 6:
					return;
				case 3:
					obj = __KnownINotifyPropertyChangingArgs.LikeNetGamesEmptyText;
					obj2 = 2;
					if (__KnownINotifyPropertyChangingArgs.RentalGamesEmptyText != null)
					{
						obj2 = 2;
					}
					break;
				case 4:
					obj = __KnownINotifyPropertyChangingArgs.Skins;
					obj2 = 3;
					break;
				case 5:
					goto IL_0776;
				default:
					{
						((Regex)Unsafe.AsPointer(ref __KnownINotifyPropertyChangingArgs.SkinOwnedSelected))._002Ector();
						obj2 = 6;
						break;
					}
					IL_009d:
					while (true)
					{
						object obj4;
						switch ((int)obj3)
						{
						case 2:
						case 3:
						case 6:
							obj = 4;
							obj3 = obj;
							continue;
						case 8:
							IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_0104: Stack underflow*/, (byte*)(int)IEnumerator_object.Do_Abi_get_Current_0((nint)/*Error near IL_00ff: Stack underflow*/, (nint*)/*Error near IL_00ff: Stack underflow*/));
							_ = null;
							IEnumerator_object._002Ecctor();
							_ = 0;
							if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
							{
								_ = 1;
							}
							continue;
						case 4:
							if (obj != null)
							{
								obj = 18;
								goto IL_013f;
							}
							goto IL_02e6;
						case 14:
						case 16:
							_ = IEnumerableMethods.IID;
							_ = __KnownINotifyPropertyChangingArgs.DisplayName;
							if ((object)IMessengerExtensions.Send<NavigationMessage>((IMessenger)(object)(delegate*<bool>)(&IEnumerable_System_IDisposable.CheckTransformableAttribute), (NavigationMessage)(nint)new INotifyCollectionChangedMethods()) == null)
							{
								_ = 2;
								continue;
							}
							goto case 7;
						case 11:
							__KnownINotifyPropertyChangingArgs.MobileAccounts = (PropertyChangingEventArgs)(object)(((nint)IListMethods<object>.AbiToProjectionVftablePtr) as EncodingProvider);
							obj3 = 10;
							if (__KnownINotifyPropertyChangingArgs.CurrentDisplayPage != null)
							{
								obj3 = 15;
							}
							continue;
						default:
							if (GlobalVtableLookup.DecorateDetailedAttribute() == null)
							{
								_ = 8;
								continue;
							}
							goto case 11;
						case 7:
							Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.DecorateGeneralAttribute();
							Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.NewAttribute();
							((Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails)null).GetExposedInterfaces();
							_ = 2;
							if (__KnownINotifyPropertyChangingArgs.VerifyCodeDelayText == null)
							{
								_ = 13;
							}
							continue;
						case 15:
							if (__KnownINotifyPropertyChangingArgs.InfoBarSeverity != null)
							{
								obj3 = 10;
								if (__KnownINotifyPropertyChangingArgs.IsDragging == null)
								{
									obj3 = 16;
								}
								continue;
							}
							goto case 9;
						case 9:
							((Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails)(object)Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.DecorateAutomatedAttribute()).GetExposedInterfaces();
							((Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails)null)._002Ector();
							_ = 5;
							continue;
						case 10:
							break;
						case 1:
						case 5:
						case 12:
						case 13:
							goto IL_0776;
							IL_02e6:
							obj = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator;
							obj4 = 8;
							goto IL_0143;
							IL_0143:
							while (true)
							{
								switch ((int)obj4)
								{
								default:
									return;
								case 10:
									if (!IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_01bb: Stack underflow*/, (INotifyPropertyChanged)/*Error near IL_01bb: Stack underflow*/, ref *(uint*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_01b6: Stack underflow*/, (uint)(nint)MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Initialized), (nint*)(nint)obj)))
									{
										obj4 = 7;
										continue;
									}
									goto case 12;
								case 0:
									return;
								case 17:
									if (MarshalInterface<INotifyPropertyChanged>.FromAbiArray((object)(&obj)) != null)
									{
										obj4 = 9;
										continue;
									}
									goto case 16;
								case 19:
								{
									uint num2 = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)/*Error near IL_0203: Stack underflow*/, (uint*)/*Error near IL_0203: Stack underflow*/);
									IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
									Interlocked.CompareExchange(ref *(Func<InfoBarDelegate>*)num2, (Func<InfoBarDelegate>)obj, (Func<InfoBarDelegate>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.MoveAttribute());
									_ = 11;
									if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute != null)
									{
										_ = 14;
									}
									continue;
								}
								case 18:
									obj = (nint)MarshalInterface<IReadOnlyList<object>>.FromManaged(IListMethods<object>.Abi_GetView_2((IntPtr)Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute));
									obj4 = 17;
									continue;
								case 6:
								case 9:
									MarshalInspectable<object>.FromAbi((IntPtr)(nint)(&obj));
									_ = 0;
									if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute == null)
									{
										_ = 11;
									}
									continue;
								case 15:
									_ = ref Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute;
									((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CLogout_003Ed__40, AccountViewModel._003CSendVerifyCode_003Ed__78>(ref this));
									_ = 0;
									if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance == null)
									{
										_ = 0;
									}
									continue;
								case 5:
									break;
								case 1:
									obj = -1;
									_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule = -1;
									obj4 = 6;
									if (!_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout)
									{
										obj4 = 0;
									}
									continue;
								case 20:
									goto IL_02e6;
								case 2:
									((AsyncTaskMethodBuilder*)/*Error near IL_0307: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<(bool, string)>*)/*Error near IL_0307: Stack underflow*/, ref *(AccountViewModel._003CEditAccount_003Ed__22*)new IList_object((nint)/*Error near IL_0302: Stack underflow*/, (uint*)(IEnumeratorMethods<INotifyPropertyChanged>.Abi_MoveNext_2((IntPtr)/*Error near IL_02fd: Stack underflow*/) ? 1 : 0)));
									obj4 = 2;
									if (__KnownINotifyPropertyChangingArgs.LoginAt == null)
									{
										obj4 = 4;
									}
									continue;
								case 16:
									obj = 0;
									__KnownINotifyPropertyChangingArgs.Message = (PropertyChangingEventArgs)0;
									obj4 = 5;
									continue;
								case 12:
									((AsyncTaskMethodBuilder*)/*Error near IL_036a: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<ContentDialogResult>*)/*Error near IL_036a: Stack underflow*/, ref *(AccountViewModel._003CLoginByHistory_003Ed__25*)IReadOnlyListMethods<IDisposable>.Abi_GetMany_3((IntPtr)/*Error near IL_0365: Stack underflow*/, (uint)/*Error near IL_0365: Stack underflow*/, ref *(IDisposable[]*)/*Error near IL_0365: Stack underflow*/));
									_ = /*Error near IL_036f: Stack underflow*/is INotifyCollectionChangedMethods;
									IEnumerator_System_ComponentModel_INotifyPropertyChanged.DecorateDynamicAttribute();
									_ = 21;
									continue;
								case 21:
									if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.DecorateConcreteAttribute() == null)
									{
										goto case 2;
									}
									goto IL_0388;
								case 8:
									__KnownINotifyPropertyChangingArgs.OnlinePlayers = null;
									obj4 = 1;
									if (__KnownINotifyPropertyChangingArgs.Description == null)
									{
										obj4 = 1;
									}
									continue;
								case 14:
									if (IReadOnlyList_System_IDisposable.Do_Abi_GetMany_3((nint)/*Error near IL_03c6: Stack underflow*/, (uint)/*Error near IL_03c6: Stack underflow*/, (uint)/*Error near IL_03c6: Stack underflow*/, (nint)/*Error near IL_03c6: Stack underflow*/, (uint*)/*Error near IL_03c6: Stack underflow*/) == 0)
									{
										obj4 = 3;
										continue;
									}
									goto case 10;
								case 11:
								{
									uint num = IReadOnlyList_System_IDisposable.Do_Abi_get_Size_1((nint)/*Error near IL_03da: Stack underflow*/, (uint*)/*Error near IL_03da: Stack underflow*/);
									IReadOnlyList_System_IDisposable._002Ecctor();
									IReadOnlyList_object.Do_Abi_GetAt_0((nint)(int)num, (uint)(int)IEnumerableMethods<IDisposable>.Abi_First_0((IntPtr)(IEnumerableMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)__KnownINotifyPropertyChangingArgs.IsLiked) ? 1 : 0)), (nint*)unchecked((nint)null));
									_ = 19;
									continue;
								}
								case 13:
									((Func<Type, string>)/*Error near IL_0418: Stack underflow*/)._002Ector((object)/*Error near IL_0418: Stack underflow*/, (nint)(int)IReadOnlyList_object.Do_Abi_get_Size_1((nint)/*Error near IL_0413: Stack underflow*/, (uint*)(int)IReadOnlyList_object.Do_Abi_GetMany_3((nint)/*Error near IL_040e: Stack underflow*/, (uint)/*Error near IL_040e: Stack underflow*/, (uint)/*Error near IL_040e: Stack underflow*/, (nint)/*Error near IL_040e: Stack underflow*/, (uint*)(int)IReadOnlyList_object.Do_Abi_IndexOf_2((nint)/*Error near IL_0409: Stack underflow*/, (nint)/*Error near IL_0409: Stack underflow*/, (uint*)/*Error near IL_0409: Stack underflow*/, (byte*)/*Error near IL_0409: Stack underflow*/))));
									ComWrappersSupport.RegisterTypeRuntimeClassNameLookup((Func<Type, string>)/*Error near IL_041d: Stack underflow*/);
									_ = null;
									IReadOnlyList_object.DecorateControllableAttribute();
									_ = 2;
									continue;
								case 3:
								case 4:
								case 7:
									goto IL_0776;
								}
								break;
							}
							_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute = obj;
							obj = 15;
							goto IL_013f;
							IL_0388:
							obj = 13;
							goto IL_013f;
							IL_013f:
							obj4 = obj;
							goto IL_0143;
						}
						break;
					}
					goto IL_066c;
					IL_0776:
					__KnownINotifyPropertyChangingArgs.SkinEmptyText = (PropertyChangingEventArgs)(-2);
					obj2 = 1;
					if (__KnownINotifyPropertyChangingArgs.SkinAllSelected == null)
					{
						obj2 = 0;
					}
					break;
					IL_066c:
					__KnownINotifyPropertyChangingArgs.ParsedAccounts = (PropertyChangingEventArgs)(object)new Mass_WinUI_Pages_MobileWinRTTypeDetails();
					obj3 = 0;
					if (__KnownINotifyPropertyChangingArgs.InputText == null)
					{
						obj3 = 0;
					}
					goto IL_009d;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00ꘀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779102, new IntPtr(2737336211532L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_A700()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00ꠀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779103, new IntPtr(2737336211532L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00꤀()
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
		internal unsafe static object _FF00_FF00_FF00ꨀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779100, new IntPtr(2737336211532L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_AB00(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00가(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779101, new IntPtr(2737336203212L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	internal static AccountModel DecorateAutomatedDic;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string Notes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00挀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00缀(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public string UserId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00紀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00怀(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public string Username
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00堀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00欀(value);
		}
	}

	public string Platform
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00崀();
		}
	}

	public unsafe string Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0029: Expected Obj, but got I
			//IL_0058: Expected I, but got Obj
			//IL_0051: Expected Obj, but got I
			nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 3122, 1790779112, 0, 0);
			object obj = num;
			if (num == 0)
			{
				obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779112, new IntPtr(2737336165772L), 15);
			}
			return (string)((delegate*<object, object>)obj)(this);
		}
	}

	public string LoginType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00樀();
		}
	}

	public bool IsOnline
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00昀() != 0;
		}
	}

	public bool IsCurrent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00最() != 0;
		}
	}

	public string State
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00縀();
		}
	}

	public bool CanLogin
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00脀() != 0;
		}
	}

	public string LoginText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00笀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public string CreateAt
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00蔀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00猀(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public string LoginAt
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00砀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00礀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe AccountModel(NeteaseAccount account)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected I, but got Obj
		//IL_0031: Expected Obj, but got I4
		//IL_0042: Expected I, but got Obj
		//IL_0078: Expected Obj, but got I4
		//IL_0092: Expected I, but got Obj
		//IL_0092: Expected I4, but got Obj
		//IL_0094: Expected Obj, but got I4
		//IL_00b2: Expected I, but got Obj
		//IL_00b4: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I4
		//IL_00d8: Expected Obj, but got I4
		//IL_00df: Expected I, but got Obj
		//IL_00e4: Expected I, but got Obj
		//IL_0099->IL0099: Incompatible stack heights: 0 vs 2
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)account;
		IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute = IEnumerator_object.Init();
		IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = (int)IEnumerator_object.Do_Abi_get_Current_0((nint)this, (nint*)IList_object._initialized);
		object runAttribute = IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute;
		object reflectTransferableAttribute;
		if (!IEnumerator_object.DecorateAutomatableAttribute())
		{
			object reflectConnectedAttribute = IReadOnlyList_System_IDisposable.ReflectConnectedAttribute;
			reflectTransferableAttribute = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Initialized;
		}
		else
		{
			reflectTransferableAttribute = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_0092: Stack underflow*/, (uint)(int)runAttribute, (nint*)(nint)IReadOnlyList_object.ReflectLogicalAttribute);
		}
		IEnumerator_System_IDisposable.ReflectTransferableAttribute = reflectTransferableAttribute;
		reflectTransferableAttribute = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)this, (uint*)IEnumerable_System_IDisposable._initialized);
		IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
		GlobalVtableLookup.CreateAttribute = IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)(nint)(&reflectTransferableAttribute));
		object reflectDividedAttribute = Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute;
		reflectTransferableAttribute = IEnumerable_System_ComponentModel_INotifyPropertyChanged.Init();
		Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute = IListMethods<object>.Abi_GetAt_0((IntPtr)this, IEnumerable_System_ComponentModel_INotifyPropertyChanged.Do_Abi_First_0((nint)reflectDividedAttribute, (nint*)(&reflectTransferableAttribute)));
		MarshalInterface<IReadOnlyList<object>>.FromManaged((IReadOnlyList<object>)this);
		int num = 0;
		if (Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute == null)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object Loc(object key)
	{
		return _FF00_FF00_FF00_FF00栀(key);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLogin_003Ed__39))]
	public Task<DesktopSession> Login()
	{
		return _FF00_FF00_FF00_FF00洀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLogout_003Ed__40))]
	public Task Logout()
	{
		return (Task)_FF00_FF00_FF00_FF00茀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NeteaseAccount GetAccount()
	{
		return (NeteaseAccount)_FF00_FF00_FF00_FF00瀀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnumAccountType GetLoginType()
	{
		return _FF00_FF00_FF00_FF00嬀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Refresh()
	{
		_FF00_FF00_FF00_FF00蘀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnNotesChanged(object value)
	{
		_FF00_FF00_FF00_FF00甀(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecoratePassiveObject()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AccountModel ReflectExternalDecorator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00匀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779113, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00吀()
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
	internal unsafe static object _FF00_FF00_FF00_FF00唀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779126, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00嘀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00圀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779127, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00堀()
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
	internal unsafe object _FF00_FF00_FF00_FF00夀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779124, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumAccountType _FF00_FF00_FF00_FF00娀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779125, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (EnumAccountType)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumAccountType _FF00_FF00_FF00_FF00嬀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0058: Expected Obj, but got I
		//IL_005d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0068->IL0026: Incompatible stack heights: 2 vs 1
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
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
				if ((IEnumerator_object.Initialized ? 1 : 0) != 5)
				{
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						_ = 0;
					}
					break;
				}
				return EnumAccountType.Com4399;
			default:
				return (EnumAccountType)IEnumerator_object.Do_Abi_get_Current_0((nint)/*Error near IL_0073: Stack underflow*/, (nint*)IList_object._initialized);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00尀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779122, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00崀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18419, 1790779123, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779123, new IntPtr(2737336162652L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00帀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779120, new IntPtr(2737336195932L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00开(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779121, new IntPtr(2737336195932L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00怀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_007a: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I
		//IL_004f: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_00aa: Expected I4, but got Obj
		//IL_00aa: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_008e->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00af->IL006e: Incompatible stack heights: 1 vs 0
		//IL_00e9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0099->IL0026: Incompatible stack heights: 3 vs 1
		//IL_006e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c3->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00f4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ce->IL0026: Incompatible stack heights: 2 vs 1
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
				_ = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					_ = 3;
				}
				break;
			case 4:
				return;
			default:
				MarshalInspectable<object>.FromAbiArray((object)IList_object._initialized);
				_ = 2;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
				{
					_ = 4;
				}
				break;
			case 2:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)/*Error near IL_009e: Stack underflow*/);
				if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)IReadOnlyList_System_IDisposable.ReflectConnectedAttribute, (uint)(int)P_0) != null)
				{
					return;
				}
				_ = 0;
				if (IEnumerator_System_IDisposable._initialized == 0)
				{
					_ = 1;
				}
				break;
			case 3:
				IEnumerator_System_IDisposable.ReflectTransferableAttribute = P_0;
				obj2 = 0;
				if (IEnumerable_System_IDisposable.CombineAttribute != null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00愀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_006f: Expected I4, but got Obj
		//IL_021e: Expected I4, but got Obj
		//IL_019f: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got I4
		//IL_0173: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I
		//IL_01d6: Expected I, but got Obj
		//IL_01d7: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I4
		//IL_01c5: Expected Obj, but got I4
		//IL_01b3->IL0026: Incompatible stack heights: 2 vs 1
		//IL_016c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0187->IL0026: Incompatible stack types: I4 vs Obj
		//IL_015b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01cf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0228->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01be->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0192->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00af->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0126->IL0026: Incompatible stack types: I4 vs Obj
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
				case 10:
					break;
				case 11:
				case 15:
					obj = IEnumerator_object.Initialized;
					obj2 = 6;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
					{
						obj2 = 6;
					}
					continue;
				case 13:
					goto IL_0100;
				case 9:
					goto IL_014a;
				case 2:
					goto IL_015b;
				case 3:
					goto IL_016c;
				case 1:
					_ = IEnumerable_object._initialized;
					obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.MoveAttribute();
					_ = 0;
					if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute != null)
					{
						_ = 0;
					}
					continue;
				case 14:
					goto IL_01be;
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 12:
				case 16:
					return IEnumerable_System_ComponentModel_INotifyPropertyChanged.Do_Abi_First_0((nint)/*Error near IL_01d6: Stack underflow*/, (nint*)(nint)obj);
				default:
					{
						switch ((int)obj)
						{
						case 1:
							break;
						case 2:
							goto IL_0100;
						case 0:
							goto IL_014a;
						case 6:
							goto IL_015b;
						case 5:
							goto IL_016c;
						case 3:
						case 4:
							goto IL_01be;
						default:
							goto IL_021e;
						}
						break;
					}
					IL_021e:
					obj2 = 15;
					continue;
					IL_01be:
					obj = IEnumerable_System_ComponentModel_INotifyPropertyChanged.Init();
					obj2 = 8;
					continue;
					IL_0100:
					obj = IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_0105: Stack underflow*/, (byte*)/*Error near IL_0105: Stack underflow*/);
					obj2 = 16;
					if (IReadOnlyList_System_IDisposable._initialized == 0)
					{
						obj2 = 9;
					}
					continue;
					IL_016c:
					obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_IndexOf_2((nint)/*Error near IL_0171: Stack underflow*/, (nint)/*Error near IL_0171: Stack underflow*/, (uint*)/*Error near IL_0171: Stack underflow*/, (byte*)/*Error near IL_0171: Stack underflow*/);
					obj2 = 8;
					if (IEnumerable_System_IDisposable.CombineAttribute != null)
					{
						obj2 = 12;
					}
					continue;
					IL_015b:
					obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_0160: Stack underflow*/, (uint)/*Error near IL_0160: Stack underflow*/, (nint*)/*Error near IL_0160: Stack underflow*/);
					obj2 = 4;
					continue;
					IL_014a:
					obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init();
					obj2 = 7;
					continue;
				}
				break;
			}
			obj = _003CModule_003E.CheckAccessibleAttribute();
			obj = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00戀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779134, new IntPtr(2737336195932L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00挀()
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
	internal unsafe object _FF00_FF00_FF00_FF00搀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779135, new IntPtr(2737336195932L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00攀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779132, new IntPtr(2737336195932L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00昀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
		_ = IEnumerator_object.Initialized;
		/*Error near IL_001f: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00最()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0071: Expected I, but got Obj
		//IL_0077: Expected I4, but got Obj
		//IL_0056->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0061->IL0026: Incompatible stack types: I4 vs Obj
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
				if (_003CModule_003E.CheckAccessibleAttribute() == null)
				{
					return 0;
				}
				obj2 = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				((ValueTuple<int, nint>*)/*Error near IL_006b: Stack underflow*/)->_002Ector((int)/*Error near IL_006b: Stack underflow*/, (nint)(int)IEnumerator_object.Do_Abi_MoveNext_2((nint)/*Error near IL_0066: Stack underflow*/, (byte*)/*Error near IL_0066: Stack underflow*/));
				return (byte)(int)IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)(int)IEnumerator_object.Do_Abi_get_Current_0((nint)/*Error near IL_0071: Stack underflow*/, (nint*)(nint)this));
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00栀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_0020: Expected Obj, but got I4
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
		return IEnumerator_object.Initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00椀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779133, new IntPtr(2737336195932L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00樀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18432, 1790779130, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779130, new IntPtr(2737336195932L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00欀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_007a: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I
		//IL_00d0: Expected Obj, but got I
		//IL_0050: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I
		//IL_00a0: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_008e->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00b4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0099->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00e9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00bf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f4->IL0026: Incompatible stack types: I4 vs Obj
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
			case 3:
				return;
			case 2:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 3;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					_ = 3;
				}
				break;
			default:
				MarshalInspectable<object>.FromAbiArray((object)IList_object._initialized);
				_ = 4;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
				{
					_ = 0;
				}
				break;
			case 4:
				IReadOnlyList_System_IDisposable._initialized = (nint)P_0;
				obj2 = 1;
				if (IReadOnlyList_object._initialized == 0)
				{
					obj2 = 2;
				}
				break;
			case 1:
				if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2(MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)/*Error near IL_00c4: Stack underflow*/), (INotifyPropertyChanged)IEnumerator_System_IDisposable._initialized, ref *(uint*)P_0))
				{
					return;
				}
				obj2 = 0;
				if (IEnumerable_System_IDisposable.CombineAttribute != null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<DesktopSession> _FF00_FF00_FF00_FF00氀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779131, new IntPtr(2737336163692L), 15))(null, 0, new IntPtr(0L));
		return (Task<DesktopSession>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<DesktopSession> _FF00_FF00_FF00_FF00洀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18435, 1790779128, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779128, new IntPtr(2737336163692L), 15);
		}
		return (Task<DesktopSession>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<DesktopSession> _FF00_FF00_FF00_FF00渀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779129, new IntPtr(2737336196972L), 15))(null, 0, new IntPtr(0L));
		return (Task<DesktopSession>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00漀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779078, new IntPtr(2737336208412L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00瀀()
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
	internal unsafe object _FF00_FF00_FF00_FF00焀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779079, new IntPtr(2737336196972L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00爀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779076, new IntPtr(2737336196972L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00猀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0066: Expected I, but got Obj
		//IL_0066: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_00aa: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_004b: Expected I, but got Obj
		//IL_007a: Expected Obj, but got I
		//IL_009f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00be->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0055->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c9->IL0026: Incompatible stack heights: 2 vs 1
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
				obj2 = 1;
				if (IList_object.PatchAttribute != null)
				{
					obj2 = 0;
				}
				break;
			case 1:
				MarshalInspectable<object>.FromManaged((object)this, (byte)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0);
				_ = 4;
				break;
			case 3:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00aa: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00aa: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)IReadOnlyList_System_IDisposable._initialized);
				_ = 0;
				if (IReadOnlyList_object.ReflectLogicalAttribute == null)
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
	private unsafe void _FF00_FF00_FF00_FF00琀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779077, new IntPtr(2737336196972L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00甀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0058: Expected Obj, but got I
		//IL_0081->IL0026: Incompatible stack heights: 2 vs 1
		//IL_005d->IL0026: Incompatible stack heights: 4 vs 1
		//IL_008c->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0068->IL0026: Incompatible stack heights: 4 vs 1
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
			case 2:
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
				_ = IEnumerator_object.Initialized;
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 1;
				}
				break;
			case 1:
				IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_006d: Stack underflow*/, (uint)/*Error near IL_006d: Stack underflow*/, (nint)/*Error near IL_006d: Stack underflow*/, (uint*)/*Error near IL_006d: Stack underflow*/);
				_ = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00瘀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779074, new IntPtr(2737336196972L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00眀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779075, new IntPtr(2737336207372L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00砀()
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
	internal unsafe void _FF00_FF00_FF00_FF00礀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00aa: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I
		//IL_00de->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00be->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0094->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c9->IL0026: Incompatible stack heights: 2 vs 1
		//IL_009f->IL0026: Incompatible stack types: I4 vs Obj
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
				IList_object.PatchAttribute = P_0;
				obj2 = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
				{
					obj2 = 0;
				}
				break;
			case 1:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00aa: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00aa: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)IReadOnlyList_System_IDisposable._initialized);
				_ = 3;
				if (IReadOnlyList_object.ReflectLogicalAttribute != null)
				{
					_ = 0;
				}
				break;
			default:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00d4: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
				_ = 4;
				break;
			case 4:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00稀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779072, new IntPtr(2737336208412L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00笀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18449, 1790779073, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779073, new IntPtr(2737336210492L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00簀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779086, new IntPtr(2737336211532L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00紀()
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
	internal unsafe object _FF00_FF00_FF00_FF00縀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18452, 1790779087, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779087, new IntPtr(2737336207372L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00缀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_0112: Expected I, but got Obj
		//IL_00fd: Expected I, but got Obj
		//IL_00fd: Expected I, but got Obj
		//IL_00d7: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I
		//IL_0077: Expected I, but got Obj
		//IL_00a8: Expected I4, but got Obj
		//IL_00a8: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_011c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0107->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00eb->IL0026: Incompatible stack heights: 3 vs 1
		//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ad->IL0107: Incompatible stack heights: 1 vs 0
		//IL_00f6->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c1->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00cc->IL0026: Incompatible stack heights: 2 vs 1
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
			case 5:
				return;
			case 3:
				IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 0;
				if (IList_object._initialized == 0)
				{
					obj2 = 1;
				}
				continue;
			case 4:
				return;
			case 6:
				MarshalInspectable<object>.FromAbiArray((object)/*Error near IL_009c: Stack underflow*/);
				if (MarshalInspectable<object>.FromManaged((object)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized, (byte)(int)P_0 != 0) != (IntPtr)0)
				{
					_ = 5;
					if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
					{
						_ = 2;
					}
					continue;
				}
				break;
			case 2:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 2;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
				{
					_ = 4;
				}
				continue;
			case 1:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_00fd: Stack underflow*/, (uint)/*Error near IL_00fd: Stack underflow*/, (uint)/*Error near IL_00fd: Stack underflow*/, (nint)this, (uint*)(nint)P_0);
				_ = 2;
				continue;
			}
			MarshalInterface<INotifyPropertyChanged>.CopyManagedArray((INotifyPropertyChanged[])(object)this, (IntPtr)IEnumerable_System_IDisposable.CombineAttribute);
			obj2 = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00耀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779084, new IntPtr(2737336209452L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00脀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (_003CModule_003E.CheckAccessibleAttribute() == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00舀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779085, new IntPtr(2737336196972L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00茀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18457, 1790779082, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779082, new IntPtr(2737336196972L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00萀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779083, new IntPtr(2737336198012L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00蔀()
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
	internal unsafe void _FF00_FF00_FF00_FF00蘀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_004f: Expected I4, but got Obj
		//IL_0089: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I
		//IL_00f6: Expected I, but got Obj
		//IL_010a: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0069: Expected Obj, but got I4
		//IL_00b8: Expected I, but got Obj
		//IL_00cd: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I4
		//IL_0125: Expected I, but got Obj
		//IL_00e1: Expected I, but got Obj
		//IL_00a2->IL0026: Incompatible stack heights: 2 vs 1
		//IL_010f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006e->IL0022: Incompatible stack heights: 1 vs 0
		//IL_00c2->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00db->IL0022: Incompatible stack heights: 2 vs 0
		//IL_0083->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0139->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00f0->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ad->IL0026: Incompatible stack heights: 2 vs 1
		//IL_011a->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0144->IL0026: Incompatible stack heights: 3 vs 1
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
				case 3:
					return;
				case 2:
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute());
					obj = 7;
					break;
				case 6:
					/*Error near IL_0079: Stack underflow*/((object[])(object)this, (int)IEnumerator_object.Init());
					obj2 = 4;
					continue;
				default:
					MarshalInspectable<object>.FromAbiArray((object)IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_0089: Stack underflow*/, (uint)/*Error near IL_0089: Stack underflow*/, (nint)/*Error near IL_0089: Stack underflow*/, (uint*)(nint)this));
					_ = 2;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
					{
						_ = 2;
					}
					continue;
				case 4:
					IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00b8: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00b8: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(IEnumerator_object.DecorateAutomatableAttribute() ? 1 : 0));
					_ = 5;
					continue;
				case 5:
					MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Initialized);
					obj = 8;
					break;
				case 8:
					IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00e6: Stack underflow*/, (INotifyPropertyChanged)/*Error near IL_00e6: Stack underflow*/, ref *(uint*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_00e1: Stack underflow*/, (uint)/*Error near IL_00e1: Stack underflow*/, (nint*)(nint)this));
					_ = 3;
					continue;
				case 1:
					IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_00fb: Stack underflow*/, (uint)/*Error near IL_00fb: Stack underflow*/, ref *(INotifyPropertyChanged[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_00f6: Stack underflow*/, (uint)/*Error near IL_00f6: Stack underflow*/, (uint)/*Error near IL_00f6: Stack underflow*/, (nint)/*Error near IL_00f6: Stack underflow*/, (uint*)(nint)this));
					_ = 0;
					if (IEnumerable_object.ReflectSetAttribute == null)
					{
						_ = 0;
					}
					continue;
				case 7:
					IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.CheckSymbolicAttribute());
					_ = 6;
					if (Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute != null)
					{
						_ = 2;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00蜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779080, new IntPtr(2737336198012L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
