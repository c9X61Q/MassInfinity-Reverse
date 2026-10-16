using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WinRT;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails))]
public class HomeViewModel : ObservableObject, IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRefresh_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private TaskAwaiter _003C_003Eu__1;

		internal static object ReflectSortedError;

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
		internal static bool CheckCombinedCache()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckTransformableUser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00眀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778159, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00砀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_0317: Expected Obj, but got Ref
			//IL_0112: Expected Obj, but got I4
			//IL_01c9: Expected Obj, but got I4
			//IL_01d3: Expected Obj, but got I4
			//IL_019f: Expected Obj, but got Ref
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0323->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0313->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0052->IL0019: Incompatible stack heights: 2 vs 1
			//IL_006d->IL0071: Incompatible stack heights: 1 vs 0
			//IL_032e->IL0019: Incompatible stack types: I4 vs Ref
			//IL_027b->IL0071: Incompatible stack heights: 2 vs 0
			//IL_0096->IL0071: Incompatible stack heights: 1 vs 0
			//IL_0155->IL00b9: Incompatible stack heights: 1 vs 0
			//IL_00b5->IL00b9: Incompatible stack heights: 1 vs 0
			//IL_0102->IL00b9: Incompatible stack heights: 1 vs 0
			//IL_011d->IL00b9: Incompatible stack heights: 3 vs 0
			//IL_0190->IL00b9: Incompatible stack heights: 3 vs 0
			//IL_0164->IL00b9: Incompatible stack heights: 1 vs 0
			//IL_01c4->IL00b9: Incompatible stack heights: 3 vs 0
			//IL_01ea->IL00b9: Incompatible stack heights: 1 vs 0
			//IL_010d->IL00b9: Incompatible stack heights: 1 vs 0
			//IL_00b9->IL00b9: Incompatible stack heights: 3 vs 0
			//IL_019b->IL00b9: Incompatible stack heights: 3 vs 0
			//IL_016f->IL00b9: Incompatible stack heights: 1 vs 0
			//IL_01b6->IL00b9: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			ref _003CRefresh_003Ed__25 reference = ref *(_003CRefresh_003Ed__25*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 2u:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				case 3u:
					if (1 == 0)
					{
						_ = 0;
					}
					while (true)
					{
						switch ((int)/*Error near IL_0086: Stack underflow*/)
						{
						case 2:
							break;
						case 1:
							_ = 3;
							continue;
						case 3:
							if (obj == null)
							{
								if (2 != 0)
								{
									_ = 2;
								}
								goto IL_00b9;
							}
							goto IL_0139;
						default:
							goto IL_026c;
							IL_00b9:
							while (true)
							{
								switch ((int)/*Error near IL_00ee: Stack underflow*/)
								{
								case 3:
									if (4 != 0)
									{
										_ = 3;
									}
									continue;
								case 4:
									obj = -1;
									_ = 8;
									continue;
								case 11:
									return;
								case 6:
									break;
								case 8:
									_ = ref obj;
									if (true)
									{
										_ = 1;
									}
									continue;
								case 7:
									_ = ref obj;
									if (7 != 0)
									{
										_ = 11;
									}
									continue;
								case 2:
								case 10:
									obj = (object)Unsafe.AsPointer(ref this);
									if (3 != 0)
									{
										_ = 3;
									}
									continue;
								case 9:
									_ = 7;
									continue;
								case 5:
									obj = 0;
									obj = 9;
									continue;
								default:
									if (&obj == null)
									{
										_ = 5;
										continue;
									}
									goto case 8;
								case 1:
									goto IL_026c;
								}
								break;
							}
							goto IL_0139;
							IL_026c:
							_ = null;
							_ = 2;
							continue;
							IL_0139:
							obj = (object)/*Error near IL_013e: Stack underflow*/;
							if (0 == 0)
							{
								_ = 0;
							}
							goto IL_00b9;
						}
						break;
					}
					goto case 2u;
				default:
					reference = ref this;
					if (true)
					{
						reference = ref *(_003CRefresh_003Ed__25*)1;
					}
					break;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 == 0)
					{
						reference = ref *(_003CRefresh_003Ed__25*)3;
					}
					break;
				case 1u:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00礀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778156, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00稀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00笀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778157, new IntPtr(2737335814732L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00簀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00紀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778154, new IntPtr(2737335814732L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00縀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00缀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778155, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CShowPaymentDialog_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private TaskAwaiter _003C_003Eu__1;

		internal static object ReflectSequentialInitializer;

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
		internal static bool CheckSetPublisher()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckEfficientTransformer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00瀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778152, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00焀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_0228: Expected Obj, but got Ref
			//IL_0099: Expected Obj, but got Ref
			//IL_00c3: Expected Obj, but got I4
			//IL_00e0: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0234->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0045->IL0019: Incompatible stack heights: 3 vs 1
			//IL_00a3->IL005b: Incompatible stack types: I4 vs Ref
			//IL_0057->IL005b: Incompatible stack types: I4 vs Ref
			//IL_023f->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0223->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00b3->IL005b: Incompatible stack heights: 2 vs 1
			//IL_0119->IL005b: Incompatible stack heights: 2 vs 1
			//IL_0145->IL005b: Incompatible stack heights: 4 vs 1
			//IL_00f9->IL005b: Incompatible stack types: I4 vs Ref
			//IL_00d0->IL005b: Incompatible stack heights: 2 vs 1
			//IL_00eb->IL005b: Incompatible stack heights: 3 vs 1
			//IL_00be->IL005b: Incompatible stack heights: 2 vs 1
			//IL_017e->IL005b: Incompatible stack types: I4 vs Ref
			//IL_0159->IL005b: Incompatible stack heights: 0 vs 1
			//IL_00db->IL005b: Incompatible stack heights: 2 vs 1
			//IL_0164->IL005b: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			ref _003CShowPaymentDialog_003Ed__23 reference = ref *(_003CShowPaymentDialog_003Ed__23*)obj;
			while (true)
			{
				ref _003CShowPaymentDialog_003Ed__23 reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 4u:
					_ = -2;
					_ = 3;
					break;
				default:
					if (obj != null)
					{
						reference2 = ref *(_003CShowPaymentDialog_003Ed__23*)9;
						goto IL_005b;
					}
					goto IL_0095;
				case 3u:
					reference = ref this;
					if (2 == 0)
					{
						reference = ref *(_003CShowPaymentDialog_003Ed__23*)2;
					}
					break;
				case 2u:
					return;
				case 1u:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							reference = ref *(_003CShowPaymentDialog_003Ed__23*)null;
						}
						break;
					}
					IL_0095:
					obj = (object)Unsafe.AsPointer(ref this);
					reference2 = ref *(_003CShowPaymentDialog_003Ed__23*)3;
					goto IL_005b;
					IL_005b:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						case 2u:
							break;
						case 8u:
							goto IL_0095;
						case 1u:
							if (true)
							{
								_ = 7;
							}
							continue;
						case 10u:
							obj = 0;
							if (1 == 0)
							{
								_ = 1;
							}
							continue;
						case 11u:
							obj = -1;
							_ = 4;
							continue;
						case 9u:
							obj = (object)/*Error near IL_00ef: Stack underflow*/;
							reference2 = ref *(_003CShowPaymentDialog_003Ed__23*)6;
							continue;
						case 5u:
							return;
						default:
							_ = ref obj;
							_ = 2;
							continue;
						case 7u:
							_ = ref obj;
							_ = 5;
							continue;
						case 6u:
							if (&obj != null)
							{
								if (0 == 0)
								{
									reference2 = ref *(_003CShowPaymentDialog_003Ed__23*)null;
								}
								continue;
							}
							goto case 10u;
						case 3u:
							reference2 = ref this;
							if (4 != 0)
							{
								reference2 = ref *(_003CShowPaymentDialog_003Ed__23*)11;
							}
							continue;
						}
						break;
					}
					goto case 4u;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00爀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778153, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00猀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00琀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778166, new IntPtr(2737335818892L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00甀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00瘀(object P_0)
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
	private struct _003CShowReferralDialog_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private TaskAwaiter _003C_003Eu__1;

		private static object CheckAttachedMap;

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
		internal static bool DecorateGlobalVisitor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SearchEmitter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00昀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778167, new IntPtr(2737335806412L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00最()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_0255: Expected Obj, but got Ref
			//IL_01b7: Expected Obj, but got Ref
			//IL_01a8: Expected Obj, but got I4
			//IL_0198: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0261->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
			//IL_026c->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0052->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0250->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0193->IL0075: Incompatible stack heights: 1 vs 0
			//IL_0071->IL0075: Incompatible stack heights: 1 vs 0
			//IL_01c1->IL0075: Incompatible stack heights: 1 vs 0
			//IL_0151->IL0075: Incompatible stack heights: 1 vs 0
			//IL_00c5->IL0075: Incompatible stack heights: 3 vs 0
			//IL_01b3->IL0075: Incompatible stack heights: 3 vs 0
			//IL_00ed->IL0075: Incompatible stack heights: 2 vs 0
			//IL_00dd->IL0075: Incompatible stack heights: 2 vs 0
			//IL_01a3->IL0075: Incompatible stack heights: 3 vs 0
			//IL_015c->IL0075: Incompatible stack heights: 1 vs 0
			//IL_00d0->IL0075: Incompatible stack heights: 3 vs 0
			//IL_00f8->IL0075: Incompatible stack heights: 2 vs 0
			//IL_0117->IL0075: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			ref _003CShowReferralDialog_003Ed__24 reference = ref *(_003CShowReferralDialog_003Ed__24*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 3u:
					_ = -2;
					if (4 == 0)
					{
						_ = 3;
					}
					break;
				default:
					if (obj == null)
					{
						if (2 != 0)
						{
							_ = 2;
						}
						goto IL_0075;
					}
					goto IL_0178;
				case 4u:
					reference = ref this;
					if (2 != 0)
					{
						reference = ref *(_003CShowReferralDialog_003Ed__24*)1;
					}
					break;
				case 2u:
					return;
				case 1u:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							reference = ref *(_003CShowReferralDialog_003Ed__24*)null;
						}
						break;
					}
					IL_0075:
					while (true)
					{
						switch ((int)/*Error near IL_00ae: Stack underflow*/)
						{
						case 3:
							break;
						case 6:
							_ = ref obj;
							if (4 != 0)
							{
								_ = 2;
							}
							continue;
						case 9:
						case 11:
							_ = ref obj;
							_ = 3;
							continue;
						case 8:
							if (6 == 0)
							{
								_ = 2;
							}
							continue;
						default:
							if (&obj != null)
							{
								if (11 != 0)
								{
									_ = 10;
								}
								continue;
							}
							goto case 7;
						case 4:
							return;
						case 5:
							if (10 == 0)
							{
								_ = 2;
							}
							continue;
						case 12:
							goto IL_0178;
						case 10:
							obj = -1;
							_ = 9;
							continue;
						case 7:
							obj = 0;
							_ = 8;
							continue;
						case 1:
						case 2:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 5;
							continue;
						}
						break;
					}
					goto case 3u;
					IL_0178:
					obj = (object)/*Error near IL_017c: Stack underflow*/;
					if (false)
					{
						_ = 0;
					}
					goto IL_0075;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00栀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778164, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00椀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00樀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778165, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00欀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778162, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00氀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00洀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778163, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00渀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00漀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778160, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? showPaymentDialogCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? showReferralDialogCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? refreshCommand;

	private static object ReflectBasicAnnotation;

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public string Username
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00ࠀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_F300(value);
		}
	}

	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public int UserId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00_0A00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_0300((uint)value);
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
			return (int)_FF00_F500();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00ﬀ((uint)value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public string ExpirationTimeText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_F600();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00Ȁ(value);
		}
	}

	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public string NativeProtocolExpirationTimeText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00Ā();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00Ѐ(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string RegistrationTimeText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00Ԁ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_0D00(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand ShowPaymentDialogCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_FF00_1800();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand ShowReferralDialogCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_FF00ༀ();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand RefreshCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_FE00();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HomeViewModel()
	{
		//IL_0051: Expected I4, but got Obj
		//IL_0033->IL003c: Incompatible stack types: I4 vs Obj
		//IL_0079->IL00ab: Incompatible stack heights: 4 vs 5
		//IL_0085->IL003c: Incompatible stack heights: 4 vs 6
		//IL_00ab->IL003c: Incompatible stack types: I4 vs Obj
		//IL_0072->IL003c: Incompatible stack types: I4 vs Obj
		//IL_0090->IL003c: Incompatible stack heights: 4 vs 6
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		HomeViewModel homeViewModel = (HomeViewModel)3;
		while (true)
		{
			switch ((int)homeViewModel)
			{
			case 3:
				homeViewModel = this;
				if (0 == 0)
				{
					homeViewModel = (HomeViewModel)0;
				}
				continue;
			case 2:
				homeViewModel = this;
				if (1 == 0)
				{
					homeViewModel = (HomeViewModel)1;
				}
				continue;
			case 1:
				return;
			}
			if (this != null)
			{
				if (2 != 0)
				{
					_ = 1;
				}
				continue;
			}
			return;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CShowPaymentDialog_003Ed__23))]
	private object ShowPaymentDialog()
	{
		return _FF00_FF00_1400();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CShowReferralDialog_003Ed__24))]
	private object ShowReferralDialog()
	{
		return _FF00_FF00_0700();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CRefresh_003Ed__25))]
	private object Refresh()
	{
		return _FF00_F000();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update(object user)
	{
		_FF00豈(user);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		_FF00切();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SaveResolver()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HomeViewModel CheckRemoteBridge()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_EF00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778313, new IntPtr(2737335813692L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_F000()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17801, 1790778326, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778326, new IntPtr(2737335813692L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_F100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778327, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_F200(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778324, new IntPtr(2737335806412L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_F300(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_009a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0082->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005c->IL0037: Incompatible stack heights: 1 vs 0
		//IL_008d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0052->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0073->IL0019: Incompatible stack types: I4 vs Obj
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
			case 3:
				obj2 = this;
				if (true)
				{
					obj2 = 1;
				}
				break;
			case 4:
				obj2 = this;
				if (P_0 != null)
				{
					return;
				}
				if (3 == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			default:
				_ = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_F400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778325, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_F500()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_F600()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_F700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778322, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_F800(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778323, new IntPtr(2737335815772L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00豈(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_0079->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0087->IL0019: Incompatible stack heights: 3 vs 1
		//IL_006a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0051->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0097->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00cc->IL0019: Incompatible stack heights: 5 vs 1
		//IL_00c1->IL00c1: Incompatible stack heights: 3 vs 4
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
				return;
			case 4:
				if (0 == 0)
				{
					_ = 0;
				}
				continue;
			case 3:
				_ = 2;
				continue;
			case 1:
				_ = 4;
				continue;
			case 2:
				_ = 5;
				continue;
			case 5:
				if (0 == 0)
				{
					_ = 1;
				}
				continue;
			}
			_ = ref obj;
			if (obj != null)
			{
			}
			_ = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00切()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0048->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0065->IL0019: Incompatible stack types: I4 vs Obj
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
				obj2 = this;
				if (2 != 0)
				{
					obj2 = 1;
				}
				break;
			case 2:
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
	internal void _FF00ﬀ(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0090->IL0051: Incompatible stack heights: 1 vs 0
		//IL_0051->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0086->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a7->IL0019: Incompatible stack types: I4 vs Obj
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
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 2:
				return;
			case 1:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 2;
				}
				break;
			case 3:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 4:
				obj2 = this;
				if (P_0 != 0)
				{
					return;
				}
				if (true)
				{
					obj2 = 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ﰀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778320, new IntPtr(2737335801212L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00ﴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778321, new IntPtr(2737335801212L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FE00()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17815, 1790778334, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778334, new IntPtr(2737335828252L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778335, new IntPtr(2737335801212L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00Ā()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00Ȁ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_005e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0083->IL005e: Incompatible stack heights: 1 vs 0
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0079->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0051->IL0019: Incompatible stack heights: 2 vs 1
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
				if (false)
				{
					_ = 0;
				}
				break;
			case 2:
				_ = 4;
				break;
			case 1:
				return;
			default:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				if (P_0 != null)
				{
					return;
				}
				_ = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_0300(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_005e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL006a: Incompatible stack heights: 1 vs 0
		//IL_00ba->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0069->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0084->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004f->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 5:
				if (P_0 != 0)
				{
					_ = 4;
					break;
				}
				goto case 3;
			case 1:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				return;
			case 4:
				return;
			case 3:
				obj2 = this;
				if (true)
				{
					obj2 = 1;
				}
				break;
			default:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00Ѐ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0041->IL008c: Incompatible stack heights: 1 vs 0
		//IL_0067->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a7->IL0019: Incompatible stack types: I4 vs Obj
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
					if (true)
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
				if (true)
				{
					obj2 = 3;
				}
				break;
			case 4:
				return;
			default:
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
	internal object _FF00_FF00Ԁ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_0600()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778332, new IntPtr(2737335798092L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_0700()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17823, 1790778333, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778333, new IntPtr(2737335798092L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00ࠀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_0900()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778330, new IntPtr(2737335799132L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_0A00()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_0B00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778331, new IntPtr(2737335812652L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_0C00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778328, new IntPtr(2737335806412L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_0D00(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0064->IL0019: Incompatible stack heights: 3 vs 1
		//IL_007c->IL0093: Incompatible stack heights: 1 vs 0
		//IL_0071->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ad->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0019: Incompatible stack types: I4 vs Obj
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
				return;
			case 1:
				_ = 5;
				continue;
			case 5:
				_ = 4;
				continue;
			case 4:
				return;
			case 3:
				obj2 = this;
				if (P_0 != null)
				{
					if (2 != 0)
					{
						obj2 = 1;
					}
					continue;
				}
				break;
			}
			obj2 = this;
			if (1 == 0)
			{
				obj2 = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_0E00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778329, new IntPtr(2737335812652L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00ༀ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17831, 1790778150, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778150, new IntPtr(2737335801212L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00က()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778151, new IntPtr(2737335799132L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00ᄀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778148, new IntPtr(2737335799132L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00ሀ()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00ጀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778149, new IntPtr(2737335799132L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_1400()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17836, 1790778146, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778146, new IntPtr(2737335812652L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00ᔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778147, new IntPtr(2737335799132L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00ᘀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778144, new IntPtr(2737335799132L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00ᜀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_1800()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17840, 1790778145, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778145, new IntPtr(2737335799132L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00ᤀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778158, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
