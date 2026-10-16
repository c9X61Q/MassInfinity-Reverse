using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Mass.Application.Desktop;
using Mass.WinUI.Enums;
using WinRT;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_02db: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_01f0: Expected Obj, but got Ref
			//IL_01a8: Expected Obj, but got I4
			//IL_0101: Expected Obj, but got Ref
			//IL_0140: Expected Obj, but got I4
			//IL_014a: Expected Obj, but got I4
			//IL_0059->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0075->IL0019: Incompatible stack heights: 2 vs 1
			//IL_02e7->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0080->IL0019: Incompatible stack heights: 2 vs 1
			//IL_01fa->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_0094->IL00a3: Incompatible stack heights: 0 vs 1
			//IL_02f2->IL0019: Incompatible stack types: I4 vs Obj
			//IL_009f->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_01b5->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_010d->IL00a3: Incompatible stack heights: 0 vs 1
			//IL_01d0->IL00a3: Incompatible stack heights: 4 vs 1
			//IL_015f->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_013b->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_01c0->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_0118->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_016a->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_012a->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_00a3->IL00a3: Incompatible stack heights: 3 vs 1
			//IL_0231->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_0184->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_0198->IL00a3: Incompatible stack heights: 0 vs 1
			//IL_0241->IL00a3: Incompatible stack heights: 0 vs 1
			//IL_01a3->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_024c->IL00a3: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				ref _003CLogin_003Ed__39 reference;
				switch ((int)obj2)
				{
				case 5:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 4;
					break;
				default:
					_ = -2;
					if (1 == 0)
					{
						_ = 1;
					}
					break;
				case 1:
					if (3 == 0)
					{
						_ = 2;
					}
					break;
				case 2:
					if (obj != null)
					{
						if (4 == 0)
						{
							reference = ref *(_003CLogin_003Ed__39*)14;
						}
						goto IL_00a3;
					}
					goto IL_01ec;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 == 0)
					{
						obj2 = 1;
					}
					break;
				case 3:
					return;
					IL_01ec:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CLogin_003Ed__39*)12;
					goto IL_00a3;
					IL_00a3:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 1u:
						case 11u:
							break;
						case 2u:
						case 6u:
							obj = (object)(&obj);
							if (11 == 0)
							{
								reference = ref *(_003CLogin_003Ed__39*)8;
							}
							continue;
						case 7u:
							if (&obj != null)
							{
								reference = ref *(_003CLogin_003Ed__39*)6;
								continue;
							}
							goto case 8u;
						case 15u:
							obj = obj;
							reference = ref *(_003CLogin_003Ed__39*)7;
							continue;
						case 8u:
							obj = 0;
							obj = 4;
							continue;
						case 4u:
							if (0 == 0)
							{
								_ = 3;
							}
							continue;
						case 12u:
							reference = ref this;
							if (false)
							{
								reference = ref *(_003CLogin_003Ed__39*)null;
							}
							continue;
						case 14u:
							if (obj != null)
							{
								if (3 != 0)
								{
									reference = ref *(_003CLogin_003Ed__39*)10;
								}
								continue;
							}
							goto case 15u;
						default:
							obj = -1;
							if (2 == 0)
							{
								_ = 1;
							}
							continue;
						case 3u:
							_ = ref obj;
							_ = 5;
							continue;
						case 5u:
							return;
						case 13u:
							goto IL_01ec;
						case 10u:
							goto IL_0216;
						case 9u:
							throw /*Error near IL_0233: Stack underflow*/;
						}
						break;
						IL_0216:
						object obj3 = obj;
						if (obj3 == null)
						{
							reference = ref *(_003CLogin_003Ed__39*)9;
							continue;
						}
						obj = obj3;
						if (1 == 0)
						{
							reference = ref *(_003CLogin_003Ed__39*)1;
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
		internal static byte _FF00_FF00_FF00뀀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
		internal static object _FF00_FF00_FF00대()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00됀(object P_0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_054a: Expected Obj, but got Ref
			//IL_0565: Expected Obj, but got Ref
			//IL_00d4: Expected Obj, but got I4
			//IL_024d: Expected Obj, but got Ref
			//IL_0105: Expected Obj, but got I4
			//IL_0231: Expected Obj, but got I4
			//IL_0227: Expected Obj, but got I4
			//IL_0293: Expected Obj, but got I4
			//IL_01d9: Expected Obj, but got Ref
			//IL_02bc: Expected Obj, but got I4
			//IL_0597->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0556->IL0019: Incompatible stack heights: 0 vs 1
			//IL_056f->IL0019: Incompatible stack types: I4 vs Obj
			//IL_057f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0059->IL0019: Incompatible stack heights: 2 vs 1
			//IL_006d->IL007c: Incompatible stack heights: 0 vs 1
			//IL_0561->IL0019: Incompatible stack types: I4 vs Obj
			//IL_058a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_04bf->IL007c: Incompatible stack types: I4 vs Ref
			//IL_0078->IL007c: Incompatible stack types: I4 vs Ref
			//IL_0424->IL007c: Incompatible stack types: Obj vs Ref
			//IL_00e9->IL007c: Incompatible stack types: Obj vs Ref
			//IL_046b->IL007c: Incompatible stack heights: 2 vs 1
			//IL_03bf->IL007c: Incompatible stack heights: 2 vs 1
			//IL_03f8->IL007c: Incompatible stack types: I4 vs Ref
			//IL_007c->IL007c: Incompatible stack types: Obj vs Ref
			//IL_0257->IL010e: Incompatible stack types: I4 vs Ref
			//IL_042f->IL007c: Incompatible stack types: I4 vs Ref
			//IL_00f4->IL007c: Incompatible stack types: I4 vs Ref
			//IL_03ca->IL007c: Incompatible stack heights: 2 vs 1
			//IL_03ab->IL007c: Incompatible stack types: I4 vs Ref
			//IL_0452->IL007c: Incompatible stack heights: 0 vs 1
			//IL_010e->IL010e: Incompatible stack types: Obj vs Ref
			//IL_045d->IL007c: Incompatible stack types: I4 vs Ref
			//IL_023e->IL010e: Incompatible stack heights: 2 vs 1
			//IL_0267->IL010e: Incompatible stack heights: 0 vs 1
			//IL_022c->IL010a: Incompatible stack heights: 2 vs 0
			//IL_02fe->IL010e: Incompatible stack heights: 3 vs 1
			//IL_02ad->IL010e: Incompatible stack types: I4 vs Ref
			//IL_030f->IL010e: Incompatible stack heights: 2 vs 1
			//IL_020f->IL010e: Incompatible stack heights: 3 vs 1
			//IL_029e->IL010e: Incompatible stack heights: 3 vs 1
			//IL_01e3->IL010e: Incompatible stack types: I4 vs Ref
			//IL_01c7->IL010e: Incompatible stack types: Obj vs Ref
			//IL_0249->IL010e: Incompatible stack heights: 2 vs 1
			//IL_0272->IL010e: Incompatible stack types: I4 vs Ref
			//IL_01fd->IL010e: Incompatible stack types: I4 vs Ref
			//IL_02db->IL010e: Incompatible stack types: I4 vs Ref
			//IL_0185->IL010e: Incompatible stack types: I4 vs Ref
			//IL_02eb->IL010e: Incompatible stack types: I4 vs Ref
			//IL_021a->IL010e: Incompatible stack heights: 3 vs 1
			//IL_01b5->IL010e: Incompatible stack types: I4 vs Ref
			//IL_01d2->IL010e: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				ref _003CLogout_003Ed__40 reference;
				switch ((int)obj2)
				{
				case 1:
					_ = null;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				case 2:
					if (obj == null)
					{
						if (3 == 0)
						{
							reference = ref *(_003CLogout_003Ed__40*)6;
						}
						goto IL_007c;
					}
					goto IL_04a5;
				case 6:
					return;
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 != 0)
					{
						obj2 = 2;
					}
					break;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 3;
					break;
				case 5:
					goto IL_056f;
				default:
					{
						_ = 6;
						break;
					}
					IL_007c:
					while (true)
					{
						ref byte reference2;
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 2u:
						case 3u:
						case 6u:
							obj = 4;
							reference = ref *(_003CLogout_003Ed__40*)obj;
							continue;
						case 8u:
							reference = ref *(_003CLogout_003Ed__40*)null;
							if (0 != 0)
							{
								reference = ref *(_003CLogout_003Ed__40*)1;
							}
							continue;
						case 4u:
							if (obj != null)
							{
								obj = 18;
								goto IL_010a;
							}
							goto IL_0249;
						case 14u:
						case 16u:
							if (Unsafe.AsPointer(ref this) == null)
							{
								reference = ref *(_003CLogout_003Ed__40*)2;
								continue;
							}
							goto case 7u;
						case 11u:
							if (10 != 0)
							{
								_ = 15;
							}
							continue;
						default:
							if (obj == null)
							{
								reference = ref *(_003CLogout_003Ed__40*)8;
								continue;
							}
							goto case 11u;
						case 7u:
							reference = ref *(_003CLogout_003Ed__40*)null;
							if (2 == 0)
							{
								reference = ref *(_003CLogout_003Ed__40*)13;
							}
							continue;
						case 15u:
							if (Unsafe.AsPointer(ref this) != null)
							{
								if (10 == 0)
								{
									reference = ref *(_003CLogout_003Ed__40*)16;
								}
								continue;
							}
							goto case 9u;
						case 9u:
							_ = null;
							_ = 5;
							continue;
						case 10u:
							break;
						case 1u:
						case 5u:
						case 12u:
						case 13u:
							goto IL_056f;
							IL_0249:
							obj = (object)Unsafe.AsPointer(ref this);
							reference2 = ref *(byte*)8;
							goto IL_010e;
							IL_010e:
							while (true)
							{
								switch ((uint)Unsafe.AsPointer(ref reference2))
								{
								default:
									return;
								case 10u:
									if (obj == null)
									{
										reference2 = ref *(byte*)7;
										continue;
									}
									goto case 12u;
								case 0u:
									return;
								case 17u:
									if (&obj != null)
									{
										reference2 = ref *(byte*)9;
										continue;
									}
									goto case 16u;
								case 19u:
									reference2 = ref *(byte*)obj;
									if (11 != 0)
									{
										reference2 = ref *(byte*)14;
									}
									continue;
								case 18u:
									obj = (object)Unsafe.AsPointer(ref this);
									reference2 = ref *(byte*)17;
									continue;
								case 6u:
								case 9u:
									reference2 = ref *(byte*)(&obj);
									if (0 == 0)
									{
										reference2 = ref *(byte*)11;
									}
									continue;
								case 15u:
									_ = ref obj;
									if (0 == 0)
									{
										_ = 0;
									}
									continue;
								case 5u:
									break;
								case 1u:
									obj = -1;
									if (6 == 0)
									{
										_ = 0;
									}
									continue;
								case 20u:
									goto IL_0249;
								case 2u:
									if (2 == 0)
									{
										reference2 = ref *(byte*)4;
									}
									continue;
								case 16u:
									obj = 0;
									_ = 5;
									continue;
								case 12u:
									reference2 = ref *(byte*)21;
									continue;
								case 21u:
									if ((int)/*Error near IL_02b3: Stack underflow*/ == 0)
									{
										goto case 2u;
									}
									goto IL_02b3;
								case 8u:
									reference2 = ref Unsafe.As<_003CLogout_003Ed__40, byte>(ref this);
									if (1 == 0)
									{
										reference2 = ref *(byte*)1;
									}
									continue;
								case 14u:
									if ((int)/*Error near IL_02e1: Stack underflow*/ == 0)
									{
										reference2 = ref *(byte*)3;
										continue;
									}
									goto case 10u;
								case 11u:
									_ = null;
									_ = 19;
									continue;
								case 13u:
									_ = null;
									_ = 2;
									continue;
								case 3u:
								case 4u:
								case 7u:
									goto IL_056f;
								}
								break;
							}
							obj = 15;
							goto IL_010a;
							IL_02b3:
							obj = 13;
							goto IL_010a;
							IL_010a:
							reference2 = ref *(byte*)obj;
							goto IL_010e;
						}
						break;
					}
					goto IL_04a5;
					IL_056f:
					_ = -2;
					if (1 == 0)
					{
						_ = 0;
					}
					break;
					IL_04a5:
					reference = ref this;
					if (0 == 0)
					{
						reference = ref *(_003CLogout_003Ed__40*)null;
					}
					goto IL_007c;
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
		internal static byte _FF00_FF00_FF00_A700()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00ꠀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779103, new IntPtr(2737336211532L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00꤀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00ꨀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779100, new IntPtr(2737336211532L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_AB00(object P_0)
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
	public AccountModel(NeteaseAccount account)
	{
		//IL_00ac: Expected I4, but got Obj
		//IL_009a->IL00a3: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = ((this != null) ? this : this);
		obj = this;
		_ = ref obj;
		obj = this;
		_ = ref obj;
		AccountModel accountModel = this;
		if (0 == 0)
		{
			accountModel = (AccountModel)0;
		}
		switch ((int)accountModel)
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
	internal static object _FF00_FF00_FF00_FF00吀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00唀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779126, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00嘀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00圀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779127, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00堀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
	internal EnumAccountType _FF00_FF00_FF00_FF00嬀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_004f: Expected I4, but got Obj
		//IL_0040->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004b->IL0019: Incompatible stack types: I4 vs Obj
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
				if ((nint)this != 5)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				return EnumAccountType.Com4399;
			default:
				return (EnumAccountType)this;
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
	internal void _FF00_FF00_FF00_FF00怀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0076->IL0051: Incompatible stack heights: 1 vs 0
		//IL_009c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0051->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008d->IL0019: Incompatible stack types: I4 vs Obj
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
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 3;
				}
				break;
			case 4:
				return;
			default:
				obj2 = this;
				if (2 == 0)
				{
					obj2 = 4;
				}
				break;
			case 2:
				obj2 = this;
				if (P_0 != null)
				{
					return;
				}
				if (0 == 0)
				{
					obj2 = 1;
				}
				break;
			case 3:
				if (false)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00愀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0062: Expected I4, but got Obj
		//IL_01b1: Expected I4, but got Obj
		//IL_0073: Expected Obj, but got I4
		//IL_0156->IL0019: Incompatible stack heights: 0 vs 1
		//IL_012b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_013a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_011e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00ea->IL0019: Incompatible stack heights: 0 vs 1
		//IL_016e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01bb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0161->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0145->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00f5->IL0019: Incompatible stack types: I4 vs Obj
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
				case 10:
					break;
				case 11:
				case 15:
					obj = (object)/*Error near IL_007b: Stack underflow*/;
					if (6 != 0)
					{
						obj2 = 6;
					}
					continue;
				case 13:
					goto IL_00db;
				case 9:
					goto IL_0111;
				case 2:
					goto IL_011e;
				case 3:
					goto IL_012b;
				case 1:
					obj = this;
					if (false)
					{
						obj2 = 0;
					}
					continue;
				case 14:
					goto IL_0161;
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 12:
				case 16:
					return obj;
				default:
					{
						switch ((int)obj)
						{
						case 1:
							break;
						case 2:
							goto IL_00db;
						case 0:
							goto IL_0111;
						case 6:
							goto IL_011e;
						case 5:
							goto IL_012b;
						case 3:
						case 4:
							goto IL_0161;
						default:
							goto IL_01b1;
						}
						break;
					}
					IL_01b1:
					obj2 = 15;
					continue;
					IL_0161:
					obj = (object)/*Error near IL_0164: Stack underflow*/;
					obj2 = 8;
					continue;
					IL_00db:
					obj = (object)/*Error near IL_00de: Stack underflow*/;
					if (16 == 0)
					{
						obj2 = 9;
					}
					continue;
					IL_012b:
					obj = (object)/*Error near IL_012e: Stack underflow*/;
					if (8 != 0)
					{
						obj2 = 12;
					}
					continue;
					IL_011e:
					obj = (object)/*Error near IL_0121: Stack underflow*/;
					obj2 = 4;
					continue;
					IL_0111:
					obj = (object)/*Error near IL_0114: Stack underflow*/;
					obj2 = 7;
					continue;
				}
				break;
			}
			obj = (object)/*Error near IL_006a: Stack underflow*/;
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
	internal object _FF00_FF00_FF00_FF00挀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
	internal byte _FF00_FF00_FF00_FF00昀()
	{
		//IL_000c: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00最()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_004e: Expected I4, but got Obj
		//IL_003d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0048->IL0019: Incompatible stack types: I4 vs Obj
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
				if ((int)/*Error near IL_0031: Stack underflow*/ != 0)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				return 0;
			default:
				return (byte)(int)this;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00_FF00_FF00栀(object P_0)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return P_0;
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
	internal void _FF00_FF00_FF00_FF00欀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0090->IL0037: Incompatible stack heights: 1 vs 0
		//IL_007b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0052->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0086->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a7->IL0019: Incompatible stack types: I4 vs Obj
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
				return;
			case 2:
				obj2 = this;
				if (3 == 0)
				{
					obj2 = 3;
				}
				break;
			default:
				obj2 = this;
				if (4 == 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
				if (1 == 0)
				{
					_ = 2;
				}
				break;
			case 1:
				obj2 = this;
				if (P_0 != null)
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
	internal object _FF00_FF00_FF00_FF00瀀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
	internal void _FF00_FF00_FF00_FF00猀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0072->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004e->IL008c: Incompatible stack heights: 1 vs 0
		//IL_0044->IL0019: Incompatible stack heights: 3 vs 1
		//IL_008c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0065->IL0019: Incompatible stack types: I4 vs Obj
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
			case 4:
				_ = 3;
				break;
			case 2:
				obj2 = this;
				if (P_0 == null)
				{
					if (true)
					{
						obj2 = 0;
					}
					break;
				}
				return;
			case 1:
				_ = 4;
				break;
			case 3:
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
	private unsafe void _FF00_FF00_FF00_FF00琀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779077, new IntPtr(2737336196972L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00甀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0058->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0040->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0063->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
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
				if (false)
				{
					_ = 1;
				}
				break;
			case 1:
				if (0 == 0)
				{
					obj2 = 0;
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
	internal object _FF00_FF00_FF00_FF00砀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00礀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0099->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0041->IL0099: Incompatible stack heights: 1 vs 0
		//IL_0067->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0058->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				obj2 = this;
				if (P_0 == null)
				{
					if (1 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				return;
			case 3:
				if (false)
				{
					_ = 0;
				}
				break;
			case 1:
				obj2 = this;
				if (3 != 0)
				{
					obj2 = 0;
				}
				break;
			default:
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
	internal object _FF00_FF00_FF00_FF00紀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
	internal void _FF00_FF00_FF00_FF00缀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_00cb->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00be->IL0019: Incompatible stack heights: 3 vs 1
		//IL_006a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0080->IL00be: Incompatible stack heights: 1 vs 0
		//IL_00b1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0075->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0097->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				if (0 == 0)
				{
					_ = 1;
				}
				continue;
			case 4:
				return;
			case 6:
				obj2 = this;
				if (P_0 != null)
				{
					if (5 != 0)
					{
						obj2 = 2;
					}
					continue;
				}
				break;
			case 2:
				obj2 = this;
				if (2 == 0)
				{
					obj2 = 4;
				}
				continue;
			case 1:
				_ = 2;
				continue;
			}
			_ = 3;
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
	internal byte _FF00_FF00_FF00_FF00脀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (this == null) ? ((byte)1) : ((byte)0);
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
	internal object _FF00_FF00_FF00_FF00蔀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00蘀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		//IL_0054: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I4
		//IL_0059->IL0015: Incompatible stack heights: 1 vs 0
		//IL_008d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009e->IL0015: Incompatible stack heights: 1 vs 0
		//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ab->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0080->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00df->IL0019: Incompatible stack types: I4 vs Obj
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
				case 3:
					return;
				case 2:
					obj = 7;
					break;
				case 6:
					_ = 4;
					continue;
				default:
					obj2 = this;
					if (2 != 0)
					{
						obj2 = 2;
					}
					continue;
				case 4:
					_ = 5;
					continue;
				case 5:
					obj = 8;
					break;
				case 8:
					_ = 3;
					continue;
				case 1:
					obj2 = this;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 7:
					obj2 = this;
					if (6 != 0)
					{
						obj2 = 2;
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
