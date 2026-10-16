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
using Mass.WinUI.Models;
using WinRT;
using WinRT.Mass_WinUIVtableClasses;
using Windows.Storage;

namespace Mass.WinUI.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails))]
public class ImportAccountViewModel : ObservableObject, IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CParseFile_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ImportAccountViewModel _003C_003E4__this;

		private TaskAwaiter<string[]> _003C_003Eu__1;

		internal static object ConvertHandler;

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
		internal static bool RateStruct()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QueryReporter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00嬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777699, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00尀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0082: Expected Obj, but got Ref
			//IL_0067: Expected Obj, but got Ref
			//IL_03c5: Expected Obj, but got I4
			//IL_0216: Expected Obj, but got I4
			//IL_01e3: Expected Obj, but got I4
			//IL_01b1: Expected Obj, but got Ref
			//IL_0171: Expected Obj, but got I4
			//IL_01d9: Expected Obj, but got I4
			//IL_031e: Expected Obj, but got Ref
			//IL_0327: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_008e->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0073->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0049->IL0019: Incompatible stack heights: 3 vs 1
			//IL_00b5->IL00b9: Incompatible stack heights: 1 vs 0
			//IL_0063->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0099->IL0019: Incompatible stack types: I4 vs Ref
			//IL_007e->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00b9->IL00b9: Incompatible stack heights: 1 vs 0
			//IL_0211->IL00e5: Incompatible stack types: I4 vs Ref
			//IL_00e1->IL00e5: Incompatible stack heights: 1 vs 3
			//IL_013e->IL01fb: Incompatible stack heights: 2 vs 0
			//IL_02dd->IL00e5: Incompatible stack heights: 5 vs 3
			//IL_029f->IL00e5: Incompatible stack heights: 5 vs 3
			//IL_0155->IL00e5: Incompatible stack heights: 4 vs 3
			//IL_024b->IL00e5: Incompatible stack heights: 5 vs 3
			//IL_01a2->IL00e5: Incompatible stack types: Obj vs Ref
			//IL_02af->IL00e5: Incompatible stack heights: 5 vs 3
			//IL_0221->IL00e5: Incompatible stack heights: 5 vs 3
			//IL_01f0->IL00e5: Incompatible stack heights: 4 vs 3
			//IL_01bd->IL00e5: Incompatible stack heights: 2 vs 3
			//IL_025b->IL00e5: Incompatible stack heights: 4 vs 3
			//IL_030b->IL030b: Incompatible stack heights: 4 vs 3
			//IL_02e8->IL00e5: Incompatible stack heights: 5 vs 3
			//IL_0160->IL00e5: Incompatible stack heights: 4 vs 3
			//IL_01ad->IL00e5: Incompatible stack types: I4 vs Ref
			//IL_0190->IL00e5: Incompatible stack types: I4 vs Ref
			//IL_01fb->IL00e5: Incompatible stack heights: 4 vs 3
			//IL_01c8->IL00e5: Incompatible stack heights: 2 vs 3
			//IL_0266->IL00e5: Incompatible stack heights: 4 vs 3
			//IL_00e5->IL00e5: Incompatible stack types: Obj vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			ref _003CParseFile_003Ed__48 reference = ref *(_003CParseFile_003Ed__48*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 5u:
					_ = -2;
					_ = 2;
					break;
				case 2u:
					reference = ref this;
					if (true)
					{
						reference = ref *(_003CParseFile_003Ed__48*)1;
					}
					break;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 == 0)
					{
						reference = ref *(_003CParseFile_003Ed__48*)3;
					}
					break;
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						reference = ref *(_003CParseFile_003Ed__48*)null;
					}
					break;
				case 1u:
					return;
				default:
					if (true)
					{
						_ = 0;
					}
					while (true)
					{
						ref _003CParseFile_003Ed__48 reference2;
						switch ((int)/*Error near IL_00ca: Stack underflow*/)
						{
						case 2:
							if (obj == null)
							{
								_ = 4;
								goto IL_00e5;
							}
							goto IL_01fb;
						case 1:
							goto IL_03bb;
							IL_00e5:
							while (true)
							{
								switch ((uint)Unsafe.AsPointer(ref reference2))
								{
								case 7u:
								case 19u:
									break;
								case 8u:
									return;
								case 6u:
									if (8 == 0)
									{
										_ = 10;
									}
									continue;
								case 15u:
									if (obj != null)
									{
										obj = 3;
										goto IL_00e1;
									}
									goto case 11u;
								case 14u:
									reference2 = ref this;
									if (17 != 0)
									{
										reference2 = ref *(_003CParseFile_003Ed__48*)3;
									}
									continue;
								case 11u:
									reference2 = ref *(_003CParseFile_003Ed__48*)obj;
									if (19 != 0)
									{
										reference2 = ref *(_003CParseFile_003Ed__48*)15;
									}
									continue;
								case 4u:
								case 18u:
									obj = (object)Unsafe.AsPointer(ref this);
									if (14 == 0)
									{
										_ = 0;
									}
									continue;
								case 16u:
									if (&obj != null)
									{
										obj = 9;
										goto IL_00e1;
									}
									goto case 13u;
								case 17u:
									obj = -1;
									if (0 == 0)
									{
										_ = 0;
									}
									continue;
								case 2u:
									goto end_IL_00e5;
								case 13u:
									obj = 0;
									_ = 20;
									continue;
								case 10u:
									_ = 1;
									_ = 7;
									continue;
								case 20u:
									if (true)
									{
										_ = 1;
									}
									continue;
								case 3u:
								case 5u:
									_ = null;
									_ = 12;
									continue;
								case 12u:
									_ = 6;
									continue;
								case 1u:
									_ = ref obj;
									if (8 == 0)
									{
										_ = 1;
									}
									continue;
								default:
									{
										ref object reference3 = ref obj;
										if (Unsafe.AsPointer(ref reference3) == null)
										{
											_ = null;
										}
										if (Unsafe.AsPointer(ref reference3) == null)
										{
											reference3 = ref obj;
										}
										obj = (object)Unsafe.AsPointer(ref reference3);
										obj = 15;
										goto IL_00e1;
									}
									IL_00e1:
									reference2 = ref *(_003CParseFile_003Ed__48*)obj;
									continue;
								}
								goto end_IL_00b9;
								continue;
								end_IL_00e5:
								break;
							}
							goto IL_01fb;
							IL_01fb:
							obj = obj;
							reference2 = ref *(_003CParseFile_003Ed__48*)16;
							goto IL_00e5;
							end_IL_00b9:
							break;
						}
						break;
						IL_03bb:
						obj = 2;
					}
					goto case 5u;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00崀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777696, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00帀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00开()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777697, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00怀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777710, new IntPtr(2737335739276L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00愀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00戀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777711, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00挀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777708, new IntPtr(2737335739276L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00搀(object P_0)
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
	private struct _003CPrimaryAsync_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ImportAccountViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object ReflectAlphabeticCollection;

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
		internal static bool CheckEditableProfile()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckLogicalChooser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00刀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777709, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00匀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_02e0: Expected Obj, but got Ref
			//IL_02b8: Expected Obj, but got Ref
			//IL_004c: Expected Obj, but got I4
			//IL_015d: Expected Obj, but got Ref
			//IL_0101: Expected Obj, but got I4
			//IL_010b: Expected Obj, but got I4
			//IL_014e: Expected Obj, but got I4
			//IL_02ea->IL0019: Incompatible stack types: I4 vs Obj
			//IL_02c4->IL0019: Incompatible stack heights: 0 vs 1
			//IL_02dc->IL0019: Incompatible stack heights: 2 vs 1
			//IL_02a8->IL0019: Incompatible stack heights: 2 vs 1
			//IL_02cf->IL0019: Incompatible stack types: I4 vs Obj
			//IL_02b3->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00c3->IL0055: Incompatible stack heights: 1 vs 0
			//IL_0055->IL0055: Incompatible stack heights: 1 vs 0
			//IL_00d0->IL0055: Incompatible stack heights: 2 vs 0
			//IL_01df->IL0055: Incompatible stack heights: 2 vs 0
			//IL_00dd->IL0055: Incompatible stack heights: 2 vs 0
			//IL_00ed->IL0055: Incompatible stack heights: 4 vs 0
			//IL_0110->IL0051: Incompatible stack heights: 2 vs 0
			//IL_0159->IL0055: Incompatible stack heights: 3 vs 0
			//IL_01a2->IL0055: Incompatible stack heights: 1 vs 0
			//IL_01fb->IL0055: Incompatible stack heights: 1 vs 0
			//IL_020d->IL0055: Incompatible stack heights: 1 vs 0
			//IL_01ea->IL0055: Incompatible stack heights: 2 vs 0
			//IL_012d->IL0055: Incompatible stack heights: 1 vs 0
			//IL_0174->IL0055: Incompatible stack heights: 1 vs 0
			//IL_01ad->IL0055: Incompatible stack heights: 1 vs 0
			//IL_0193->IL0055: Incompatible stack heights: 1 vs 0
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
					if (obj == null)
					{
						obj = 10;
						goto IL_0055;
					}
					goto IL_00a7;
				case 4:
					goto IL_0298;
				case 3:
					return;
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
						obj2 = 5;
						break;
					}
					IL_0298:
					_ = -2;
					if (2 == 0)
					{
						_ = 1;
					}
					break;
					IL_0055:
					while (true)
					{
						switch ((int)/*Error near IL_00a2: Stack underflow*/)
						{
						case 12:
							break;
						case 3:
							_ = 15;
							continue;
						case 8:
							_ = ref obj;
							_ = 5;
							continue;
						case 9:
							_ = ref obj;
							_ = 17;
							continue;
						case 14:
							obj = 0;
							obj = 4;
							continue;
						case 7:
							obj = obj;
							if (1 == 0)
							{
								_ = 1;
							}
							continue;
						case 17:
							return;
						case 15:
							obj = -1;
							_ = 8;
							continue;
						case 10:
						case 13:
							obj = (object)Unsafe.AsPointer(ref this);
							if (3 == 0)
							{
								_ = 0;
							}
							continue;
						case 6:
							if ((nint)obj != 1)
							{
								if (11 == 0)
								{
									_ = 7;
								}
								continue;
							}
							goto case 16;
						case 16:
							if (1 == 0)
							{
								_ = 2;
							}
							continue;
						case 4:
							if (5 == 0)
							{
								_ = 9;
							}
							continue;
						default:
							if (obj != null)
							{
								_ = 6;
								continue;
							}
							goto case 7;
						case 1:
							if (&obj == null)
							{
								_ = 14;
								continue;
							}
							goto case 8;
						case 2:
						case 5:
						case 11:
							goto IL_0298;
						}
						break;
					}
					goto IL_00a7;
					IL_00a7:
					obj = obj;
					if (false)
					{
						_ = 0;
					}
					goto IL_0055;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00吀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777706, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00唀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00嘀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00圀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777707, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00堀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00夀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777704, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSelectFile_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ImportAccountViewModel _003C_003E4__this;

		private TaskAwaiter<StorageFile> _003C_003Eu__1;

		internal static object ReflectSimpleSolver;

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
		internal static bool WatchProfiler()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectTransferableTracer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00䤀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777705, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00䨀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_026e: Expected Obj, but got Ref
			//IL_0260: Expected Obj, but got Ref
			//IL_01ac: Expected Obj, but got Ref
			//IL_0174: Expected Obj, but got I4
			//IL_00d5: Expected Obj, but got Unknown
			//IL_0115: Expected Obj, but got I4
			//IL_0191: Expected Obj, but got Ref
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0278->IL0019: Incompatible stack types: I4 vs Ref
			//IL_026a->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0251->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0241->IL0019: Incompatible stack types: I4 vs Ref
			//IL_025c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00c0->IL0051: Incompatible stack heights: 3 vs 1
			//IL_0181->IL0051: Incompatible stack heights: 2 vs 1
			//IL_0150->IL0051: Incompatible stack heights: 3 vs 1
			//IL_00a3->IL0051: Incompatible stack heights: 2 vs 1
			//IL_0101->IL0051: Incompatible stack heights: 2 vs 1
			//IL_0120->IL0051: Incompatible stack heights: 3 vs 1
			//IL_019d->IL0051: Incompatible stack heights: 0 vs 1
			//IL_00cb->IL0051: Incompatible stack heights: 3 vs 1
			//IL_018c->IL0051: Incompatible stack heights: 2 vs 1
			//IL_00ae->IL0051: Incompatible stack heights: 2 vs 1
			//IL_0164->IL0051: Incompatible stack heights: 0 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			ref _003CSelectFile_003Ed__45 reference = ref *(_003CSelectFile_003Ed__45*)obj;
			while (true)
			{
				int num;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 5u:
					if (obj != null)
					{
						num = 6;
						goto IL_0051;
					}
					goto IL_01a8;
				default:
					reference = ref this;
					if (1 == 0)
					{
						reference = ref *(_003CSelectFile_003Ed__45*)null;
					}
					break;
				case 4u:
					goto IL_0241;
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CSelectFile_003Ed__45*)2;
					break;
				case 2u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CSelectFile_003Ed__45*)5;
					break;
				case 1u:
					return;
					IL_0051:
					while (true)
					{
						switch (num)
						{
						case 7:
							if (0 == 0)
							{
								_ = 2;
							}
							continue;
						case 2:
							_ = ref obj;
							if (1 == 0)
							{
								_ = 1;
							}
							continue;
						case 6:
						{
							obj = (object)/*Error near IL_00cc: Stack underflow*/;
							_003F val = /*Error near IL_00d5: Stack underflow*/;
							obj = obj;
							num = (int)val;
							if (13 != 0)
							{
								num = 11;
							}
							continue;
						}
						case 10:
							_ = 4;
							continue;
						case 1:
							return;
						case 11:
							obj = 0;
							_ = 7;
							continue;
						default:
							if (obj == null)
							{
								num = 3;
								continue;
							}
							goto case 5;
						case 5:
							_ = 9;
							continue;
						case 13:
							if (&obj == null)
							{
								if (11 == 0)
								{
									num = 2;
								}
								continue;
							}
							goto case 12;
						case 4:
							obj = -1;
							if (12 != 0)
							{
								_ = 4;
							}
							continue;
						case 12:
							obj = (object)(&obj);
							if (false)
							{
								num = 0;
							}
							continue;
						case 8:
							break;
						case 3:
						case 9:
							goto IL_0241;
						}
						break;
					}
					goto IL_01a8;
					IL_0241:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
					IL_01a8:
					obj = (object)Unsafe.AsPointer(ref this);
					num = 10;
					goto IL_0051;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00䬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777718, new IntPtr(2737335738236L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00䰀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777719, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00䴀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00一()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777716, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00伀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00倀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00儀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777717, new IntPtr(2737335708076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	private object _filePath;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? selectFileCommand;

	private static object DecorateAdjustableRecord;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsDragging
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 脀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			ꠀ(value ? ((byte)1) : ((byte)0));
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public ImportStep Step
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 鴀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			需(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string SelectedFileName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)鐀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			대(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool HasSelectedFile
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return ꈀ() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			眀(value ? ((byte)1) : ((byte)0));
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int ParsedCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)退();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			褀((uint)value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int ImportedCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)蜀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			礀((uint)value);
		}
	}

	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public int SkippedCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)鰀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			ꨀ((uint)value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ObservableCollection<AccountModel> ParsedAccounts
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 鼀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			蠀(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? ParseErrorMessage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string?)蔀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			錀(value);
		}
	}

	public bool IsStepSelectFile
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 谀() != 0;
		}
	}

	public bool IsStepPreview
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 舀() != 0;
		}
	}

	public bool IsStepDone
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 猀() != 0;
		}
	}

	public bool IsPrimaryButtonEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 笀() != 0;
		}
	}

	public string Title
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)簀();
		}
	}

	public string PrimaryButtonText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)謀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand SelectFileCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)ꘀ();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ImportAccountViewModel()
	{
		//IL_0052: Expected I4, but got Obj
		//IL_0038->IL0041: Incompatible stack types: I4 vs Obj
		//IL_008d->IL0041: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0041: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ImportAccountViewModel importAccountViewModel = this;
		if (true)
		{
			importAccountViewModel = (ImportAccountViewModel)1;
		}
		while (true)
		{
			switch ((int)importAccountViewModel)
			{
			case 1:
				importAccountViewModel = this;
				if (false)
				{
					importAccountViewModel = (ImportAccountViewModel)0;
				}
				break;
			default:
				importAccountViewModel = this;
				if (2 != 0)
				{
					importAccountViewModel = (ImportAccountViewModel)0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		甀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSelectFile_003Ed__45))]
	[RelayCommand]
	private object SelectFile()
	{
		return 鬀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPrimaryAsync_003Ed__46))]
	public Task PrimaryAsync()
	{
		return (Task)贀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DoImport()
	{
		가();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CParseFile_003Ed__48))]
	private object ParseFile()
	{
		return ꐀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DragStatusChanged(byte isDragging)
	{
		ꄀ(isDragging);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadFile(object path)
	{
		넀(path);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FilesDropped(object files)
	{
		딀(files);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnStepChanged(ImportStep value)
	{
		꼀(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnHasSelectedFileChanged(byte value)
	{
		縀(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckGenericContext()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ImportAccountViewModel VerifyMonitor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object 瀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777650, new IntPtr(2737335708076L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 焀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte 爀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777651, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte 猀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((nint)this == 2) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte 琀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777648, new IntPtr(2737335735116L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void 甀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_005d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0076->IL0019: Incompatible stack types: I4 vs Obj
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
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 1;
				}
				break;
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
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 瘀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777649, new IntPtr(2737335729916L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 眀(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_00a5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0049->IL00b1: Incompatible stack heights: 1 vs 0
		//IL_00be->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0096->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0089->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0060->IL0019: Incompatible stack types: I4 vs Obj
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
				if (P_0 != 0)
				{
					if (1 == 0)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			case 1:
				return;
			case 6:
				if (0 == 0)
				{
					_ = 0;
				}
				continue;
			case 5:
				_ = 3;
				continue;
			default:
				if (0 == 0)
				{
					_ = 5;
				}
				continue;
			case 3:
				return;
			case 4:
				break;
			}
			_ = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 砀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777662, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 礀(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_007b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0090->IL0051: Incompatible stack heights: 1 vs 0
		//IL_0086->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0051->IL0019: Incompatible stack types: I4 vs Obj
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
			case 4:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				obj2 = this;
				if (true)
				{
					obj2 = 1;
				}
				break;
			case 1:
				if (3 != 0)
				{
					_ = 4;
				}
				break;
			case 3:
				if (P_0 != 0)
				{
					return;
				}
				_ = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 稀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777663, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte 笀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_004c: Expected I4, but got Obj
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
					if (false)
					{
						obj2 = 0;
					}
					break;
				}
				return 1;
			default:
				return (byte)(int)this;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 簀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17430, 1790777660, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777660, new IntPtr(2737335727836L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 紀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777661, new IntPtr(2737335728876L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void 縀(byte P_0)
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
				if (false)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 缀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777658, new IntPtr(2737335728876L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte 耀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777659, new IntPtr(2737335729916L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte 脀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte 舀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((nint)this == 1) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte 茀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777656, new IntPtr(2737335728876L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 萀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777657, new IntPtr(2737335702876L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object 蔀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint 蘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777606, new IntPtr(2737335728876L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint 蜀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 蠀(ObservableCollection<AccountModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0083->IL005e: Incompatible stack heights: 1 vs 0
		//IL_0051->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0079->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008d->IL0019: Incompatible stack heights: 2 vs 1
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
			case 1:
				_ = 2;
				break;
			case 2:
				return;
			case 3:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
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
	internal void 褀(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0072->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0081->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0041->IL008c: Incompatible stack heights: 1 vs 0
		//IL_008c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0065->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
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
				if (P_0 == 0)
				{
					_ = 2;
					break;
				}
				return;
			case 2:
				obj2 = this;
				if (true)
				{
					obj2 = 1;
				}
				break;
			default:
				_ = 4;
				break;
			case 1:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 4:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 言(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777607, new IntPtr(2737335728876L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 謀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17445, 1790777604, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777604, new IntPtr(2737335728876L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte 谀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (this == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 贀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17447, 1790777605, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777605, new IntPtr(2737335735116L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 踀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777602, new IntPtr(2737335702876L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint 輀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777603, new IntPtr(2737335702876L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint 退()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint 鄀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777600, new IntPtr(2737335729916L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 鈀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777601, new IntPtr(2737335702876L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 錀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0099->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005b->IL0099: Incompatible stack heights: 1 vs 0
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0051->IL0019: Incompatible stack heights: 2 vs 1
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
			case 4:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
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
			default:
				obj2 = this;
				if (3 != 0)
				{
					obj2 = 2;
				}
				break;
			case 1:
				_ = 4;
				break;
			case 3:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object 鐀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 销()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777614, new IntPtr(2737335702876L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 阀(ImportStep P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777615, new IntPtr(2737335729916L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 需(ImportStep P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0079->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL003b: Incompatible stack heights: 1 vs 0
		//IL_0091->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0084->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0050->IL0019: Incompatible stack heights: 2 vs 1
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
			case 0:
				return;
			case 3:
				if (P_0 != ImportStep.SelectFile)
				{
					return;
				}
				_ = 2;
				break;
			case 2:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				if (true)
				{
					_ = 4;
				}
				break;
			case 4:
				_ = 5;
				break;
			case 5:
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
	internal unsafe static byte 頀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777612, new IntPtr(2737335729916L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte 餀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte 騀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777613, new IntPtr(2737335729916L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object 鬀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17461, 1790777610, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777610, new IntPtr(2737335729916L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint 鰀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ImportStep 鴀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ImportStep)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ImportStep 鸀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777611, new IntPtr(2737335702876L), 15))(null, 0, new IntPtr(0L));
		return (ImportStep)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ObservableCollection<AccountModel> 鼀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<AccountModel>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<AccountModel> ꀀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777608, new IntPtr(2737335708076L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<AccountModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ꄀ(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0041->IL0019: Incompatible stack heights: 4 vs 1
		//IL_004c->IL0019: Incompatible stack heights: 4 vs 1
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
				/*Error near IL_002c: Stack underflow*/;
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
	internal byte ꈀ()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object ꌀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777609, new IntPtr(2737335702876L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object ꐀ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17470, 1790777622, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777622, new IntPtr(2737335702876L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object ꔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777623, new IntPtr(2737335736156L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object ꘀ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17472, 1790777620, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777620, new IntPtr(2737335736156L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _A700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777621, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void ꠀ(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0082->IL0099: Incompatible stack heights: 1 vs 0
		//IL_0078->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0051->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0099->IL0019: Incompatible stack types: I4 vs Obj
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
				if (1 == 0)
				{
					_ = 2;
				}
				break;
			default:
				obj2 = this;
				if (4 == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				_ = 3;
				break;
			case 1:
				obj2 = this;
				if (P_0 == 0)
				{
					if (false)
					{
						obj2 = 0;
					}
					break;
				}
				return;
			case 3:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _꤀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777618, new IntPtr(2737335740316L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void ꨀ(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_006d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0092: Incompatible stack heights: 1 vs 0
		//IL_0078->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0092->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ac->IL0019: Incompatible stack types: I4 vs Obj
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
				if (P_0 != 0)
				{
					_ = 2;
					continue;
				}
				break;
			case 2:
				return;
			case 1:
				if (4 == 0)
				{
					_ = 2;
				}
				continue;
			case 4:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				continue;
			case 5:
				break;
			case 0:
				return;
			}
			obj2 = this;
			if (false)
			{
				obj2 = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _AB00(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777619, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 가()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0046: Expected I4, but got Obj
		//IL_0146: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got Ref
		//IL_0169->IL0019: Incompatible stack heights: 2 vs 1
		//IL_012d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_011e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0158->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0181->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01a1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0174->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0138->IL0019: Incompatible stack heights: 2 vs 1
		//IL_018c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01ac->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01e0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b5->IL0060: Incompatible stack heights: 1 vs 0
		//IL_0099->IL0060: Incompatible stack heights: 1 vs 0
		//IL_00c5->IL0060: Incompatible stack heights: 3 vs 0
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
				case 6:
					return;
				case 9:
					while (true)
					{
						if (&obj == null)
						{
							if (0 == 0)
							{
								_ = 0;
							}
							goto IL_0060;
						}
						goto IL_0099;
						IL_0099:
						obj = (object)(&obj);
						if (1 == 0)
						{
							_ = 0;
						}
						goto IL_0060;
						IL_0060:
						while (true)
						{
							switch ((int)/*Error near IL_0075: Stack underflow*/)
							{
							case 3:
								break;
							case 2:
								goto IL_0099;
							case 1:
								_ = 3;
								continue;
							default:
								goto end_IL_007a;
							}
							break;
						}
						continue;
						end_IL_007a:
						break;
					}
					goto case 4;
				case 2:
					_ = 5;
					continue;
				case 1:
					_ = 2;
					if (6 == 0)
					{
						_ = 1;
					}
					continue;
				case 8:
					break;
				case 3:
					obj = (object)/*Error near IL_014e: Stack underflow*/;
					obj2 = 2;
					continue;
				default:
					if (7 == 0)
					{
						_ = 2;
					}
					continue;
				case 4:
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 7:
					_ = (object)this - obj;
					if (1 == 0)
					{
						_ = 1;
					}
					continue;
				case 5:
					obj2 = ((object)this) ?? ((object)/*Error near IL_01be: Stack underflow*/);
					obj = obj;
					if (8 == 0)
					{
						obj2 = 1;
					}
					continue;
				}
				break;
			}
			obj = obj;
			obj = 9;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 관()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777616, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 글(ImportStep P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777617, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void 꼀(ImportStep P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_00b5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0073->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0059->IL0019: Incompatible stack types: I4 vs Obj
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
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			default:
				obj2 = this;
				if (4 != 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 3:
				return;
			case 4:
				_ = 2;
				break;
			case 6:
				_ = 5;
				break;
			case 2:
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 뀀(ImportStep P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777630, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void 넀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0096->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0060->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0051->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0086->IL0019: Incompatible stack heights: 2 vs 1
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
				_ = 1;
				if (false)
				{
					_ = 4;
				}
				break;
			case 3:
				if (false)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 4:
				_ = null;
				if (3 != 0)
				{
					_ = 0;
				}
				break;
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
	private unsafe void 눀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777631, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 대(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0096->IL003b: Incompatible stack heights: 1 vs 0
		//IL_0055->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0081->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0048->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ad->IL0019: Incompatible stack types: I4 vs Obj
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
				_ = 3;
				break;
			case 2:
				_ = 4;
				break;
			case 0:
				return;
			case 4:
				return;
			case 3:
				if (true)
				{
					_ = 2;
				}
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
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 됀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777628, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void 딀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_0066: Expected Obj, but got I4
		//IL_006b->IL0015: Incompatible stack heights: 2 vs 0
		//IL_004e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0059->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00ca->IL0019: Incompatible stack heights: 3 vs 1
		//IL_008a->IL0019: Incompatible stack types: I4 vs Obj
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
					obj = (object)/*Error near IL_0042: Stack underflow*/;
					if (false)
					{
						obj2 = 0;
					}
					continue;
				case 3:
					if (obj != null)
					{
						if (2 == 0)
						{
							obj2 = 1;
						}
						continue;
					}
					return;
				case 5:
					return;
				case 4:
					return;
				case 2:
					_ = 5;
					continue;
				case 6:
				{
					object obj3 = obj;
					_ = 3;
					continue;
				}
				}
				break;
			}
			obj = 6;
		}
	}
}
