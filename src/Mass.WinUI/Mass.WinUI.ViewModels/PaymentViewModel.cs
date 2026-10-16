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
using Mass.Domain.Entities.Mass;
using Mass.WinUI.Helpers;
using Mass.WinUI.Models;
using Microsoft.UI.Xaml.Controls;
using WinRT;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails))]
public class PaymentViewModel : ObservableObject, IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRedeemCode_003Ed__97 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PaymentViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object DisableCreator;

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
		internal static bool ReplaceManager()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LoadEngine()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00팀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778391, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00퐀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_005c: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_01e5: Expected Obj, but got I4
			//IL_023e: Expected Obj, but got Ref
			//IL_01ba: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_004a->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0068->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0058->IL0019: Incompatible stack types: I4 vs Ref
			//IL_009f->IL00a3: Incompatible stack heights: 1 vs 0
			//IL_0073->IL0019: Incompatible stack types: I4 vs Ref
			//IL_008d->IL0019: Incompatible stack types: I4 vs Ref
			//IL_031b->IL00a3: Incompatible stack heights: 1 vs 0
			//IL_00e0->IL00a3: Incompatible stack heights: 2 vs 0
			//IL_011c->IL0120: Incompatible stack heights: 1 vs 0
			//IL_00eb->IL00a3: Incompatible stack heights: 2 vs 0
			//IL_0333->IL00a3: Incompatible stack heights: 1 vs 0
			//IL_010a->IL00a3: Incompatible stack heights: 1 vs 0
			//IL_01b5->IL0120: Incompatible stack heights: 1 vs 0
			//IL_01f0->IL0120: Incompatible stack heights: 3 vs 0
			//IL_0248->IL0120: Incompatible stack heights: 1 vs 0
			//IL_01d5->IL0120: Incompatible stack heights: 2 vs 0
			//IL_01c5->IL0120: Incompatible stack heights: 3 vs 0
			//IL_018c->IL0120: Incompatible stack heights: 1 vs 0
			//IL_023a->IL0120: Incompatible stack heights: 2 vs 0
			//IL_0202->IL0120: Incompatible stack heights: 3 vs 0
			//IL_022d->IL0120: Incompatible stack heights: 3 vs 0
			//IL_01e0->IL0120: Incompatible stack heights: 2 vs 0
			//IL_0197->IL0120: Incompatible stack heights: 1 vs 0
			//IL_020d->IL0120: Incompatible stack heights: 3 vs 0
			//IL_017d->IL0120: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			ref _003CRedeemCode_003Ed__97 reference = ref *(_003CRedeemCode_003Ed__97*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 1u:
					return;
				default:
					_ = -2;
					_ = 5;
					break;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CRedeemCode_003Ed__97*)3;
					break;
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						reference = ref *(_003CRedeemCode_003Ed__97*)2;
					}
					break;
				case 5u:
					reference = ref this;
					if (true)
					{
						reference = ref *(_003CRedeemCode_003Ed__97*)null;
					}
					break;
				case 2u:
					{
						if (obj == null)
						{
							_ = 3;
							goto IL_00a3;
						}
						goto IL_02fe;
					}
					IL_02fe:
					obj = obj;
					if (0 == 0)
					{
						_ = 0;
					}
					goto IL_00a3;
					IL_00a3:
					while (true)
					{
						switch ((int)/*Error near IL_00c8: Stack underflow*/)
						{
						case 1:
						case 6:
							break;
						case 5:
							_ = 2;
							if (false)
							{
								_ = 1;
							}
							continue;
						default:
							if (obj != null)
							{
								if (3 != 0)
								{
									_ = 5;
								}
								continue;
							}
							goto case 3;
						case 4:
							if (obj == null)
							{
								_ = 5;
								goto IL_0120;
							}
							goto IL_0197;
						case 2:
							goto IL_02fe;
						case 3:
						case 7:
							{
								if (1 == 0)
								{
									_ = 4;
								}
								continue;
							}
							IL_0197:
							obj = obj;
							if (0 == 0)
							{
								_ = 0;
							}
							goto IL_0120;
							IL_0120:
							while (true)
							{
								switch ((int)/*Error near IL_0159: Stack underflow*/)
								{
								case 8:
									return;
								case 12:
									break;
								default:
									if (&obj == null)
									{
										if (1 == 0)
										{
											_ = 1;
										}
										continue;
									}
									goto case 6;
								case 6:
									_ = ref obj;
									if (11 == 0)
									{
										_ = 11;
									}
									continue;
								case 10:
									goto IL_0197;
								case 4:
									obj = -1;
									_ = 6;
									continue;
								case 3:
									if (7 == 0)
									{
										_ = 9;
									}
									continue;
								case 1:
									obj = 0;
									_ = 3;
									continue;
								case 9:
									_ = ref obj;
									if (8 == 0)
									{
										_ = 8;
									}
									continue;
								case 11:
									_ = 1;
									_ = 12;
									continue;
								case 7:
									_ = 4;
									continue;
								case 2:
								case 5:
									obj = (object)Unsafe.AsPointer(ref this);
									_ = 7;
									continue;
								}
								break;
							}
							break;
						}
						break;
					}
					goto default;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00픀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778388, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00혀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778389, new IntPtr(2737336183452L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00휀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778386, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FFFD()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FFFD(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FFFD(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778387, new IntPtr(2737336185532L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRedeemProduct_003Ed__96 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ProductModel productModel;

		public PaymentViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object CheckIntegratedStub;

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
		internal static bool MoveEvaluator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckSymbolicTask()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00준()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778384, new IntPtr(2737336188652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00쨀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0317: Expected Obj, but got Ref
			//IL_033f: Expected Obj, but got Ref
			//IL_0363: Expected Obj, but got I4
			//IL_0048: Expected Obj, but got I4
			//IL_0062: Expected I4, but got Obj
			//IL_00e9: Expected Obj, but got Ref
			//IL_0197: Expected Obj, but got Ref
			//IL_0117: Expected Obj, but got I4
			//IL_01fc: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0321->IL0019: Incompatible stack types: I4 vs Ref
			//IL_034b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0368->IL0015: Incompatible stack heights: 2 vs 0
			//IL_0356->IL0019: Incompatible stack types: I4 vs Ref
			//IL_033b->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0074->IL0051: Incompatible stack heights: 0 vs 1
			//IL_00f3->IL00a2: Incompatible stack types: I4 vs Ref
			//IL_0093->IL00a2: Incompatible stack heights: 0 vs 1
			//IL_007f->IL0051: Incompatible stack types: I4 vs Obj
			//IL_009e->IL00a2: Incompatible stack types: I4 vs Ref
			//IL_01a3->IL00a2: Incompatible stack heights: 0 vs 1
			//IL_01be->IL00a2: Incompatible stack heights: 4 vs 1
			//IL_0107->IL00a2: Incompatible stack heights: 0 vs 1
			//IL_01ec->IL00a2: Incompatible stack heights: 2 vs 1
			//IL_0168->IL00a2: Incompatible stack heights: 2 vs 1
			//IL_0124->IL00a2: Incompatible stack heights: 2 vs 1
			//IL_0207->IL00a2: Incompatible stack heights: 3 vs 1
			//IL_01ce->IL00a2: Incompatible stack heights: 2 vs 1
			//IL_01ae->IL00a2: Incompatible stack types: I4 vs Ref
			//IL_015b->IL00a2: Incompatible stack types: I4 vs Ref
			//IL_0112->IL00a2: Incompatible stack types: I4 vs Ref
			//IL_01f7->IL00a2: Incompatible stack heights: 2 vs 1
			//IL_0141->IL00a2: Incompatible stack types: I4 vs Ref
			//IL_012f->IL00a2: Incompatible stack heights: 2 vs 1
			//IL_01d9->IL00a2: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			while (true)
			{
				ref _003CRedeemProduct_003Ed__96 reference = ref *(_003CRedeemProduct_003Ed__96*)obj;
				while (true)
				{
					switch ((uint)Unsafe.AsPointer(ref reference))
					{
					case 5u:
					{
						obj = 2;
						object obj2 = obj;
						while (true)
						{
							ref object reference2;
							switch ((int)obj2)
							{
							case 2:
								if (0 == 0)
								{
									obj2 = 0;
								}
								continue;
							default:
								if (obj == null)
								{
									if (0 == 0)
									{
										reference2 = ref *(object*)2;
									}
									goto IL_00a2;
								}
								goto IL_00e4;
							case 1:
								break;
								IL_00a2:
								while (true)
								{
									switch ((uint)Unsafe.AsPointer(ref reference2))
									{
									case 4u:
										break;
									case 7u:
										obj = obj;
										if (10 != 0)
										{
											reference2 = ref *(object*)5;
										}
										continue;
									case 11u:
										obj = -1;
										if (6 == 0)
										{
											_ = 3;
										}
										continue;
									case 10u:
										if (&obj == null)
										{
											reference2 = ref *(object*)12;
											continue;
										}
										goto case 6u;
									case 6u:
										reference2 = ref obj;
										if (true)
										{
											reference2 = ref *(object*)8;
										}
										continue;
									case 9u:
										_ = 11;
										continue;
									case 5u:
										return;
									default:
										obj = (object)Unsafe.AsPointer(ref this);
										if (5 != 0)
										{
											reference2 = ref *(object*)9;
										}
										continue;
									case 3u:
										_ = ref obj;
										_ = 5;
										continue;
									case 13u:
										if (0 == 0)
										{
											_ = 3;
										}
										continue;
									case 8u:
										_ = 1;
										if (1 == 0)
										{
											_ = 1;
										}
										continue;
									case 12u:
										obj = 0;
										_ = 13;
										continue;
									case 1u:
										goto end_IL_0051;
									}
									break;
								}
								goto IL_00e4;
								IL_00e4:
								obj = (object)Unsafe.AsPointer(ref this);
								reference2 = ref *(object*)7;
								goto IL_00a2;
								end_IL_0051:
								break;
							}
							break;
						}
						break;
					}
					default:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(_003CRedeemProduct_003Ed__96*)5;
						continue;
					case 3u:
						reference = ref this;
						if (true)
						{
							reference = ref *(_003CRedeemProduct_003Ed__96*)4;
						}
						continue;
					case 1u:
						obj = (object)Unsafe.AsPointer(ref this);
						if (false)
						{
							reference = ref *(_003CRedeemProduct_003Ed__96*)null;
						}
						continue;
					case 2u:
						break;
					case 4u:
						return;
					}
					break;
				}
				_ = -2;
				obj = 3;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00쬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778385, new IntPtr(2737336183452L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00찀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00촀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778398, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00츀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778399, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00케()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00퀀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00턀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778396, new IntPtr(2737336188652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRefreshHistoryOrder_003Ed__94 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HistoryOrderModel order;

		public PaymentViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object ReflectConfigurableViewer;

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
		internal static bool CheckSeparatedCalculator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectMonoDictionary()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00뼀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778397, new IntPtr(2737336188652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00쀀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0513: Expected Obj, but got Ref
			//IL_03d2: Expected Obj, but got Ref
			//IL_03db: Expected Obj, but got I4
			//IL_022c: Expected Obj, but got Ref
			//IL_0235: Expected Obj, but got I4
			//IL_039a: Expected Obj, but got I4
			//IL_0342: Expected Obj, but got Ref
			//IL_03e5: Expected Obj, but got I4
			//IL_01b9: Expected Obj, but got I4
			//IL_0193: Expected Obj, but got I4
			//IL_020d: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_051f->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
			//IL_008b->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0056->IL0019: Incompatible stack types: I4 vs Ref
			//IL_052a->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0071->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00f7->IL00a1: Incompatible stack heights: 0 vs 1
			//IL_00d8->IL00a1: Incompatible stack heights: 0 vs 1
			//IL_049e->IL00a1: Incompatible stack heights: 3 vs 1
			//IL_0300->IL0300: Incompatible stack heights: 1 vs 0
			//IL_02fc->IL0300: Incompatible stack heights: 1 vs 0
			//IL_014d->IL014d: Incompatible stack heights: 1 vs 0
			//IL_0149->IL014d: Incompatible stack heights: 1 vs 0
			//IL_037c->IL0300: Incompatible stack heights: 1 vs 0
			//IL_041a->IL0300: Incompatible stack heights: 4 vs 0
			//IL_03a5->IL0300: Incompatible stack heights: 3 vs 0
			//IL_03ce->IL0300: Incompatible stack heights: 2 vs 0
			//IL_0395->IL0300: Incompatible stack heights: 3 vs 0
			//IL_03f0->IL0300: Incompatible stack heights: 3 vs 0
			//IL_03ff->IL0300: Incompatible stack heights: 1 vs 0
			//IL_0228->IL014d: Incompatible stack heights: 4 vs 0
			//IL_01d1->IL014d: Incompatible stack heights: 2 vs 0
			//IL_01fd->IL014d: Incompatible stack heights: 2 vs 0
			//IL_01c4->IL014d: Incompatible stack heights: 3 vs 0
			//IL_0198->IL0149: Incompatible stack heights: 1 vs 0
			//IL_0218->IL014d: Incompatible stack heights: 3 vs 0
			//IL_0387->IL0300: Incompatible stack heights: 1 vs 0
			//IL_036b->IL0300: Incompatible stack heights: 1 vs 0
			//IL_0359->IL0300: Incompatible stack heights: 1 vs 0
			//IL_040a->IL0300: Incompatible stack heights: 1 vs 0
			//IL_01b4->IL014d: Incompatible stack heights: 1 vs 0
			//IL_0208->IL014d: Incompatible stack heights: 2 vs 0
			//IL_024c->IL014d: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			ref _003CRefreshHistoryOrder_003Ed__94 reference = ref *(_003CRefreshHistoryOrder_003Ed__94*)obj;
			while (true)
			{
				int num;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 2u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (5 == 0)
					{
						reference = ref *(_003CRefreshHistoryOrder_003Ed__94*)3;
					}
					break;
				case 4u:
					_ = -2;
					if (false)
					{
						_ = 0;
					}
					break;
				default:
					reference = ref this;
					if (true)
					{
						reference = ref *(_003CRefreshHistoryOrder_003Ed__94*)null;
					}
					break;
				case 5u:
					if (obj == null)
					{
						num = 2;
						goto IL_00a1;
					}
					goto IL_00e3;
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 != 0)
					{
						reference = ref *(_003CRefreshHistoryOrder_003Ed__94*)null;
					}
					break;
				case 1u:
					return;
					IL_00a1:
					while (true)
					{
						switch (num)
						{
						case 6:
							break;
						default:
							if (true)
							{
								num = 1;
							}
							continue;
						case 5:
							goto IL_00e3;
						case 4:
							goto IL_0102;
						case 3:
							if ((nint)obj != 1)
							{
								if (false)
								{
									_ = 0;
								}
								goto IL_014d;
							}
							goto IL_0228;
						case 1:
							if (obj != null)
							{
								if (8 == 0)
								{
									_ = 6;
								}
								goto IL_0300;
							}
							goto IL_03ce;
						case 7:
							goto IL_048f;
							IL_0228:
							obj = (object)Unsafe.AsPointer(ref this);
							obj = 2;
							goto IL_014d;
							IL_014d:
							while (true)
							{
								switch ((int)/*Error near IL_0182: Stack underflow*/)
								{
								case 6:
								case 9:
									_ = ref obj;
									obj = 11;
									continue;
								default:
									obj = (object)/*Error near IL_019d: Stack underflow*/;
									if (8 == 0)
									{
										_ = 3;
									}
									continue;
								case 5:
									obj = 1;
									_ = 4;
									continue;
								case 2:
									_ = 7;
									continue;
								case 3:
									return;
								case 4:
									if (1 == 0)
									{
										_ = 1;
									}
									continue;
								case 7:
									obj = -1;
									_ = 6;
									continue;
								case 1:
									_ = ref obj;
									_ = 3;
									continue;
								case 10:
									break;
								case 8:
									if (&obj != null)
									{
										_ = 9;
										continue;
									}
									goto case 5;
								case 11:
									goto IL_048f;
								}
								break;
							}
							goto IL_0228;
							IL_03ce:
							obj = (object)Unsafe.AsPointer(ref this);
							obj = 5;
							goto IL_0300;
							IL_0300:
							while (true)
							{
								switch ((int)/*Error near IL_0335: Stack underflow*/)
								{
								case 8:
									obj = (object)Unsafe.AsPointer(ref this);
									if (5 == 0)
									{
										_ = 6;
									}
									continue;
								case 6:
									if (&obj == null)
									{
										_ = 10;
										continue;
									}
									goto case 11;
								case 1:
									_ = null;
									if (false)
									{
										_ = 0;
									}
									continue;
								case 9:
									_ = 2;
									continue;
								case 4:
									obj = -1;
									_ = 11;
									continue;
								case 7:
									return;
								case 5:
									_ = 4;
									continue;
								case 3:
									goto IL_03ce;
								case 10:
									obj = 0;
									_ = 9;
									continue;
								case 11:
									_ = ref obj;
									if (1 == 0)
									{
										_ = 0;
									}
									continue;
								case 2:
									_ = ref obj;
									_ = 7;
									continue;
								}
								break;
							}
							goto IL_0102;
							IL_048f:
							_ = null;
							_ = 6;
							continue;
						}
						break;
					}
					goto case 4u;
					IL_00e3:
					if ((nint)obj != 1)
					{
						if (0 == 0)
						{
							num = 0;
						}
						goto IL_00a1;
					}
					goto IL_0102;
					IL_0102:
					num = 3;
					goto IL_00a1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00섀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778394, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00숀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00쌀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00쐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778395, new IntPtr(2737336185532L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00씀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778392, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00였(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00윀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778393, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRefreshHistoryOrderCollection_003Ed__95 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PaymentViewModel _003C_003E4__this;

		private TaskAwaiter<List<EntityMassHistoryOrder>> _003C_003Eu__1;

		internal static object ReflectOrderedMonitor;

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
		internal static bool ReflectVisualSynchronizer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AddDictionary()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00똀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778470, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00뜀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0048: Expected Obj, but got I4
			//IL_0348: Expected Obj, but got Ref
			//IL_032d: Expected Obj, but got Ref
			//IL_0062: Expected I4, but got Obj
			//IL_00d0: Expected Obj, but got I4
			//IL_010a: Expected Obj, but got Ref
			//IL_0134: Expected Obj, but got Ref
			//IL_00c0: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0354->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0339->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0329->IL0019: Incompatible stack heights: 3 vs 1
			//IL_035f->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0344->IL0019: Incompatible stack types: I4 vs Ref
			//IL_031a->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0277->IL0051: Incompatible stack heights: 0 vs 1
			//IL_0282->IL0051: Incompatible stack types: I4 vs Obj
			//IL_00dd->IL007d: Incompatible stack heights: 2 vs 1
			//IL_01a5->IL007d: Incompatible stack heights: 3 vs 1
			//IL_0193->IL007d: Incompatible stack heights: 2 vs 1
			//IL_0124->IL007d: Incompatible stack heights: 2 vs 1
			//IL_0140->IL007d: Incompatible stack heights: 0 vs 1
			//IL_00cb->IL007d: Incompatible stack heights: 3 vs 1
			//IL_00e8->IL007d: Incompatible stack heights: 2 vs 1
			//IL_01b0->IL007d: Incompatible stack heights: 3 vs 1
			//IL_012f->IL007d: Incompatible stack heights: 2 vs 1
			//IL_017b->IL007d: Incompatible stack heights: 0 vs 1
			//IL_01d0->IL007d: Incompatible stack heights: 2 vs 1
			//IL_01db->IL007d: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			ref _003CRefreshHistoryOrderCollection_003Ed__95 reference = ref *(_003CRefreshHistoryOrderCollection_003Ed__95*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
				{
					obj = 2;
					object obj2 = obj;
					while (true)
					{
						int num;
						switch ((int)obj2)
						{
						case 1:
							if (obj == null)
							{
								num = 2;
								goto IL_007d;
							}
							goto IL_00e8;
						case 2:
							{
								if (true)
								{
									obj2 = 1;
								}
								continue;
							}
							IL_00e8:
							obj = (object)/*Error near IL_00ed: Stack underflow*/;
							num = 8;
							goto IL_007d;
							IL_007d:
							while (true)
							{
								switch (num)
								{
								case 11:
									obj = -1;
									_ = 9;
									continue;
								default:
									obj = 0;
									if (5 != 0)
									{
										_ = 2;
									}
									continue;
								case 7:
									break;
								case 2:
								case 3:
									obj = (object)Unsafe.AsPointer(ref this);
									num = 4;
									continue;
								case 5:
									if (true)
									{
										_ = 0;
									}
									continue;
								case 9:
									obj = (object)(&obj);
									if (12 == 0)
									{
										num = 11;
									}
									continue;
								case 6:
									return;
								case 8:
									if (&obj == null)
									{
										if (0 == 0)
										{
											num = 0;
										}
										continue;
									}
									goto case 9;
								case 4:
									_ = 11;
									continue;
								case 1:
									_ = ref obj;
									if (6 == 0)
									{
										_ = 4;
									}
									continue;
								case 12:
								{
									object obj3 = obj;
									if (true)
									{
										_ = 10;
									}
									continue;
								}
								case 10:
									goto end_IL_0051;
								}
								break;
							}
							goto IL_00e8;
							end_IL_0051:
							break;
						}
						break;
					}
					goto case 3u;
				}
				case 5u:
					reference = ref this;
					if (2 != 0)
					{
						reference = ref *(_003CRefreshHistoryOrderCollection_003Ed__95*)4;
					}
					break;
				case 4u:
					return;
				case 3u:
					_ = -2;
					_ = 5;
					break;
				case 2u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						reference = ref *(_003CRefreshHistoryOrderCollection_003Ed__95*)1;
					}
					break;
				case 1u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						reference = ref *(_003CRefreshHistoryOrderCollection_003Ed__95*)null;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00렀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778471, new IntPtr(2737336183452L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00뤀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00먀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778468, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00묀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00밀(object P_0)
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
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRefreshShopCollection_003Ed__93 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PaymentViewModel _003C_003E4__this;

		private TaskAwaiter<EntityMassShop> _003C_003Eu__1;

		internal static object ReflectStaticSystem;

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
		internal static bool DecorateDynamicRole()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckConcreteCollection()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00가()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778469, new IntPtr(2737336163692L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00관()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0067: Expected Obj, but got Ref
			//IL_0082: Expected Obj, but got Ref
			//IL_04d2: Expected Obj, but got Ref
			//IL_02b0: Expected Obj, but got I4
			//IL_03b2: Expected Obj, but got I4
			//IL_0294: Expected Obj, but got I4
			//IL_048e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0491: Expected Obj, but got Unknown
			//IL_039e: Expected Obj, but got I4
			//IL_03d6: Expected Obj, but got I4
			//IL_023b: Expected Obj, but got I4
			//IL_044c: Expected Obj, but got Ref
			//IL_034a: Unknown result type (might be due to invalid IL or missing references)
			//IL_034d: Expected Obj, but got Unknown
			//IL_0373: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0063->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0073->IL0019: Incompatible stack heights: 0 vs 1
			//IL_008e->IL0019: Incompatible stack heights: 0 vs 1
			//IL_00b5->IL00b9: Incompatible stack heights: 1 vs 0
			//IL_0055->IL0019: Incompatible stack types: I4 vs Ref
			//IL_007e->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0099->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00e7->IL00b9: Incompatible stack heights: 1 vs 0
			//IL_00fa->IL00fe: Incompatible stack heights: 1 vs 0
			//IL_04e9->IL00fe: Incompatible stack heights: 1 vs 0
			//IL_02bb->IL00fe: Incompatible stack heights: 3 vs 0
			//IL_0480->IL00fe: Incompatible stack heights: 2 vs 0
			//IL_03ff->IL00fe: Incompatible stack heights: 4 vs 0
			//IL_020d->IL00fe: Incompatible stack heights: 1 vs 0
			//IL_0281->IL00fe: Incompatible stack heights: 1 vs 0
			//IL_055e->IL00fe: Incompatible stack heights: 3 vs 0
			//IL_043d->IL0281: Incompatible stack heights: 2 vs 0
			//IL_0291->IL00fe: Incompatible stack heights: 1 vs 0
			//IL_02ef->IL00fe: Incompatible stack heights: 3 vs 0
			//IL_049b->IL00fe: Incompatible stack heights: 1 vs 0
			//IL_03a3->IL00fa: Incompatible stack heights: 0 vs 3
			//IL_04fb->IL00fe: Incompatible stack heights: 2 vs 0
			//IL_02db->IL00fe: Incompatible stack heights: 3 vs 0
			//IL_0248->IL00fe: Incompatible stack heights: 2 vs 0
			//IL_01d7->IL00fe: Incompatible stack heights: 2 vs 0
			//IL_058f->IL00fe: Incompatible stack heights: 3 vs 0
			//IL_0456->IL00fe: Incompatible stack heights: 1 vs 0
			//IL_0387->IL00fe: Incompatible stack heights: 1 vs 0
			//IL_0574->IL00fe: Incompatible stack heights: 2 vs 0
			//IL_01f3->IL00fe: Incompatible stack heights: 2 vs 0
			//IL_0321->IL02ca: Incompatible stack heights: 2 vs 0
			//IL_0378->IL00fa: Incompatible stack heights: 0 vs 3
			//IL_0517->IL00fe: Incompatible stack heights: 1 vs 0
			//IL_03d3->IL00fe: Incompatible stack heights: 1 vs 0
			//IL_048b->IL00fe: Incompatible stack heights: 2 vs 0
			//IL_00fe->IL00fe: Incompatible stack heights: 4 vs 0
			//IL_05ea->IL00fe: Incompatible stack heights: 3 vs 0
			//IL_0447->IL00fe: Incompatible stack heights: 3 vs 0
			//IL_02ab->IL00fe: Incompatible stack heights: 1 vs 0
			//IL_05a7->IL00fe: Incompatible stack heights: 3 vs 0
			//IL_059c->IL059c: Incompatible stack heights: 1 vs 2
			//IL_0236->IL00fe: Incompatible stack heights: 1 vs 0
			//IL_02fa->IL00fe: Incompatible stack heights: 3 vs 0
			//IL_03ed->IL00fe: Incompatible stack heights: 1 vs 0
			//IL_0506->IL00fe: Incompatible stack heights: 2 vs 0
			//IL_04ce->IL00fe: Incompatible stack heights: 1 vs 0
			//IL_0253->IL00fe: Incompatible stack heights: 2 vs 0
			//IL_04b9->IL00fe: Incompatible stack heights: 1 vs 0
			//IL_01e2->IL00fe: Incompatible stack heights: 2 vs 0
			//IL_0470->IL00fe: Incompatible stack heights: 1 vs 0
			//IL_0314->IL00fe: Incompatible stack heights: 1 vs 0
			//IL_0364->IL00fe: Incompatible stack heights: 1 vs 0
			//IL_0392->IL00fe: Incompatible stack heights: 1 vs 0
			//IL_057f->IL00fe: Incompatible stack heights: 2 vs 0
			//IL_01fe->IL00fe: Incompatible stack heights: 2 vs 0
			//IL_032d->IL00fe: Incompatible stack heights: 2 vs 0
			//IL_060e->IL00fe: Incompatible stack heights: 3 vs 0
			//IL_0272->IL00fe: Incompatible stack heights: 1 vs 0
			//IL_0421->IL00fe: Incompatible stack heights: 1 vs 0
			//IL_05cb->IL00fe: Incompatible stack heights: 3 vs 0
			//IL_0338->IL00fe: Incompatible stack heights: 2 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			ref _003CRefreshShopCollection_003Ed__93 reference = ref *(_003CRefreshShopCollection_003Ed__93*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 2u:
					reference = ref this;
					if (5 == 0)
					{
						reference = ref *(_003CRefreshShopCollection_003Ed__93*)4;
					}
					break;
				default:
					_ = -2;
					_ = 2;
					break;
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						reference = ref *(_003CRefreshShopCollection_003Ed__93*)1;
					}
					break;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						reference = ref *(_003CRefreshShopCollection_003Ed__93*)3;
					}
					break;
				case 5u:
					return;
				case 1u:
					if (true)
					{
						_ = 1;
					}
					while (true)
					{
						switch ((int)/*Error near IL_00ca: Stack underflow*/)
						{
						case 1:
							if (2 != 0)
							{
								_ = 1;
							}
							continue;
						case 2:
							{
								if (obj != null)
								{
									_ = 11;
									goto IL_00fe;
								}
								goto IL_04ce;
							}
							IL_00fe:
							while (true)
							{
								switch ((int)/*Error near IL_01bf: Stack underflow*/)
								{
								case 12:
									break;
								case 23:
									return;
								case 7:
								case 31:
									if (16 == 0)
									{
										_ = 22;
									}
									continue;
								case 41:
									if (1 == 0)
									{
										_ = 5;
									}
									continue;
								case 10:
									obj = obj;
									_ = 25;
									continue;
								case 20:
									obj = (object)/*Error near IL_021f: Stack underflow*/;
									if (32 != 0)
									{
										_ = 36;
									}
									continue;
								case 29:
									obj = 0;
									if (2 != 0)
									{
										_ = 0;
									}
									continue;
								case 8:
									if (&obj != null)
									{
										if (9 == 0)
										{
											_ = 7;
										}
										continue;
									}
									goto case 29;
								case 11:
									obj = (object)/*Error near IL_0277: Stack underflow*/;
									_ = 8;
									continue;
								case 16:
									obj = obj;
									_ = 13;
									continue;
								case 17:
									obj = 0;
									if (15 != 0)
									{
										_ = 13;
									}
									continue;
								default:
									obj = -1;
									_ = 35;
									continue;
								case 28:
									_ = 37;
									continue;
								case 21:
									if (18 != 0)
									{
										_ = 31;
									}
									continue;
								case 36:
									obj = (object)/*Error near IL_02fd: Stack underflow*/;
									if (true)
									{
										_ = 1;
									}
									continue;
								case 43:
									if (&obj == null)
									{
										if (30 != 0)
										{
											_ = 44;
										}
										continue;
									}
									goto case 28;
								case 37:
									obj++;
									if (21 == 0)
									{
										_ = 27;
									}
									continue;
								case 44:
									obj = obj;
									obj = 41;
									continue;
								case 39:
									if (false)
									{
										_ = 0;
									}
									continue;
								case 24:
									obj = (object)/*Error near IL_0395: Stack underflow*/;
									obj = 10;
									continue;
								case 3:
									_ = ref obj;
									obj = 23;
									continue;
								case 1:
									obj = obj;
									if (17 != 0)
									{
										_ = 13;
									}
									continue;
								case 25:
									obj = 0;
									if (46 == 0)
									{
										_ = 23;
									}
									continue;
								case 5:
									_ = 28;
									continue;
								case 38:
								case 46:
									if ((nint)obj >= ((Array)obj).Length)
									{
										if (22 != 0)
										{
											_ = 26;
										}
										continue;
									}
									goto case 30;
								case 14:
									if (&obj != null)
									{
										_ = 7;
										continue;
									}
									goto case 16;
								case 9:
								case 35:
									obj = (object)(&obj);
									_ = 19;
									continue;
								case 34:
									obj = (object)/*Error near IL_0459: Stack underflow*/;
									if (24 == 0)
									{
										_ = 6;
									}
									continue;
								case 2:
									if (3 != 0)
									{
										_ = 3;
									}
									continue;
								case 22:
									obj++;
									_ = 38;
									continue;
								case 30:
									obj = ((object[])obj)[obj];
									if (14 != 0)
									{
										_ = 3;
									}
									continue;
								case 15:
								case 27:
									if ((nint)obj < ((Array)obj).Length)
									{
										_ = 32;
										continue;
									}
									goto case 33;
								case 18:
									goto end_IL_00fe;
								case 26:
									if (4 == 0)
									{
										_ = 2;
									}
									continue;
								case 32:
								case 45:
									obj = ((object[])obj)[obj];
									_ = 43;
									continue;
								case 13:
									_ = 21;
									continue;
								case 40:
									if (3 != 0)
									{
										_ = 6;
									}
									continue;
								case 33:
									_ = 40;
									continue;
								case 19:
									if (obj == null)
									{
									}
									_ = 42;
									continue;
								case 42:
								{
									object obj4 = obj;
									_ = 34;
									continue;
								}
								case 4:
								{
									object obj3 = obj;
									_ = 20;
									continue;
								}
								case 6:
								{
									object obj2 = obj;
									_ = 12;
									continue;
								}
								}
								goto end_IL_00b9;
								continue;
								end_IL_00fe:
								break;
							}
							goto IL_04ce;
							IL_04ce:
							obj = (object)Unsafe.AsPointer(ref this);
							if (35 == 0)
							{
								_ = 39;
							}
							goto IL_00fe;
							end_IL_00b9:
							break;
						}
						break;
					}
					goto default;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00글()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778466, new IntPtr(2737336182412L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00꼀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00뀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778467, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00넀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778464, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00눀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00대(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00됀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778465, new IntPtr(2737336185532L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CTopUp_003Ed__92 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TopUpArgs args;

		public PaymentViewModel _003C_003E4__this;

		private TaskAwaiter<EntityMassOrder> _003C_003Eu__1;

		internal static object DefineSystem;

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
		internal static bool DecorateAlphabeticChooser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckEditableSolver()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00ꈀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778478, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00ꌀ()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_005a: Expected Obj, but got Ref
			//IL_049b: Expected Obj, but got Ref
			//IL_0188: Expected Obj, but got Ref
			//IL_0175: Expected Obj, but got I4
			//IL_017e: Expected Obj, but got I4
			//IL_03f3: Expected Obj, but got I4
			//IL_0162: Expected Obj, but got I4
			//IL_0308: Expected Obj, but got Ref
			//IL_0284: Expected Obj, but got Ref
			//IL_02ba: Expected Obj, but got Ref
			//IL_02a0: Expected Obj, but got I4
			//IL_02aa: Expected Obj, but got I4
			//IL_02d9: Expected Obj, but got I4
			//IL_0066->IL0019: Incompatible stack heights: 0 vs 1
			//IL_04a7->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0497->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0071->IL0019: Incompatible stack types: I4 vs Obj
			//IL_04b2->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0084->IL0088: Incompatible stack heights: 1 vs 0
			//IL_019f->IL0088: Incompatible stack heights: 1 vs 0
			//IL_0172->IL0088: Incompatible stack heights: 1 vs 0
			//IL_0167->IL0084: Incompatible stack heights: 2 vs 0
			//IL_0088->IL0088: Incompatible stack heights: 1 vs 0
			//IL_01b3->IL01c2: Incompatible stack heights: 0 vs 1
			//IL_03f0->IL0088: Incompatible stack heights: 1 vs 0
			//IL_040a->IL0088: Incompatible stack heights: 1 vs 0
			//IL_0143->IL0088: Incompatible stack heights: 1 vs 0
			//IL_00ed->IL0088: Incompatible stack heights: 1 vs 0
			//IL_02d4->IL01c2: Incompatible stack heights: 4 vs 1
			//IL_0236->IL01c2: Incompatible stack heights: 5 vs 1
			//IL_02f9->IL01c2: Incompatible stack heights: 2 vs 1
			//IL_0244->IL01c2: Incompatible stack heights: 3 vs 1
			//IL_02c4->IL01c2: Incompatible stack heights: 2 vs 1
			//IL_029b->IL01c2: Incompatible stack heights: 2 vs 1
			//IL_0322->IL01c2: Incompatible stack heights: 2 vs 1
			//IL_034a->IL01c2: Incompatible stack heights: 3 vs 1
			//IL_02e4->IL01c2: Incompatible stack heights: 3 vs 1
			//IL_0220->IL01c2: Incompatible stack heights: 2 vs 1
			//IL_0274->IL01c2: Incompatible stack heights: 0 vs 1
			//IL_0304->IL01c2: Incompatible stack heights: 2 vs 1
			//IL_032d->IL01c2: Incompatible stack heights: 2 vs 1
			//IL_01c2->IL01c2: Incompatible stack heights: 3 vs 1
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
					_ = -2;
					if (2 == 0)
					{
						_ = 2;
					}
					break;
				default:
					obj = (object)Unsafe.AsPointer(ref this);
					if (5 == 0)
					{
						obj2 = 0;
					}
					break;
				case 3:
					return;
				case 5:
					if (obj == null)
					{
						_ = 11;
						goto IL_0088;
					}
					goto IL_0183;
				case 2:
					_ = 3;
					break;
				case 1:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (false)
						{
							obj2 = 0;
						}
						break;
					}
					IL_0088:
					while (true)
					{
						int num;
						switch ((int)/*Error near IL_00c9: Stack underflow*/)
						{
						case 2:
						case 6:
							break;
						case 8:
							if ((nint)obj <= 0)
							{
								if (false)
								{
									_ = 1;
								}
								continue;
							}
							goto case 5;
						default:
							if (obj != null)
							{
								if (14 == 0)
								{
									_ = 6;
								}
								continue;
							}
							goto case 10;
						case 14:
							_ = 2;
							obj = 2;
							continue;
						case 10:
						case 11:
							_ = 4;
							continue;
						case 1:
						case 3:
							obj = 1;
							obj = 7;
							continue;
						case 9:
							goto IL_0183;
						case 4:
							if (obj != null)
							{
								if (6 == 0)
								{
									num = 8;
								}
								goto IL_01c2;
							}
							goto IL_0304;
						case 5:
							if ((nint)obj <= 500)
							{
								_ = 13;
								continue;
							}
							goto case 1;
						case 12:
						case 13:
							{
								obj = 0;
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							}
							IL_0304:
							obj = (object)Unsafe.AsPointer(ref this);
							num = 9;
							goto IL_01c2;
							IL_01c2:
							while (true)
							{
								switch (num)
								{
								case 14:
									break;
								case 16:
									return;
								case 15:
									_ = 14;
									continue;
								case 5:
									_ = 11;
									continue;
								case 7:
									_ = 1;
									_ = 6;
									continue;
								case 3:
									if (&obj != null)
									{
										if (0 == 0)
										{
											num = 0;
										}
										continue;
									}
									goto case 12;
								default:
									obj = (object)(&obj);
									num = 5;
									continue;
								case 9:
									_ = 13;
									continue;
								case 12:
									obj = 0;
									obj = 10;
									continue;
								case 8:
									obj = (object)Unsafe.AsPointer(ref this);
									_ = 3;
									continue;
								case 1:
									_ = ref obj;
									_ = 16;
									continue;
								case 13:
									obj = -1;
									_ = 2;
									continue;
								case 6:
									_ = null;
									if (15 == 0)
									{
										_ = 1;
									}
									continue;
								case 4:
									goto IL_0304;
								case 10:
									if (true)
									{
										_ = 1;
									}
									continue;
								case 11:
									_ = -1;
									_ = 7;
									continue;
								}
								break;
							}
							break;
						}
						break;
					}
					goto case 4;
					IL_0183:
					obj = (object)Unsafe.AsPointer(ref this);
					if (4 != 0)
					{
						_ = 8;
					}
					goto IL_0088;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00ꐀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778479, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00ꔀ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00ꘀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778476, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_A700()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00ꠀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778477, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00꤀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00ꨀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778474, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[CompilerGenerated]
	private Func<InfoBarDelegate>? m_GetInfoBar;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<TopUpArgs>? topUpCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? refreshShopCollectionCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<HistoryOrderModel>? refreshHistoryOrderCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? refreshHistoryOrderCollectionCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<ProductModel>? redeemProductCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? redeemCodeCommand;

	private static object UpdateDic;

	public bool IsRunning
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return this._FF00_FF00_FFFD() != 0;
		}
	}

	public bool CanSelect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_2900() != 0;
		}
	}

	public bool ShowTabs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00눀() != 0;
		}
	}

	[NotifyPropertyChangedFor("ShowTabs")]
	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsLoading
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_EF00() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_E300(value ? ((byte)1) : ((byte)0));
		}
	}

	[NotifyPropertyChangedFor("CanSelect")]
	[NotifyPropertyChangedFor("ShowTabs")]
	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool Ordering
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_2F00() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00切(value ? ((byte)1) : ((byte)0));
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int Balance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00딀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_0300((uint)value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[NotifyPropertyChangedFor("HasShopDescription")]
	public string ShopDescription
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00ﰀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00케(value);
		}
	}

	public bool HasShopDescription
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_2500() != 0;
		}
	}

	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public string Code
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_0900();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FE00(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public int SelectedIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)this._FF00_FF00_FFFD();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00됀((uint)value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int CurrentPage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00저();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00ᔀ((uint)value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public double CustomCoinAmount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_EC00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00ጀ(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public ObservableCollection<ProductModel> Products
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00쌀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			this._FF00_FF00_FFFD(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public ObservableCollection<ProductGroupModel> ProductGroups
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_2200();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00촀(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[NotifyPropertyChangedFor("SelectedProductGroup")]
	public int SelectedProductGroupIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00_FF00㐀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_F300((uint)value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int SelectedTopUpTabIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00_F700();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00묀((uint)value);
		}
	}

	public ProductGroupModel? SelectedProductGroup
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (ProductGroupModel?)_FF00_FF00뼀();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public ObservableCollection<TopUpModel> TopUps
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00픀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_F100(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ObservableCollection<TopUpGroupModel> TopUpGroups
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00쬀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_E700(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[NotifyPropertyChangedFor("SelectedTopUpGroup")]
	[ObservableProperty]
	public int SelectedTopUpGroupIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00_FF00_2600();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_0C00((uint)value);
		}
	}

	public TopUpGroupModel? SelectedTopUpGroup
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (TopUpGroupModel?)_FF00_FF00_FF00Ȁ();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public ObservableCollection<object> TopUpItems
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00휀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00렀(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public ObservableCollection<PayMethodModel> PayMethods
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00ᤀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00툀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public ObservableCollection<HistoryOrderModel> Orders
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00쐀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00ἀ(value);
		}
	}

	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public OrderModel Order
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (OrderModel)_FF00_FF00_E200();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_EA00(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand<TopUpArgs> TopUpCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_F800();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand RefreshShopCollectionCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_FF00턀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<HistoryOrderModel> RefreshHistoryOrderCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00뤀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand RefreshHistoryOrderCollectionCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_FF00_FF00_0700();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand<ProductModel> RedeemProductCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00㜀();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand RedeemCodeCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_FF00쀀();
		}
	}

	public event Func<InfoBarDelegate>? GetInfoBar
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00_FF00_FF00_2800(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00_FF00_FF00Ⰰ(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PaymentViewModel()
	{
		//IL_00ba: Expected I4, but got Obj
		//IL_0080->IL0089: Incompatible stack types: I4 vs Obj
		//IL_00ec->IL0089: Incompatible stack heights: 15 vs 14
		//IL_01b4->IL0089: Incompatible stack heights: 16 vs 14
		//IL_00d2->IL0089: Incompatible stack heights: 15 vs 14
		//IL_018d->IL0140: Incompatible stack heights: 12 vs 13
		//IL_0119->IL0089: Incompatible stack heights: 15 vs 14
		//IL_00fe->IL0089: Incompatible stack heights: 15 vs 14
		//IL_016b->IL0089: Incompatible stack heights: 16 vs 14
		//IL_017b->IL0089: Incompatible stack heights: 15 vs 14
		//IL_00dd->IL0089: Incompatible stack heights: 15 vs 14
		//IL_0199->IL0089: Incompatible stack heights: 12 vs 14
		//IL_0124->IL0089: Incompatible stack heights: 15 vs 14
		//IL_0109->IL0089: Incompatible stack heights: 15 vs 14
		//IL_015b->IL0089: Incompatible stack types: I4 vs Obj
		//IL_0186->IL0089: Incompatible stack heights: 15 vs 14
		//IL_01a4->IL0089: Incompatible stack heights: 12 vs 14
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = 1;
		_ = 1.0;
		PaymentViewModel paymentViewModel = this;
		if (0 == 0)
		{
			paymentViewModel = (PaymentViewModel)0;
		}
		while (true)
		{
			switch ((int)paymentViewModel)
			{
			case 3:
				return;
			case 2:
				if (true)
				{
					_ = 1;
				}
				break;
			default:
				_ = 4;
				break;
			case 5:
			case 7:
				if (2 == 0)
				{
					_ = 2;
				}
				break;
			case 6:
				_ = null;
				if (1 == 0)
				{
					_ = 3;
				}
				break;
			case 8:
				paymentViewModel = this;
				if (7 != 0)
				{
					paymentViewModel = (PaymentViewModel)5;
				}
				break;
			case 9:
				_ = 10;
				break;
			case 10:
				_ = null;
				if (6 != 0)
				{
					_ = 6;
				}
				break;
			case 4:
				if (this == null)
				{
					if (5 != 0)
					{
						_ = 5;
					}
					break;
				}
				goto case 8;
			case 1:
				_ = 9;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateSelect(object? sender, object e)
	{
		_FF00_FF00_FF00က(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		_FF00_FF00_FF00ᰀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update(object user)
	{
		_FF00_FF00_FF00_3100(user);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CTopUp_003Ed__92))]
	private object TopUp(object args)
	{
		return _FF00_FF00_F500(args);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshShopCollection_003Ed__93))]
	[RelayCommand]
	private object RefreshShopCollection()
	{
		return _FF00_FF00_FF00_2300();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshHistoryOrder_003Ed__94))]
	[RelayCommand]
	private object RefreshHistoryOrder(object order)
	{
		return _FF00_FF00_FF00_3200(order);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshHistoryOrderCollection_003Ed__95))]
	[RelayCommand]
	private object RefreshHistoryOrderCollection()
	{
		return _FF00_FF00_FF00Ā();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedeemProduct_003Ed__96))]
	[RelayCommand]
	private object RedeemProduct(object productModel)
	{
		return _FF00_FF00였(productModel);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CRedeemCode_003Ed__97))]
	private object RedeemCode()
	{
		return _FF00_FF00뜀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InfoBar(object text, InfoBarSeverity severity = (InfoBarSeverity)0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_FF00_FF00_E000(text, severity);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnSelectedIndexChanged(uint value)
	{
		_FF00_FF00_E500(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnProductGroupsChanged(ObservableCollection<ProductGroupModel> value)
	{
		_FF00_FF00_FF00_1B00(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnTopUpGroupsChanged(ObservableCollection<TopUpGroupModel> value)
	{
		_FF00_FF00봀(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckConfigurableEngine()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PaymentViewModel DecorateSeparatedCompiler()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00넀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778567, new IntPtr(2737336170972L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00눀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
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
				if (this == null)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				return 0;
			default:
				return (this == null) ? ((byte)1) : ((byte)0);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00대(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778564, new IntPtr(2737336167852L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00됀(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_0073->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0066->IL0019: Incompatible stack heights: 3 vs 1
		//IL_004e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0097->IL0066: Incompatible stack heights: 1 vs 0
		//IL_0059->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0019: Incompatible stack types: I4 vs Obj
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
			case 3:
				if (2 != 0)
				{
					_ = 2;
				}
				break;
			case 2:
				_ = 6;
				break;
			case 1:
				_ = 3;
				break;
			case 6:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 5:
				obj2 = this;
				if (P_0 != 0)
				{
					if (4 != 0)
					{
						obj2 = 4;
					}
					break;
				}
				goto case 1;
			case 0:
				return;
			case 4:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00딀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00똀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778565, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00뜀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17999, 1790778562, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778562, new IntPtr(2737336186572L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00렀(ObservableCollection<object> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0046->IL0084: Incompatible stack heights: 1 vs 0
		//IL_0091->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0084->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0077->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005d->IL0019: Incompatible stack types: I4 vs Obj
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
			case 1:
				return;
			case 2:
				obj2 = this;
				if (P_0 != null)
				{
					if (0 == 0)
					{
						obj2 = 1;
					}
					continue;
				}
				break;
			case 5:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				continue;
			case 4:
				_ = 5;
				continue;
			case 3:
				break;
			}
			_ = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<HistoryOrderModel> _FF00_FF00뤀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18001, 1790778563, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778563, new IntPtr(2737336181372L), 15);
		}
		return (IAsyncRelayCommand<HistoryOrderModel>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<HistoryOrderModel> _FF00_FF00먀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778560, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<HistoryOrderModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00묀(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0089->IL0058: Incompatible stack heights: 1 vs 0
		//IL_0058->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0065->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a0->IL0019: Incompatible stack types: I4 vs Obj
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
			case 1:
				return;
			case 0:
				return;
			case 3:
				_ = 5;
				break;
			case 4:
				_ = 3;
				break;
			case 5:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 2:
				obj2 = this;
				if (P_0 != 0)
				{
					if (true)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00밀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778561, new IntPtr(2737336158492L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00봀(ObservableCollection<TopUpGroupModel> P_0)
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
			case 0:
				return;
			case 1:
				_ = 0;
				if (false)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00븀(ObservableCollection<TopUpGroupModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778574, new IntPtr(2737336180332L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00뼀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18007, 1790778575, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778575, new IntPtr(2737336170972L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00쀀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18008, 1790778572, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778572, new IntPtr(2737336167852L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00섀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778573, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<ProductModel> _FF00_FF00숀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778570, new IntPtr(2737336180332L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<ProductModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ObservableCollection<ProductModel> _FF00_FF00쌀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<ProductModel>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ObservableCollection<HistoryOrderModel> _FF00_FF00쐀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<HistoryOrderModel>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00씀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778571, new IntPtr(2737336176172L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00였(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18014, 1790778568, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778568, new IntPtr(2737336168892L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00윀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778569, new IntPtr(2737336182412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00저()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00준()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778582, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<TopUpGroupModel> _FF00_FF00쨀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778583, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<TopUpGroupModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ObservableCollection<TopUpGroupModel> _FF00_FF00쬀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<TopUpGroupModel>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00찀(ObservableCollection<ProductGroupModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778580, new IntPtr(2737336180332L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00촀(ObservableCollection<ProductGroupModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_00af->IL0019: Incompatible stack heights: 3 vs 1
		//IL_006f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0049->IL007a: Incompatible stack heights: 1 vs 0
		//IL_0087->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0060->IL0019: Incompatible stack types: I4 vs Obj
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
				obj2 = this;
				if (P_0 != null)
				{
					if (3 == 0)
					{
						obj2 = 3;
					}
					break;
				}
				goto case 6;
			case 2:
				if (false)
				{
					_ = 0;
				}
				break;
			case 6:
				_ = 2;
				break;
			case 1:
				return;
			case 3:
				return;
			case 5:
				obj2 = this;
				if (true)
				{
					obj2 = 1;
				}
				break;
			default:
				_ = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00츀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778581, new IntPtr(2737336163692L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00케(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0070->IL00c8: Incompatible stack heights: 1 vs 0
		//IL_00c8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0059->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00bb->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0087->IL0019: Incompatible stack types: I4 vs Obj
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
				obj2 = this;
				if (6 == 0)
				{
					obj2 = 5;
				}
				break;
			default:
				_ = 4;
				break;
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
			case 5:
				obj2 = this;
				if (3 == 0)
				{
					obj2 = 3;
				}
				break;
			case 6:
				if (2 == 0)
				{
					_ = 2;
				}
				break;
			case 2:
				_ = 5;
				break;
			case 3:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00퀀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778578, new IntPtr(2737336180332L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00턀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18025, 1790778579, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778579, new IntPtr(2737336154332L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00툀(ObservableCollection<PayMethodModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0043: Expected Obj, but got I4
		//IL_0093->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0048->IL0015: Incompatible stack heights: 1 vs 0
		//IL_006c->IL0083: Incompatible stack heights: 1 vs 0
		//IL_009e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0062->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0083->IL0019: Incompatible stack types: I4 vs Obj
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
					break;
				case 3:
					obj2 = this;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 4:
					obj2 = this;
					if (P_0 == null)
					{
						if (3 != 0)
						{
							obj2 = 1;
						}
						continue;
					}
					return;
				case 2:
					return;
				default:
					if (true)
					{
						_ = 0;
					}
					continue;
				}
				break;
			}
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00팀(ObservableCollection<PayMethodModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778576, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<TopUpModel> _FF00_FF00퐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778577, new IntPtr(2737336179292L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<TopUpModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ObservableCollection<TopUpModel> _FF00_FF00픀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<TopUpModel>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<TopUpModel> _FF00_FF00혀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778590, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<TopUpModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ObservableCollection<object> _FF00_FF00휀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<object>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FFFD()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778591, new IntPtr(2737336182412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778588, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FFFD()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0052: Expected I4, but got Obj
		//IL_0043->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0068->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004e->IL0019: Incompatible stack types: I4 vs Obj
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
			default:
				if (this == null)
				{
					if (1 == 0)
					{
						obj2 = 2;
					}
					break;
				}
				goto IL_0052;
			case 2:
				return (byte)(int)this;
			case 1:
				{
					if (this == null)
					{
						if (0 == 0)
						{
							obj2 = 0;
						}
						break;
					}
					goto IL_0052;
				}
				IL_0052:
				return 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778589, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FFFD(ObservableCollection<ProductModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778586, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FFFD(ObservableCollection<ProductModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0069->IL0037: Incompatible stack heights: 1 vs 0
		//IL_0054->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0080->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				return;
			case 2:
				_ = 4;
				break;
			case 4:
				if (false)
				{
					_ = 0;
				}
				break;
			case 3:
				obj2 = this;
				if (P_0 != null)
				{
					return;
				}
				if (2 != 0)
				{
					obj2 = 1;
				}
				break;
			default:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FFFD(ObservableCollection<ProductModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778587, new IntPtr(2737336182412L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_E000(object P_0, InfoBarSeverity P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0044->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006c->IL0019: Incompatible stack heights: 3 vs 1
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
				if (this == null)
				{
					if (1 == 0)
					{
						obj2 = 0;
					}
				}
				else if (0 == 0)
				{
					_ = 0;
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
	private unsafe void _FF00_FF00_E100(object P_0, InfoBarSeverity P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778584, new IntPtr(2737336158492L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_E200()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_E300(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_00a6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0082->IL0044: Incompatible stack heights: 1 vs 0
		//IL_00b3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00cd->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0078->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0099->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				return;
			case 4:
				return;
			case 3:
				obj2 = this;
				if (6 == 0)
				{
					obj2 = 0;
				}
				break;
			case 7:
				if (false)
				{
					_ = 0;
				}
				break;
			case 2:
				obj2 = this;
				if (P_0 != 0)
				{
					if (true)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 3;
			default:
				_ = 5;
				break;
			case 5:
				_ = 4;
				break;
			case 6:
				obj2 = this;
				if (5 == 0)
				{
					obj2 = 7;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_E400(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778585, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_E500(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
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
	private unsafe void _FF00_FF00_E600(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778406, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_E700(ObservableCollection<TopUpGroupModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_00be->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a4->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004a->IL0061: Incompatible stack heights: 1 vs 0
		//IL_00c9->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00af->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0095->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0061->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 0:
				return;
			case 5:
				return;
			case 6:
				obj2 = this;
				if (P_0 != null)
				{
					if (3 != 0)
					{
						obj2 = 5;
					}
					break;
				}
				goto case 2;
			case 2:
				obj2 = this;
				if (3 == 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				if (0 == 0)
				{
					_ = 1;
				}
				break;
			case 1:
				if (4 == 0)
				{
					_ = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_E800(ObservableCollection<TopUpGroupModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778407, new IntPtr(2737336183452L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_E900(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778404, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_EA00(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_008d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0042->IL0037: Incompatible stack heights: 1 vs 0
		//IL_0080->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0073->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0059->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = this;
				if (P_0 != null)
				{
					return;
				}
				if (true)
				{
					obj2 = 1;
				}
				break;
			case 1:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
				_ = 3;
				break;
			default:
				_ = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_EB00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778405, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal double _FF00_FF00_EC00()
	{
		//IL_000a: Expected F8, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (double)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe double _FF00_FF00_ED00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778402, new IntPtr(2737336173052L), 15))(null, 0, new IntPtr(0L));
		return (double)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_EE00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778403, new IntPtr(2737336173052L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_EF00()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_F000(ObservableCollection<TopUpModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778400, new IntPtr(2737336173052L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_F100(ObservableCollection<TopUpModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0075->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0041->IL0065: Incompatible stack heights: 1 vs 0
		//IL_0065->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0080->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
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
				if (P_0 == null)
				{
					_ = 3;
					break;
				}
				return;
			default:
				obj2 = this;
				if (2 != 0)
				{
					obj2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 3:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_F200(ObservableCollection<TopUpModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778401, new IntPtr(2737336177212L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_F300(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_00ae: Expected Obj, but got I4
		//IL_004c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0056->IL007a: Incompatible stack heights: 1 vs 0
		//IL_008a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b3->IL0015: Incompatible stack heights: 1 vs 0
		//IL_007a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0060->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0095->IL0019: Incompatible stack heights: 2 vs 1
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
					_ = 6;
					continue;
				case 3:
					if (P_0 == 0)
					{
						_ = 2;
						continue;
					}
					return;
				case 1:
					obj2 = this;
					if (false)
					{
						obj2 = 0;
					}
					continue;
				case 6:
					return;
				case 4:
					if (1 == 0)
					{
						_ = 1;
					}
					continue;
				case 2:
					_ = 5;
					continue;
				case 5:
					break;
				}
				break;
			}
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_F400(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778414, new IntPtr(2737336182412L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_F500(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18061, 1790778415, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778415, new IntPtr(2737336184492L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_F600(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778412, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_F700()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<TopUpArgs> _FF00_FF00_F800()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18064, 1790778413, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778413, new IntPtr(2737336187612L), 15);
		}
		return (IAsyncRelayCommand<TopUpArgs>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<TopUpArgs> _FF00_FF00豈()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778410, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<TopUpArgs>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00切(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0046: Expected I4, but got Obj
		//IL_00d5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ba->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0072->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007c->IL004b: Incompatible stack heights: 1 vs 0
		//IL_0093->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0065->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ad->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0086->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 8;
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
			case 5:
				_ = 4;
				break;
			case 8:
				if (P_0 != 0)
				{
					_ = 7;
					break;
				}
				goto default;
			case 9:
				_ = 5;
				break;
			case 4:
				obj2 = this;
				if (6 == 0)
				{
					obj2 = 3;
				}
				break;
			case 2:
				_ = 9;
				break;
			case 3:
				return;
			case 7:
				return;
			case 6:
				_ = 3;
				break;
			case 1:
				_ = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00ﬀ(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778411, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00ﰀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00ﴀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778408, new IntPtr(2737336180332L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FE00(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0067->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0041->IL00a6: Incompatible stack heights: 1 vs 0
		//IL_00a6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0058->IL0019: Incompatible stack types: I4 vs Obj
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
				obj2 = this;
				if (P_0 == null)
				{
					if (3 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				return;
			case 1:
				if (false)
				{
					_ = 0;
				}
				break;
			case 3:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			default:
				obj2 = this;
				if (2 != 0)
				{
					obj2 = 1;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778409, new IntPtr(2737336158492L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00Ā()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18072, 1790778422, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778422, new IntPtr(2737336158492L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00Ȁ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18073, 1790778423, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778423, new IntPtr(2737336155372L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_0300(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0048->IL0019: Incompatible stack heights: 3 vs 1
		//IL_007c->IL0048: Incompatible stack heights: 1 vs 0
		//IL_00a0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0062->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0019: Incompatible stack types: I4 vs Obj
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
				_ = 4;
				break;
			case 3:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 1:
				return;
			case 5:
				return;
			case 2:
				obj2 = this;
				if (P_0 != 0)
				{
					if (1 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 3;
			case 4:
				_ = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00Ѐ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778420, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00Ԁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778421, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_0600()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_0700()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18078, 1790778418, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778418, new IntPtr(2737336172012L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00ࠀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778419, new IntPtr(2737336173052L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_0900()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_0A00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778416, new IntPtr(2737336173052L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_0B00(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778417, new IntPtr(2737336182412L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_0C00(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_00c9->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008b->IL004c: Incompatible stack heights: 1 vs 0
		//IL_0076->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0067->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00bc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0081->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a2->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 6:
				_ = 4;
				break;
			case 1:
				return;
			case 2:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 5:
				if (6 == 0)
				{
					_ = 6;
				}
				break;
			case 3:
				obj2 = this;
				if (P_0 != 0)
				{
					return;
				}
				if (1 == 0)
				{
					obj2 = 2;
				}
				break;
			case 4:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			default:
				_ = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_0D00(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778430, new IntPtr(2737336163692L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_0E00(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0065->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0097->IL0054: Incompatible stack heights: 1 vs 0
		//IL_0088->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0070->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ae->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
			case 1:
				return;
			default:
				_ = -2;
				if (2 != 0)
				{
					_ = 1;
				}
				continue;
			case 4:
				obj2 = this;
				if (obj2 != null)
				{
					break;
				}
				obj2 = 3;
				continue;
			case 3:
				obj2 = null;
				break;
			}
			if (P_1 != null)
			{
				break;
			}
			if (false)
			{
				obj2 = 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00ༀ(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778431, new IntPtr(2737336185532L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00က(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0041->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0075->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005b->IL0019: Incompatible stack types: I4 vs Obj
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
			case 1:
				_ = 3;
				break;
			case 3:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				obj2 = this;
				if (true)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00ᄀ(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778428, new IntPtr(2737336173052L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00ሀ(double P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778429, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00ጀ(double P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_008d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0041->IL007f: Incompatible stack heights: 1 vs 0
		//IL_0065->IL0019: Incompatible stack heights: 3 vs 1
		//IL_007f->IL0019: Incompatible stack types: I4 vs Obj
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
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				return;
			case 3:
				_ = 4;
				break;
			case 4:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 2;
				}
				break;
			case 2:
				return;
			default:
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_1400(double P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778426, new IntPtr(2737336176172L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00ᔀ(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0045->IL00a0: Incompatible stack heights: 1 vs 0
		//IL_0069->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00ba->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0084->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005c->IL0019: Incompatible stack types: I4 vs Obj
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
				return;
			case 3:
				obj2 = this;
				if (P_0 != 0)
				{
					if (2 != 0)
					{
						obj2 = 2;
					}
					continue;
				}
				break;
			case 4:
				_ = 5;
				continue;
			case 0:
				return;
			case 2:
				return;
			case 5:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				continue;
			case 1:
				break;
			}
			obj2 = this;
			if (4 == 0)
			{
				obj2 = 3;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00ᘀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00ᜀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778427, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<PayMethodModel> _FF00_FF00_FF00_1800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778424, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<PayMethodModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ObservableCollection<PayMethodModel> _FF00_FF00_FF00ᤀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<PayMethodModel>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<PayMethodModel> _FF00_FF00_FF00ᨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778425, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<PayMethodModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_1B00(ObservableCollection<ProductGroupModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
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
				_ = 0;
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
	internal sealed void _FF00_FF00_FF00ᰀ()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0047->IL0019: Incompatible stack types: I4 vs Obj
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
				if (false)
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
	internal unsafe sealed void _FF00_FF00_FF00ᴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778374, new IntPtr(2737336188652L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00Ḁ(ObservableCollection<HistoryOrderModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778375, new IntPtr(2737336182412L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00ἀ(ObservableCollection<HistoryOrderModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0060->IL006a: Incompatible stack heights: 1 vs 0
		//IL_0077->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0086->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0055->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0091->IL0019: Incompatible stack heights: 2 vs 1
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
				return;
			case 1:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				return;
			case 3:
				if (P_0 != null)
				{
					_ = 2;
					break;
				}
				goto case 4;
			case 4:
				_ = 5;
				break;
			case 5:
				if (true)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_2000(ObservableCollection<HistoryOrderModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778372, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<ProductGroupModel> _FF00_FF00_FF00_2100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778373, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<ProductGroupModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ObservableCollection<ProductGroupModel> _FF00_FF00_FF00_2200()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<ProductGroupModel>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_2300()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18106, 1790778370, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778370, new IntPtr(2737336179292L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_2400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778371, new IntPtr(2737336173052L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_2500()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (this == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_2600()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_2700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778368, new IntPtr(2737336185532L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_2800(Func<InfoBarDelegate> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_008d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_005c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007a->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				if (obj == obj)
				{
					obj2 = 5;
					break;
				}
				goto case 1;
			case 1:
				obj = obj;
				obj2 = 4;
				break;
			case 4:
				obj2 = obj;
				obj = P_0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				obj = obj;
				_ = 3;
				break;
			case 2:
				obj = this;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_2900()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0066->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0071->IL0019: Incompatible stack types: I4 vs Obj
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
				return (this == null) ? ((byte)1) : ((byte)0);
			case 1:
				return 0;
			case 2:
				if (this != null)
				{
					if (true)
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
	internal unsafe byte _FF00_FF00_FF00_2A00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778369, new IntPtr(2737336182412L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_2B00(Func<InfoBarDelegate> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778382, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00Ⰰ(Func<InfoBarDelegate> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00a5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0051->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0077->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0097->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
			case 4:
				obj = obj;
				if (false)
				{
					_ = 0;
				}
				break;
			case 2:
				obj = this;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			default:
				if (obj == obj)
				{
					if (3 != 0)
					{
						obj2 = 3;
					}
					break;
				}
				goto case 1;
			case 1:
				obj = obj;
				obj2 = 5;
				break;
			case 5:
				obj = P_0;
				_ = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00ⴀ(Func<InfoBarDelegate> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778383, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_2E00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778380, new IntPtr(2737336185532L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_2F00()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_3000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778381, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_3100(object P_0)
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
	private unsafe object _FF00_FF00_FF00_3200(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18121, 1790778378, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778378, new IntPtr(2737336176172L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_3300(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778379, new IntPtr(2737336173052L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00㐀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00㔀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778376, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<ProductModel> _FF00_FF00_FF00㘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778377, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<ProductModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<ProductModel> _FF00_FF00_FF00㜀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18126, 1790778390, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778390, new IntPtr(2737336173052L), 15);
		}
		return (IAsyncRelayCommand<ProductModel>)((delegate*<object, object>)obj)(this);
	}
}
