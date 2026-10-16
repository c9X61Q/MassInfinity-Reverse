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
using System.Threading.Tasks;
using ABI.Microsoft.UI.Composition;
using ABI.Microsoft.UI.Xaml.Markup;
using ABI.System.Collections;
using ABI.System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using DevWinUI;
using Mass.Application.Models;
using Mass.Application.Services;
using Mass.Domain.Desktop.Entities.RentalGame;
using Mass.Domain.Desktop.Interfaces;
using Mass.Domain.Entities.Mass;
using Mass.WinUI.Controls;
using Mass.WinUI.Helpers;
using Mass.WinUI.Mass_WinUI_XamlTypeInfo;
using Mass.WinUI.Models;
using Mass.WinUI.Pages;
using Microsoft.UI.Composition;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
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

[WinRTExposedType(typeof(Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
public class LoginWindowViewModel : ObservableObject
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInit_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public LoginWindowViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private nint _003C_003E7__wrap1;

		private TaskAwaiter<EntityMassVersion> _003C_003Eu__2;

		private static object? CheckStatelessArgument;

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
		internal static bool MatchDefinition()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? ReflectFilteredProgram()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00圀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778217, new IntPtr(2737336177212L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00堀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_14cb: Expected Obj, but got Ref
			//IL_14f2: Expected Obj, but got Ref
			//IL_14fe: Expected native int or pointer, but got Obj
			//IL_007f: Expected I4, but got Obj
			//IL_0051: Expected Obj, but got Ref
			//IL_07b7: Expected Obj, but got Ref
			//IL_0b99: Expected Obj, but got Ref
			//IL_01ac: Expected Obj, but got I
			//IL_0088: Expected Obj, but got I4
			//IL_0cd1: Expected Obj, but got Ref
			//IL_0d2b: Expected VT, but got I4
			//IL_0b51: Expected Obj, but got Ref
			//IL_0b51: Unknown result type (might be due to invalid IL or missing references)
			//IL_12ac: Expected Obj, but got I4
			//IL_12ac: Expected Obj, but got Ref
			//IL_1351: Expected Obj, but got Ref
			//IL_1351: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c33: Expected Obj, but got VT
			//IL_0b18: Expected Obj, but got I4
			//IL_0c42: Expected Obj, but got I4
			//IL_0c47: Expected Obj, but got I4
			//IL_0c47: Expected Obj, but got Ref
			//IL_0bbf: Expected Obj, but got I4
			//IL_0bc4: Expected Obj, but got I4
			//IL_0bc4: Expected Obj, but got Ref
			//IL_13cf: Expected Obj, but got I4
			//IL_0cfb: Expected Obj, but got Ref
			//IL_0457: Expected Obj, but got Ref
			//IL_13fa: Expected Obj, but got Ref
			//IL_12bb: Expected Obj, but got I4
			//IL_12c0: Expected Obj, but got I4
			//IL_12c0: Expected Obj, but got Ref
			//IL_1316: Expected Obj, but got Ref
			//IL_0b8e: Expected Obj, but got I4
			//IL_0792: Expected Obj, but got I
			//IL_0be0: Expected Obj, but got I4
			//IL_0c18: Expected Obj, but got I4
			//IL_0c1d: Expected Obj, but got I4
			//IL_0c1d: Expected Obj, but got Ref
			//IL_1326: Expected Obj, but got Ref
			//IL_132e: Expected Obj, but got Ref
			//IL_132e: Expected Obj, but got Ref
			//IL_1337: Expected Obj, but got I4
			//IL_0ac1: Expected Obj, but got I4
			//IL_12d1: Expected Obj, but got Ref
			//IL_0c59: Expected Obj, but got I4
			//IL_0162: Expected I4, but got Obj
			//IL_02cf: Expected Obj, but got Ref
			//IL_0942: Expected Obj, but got Ref
			//IL_063e: Expected Obj, but got Ref
			//IL_0e65: Expected Obj, but got Ref
			//IL_02a2: Expected Obj, but got Ref
			//IL_02aa: Expected Obj, but got Ref
			//IL_02aa: Expected Obj, but got Ref
			//IL_0380: Expected Obj, but got I4
			//IL_0385: Expected VT, but got I4
			//IL_0385: Expected Obj, but got Ref
			//IL_022d: Expected Obj, but got I4
			//IL_0232: Expected Obj, but got I4
			//IL_0232: Expected Obj, but got Ref
			//IL_0241: Expected Obj, but got I
			//IL_0217: Expected I4, but got Obj
			//IL_021e: Expected Obj, but got I4
			//IL_0330: Expected Obj, but got Ref
			//IL_0330: Unknown result type (might be due to invalid IL or missing references)
			//IL_027d: Expected I, but got Obj
			//IL_027d: Expected Obj, but got Ref
			//IL_0908: Expected Obj, but got Ref
			//IL_0908: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ac: Expected Obj, but got Ref
			//IL_08d6: Expected Obj, but got Ref
			//IL_08de: Expected Obj, but got Ref
			//IL_08de: Expected Obj, but got Ref
			//IL_0883: Expected Obj, but got I4
			//IL_0888: Expected Obj, but got I4
			//IL_0888: Expected Obj, but got Ref
			//IL_08ac: Expected Obj, but got I4
			//IL_08b1: Expected Obj, but got I4
			//IL_08b1: Expected Obj, but got Ref
			//IL_05c1: Expected Obj, but got I4
			//IL_05c6: Expected Obj, but got I4
			//IL_05c6: Expected Obj, but got Ref
			//IL_0682: Expected Obj, but got I4
			//IL_0687: Expected Obj, but got I4
			//IL_0687: Expected Obj, but got Ref
			//IL_06ae: Expected Obj, but got Ref
			//IL_057e: Expected Obj, but got Ref
			//IL_0611: Expected Obj, but got Ref
			//IL_0597: Expected Obj, but got Ref
			//IL_0e8c: Expected Obj, but got Ref
			//IL_0e94: Expected Obj, but got Ref
			//IL_0fb2: Expected Obj, but got Ref
			//IL_0fb2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ec8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ed2: Expected Obj, but got Unknown
			//IL_1025: Expected Obj, but got Ref
			//IL_102e: Expected Obj, but got I4
			//IL_0e17: Expected VT, but got Ref
			//IL_0db2: Expected Obj, but got Ref
			//IL_1038: Expected Obj, but got I4
			//IL_103d: Expected Obj, but got I4
			//IL_103d: Expected Obj, but got Ref
			//IL_0e3b: Expected Obj, but got I4
			//IL_0e40: Expected Obj, but got I4
			//IL_0e40: Expected Obj, but got Ref
			//IL_0fcc: Expected Obj, but got I4
			//IL_0fd3: Expected Obj, but got I4
			//IL_0f79: Expected Obj, but got I4
			//IL_0f7e: Expected Obj, but got I4
			//IL_0f7e: Expected Obj, but got Ref
			//IL_0efd: Expected Obj, but got I4
			//IL_0f02: Expected Obj, but got I4
			//IL_0f02: Expected Obj, but got Ref
			//IL_0dd7: Expected Obj, but got Ref
			//IL_0ddf: Expected Obj, but got Ref
			//IL_0ddf: Expected Obj, but got Ref
			//IL_0f53: Expected Obj, but got Ref
			//IL_0ff4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f12: Expected Obj, but got Ref
			//IL_0f29: Expected Obj, but got Ref
			//IL_08fd: Expected Obj, but got I4
			//IL_058c: Expected Obj, but got I4
			//IL_0da5: Expected I4, but got Obj
			//IL_0538: Expected I4, but got Obj
			//IL_14e1->IL0026: Incompatible stack types: I4 vs Obj
			//IL_1508->IL0026: Incompatible stack types: I4 vs Obj
			//IL_152a->IL0026: Incompatible stack heights: 2 vs 1
			//IL_005b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_14ec->IL0026: Incompatible stack types: I4 vs Obj
			//IL_1513->IL0026: Incompatible stack types: I4 vs Obj
			//IL_07c3->IL0091: Incompatible stack types: I4 vs Obj
			//IL_13e9->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0afb->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0baf->IL0091: Incompatible stack types: I4 vs Obj
			//IL_01b1->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0adb->IL0091: Incompatible stack types: I4 vs Obj
			//IL_13f4->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0b06->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0bba->IL0091: Incompatible stack types: I4 vs Obj
			//IL_01bc->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0ae6->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0d35->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0b6b->IL0091: Incompatible stack types: I4 vs Obj
			//IL_12b6->IL0091: Incompatible stack types: I4 vs Obj
			//IL_136b->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0c3d->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0c9b->IL0091: Incompatible stack heights: 2 vs 1
			//IL_019c->IL0091: Incompatible stack types: I4 vs Obj
			//IL_13ac->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0c51->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0bce->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0d11->IL0091: Incompatible stack types: I4 vs Obj
			//IL_1429->IL0091: Incompatible stack types: I4 vs Obj
			//IL_046b->IL0091: Incompatible stack types: I4 vs Obj
			//IL_140c->IL0091: Incompatible stack types: I4 vs Obj
			//IL_07e6->IL0091: Incompatible stack heights: 2 vs 1
			//IL_0b40->IL0091: Incompatible stack types: I4 vs Obj
			//IL_12ca->IL0091: Incompatible stack types: I4 vs Obj
			//IL_1320->IL0091: Incompatible stack types: I4 vs Obj
			//IL_07a6->IL0091: Incompatible stack heights: 2 vs 1
			//IL_130e->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0c27->IL0091: Incompatible stack types: I4 vs Obj
			//IL_133c->IL008d: Incompatible stack heights: 1 vs 0
			//IL_0ac6->IL008d: Incompatible stack heights: 2 vs 0
			//IL_0c08->IL0091: Incompatible stack types: I4 vs Obj
			//IL_04e1->IL0091: Incompatible stack heights: 2 vs 1
			//IL_0c6d->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0cea->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0b76->IL0091: Incompatible stack types: I4 vs Obj
			//IL_1376->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0ca6->IL0091: Incompatible stack heights: 2 vs 1
			//IL_064a->IL0503: Incompatible stack types: I4 vs Obj
			//IL_04ff->IL0503: Incompatible stack types: I4 vs Obj
			//IL_13b7->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0d1c->IL0091: Incompatible stack types: I4 vs Obj
			//IL_1434->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0476->IL0091: Incompatible stack types: I4 vs Obj
			//IL_07f1->IL0091: Incompatible stack heights: 2 vs 1
			//IL_0786->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0b4b->IL0091: Incompatible stack types: I4 vs Obj
			//IL_07b1->IL0091: Incompatible stack heights: 2 vs 1
			//IL_0e7b->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_0d48->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_0811->IL0091: Incompatible stack types: I4 vs Obj
			//IL_12ea->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0c13->IL0091: Incompatible stack types: I4 vs Obj
			//IL_04ec->IL0091: Incompatible stack heights: 2 vs 1
			//IL_0c78->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0cf5->IL0091: Incompatible stack types: I4 vs Obj
			//IL_0e86->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_081c->IL0091: Incompatible stack types: I4 vs Obj
			//IL_12f5->IL0091: Incompatible stack types: I4 vs Obj
			//IL_02be->IL01d3: Incompatible stack heights: 2 vs 1
			//IL_08f4->IL0963: Incompatible stack heights: 1 vs 0
			//IL_08e8->IL0848: Incompatible stack heights: 3 vs 1
			//IL_05da->IL0503: Incompatible stack types: I4 vs Obj
			//IL_069b->IL0503: Incompatible stack types: I4 vs Obj
			//IL_06b8->IL0503: Incompatible stack types: I4 vs Obj
			//IL_056c->IL0503: Incompatible stack types: I4 vs Obj
			//IL_062d->IL0503: Incompatible stack heights: 2 vs 1
			//IL_05b1->IL0503: Incompatible stack types: I4 vs Obj
			//IL_0ea8->IL0d4c: Incompatible stack heights: 4 vs 1
			//IL_0fc2->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_0eed->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_0e2b->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_0dc6->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_1047->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_0e54->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_0fe7->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_0f92->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_0f0c->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_0df3->IL0d4c: Incompatible stack heights: 3 vs 1
			//IL_0f69->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_0f22->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_02c9->IL01d3: Incompatible stack heights: 2 vs 1
			//IL_05e5->IL0503: Incompatible stack types: I4 vs Obj
			//IL_06a6->IL0503: Incompatible stack types: I4 vs Obj
			//IL_0577->IL0503: Incompatible stack types: I4 vs Obj
			//IL_0638->IL0503: Incompatible stack heights: 2 vs 1
			//IL_05bc->IL0503: Incompatible stack types: I4 vs Obj
			//IL_0eb3->IL0d4c: Incompatible stack heights: 4 vs 1
			//IL_0ef8->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_0e36->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_0dd1->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_0e5f->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_0ff2->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_0f9d->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_0dfe->IL0d4c: Incompatible stack heights: 3 vs 1
			//IL_0e10->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_0f74->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_1012->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_0f42->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_0848->IL0848: Incompatible stack heights: 2 vs 1
			//IL_101d->IL0d4c: Incompatible stack types: I4 vs Obj
			//IL_0f4d->IL0d4c: Incompatible stack types: I4 vs Obj
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 1;
			object obj = awaiter;
			while (true)
			{
				switch ((int)obj)
				{
				case 5:
					return;
				case 4:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = -2;
					obj = 3;
					break;
				case 2:
				{
					object obj2;
					switch ((int)awaiter)
					{
					default:
						awaiter = 44;
						goto IL_008d;
					case 5:
						obj2 = 8;
						if (IList_object.PatchAttribute == null)
						{
							obj2 = 9;
						}
						goto IL_0091;
					case 0:
						goto IL_07b1;
					case 6:
						goto IL_0ac6;
					case 2:
					case 3:
						goto IL_0ae6;
					case 4:
						goto IL_0b93;
					case 1:
						goto IL_13d4;
						IL_008d:
						obj2 = awaiter;
						goto IL_0091;
						IL_0091:
						while (true)
						{
							int num;
							object obj4;
							object obj3;
							switch ((int)obj2)
							{
							case 45:
								return;
							case 50:
								return;
							case 2:
							case 35:
							case 36:
								break;
							case 14:
							case 15:
								/*Error near IL_0192: Stack underflow*/((object[])/*Error near IL_0192: Stack underflow*/, (nint)(&awaiter));
								obj2 = 16;
								continue;
							case 28:
								goto end_IL_0091;
							case 9:
								if ((nint)awaiter != 5)
								{
									num = 6;
									goto IL_01d3;
								}
								goto IL_02c9;
							case 23:
								__KnownINotifyPropertyChangingArgs.IsSkeleton = (PropertyChangingEventArgs)awaiter;
								obj2 = 28;
								if (__KnownINotifyPropertyChangingArgs.ShowMaxPlayer == null)
								{
									obj2 = 42;
								}
								continue;
							case 48:
								IEnumeratorMethods<IDisposable>.Abi_GetMany_3((IntPtr)/*Error near IL_04cd: Stack underflow*/, ref *(IDisposable[]*)IReadOnlyList_System_IDisposable.Do_Abi_get_Size_1((nint)/*Error near IL_04c8: Stack underflow*/, (uint*)(int)IReadOnlyList_System_IDisposable.Do_Abi_GetMany_3((nint)/*Error near IL_04c3: Stack underflow*/, (uint)/*Error near IL_04c3: Stack underflow*/, (uint)/*Error near IL_04c3: Stack underflow*/, (nint)/*Error near IL_04c3: Stack underflow*/, (uint*)/*Error near IL_04c3: Stack underflow*/)));
								_ = 7;
								if (__KnownINotifyPropertyChangingArgs.IsLiked == null)
								{
									_ = 2;
								}
								continue;
							case 13:
								if ((nint)awaiter != 1)
								{
									obj4 = 7;
									goto IL_0503;
								}
								goto IL_0638;
							case 26:
								if ((nint)awaiter == 1)
								{
									obj2 = 10;
									continue;
								}
								goto case 17;
							case 34:
								Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ValidateAttribute();
								awaiter = (nint)IEnumeratorMethods<IDisposable>.AbiToProjectionVftablePtr;
								_ = 1;
								if (__KnownINotifyPropertyChangingArgs.IsDragging != null)
								{
									_ = 1;
								}
								continue;
							case 29:
								goto IL_07b1;
							case 25:
								((Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails)(object)((Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails)/*Error near IL_07c8: Stack underflow*/).GetExposedInterfaces())._002Ector();
								_ = IVisualElementMethods.AbiToProjectionVftablePtr;
								_ = 33;
								if (__KnownINotifyPropertyChangingArgs.SkippedCount == null)
								{
									_ = 18;
								}
								continue;
							case 44:
								if (__KnownINotifyPropertyChangingArgs.ParsedAccounts != null)
								{
									obj2 = 28;
									if (__KnownINotifyPropertyChangingArgs.InputText == null)
									{
										obj2 = 39;
									}
									continue;
								}
								goto case 25;
							case 12:
								goto IL_081c;
							default:
								goto IL_0ab1;
							case 32:
								goto IL_0ac6;
							case 3:
								goto IL_0ae6;
							case 16:
								goto IL_0b06;
							case 27:
								goto IL_0b1d;
							case 6:
								__KnownINotifyPropertyChangingArgs.SelectedTopUpGroup = (PropertyChangingEventArgs)default(NumberBox);
								obj2 = 26;
								if (__KnownINotifyPropertyChangingArgs.Orders == null)
								{
									obj2 = 30;
								}
								continue;
							case 33:
								goto IL_0b76;
							case 38:
								goto IL_0b93;
							case 19:
								awaiter = 0;
								__KnownINotifyPropertyChangingArgs.Customers = (PropertyChangingEventArgs)0;
								obj2 = 31;
								continue;
							case 39:
								goto IL_0bce;
							case 47:
								((App)/*Error near IL_0bea: Stack underflow*/).OnLaunched((LaunchActivatedEventArgs)/*Error near IL_0bea: Stack underflow*/);
								((App)/*Error near IL_0bef: Stack underflow*/).AppClosing((byte)/*Error near IL_0bef: Stack underflow*/ != 0, (AppWindow)/*Error near IL_0bef: Stack underflow*/, (AppWindowClosingEventArgs)/*Error near IL_0bef: Stack underflow*/);
								((AsyncVoidMethodBuilder*)/*Error near IL_0bf4: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_0bf4: Stack underflow*/, ref *(TStateMachine*)/*Error near IL_0bf4: Stack underflow*/);
								obj2 = 22;
								if (__KnownINotifyPropertyChangedArgs.CreateAt != null)
								{
									obj2 = 12;
								}
								continue;
							case 40:
								awaiter = -1;
								__KnownINotifyPropertyChangedArgs.LoginAt = (PropertyChangedEventArgs)(-1);
								obj2 = 43;
								continue;
							case 10:
								awaiter = ((Task)(object)((App)/*Error near IL_0c2c: Stack underflow*/).GetXmlnsDefinitions()).GetAwaiter();
								obj2 = 46;
								continue;
							case 18:
								awaiter = 4;
								__KnownINotifyPropertyChangedArgs.Message = (PropertyChangedEventArgs)4;
								obj2 = 23;
								continue;
							case 49:
								__KnownINotifyPropertyChangedArgs.CharacterName = (PropertyChangedEventArgs)1;
								obj2 = 32;
								if (__KnownINotifyPropertyChangedArgs.IsSelected != null)
								{
									obj2 = 47;
								}
								continue;
							case 11:
								App._003CLogout_003Ed__15.ReplaceModel();
								((UserControl)App._003CLogout_003Ed__15.LoadCreator())._002Ector();
								_ = 25;
								if (__KnownINotifyPropertyChangedArgs.MaxPlayers == null)
								{
									_ = 32;
								}
								continue;
							case 1:
								((InvokeCommandAction)/*Error near IL_0cd1: Stack underflow*/).CommandParameter = (object)(&awaiter);
								if ((int)/*Error near IL_0cd6: Stack underflow*/ != 0)
								{
									obj2 = 0;
									if (__KnownINotifyPropertyChangedArgs.Characters == null)
									{
										obj2 = 0;
									}
									continue;
								}
								goto case 19;
							case 21:
								awaiter = __KnownINotifyPropertyChangedArgs.BackgroundImageUrl;
								obj2 = 26;
								if (__KnownINotifyPropertyChangedArgs.Summary != null)
								{
									obj2 = 4;
								}
								continue;
							case 5:
								goto IL_0d1c;
							case 41:
								if ((nint)awaiter != 2)
								{
									obj3 = 15;
									goto IL_0d4c;
								}
								goto IL_0e5f;
							case 7:
								__KnownINotifyPropertyChangedArgs.Instances = (PropertyChangedEventArgs)0;
								obj2 = 3;
								continue;
							case 30:
								awaiter = -1;
								__KnownINotifyPropertyChangedArgs.InputUsername = (PropertyChangedEventArgs)(-1);
								obj2 = 14;
								continue;
							case 46:
								((Collection<GameResourceModel>)(&awaiter))._002Ector();
								if ((int)/*Error near IL_12d6: Stack underflow*/ != 0)
								{
									obj2 = 0;
									if (__KnownINotifyPropertyChangedArgs.CanDesktopMenuInvoke == null)
									{
										obj2 = 15;
									}
									continue;
								}
								goto case 18;
							case 37:
								((ActionCollection)((XamlTypeInfoProvider)((XamlTypeInfoProvider)/*Error near IL_12fa: Stack underflow*/).Activate_96_ObservableCollection()).Activate_97_Collection())._002Ector();
								obj2 = 28;
								continue;
							case 31:
								__KnownINotifyPropertyChangedArgs.Ordering = (PropertyChangedEventArgs)awaiter;
								obj2 = 24;
								continue;
							case 42:
								goto IL_1320;
							case 8:
								__KnownINotifyPropertyChangedArgs.HasShopDescription = (PropertyChangedEventArgs)default(NavigationViewBackButtonVisible);
								obj2 = 40;
								if (__KnownINotifyPropertyChangedArgs.CustomCoinAmount != null)
								{
									obj2 = 10;
								}
								continue;
							case 17:
								((ObservableCollection<object>)((XamlTypeInfoProvider)((XamlTypeInfoProvider)/*Error near IL_138e: Stack underflow*/).Activate_121_AppNavigationViewItemPresenter()).Activate_122_NavigationViewItemPresenter())._002Ector();
								obj2 = 35;
								if (__KnownINotifyPropertyChangedArgs.SelectedTopUpTabIndex == null)
								{
									obj2 = 37;
								}
								continue;
							case 20:
								goto IL_13b7;
							case 4:
								goto IL_13d4;
							case 24:
								Unsafe.As<PropertyChangedEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangedArgs.PayMethods).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<(bool, string)>*)(&awaiter), ref Unsafe.As<_003CInit_003Ed__14, MobileGameModel._003CLaunchGame_003Ed__52>(ref this));
								obj2 = 50;
								continue;
							case 22:
								{
									awaiter = __KnownINotifyPropertyChangedArgs.Order;
									obj2 = 34;
									if (__KnownINotifyPropertyChangedArgs.InviteUrl != null)
									{
										obj2 = 35;
									}
									continue;
								}
								IL_01d3:
								while (true)
								{
									switch (num)
									{
									case 11:
										return;
									case 6:
										awaiter = IEnumeratorMethods<object>.Abi_get_HasCurrent_1(MarshalInspectable<object>.FromManaged((object)/*Error near IL_0217: Stack underflow*/, (byte)(int)IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)/*Error near IL_0212: Stack underflow*/) != 0));
										num = 2;
										continue;
									case 5:
										awaiter = -1;
										IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = -1;
										num = 0;
										if (IReadOnlyList_object.ReflectLogicalAttribute == null)
										{
											num = 0;
										}
										continue;
									case 9:
										IEnumerable_System_IDisposable._initialized = (nint)awaiter;
										num = 1;
										if (IEnumerable_object._initialized == 0)
										{
											num = 1;
										}
										continue;
									case 1:
										Interlocked.CompareExchange(ref Unsafe.As<object, Func<InfoBarDelegate>>(ref IEnumerable_object.ReflectSetAttribute), (Func<InfoBarDelegate>)(&awaiter), (Func<InfoBarDelegate>)Unsafe.AsPointer(ref this));
										_ = 11;
										if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute != null)
										{
											_ = 1;
										}
										continue;
									case 10:
										break;
									case 2:
										if (IListMethods<object>.Abi_IndexOf_3((IntPtr)/*Error near IL_031b: Stack underflow*/, (object)/*Error near IL_031b: Stack underflow*/, ref *(uint*)(&awaiter)))
										{
											num = 4;
											continue;
										}
										goto case 3;
									case 8:
										Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute = (object)default(IReadOnlyListMethods<, >);
										num = 5;
										if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute == null)
										{
											num = 5;
										}
										continue;
									default:
										IListMethods<object>.Abi_RemoveAtEnd_8((IntPtr)(nint)(&awaiter));
										num = 5;
										if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule == null)
										{
											num = 7;
										}
										continue;
									case 3:
										awaiter = 5;
										_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout = (TimeSpan)5;
										num = 9;
										continue;
									case 7:
										goto IL_0b1d;
									}
									break;
								}
								goto IL_02c9;
								IL_0e5f:
								awaiter = __KnownINotifyPropertyChangedArgs.PayAt;
								obj3 = 18;
								if (__KnownINotifyPropertyChangedArgs.PayUrl == null)
								{
									obj3 = 3;
								}
								goto IL_0d4c;
								IL_0d4c:
								while (true)
								{
									switch ((int)obj3)
									{
									case 6:
										return;
									case 19:
										return;
									case 10:
										break;
									case 5:
										__KnownINotifyPropertyChangedArgs.Executor = (PropertyChangedEventArgs)awaiter;
										obj3 = 0;
										if (__KnownINotifyPropertyChangedArgs.State != null)
										{
											obj3 = 0;
										}
										continue;
									case 14:
										_ = ref __KnownINotifyPropertyChangedArgs.StateText;
										((IEnumerable<EntityMassReferralCustomer>)(&awaiter)).Select((Func<EntityMassReferralCustomer, ReferralCustomerModel>)Unsafe.AsPointer(ref this));
										_ = 1;
										if (__KnownINotifyPropertyChangedArgs.Type == null)
										{
											_ = 6;
										}
										continue;
									case 15:
										if ((nint)awaiter != 3)
										{
											obj3 = 11;
											continue;
										}
										goto case 16;
									case 4:
										((OverlappedPresenter)/*Error near IL_0e17: Stack underflow*/).PreferredMinimumHeight = (int?)(object)(&awaiter);
										obj3 = 10;
										if (__KnownINotifyPropertyChangedArgs.OrderId == null)
										{
											obj3 = 1;
										}
										continue;
									case 9:
										awaiter = 3;
										__KnownINotifyPropertyChangedArgs.Price = (PropertyChangedEventArgs)3;
										obj3 = 5;
										if (__KnownINotifyPropertyChangedArgs.OrderAt == null)
										{
											obj3 = 5;
										}
										continue;
									case 8:
										goto IL_0e5f;
									default:
										_ = ref __KnownINotifyPropertyChangedArgs.Image;
										_ = ref awaiter;
										CastExtensions.As<DesktopGameCard>((object)Unsafe.AsPointer(ref this));
										_ = 19;
										if (__KnownINotifyPropertyChangedArgs.TotalCoins == null)
										{
											_ = 7;
										}
										continue;
									case 2:
										((MainWindow)((FrameworkElement*)(&awaiter))->ActualTheme).InitializeComponent();
										awaiter = ((Panel)/*Error near IL_0ed7: Stack underflow*/).Children;
										obj3 = 17;
										if (__KnownINotifyPropertyChangedArgs.DesktopAccounts != null)
										{
											obj3 = 14;
										}
										continue;
									case 13:
										awaiter = -1;
										__KnownINotifyPropertyChangedArgs.MobileAccounts = (PropertyChangedEventArgs)(-1);
										obj3 = 2;
										continue;
									case 18:
										__KnownINotifyPropertyChangedArgs.SelectedAccounts = null;
										obj3 = 13;
										continue;
									case 20:
										((DispatcherQueueSynchronizationContext)/*Error near IL_0f29: Stack underflow*/)._002Ector((DispatcherQueue)(object)(&awaiter));
										if ((int)/*Error near IL_0f2e: Stack underflow*/ == 0)
										{
											obj3 = 7;
											if (__KnownINotifyPropertyChangedArgs.InputEmail == null)
											{
												obj3 = 3;
											}
											continue;
										}
										goto case 2;
									case 16:
										awaiter = __KnownINotifyPropertyChangedArgs.InputCookie;
										obj3 = 1;
										if (__KnownINotifyPropertyChangedArgs.Input163Password != null)
										{
											obj3 = 0;
										}
										continue;
									case 12:
										awaiter = -1;
										__KnownINotifyPropertyChangedArgs.InputMobilePassword = (PropertyChangedEventArgs)(-1);
										obj3 = 4;
										if (__KnownINotifyPropertyChangedArgs.InputVerifyCode == null)
										{
											obj3 = 4;
										}
										continue;
									case 1:
										__KnownINotifyPropertyChangedArgs.VerifyCodeDelayText = (PropertyChangedEventArgs)default(CompositionObject);
										obj3 = 12;
										continue;
									case 11:
										((Dictionary<string, IXamlMember>)/*Error near IL_0fcc: Stack underflow*/).Add((string)/*Error near IL_0fcc: Stack underflow*/, (IXamlMember)(object)string.IsNullOrEmpty((string?)/*Error near IL_0fc7: Stack underflow*/));
										awaiter = ((Dictionary<string, IXamlMember>)/*Error near IL_0fd1: Stack underflow*/).TryGetValue((string)/*Error near IL_0fd1: Stack underflow*/, out *(IXamlMember*)/*Error near IL_0fd1: Stack underflow*/);
										obj3 = 20;
										if (__KnownINotifyPropertyChangedArgs.SelectedFileName == null)
										{
											obj3 = 2;
										}
										continue;
									case 17:
										awaiter = (object)new XamlControlsResources();
										if ((int)/*Error near IL_0ffe: Stack underflow*/ == 0)
										{
											obj3 = 9;
											if (__KnownINotifyPropertyChangedArgs.ImportedCount != null)
											{
												obj3 = 9;
											}
											continue;
										}
										goto case 4;
									case 3:
										__KnownINotifyPropertyChangedArgs.SkippedCount = (PropertyChangedEventArgs)awaiter;
										awaiter = 14;
										obj3 = awaiter;
										continue;
									case 7:
										awaiter = 2;
										__KnownINotifyPropertyChangedArgs.ParsedAccounts = (PropertyChangedEventArgs)2;
										obj3 = 3;
										continue;
									}
									break;
								}
								goto case 21;
								IL_0b1d:
								((Microsoft.Windows.ApplicationModel.WindowsAppRuntime.Common.AutoInitialize)/*Error near IL_0b22: Stack underflow*/)._002Ector();
								((AppWindow)NativeMethods.WindowsAppRuntime_EnsureIsLoaded()).Destroy();
								obj2 = 11;
								if (__KnownINotifyPropertyChangingArgs.SelectedTopUpGroupIndex == null)
								{
									obj2 = 5;
								}
								continue;
								IL_02c9:
								awaiter = Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute;
								num = 8;
								if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute == null)
								{
									num = 1;
								}
								goto IL_01d3;
								IL_0638:
								awaiter = __KnownINotifyPropertyChangingArgs.JoinedAt;
								obj4 = 9;
								goto IL_0503;
								IL_0503:
								while (true)
								{
									switch ((int)obj4)
									{
									case 2:
										return;
									case 7:
										awaiter = IEnumerableMethods<object>.Abi_First_0((IntPtr)(IEnumerableMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(int)IReadOnlyList_object.Do_Abi_GetAt_0((nint)/*Error near IL_054c: Stack underflow*/, IEnumerableMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)/*Error near IL_0542: Stack underflow*/) ? 1u : 0u, (nint*)(int)IReadOnlyList_object.Init())) ? 1 : 0));
										obj4 = 4;
										if (__KnownINotifyPropertyChangingArgs.State != null)
										{
											obj4 = 5;
										}
										continue;
									case 5:
										ComWrappersSupport.RegisterTypeRuntimeClassNameLookup((Func<Type, string>)(&awaiter));
										if ((int)/*Error near IL_0583: Stack underflow*/ != 0)
										{
											awaiter = 10;
											obj4 = awaiter;
											continue;
										}
										goto default;
									case 9:
										Unsafe.As<PropertyChangingEventArgs, char>(ref __KnownINotifyPropertyChangingArgs.OperationText) = default;
										obj4 = 1;
										if (__KnownINotifyPropertyChangingArgs.CanDelete == null)
										{
											obj4 = 0;
										}
										continue;
									default:
										awaiter = 1;
										__KnownINotifyPropertyChangingArgs.Id = (PropertyChangingEventArgs)1;
										obj4 = 4;
										if (__KnownINotifyPropertyChangingArgs.Price != null)
										{
											obj4 = 0;
										}
										continue;
									case 6:
									case 10:
										_ = ref awaiter;
										/*Error near IL_05e7: Member reference must be method, but was: Field*/;
									case 8:
										_ = ref __KnownINotifyPropertyChangingArgs.Number;
										((AsyncTaskMethodBuilder*)(&awaiter))->Start(ref Unsafe.As<_003CInit_003Ed__14, DesktopViewModel._003CLaunchGame_003Ed__3>(ref this));
										_ = 0;
										if (__KnownINotifyPropertyChangingArgs.DisplayName != null)
										{
											_ = 2;
										}
										continue;
									case 11:
										break;
									case 1:
										awaiter = -1;
										__KnownINotifyPropertyChangingArgs.Amount = (PropertyChangingEventArgs)(-1);
										obj4 = 4;
										if (__KnownINotifyPropertyChangingArgs.Quantity != null)
										{
											obj4 = 6;
										}
										continue;
									case 4:
										__KnownINotifyPropertyChangingArgs.DesktopAccounts = (PropertyChangingEventArgs)awaiter;
										obj4 = 8;
										continue;
									case 3:
										goto IL_13b7;
									}
									break;
								}
								goto IL_0638;
							}
							goto end_IL_005e;
							IL_081c:
							int num2;
							if ((nint)awaiter != 6)
							{
								num2 = 1;
								if (__KnownINotifyPropertyChangingArgs.HasSelectedGame == null)
								{
									num2 = 8;
								}
								goto IL_0848;
							}
							goto IL_093c;
							IL_0d1c:
							((MainContent.IMainContent_BindingsScopeConnector)/*Error near IL_0d21: Stack underflow*/).Parent = (WeakReference)/*Error near IL_0d21: Stack underflow*/;
							((OverlappedPresenter)/*Error near IL_0d2b: Stack underflow*/).PreferredMinimumWidth = (int?)(object)((MainContent.IMainContent_BindingsScopeConnector)/*Error near IL_0d26: Stack underflow*/).ContainsElement((int)/*Error near IL_0d26: Stack underflow*/);
							obj2 = 49;
							continue;
							IL_0848:
							while (true)
							{
								switch (num2)
								{
								case 7:
									return;
								case 6:
									awaiter = 6;
									__KnownINotifyPropertyChangingArgs.LanGames = (PropertyChangingEventArgs)6;
									num2 = 1;
									if (__KnownINotifyPropertyChangingArgs.NetGames == null)
									{
										num2 = 1;
									}
									continue;
								case 9:
									awaiter = -1;
									__KnownINotifyPropertyChangingArgs.LikeNetGames = (PropertyChangingEventArgs)(-1);
									num2 = 4;
									if (__KnownINotifyPropertyChangingArgs.NetGamesEmptyText != null)
									{
										num2 = 4;
									}
									continue;
								case 3:
									_ = ref __KnownINotifyPropertyChangingArgs.LikeNetGamesEmptyText;
									((IEnumerable<IDesktopSkin>)(&awaiter)).Select((Func<IDesktopSkin, DesktopSkinModel>)Unsafe.AsPointer(ref this));
									_ = 7;
									continue;
								case 2:
									_ = ref awaiter;
									if ((nint)IXamlMetadataProviderMethods.IID == 0)
									{
										awaiter = 6;
										continue;
									}
									goto case 4;
								default:
									__KnownINotifyPropertyChangingArgs.Skins = (PropertyChangingEventArgs)default(DispatcherQueuePriority);
									num2 = 9;
									if (__KnownINotifyPropertyChangingArgs.SkinAllSelected != null)
									{
										num2 = 7;
									}
									continue;
								case 10:
									break;
								case 4:
									_ = ref awaiter;
									/*Error near IL_0965: Member reference must be method, but was: Field*/;
								case 8:
									/*Error near IL_0989: Member reference must be method, but was: Field*/;
								case 1:
									__KnownINotifyPropertyChangingArgs.AllResources = (PropertyChangingEventArgs)awaiter;
									num2 = 3;
									continue;
								case 5:
									goto IL_0d1c;
								}
								break;
							}
							goto IL_093c;
							IL_093c:
							awaiter = __KnownINotifyPropertyChangingArgs.SkinOwnedSelected;
							num2 = 0;
							if (__KnownINotifyPropertyChangingArgs.PagesOfSkins == null)
							{
								num2 = 0;
							}
							goto IL_0848;
							continue;
							end_IL_0091:
							break;
						}
						goto case 5;
						IL_13d4:
						obj2 = 13;
						if (__KnownINotifyPropertyChangedArgs.TopUpItems == null)
						{
							obj2 = 10;
						}
						goto IL_0091;
						IL_07b1:
						awaiter = __KnownINotifyPropertyChangingArgs.Step;
						obj2 = 8;
						goto IL_0091;
						IL_1320:
						_ = ref __KnownINotifyPropertyChangedArgs.CanSelect;
						ObservableHelper.UpdateObservableCollection((IList<DesktopGameCharacterModel>)(&awaiter), (List<DesktopGameCharacterModel>)Unsafe.AsPointer(ref this));
						awaiter = 45;
						goto IL_008d;
						IL_0bce:
						awaiter = __KnownINotifyPropertyChangingArgs.RedeemOptions;
						awaiter = 36;
						goto IL_008d;
						IL_0b93:
						awaiter = __KnownINotifyPropertyChangingArgs.CanRedeem;
						obj2 = 6;
						if (__KnownINotifyPropertyChangingArgs.Earnings == null)
						{
							obj2 = 0;
						}
						goto IL_0091;
						IL_13b7:
						((Collection<HistoryOrderModel>)((XamlTypeInfoProvider)((XamlTypeInfoProvider)/*Error near IL_13bc: Stack underflow*/).Activate_131_ItemCollectionTransitionProvider()).Activate_133_StackLayout())._002Ector();
						awaiter = 48;
						goto IL_008d;
						IL_0b76:
						((App)/*Error near IL_0b7b: Stack underflow*/).Window = (Window?)/*Error near IL_0b7b: Stack underflow*/;
						((ILogger)/*Error near IL_0b85: Stack underflow*/).Warning((string)(object)((App)/*Error near IL_0b80: Stack underflow*/).RootElement);
						awaiter = 34;
						goto IL_008d;
						IL_0b06:
						awaiter = __KnownINotifyPropertyChangingArgs.SelectedProductGroupIndex;
						awaiter = 2;
						goto IL_008d;
						IL_0ae6:
						obj2 = 6;
						if (__KnownINotifyPropertyChangingArgs.ProductGroups == null)
						{
							obj2 = 41;
						}
						goto IL_0091;
						IL_0ac6:
						obj2 = 3;
						if (__KnownINotifyPropertyChangingArgs.CustomCoinAmount == null)
						{
							obj2 = 12;
						}
						goto IL_0091;
						IL_0ab1:
						_ = ref awaiter;
						_ = WeakReferenceMessenger.Default;
						awaiter = 4;
						goto IL_008d;
						end_IL_005e:
						break;
					}
					goto case 4;
				}
				default:
					awaiter = App.Logger__BackingField;
					obj = 2;
					if (((App)App.Window__BackingField)._contentLoaded != 0)
					{
						obj = 0;
					}
					break;
				case 1:
					awaiter = ((App)Unsafe.AsPointer(ref this)).__appProvider;
					obj = 0;
					if (((App._003CLogout_003Ed__15*)(nint)App.CheckAlphabeticDictionary)->_003C_003E1__state == 0)
					{
						obj = 0;
					}
					break;
				case 3:
					_ = ref ((App._003CLogout_003Ed__15)this)._003C_003Et__builder;
					((CompositionShadow)awaiter)._002Ector();
					_ = 5;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00夀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778230, new IntPtr(2737336176172L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00娀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00嬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778231, new IntPtr(2737336169932L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00尀()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00崀(object? P_0)
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
	private struct _003CInitialize_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public LoginWindowViewModel _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private static object? CheckAutomatedTemplate;

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
		internal static bool ReflectPassiveAuditor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? ReflectExternalDecider()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00㼀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778228, new IntPtr(2737336151212L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00䀀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_004e: Expected Obj, but got Ref
			//IL_0064: Expected Obj, but got I
			//IL_00a1: Expected Obj, but got Ref
			//IL_007a: Expected Obj, but got Ref
			//IL_007c: Expected Obj, but got I
			//IL_008d: Expected Obj, but got Ref
			//IL_0219: Expected Obj, but got Ref
			//IL_03f0: Expected Obj, but got Ref
			//IL_01df: Expected Obj, but got Ref
			//IL_03de: Expected I, but got Obj
			//IL_03e0: Expected Obj, but got I4
			//IL_0207: Expected Obj, but got Ref
			//IL_0209: Expected Obj, but got I
			//IL_02a3: Expected Obj, but got Ref
			//IL_02ab: Expected Obj, but got Ref
			//IL_02ab: Expected Obj, but got Ref
			//IL_0291: Expected Obj, but got Ref
			//IL_023f: Expected Obj, but got I4
			//IL_0244: Expected Obj, but got I4
			//IL_0244: Expected Obj, but got Ref
			//IL_024d: Expected Obj, but got I4
			//IL_01a2: Expected Obj, but got I4
			//IL_01a7: Expected Obj, but got Ref
			//IL_0178: Expected Obj, but got Ref
			//IL_0257: Expected Obj, but got I4
			//IL_025c: Expected Obj, but got I4
			//IL_025c: Expected Obj, but got Ref
			//IL_036b: Expected Obj, but got I4
			//IL_0370: Expected Obj, but got I4
			//IL_0370: Expected Obj, but got Ref
			//IL_0306: Expected Obj, but got Ref
			//IL_0344: Expected I, but got Obj
			//IL_03bc: Expected Obj, but got Ref
			//IL_03cd: Expected Obj, but got I4
			//IL_02f6: Expected I4, but got Obj
			//IL_02f6: Expected Obj, but got Ref
			//IL_015c: Expected I4, but got Obj
			//IL_0069->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00b5->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0086->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0099->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0074->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00c0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00dc->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_022f->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_03ab->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_00e7->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_023a->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_03b6->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0400->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_01f5->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_03ea->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0213->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_02bf->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_029d->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_01bb->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0182->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0266->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0384->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0316->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0350->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0300->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0200->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_02ca->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_01c6->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_019d->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0420->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_038f->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0366->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_042b->IL00eb: Incompatible stack types: I4 vs Obj
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 4;
			object obj = awaiter;
			while (true)
			{
				object obj2;
				switch ((int)obj)
				{
				default:
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)(nint)Unsafe.AsPointer(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized), ref *(object[]*)awaiter);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						_ = 2;
					}
					continue;
				case 3:
					awaiter = IList_object._initialized;
					obj = 5;
					continue;
				case 2:
					return;
				case 4:
					awaiter = IList_object.PatchAttribute;
					obj = 3;
					continue;
				case 1:
					break;
				case 5:
					{
						if (awaiter == null)
						{
							obj2 = 25;
							if (IReadOnlyList_object._initialized != 0)
							{
								obj2 = 19;
							}
							goto IL_00eb;
						}
						goto IL_038f;
					}
					IL_00eb:
					while (true)
					{
						switch ((int)obj2)
						{
						case 8:
							return;
						case 24:
							return;
						case 6:
						case 18:
							break;
						case 12:
							IReadOnlyList_object.ReflectLogicalAttribute = awaiter;
							obj2 = 7;
							continue;
						case 13:
							if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_018e: Stack underflow*/, (INotifyPropertyChanged)/*Error near IL_018e: Stack underflow*/, ref *(uint*)IEnumerator_System_IDisposable._initialized))
							{
								obj2 = 4;
								continue;
							}
							goto case 20;
						case 11:
							awaiter = 1;
							IEnumerable_System_IDisposable._initialized = 1;
							obj2 = 12;
							if (IEnumerable_object._initialized == 0)
							{
								obj2 = 12;
							}
							continue;
						case 1:
						case 25:
							awaiter = IEnumerable_object.ReflectSetAttribute;
							obj2 = 19;
							if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute != null)
							{
								obj2 = 5;
							}
							continue;
						case 3:
							awaiter = (nint)MarshalInterface<IEnumerator<INotifyPropertyChanged>>.FromManaged((IEnumerator<INotifyPropertyChanged>)(&awaiter));
							obj2 = 6;
							continue;
						case 14:
							goto end_IL_00eb;
						case 10:
							awaiter = 0;
							Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute = 0;
							awaiter = 22;
							goto IL_00e7;
						case 15:
							awaiter = -1;
							Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute = -1;
							obj2 = 3;
							continue;
						case 5:
						case 9:
							IListMethods<object>.Abi_InsertAt_5((IntPtr)/*Error near IL_0291: Stack underflow*/, (uint)/*Error near IL_0291: Stack underflow*/, (object)(&awaiter));
							awaiter = (object)/*Error near IL_0293: Stack underflow*/;
							obj2 = 18;
							continue;
						case 7:
							Unsafe.As<object, ILogger>(ref Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute).Warning<string>((string)(&awaiter), (string)Unsafe.AsPointer(ref this));
							obj2 = 24;
							if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute != null)
							{
								obj2 = 16;
							}
							continue;
						case 22:
							_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout = (byte)(int)awaiter != 0;
							obj2 = 21;
							continue;
						case 19:
							Unsafe.As<object, SortDirection?>(ref _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator) = null;
							obj2 = 15;
							continue;
						case 20:
							awaiter = IEnumeratorMethods<INotifyPropertyChanged>.Abi_get_Current_0((IntPtr)__KnownINotifyPropertyChangingArgs.UserId);
							obj2 = 26;
							continue;
						case 26:
							if (!IEnumeratorMethods<INotifyPropertyChanged>.Abi_get_HasCurrent_1((IntPtr)(nint)(&awaiter)))
							{
								obj2 = 10;
								continue;
							}
							goto case 3;
						case 17:
							awaiter = -1;
							__KnownINotifyPropertyChangingArgs.LoginAt = (PropertyChangingEventArgs)(-1);
							obj2 = 9;
							if (__KnownINotifyPropertyChangingArgs.IsMyself == null)
							{
								obj2 = 0;
							}
							continue;
						case 23:
							goto IL_038f;
						case 21:
							Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.Content).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<ContentDialogResult>*)(&awaiter), ref Unsafe.As<_003CInitialize_003Ed__13, AccountViewModel._003CLoginByHistory_003Ed__25>(ref this));
							awaiter = 8;
							goto IL_00e7;
						case 2:
						case 4:
						{
							object obj3 = awaiter;
							IEnumerator_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
							awaiter = IReadOnlyListMethods<IDisposable>.Abi_get_Size_1((IntPtr)obj3);
							obj2 = 16;
							continue;
						}
						default:
							__KnownINotifyPropertyChangingArgs.ShowMaxPlayer = null;
							obj2 = 17;
							continue;
						case 16:
							{
								if (IReadOnlyListMethods<object>.Abi_IndexOf_2((IntPtr)/*Error near IL_0407: Stack underflow*/, (object)/*Error near IL_0407: Stack underflow*/, ref *(uint*)(&awaiter)))
								{
									obj2 = 5;
									if (__KnownINotifyPropertyChangingArgs.Description != null)
									{
										obj2 = 4;
									}
									continue;
								}
								goto case 11;
							}
							IL_00e7:
							obj2 = awaiter;
							continue;
						}
						goto end_IL_0026;
						continue;
						end_IL_00eb:
						break;
					}
					goto IL_0213;
					IL_038f:
					if ((nint)awaiter != 1)
					{
						obj2 = 13;
						if (__KnownINotifyPropertyChangingArgs.CharacterName == null)
						{
							obj2 = 0;
						}
						goto IL_00eb;
					}
					goto IL_0213;
					IL_0213:
					awaiter = Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute;
					obj2 = 0;
					if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute != null)
					{
						obj2 = 0;
					}
					goto IL_00eb;
					end_IL_0026:
					break;
				}
				IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = -2;
				obj = 0;
				if (IReadOnlyList_System_IDisposable._initialized != 0)
				{
					obj = 0;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00䄀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778229, new IntPtr(2737336164732L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00䈀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00䌀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778226, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00䐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778227, new IntPtr(2737336161612L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00䔀()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00䘀(object? P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00䜀(object? P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778224, new IntPtr(2737336155372L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSecurity_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string method;

		public LoginWindowViewModel _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private static object? CheckOperationalList;

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
		internal static bool CheckVirtualRecord()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? DecorateIdentifiableContext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00㠀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778225, new IntPtr(2737336179292L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00㤀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0eb6: Expected Obj, but got I4
			//IL_0eb6: Expected Obj, but got Ref
			//IL_0e9e: Expected Obj, but got Ref
			//IL_0ea3: Expected Obj, but got Ref
			//IL_0e50: Expected Obj, but got Ref
			//IL_0e77: Expected Obj, but got Ref
			//IL_0060: Expected I4, but got Obj
			//IL_0b2e: Expected Obj, but got Ref
			//IL_023a: Expected Obj, but got Ref
			//IL_0843: Expected Obj, but got I4
			//IL_0546: Expected I, but got Obj
			//IL_0160: Expected I, but got Obj
			//IL_0160: Expected Obj, but got Ref
			//IL_019d: Expected Obj, but got I
			//IL_086d: Expected Obj, but got I4
			//IL_0872: Expected Obj, but got I4
			//IL_0872: Expected Obj, but got Ref
			//IL_0297: Expected Obj, but got Ref
			//IL_027e: Expected Obj, but got Ref
			//IL_0ccf: Expected Obj, but got I4
			//IL_0529: Expected Obj, but got Ref
			//IL_052e: Expected I, but got Obj
			//IL_0bd2: Expected Obj, but got Ref
			//IL_0be7: Expected Obj, but got I4
			//IL_0b68: Expected Obj, but got I4
			//IL_0b6d: Expected Obj, but got I4
			//IL_0b6d: Expected Obj, but got Ref
			//IL_014e: Expected Obj, but got I4
			//IL_0bfc: Expected Obj, but got Ref
			//IL_0215: Expected I, but got Obj
			//IL_037e: Expected Obj, but got Ref
			//IL_0d89: Expected Obj, but got I4
			//IL_028c: Expected Obj, but got I4
			//IL_09e9: Expected Obj, but got Ref
			//IL_05bf: Expected Obj, but got Ref
			//IL_0341: Expected Obj, but got I4
			//IL_041d: Expected Obj, but got Ref
			//IL_041d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0456: Expected Obj, but got I4
			//IL_045b: Expected Obj, but got I4
			//IL_045b: Expected Obj, but got Ref
			//IL_03cf: Expected Obj, but got I4
			//IL_03d4: Expected Obj, but got I4
			//IL_03d4: Expected Obj, but got Ref
			//IL_0315: Expected Obj, but got Ref
			//IL_0366: Expected Obj, but got Ref
			//IL_09b2: Expected Obj, but got Ref
			//IL_0983: Expected Obj, but got Ref
			//IL_098b: Expected Obj, but got Ref
			//IL_098b: Expected Obj, but got Ref
			//IL_0907: Expected Obj, but got I4
			//IL_090c: Expected Obj, but got I4
			//IL_090c: Expected Obj, but got Ref
			//IL_09d9: Expected Obj, but got Ref
			//IL_09c3: Expected Obj, but got Ref
			//IL_0959: Expected Obj, but got I4
			//IL_095e: Expected Obj, but got I4
			//IL_095e: Expected Obj, but got Ref
			//IL_09fb: Expected Obj, but got Ref
			//IL_09fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e7: Expected Obj, but got Ref
			//IL_06e3: Expected Obj, but got I
			//IL_066f: Expected Obj, but got I4
			//IL_0674: Expected Obj, but got I4
			//IL_0674: Expected Obj, but got Ref
			//IL_0699: Expected Obj, but got Ref
			//IL_0660: Expected Obj, but got Ref
			//IL_06ae: Expected Obj, but got I4
			//IL_06b3: Expected Obj, but got I4
			//IL_06b3: Expected Obj, but got Ref
			//IL_0d4b: Expected Obj, but got I4
			//IL_0d41: Expected Obj, but got I4
			//IL_0eca->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0ead->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0e66->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0e8d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0ed5->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0e71->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0e98->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0256->IL006e: Incompatible stack heights: 2 vs 1
			//IL_01a2->IL006e: Incompatible stack heights: 2 vs 1
			//IL_07eb->IL006e: Incompatible stack heights: 3 vs 1
			//IL_0c69->IL006e: Incompatible stack heights: 2 vs 1
			//IL_0bec->IL006a: Incompatible stack heights: 0 vs 2
			//IL_0158->IL006e: Incompatible stack heights: 5 vs 1
			//IL_0bac->IL006e: Incompatible stack heights: 3 vs 1
			//IL_0229->IL006e: Incompatible stack heights: 3 vs 1
			//IL_0261->IL006e: Incompatible stack heights: 2 vs 1
			//IL_006e->IL006e: Incompatible stack heights: 3 vs 1
			//IL_01ad->IL006e: Incompatible stack heights: 2 vs 1
			//IL_0d93->IL006e: Incompatible stack heights: 2 vs 1
			//IL_07f6->IL006e: Incompatible stack heights: 3 vs 1
			//IL_0291->IL006a: Incompatible stack heights: 0 vs 2
			//IL_0c74->IL006e: Incompatible stack heights: 2 vs 1
			//IL_0d83->IL0d83: Incompatible stack heights: 0 vs 3
			//IL_0234->IL006e: Incompatible stack heights: 3 vs 1
			//IL_0330->IL02d3: Incompatible stack heights: 2 vs 1
			//IL_099f->IL08cc: Incompatible stack heights: 3 vs 1
			//IL_064d->IL0583: Incompatible stack heights: 3 vs 1
			//IL_0603->IL0583: Incompatible stack heights: 2 vs 1
			//IL_06ed->IL0583: Incompatible stack heights: 8 vs 1
			//IL_05d7->IL0632: Incompatible stack heights: 1 vs 0
			//IL_09aa->IL08cc: Incompatible stack heights: 3 vs 1
			//IL_0658->IL0583: Incompatible stack heights: 3 vs 1
			//IL_060e->IL0583: Incompatible stack heights: 2 vs 1
			//IL_05e1->IL0583: Incompatible stack heights: 2 vs 1
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
				case 5:
				{
					int num;
					switch ((int)awaiter)
					{
					default:
						num = 40;
						goto IL_006e;
					case 2:
						num = 21;
						goto IL_006e;
					case 1:
						goto IL_07a7;
					case 0:
						goto IL_0b28;
					case 3:
						goto IL_0c85;
						IL_006e:
						while (true)
						{
							int num2;
							int num4;
							int num3;
							bool flag2;
							MainContent.XamlBindingSetters sender;
							switch (num)
							{
							case 39:
								_003CModule_003E.CheckAccessibleAttribute();
								_ = IEnumerator_object.Initialized;
								CastExtensions.As<NavigationView>((object)IEnumerator_object.Init());
								_ = 10;
								continue;
							case 9:
								IList_object._initialized = (nint)awaiter;
								num = 0;
								if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
								{
									num = 0;
								}
								continue;
							case 10:
								IEnumerator_object._002Ecctor();
								IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_018e: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_018e: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_018e: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(IEnumerator_object.DecorateAutomatableAttribute() ? 1 : 0));
								_ = 14;
								if (IReadOnlyList_object.ReflectLogicalAttribute == null)
								{
									_ = 14;
								}
								continue;
							case 8:
								MarshalInterface<INotifyPropertyChanged>.CopyManagedArray((INotifyPropertyChanged[])/*Error near IL_01e0: Stack underflow*/, (IntPtr)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)/*Error near IL_01db: Stack underflow*/, (uint*)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_01d6: Stack underflow*/, (uint)/*Error near IL_01d6: Stack underflow*/, (uint)/*Error near IL_01d6: Stack underflow*/, (nint)/*Error near IL_01d6: Stack underflow*/, (uint*)/*Error near IL_01d6: Stack underflow*/)));
								num = 18;
								continue;
							case 44:
								break;
							case 2:
								if (awaiter != null)
								{
									num = 25;
									continue;
								}
								goto case 15;
							case 46:
								IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.MoveAttribute();
								IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.CheckSymbolicAttribute());
								_ = 27;
								if (Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute != null)
								{
									_ = 41;
								}
								continue;
							default:
								_ = ref Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute;
								((AsyncTaskMethodBuilder*)(&awaiter))->Start(ref Unsafe.As<_003CSecurity_003Ed__10, AccountViewModel._003CLogoutAccount_003Ed__23>(ref this));
								_ = 3;
								if (Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute != null)
								{
									_ = 3;
								}
								continue;
							case 34:
								if (IListMethods<object>.Abi_IndexOf_3((IntPtr)/*Error near IL_0268: Stack underflow*/, (object)/*Error near IL_0268: Stack underflow*/, ref *(uint*)(&awaiter)))
								{
									num = 26;
									continue;
								}
								goto case 33;
							case 17:
							case 26:
								IListMethods<object>.Abi_SetAt_4((IntPtr)/*Error near IL_027e: Stack underflow*/, (uint)/*Error near IL_027e: Stack underflow*/, (object)(&awaiter));
								if ((int)/*Error near IL_0283: Stack underflow*/ != 0)
								{
									awaiter = 29;
									continue;
								}
								goto end_IL_004b;
							case 12:
								Unsafe.As<object, ReadOnlySpan<char>>(ref Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute) = default;
								num = 1;
								if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance == null)
								{
									num = 11;
								}
								continue;
							case 4:
								if ((nint)awaiter != 3)
								{
									num2 = 2;
									goto IL_02d3;
								}
								goto IL_0378;
							case 23:
							case 29:
								IEnumerator_System_IDisposable.Do_Abi_GetMany_3((nint)/*Error near IL_052e: Stack underflow*/, (uint)/*Error near IL_052e: Stack underflow*/, (nint)/*Error near IL_052e: Stack underflow*/, (uint*)(nint)__KnownINotifyPropertyChangingArgs.CanDelete);
								/*Error near IL_052e: Member reference must be method, but was: Field*/;
							case 7:
								IEnumerator_System_IDisposable.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_0546: Stack underflow*/, (byte*)(nint)awaiter);
								/*Error near IL_0546: Member reference must be method, but was: Field*/;
							case 42:
								if ((nint)awaiter != 1)
								{
									num4 = 5;
									goto IL_0583;
								}
								goto IL_05b9;
							case 36:
								goto IL_07a7;
							case 13:
								((Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails)/*Error near IL_07b7: Stack underflow*/)._002Ector();
								num = 22;
								continue;
							case 16:
								Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateInternalAttribute();
								((IEnumerable<EntityRentalGameItem>)(object)Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.CheckExpandableAttribute()).Select((Func<EntityRentalGameItem, DesktopGameModel>)(object)((Mass_WinUI_AppWinRTTypeDetails)awaiter).GetExposedInterfaces());
								_ = 30;
								if (__KnownINotifyPropertyChangingArgs.NetGamesEmptyText != null)
								{
									_ = 36;
								}
								continue;
							case 45:
								if (awaiter == null)
								{
									num = 31;
									continue;
								}
								goto case 7;
							case 1:
								((Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails)/*Error near IL_082e: Stack underflow*/).GetExposedInterfaces();
								((Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails)awaiter)._002Ector();
								Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.ReflectCustomAttribute();
								awaiter = 13;
								continue;
							case 6:
							{
								ComWrappers.ComInterfaceEntry[] exposedInterfaces = ((Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails)(object)Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.CheckAdvancedAttribute()).GetExposedInterfaces();
								((Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails)awaiter)._002Ector();
								((AsyncTaskMethodBuilder*)/*Error near IL_085e: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)/*Error near IL_085e: Stack underflow*/, ref *(DesktopViewModel._003CStartProxy_003Ed__2*)exposedInterfaces);
								num = 44;
								continue;
							}
							case 11:
								awaiter = -1;
								__KnownINotifyPropertyChangingArgs.SkinOwnedSelected = (PropertyChangingEventArgs)(-1);
								num = 17;
								continue;
							case 21:
								if ((nint)awaiter != 2)
								{
									num3 = 1;
									if (__KnownINotifyPropertyChangingArgs.SelectedPageOfSkin != null)
									{
										num3 = 0;
									}
									goto IL_08cc;
								}
								goto IL_09e3;
							case 37:
								((App)/*Error near IL_0b14: Stack underflow*/).Window = (Window?)awaiter;
								((AppWindowClosingEventArgs)/*Error near IL_0b19: Stack underflow*/).Cancel = (byte)/*Error near IL_0b19: Stack underflow*/ != 0;
								if ((int)/*Error near IL_0b1e: Stack underflow*/ != 0)
								{
									num = 43;
									continue;
								}
								goto case 32;
							case 5:
								goto IL_0b28;
							case 20:
								((App)/*Error near IL_0b41: Stack underflow*/).SetAppRequestTheme((ElementTheme)awaiter);
								Application.LoadComponent((object)/*Error near IL_0b46: Stack underflow*/, (Uri)/*Error near IL_0b46: Stack underflow*/);
								awaiter = (object)/*Error near IL_0b48: Stack underflow*/;
								num = 34;
								continue;
							case 47:
								if (awaiter != null)
								{
									num = 30;
									continue;
								}
								goto case 37;
							case 33:
								awaiter = 0;
								__KnownINotifyPropertyChangingArgs.Earnings = (PropertyChangingEventArgs)0;
								num = 1;
								if (__KnownINotifyPropertyChangingArgs.RedeemOptions == null)
								{
									num = 9;
								}
								continue;
							case 41:
								((App)/*Error near IL_0b96: Stack underflow*/).AppClosing((byte)/*Error near IL_0b96: Stack underflow*/ != 0, (AppWindow)/*Error near IL_0b96: Stack underflow*/, (AppWindowClosingEventArgs)__KnownINotifyPropertyChangingArgs.SerializeAttribute);
								((App)/*Error near IL_0b9b: Stack underflow*/).InitializeComponent();
								_ = null;
								_ = ((App)null)._AppProvider;
								_ = 38;
								continue;
							case 31:
								if (awaiter == null)
								{
									num = 46;
									continue;
								}
								goto case 7;
							case 28:
								awaiter = ((MassIrcService)(object)((App)/*Error near IL_0bd7: Stack underflow*/).GetXamlType((string)(object)__KnownINotifyPropertyChangedArgs.CreateAt)).DisconnectAsync();
								awaiter = 45;
								continue;
							case 40:
								App._002Ecctor();
								(App.CheckEditableMonitor() ? ((AsyncTaskMethodBuilder*)1) : ((AsyncTaskMethodBuilder*)null))->Start(ref *(PaymentViewModel._003CRedeemCode_003Ed__97*)__KnownINotifyPropertyChangedArgs.CharacterName);
								num = 8;
								if (__KnownINotifyPropertyChangedArgs.IsSkeleton == null)
								{
									num = 20;
								}
								continue;
							case 3:
								return;
							case 18:
								((MainContent)/*Error near IL_0c49: Stack underflow*/).InitializeComponent();
								((MainContent)/*Error near IL_0c50: Stack underflow*/).Connect((int)/*Error near IL_0c50: Stack underflow*/, awaiter);
								((MainContent)/*Error near IL_0c55: Stack underflow*/).GetBindingConnector((int)/*Error near IL_0c55: Stack underflow*/, (object)/*Error near IL_0c55: Stack underflow*/);
								_ = 1;
								if (__KnownINotifyPropertyChangedArgs.Version == null)
								{
									_ = 1;
								}
								continue;
							case 32:
								if (awaiter != null)
								{
									num = 16;
									continue;
								}
								goto case 6;
							case 14:
								goto IL_0c85;
							case 27:
								goto IL_0ca5;
							case 22:
								((MainContent.IMainContent_BindingsScopeConnector)/*Error near IL_0ccf: Stack underflow*/).RegisterForElementConnection((int)/*Error near IL_0ccf: Stack underflow*/, (IComponentConnector)(object)((MainContent.IMainContent_BindingsScopeConnector)/*Error near IL_0cca: Stack underflow*/).ContainsElement((int)/*Error near IL_0cca: Stack underflow*/));
								num = 35;
								continue;
							case 15:
								_ = __KnownINotifyPropertyChangedArgs.Executor;
								flag2 = MainContent.XamlBindingSetters.CheckVisualCalculator();
								sender = MainContent.XamlBindingSetters.ReflectScopeDictionary();
								goto IL_0d83;
							case 30:
							case 43:
							{
								((MainContent.MainContent_obj1_Bindings)/*Error near IL_0d06: Stack underflow*/)._002Ector();
								((MainContent.MainContent_obj1_Bindings)/*Error near IL_0d0b: Stack underflow*/).Connect((int)/*Error near IL_0d0b: Stack underflow*/, (object)/*Error near IL_0d0b: Stack underflow*/);
								IComponentConnector bindingConnector = ((MainContent.MainContent_obj1_Bindings)/*Error near IL_0d10: Stack underflow*/).GetBindingConnector((int)/*Error near IL_0d10: Stack underflow*/, (object)/*Error near IL_0d10: Stack underflow*/);
								if (awaiter == null)
								{
									((MainContent.MainContent_obj1_Bindings)(object)bindingConnector).Initialize();
								}
								else
								{
									((MainContent.MainContent_obj1_Bindings)(object)bindingConnector).Update();
								}
								((MainContent.MainContent_obj1_Bindings)/*Error near IL_0d2b: Stack underflow*/).StopTracking();
								((TypedEventHandler<AppWindow, AppWindowClosingEventArgs>)/*Error near IL_0d30: Stack underflow*/)._002Ector((object)/*Error near IL_0d30: Stack underflow*/, (IntPtr)/*Error near IL_0d30: Stack underflow*/);
								bool flag = ((MainContent.MainContent_obj1_Bindings)/*Error near IL_0d35: Stack underflow*/).SetDataRoot((object)/*Error near IL_0d35: Stack underflow*/);
								if (awaiter == null)
								{
									((MainContent.MainContent_obj1_Bindings)/*Error near IL_0d41: Stack underflow*/).Activated((object)/*Error near IL_0d41: Stack underflow*/, (WindowActivatedEventArgs)(object)flag);
								}
								else
								{
									((MainContent.MainContent_obj1_Bindings)/*Error near IL_0d4b: Stack underflow*/).Loading((FrameworkElement)/*Error near IL_0d4b: Stack underflow*/, (object)flag);
								}
								((AsyncVoidMethodBuilder*)/*Error near IL_0d55: Stack underflow*/)->Start(ref *(((DispatcherQueue)/*Error near IL_0d50: Stack underflow*/).TryEnqueue((DispatcherQueuePriority)/*Error near IL_0d50: Stack underflow*/, (DispatcherQueueHandler)/*Error near IL_0d50: Stack underflow*/) ? ((Desktop._003CWebView2Loaded_003Ed__9*)1) : ((Desktop._003CWebView2Loaded_003Ed__9*)null)));
								num = 2;
								if (__KnownINotifyPropertyChangedArgs.Image == null)
								{
									num = 2;
								}
								continue;
							}
							case 25:
								((MainWindow)(object)__KnownINotifyPropertyChangedArgs.DisplayName).SwitchToMainMode();
								((MainWindow)/*Error near IL_0d83: Stack underflow*/).UpdateTitleBarPreferredTheme((FrameworkElement)/*Error near IL_0d83: Stack underflow*/);
								goto IL_0d83;
							case 19:
							case 24:
							case 35:
							case 38:
								goto end_IL_004b;
								IL_0378:
								awaiter = __KnownINotifyPropertyChangingArgs.LoginAt;
								num2 = 3;
								if (__KnownINotifyPropertyChangingArgs.IsMyself != null)
								{
									num2 = 3;
								}
								goto IL_02d3;
								IL_02d3:
								while (true)
								{
									switch (num2)
									{
									case 9:
										break;
									case 10:
										_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute = awaiter;
										num2 = 11;
										continue;
									default:
										IListMethods<object>.Abi_GetMany_10((IntPtr)/*Error near IL_0326: Stack underflow*/, (uint)/*Error near IL_0326: Stack underflow*/, ref *(object[]*)(&awaiter));
										_ = 9;
										continue;
									case 2:
										IListMethods<object>.Abi_ReplaceAll_11((IntPtr)/*Error near IL_0335: Stack underflow*/, (object[])/*Error near IL_0335: Stack underflow*/);
										awaiter = IEnumeratorMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, nint*, int>)/*Error near IL_033f: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)/*Error near IL_033f: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)/*Error near IL_033f: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, uint*, int>)(int)IListMethods<object>.Abi_get_Size_1((IntPtr)/*Error near IL_033a: Stack underflow*/));
										num2 = 0;
										if (__KnownINotifyPropertyChangingArgs.UserId == null)
										{
											num2 = 7;
										}
										continue;
									case 11:
										Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.Username).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<string>*)(&awaiter), ref Unsafe.As<_003CSecurity_003Ed__10, AccountViewModel._003CExportAccounts_003Ed__26>(ref this));
										num2 = 8;
										continue;
									case 1:
										goto IL_0378;
									case 7:
										if (MarshalInterface<IDisposable>.FromAbi((IntPtr)(nint)(&awaiter)) != null)
										{
											num2 = 2;
											if (__KnownINotifyPropertyChangingArgs.Content == null)
											{
												num2 = 4;
											}
											continue;
										}
										goto case 5;
									case 6:
										awaiter = -1;
										__KnownINotifyPropertyChangingArgs.IsSelected = (PropertyChangingEventArgs)(-1);
										num2 = 0;
										if (__KnownINotifyPropertyChangingArgs.CanProxy == null)
										{
											num2 = 0;
										}
										continue;
									case 8:
										return;
									case 3:
										__KnownINotifyPropertyChangingArgs.MaxPlayers = (PropertyChangingEventArgs)default(IAnimationObjectMethods);
										num2 = 6;
										if (__KnownINotifyPropertyChangingArgs.Version == null)
										{
											num2 = 5;
										}
										continue;
									case 5:
										awaiter = 3;
										__KnownINotifyPropertyChangingArgs.ImageUrl = (PropertyChangingEventArgs)3;
										num2 = 10;
										continue;
									}
									break;
								}
								goto case 8;
								IL_0d83:
								((MainWindow)flag2).AppWindowClosing((object)sender, (object)null);
								_ = 19;
								continue;
								IL_09e3:
								awaiter = __KnownINotifyPropertyChangingArgs.IsLoading;
								num3 = 10;
								goto IL_08cc;
								IL_08cc:
								while (true)
								{
									switch (num3)
									{
									case 2:
										break;
									case 6:
										awaiter = -1;
										__KnownINotifyPropertyChangingArgs.SearchText = (PropertyChangingEventArgs)(-1);
										num3 = 7;
										continue;
									case 1:
										/*Error near IL_0916: Member reference must be method, but was: Field*/;
									case 9:
										awaiter = 2;
										__KnownINotifyPropertyChangingArgs.ExpirationTimeText = (PropertyChangingEventArgs)2;
										num3 = 3;
										if (__KnownINotifyPropertyChangingArgs.RegistrationTimeText != null)
										{
											num3 = 3;
										}
										continue;
									case 5:
										_ = ref __KnownINotifyPropertyChangingArgs.SelectedCategoryIndex;
										((IEnumerable<GameInstance>)(&awaiter)).Select((Func<GameInstance, GameInstanceModel>)Unsafe.AsPointer(ref this));
										_ = 3;
										if (__KnownINotifyPropertyChangingArgs.InputPassword == null)
										{
											_ = 4;
										}
										continue;
									case 3:
										__KnownINotifyPropertyChangingArgs.InputInviteCode = (PropertyChangingEventArgs)awaiter;
										num3 = 5;
										continue;
									case 8:
										((PropertyChangingEventArgs)/*Error near IL_09c3: Stack underflow*/)._002Ector((string?)(&awaiter));
										if ((int)/*Error near IL_09c8: Stack underflow*/ == 0)
										{
											num3 = 9;
											continue;
										}
										goto case 7;
									case 7:
										((PropertyChangedEventArgs)/*Error near IL_09d9: Stack underflow*/)._002Ector((string?)(&awaiter));
										num3 = 2;
										continue;
									default:
										goto IL_09e3;
									case 10:
										__KnownINotifyPropertyChangingArgs.ShowTabs = (PropertyChangingEventArgs)default(SortDirection);
										num3 = 5;
										if (__KnownINotifyPropertyChangingArgs.ShopDescription == null)
										{
											num3 = 6;
										}
										continue;
									case 4:
										return;
									}
									break;
								}
								goto case 39;
								IL_05b9:
								awaiter = __KnownINotifyPropertyChangingArgs.Number;
								num4 = 7;
								goto IL_0583;
								IL_0583:
								while (true)
								{
									switch (num4)
									{
									default:
										return;
									case 4:
										break;
									case 10:
										_ = ref awaiter;
										if (IListMethods.AbiToProjectionVftablePtr == (IntPtr)0)
										{
											_ = 9;
											continue;
										}
										goto case 1;
									case 3:
										_ = ref __KnownINotifyPropertyChangingArgs.Image;
										((AsyncTaskMethodBuilder*)(&awaiter))->Start(ref Unsafe.As<_003CSecurity_003Ed__10, DesktopViewModel._003CLaunchShadowClient_003Ed__5>(ref this));
										_ = 0;
										if (__KnownINotifyPropertyChangingArgs.TotalCoins == null)
										{
											_ = 0;
										}
										continue;
									case 0:
										return;
									case 1:
										_ = ref awaiter;
										_ = IListMethods<object>.IID;
										_ = 0;
										if (__KnownINotifyPropertyChangingArgs.DesktopAccounts == null)
										{
											_ = 2;
										}
										continue;
									case 8:
										__KnownINotifyPropertyChangingArgs.MobileAccounts = (PropertyChangingEventArgs)awaiter;
										num4 = 3;
										continue;
									case 6:
										awaiter = -1;
										__KnownINotifyPropertyChangingArgs.SelectedAccounts = (PropertyChangingEventArgs)(-1);
										num4 = 1;
										if (__KnownINotifyPropertyChangingArgs.SelectedIndex == null)
										{
											num4 = 1;
										}
										continue;
									case 7:
										__KnownINotifyPropertyChangingArgs.Input4399Username = null;
										num4 = 6;
										continue;
									case 9:
										awaiter = 1;
										__KnownINotifyPropertyChangingArgs.InputCookie = (PropertyChangingEventArgs)1;
										num4 = 8;
										continue;
									case 5:
										_ = IEnumeratorMethods<object>.IID;
										Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.DecorateGeneralAttribute();
										Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.NewAttribute();
										((Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails)awaiter).GetExposedInterfaces();
										_ = IEnumerableMethods<IDisposable>.IID;
										awaiter = (nint)IEnumerableMethods<IDisposable>.AbiToProjectionVftablePtr;
										_ = 10;
										continue;
									case 2:
										goto IL_0ca5;
									}
									break;
								}
								goto IL_05b9;
								IL_0ca5:
								((MainContent.IMainContent_Bindings)/*Error near IL_0caa: Stack underflow*/).StopTracking();
								((MainContent.IMainContent_Bindings)/*Error near IL_0caf: Stack underflow*/).DisconnectUnloadedObject((int)/*Error near IL_0caf: Stack underflow*/);
								((AsyncTaskMethodBuilder*)/*Error near IL_0cbb: Stack underflow*/)->Start(ref *(ReferralViewModel._003CRedeemPoints_003Ed__52*)((MainContent.IMainContent_BindingsScopeConnector)awaiter).Parent);
								num = 6;
								continue;
							}
							break;
						}
						goto case 2;
						IL_0c85:
						num = 4;
						if (__KnownINotifyPropertyChangedArgs.Characters != null)
						{
							num = 4;
						}
						goto IL_006e;
						IL_0b28:
						awaiter = __KnownINotifyPropertyChangingArgs.InviteUrl;
						num = 12;
						goto IL_006e;
						IL_07a7:
						num = 42;
						goto IL_006e;
						end_IL_004b:
						break;
					}
					break;
				}
				case 3:
					awaiter = __KnownINotifyPropertyChangedArgs.Input4399Password;
					obj = 0;
					if (__KnownINotifyPropertyChangedArgs.InputMobilePassword != null)
					{
						obj = 5;
					}
					continue;
				case 4:
					awaiter = __KnownINotifyPropertyChangedArgs.InputMobile;
					obj = 3;
					if (__KnownINotifyPropertyChangedArgs.VerifyCodeDelayText != null)
					{
						obj = 2;
					}
					continue;
				case 1:
					string.IsNullOrEmpty((string?)Unsafe.AsPointer(ref __KnownINotifyPropertyChangedArgs.InfoBarMessage));
					_ = 2;
					continue;
				case 2:
					return;
				}
				__KnownINotifyPropertyChangedArgs.InfoBarIsOpen = (PropertyChangedEventArgs)(-2);
				obj = 1;
				if (__KnownINotifyPropertyChangedArgs.Step == null)
				{
					obj = 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00㨀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778238, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00㬀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00㰀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778239, new IntPtr(2737336166812L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00㴀()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00㸀(object? P_0)
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

	private nint _initialized;

	private readonly Task<bool> _initializeTask;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<string>? securityCommand;

	private static object? CheckScalableSorter;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public string? InputUsername
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string?)_FF00_FF00䴀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00㜀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public string? InputPassword
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string?)_FF00_FF00㐀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00䔀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public string? InputInviteCode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string?)_FF00_FF00䀀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00㨀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<string> SecurityCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00䬀();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe LoginWindowViewModel()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_01db: Expected Obj, but got I4
		//IL_008a: Expected I, but got Obj
		//IL_0094: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I
		//IL_013c: Expected I, but got Obj
		//IL_013c: Expected Obj, but got I4
		//IL_0232: Expected I, but got Obj
		//IL_012b: Expected I, but got Obj
		//IL_012b: Expected I, but got Obj
		//IL_0180: Expected I, but got Obj
		//IL_0180: Expected I, but got Obj
		//IL_0185: Expected Obj, but got I4
		//IL_0185: Expected Obj, but got I4
		//IL_01b0: Expected Obj, but got I4
		//IL_021b: Expected Obj, but got I4
		//IL_01d4: Expected I, but got Obj
		//IL_01db: Expected Obj, but got I4
		//IL_008a: Expected I, but got Obj
		//IL_008a: Expected I, but got Obj
		//IL_0094: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I
		//IL_013c: Expected I, but got Obj
		//IL_0232: Expected I, but got Obj
		//IL_01ea: Expected I, but got Obj
		//IL_012b: Expected I, but got Obj
		//IL_012b: Expected I, but got Obj
		//IL_0180: Expected I, but got Obj
		//IL_0180: Expected I, but got Obj
		//IL_0185: Expected Obj, but got I4
		//IL_01b0: Expected Obj, but got I4
		//IL_0207: Expected I, but got Obj
		//IL_002e->IL0042: Incompatible stack types: I4 vs Obj
		//IL_0039->IL0042: Incompatible stack types: I4 vs Obj
		//IL_01e5->IL0042: Incompatible stack heights: 1 vs 2
		//IL_0141->IL00b3: Incompatible stack heights: 0 vs 1
		//IL_0200->IL0042: Incompatible stack heights: 1 vs 2
		//IL_0135->IL0042: Incompatible stack heights: 3 vs 2
		//IL_0199->IL0042: Incompatible stack heights: 1 vs 2
		//IL_00d0->IL0042: Incompatible stack heights: 5 vs 2
		//IL_01c4->IL0042: Incompatible stack heights: 3 vs 2
		//IL_016f->IL00b3: Incompatible stack heights: 2 vs 1
		//IL_020c->IL0135: Incompatible stack heights: 0 vs 1
		//IL_0155->IL0042: Incompatible stack heights: 1 vs 2
		//IL_01a4->IL0042: Incompatible stack heights: 1 vs 2
		//IL_00db->IL0042: Incompatible stack heights: 5 vs 2
		//IL_01cf->IL0042: Incompatible stack heights: 3 vs 2
		//IL_0179->IL0042: Incompatible stack heights: 3 vs 2
		//IL_0220->IL0042: Incompatible stack heights: 1 vs 2
		//IL_0160->IL0042: Incompatible stack heights: 1 vs 2
		//IL_022b->IL0042: Incompatible stack heights: 1 vs 2
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		int hRForException = ExceptionHelpers.GetHRForException((Exception)(object)this);
		int num = 11;
		object[] array = (object[])hRForException;
		if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
		{
			num = 7;
			array = (object[])hRForException;
		}
		object obj = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				array = MarshalInspectable<object>.FromAbiArray((object)IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_008f: Stack underflow*/, (uint)/*Error near IL_008f: Stack underflow*/, (nint)/*Error near IL_008f: Stack underflow*/, (uint*)(int)IEnumerator_object.Do_Abi_MoveNext_2((nint)array, (byte*)(nint)this)));
				num = 5;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
				{
					num = 7;
				}
				break;
			case 2:
				return;
			case 7:
				return;
			case 10:
				IEnumerator_object.DecorateAutomatableAttribute();
				_ = 9;
				if (IReadOnlyList_object._initialized == 0)
				{
					_ = 2;
				}
				break;
			case 8:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)this, (uint*)(nint)obj);
				_ = 10;
				break;
			case 3:
				MarshalInterface<INotifyPropertyChanged>.CopyManagedArray((INotifyPropertyChanged[])array, (IntPtr)obj);
				if ((int)/*Error near IL_0141: Stack underflow*/ != 0)
				{
					return;
				}
				_ = 1;
				if (GlobalVtableLookup.CreateAttribute != null)
				{
					_ = 1;
				}
				break;
			case 12:
				_ = IEnumerable_System_ComponentModel_INotifyPropertyChanged.Initialized;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.Init() == 0)
				{
					return;
				}
				_ = 13;
				break;
			case 4:
			case 9:
				Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute = IEnumerable_System_ComponentModel_INotifyPropertyChanged.Do_Abi_First_0((nint)this, (nint*)(nint)this);
				_ = 1;
				if (Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute == null)
				{
					_ = 12;
				}
				break;
			case 11:
				_ = IList_object.Initialized;
				obj = IList_object.Init();
				_ = 0;
				if (Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute != null)
				{
					_ = 0;
				}
				break;
			default:
				obj = IList_object.Do_Abi_SetAt_4((nint)/*Error near IL_01d9: Stack underflow*/, (uint)/*Error near IL_01d9: Stack underflow*/, (nint)(int)IList_object.Do_Abi_IndexOf_3((nint)/*Error near IL_01d4: Stack underflow*/, (nint)/*Error near IL_01d4: Stack underflow*/, (uint*)/*Error near IL_01d4: Stack underflow*/, (byte*)(nint)array));
				_ = 5;
				break;
			case 6:
				((AsyncTaskMethodBuilder*)IList_object.Do_Abi_RemoveAt_6((nint)/*Error near IL_01ef: Stack underflow*/, IList_object.Do_Abi_InsertAt_5((nint)/*Error near IL_01ea: Stack underflow*/, (uint)/*Error near IL_01ea: Stack underflow*/, (nint)array)))->Start(ref *(AccountViewModel._003CLoginRandom_003Ed__85*)obj);
				_ = 8;
				break;
			case 13:
				IListMethods<object>.Abi_ReplaceAll_11((IntPtr)array, (object[])obj);
				if ((int)/*Error near IL_020c: Stack underflow*/ != 0)
				{
					_ = 2;
					if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator == null)
					{
						_ = 1;
					}
					break;
				}
				goto case 3;
			case 5:
				if (IEnumeratorMethods<INotifyPropertyChanged>.Abi_MoveNext_2((IntPtr)obj))
				{
					num = 4;
					break;
				}
				goto case 6;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CSecurity_003Ed__10))]
	private object Security(object method)
	{
		return _FF00_FF00㴀(method);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitialize_003Ed__13))]
	private Task<bool> Initialize()
	{
		return _FF00_FF00䠀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInit_003Ed__14))]
	private Task<bool> Init()
	{
		return _FF00_FF00䘀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DirectPublisher()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LoginWindowViewModel? NewTransformer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _FF00_FF00_3300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778138, new IntPtr(2737335815772L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _FF00_FF00㐀()
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
	internal unsafe object? _FF00_FF00㔀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778139, new IntPtr(2737335818892L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00㘀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778136, new IntPtr(2737335803292L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00㜀(object? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0073: Expected Obj, but got I
		//IL_004f: Expected I, but got Obj
		//IL_008b: Expected I, but got Obj
		//IL_0078->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c0->IL0083: Incompatible stack heights: 2 vs 0
		//IL_009f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0083->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ca->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00aa->IL0026: Incompatible stack types: I4 vs Obj
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
			case 2:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 4;
				break;
			case 1:
				/*Error near IL_0064: Stack underflow*/((object[])(object)this, IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized);
				obj2 = 0;
				if (IList_object.PatchAttribute != null)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			case 4:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 1;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_00af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_00af: Stack underflow*/);
				_ = IReadOnlyList_object._initialized;
				if (MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)P_0) != (IntPtr)0)
				{
					return;
				}
				_ = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00㠀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778137, new IntPtr(2737335803292L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00㤀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00㨀(object? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_00af: Expected I4, but got Obj
		//IL_00af: Expected I, but got Obj
		//IL_0085: Expected I, but got Obj
		//IL_00e9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c3->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0099->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00f4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ce->IL0026: Incompatible stack heights: 2 vs 1
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
			default:
				return;
			case 3:
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_0049: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0050: Member reference must be method, but was: Field*/;
			case 0:
				return;
			case 4:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
				_ = 0;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)this, (uint)(int)IReadOnlyList_System_IDisposable.ReflectConnectedAttribute);
				_ = 1;
				if (IEnumerator_System_IDisposable._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 1:
				IEnumerator_System_IDisposable.ReflectTransferableAttribute = P_0;
				obj2 = 0;
				if (IEnumerable_System_IDisposable.CombineAttribute != null)
				{
					obj2 = 4;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00㬀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778214, new IntPtr(2737335803292L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? _FF00_FF00㰀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778215, new IntPtr(2737335815772L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? _FF00_FF00㴀(object? P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17877, 1790778212, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778212, new IntPtr(2737335803292L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? _FF00_FF00㸀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778213, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _FF00_FF00㼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778210, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _FF00_FF00䀀()
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
	internal unsafe static object? _FF00_FF00䄀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778211, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? _FF00_FF00䈀()
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
	internal unsafe static object? _FF00_FF00䌀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778208, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00䐀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778209, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00䔀(object? P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I
		//IL_0093: Expected I, but got Obj
		//IL_0063: Expected I, but got Obj
		//IL_0072: Expected Obj, but got I
		//IL_00e1->IL0022: Incompatible stack heights: 2 vs 0
		//IL_00bd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0098->IL0058: Incompatible stack heights: 1 vs 0
		//IL_0077->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a2->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0082->IL0026: Incompatible stack heights: 2 vs 1
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
				case 2:
					return;
				case 4:
					return;
				case 5:
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
					_ = 1;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
					{
						_ = 1;
					}
					continue;
				case 3:
					*((int, nint)*)(nint)/*Error near IL_0087: Stack underflow*/ = ((int)/*Error near IL_0087: Stack underflow*/, (nint)/*Error near IL_0087: Stack underflow*/);
					_ = IList_object.PatchAttribute;
					if (IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)P_0) != null)
					{
						_ = 2;
						continue;
					}
					goto case 5;
				case 1:
					IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute = P_0;
					obj2 = 0;
					if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			}
			MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<bool>? _FF00_FF00䘀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17886, 1790778222, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778222, new IntPtr(2737335815772L), 15);
		}
		return (Task<bool>?)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<bool>? _FF00_FF00䜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778223, new IntPtr(2737335818892L), 15))(null, 0, new IntPtr(0L));
		return (Task<bool>?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<bool>? _FF00_FF00䠀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17888, 1790778220, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778220, new IntPtr(2737335809532L), 15);
		}
		return (Task<bool>?)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<string?>? _FF00_FF00䨀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778221, new IntPtr(2737335818892L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<string?>?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<string?>? _FF00_FF00䬀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17891, 1790778218, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778218, new IntPtr(2737335818892L), 15);
		}
		return (IAsyncRelayCommand<string?>?)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<string?>? _FF00_FF00䰀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778219, new IntPtr(2737336180332L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<string?>?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _FF00_FF00䴀()
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
	internal unsafe object? _FF00_FF00一()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778216, new IntPtr(2737336155372L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}
}
