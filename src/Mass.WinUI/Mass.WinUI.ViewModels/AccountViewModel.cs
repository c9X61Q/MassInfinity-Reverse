using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mass.Application.Desktop;
using Mass.Application.Mobile;
using Mass.WinUI.Enums;
using Mass.WinUI.Helpers;
using Mass.WinUI.Models;
using Microsoft.UI.Xaml.Controls;
using WinRT;
using WinRT.Mass_WinUIVtableClasses;

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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_005a: Expected Obj, but got Ref
			//IL_019e: Expected Obj, but got Ref
			//IL_0162: Expected Obj, but got I4
			//IL_0108: Expected Obj, but got I4
			//IL_0190: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0066->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0244->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0056->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0071->IL0019: Incompatible stack types: I4 vs Ref
			//IL_01a8->IL0094: Incompatible stack types: I4 vs Ref
			//IL_0085->IL0094: Incompatible stack heights: 0 vs 1
			//IL_025e->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0090->IL0094: Incompatible stack types: I4 vs Ref
			//IL_016d->IL0094: Incompatible stack heights: 3 vs 1
			//IL_00f8->IL0094: Incompatible stack heights: 0 vs 1
			//IL_0113->IL0094: Incompatible stack heights: 3 vs 1
			//IL_0121->IL0094: Incompatible stack heights: 3 vs 1
			//IL_019a->IL0094: Incompatible stack heights: 2 vs 1
			//IL_0133->IL0094: Incompatible stack heights: 3 vs 1
			//IL_0152->IL0094: Incompatible stack heights: 0 vs 1
			//IL_0103->IL0094: Incompatible stack types: I4 vs Ref
			//IL_00e8->IL0094: Incompatible stack types: I4 vs Ref
			//IL_013e->IL0094: Incompatible stack heights: 3 vs 1
			//IL_015d->IL0094: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			ref _003CCreateAccount_003Ed__21 reference = ref *(_003CCreateAccount_003Ed__21*)obj;
			while (true)
			{
				ref _003CCreateAccount_003Ed__21 reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 != 0)
					{
						reference = ref *(_003CCreateAccount_003Ed__21*)1;
					}
					break;
				case 1u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						reference = ref *(_003CCreateAccount_003Ed__21*)null;
					}
					break;
				case 2u:
					if (obj != null)
					{
						if (4 == 0)
						{
							reference2 = ref *(_003CCreateAccount_003Ed__21*)10;
						}
						goto IL_0094;
					}
					goto IL_019a;
				case 3u:
					return;
				case 5u:
					goto IL_0236;
				case 4u:
					{
						reference = ref this;
						if (false)
						{
							reference = ref *(_003CCreateAccount_003Ed__21*)3;
						}
						break;
					}
					IL_0236:
					_ = -2;
					_ = 4;
					break;
					IL_019a:
					obj = (object)Unsafe.AsPointer(ref this);
					reference2 = ref *(_003CCreateAccount_003Ed__21*)4;
					goto IL_0094;
					IL_0094:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						default:
							return;
						case 4u:
							reference2 = ref this;
							if (1 == 0)
							{
								reference2 = ref *(_003CCreateAccount_003Ed__21*)1;
							}
							continue;
						case 3u:
						case 6u:
							_ = ref obj;
							if (5 == 0)
							{
								reference2 = ref *(_003CCreateAccount_003Ed__21*)8;
							}
							continue;
						case 5u:
							obj = 0;
							_ = 7;
							continue;
						case 7u:
							_ = 11;
							continue;
						case 11u:
							_ = ref obj;
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 2u:
							if (&obj != null)
							{
								if (6 == 0)
								{
									reference2 = ref *(_003CCreateAccount_003Ed__21*)4;
								}
								continue;
							}
							goto case 5u;
						case 1u:
							obj = -1;
							_ = 3;
							continue;
						case 10u:
							obj = 0;
							_ = 2;
							continue;
						case 9u:
							break;
						case 0u:
							return;
						case 8u:
							goto IL_0236;
						}
						break;
					}
					goto IL_019a;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_F300()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00_F400()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777734, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? _FF00_FF00_FF00_FF00_FF00_FF00_F500()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object?)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00_F600()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777735, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_F700(object? P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (0 == 0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_003c: Expected Obj, but got Ref
			//IL_0192: Expected Obj, but got Ref
			//IL_0195: Expected Obj, but got Ref
			//IL_01c0: Expected Obj, but got I4
			//IL_00e3: Expected Obj, but got Ref
			//IL_021d: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0048->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0061->IL0019: Incompatible stack heights: 3 vs 1
			//IL_008d->IL0091: Incompatible stack heights: 1 vs 0
			//IL_0053->IL0019: Incompatible stack types: I4 vs Ref
			//IL_007b->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0209->IL0091: Incompatible stack heights: 1 vs 0
			//IL_011b->IL0091: Incompatible stack heights: 1 vs 0
			//IL_0153->IL0091: Incompatible stack heights: 3 vs 0
			//IL_01cb->IL0091: Incompatible stack heights: 3 vs 0
			//IL_0136->IL0091: Incompatible stack heights: 2 vs 0
			//IL_0228->IL0091: Incompatible stack heights: 3 vs 0
			//IL_01bb->IL0091: Incompatible stack heights: 3 vs 0
			//IL_0126->IL0091: Incompatible stack heights: 1 vs 0
			//IL_018b->IL0091: Incompatible stack heights: 1 vs 0
			//IL_01ac->IL0091: Incompatible stack heights: 1 vs 0
			//IL_015e->IL0091: Incompatible stack heights: 3 vs 0
			//IL_010c->IL0091: Incompatible stack heights: 1 vs 0
			//IL_00fa->IL0091: Incompatible stack heights: 1 vs 0
			//IL_0141->IL0091: Incompatible stack heights: 2 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			ref _003CEditAccount_003Ed__22 reference = ref *(_003CEditAccount_003Ed__22*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 0u:
					return;
				case 2u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						reference = ref *(_003CEditAccount_003Ed__22*)1;
					}
					break;
				case 3u:
					_ = -2;
					_ = 4;
					break;
				case 4u:
					reference = ref this;
					if (0 == 0)
					{
						reference = ref *(_003CEditAccount_003Ed__22*)null;
					}
					break;
				case 1u:
					{
						if (obj == null)
						{
							_ = 10;
							goto IL_0091;
						}
						goto IL_01e7;
					}
					IL_01e7:
					obj = (object)/*Error near IL_01f2: Stack underflow*/;
					if (7 != 0)
					{
						_ = 1;
					}
					goto IL_0091;
					IL_0091:
					while (true)
					{
						switch ((int)/*Error near IL_00da: Stack underflow*/)
						{
						case 12:
							return;
						case 13:
						case 16:
							break;
						case 8:
						case 10:
							obj = (object)Unsafe.AsPointer(ref this);
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 7:
							if (&obj != null)
							{
								_ = 6;
								continue;
							}
							goto case 11;
						default:
							if (4 == 0)
							{
								_ = 1;
							}
							continue;
						case 9:
							if (3 == 0)
							{
								_ = 3;
							}
							continue;
						case 3:
							_ = ref obj;
							if (11 == 0)
							{
								_ = 12;
							}
							continue;
						case 1:
							if (obj != null)
							{
								_ = 15;
								continue;
							}
							break;
						case 2:
						case 6:
							obj = (object)(&obj);
							obj = (object)(&obj);
							if (0 == 0)
							{
								_ = 1;
							}
							continue;
						case 14:
						case 15:
							_ = 13;
							continue;
						case 4:
							obj = -1;
							_ = 2;
							continue;
						case 5:
							goto IL_01e7;
						case 11:
							obj = 0;
							_ = 9;
							continue;
						}
						break;
					}
					goto case 3u;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_EC00()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00_ED00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777731, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? _FF00_FF00_FF00_FF00_FF00_FF00_EE00()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object?)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_EF00(object? P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (false)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_04b5: Expected Obj, but got Ref
			//IL_048c: Expected Obj, but got Ref
			//IL_02ed: Expected Obj, but got Ref
			//IL_0168: Expected Obj, but got I4
			//IL_01d3: Expected Obj, but got I4
			//IL_01c4: Expected Obj, but got Ref
			//IL_02a7: Expected Obj, but got I4
			//IL_0223: Expected Obj, but got Ref
			//IL_0297: Expected Obj, but got I4
			//IL_021a: Expected Obj, but got I4
			//IL_0488->IL0019: Incompatible stack heights: 2 vs 1
			//IL_04a6->IL0019: Incompatible stack heights: 2 vs 1
			//IL_04c1->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0496->IL0019: Incompatible stack types: I4 vs Obj
			//IL_04b1->IL0019: Incompatible stack heights: 2 vs 1
			//IL_04cc->IL0019: Incompatible stack types: I4 vs Obj
			//IL_004f->IL0053: Incompatible stack heights: 1 vs 0
			//IL_00c9->IL0053: Incompatible stack heights: 1 vs 0
			//IL_0095->IL0053: Incompatible stack heights: 1 vs 0
			//IL_0192->IL00ec: Incompatible stack heights: 1 vs 0
			//IL_00e8->IL00ec: Incompatible stack heights: 1 vs 0
			//IL_0304->IL00ec: Incompatible stack heights: 1 vs 0
			//IL_02de->IL00ec: Incompatible stack heights: 1 vs 0
			//IL_0175->IL00ec: Incompatible stack heights: 2 vs 0
			//IL_0264->IL00ec: Incompatible stack heights: 3 vs 0
			//IL_0209->IL00ec: Incompatible stack heights: 3 vs 0
			//IL_0163->IL00ec: Incompatible stack heights: 2 vs 0
			//IL_01de->IL00ec: Incompatible stack heights: 3 vs 0
			//IL_02bf->IL00ec: Incompatible stack heights: 2 vs 0
			//IL_01f0->IL00ec: Incompatible stack heights: 3 vs 0
			//IL_01ce->IL00ec: Incompatible stack heights: 1 vs 0
			//IL_02b2->IL00ec: Incompatible stack heights: 3 vs 0
			//IL_02cf->IL00ec: Incompatible stack heights: 4 vs 0
			//IL_02a2->IL00ec: Incompatible stack heights: 3 vs 0
			//IL_02e9->IL00ec: Incompatible stack heights: 1 vs 0
			//IL_0180->IL00ec: Incompatible stack heights: 2 vs 0
			//IL_01fb->IL00ec: Incompatible stack heights: 3 vs 0
			//IL_023a->IL00ec: Incompatible stack heights: 1 vs 0
			//IL_0283->IL00ec: Incompatible stack heights: 1 vs 0
			//IL_00ec->IL00ec: Incompatible stack heights: 1 vs 0
			//IL_0352->IL00ec: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 5:
					return;
				case 4:
					if ((nuint)(nint)obj > (nuint)1u)
					{
						_ = 2;
						goto IL_0053;
					}
					goto IL_00b1;
				default:
					_ = 5;
					break;
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 2;
					break;
				case 1:
					goto IL_0496;
				case 2:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (4 != 0)
						{
							obj2 = 4;
						}
						break;
					}
					IL_0496:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
					IL_0053:
					while (true)
					{
						switch ((int)/*Error near IL_0070: Stack underflow*/)
						{
						case 2:
							if (obj != null)
							{
								if (1 == 0)
								{
									_ = 0;
								}
								continue;
							}
							goto IL_0496;
						case 5:
							if (obj == null)
							{
								if (3 == 0)
								{
									_ = 9;
								}
								goto IL_00ec;
							}
							goto IL_0180;
						case 3:
						case 4:
							goto IL_0496;
							IL_02e9:
							obj = (object)Unsafe.AsPointer(ref this);
							if (3 != 0)
							{
								_ = 8;
							}
							goto IL_00ec;
							IL_0180:
							if ((nint)obj != 1)
							{
								_ = 17;
								goto IL_00ec;
							}
							goto IL_02e9;
							IL_00ec:
							while (true)
							{
								switch ((int)/*Error near IL_0151: Stack underflow*/)
								{
								case 15:
									return;
								case 22:
									return;
								case 3:
								case 6:
									_ = ref obj;
									_ = 19;
									continue;
								case 1:
									obj = 1;
									if (5 != 0)
									{
										_ = 5;
									}
									continue;
								case 16:
									break;
								case 2:
								case 11:
									obj = (object)(&obj);
									_ = 13;
									continue;
								case 7:
									obj = -1;
									_ = 11;
									continue;
								case 10:
									_ = ref obj;
									if (17 != 0)
									{
										_ = 22;
									}
									continue;
								case 5:
									_ = 21;
									continue;
								case 18:
									if (&obj != null)
									{
										obj = 2;
										continue;
									}
									goto case 23;
								case 9:
								case 20:
									obj = (object)Unsafe.AsPointer(ref this);
									if (false)
									{
										_ = 0;
									}
									continue;
								case 4:
									_ = 10;
									continue;
								case 13:
									if (&obj != null)
									{
										if (1 == 0)
										{
											_ = 3;
										}
										continue;
									}
									goto case 1;
								case 23:
									obj = 0;
									_ = 4;
									continue;
								case 12:
									obj = -1;
									_ = 6;
									continue;
								case 8:
									_ = 12;
									continue;
								case 21:
									_ = ref obj;
									_ = 15;
									continue;
								default:
									if (7 == 0)
									{
										_ = 7;
									}
									continue;
								case 14:
									goto IL_02e9;
								case 17:
									obj = obj ?? ((object)/*Error near IL_0334: Stack underflow*/);
									if (16 == 0)
									{
										_ = 18;
									}
									continue;
								case 19:
									goto IL_0496;
								}
								break;
							}
							goto IL_0180;
						}
						break;
					}
					goto IL_00b1;
					IL_00b1:
					if (5 != 0)
					{
						_ = 5;
					}
					goto IL_0053;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_E200()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
		internal static object? _FF00_FF00_FF00_FF00_FF00_FF00_E500()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object?)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_E600(object? P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777740, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_E700(object? P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (false)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0251: Expected Obj, but got Ref
			//IL_0227: Expected Obj, but got Ref
			//IL_0115: Expected Obj, but got Ref
			//IL_011e: Expected Obj, but got I4
			//IL_008a: Expected I4, but got Obj
			//IL_0173: Expected Obj, but got I4
			//IL_00e7: Expected Obj, but got I4
			//IL_014e: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_024d->IL0019: Incompatible stack heights: 3 vs 1
			//IL_025d->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0233->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004d->IL0051: Incompatible stack types: I4 vs Obj
			//IL_0268->IL0019: Incompatible stack types: I4 vs Ref
			//IL_023e->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0223->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00ab->IL0051: Incompatible stack heights: 2 vs 1
			//IL_017e->IL0051: Incompatible stack heights: 3 vs 1
			//IL_00f4->IL0051: Incompatible stack heights: 2 vs 1
			//IL_0163->IL0051: Incompatible stack heights: 0 vs 1
			//IL_00b9->IL0051: Incompatible stack heights: 3 vs 1
			//IL_00ca->IL0051: Incompatible stack heights: 2 vs 1
			//IL_00e2->IL0051: Incompatible stack heights: 2 vs 1
			//IL_0153->IL004d: Incompatible stack heights: 3 vs 0
			//IL_00ff->IL0051: Incompatible stack heights: 2 vs 1
			//IL_016e->IL0051: Incompatible stack types: I4 vs Obj
			//IL_0111->IL0051: Incompatible stack types: I4 vs Obj
			//IL_00d5->IL0051: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			ref _003CImportAccounts_003Ed__28 reference = ref *(_003CImportAccounts_003Ed__28*)obj;
			while (true)
			{
				object obj2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					if (obj != null)
					{
						obj2 = 3;
						goto IL_0051;
					}
					goto IL_0111;
				case 4u:
					reference = ref this;
					if (2 != 0)
					{
						reference = ref *(_003CImportAccounts_003Ed__28*)5;
					}
					break;
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 != 0)
					{
						reference = ref *(_003CImportAccounts_003Ed__28*)2;
					}
					break;
				case 5u:
					return;
				case 1u:
					goto IL_023f;
				case 2u:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (false)
						{
							reference = ref *(_003CImportAccounts_003Ed__28*)null;
						}
						break;
					}
					IL_004d:
					obj2 = obj;
					goto IL_0051;
					IL_0051:
					while (true)
					{
						switch ((int)obj2)
						{
						case 9:
							return;
						default:
							_ = ref obj;
							_ = 7;
							continue;
						case 6:
							_ = 12;
							continue;
						case 7:
							_ = null;
							if (4 == 0)
							{
								_ = 0;
							}
							continue;
						case 8:
							_ = 2;
							continue;
						case 2:
							obj = -1;
							if (false)
							{
								_ = 0;
							}
							continue;
						case 5:
							if (&obj != null)
							{
								obj2 = 11;
								continue;
							}
							goto case 1;
						case 10:
							break;
						case 12:
							goto IL_013f;
						case 3:
							obj = (object)/*Error near IL_0157: Stack underflow*/;
							if (4 == 0)
							{
								obj2 = 5;
							}
							continue;
						case 1:
							obj = 0;
							_ = 6;
							continue;
						case 4:
							goto IL_023f;
						}
						break;
					}
					goto IL_0111;
					IL_023f:
					_ = -2;
					_ = 4;
					break;
					IL_013f:
					_ = ref obj;
					obj = 9;
					goto IL_004d;
					IL_0111:
					obj = (object)Unsafe.AsPointer(ref this);
					obj = 8;
					goto IL_004d;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object?)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777736, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object? P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (false)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0082: Expected Obj, but got Ref
			//IL_0067: Expected Obj, but got Ref
			//IL_011c: Expected I4, but got Obj
			//IL_0771: Expected Obj, but got Ref
			//IL_08d0: Expected Obj, but got Ref
			//IL_07d8: Expected Obj, but got Ref
			//IL_05e8: Expected Obj, but got Ref
			//IL_0545: Expected Obj, but got Ref
			//IL_02ea: Expected Obj, but got I4
			//IL_05cb: Expected Obj, but got Ref
			//IL_07f4: Expected Obj, but got I4
			//IL_05a1: Expected Obj, but got I4
			//IL_07b3: Expected Obj, but got I4
			//IL_06ad: Expected Obj, but got I4
			//IL_03a8: Expected Obj, but got Ref
			//IL_03d4: Expected Obj, but got I4
			//IL_0354: Expected Obj, but got I4
			//IL_035e: Expected Obj, but got I4
			//IL_08f9: Expected Obj, but got I4
			//IL_0755: Expected Obj, but got I4
			//IL_071f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0735: Expected I4, but got Unknown
			//IL_05f7: Expected Obj, but got I4
			//IL_032e: Expected Obj, but got I4
			//IL_087c: Expected Obj, but got Ref
			//IL_074b: Expected Obj, but got I4
			//IL_02aa: Expected I4, but got Obj
			//IL_083c: Expected Obj, but got Ref
			//IL_040d: Expected Obj, but got I4
			//IL_0560: Expected Obj, but got Ref
			//IL_0569: Expected Obj, but got I4
			//IL_07bd: Expected Obj, but got Ref
			//IL_0275: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0049->IL0019: Incompatible stack heights: 3 vs 1
			//IL_008c->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0073->IL0019: Incompatible stack heights: 0 vs 1
			//IL_007e->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0063->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00a0->IL00a4: Incompatible stack heights: 1 vs 0
			//IL_0a6a->IL00a4: Incompatible stack heights: 1 vs 0
			//IL_00e8->IL0a52: Incompatible stack heights: 1 vs 0
			//IL_00f4->IL00a4: Incompatible stack heights: 1 vs 0
			//IL_05f2->IL012a: Incompatible stack heights: 1 vs 0
			//IL_0126->IL012a: Incompatible stack heights: 1 vs 0
			//IL_00ff->IL00a4: Incompatible stack heights: 1 vs 0
			//IL_0788->IL012a: Incompatible stack heights: 1 vs 0
			//IL_08e7->IL012a: Incompatible stack heights: 1 vs 0
			//IL_07ef->IL012a: Incompatible stack heights: 1 vs 0
			//IL_055c->IL012a: Incompatible stack heights: 1 vs 0
			//IL_066d->IL012a: Incompatible stack heights: 2 vs 0
			//IL_0649->IL012a: Incompatible stack heights: 3 vs 0
			//IL_028f->IL012a: Incompatible stack heights: 2 vs 0
			//IL_02c3->IL012a: Incompatible stack heights: 1 vs 0
			//IL_0446->IL012a: Incompatible stack heights: 1 vs 0
			//IL_0686->IL012a: Incompatible stack heights: 3 vs 0
			//IL_0711->IL012a: Incompatible stack heights: 2 vs 0
			//IL_0387->IL012a: Incompatible stack heights: 1 vs 0
			//IL_0837->IL012a: Incompatible stack heights: 4 vs 0
			//IL_05d5->IL012a: Incompatible stack heights: 1 vs 0
			//IL_05bc->IL012a: Incompatible stack heights: 2 vs 0
			//IL_0801->IL012a: Incompatible stack heights: 2 vs 0
			//IL_05ac->IL012a: Incompatible stack heights: 3 vs 0
			//IL_07b8->IL0126: Incompatible stack heights: 3 vs 1
			//IL_08a0->IL012a: Incompatible stack heights: 2 vs 0
			//IL_04fc->IL012a: Incompatible stack heights: 3 vs 0
			//IL_06ba->IL012a: Incompatible stack heights: 2 vs 0
			//IL_0519->IL012a: Incompatible stack heights: 3 vs 0
			//IL_0536->IL012a: Incompatible stack heights: 1 vs 0
			//IL_0877->IL012a: Incompatible stack heights: 2 vs 0
			//IL_061f->IL012a: Incompatible stack heights: 4 vs 0
			//IL_03e1->IL012a: Incompatible stack heights: 2 vs 0
			//IL_0359->IL0126: Incompatible stack heights: 0 vs 1
			//IL_036b->IL012a: Incompatible stack heights: 2 vs 0
			//IL_0904->IL012a: Incompatible stack heights: 3 vs 0
			//IL_0762->IL012a: Incompatible stack heights: 2 vs 0
			//IL_065d->IL012a: Incompatible stack heights: 2 vs 0
			//IL_06f6->IL012a: Incompatible stack heights: 3 vs 0
			//IL_0604->IL012a: Incompatible stack heights: 2 vs 0
			//IL_069d->IL012a: Incompatible stack heights: 1 vs 0
			//IL_033b->IL012a: Incompatible stack heights: 2 vs 0
			//IL_03cf->IL012a: Incompatible stack heights: 2 vs 0
			//IL_0498->IL012a: Incompatible stack heights: 2 vs 0
			//IL_02de->IL012a: Incompatible stack heights: 2 vs 0
			//IL_081c->IL012a: Incompatible stack heights: 2 vs 0
			//IL_04bf->IL012a: Incompatible stack heights: 2 vs 0
			//IL_0846->IL012a: Incompatible stack heights: 1 vs 0
			//IL_08f4->IL012a: Incompatible stack heights: 2 vs 0
			//IL_0418->IL012a: Incompatible stack heights: 3 vs 0
			//IL_056e->IL0126: Incompatible stack heights: 0 vs 1
			//IL_08b0->IL012a: Incompatible stack heights: 1 vs 0
			//IL_0678->IL012a: Incompatible stack heights: 2 vs 0
			//IL_02ce->IL012a: Incompatible stack heights: 1 vs 0
			//IL_0451->IL012a: Incompatible stack heights: 1 vs 0
			//IL_071c->IL012a: Incompatible stack heights: 2 vs 0
			//IL_012a->IL012a: Incompatible stack heights: 2 vs 0
			//IL_05c7->IL012a: Incompatible stack heights: 2 vs 0
			//IL_0408->IL012a: Incompatible stack heights: 1 vs 0
			//IL_080c->IL012a: Incompatible stack heights: 2 vs 0
			//IL_0507->IL012a: Incompatible stack heights: 3 vs 0
			//IL_06c5->IL012a: Incompatible stack heights: 2 vs 0
			//IL_0524->IL012a: Incompatible stack heights: 3 vs 0
			//IL_03bf->IL012a: Incompatible stack heights: 1 vs 0
			//IL_0541->IL012a: Incompatible stack heights: 1 vs 0
			//IL_03ec->IL012a: Incompatible stack heights: 2 vs 0
			//IL_04aa->IL012a: Incompatible stack heights: 1 vs 0
			//IL_0376->IL012a: Incompatible stack heights: 2 vs 0
			//IL_076d->IL012a: Incompatible stack heights: 2 vs 0
			//IL_0701->IL012a: Incompatible stack heights: 3 vs 0
			//IL_073f->IL012a: Incompatible stack heights: 1 vs 0
			//IL_060f->IL012a: Incompatible stack heights: 2 vs 0
			//IL_06a8->IL012a: Incompatible stack heights: 1 vs 0
			//IL_0346->IL012a: Incompatible stack heights: 2 vs 0
			//IL_0893->IL012a: Incompatible stack heights: 1 vs 0
			//IL_02b4->IL012a: Incompatible stack heights: 1 vs 0
			//IL_0827->IL012a: Incompatible stack heights: 2 vs 0
			//IL_07d4->IL012a: Incompatible stack heights: 1 vs 0
			//IL_027a->IL0126: Incompatible stack heights: 0 vs 1
			//IL_0437->IL012a: Incompatible stack heights: 1 vs 0
			//IL_058d->IL012a: Incompatible stack heights: 1 vs 0
			//IL_06e4->IL012a: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			ref _003CLoginBedrock_003Ed__86 reference = ref *(_003CLoginBedrock_003Ed__86*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					_ = -2;
					_ = 4;
					break;
				case 4u:
					reference = ref this;
					if (3 == 0)
					{
						reference = ref *(_003CLoginBedrock_003Ed__86*)3;
					}
					break;
				case 2u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						reference = ref *(_003CLoginBedrock_003Ed__86*)null;
					}
					break;
				case 1u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CLoginBedrock_003Ed__86*)5;
					break;
				case 3u:
					return;
				case 5u:
					{
						if ((nuint)(nint)obj > (nuint)4u)
						{
							_ = 2;
							goto IL_00a4;
						}
						goto IL_0a52;
					}
					IL_0a52:
					if (4 == 0)
					{
						_ = 0;
					}
					goto IL_00a4;
					IL_00a4:
					while (true)
					{
						switch ((int)/*Error near IL_00bd: Stack underflow*/)
						{
						case 2:
							if (Unsafe.AsPointer(ref this) != null)
							{
								if (1 == 0)
								{
									_ = 3;
								}
								continue;
							}
							goto IL_0a52;
						case 4:
							switch ((int)obj)
							{
							default:
								_ = 16;
								goto IL_012a;
							case 4:
								obj = (object)Unsafe.AsPointer(ref this);
								if (34 == 0)
								{
									_ = 58;
								}
								goto IL_012a;
							case 3:
								goto IL_05e4;
							case 0:
								goto IL_076d;
							case 2:
								goto IL_07d4;
							case 1:
								goto IL_08cc;
								IL_012a:
								while (true)
								{
									scoped ref _003CLoginBedrock_003Ed__86 reference2;
									switch ((int)/*Error near IL_025f: Stack underflow*/)
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
										if (&obj == null)
										{
											obj = 71;
											continue;
										}
										goto case 31;
									case 3:
										obj = obj;
										_ = 40;
										continue;
									case 59:
										switch ((int)obj)
										{
										case 4:
											break;
										default:
											goto IL_02aa;
										case 0:
											goto IL_0346;
										case 3:
											goto IL_04aa;
										case 1:
											goto IL_0649;
										case 2:
											goto IL_0686;
										}
										goto case 3;
									case 5:
										if (9 == 0)
										{
											_ = 41;
										}
										continue;
									case 62:
										_ = 55;
										continue;
									case 15:
										reference2 = ref this;
										obj = 19;
										continue;
									case 53:
										obj = 1;
										if (65 == 0)
										{
											_ = 9;
										}
										continue;
									case 39:
										goto IL_0346;
									case 41:
										obj = -1;
										if (33 == 0)
										{
											_ = 73;
										}
										continue;
									case 10:
										obj = obj;
										_ = 64;
										continue;
									case 31:
										obj = (object)(&obj);
										if (false)
										{
											_ = 0;
										}
										continue;
									case 57:
										goto IL_03bf;
									case 38:
										obj = 0;
										if (6 != 0)
										{
											_ = 7;
										}
										continue;
									case 18:
										obj = (object)/*Error near IL_03f1: Stack underflow*/;
										if (46 == 0)
										{
											_ = 11;
										}
										continue;
									case 71:
										obj = 2;
										_ = 9;
										continue;
									case 4:
										if (&obj != null)
										{
											if (50 == 0)
											{
												_ = 23;
											}
											continue;
										}
										goto case 53;
									case 6:
										if (19 == 0)
										{
											_ = 26;
										}
										continue;
									case 60:
										_ = 43;
										continue;
									case 40:
										if (&obj == null)
										{
											_ = 42;
											continue;
										}
										goto case 56;
									case 68:
										goto IL_04aa;
									case 25:
										_ = ref obj;
										if (1 == 0)
										{
											_ = 52;
										}
										continue;
									case 27:
										_ = ref obj;
										if (29 != 0)
										{
											_ = 21;
										}
										continue;
									case 32:
										goto IL_0524;
									case 61:
										goto end_IL_012a;
									case 35:
									case 37:
									case 55:
									case 72:
										obj = (object)Unsafe.AsPointer(ref this);
										obj = 59;
										continue;
									case 23:
										if (&obj != null)
										{
											if (12 != 0)
											{
												_ = 2;
											}
											continue;
										}
										goto case 38;
									case 20:
										obj = -1;
										_ = 70;
										continue;
									case 17:
										_ = null;
										if (66 != 0)
										{
											_ = 3;
										}
										continue;
									case 16:
										obj = (object)Unsafe.AsPointer(ref this);
										_ = 47;
										continue;
									case 48:
										goto IL_05e4;
									case 49:
										obj = 4;
										if (0 == 0)
										{
											_ = 1;
										}
										continue;
									case 36:
										_ = ref obj;
										_ = 54;
										continue;
									case 2:
										_ = 14;
										continue;
									case 44:
										goto IL_0649;
									case 1:
										if (22 == 0)
										{
											_ = 1;
										}
										continue;
									case 7:
										_ = 36;
										continue;
									case 51:
										goto IL_0686;
									case 26:
										obj = -1;
										if (69 == 0)
										{
											_ = 42;
										}
										continue;
									case 64:
										if (&obj == null)
										{
											if (46 == 0)
											{
												_ = 49;
											}
											continue;
										}
										goto case 70;
									case 46:
										_ = 1;
										if (17 != 0)
										{
											_ = 11;
										}
										continue;
									case 9:
										if (16 == 0)
										{
											_ = 27;
										}
										continue;
									case 47:
										switch (obj - 1)
										{
										case 1:
											break;
										case 0:
											goto IL_03bf;
										case 2:
										case 3:
											goto IL_0524;
										default:
											goto IL_0735;
										}
										goto case 62;
									case 58:
										reference2 = ref this;
										obj = 20;
										continue;
									case 43:
										obj = -1;
										if (7 == 0)
										{
											_ = 56;
										}
										continue;
									case 11:
										goto IL_076d;
									case 22:
										_ = ref obj;
										obj = 45;
										continue;
									case 12:
									case 73:
										obj = (object)(&obj);
										if (33 == 0)
										{
											_ = 22;
										}
										continue;
									case 63:
										goto IL_07d4;
									case 19:
										obj = -1;
										if (31 == 0)
										{
											_ = 14;
										}
										continue;
									case 65:
										if (8 != 0)
										{
											_ = 25;
										}
										continue;
									case 14:
										_ = ref obj;
										_ = 30;
										continue;
									case 50:
									case 69:
										obj = (object)(&obj);
										_ = 21;
										continue;
									case 34:
										_ = 10;
										continue;
									case 56:
										obj = (object)(&obj);
										if (5 != 0)
										{
											_ = 8;
										}
										continue;
									case 24:
										_ = 18;
										continue;
									case 28:
									case 74:
										throw /*Error near IL_08a2: Stack underflow*/;
									default:
										obj = obj;
										_ = 34;
										continue;
									case 67:
										goto IL_08cc;
									case 70:
										_ = ref obj;
										_ = 24;
										continue;
									case 42:
										{
											obj = 3;
											_ = 2;
											continue;
										}
										IL_0649:
										obj = obj;
										_ = 23;
										continue;
										IL_0735:
										_ = 35;
										continue;
										IL_04aa:
										obj = obj;
										_ = 75;
										continue;
										IL_0346:
										obj = obj;
										obj = 13;
										continue;
										IL_03bf:
										_ = 37;
										continue;
										IL_02aa:
										_ = 28;
										continue;
										IL_0524:
										if (66 == 0)
										{
											_ = 72;
										}
										continue;
										IL_0686:
										obj = obj;
										if (2 != 0)
										{
											_ = 4;
										}
										continue;
									}
									goto end_IL_0103;
									continue;
									end_IL_012a:
									break;
								}
								goto case 4;
								IL_08cc:
								obj = (object)Unsafe.AsPointer(ref this);
								if (6 == 0)
								{
									_ = 3;
								}
								goto IL_012a;
								IL_05e4:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 60;
								goto IL_012a;
								IL_07d4:
								obj = (object)Unsafe.AsPointer(ref this);
								if (4 != 0)
								{
									_ = 15;
								}
								goto IL_012a;
								IL_076d:
								obj = (object)Unsafe.AsPointer(ref this);
								if (5 != 0)
								{
									_ = 3;
								}
								goto IL_012a;
								end_IL_0103:
								break;
							}
							break;
						case 1:
							goto IL_0a52;
						}
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
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00툀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00팀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777751, new IntPtr(2737335728876L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? _FF00_FF00_FF00_FF00_FF00_FF00퐀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object?)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00픀(object? P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (false)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0678: Expected Obj, but got Ref
			//IL_0075: Expected Obj, but got Ref
			//IL_01d4: Expected Obj, but got Ref
			//IL_024c: Expected Obj, but got Ref
			//IL_01c4: Expected Obj, but got I4
			//IL_05cd: Invalid comparison between Unknown and I4
			//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e2: Invalid comparison between Unknown and I4
			//IL_040e: Expected Obj, but got I4
			//IL_03fd: Expected Obj, but got I4
			//IL_0359: Expected I4, but got Obj
			//IL_0462: Expected Obj, but got I4
			//IL_058b: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0684->IL0019: Incompatible stack heights: 0 vs 1
			//IL_007f->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0071->IL0019: Incompatible stack heights: 2 vs 1
			//IL_068f->IL0019: Incompatible stack types: I4 vs Ref
			//IL_01de->IL0095: Incompatible stack types: I4 vs Ref
			//IL_0091->IL0095: Incompatible stack types: I4 vs Ref
			//IL_0056->IL0019: Incompatible stack types: I4 vs Ref
			//IL_05ca->IL0095: Incompatible stack heights: 3 vs 1
			//IL_028e->IL0095: Incompatible stack heights: 3 vs 1
			//IL_0258->IL0095: Incompatible stack heights: 0 vs 1
			//IL_01cf->IL0095: Incompatible stack heights: 3 vs 1
			//IL_0271->IL0095: Incompatible stack heights: 3 vs 1
			//IL_03de->IL0095: Incompatible stack heights: 0 vs 1
			//IL_0437->IL0095: Incompatible stack heights: 2 vs 1
			//IL_050e->IL0095: Incompatible stack heights: 3 vs 1
			//IL_0477->IL0095: Incompatible stack heights: 3 vs 1
			//IL_01a1->IL0095: Incompatible stack heights: 3 vs 1
			//IL_0201->IL0095: Incompatible stack heights: 3 vs 1
			//IL_037e->IL0095: Incompatible stack heights: 3 vs 1
			//IL_02a0->IL0095: Incompatible stack heights: 2 vs 1
			//IL_02c1->IL0095: Incompatible stack heights: 3 vs 1
			//IL_041a->IL0095: Incompatible stack types: Obj vs Ref
			//IL_0408->IL0095: Incompatible stack heights: 3 vs 1
			//IL_059f->IL0095: Incompatible stack types: I4 vs Ref
			//IL_023d->IL0095: Incompatible stack heights: 0 vs 1
			//IL_0489->IL0095: Incompatible stack heights: 2 vs 1
			//IL_03cd->IL0095: Incompatible stack heights: 3 vs 1
			//IL_0572->IL0095: Incompatible stack heights: 2 vs 1
			//IL_01b4->IL0095: Incompatible stack heights: 2 vs 1
			//IL_04b2->IL0095: Incompatible stack types: I4 vs Ref
			//IL_03bd->IL0095: Incompatible stack heights: 3 vs 1
			//IL_0590->IL0091: Incompatible stack heights: 0 vs 3
			//IL_02f3->IL0095: Incompatible stack heights: 2 vs 1
			//IL_0193->IL0095: Incompatible stack heights: 3 vs 1
			//IL_02e1->IL0095: Incompatible stack heights: 3 vs 1
			//IL_0213->IL0095: Incompatible stack heights: 2 vs 1
			//IL_0263->IL0095: Incompatible stack types: I4 vs Ref
			//IL_03e9->IL0095: Incompatible stack types: I4 vs Ref
			//IL_0442->IL0095: Incompatible stack heights: 2 vs 1
			//IL_0390->IL0095: Incompatible stack types: I4 vs Ref
			//IL_02d3->IL0095: Incompatible stack types: I4 vs Ref
			//IL_05de->IL0095: Incompatible stack heights: 0 vs 1
			//IL_0453->IL0095: Incompatible stack types: I4 vs Ref
			//IL_04f3->IL0095: Incompatible stack heights: 0 vs 1
			//IL_0544->IL0095: Incompatible stack types: I4 vs Ref
			//IL_02ab->IL0095: Incompatible stack heights: 2 vs 1
			//IL_0425->IL0095: Incompatible stack types: I4 vs Ref
			//IL_0248->IL0095: Incompatible stack types: I4 vs Ref
			//IL_0494->IL0095: Incompatible stack heights: 2 vs 1
			//IL_057d->IL0095: Incompatible stack heights: 2 vs 1
			//IL_0365->IL0095: Incompatible stack heights: 0 vs 1
			//IL_01bf->IL0095: Incompatible stack heights: 2 vs 1
			//IL_0095->IL0095: Incompatible stack heights: 4 vs 1
			//IL_0557->IL0095: Incompatible stack heights: 0 vs 1
			//IL_02fe->IL0095: Incompatible stack heights: 2 vs 1
			//IL_021e->IL0095: Incompatible stack heights: 2 vs 1
			//IL_05e9->IL0095: Incompatible stack types: I4 vs Ref
			//IL_04fe->IL0095: Incompatible stack types: I4 vs Ref
			//IL_0370->IL0095: Incompatible stack types: I4 vs Ref
			//IL_0562->IL0095: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			ref _003CLoginByHistory_003Ed__25 reference = ref *(_003CLoginByHistory_003Ed__25*)obj;
			while (true)
			{
				ref _003CLoginByHistory_003Ed__25 reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 1u:
					return;
				case 5u:
					reference = ref this;
					if (true)
					{
						reference = ref *(_003CLoginByHistory_003Ed__25*)null;
					}
					break;
				default:
					_ = -2;
					if (5 == 0)
					{
						_ = 2;
					}
					break;
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CLoginByHistory_003Ed__25*)2;
					break;
				case 4u:
					if (obj == null)
					{
						reference2 = ref *(_003CLoginByHistory_003Ed__25*)18;
						goto IL_0095;
					}
					goto IL_01cf;
				case 2u:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (4 != 0)
						{
							reference = ref *(_003CLoginByHistory_003Ed__25*)3;
						}
						break;
					}
					IL_01cf:
					obj = (object)Unsafe.AsPointer(ref this);
					reference2 = ref *(_003CLoginByHistory_003Ed__25*)31;
					goto IL_0095;
					IL_0095:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						case 34u:
							return;
						case 22u:
							break;
						case 48u:
						case 49u:
							_ = 37;
							continue;
						case 13u:
							_ = 2;
							_ = 52;
							continue;
						case 39u:
							_ = 0;
							if (36 == 0)
							{
								_ = 15;
							}
							continue;
						case 3u:
							obj = -1;
							_ = 32;
							continue;
						case 51u:
							goto IL_01cf;
						case 16u:
							_ = 15;
							continue;
						case 52u:
							if (35 != 0)
							{
								_ = 13;
							}
							continue;
						case 27u:
						case 32u:
							_ = ref obj;
							if (22 == 0)
							{
								reference2 = ref *(_003CLoginByHistory_003Ed__25*)null;
							}
							continue;
						case 2u:
						case 18u:
							obj = (object)Unsafe.AsPointer(ref this);
							if (4 == 0)
							{
								reference2 = ref *(_003CLoginByHistory_003Ed__25*)19;
							}
							continue;
						case 5u:
							goto IL_0263;
						case 1u:
							goto IL_0280;
						case 23u:
							if (18 == 0)
							{
								_ = 28;
							}
							continue;
						case 24u:
							goto IL_02ab;
						case 12u:
							if (&obj != null)
							{
								reference2 = ref *(_003CLoginByHistory_003Ed__25*)27;
								continue;
							}
							goto case 29u;
						case 50u:
							_ = 43;
							continue;
						case 47u:
							if (true)
							{
								_ = 11;
							}
							continue;
						case 38u:
							switch ((int)obj)
							{
							case 2:
								break;
							case 3:
								goto IL_0263;
							case 4:
								goto IL_0280;
							case 1:
							case 5:
							case 6:
								goto IL_02ab;
							default:
								goto IL_0359;
							case 0:
								goto IL_0370;
							}
							goto case 13u;
						case 21u:
							goto IL_0370;
						case 8u:
							if ((nint)obj != 1)
							{
								reference2 = ref *(_003CLoginByHistory_003Ed__25*)25;
								continue;
							}
							goto case 41u;
						case 41u:
							_ = 45;
							continue;
						case 35u:
							_ = 20;
							continue;
						case 6u:
							obj = obj;
							if (12 == 0)
							{
								reference2 = ref *(_003CLoginByHistory_003Ed__25*)17;
							}
							continue;
						case 29u:
							obj = 0;
							_ = 50;
							continue;
						case 10u:
						case 28u:
						case 44u:
						{
							object obj2 = obj;
							obj = 1;
							reference2 = ref *(_003CLoginByHistory_003Ed__25*)obj2;
							if (14 == 0)
							{
								reference2 = ref *(_003CLoginByHistory_003Ed__25*)6;
							}
							continue;
						}
						case 7u:
							if (2 != 0)
							{
								_ = 4;
							}
							continue;
						case 4u:
						case 15u:
						case 20u:
						case 26u:
						case 30u:
						case 42u:
							if ((int)/*Error near IL_0449: Stack underflow*/ == 0)
							{
								reference2 = ref *(_003CLoginByHistory_003Ed__25*)10;
								continue;
							}
							goto case 6u;
						case 43u:
							_ = ref obj;
							obj = 34;
							continue;
						case 11u:
							_ = 30;
							continue;
						case 33u:
							if (26 == 0)
							{
								_ = 16;
							}
							continue;
						case 40u:
							obj = obj;
							reference2 = ref *(_003CLoginByHistory_003Ed__25*)46;
							continue;
						case 17u:
							if (obj - 2 > 2)
							{
								if (44 == 0)
								{
									reference2 = ref *(_003CLoginByHistory_003Ed__25*)null;
								}
								continue;
							}
							goto case 39u;
						case 9u:
							_ = 7;
							continue;
						case 19u:
							reference2 = ref this;
							if (3 != 0)
							{
								reference2 = ref *(_003CLoginByHistory_003Ed__25*)3;
							}
							continue;
						case 46u:
							if (obj == null)
							{
								if (48 == 0)
								{
									reference2 = ref *(_003CLoginByHistory_003Ed__25*)44;
								}
								continue;
							}
							goto case 8u;
						case 36u:
							_ = 5;
							if (8 == 0)
							{
								_ = 23;
							}
							continue;
						case 25u:
						case 37u:
						case 45u:
							obj = obj;
							obj = 12;
							continue;
						case 31u:
							obj = obj;
							reference2 = ref *(_003CLoginByHistory_003Ed__25*)38;
							continue;
						default:
							_ = 40;
							continue;
						case 14u:
							{
								if ((int)/*Error near IL_05d2: Stack underflow*/ == 1)
								{
									if (false)
									{
										reference2 = ref *(_003CLoginByHistory_003Ed__25*)null;
									}
									continue;
								}
								goto case 25u;
							}
							IL_02ab:
							_ = (nint)obj != 1;
							_ = 9;
							continue;
							IL_0280:
							_ = 4;
							_ = 33;
							continue;
							IL_0263:
							_ = 3;
							_ = 47;
							continue;
							IL_0370:
							_ = 5;
							_ = 16;
							continue;
							IL_0359:
							if (42 == 0)
							{
								reference2 = ref *(_003CLoginByHistory_003Ed__25*)10;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00저()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
		internal static object? _FF00_FF00_FF00_FF00_FF00_FF00쬀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object?)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00찀(object? P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (0 == 0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_100d: Expected Obj, but got Ref
			//IL_0fe5: Expected Obj, but got Ref
			//IL_00f7: Expected I4, but got Obj
			//IL_0b64: Expected Obj, but got Ref
			//IL_0956: Expected Obj, but got Ref
			//IL_0430: Expected Obj, but got Ref
			//IL_09ca: Expected Obj, but got Ref
			//IL_069d: Expected Obj, but got Ref
			//IL_0865: Expected Obj, but got Ref
			//IL_09e6: Expected Obj, but got Ref
			//IL_091c: Expected Obj, but got I4
			//IL_08d1: Expected Obj, but got I4
			//IL_09d8: Expected Obj, but got Ref
			//IL_0ba1: Expected Obj, but got Ref
			//IL_04f0: Expected Obj, but got I4
			//IL_0b82: Expected Obj, but got Ref
			//IL_0375: Expected Obj, but got Ref
			//IL_0af1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b07: Expected I4, but got Unknown
			//IL_0590: Expected Obj, but got Ref
			//IL_080a: Expected Obj, but got I4
			//IL_0b2f: Expected Obj, but got Ref
			//IL_07b3: Expected Obj, but got I4
			//IL_0d52: Expected Obj, but got Ref
			//IL_0b16: Expected Obj, but got I4
			//IL_0d3d: Expected Obj, but got Ref
			//IL_0d46: Expected Obj, but got I4
			//IL_0c5a: Expected Obj, but got I4
			//IL_0a61: Expected Obj, but got Ref
			//IL_045a: Expected Obj, but got I4
			//IL_03cb: Expected Obj, but got I4
			//IL_07d2: Expected Obj, but got Ref
			//IL_099e: Expected Obj, but got I4
			//IL_0bce: Expected I4, but got Obj
			//IL_0826: Expected Obj, but got I4
			//IL_064b: Expected Obj, but got Ref
			//IL_035a: Expected Obj, but got Ref
			//IL_09ae: Expected Obj, but got I4
			//IL_048a: Expected Obj, but got I4
			//IL_06c1: Expected Obj, but got Ref
			//IL_0857: Expected Obj, but got Ref
			//IL_0710: Expected I4, but got Obj
			//IL_0681: Expected Obj, but got I4
			//IL_03b8: Expected Obj, but got I4
			//IL_073c: Expected Obj, but got I4
			//IL_0b46: Expected Obj, but got I4
			//IL_0b55: Expected Obj, but got I4
			//IL_05ac: Expected Obj, but got I4
			//IL_05b6: Expected Obj, but got I4
			//IL_087e: Expected Obj, but got I4
			//IL_0dc2: Expected Obj, but got I4
			//IL_0e01: Expected Obj, but got I4
			//IL_1019->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0ff1->IL0019: Incompatible stack heights: 0 vs 1
			//IL_1009->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0fd6->IL0019: Incompatible stack heights: 2 vs 1
			//IL_1024->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0ffc->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0fe1->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00b6->IL005f: Incompatible stack heights: 1 vs 0
			//IL_005b->IL005f: Incompatible stack heights: 1 vs 0
			//IL_0087->IL009e: Incompatible stack heights: 1 vs 0
			//IL_0093->IL005f: Incompatible stack heights: 1 vs 0
			//IL_0b6e->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0960->IL0105: Incompatible stack types: I4 vs Ref
			//IL_043c->IL0105: Incompatible stack heights: 0 vs 1
			//IL_09d4->IL0105: Incompatible stack types: I4 vs Ref
			//IL_06a7->IL0105: Incompatible stack types: I4 vs Ref
			//IL_086f->IL0105: Incompatible stack types: I4 vs Ref
			//IL_09f2->IL0105: Incompatible stack heights: 0 vs 1
			//IL_0101->IL0105: Incompatible stack types: I4 vs Ref
			//IL_009e->IL005f: Incompatible stack heights: 1 vs 0
			//IL_0447->IL0105: Incompatible stack types: I4 vs Ref
			//IL_09fd->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0764->IL0105: Incompatible stack heights: 2 vs 1
			//IL_0339->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0558->IL0105: Incompatible stack heights: 2 vs 1
			//IL_0927->IL0105: Incompatible stack heights: 3 vs 1
			//IL_0a3a->IL0105: Incompatible stack heights: 2 vs 1
			//IL_042c->IL0105: Incompatible stack heights: 4 vs 1
			//IL_08de->IL0105: Incompatible stack heights: 2 vs 1
			//IL_09e2->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0402->IL0105: Incompatible stack heights: 2 vs 1
			//IL_0bab->IL0105: Incompatible stack heights: 2 vs 1
			//IL_0c13->IL0105: Incompatible stack heights: 2 vs 1
			//IL_0d2d->IL0105: Incompatible stack types: Obj vs Ref
			//IL_04fb->IL0105: Incompatible stack heights: 3 vs 1
			//IL_0b8e->IL0105: Incompatible stack heights: 0 vs 1
			//IL_037f->IL0105: Incompatible stack types: I4 vs Ref
			//IL_059c->IL0105: Incompatible stack heights: 2 vs 1
			//IL_0815->IL0105: Incompatible stack heights: 3 vs 1
			//IL_0805->IL0105: Incompatible stack heights: 2 vs 1
			//IL_0b39->IL0105: Incompatible stack heights: 4 vs 1
			//IL_0568->IL0105: Incompatible stack heights: 2 vs 1
			//IL_07be->IL0105: Incompatible stack heights: 3 vs 1
			//IL_05d0->IL0105: Incompatible stack heights: 2 vs 1
			//IL_0629->IL0105: Incompatible stack types: Obj vs Ref
			//IL_0d5c->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0b21->IL0105: Incompatible stack heights: 3 vs 1
			//IL_0d6c->IL0105: Incompatible stack heights: 2 vs 1
			//IL_0c64->IL0105: Incompatible stack heights: 4 vs 1
			//IL_06e0->IL0105: Incompatible stack heights: 2 vs 1
			//IL_0a6d->IL0105: Incompatible stack heights: 0 vs 1
			//IL_03e7->IL0105: Incompatible stack types: Obj vs Ref
			//IL_0465->IL0105: Incompatible stack heights: 3 vs 1
			//IL_08bd->IL0105: Incompatible stack heights: 3 vs 1
			//IL_07a3->IL0105: Incompatible stack types: Obj vs Ref
			//IL_0891->IL0105: Incompatible stack heights: 3 vs 1
			//IL_0485->IL0105: Incompatible stack heights: 4 vs 1
			//IL_07dc->IL0105: Incompatible stack types: I4 vs Ref
			//IL_09a9->IL0105: Incompatible stack heights: 3 vs 1
			//IL_0657->IL0105: Incompatible stack heights: 0 vs 1
			//IL_0366->IL0105: Incompatible stack heights: 0 vs 1
			//IL_09bb->IL0105: Incompatible stack heights: 2 vs 1
			//IL_0475->IL0105: Incompatible stack heights: 2 vs 1
			//IL_0c3e->IL0105: Incompatible stack heights: 3 vs 1
			//IL_0aa9->IL0105: Incompatible stack heights: 3 vs 1
			//IL_0497->IL0105: Incompatible stack heights: 2 vs 1
			//IL_0a8a->IL0105: Incompatible stack heights: 3 vs 1
			//IL_03a0->IL0105: Incompatible stack heights: 3 vs 1
			//IL_096e->IL0105: Incompatible stack heights: 3 vs 1
			//IL_06ed->IL0105: Incompatible stack heights: 2 vs 1
			//IL_06cb->IL0105: Incompatible stack types: I4 vs Ref
			//IL_04c0->IL0105: Incompatible stack heights: 2 vs 1
			//IL_0a51->IL0105: Incompatible stack types: Obj vs Ref
			//IL_0861->IL0105: Incompatible stack heights: 4 vs 1
			//IL_0737->IL0105: Incompatible stack heights: 4 vs 1
			//IL_0a22->IL0105: Incompatible stack heights: 3 vs 1
			//IL_0c76->IL0105: Incompatible stack heights: 3 vs 1
			//IL_0936->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0c92->IL0105: Incompatible stack types: Obj vs Ref
			//IL_0cab->IL0105: Incompatible stack heights: 3 vs 1
			//IL_0455->IL0105: Incompatible stack heights: 3 vs 1
			//IL_068e->IL0105: Incompatible stack heights: 2 vs 1
			//IL_03bd->IL0101: Incompatible stack heights: 2 vs 0
			//IL_0749->IL0105: Incompatible stack heights: 2 vs 1
			//IL_0b50->IL0105: Incompatible stack heights: 4 vs 1
			//IL_0b60->IL0105: Incompatible stack heights: 3 vs 1
			//IL_05bb->IL0101: Incompatible stack heights: 2 vs 0
			//IL_0883->IL0101: Incompatible stack heights: 1 vs 0
			//IL_06bc->IL0105: Incompatible stack heights: 2 vs 1
			//IL_0ce9->IL0105: Incompatible stack types: I4 vs Ref
			//IL_052a->IL0105: Incompatible stack heights: 4 vs 1
			//IL_076f->IL0105: Incompatible stack heights: 2 vs 1
			//IL_08e9->IL0105: Incompatible stack heights: 2 vs 1
			//IL_0585->IL0105: Incompatible stack types: I4 vs Ref
			//IL_040d->IL0105: Incompatible stack heights: 2 vs 1
			//IL_0d38->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0acf->IL0105: Incompatible stack types: I4 vs Ref
			//IL_051a->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0b99->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0bf7->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0b11->IL0105: Incompatible stack types: I4 vs Ref
			//IL_05a7->IL0105: Incompatible stack heights: 2 vs 1
			//IL_08a1->IL0105: Incompatible stack heights: 3 vs 1
			//IL_05fc->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0573->IL0105: Incompatible stack heights: 2 vs 1
			//IL_067c->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0cfb->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0634->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0d77->IL0105: Incompatible stack heights: 2 vs 1
			//IL_0105->IL0105: Incompatible stack types: Obj vs Ref
			//IL_0a78->IL0105: Incompatible stack types: I4 vs Ref
			//IL_03f2->IL0105: Incompatible stack types: I4 vs Ref
			//IL_07ae->IL0105: Incompatible stack types: I4 vs Ref
			//IL_054b->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0bda->IL0105: Incompatible stack heights: 0 vs 1
			//IL_0d84->IL0d8a: Incompatible stack heights: 0 vs 2
			//IL_0662->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0371->IL0105: Incompatible stack types: I4 vs Ref
			//IL_09c6->IL0105: Incompatible stack heights: 2 vs 1
			//IL_05e2->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0ab4->IL0105: Incompatible stack heights: 3 vs 1
			//IL_04a2->IL0105: Incompatible stack heights: 2 vs 1
			//IL_0a95->IL0105: Incompatible stack heights: 3 vs 1
			//IL_03ab->IL0105: Incompatible stack heights: 3 vs 1
			//IL_0ae3->IL0105: Incompatible stack heights: 0 vs 1
			//IL_0a5c->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0cbf->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0a2d->IL0105: Incompatible stack heights: 3 vs 1
			//IL_0c81->IL0105: Incompatible stack heights: 3 vs 1
			//IL_071c->IL0105: Incompatible stack heights: 0 vs 1
			//IL_0c9d->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0699->IL0105: Incompatible stack heights: 2 vs 1
			//IL_090c->IL0105: Incompatible stack heights: 0 vs 1
			//IL_0754->IL0105: Incompatible stack heights: 2 vs 1
			//IL_0df1->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0be5->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0d9f->IL0105: Incompatible stack heights: 3 vs 1
			//IL_0dd8->IL0105: Incompatible stack heights: 2 vs 1
			//IL_0aee->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0727->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0917->IL0105: Incompatible stack types: I4 vs Ref
			//IL_0e06->IL0101: Incompatible stack heights: 1 vs 0
			//IL_0daa->IL0105: Incompatible stack heights: 3 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				ref byte reference;
				switch ((int)obj2)
				{
				case 4:
					if ((nuint)(nint)obj > (nuint)6u)
					{
						if (0 == 0)
						{
							_ = 1;
						}
						goto IL_005f;
					}
					goto IL_009e;
				case 3:
					return;
				case 5:
					goto IL_0fc6;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				case 2:
					_ = 3;
					break;
				default:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							obj2 = 4;
						}
						break;
					}
					IL_009e:
					if (4 == 0)
					{
						_ = 4;
					}
					goto IL_005f;
					IL_0fc6:
					_ = -2;
					if (2 != 0)
					{
						_ = 2;
					}
					break;
					IL_005f:
					while (true)
					{
						switch ((int)/*Error near IL_0078: Stack underflow*/)
						{
						case 1:
							if (Unsafe.AsPointer(ref this) != null)
							{
								if (3 != 0)
								{
									_ = 1;
								}
								continue;
							}
							break;
						case 4:
							goto IL_00d2;
						case 2:
						case 3:
							goto IL_0fc6;
						}
						break;
					}
					goto IL_009e;
					IL_00d2:
					switch ((int)obj)
					{
					default:
						reference = ref *(byte*)74;
						goto IL_0105;
					case 2:
						obj = (object)Unsafe.AsPointer(ref this);
						if (3 != 0)
						{
							reference = ref *(byte*)39;
						}
						goto IL_0105;
					case 4:
						goto IL_0699;
					case 5:
						goto IL_0861;
					case 1:
						goto IL_0952;
					case 3:
						goto IL_09c6;
					case 6:
						goto IL_09e2;
					case 0:
						goto IL_0b60;
						IL_0105:
						while (true)
						{
							object obj4;
							object obj5;
							switch ((uint)Unsafe.AsPointer(ref reference))
							{
							case 19u:
								return;
							case 2u:
								reference = ref *(byte*)42;
								continue;
							case 26u:
							case 75u:
								obj = (object)(&obj);
								if (30 != 0)
								{
									reference = ref *(byte*)1;
								}
								continue;
							case 24u:
								obj = (object)Unsafe.AsPointer(ref this);
								reference = ref *(byte*)70;
								continue;
							case 88u:
								_ = ref obj;
								if (44 != 0)
								{
									_ = 18;
								}
								continue;
							case 120u:
								obj = 88;
								goto IL_0101;
							case 63u:
							case 81u:
								obj = 73;
								goto IL_0101;
							case 58u:
							{
								object obj3 = obj;
								obj = obj;
								reference = ref *(byte*)obj3;
								if (16 != 0)
								{
									reference = ref *(byte*)41;
								}
								continue;
							}
							case 12u:
								if (62 == 0)
								{
									_ = 87;
								}
								continue;
							case 6u:
								_ = ref obj;
								_ = 98;
								continue;
							case 50u:
								break;
							case 114u:
								_ = null;
								_ = 51;
								continue;
							case 59u:
								obj = 2;
								_ = 65;
								continue;
							case 79u:
								_ = 104;
								continue;
							case 66u:
								_ = ref obj;
								_ = 103;
								continue;
							case 84u:
								obj = 6;
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							case 98u:
								return;
							case 99u:
								_ = 43;
								continue;
							case 17u:
								obj = -1;
								_ = 52;
								continue;
							case 36u:
								return;
							case 1u:
							case 96u:
								throw /*Error near IL_050c: Stack underflow*/;
							case 22u:
							case 46u:
							case 48u:
							case 72u:
							case 107u:
							case 117u:
							case 122u:
								obj = obj;
								reference = ref *(byte*)101;
								continue;
							case 131u:
								_ = ref obj;
								_ = 86;
								continue;
							case 92u:
								return;
							case 69u:
								if (&obj != null)
								{
									reference = ref *(byte*)14;
									continue;
								}
								goto case 47u;
							case 3u:
								_ = 68;
								continue;
							case 37u:
								if (2 == 0)
								{
									_ = 6;
								}
								continue;
							case 10u:
								if (&obj != null)
								{
									reference = ref *(byte*)95;
									continue;
								}
								goto case 59u;
							case 29u:
								_ = 0;
								obj = (object)Unsafe.AsPointer(ref this);
								if (112 == 0)
								{
									_ = 122;
								}
								continue;
							case 126u:
								obj = -1;
								obj = 75;
								goto IL_0101;
							case 40u:
								goto IL_05bb;
							case 77u:
								if (&obj == null)
								{
									reference = ref *(byte*)76;
									continue;
								}
								goto case 56u;
							case 31u:
								reference = ref Unsafe.As<_003CLoginDesktop_003Ed__87, byte>(ref this);
								if (112 != 0)
								{
									reference = ref *(byte*)124;
								}
								continue;
							case 103u:
								return;
							case 42u:
								reference = ref *(byte*)obj;
								if (41 == 0)
								{
									reference = ref *(byte*)114;
								}
								continue;
							case 74u:
								obj = (object)Unsafe.AsPointer(ref this);
								if (28 == 0)
								{
									reference = ref *(byte*)8;
								}
								continue;
							case 39u:
								reference = ref Unsafe.As<_003CLoginDesktop_003Ed__87, byte>(ref this);
								if (116 != 0)
								{
									reference = ref *(byte*)22;
								}
								continue;
							case 116u:
								obj = -1;
								if (67 != 0)
								{
									_ = 26;
								}
								continue;
							case 7u:
								goto IL_0699;
							case 128u:
								goto IL_06a7;
							case 78u:
							case 97u:
								obj = (object)(&obj);
								reference = ref *(byte*)32;
								continue;
							case 55u:
								goto IL_06cb;
							case 91u:
								_ = 17;
								continue;
							case 110u:
								switch ((int)obj)
								{
								case 4:
									break;
								case 3:
									goto IL_05bb;
								case 2:
									goto IL_06a7;
								default:
									goto IL_0710;
								case 0:
									goto IL_0927;
								case 6:
									goto IL_0a3a;
								case 1:
									goto IL_0d17;
								case 5:
									goto IL_0d77;
								}
								goto case 58u;
							case 106u:
								_ = 1;
								_ = 24;
								continue;
							case 121u:
								obj = 3;
								if (4 != 0)
								{
									_ = 90;
								}
								continue;
							default:
								if (131 == 0)
								{
									_ = 23;
								}
								continue;
							case 64u:
								goto IL_0791;
							case 38u:
								obj = -1;
								_ = 97;
								continue;
							case 67u:
							case 95u:
								obj = (object)(&obj);
								reference = ref *(byte*)62;
								continue;
							case 34u:
								_ = 126;
								continue;
							case 33u:
								obj = -1;
								_ = 18;
								continue;
							case 73u:
								obj = (object)/*Error near IL_081d: Stack underflow*/;
								obj = 106;
								goto IL_0101;
							case 44u:
								return;
							case 102u:
								goto IL_0849;
							case 27u:
								goto IL_0861;
							case 127u:
								goto IL_086f;
							case 65u:
								_ = 109;
								continue;
							case 45u:
							case 57u:
								throw /*Error near IL_0893: Stack underflow*/;
							case 30u:
							case 32u:
							case 62u:
							case 82u:
							case 115u:
							case 119u:
							case 130u:
								_ = 99;
								continue;
							case 86u:
								return;
							case 60u:
								_ = null;
								_ = 94;
								continue;
							case 8u:
								obj = 5;
								if (120 != 0)
								{
									_ = 51;
								}
								continue;
							case 118u:
								if (&obj != null)
								{
									if (78 == 0)
									{
										reference = ref *(byte*)21;
									}
									continue;
								}
								goto case 4u;
							case 4u:
								obj = 0;
								_ = 37;
								continue;
							case 111u:
								goto IL_0927;
							case 9u:
								goto IL_0952;
							case 90u:
								_ = 66;
								continue;
							case 68u:
								obj = -1;
								_ = 23;
								continue;
							case 76u:
								obj = 4;
								if (8 == 0)
								{
									_ = 12;
								}
								continue;
							case 21u:
								goto IL_09c6;
							case 11u:
							case 53u:
							case 85u:
							case 104u:
								obj = (object)Unsafe.AsPointer(ref this);
								reference = ref *(byte*)110;
								continue;
							case 49u:
								goto IL_09e2;
							case 108u:
								_ = ref obj;
								if (36 == 0)
								{
									_ = 8;
								}
								continue;
							case 5u:
								_ = 38;
								continue;
							case 100u:
								goto IL_0a3a;
							case 56u:
								obj = (object)(&obj);
								if (115 != 0)
								{
									reference = ref *(byte*)87;
								}
								continue;
							case 87u:
								_ = ref obj;
								if (16 == 0)
								{
									_ = 19;
								}
								continue;
							case 83u:
								_ = 0;
								if (2 == 0)
								{
									_ = 1;
								}
								continue;
							case 18u:
								reference = ref *(byte*)(&obj);
								if (58 == 0)
								{
									reference = ref *(byte*)129;
								}
								continue;
							case 93u:
								if (&obj != null)
								{
									if (7 == 0)
									{
										reference = ref *(byte*)26;
									}
									continue;
								}
								goto case 121u;
							case 28u:
								switch (obj - 1)
								{
								case 0:
									break;
								case 2:
								case 3:
									goto IL_0791;
								case 1:
									goto IL_086f;
								default:
									goto IL_0b07;
								}
								goto case 79u;
							case 47u:
								obj = 1;
								_ = 113;
								continue;
							case 35u:
								goto IL_0b21;
							case 123u:
								goto IL_0b39;
							case 124u:
								obj = -1;
								_ = 56;
								continue;
							case 20u:
								goto IL_0b60;
							case 23u:
							case 105u:
								obj = (object)(&obj);
								if (119 != 0)
								{
									reference = ref *(byte*)36;
								}
								continue;
							case 13u:
								goto IL_0b99;
							case 70u:
								switch ((int)obj)
								{
								case 4:
									break;
								case 1:
									goto IL_06cb;
								case 2:
									goto IL_0849;
								case 3:
									goto IL_0b21;
								case 6:
									goto IL_0b39;
								case 0:
									goto IL_0b99;
								default:
									goto IL_0bce;
								case 5:
									goto IL_0c4d;
								}
								goto case 29u;
							case 25u:
								if (&obj == null)
								{
									reference = ref *(byte*)84;
									continue;
								}
								goto case 18u;
							case 15u:
								_ = 33;
								continue;
							case 80u:
								_ = null;
								_ = 60;
								continue;
							case 54u:
								goto IL_0c4d;
							case 109u:
								_ = ref obj;
								if (92 == 0)
								{
									_ = 70;
								}
								continue;
							case 112u:
								reference = ref *(byte*)obj;
								if (65 != 0)
								{
									reference = ref *(byte*)83;
								}
								continue;
							case 113u:
								_ = 108;
								continue;
							case 101u:
								if (obj == null)
								{
									reference = ref *(byte*)112;
									continue;
								}
								goto case 42u;
							case 129u:
								reference = ref *(byte*)89;
								continue;
							case 41u:
								if (&obj != null)
								{
									reference = ref *(byte*)105;
									continue;
								}
								goto case 8u;
							case 16u:
								goto IL_0d17;
							case 14u:
							case 52u:
								obj = (object)(&obj);
								obj = 130;
								goto IL_0101;
							case 43u:
								obj = (object)Unsafe.AsPointer(ref this);
								reference = ref *(byte*)25;
								continue;
							case 51u:
								_ = 0;
								if (57 == 0)
								{
									_ = 80;
								}
								continue;
							case 71u:
								goto IL_0d77;
							case 89u:
								if (obj == null)
								{
									obj = 61;
									goto IL_0101;
								}
								_ = 125;
								continue;
							case 61u:
							case 125u:
								if (obj == null)
								{
									reference = ref *(byte*)81;
									continue;
								}
								obj = 63;
								goto IL_0101;
							case 94u:
								goto end_IL_00d6;
								IL_0c4d:
								_ = 0;
								obj = 1;
								_ = 48;
								continue;
								IL_0bce:
								if (false)
								{
									reference = ref *(byte*)1;
								}
								continue;
								IL_05bb:
								obj = obj;
								_ = 77;
								continue;
								IL_0b99:
								_ = 0;
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 22;
								continue;
								IL_0b39:
								_ = 0;
								obj = 0;
								_ = 107;
								continue;
								IL_0b21:
								_ = 0;
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 117;
								continue;
								IL_0b07:
								reference = ref *(byte*)85;
								continue;
								IL_0101:
								reference = ref *(byte*)obj;
								continue;
								IL_086f:
								obj = 53;
								goto IL_0101;
								IL_0849:
								_ = 0;
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 72;
								continue;
								IL_0791:
								reference = ref *(byte*)obj;
								if (11 == 0)
								{
									reference = ref *(byte*)2;
								}
								continue;
								IL_0d77:
								if ((int)/*Error near IL_0d79: Stack underflow*/ == 0)
								{
									_ = null;
								}
								obj = null;
								if (94 == 0)
								{
									_ = 118;
								}
								continue;
								IL_0d17:
								obj4 = obj;
								obj = obj;
								reference = ref *(byte*)obj4;
								if (3 == 0)
								{
									reference = ref *(byte*)10;
								}
								continue;
								IL_0a3a:
								obj5 = obj;
								obj = obj;
								reference = ref *(byte*)obj5;
								if (41 == 0)
								{
									reference = ref *(byte*)69;
								}
								continue;
								IL_0927:
								obj = obj;
								reference = ref *(byte*)82;
								continue;
								IL_0710:
								if (19 == 0)
								{
									reference = ref *(byte*)45;
								}
								continue;
								IL_06cb:
								obj = obj;
								_ = 46;
								continue;
								IL_06a7:
								obj = obj;
								_ = 93;
								continue;
							}
							break;
						}
						goto case 2;
						IL_0b60:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(byte*)5;
						goto IL_0105;
						IL_09e2:
						obj = (object)Unsafe.AsPointer(ref this);
						if (15 == 0)
						{
							reference = ref *(byte*)11;
						}
						goto IL_0105;
						IL_09c6:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(byte*)34;
						goto IL_0105;
						IL_0952:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(byte*)91;
						goto IL_0105;
						IL_0861:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(byte*)3;
						goto IL_0105;
						IL_0699:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(byte*)31;
						goto IL_0105;
						end_IL_00d6:
						break;
					}
					goto IL_0fc6;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00뼀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
		internal static object? _FF00_FF00_FF00_FF00_FF00_FF00숀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object?)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00쌀(object? P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (0 == 0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0051: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_0048: Expected Obj, but got I4
			//IL_015e: Expected Obj, but got Ref
			//IL_0435: Expected Obj, but got I4
			//IL_0426: Expected Obj, but got Ref
			//IL_00de: Expected Obj, but got I4
			//IL_0413: Expected Obj, but got I4
			//IL_0297: Expected Obj, but got Ref
			//IL_02cf: Expected Obj, but got Ref
			//IL_01df: Expected Obj, but got I4
			//IL_01e9: Expected Obj, but got I4
			//IL_028e: Expected Obj, but got I4
			//IL_0230: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0586->IL0019: Incompatible stack heights: 2 vs 1
			//IL_005b->IL0019: Incompatible stack types: I4 vs Ref
			//IL_05ab->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0591->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0168->IL007e: Incompatible stack types: I4 vs Ref
			//IL_006f->IL007e: Incompatible stack heights: 0 vs 1
			//IL_007a->IL007e: Incompatible stack types: I4 vs Ref
			//IL_045f->IL007e: Incompatible stack heights: 3 vs 1
			//IL_0442->IL007e: Incompatible stack heights: 2 vs 1
			//IL_00f4->IL007e: Incompatible stack heights: 2 vs 1
			//IL_04cf->IL007e: Incompatible stack heights: 2 vs 1
			//IL_014f->IL007e: Incompatible stack heights: 2 vs 1
			//IL_040e->IL007e: Incompatible stack heights: 2 vs 1
			//IL_0430->IL007e: Incompatible stack heights: 2 vs 1
			//IL_041e->IL007e: Incompatible stack heights: 3 vs 1
			//IL_046a->IL007e: Incompatible stack heights: 3 vs 1
			//IL_044d->IL007e: Incompatible stack heights: 2 vs 1
			//IL_00ff->IL007e: Incompatible stack heights: 2 vs 1
			//IL_0484->IL007e: Incompatible stack types: I4 vs Ref
			//IL_04da->IL007e: Incompatible stack heights: 2 vs 1
			//IL_04ed->IL007e: Incompatible stack heights: 0 vs 1
			//IL_015a->IL007e: Incompatible stack heights: 2 vs 1
			//IL_0110->IL007e: Incompatible stack types: I4 vs Ref
			//IL_0498->IL007e: Incompatible stack heights: 0 vs 1
			//IL_007e->IL007e: Incompatible stack types: Obj vs Ref
			//IL_0133->IL007e: Incompatible stack heights: 0 vs 1
			//IL_04f8->IL007e: Incompatible stack types: I4 vs Ref
			//IL_04a3->IL007e: Incompatible stack types: I4 vs Ref
			//IL_02ae->IL018c: Incompatible stack heights: 1 vs 0
			//IL_0188->IL018c: Incompatible stack heights: 1 vs 0
			//IL_013e->IL007e: Incompatible stack types: I4 vs Ref
			//IL_0293->IL0188: Incompatible stack heights: 0 vs 2
			//IL_0307->IL018c: Incompatible stack heights: 2 vs 0
			//IL_022b->IL018c: Incompatible stack heights: 2 vs 0
			//IL_01ff->IL018c: Incompatible stack heights: 1 vs 0
			//IL_023d->IL018c: Incompatible stack heights: 2 vs 0
			//IL_025a->IL018c: Incompatible stack heights: 3 vs 0
			//IL_0321->IL018c: Incompatible stack heights: 1 vs 0
			//IL_02e6->IL018c: Incompatible stack heights: 1 vs 0
			//IL_018c->IL018c: Incompatible stack heights: 3 vs 0
			//IL_02c9->IL018c: Incompatible stack heights: 1 vs 0
			//IL_0312->IL018c: Incompatible stack heights: 2 vs 0
			//IL_020a->IL018c: Incompatible stack heights: 1 vs 0
			//IL_0248->IL018c: Incompatible stack heights: 2 vs 0
			//IL_02f7->IL018c: Incompatible stack heights: 1 vs 0
			//IL_0265->IL018c: Incompatible stack heights: 3 vs 0
			//IL_032c->IL018c: Incompatible stack heights: 1 vs 0
			//IL_034a->IL018c: Incompatible stack heights: 1 vs 0
			//IL_0370->IL018c: Incompatible stack heights: 1 vs 0
			//IL_0284->IL018c: Incompatible stack heights: 1 vs 0
			//IL_037b->IL018c: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			while (true)
			{
				ref _003CLoginHistoryAccount_003Ed__24 reference = ref *(_003CLoginHistoryAccount_003Ed__24*)obj;
				while (true)
				{
					ref object reference2;
					switch ((uint)Unsafe.AsPointer(ref reference))
					{
					case 3u:
						break;
					case 2u:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(_003CLoginHistoryAccount_003Ed__24*)4;
						continue;
					case 4u:
						if (obj != null)
						{
							if (9 == 0)
							{
								reference2 = ref *(object*)12;
							}
							goto IL_007e;
						}
						goto IL_015a;
					case 1u:
						goto IL_0576;
					default:
						reference = ref this;
						if (5 == 0)
						{
							reference = ref *(_003CLoginHistoryAccount_003Ed__24*)5;
						}
						continue;
					case 5u:
						return;
						IL_007e:
						while (true)
						{
							switch ((uint)Unsafe.AsPointer(ref reference2))
							{
							case 16u:
								obj = 14;
								reference2 = ref *(object*)obj;
								continue;
							case 4u:
								if (10 == 0)
								{
									_ = 8;
								}
								continue;
							case 10u:
								if (Unsafe.AsPointer(ref this) == null)
								{
									reference2 = ref *(object*)8;
									continue;
								}
								goto case 16u;
							case 7u:
								return;
							case 17u:
								if (&obj == null)
								{
									if (2 == 0)
									{
										reference2 = ref *(object*)1;
									}
									continue;
								}
								goto case 5u;
							case 9u:
								_ = null;
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							case 3u:
								break;
							case 14u:
								if ((nint)obj != 1)
								{
									if (0 == 0)
									{
										_ = 0;
									}
									goto IL_018c;
								}
								goto IL_0293;
							case 13u:
								_ = 18;
								continue;
							case 18u:
								obj = -1;
								_ = 5;
								continue;
							case 15u:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 17;
								continue;
							case 2u:
								obj = 0;
								if (6 == 0)
								{
									_ = 2;
								}
								continue;
							case 1u:
								_ = ref obj;
								if (1 == 0)
								{
									_ = 7;
								}
								continue;
							case 5u:
								reference2 = ref obj;
								if (9 == 0)
								{
									reference2 = ref *(object*)11;
								}
								continue;
							case 12u:
								if ((nint)obj != 1)
								{
									if (1 == 0)
									{
										reference2 = ref *(object*)4;
									}
									continue;
								}
								goto case 16u;
							case 6u:
								if (1 == 0)
								{
									_ = 1;
								}
								continue;
							case 8u:
								if ((int)/*Error near IL_04e1: Stack underflow*/ != 0)
								{
									if (3 == 0)
									{
										reference2 = ref *(object*)15;
									}
									continue;
								}
								goto case 16u;
							default:
								goto IL_0576;
								IL_0293:
								obj = (object)Unsafe.AsPointer(ref this);
								if (3 == 0)
								{
									_ = 16;
								}
								goto IL_018c;
								IL_018c:
								while (true)
								{
									switch ((int)/*Error near IL_01d5: Stack underflow*/)
									{
									case 6:
										break;
									case 1:
										obj = -1;
										obj = 5;
										continue;
									case 9:
										if (2 != 0)
										{
											_ = 2;
										}
										continue;
									case 7:
										return;
									case 5:
										_ = ref obj;
										_ = 3;
										continue;
									case 10:
										obj = 1;
										if (4 != 0)
										{
											_ = 4;
										}
										continue;
									case 14:
										_ = ref obj;
										if (0 == 0)
										{
											_ = 7;
										}
										continue;
									case 15:
										if (&obj == null)
										{
											if (true)
											{
												_ = 10;
											}
											continue;
										}
										goto case 5;
									case 2:
										obj = 8;
										continue;
									case 12:
										goto IL_0293;
									case 3:
										if (11 == 0)
										{
											_ = 2;
										}
										continue;
									default:
										obj = (object)Unsafe.AsPointer(ref this);
										if (15 != 0)
										{
											_ = 0;
										}
										continue;
									case 11:
										if (Unsafe.AsPointer(ref this) == null)
										{
											_ = 9;
											continue;
										}
										goto case 8;
									case 4:
										if (9 != 0)
										{
											_ = 14;
										}
										continue;
									case 16:
										if (0 == 0)
										{
											_ = 1;
										}
										continue;
									case 8:
										if (Unsafe.AsPointer(ref this) == null)
										{
										}
										_ = 13;
										continue;
									case 13:
										if (Unsafe.AsPointer(ref this) != null)
										{
										}
										_ = null;
										if (6 != 0)
										{
											_ = 2;
										}
										continue;
									}
									break;
								}
								goto case 9u;
							}
							break;
						}
						goto IL_015a;
						IL_0576:
						_ = -2;
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
						IL_015a:
						obj = (object)Unsafe.AsPointer(ref this);
						reference2 = ref *(object*)13;
						goto IL_007e;
					}
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
				obj = 2;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00넀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00눀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777753, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? _FF00_FF00_FF00_FF00_FF00_FF00대()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object?)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00됀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777830, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00딀(object? P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (0 == 0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_004d: Expected Obj, but got Ref
			//IL_0121: Expected I4, but got Obj
			//IL_05ef: Expected Obj, but got Ref
			//IL_061d: Expected Obj, but got Ref
			//IL_081e: Expected Obj, but got Ref
			//IL_0827: Expected Obj, but got I4
			//IL_041a: Expected Obj, but got Ref
			//IL_0423: Expected Obj, but got I4
			//IL_04b2: Expected Obj, but got Ref
			//IL_036a: Expected Obj, but got Ref
			//IL_0869: Expected Obj, but got Ref
			//IL_04f5: Expected Obj, but got Ref
			//IL_04db: Expected Obj, but got Ref
			//IL_05a9: Expected Obj, but got I4
			//IL_053d: Expected Obj, but got Ref
			//IL_0c8b: Expected Obj, but got Ref
			//IL_0ba0: Expected Obj, but got I4
			//IL_0b4d: Expected Obj, but got I4
			//IL_0734: Unknown result type (might be due to invalid IL or missing references)
			//IL_074e: Expected I4, but got Unknown
			//IL_0bf4: Expected Obj, but got Ref
			//IL_0a4a: Expected Obj, but got I4
			//IL_051f: Expected Obj, but got Ref
			//IL_058d: Expected Obj, but got Ref
			//IL_0956: Expected Obj, but got Ref
			//IL_0878: Expected Obj, but got I4
			//IL_0831: Expected Obj, but got Ref
			//IL_09f8: Expected Obj, but got I4
			//IL_090c: Expected I4, but got Obj
			//IL_0791: Expected Obj, but got I4
			//IL_0bd7: Expected Obj, but got I4
			//IL_07e9: Expected Obj, but got Ref
			//IL_05e1: Expected Obj, but got Ref
			//IL_070e: Expected Obj, but got I4
			//IL_043c: Expected Obj, but got I4
			//IL_04c8: Expected Obj, but got I4
			//IL_0348: Expected Obj, but got I4
			//IL_0943: Expected Obj, but got I4
			//IL_0b30: Expected Obj, but got I4
			//IL_03e7: Expected Obj, but got I4
			//IL_0665: Expected Obj, but got I4
			//IL_0af0: Expected Obj, but got Ref
			//IL_09b1: Expected Obj, but got I4
			//IL_0bc8: Expected I4, but got Obj
			//IL_05ce: Expected Obj, but got I4
			//IL_05d7: Expected Obj, but got I4
			//IL_072c: Expected Obj, but got I4
			//IL_0a60: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0049->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0059->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0f04->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0f0f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_007e->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0e7f->IL00a2: Incompatible stack heights: 2 vs 0
			//IL_00c3->IL00c8: Incompatible stack heights: 0 vs 1
			//IL_009e->IL00a2: Incompatible stack heights: 1 vs 0
			//IL_0e6b->IL00a2: Incompatible stack heights: 1 vs 0
			//IL_0627->IL012f: Incompatible stack heights: 1 vs 0
			//IL_04bc->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0374->IL012f: Incompatible stack heights: 1 vs 0
			//IL_012b->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0606->IL012f: Incompatible stack heights: 1 vs 0
			//IL_012f->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0494->IL012f: Incompatible stack heights: 3 vs 0
			//IL_0457->IL012f: Incompatible stack heights: 4 vs 0
			//IL_0873->IL012f: Incompatible stack heights: 1 vs 0
			//IL_08d1->IL012f: Incompatible stack heights: 1 vs 0
			//IL_03cf->IL012f: Incompatible stack heights: 2 vs 0
			//IL_04e5->IL012f: Incompatible stack heights: 4 vs 0
			//IL_05b6->IL012f: Incompatible stack heights: 2 vs 0
			//IL_0547->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0480->IL012f: Incompatible stack heights: 3 vs 0
			//IL_0c95->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0ba5->IL012b: Incompatible stack heights: 2 vs 0
			//IL_0b58->IL012f: Incompatible stack heights: 3 vs 0
			//IL_0644->IL012f: Incompatible stack heights: 3 vs 0
			//IL_0467->IL012f: Incompatible stack heights: 2 vs 0
			//IL_0327->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0a4f->IL012b: Incompatible stack heights: 1 vs 0
			//IL_0529->IL012f: Incompatible stack heights: 1 vs 0
			//IL_089f->IL012f: Incompatible stack heights: 2 vs 0
			//IL_0597->IL012f: Incompatible stack heights: 3 vs 0
			//IL_06b3->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0960->IL012f: Incompatible stack heights: 2 vs 0
			//IL_0885->IL012f: Incompatible stack heights: 2 vs 0
			//IL_0a05->IL012f: Incompatible stack heights: 2 vs 0
			//IL_0539->IL012f: Incompatible stack heights: 2 vs 0
			//IL_0b75->IL012f: Incompatible stack heights: 1 vs 0
			//IL_079b->IL012f: Incompatible stack heights: 4 vs 0
			//IL_07c1->IL012f: Incompatible stack heights: 3 vs 0
			//IL_09ac->IL012f: Incompatible stack heights: 2 vs 0
			//IL_03fa->IL012f: Incompatible stack heights: 3 vs 0
			//IL_06fe->IL012f: Incompatible stack heights: 3 vs 0
			//IL_0a83->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0be4->IL012f: Incompatible stack heights: 2 vs 0
			//IL_09f3->IL012f: Incompatible stack heights: 2 vs 0
			//IL_0933->IL012f: Incompatible stack heights: 2 vs 0
			//IL_03b4->IL012f: Incompatible stack heights: 1 vs 0
			//IL_07f5->IL012f: Incompatible stack heights: 3 vs 0
			//IL_0aa0->IL012f: Incompatible stack heights: 3 vs 0
			//IL_05eb->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0719->IL012f: Incompatible stack heights: 3 vs 0
			//IL_0447->IL012f: Incompatible stack heights: 3 vs 0
			//IL_0c63->IL012f: Incompatible stack heights: 3 vs 0
			//IL_04cd->IL012b: Incompatible stack heights: 1 vs 0
			//IL_0338->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0353->IL012f: Incompatible stack heights: 3 vs 0
			//IL_0784->IL012f: Incompatible stack heights: 4 vs 0
			//IL_0b66->IL012f: Incompatible stack heights: 2 vs 0
			//IL_094e->IL012f: Incompatible stack heights: 3 vs 0
			//IL_0b3d->IL012f: Incompatible stack heights: 2 vs 0
			//IL_03ec->IL012b: Incompatible stack heights: 2 vs 0
			//IL_0672->IL012f: Incompatible stack heights: 2 vs 0
			//IL_0afa->IL012f: Incompatible stack heights: 1 vs 0
			//IL_08af->IL012f: Incompatible stack heights: 2 vs 0
			//IL_0557->IL012f: Incompatible stack heights: 4 vs 0
			//IL_05a4->IL012f: Incompatible stack heights: 2 vs 0
			//IL_09be->IL012f: Incompatible stack heights: 2 vs 0
			//IL_080f->IL012f: Incompatible stack heights: 1 vs 0
			//IL_08e9->IL012f: Incompatible stack heights: 2 vs 0
			//IL_04f0->IL012f: Incompatible stack heights: 1 vs 0
			//IL_085a->IL012f: Incompatible stack heights: 3 vs 0
			//IL_0b11->IL012f: Incompatible stack heights: 1 vs 0
			//IL_05dc->IL012b: Incompatible stack heights: 3 vs 0
			//IL_049f->IL012f: Incompatible stack heights: 3 vs 0
			//IL_03a2->IL012f: Incompatible stack heights: 1 vs 0
			//IL_08dc->IL012f: Incompatible stack heights: 1 vs 0
			//IL_03da->IL012f: Incompatible stack heights: 2 vs 0
			//IL_050c->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0637->IL012f: Incompatible stack heights: 1 vs 0
			//IL_05c1->IL012f: Incompatible stack heights: 2 vs 0
			//IL_09db->IL012f: Incompatible stack heights: 2 vs 0
			//IL_06d0->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0472->IL012f: Incompatible stack heights: 2 vs 0
			//IL_0c0b->IL012f: Incompatible stack heights: 1 vs 0
			//IL_06be->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0890->IL012f: Incompatible stack heights: 2 vs 0
			//IL_0848->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0a10->IL012f: Incompatible stack heights: 2 vs 0
			//IL_0b80->IL012f: Incompatible stack heights: 1 vs 0
			//IL_07cc->IL012f: Incompatible stack heights: 3 vs 0
			//IL_0ce1->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0709->IL012f: Incompatible stack heights: 3 vs 0
			//IL_0a8e->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0bef->IL012f: Incompatible stack heights: 2 vs 0
			//IL_093e->IL012f: Incompatible stack heights: 2 vs 0
			//IL_03bf->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0800->IL012f: Incompatible stack heights: 3 vs 0
			//IL_0aab->IL012f: Incompatible stack heights: 3 vs 0
			//IL_097b->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0343->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0aeb->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0d03->IL012f: Incompatible stack heights: 2 vs 0
			//IL_07af->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0b48->IL012f: Incompatible stack heights: 2 vs 0
			//IL_0573->IL012f: Incompatible stack heights: 1 vs 0
			//IL_067d->IL012f: Incompatible stack heights: 2 vs 0
			//IL_08ba->IL012f: Incompatible stack heights: 2 vs 0
			//IL_09c9->IL012f: Incompatible stack heights: 2 vs 0
			//IL_081a->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0ca2->IL0ca8: Incompatible stack heights: 0 vs 2
			//IL_0c75->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0865->IL012f: Incompatible stack heights: 3 vs 0
			//IL_0b1c->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0bd2->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0aca->IL012f: Incompatible stack heights: 1 vs 0
			//IL_09e6->IL012f: Incompatible stack heights: 2 vs 0
			//IL_0765->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0923->IL012f: Incompatible stack heights: 1 vs 0
			//IL_069c->IL012f: Incompatible stack heights: 1 vs 0
			//IL_0cf2->IL012f: Incompatible stack heights: 2 vs 0
			//IL_0cbd->IL012f: Incompatible stack heights: 3 vs 0
			//IL_0cc8->IL012f: Incompatible stack heights: 3 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			ref _003CLoginMobile_003Ed__88 reference = ref *(_003CLoginMobile_003Ed__88*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 1u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CLoginMobile_003Ed__88*)4;
					continue;
				case 2u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						reference = ref *(_003CLoginMobile_003Ed__88*)null;
					}
					continue;
				case 5u:
					reference = ref this;
					if (0 == 0)
					{
						reference = ref *(_003CLoginMobile_003Ed__88*)null;
					}
					continue;
				case 4u:
					if ((nuint)(nint)obj <= (nuint)5u)
					{
						if (false)
						{
							_ = 0;
						}
						goto IL_00a2;
					}
					goto IL_0e6b;
				case 3u:
					break;
				case 0u:
					return;
					IL_0e6b:
					if (Unsafe.AsPointer(ref this) != null)
					{
						break;
					}
					_ = 2;
					goto IL_00a2;
					IL_00a2:
					while (true)
					{
						switch ((int)/*Error near IL_00c3: Stack underflow*/)
						{
						case 4:
							break;
						default:
							if (4 == 0)
							{
								_ = 4;
							}
							continue;
						case 5:
							goto IL_0e6b;
						case 3:
						case 6:
							goto end_IL_0019;
						}
						break;
					}
					switch ((int)obj)
					{
					default:
						_ = 13;
						goto IL_012f;
					case 5:
						obj = (object)Unsafe.AsPointer(ref this);
						_ = 49;
						goto IL_012f;
					case 3:
						goto IL_0416;
					case 4:
						goto IL_04ae;
					case 0:
						goto IL_05eb;
					case 1:
						goto IL_0619;
					case 2:
						goto IL_081a;
						IL_012f:
						while (true)
						{
							switch ((int)/*Error near IL_0304: Stack underflow*/)
							{
							case 30:
								obj = obj;
								_ = 20;
								continue;
							case 82:
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							case 86:
								obj = 4;
								_ = 94;
								continue;
							case 68:
								break;
							case 1:
								obj = (object)/*Error near IL_038b: Stack underflow*/;
								if (112 == 0)
								{
									_ = 53;
								}
								continue;
							case 69:
								if (5 == 0)
								{
									_ = 54;
								}
								continue;
							case 5:
								if (5 != 0)
								{
									_ = 55;
								}
								continue;
							case 94:
								obj = 87;
								continue;
							case 60:
								_ = 1;
								_ = 79;
								continue;
							case 110:
								goto IL_0416;
							case 77:
								obj = -1;
								_ = 7;
								continue;
							case 2:
								_ = ref obj;
								_ = 15;
								continue;
							case 24:
								if (100 == 0)
								{
									_ = 27;
								}
								continue;
							case 16:
								_ = 2;
								continue;
							default:
								_ = 0;
								if (108 == 0)
								{
									_ = 40;
								}
								continue;
							case 27:
								goto IL_04ae;
							case 81:
								obj = 92;
								continue;
							case 9:
								_ = 1;
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 8;
								continue;
							case 108:
								_ = 65;
								continue;
							case 7:
								obj = (object)(&obj);
								if (2 != 0)
								{
									_ = 83;
								}
								continue;
							case 40:
								return;
							case 12:
							case 34:
							case 50:
							case 54:
								goto IL_051b;
							case 46:
								goto IL_0529;
							case 13:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 28;
								continue;
							case 100:
								_ = ref obj;
								_ = 11;
								continue;
							case 33:
							case 95:
								if (1 == 0)
								{
									_ = 1;
								}
								continue;
							case 78:
								return;
							case 36:
								goto IL_0582;
							case 101:
								_ = 21;
								continue;
							case 10:
								obj = 0;
								if (5 != 0)
								{
									_ = 5;
								}
								continue;
							case 115:
								goto IL_05c1;
							case 73:
								obj = (object)(&obj);
								_ = 111;
								continue;
							case 67:
								goto IL_05eb;
							case 80:
								return;
							case 74:
								goto IL_0619;
							case 57:
							case 63:
								goto IL_0627;
							case 8:
							case 18:
							case 56:
							case 97:
							case 105:
							case 107:
								obj = obj;
								_ = 44;
								continue;
							case 23:
								_ = null;
								_ = 37;
								continue;
							case 96:
								obj = 1;
								if (10 != 0)
								{
									_ = 19;
								}
								continue;
							case 48:
								if (&obj == null)
								{
									if (15 == 0)
									{
										_ = 64;
									}
									continue;
								}
								goto case 98;
							case 38:
								goto IL_069c;
							case 22:
								if (&obj == null)
								{
									_ = 86;
									continue;
								}
								goto case 73;
							case 61:
								_ = ref obj;
								if (40 == 0)
								{
									_ = 23;
								}
								continue;
							case 76:
								obj = -1;
								_ = 29;
								continue;
							case 44:
								if (obj != null)
								{
									obj = 25;
									continue;
								}
								goto case 82;
							case 28:
								switch (obj - 2)
								{
								case 4:
									break;
								case 3:
									goto IL_051b;
								case 1:
								case 2:
									goto IL_0529;
								default:
									goto IL_074e;
								case 0:
									goto IL_0a3b;
								}
								goto case 69;
							case 87:
								_ = ref obj;
								_ = 78;
								continue;
							case 52:
								goto IL_0784;
							case 14:
							case 90:
								goto IL_079b;
							case 55:
								_ = ref obj;
								if (80 == 0)
								{
									_ = 24;
								}
								continue;
							case 71:
								goto IL_07db;
							case 103:
								if (27 == 0)
								{
									_ = 77;
								}
								continue;
							case 89:
								goto IL_081a;
							case 42:
							case 51:
								obj = (object)(&obj);
								if (40 != 0)
								{
									_ = 43;
								}
								continue;
							case 112:
								_ = 1;
								if (2 == 0)
								{
									_ = 3;
								}
								continue;
							case 3:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 47;
								continue;
							case 41:
								obj = 2;
								if (16 != 0)
								{
									_ = 0;
								}
								continue;
							case 35:
								_ = 17;
								continue;
							case 99:
								if (53 != 0)
								{
									_ = 61;
								}
								continue;
							case 4:
								goto IL_08ba;
							case 104:
								_ = 45;
								continue;
							case 47:
								switch ((int)obj)
								{
								case 2:
									break;
								case 4:
									goto IL_0582;
								case 5:
									goto IL_05c1;
								case 1:
									goto IL_0627;
								case 6:
									goto IL_0784;
								case 3:
									goto IL_07db;
								default:
									goto IL_090c;
								case 0:
									goto IL_094e;
								}
								goto case 9;
							case 66:
								_ = null;
								if (60 != 0)
								{
									_ = 45;
								}
								continue;
							case 92:
								obj = -1;
								_ = 73;
								continue;
							case 39:
								goto IL_094e;
							case 75:
								if (41 != 0)
								{
									_ = 58;
								}
								continue;
							case 59:
								goto IL_0997;
							case 102:
								obj = -1;
								if (false)
								{
									_ = 88;
								}
								continue;
							case 26:
							case 31:
								goto IL_09c9;
							case 20:
							case 43:
							case 70:
							case 83:
							case 91:
							case 111:
								if (35 != 0)
								{
									_ = 24;
								}
								continue;
							case 25:
							case 65:
								_ = 66;
								continue;
							case 45:
								obj = -1;
								if (10 != 0)
								{
									_ = 42;
								}
								continue;
							case 15:
								return;
							case 11:
								return;
							case 32:
								goto IL_0a3b;
							case 85:
								if (&obj != null)
								{
									obj = 51;
									continue;
								}
								goto case 96;
							case 62:
								if (76 != 0)
								{
									_ = 67;
								}
								continue;
							case 72:
								_ = ref obj;
								if (53 != 0)
								{
									_ = 18;
								}
								continue;
							case 6:
								if (&obj == null)
								{
									if (10 == 0)
									{
										_ = 1;
									}
									continue;
								}
								goto case 29;
							case 84:
								if (&obj == null)
								{
									_ = 41;
									continue;
								}
								goto case 7;
							case 98:
								obj = (object)(&obj);
								_ = 91;
								continue;
							case 113:
								goto IL_0afa;
							case 93:
								obj = 5;
								if (24 != 0)
								{
									_ = 11;
								}
								continue;
							case 21:
								obj = -1;
								_ = 98;
								continue;
							case 88:
								_ = ref obj;
								_ = 75;
								continue;
							case 49:
								if (98 != 0)
								{
									_ = 102;
								}
								continue;
							case 19:
								obj = 72;
								continue;
							case 114:
								switch ((int)obj)
								{
								case 0:
									break;
								case 3:
									goto IL_069c;
								case 6:
									goto IL_08ba;
								case 2:
									goto IL_0997;
								case 1:
									goto IL_09c9;
								case 4:
									goto IL_0afa;
								default:
									goto IL_0bc8;
								case 5:
									goto IL_0c95;
								}
								goto case 30;
							case 64:
								obj = 3;
								if (99 == 0)
								{
									_ = 44;
								}
								continue;
							case 29:
								obj = (object)(&obj);
								if (48 != 0)
								{
									_ = 70;
								}
								continue;
							case 53:
								return;
							case 79:
								_ = null;
								_ = 23;
								continue;
							case 109:
								if (&obj == null)
								{
									_ = 93;
									continue;
								}
								goto case 88;
							case 17:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 109;
								continue;
							case 106:
								goto IL_0c95;
							case 58:
								goto IL_0cc8;
							case 37:
								goto end_IL_0104;
								IL_0c95:
								if ((int)/*Error near IL_0c97: Stack underflow*/ == 0)
								{
									_ = null;
								}
								obj = null;
								if (4 == 0)
								{
									_ = 6;
								}
								continue;
								IL_0bc8:
								_ = 31;
								continue;
								IL_0afa:
								obj = obj;
								if (22 == 0)
								{
									_ = 3;
								}
								continue;
								IL_0627:
								throw /*Error near IL_0629: Stack underflow*/;
								IL_05c1:
								_ = 1;
								obj = 1;
								obj = 56;
								continue;
								IL_0582:
								_ = 1;
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 105;
								continue;
								IL_09c9:
								throw /*Error near IL_09cb: Stack underflow*/;
								IL_0997:
								obj = obj;
								_ = 84;
								continue;
								IL_094e:
								_ = 1;
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 97;
								continue;
								IL_090c:
								if (63 == 0)
								{
									_ = 39;
								}
								continue;
								IL_0529:
								_ = 34;
								continue;
								IL_08ba:
								obj = obj;
								if (85 == 0)
								{
									_ = 40;
								}
								continue;
								IL_051b:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 114;
								continue;
								IL_07db:
								_ = 1;
								obj = (object)Unsafe.AsPointer(ref this);
								if (18 != 0)
								{
									_ = 1;
								}
								continue;
								IL_0784:
								_ = 1;
								obj = 0;
								_ = 107;
								continue;
								IL_0a3b:
								obj = 12;
								continue;
								IL_074e:
								if (50 == 0)
								{
									_ = 1;
								}
								continue;
								IL_069c:
								obj = obj;
								if (48 == 0)
								{
									_ = 16;
								}
								continue;
							}
							break;
							IL_0cc8:
							if (obj == null)
							{
								_ = 14;
							}
							else
							{
								_ = 90;
							}
							continue;
							IL_079b:
							if (obj == null)
							{
								_ = 33;
							}
							else
							{
								_ = 95;
							}
						}
						goto case 5;
						IL_081a:
						obj = (object)Unsafe.AsPointer(ref this);
						obj = 103;
						goto IL_012f;
						IL_0619:
						obj = (object)Unsafe.AsPointer(ref this);
						_ = 104;
						goto IL_012f;
						IL_05eb:
						obj = (object)Unsafe.AsPointer(ref this);
						if (62 == 0)
						{
							_ = 23;
						}
						goto IL_012f;
						IL_04ae:
						obj = (object)Unsafe.AsPointer(ref this);
						_ = 81;
						goto IL_012f;
						IL_0416:
						obj = (object)Unsafe.AsPointer(ref this);
						obj = 101;
						goto IL_012f;
						end_IL_0104:
						break;
					}
					break;
					end_IL_0019:
					break;
				}
				_ = -2;
				if (5 != 0)
				{
					_ = 5;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00ꔀ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00ꘀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777827, new IntPtr(2737335735116L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? _FF00_FF00_FF00_FF00_FF00_FF00_A700()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object?)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00ꠀ(object? P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (false)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0075: Expected Obj, but got Ref
			//IL_01e4: Expected Obj, but got I4
			//IL_018f: Expected Obj, but got I4
			//IL_01d0: Expected Obj, but got I4
			//IL_013d: Expected Obj, but got Ref
			//IL_016b: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_007f->IL0019: Incompatible stack types: I4 vs Ref
			//IL_026f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0071->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0056->IL0019: Incompatible stack types: I4 vs Ref
			//IL_027a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0166->IL00a2: Incompatible stack heights: 1 vs 0
			//IL_009e->IL00a2: Incompatible stack heights: 1 vs 0
			//IL_01ee->IL00a2: Incompatible stack heights: 2 vs 0
			//IL_012a->IL00a2: Incompatible stack heights: 3 vs 0
			//IL_01bd->IL00a2: Incompatible stack heights: 2 vs 0
			//IL_01db->IL00a2: Incompatible stack heights: 3 vs 0
			//IL_0178->IL00a2: Incompatible stack heights: 2 vs 0
			//IL_0111->IL00a2: Incompatible stack heights: 3 vs 0
			//IL_00a2->IL00a2: Incompatible stack heights: 2 vs 0
			//IL_0154->IL00a2: Incompatible stack heights: 1 vs 0
			//IL_0183->IL00a2: Incompatible stack heights: 2 vs 0
			//IL_011c->IL00a2: Incompatible stack heights: 3 vs 0
			//IL_00ff->IL00a2: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			ref _003CLoginRandom_003Ed__85 reference = ref *(_003CLoginRandom_003Ed__85*)obj;
			while (true)
			{
				object obj2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						reference = ref *(_003CLoginRandom_003Ed__85*)2;
					}
					continue;
				case 1u:
					return;
				default:
					reference = ref this;
					if (true)
					{
						reference = ref *(_003CLoginRandom_003Ed__85*)1;
					}
					continue;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CLoginRandom_003Ed__85*)3;
					continue;
				case 2u:
					if (obj == null)
					{
						if (9 == 0)
						{
							_ = 10;
						}
						goto IL_00a2;
					}
					goto IL_0154;
				case 5u:
					break;
					IL_01bd:
					obj2 = obj;
					goto IL_01df;
					IL_0154:
					if (obj != null)
					{
						_ = 7;
						goto IL_00a2;
					}
					obj2 = obj;
					goto IL_01df;
					IL_01df:
					obj = 5;
					_ = 2;
					goto IL_00a2;
					IL_00a2:
					while (true)
					{
						switch ((int)/*Error near IL_00db: Stack underflow*/)
						{
						case 6:
							return;
						case 2:
							if (&obj == null)
							{
								if (9 != 0)
								{
									_ = 11;
								}
								continue;
							}
							goto case 4;
						case 12:
							_ = ref obj;
							if (4 == 0)
							{
								_ = 6;
							}
							continue;
						default:
							_ = 12;
							continue;
						case 8:
						case 10:
							obj = (object)Unsafe.AsPointer(ref this);
							if (true)
							{
								_ = 0;
							}
							continue;
						case 3:
							break;
						case 11:
							obj = 0;
							if (false)
							{
								_ = 0;
							}
							continue;
						case 4:
							_ = ref obj;
							obj = 9;
							continue;
						case 1:
							_ = 5;
							continue;
						case 7:
							goto IL_01bd;
						case 5:
							obj = -1;
							_ = 4;
							continue;
						case 9:
							goto end_IL_0019;
						}
						break;
					}
					goto IL_0154;
					end_IL_0019:
					break;
				}
				_ = -2;
				if (0 == 0)
				{
					_ = 0;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00阀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
		internal static object? _FF00_FF00_FF00_FF00_FF00_FF00餀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object?)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00騀(object? P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (0 == 0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0056: Expected Obj, but got I4
			//IL_0261: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_015a: Expected Obj, but got Ref
			//IL_0163: Expected Obj, but got I4
			//IL_00ae: Expected I4, but got Obj
			//IL_0115: Expected Obj, but got I4
			//IL_00e1: Expected Obj, but got I4
			//IL_011f: Expected Obj, but got I4
			//IL_016c: Expected Obj, but got Ref
			//IL_005b->IL0015: Incompatible stack heights: 1 vs 0
			//IL_026d->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0252->IL0019: Incompatible stack heights: 2 vs 1
			//IL_006d->IL0071: Incompatible stack types: I4 vs Ref
			//IL_0278->IL0019: Incompatible stack types: I4 vs Obj
			//IL_025d->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0071->IL0071: Incompatible stack types: Obj vs Ref
			//IL_011a->IL006d: Incompatible stack heights: 1 vs 0
			//IL_0109->IL0071: Incompatible stack heights: 4 vs 1
			//IL_01b7->IL0071: Incompatible stack heights: 3 vs 1
			//IL_00ee->IL0071: Incompatible stack heights: 2 vs 1
			//IL_013a->IL0071: Incompatible stack heights: 2 vs 1
			//IL_012a->IL0071: Incompatible stack heights: 3 vs 1
			//IL_0178->IL0071: Incompatible stack heights: 0 vs 1
			//IL_00dc->IL0071: Incompatible stack types: I4 vs Ref
			//IL_00f9->IL0071: Incompatible stack heights: 2 vs 1
			//IL_0145->IL0071: Incompatible stack heights: 2 vs 1
			//IL_0195->IL0071: Incompatible stack types: I4 vs Ref
			//IL_0183->IL0071: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					ref object reference;
					switch ((int)obj2)
					{
					case 4:
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 3;
						continue;
					case 2:
						return;
					case 1:
						break;
					default:
						if (obj == null)
						{
							reference = ref *(object*)5;
							goto IL_0071;
						}
						goto IL_0154;
					case 5:
						goto IL_0242;
					case 3:
						{
							obj = (object)Unsafe.AsPointer(ref this);
							if (0 == 0)
							{
								obj2 = 0;
							}
							continue;
						}
						IL_0242:
						_ = -2;
						if (true)
						{
							_ = 1;
						}
						continue;
						IL_0154:
						obj = (object)Unsafe.AsPointer(ref this);
						obj = 9;
						goto IL_006d;
						IL_006d:
						reference = ref *(object*)obj;
						goto IL_0071;
						IL_0071:
						while (true)
						{
							switch ((uint)Unsafe.AsPointer(ref reference))
							{
							case 11u:
								return;
							default:
								reference = ref obj;
								if (3 != 0)
								{
									reference = ref *(object*)3;
								}
								continue;
							case 6u:
								obj = -1;
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							case 2u:
								_ = ref obj;
								_ = 11;
								continue;
							case 1u:
								break;
							case 12u:
								obj = 0;
								_ = 7;
								continue;
							case 7u:
								if (2 == 0)
								{
									_ = 2;
								}
								continue;
							case 4u:
								goto IL_0154;
							case 5u:
							case 13u:
								obj = (object)Unsafe.AsPointer(ref this);
								if (true)
								{
									reference = ref *(object*)1;
								}
								continue;
							case 9u:
								if (&obj != null)
								{
									reference = ref *(object*)8;
									continue;
								}
								goto case 12u;
							case 3u:
								_ = null;
								_ = 10;
								continue;
							case 10u:
								goto IL_0242;
							}
							break;
						}
						obj = 6;
						goto IL_006d;
					}
					break;
				}
				obj = 2;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00贀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? _FF00_FF00_FF00_FF00_FF00_FF00踀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object?)/*Error near IL_0009: Stack underflow*/;
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
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00鄀(object? P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (false)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_038e: Expected Obj, but got Ref
			//IL_0397: Expected Obj, but got I4
			//IL_033d: Expected Obj, but got Ref
			//IL_019a: Expected Obj, but got I4
			//IL_0126: Expected Obj, but got I4
			//IL_00fb: Expected Obj, but got Ref
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0349->IL0019: Incompatible stack heights: 0 vs 1
			//IL_037f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0354->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0056->IL005a: Incompatible stack heights: 1 vs 0
			//IL_036e->IL0019: Incompatible stack types: I4 vs Ref
			//IL_038a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_02c8->IL005a: Incompatible stack heights: 3 vs 0
			//IL_02b7->IL005a: Incompatible stack heights: 1 vs 0
			//IL_01f0->IL0097: Incompatible stack heights: 1 vs 0
			//IL_01db->IL01db: Incompatible stack heights: 2 vs 0
			//IL_0093->IL0097: Incompatible stack heights: 1 vs 0
			//IL_01fb->IL0097: Incompatible stack heights: 1 vs 0
			//IL_01a7->IL0097: Incompatible stack heights: 2 vs 0
			//IL_0185->IL0097: Incompatible stack heights: 3 vs 0
			//IL_014d->IL0097: Incompatible stack heights: 1 vs 0
			//IL_0195->IL0097: Incompatible stack heights: 4 vs 0
			//IL_0133->IL0097: Incompatible stack heights: 2 vs 0
			//IL_0105->IL0097: Incompatible stack heights: 1 vs 0
			//IL_01b2->IL0097: Incompatible stack heights: 2 vs 0
			//IL_01cd->IL0097: Incompatible stack heights: 1 vs 0
			//IL_0158->IL0097: Incompatible stack heights: 1 vs 0
			//IL_013e->IL0097: Incompatible stack heights: 2 vs 0
			//IL_0177->IL0097: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			while (true)
			{
				ref _003CRegisterRandom4399_003Ed__84 reference = ref *(_003CRegisterRandom4399_003Ed__84*)obj;
				while (true)
				{
					switch ((uint)Unsafe.AsPointer(ref reference))
					{
					default:
						return;
					case 3u:
						if (false)
						{
							_ = 0;
						}
						while (true)
						{
							switch ((int)/*Error near IL_006f: Stack underflow*/)
							{
							case 2:
								if (obj == null)
								{
									if (11 != 0)
									{
										_ = 5;
									}
									goto IL_0097;
								}
								goto IL_01cd;
							default:
								if (2 != 0)
								{
									_ = 1;
								}
								continue;
							case 1:
								goto IL_02b7;
							case 3:
								break;
								IL_01cd:
								if ((int)/*Error near IL_01cf: Stack underflow*/ == 0)
								{
									_ = null;
								}
								obj = null;
								if (1 == 0)
								{
									_ = 0;
								}
								goto IL_0097;
								IL_0097:
								while (true)
								{
									switch ((int)/*Error near IL_00d0: Stack underflow*/)
									{
									case 11:
									case 12:
										obj = (object)Unsafe.AsPointer(ref this);
										_ = 8;
										continue;
									case 7:
										return;
									case 10:
										obj = -1;
										if (6 != 0)
										{
											_ = 3;
										}
										continue;
									case 8:
										if (10 == 0)
										{
											_ = 10;
										}
										continue;
									case 1:
										if (&obj != null)
										{
											if (5 == 0)
											{
												_ = 2;
											}
											continue;
										}
										goto case 2;
									case 4:
										_ = 9;
										continue;
									case 9:
										_ = ref obj;
										_ = 7;
										continue;
									case 2:
										obj = 0;
										if (1 == 0)
										{
											_ = 4;
										}
										continue;
									case 5:
									case 6:
										_ = ref obj;
										if (false)
										{
											_ = 0;
										}
										continue;
									case 3:
										break;
									default:
										goto IL_02b7;
									}
									break;
								}
								goto IL_01cd;
								IL_02b7:
								_ = 1;
								_ = 3;
								continue;
							}
							break;
						}
						break;
					case 2u:
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							reference = ref *(_003CRegisterRandom4399_003Ed__84*)1;
						}
						continue;
					case 4u:
						reference = ref this;
						if (0 == 0)
						{
							reference = ref *(_003CRegisterRandom4399_003Ed__84*)null;
						}
						continue;
					case 0u:
						return;
					case 5u:
						break;
					case 1u:
						goto end_IL_0019;
					}
					_ = -2;
					if (0 == 0)
					{
						_ = 4;
					}
					continue;
					end_IL_0019:
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
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
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00蘀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00_FF00蜀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777845, new IntPtr(2737335708076L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? _FF00_FF00_FF00_FF00_FF00_FF00蠀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object?)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00褀(object? P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (false)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_004d: Expected Obj, but got Ref
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got Ref
			//IL_0398: Expected Obj, but got Ref
			//IL_0315: Expected Obj, but got I4
			//IL_02f5: Expected Obj, but got I4
			//IL_02ff: Expected Obj, but got I4
			//IL_0134: Expected Obj, but got I4
			//IL_03d8: Expected Obj, but got I4
			//IL_0335: Expected Obj, but got I4
			//IL_037d: Expected Obj, but got I4
			//IL_010b: Expected I4, but got Obj
			//IL_01b4: Expected Obj, but got I4
			//IL_0274: Expected Obj, but got Ref
			//IL_021b: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0049->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0084->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0076->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0096->IL009a: Incompatible stack types: I4 vs Obj
			//IL_03a4->IL009a: Incompatible stack heights: 0 vs 1
			//IL_03af->IL009a: Incompatible stack types: I4 vs Obj
			//IL_0359->IL009a: Incompatible stack heights: 2 vs 1
			//IL_0376->IL009a: Incompatible stack heights: 3 vs 1
			//IL_04a9->IL009a: Incompatible stack heights: 2 vs 1
			//IL_0304->IL0096: Incompatible stack heights: 2 vs 0
			//IL_045a->IL009a: Incompatible stack heights: 2 vs 1
			//IL_0141->IL009a: Incompatible stack heights: 2 vs 1
			//IL_03ed->IL009a: Incompatible stack heights: 3 vs 1
			//IL_04b9->IL009a: Incompatible stack heights: 2 vs 1
			//IL_049c->IL009a: Incompatible stack types: I4 vs Obj
			//IL_03dd->IL0096: Incompatible stack heights: 1 vs 0
			//IL_0491->IL009a: Incompatible stack heights: 4 vs 1
			//IL_0341->IL009a: Incompatible stack heights: 0 vs 1
			//IL_0394->IL009a: Incompatible stack heights: 7 vs 1
			//IL_032c->IL009a: Incompatible stack types: I4 vs Obj
			//IL_0465->IL009a: Incompatible stack heights: 2 vs 1
			//IL_014c->IL009a: Incompatible stack heights: 2 vs 1
			//IL_04c4->IL009a: Incompatible stack heights: 2 vs 1
			//IL_034c->IL009a: Incompatible stack types: I4 vs Obj
			//IL_0124->IL009a: Incompatible stack heights: 0 vs 1
			//IL_041c->IL009a: Incompatible stack types: I4 vs Obj
			//IL_012f->IL009a: Incompatible stack types: I4 vs Obj
			//IL_01bf->IL0175: Incompatible stack heights: 3 vs 1
			//IL_0280->IL0175: Incompatible stack heights: 0 vs 1
			//IL_0270->IL0175: Incompatible stack heights: 3 vs 1
			//IL_0233->IL0175: Incompatible stack heights: 2 vs 1
			//IL_0226->IL0175: Incompatible stack heights: 3 vs 1
			//IL_01e8->IL0175: Incompatible stack heights: 2 vs 1
			//IL_0245->IL0175: Incompatible stack heights: 3 vs 1
			//IL_0250->IL0175: Incompatible stack heights: 3 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			while (true)
			{
				ref _003CSendVerifyCode_003Ed__78 reference = ref *(_003CSendVerifyCode_003Ed__78*)obj;
				while (true)
				{
					object obj2;
					switch ((uint)Unsafe.AsPointer(ref reference))
					{
					default:
						return;
					case 1u:
						_ = -2;
						_ = 2;
						continue;
					case 3u:
						break;
					case 0u:
						return;
					case 2u:
						reference = ref this;
						if (false)
						{
							reference = ref *(_003CSendVerifyCode_003Ed__78*)null;
						}
						continue;
					case 4u:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(_003CSendVerifyCode_003Ed__78*)3;
						continue;
					case 5u:
						{
							if (obj == null)
							{
								obj2 = 14;
								goto IL_009a;
							}
							goto IL_0304;
						}
						IL_0304:
						if ((nint)obj != 1)
						{
							obj = 26;
							goto IL_0096;
						}
						goto IL_0394;
						IL_0394:
						obj = (object)Unsafe.AsPointer(ref this);
						if (1 == 0)
						{
							obj2 = 0;
						}
						goto IL_009a;
						IL_009a:
						while (true)
						{
							int num;
							switch ((int)obj2)
							{
							case 8:
							case 10:
								break;
							case 16:
								return;
							case 23:
							case 25:
								if ((nint)Unsafe.AsPointer(ref this) > unchecked((nint)null))
								{
									if (3 != 0)
									{
										obj2 = 7;
									}
									continue;
								}
								goto IL_03cb;
							case 11:
								obj = -1;
								if (true)
								{
									_ = 4;
								}
								continue;
							case 18:
								if (obj == null)
								{
									num = 8;
									goto IL_0175;
								}
								goto IL_0250;
							case 6:
								goto IL_02f0;
							default:
								goto IL_0304;
							case 5:
								if (&obj != null)
								{
									obj2 = 2;
									continue;
								}
								goto IL_02f0;
							case 22:
								obj = 1000;
								if (5 != 0)
								{
									obj2 = 5;
								}
								continue;
							case 1:
								_ = 11;
								continue;
							case 3:
								_ = 20;
								continue;
							case 7:
							case 24:
								_ = 1;
								obj = 1;
								_ = ref obj;
								_ = ref obj;
								_ = ref obj;
								_ = 12;
								continue;
							case 21:
								goto IL_0394;
							case 19:
								goto IL_03cb;
							case 12:
								Unsafe.SubtractByteOffset(ref this, 1);
								_ = 22;
								continue;
							case 26:
								if (obj == null)
								{
									obj2 = 13;
									continue;
								}
								goto case 9;
							case 9:
								_ = 2;
								if (10 == 0)
								{
									_ = 6;
								}
								continue;
							case 20:
								_ = ref obj;
								_ = 16;
								continue;
							case 13:
							case 14:
							case 17:
								obj2 = 18;
								continue;
							case 2:
							case 4:
								_ = ref obj;
								_ = 25;
								continue;
							case 15:
								goto IL_04a9;
								IL_0250:
								obj = obj;
								num = 4;
								goto IL_0175;
								IL_0175:
								while (true)
								{
									switch (num)
									{
									case 1:
										return;
									case 2:
										obj = 0;
										_ = 5;
										continue;
									case 9:
										_ = 7;
										continue;
									case 4:
										if (&obj == null)
										{
											num = 2;
											continue;
										}
										goto case 6;
									case 7:
										obj = -1;
										_ = 6;
										continue;
									case 6:
										_ = ref obj;
										_ = 11;
										continue;
									case 10:
										_ = ref obj;
										if (0 == 0)
										{
											_ = 1;
										}
										continue;
									case 5:
										_ = 10;
										continue;
									case 3:
									case 8:
										obj = (object)Unsafe.AsPointer(ref this);
										if (6 == 0)
										{
											num = 9;
										}
										continue;
									case 11:
										goto IL_04a9;
									}
									break;
								}
								goto IL_0250;
								IL_04a9:
								_ = 60;
								if (19 == 0)
								{
									_ = 23;
								}
								continue;
							}
							break;
						}
						goto case 1u;
						IL_02f0:
						obj = 1;
						obj = 3;
						goto IL_0096;
						IL_03cb:
						obj = 8;
						goto IL_0096;
						IL_0096:
						obj2 = obj;
						goto IL_009a;
					}
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
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
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00簀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
		internal static object? _FF00_FF00_FF00_FF00_FF00_FF00缀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object?)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00耀(object? P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (0 == 0)
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
	public AccountViewModel()
	{
		//IL_0052: Expected I4, but got Obj
		//IL_007e: Expected Obj, but got I4
		//IL_0038->IL0041: Incompatible stack types: I4 vs Obj
		//IL_0067->IL0041: Incompatible stack heights: 5 vs 4
		//IL_0041->IL0041: Incompatible stack heights: 5 vs 4
		//IL_0072->IL0041: Incompatible stack heights: 5 vs 4
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		AccountViewModel accountViewModel = this;
		if (true)
		{
			accountViewModel = (AccountViewModel)1;
		}
		while (true)
		{
			switch ((int)accountViewModel)
			{
			case 1:
				_ = null;
				if (false)
				{
					_ = 0;
				}
				break;
			case 2:
				return;
			default:
			{
				object obj = 2;
				break;
			}
			}
		}
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00섀(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0041->IL0099: Incompatible stack heights: 1 vs 0
		//IL_007f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0099->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0058->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				obj2 = this;
				if (P_0 == null)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				return;
			case 4:
				obj2 = this;
				if (2 == 0)
				{
					obj2 = 3;
				}
				break;
			case 2:
				_ = 4;
				break;
			default:
				obj2 = this;
				if (2 == 0)
				{
					obj2 = 2;
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00쐀(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_005c->IL0051: Incompatible stack heights: 1 vs 0
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0051->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0073->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				if (3 != 0)
				{
					_ = 2;
				}
				break;
			case 4:
				return;
			case 1:
				obj2 = this;
				if (P_0 != 0)
				{
					return;
				}
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				obj2 = this;
				if (false)
				{
					obj2 = 2;
				}
				break;
			case 3:
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00윀(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0079->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0083->IL0037: Incompatible stack heights: 1 vs 0
		//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0052->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009a->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				if (2 == 0)
				{
					_ = 1;
				}
				break;
			case 2:
				obj2 = this;
				if (4 == 0)
				{
					obj2 = 3;
				}
				break;
			default:
				_ = 3;
				break;
			case 1:
				obj2 = this;
				if (P_0 != 0)
				{
					return;
				}
				if (false)
				{
					obj2 = 0;
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
	private void _FF00_FF00_FF00_FF00_FF00_FF00_FF00준(object? P_0, object? P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0059->IL0019: Incompatible stack heights: 2 vs 1
		//IL_003e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0064->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			case 1:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				return;
			default:
				if (0 == 0)
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00쬀(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0047: Expected Obj, but got I4
		//IL_004c->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0056->IL007a: Incompatible stack heights: 1 vs 0
		//IL_0094->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0060->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					goto end_IL_0019;
				case 4:
					if (P_0 != null)
					{
						_ = 3;
						continue;
					}
					break;
				case 2:
					obj2 = this;
					if (5 != 0)
					{
						obj2 = 5;
					}
					continue;
				case 3:
					return;
				case 5:
					return;
				}
				obj2 = this;
				if (false)
				{
					obj2 = 1;
				}
				continue;
				end_IL_0019:
				break;
			}
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00찀(Func<InfoBarDelegate?>? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00c1: Expected Obj, but got I4
		//IL_0089->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0094->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a9->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0074->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b4->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (false)
					{
						obj2 = 3;
					}
					continue;
				case 3:
					obj2 = obj;
					obj = P_0;
					if (true)
					{
						obj2 = 0;
					}
					continue;
				case 1:
					obj = obj;
					if (2 == 0)
					{
						_ = 2;
					}
					continue;
				case 2:
					if (obj == obj)
					{
						if (0 == 0)
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
			obj = this;
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
	private void _FF00_FF00_FF00_FF00_FF00_FF00_FF00츀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0044->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0069->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004f->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = this;
				if (obj2 == null)
				{
					if (true)
					{
						obj2 = 1;
					}
				}
				else if (0 == 0)
				{
					obj2 = 0;
				}
				break;
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
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_005b: Expected Obj, but got Ref
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0084->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00af->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0076->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009f->IL0019: Incompatible stack types: I4 vs Ref
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			default:
				_ = ref obj;
				if (3 == 0)
				{
					_ = 3;
				}
				break;
			case 4u:
				return (object?)(&obj);
			case 1u:
				_ = ref obj;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 3u:
				_ = ref obj;
				_ = -1;
				_ = 5;
				break;
			case 2u:
				reference = ref obj;
				if (false)
				{
					reference = ref *(object*)1;
				}
				break;
			case 5u:
				_ = ref obj;
				_ = ref obj;
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00툀(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0091->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0084: Incompatible stack heights: 1 vs 0
		//IL_0078->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0069->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0083->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				if (P_0 != null)
				{
					_ = 2;
					continue;
				}
				break;
			case 4:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 1;
				}
				continue;
			case 5:
				if (4 != 0)
				{
					_ = 4;
				}
				continue;
			case 1:
				return;
			case 2:
				return;
			}
			_ = 5;
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00퐀(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_004a: Expected Obj, but got I4
		//IL_005c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0041->IL005c: Incompatible stack heights: 1 vs 0
		//IL_006c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0091->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004f->IL0015: Incompatible stack heights: 1 vs 0
		//IL_0077->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					return;
				case 3:
					if (P_0 != null)
					{
						return;
					}
					goto end_IL_0019;
				case 2:
					_ = 4;
					break;
				case 0:
					return;
				case 4:
					if (1 == 0)
					{
						_ = 1;
					}
					break;
				case 1:
					obj2 = this;
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				continue;
				end_IL_0019:
				break;
			}
			obj = 2;
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0053->IL006a: Incompatible stack heights: 1 vs 0
		//IL_0049->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0077->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0091->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006a->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				_ = 4;
				break;
			case 1:
				obj2 = this;
				if (P_0 != null)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 5;
			case 5:
				_ = 3;
				break;
			case 4:
				obj2 = this;
				if (2 != 0)
				{
					obj2 = 1;
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
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00b8->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_007e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0089->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0069->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				obj = this;
				if (0 == 0)
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
				obj = obj;
				if (0 == 0)
				{
					_ = 5;
				}
				continue;
			case 4:
				return;
			case 3:
				obj2 = obj;
				obj = P_0;
				if (false)
				{
					obj2 = 2;
				}
				continue;
			}
			obj = obj;
			if (false)
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E000(InfoBarSeverity P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041->IL0058: Incompatible stack heights: 1 vs 0
		//IL_0082->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0073->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0058->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				obj2 = this;
				if ((int)P_0 == 0)
				{
					if (false)
					{
						obj2 = 0;
					}
					break;
				}
				return;
			case 4:
				return;
			default:
				obj2 = this;
				if (3 == 0)
				{
					obj2 = 3;
				}
				break;
			case 3:
				if (2 == 0)
				{
					_ = 2;
				}
				break;
			case 2:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 4;
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E200(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_007b: Expected Obj, but got I4
		//IL_0050->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ae->IL0019: Incompatible stack heights: 0 vs 1
		//IL_005b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009e->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					obj = obj;
					if (false)
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
					obj2 = obj;
					obj = P_0;
					if (false)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					obj = this;
					if (1 == 0)
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
	private void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E600()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0155: Expected Obj, but got I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00f5: Expected Obj, but got I4
		//IL_00d1: Expected I4, but got Obj
		//IL_009c->IL00a0: Incompatible stack types: I4 vs Obj
		//IL_0081->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0161->IL00a0: Incompatible stack heights: 0 vs 1
		//IL_00e6->IL00a0: Incompatible stack types: I4 vs Obj
		//IL_0122->IL00a0: Incompatible stack types: I4 vs Obj
		//IL_0152->IL00a0: Incompatible stack types: I4 vs Obj
		//IL_0132->IL00a0: Incompatible stack heights: 2 vs 1
		//IL_008c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
		//IL_016c->IL00a0: Incompatible stack types: I4 vs Obj
		//IL_0117->IL00a0: Incompatible stack types: I4 vs Obj
		//IL_0183->IL00a0: Incompatible stack heights: 0 vs 1
		//IL_00a0->IL00a0: Incompatible stack heights: 2 vs 1
		//IL_018e->IL00a0: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				if (this != null)
				{
					if (3 != 0)
					{
						obj2 = 0;
					}
					break;
				}
				return;
			case 0:
				return;
			case 2:
				return;
			case 3:
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
			{
				obj = this;
				object obj3 = 2;
				while (true)
				{
					switch ((int)obj3)
					{
					case 3:
						return;
					case 5:
						obj++;
						obj3 = 9;
						break;
					case 10:
						obj = 4;
						break;
					case 4:
						obj3 = obj;
						if (5 == 0)
						{
							obj3 = 5;
						}
						break;
					case 6:
						obj3 = 3;
						break;
					case 8:
						_ = 10;
						break;
					case 1:
					case 7:
						obj = ((object[])obj)[obj];
						obj3 = 8;
						break;
					case 2:
						obj = 0;
						if (false)
						{
							obj3 = 0;
						}
						break;
					default:
						if ((nint)obj < ((Array)obj).Length)
						{
							if (true)
							{
								obj3 = 1;
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
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_00af->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = ((object)this) ?? ((object)/*Error near IL_0043: Stack underflow*/);
				if (obj2 == null)
				{
					obj2 = (object)/*Error near IL_0056: Stack underflow*/;
				}
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				obj2 = ((object)this) ?? ((object)/*Error near IL_0080: Stack underflow*/);
				if (obj2 == null)
				{
					obj2 = (object)/*Error near IL_0093: Stack underflow*/;
				}
				if (0 == 0)
				{
					obj2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E800(ObservableCollection<AccountModel?>? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777455, new IntPtr(2737335728876L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E900(ObservableCollection<AccountModel?>? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0060->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0090->IL0085: Incompatible stack heights: 1 vs 0
		//IL_0085->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0051->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009a->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = this;
				if (true)
				{
					obj2 = 2;
				}
				break;
			case 2:
				if (1 == 0)
				{
					_ = 0;
				}
				break;
			case 1:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			case 4:
				if (P_0 != null)
				{
					return;
				}
				_ = 3;
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_EC00(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0061->IL00a0: Incompatible stack heights: 1 vs 0
		//IL_00ad->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0092->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0078->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = this;
				if (P_0 != null)
				{
					if (false)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			case 5:
				obj2 = this;
				if (3 == 0)
				{
					obj2 = 2;
				}
				continue;
			case 4:
				_ = 5;
				continue;
			case 3:
				return;
			case 2:
				break;
			}
			_ = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_ED00()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				_ = null;
				if (0 == 0)
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
	internal object? _FF00_FF00_FF00_FF00_FF00_FF00_FF00_EF00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
	internal object? _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F100()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
	internal object? _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F700()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777461, new IntPtr(2737335726796L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object? _FF00_FF00_FF00_FF00_FF00_FF00_FF00豈()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ﬀ(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_00c0->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0070->IL0019: Incompatible stack heights: 3 vs 1
		//IL_007f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00af->IL0019: Incompatible stack heights: 5 vs 1
		//IL_00cb->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0053->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0093->IL0019: Incompatible stack heights: 0 vs 1
		//IL_005e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009e->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				_ = 6;
				break;
			case 3:
				_ = 2;
				break;
			case 2:
				if (P_0 != null)
				{
					_ = null;
					if (false)
					{
						_ = 0;
					}
				}
				else if (0 == 0)
				{
					obj2 = 1;
				}
				break;
			case 6:
				_ = 3;
				_ = 4;
				break;
			default:
				_ = 3;
				if (5 != 0)
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ﴀ(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0045->IL005c: Incompatible stack heights: 1 vs 0
		//IL_0077->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0095->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0069->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005c->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = this;
				if (P_0 != null)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 5;
			case 5:
				_ = 3;
				break;
			case 0:
				return;
			case 4:
				return;
			case 2:
				_ = 4;
				break;
			case 3:
				if (2 == 0)
				{
					_ = 2;
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
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FF00()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_005a: Expected I4, but got Obj
		//IL_006e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_009e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a9->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				if (this != null)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 1;
			case 4:
				return (byte)(int)this;
			default:
				return 1;
			case 1:
				if (this == null)
				{
					obj2 = 4;
					break;
				}
				goto default;
			case 3:
				if (this == null)
				{
					if (2 != 0)
					{
						obj2 = 1;
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
	internal static object? Ѐ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object?)/*Error near IL_0009: Stack underflow*/;
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
	internal ObservableCollection<AccountModel?>? _0700()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<AccountModel?>?)(object)this;
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
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0064->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0076->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0092->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0054->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0081->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		while (true)
		{
			switch ((int)obj)
			{
			case 1:
				if (false)
				{
					_ = 0;
				}
				break;
			default:
				_ = 4;
				break;
			case 2:
				if (0 == 0)
				{
					_ = 1;
				}
				break;
			case 3:
				return;
			case 4:
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _0C00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777464, new IntPtr(2737335705996L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _0D00(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0086->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006d->IL003c: Incompatible stack heights: 1 vs 0
		//IL_0063->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0091->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0077->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				_ = 2;
				break;
			case 1:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 5:
				if (P_0 != null)
				{
					_ = 4;
					break;
				}
				goto case 3;
			case 2:
				if (true)
				{
					_ = 1;
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
	internal ObservableCollection<AccountModel?>? က()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<AccountModel?>?)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<AccountModel?>? ᄀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777415, new IntPtr(2737335728876L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<AccountModel?>?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ሀ(object? P_0, InfoBarSeverity P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0055->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0066->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0071->IL0019: Incompatible stack heights: 3 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				if (this == null)
				{
					if (false)
					{
						obj2 = 0;
					}
				}
				else if (2 == 0)
				{
					_ = 2;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal InfoBarSeverity ጀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (InfoBarSeverity)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _1400(object? P_0, object? P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0046->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
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
	internal object? ᘀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
	private void ᤀ(object? P_0, object? P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0046->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
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
	private void ἀ(object? P_0, object? P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_003f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0059->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0064->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				if (2 == 0)
				{
					_ = 0;
				}
				break;
			case 1:
				if (false)
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
	private static (string?, string?) _2200()
	{
		//IL_0011: Expected VT, but got I4
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = 6;
		return ((string?, string?))10;
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
	private byte Ⰰ(EnumAccountType P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_00a2: Expected I4, but got Obj
		//IL_0162: Expected I4, but got Obj
		//IL_01b4: Expected Obj, but got I4
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected I4, but got Unknown
		//IL_02b1: Expected Obj, but got I4
		//IL_0303: Expected I4, but got Obj
		//IL_01f0: Expected Obj, but got I4
		//IL_0207->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ef->IL0019: Incompatible stack heights: 2 vs 1
		//IL_013f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_03db->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0185->IL0019: Incompatible stack heights: 2 vs 1
		//IL_026b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01be->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02bb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03ad->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0212->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01d2->IL0019: Incompatible stack heights: 0 vs 1
		//IL_012f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00fa->IL0019: Incompatible stack heights: 2 vs 1
		//IL_03e6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0190->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02f6->IL02fa: Incompatible stack types: I4 vs Obj
		//IL_0276->IL0019: Incompatible stack heights: 2 vs 1
		//IL_016c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0452->IL0019: Incompatible stack heights: 0 vs 1
		//IL_024e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0425->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_046f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01dd->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0226->IL0019: Incompatible stack types: I4 vs Obj
		//IL_010e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01a6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_023a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_045d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0259->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01b1->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (10 != 0)
					{
						obj2 = 0;
					}
					break;
				case 5:
					_ = 2;
					if (15 == 0)
					{
						_ = 22;
					}
					break;
				case 22:
					return 1;
				case 4:
					if (this != null)
					{
						obj2 = 25;
						break;
					}
					goto IL_016e;
				case 7:
					_ = 2;
					_ = 26;
					break;
				case 13:
					switch ((int)obj)
					{
					case 2:
						break;
					default:
						goto IL_0162;
					case 3:
					case 4:
						goto IL_0192;
					case 1:
						goto IL_01df;
					case 0:
						goto IL_0214;
					case 5:
						goto IL_02ae;
					case 6:
						goto IL_045d;
					}
					if (this != null)
					{
						obj2 = 8;
						break;
					}
					goto IL_02ae;
				case 32:
					return 1;
				case 2:
				case 12:
				case 16:
				case 19:
				case 28:
					goto IL_016e;
				case 9:
					_ = 2;
					if (15 == 0)
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
					goto IL_01be;
				case 6:
					return 1;
				default:
					_ = 2;
					if (18 != 0)
					{
						_ = 21;
					}
					break;
				case 15:
					return 1;
				case 21:
					return 1;
				case 23:
					goto IL_023a;
				case 11:
					_ = 2;
					if (4 != 0)
					{
						_ = 6;
					}
					break;
				case 1:
				case 18:
				case 20:
					goto IL_02ae;
				case 10:
				{
					object obj3 = null;
					if (0 == 0)
					{
						obj3 = 0;
					}
					switch ((int)obj3)
					{
					}
					goto IL_02ae;
				}
				case 24:
					_ = 2;
					_ = 32;
					break;
				case 8:
					_ = 2;
					if (16 == 0)
					{
						_ = 27;
					}
					break;
				case 29:
					goto IL_0413;
				case 17:
					switch (obj - 1)
					{
					case 0:
						break;
					case 4:
						goto IL_016e;
					case 1:
						goto IL_01be;
					case 3:
						goto IL_0228;
					case 2:
						goto IL_023a;
					case 5:
						goto IL_0413;
					default:
						goto IL_0446;
					}
					goto case 4;
				case 31:
					goto IL_045d;
					IL_0446:
					if (2 == 0)
					{
						obj2 = 2;
					}
					break;
					IL_0214:
					if (this == null)
					{
						obj2 = 30;
						break;
					}
					goto case 7;
					IL_0228:
					if (this == null)
					{
						obj2 = 19;
						break;
					}
					goto case 24;
					IL_0413:
					if (this == null)
					{
						obj2 = 16;
						break;
					}
					goto default;
					IL_01df:
					if (this != null)
					{
						goto end_IL_0019;
					}
					goto IL_02ae;
					IL_0192:
					if (this == null)
					{
						if (0 == 0)
						{
							obj2 = 1;
						}
						break;
					}
					goto case 9;
					IL_016e:
					return 0;
					IL_023a:
					if (this != null)
					{
						if (false)
						{
							obj2 = 0;
						}
						break;
					}
					goto IL_016e;
					IL_0162:
					obj2 = 18;
					break;
					IL_01be:
					if (this == null)
					{
						if (9 != 0)
						{
							obj2 = 12;
						}
						break;
					}
					goto default;
					IL_02ae:
					obj = P_0;
					obj2 = 17;
					break;
					IL_045d:
					if (this != null)
					{
						obj2 = 11;
						break;
					}
					goto IL_02ae;
				}
				continue;
				end_IL_0019:
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
	internal object? _2E00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
	internal object? _3300()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? 㐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777438, new IntPtr(2737335724716L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void 㘀(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0063->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0051->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0089->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object? obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				_ = null;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 2:
				_ = 3;
				if (true)
				{
					_ = 1;
				}
				break;
			case 3:
				obj2 = P_0;
				if (1 == 0)
				{
					obj2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint 㜀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
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
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00a5: Expected Obj, but got Ref
		//IL_0048: Expected Obj, but got I4
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_004d->IL0015: Incompatible stack heights: 2 vs 0
		//IL_005f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b3->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0095->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0085->IL0019: Incompatible stack types: I4 vs Ref
		//IL_006a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a0->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		while (true)
		{
			ref object reference = ref *(object*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 1u:
					break;
				case 3u:
					_ = ref obj;
					_ = ref obj;
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 2u:
					reference = ref obj;
					if (true)
					{
						reference = ref *(object*)1;
					}
					continue;
				case 5u:
					_ = ref obj;
					if (4 == 0)
					{
						_ = 0;
					}
					continue;
				default:
					return (object?)(&obj);
				case 4u:
					_ = ref obj;
					_ = -1;
					_ = 3;
					continue;
				}
				break;
			}
			_ = ref obj;
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
	private void 㼀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_00b6: Expected Obj, but got I4
		//IL_0168: Expected I4, but got Obj
		//IL_0085: Expected I4, but got Obj
		//IL_0048->IL0019: Incompatible stack heights: 0 vs 1
		//IL_012b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0053->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0136->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0181->IL0157: Incompatible stack heights: 0 vs 1
		//IL_01a7->IL0157: Incompatible stack types: I4 vs Obj
		//IL_018c->IL0157: Incompatible stack types: I4 vs Obj
		//IL_00a5->IL0074: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				obj = this;
				if (false)
				{
					obj2 = 0;
				}
				continue;
			case 2:
				while (true)
				{
					object obj4;
					if (obj == null)
					{
						obj = 2;
						obj4 = obj;
						goto IL_0074;
					}
					goto IL_008a;
					IL_0074:
					switch ((int)obj4)
					{
					case 1:
						break;
					default:
						continue;
					case 2:
						return;
					}
					goto IL_008a;
					IL_008a:
					obj4 = obj;
					if (false)
					{
						obj4 = 0;
					}
					goto IL_0074;
				}
			case 3:
				return;
			case 4:
				break;
			default:
				while (true)
				{
					object obj3;
					if (obj == null)
					{
						if (true)
						{
							obj3 = 1;
						}
						goto IL_0157;
					}
					goto IL_018c;
					IL_018c:
					obj3 = obj;
					if (false)
					{
						obj3 = 0;
					}
					goto IL_0157;
					IL_0157:
					switch ((int)obj3)
					{
					case 1:
						break;
					default:
						continue;
					case 2:
						goto IL_018c;
					}
					break;
				}
				break;
			}
			obj = this;
			if (2 != 0)
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
	private void 䄀(object? P_0, object? P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0046->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
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
	internal void 䌀(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0052->IL003b: Incompatible stack heights: 1 vs 0
		//IL_0079->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0048->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ba->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0084->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0069->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				_ = 4;
				break;
			case 1:
				obj2 = this;
				if (P_0 != null)
				{
					if (false)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 5;
			case 0:
				return;
			case 2:
				return;
			case 4:
				if (3 == 0)
				{
					_ = 0;
				}
				break;
			case 3:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? 䐀(EnumAccountType P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00a2: Expected Obj, but got Ref
		//IL_005b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0082->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0074->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0092->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009d->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				_ = ref obj;
				_ = 3;
				break;
			case 1:
				_ = ref obj;
				_ = ref obj;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 3:
				_ = ref obj;
				_ = 2;
				break;
			case 2:
				_ = ref obj;
				_ = 5;
				break;
			case 5:
				_ = ref obj;
				_ = -1;
				if (true)
				{
					_ = 1;
				}
				break;
			default:
				return (object?)(&obj);
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
	internal void 䜀(Func<InfoBarDelegate?>? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00ab->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0090->IL0019: Incompatible stack heights: 0 vs 1
		//IL_007f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00b6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004e->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = obj;
				obj = P_0;
				if (0 == 0)
				{
					obj2 = 4;
				}
				continue;
			case 4:
				obj = obj;
				_ = 5;
				continue;
			case 3:
				return;
			case 1:
				obj = this;
				if (false)
				{
					obj2 = 0;
				}
				continue;
			}
			obj = obj;
			if (2 == 0)
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
	internal void 䤀(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0064->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0071->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0095->IL0057: Incompatible stack heights: 1 vs 0
		//IL_0080->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008b->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		while (true)
		{
			switch ((int)obj)
			{
			case 3:
				return;
			default:
				_ = 5;
				break;
			case 1:
				_ = 2;
				break;
			case 5:
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 4:
				if (P_0 != null)
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
	internal void 䰀(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0089->IL0058: Incompatible stack heights: 1 vs 0
		//IL_0065->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0074->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ad->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a0->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				_ = 4;
				break;
			case 4:
				if (5 == 0)
				{
					_ = 4;
				}
				break;
			case 1:
				obj2 = this;
				if (P_0 != 0)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 2;
			case 5:
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object? 䴀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? 一()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777760, new IntPtr(2737335724716L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void 伀(object? P_0, object? P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0045->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = this;
				if (0 == 0)
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
	internal void 刀(ObservableCollection<AccountModel?>? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_005e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0068->IL0072: Incompatible stack heights: 1 vs 0
		//IL_0082->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0051->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008d->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				obj2 = this;
				if (true)
				{
					obj2 = 1;
				}
				break;
			case 2:
				_ = 4;
				break;
			case 3:
				if (P_0 == null)
				{
					_ = 2;
					break;
				}
				return;
			case 1:
				return;
			case 4:
				if (false)
				{
					_ = 0;
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
	private void 吀(object? P_0, object? P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_003f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0059->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0064->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				if (2 == 0)
				{
					_ = 1;
				}
				break;
			case 1:
				if (false)
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
	internal object? 嘀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? 圀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777773, new IntPtr(2737335709116L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void 堀(object? P_0, object? P_1, InfoBarSeverity P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0055->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0067->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0072->IL0019: Incompatible stack heights: 4 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				if (this == null)
				{
					if (1 == 0)
					{
						obj2 = 0;
					}
				}
				else if (false)
				{
					_ = 0;
				}
				break;
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
	internal static byte 尀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
	internal object? 挀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
	internal uint 栀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint 椀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777791, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<AccountModel?>? 樀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (List<AccountModel?>?)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<AccountModel?>? 欀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777788, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
		return (List<AccountModel?>?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 氀(List<AccountModel?>? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_009c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0076->IL006b: Incompatible stack heights: 1 vs 0
		//IL_0051->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008d->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				obj2 = this;
				if (true)
				{
					obj2 = 1;
				}
				break;
			case 3:
				obj2 = this;
				if (2 != 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				return;
			case 4:
				obj2 = this;
				if (P_0 != null)
				{
					return;
				}
				if (true)
				{
					obj2 = 3;
				}
				break;
			case 2:
				if (0 == 0)
				{
					_ = 0;
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
