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

[WinRTExposedType(typeof(Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
public class ReferralViewModel : ObservableObject, IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRedeemPoints_003Ed__52 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ReferralViewModel _003C_003E4__this;

		public string productCode;

		private object _003Cresult_003E5__2;

		private object _003CfileName_003E5__3;

		private TaskAwaiter<EntityMassReferralVoucher> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		internal static object CombineDecryptor;

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
		internal static bool DecorateTransformableInitializer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateSequentialPublisher()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00需()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778814, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00頀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0640: Expected Obj, but got Ref
			//IL_011a: Expected I4, but got Obj
			//IL_024b: Expected Obj, but got Ref
			//IL_02ed: Expected Obj, but got Ref
			//IL_0461: Expected Obj, but got Ref
			//IL_0389: Expected Obj, but got Ref
			//IL_0200: Expected Obj, but got I4
			//IL_0532: Expected Obj, but got I4
			//IL_0410: Expected Obj, but got I4
			//IL_022f: Expected Obj, but got I4
			//IL_0515: Expected Obj, but got I4
			//IL_0400: Expected Obj, but got I4
			//IL_02af: Expected Obj, but got Ref
			//IL_047d: Expected Obj, but got I4
			//IL_0657->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_064a->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0084->IL0088: Incompatible stack heights: 1 vs 0
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0071->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00c2->IL0088: Incompatible stack heights: 1 vs 0
			//IL_00e2->IL0088: Incompatible stack heights: 3 vs 0
			//IL_046b->IL0135: Incompatible stack heights: 1 vs 0
			//IL_0262->IL0135: Incompatible stack heights: 1 vs 0
			//IL_0304->IL0135: Incompatible stack heights: 1 vs 0
			//IL_0131->IL0135: Incompatible stack heights: 1 vs 0
			//IL_0106->IL0088: Incompatible stack heights: 1 vs 0
			//IL_0379->IL0135: Incompatible stack heights: 1 vs 0
			//IL_0393->IL0135: Incompatible stack heights: 1 vs 0
			//IL_029d->IL0135: Incompatible stack heights: 2 vs 0
			//IL_022a->IL0135: Incompatible stack heights: 10 vs 0
			//IL_053f->IL0135: Incompatible stack heights: 2 vs 0
			//IL_0331->IL0135: Incompatible stack heights: 3 vs 0
			//IL_0444->IL0135: Incompatible stack heights: 2 vs 0
			//IL_042a->IL0135: Incompatible stack heights: 1 vs 0
			//IL_045d->IL0135: Incompatible stack heights: 3 vs 0
			//IL_02d6->IL0135: Incompatible stack heights: 4 vs 0
			//IL_0283->IL0135: Incompatible stack heights: 1 vs 0
			//IL_041b->IL0135: Incompatible stack heights: 3 vs 0
			//IL_04c1->IL0135: Incompatible stack heights: 4 vs 0
			//IL_01e6->IL0135: Incompatible stack heights: 1 vs 0
			//IL_0478->IL0135: Incompatible stack heights: 2 vs 0
			//IL_023c->IL0135: Incompatible stack heights: 2 vs 0
			//IL_0314->IL0135: Incompatible stack heights: 2 vs 0
			//IL_0522->IL0135: Incompatible stack heights: 2 vs 0
			//IL_0274->IL0135: Incompatible stack heights: 2 vs 0
			//IL_0510->IL0135: Incompatible stack heights: 3 vs 0
			//IL_040b->IL0135: Incompatible stack heights: 3 vs 0
			//IL_04f4->IL0135: Incompatible stack heights: 2 vs 0
			//IL_04d5->IL0135: Incompatible stack heights: 4 vs 0
			//IL_03c2->IL0135: Incompatible stack heights: 2 vs 0
			//IL_048a->IL0135: Incompatible stack heights: 2 vs 0
			//IL_0384->IL0135: Incompatible stack heights: 1 vs 0
			//IL_02a8->IL0135: Incompatible stack heights: 2 vs 0
			//IL_054a->IL0135: Incompatible stack heights: 2 vs 0
			//IL_033c->IL0135: Incompatible stack heights: 3 vs 0
			//IL_044f->IL0135: Incompatible stack heights: 2 vs 0
			//IL_0435->IL0135: Incompatible stack heights: 1 vs 0
			//IL_028e->IL0135: Incompatible stack heights: 1 vs 0
			//IL_01f1->IL0135: Incompatible stack heights: 1 vs 0
			//IL_0247->IL0135: Incompatible stack heights: 2 vs 0
			//IL_031f->IL0135: Incompatible stack heights: 2 vs 0
			//IL_052d->IL0135: Incompatible stack heights: 2 vs 0
			//IL_03df->IL0135: Incompatible stack heights: 1 vs 0
			//IL_04ff->IL0135: Incompatible stack heights: 2 vs 0
			//IL_03cd->IL0135: Incompatible stack heights: 2 vs 0
			//IL_02c6->IL0135: Incompatible stack heights: 1 vs 0
			//IL_0495->IL0135: Incompatible stack heights: 2 vs 0
			//IL_03b2->IL0135: Incompatible stack heights: 1 vs 0
			//IL_036a->IL0135: Incompatible stack heights: 1 vs 0
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
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						obj2 = 0;
					}
					break;
				case 4:
					_ = -2;
					if (1 == 0)
					{
						_ = 1;
					}
					break;
				default:
					if ((nuint)(nint)obj > (nuint)2u)
					{
						_ = 4;
						goto IL_0088;
					}
					goto IL_00aa;
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 2;
					break;
				case 1:
					_ = 5;
					break;
				case 5:
					return;
					IL_00aa:
					if (0 == 0)
					{
						_ = 1;
					}
					goto IL_0088;
					IL_0088:
					while (true)
					{
						switch ((int)/*Error near IL_00a5: Stack underflow*/)
						{
						case 3:
						case 5:
							break;
						case 2:
							goto IL_00aa;
						default:
							_ = 2;
							_ = 3;
							continue;
						case 4:
							if ((nint)obj < 200)
							{
								if (false)
								{
									_ = 0;
								}
								continue;
							}
							goto IL_00aa;
						case 1:
							switch ((int)obj)
							{
							default:
								if (36 != 0)
								{
									_ = 4;
								}
								goto IL_0135;
							case 0:
								obj = (object)Unsafe.AsPointer(ref this);
								if (14 == 0)
								{
									_ = 14;
								}
								goto IL_0135;
							case 1:
								goto IL_02e9;
							case 2:
								goto IL_045d;
								IL_0135:
								while (true)
								{
									switch ((int)/*Error near IL_01d2: Stack underflow*/)
									{
									case 8:
										break;
									case 18:
										_ = ref obj;
										if (2 != 0)
										{
											_ = 9;
										}
										continue;
									case 3:
										/*Error near IL_01f6: Stack underflow*/;
										_ = 11;
										obj = 1;
										_ = ref obj;
										_ = ref obj;
										_ = ref obj;
										_ = ref obj;
										_ = ref obj;
										obj = obj;
										_ = 27;
										continue;
									case 21:
										obj = 1;
										if (29 != 0)
										{
											_ = 35;
										}
										continue;
									case 26:
										goto end_IL_0135;
									case 24:
										obj = null;
										_ = 13;
										continue;
									case 14:
										if (37 != 0)
										{
											_ = 25;
										}
										continue;
									case 2:
										_ = null;
										if (0 == 0)
										{
											_ = 8;
										}
										continue;
									case 36:
										obj = (object)Unsafe.AsPointer(ref this);
										if (18 != 0)
										{
											_ = 28;
										}
										continue;
									case 12:
										_ = ref obj;
										_ = 7;
										continue;
									case 6:
										goto IL_02e9;
									case 22:
										if (5 == 0)
										{
											_ = 2;
										}
										continue;
									case 5:
										_ = ref obj;
										if (17 != 0)
										{
											_ = 8;
										}
										continue;
									case 7:
										return;
									case 27:
										if (&obj != null)
										{
											if (8 == 0)
											{
												_ = 29;
											}
											continue;
										}
										goto case 21;
									default:
										_ = ref obj;
										if (4 != 0)
										{
											_ = 25;
										}
										continue;
									case 1:
									case 33:
										obj = (object)(&obj);
										_ = 11;
										continue;
									case 13:
										if (&obj == null)
										{
											if (4 == 0)
											{
												_ = 4;
											}
											continue;
										}
										goto case 18;
									case 35:
										if (10 == 0)
										{
											_ = 12;
										}
										continue;
									case 28:
										if (&obj != null)
										{
											_ = 33;
											continue;
										}
										goto case 30;
									case 17:
										return;
									case 30:
										obj = 0;
										_ = 31;
										continue;
									case 15:
										obj = -1;
										_ = 18;
										continue;
									case 10:
										if (15 == 0)
										{
											_ = 5;
										}
										continue;
									case 9:
										_ = null;
										if (false)
										{
											_ = 2;
										}
										continue;
									case 11:
										_ = 3;
										continue;
									case 20:
										goto IL_045d;
									case 19:
										_ = 23;
										continue;
									case 37:
										obj = -1;
										if (1 == 0)
										{
											_ = 1;
										}
										continue;
									case 16:
										_ = ref obj;
										_ = 34;
										continue;
									case 32:
										_ = 1;
										_ = 24;
										continue;
									case 34:
										return;
									case 31:
										if (16 == 0)
										{
											_ = 1;
										}
										continue;
									case 25:
										/*Error near IL_0500: Stack underflow*/;
										_ = 32;
										continue;
									case 23:
										obj = -1;
										if (false)
										{
											_ = 0;
										}
										continue;
									case 4:
										obj = 2;
										if (22 == 0)
										{
											_ = 14;
										}
										continue;
									}
									goto end_IL_0109;
									continue;
									end_IL_0135:
									break;
								}
								goto case 0;
								IL_045d:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 10;
								goto IL_0135;
								IL_02e9:
								obj = (object)Unsafe.AsPointer(ref this);
								if (19 != 0)
								{
									_ = 15;
								}
								goto IL_0135;
								end_IL_0109:
								break;
							}
							break;
						}
						break;
					}
					goto case 4;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00餀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778815, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00騀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778812, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00鬀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00鰀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778813, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00鴀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00鸀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00鼀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778810, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRedeemSelf_003Ed__51 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string productCode;

		public ReferralViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object ArrangeUser;

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
		internal static bool ReflectEfficientMap()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateAttachedVisitor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00謀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778811, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00谀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0069: Expected Obj, but got Ref
			//IL_0322: Expected Obj, but got Ref
			//IL_029e: Expected Obj, but got I4
			//IL_01b3: Expected Obj, but got Ref
			//IL_01c9: Expected Obj, but got I4
			//IL_0181: Expected Obj, but got I4
			//IL_0166: Expected Obj, but got I4
			//IL_02dd: Expected Obj, but got Ref
			//IL_01f2: Expected Obj, but got I4
			//IL_01fc: Expected Obj, but got I4
			//IL_0156: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_005a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0049->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0073->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0065->IL0019: Incompatible stack heights: 2 vs 1
			//IL_008d->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00aa->IL00ae: Incompatible stack heights: 1 vs 0
			//IL_03d2->IL00ae: Incompatible stack heights: 1 vs 0
			//IL_0339->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_00e3->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_022e->IL00e7: Incompatible stack heights: 3 vs 0
			//IL_0248->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_0313->IL00e7: Incompatible stack heights: 3 vs 0
			//IL_02d6->IL00e7: Incompatible stack heights: 3 vs 0
			//IL_0301->IL00e7: Incompatible stack heights: 2 vs 0
			//IL_01af->IL00e7: Incompatible stack heights: 2 vs 0
			//IL_02a9->IL00e7: Incompatible stack heights: 3 vs 0
			//IL_01bd->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_0186->IL00e3: Incompatible stack heights: 2 vs 1
			//IL_0211->IL00e7: Incompatible stack heights: 2 vs 0
			//IL_0171->IL00e7: Incompatible stack heights: 3 vs 0
			//IL_0201->IL00e3: Incompatible stack heights: 2 vs 1
			//IL_01e2->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_0161->IL00e7: Incompatible stack heights: 3 vs 0
			//IL_0239->IL00e7: Incompatible stack heights: 3 vs 0
			//IL_0287->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_0253->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_031e->IL00e7: Incompatible stack heights: 3 vs 0
			//IL_00e7->IL00e7: Incompatible stack heights: 2 vs 0
			//IL_021c->IL00e7: Incompatible stack heights: 2 vs 0
			//IL_02f4->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_0299->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_01ed->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_02c8->IL00e7: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			ref _003CRedeemSelf_003Ed__51 reference = ref *(_003CRedeemSelf_003Ed__51*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CRedeemSelf_003Ed__51*)2;
					break;
				case 5u:
					return;
				default:
					_ = -2;
					if (true)
					{
						_ = 1;
					}
					break;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CRedeemSelf_003Ed__51*)3;
					break;
				case 1u:
					reference = ref this;
					if (1 == 0)
					{
						reference = ref *(_003CRedeemSelf_003Ed__51*)5;
					}
					break;
				case 2u:
					_ = 1;
					if (1 == 0)
					{
						_ = 1;
					}
					while (true)
					{
						switch ((int)/*Error near IL_00bf: Stack underflow*/)
						{
						case 2:
							break;
						default:
							if (obj != null)
							{
								if (21 == 0)
								{
									_ = 1;
								}
								goto IL_00e7;
							}
							goto IL_031e;
						case 1:
							{
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							}
							IL_00e7:
							while (true)
							{
								switch ((int)/*Error near IL_014c: Stack underflow*/)
								{
								case 15:
									return;
								case 19:
									return;
								case 4:
									break;
								case 23:
									obj = 1;
									_ = 13;
									continue;
								case 14:
									obj = 0;
									_ = 6;
									continue;
								case 12:
									_ = 1;
									obj = 22;
									continue;
								case 8:
									_ = 9;
									continue;
								case 10:
									obj = (object)Unsafe.AsPointer(ref this);
									_ = 8;
									continue;
								case 11:
									obj = 18;
									continue;
								case 22:
									obj = null;
									if (17 == 0)
									{
										_ = 3;
									}
									continue;
								case 18:
									obj = -1;
									obj = 7;
									continue;
								case 13:
									if (0 == 0)
									{
										_ = 0;
									}
									continue;
								default:
									_ = ref obj;
									if (16 == 0)
									{
										_ = 19;
									}
									continue;
								case 2:
								case 3:
									_ = ref obj;
									if (true)
									{
										_ = 4;
									}
									continue;
								case 1:
									if (&obj == null)
									{
										_ = 14;
										continue;
									}
									goto case 7;
								case 17:
									if (&obj != null)
									{
										_ = 2;
										continue;
									}
									goto case 23;
								case 9:
									obj = -1;
									_ = 3;
									continue;
								case 21:
									if ((nint)obj != 1)
									{
										if (16 == 0)
										{
											_ = 11;
										}
										continue;
									}
									goto case 10;
								case 6:
									_ = 5;
									continue;
								case 16:
									obj = (object)Unsafe.AsPointer(ref this);
									if (1 == 0)
									{
										_ = 1;
									}
									continue;
								case 7:
									_ = ref obj;
									_ = 12;
									continue;
								case 5:
									_ = ref obj;
									if (15 == 0)
									{
										_ = 9;
									}
									continue;
								case 20:
									goto end_IL_00e7;
								}
								goto end_IL_00ae;
								continue;
								end_IL_00e7:
								break;
							}
							goto IL_031e;
							IL_031e:
							obj = (object)Unsafe.AsPointer(ref this);
							if (1 == 0)
							{
								_ = 11;
							}
							goto IL_00e7;
							end_IL_00ae:
							break;
						}
						break;
					}
					goto default;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00贀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778808, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00踀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00輀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778809, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00退()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778758, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00鄀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00鈀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778759, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00錀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778756, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00鐀(object P_0)
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
	private struct _003CRefresh_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ReferralViewModel _003C_003E4__this;

		private TaskAwaiter<List<EntityMassReferralProduct>> _003C_003Eu__1;

		private TaskAwaiter<EntityMassReferralInfo> _003C_003Eu__2;

		private static object CreateTransformer;

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
		internal static bool ControlMap()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateDetailedDriver()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00舀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778757, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00茀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0625: Expected Obj, but got Ref
			//IL_0040: Expected Obj, but got Ref
			//IL_0494: Expected Obj, but got Ref
			//IL_0238: Expected Obj, but got Ref
			//IL_04db: Expected Obj, but got I4
			//IL_04b0: Expected Obj, but got Ref
			//IL_0464: Expected Obj, but got I4
			//IL_048b: Expected Obj, but got I4
			//IL_0264: Expected Obj, but got I4
			//IL_01b3: Expected Obj, but got I4
			//IL_01f1: Expected Obj, but got Ref
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0081->IL0019: Incompatible stack heights: 2 vs 1
			//IL_062f->IL0019: Incompatible stack types: I4 vs Ref
			//IL_004c->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0071->IL0019: Incompatible stack types: I4 vs Ref
			//IL_008c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0057->IL0019: Incompatible stack types: I4 vs Ref
			//IL_009e->IL00a2: Incompatible stack heights: 1 vs 0
			//IL_03fd->IL00a2: Incompatible stack heights: 1 vs 0
			//IL_00d8->IL00a2: Incompatible stack heights: 2 vs 0
			//IL_0421->IL0425: Incompatible stack heights: 1 vs 0
			//IL_00f9->IL0108: Incompatible stack heights: 0 vs 1
			//IL_00e3->IL00a2: Incompatible stack heights: 2 vs 0
			//IL_03e5->IL00a2: Incompatible stack heights: 1 vs 0
			//IL_040f->IL00a2: Incompatible stack heights: 1 vs 0
			//IL_04ab->IL0425: Incompatible stack heights: 1 vs 0
			//IL_04d6->IL0425: Incompatible stack heights: 2 vs 0
			//IL_0501->IL0425: Incompatible stack heights: 3 vs 0
			//IL_04e8->IL0425: Incompatible stack heights: 2 vs 0
			//IL_04ba->IL0425: Incompatible stack heights: 1 vs 0
			//IL_0471->IL0425: Incompatible stack heights: 2 vs 0
			//IL_04c9->IL0425: Incompatible stack heights: 1 vs 0
			//IL_01a3->IL0108: Incompatible stack heights: 2 vs 1
			//IL_0191->IL0108: Incompatible stack heights: 4 vs 1
			//IL_0164->IL0108: Incompatible stack heights: 3 vs 1
			//IL_0181->IL0108: Incompatible stack heights: 3 vs 1
			//IL_0171->IL0108: Incompatible stack heights: 2 vs 1
			//IL_026f->IL0108: Incompatible stack heights: 3 vs 1
			//IL_021a->IL0108: Incompatible stack heights: 2 vs 1
			//IL_01c0->IL0108: Incompatible stack heights: 2 vs 1
			//IL_0254->IL0108: Incompatible stack heights: 2 vs 1
			//IL_01fd->IL0108: Incompatible stack heights: 0 vs 1
			//IL_04f3->IL0425: Incompatible stack heights: 2 vs 0
			//IL_047c->IL0425: Incompatible stack heights: 2 vs 0
			//IL_054d->IL0425: Incompatible stack heights: 3 vs 0
			//IL_0540->IL0540: Incompatible stack heights: 3 vs 2
			//IL_0425->IL0425: Incompatible stack heights: 4 vs 0
			//IL_0290->IL0108: Incompatible stack heights: 2 vs 1
			//IL_01ae->IL0108: Incompatible stack heights: 2 vs 1
			//IL_0225->IL0108: Incompatible stack heights: 2 vs 1
			//IL_01cb->IL0108: Incompatible stack heights: 2 vs 1
			//IL_025f->IL0108: Incompatible stack heights: 2 vs 1
			//IL_02ba->IL0108: Incompatible stack heights: 3 vs 1
			//IL_052f->IL0425: Incompatible stack heights: 1 vs 0
			//IL_029b->IL0108: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			ref _003CRefresh_003Ed__47 reference = ref *(_003CRefresh_003Ed__47*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 1u:
					return;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (3 != 0)
					{
						reference = ref *(_003CRefresh_003Ed__47*)2;
					}
					break;
				default:
					reference = ref this;
					if (true)
					{
						reference = ref *(_003CRefresh_003Ed__47*)null;
					}
					break;
				case 2u:
					_ = -2;
					if (false)
					{
						_ = 0;
					}
					break;
				case 5u:
					if (obj != null)
					{
						_ = 6;
						goto IL_00a2;
					}
					goto IL_03e5;
				case 3u:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(_003CRefresh_003Ed__47*)5;
						break;
					}
					IL_03e5:
					if (0 == 0)
					{
						_ = 0;
					}
					goto IL_00a2;
					IL_00a2:
					while (true)
					{
						int num;
						switch ((int)/*Error near IL_00c3: Stack underflow*/)
						{
						case 5:
							break;
						case 3:
							_ = 1;
							if (2 != 0)
							{
								_ = 1;
							}
							continue;
						case 1:
							if ((nint)obj != 1)
							{
								if (1 == 0)
								{
									num = 11;
								}
								goto IL_0108;
							}
							goto IL_0234;
						case 4:
							if (1 == 0)
							{
								_ = 0;
							}
							continue;
						case 2:
							goto IL_03e5;
						case 6:
							if ((nint)obj != 1)
							{
								_ = 3;
								continue;
							}
							goto case 4;
						default:
							{
								if (obj != null)
								{
									_ = 9;
									goto IL_0425;
								}
								goto IL_0490;
							}
							IL_0490:
							obj = (object)Unsafe.AsPointer(ref this);
							if (0 == 0)
							{
								_ = 0;
							}
							goto IL_0425;
							IL_0108:
							while (true)
							{
								switch (num)
								{
								case 4:
									return;
								case 10:
									break;
								case 3:
									_ = 2;
									continue;
								case 6:
									_ = 9;
									continue;
								case 5:
									_ = 8;
									continue;
								case 2:
									_ = ref obj;
									_ = 4;
									continue;
								case 1:
									if (0 == 0)
									{
										_ = 0;
									}
									continue;
								case 9:
									obj = -1;
									if (16 != 0)
									{
										_ = 12;
									}
									continue;
								case 13:
									if (&obj == null)
									{
										num = 7;
										continue;
									}
									goto case 16;
								case 16:
									obj = (object)(&obj);
									if (12 != 0)
									{
										num = 4;
									}
									continue;
								case 8:
									if (1 == 0)
									{
										_ = 1;
									}
									continue;
								case 11:
									obj = (object)/*Error near IL_022a: Stack underflow*/;
									num = 13;
									continue;
								case 15:
									goto IL_0234;
								case 12:
									if (5 == 0)
									{
										_ = 0;
									}
									continue;
								case 7:
									obj = 1;
									_ = 3;
									continue;
								default:
								{
									object obj3 = obj;
									if (9 == 0)
									{
										_ = 14;
									}
									continue;
								}
								case 14:
								{
									object obj2 = obj;
									_ = 10;
									continue;
								}
								}
								break;
							}
							break;
							IL_0425:
							while (true)
							{
								switch ((int)/*Error near IL_045a: Stack underflow*/)
								{
								case 8:
									return;
								case 11:
									break;
								case 6:
									obj = 0;
									if (0 == 0)
									{
										_ = 1;
									}
									continue;
								case 10:
									_ = ref obj;
									obj = 8;
									continue;
								case 5:
									goto IL_0490;
								case 4:
									obj = (object)(&obj);
									_ = 7;
									continue;
								case 9:
									obj = (object)/*Error near IL_04bf: Stack underflow*/;
									_ = 2;
									continue;
								default:
									_ = 3;
									continue;
								case 3:
									obj = -1;
									if (0 == 0)
									{
										_ = 4;
									}
									continue;
								case 1:
									_ = 10;
									continue;
								case 2:
									if (&obj == null)
									{
										if (0 == 0)
										{
											_ = 6;
										}
										continue;
									}
									goto case 4;
								case 7:
									if (obj == null)
									{
										_ = null;
									}
									_ = 11;
									continue;
								}
								break;
							}
							goto case 4;
							IL_0234:
							obj = (object)Unsafe.AsPointer(ref this);
							num = 6;
							goto IL_0108;
						}
						break;
					}
					goto case 2u;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00萀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778754, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00蔀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00蘀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00蜀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778755, new IntPtr(2737336163692L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00蠀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00褀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778752, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[CompilerGenerated]
	private Func<InfoBarDelegate>? m_GetInfoBar;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? refreshCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand<string>? copyTextCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? copyInviteCodeCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? copyInviteUrlCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<string>? redeemSelfCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<string>? redeemPointsCommand;

	internal static ReferralViewModel TestArgument;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public string Username
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00瀀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00䈀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public int UserId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00_FF00䨀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00簀((uint)value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string InviteCode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00爀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00䠀(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string InviteUrl
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00琀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00蔀(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[NotifyPropertyChangedFor("CanRedeem")]
	public int TotalPoints
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00_FF00縀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00崀((uint)value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int CustomerCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00_FF00嬀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00䔀((uint)value);
		}
	}

	public bool CanRedeem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00㨀() != 0;
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public bool IsLoading
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00渀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00一(value ? ((byte)1) : ((byte)0));
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
			return (int)_FF00_FF00_FF00耀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00怀((uint)value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ObservableCollection<ReferralEarningModel> Earnings
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00蘀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00儀(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ObservableCollection<ReferralCustomerModel> Customers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00㤀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00戀(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ObservableCollection<ReferralRedeemOption> RedeemOptions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00搀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00氀(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand RefreshCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_FF00_FF00樀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand<string> CopyTextCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00吀();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IRelayCommand CopyInviteCodeCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IRelayCommand)_FF00_FF00_FF00䘀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand CopyInviteUrlCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IRelayCommand)_FF00_FF00_FF00䜀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<string> RedeemSelfCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00㰀();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand<string> RedeemPointsCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00䴀();
		}
	}

	public event Func<InfoBarDelegate>? GetInfoBar
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00_FF00_FF00㼀(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00_FF00_FF00茀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ReferralViewModel()
	{
		//IL_007e: Expected I4, but got Obj
		//IL_00ca: Expected Obj, but got I4
		//IL_0058->IL0061: Incompatible stack types: I4 vs Obj
		//IL_00fa->IL0061: Incompatible stack heights: 10 vs 9
		//IL_0093->IL0061: Incompatible stack heights: 10 vs 9
		//IL_00c1->IL009e: Incompatible stack heights: 7 vs 8
		//IL_00b9->IL0061: Incompatible stack types: I4 vs Obj
		//IL_009e->IL0061: Incompatible stack heights: 10 vs 9
		//IL_0061->IL0061: Incompatible stack heights: 8 vs 9
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = 1;
		ReferralViewModel referralViewModel = this;
		if (false)
		{
			referralViewModel = (ReferralViewModel)0;
		}
		while (true)
		{
			switch ((int)referralViewModel)
			{
			case 2:
			case 4:
				_ = null;
				if (1 == 0)
				{
					_ = 0;
				}
				break;
			case 3:
				referralViewModel = this;
				if (4 == 0)
				{
					referralViewModel = (ReferralViewModel)0;
				}
				break;
			case 1:
				return;
			case 5:
				if (this == null)
				{
					object obj = 2;
					break;
				}
				goto case 3;
			default:
				_ = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefresh_003Ed__47))]
	[RelayCommand]
	private object Refresh()
	{
		return _FF00_FF00_FF00昀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	private void CopyText(object text)
	{
		_FF00_FF00_FF00嘀(text);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	private void CopyInviteCode()
	{
		_FF00_FF00_FF00䰀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	private void CopyInviteUrl()
	{
		_FF00_FF00_FF00眀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedeemSelf_003Ed__51))]
	[RelayCommand]
	private object RedeemSelf(object productCode)
	{
		return _FF00_FF00_FF00最(productCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CRedeemPoints_003Ed__52))]
	private object RedeemPoints(object productCode)
	{
		return _FF00_FF00_FF00圀(productCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnUserChanged(object user)
	{
		_FF00_FF00_FF00匀(user);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InfoBar(object text, InfoBarSeverity severity = (InfoBarSeverity)0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_FF00_FF00_FF00䌀(text, severity);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		_FF00_FF00_FF00㸀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectOrderedPredicate()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ReferralViewModel ReflectVisualStub()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<ReferralCustomerModel> _FF00_FF00_FF00㠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778447, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<ReferralCustomerModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ObservableCollection<ReferralCustomerModel> _FF00_FF00_FF00㤀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<ReferralCustomerModel>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00㨀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((nint)this >= 200) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<string> _FF00_FF00_FF00㬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778444, new IntPtr(2737336180332L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<string> _FF00_FF00_FF00㰀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18131, 1790778445, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778445, new IntPtr(2737336188652L), 15);
		}
		return (IAsyncRelayCommand<string>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00㴀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778442, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00㸀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
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
			case 2:
				return;
			default:
				obj2 = this;
				if (2 != 0)
				{
					obj2 = 2;
				}
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
	internal void _FF00_FF00_FF00㼀(Func<InfoBarDelegate> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00a4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0050->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00af->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0076->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0094->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005b->IL0019: Incompatible stack types: I4 vs Obj
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
				if (obj == obj)
				{
					if (false)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 2;
			case 3:
				obj = this;
				if (2 == 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
				obj2 = obj;
				obj = P_0;
				if (5 == 0)
				{
					obj2 = 1;
				}
				break;
			case 2:
				obj = obj;
				if (0 == 0)
				{
					obj2 = 4;
				}
				break;
			case 0:
				return;
			case 5:
				obj = obj;
				if (false)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00䀀(Func<InfoBarDelegate> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778443, new IntPtr(2737336189692L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00䄀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778440, new IntPtr(2737336182412L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00䈀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008f->IL0099: Incompatible stack heights: 1 vs 0
		//IL_0051->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0085->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0099->IL0019: Incompatible stack heights: 2 vs 1
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
				if (false)
				{
					_ = 1;
				}
				break;
			case 2:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				obj2 = this;
				if (false)
				{
					obj2 = 4;
				}
				break;
			case 3:
				if (P_0 == null)
				{
					_ = 2;
					break;
				}
				return;
			case 4:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00䌀(object P_0, InfoBarSeverity P_1)
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
				else if (2 != 0)
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
	private unsafe void _FF00_FF00_FF00䐀(object P_0, InfoBarSeverity P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778441, new IntPtr(2737336189692L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00䔀(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0084: Expected Obj, but got I4
		//IL_00a4->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0097->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007b->IL0097: Incompatible stack heights: 1 vs 0
		//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0089->IL0015: Incompatible stack heights: 1 vs 0
		//IL_0071->IL0019: Incompatible stack heights: 2 vs 1
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
				case 2:
					return;
				case 4:
					if (true)
					{
						_ = 0;
					}
					continue;
				case 3:
					if (P_0 == 0)
					{
						break;
					}
					goto end_IL_0019;
				case 5:
					return;
				case 1:
					_ = 5;
					continue;
				}
				_ = 4;
				continue;
				end_IL_0019:
				break;
			}
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00䘀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18141, 1790778454, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778454, new IntPtr(2737336180332L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00䜀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18142, 1790778455, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778455, new IntPtr(2737336182412L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00䠀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_007e: Expected Obj, but got I4
		//IL_0083->IL0015: Incompatible stack heights: 2 vs 0
		//IL_005b->IL0083: Incompatible stack heights: 1 vs 0
		//IL_009e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0051->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0019: Incompatible stack types: I4 vs Obj
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
				default:
					return;
				case 3:
					obj2 = this;
					if (false)
					{
						obj2 = 1;
					}
					continue;
				case 4:
					obj2 = this;
					if (P_0 == null)
					{
						if (2 != 0)
						{
							obj2 = 3;
						}
						continue;
					}
					return;
				case 1:
					break;
				case 0:
					return;
				case 2:
					obj2 = this;
					if (false)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			}
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00䤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778452, new IntPtr(2737336177212L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00䨀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00䬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778453, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00䰀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0041->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006a->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				_ = 1;
				if (true)
				{
					_ = 2;
				}
				break;
			case 2:
				return;
			case 1:
				/*Error near IL_004e: Stack underflow*/;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<string> _FF00_FF00_FF00䴀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18148, 1790778450, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778450, new IntPtr(2737336175132L), 15);
		}
		return (IAsyncRelayCommand<string>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00一(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0098->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0089->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL007c: Incompatible stack heights: 1 vs 0
		//IL_006d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0053->IL0015: Incompatible stack heights: 1 vs 0
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
				case 5:
					if (P_0 != 0)
					{
						goto end_IL_0019;
					}
					goto case 3;
				case 4:
					return;
				case 3:
					_ = 2;
					continue;
				case 2:
					if (false)
					{
						_ = 0;
					}
					continue;
				case 1:
					return;
				}
				obj2 = this;
				if (true)
				{
					obj2 = 0;
				}
				continue;
				end_IL_0019:
				break;
			}
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00伀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778451, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00倀(ObservableCollection<ReferralEarningModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778448, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00儀(ObservableCollection<ReferralEarningModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00a3->IL0065: Incompatible stack heights: 1 vs 0
		//IL_008e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0099->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0064->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ba->IL0019: Incompatible stack types: I4 vs Obj
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
			case 4:
				obj2 = this;
				if (2 != 0)
				{
					obj2 = 2;
				}
				break;
			case 2:
				return;
			case 5:
				obj2 = this;
				if (3 != 0)
				{
					obj2 = 3;
				}
				break;
			case 3:
				if (4 != 0)
				{
					_ = 4;
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
	private unsafe void _FF00_FF00_FF00刀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778449, new IntPtr(2737336189692L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00匀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_005a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_003f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0065->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004a->IL0019: Incompatible stack heights: 2 vs 1
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
			case 2:
				if (1 == 0)
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
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IRelayCommand<string> _FF00_FF00_FF00吀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18155, 1790778462, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778462, new IntPtr(2737336183452L), 15);
		}
		return (IRelayCommand<string>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IRelayCommand<string> _FF00_FF00_FF00唀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778463, new IntPtr(2737336177212L), 15))(null, 0, new IntPtr(0L));
		return (IRelayCommand<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00嘀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_005e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0040->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0069->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			case 1:
				/*Error near IL_0030: Stack underflow*/;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				return;
			default:
				_ = 1;
				if (0 == 0)
				{
					_ = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00圀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18158, 1790778460, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778460, new IntPtr(2737336177212L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00堀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778461, new IntPtr(2737336185532L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00夀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00娀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778458, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00嬀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00尀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778459, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00崀(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_00d2: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I4
		//IL_00c6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d7->IL0015: Incompatible stack heights: 2 vs 0
		//IL_00b9->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004d->IL0064: Incompatible stack heights: 1 vs 0
		//IL_008f->IL0015: Incompatible stack heights: 1 vs 0
		//IL_007e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0064->IL0019: Incompatible stack types: I4 vs Obj
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
				case 5:
					obj2 = this;
					if (P_0 != 0)
					{
						if (0 == 0)
						{
							obj2 = 4;
						}
						continue;
					}
					goto default;
				default:
					obj2 = this;
					if (0 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 7:
					obj = 6;
					break;
				case 4:
					return;
				case 6:
					return;
				case 3:
					_ = 7;
					continue;
				case 1:
					_ = 2;
					continue;
				case 2:
					obj = 3;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00帀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778456, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00开(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778457, new IntPtr(2737336185532L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00怀(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0076->IL006b: Incompatible stack heights: 1 vs 0
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0051->IL0019: Incompatible stack heights: 2 vs 1
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
			case 4:
				if (false)
				{
					_ = 0;
				}
				break;
			case 1:
				obj2 = this;
				if (2 == 0)
				{
					obj2 = 4;
				}
				break;
			case 3:
				return;
			case 2:
				obj2 = this;
				if (P_0 != 0)
				{
					return;
				}
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			default:
				obj2 = this;
				if (3 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00愀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778790, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00戀(ObservableCollection<ReferralCustomerModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0043: Expected Obj, but got I4
		//IL_0058->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0048->IL0015: Incompatible stack heights: 1 vs 0
		//IL_006d->IL0048: Incompatible stack heights: 1 vs 0
		//IL_009e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0063->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0084->IL0019: Incompatible stack types: I4 vs Obj
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
				case 3:
					break;
				case 1:
					return;
				case 2:
					if (false)
					{
						_ = 0;
					}
					continue;
				case 4:
					obj2 = this;
					if (P_0 != null)
					{
						return;
					}
					if (1 == 0)
					{
						obj2 = 3;
					}
					continue;
				default:
					obj2 = this;
					if (1 == 0)
					{
						obj2 = 1;
					}
					continue;
				}
				break;
			}
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00挀(ObservableCollection<ReferralCustomerModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778791, new IntPtr(2737336189692L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ObservableCollection<ReferralRedeemOption> _FF00_FF00_FF00搀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<ReferralRedeemOption>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<ReferralRedeemOption> _FF00_FF00_FF00攀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778788, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<ReferralRedeemOption>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00昀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18173, 1790778789, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778789, new IntPtr(2737336185532L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00最(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18174, 1790778786, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778786, new IntPtr(2737336189692L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00栀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778787, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00椀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778784, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00樀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18177, 1790778785, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778785, new IntPtr(2737336157452L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00欀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778798, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00氀(ObservableCollection<ReferralRedeemOption> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0090: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		//IL_0095->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0041->IL0083: Incompatible stack heights: 1 vs 0
		//IL_0069->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0083->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004f->IL0015: Incompatible stack heights: 1 vs 0
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
				case 4:
					if (P_0 == null)
					{
						obj = 3;
						break;
					}
					return;
				case 2:
					obj2 = this;
					if (true)
					{
						obj2 = 1;
					}
					continue;
				case 3:
					obj2 = this;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 1:
					return;
				default:
					obj = 2;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00洀(ObservableCollection<ReferralRedeemOption> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778799, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00渀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00漀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778796, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00瀀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00焀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778797, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00爀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00猀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778794, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00琀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00甀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778795, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00瘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778792, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00眀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0041->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006a->IL0019: Incompatible stack heights: 2 vs 1
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
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 2:
				/*Error near IL_004e: Stack underflow*/;
				if (true)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00砀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778793, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00礀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778806, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00稀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00笀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778807, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00簀(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00ad->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0095->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0061->IL00a0: Incompatible stack heights: 1 vs 0
		//IL_0085->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006b->IL0019: Incompatible stack heights: 2 vs 1
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
			case 4:
				if (P_0 != 0)
				{
					_ = 3;
					continue;
				}
				break;
			case 1:
				obj2 = this;
				if (2 == 0)
				{
					obj2 = 5;
				}
				continue;
			case 5:
				return;
			case 2:
				if (false)
				{
					_ = 1;
				}
				continue;
			}
			_ = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00紀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778804, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00縀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00缀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778805, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00耀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00脀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778802, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00舀(Func<InfoBarDelegate> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778803, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00茀(Func<InfoBarDelegate> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0066->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0083->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0096->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0071->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ab->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00b6->IL0019: Incompatible stack types: I4 vs Obj
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
				obj = obj;
				if (4 != 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				obj = this;
				if (true)
				{
					obj2 = 1;
				}
				break;
			case 0:
				return;
			case 4:
				obj = P_0;
				_ = 5;
				break;
			case 5:
				obj = obj;
				_ = 3;
				break;
			case 3:
				if (obj == obj)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00萀(Func<InfoBarDelegate> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778800, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00蔀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_008c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004e->IL008c: Incompatible stack heights: 1 vs 0
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
			case 3:
				_ = 4;
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
			case 4:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 1:
				_ = 3;
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ObservableCollection<ReferralEarningModel> _FF00_FF00_FF00蘀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<ReferralEarningModel>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<ReferralEarningModel> _FF00_FF00_FF00蜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778801, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<ReferralEarningModel>)/*Error near IL_0033: Stack underflow*/;
	}
}
