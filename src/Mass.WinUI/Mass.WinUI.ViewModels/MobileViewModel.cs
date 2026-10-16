using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mass.Domain.Mobile.Entities.NetGame;
using Mass.Domain.Mobile.Entities.RentalGame;
using Mass.Domain.Value;
using Mass.WinUI.Models;
using Microsoft.UI.Xaml.Controls;
using WinRT;
using WinRT.Mass_WinUIVtableClasses;

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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_02cb: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_02ee: Expected Obj, but got I4
			//IL_01cd: Expected Obj, but got Ref
			//IL_00df: Expected Obj, but got I4
			//IL_0184: Expected Obj, but got I4
			//IL_0103: Expected Obj, but got I4
			//IL_0244: Expected Obj, but got I4
			//IL_00d5: Expected Obj, but got I4
			//IL_0303->IL0019: Incompatible stack heights: 2 vs 1
			//IL_02d7->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
			//IL_02f3->IL0015: Incompatible stack heights: 1 vs 0
			//IL_030e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_005c->IL0060: Incompatible stack heights: 1 vs 0
			//IL_02e2->IL0019: Incompatible stack types: I4 vs Obj
			//IL_01e4->IL0060: Incompatible stack heights: 1 vs 0
			//IL_00f7->IL0060: Incompatible stack heights: 2 vs 0
			//IL_0146->IL0060: Incompatible stack heights: 2 vs 0
			//IL_00ea->IL0060: Incompatible stack heights: 3 vs 0
			//IL_0191->IL0060: Incompatible stack heights: 2 vs 0
			//IL_01c9->IL0060: Incompatible stack heights: 3 vs 0
			//IL_01f4->IL0060: Incompatible stack heights: 3 vs 0
			//IL_0158->IL0060: Incompatible stack heights: 3 vs 0
			//IL_0249->IL005c: Incompatible stack heights: 0 vs 1
			//IL_0206->IL0060: Incompatible stack heights: 1 vs 0
			//IL_019c->IL0060: Incompatible stack heights: 2 vs 0
			//IL_0060->IL0060: Incompatible stack heights: 2 vs 0
			//IL_00da->IL005c: Incompatible stack heights: 0 vs 1
			//IL_0163->IL0060: Incompatible stack heights: 3 vs 0
			//IL_021f->IL0060: Incompatible stack heights: 1 vs 0
			//IL_01bb->IL0060: Incompatible stack heights: 1 vs 0
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
					case 3:
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 2;
						continue;
					case 4:
						return;
					case 1:
						if (obj != null)
						{
							_ = 2;
							goto IL_0060;
						}
						goto IL_01c9;
					case 2:
						obj = (object)Unsafe.AsPointer(ref this);
						if (1 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 5:
						goto end_IL_0019;
						IL_0060:
						while (true)
						{
							object obj3;
							switch ((int)/*Error near IL_00b1: Stack underflow*/)
							{
							case 1:
								return;
							case 13:
								if (obj == null)
								{
									obj = 15;
									continue;
								}
								goto case 4;
							case 7:
								obj = 0;
								_ = 12;
								continue;
							default:
								_ = ref obj;
								_ = 9;
								continue;
							case 11:
								obj = 8;
								continue;
							case 4:
								obj = obj;
								_ = 6;
								continue;
							case 16:
								_ = ref obj;
								if (false)
								{
									_ = 1;
								}
								continue;
							case 8:
								obj = -1;
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							case 2:
								if (obj == null)
								{
									goto end_IL_0019_2;
								}
								if (14 == 0)
								{
									_ = 8;
								}
								continue;
							case 12:
								_ = 16;
								continue;
							case 17:
								break;
							case 15:
								_ = null;
								_ = null;
								_ = 3;
								continue;
							case 6:
								if (&obj == null)
								{
									_ = 7;
									continue;
								}
								goto default;
							case 14:
							case 18:
								obj3 = obj;
								if (obj3 == null)
								{
									_ = 5;
									continue;
								}
								if (obj3 == null)
								{
									obj3 = (object)/*Error near IL_0235: Stack underflow*/;
								}
								goto IL_0238;
							case 5:
								obj3 = null;
								goto IL_0238;
							case 3:
							case 9:
							case 10:
								goto end_IL_0019_2;
								IL_0238:
								obj = obj3;
								obj = 13;
								continue;
							}
							break;
						}
						goto IL_01c9;
						IL_01c9:
						obj = (object)Unsafe.AsPointer(ref this);
						if (4 == 0)
						{
							_ = 11;
						}
						goto IL_0060;
						end_IL_0019_2:
						break;
					}
					_ = -2;
					if (5 == 0)
					{
						_ = 2;
					}
					continue;
					end_IL_0019:
					break;
				}
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
		internal static byte _FF00_FF00_FF00_FF00_FF00_0B00()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
		internal static object _FF00_FF00_FF00_FF00_FF00_0E00()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00ༀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778513, new IntPtr(2737336168892L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00က(object P_0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0082: Expected Obj, but got Ref
			//IL_005a: Expected Obj, but got Ref
			//IL_02ce: Expected Obj, but got Ref
			//IL_03ee: Expected Obj, but got I4
			//IL_03f7: Expected Obj, but got I4
			//IL_02a1: Expected Obj, but got I4
			//IL_0267: Expected Obj, but got I4
			//IL_0317: Expected Obj, but got Ref
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_008c->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0064->IL0019: Incompatible stack types: I4 vs Ref
			//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_007e->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0139->IL00af: Incompatible stack heights: 1 vs 0
			//IL_00ab->IL00af: Incompatible stack heights: 1 vs 0
			//IL_0111->IL00af: Incompatible stack heights: 2 vs 0
			//IL_0121->IL00af: Incompatible stack heights: 3 vs 0
			//IL_0163->IL00af: Incompatible stack heights: 1 vs 0
			//IL_0173->IL00af: Incompatible stack heights: 2 vs 0
			//IL_017e->IL00af: Incompatible stack heights: 2 vs 0
			//IL_02e5->IL01a1: Incompatible stack heights: 1 vs 0
			//IL_019d->IL01a1: Incompatible stack heights: 1 vs 0
			//IL_0156->IL00af: Incompatible stack heights: 1 vs 0
			//IL_022a->IL01a1: Incompatible stack heights: 1 vs 0
			//IL_01f2->IL01a1: Incompatible stack heights: 1 vs 0
			//IL_02f4->IL01a1: Incompatible stack heights: 1 vs 0
			//IL_02ae->IL01a1: Incompatible stack heights: 2 vs 0
			//IL_0274->IL01a1: Incompatible stack heights: 2 vs 0
			//IL_0245->IL01a1: Incompatible stack heights: 2 vs 0
			//IL_0291->IL01a1: Incompatible stack heights: 3 vs 0
			//IL_020f->IL01a1: Incompatible stack heights: 2 vs 0
			//IL_02ca->IL01a1: Incompatible stack heights: 2 vs 0
			//IL_00af->IL00af: Incompatible stack heights: 2 vs 0
			//IL_0235->IL01a1: Incompatible stack heights: 1 vs 0
			//IL_01fd->IL01a1: Incompatible stack heights: 1 vs 0
			//IL_02b9->IL01a1: Incompatible stack heights: 2 vs 0
			//IL_027f->IL01a1: Incompatible stack heights: 2 vs 0
			//IL_0250->IL01a1: Incompatible stack heights: 2 vs 0
			//IL_0262->IL01a1: Incompatible stack heights: 1 vs 0
			//IL_029c->IL01a1: Incompatible stack heights: 3 vs 0
			//IL_021a->IL01a1: Incompatible stack heights: 2 vs 0
			//IL_032e->IL01a1: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			ref _003CRefreshNetGames_003Ed__17 reference = ref *(_003CRefreshNetGames_003Ed__17*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 5u:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CRefreshNetGames_003Ed__17*)3;
					break;
				default:
					reference = ref this;
					if (true)
					{
						reference = ref *(_003CRefreshNetGames_003Ed__17*)1;
					}
					break;
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CRefreshNetGames_003Ed__17*)2;
					break;
				case 2u:
					if (obj != null)
					{
						if (1 == 0)
						{
							_ = 3;
						}
						goto IL_00af;
					}
					goto IL_0121;
				case 1u:
					return;
					IL_0121:
					if (1 == 0)
					{
						_ = 1;
					}
					goto IL_00af;
					IL_00af:
					while (true)
					{
						switch ((int)/*Error near IL_00e0: Stack underflow*/)
						{
						case 2:
						case 9:
							break;
						case 6:
							_ = 10;
							continue;
						case 7:
							_ = 6;
							continue;
						default:
							goto IL_0121;
						case 3:
							if ((int)/*Error near IL_013f: Stack underflow*/ == 0)
							{
								break;
							}
							if (3 == 0)
							{
								_ = 5;
							}
							continue;
						case 5:
						case 8:
							_ = 4;
							continue;
						case 10:
							_ = 0;
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 1:
							if (obj != null)
							{
								if (4 != 0)
								{
									_ = 2;
								}
								goto IL_01a1;
							}
							goto IL_02ca;
						case 4:
							{
								int num = 6;
								if (num == 0)
								{
									num = 0;
								}
								obj = num;
								obj = 7;
								continue;
							}
							IL_02ca:
							obj = (object)Unsafe.AsPointer(ref this);
							if (3 != 0)
							{
								_ = 2;
							}
							goto IL_01a1;
							IL_01a1:
							while (true)
							{
								switch ((int)/*Error near IL_01de: Stack underflow*/)
								{
								case 2:
									break;
								case 3:
									if (3 == 0)
									{
										_ = 7;
									}
									continue;
								case 11:
									if (false)
									{
										_ = 1;
									}
									continue;
								case 1:
									if (3 == 0)
									{
										_ = 13;
									}
									continue;
								case 8:
									if (1 == 0)
									{
										_ = 10;
									}
									continue;
								case 9:
									if (&obj == null)
									{
										_ = 6;
										continue;
									}
									goto default;
								case 7:
									obj = -1;
									if (0 == 0)
									{
										_ = 0;
									}
									continue;
								case 10:
									_ = ref obj;
									if (12 != 0)
									{
										_ = 5;
									}
									continue;
								case 6:
									obj = 0;
									if (7 != 0)
									{
										_ = 8;
									}
									continue;
								case 13:
									_ = 2;
									continue;
								case 5:
									goto IL_02ca;
								case 4:
									obj = (object)/*Error near IL_02ea: Stack underflow*/;
									_ = 9;
									continue;
								case 12:
									return;
								default:
								{
									ref object reference2 = ref obj;
									if (Unsafe.AsPointer(ref reference2) == null)
									{
										reference2 = ref *(object*)/*Error near IL_0311: Stack underflow*/;
									}
									obj = (object)Unsafe.AsPointer(ref reference2);
									if (11 == 0)
									{
										_ = 0;
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
					goto case 5u;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00Ѐ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00Ԁ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778525, new IntPtr(2737336182412L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_0600()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_0700(object P_0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0074: Expected Obj, but got Ref
			//IL_05af: Expected Obj, but got Ref
			//IL_04da: Expected Obj, but got I4
			//IL_0273: Expected Obj, but got Ref
			//IL_01c4: Expected Obj, but got I4
			//IL_032b: Expected Obj, but got I4
			//IL_0348: Expected Obj, but got Ref
			//IL_0251: Expected Obj, but got Ref
			//IL_0368: Expected Obj, but got I4
			//IL_02d1: Expected Obj, but got I4
			//IL_0282: Expected Obj, but got Ref
			//IL_0260: Expected Obj, but got I4
			//IL_026a: Expected Obj, but got I4
			//IL_0394: Expected Obj, but got I4
			//IL_02b0: Expected Obj, but got I4
			//IL_016c: Expected I4, but got Obj
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_007e->IL0019: Incompatible stack types: I4 vs Ref
			//IL_05bb->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0070->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
			//IL_05c6->IL0019: Incompatible stack types: I4 vs Ref
			//IL_04b1->IL00a3: Incompatible stack heights: 1 vs 0
			//IL_009f->IL00a3: Incompatible stack heights: 1 vs 0
			//IL_0460->IL00a3: Incompatible stack heights: 2 vs 0
			//IL_04a1->IL00a3: Incompatible stack heights: 1 vs 0
			//IL_0494->IL00a3: Incompatible stack heights: 1 vs 0
			//IL_00a3->IL00a3: Incompatible stack heights: 3 vs 0
			//IL_027d->IL00ef: Incompatible stack types: I4 vs Obj
			//IL_00eb->IL00ef: Incompatible stack types: I4 vs Obj
			//IL_0515->IL00a3: Incompatible stack heights: 3 vs 0
			//IL_01d0->IL00ef: Incompatible stack heights: 0 vs 1
			//IL_01af->IL00ef: Incompatible stack heights: 3 vs 1
			//IL_0363->IL00ef: Incompatible stack heights: 2 vs 1
			//IL_0338->IL00ef: Incompatible stack heights: 2 vs 1
			//IL_031b->IL00ef: Incompatible stack heights: 3 vs 1
			//IL_0352->IL00ef: Incompatible stack types: I4 vs Obj
			//IL_025b->IL00ef: Incompatible stack types: I4 vs Obj
			//IL_0214->IL00ef: Incompatible stack heights: 0 vs 1
			//IL_0373->IL00ef: Incompatible stack heights: 3 vs 1
			//IL_024d->IL00ef: Incompatible stack heights: 2 vs 1
			//IL_028c->IL00ef: Incompatible stack types: I4 vs Obj
			//IL_0399->IL00eb: Incompatible stack heights: 3 vs 2
			//IL_0299->IL00ef: Incompatible stack heights: 2 vs 1
			//IL_018e->IL00ef: Incompatible stack heights: 3 vs 1
			//IL_0204->IL00ef: Incompatible stack heights: 2 vs 1
			//IL_02bd->IL00ef: Incompatible stack heights: 2 vs 1
			//IL_0520->IL00a3: Incompatible stack heights: 3 vs 0
			//IL_01db->IL00ef: Incompatible stack types: I4 vs Obj
			//IL_0234->IL00ef: Incompatible stack heights: 0 vs 1
			//IL_0385->IL00ef: Incompatible stack types: I4 vs Obj
			//IL_0343->IL00ef: Incompatible stack heights: 2 vs 1
			//IL_0309->IL00ef: Incompatible stack types: I4 vs Obj
			//IL_02ab->IL00ef: Incompatible stack types: I4 vs Obj
			//IL_0326->IL00ef: Incompatible stack heights: 3 vs 1
			//IL_021f->IL00ef: Incompatible stack types: I4 vs Obj
			//IL_02e8->IL00ef: Incompatible stack types: I4 vs Obj
			//IL_00ef->IL00ef: Incompatible stack heights: 3 vs 1
			//IL_03b8->IL00ef: Incompatible stack heights: 3 vs 1
			//IL_02c8->IL00ef: Incompatible stack heights: 2 vs 1
			//IL_023f->IL00ef: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			ref _003CRefreshRentalGames_003Ed__22 reference = ref *(_003CRefreshRentalGames_003Ed__22*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 1u:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				default:
					reference = ref this;
					if (2 == 0)
					{
						reference = ref *(_003CRefreshRentalGames_003Ed__22*)1;
					}
					break;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CRefreshRentalGames_003Ed__22*)3;
					break;
				case 2u:
					return;
				case 3u:
					if ((nuint)(nint)obj <= (nuint)1u)
					{
						if (4 != 0)
						{
							_ = 4;
						}
						goto IL_00a3;
					}
					goto IL_04a1;
				case 5u:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (4 == 0)
						{
							reference = ref *(_003CRefreshRentalGames_003Ed__22*)3;
						}
						break;
					}
					IL_00a3:
					while (true)
					{
						object obj2;
						switch ((int)/*Error near IL_00d4: Stack underflow*/)
						{
						case 1:
						case 10:
							break;
						case 6:
							if (obj != null)
							{
								obj2 = 9;
								goto IL_00ef;
							}
							goto IL_026f;
						default:
							_ = 5;
							continue;
						case 2:
						case 4:
							if (0 == 0)
							{
								_ = 6;
							}
							continue;
						case 3:
						case 9:
							_ = 8;
							continue;
						case 7:
							goto IL_04a1;
						case 5:
							_ = 1;
							obj = 2;
							continue;
						case 8:
							{
								int num = 6;
								if (num == 0)
								{
									num = 0;
								}
								if (false)
								{
									_ = 0;
								}
								continue;
							}
							IL_00ef:
							while (true)
							{
								switch ((int)obj2)
								{
								case 22:
									break;
								case 1:
									return;
								case 29:
									return;
								case 26:
									_ = 23;
									continue;
								case 3:
									_ = 11;
									continue;
								default:
									obj = 0;
									if (2 != 0)
									{
										obj2 = 4;
									}
									continue;
								case 27:
									_ = 20;
									continue;
								case 14:
								case 21:
									obj = obj;
									if (25 != 0)
									{
										obj2 = 11;
									}
									continue;
								case 2:
									if (obj != null)
									{
										if (0 == 0)
										{
											obj2 = 0;
										}
										continue;
									}
									goto case 16;
								case 17:
									_ = 5;
									continue;
								case 13:
									obj = (object)Unsafe.AsPointer(ref this);
									obj2 = 27;
									continue;
								case 20:
									obj = -1;
									obj = 18;
									continue;
								case 19:
									goto IL_026f;
								case 7:
								case 18:
									obj = (object)(&obj);
									obj2 = 14;
									continue;
								case 24:
									_ = 28;
									continue;
								case 10:
									if (&obj != null)
									{
										obj2 = 7;
										continue;
									}
									goto case 15;
								case 28:
									obj = -1;
									if (4 == 0)
									{
										_ = 12;
									}
									continue;
								case 16:
									obj2 = obj;
									obj = 0;
									if (7 != 0)
									{
										obj2 = 10;
									}
									continue;
								case 9:
									if ((nint)obj != 1)
									{
										obj2 = 2;
										continue;
									}
									goto case 13;
								case 11:
									_ = ref obj;
									if (1 == 0)
									{
										_ = 0;
									}
									continue;
								case 8:
									obj = 0;
									if (26 != 0)
									{
										_ = 13;
									}
									continue;
								case 6:
								case 12:
									obj = (object)(&obj);
									obj2 = 21;
									continue;
								case 5:
									_ = 22;
									continue;
								case 15:
									obj = 1;
									_ = 3;
									continue;
								case 4:
									if (&obj != null)
									{
										obj2 = 6;
										continue;
									}
									goto case 8;
								case 23:
									_ = ref obj;
									obj = 29;
									continue;
								case 25:
								{
									object obj3 = obj;
									_ = 17;
									continue;
								}
								}
								break;
							}
							break;
							IL_026f:
							obj = (object)Unsafe.AsPointer(ref this);
							obj2 = 24;
							goto IL_00ef;
						}
						break;
					}
					goto case 1u;
					IL_04a1:
					if ((int)/*Error near IL_04a7: Stack underflow*/ != 0)
					{
						_ = 3;
						goto IL_00a3;
					}
					goto case 1u;
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
		internal static byte _FF00_FF00_FF00_FF00_F600()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_F700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778520, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_F800()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00豈(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778521, new IntPtr(2737336168892L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00切(object P_0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0367: Expected Obj, but got Ref
			//IL_0382: Expected Obj, but got Ref
			//IL_038b: Expected Obj, but got I4
			//IL_0197: Expected Obj, but got Ref
			//IL_016a: Expected Obj, but got I4
			//IL_00f6: Expected Obj, but got I4
			//IL_01c0: Expected Obj, but got Ref
			//IL_0356->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0363->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0373->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004f->IL005e: Incompatible stack heights: 0 vs 1
			//IL_037e->IL0019: Incompatible stack types: I4 vs Obj
			//IL_02bd->IL005e: Incompatible stack types: I4 vs Ref
			//IL_005a->IL005e: Incompatible stack types: I4 vs Ref
			//IL_02a0->IL005e: Incompatible stack types: I4 vs Ref
			//IL_008e->IL0092: Incompatible stack heights: 1 vs 0
			//IL_01ae->IL0092: Incompatible stack heights: 1 vs 0
			//IL_0177->IL0092: Incompatible stack heights: 2 vs 0
			//IL_0103->IL0092: Incompatible stack heights: 2 vs 0
			//IL_015a->IL0092: Incompatible stack heights: 2 vs 0
			//IL_01d7->IL0092: Incompatible stack heights: 2 vs 0
			//IL_0137->IL0092: Incompatible stack heights: 2 vs 0
			//IL_01bc->IL0092: Incompatible stack heights: 3 vs 0
			//IL_00e6->IL0092: Incompatible stack heights: 3 vs 0
			//IL_01ca->IL0092: Incompatible stack heights: 1 vs 0
			//IL_0182->IL0092: Incompatible stack heights: 2 vs 0
			//IL_010e->IL0092: Incompatible stack heights: 2 vs 0
			//IL_0149->IL0092: Incompatible stack heights: 1 vs 0
			//IL_0165->IL0092: Incompatible stack heights: 2 vs 0
			//IL_00f1->IL0092: Incompatible stack heights: 3 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					scoped ref _003CSelectGame_003Ed__6 reference;
					switch ((int)obj2)
					{
					case 1:
						if (obj == null)
						{
							if (0 == 0)
							{
								reference = ref *(_003CSelectGame_003Ed__6*)null;
							}
							goto IL_005e;
						}
						goto IL_02a0;
					default:
						goto IL_0348;
					case 2:
						_ = 5;
						continue;
					case 3:
						obj = (object)Unsafe.AsPointer(ref this);
						if (true)
						{
							obj2 = 1;
						}
						continue;
					case 4:
						break;
					case 5:
						return;
						IL_02a0:
						reference = ref this;
						if (4 != 0)
						{
							reference = ref *(_003CSelectGame_003Ed__6*)2;
						}
						goto IL_005e;
						IL_0348:
						_ = -2;
						_ = 2;
						continue;
						IL_005e:
						while (true)
						{
							switch ((uint)Unsafe.AsPointer(ref reference))
							{
							case 3u:
								if (obj == null)
								{
									_ = 3;
									goto IL_0092;
								}
								goto IL_0191;
							default:
								reference = ref *(_003CSelectGame_003Ed__6*)3;
								continue;
							case 2u:
								break;
							case 1u:
								goto IL_0348;
								IL_0092:
								while (true)
								{
									switch ((int)/*Error near IL_00cf: Stack underflow*/)
									{
									default:
										return;
									case 10:
										_ = ref obj;
										if (0 == 0)
										{
											_ = 0;
										}
										continue;
									case 4:
										obj = -1;
										if (7 != 0)
										{
											_ = 4;
										}
										continue;
									case 8:
										_ = 4;
										continue;
									case 5:
										if (&obj != null)
										{
											_ = 12;
											continue;
										}
										goto case 1;
									case 6:
										if (2 != 0)
										{
											_ = 0;
										}
										continue;
									case 1:
										obj = 0;
										if (9 == 0)
										{
											_ = 9;
										}
										continue;
									case 0:
										return;
									case 11:
										break;
									case 9:
										_ = 10;
										continue;
									case 3:
									case 13:
										obj = (object)Unsafe.AsPointer(ref this);
										_ = 8;
										continue;
									case 7:
									case 12:
										_ = ref obj;
										_ = 6;
										continue;
									case 2:
										goto IL_0348;
									}
									break;
								}
								goto IL_0191;
								IL_0191:
								obj = (object)Unsafe.AsPointer(ref this);
								if (3 == 0)
								{
									_ = 5;
								}
								goto IL_0092;
							}
							break;
						}
						goto IL_02a0;
					}
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
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
		internal static byte _FF00_FF00_FF00_FF00_E800()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
		internal static object _FF00_FF00_FF00_FF00_EB00()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_EC00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778595, new IntPtr(2737336181372L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_ED00(object P_0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_004d: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_016b: Expected Obj, but got I4
			//IL_0157: Expected Obj, but got I4
			//IL_0161: Expected Obj, but got I4
			//IL_00f5: Expected Obj, but got Ref
			//IL_0081->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0071->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0059->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
			//IL_008c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0194->IL00af: Incompatible stack heights: 1 vs 0
			//IL_01a6->IL00af: Incompatible stack heights: 1 vs 0
			//IL_00ab->IL00af: Incompatible stack heights: 1 vs 0
			//IL_01c7->IL00af: Incompatible stack heights: 3 vs 0
			//IL_0178->IL00af: Incompatible stack heights: 2 vs 0
			//IL_0152->IL00af: Incompatible stack heights: 2 vs 0
			//IL_01f3->IL00af: Incompatible stack heights: 1 vs 0
			//IL_011c->IL00af: Incompatible stack heights: 2 vs 0
			//IL_01d2->IL00af: Incompatible stack heights: 3 vs 0
			//IL_0183->IL00af: Incompatible stack heights: 2 vs 0
			//IL_00af->IL00af: Incompatible stack heights: 3 vs 0
			//IL_01fe->IL00af: Incompatible stack heights: 1 vs 0
			//IL_01e4->IL00af: Incompatible stack heights: 1 vs 0
			//IL_0127->IL00af: Incompatible stack heights: 2 vs 0
			//IL_010c->IL00af: Incompatible stack heights: 1 vs 0
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
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 4;
					continue;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					_ = 3;
					continue;
				case 1:
					break;
				default:
					if (obj == null)
					{
						if (4 == 0)
						{
							_ = 3;
						}
						goto IL_00af;
					}
					goto IL_0194;
				case 3:
					return;
					IL_0194:
					if (obj == null)
					{
						_ = 10;
						goto IL_00af;
					}
					goto IL_0183;
					IL_0183:
					obj = obj;
					_ = 11;
					goto IL_00af;
					IL_00af:
					while (true)
					{
						switch ((int)/*Error near IL_00ec: Stack underflow*/)
						{
						case 4:
						case 13:
							obj = (object)Unsafe.AsPointer(ref this);
							if (1 == 0)
							{
								_ = 6;
							}
							continue;
						case 12:
							if (1 == 0)
							{
								_ = 1;
							}
							continue;
						case 3:
							return;
						case 6:
							_ = 5;
							continue;
						case 7:
							obj = 0;
							obj = 12;
							continue;
						case 5:
							obj = -1;
							if (9 == 0)
							{
								_ = 7;
							}
							continue;
						case 2:
							goto end_IL_00af;
						case 8:
							goto IL_0194;
						case 1:
							_ = ref obj;
							if (true)
							{
								_ = 3;
							}
							continue;
						case 11:
							if (&obj == null)
							{
								_ = 7;
								continue;
							}
							goto case 9;
						case 9:
							_ = ref obj;
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						}
						goto end_IL_0019;
						continue;
						end_IL_00af:
						break;
					}
					goto IL_0183;
					end_IL_0019:
					break;
				}
				_ = -2;
				if (true)
				{
					_ = 2;
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
		internal static byte _FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_E000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778607, new IntPtr(2737336179292L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_E100()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_E200(object P_0)
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
	public MobileViewModel()
	{
		//IL_004e: Expected I4, but got Obj
		//IL_0038->IL0041: Incompatible stack types: I4 vs Obj
		//IL_006d->IL0041: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		MobileViewModel mobileViewModel = this;
		if (0 == 0)
		{
			mobileViewModel = (MobileViewModel)0;
		}
		while (true)
		{
			switch ((int)mobileViewModel)
			{
			case 1:
				return;
			}
			mobileViewModel = this;
			if (true)
			{
				mobileViewModel = (MobileViewModel)1;
			}
		}
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
	internal static object _FF00_FF00洀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00渀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
	internal void _FF00_FF00焀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_004b: Expected Obj, but got I4
		//IL_006b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008f->IL005d: Incompatible stack heights: 1 vs 0
		//IL_00b5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0050->IL0015: Incompatible stack heights: 1 vs 0
		//IL_005d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0085->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a6->IL0019: Incompatible stack types: I4 vs Obj
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
				case 4:
					break;
				case 6:
					_ = 5;
					continue;
				case 5:
					return;
				case 1:
					_ = 4;
					continue;
				default:
					obj2 = this;
					if (3 == 0)
					{
						obj2 = 6;
					}
					continue;
				case 2:
					obj2 = this;
					if (P_0 != null)
					{
						return;
					}
					if (1 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 3:
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				}
				break;
			}
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00爀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0098->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0069->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0057->IL0019: Incompatible stack types: I4 vs Obj
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
			case 3:
				if (this != null)
				{
					obj2 = 2;
					break;
				}
				if (this == null)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				return;
			case 4:
				return;
			case 1:
				return;
			default:
				_ = 1;
				obj2 = 4;
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
	internal void _FF00_FF00瘀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0099: Expected Obj, but got I4
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0090->IL006b: Incompatible stack heights: 1 vs 0
		//IL_0051->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0086->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009e->IL0015: Incompatible stack heights: 1 vs 0
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
					if (1 == 0)
					{
						_ = 1;
					}
					continue;
				case 2:
					obj2 = this;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 4:
					return;
				case 1:
					obj2 = this;
					if (0 == 0)
					{
						obj2 = 4;
					}
					continue;
				case 3:
					if (P_0 != null)
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
	internal byte _FF00_FF00砀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
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
	internal byte _FF00_FF00紀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (this != null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00縀(ObservableCollection<MobileGameModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778551, new IntPtr(2737336153292L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00缀(ObservableCollection<MobileGameModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0099->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0060->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0075->IL0099: Incompatible stack heights: 1 vs 0
		//IL_006b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0051->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008c->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				obj2 = this;
				if (true)
				{
					obj2 = 1;
				}
				break;
			case 1:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 4:
				obj2 = this;
				if (P_0 == null)
				{
					if (3 == 0)
					{
						obj2 = 2;
					}
					break;
				}
				return;
			default:
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
	internal uint _FF00_FF00脀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00舀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_006a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0075->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0057->IL0019: Incompatible stack types: I4 vs Obj
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
				continue;
			case 3:
				if (this != null)
				{
					obj2 = 2;
					continue;
				}
				break;
			case 4:
				return;
			}
			_ = null;
			_ = null;
			if (true)
			{
				_ = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00茀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00萀(ObservableCollection<ConfigValue> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778549, new IntPtr(2737336151212L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00蔀(ObservableCollection<ConfigValue> P_0)
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
	internal void _FF00_FF00蘀(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0073->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0082->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005c->IL0037: Incompatible stack heights: 1 vs 0
		//IL_008d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0052->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
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
				if (1 == 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
				if (P_0 != 0)
				{
					return;
				}
				_ = 3;
				break;
			default:
				_ = 2;
				break;
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
	internal ObservableCollection<MobileGameModel> _FF00_FF00蜀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<MobileGameModel>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00蠀(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0069->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0042->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0074->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004d->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		while (true)
		{
			switch ((int)obj)
			{
			case 2:
				if (false)
				{
					_ = 0;
				}
				continue;
			case 3:
				_ = 1;
				_ = 2;
				continue;
			case 1:
				return;
			}
			_ = 0;
			if (0 == 0)
			{
				_ = 1;
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
	private ObservableCollection<ConfigValue> _FF00_FF00言()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<ConfigValue>)(object)this;
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
	internal void _FF00_FF00贀(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0052: Expected I4, but got Obj
		//IL_0068->IL0019: Incompatible stack heights: 3 vs 1
		//IL_011d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_014d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c6->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0102->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00f2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ad->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0158->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0078->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d9->IL0019: Incompatible stack heights: 0 vs 1
		//IL_010d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e4->IL0019: Incompatible stack types: I4 vs Obj
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
				if (this == null)
				{
					if (false)
					{
						obj2 = 2;
					}
					continue;
				}
				break;
			case 8:
				_ = null;
				_ = 4;
				continue;
			case 11:
				if (P_0 != 1)
				{
					if (1 == 0)
					{
						obj2 = 1;
					}
					continue;
				}
				goto case 12;
			case 5:
				return;
			case 2:
				_ = 6;
				continue;
			case 12:
				_ = null;
				if (0 == 0)
				{
					_ = 0;
				}
				continue;
			case 6:
				_ = P_0 == 1;
				_ = 10;
				continue;
			case 9:
				return;
			case 7:
				break;
			}
			if (false)
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
	internal static byte _FF00_FF00錀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00鐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778554, new IntPtr(2737336167852L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00销()
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
				_ = null;
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
	internal unsafe ObservableCollection<MobileGameModel> _FF00_FF00阀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778555, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<MobileGameModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ObservableCollection<MobileGameModel> _FF00_FF00需()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<MobileGameModel>)(object)this;
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
	private void _FF00_FF00鼀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_007c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006b->IL0019: Incompatible stack types: I4 vs Obj
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
			case 0:
				return;
			case 2:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			case 3:
				if (this == null)
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
	internal void _FF00_FF00ꐀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0041->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0066->IL0019: Incompatible stack types: I4 vs Obj
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
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				if (0 == 0)
				{
					obj2 = 1;
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
	internal void _FF00_FF00ꘀ(ObservableCollection<MobileGameModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_008d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0041->IL0065: Incompatible stack heights: 1 vs 0
		//IL_0065->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0080->IL0019: Incompatible stack types: I4 vs Obj
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
				_ = 4;
				break;
			case 4:
				return;
			case 1:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			default:
				_ = 3;
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
	private byte _FF00_FF00꼀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0043->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0061->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006c->IL0019: Incompatible stack types: I4 vs Obj
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
				return 1;
			case 2:
				if (this == null)
				{
					_ = null;
					_ = null;
					if (0 == 0)
					{
						_ = 0;
					}
				}
				else if (false)
				{
					obj2 = 1;
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
