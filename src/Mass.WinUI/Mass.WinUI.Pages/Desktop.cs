using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Markup;
using Microsoft.Web.WebView2.Core;
using WinRT;
using WinRT.Mass_WinUIVtableClasses;

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
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_006f: Expected Obj, but got Ref
			//IL_008a: Expected Obj, but got Ref
			//IL_0066: Expected Obj, but got I4
			//IL_00a6: Expected Obj, but got I4
			//IL_0312: Expected Obj, but got Ref
			//IL_015c: Expected I4, but got Obj
			//IL_01ec: Expected Obj, but got I4
			//IL_0276: Expected Obj, but got Ref
			//IL_01a1: Expected Obj, but got I4
			//IL_0309: Expected Obj, but got I4
			//IL_0297: Expected Obj, but got Ref
			//IL_02df: Invalid comparison between Obj and Ref
			//IL_0166: Expected Obj, but got Ref
			//IL_03b3: Expected Obj, but got I4
			//IL_03c6: Expected Obj, but got Ref
			//IL_042c: Expected Obj, but got I4
			//IL_035c: Expected Obj, but got Ref
			//IL_0564->IL0019: Incompatible stack heights: 2 vs 1
			//IL_007b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0094->IL0019: Incompatible stack types: I4 vs Obj
			//IL_004f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_006b->IL0015: Incompatible stack heights: 1 vs 0
			//IL_056f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0086->IL0019: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_031c->IL00af: Incompatible stack types: I4 vs Ref
			//IL_0262->IL00af: Incompatible stack types: I4 vs Ref
			//IL_00af->IL00af: Incompatible stack types: Obj vs Ref
			//IL_01f9->IL00af: Incompatible stack heights: 2 vs 1
			//IL_0282->IL00af: Incompatible stack heights: 0 vs 1
			//IL_018d->IL00af: Incompatible stack types: I4 vs Ref
			//IL_0462->IL00af: Incompatible stack heights: 2 vs 1
			//IL_01ae->IL00af: Incompatible stack heights: 2 vs 1
			//IL_03ae->IL00af: Incompatible stack heights: 2 vs 1
			//IL_01dc->IL00af: Incompatible stack heights: 2 vs 1
			//IL_040b->IL00af: Incompatible stack types: I4 vs Ref
			//IL_0474->IL00af: Incompatible stack heights: 0 vs 1
			//IL_030e->IL00ab: Incompatible stack heights: 2 vs 0
			//IL_02a1->IL00af: Incompatible stack heights: 2 vs 1
			//IL_0396->IL00af: Incompatible stack heights: 3 vs 1
			//IL_0172->IL00af: Incompatible stack heights: 0 vs 1
			//IL_03be->IL00af: Incompatible stack heights: 3 vs 1
			//IL_03d0->IL00af: Incompatible stack heights: 2 vs 1
			//IL_0236->IL00af: Incompatible stack types: I4 vs Ref
			//IL_034d->IL00af: Incompatible stack heights: 3 vs 1
			//IL_033b->IL00af: Incompatible stack types: I4 vs Ref
			//IL_0439->IL00af: Incompatible stack heights: 2 vs 1
			//IL_0366->IL00af: Incompatible stack types: I4 vs Ref
			//IL_0494->IL00af: Incompatible stack heights: 2 vs 1
			//IL_02af->IL00af: Incompatible stack heights: 3 vs 1
			//IL_0204->IL00af: Incompatible stack heights: 2 vs 1
			//IL_028d->IL00af: Incompatible stack types: I4 vs Ref
			//IL_01b9->IL00af: Incompatible stack heights: 2 vs 1
			//IL_03f3->IL00af: Incompatible stack heights: 0 vs 1
			//IL_032e->IL00af: Incompatible stack types: I4 vs Ref
			//IL_01e7->IL00af: Incompatible stack heights: 2 vs 1
			//IL_0455->IL00af: Incompatible stack types: I4 vs Ref
			//IL_0218->IL00af: Incompatible stack types: I4 vs Ref
			//IL_047f->IL00af: Incompatible stack types: I4 vs Ref
			//IL_03a1->IL00af: Incompatible stack heights: 3 vs 1
			//IL_02f0->IL00af: Incompatible stack heights: 0 vs 1
			//IL_0250->IL00af: Incompatible stack types: I4 vs Ref
			//IL_017d->IL00af: Incompatible stack types: I4 vs Ref
			//IL_0358->IL00af: Incompatible stack heights: 3 vs 1
			//IL_0444->IL00af: Incompatible stack heights: 2 vs 1
			//IL_0379->IL00af: Incompatible stack heights: 0 vs 1
			//IL_03fe->IL00af: Incompatible stack types: I4 vs Ref
			//IL_02fb->IL00af: Incompatible stack types: I4 vs Ref
			//IL_04bb->IL00af: Incompatible stack heights: 0 vs 1
			//IL_0384->IL00af: Incompatible stack types: I4 vs Ref
			//IL_04c6->IL00af: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					ref _003CGridViewItemClick_003Ed__5 reference;
					switch ((int)obj2)
					{
					case 4:
						_ = -2;
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
					case 5:
						break;
					case 2:
						obj = (object)Unsafe.AsPointer(ref this);
						if (false)
						{
							obj2 = 1;
						}
						continue;
					case 3:
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 2;
						continue;
					case 6:
						return;
					case 1:
						if (obj == null)
						{
							obj = 13;
							goto IL_00ab;
						}
						goto IL_0250;
					default:
						{
							_ = null;
							if (3 == 0)
							{
								_ = 5;
							}
							continue;
						}
						IL_0250:
						if ((nint)obj != 1)
						{
							reference = ref *(_003CGridViewItemClick_003Ed__5*)17;
							goto IL_00af;
						}
						goto IL_030e;
						IL_030e:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(_003CGridViewItemClick_003Ed__5*)26;
						goto IL_00af;
						IL_00af:
						while (true)
						{
							object obj3;
							switch ((uint)Unsafe.AsPointer(ref reference))
							{
							case 14u:
							case 19u:
							case 20u:
							case 22u:
							case 29u:
								break;
							case 27u:
								return;
							case 33u:
								return;
							case 4u:
							case 28u:
								obj = (object)Unsafe.AsPointer(ref this);
								if (4 == 0)
								{
									reference = ref *(_003CGridViewItemClick_003Ed__5*)18;
								}
								continue;
							case 3u:
								obj = obj;
								reference = ref *(_003CGridViewItemClick_003Ed__5*)39;
								continue;
							case 6u:
								obj = 0;
								if (3 == 0)
								{
									_ = 11;
								}
								continue;
							case 11u:
								if (24 != 0)
								{
									_ = 2;
								}
								continue;
							default:
								obj = -1;
								if (0 == 0)
								{
									_ = 2;
								}
								continue;
							case 15u:
								obj3 = obj;
								if (obj3 == null)
								{
									reference = ref *(_003CGridViewItemClick_003Ed__5*)35;
									continue;
								}
								goto IL_04aa;
							case 32u:
								obj = (object)/*Error near IL_022c: Stack underflow*/;
								reference = ref *(_003CGridViewItemClick_003Ed__5*)21;
								continue;
							case 26u:
								reference = ref this;
								if (0 == 0)
								{
									reference = ref *(_003CGridViewItemClick_003Ed__5*)null;
								}
								continue;
							case 7u:
								goto IL_0250;
							case 2u:
								obj = (object)(&obj);
								if (3 != 0)
								{
									reference = ref *(_003CGridViewItemClick_003Ed__5*)3;
								}
								continue;
							case 21u:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 8;
								continue;
							case 40u:
								_ = 34;
								continue;
							case 25u:
								if (Unsafe.AreSame(ref *(byte*)obj, ref Unsafe.As<_003CGridViewItemClick_003Ed__5, byte>(ref this)))
								{
									if (8 != 0)
									{
										reference = ref *(_003CGridViewItemClick_003Ed__5*)14;
									}
									continue;
								}
								goto case 31u;
							case 18u:
								goto IL_02fb;
							case 1u:
								goto IL_030e;
							case 9u:
								if (&obj != null)
								{
									reference = ref *(_003CGridViewItemClick_003Ed__5*)23;
									continue;
								}
								goto case 6u;
							case 36u:
								reference = ref *(_003CGridViewItemClick_003Ed__5*)19;
								continue;
							case 34u:
								_ = ref obj;
								if (27 == 0)
								{
									_ = 14;
								}
								continue;
							case 13u:
							case 38u:
								obj = (object)Unsafe.AsPointer(ref this);
								reference = ref *(_003CGridViewItemClick_003Ed__5*)10;
								continue;
							case 41u:
								if (Unsafe.AsPointer(ref this) == null)
								{
									if (6 == 0)
									{
										reference = ref *(_003CGridViewItemClick_003Ed__5*)16;
									}
									continue;
								}
								goto case 25u;
							case 24u:
								_ = ref obj;
								if (33 == 0)
								{
									_ = 20;
								}
								continue;
							case 10u:
								_ = 30;
								continue;
							case 30u:
								obj = -1;
								_ = 5;
								continue;
							case 31u:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 9;
								continue;
							case 8u:
								if (&obj == null)
								{
									if (23 == 0)
									{
										reference = ref *(_003CGridViewItemClick_003Ed__5*)37;
									}
									continue;
								}
								goto case 2u;
							case 16u:
								reference = ref *(_003CGridViewItemClick_003Ed__5*)29;
								continue;
							case 37u:
								obj = 1;
								if (20 != 0)
								{
									_ = 40;
								}
								continue;
							case 12u:
								if (obj != null)
								{
									reference = ref *(_003CGridViewItemClick_003Ed__5*)4;
									continue;
								}
								goto case 36u;
							case 5u:
							case 23u:
								_ = ref obj;
								_ = 15;
								continue;
							case 17u:
								obj = obj;
								if (true)
								{
									reference = ref *(_003CGridViewItemClick_003Ed__5*)12;
								}
								continue;
							case 39u:
								_ = 22;
								continue;
							case 35u:
								{
									obj3 = null;
									goto IL_04aa;
								}
								IL_04aa:
								if (obj3 == null)
								{
									if (false)
									{
										reference = ref *(_003CGridViewItemClick_003Ed__5*)20;
									}
									continue;
								}
								goto case 32u;
							}
							break;
						}
						goto case 4;
						IL_02fb:
						obj = 41;
						goto IL_00ab;
						IL_00ab:
						reference = ref *(_003CGridViewItemClick_003Ed__5*)obj;
						goto IL_00af;
					}
					break;
				}
				obj = 6;
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
		internal static byte _FF00_FF00_FF00_FF00堀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
		internal static object _FF00_FF00_FF00_FF00嬀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
		private sealed void _FF00_FF00_FF00_FF00帀(object P_0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0390: Expected Obj, but got Ref
			//IL_03b8: Expected Obj, but got Ref
			//IL_019e: Expected Obj, but got Ref
			//IL_027f: Expected Obj, but got Ref
			//IL_018f: Expected Obj, but got I4
			//IL_0243: Expected Obj, but got Ref
			//IL_0310: Expected Obj, but got I4
			//IL_02bb: Expected Obj, but got I4
			//IL_0134: Expected Obj, but got I4
			//IL_025f: Expected Obj, but got I4
			//IL_01df: Expected Obj, but got I4
			//IL_039c->IL0019: Incompatible stack heights: 0 vs 1
			//IL_03c4->IL0019: Incompatible stack heights: 0 vs 1
			//IL_03b4->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_03a7->IL0019: Incompatible stack types: I4 vs Obj
			//IL_03cf->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0069->IL006d: Incompatible stack heights: 1 vs 0
			//IL_01b5->IL006d: Incompatible stack heights: 1 vs 0
			//IL_019a->IL006d: Incompatible stack heights: 3 vs 0
			//IL_02ab->IL006d: Incompatible stack heights: 3 vs 0
			//IL_018a->IL006d: Incompatible stack heights: 2 vs 0
			//IL_030b->IL006d: Incompatible stack heights: 3 vs 0
			//IL_027a->IL006d: Incompatible stack heights: 4 vs 0
			//IL_02e0->IL006d: Incompatible stack heights: 2 vs 0
			//IL_023f->IL006d: Incompatible stack heights: 1 vs 0
			//IL_00f3->IL006d: Incompatible stack heights: 1 vs 0
			//IL_02ed->IL006d: Incompatible stack heights: 2 vs 0
			//IL_031b->IL006d: Incompatible stack heights: 3 vs 0
			//IL_02c8->IL006d: Incompatible stack heights: 2 vs 0
			//IL_016c->IL006d: Incompatible stack heights: 2 vs 0
			//IL_02fd->IL006d: Incompatible stack heights: 4 vs 0
			//IL_026a->IL006d: Incompatible stack heights: 3 vs 0
			//IL_01e4->IL0069: Incompatible stack heights: 1 vs 2
			//IL_010b->IL006d: Incompatible stack heights: 2 vs 0
			//IL_0296->IL006d: Incompatible stack heights: 1 vs 0
			//IL_02b6->IL006d: Incompatible stack heights: 3 vs 0
			//IL_0212->IL006d: Incompatible stack heights: 1 vs 0
			//IL_025a->IL006d: Incompatible stack heights: 1 vs 0
			//IL_00fe->IL006d: Incompatible stack heights: 1 vs 0
			//IL_02d3->IL006d: Incompatible stack heights: 2 vs 0
			//IL_0177->IL006d: Incompatible stack heights: 2 vs 0
			//IL_006d->IL006d: Incompatible stack heights: 3 vs 0
			//IL_0158->IL006d: Incompatible stack heights: 1 vs 0
			//IL_0231->IL006d: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 3:
					_ = -2;
					if (2 != 0)
					{
						_ = 0;
					}
					break;
				case 4:
					return;
				case 5:
					if (obj != null)
					{
						_ = 5;
						goto IL_006d;
					}
					goto IL_019a;
				default:
					obj = (object)Unsafe.AsPointer(ref this);
					if (5 == 0)
					{
						obj2 = 3;
					}
					break;
				case 2:
					_ = 4;
					break;
				case 1:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							obj2 = 0;
						}
						break;
					}
					IL_019a:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 == 0)
					{
						_ = 26;
					}
					goto IL_006d;
					IL_006d:
					while (true)
					{
						switch ((int)/*Error near IL_00de: Stack underflow*/)
						{
						case 16:
							break;
						case 6:
							return;
						case 13:
							return;
						case 14:
							if (3 != 0)
							{
								_ = 20;
							}
							continue;
						case 26:
							_ = 19;
							continue;
						case 22:
							obj = 21;
							continue;
						case 12:
							if (&obj == null)
							{
								if (18 == 0)
								{
									_ = 3;
								}
								continue;
							}
							goto case 9;
						case 20:
							if (3 == 0)
							{
								_ = 0;
							}
							continue;
						case 3:
							obj = obj;
							_ = 12;
							continue;
						case 1:
							obj = 0;
							_ = 22;
							continue;
						case 24:
							goto IL_019a;
						case 25:
							obj = 2;
							continue;
						case 5:
							if ((nint)obj != 1)
							{
								_ = 11;
								continue;
							}
							goto case 7;
						case 17:
							if (&obj != null)
							{
								if (10 == 0)
								{
									_ = 0;
								}
								continue;
							}
							goto case 1;
						case 11:
							obj = (object)/*Error near IL_0235: Stack underflow*/;
							_ = 17;
							continue;
						case 7:
							obj = (object)Unsafe.AsPointer(ref this);
							if (15 == 0)
							{
								_ = 10;
							}
							continue;
						case 23:
							obj = -1;
							_ = 9;
							continue;
						case 8:
							_ = ref obj;
							_ = 6;
							continue;
						default:
							obj = (object)(&obj);
							if (12 == 0)
							{
								_ = 14;
							}
							continue;
						case 2:
							_ = 0;
							if (16 == 0)
							{
								_ = 12;
							}
							continue;
						case 19:
							obj = -1;
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 9:
							_ = ref obj;
							_ = 25;
							continue;
						case 15:
							_ = 23;
							continue;
						case 21:
							_ = ref obj;
							_ = 13;
							continue;
						case 4:
							_ = 8;
							continue;
						case 18:
							obj = 1;
							_ = 4;
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
		internal static byte _FF00_FF00_FF00_FF00䬀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00䰀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00䴀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778660, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00一(object P_0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_0584: Expected Obj, but got Ref
			//IL_0367: Expected Obj, but got Ref
			//IL_03dc: Expected Obj, but got I4
			//IL_01e0: Expected Obj, but got Ref
			//IL_0171: Expected Obj, but got I4
			//IL_0491: Expected Obj, but got Ref
			//IL_0383: Expected Obj, but got I4
			//IL_02ce: Expected Obj, but got Ref
			//IL_03a0: Expected Obj, but got I4
			//IL_0189: Expected Obj, but got I4
			//IL_023b: Expected Obj, but got I4
			//IL_0580->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0590->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0068->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0568->IL0019: Incompatible stack heights: 2 vs 1
			//IL_059b->IL0019: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0573->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0087->IL008b: Incompatible stack heights: 1 vs 0
			//IL_037e->IL008b: Incompatible stack heights: 1 vs 0
			//IL_008b->IL008b: Incompatible stack heights: 1 vs 0
			//IL_0454->IL008b: Incompatible stack heights: 4 vs 0
			//IL_0482->IL008b: Incompatible stack heights: 2 vs 0
			//IL_030d->IL008b: Incompatible stack heights: 2 vs 0
			//IL_0345->IL008b: Incompatible stack heights: 2 vs 0
			//IL_01f7->IL008b: Incompatible stack heights: 2 vs 0
			//IL_0465->IL008b: Incompatible stack heights: 2 vs 0
			//IL_0209->IL008b: Incompatible stack heights: 3 vs 0
			//IL_01ea->IL008b: Incompatible stack heights: 1 vs 0
			//IL_02f5->IL008b: Incompatible stack heights: 2 vs 0
			//IL_017c->IL008b: Incompatible stack heights: 3 vs 0
			//IL_0363->IL008b: Incompatible stack heights: 3 vs 0
			//IL_031f->IL008b: Incompatible stack heights: 2 vs 0
			//IL_0353->IL008b: Incompatible stack heights: 1 vs 0
			//IL_029d->IL008b: Incompatible stack heights: 3 vs 0
			//IL_03ba->IL008b: Incompatible stack heights: 2 vs 0
			//IL_049b->IL008b: Incompatible stack heights: 1 vs 0
			//IL_0390->IL008b: Incompatible stack heights: 2 vs 0
			//IL_0407->IL008b: Incompatible stack heights: 1 vs 0
			//IL_0263->IL008b: Incompatible stack heights: 4 vs 0
			//IL_03ab->IL008b: Incompatible stack heights: 3 vs 0
			//IL_022b->IL008b: Incompatible stack heights: 3 vs 0
			//IL_018e->IL0087: Incompatible stack heights: 2 vs 0
			//IL_02be->IL008b: Incompatible stack heights: 2 vs 0
			//IL_0338->IL008b: Incompatible stack heights: 1 vs 0
			//IL_0248->IL008b: Incompatible stack heights: 2 vs 0
			//IL_048d->IL008b: Incompatible stack heights: 2 vs 0
			//IL_03f3->IL008b: Incompatible stack heights: 1 vs 0
			//IL_02ae->IL008b: Incompatible stack heights: 1 vs 0
			//IL_0470->IL008b: Incompatible stack heights: 2 vs 0
			//IL_0214->IL008b: Incompatible stack heights: 3 vs 0
			//IL_0300->IL008b: Incompatible stack heights: 2 vs 0
			//IL_032a->IL008b: Incompatible stack heights: 2 vs 0
			//IL_039b->IL008b: Incompatible stack heights: 2 vs 0
			//IL_03cb->IL008b: Incompatible stack heights: 1 vs 0
			//IL_02e5->IL008b: Incompatible stack heights: 1 vs 0
			//IL_0412->IL008b: Incompatible stack heights: 1 vs 0
			//IL_0236->IL008b: Incompatible stack heights: 3 vs 0
			//IL_02c9->IL008b: Incompatible stack heights: 2 vs 0
			//IL_0253->IL008b: Incompatible stack heights: 2 vs 0
			//IL_0424->IL008b: Incompatible stack heights: 1 vs 0
			//IL_04b9->IL008b: Incompatible stack heights: 1 vs 0
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
					_ = null;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				case 5:
					_ = -2;
					_ = 6;
					break;
				case 1:
					if (obj == null)
					{
						if (13 == 0)
						{
							_ = 21;
						}
						goto IL_008b;
					}
					goto IL_03cb;
				case 6:
					_ = null;
					if (4 != 0)
					{
						_ = 1;
					}
					break;
				default:
					_ = 3;
					break;
				case 2:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (false)
						{
							obj2 = 1;
						}
						break;
					}
					IL_0363:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 == 0)
					{
						_ = 5;
					}
					goto IL_008b;
					IL_008b:
					while (true)
					{
						switch ((int)/*Error near IL_013c: Stack underflow*/)
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
							_ = 36;
							continue;
						case 35:
							obj = 11;
							continue;
						case 12:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 14;
							continue;
						case 8:
							_ = 26;
							continue;
						case 11:
							_ = ref obj;
							if (5 != 0)
							{
								_ = 7;
							}
							continue;
						case 32:
							_ = 1;
							if (9 == 0)
							{
								_ = 17;
							}
							continue;
						case 39:
							obj = -1;
							if (true)
							{
								_ = 3;
							}
							continue;
						case 30:
							_ = ref obj;
							_ = 20;
							continue;
						case 23:
							_ = 18;
							continue;
						case 9:
							if (Unsafe.AsPointer(ref this) == null)
							{
								_ = 4;
								continue;
							}
							goto case 37;
						case 36:
							if (30 == 0)
							{
								_ = 2;
							}
							continue;
						case 19:
						case 28:
							obj = (object)(&obj);
							if (9 != 0)
							{
								_ = 29;
							}
							continue;
						case 14:
							_ = 1;
							if (1 == 0)
							{
								_ = 0;
							}
							continue;
						case 3:
						case 38:
							_ = ref obj;
							_ = 12;
							continue;
						case 17:
							_ = 0;
							if (15 == 0)
							{
								_ = 16;
							}
							continue;
						case 37:
							obj = (object)/*Error near IL_032e: Stack underflow*/;
							_ = 6;
							continue;
						case 5:
							_ = 39;
							continue;
						case 13:
						case 22:
							obj = (object)/*Error near IL_0349: Stack underflow*/;
							_ = 27;
							continue;
						case 16:
							_ = 0;
							_ = 2;
							continue;
						case 33:
							goto IL_0363;
						case 26:
							obj = -1;
							if (11 == 0)
							{
								_ = 28;
							}
							continue;
						case 31:
							obj = 1;
							_ = 35;
							continue;
						case 24:
							_ = 40;
							continue;
						case 27:
							if (obj == null)
							{
								_ = 34;
								continue;
							}
							goto case 10;
						default:
							goto IL_03cb;
						case 6:
							if (&obj != null)
							{
								_ = 19;
								continue;
							}
							goto case 15;
						case 29:
							obj = obj;
							if (12 != 0)
							{
								_ = 41;
							}
							continue;
						case 41:
							if (&obj != null)
							{
								_ = 38;
								continue;
							}
							goto case 31;
						case 1:
							_ = 1;
							_ = 32;
							continue;
						case 10:
							if (8 == 0)
							{
								_ = 9;
							}
							continue;
						case 2:
							_ = 0;
							if (4 == 0)
							{
								_ = 24;
							}
							continue;
						case 21:
						case 25:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 8;
							continue;
						case 18:
							if (Unsafe.AsPointer(ref this) == null)
							{
								break;
							}
							if (13 != 0)
							{
								_ = 13;
							}
							continue;
						}
						break;
					}
					goto case 5;
					IL_03cb:
					if ((nint)obj != 1)
					{
						obj = 23;
						goto IL_008b;
					}
					goto IL_0363;
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
		internal static byte _FF00_FF00_FF00_FF00䌀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00䐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778657, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00䔀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00䘀(object P_0)
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
	public Desktop()
	{
		//IL_004a: Expected I4, but got Obj
		//IL_0085: Expected Obj, but got I4
		//IL_0020->IL0029: Incompatible stack types: I4 vs Obj
		//IL_006c->IL0029: Incompatible stack heights: 0 vs 1
		//IL_005d->IL0029: Incompatible stack heights: 3 vs 1
		//IL_00c4->IL0029: Incompatible stack heights: 2 vs 1
		//IL_00b3->IL0029: Incompatible stack heights: 3 vs 1
		//IL_0029->IL0029: Incompatible stack heights: 3 vs 1
		//IL_0077->IL0029: Incompatible stack types: I4 vs Obj
		//IL_00cf->IL0029: Incompatible stack heights: 2 vs 1
		//IL_00a3->IL0029: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		Desktop desktop = this;
		if (5 != 0)
		{
			desktop = (Desktop)5;
		}
		while (true)
		{
			switch ((int)desktop)
			{
			case 2:
				_ = null;
				_ = 4;
				break;
			case 1:
			{
				object obj = (object)/*Error near IL_0060: Stack underflow*/;
				if (0 == 0)
				{
					desktop = (Desktop)0;
				}
				break;
			}
			case 3:
				return;
			default:
			{
				object obj = 6;
				break;
			}
			case 5:
				desktop = this;
				if (1 == 0)
				{
					desktop = (Desktop)0;
				}
				break;
			case 6:
				_ = 2;
				break;
			case 4:
				if (1 == 0)
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
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_0080->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0099->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0065->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0053->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0070->IL0019: Incompatible stack heights: 2 vs 1
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
				return;
			case 0u:
				return;
			case 2u:
				reference = ref obj;
				if (1 == 0)
				{
					reference = ref *(object*)null;
				}
				break;
			case 4u:
				_ = ref obj;
				_ = ref obj;
				if (false)
				{
					_ = 0;
				}
				break;
			case 1u:
				_ = ref obj;
				if (3 == 0)
				{
					_ = 3;
				}
				break;
			case 3u:
				_ = ref obj;
				_ = -1;
				_ = 4;
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
	internal static object _FF00_FF00_FF00똀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00뜀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778830, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00렀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_007d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0060->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0088->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0047->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0052->IL0019: Incompatible stack types: I4 vs Obj
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
			case 0:
				return;
			case 2:
				if (obj == null)
				{
					return;
				}
				if (true)
				{
					obj2 = 1;
				}
				break;
			case 3:
				obj = P_0;
				obj2 = 2;
				break;
			case 1:
				_ = 1.04;
				_ = 250;
				if (0 == 0)
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
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_0083: Expected Obj, but got I4
		//IL_0099->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0055->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0060->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b8->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0073->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e9->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				case 4:
					if (4 != 0)
					{
						_ = 6;
					}
					break;
				case 6:
					if (this == null)
					{
						obj2 = 5;
					}
					else
					{
						_ = 7;
					}
					break;
				default:
					if (obj != null)
					{
						goto end_IL_0019;
					}
					goto case 6;
				case 1:
					obj = this;
					if (false)
					{
						obj2 = 0;
					}
					break;
				case 2:
					return;
				case 5:
				case 7:
					obj2 = this;
					if (obj2 == null)
					{
						obj2 = 3;
					}
					else if (2 == 0)
					{
						obj2 = 1;
					}
					break;
				case 3:
					return;
				}
				continue;
				end_IL_0019:
				break;
			}
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00밀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778829, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00봀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		//IL_0057->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0093->IL0019: Incompatible stack heights: 0 vs 1
		//IL_011c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0075->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ff->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c2->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0062->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0080->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00af->IL0019: Incompatible stack types: I4 vs Obj
		//IL_010a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00cd->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ed->IL0019: Incompatible stack types: I4 vs Obj
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
				obj = P_0;
				if (1 == 0)
				{
					obj2 = 0;
				}
				break;
			case 7:
				if (2 == 0)
				{
					_ = 4;
				}
				break;
			case 3:
				_ = 1;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 8:
				if (obj == null)
				{
					obj2 = 6;
					break;
				}
				obj2 = obj;
				if (7 == 0)
				{
					obj2 = 5;
				}
				break;
			case 1:
				if (obj == null)
				{
					if (5 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				obj = this;
				if (8 != 0)
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
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00븀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_00c3: Expected Obj, but got I4
		//IL_00d9->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00f5->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0054->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00e4->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008b->IL0019: Incompatible stack heights: 3 vs 1
		//IL_005f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0079->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0096->IL0019: Incompatible stack heights: 3 vs 1
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
				case 7:
					return;
				case 4:
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				case 5:
					obj = (object)/*Error near IL_0062: Stack underflow*/;
					if (1 == 0)
					{
						obj2 = 4;
					}
					break;
				case 6:
					return;
				case 3:
					_ = null;
					_ = null;
					if (false)
					{
						_ = 1;
					}
					break;
				case 2:
					if (obj == null)
					{
						return;
					}
					goto end_IL_0019;
				default:
					if (2 == 0)
					{
						_ = 2;
					}
					break;
				case 1:
					_ = 7;
					break;
				}
				continue;
				end_IL_0019:
				break;
			}
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00뼀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_004a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0068->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0095->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				return;
			case 5:
				obj = P_0;
				obj2 = 4;
				break;
			case 2:
				return;
			case 3:
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 4:
				if (obj == null)
				{
					return;
				}
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
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
	private void _FF00_FF00_FF00씀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_005e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0044->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0072->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007d->IL0019: Incompatible stack types: I4 vs Obj
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
				return;
			case 3:
				obj = this;
				obj2 = 2;
				break;
			case 0:
				return;
			case 2:
				if (obj != null)
				{
					if (0 == 0)
					{
						_ = 0;
					}
				}
				else if (1 == 0)
				{
					obj2 = 0;
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
	private void _FF00_FF00_FF00윀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0075->IL0019: Incompatible stack heights: 3 vs 1
		//IL_004d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0083->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0093->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0058->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009e->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				_ = ref obj;
				_ = ref obj;
				if (false)
				{
					_ = 1;
				}
				break;
			case 5:
				_ = ref obj;
				_ = 4;
				break;
			case 1:
				return;
			default:
				_ = ref obj;
				_ = 3;
				break;
			case 3:
				_ = ref obj;
				_ = -1;
				_ = 2;
				break;
			case 4:
				_ = ref obj;
				if (false)
				{
					_ = 0;
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
		//IL_0010: Expected Obj, but got I4
		//IL_00ce: Expected I4, but got Obj
		//IL_02d6: Expected Obj, but got I4
		//IL_01c3: Expected Obj, but got I4
		//IL_04a3: Expected Obj, but got I4
		//IL_011a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0309->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02aa->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02b8->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00e3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0280->IL0019: Incompatible stack heights: 2 vs 1
		//IL_015f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01d8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0241->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0208->IL0019: Incompatible stack heights: 4 vs 1
		//IL_01f1->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0436->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0151->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02db->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0343->IL0019: Incompatible stack heights: 3 vs 1
		//IL_048b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01c8->IL0015: Incompatible stack heights: 2 vs 0
		//IL_016f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0138->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0299->IL0019: Incompatible stack heights: 3 vs 1
		//IL_032a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_04a8->IL0015: Incompatible stack heights: 2 vs 0
		//IL_00ee->IL0019: Incompatible stack heights: 2 vs 1
		//IL_028b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01e3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_024c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0213->IL0019: Incompatible stack heights: 4 vs 1
		//IL_03fb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0441->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0496->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0143->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0335->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 25;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 15:
					if (38 == 0)
					{
						_ = 34;
					}
					continue;
				case 1:
					goto IL_010a;
				default:
					_ = 1;
					if (30 == 0)
					{
						_ = 40;
					}
					continue;
				case 27:
					goto IL_0143;
				case 17:
					goto IL_0151;
				case 35:
					goto IL_015f;
				case 34:
					goto IL_01b6;
				case 19:
					goto IL_01c8;
				case 23:
					goto IL_01e3;
				case 22:
					goto IL_01f1;
				case 21:
					goto IL_022f;
				case 16:
					goto IL_026e;
				case 39:
					goto IL_028b;
				case 40:
					return;
				case 5:
					_ = 30;
					continue;
				case 14:
					goto IL_02aa;
				case 29:
					goto IL_02c7;
				case 2:
					goto IL_02f9;
				case 41:
					goto IL_0318;
				case 31:
					goto IL_0335;
				case 25:
					switch (P_0)
					{
					case 3u:
						break;
					case 7u:
						goto IL_010a;
					case 2u:
						goto IL_0143;
					case 20u:
						goto IL_0151;
					case 11u:
						goto IL_015f;
					case 6u:
						goto IL_01b6;
					case 15u:
						goto IL_01c8;
					case 18u:
						goto IL_01e3;
					case 9u:
						goto IL_01f1;
					case 13u:
						goto IL_022f;
					case 12u:
						goto IL_026e;
					case 17u:
						goto IL_028b;
					case 21u:
						goto IL_02aa;
					case 14u:
						goto IL_02c7;
					case 10u:
						goto IL_02f9;
					case 5u:
						goto IL_0318;
					case 4u:
						goto IL_0335;
					default:
						goto IL_03f1;
					case 19u:
						goto IL_0426;
					case 16u:
						goto IL_0479;
					case 8u:
						goto IL_0496;
					}
					goto case 15;
				case 26:
					goto IL_0426;
				case 32:
					goto IL_0479;
				case 43:
					goto IL_0496;
					IL_0496:
					obj = 18;
					break;
					IL_0479:
					if (11 == 0)
					{
						_ = 7;
					}
					continue;
					IL_01b6:
					obj = 20;
					break;
					IL_0426:
					if (3 != 0)
					{
						_ = 2;
					}
					continue;
					IL_015f:
					_ = 9;
					continue;
					IL_03f1:
					obj2 = 24;
					continue;
					IL_0335:
					_ = 7;
					continue;
					IL_0318:
					if (10 == 0)
					{
						_ = 13;
					}
					continue;
					IL_0151:
					_ = 28;
					continue;
					IL_02f9:
					_ = 12;
					continue;
					IL_02c7:
					obj = 4;
					break;
					IL_02aa:
					_ = 36;
					continue;
					IL_028b:
					_ = 5;
					continue;
					IL_026e:
					if (10 != 0)
					{
						_ = 5;
					}
					continue;
					IL_0143:
					_ = 8;
					continue;
					IL_022f:
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
					IL_01f1:
					if (6 == 0)
					{
						_ = 6;
					}
					continue;
					IL_01e3:
					_ = 37;
					continue;
					IL_01c8:
					if (42 != 0)
					{
						_ = 28;
					}
					continue;
					IL_010a:
					_ = 33;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00쨀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_006c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0051->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0088->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0077->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005c->IL0019: Incompatible stack heights: 3 vs 1
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
			case 3:
				_ = 1.0;
				_ = 350;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				obj = P_0;
				if (1 == 0)
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
	private static void _FF00_FF00_FF00케(object P_0, double P_1, uint P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0046: Expected I4, but got Obj
		//IL_0155: Expected Obj, but got F8
		//IL_0051: Expected Obj, but got I4
		//IL_00f9: Expected Obj, but got F8
		//IL_009b: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		//IL_0161->IL0019: Incompatible stack heights: 3 vs 1
		//IL_005b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00e3->IL0019: Incompatible stack heights: 3 vs 1
		//IL_006b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0131->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0105->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00d5->IL0019: Incompatible stack heights: 25 vs 1
		//IL_016c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_013c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0110->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00f4->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				/*Error near IL_004c: Stack underflow*/;
				obj = 0;
				_ = 7;
				continue;
			case 8:
				return;
			case 3:
				obj = P_0;
				obj2 = 9;
				continue;
			case 7:
				/*Error near IL_0089: Stack underflow*/;
				obj = 1;
				obj = 1;
				_ = 8;
				continue;
			case 2:
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
				obj = (double)(int)P_2;
				if (1 == 0)
				{
					obj2 = 1;
				}
				continue;
			case 4:
				_ = 0.5;
				_ = 0.5;
				if (1 == 0)
				{
					_ = 3;
				}
				continue;
			}
			/*Error near IL_013d: Stack underflow*/;
			_ = 1.0;
			obj = 1.0;
			if (2 == 0)
			{
				_ = 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00퀀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_0064: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_006e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00aa->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0099->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00f7->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00cc->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d7->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 7;
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
					return;
				case 7:
					if (P_1 == null)
					{
						obj = P_0;
						obj2 = 5;
						break;
					}
					goto end_IL_0019;
				case 0:
					return;
				case 3:
					obj = (nint)obj == 5;
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
					if (true)
					{
						_ = 0;
					}
					break;
				case 1:
					_ = 4;
					break;
				}
				continue;
				end_IL_0019:
				break;
			}
			obj = 6;
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
	internal void _FF00_FF00_FF00퐀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00b0->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0067->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00bb->IL0019: Incompatible stack heights: 3 vs 1
		//IL_009f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0085->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0072->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0090->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				obj = (object)/*Error near IL_005b: Stack underflow*/;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				if (this == null)
				{
					if (1 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				return;
			case 3:
				return;
			case 5:
				return;
			case 1:
				_ = 1;
				_ = 4;
				break;
			default:
				_ = 0;
				if (3 == 0)
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
