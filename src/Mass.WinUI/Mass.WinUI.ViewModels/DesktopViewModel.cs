using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mass.Domain.Desktop.Entities.LanGame;
using Mass.Domain.Desktop.Entities.NetGame;
using Mass.Domain.Desktop.Entities.RentalGame;
using Mass.Domain.Desktop.Interfaces;
using Mass.Domain.Desktop.Models;
using Mass.Domain.Value;
using Mass.WinUI.Models;
using Microsoft.UI.Xaml.Controls;
using WinRT;
using WinRT.Mass_WinUIVtableClasses;

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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0401: Expected Obj, but got Ref
			//IL_03cb: Expected Obj, but got Ref
			//IL_01b8: Expected Obj, but got Ref
			//IL_00e1: Expected Obj, but got I4
			//IL_0126: Expected Obj, but got I4
			//IL_02e8: Expected Obj, but got I4
			//IL_01ed: Expected Obj, but got Ref
			//IL_028d: Expected Obj, but got Ref
			//IL_0290: Expected Obj, but got Ref
			//IL_0323: Expected Obj, but got I4
			//IL_0232: Expected Obj, but got I4
			//IL_0108: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_03bc->IL0019: Incompatible stack heights: 2 vs 1
			//IL_040b->IL0019: Incompatible stack types: I4 vs Ref
			//IL_03d7->IL0019: Incompatible stack heights: 0 vs 1
			//IL_03c7->IL0019: Incompatible stack heights: 2 vs 1
			//IL_03fc->IL0019: Incompatible stack types: I4 vs Ref
			//IL_03e2->IL0019: Incompatible stack types: I4 vs Ref
			//IL_01c2->IL005e: Incompatible stack heights: 1 vs 0
			//IL_01d4->IL005e: Incompatible stack heights: 1 vs 0
			//IL_005a->IL005e: Incompatible stack heights: 1 vs 0
			//IL_00ec->IL005e: Incompatible stack heights: 3 vs 0
			//IL_00fc->IL005e: Incompatible stack heights: 4 vs 0
			//IL_0132->IL005e: Incompatible stack heights: 2 vs 0
			//IL_0211->IL005e: Incompatible stack heights: 2 vs 0
			//IL_02f3->IL005e: Incompatible stack heights: 3 vs 0
			//IL_01e9->IL005e: Incompatible stack heights: 1 vs 0
			//IL_02c9->IL005e: Incompatible stack heights: 2 vs 0
			//IL_016c->IL005e: Incompatible stack heights: 4 vs 0
			//IL_032e->IL005e: Incompatible stack heights: 3 vs 0
			//IL_023d->IL005e: Incompatible stack heights: 3 vs 0
			//IL_01b4->IL005e: Incompatible stack heights: 1 vs 0
			//IL_017c->IL005e: Incompatible stack heights: 2 vs 0
			//IL_013d->IL005e: Incompatible stack heights: 2 vs 0
			//IL_02d4->IL005e: Incompatible stack heights: 2 vs 0
			//IL_0204->IL005e: Incompatible stack heights: 1 vs 0
			//IL_02a7->IL005e: Incompatible stack heights: 1 vs 0
			//IL_005e->IL005e: Incompatible stack heights: 2 vs 0
			//IL_02b9->IL005e: Incompatible stack heights: 1 vs 0
			//IL_0187->IL005e: Incompatible stack heights: 2 vs 0
			//IL_015c->IL005e: Incompatible stack heights: 1 vs 0
			//IL_01a6->IL005e: Incompatible stack heights: 1 vs 0
			//IL_025b->IL005e: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			ref _003CAddCharacter_003Ed__0 reference = ref *(_003CAddCharacter_003Ed__0*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 2u:
					if (obj == null)
					{
						if (0 == 0)
						{
							_ = 0;
						}
						goto IL_005e;
					}
					goto IL_01c2;
				default:
					goto IL_03ac;
				case 5u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (4 != 0)
					{
						reference = ref *(_003CAddCharacter_003Ed__0*)null;
					}
					break;
				case 1u:
					reference = ref this;
					if (3 == 0)
					{
						reference = ref *(_003CAddCharacter_003Ed__0*)3;
					}
					break;
				case 3u:
					return;
				case 4u:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(_003CAddCharacter_003Ed__0*)2;
						break;
					}
					IL_01c2:
					if ((nint)obj != 1)
					{
						_ = 23;
						goto IL_005e;
					}
					goto IL_01b4;
					IL_03ac:
					_ = -2;
					if (0 == 0)
					{
						_ = 1;
					}
					break;
					IL_01b4:
					obj = (object)Unsafe.AsPointer(ref this);
					_ = 6;
					goto IL_005e;
					IL_005e:
					while (true)
					{
						switch ((int)/*Error near IL_00d7: Stack underflow*/)
						{
						case 3:
							obj = 0;
							_ = 25;
							continue;
						case 4:
							_ = ref obj;
							_ = 21;
							continue;
						case 18:
							obj = 17;
							continue;
						case 5:
							obj = 1;
							if (true)
							{
								_ = 1;
							}
							continue;
						case 1:
							if (&obj != null)
							{
								if (12 != 0)
								{
									_ = 28;
								}
								continue;
							}
							goto case 15;
						case 11:
							_ = ref obj;
							_ = 24;
							continue;
						case 25:
							if (11 != 0)
							{
								_ = 6;
							}
							continue;
						case 2:
							if (&obj != null)
							{
								if (6 != 0)
								{
									_ = 22;
								}
								continue;
							}
							goto case 3;
						case 19:
						case 28:
							_ = ref obj;
							_ = 26;
							continue;
						case 16:
							break;
						case 27:
							goto IL_01c2;
						case 8:
							obj = (object)/*Error near IL_01df: Stack underflow*/;
							_ = 2;
							continue;
						default:
							obj = (object)Unsafe.AsPointer(ref this);
							if (18 == 0)
							{
								_ = 18;
							}
							continue;
						case 6:
							_ = 7;
							continue;
						case 24:
							return;
						case 17:
							obj = -1;
							_ = 14;
							continue;
						case 20:
							if (obj == null)
							{
								if (12 != 0)
								{
									_ = 11;
								}
								continue;
							}
							goto case 5;
						case 14:
						case 22:
							obj = (object)(&obj);
							obj = (object)(&obj);
							if (20 == 0)
							{
								_ = 9;
							}
							continue;
						case 23:
							if (obj == null)
							{
								_ = 10;
								continue;
							}
							goto case 8;
						case 9:
							if (2 == 0)
							{
								_ = 4;
							}
							continue;
						case 21:
							return;
						case 7:
							obj = -1;
							_ = 19;
							continue;
						case 15:
							obj = 1;
							_ = 9;
							continue;
						case 10:
						case 12:
						case 26:
							goto IL_03ac;
						}
						break;
					}
					goto IL_01b4;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_2B00()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_2E00()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_3100(object P_0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0074: Expected Obj, but got Ref
			//IL_0147: Expected Obj, but got Ref
			//IL_0173: Expected Obj, but got I4
			//IL_0190: Expected Obj, but got I4
			//IL_01c7: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_007e->IL0019: Incompatible stack types: I4 vs Ref
			//IL_008e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00ac->IL00b0: Incompatible stack heights: 1 vs 0
			//IL_0070->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0056->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0099->IL0019: Incompatible stack heights: 2 vs 1
			//IL_015e->IL00b0: Incompatible stack heights: 1 vs 0
			//IL_0128->IL00b0: Incompatible stack heights: 2 vs 0
			//IL_011b->IL00b0: Incompatible stack heights: 1 vs 0
			//IL_016e->IL00b0: Incompatible stack heights: 4 vs 0
			//IL_0180->IL00b0: Incompatible stack heights: 2 vs 0
			//IL_019d->IL00b0: Incompatible stack heights: 2 vs 0
			//IL_01ba->IL00b0: Incompatible stack heights: 1 vs 0
			//IL_018b->IL00b0: Incompatible stack heights: 2 vs 0
			//IL_01a8->IL00b0: Incompatible stack heights: 2 vs 0
			//IL_00b0->IL00b0: Incompatible stack heights: 3 vs 0
			//IL_0143->IL00b0: Incompatible stack heights: 1 vs 0
			//IL_01de->IL00b0: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			ref _003CAddRandomCharacter_003Ed__1 reference = ref *(_003CAddRandomCharacter_003Ed__1*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 2u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						reference = ref *(_003CAddRandomCharacter_003Ed__1*)null;
					}
					continue;
				case 1u:
					reference = ref this;
					if (4 == 0)
					{
						reference = ref *(_003CAddRandomCharacter_003Ed__1*)2;
					}
					continue;
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CAddRandomCharacter_003Ed__1*)2;
					continue;
				case 5u:
					break;
				case 4u:
					return;
				default:
					{
						if (obj != null)
						{
							_ = 12;
							goto IL_00b0;
						}
						goto IL_0143;
					}
					IL_0143:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						_ = 0;
					}
					goto IL_00b0;
					IL_00b0:
					while (true)
					{
						switch ((int)/*Error near IL_00e9: Stack underflow*/)
						{
						case 7:
							return;
						case 2:
							obj = obj;
							_ = 4;
							continue;
						case 1:
							_ = 5;
							continue;
						case 11:
							_ = ref obj;
							if (false)
							{
								_ = 0;
							}
							continue;
						case 10:
							goto end_IL_00b0;
						case 3:
							_ = ref obj;
							_ = 7;
							continue;
						case 5:
							obj = -1;
							if (11 == 0)
							{
								_ = 7;
							}
							continue;
						case 8:
							obj = 0;
							if (1 == 0)
							{
								_ = 9;
							}
							continue;
						case 4:
							if (&obj == null)
							{
								_ = 8;
								continue;
							}
							goto case 11;
						case 9:
							obj = 3;
							continue;
						case 12:
							if (obj == null)
							{
								_ = 6;
								continue;
							}
							goto case 2;
						}
						goto end_IL_0019;
						continue;
						end_IL_00b0:
						break;
					}
					goto IL_0143;
					end_IL_0019:
					break;
				}
				_ = -2;
				if (0 == 0)
				{
					_ = 1;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_2400()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_2500()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_2600()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777868, new IntPtr(2737335798092L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_2700(object P_0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0049: Expected Obj, but got I4
			//IL_006d: Expected Obj, but got Ref
			//IL_0052: Expected Obj, but got Ref
			//IL_012e: Expected Obj, but got Ref
			//IL_0222: Expected Obj, but got I4
			//IL_01f1: Expected Obj, but got I4
			//IL_01c1: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_004e->IL0015: Incompatible stack heights: 2 vs 0
			//IL_0079->IL0019: Incompatible stack heights: 0 vs 1
			//IL_005e->IL0019: Incompatible stack heights: 0 vs 1
			//IL_02ff->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0084->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0069->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0145->IL00a7: Incompatible stack heights: 1 vs 0
			//IL_00a3->IL00a7: Incompatible stack heights: 1 vs 0
			//IL_022e->IL00a7: Incompatible stack heights: 2 vs 0
			//IL_01fe->IL00a7: Incompatible stack heights: 2 vs 0
			//IL_01d9->IL00a7: Incompatible stack heights: 2 vs 0
			//IL_0104->IL00a7: Incompatible stack heights: 1 vs 0
			//IL_01cc->IL00a7: Incompatible stack heights: 3 vs 0
			//IL_0155->IL00a7: Incompatible stack heights: 4 vs 0
			//IL_011f->IL00a7: Incompatible stack heights: 2 vs 0
			//IL_0239->IL00a7: Incompatible stack heights: 2 vs 0
			//IL_0199->IL00a7: Incompatible stack heights: 1 vs 0
			//IL_0209->IL00a7: Incompatible stack heights: 2 vs 0
			//IL_010f->IL00a7: Incompatible stack heights: 1 vs 0
			//IL_01bc->IL00a7: Incompatible stack heights: 1 vs 0
			//IL_012a->IL00a7: Incompatible stack heights: 2 vs 0
			//IL_0174->IL00a7: Incompatible stack heights: 1 vs 0
			//IL_0267->IL00a7: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			while (true)
			{
				ref _003CLaunchEchoClient_003Ed__7 reference = ref *(_003CLaunchEchoClient_003Ed__7*)obj;
				while (true)
				{
					switch ((uint)Unsafe.AsPointer(ref reference))
					{
					case 1u:
						return;
					case 5u:
						obj = (object)Unsafe.AsPointer(ref this);
						if (4 == 0)
						{
							reference = ref *(_003CLaunchEchoClient_003Ed__7*)1;
						}
						continue;
					case 4u:
						obj = (object)Unsafe.AsPointer(ref this);
						if (2 == 0)
						{
							reference = ref *(_003CLaunchEchoClient_003Ed__7*)1;
						}
						continue;
					case 2u:
						if (obj != null)
						{
							if (1 == 0)
							{
								_ = 0;
							}
							goto IL_00a7;
						}
						goto IL_012a;
					case 3u:
						{
							reference = ref this;
							if (false)
							{
								reference = ref *(_003CLaunchEchoClient_003Ed__7*)1;
							}
							continue;
						}
						IL_00a7:
						while (true)
						{
							object obj2;
							switch ((int)/*Error near IL_00f0: Stack underflow*/)
							{
							case 11:
								return;
							case 9:
							case 12:
								break;
							case 3:
							case 8:
								_ = ref obj;
								if (6 == 0)
								{
									_ = 12;
								}
								continue;
							case 15:
								if (11 == 0)
								{
									_ = 14;
								}
								continue;
							case 2:
								goto end_IL_00a7;
							case 14:
								_ = ref obj;
								_ = 11;
								continue;
							case 5:
								if (&obj != null)
								{
									if (2 == 0)
									{
										_ = 3;
									}
									continue;
								}
								goto case 4;
							case 1:
								if (obj == null)
								{
									break;
								}
								_ = 7;
								continue;
							case 7:
							case 13:
								obj2 = obj;
								if (obj2 == null)
								{
									_ = 16;
									continue;
								}
								if (obj2 == null)
								{
									obj2 = (object)/*Error near IL_024a: Stack underflow*/;
								}
								goto IL_024d;
							case 10:
								obj = -1;
								_ = 8;
								continue;
							case 6:
								_ = 10;
								continue;
							case 4:
								obj = 0;
								if (5 != 0)
								{
									_ = 15;
								}
								continue;
							default:
								obj = 2;
								if (5 == 0)
								{
									_ = 3;
								}
								continue;
							case 16:
								{
									obj2 = null;
									goto IL_024d;
								}
								IL_024d:
								obj = obj2;
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							}
							goto end_IL_0019;
							continue;
							end_IL_00a7:
							break;
						}
						goto IL_012a;
						IL_012a:
						obj = (object)Unsafe.AsPointer(ref this);
						if (6 == 0)
						{
							_ = 2;
						}
						goto IL_00a7;
						end_IL_0019:
						break;
					}
					break;
				}
				_ = -2;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00ᴀ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00Ḁ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777867, new IntPtr(2737335798092L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00ἀ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_2000(object P_0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_006d: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_0048: Expected Obj, but got I4
			//IL_0201: Expected Obj, but got I4
			//IL_0105: Expected Obj, but got I4
			//IL_01de: Expected Obj, but got Ref
			//IL_01c2: Expected Obj, but got I4
			//IL_0265: Expected Obj, but got I4
			//IL_005b->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0069->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0079->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0084->IL0019: Incompatible stack types: I4 vs Obj
			//IL_01bd->IL009a: Incompatible stack heights: 3 vs 1
			//IL_0110->IL009a: Incompatible stack heights: 3 vs 1
			//IL_01af->IL009a: Incompatible stack heights: 2 vs 1
			//IL_0174->IL009a: Incompatible stack heights: 3 vs 1
			//IL_0120->IL009a: Incompatible stack heights: 3 vs 1
			//IL_01ea->IL009a: Incompatible stack heights: 0 vs 1
			//IL_0197->IL009a: Incompatible stack heights: 3 vs 1
			//IL_01cf->IL009a: Incompatible stack heights: 2 vs 1
			//IL_009a->IL009a: Incompatible stack heights: 2 vs 1
			//IL_02cc->IL009a: Incompatible stack heights: 0 vs 1
			//IL_026a->IL0096: Incompatible stack heights: 0 vs 1
			//IL_01a2->IL009a: Incompatible stack heights: 3 vs 1
			//IL_01da->IL009a: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					case 5:
						break;
					case 1:
						_ = -2;
						_ = 3;
						continue;
					case 2:
						return;
					case 3:
						_ = 2;
						continue;
					case 4:
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							obj2 = 0;
						}
						continue;
					default:
						{
							if (obj == null)
							{
								num = 19;
								goto IL_009a;
							}
							goto IL_0215;
						}
						IL_0215:
						if (obj == null)
						{
							goto case 1;
						}
						num = 15;
						goto IL_009a;
						IL_009a:
						while (true)
						{
							object obj3;
							object obj4;
							switch (num)
							{
							case 3:
							case 5:
							case 12:
								break;
							case 1:
								return;
							case 7:
								obj = -1;
								_ = 4;
								continue;
							case 16:
								_ = null;
								_ = null;
								_ = 12;
								continue;
							case 21:
								obj3 = obj;
								if (obj3 == null)
								{
									num = 9;
									continue;
								}
								if (obj3 == null)
								{
									obj3 = (object)/*Error near IL_02ba: Stack underflow*/;
								}
								goto IL_02bd;
							case 13:
								obj = obj;
								_ = 14;
								continue;
							case 2:
								if (obj == null)
								{
									num = 16;
									continue;
								}
								goto case 21;
							case 20:
								_ = ref obj;
								if (0 == 0)
								{
									_ = 1;
								}
								continue;
							case 10:
								_ = 7;
								continue;
							default:
								_ = 20;
								continue;
							case 22:
								obj = 0;
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							case 18:
							case 19:
								obj = (object)Unsafe.AsPointer(ref this);
								if (10 == 0)
								{
									num = 6;
								}
								continue;
							case 4:
							case 17:
								_ = ref obj;
								obj = 5;
								continue;
							case 6:
								goto IL_0215;
							case 14:
								if (&obj != null)
								{
									obj = 17;
									continue;
								}
								goto case 22;
							case 11:
							case 15:
								obj4 = obj;
								if (obj4 == null)
								{
									num = 8;
									continue;
								}
								if (obj4 == null)
								{
									obj4 = (object)/*Error near IL_0294: Stack underflow*/;
								}
								goto IL_0297;
							case 8:
								obj4 = null;
								goto IL_0297;
							case 9:
								{
									obj3 = null;
									goto IL_02bd;
								}
								IL_0297:
								obj = obj4;
								num = 2;
								continue;
								IL_02bd:
								obj = obj3;
								if (4 == 0)
								{
									num = 13;
								}
								continue;
							}
							break;
						}
						goto case 1;
					}
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
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
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_1400()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00ᔀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777878, new IntPtr(2737335806412L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00ᘀ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ᜀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777879, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_1800(object P_0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0279: Expected Obj, but got Ref
			//IL_004d: Expected Obj, but got Ref
			//IL_01ad: Expected Obj, but got Ref
			//IL_00d5: Expected Obj, but got I4
			//IL_0175: Expected Obj, but got I4
			//IL_0159: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0285->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0059->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0049->IL0019: Incompatible stack heights: 3 vs 1
			//IL_01b7->IL007a: Incompatible stack types: I4 vs Ref
			//IL_0076->IL007a: Incompatible stack types: I4 vs Ref
			//IL_0290->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0064->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0275->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00e0->IL007a: Incompatible stack heights: 3 vs 1
			//IL_013b->IL007a: Incompatible stack heights: 3 vs 1
			//IL_0180->IL007a: Incompatible stack heights: 3 vs 1
			//IL_0165->IL007a: Incompatible stack heights: 2 vs 1
			//IL_00d0->IL007a: Incompatible stack heights: 4 vs 1
			//IL_01a9->IL007a: Incompatible stack types: I4 vs Ref
			//IL_01dd->IL007a: Incompatible stack types: I4 vs Ref
			//IL_0101->IL007a: Incompatible stack types: I4 vs Ref
			//IL_014f->IL007a: Incompatible stack types: I4 vs Ref
			//IL_012d->IL007a: Incompatible stack types: I4 vs Ref
			//IL_0170->IL007a: Incompatible stack heights: 2 vs 1
			//IL_011b->IL007a: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			ref _003CLaunchHeadlessShadowClient_003Ed__9 reference = ref *(_003CLaunchHeadlessShadowClient_003Ed__9*)obj;
			while (true)
			{
				ref byte reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 4u:
					_ = -2;
					_ = 5;
					break;
				case 2u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (true)
					{
						reference = ref *(_003CLaunchHeadlessShadowClient_003Ed__9*)1;
					}
					break;
				default:
					if (obj != null)
					{
						reference2 = ref *(byte*)9;
						goto IL_007a;
					}
					goto IL_01a9;
				case 5u:
					reference = ref this;
					if (false)
					{
						reference = ref *(_003CLaunchHeadlessShadowClient_003Ed__9*)3;
					}
					break;
				case 1u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						reference = ref *(_003CLaunchHeadlessShadowClient_003Ed__9*)null;
					}
					break;
				case 3u:
					return;
					IL_007a:
					while (true)
					{
						object obj2;
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						case 13u:
							_ = ref obj;
							_ = 3;
							continue;
						case 1u:
							obj = -1;
							_ = 2;
							continue;
						case 3u:
							return;
						case 9u:
							if (obj == null)
							{
								reference2 = ref *(byte*)4;
								continue;
							}
							goto case 10u;
						case 14u:
							reference2 = ref Unsafe.As<_003CLaunchHeadlessShadowClient_003Ed__9, byte>(ref this);
							if (true)
							{
								reference2 = ref *(byte*)1;
							}
							continue;
						case 11u:
							if (&obj == null)
							{
								reference2 = ref *(byte*)6;
								continue;
							}
							goto case 2u;
						case 5u:
							_ = 13;
							continue;
						case 10u:
							obj2 = obj;
							if (obj2 == null)
							{
								reference2 = ref *(byte*)7;
								continue;
							}
							if (obj2 == null)
							{
								obj2 = (object)/*Error near IL_01cd: Stack underflow*/;
							}
							goto IL_01d0;
						case 12u:
							obj = 1;
							if (11 == 0)
							{
								_ = 10;
							}
							continue;
						case 6u:
							obj = 0;
							_ = 5;
							continue;
						case 2u:
							reference2 = ref *(byte*)(&obj);
							if (0 == 0)
							{
								reference2 = ref *(byte*)null;
							}
							continue;
						case 8u:
							goto IL_01a9;
						case 7u:
							{
								obj2 = null;
								goto IL_01d0;
							}
							IL_01d0:
							obj = obj2;
							reference2 = ref *(byte*)12;
							continue;
						}
						break;
					}
					goto case 4u;
					IL_01a9:
					obj = (object)Unsafe.AsPointer(ref this);
					reference2 = ref *(byte*)14;
					goto IL_007a;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_0A00()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_0D00()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_0E00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777873, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00ༀ(object P_0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_008f: Expected Obj, but got Ref
			//IL_01fe: Expected Obj, but got I4
			//IL_0136: Expected Obj, but got Ref
			//IL_013f: Expected Obj, but got I4
			//IL_011a: Expected Obj, but got I4
			//IL_01bd: Expected Obj, but got I4
			//IL_00f5: Expected I4, but got Obj
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0080->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0099->IL0019: Incompatible stack types: I4 vs Ref
			//IL_008b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00ac->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0070->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0056->IL0019: Incompatible stack types: I4 vs Ref
			//IL_01ad->IL00b0: Incompatible stack heights: 0 vs 1
			//IL_0230->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_01b8->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_010a->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_0208->IL00b0: Incompatible stack heights: 3 vs 1
			//IL_0181->IL00b0: Incompatible stack heights: 3 vs 1
			//IL_0199->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_01e2->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_0127->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_01ca->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_0115->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_018c->IL00b0: Incompatible stack heights: 3 vs 1
			//IL_01f4->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0253->IL00b0: Incompatible stack heights: 0 vs 1
			//IL_0132->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_01d5->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_025e->IL00b0: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			ref _003CLaunchShadowClient_003Ed__5 reference = ref *(_003CLaunchShadowClient_003Ed__5*)obj;
			while (true)
			{
				object obj2;
				object obj3;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (true)
					{
						reference = ref *(_003CLaunchShadowClient_003Ed__5*)2;
					}
					break;
				case 3u:
					reference = ref this;
					if (true)
					{
						reference = ref *(_003CLaunchShadowClient_003Ed__5*)1;
					}
					break;
				default:
					_ = -2;
					if (3 == 0)
					{
						_ = 3;
					}
					break;
				case 5u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CLaunchShadowClient_003Ed__5*)4;
					break;
				case 1u:
					return;
				case 2u:
					{
						if (obj == null)
						{
							obj2 = 12;
							goto IL_00b0;
						}
						goto IL_0199;
					}
					IL_0230:
					obj3 = null;
					goto IL_0244;
					IL_0199:
					if (obj == null)
					{
						if (8 != 0)
						{
							obj2 = 7;
						}
						goto IL_00b0;
					}
					goto IL_0217;
					IL_0244:
					obj = obj3;
					if (0 == 0)
					{
						obj2 = 1;
					}
					goto IL_00b0;
					IL_0217:
					obj3 = obj;
					if (obj3 == null)
					{
						obj2 = 9;
						goto IL_00b0;
					}
					if (obj3 == null)
					{
						obj3 = (object)/*Error near IL_0241: Stack underflow*/;
					}
					goto IL_0244;
					IL_00b0:
					while (true)
					{
						switch ((int)obj2)
						{
						case 8:
						case 11:
							break;
						case 15:
							return;
						default:
							if (2 == 0)
							{
								_ = 0;
							}
							continue;
						case 10:
							obj = -1;
							if (7 == 0)
							{
								_ = 6;
							}
							continue;
						case 3:
						case 12:
							obj = (object)Unsafe.AsPointer(ref this);
							obj = 4;
							obj2 = obj;
							continue;
						case 2:
							_ = ref obj;
							if (14 != 0)
							{
								_ = 15;
							}
							continue;
						case 4:
							_ = 10;
							continue;
						case 13:
							goto IL_0199;
						case 14:
							obj = 0;
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 7:
							_ = ref obj;
							_ = 11;
							continue;
						case 6:
							if (&obj == null)
							{
								obj2 = 14;
								continue;
							}
							goto case 7;
						case 1:
							obj = 0;
							_ = 6;
							continue;
						case 5:
							goto IL_0217;
						case 9:
							goto IL_0230;
						}
						break;
					}
					goto default;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_0300()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00Ѐ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777885, new IntPtr(2737335823052L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00Ԁ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_0600(object P_0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_02a0: Expected Obj, but got Ref
			//IL_0292: Expected Obj, but got Ref
			//IL_01da: Expected Obj, but got I4
			//IL_01af: Expected Obj, but got Ref
			//IL_00f4: Expected Obj, but got I4
			//IL_01a0: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_02ac->IL0019: Incompatible stack heights: 0 vs 1
			//IL_029c->IL0019: Incompatible stack types: I4 vs Ref
			//IL_004c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0083->IL0087: Incompatible stack types: I4 vs Ref
			//IL_0071->IL0019: Incompatible stack types: I4 vs Ref
			//IL_02b7->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0057->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0144->IL0087: Incompatible stack heights: 0 vs 1
			//IL_014f->IL0087: Incompatible stack types: I4 vs Ref
			//IL_01e7->IL0087: Incompatible stack heights: 2 vs 1
			//IL_01b9->IL0087: Incompatible stack types: I4 vs Ref
			//IL_0190->IL0087: Incompatible stack heights: 0 vs 1
			//IL_010b->IL0087: Incompatible stack heights: 3 vs 1
			//IL_01ab->IL0087: Incompatible stack heights: 3 vs 1
			//IL_01f2->IL0087: Incompatible stack heights: 2 vs 1
			//IL_019b->IL0087: Incompatible stack types: I4 vs Ref
			//IL_0130->IL0087: Incompatible stack types: I4 vs Ref
			//IL_0087->IL0087: Incompatible stack heights: 3 vs 1
			//IL_00e7->IL0087: Incompatible stack types: I4 vs Ref
			//IL_0163->IL0087: Incompatible stack heights: 0 vs 1
			//IL_0116->IL0087: Incompatible stack heights: 3 vs 1
			//IL_016e->IL0087: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			ref _003COpenGameResourceFolder_003Ed__4 reference = ref *(_003COpenGameResourceFolder_003Ed__4*)obj;
			while (true)
			{
				ref byte reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 4u:
					return;
				case 5u:
					_ = -2;
					if (false)
					{
						_ = 1;
					}
					break;
				case 1u:
					reference = ref this;
					if (3 != 0)
					{
						reference = ref *(_003COpenGameResourceFolder_003Ed__4*)4;
					}
					break;
				default:
					if (obj == null)
					{
						reference2 = ref *(byte*)5;
						goto IL_0087;
					}
					goto IL_0130;
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003COpenGameResourceFolder_003Ed__4*)2;
					break;
				case 2u:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							reference = ref *(_003COpenGameResourceFolder_003Ed__4*)null;
						}
						break;
					}
					IL_0087:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						case 1u:
							return;
						case 4u:
						case 7u:
							break;
						case 11u:
							reference2 = ref Unsafe.As<_003COpenGameResourceFolder_003Ed__4, byte>(ref this);
							if (14 != 0)
							{
								reference2 = ref *(byte*)10;
							}
							continue;
						case 10u:
							obj = 13;
							continue;
						case 13u:
							_ = ref obj;
							if (1 == 0)
							{
								_ = 1;
							}
							continue;
						case 9u:
							reference2 = ref *(byte*)(&obj);
							if (7 != 0)
							{
								reference2 = ref *(byte*)7;
							}
							continue;
						case 8u:
							goto IL_0130;
						case 12u:
							if (&obj == null)
							{
								if (0 == 0)
								{
									reference2 = ref *(byte*)null;
								}
								continue;
							}
							goto case 9u;
						case 3u:
						case 6u:
							obj = obj;
							if (3 != 0)
							{
								reference2 = ref *(byte*)12;
							}
							continue;
						case 14u:
							obj = -1;
							_ = 9;
							continue;
						case 2u:
						case 5u:
							obj = (object)Unsafe.AsPointer(ref this);
							reference2 = ref *(byte*)11;
							continue;
						default:
							obj = 0;
							if (10 == 0)
							{
								_ = 10;
							}
							continue;
						}
						break;
					}
					goto case 5u;
					IL_0130:
					if (obj != null)
					{
						if (4 == 0)
						{
							reference2 = ref *(byte*)6;
						}
						goto IL_0087;
					}
					goto case 5u;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00切()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00ﬀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777880, new IntPtr(2737335801212L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00ﰀ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00ﴀ(object P_0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_03b1: Expected Obj, but got Ref
			//IL_0396: Expected Obj, but got Ref
			//IL_028d: Expected Obj, but got Ref
			//IL_01d2: Expected Obj, but got Ref
			//IL_0168: Expected Obj, but got I4
			//IL_02c6: Expected Obj, but got I4
			//IL_025d: Expected Obj, but got I4
			//IL_0139: Expected Obj, but got I4
			//IL_012f: Expected Obj, but got I4
			//IL_0253: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_03bb->IL0019: Incompatible stack types: I4 vs Ref
			//IL_03a2->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0387->IL0019: Incompatible stack heights: 2 vs 1
			//IL_03d6->IL0019: Incompatible stack types: I4 vs Ref
			//IL_03ad->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0392->IL0019: Incompatible stack heights: 2 vs 1
			//IL_02a4->IL005e: Incompatible stack heights: 1 vs 0
			//IL_005a->IL005e: Incompatible stack heights: 1 vs 0
			//IL_01ce->IL005e: Incompatible stack heights: 2 vs 0
			//IL_02b6->IL005e: Incompatible stack heights: 3 vs 0
			//IL_02ed->IL005e: Incompatible stack heights: 1 vs 0
			//IL_01b6->IL005e: Incompatible stack heights: 1 vs 0
			//IL_0175->IL005e: Incompatible stack heights: 2 vs 0
			//IL_0123->IL005e: Incompatible stack heights: 3 vs 0
			//IL_02d3->IL005e: Incompatible stack heights: 2 vs 0
			//IL_0190->IL005e: Incompatible stack heights: 4 vs 0
			//IL_0268->IL005e: Incompatible stack heights: 3 vs 0
			//IL_0306->IL005e: Incompatible stack heights: 3 vs 0
			//IL_0146->IL005e: Incompatible stack heights: 2 vs 0
			//IL_01f6->IL005e: Incompatible stack heights: 2 vs 0
			//IL_01a2->IL005e: Incompatible stack heights: 2 vs 0
			//IL_0106->IL005e: Incompatible stack heights: 1 vs 0
			//IL_0233->IL005e: Incompatible stack heights: 1 vs 0
			//IL_02c1->IL005e: Incompatible stack heights: 3 vs 0
			//IL_02f8->IL005e: Incompatible stack heights: 1 vs 0
			//IL_01c1->IL005e: Incompatible stack heights: 1 vs 0
			//IL_01e9->IL005e: Incompatible stack heights: 1 vs 0
			//IL_0258->IL005a: Incompatible stack heights: 0 vs 1
			//IL_0163->IL005e: Incompatible stack heights: 1 vs 0
			//IL_0289->IL005e: Incompatible stack heights: 1 vs 0
			//IL_0180->IL005e: Incompatible stack heights: 2 vs 0
			//IL_02de->IL005e: Incompatible stack heights: 2 vs 0
			//IL_0151->IL005e: Incompatible stack heights: 2 vs 0
			//IL_005e->IL005e: Incompatible stack heights: 2 vs 0
			//IL_00f7->IL005e: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			ref _003CRefreshGame_003Ed__35 reference = ref *(_003CRefreshGame_003Ed__35*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 5u:
					if (obj != null)
					{
						if (0 == 0)
						{
							_ = 0;
						}
						goto IL_005e;
					}
					goto IL_0289;
				case 4u:
					goto IL_0377;
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 == 0)
					{
						reference = ref *(_003CRefreshGame_003Ed__35*)2;
					}
					break;
				case 2u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CRefreshGame_003Ed__35*)5;
					break;
				case 1u:
					return;
				default:
					{
						reference = ref this;
						if (1 == 0)
						{
							reference = ref *(_003CRefreshGame_003Ed__35*)null;
						}
						break;
					}
					IL_005e:
					while (true)
					{
						switch ((int)/*Error near IL_00d3: Stack underflow*/)
						{
						case 14:
							if ((nint)obj != 3)
							{
								if (6 != 0)
								{
									_ = 3;
								}
								continue;
							}
							goto case 24;
						case 27:
							obj = obj;
							_ = 14;
							continue;
						case 16:
							_ = 2;
							continue;
						case 25:
						case 26:
							_ = ref obj;
							obj = 7;
							continue;
						case 21:
							obj = 1;
							if (4 == 0)
							{
								_ = 16;
							}
							continue;
						case 9:
							if (&obj != null)
							{
								_ = 26;
								continue;
							}
							goto case 19;
						case 15:
							obj = -1;
							if (11 == 0)
							{
								_ = 25;
							}
							continue;
						case 18:
							_ = ref obj;
							_ = 13;
							continue;
						case 24:
							obj = null;
							_ = 9;
							continue;
						case 4:
							obj = null;
							if (6 == 0)
							{
								_ = 11;
							}
							continue;
						case 1:
							_ = 15;
							continue;
						case 5:
							obj = (object)Unsafe.AsPointer(ref this);
							if (3 == 0)
							{
								_ = 3;
							}
							continue;
						case 22:
							_ = ref obj;
							_ = 8;
							continue;
						case 13:
							return;
						case 23:
							return;
						default:
							if ((nint)obj != 1)
							{
								_ = 27;
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
							_ = 20;
							continue;
						case 11:
							if (&obj == null)
							{
								_ = 21;
								continue;
							}
							goto case 22;
						case 12:
							break;
						case 2:
							_ = ref obj;
							if (23 == 0)
							{
								_ = 23;
							}
							continue;
						case 17:
							obj = -1;
							if (12 == 0)
							{
								_ = 22;
							}
							continue;
						case 3:
							if (17 == 0)
							{
								_ = 1;
							}
							continue;
						case 20:
							_ = 18;
							continue;
						case 7:
						case 8:
						case 10:
							goto IL_0377;
						}
						break;
					}
					goto IL_0289;
					IL_0289:
					obj = (object)Unsafe.AsPointer(ref this);
					if (true)
					{
						_ = 1;
					}
					goto IL_005e;
					IL_0377:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00_F000()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
		internal static object _FF00_FF00_FF00_FF00_FF00_F300()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
		private sealed void _FF00_FF00_FF00_FF00_FF00_F600(object P_0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0083: Expected Obj, but got Ref
			//IL_004c: Expected Obj, but got Ref
			//IL_04fd: Expected Obj, but got I4
			//IL_025a: Expected Obj, but got Ref
			//IL_03a9: Expected Obj, but got I4
			//IL_03b3: Expected Obj, but got I4
			//IL_0276: Expected Obj, but got I4
			//IL_032a: Expected Obj, but got I4
			//IL_024c: Expected Obj, but got I4
			//IL_02d2: Expected Obj, but got Ref
			//IL_035f: Expected Obj, but got Ref
			//IL_03de: Expected Obj, but got Ref
			//IL_036e: Expected Obj, but got I4
			//IL_0048->IL0019: Incompatible stack heights: 2 vs 1
			//IL_008d->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0058->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0074->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0019: Incompatible stack types: I4 vs Obj
			//IL_007f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00a2->IL00b1: Incompatible stack heights: 0 vs 1
			//IL_04dd->IL00b1: Incompatible stack heights: 0 vs 1
			//IL_0127->IL00b1: Incompatible stack heights: 2 vs 1
			//IL_0119->IL00b1: Incompatible stack heights: 3 vs 1
			//IL_00fe->IL00b1: Incompatible stack heights: 2 vs 1
			//IL_013c->IL00b1: Incompatible stack heights: 0 vs 1
			//IL_0109->IL00b1: Incompatible stack heights: 2 vs 1
			//IL_0271->IL016a: Incompatible stack heights: 1 vs 0
			//IL_0166->IL016a: Incompatible stack heights: 1 vs 0
			//IL_0540->IL00b1: Incompatible stack heights: 2 vs 1
			//IL_0533->IL0533: Incompatible stack heights: 1 vs 2
			//IL_0281->IL016a: Incompatible stack heights: 3 vs 0
			//IL_0335->IL016a: Incompatible stack heights: 3 vs 0
			//IL_0325->IL016a: Incompatible stack heights: 2 vs 0
			//IL_0256->IL016a: Incompatible stack heights: 1 vs 0
			//IL_0218->IL016a: Incompatible stack heights: 2 vs 0
			//IL_0369->IL016a: Incompatible stack heights: 1 vs 0
			//IL_028f->IL016a: Incompatible stack heights: 2 vs 0
			//IL_0245->IL016a: Incompatible stack heights: 4 vs 0
			//IL_03c8->IL016a: Incompatible stack heights: 3 vs 0
			//IL_03d9->IL016a: Incompatible stack heights: 2 vs 0
			//IL_02a1->IL016a: Incompatible stack heights: 1 vs 0
			//IL_03e8->IL016a: Incompatible stack heights: 1 vs 0
			//IL_03f8->IL016a: Incompatible stack heights: 4 vs 0
			//IL_02ce->IL016a: Incompatible stack heights: 3 vs 0
			//IL_02c0->IL016a: Incompatible stack heights: 2 vs 0
			//IL_0379->IL016a: Incompatible stack heights: 3 vs 0
			//IL_054b->IL00b1: Incompatible stack heights: 2 vs 1
			//IL_016a->IL016a: Incompatible stack heights: 3 vs 0
			//IL_02e9->IL016a: Incompatible stack heights: 1 vs 0
			//IL_035a->IL016a: Incompatible stack heights: 1 vs 0
			//IL_0223->IL016a: Incompatible stack heights: 2 vs 0
			//IL_0235->IL016a: Incompatible stack heights: 1 vs 0
			//IL_0348->IL016a: Incompatible stack heights: 1 vs 0
			//IL_02b3->IL016a: Incompatible stack heights: 1 vs 0
			//IL_0427->IL016a: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					_ = 4;
					break;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 1;
					}
					break;
				case 4:
					return;
				case 3:
					_ = -2;
					if (false)
					{
						_ = 0;
					}
					break;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 5;
					break;
				case 5:
					{
						if ((nuint)(nint)obj > (nuint)1u)
						{
							if (2 == 0)
							{
								num = 0;
							}
							goto IL_00b1;
						}
						goto IL_00e3;
					}
					IL_00e3:
					num = 4;
					goto IL_00b1;
					IL_00b1:
					while (true)
					{
						switch (num)
						{
						case 5:
							goto IL_00e3;
						case 8:
							_ = 1;
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 6:
							_ = 3;
							continue;
						case 3:
							_ = 5;
							continue;
						case 7:
							if (obj == null)
							{
								if (9 != 0)
								{
									num = 4;
								}
								continue;
							}
							goto case 8;
						case 4:
							if (obj != null)
							{
								if (20 == 0)
								{
									_ = 28;
								}
								goto IL_016a;
							}
							goto IL_0256;
						case 2:
							if (1 == 0)
							{
								num = 0;
							}
							continue;
						case 1:
						{
							num = 0;
							int num2 = 11;
							if (num2 == 0)
							{
								num2 = num;
							}
							obj = num2;
							if (6 == 0)
							{
								num = 3;
							}
							continue;
						}
						case 9:
							{
								if (obj != null)
								{
								}
								if (6 == 0)
								{
									_ = 8;
								}
								continue;
							}
							IL_0256:
							obj = (object)Unsafe.AsPointer(ref this);
							if (4 != 0)
							{
								_ = 4;
							}
							goto IL_016a;
							IL_016a:
							while (true)
							{
								switch ((int)/*Error near IL_01e7: Stack underflow*/)
								{
								case 12:
									return;
								case 18:
									return;
								case 25:
									break;
								case 8:
									if (8 == 0)
									{
										_ = 13;
									}
									continue;
								case 16:
									if (&obj != null)
									{
										_ = 2;
										continue;
									}
									goto default;
								case 13:
									_ = ref obj;
									_ = 12;
									continue;
								case 5:
									obj = 50;
									_ = 7;
									continue;
								case 19:
									goto IL_0256;
								case 1:
									obj = 0;
									_ = 8;
									continue;
								case 10:
									_ = 17;
									continue;
								case 20:
									obj = obj;
									_ = 16;
									continue;
								case 28:
									if ((nint)obj != 1)
									{
										_ = 22;
										continue;
									}
									goto case 6;
								case 26:
									_ = 29;
									continue;
								case 24:
									_ = 23;
									continue;
								case 6:
									obj = (object)Unsafe.AsPointer(ref this);
									if (26 != 0)
									{
										_ = 10;
									}
									continue;
								case 4:
									_ = 3;
									continue;
								case 3:
									obj = -1;
									_ = 9;
									continue;
								case 22:
									if (obj != null)
									{
										_ = 5;
										continue;
									}
									goto case 20;
								case 7:
									if (&obj != null)
									{
										_ = 11;
										continue;
									}
									goto case 1;
								case 9:
								case 11:
									obj = (object)(&obj);
									_ = 14;
									continue;
								case 29:
									obj = -1;
									_ = 21;
									continue;
								default:
									obj = 1;
									obj = 24;
									continue;
								case 15:
									_ = 10;
									continue;
								case 17:
									_ = 25;
									continue;
								case 2:
								case 21:
									obj = (object)(&obj);
									_ = 27;
									continue;
								case 23:
									_ = ref obj;
									_ = 18;
									continue;
								case 14:
								case 27:
									obj = obj ?? ((object)/*Error near IL_040a: Stack underflow*/);
									if (11 == 0)
									{
										_ = 15;
									}
									continue;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00_E800()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_E900()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
		private sealed void _FF00_FF00_FF00_FF00_FF00_EC00(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0059: Expected Obj, but got Ref
			//IL_0067: Expected Obj, but got Ref
			//IL_008b: Expected Obj, but got I4
			//IL_05c2: Expected Obj, but got I4
			//IL_036a: Expected Obj, but got Ref
			//IL_00f8: Expected I4, but got Obj
			//IL_0597: Expected Obj, but got I4
			//IL_0246: Expected Obj, but got I4
			//IL_02e1: Expected Obj, but got Ref
			//IL_034b: Expected Obj, but got Ref
			//IL_0361: Expected Obj, but got I4
			//IL_0263: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0063->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0073->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0090->IL0015: Incompatible stack heights: 2 vs 0
			//IL_007e->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00a3->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_0055->IL0019: Incompatible stack types: I4 vs Ref
			//IL_010a->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_017e->IL00a7: Incompatible stack heights: 0 vs 1
			//IL_0189->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_0134->IL00a7: Incompatible stack heights: 2 vs 1
			//IL_0509->IL00a7: Incompatible stack heights: 2 vs 1
			//IL_0578->IL00a7: Incompatible stack heights: 2 vs 1
			//IL_0541->IL00a7: Incompatible stack heights: 3 vs 1
			//IL_054c->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_0142->IL00a7: Incompatible stack heights: 2 vs 1
			//IL_0526->IL00a7: Incompatible stack heights: 2 vs 1
			//IL_05cc->IL00a7: Incompatible stack heights: 2 vs 1
			//IL_0514->IL00a7: Incompatible stack heights: 2 vs 1
			//IL_0583->IL00a7: Incompatible stack heights: 2 vs 1
			//IL_019c->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_015d->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_05a3->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_0531->IL00a7: Incompatible stack heights: 2 vs 1
			//IL_05f6->IL00a7: Incompatible stack heights: 3 vs 1
			//IL_05eb->IL05eb: Incompatible stack heights: 1 vs 2
			//IL_0381->IL01bf: Incompatible stack heights: 1 vs 0
			//IL_01bb->IL01bf: Incompatible stack heights: 1 vs 0
			//IL_05ae->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_030a->IL01bf: Incompatible stack heights: 1 vs 0
			//IL_0336->IL01bf: Incompatible stack heights: 2 vs 0
			//IL_0253->IL01bf: Incompatible stack heights: 2 vs 0
			//IL_03d0->IL01bf: Incompatible stack heights: 3 vs 0
			//IL_02eb->IL01bf: Incompatible stack heights: 1 vs 0
			//IL_03c2->IL01bf: Incompatible stack heights: 2 vs 0
			//IL_0355->IL01bf: Incompatible stack heights: 2 vs 0
			//IL_0395->IL01bf: Incompatible stack heights: 2 vs 0
			//IL_026e->IL01bf: Incompatible stack heights: 3 vs 0
			//IL_0326->IL01bf: Incompatible stack heights: 3 vs 0
			//IL_027f->IL01bf: Incompatible stack heights: 2 vs 0
			//IL_02ad->IL01bf: Incompatible stack heights: 3 vs 0
			//IL_02ba->IL01bf: Incompatible stack heights: 2 vs 0
			//IL_02fb->IL01bf: Incompatible stack heights: 4 vs 0
			//IL_0315->IL01bf: Incompatible stack heights: 1 vs 0
			//IL_0341->IL01bf: Incompatible stack heights: 2 vs 0
			//IL_025e->IL01bf: Incompatible stack heights: 2 vs 0
			//IL_03ec->IL01bf: Incompatible stack heights: 1 vs 0
			//IL_0241->IL01bf: Incompatible stack heights: 1 vs 0
			//IL_01bf->IL01bf: Incompatible stack heights: 3 vs 0
			//IL_02cd->IL01bf: Incompatible stack heights: 1 vs 0
			//IL_03b4->IL01bf: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			while (true)
			{
				ref _003CRefreshNetGames_003Ed__67 reference = ref *(_003CRefreshNetGames_003Ed__67*)obj;
				while (true)
				{
					object obj2;
					switch ((uint)Unsafe.AsPointer(ref reference))
					{
					case 5u:
						reference = ref this;
						if (2 != 0)
						{
							reference = ref *(_003CRefreshNetGames_003Ed__67*)null;
						}
						continue;
					default:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(_003CRefreshNetGames_003Ed__67*)4;
						continue;
					case 1u:
						obj = (object)Unsafe.AsPointer(ref this);
						if (false)
						{
							reference = ref *(_003CRefreshNetGames_003Ed__67*)null;
						}
						continue;
					case 3u:
						break;
					case 2u:
						return;
					case 4u:
						{
							if (obj == null)
							{
								obj2 = 16;
								goto IL_00a7;
							}
							goto IL_016c;
						}
						IL_016c:
						if ((int)/*Error near IL_0172: Stack underflow*/ == 0)
						{
							if (10 == 0)
							{
								obj2 = 11;
							}
							goto IL_00a7;
						}
						goto IL_00fd;
						IL_00fd:
						obj2 = 17;
						goto IL_00a7;
						IL_00a7:
						while (true)
						{
							switch ((int)obj2)
							{
							case 4:
								goto end_IL_00a7;
							case 2:
								_ = 12;
								continue;
							case 15:
								_ = 2;
								continue;
							case 12:
								obj2 = obj;
								if (13 == 0)
								{
									obj2 = 7;
								}
								continue;
							case 14:
								goto IL_016c;
							case 9:
								if (obj != null)
								{
									obj2 = 7;
									continue;
								}
								goto case 1;
							case 5:
								if (obj != null)
								{
									if (1 == 0)
									{
										_ = 1;
									}
									goto IL_01bf;
								}
								goto IL_0366;
							case 6:
								if (10 != 0)
								{
									_ = 4;
								}
								continue;
							case 18:
								if (6 == 0)
								{
									_ = 2;
								}
								continue;
							case 10:
								_ = 15;
								continue;
							case 13:
							case 16:
								obj2 = 5;
								continue;
							case 7:
							case 8:
								_ = 1;
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							case 17:
							{
								int num2 = 8;
								if (num2 == 0)
								{
									num2 = 0;
								}
								obj = num2;
								obj2 = 0;
								if (2 == 0)
								{
									obj2 = 3;
								}
								continue;
							}
							case 3:
							{
								int num = 4;
								if (num == 0)
								{
									num = 0;
								}
								obj = num;
								_ = 18;
								continue;
							}
							case 1:
								{
									if (obj != null)
									{
									}
									_ = 8;
									continue;
								}
								IL_0366:
								obj = (object)Unsafe.AsPointer(ref this);
								if (20 != 0)
								{
									_ = 9;
								}
								goto IL_01bf;
								IL_01bf:
								while (true)
								{
									switch ((int)/*Error near IL_0220: Stack underflow*/)
									{
									case 10:
										return;
									case 2:
										break;
									case 14:
										obj = (object)/*Error near IL_022a: Stack underflow*/;
										if (false)
										{
											_ = 0;
										}
										continue;
									case 4:
										obj = -1;
										if (7 == 0)
										{
											_ = 3;
										}
										continue;
									case 16:
										obj = 0;
										_ = 5;
										continue;
									case 18:
										_ = 3;
										continue;
									case 19:
										((int[])2)[0] = 100000000;
										((int[])2)[1] = 200000000;
										_ = 14;
										continue;
									case 20:
										_ = 4;
										continue;
									case 22:
										if (obj == null)
										{
											_ = 13;
											continue;
										}
										goto case 12;
									case 7:
									case 11:
										obj = (object)(&obj);
										_ = 9;
										continue;
									case 21:
										_ = ref obj;
										_ = 10;
										continue;
									case 1:
										if (5 == 0)
										{
											_ = 19;
										}
										continue;
									case 17:
										_ = 8;
										continue;
									case 3:
										_ = 0;
										if (6 == 0)
										{
											_ = 15;
										}
										continue;
									case 9:
										obj = (object)Unsafe.AsPointer(ref this);
										_ = 22;
										continue;
									case 15:
										_ = null;
										obj = 2;
										continue;
									case 6:
										goto IL_0366;
									case 13:
										obj = obj;
										_ = 12;
										continue;
									default:
										if (&obj != null)
										{
											if (11 != 0)
											{
												_ = 4;
											}
											continue;
										}
										goto case 16;
									case 8:
										_ = 18;
										continue;
									case 5:
										_ = 21;
										continue;
									case 12:
										obj = obj ?? ((object)/*Error near IL_03dd: Stack underflow*/);
										_ = 17;
										continue;
									}
									break;
								}
								goto case 9;
							}
							goto end_IL_0019;
							continue;
							end_IL_00a7:
							break;
						}
						goto IL_00fd;
						end_IL_0019:
						break;
					}
					break;
				}
				_ = -2;
				obj = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777965, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777962, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FFFD(object P_0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_047f: Expected Obj, but got Ref
			//IL_042e: Expected Obj, but got Ref
			//IL_0168: Expected Obj, but got Ref
			//IL_036b: Expected Obj, but got I4
			//IL_01e5: Expected Obj, but got I4
			//IL_01be: Expected Obj, but got I4
			//IL_01c8: Expected Obj, but got I4
			//IL_0216: Expected Obj, but got Ref
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0470->IL0019: Incompatible stack heights: 2 vs 1
			//IL_048b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_043a->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004d->IL0051: Incompatible stack heights: 1 vs 0
			//IL_047b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0496->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0445->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0460->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0335->IL0051: Incompatible stack heights: 1 vs 0
			//IL_00b2->IL0051: Incompatible stack heights: 1 vs 0
			//IL_02f3->IL0051: Incompatible stack heights: 1 vs 0
			//IL_0343->IL0051: Incompatible stack heights: 3 vs 0
			//IL_0310->IL0051: Incompatible stack heights: 2 vs 0
			//IL_02fe->IL0051: Incompatible stack heights: 1 vs 0
			//IL_0377->IL0051: Incompatible stack heights: 1 vs 0
			//IL_031b->IL0051: Incompatible stack heights: 2 vs 0
			//IL_0356->IL0051: Incompatible stack heights: 1 vs 0
			//IL_03ac->IL0051: Incompatible stack heights: 3 vs 0
			//IL_03a1->IL03a1: Incompatible stack heights: 1 vs 2
			//IL_0382->IL0051: Incompatible stack heights: 1 vs 0
			//IL_0118->IL00c8: Incompatible stack heights: 3 vs 1
			//IL_01f2->IL00c8: Incompatible stack heights: 2 vs 1
			//IL_0126->IL00c8: Incompatible stack heights: 2 vs 1
			//IL_0191->IL00c8: Incompatible stack heights: 2 vs 1
			//IL_01a3->IL00c8: Incompatible stack heights: 2 vs 1
			//IL_0159->IL00c8: Incompatible stack heights: 3 vs 1
			//IL_01d5->IL00c8: Incompatible stack heights: 2 vs 1
			//IL_01fd->IL00c8: Incompatible stack heights: 2 vs 1
			//IL_01ae->IL00c8: Incompatible stack heights: 2 vs 1
			//IL_00c8->IL00c8: Incompatible stack heights: 2 vs 1
			//IL_0164->IL00c8: Incompatible stack heights: 3 vs 1
			//IL_01e0->IL00c8: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			ref _003CRefreshRentalGame_003Ed__79 reference = ref *(_003CRefreshRentalGame_003Ed__79*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					if (obj == null)
					{
						_ = 9;
						goto IL_0051;
					}
					goto IL_031b;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (3 == 0)
					{
						reference = ref *(_003CRefreshRentalGame_003Ed__79*)null;
					}
					break;
				case 1u:
					return;
				case 5u:
					reference = ref this;
					if (true)
					{
						reference = ref *(_003CRefreshRentalGame_003Ed__79*)1;
					}
					break;
				case 2u:
					goto IL_0460;
				case 3u:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (false)
						{
							reference = ref *(_003CRefreshRentalGame_003Ed__79*)null;
						}
						break;
					}
					IL_0051:
					while (true)
					{
						int num2;
						switch ((int)/*Error near IL_0086: Stack underflow*/)
						{
						default:
							_ = 2;
							continue;
						case 2:
							if (obj != null)
							{
								num2 = 12;
								goto IL_00c8;
							}
							goto IL_0164;
						case 1:
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 8:
							if (0 == 0)
							{
								_ = 1;
							}
							continue;
						case 5:
							break;
						case 3:
						case 6:
							_ = 1;
							_ = 10;
							continue;
						case 11:
							goto IL_0343;
						case 7:
						{
							int num = 10;
							if (num == 0)
							{
								num = 0;
							}
							obj = num;
							if (4 != 0)
							{
								_ = 8;
							}
							continue;
						}
						case 4:
							if (obj != null)
							{
							}
							_ = 3;
							continue;
						case 10:
							goto IL_0460;
							IL_0164:
							obj = (object)Unsafe.AsPointer(ref this);
							num2 = 6;
							goto IL_00c8;
							IL_00c8:
							while (true)
							{
								switch (num2)
								{
								case 1:
									_ = 11;
									continue;
								case 4:
									_ = 9;
									continue;
								case 10:
									if (&obj == null)
									{
										num2 = 2;
										continue;
									}
									goto default;
								case 5:
									return;
								case 11:
									_ = ref obj;
									if (4 == 0)
									{
										_ = 5;
									}
									continue;
								case 3:
									break;
								case 12:
									obj = obj;
									num2 = 10;
									continue;
								case 6:
									_ = 13;
									continue;
								case 7:
									if (4 == 0)
									{
										_ = 3;
									}
									continue;
								case 9:
									obj = 8;
									continue;
								case 13:
									obj = -1;
									if (false)
									{
										_ = 0;
									}
									continue;
								case 2:
									obj = 0;
									if (true)
									{
										_ = 1;
									}
									continue;
								default:
								{
									ref object reference2 = ref obj;
									if (Unsafe.AsPointer(ref reference2) == null)
									{
										reference2 = ref *(object*)/*Error near IL_0210: Stack underflow*/;
									}
									obj = (object)Unsafe.AsPointer(ref reference2);
									num2 = 7;
									continue;
								}
								case 8:
									goto IL_0343;
								}
								break;
							}
							goto IL_0164;
							IL_0343:
							if (obj != null)
							{
								_ = 6;
								continue;
							}
							goto case 4;
						}
						break;
					}
					goto IL_031b;
					IL_031b:
					if (3 == 0)
					{
						_ = 7;
					}
					goto IL_0051;
					IL_0460:
					_ = -2;
					if (4 == 0)
					{
						_ = 5;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00츀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
		internal static object _FF00_FF00_FF00_FF00_FF00턀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
		private sealed void _FF00_FF00_FF00_FF00_FF00퐀(object P_0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_005a: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_0155: Expected I4, but got Obj
			//IL_00d0: Expected I4, but got Obj
			//IL_0561: Expected Obj, but got Ref
			//IL_0284: Expected Obj, but got Ref
			//IL_028d: Expected Obj, but got I4
			//IL_035f: Expected Obj, but got Ref
			//IL_03df: Expected Obj, but got Ref
			//IL_0529: Expected Obj, but got I4
			//IL_036e: Expected Obj, but got Ref
			//IL_0570: Expected Obj, but got I4
			//IL_030a: Expected Obj, but got I4
			//IL_038b: Expected Obj, but got I4
			//IL_0276: Expected Obj, but got Ref
			//IL_03ee: Expected Obj, but got Ref
			//IL_02ee: Expected Obj, but got Ref
			//IL_059c: Invalid comparison between Ref and Obj
			//IL_0698: Expected Obj, but got I4
			//IL_03aa: Expected Obj, but got Ref
			//IL_0327: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_007f->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0066->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_00f3->IL00a3: Incompatible stack types: I4 vs Obj
			//IL_0094->IL00a3: Incompatible stack heights: 0 vs 2
			//IL_0071->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0056->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0854->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00d0->IL00e3: Incompatible stack heights: 1 vs 0
			//IL_009f->IL00a3: Incompatible stack heights: 1 vs 2
			//IL_0121->IL00a3: Incompatible stack heights: 4 vs 2
			//IL_00e3->IL00a3: Incompatible stack heights: 4 vs 2
			//IL_0780->IL00a3: Incompatible stack types: I4 vs Obj
			//IL_0136->IL00a3: Incompatible stack heights: 1 vs 2
			//IL_010e->IL00a3: Incompatible stack types: I4 vs Obj
			//IL_056b->IL0163: Incompatible stack types: I4 vs Ref
			//IL_0369->IL0163: Incompatible stack types: I4 vs Ref
			//IL_015f->IL0163: Incompatible stack types: I4 vs Ref
			//IL_0141->IL00a3: Incompatible stack heights: 1 vs 2
			//IL_07c9->IL00a3: Incompatible stack heights: 3 vs 2
			//IL_07b3->IL07be: Incompatible stack heights: 3 vs 2
			//IL_0163->IL0163: Incompatible stack types: Obj vs Ref
			//IL_03e9->IL0163: Incompatible stack heights: 3 vs 2
			//IL_0536->IL0163: Incompatible stack heights: 3 vs 2
			//IL_04de->IL0163: Incompatible stack types: I4 vs Ref
			//IL_0624->IL0163: Incompatible stack heights: 5 vs 2
			//IL_0436->IL0163: Incompatible stack heights: 3 vs 2
			//IL_0378->IL0163: Incompatible stack types: I4 vs Ref
			//IL_0477->IL0163: Incompatible stack heights: 3 vs 2
			//IL_06c6->IL0163: Incompatible stack heights: 3 vs 2
			//IL_057b->IL0163: Incompatible stack heights: 4 vs 2
			//IL_02be->IL0163: Incompatible stack heights: 3 vs 2
			//IL_0317->IL0163: Incompatible stack heights: 3 vs 2
			//IL_0396->IL0163: Incompatible stack heights: 4 vs 2
			//IL_0280->IL0163: Incompatible stack types: I4 vs Ref
			//IL_03fa->IL0163: Incompatible stack heights: 1 vs 2
			//IL_0469->IL0163: Incompatible stack types: I4 vs Ref
			//IL_0632->IL0163: Incompatible stack heights: 4 vs 2
			//IL_04f0->IL0163: Incompatible stack heights: 4 vs 2
			//IL_02fa->IL0163: Incompatible stack heights: 1 vs 2
			//IL_0552->IL0163: Incompatible stack heights: 3 vs 2
			//IL_04b9->IL05b8: Incompatible stack heights: 2 vs 1
			//IL_06f3->IL00f3: Incompatible stack heights: 0 vs 1
			//IL_06a5->IL0163: Incompatible stack heights: 3 vs 2
			//IL_05c6->IL0163: Incompatible stack heights: 4 vs 2
			//IL_0386->IL0163: Incompatible stack heights: 4 vs 2
			//IL_05f2->IL0163: Incompatible stack heights: 4 vs 2
			//IL_0674->IL0163: Incompatible stack heights: 4 vs 2
			//IL_03b6->IL0163: Incompatible stack heights: 1 vs 2
			//IL_0334->IL0163: Incompatible stack heights: 3 vs 2
			//IL_0262->IL0163: Incompatible stack heights: 4 vs 2
			//IL_0647->IL0163: Incompatible stack heights: 1 vs 2
			//IL_0541->IL0163: Incompatible stack heights: 3 vs 2
			//IL_0419->IL0163: Incompatible stack heights: 1 vs 2
			//IL_0441->IL0163: Incompatible stack heights: 3 vs 2
			//IL_06d1->IL0163: Incompatible stack heights: 3 vs 2
			//IL_02c9->IL0163: Incompatible stack heights: 3 vs 2
			//IL_0322->IL0163: Incompatible stack heights: 3 vs 2
			//IL_0405->IL0163: Incompatible stack heights: 1 vs 2
			//IL_04fb->IL0163: Incompatible stack heights: 4 vs 2
			//IL_0305->IL0163: Incompatible stack heights: 1 vs 2
			//IL_055d->IL0163: Incompatible stack heights: 3 vs 2
			//IL_04c5->IL0163: Incompatible stack types: Obj vs Ref
			//IL_05ad->IL0163: Incompatible stack heights: 1 vs 2
			//IL_0664->IL0163: Incompatible stack types: I4 vs Ref
			//IL_045b->IL0163: Incompatible stack types: I4 vs Ref
			//IL_0524->IL0163: Incompatible stack types: I4 vs Ref
			//IL_04ad->IL0163: Incompatible stack types: I4 vs Ref
			//IL_06ee->IL0163: Incompatible stack types: I4 vs Ref
			//IL_06b0->IL0163: Incompatible stack heights: 3 vs 2
			//IL_0688->IL0163: Incompatible stack heights: 1 vs 2
			//IL_03c1->IL0163: Incompatible stack heights: 1 vs 2
			//IL_033f->IL0163: Incompatible stack heights: 3 vs 2
			//IL_026d->IL0163: Incompatible stack heights: 4 vs 2
			//IL_03d3->IL0163: Incompatible stack types: I4 vs Ref
			//IL_0652->IL0163: Incompatible stack heights: 1 vs 2
			//IL_0424->IL0163: Incompatible stack heights: 1 vs 2
			//IL_04d0->IL0163: Incompatible stack types: I4 vs Ref
			//IL_05b8->IL0163: Incompatible stack heights: 1 vs 2
			//IL_0693->IL0163: Incompatible stack heights: 1 vs 2
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			ref _003CRefreshSkin_003Ed__111 reference = ref *(_003CRefreshSkin_003Ed__111*)obj;
			while (true)
			{
				object obj2;
				object obj3;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (3 == 0)
					{
						reference = ref *(_003CRefreshSkin_003Ed__111*)null;
					}
					break;
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						reference = ref *(_003CRefreshSkin_003Ed__111*)null;
					}
					break;
				case 2u:
					_ = -2;
					_ = 5;
					break;
				default:
					if ((nuint)(nint)obj <= (nuint)2u)
					{
						if (true)
						{
							_ = 0;
						}
						goto IL_00a3;
					}
					goto IL_00e3;
				case 5u:
					reference = ref this;
					if (1 == 0)
					{
						reference = ref *(_003CRefreshSkin_003Ed__111*)1;
					}
					break;
				case 1u:
					return;
					IL_00e3:
					obj2 = obj;
					obj3 = 6;
					goto IL_00a3;
					IL_00a3:
					while (true)
					{
						switch ((int)obj3)
						{
						case 3:
							break;
						case 6:
							_ = null;
							_ = 8;
							continue;
						case 9:
							goto IL_00e3;
						case 2:
							obj3 = obj;
							if (false)
							{
								obj3 = 0;
							}
							continue;
						case 5:
							_ = obj == null;
							_ = 3;
							continue;
						default:
							if (obj == null)
							{
								if (4 == 0)
								{
									_ = 2;
								}
								continue;
							}
							goto case 5;
						case 7:
						{
							ref _003CRefreshSkin_003Ed__111 reference2;
							switch ((int)obj)
							{
							default:
								reference2 = ref *(_003CRefreshSkin_003Ed__111*)27;
								goto IL_0163;
							case 1:
								obj = (object)Unsafe.AsPointer(ref this);
								obj = 34;
								reference2 = ref *(_003CRefreshSkin_003Ed__111*)obj;
								goto IL_0163;
							case 2:
								goto IL_035b;
							case 0:
								goto IL_055d;
								IL_0163:
								while (true)
								{
									switch ((uint)Unsafe.AsPointer(ref reference2))
									{
									case 31u:
										break;
									case 51u:
										_ = ref obj;
										if (42 == 0)
										{
											_ = 34;
										}
										continue;
									case 19u:
										obj = (object)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref this, 1));
										reference2 = ref *(_003CRefreshSkin_003Ed__111*)29;
										continue;
									case 16u:
										goto end_IL_0163;
									case 14u:
										if (6 != 0)
										{
											_ = 5;
										}
										continue;
									case 25u:
										obj = (object)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref this, 1));
										if (52 == 0)
										{
											_ = 37;
										}
										continue;
									case 17u:
										obj = -1;
										if (2 == 0)
										{
											_ = 9;
										}
										continue;
									case 48u:
										obj = 1;
										if (23 == 0)
										{
											_ = 6;
										}
										continue;
									case 42u:
										return;
									case 50u:
										goto IL_035b;
									case 5u:
									case 9u:
										obj = (object)(&obj);
										reference2 = ref *(_003CRefreshSkin_003Ed__111*)21;
										continue;
									case 39u:
										_ = 24;
										continue;
									case 18u:
										obj = 0;
										_ = 39;
										continue;
									case 32u:
										return;
									case 45u:
									case 49u:
										obj = (object)(&obj);
										if (0 == 0)
										{
											_ = 0;
										}
										continue;
									case 52u:
										if (&obj != null)
										{
											reference2 = ref *(_003CRefreshSkin_003Ed__111*)49;
											continue;
										}
										goto case 18u;
									case 1u:
									case 11u:
										obj = (object)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref this, 1));
										_ = 40;
										continue;
									case 20u:
									case 41u:
										obj = (object)(&obj);
										if (4 == 0)
										{
											_ = 2;
										}
										continue;
									case 7u:
										if (obj == null)
										{
											if (2 == 0)
											{
												_ = 2;
											}
											continue;
										}
										goto case 19u;
									case 8u:
									case 46u:
										if (12 == 0)
										{
											_ = 11;
										}
										continue;
									case 30u:
										reference2 = ref this;
										if (17 != 0)
										{
											reference2 = ref *(_003CRefreshSkin_003Ed__111*)3;
										}
										continue;
									case 21u:
									case 37u:
										obj = obj;
										reference2 = ref *(_003CRefreshSkin_003Ed__111*)35;
										continue;
									case 10u:
										_ = 43;
										continue;
									case 34u:
										reference2 = ref this;
										if (36 != 0)
										{
											reference2 = ref *(_003CRefreshSkin_003Ed__111*)33;
										}
										continue;
									case 27u:
									{
										object obj4 = obj;
										if (obj == null)
										{
											reference2 = ref *(_003CRefreshSkin_003Ed__111*)obj4;
											if (15 != 0)
											{
												reference2 = ref *(_003CRefreshSkin_003Ed__111*)1;
											}
											continue;
										}
										goto case 38u;
									}
									default:
										obj = obj;
										reference2 = ref *(_003CRefreshSkin_003Ed__111*)37;
										continue;
									case 24u:
										_ = ref obj;
										if (16 == 0)
										{
											_ = 32;
										}
										continue;
									case 33u:
										reference2 = ref this;
										if (7 != 0)
										{
											reference2 = ref *(_003CRefreshSkin_003Ed__111*)13;
										}
										continue;
									case 3u:
										obj = 2;
										if (14 != 0)
										{
											_ = 13;
										}
										continue;
									case 15u:
									case 26u:
										if (0 == 0)
										{
											_ = 7;
										}
										continue;
									case 22u:
										goto IL_055d;
									case 13u:
										obj = -1;
										_ = 45;
										continue;
									case 47u:
										return;
									case 28u:
										if (!Unsafe.IsAddressGreaterThan(ref Unsafe.As<_003CRefreshSkin_003Ed__111, byte>(ref this), ref *(byte*)obj))
										{
											if (45 == 0)
											{
												_ = 46;
											}
											continue;
										}
										goto case 44u;
									case 38u:
										_ = 0;
										_ = 26;
										continue;
									case 43u:
										_ = 28;
										continue;
									case 6u:
										_ = ref obj;
										_ = 47;
										continue;
									case 23u:
										_ = 51;
										continue;
									case 2u:
										if (obj == null)
										{
											if (7 == 0)
											{
												_ = 11;
											}
											continue;
										}
										goto case 25u;
									case 29u:
										if (&obj != null)
										{
											reference2 = ref *(_003CRefreshSkin_003Ed__111*)5;
											continue;
										}
										goto case 3u;
									case 44u:
										_ = 8;
										continue;
									case 40u:
										if (&obj != null)
										{
											if (15 == 0)
											{
												_ = 41;
											}
											continue;
										}
										goto case 48u;
									case 36u:
										obj = -1;
										if (12 == 0)
										{
											_ = 20;
										}
										continue;
									case 12u:
										if (31 == 0)
										{
											_ = 0;
										}
										continue;
									case 35u:
										obj = obj ?? obj2;
										reference2 = ref *(_003CRefreshSkin_003Ed__111*)10;
										continue;
									}
									goto end_IL_0144;
									continue;
									end_IL_0163:
									break;
								}
								goto case 1;
								IL_055d:
								obj = (object)Unsafe.AsPointer(ref this);
								reference2 = ref *(_003CRefreshSkin_003Ed__111*)33;
								goto IL_0163;
								IL_035b:
								obj = (object)Unsafe.AsPointer(ref this);
								reference2 = ref *(_003CRefreshSkin_003Ed__111*)30;
								goto IL_0163;
								end_IL_0144:
								break;
							}
							goto case 2;
						}
						case 1:
						case 8:
							obj3 = 7;
							continue;
						case 4:
							if (obj == null || obj != null)
							{
							}
							_ = 5;
							continue;
						}
						break;
					}
					goto case 2u;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00쌀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00쐀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00씀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777968, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00였(object P_0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0074: Expected Obj, but got Ref
			//IL_0180: Expected Obj, but got Ref
			//IL_0213: Expected Obj, but got I4
			//IL_02b2: Expected Obj, but got Ref
			//IL_0284: Expected Obj, but got I4
			//IL_01dd: Expected Obj, but got Ref
			//IL_01e6: Expected Obj, but got I4
			//IL_0246: Expected Obj, but got Ref
			//IL_022a: Expected Obj, but got I4
			//IL_02dd: Expected Obj, but got I4
			//IL_0162: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_04f4->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_007e->IL0019: Incompatible stack types: I4 vs Ref
			//IL_04ff->IL0019: Incompatible stack heights: 2 vs 1
			//IL_03f4->IL0095: Incompatible stack types: I4 vs Ref
			//IL_0091->IL0095: Incompatible stack types: I4 vs Ref
			//IL_0056->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0070->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0466->IL0095: Incompatible stack types: I4 vs Ref
			//IL_00cd->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_043e->IL0095: Incompatible stack heights: 0 vs 1
			//IL_018c->IL00d1: Incompatible stack heights: 0 vs 1
			//IL_01c5->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_0449->IL0095: Incompatible stack types: I4 vs Ref
			//IL_0197->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_02be->IL00d1: Incompatible stack heights: 0 vs 1
			//IL_027f->IL00d1: Incompatible stack heights: 4 vs 1
			//IL_028f->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_01eb->IL00cd: Incompatible stack heights: 0 vs 2
			//IL_0250->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_026f->IL00d1: Incompatible stack heights: 2 vs 1
			//IL_0237->IL00d1: Incompatible stack heights: 2 vs 1
			//IL_0225->IL00d1: Incompatible stack heights: 2 vs 1
			//IL_02ea->IL00d1: Incompatible stack heights: 2 vs 1
			//IL_016d->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_0313->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_01fb->IL00d1: Incompatible stack heights: 2 vs 1
			//IL_02a1->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_015d->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_00d1->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_02c9->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_0262->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_0349->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_0242->IL00d1: Incompatible stack heights: 2 vs 1
			//IL_02f5->IL00d1: Incompatible stack heights: 2 vs 1
			//IL_01d7->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_0206->IL00d1: Incompatible stack heights: 2 vs 1
			//IL_02ac->IL00d1: Incompatible stack heights: 3 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			ref _003CSelectGame_003Ed__34 reference = ref *(_003CSelectGame_003Ed__34*)obj;
			while (true)
			{
				ref _003CSelectGame_003Ed__34 reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 == 0)
					{
						reference = ref *(_003CSelectGame_003Ed__34*)2;
					}
					continue;
				case 5u:
					reference = ref this;
					if (true)
					{
						reference = ref *(_003CSelectGame_003Ed__34*)null;
					}
					continue;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CSelectGame_003Ed__34*)3;
					continue;
				case 2u:
					if ((nuint)(nint)obj > (nuint)1u)
					{
						reference2 = ref *(_003CSelectGame_003Ed__34*)5;
						goto IL_0095;
					}
					goto IL_03e9;
				case 1u:
					return;
					IL_03e9:
					reference2 = ref *(_003CSelectGame_003Ed__34*)3;
					goto IL_0095;
					IL_0095:
					while (true)
					{
						ref byte reference3;
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						case 3u:
							if (obj == null)
							{
								reference3 = ref *(byte*)12;
								goto IL_00d1;
							}
							goto IL_01b3;
						case 2u:
							break;
						case 5u:
							if ((int)/*Error near IL_0432: Stack underflow*/ == 0)
							{
								goto end_IL_0019;
							}
							if (2 != 0)
							{
								reference2 = ref *(_003CSelectGame_003Ed__34*)4;
							}
							continue;
						default:
							reference2 = ref this;
							if (2 == 0)
							{
								reference2 = ref *(_003CSelectGame_003Ed__34*)2;
							}
							continue;
						case 1u:
						case 6u:
							goto end_IL_0019;
							IL_017c:
							obj = (object)Unsafe.AsPointer(ref this);
							if (false)
							{
								reference3 = ref *(byte*)null;
							}
							goto IL_00d1;
							IL_01b3:
							if ((nint)obj != 1)
							{
								reference3 = ref *(byte*)20;
								goto IL_00d1;
							}
							goto IL_017c;
							IL_00d1:
							while (true)
							{
								switch ((uint)Unsafe.AsPointer(ref reference3))
								{
								default:
									reference3 = ref Unsafe.As<_003CSelectGame_003Ed__34, byte>(ref this);
									if (6 == 0)
									{
										reference3 = ref *(byte*)6;
									}
									continue;
								case 19u:
									obj = 0;
									_ = 23;
									continue;
								case 15u:
									break;
								case 24u:
									goto IL_01b3;
								case 21u:
									if (&obj != null)
									{
										reference3 = ref *(byte*)5;
										continue;
									}
									goto case 19u;
								case 7u:
									obj = (object)Unsafe.AsPointer(ref this);
									obj = 21;
									continue;
								case 23u:
									if (true)
									{
										_ = 4;
									}
									continue;
								case 1u:
									obj = 25;
									continue;
								case 17u:
									_ = 18;
									continue;
								case 16u:
									obj = 1;
									if (true)
									{
										_ = 1;
									}
									continue;
								case 9u:
								case 12u:
									obj = (object)Unsafe.AsPointer(ref this);
									reference3 = ref *(byte*)17;
									continue;
								case 10u:
									if (&obj != null)
									{
										reference3 = ref *(byte*)22;
										continue;
									}
									goto case 16u;
								case 11u:
								case 22u:
									_ = ref obj;
									_ = 14;
									continue;
								case 4u:
									_ = ref obj;
									_ = 8;
									continue;
								case 6u:
									obj = -1;
									_ = 11;
									continue;
								case 25u:
									_ = ref obj;
									if (1 == 0)
									{
										_ = 2;
									}
									continue;
								case 3u:
									obj = (object)Unsafe.AsPointer(ref this);
									if (10 != 0)
									{
										reference3 = ref *(byte*)3;
									}
									continue;
								case 18u:
									obj = -1;
									if (9 != 0)
									{
										_ = 13;
									}
									continue;
								case 8u:
									return;
								case 20u:
									_ = 7;
									continue;
								case 2u:
									return;
								case 5u:
								case 13u:
									reference3 = ref *(byte*)(&obj);
									if (3 == 0)
									{
										reference3 = ref *(byte*)1;
									}
									continue;
								case 14u:
									goto end_IL_0019;
								}
								break;
							}
							goto IL_017c;
						}
						break;
					}
					goto IL_03e9;
					end_IL_0019:
					break;
				}
				_ = -2;
				if (5 == 0)
				{
					_ = 1;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00뜀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00렀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777981, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00뤀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00먀(object P_0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0067: Expected Obj, but got Ref
			//IL_01b4: Expected Obj, but got Ref
			//IL_014c: Expected Obj, but got I4
			//IL_0130: Expected Obj, but got Ref
			//IL_010e: Expected Obj, but got I4
			//IL_0118: Expected Obj, but got I4
			//IL_0063->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0073->IL0019: Incompatible stack heights: 0 vs 1
			//IL_008e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_007e->IL0019: Incompatible stack types: I4 vs Obj
			//IL_01be->IL00af: Incompatible stack types: I4 vs Ref
			//IL_00ab->IL00af: Incompatible stack types: I4 vs Ref
			//IL_0099->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0157->IL00af: Incompatible stack heights: 3 vs 1
			//IL_013c->IL00af: Incompatible stack heights: 0 vs 1
			//IL_012a->IL00af: Incompatible stack heights: 2 vs 1
			//IL_0109->IL00af: Incompatible stack heights: 2 vs 1
			//IL_0186->IL00af: Incompatible stack heights: 3 vs 1
			//IL_00fc->IL00af: Incompatible stack heights: 3 vs 1
			//IL_01ce->IL00af: Incompatible stack heights: 2 vs 1
			//IL_01a5->IL00af: Incompatible stack heights: 0 vs 1
			//IL_0147->IL00af: Incompatible stack types: I4 vs Ref
			//IL_0191->IL00af: Incompatible stack heights: 3 vs 1
			//IL_00af->IL00af: Incompatible stack heights: 3 vs 1
			//IL_0174->IL00af: Incompatible stack types: I4 vs Ref
			//IL_01d9->IL00af: Incompatible stack heights: 2 vs 1
			//IL_01b0->IL00af: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				ref _003CSelectSkin_003Ed__112 reference;
				switch ((int)obj2)
				{
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (3 == 0)
					{
						obj2 = 0;
					}
					continue;
				default:
					_ = 4;
					continue;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 5:
					break;
				case 3:
					if (obj != null)
					{
						reference = ref *(_003CSelectSkin_003Ed__112*)11;
						goto IL_00af;
					}
					goto IL_01b0;
				case 4:
					return;
					IL_01b0:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CSelectSkin_003Ed__112*)5;
					goto IL_00af;
					IL_00af:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 7u:
							break;
						case 9u:
							_ = 2;
							continue;
						case 5u:
							_ = 10;
							continue;
						case 10u:
							obj = -1;
							obj = 4;
							continue;
						case 4u:
							_ = ref obj;
							_ = 7;
							continue;
						case 2u:
							obj = (object)Unsafe.AsPointer(ref this);
							if (0 == 0)
							{
								reference = ref *(_003CSelectSkin_003Ed__112*)null;
							}
							continue;
						case 1u:
							obj = 0;
							_ = 12;
							continue;
						case 11u:
							reference = ref this;
							if (9 != 0)
							{
								reference = ref *(_003CSelectSkin_003Ed__112*)9;
							}
							continue;
						case 8u:
							_ = ref obj;
							if (3 == 0)
							{
								_ = 2;
							}
							continue;
						default:
							if (&obj == null)
							{
								if (1 == 0)
								{
									reference = ref *(_003CSelectSkin_003Ed__112*)1;
								}
								continue;
							}
							goto case 4u;
						case 6u:
							goto end_IL_00af;
						case 12u:
							if (8 != 0)
							{
								_ = 5;
							}
							continue;
						case 3u:
							return;
						}
						goto end_IL_0019;
						continue;
						end_IL_00af:
						break;
					}
					goto IL_01b0;
					end_IL_0019:
					break;
				}
				_ = -2;
				if (false)
				{
					_ = 0;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00가()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
		internal static object _FF00_FF00_FF00_FF00_FF00꼀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
		private sealed void _FF00_FF00_FF00_FF00_FF00눀(object P_0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_02b0: Expected Obj, but got Ref
			//IL_012b: Expected Obj, but got I4
			//IL_0135: Expected Obj, but got I4
			//IL_00c5: Expected Obj, but got Ref
			//IL_015b: Expected Obj, but got I4
			//IL_01cb: Expected Obj, but got Ref
			//IL_01d4: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0045->IL0019: Incompatible stack heights: 3 vs 1
			//IL_02bc->IL0019: Incompatible stack heights: 0 vs 1
			//IL_02c7->IL0019: Incompatible stack types: I4 vs Ref
			//IL_02ab->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0206->IL0068: Incompatible stack heights: 1 vs 0
			//IL_0064->IL0068: Incompatible stack heights: 1 vs 0
			//IL_01ac->IL0068: Incompatible stack heights: 2 vs 0
			//IL_00bf->IL0068: Incompatible stack heights: 2 vs 0
			//IL_0183->IL0068: Incompatible stack heights: 4 vs 0
			//IL_01bc->IL0068: Incompatible stack heights: 2 vs 0
			//IL_0168->IL0068: Incompatible stack heights: 2 vs 0
			//IL_01d9->IL0064: Incompatible stack heights: 0 vs 2
			//IL_0068->IL0068: Incompatible stack heights: 3 vs 0
			//IL_01c7->IL0068: Incompatible stack heights: 2 vs 0
			//IL_00dc->IL0068: Incompatible stack heights: 1 vs 0
			//IL_0173->IL0068: Incompatible stack heights: 2 vs 0
			//IL_010a->IL0068: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			ref _003CSetSkin_003Ed__113 reference = ref *(_003CSetSkin_003Ed__113*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					_ = -2;
					_ = 3;
					break;
				case 1u:
					if (obj == null)
					{
						if (true)
						{
							_ = 2;
						}
						goto IL_0068;
					}
					goto IL_01f5;
				case 3u:
					reference = ref this;
					if (4 == 0)
					{
						reference = ref *(_003CSetSkin_003Ed__113*)1;
					}
					break;
				case 4u:
					return;
				case 2u:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (false)
						{
							reference = ref *(_003CSetSkin_003Ed__113*)1;
						}
						break;
					}
					IL_0068:
					while (true)
					{
						switch ((int)/*Error near IL_00ad: Stack underflow*/)
						{
						case 3:
						case 11:
							break;
						case 7:
							_ = 13;
							continue;
						case 12:
						case 14:
							obj = (object)Unsafe.AsPointer(ref this);
							if (3 != 0)
							{
								_ = 5;
							}
							continue;
						case 5:
							if (&obj != null)
							{
								if (9 != 0)
								{
									_ = 3;
								}
								continue;
							}
							goto case 6;
						case 6:
							obj = 0;
							obj = 10;
							continue;
						case 4:
							return;
						case 13:
							obj = -1;
							if (false)
							{
								_ = 1;
							}
							continue;
						case 8:
							_ = ref obj;
							_ = 4;
							continue;
						case 1:
						case 9:
							_ = ref obj;
							_ = 11;
							continue;
						case 10:
							if (8 == 0)
							{
								_ = 8;
							}
							continue;
						case 2:
						case 15:
							obj = (object)Unsafe.AsPointer(ref this);
							obj = 7;
							continue;
						default:
							goto IL_01f5;
						}
						break;
					}
					goto default;
					IL_01f5:
					if (Unsafe.AsPointer(ref this) == null)
					{
						goto default;
					}
					_ = 14;
					goto IL_0068;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00ꌀ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00ꐀ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00ꔀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777923, new IntPtr(2737335812652L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00ꘀ(object P_0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0062: Expected Obj, but got I4
			//IL_0086: Expected Obj, but got Ref
			//IL_006b: Expected Obj, but got Ref
			//IL_0190: Expected Obj, but got I4
			//IL_01fb: Expected Obj, but got I4
			//IL_0226: Expected Obj, but got Ref
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0067->IL0015: Incompatible stack heights: 2 vs 0
			//IL_0092->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0077->IL0019: Incompatible stack heights: 0 vs 1
			//IL_00b0->IL00b4: Incompatible stack types: I4 vs Ref
			//IL_0055->IL0019: Incompatible stack types: I4 vs Ref
			//IL_009d->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0082->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0114->IL00b4: Incompatible stack types: I4 vs Ref
			//IL_0139->IL00b4: Incompatible stack heights: 0 vs 1
			//IL_0163->IL00b4: Incompatible stack heights: 3 vs 1
			//IL_018b->IL00b4: Incompatible stack heights: 3 vs 1
			//IL_0151->IL00b4: Incompatible stack heights: 2 vs 1
			//IL_01d5->IL00b4: Incompatible stack heights: 2 vs 1
			//IL_019d->IL00b4: Incompatible stack heights: 2 vs 1
			//IL_0206->IL00b4: Incompatible stack heights: 3 vs 1
			//IL_0232->IL00b4: Incompatible stack heights: 0 vs 1
			//IL_0144->IL00b4: Incompatible stack types: I4 vs Ref
			//IL_025e->IL00b4: Incompatible stack types: I4 vs Ref
			//IL_016e->IL00b4: Incompatible stack heights: 3 vs 1
			//IL_01c2->IL00b4: Incompatible stack types: I4 vs Ref
			//IL_01a8->IL00b4: Incompatible stack heights: 2 vs 1
			//IL_01e7->IL00b4: Incompatible stack types: I4 vs Ref
			//IL_023d->IL00b4: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			while (true)
			{
				ref _003CStartProxy_003Ed__2 reference = ref *(_003CStartProxy_003Ed__2*)obj;
				while (true)
				{
					ref object reference2;
					object obj2;
					switch ((uint)Unsafe.AsPointer(ref reference))
					{
					default:
						return;
					case 3u:
						reference = ref this;
						if (0 == 0)
						{
							reference = ref *(_003CStartProxy_003Ed__2*)null;
						}
						continue;
					case 2u:
						break;
					case 5u:
						obj = (object)Unsafe.AsPointer(ref this);
						if (4 != 0)
						{
							reference = ref *(_003CStartProxy_003Ed__2*)3;
						}
						continue;
					case 4u:
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							reference = ref *(_003CStartProxy_003Ed__2*)1;
						}
						continue;
					case 0u:
						return;
					case 1u:
						{
							if (obj == null)
							{
								reference2 = ref *(object*)4;
								goto IL_00b4;
							}
							goto IL_0102;
						}
						IL_0251:
						obj = obj2;
						reference2 = ref *(object*)8;
						goto IL_00b4;
						IL_0102:
						if (obj == null)
						{
							reference2 = ref *(object*)3;
							goto IL_00b4;
						}
						goto IL_0123;
						IL_00b4:
						while (true)
						{
							switch ((uint)Unsafe.AsPointer(ref reference2))
							{
							case 1u:
							case 3u:
								break;
							case 11u:
								return;
							case 5u:
								goto end_IL_00b4;
							case 12u:
								goto IL_0123;
							case 7u:
								_ = 15;
								continue;
							case 2u:
								_ = ref obj;
								if (2 == 0)
								{
									_ = 11;
								}
								continue;
							case 6u:
								_ = 2;
								continue;
							case 10u:
								obj = 0;
								if (6 == 0)
								{
									_ = 4;
								}
								continue;
							case 9u:
							case 13u:
								reference2 = ref obj;
								if (1 == 0)
								{
									reference2 = ref *(object*)null;
								}
								continue;
							case 8u:
								obj = obj;
								_ = 14;
								continue;
							case 14u:
								if (&obj != null)
								{
									reference2 = ref *(object*)13;
									continue;
								}
								goto case 10u;
							case 15u:
								obj = -1;
								_ = 9;
								continue;
							case 4u:
							case 16u:
								obj = (object)Unsafe.AsPointer(ref this);
								if (7 == 0)
								{
									reference2 = ref *(object*)3;
								}
								continue;
							default:
								goto IL_023d;
							}
							goto end_IL_0019;
							continue;
							end_IL_00b4:
							break;
						}
						goto IL_0102;
						IL_0123:
						obj2 = obj;
						if (obj2 == null)
						{
							if (false)
							{
								reference2 = ref *(object*)null;
							}
							goto IL_00b4;
						}
						if (obj2 == null)
						{
							obj2 = (object)/*Error near IL_024e: Stack underflow*/;
						}
						goto IL_0251;
						IL_023d:
						obj2 = null;
						goto IL_0251;
						end_IL_0019:
						break;
					}
					break;
				}
				_ = -2;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00鬀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00鰀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777935, new IntPtr(2737335814732L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00鴀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00鸀(object P_0)
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
	public DesktopViewModel()
	{
		//IL_00ae: Expected I4, but got Obj
		//IL_0098->IL00a1: Incompatible stack types: I4 vs Obj
		//IL_00cc->IL00a1: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = 1;
		_ = 1;
		DesktopViewModel desktopViewModel = this;
		if (1 == 0)
		{
			desktopViewModel = (DesktopViewModel)1;
		}
		while (true)
		{
			switch ((int)desktopViewModel)
			{
			default:
				return;
			case 1:
				desktopViewModel = this;
				if (false)
				{
					desktopViewModel = (DesktopViewModel)0;
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
	internal void 턀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0048->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0055->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005f->IL0048: Incompatible stack heights: 1 vs 0
		//IL_0094->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0069->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009f->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				_ = 5;
				break;
			case 1:
				_ = 4;
				break;
			case 3:
				if (P_0 != null)
				{
					_ = 2;
					break;
				}
				goto case 1;
			case 2:
				return;
			case 4:
				if (0 == 0)
				{
					_ = 0;
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
	internal byte 휀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0045->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0050->IL0019: Incompatible stack types: I4 vs Obj
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
				if ((int)/*Error near IL_002d: Stack underflow*/ != 0)
				{
					return (byte)/*Error near IL_0054: Stack underflow*/;
				}
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
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
	private byte _FFFD()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0045: Expected Obj, but got I4
		//IL_005e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0069->IL0019: Incompatible stack heights: 2 vs 1
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
					return 0;
				case 3:
					if (this == null)
					{
						goto end_IL_0019;
					}
					goto case 1;
				case 1:
					return 1;
				case 2:
					_ = null;
					_ = null;
					if (0 == 0)
					{
						_ = 0;
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
	internal byte _FFFD()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (this != null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FFFD(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_00bf->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00a7->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0063->IL0096: Incompatible stack heights: 1 vs 0
		//IL_0089->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0096->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0059->IL0019: Incompatible stack types: I4 vs Obj
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
			case 6:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 2:
				obj2 = this;
				if (P_0 == 0)
				{
					if (true)
					{
						obj2 = 1;
					}
					break;
				}
				return;
			case 4:
				_ = 5;
				break;
			case 5:
				_ = 3;
				break;
			case 3:
				return;
			case 1:
				obj = this;
				if (3 == 0)
				{
					obj2 = 6;
				}
				break;
			default:
				_ = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FFFD()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FFFD(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_007a: Expected Obj, but got I4
		//IL_00a6->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00b3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004a->IL003f: Incompatible stack heights: 1 vs 0
		//IL_006e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007f->IL0015: Incompatible stack heights: 1 vs 0
		//IL_0099->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0061->IL0019: Incompatible stack types: I4 vs Obj
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
				case 5:
					return;
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
					continue;
				case 3:
					_ = 4;
					continue;
				case 4:
					break;
				case 6:
					obj2 = this;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				default:
					_ = 3;
					continue;
				case 1:
					_ = 6;
					continue;
				}
				break;
			}
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
	internal ObservableCollection<DesktopGameModel> _E300()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<DesktopGameModel>)(object)this;
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
	internal byte _E600()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0045->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0050->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0057->IL0057: Incompatible stack heights: 0 vs 1
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
				if ((int)/*Error near IL_002d: Stack underflow*/ != 0)
				{
					break;
				}
				if (0 == 0)
				{
					obj2 = 0;
				}
				continue;
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
	private void _EA00(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0056: Expected I4, but got Obj
		//IL_01a1: Expected Obj, but got I4
		//IL_017b->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0066->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0097->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0154->IL0019: Incompatible stack heights: 3 vs 1
		//IL_007c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_016c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c7->IL0019: Incompatible stack heights: 0 vs 1
		//IL_015f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00fe->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0123->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ec->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0109->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01a6->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0197->IL0197: Incompatible stack heights: 1 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					obj2 = 6;
					continue;
				case 8:
					obj = this;
					if (1 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 3:
				case 11:
					_ = 5;
					continue;
				default:
					if (this != null)
					{
						if (7 == 0)
						{
							obj2 = 11;
						}
						continue;
					}
					break;
				case 10:
					obj2 = this;
					if (6 == 0)
					{
						obj2 = 7;
					}
					continue;
				case 5:
					if (P_0 == 0)
					{
						if (13 == 0)
						{
							obj2 = 6;
						}
						continue;
					}
					goto case 2;
				case 7:
					obj2 = this;
					if (false)
					{
						obj2 = 0;
					}
					continue;
				case 6:
					return;
				case 13:
					return;
				case 4:
					_ = 4;
					if (4 == 0)
					{
						_ = 10;
					}
					continue;
				case 9:
					obj2 = 8;
					continue;
				case 1:
					_ = 4;
					continue;
				case 12:
					break;
				}
				break;
			}
			if (this != null)
			{
			}
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
	internal object _EC00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _ED00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778045, new IntPtr(2737335744476L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _EE00(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_008d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004e->IL007f: Incompatible stack heights: 1 vs 0
		//IL_0044->IL0019: Incompatible stack heights: 3 vs 1
		//IL_007f->IL0019: Incompatible stack types: I4 vs Obj
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
					if (0 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				return;
			case 3:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
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
	private void _F100(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_005f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0044->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004f->IL0019: Incompatible stack types: I4 vs Obj
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
				if (P_1 != null)
				{
					if (false)
					{
						obj2 = 0;
					}
					break;
				}
				_ = 1;
				if (0 == 0)
				{
					_ = 2;
				}
				break;
			case 0:
				return;
			case 2:
				return;
			}
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
	internal void _F400(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_009a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0067->IL0043: Incompatible stack heights: 1 vs 0
		//IL_00a5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00da->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0071->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 7;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				obj2 = this;
				if (3 == 0)
				{
					obj2 = 4;
				}
				break;
			case 7:
				if (P_0 != 0)
				{
					_ = 6;
					break;
				}
				goto case 3;
			case 1:
				obj2 = this;
				if (2 != 0)
				{
					obj2 = 1;
				}
				break;
			default:
				if (false)
				{
					_ = 5;
				}
				break;
			case 2:
				return;
			case 6:
				return;
			case 4:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 5:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 1;
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
	internal ObservableCollection<DesktopSkinModel> _F600()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<DesktopSkinModel>)(object)this;
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
	internal ObservableCollection<DesktopGameModel> 豈()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<DesktopGameModel>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<DesktopGameModel> 切()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777989, new IntPtr(2737335743436L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<DesktopGameModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte ﬀ()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void ﰀ()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0062->IL0019: Incompatible stack types: I4 vs Obj
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
			case 2:
				return;
			case 1:
				obj2 = this;
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
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ﴀ()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_003f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0068->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				_ = null;
				if (false)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
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
	private void _FF00_0600(uint P_0, uint P_1)
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
				if (false)
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
	internal uint _FF00_0A00()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_0B00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777992, new IntPtr(2737335754876L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_0C00(ObservableCollection<DesktopGameModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0046: Expected I4, but got Obj
		//IL_00f0: Expected Obj, but got I4
		//IL_0058->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00cd->IL009c: Incompatible stack heights: 1 vs 0
		//IL_00a9->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00f5->IL0015: Incompatible stack heights: 2 vs 0
		//IL_00c3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_010f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e4->IL0019: Incompatible stack types: I4 vs Obj
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
					_ = 3;
					continue;
				case 4:
					return;
				case 3:
					return;
				case 8:
					obj2 = this;
					if (7 == 0)
					{
						obj2 = 4;
					}
					continue;
				case 2:
					_ = 8;
					continue;
				case 6:
					_ = 2;
					continue;
				case 1:
					obj2 = this;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 5:
					obj2 = this;
					if (P_0 != null)
					{
						if (4 == 0)
						{
							obj2 = 4;
						}
						continue;
					}
					goto case 6;
				case 7:
					break;
				case 9:
					obj2 = this;
					if (1 == 0)
					{
						obj2 = 1;
					}
					continue;
				}
				break;
			}
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
	internal object _FF00_0E00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
	internal void _FF00ᘀ(ObservableCollection<DesktopGameModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0078->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005f->IL003b: Incompatible stack heights: 1 vs 0
		//IL_00ac->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0055->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0083->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0069->IL0019: Incompatible stack heights: 2 vs 1
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
				if (0 == 0)
				{
					obj2 = 1;
				}
				break;
			case 3:
				if (P_0 != null)
				{
					_ = 2;
					break;
				}
				goto default;
			case 1:
				if (4 == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				return;
			case 4:
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
	internal object _FF00ᤀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00ᨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778015, new IntPtr(2737335746556L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_1B00(byte P_0, byte P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_003f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0067->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				_ = null;
				if (2 != 0)
				{
					_ = 1;
				}
				break;
			case 1:
				_ = P_1 == 0;
				if (0 == 0)
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
	private void _FF00Ḁ(ObservableCollection<ConfigValue> P_0)
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
	internal void _FF00_2300(ObservableCollection<DesktopGameModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0095->IL0071: Incompatible stack heights: 1 vs 0
		//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0071->IL0019: Incompatible stack heights: 2 vs 1
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
				return;
			case 5:
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			default:
				obj2 = this;
				if (5 == 0)
				{
					obj2 = 4;
				}
				break;
			case 4:
				if (P_0 != null)
				{
					_ = 3;
					break;
				}
				goto default;
			case 1:
				obj2 = this;
				if (2 != 0)
				{
					obj2 = 2;
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
	internal void _FF00_2800(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0099->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0075->IL0099: Incompatible stack heights: 1 vs 0
		//IL_006b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0051->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008c->IL0019: Incompatible stack types: I4 vs Obj
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
				obj2 = this;
				if (true)
				{
					obj2 = 1;
				}
				break;
			case 2:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 3:
				obj2 = this;
				if (P_0 == null)
				{
					if (0 == 0)
					{
						obj2 = 2;
					}
					break;
				}
				return;
			default:
				_ = 4;
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
	internal byte _FF00_3000()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
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
	internal byte _FF00_3300()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0045->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0050->IL0019: Incompatible stack types: I4 vs Obj
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
				if ((int)/*Error near IL_002d: Stack underflow*/ != 0)
				{
					return (byte)/*Error near IL_0054: Stack underflow*/;
				}
				if (false)
				{
					obj2 = 0;
				}
				break;
			default:
				return 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ObservableCollection<DesktopGameModel> _FF00㐀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<DesktopGameModel>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00㔀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778091, new IntPtr(2737335746556L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00㘀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_004e: Expected I4, but got Obj
		//IL_00d3: Expected I4, but got Obj
		//IL_00dc: Expected Obj, but got I4
		//IL_0154->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0099->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ef->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0063->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00fd->IL0019: Incompatible stack heights: 3 vs 1
		//IL_007e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_015f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a4->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0089->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					obj = this;
					if (7 != 0)
					{
						obj2 = 7;
					}
					break;
				case 10:
					_ = null;
					if (1 == 0)
					{
						_ = 2;
					}
					break;
				case 5:
					goto IL_0089;
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
						goto IL_0089;
					default:
						goto end_IL_0019;
					case 4:
						goto IL_00e1;
					case 3:
						goto IL_00ef;
					}
					goto case 10;
				case 6:
					goto IL_00e1;
				case 9:
					goto IL_00ef;
				default:
					{
						if (true)
						{
							_ = 0;
						}
						break;
					}
					IL_00ef:
					_ = null;
					_ = 3;
					break;
					IL_00e1:
					_ = null;
					_ = 4;
					break;
					IL_0089:
					_ = null;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				}
				continue;
				end_IL_0019:
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
	internal uint _FF00㨀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00㬀(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0054->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0069->IL0037: Incompatible stack heights: 1 vs 0
		//IL_008d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0073->IL0019: Incompatible stack heights: 2 vs 1
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
			case 0:
				return;
			case 3:
				_ = 2;
				break;
			case 2:
				if (1 == 0)
				{
					_ = 0;
				}
				break;
			case 4:
				if (P_0 != 0)
				{
					return;
				}
				_ = 3;
				break;
			case 1:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
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
	internal uint _FF00䄀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00䈀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
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
	internal byte _FF00䔀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0052->IL0052: Incompatible stack heights: 0 vs 1
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
				if ((int)/*Error near IL_002d: Stack underflow*/ == 0)
				{
					if (false)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
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
	internal byte _FF00䜀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (this == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00䠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778111, new IntPtr(2737335746556L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ObservableCollection<DesktopGameModel> _FF00䤀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<DesktopGameModel>)(object)this;
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
	internal void _FF00䰀(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0046: Expected I4, but got Obj
		//IL_00b5->IL00d9: Incompatible stack heights: 1 vs 0
		//IL_0067->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00e7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005a->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0091->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00d9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00bf->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0101->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ab->IL0019: Incompatible stack types: I4 vs Obj
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
			case 8:
				_ = 4;
				break;
			case 5:
				_ = 9;
				break;
			case 0:
				return;
			case 2:
				return;
			case 9:
				_ = 8;
				break;
			case 7:
				obj2 = this;
				if (5 == 0)
				{
					obj2 = 1;
				}
				break;
			case 3:
				if (P_0 != 0)
				{
					_ = 2;
					break;
				}
				goto case 6;
			case 1:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 6:
				obj = this;
				obj2 = 7;
				break;
			case 4:
				obj2 = this;
				if (true)
				{
					obj2 = 0;
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
	internal ObservableCollection<DesktopGameModel> _FF00伀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<DesktopGameModel>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<DesktopGameModel> _FF00倀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778104, new IntPtr(2737335746556L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<DesktopGameModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00儀(ObservableCollection<DesktopSkinModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0052->IL0093: Incompatible stack heights: 1 vs 0
		//IL_0048->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0088->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0093->IL0019: Incompatible stack heights: 2 vs 1
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
			case 2:
				_ = 4;
				continue;
			case 1:
				obj2 = this;
				if (P_0 != null)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			case 0:
				return;
			case 4:
				return;
			case 5:
				if (2 == 0)
				{
					_ = 0;
				}
				continue;
			case 3:
				break;
			}
			_ = 5;
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
	internal byte _FF00嘀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0045->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0050->IL0019: Incompatible stack types: I4 vs Obj
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
				if ((int)/*Error near IL_002d: Stack underflow*/ != 0)
				{
					return (byte)/*Error near IL_0054: Stack underflow*/;
				}
				if (false)
				{
					obj2 = 0;
				}
				break;
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
	private void _FF00夀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_005e: Expected Obj, but got I4
		//IL_01ba: Expected I4, but got Obj
		//IL_00a7: Expected I4, but got Obj
		//IL_028a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0076->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0050->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0081->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01f2->IL01a9: Incompatible stack heights: 0 vs 2
		//IL_00c0->IL0096: Incompatible stack heights: 0 vs 2
		//IL_01ba->IL01de: Incompatible stack heights: 1 vs 0
		//IL_01ba->IL01bf: Incompatible stack heights: 1 vs 0
		//IL_01de->IL01a9: Incompatible stack types: I4 vs Obj
		//IL_01fd->IL01a9: Incompatible stack heights: 1 vs 2
		//IL_00a7->IL00ac: Incompatible stack heights: 1 vs 0
		//IL_00a7->IL00cb: Incompatible stack heights: 1 vs 0
		//IL_00ea->IL0096: Incompatible stack types: I4 vs Obj
		//IL_00cb->IL0096: Incompatible stack heights: 1 vs 2
		//IL_01bf->IL01de: Incompatible stack heights: 1 vs 0
		//IL_00ac->IL00ac: Incompatible stack heights: 1 vs 0
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
				case 5:
					if (P_1 != null)
					{
						obj2 = 6;
						continue;
					}
					return;
				case 6:
					break;
				case 1:
					if (P_1 != null)
					{
						if (0 == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 5;
				case 2:
					return;
				case 4:
					while (true)
					{
						if (obj == null)
						{
							if (1 == 0)
							{
								_ = 1;
							}
							goto IL_0096;
						}
						goto IL_00cb;
						IL_00cb:
						DesktopViewModel desktopViewModel2 = this;
						if (false)
						{
							desktopViewModel2 = (DesktopViewModel)0;
						}
						goto IL_0096;
						IL_0096:
						switch ((int)desktopViewModel2)
						{
						case 1:
							break;
						default:
							continue;
						case 2:
							goto IL_00cb;
						}
						break;
					}
					goto case 5;
				case 3:
					while (true)
					{
						if (obj == null)
						{
							if (0 == 0)
							{
								_ = 1;
							}
							goto IL_01a9;
						}
						goto IL_01bf;
						IL_01bf:
						DesktopViewModel desktopViewModel = this;
						if (false)
						{
							desktopViewModel = (DesktopViewModel)0;
						}
						goto IL_01a9;
						IL_01a9:
						switch ((int)desktopViewModel)
						{
						case 1:
							return;
						case 2:
							break;
						default:
							continue;
						}
						goto IL_01bf;
					}
				default:
					obj = P_1;
					obj2 = 4;
					continue;
				}
				break;
			}
			obj = P_1;
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00娀(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0088->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0061->IL0093: Incompatible stack heights: 1 vs 0
		//IL_0079->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ad->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006b->IL0019: Incompatible stack heights: 2 vs 1
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
				if (P_0 != 0)
				{
					_ = 2;
					continue;
				}
				break;
			case 5:
				return;
			case 4:
				_ = 5;
				continue;
			case 1:
				if (4 == 0)
				{
					_ = 0;
				}
				continue;
			}
			obj2 = this;
			if (0 == 0)
			{
				obj2 = 1;
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
	internal uint _FF00帀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00开()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00怀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0048->IL0019: Incompatible stack heights: 2 vs 1
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
	internal unsafe object _FF00愀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778062, new IntPtr(2737335762156L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00戀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
	internal void _FF00洀(ObservableCollection<DesktopGameModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_007f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_005b->IL007f: Incompatible stack heights: 1 vs 0
		//IL_009a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0051->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0019: Incompatible stack types: I4 vs Obj
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
				obj2 = this;
				if (3 != 0)
				{
					obj2 = 4;
				}
				break;
			case 2:
				obj2 = this;
				if (P_0 == null)
				{
					if (1 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				return;
			default:
				_ = 3;
				break;
			case 4:
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
	internal static byte _FF00爀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
	internal void _FF00眀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_004a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0082->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0055->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0071->IL0019: Incompatible stack heights: 2 vs 1
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
			case 4:
				_ = null;
				_ = null;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 2:
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 3:
				if (this != null)
				{
					obj2 = 2;
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
	internal void _FF00稀(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0052: Expected I4, but got Obj
		//IL_00a2: Expected Obj, but got I4
		//IL_006e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00f0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b5->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0143->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00c3->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00a7->IL0015: Incompatible stack heights: 2 vs 0
		//IL_016d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0079->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00fb->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00e1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0178->IL0019: Incompatible stack types: I4 vs Obj
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
				case 5:
					return;
				case 1:
					obj = this;
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 10:
					break;
				case 4:
					goto IL_00a7;
				case 9:
					goto IL_00b5;
				case 3:
				case 7:
				case 8:
				case 11:
				case 12:
					if (5 == 0)
					{
						_ = 0;
					}
					continue;
				case 2:
					_ = 0;
					if (true)
					{
						_ = 1;
					}
					continue;
				case 6:
					goto IL_0135;
				default:
					{
						switch (P_0)
						{
						case 0u:
						case 1u:
						case 2u:
							break;
						case 3u:
							goto IL_00a7;
						case 4u:
							goto IL_00b5;
						case 5u:
							goto IL_0135;
						default:
							goto IL_0161;
						}
						break;
					}
					IL_0161:
					if (11 == 0)
					{
						obj2 = 0;
					}
					continue;
					IL_00b5:
					_ = null;
					_ = 8;
					continue;
					IL_0135:
					_ = null;
					_ = 3;
					continue;
					IL_00a7:
					_ = null;
					_ = 12;
					continue;
				}
				break;
			}
			_ = null;
			obj = 7;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00笀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_009a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0082->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0042->IL0037: Incompatible stack heights: 1 vs 0
		//IL_008d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0073->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0059->IL0019: Incompatible stack types: I4 vs Obj
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
			case 3:
				obj2 = this;
				if (P_0 != null)
				{
					return;
				}
				if (1 == 0)
				{
					obj2 = 2;
				}
				break;
			case 2:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				if (false)
				{
					_ = 0;
				}
				break;
			default:
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
	internal object _FF00紀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00縀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778072, new IntPtr(2737335805372L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00缀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
	internal void _FF00萀(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 2 vs 1
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
				_ = P_0 == 0;
				if (false)
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
	private void _FF00蘀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0067: Expected Obj, but got I4
		//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_007f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
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
				case 1:
					if (this == null)
					{
						if (0 == 0)
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
				if (this == null)
				{
					break;
				}
				obj2 = 3;
			}
			_ = 1;
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte _FF00蜀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
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
	internal byte _FF00言()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0052->IL0052: Incompatible stack heights: 0 vs 1
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
				if ((int)/*Error near IL_002d: Stack underflow*/ == 0)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
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
	internal byte _FF00贀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((nint)this > 0) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00踀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777902, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00輀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
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
	internal object _FF00鈀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
	internal void _FF00阀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0059->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007b->IL0064: Incompatible stack heights: 1 vs 0
		//IL_0071->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ad->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0064->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0092->IL0019: Incompatible stack types: I4 vs Obj
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
				return;
			case 2:
				if (false)
				{
					_ = 0;
				}
				break;
			case 5:
				_ = 2;
				break;
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
				goto case 5;
			case 1:
				return;
			default:
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
	internal unsafe void _FF00需(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777896, new IntPtr(2737335814732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte _FF00頀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_00b9: Expected I4, but got Obj
		//IL_0052: Expected Obj, but got I4
		//IL_007e->IL00b3: Incompatible stack heights: 1 vs 0
		//IL_00c5->IL0073: Incompatible stack heights: 1 vs 0
		//IL_0049->IL00bb: Incompatible stack heights: 1 vs 0
		//IL_0088->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0057->IL0015: Incompatible stack heights: 1 vs 0
		//IL_00dc->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 6:
					if (this != null)
					{
						break;
					}
					goto case 4;
				case 2:
					if (this != null)
					{
						_ = 3;
						continue;
					}
					goto default;
				default:
					return (byte)(int)this;
				case 1:
				case 3:
				case 5:
					return 1;
				case 4:
					obj2 = P_0;
					if (this != null)
					{
						if (1 == 0)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 2;
				}
				break;
			}
			obj = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00餀(ObservableCollection<DesktopGameModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0047: Expected Obj, but got I4
		//IL_0070->IL0096: Incompatible stack heights: 1 vs 0
		//IL_00a3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004c->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0066->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0019: Incompatible stack types: I4 vs Obj
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
					return;
				case 4:
					goto end_IL_0019;
				case 5:
					obj2 = this;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					obj2 = this;
					if (P_0 != null)
					{
						if (1 == 0)
						{
							obj2 = 1;
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
				_ = 4;
				continue;
				end_IL_0019:
				break;
			}
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
	private ObservableCollection<ConfigValue> _FF00鸀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<ConfigValue>)(object)this;
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
	internal void _FF00ꈀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0040->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0066->IL0019: Incompatible stack types: I4 vs Obj
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
				if (2 == 0)
				{
					_ = 2;
				}
				break;
			case 2:
				return;
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
	internal unsafe void _FF00ꌀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777907, new IntPtr(2737335813692L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00ꐀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0048->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0057->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a3->IL003b: Incompatible stack heights: 1 vs 0
		//IL_007d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0062->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ad->IL0019: Incompatible stack heights: 2 vs 1
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
			case 2:
				_ = 3;
				break;
			case 3:
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 0:
				return;
			case 4:
				return;
			case 1:
				obj2 = this;
				if (0 == 0)
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
	internal void _FF00_A700(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0080->IL0019: Incompatible stack heights: 3 vs 1
		//IL_005c->IL0051: Incompatible stack heights: 1 vs 0
		//IL_008d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0051->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0073->IL0019: Incompatible stack types: I4 vs Obj
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
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
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
			default:
				_ = 3;
				break;
			case 3:
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
	private byte _FF00ꨀ()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe byte _FF00_AB00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777916, new IntPtr(2737335823052L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00가(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_009b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b0->IL003b: Incompatible stack heights: 1 vs 0
		//IL_00a6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0070->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0055->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c7->IL0019: Incompatible stack types: I4 vs Obj
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
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 1:
				return;
			case 2:
				return;
			case 4:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			default:
				if (4 == 0)
				{
					_ = 2;
				}
				break;
			case 3:
				obj2 = this;
				if (P_0 != null)
				{
					if (true)
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
