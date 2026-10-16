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
using Mass.Domain.Desktop.Entities.Game;
using Mass.Domain.Desktop.Entities.NetGame;
using Mass.Domain.Desktop.Entities.RentalGame;
using Mass.Domain.Desktop.Interfaces;
using Mass.Domain.Value;
using Mass.Game.Launcher.Java;
using Mass.Game.Proxy;
using Matrix.Core.Java;
using WinRT;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.Models;

[WinRTExposedType(typeof(Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
public class DesktopGameModel : ObservableObject, ICloneable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddCharacter_003Ed__79 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<(bool isSuccess, bool needRetry)> _003C_003Et__builder;

		public string name;

		public DesktopGameModel _003C_003E4__this;

		public bool growl;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<EntityGameCharacter> _003C_003Eu__2;

		internal static object RunSynchronizer;

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
		internal static bool DecorateExpandableWrapper()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectHiddenProcessor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00萀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778955, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00蔀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_070e: Expected Obj, but got I4
			//IL_06e9: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_00f4: Expected Obj, but got I4
			//IL_011f: Expected I4, but got Obj
			//IL_065d: Expected Obj, but got I4
			//IL_0249: Expected Obj, but got Ref
			//IL_035e: Expected Obj, but got Ref
			//IL_0392: Expected Obj, but got Ref
			//IL_02c4: Expected Obj, but got I4
			//IL_02fa: Expected Obj, but got I4
			//IL_0420: Expected Obj, but got I4
			//IL_0403: Expected Obj, but got I4
			//IL_04af: Expected Obj, but got I4
			//IL_03d6: Expected Obj, but got I4
			//IL_01cc: Expected Obj, but got I4
			//IL_01d6: Expected Obj, but got I4
			//IL_0221: Expected Obj, but got Ref
			//IL_0389: Expected Obj, but got I4
			//IL_0713->IL0015: Incompatible stack heights: 2 vs 0
			//IL_06f5->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0058->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0700->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00ef->IL006f: Incompatible stack heights: 2 vs 1
			//IL_064d->IL006f: Incompatible stack heights: 0 vs 1
			//IL_00b9->IL006f: Incompatible stack heights: 0 vs 1
			//IL_0667->IL006f: Incompatible stack heights: 2 vs 1
			//IL_0253->IL012d: Incompatible stack types: I4 vs Ref
			//IL_0368->IL012d: Incompatible stack types: I4 vs Ref
			//IL_039e->IL012d: Incompatible stack heights: 0 vs 1
			//IL_0129->IL012d: Incompatible stack types: I4 vs Ref
			//IL_03a9->IL012d: Incompatible stack types: I4 vs Ref
			//IL_02d0->IL012d: Incompatible stack types: I4 vs Ref
			//IL_04cc->IL012d: Incompatible stack heights: 0 vs 1
			//IL_0378->IL012d: Incompatible stack heights: 4 vs 1
			//IL_02b4->IL012d: Incompatible stack heights: 2 vs 1
			//IL_0305->IL012d: Incompatible stack heights: 3 vs 1
			//IL_042b->IL012d: Incompatible stack heights: 3 vs 1
			//IL_0410->IL012d: Incompatible stack heights: 2 vs 1
			//IL_04ba->IL012d: Incompatible stack heights: 3 vs 1
			//IL_03b7->IL012d: Incompatible stack heights: 3 vs 1
			//IL_034f->IL012d: Incompatible stack heights: 0 vs 1
			//IL_01ea->IL012d: Incompatible stack heights: 2 vs 1
			//IL_01f7->IL012d: Incompatible stack heights: 2 vs 1
			//IL_03e1->IL012d: Incompatible stack heights: 3 vs 1
			//IL_0278->IL012d: Incompatible stack heights: 3 vs 1
			//IL_0295->IL012d: Incompatible stack heights: 3 vs 1
			//IL_043b->IL012d: Incompatible stack heights: 2 vs 1
			//IL_022b->IL012d: Incompatible stack heights: 2 vs 1
			//IL_0453->IL012d: Incompatible stack heights: 2 vs 1
			//IL_031e->IL012d: Incompatible stack heights: 3 vs 1
			//IL_03ef->IL012d: Incompatible stack heights: 3 vs 1
			//IL_02db->IL012d: Incompatible stack types: I4 vs Ref
			//IL_04d7->IL012d: Incompatible stack types: I4 vs Ref
			//IL_02bf->IL012d: Incompatible stack heights: 2 vs 1
			//IL_041b->IL012d: Incompatible stack heights: 2 vs 1
			//IL_038e->IL0129: Incompatible stack heights: 0 vs 2
			//IL_020b->IL012d: Incompatible stack heights: 0 vs 1
			//IL_0245->IL012d: Incompatible stack types: I4 vs Ref
			//IL_049f->IL012d: Incompatible stack heights: 0 vs 1
			//IL_035a->IL012d: Incompatible stack types: I4 vs Ref
			//IL_0283->IL012d: Incompatible stack heights: 3 vs 1
			//IL_012d->IL012d: Incompatible stack heights: 3 vs 1
			//IL_02a0->IL012d: Incompatible stack heights: 3 vs 1
			//IL_03d1->IL012d: Incompatible stack types: I4 vs Ref
			//IL_02f5->IL012d: Incompatible stack types: I4 vs Ref
			//IL_0446->IL012d: Incompatible stack heights: 2 vs 1
			//IL_0334->IL012d: Incompatible stack heights: 0 vs 1
			//IL_0216->IL012d: Incompatible stack types: I4 vs Ref
			//IL_04aa->IL012d: Incompatible stack types: I4 vs Ref
			//IL_033f->IL012d: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					int num;
					switch ((int)obj2)
					{
					case 4:
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 3;
						continue;
					case 5:
						_ = 2;
						continue;
					default:
						if ((nuint)(nint)obj <= (nuint)2u)
						{
							num = 8;
							goto IL_006f;
						}
						goto IL_063b;
					case 3:
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 2:
						return;
					case 1:
						break;
						IL_00e0:
						_ = 5;
						goto IL_006f;
						IL_006f:
						while (true)
						{
							switch (num)
							{
							case 5:
							case 8:
								if (false)
								{
									num = 3;
								}
								continue;
							case 7:
								break;
							case 1:
								num = 0;
								obj = 0;
								if (2 == 0)
								{
									num = 2;
								}
								continue;
							case 3:
							{
								ref byte reference;
								switch ((int)obj)
								{
								default:
									reference = ref *(byte*)30;
									goto IL_012d;
								case 0:
									obj = (object)Unsafe.AsPointer(ref this);
									reference = ref *(byte*)13;
									goto IL_012d;
								case 1:
									goto IL_035a;
								case 2:
									goto IL_038e;
									IL_012d:
									while (true)
									{
										switch ((uint)Unsafe.AsPointer(ref reference))
										{
										case 24u:
											obj = 1;
											obj = 28;
											continue;
										case 19u:
										case 33u:
											_ = 4;
											continue;
										case 20u:
											_ = ref obj;
											_ = 33;
											continue;
										case 11u:
											if (&obj == null)
											{
												if (8 != 0)
												{
													reference = ref *(byte*)9;
												}
												continue;
											}
											goto case 27u;
										case 29u:
											obj = (object)Unsafe.AsPointer(ref this);
											_ = 10;
											continue;
										case 13u:
											reference = ref Unsafe.As<_003CAddCharacter_003Ed__79, byte>(ref this);
											if (7 == 0)
											{
												reference = ref *(byte*)null;
											}
											continue;
										case 17u:
											break;
										case 22u:
											_ = ref obj;
											if (34 != 0)
											{
												_ = 27;
											}
											continue;
										case 25u:
											_ = ref obj;
											if (6 == 0)
											{
												_ = 0;
											}
											continue;
										case 4u:
											_ = null;
											if (1 == 0)
											{
												_ = 1;
											}
											continue;
										default:
											obj = 0;
											reference = ref *(byte*)1;
											if (8 != 0)
											{
												reference = ref *(byte*)8;
											}
											continue;
										case 27u:
											reference = ref *(byte*)(&obj);
											if (0 == 0)
											{
												reference = ref *(byte*)null;
											}
											continue;
										case 5u:
											obj = -1;
											_ = 27;
											continue;
										case 32u:
											obj = obj;
											_ = 15;
											continue;
										case 30u:
											if ((nint)obj == 8)
											{
												if (29 != 0)
												{
													reference = ref *(byte*)28;
												}
												continue;
											}
											goto case 32u;
										case 18u:
											_ = ref obj;
											if (13 == 0)
											{
												reference = ref *(byte*)19;
											}
											continue;
										case 3u:
											goto IL_035a;
										case 2u:
											_ = ref obj;
											_ = 14;
											continue;
										case 10u:
											if (&obj == null)
											{
												obj = 12;
												continue;
											}
											goto case 20u;
										case 23u:
											goto IL_038e;
										case 16u:
											_ = 22;
											continue;
										case 26u:
											reference = ref Unsafe.As<_003CAddCharacter_003Ed__79, byte>(ref this);
											if (5 == 0)
											{
												reference = ref *(byte*)null;
											}
											continue;
										case 21u:
											obj = -1;
											_ = 18;
											continue;
										case 35u:
											_ = 25;
											continue;
										case 34u:
											return;
										case 9u:
											obj = 2;
											if (14 != 0)
											{
												_ = 35;
											}
											continue;
										case 7u:
											obj = -1;
											_ = 20;
											continue;
										case 28u:
											if (2 != 0)
											{
												_ = 1;
											}
											continue;
										case 31u:
											_ = 21;
											continue;
										case 6u:
											return;
										case 14u:
											return;
										case 15u:
											if (&obj == null)
											{
												if (24 != 0)
												{
													reference = ref *(byte*)21;
												}
												continue;
											}
											goto case 18u;
										case 12u:
											obj = 0;
											_ = 16;
											continue;
										case 1u:
											obj = obj;
											if (4 != 0)
											{
												reference = ref *(byte*)11;
											}
											continue;
										case 8u:
											goto end_IL_010e;
										}
										break;
									}
									goto case 0;
									IL_038e:
									obj = (object)Unsafe.AsPointer(ref this);
									if (11 != 0)
									{
										reference = ref *(byte*)26;
									}
									goto IL_012d;
									IL_035a:
									obj = (object)Unsafe.AsPointer(ref this);
									reference = ref *(byte*)31;
									goto IL_012d;
									end_IL_010e:
									break;
								}
								goto end_IL_0019;
							}
							default:
								goto IL_063b;
							case 6:
								_ = 0;
								obj = 0;
								_ = 4;
								continue;
							case 2:
							case 4:
								goto end_IL_0019;
							}
							break;
						}
						goto IL_00e0;
						IL_063b:
						if ((int)/*Error near IL_0641: Stack underflow*/ == 0)
						{
							if (true)
							{
								num = 0;
							}
							goto IL_006f;
						}
						goto IL_00e0;
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
		internal unsafe static byte _FF00_FF00_FF00蘀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778952, new IntPtr(2737336575116L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00蜀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00蠀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778953, new IntPtr(2737336586556L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00褀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778966, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00言()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00謀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00谀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778967, new IntPtr(2737336582396L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddRandomCharacter_003Ed__78 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public DesktopGameModel _003C_003E4__this;

		private nint _003Ci_003E5__2;

		private object _003CcharacterName_003E5__3;

		private TaskAwaiter<(bool isSuccess, bool needRetry)> _003C_003Eu__1;

		internal static object DefineRole;

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
		internal static bool ReflectGenericConverter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectRandomVerifier()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00礀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778964, new IntPtr(2737336590716L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00稀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0409: Expected Obj, but got Ref
			//IL_0424: Expected Obj, but got Ref
			//IL_0324: Expected Obj, but got I4
			//IL_02aa: Expected Obj, but got Ref
			//IL_0301: Expected Obj, but got Ref
			//IL_0304: Expected Obj, but got Ref
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Expected Obj, but got I4
			//IL_00e9: Expected Obj, but got I4
			//IL_0185: Expected Obj, but got Ref
			//IL_033f: Expected Obj, but got Ref
			//IL_043f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_045b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0415->IL0019: Incompatible stack heights: 0 vs 1
			//IL_042e->IL0019: Incompatible stack types: I4 vs Obj
			//IL_044a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0466->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0171->IL005e: Incompatible stack types: I4 vs Ref
			//IL_004f->IL005e: Incompatible stack heights: 0 vs 3
			//IL_0420->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00df->IL0164: Incompatible stack heights: 2 vs 0
			//IL_005a->IL005e: Incompatible stack heights: 1 vs 3
			//IL_0363->IL005e: Incompatible stack heights: 4 vs 3
			//IL_0270->IL005e: Incompatible stack heights: 4 vs 3
			//IL_0330->IL005e: Incompatible stack heights: 4 vs 3
			//IL_02b6->IL005e: Incompatible stack heights: 2 vs 3
			//IL_0310->IL005e: Incompatible stack heights: 2 vs 3
			//IL_0181->IL005e: Incompatible stack heights: 5 vs 3
			//IL_02d0->IL005e: Incompatible stack heights: 2 vs 3
			//IL_0245->IL005e: Incompatible stack heights: 4 vs 3
			//IL_01ca->IL005e: Incompatible stack heights: 4 vs 3
			//IL_02fa->IL005e: Incompatible stack heights: 6 vs 3
			//IL_01e5->IL005e: Incompatible stack heights: 4 vs 3
			//IL_011a->IL005e: Incompatible stack heights: 4 vs 3
			//IL_00f4->IL005e: Incompatible stack heights: 5 vs 3
			//IL_0191->IL005e: Incompatible stack heights: 2 vs 3
			//IL_01fd->IL005e: Incompatible stack types: I4 vs Ref
			//IL_034b->IL005e: Incompatible stack heights: 2 vs 3
			//IL_0374->IL005e: Incompatible stack types: I4 vs Ref
			//IL_027b->IL005e: Incompatible stack heights: 4 vs 3
			//IL_033b->IL005e: Incompatible stack heights: 4 vs 3
			//IL_02c1->IL005e: Incompatible stack heights: 2 vs 3
			//IL_031b->IL005e: Incompatible stack heights: 2 vs 3
			//IL_022c->IL005e: Incompatible stack heights: 2 vs 3
			//IL_02db->IL005e: Incompatible stack heights: 2 vs 3
			//IL_01d5->IL005e: Incompatible stack heights: 4 vs 3
			//IL_0146->IL005e: Incompatible stack types: I4 vs Ref
			//IL_01f0->IL005e: Incompatible stack heights: 4 vs 3
			//IL_0125->IL005e: Incompatible stack heights: 4 vs 3
			//IL_0218->IL005e: Incompatible stack types: I4 vs Ref
			//IL_019c->IL005e: Incompatible stack heights: 2 vs 3
			//IL_0356->IL005e: Incompatible stack heights: 2 vs 3
			//IL_0159->IL005e: Incompatible stack heights: 2 vs 3
			//IL_0237->IL005e: Incompatible stack heights: 2 vs 3
			//IL_0164->IL005e: Incompatible stack heights: 2 vs 3
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				ref _003CAddRandomCharacter_003Ed__78 reference;
				switch ((int)obj2)
				{
				case 3:
					if (obj == null)
					{
						if (13 != 0)
						{
							_ = 21;
						}
						goto IL_005e;
					}
					goto IL_0164;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					if (3 != 0)
					{
						obj2 = 3;
					}
					continue;
				case 5:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 4;
					continue;
				default:
					if (0 == 0)
					{
						_ = 1;
					}
					continue;
				case 1:
					return;
				case 2:
					break;
					IL_0164:
					_ = 0;
					reference = ref *(_003CAddRandomCharacter_003Ed__78*)19;
					goto IL_005e;
					IL_005e:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 20u:
							obj = -1;
							_ = 8;
							continue;
						case 7u:
							return;
						case 18u:
							_ = 5;
							_ = null;
							if (11 == 0)
							{
								_ = 7;
							}
							continue;
						case 15u:
						case 19u:
							if ((nint)Unsafe.AsPointer(ref this) < (nint)5)
							{
								reference = ref *(_003CAddRandomCharacter_003Ed__78*)30;
								continue;
							}
							goto case 12u;
						case 28u:
							if (obj != null)
							{
								if (2 == 0)
								{
									_ = 24;
								}
								continue;
							}
							goto default;
						case 27u:
							break;
						case 9u:
							_ = obj + 1;
							_ = 15;
							continue;
						case 24u:
							obj = (object)Unsafe.AsPointer(ref this);
							if (6 == 0)
							{
								_ = 6;
							}
							continue;
						case 13u:
							obj = 0;
							if (9 == 0)
							{
								_ = 16;
							}
							continue;
						case 16u:
							if (8 == 0)
							{
								_ = 14;
							}
							continue;
						case 25u:
							obj = null;
							reference = ref *(_003CAddRandomCharacter_003Ed__78*)17;
							continue;
						case 22u:
						case 30u:
							reference = ref this;
							if (4 != 0)
							{
								reference = ref *(_003CAddRandomCharacter_003Ed__78*)3;
							}
							continue;
						case 10u:
							if (&obj != null)
							{
								if (23 == 0)
								{
									_ = 13;
								}
								continue;
							}
							goto case 13u;
						case 12u:
							_ = 5;
							_ = 18;
							continue;
						case 2u:
						case 3u:
							_ = null;
							if (26 == 0)
							{
								_ = 22;
							}
							continue;
						case 5u:
						case 21u:
							obj = (object)Unsafe.AsPointer(ref this);
							if (1 == 0)
							{
								_ = 1;
							}
							continue;
						case 11u:
							obj = null;
							if (29 == 0)
							{
								_ = 24;
							}
							continue;
						case 14u:
							_ = ref obj;
							_ = 7;
							continue;
						case 8u:
						case 23u:
							obj = (object)(&obj);
							obj = (object)(&obj);
							if (6 == 0)
							{
								_ = 28;
							}
							continue;
						case 4u:
							obj = 0;
							if (10 != 0)
							{
								_ = 10;
							}
							continue;
						case 26u:
							obj = (object)Unsafe.AsPointer(ref this);
							if (9 == 0)
							{
								_ = 2;
							}
							continue;
						case 1u:
							_ = 20;
							continue;
						default:
							if (obj != null)
							{
								reference = ref *(_003CAddRandomCharacter_003Ed__78*)2;
								continue;
							}
							goto case 25u;
						case 6u:
						case 17u:
						case 29u:
							goto end_IL_0019;
						}
						break;
					}
					goto IL_0164;
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
		internal unsafe static byte _FF00_FF00_FF00笀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778965, new IntPtr(2737336604236L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00簀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00紀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00縀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778962, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00缀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00耀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778963, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CFastStart_003Ed__80 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopGameModel _003C_003E4__this;

		private object _003C_003E8__1;

		private TaskAwaiter<string?> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private static object ReflectCustomAnnotation;

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
		internal static bool EncodeSolver()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ExcludeTester()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00漀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778960, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00瀀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_005e: Expected Obj, but got Ref
			//IL_0043: Expected Obj, but got Ref
			//IL_00ae: Expected Obj, but got I4
			//IL_03c3: Expected Obj, but got Ref
			//IL_0343: Expected Obj, but got Ref
			//IL_0261: Expected Obj, but got Ref
			//IL_02b7: Expected Obj, but got I4
			//IL_029f: Expected Obj, but got I4
			//IL_03ec: Expected Obj, but got I4
			//IL_037c: Expected Obj, but got I4
			//IL_02c1: Expected Obj, but got I4
			//IL_0068->IL0019: Incompatible stack types: I4 vs Obj
			//IL_004f->IL0019: Incompatible stack heights: 0 vs 1
			//IL_009d->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0085->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0075->IL0019: Incompatible stack heights: 2 vs 1
			//IL_005a->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0090->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00b7->IL00b7: Incompatible stack heights: 1 vs 0
			//IL_03da->IL00b7: Incompatible stack heights: 1 vs 0
			//IL_019c->IL00b7: Incompatible stack heights: 1 vs 0
			//IL_0314->IL00b7: Incompatible stack heights: 1 vs 0
			//IL_03b4->IL00b7: Incompatible stack heights: 1 vs 0
			//IL_03e7->IL00b7: Incompatible stack heights: 2 vs 0
			//IL_01cd->IL00b7: Incompatible stack heights: 2 vs 0
			//IL_0200->IL00b7: Incompatible stack heights: 4 vs 0
			//IL_02bc->IL00b3: Incompatible stack heights: 2 vs 0
			//IL_0395->IL00b7: Incompatible stack heights: 3 vs 0
			//IL_02aa->IL00b7: Incompatible stack heights: 3 vs 0
			//IL_02de->IL00b7: Incompatible stack heights: 3 vs 0
			//IL_03f7->IL00b7: Incompatible stack heights: 3 vs 0
			//IL_0387->IL00b7: Incompatible stack heights: 3 vs 0
			//IL_02cc->IL00b7: Incompatible stack heights: 3 vs 0
			//IL_0172->IL00b7: Incompatible stack heights: 2 vs 0
			//IL_03a5->IL00b7: Incompatible stack heights: 4 vs 0
			//IL_022c->IL00b7: Incompatible stack heights: 2 vs 0
			//IL_02fa->IL00b7: Incompatible stack heights: 2 vs 0
			//IL_031f->IL00b7: Incompatible stack heights: 1 vs 0
			//IL_035a->IL00b7: Incompatible stack heights: 1 vs 0
			//IL_0278->IL00b7: Incompatible stack heights: 1 vs 0
			//IL_03bf->IL00b7: Incompatible stack heights: 1 vs 0
			//IL_02e9->IL00b7: Incompatible stack heights: 3 vs 0
			//IL_017d->IL00b7: Incompatible stack heights: 2 vs 0
			//IL_0377->IL00b7: Incompatible stack heights: 1 vs 0
			//IL_0305->IL00b7: Incompatible stack heights: 2 vs 0
			//IL_01ec->IL00b7: Incompatible stack heights: 1 vs 0
			//IL_021f->IL00b7: Incompatible stack heights: 1 vs 0
			//IL_01b9->IL00b7: Incompatible stack heights: 1 vs 0
			//IL_033e->IL00b7: Incompatible stack heights: 1 vs 0
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
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						obj2 = 0;
					}
					break;
				default:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 3;
					break;
				case 6:
					_ = 4;
					break;
				case 5:
					_ = -2;
					if (2 != 0)
					{
						_ = 2;
					}
					break;
				case 2:
					_ = null;
					_ = 6;
					break;
				case 3:
					if (obj == null)
					{
						obj = 31;
						goto IL_00b7;
					}
					goto IL_017d;
				case 4:
					return;
					IL_017d:
					if ((nint)obj != 1)
					{
						if (5 != 0)
						{
							_ = 3;
						}
						goto IL_00b7;
					}
					goto IL_03bf;
					IL_03bf:
					obj = (object)Unsafe.AsPointer(ref this);
					if (true)
					{
						_ = 1;
					}
					goto IL_00b7;
					IL_00b7:
					while (true)
					{
						switch ((int)/*Error near IL_013c: Stack underflow*/)
						{
						case 22:
							_ = null;
							if (23 != 0)
							{
								_ = 14;
							}
							continue;
						case 18:
							goto IL_017d;
						case 21:
							if ((int)/*Error near IL_01a2: Stack underflow*/ == 0)
							{
								if (false)
								{
									_ = 0;
								}
								continue;
							}
							goto case 22;
						case 7:
							obj = obj;
							_ = 10;
							continue;
						case 10:
							if (&obj == null)
							{
								if (20 != 0)
								{
									_ = 10;
								}
								continue;
							}
							goto case 6;
						case 8:
							_ = 1;
							_ = 7;
							continue;
						case 14:
							if (&obj != null)
							{
								if (24 != 0)
								{
									_ = 5;
								}
								continue;
							}
							goto case 19;
						case 27:
							_ = 13;
							continue;
						case 2:
							return;
						case 28:
							return;
						case 4:
						case 31:
							obj = (object)Unsafe.AsPointer(ref this);
							if (27 == 0)
							{
								_ = 16;
							}
							continue;
						case 13:
							obj = -1;
							_ = 3;
							continue;
						case 9:
							obj = 15;
							continue;
						case 20:
							obj = 1;
							_ = 11;
							continue;
						case 15:
							_ = ref obj;
							if (27 == 0)
							{
								_ = 28;
							}
							continue;
						case 30:
							if (29 != 0)
							{
								_ = 29;
							}
							continue;
						case 1:
							if (14 == 0)
							{
								_ = 17;
							}
							continue;
						case 29:
							if (Unsafe.AsPointer(ref this) == null)
							{
								if (4 != 0)
								{
									_ = 16;
								}
								continue;
							}
							goto case 8;
						case 3:
						case 24:
							obj = (object)(&obj);
							if (30 == 0)
							{
								_ = 10;
							}
							continue;
						case 23:
							obj = obj;
							if (6 == 0)
							{
								_ = 14;
							}
							continue;
						case 19:
							obj = 0;
							_ = 9;
							continue;
						case 11:
							_ = 25;
							continue;
						case 25:
							_ = ref obj;
							_ = 2;
							continue;
						case 5:
							if (21 == 0)
							{
								_ = 14;
							}
							continue;
						case 26:
							goto IL_03bf;
						case 6:
							_ = ref obj;
							_ = 12;
							continue;
						case 17:
							obj = -1;
							_ = 6;
							continue;
						}
						break;
					}
					goto case 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00焀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778961, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00爀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00猀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778974, new IntPtr(2737336590716L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00琀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778975, new IntPtr(2737336596956L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00甀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00瘀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00眀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778972, new IntPtr(2737336591756L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLaunchGame_003Ed__82 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopGameModel _003C_003E4__this;

		public SectionValue gameValue;

		public SectionValue proxyValue;

		private object _003CgameId_003E5__2;

		private object _003Cname_003E5__3;

		private TaskAwaiter<JavaGame> _003C_003Eu__1;

		private TaskAwaiter<(bool IsConfirmed, string Text)> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		internal static object DecorateMixedCommand;

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
		internal static bool DecorateFlexibleConsumer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PresentDecryptor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00昀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778973, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00最()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_003e: Expected I4, but got Obj
			//IL_0b2f: Expected Obj, but got Ref
			//IL_0066: Expected Obj, but got Ref
			//IL_005d: Expected Obj, but got I4
			//IL_083e: Expected Obj, but got Ref
			//IL_087a: Expected Obj, but got I4
			//IL_09d5: Expected Obj, but got I4
			//IL_089f: Expected Obj, but got I4
			//IL_08b6: Expected Obj, but got I4
			//IL_015d: Expected Obj, but got I4
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f6: Invalid comparison between Unknown and I4
			//IL_0858: Expected Obj, but got I4
			//IL_0861: Expected Obj, but got I4
			//IL_0226: Expected I4, but got Obj
			//IL_071b: Expected Obj, but got Ref
			//IL_0542: Expected Obj, but got Ref
			//IL_0374: Expected Obj, but got Ref
			//IL_0a43: Expected Obj, but got I4
			//IL_067c: Expected Obj, but got I4
			//IL_06b6: Expected Obj, but got I4
			//IL_04a6: Expected Obj, but got Ref
			//IL_04af: Expected Obj, but got I4
			//IL_0699: Expected Obj, but got I4
			//IL_0627: Expected Obj, but got Ref
			//IL_0400: Expected Obj, but got I4
			//IL_0355: Expected Obj, but got I4
			//IL_04d9: Expected Obj, but got Ref
			//IL_0739: Expected Obj, but got Ref
			//IL_073c: Expected Obj, but got Ref
			//IL_0778: Expected Obj, but got Ref
			//IL_0317: Expected Obj, but got Ref
			//IL_03c7: Expected Obj, but got I4
			//IL_008a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0b3b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0072->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0062->IL0015: Incompatible stack heights: 2 vs 0
			//IL_0051->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0b55->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0b46->IL0019: Incompatible stack types: I4 vs Obj
			//IL_007d->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0b60->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0a69->IL00ae: Incompatible stack heights: 1 vs 0
			//IL_00aa->IL00ae: Incompatible stack heights: 1 vs 0
			//IL_0855->IL00ae: Incompatible stack heights: 1 vs 0
			//IL_09a0->IL0a48: Incompatible stack heights: 1 vs 0
			//IL_0887->IL00ae: Incompatible stack heights: 2 vs 0
			//IL_0212->IL00ae: Incompatible stack heights: 2 vs 0
			//IL_0a7b->IL00ae: Incompatible stack heights: 2 vs 0
			//IL_08eb->IL00ae: Incompatible stack heights: 2 vs 0
			//IL_09ea->IL00ae: Incompatible stack heights: 3 vs 0
			//IL_0a32->IL00ae: Incompatible stack heights: 4 vs 0
			//IL_0168->IL00ae: Incompatible stack heights: 3 vs 0
			//IL_0a57->IL00ae: Incompatible stack heights: 2 vs 0
			//IL_0178->IL00ae: Incompatible stack heights: 3 vs 0
			//IL_0a22->IL00ae: Incompatible stack heights: 1 vs 0
			//IL_0198->IL00ae: Incompatible stack heights: 2 vs 0
			//IL_08b3->IL00ae: Incompatible stack heights: 2 vs 0
			//IL_0866->IL00aa: Incompatible stack heights: 0 vs 2
			//IL_09aa->IL00ae: Incompatible stack heights: 2 vs 0
			//IL_0892->IL00ae: Incompatible stack heights: 2 vs 0
			//IL_0a86->IL00ae: Incompatible stack heights: 2 vs 0
			//IL_0a08->IL00ae: Incompatible stack heights: 1 vs 0
			//IL_097a->IL00ae: Incompatible stack heights: 1 vs 0
			//IL_01f1->IL00ae: Incompatible stack heights: 1 vs 0
			//IL_0941->IL00ae: Incompatible stack heights: 1 vs 0
			//IL_0924->IL00ae: Incompatible stack heights: 1 vs 0
			//IL_00ae->IL00ae: Incompatible stack heights: 3 vs 0
			//IL_08cd->IL00ae: Incompatible stack heights: 1 vs 0
			//IL_01a9->IL00ae: Incompatible stack heights: 1 vs 0
			//IL_01c5->IL00ae: Incompatible stack heights: 1 vs 0
			//IL_0205->IL00ae: Incompatible stack heights: 1 vs 0
			//IL_0230->IL0234: Incompatible stack heights: 1 vs 0
			//IL_0a48->IL00aa: Incompatible stack heights: 0 vs 2
			//IL_0960->IL00ae: Incompatible stack heights: 1 vs 0
			//IL_0732->IL0234: Incompatible stack heights: 1 vs 0
			//IL_0559->IL0234: Incompatible stack heights: 1 vs 0
			//IL_038b->IL0234: Incompatible stack heights: 1 vs 0
			//IL_0689->IL0234: Incompatible stack heights: 2 vs 0
			//IL_07ad->IL0234: Incompatible stack heights: 2 vs 0
			//IL_0643->IL0234: Incompatible stack heights: 3 vs 0
			//IL_04c9->IL0234: Incompatible stack heights: 1 vs 0
			//IL_065b->IL0234: Incompatible stack heights: 2 vs 0
			//IL_039a->IL0234: Incompatible stack heights: 1 vs 0
			//IL_06c1->IL0234: Incompatible stack heights: 3 vs 0
			//IL_06a6->IL0234: Incompatible stack heights: 2 vs 0
			//IL_0631->IL0234: Incompatible stack heights: 5 vs 0
			//IL_040b->IL0234: Incompatible stack heights: 3 vs 0
			//IL_0360->IL0234: Incompatible stack heights: 3 vs 0
			//IL_0717->IL0234: Incompatible stack heights: 3 vs 0
			//IL_0592->IL0234: Incompatible stack heights: 4 vs 0
			//IL_04e3->IL0234: Incompatible stack heights: 4 vs 0
			//IL_06ed->IL0234: Incompatible stack heights: 1 vs 0
			//IL_0746->IL0234: Incompatible stack heights: 1 vs 0
			//IL_0782->IL0234: Incompatible stack heights: 1 vs 0
			//IL_0370->IL0234: Incompatible stack heights: 4 vs 0
			//IL_05ef->IL0234: Incompatible stack heights: 1 vs 0
			//IL_03b3->IL0234: Incompatible stack heights: 3 vs 0
			//IL_0321->IL0234: Incompatible stack heights: 1 vs 0
			//IL_03d4->IL0234: Incompatible stack heights: 2 vs 0
			//IL_05d5->IL0234: Incompatible stack heights: 2 vs 0
			//IL_0694->IL0234: Incompatible stack heights: 2 vs 0
			//IL_07b8->IL0234: Incompatible stack heights: 2 vs 0
			//IL_064e->IL0234: Incompatible stack heights: 3 vs 0
			//IL_05a4->IL0234: Incompatible stack heights: 1 vs 0
			//IL_03a5->IL0234: Incompatible stack heights: 1 vs 0
			//IL_0234->IL0234: Incompatible stack heights: 3 vs 0
			//IL_06b1->IL0234: Incompatible stack heights: 2 vs 0
			//IL_0350->IL0234: Incompatible stack heights: 1 vs 0
			//IL_0573->IL0234: Incompatible stack heights: 1 vs 0
			//IL_0333->IL0234: Incompatible stack heights: 1 vs 0
			//IL_079d->IL0234: Incompatible stack heights: 1 vs 0
			//IL_05fa->IL0234: Incompatible stack heights: 1 vs 0
			//IL_046f->IL0234: Incompatible stack heights: 1 vs 0
			//IL_03df->IL0234: Incompatible stack heights: 2 vs 0
			//IL_05e0->IL0234: Incompatible stack heights: 2 vs 0
			//IL_0618->IL0234: Incompatible stack heights: 1 vs 0
			//IL_05c3->IL0234: Incompatible stack heights: 1 vs 0
			//IL_0520->IL0234: Incompatible stack heights: 1 vs 0
			//IL_053e->IL0234: Incompatible stack heights: 1 vs 0
			//IL_0502->IL0234: Incompatible stack heights: 1 vs 0
			//IL_0764->IL0234: Incompatible stack heights: 1 vs 0
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
					case 6:
						_ = -2;
						_ = 3;
						continue;
					case 3:
						break;
					case 2:
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							obj2 = 1;
						}
						continue;
					default:
						_ = 4;
						continue;
					case 5:
						if ((nuint)(nint)obj <= (nuint)2u)
						{
							if (1 == 0)
							{
								_ = 8;
							}
							goto IL_00ae;
						}
						goto IL_0a57;
					case 4:
						return;
					case 1:
						obj = (object)Unsafe.AsPointer(ref this);
						if (5 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 7:
						{
							_ = null;
							if (false)
							{
								_ = 0;
							}
							continue;
						}
						IL_083a:
						obj = (object)Unsafe.AsPointer(ref this);
						if (13 == 0)
						{
							_ = 33;
						}
						goto IL_00ae;
						IL_00ae:
						while (true)
						{
							scoped ref _003CLaunchGame_003Ed__82 reference;
							object obj3;
							switch ((int)/*Error near IL_0153: Stack underflow*/)
							{
							case 2:
							case 15:
							case 21:
							case 23:
							case 37:
								break;
							case 24:
								obj = -1;
								_ = 4;
								continue;
							case 30:
								_ = 9;
								continue;
							case 33:
								_ = 24;
								continue;
							case 5:
							case 22:
								if (obj == null)
								{
									_ = 27;
									continue;
								}
								goto case 7;
							case 25:
								if (14 == 0)
								{
									_ = 14;
								}
								continue;
							case 12:
								if ((int)/*Error near IL_01e7: Stack underflow*/ == 0)
								{
									_ = 23;
									continue;
								}
								goto case 39;
							case 35:
								if (obj - 2 <= 1)
								{
									_ = 20;
									continue;
								}
								goto case 36;
							case 4:
								_ = ref obj;
								_ = 2;
								continue;
							case 38:
								switch ((int)obj)
								{
								default:
									_ = 46;
									goto IL_0234;
								case 2:
									goto IL_0370;
								case 1:
									goto IL_053e;
								case 0:
									goto IL_0717;
									IL_0234:
									while (true)
									{
										switch ((int)/*Error near IL_030d: Stack underflow*/)
										{
										case 37:
										case 43:
											break;
										case 48:
											obj = (object)(&obj);
											_ = 16;
											continue;
										case 29:
											if (&obj == null)
											{
												_ = 19;
												continue;
											}
											goto case 48;
										case 6:
										case 20:
											obj = obj;
											if (5 != 0)
											{
												_ = 31;
											}
											continue;
										case 25:
											obj = -1;
											_ = 38;
											continue;
										case 41:
											_ = ref obj;
											_ = 26;
											continue;
										case 3:
											goto IL_0370;
										case 12:
											if (11 == 0)
											{
												_ = 49;
											}
											continue;
										case 45:
											_ = 28;
											continue;
										case 44:
											return;
										case 49:
											obj = -1;
											if (13 != 0)
											{
												_ = 48;
											}
											continue;
										case 22:
											obj = -1;
											_ = 40;
											continue;
										case 46:
											obj = obj;
											if (2 != 0)
											{
												_ = 15;
											}
											continue;
										case 26:
											return;
										case 18:
											obj = (object)Unsafe.AsPointer(ref this);
											obj = 9;
											continue;
										case 8:
											obj = (object)/*Error near IL_04bf: Stack underflow*/;
											_ = 51;
											continue;
										case 33:
											obj = (object)Unsafe.AsPointer(ref this);
											_ = 11;
											continue;
										case 51:
											if (&obj == null)
											{
												if (0 == 0)
												{
													_ = 0;
												}
												continue;
											}
											goto case 38;
										case 31:
											if (obj == null)
											{
												if (25 == 0)
												{
													_ = 34;
												}
												continue;
											}
											goto case 24;
										case 36:
											if (obj == null)
											{
												if (17 == 0)
												{
													_ = 15;
												}
												continue;
											}
											goto case 18;
										case 30:
											goto IL_053e;
										case 24:
											obj = null;
											if (17 == 0)
											{
												_ = 23;
											}
											continue;
										case 28:
											_ = ref obj;
											_ = 44;
											continue;
										case 11:
											if (&obj != null)
											{
												_ = 47;
												continue;
											}
											goto case 13;
										case 23:
											if (obj == null)
											{
												if (1 == 0)
												{
													_ = 1;
												}
												continue;
											}
											goto case 8;
										case 17:
										case 50:
											_ = null;
											_ = null;
											if (5 == 0)
											{
												_ = 43;
											}
											continue;
										case 42:
											if (22 == 0)
											{
												_ = 22;
											}
											continue;
										case 15:
											if (obj == null)
											{
												if (6 == 0)
												{
													_ = 4;
												}
												continue;
											}
											goto case 33;
										case 1:
										case 21:
											obj = (object)Unsafe.AsPointer(ref this);
											_ = 29;
											continue;
										case 4:
											_ = ref obj;
											if (false)
											{
												_ = 5;
											}
											continue;
										case 10:
											_ = 25;
											continue;
										default:
											obj = 1;
											if (2 != 0)
											{
												_ = 0;
											}
											continue;
										case 19:
											obj = 2;
											if (45 != 0)
											{
												_ = 35;
											}
											continue;
										case 13:
											obj = 0;
											_ = 27;
											continue;
										case 34:
										case 35:
											obj = obj;
											_ = 36;
											continue;
										case 5:
											return;
										case 27:
											_ = 4;
											continue;
										case 7:
											goto IL_0717;
										case 38:
											obj = (object)(&obj);
											obj = (object)(&obj);
											_ = 52;
											continue;
										case 52:
											if (obj == null)
											{
												if (37 != 0)
												{
													_ = 21;
												}
												continue;
											}
											goto case 32;
										case 40:
										case 47:
											obj = (object)(&obj);
											_ = 39;
											continue;
										case 32:
											obj = obj;
											if (21 == 0)
											{
												_ = 4;
											}
											continue;
										case 2:
											if (1 == 0)
											{
												_ = 41;
											}
											continue;
										case 9:
										case 14:
										case 16:
										case 39:
											goto IL_09da;
										}
										break;
									}
									break;
									IL_0717:
									obj = (object)Unsafe.AsPointer(ref this);
									if (31 != 0)
									{
										_ = 42;
									}
									goto IL_0234;
									IL_0370:
									obj = (object)Unsafe.AsPointer(ref this);
									if (7 == 0)
									{
										_ = 12;
									}
									goto IL_0234;
									IL_053e:
									obj = (object)Unsafe.AsPointer(ref this);
									if (10 == 0)
									{
										_ = 4;
									}
									goto IL_0234;
								}
								break;
							case 29:
								goto IL_083a;
							case 36:
								obj = 0;
								obj = 22;
								continue;
							case 1:
								obj = 3;
								if (19 == 0)
								{
									_ = 13;
								}
								continue;
							case 19:
								reference = ref this;
								obj3 = obj;
								obj = 18;
								continue;
							case 34:
								_ = null;
								_ = 21;
								continue;
							case 20:
								obj = 1;
								if (0 == 0)
								{
									_ = 5;
								}
								continue;
							case 10:
							case 26:
								_ = 31;
								continue;
							case 11:
								return;
							case 14:
								obj = (object)/*Error near IL_090d: Stack underflow*/;
								if (35 == 0)
								{
									_ = 7;
								}
								continue;
							case 13:
							case 27:
								obj = obj;
								if (2 == 0)
								{
									_ = 3;
								}
								continue;
							case 3:
								if (&obj == null)
								{
									if (1 == 0)
									{
										_ = 1;
									}
									continue;
								}
								goto case 4;
							case 9:
								if (16 != 0)
								{
									_ = 25;
								}
								continue;
							default:
								if (Unsafe.AsPointer(ref this) == null)
								{
									_ = 26;
									continue;
								}
								goto case 28;
							case 17:
								reference = ref this;
								obj3 = obj;
								obj = 6;
								continue;
							case 16:
								goto IL_09da;
							case 7:
								_ = 1;
								if (15 == 0)
								{
									_ = 13;
								}
								continue;
							case 8:
							case 31:
								_ = 38;
								continue;
							case 18:
								_ = ref obj;
								_ = 11;
								continue;
							case 39:
								if (obj == null)
								{
									obj = 34;
									continue;
								}
								goto case 17;
							case 28:
								_ = null;
								_ = 37;
								continue;
							case 32:
								goto IL_0a57;
							case 6:
								{
									if (0 == 0)
									{
										_ = 0;
									}
									continue;
								}
								IL_09da:
								_ = 30;
								continue;
							}
							break;
						}
						goto case 6;
						IL_0a57:
						if ((nint)obj != 3)
						{
							_ = 12;
							goto IL_00ae;
						}
						goto IL_083a;
					}
					break;
				}
				_ = null;
				obj = 7;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00栀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778970, new IntPtr(2737336605276L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00椀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00樀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778971, new IntPtr(2737336600076L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00欀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00氀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778968, new IntPtr(2737336606316L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00洀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00渀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778969, new IntPtr(2737336596956L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLaunchShadowClient_003Ed__83 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ShadowJavaGameType type;

		public DesktopGameModel _003C_003E4__this;

		public SectionValue sectionValue;

		private TaskAwaiter<ShadowJavaGame> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		internal static object CombineError;

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
		internal static bool StartCache()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectPortableEmitter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00帀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779302, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00开()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_005a: Expected Obj, but got Ref
			//IL_0063: Expected Obj, but got I4
			//IL_003f: Expected Obj, but got Ref
			//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e4: Invalid comparison between Unknown and I4
			//IL_084a: Expected Obj, but got Ref
			//IL_0853: Expected Obj, but got I4
			//IL_0720: Expected Obj, but got I4
			//IL_0704: Expected Obj, but got Ref
			//IL_074e: Expected Obj, but got I4
			//IL_023c: Expected I4, but got Obj
			//IL_01f1: Expected Obj, but got I4
			//IL_0656: Expected Obj, but got I4
			//IL_07e1: Expected Obj, but got I4
			//IL_07ea: Expected Obj, but got I4
			//IL_039d: Expected Obj, but got Ref
			//IL_03c9: Expected Obj, but got Ref
			//IL_033e: Expected Obj, but got Ref
			//IL_0347: Expected Obj, but got I4
			//IL_04bb: Expected Obj, but got I4
			//IL_03ba: Expected I4, but got Obj
			//IL_03fa: Expected Obj, but got Ref
			//IL_045e: Expected Obj, but got I4
			//IL_0377: Expected Obj, but got I4
			//IL_0319: Expected I4, but got Obj
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0084->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0075->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0601->IL009a: Incompatible stack types: I4 vs Ref
			//IL_0096->IL009a: Incompatible stack types: I4 vs Ref
			//IL_07b7->IL009a: Incompatible stack heights: 0 vs 1
			//IL_069c->IL009a: Incompatible stack types: Obj vs Ref
			//IL_063f->IL009a: Incompatible stack heights: 0 vs 1
			//IL_0873->IL009a: Incompatible stack heights: 3 vs 1
			//IL_0592->IL009a: Incompatible stack types: Obj vs Ref
			//IL_072b->IL009a: Incompatible stack heights: 3 vs 1
			//IL_0281->IL0581: Incompatible stack heights: 1 vs 0
			//IL_0846->IL009a: Incompatible stack heights: 2 vs 1
			//IL_0710->IL009a: Incompatible stack heights: 0 vs 1
			//IL_0759->IL009a: Incompatible stack heights: 3 vs 1
			//IL_0865->IL009a: Incompatible stack types: I4 vs Ref
			//IL_06b4->IL009a: Incompatible stack types: I4 vs Ref
			//IL_01b8->IL009a: Incompatible stack heights: 0 vs 1
			//IL_0803->IL009a: Incompatible stack types: Obj vs Ref
			//IL_0767->IL009a: Incompatible stack heights: 2 vs 1
			//IL_0189->IL009a: Incompatible stack types: I4 vs Ref
			//IL_0883->IL009a: Incompatible stack types: I4 vs Ref
			//IL_081d->IL009a: Incompatible stack heights: 0 vs 1
			//IL_026d->IL080e: Incompatible stack heights: 1 vs 0
			//IL_07a5->IL009a: Incompatible stack heights: 4 vs 1
			//IL_0680->IL009a: Incompatible stack heights: 0 vs 1
			//IL_0258->IL009a: Incompatible stack heights: 0 vs 1
			//IL_01fd->IL009a: Incompatible stack heights: 0 vs 1
			//IL_065b->IL0096: Incompatible stack heights: 1 vs 0
			//IL_06f5->IL009a: Incompatible stack heights: 0 vs 1
			//IL_07c2->IL009a: Incompatible stack types: I4 vs Ref
			//IL_08ad->IL08b3: Incompatible stack heights: 0 vs 1
			//IL_06a7->IL009a: Incompatible stack types: I4 vs Ref
			//IL_021a->IL009a: Incompatible stack types: I4 vs Ref
			//IL_064a->IL009a: Incompatible stack types: I4 vs Ref
			//IL_009a->IL009a: Incompatible stack types: Obj vs Ref
			//IL_059d->IL009a: Incompatible stack types: I4 vs Ref
			//IL_066d->IL009a: Incompatible stack types: I4 vs Ref
			//IL_028b->IL009a: Incompatible stack heights: 2 vs 1
			//IL_05e4->IL009a: Incompatible stack types: I4 vs Ref
			//IL_05f6->IL009a: Incompatible stack types: I4 vs Ref
			//IL_071b->IL009a: Incompatible stack types: I4 vs Ref
			//IL_019d->IL009a: Incompatible stack heights: 0 vs 1
			//IL_03a7->IL02b0: Incompatible stack types: I4 vs Obj
			//IL_02ac->IL02b0: Incompatible stack types: I4 vs Obj
			//IL_01c3->IL009a: Incompatible stack types: I4 vs Ref
			//IL_080e->IL009a: Incompatible stack types: I4 vs Ref
			//IL_0895->IL009a: Incompatible stack heights: 0 vs 1
			//IL_078a->IL009a: Incompatible stack heights: 0 vs 1
			//IL_0828->IL009a: Incompatible stack types: I4 vs Ref
			//IL_0277->IL009a: Incompatible stack heights: 2 vs 1
			//IL_068b->IL009a: Incompatible stack types: I4 vs Ref
			//IL_0263->IL009a: Incompatible stack types: I4 vs Ref
			//IL_0246->IL009a: Incompatible stack types: I4 vs Ref
			//IL_0208->IL009a: Incompatible stack types: I4 vs Ref
			//IL_073e->IL009a: Incompatible stack heights: 0 vs 1
			//IL_0700->IL009a: Incompatible stack types: I4 vs Ref
			//IL_01a8->IL009a: Incompatible stack types: I4 vs Ref
			//IL_08a0->IL009a: Incompatible stack types: I4 vs Ref
			//IL_0795->IL009a: Incompatible stack types: I4 vs Ref
			//IL_0749->IL009a: Incompatible stack types: I4 vs Ref
			//IL_08c5->IL009a: Incompatible stack heights: 0 vs 1
			//IL_03d5->IL02b0: Incompatible stack heights: 0 vs 1
			//IL_0483->IL02b0: Incompatible stack heights: 2 vs 1
			//IL_033a->IL02b0: Incompatible stack heights: 3 vs 1
			//IL_03ed->IL02b0: Incompatible stack types: I4 vs Obj
			//IL_04c8->IL02b0: Incompatible stack heights: 2 vs 1
			//IL_038e->IL02b0: Incompatible stack heights: 3 vs 1
			//IL_0406->IL02b0: Incompatible stack heights: 2 vs 1
			//IL_035b->IL02b0: Incompatible stack heights: 0 vs 1
			//IL_04b6->IL02b0: Incompatible stack heights: 4 vs 1
			//IL_044a->IL02b0: Incompatible stack types: I4 vs Obj
			//IL_050c->IL02b0: Incompatible stack types: I4 vs Obj
			//IL_0421->IL02b0: Incompatible stack heights: 3 vs 1
			//IL_046b->IL02b0: Incompatible stack heights: 2 vs 1
			//IL_032c->IL02b0: Incompatible stack heights: 2 vs 1
			//IL_08d0->IL009a: Incompatible stack types: I4 vs Ref
			//IL_03e0->IL02b0: Incompatible stack types: I4 vs Obj
			//IL_04d3->IL02b0: Incompatible stack heights: 2 vs 1
			//IL_03c4->IL02b0: Incompatible stack types: I4 vs Obj
			//IL_0399->IL02b0: Incompatible stack heights: 3 vs 1
			//IL_0411->IL02b0: Incompatible stack heights: 2 vs 1
			//IL_0366->IL02b0: Incompatible stack types: I4 vs Obj
			//IL_0476->IL02b0: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					ref _003CLaunchShadowClient_003Ed__83 reference;
					switch ((int)obj2)
					{
					case 1:
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							obj2 = 0;
						}
						continue;
					default:
						goto end_IL_0019;
					case 5:
						_ = 3;
						continue;
					case 3:
						return;
					case 2:
						break;
					case 4:
						{
							if (obj != null)
							{
								reference = ref *(_003CLaunchShadowClient_003Ed__83*)37;
								goto IL_009a;
							}
							goto IL_05f6;
						}
						IL_05f6:
						reference = ref *(_003CLaunchShadowClient_003Ed__83*)27;
						goto IL_009a;
						IL_009a:
						while (true)
						{
							object obj3;
							switch ((uint)Unsafe.AsPointer(ref reference))
							{
							case 21u:
								return;
							case 2u:
							case 10u:
							case 30u:
							case 32u:
							case 36u:
							case 52u:
								break;
							case 38u:
								obj = (object)/*Error near IL_017f: Stack underflow*/;
								reference = ref *(_003CLaunchShadowClient_003Ed__83*)41;
								continue;
							case 23u:
								if (Unsafe.AsPointer(ref this) != (void*)1)
								{
									if (3 == 0)
									{
										reference = ref *(_003CLaunchShadowClient_003Ed__83*)1;
									}
									continue;
								}
								goto case 39u;
							case 28u:
								obj = (object)/*Error near IL_01ac: Stack underflow*/;
								if (0 == 0)
								{
									reference = ref *(_003CLaunchShadowClient_003Ed__83*)null;
								}
								continue;
							case 48u:
								obj = 1;
								if (10 != 0)
								{
									reference = ref *(_003CLaunchShadowClient_003Ed__83*)11;
								}
								continue;
							case 5u:
								if (&obj == null)
								{
									reference = ref *(_003CLaunchShadowClient_003Ed__83*)24;
									continue;
								}
								goto case 49u;
							case 47u:
								switch ((int)obj)
								{
								case 1:
									break;
								default:
									goto IL_023c;
								case 2:
									goto IL_0630;
								case 0:
									goto IL_06a7;
								}
								goto case 38u;
							case 34u:
							case 46u:
								obj = obj;
								if (5 == 0)
								{
									reference = ref *(_003CLaunchShadowClient_003Ed__83*)5;
								}
								continue;
							case 43u:
								if (obj == null)
								{
									_ = 31;
									continue;
								}
								goto case 42u;
							case 16u:
								if (obj == null)
								{
									_ = 12;
									continue;
								}
								goto case 9u;
							case 27u:
								if (obj != null)
								{
									obj3 = 14;
									goto IL_02b0;
								}
								goto IL_0399;
							case 9u:
								reference = ref *(_003CLaunchShadowClient_003Ed__83*)null;
								if (18 != 0)
								{
									reference = ref *(_003CLaunchShadowClient_003Ed__83*)36;
								}
								continue;
							case 18u:
								reference = ref this;
								if (12 == 0)
								{
									reference = ref *(_003CLaunchShadowClient_003Ed__83*)13;
								}
								continue;
							case 19u:
								if (obj != null)
								{
									reference = ref *(_003CLaunchShadowClient_003Ed__83*)53;
									continue;
								}
								goto case 20u;
							case 12u:
							case 31u:
								goto end_IL_009a;
							case 6u:
								goto IL_0630;
							case 49u:
								_ = ref obj;
								obj = 30;
								goto IL_0096;
							case 15u:
								if (Unsafe.AsPointer(ref this) == (void*)2)
								{
									reference = ref *(_003CLaunchShadowClient_003Ed__83*)19;
									continue;
								}
								goto case 42u;
							case 45u:
								_ = 1;
								if (10 != 0)
								{
									reference = ref *(_003CLaunchShadowClient_003Ed__83*)10;
								}
								continue;
							case 4u:
								reference = ref *(_003CLaunchShadowClient_003Ed__83*)null;
								if (52 != 0)
								{
									reference = ref *(_003CLaunchShadowClient_003Ed__83*)38;
								}
								continue;
							case 26u:
								goto IL_06a7;
							default:
								if (obj - 2 <= 1)
								{
									if (48 != 0)
									{
										reference = ref *(_003CLaunchShadowClient_003Ed__83*)45;
									}
									continue;
								}
								goto case 50u;
							case 22u:
								obj = (object)Unsafe.AsPointer(ref this);
								if (47 == 0)
								{
									reference = ref *(_003CLaunchShadowClient_003Ed__83*)27;
								}
								continue;
							case 13u:
								obj = -1;
								_ = 49;
								continue;
							case 11u:
							case 51u:
								if (obj == null)
								{
									if (23 != 0)
									{
										reference = ref *(_003CLaunchShadowClient_003Ed__83*)34;
									}
									continue;
								}
								goto case 45u;
							case 24u:
								obj = 1;
								_ = 8;
								continue;
							case 14u:
							case 35u:
								_ = 29;
								continue;
							case 37u:
								if ((nint)obj != 1)
								{
									if (33 == 0)
									{
										reference = ref *(_003CLaunchShadowClient_003Ed__83*)10;
									}
									continue;
								}
								goto case 7u;
							case 44u:
								_ = ref obj;
								_ = 21;
								continue;
							case 1u:
							case 53u:
								obj = obj;
								if (16 != 0)
								{
									reference = ref *(_003CLaunchShadowClient_003Ed__83*)null;
								}
								continue;
							case 50u:
								obj = 0;
								obj = 51;
								goto IL_0096;
							case 17u:
							case 29u:
							case 40u:
							case 41u:
								reference = ref *(_003CLaunchShadowClient_003Ed__83*)obj;
								if (11 != 0)
								{
									reference = ref *(_003CLaunchShadowClient_003Ed__83*)28;
								}
								continue;
							case 42u:
								obj = (object)/*Error near IL_0811: Stack underflow*/;
								if (9 == 0)
								{
									reference = ref *(_003CLaunchShadowClient_003Ed__83*)43;
								}
								continue;
							case 20u:
								_ = null;
								_ = 32;
								continue;
							case 7u:
								obj = (object)Unsafe.AsPointer(ref this);
								obj = 18;
								goto IL_0096;
							case 25u:
								goto IL_0858;
							case 8u:
								_ = 44;
								continue;
							case 39u:
								obj = obj;
								reference = ref *(_003CLaunchShadowClient_003Ed__83*)15;
								continue;
							case 33u:
								if ((int)/*Error near IL_0889: Stack underflow*/ == 0)
								{
									if (2 == 0)
									{
										reference = ref *(_003CLaunchShadowClient_003Ed__83*)2;
									}
									continue;
								}
								goto case 23u;
							case 3u:
								{
									_003F val;
									if ((int)/*Error near IL_08a2: Stack underflow*/ == 0)
									{
										val = /*Error near IL_08b1: Stack underflow*/;
									}
									if ((int)val != 0)
									{
										if (4 == 0)
										{
											reference = ref *(_003CLaunchShadowClient_003Ed__83*)2;
										}
										continue;
									}
									goto case 39u;
								}
								IL_0399:
								obj = (object)Unsafe.AsPointer(ref this);
								obj3 = 3;
								goto IL_02b0;
								IL_02b0:
								while (true)
								{
									switch ((int)obj3)
									{
									case 6:
										return;
									case 23:
									case 24:
										_ = 16;
										continue;
									case 7:
										_ = 13;
										continue;
									case 2:
										obj = (object)Unsafe.AsPointer(ref this);
										obj = 10;
										goto IL_02ac;
									case 15:
										obj = (object)/*Error near IL_034f: Stack underflow*/;
										if (5 == 0)
										{
											obj3 = 3;
										}
										continue;
									case 18:
										if (&obj != null)
										{
											obj = 17;
											goto IL_02ac;
										}
										goto case 22;
									case 13:
										_ = ref obj;
										if (2 != 0)
										{
											_ = 6;
										}
										continue;
									case 1:
										break;
									case 10:
										switch ((int)obj)
										{
										case 1:
											break;
										default:
											goto IL_03ba;
										case 0:
											goto IL_03e0;
										case 2:
											goto IL_043d;
										}
										goto case 15;
									default:
										obj = (object)(&obj);
										if (false)
										{
											obj3 = 20;
										}
										continue;
									case 8:
										goto IL_03e0;
									case 14:
										obj = (object)Unsafe.AsPointer(ref this);
										if (5 == 0)
										{
											_ = 18;
										}
										continue;
									case 21:
										_ = 11;
										continue;
									case 19:
										goto IL_043d;
									case 22:
										obj = 0;
										if (6 != 0)
										{
											_ = 7;
										}
										continue;
									case 3:
										_ = 9;
										continue;
									case 4:
									case 5:
									case 12:
									case 16:
										_ = 21;
										continue;
									case 9:
										obj = -1;
										if (false)
										{
											_ = 0;
										}
										continue;
									case 20:
										obj = obj;
										obj3 = 2;
										continue;
									case 11:
										goto IL_0858;
										IL_043d:
										obj = (object)/*Error near IL_0440: Stack underflow*/;
										obj3 = 4;
										continue;
										IL_03e0:
										obj = (object)/*Error near IL_03e3: Stack underflow*/;
										obj3 = 12;
										continue;
										IL_03ba:
										obj3 = 23;
										continue;
										IL_02ac:
										obj3 = obj;
										continue;
									}
									break;
								}
								goto IL_0399;
								IL_0858:
								reference = ref *(_003CLaunchShadowClient_003Ed__83*)22;
								continue;
								IL_0096:
								reference = ref *(_003CLaunchShadowClient_003Ed__83*)obj;
								continue;
								IL_06a7:
								obj = (object)/*Error near IL_06aa: Stack underflow*/;
								reference = ref *(_003CLaunchShadowClient_003Ed__83*)17;
								continue;
								IL_0630:
								obj = (object)/*Error near IL_0633: Stack underflow*/;
								if (2 != 0)
								{
									reference = ref *(_003CLaunchShadowClient_003Ed__83*)40;
								}
								continue;
								IL_023c:
								reference = ref *(_003CLaunchShadowClient_003Ed__83*)14;
								continue;
							}
							goto end_IL_0019_2;
							continue;
							end_IL_009a:
							break;
						}
						goto IL_05f6;
						end_IL_0019_2:
						break;
					}
					_ = -2;
					_ = 5;
					continue;
					end_IL_0019:
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
				obj = 4;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00怀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779303, new IntPtr(2737336577196L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00愀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00戀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779300, new IntPtr(2737336585516L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00挀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00搀(object P_0)
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
	private struct _003CLoadDetailsAsync_003Ed__76 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopGameModel _003C_003E4__this;

		private TaskAwaiter<EntityNetGameDetails> _003C_003Eu__1;

		private static object CheckBasicRunner;

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
		internal static bool DecorateReadableClient()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckRemoteListener()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00儀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779301, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00刀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779298, new IntPtr(2737336588636L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00匀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779299, new IntPtr(2737336584476L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00吀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779296, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00唀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779297, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00嘀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779310, new IntPtr(2737336592796L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00圀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779311, new IntPtr(2737336576156L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00堀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779308, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00夀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779309, new IntPtr(2737336582396L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00娀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779306, new IntPtr(2737336582396L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COpenGameResourceFolder_003Ed__84 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopGameModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object CreateMap;

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
		internal unsafe static bool ReflectJoinedFinalizer()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779305, new IntPtr(2737336606316L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object DecorateLiteralAggregator()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779318, new IntPtr(2737336590716L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䨀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779319, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779316, new IntPtr(2737336590716L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00䰀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779317, new IntPtr(2737336585516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00䴀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779314, new IntPtr(2737336582396L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00一()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779315, new IntPtr(2737336591756L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00伀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779312, new IntPtr(2737336595916L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00倀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779313, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRefreshCharactersAsync_003Ed__77 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopGameModel _003C_003E4__this;

		private object _003C_003E8__1;

		private TaskAwaiter<EntityRentalGameCharacter[]> _003C_003Eu__1;

		private TaskAwaiter<EntityGameCharacter[]> _003C_003Eu__2;

		private static object ReflectScalableTag;

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
		internal unsafe static bool CheckModularEngine()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779324, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object ReflectGroupedCompiler()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779325, new IntPtr(2737336574076L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䈀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779322, new IntPtr(2737336585516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䌀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779323, new IntPtr(2737336592796L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779320, new IntPtr(2737336601116L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00䔀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779321, new IntPtr(2737336601116L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00䘀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779270, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00䜀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779271, new IntPtr(2737336578236L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䠀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779268, new IntPtr(2737336592796L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䤀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779269, new IntPtr(2737336602156L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStartProxy_003Ed__81 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopGameModel _003C_003E4__this;

		public SectionValue sectionValue;

		private object _003CgameId_003E5__2;

		private object _003Cname_003E5__3;

		private TaskAwaiter<GameProxy> _003C_003Eu__1;

		private TaskAwaiter<(bool IsConfirmed, string Text)> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private static object CheckDic;

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
		internal unsafe static bool CancelObject()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779264, new IntPtr(2737336575116L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object DecorateAutomatableStub()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779265, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00㔀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779278, new IntPtr(2737336604236L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00㘀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779279, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00㜀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779276, new IntPtr(2737336574076L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00㠀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779277, new IntPtr(2737336577196L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00㤀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779274, new IntPtr(2737336574076L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00㨀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779275, new IntPtr(2737336581356L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00㬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779272, new IntPtr(2737336591756L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00㰀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779273, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00㴀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779286, new IntPtr(2737336574076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	private static object DecorateGenericMapper;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsSkeleton
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_EF00() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00쐀(value ? ((byte)1) : ((byte)0));
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool CanProxy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_0E00() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00씀(value ? ((byte)1) : ((byte)0));
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public bool ShowMaxPlayer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_EC00() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00က(value ? ((byte)1) : ((byte)0));
		}
	}

	public bool IsRentalGame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00촀() != 0;
		}
	}

	public bool HasRentalPassword
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_E700() != 0;
		}
	}

	public bool ShowPlayerCount => true;

	public string PlayerCountText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)this._FF00_FF00_FF00_FF00_FFFD();
		}
	}

	public bool HasRentalMinLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00ᤀ() != 0;
		}
	}

	public string RentalMinLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_0B00();
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_2100();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_F100(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int OnlinePlayers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_FF00ሀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_F600((uint)value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public int MaxPlayers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_FF00_0A00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FFFD((uint)value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string Author
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00츀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			this._FF00_FF00_FF00_FF00_FFFD((object)value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00팀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00준(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public string Version
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_E100();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_E900(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public string ImageUrl
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00ἀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00ᨀ(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ObservableCollection<DesktopGameCharacterModel> Characters
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00Ā();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00쬀(value);
		}
	}

	public DesktopGameCharacterModel? SelectedCharacter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (DesktopGameCharacterModel?)_FF00_FF00_FF00_FF00_FF00_1400();
		}
	}

	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public string BackgroundImageUrl
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_0700();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			this._FF00_FF00_FF00_FF00_FFFD((object)value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public bool IsLiked
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return this._FF00_FF00_FF00_FF00_FFFD() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00ᴀ(value ? ((byte)1) : ((byte)0));
		}
	}

	public IDesktopGame Game
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IDesktopGame)_FF00_FF00_FF00_FF00_E400();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00切(value);
		}
	}

	public bool IsShadowGame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00ﴀ() != 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DesktopGameModel(IDesktopGame? game = null)
	{
		//IL_008f: Expected Obj, but got I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_007d: Expected Obj, but got I4
		//IL_01d1: Expected I4, but got Obj
		//IL_00bb->IL00bb: Incompatible stack heights: 9 vs 10
		//IL_00d1->IL00d2: Incompatible stack types: I4 vs Obj
		//IL_00e8->IL00e9: Incompatible stack types: I4 vs Obj
		//IL_0108->IL0108: Incompatible stack heights: 15 vs 16
		//IL_012c->IL012c: Incompatible stack heights: 17 vs 18
		//IL_0151->IL0151: Incompatible stack heights: 19 vs 20
		//IL_0167->IL0168: Incompatible stack heights: 22 vs 21
		//IL_0197->IL0197: Incompatible stack types: I4 vs Obj
		//IL_01bf->IL01c8: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = this == null;
		object obj = this;
		obj = this;
		if (obj != null)
		{
			obj = obj;
			if (obj - 8 <= 1)
			{
				obj = 1;
				goto IL_009d;
			}
		}
		obj = 0;
		goto IL_009d;
		IL_009d:
		if ((this ?? null) == null)
		{
		}
		if ((this ?? null) == null)
		{
		}
		if ((this ?? null) == null)
		{
		}
		if ((this ?? null) == null)
		{
		}
		if (this != null)
		{
		}
		DesktopGameModel desktopGameModel = this;
		if (false)
		{
			desktopGameModel = (DesktopGameModel)0;
		}
		switch ((int)desktopGameModel)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Clone()
	{
		return _FF00_FF00_FF00_FF00픀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return (string)_FF00_FF00_FF00_FF00_E200();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoadDetailsAsync_003Ed__76))]
	public Task LoadDetailsAsync()
	{
		return (Task)_FF00_FF00_FF00_FF00_F300();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshCharactersAsync_003Ed__77))]
	public Task RefreshCharactersAsync()
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00_2300();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddRandomCharacter_003Ed__78))]
	public Task<string?> AddRandomCharacter()
	{
		return _FF00_FF00_FF00_FF00숀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddCharacter_003Ed__79))]
	public Task<(bool isSuccess, bool needRetry)> AddCharacter(string name, bool growl = true)
	{
		return _FF00_FF00_FF00_FF00턀(name, growl ? ((byte)1) : ((byte)0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CFastStart_003Ed__80))]
	public Task FastStart()
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00_0D00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CStartProxy_003Ed__81))]
	public Task StartProxy(SectionValue? sectionValue)
	{
		return (Task)_FF00_FF00_FF00_FF00윀(sectionValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLaunchGame_003Ed__82))]
	public Task LaunchGame(SectionValue gameValue, SectionValue? proxyValue)
	{
		return (Task)_FF00_FF00_FF00_FF00_F800(gameValue, proxyValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLaunchShadowClient_003Ed__83))]
	public Task LaunchShadowClient(SectionValue? sectionValue, ShadowJavaGameType type = (ShadowJavaGameType)0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (Task)_FF00_FF00_FF00_FF00_FF00ᜀ(sectionValue, type);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COpenGameResourceFolder_003Ed__84))]
	public Task OpenGameResourceFolder()
	{
		return (Task)_FF00_FF00_FF00_FF00_EA00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object GetImageUrl(object game)
	{
		return _FF00_FF00_FF00_FF00_FF00_0300(game);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnIsLikedChanged(byte value)
	{
		_FF00_FF00_FF00_FF00_FE00(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FillStruct()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DesktopGameModel ReflectCustomRequester()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00뼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778890, new IntPtr(2737336200092L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00쀀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00섀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778891, new IntPtr(2737336200092L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<string> _FF00_FF00_FF00_FF00숀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18520, 1790778888, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778888, new IntPtr(2737336200092L), 15);
		}
		return (Task<string>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<string> _FF00_FF00_FF00_FF00쌀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778889, new IntPtr(2737336211532L), 15))(null, 0, new IntPtr(0L));
		return (Task<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00쐀(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0072->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0065->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0041->IL008c: Incompatible stack heights: 1 vs 0
		//IL_0081->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008c->IL0019: Incompatible stack heights: 2 vs 1
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
				if (P_0 == 0)
				{
					if (1 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				return;
			case 1:
				_ = 3;
				break;
			default:
				_ = 4;
				break;
			case 3:
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
	internal void _FF00_FF00_FF00_FF00씀(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_007a->IL003b: Incompatible stack heights: 1 vs 0
		//IL_0064->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0084->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0055->IL0019: Incompatible stack types: I4 vs Obj
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
				if (4 == 0)
				{
					obj2 = 4;
				}
				break;
			case 4:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 1:
				return;
			case 2:
				return;
			case 3:
				if (P_0 != 0)
				{
					_ = 2;
					break;
				}
				goto case 5;
			default:
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
	internal unsafe void _FF00_FF00_FF00_FF00였(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778902, new IntPtr(2737336201132L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00윀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18525, 1790778903, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778903, new IntPtr(2737336201132L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00저(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778900, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00준(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0062->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0088->IL0055: Incompatible stack heights: 1 vs 0
		//IL_00ac->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0055->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0092->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				if (2 != 0)
				{
					_ = 2;
				}
				break;
			default:
				_ = 3;
				break;
			case 4:
				return;
			case 5:
				if (P_0 != null)
				{
					_ = 4;
					break;
				}
				goto default;
			case 2:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00쬀(ObservableCollection<DesktopGameCharacterModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0047: Expected Obj, but got I4
		//IL_004c->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0070->IL004c: Incompatible stack heights: 1 vs 0
		//IL_00a4->IL0019: Incompatible stack heights: 2 vs 1
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
					goto case 5;
				case 1:
					return;
				case 4:
					return;
				case 3:
					_ = 4;
					continue;
				}
				break;
			}
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00찀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778901, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00촀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (this != null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00츀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00케()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778898, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<(bool, bool)> _FF00_FF00_FF00_FF00퀀(object P_0, byte P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778899, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		return (Task<(bool, bool)>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<(bool, bool)> _FF00_FF00_FF00_FF00턀(object P_0, byte P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_0089: Expected Obj, but got Ref
		//IL_0076->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0099->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0084->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00b4->IL0019: Incompatible stack heights: 3 vs 1
		//IL_005d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a4->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0068->IL0019: Incompatible stack heights: 2 vs 1
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
				_ = ref obj;
				_ = 4;
				break;
			case 4:
				_ = ref obj;
				if (true)
				{
					_ = 0;
				}
				break;
			default:
				_ = ref obj;
				_ = 2;
				break;
			case 2:
				_ = ref obj;
				_ = -1;
				_ = 3;
				break;
			case 6:
				return (Task<(bool, bool)>)(&obj);
			case 1:
				_ = ref obj;
				if (false)
				{
					_ = 0;
				}
				break;
			case 3:
				_ = ref obj;
				_ = ref obj;
				_ = 6;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00툀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778896, new IntPtr(2737336211532L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00팀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00퐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778897, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed object _FF00_FF00_FF00_FF00픀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00휀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778910, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18542, 1790778911, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778911, new IntPtr(2737336211532L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0082->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0044->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004e->IL0058: Incompatible stack heights: 1 vs 0
		//IL_0073->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0058->IL0019: Incompatible stack heights: 2 vs 1
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
				_ = 2;
				break;
			case 4:
				if (P_0 == null)
				{
					_ = 3;
					break;
				}
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
	internal unsafe void _FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778908, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0060->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0075->IL00a6: Incompatible stack heights: 1 vs 0
		//IL_006b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0051->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a6->IL0019: Incompatible stack types: I4 vs Obj
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
			case 2:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			default:
				if (2 != 0)
				{
					_ = 4;
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
			case 4:
				obj2 = this;
				if (true)
				{
					obj2 = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778909, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778906, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FFFD(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_008f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005b->IL007f: Incompatible stack heights: 1 vs 0
		//IL_009a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0051->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0019: Incompatible stack types: I4 vs Obj
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
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 3:
				obj2 = this;
				if (P_0 == 0)
				{
					if (true)
					{
						obj2 = 2;
					}
					break;
				}
				return;
			case 1:
				_ = 4;
				break;
			case 4:
				return;
			default:
				if (true)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_E000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778907, new IntPtr(2737336208412L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_E100()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_E200()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_E300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778904, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_E400()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_E500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778905, new IntPtr(2737336209452L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_E600()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778982, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_E700()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0033: Expected I4, but got Obj
		//IL_0046->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0064->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0051->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0019: Incompatible stack types: I4 vs Obj
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
				return (byte)(int)obj;
			case 2:
				obj = this;
				if (true)
				{
					obj2 = 1;
				}
				break;
			case 1:
				if (obj == null)
				{
					return 0;
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
	internal unsafe byte _FF00_FF00_FF00_FF00_E800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778983, new IntPtr(2737336208412L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_E900(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_008b->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0095->IL0064: Incompatible stack heights: 1 vs 0
		//IL_007e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0055->IL0019: Incompatible stack types: I4 vs Obj
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
			case 5:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 3:
				return;
			case 2:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				_ = 5;
				break;
			case 4:
				if (P_0 != null)
				{
					_ = 3;
					break;
				}
				goto case 2;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_EA00()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18560, 1790778980, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778980, new IntPtr(2737336202172L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_EB00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778981, new IntPtr(2737336203212L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_EC00()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_ED00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778978, new IntPtr(2737336208412L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_EE00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778979, new IntPtr(2737336203212L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_EF00()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_F000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778976, new IntPtr(2737336203212L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_F100(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0095->IL009f: Incompatible stack heights: 1 vs 0
		//IL_0080->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0055->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008b->IL0019: Incompatible stack heights: 2 vs 1
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
				if (2 != 0)
				{
					obj2 = 5;
				}
				continue;
			case 2:
				return;
			case 4:
				if (false)
				{
					_ = 0;
				}
				continue;
			case 3:
				if (P_0 != null)
				{
					_ = 2;
					continue;
				}
				break;
			case 1:
				break;
			case 5:
				return;
			}
			obj2 = this;
			if (4 != 0)
			{
				obj2 = 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_F200(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778977, new IntPtr(2737336206332L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_F300()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18569, 1790778990, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778990, new IntPtr(2737336203212L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_F400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778991, new IntPtr(2737336204252L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_F500(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778988, new IntPtr(2737336204252L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_F600(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0045->IL0078: Incompatible stack heights: 1 vs 0
		//IL_0085->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00af->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ba->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005c->IL0019: Incompatible stack types: I4 vs Obj
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
				if (P_0 != 0)
				{
					if (true)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 4;
			case 1:
				return;
			case 4:
				_ = 5;
				break;
			case 0:
				return;
			case 3:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 5:
				if (2 == 0)
				{
					_ = 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_F700(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778989, new IntPtr(2737336204252L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_F800(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18574, 1790778986, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790778986, new IntPtr(2737336204252L), 15);
		}
		return ((delegate*<object, object, object, object>)obj)(this, P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00豈(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778987, new IntPtr(2737336205292L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00切(object P_0)
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
				if (false)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00ﬀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778984, new IntPtr(2737336205292L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00ﴀ()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0055: Expected I4, but got Obj
		//IL_0040->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004b->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		object obj3;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				obj3 = this;
				if (obj3 == null)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			default:
				obj3 = null;
				break;
			}
			break;
		}
		return (byte)(int)obj3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_FE00(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00a4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0068->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0019: Incompatible stack types: I4 vs Obj
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
			case 3:
				obj2 = this;
				if (true)
				{
					obj2 = 1;
				}
				break;
			case 1:
				return;
			case 5:
				if (this != null)
				{
					if (2 == 0)
					{
						obj2 = 4;
					}
					break;
				}
				if (P_0 == 0)
				{
					obj2 = 3;
					break;
				}
				goto case 2;
			case 2:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<DesktopGameCharacterModel> _FF00_FF00_FF00_FF00_FF00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778985, new IntPtr(2737336205292L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<DesktopGameCharacterModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ObservableCollection<DesktopGameCharacterModel> _FF00_FF00_FF00_FF00_FF00Ā()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<DesktopGameCharacterModel>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<DesktopGameCharacterModel> _FF00_FF00_FF00_FF00_FF00Ȁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778998, new IntPtr(2737336205292L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<DesktopGameCharacterModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_0300(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18584, 1790778999, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778999, new IntPtr(2737336205292L), 15);
		}
		return ((delegate*<object, object>)obj)(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00Ѐ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00Ԁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778996, new IntPtr(2737336206332L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_0600()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778997, new IntPtr(2737336206332L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_0700()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00ࠀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778994, new IntPtr(2737336206332L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_0900()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778995, new IntPtr(2737336206332L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00_FF00_0A00()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_0B00()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18592, 1790778992, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778992, new IntPtr(2737336206332L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_0C00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778993, new IntPtr(2737336208412L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_0D00()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18594, 1790779006, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779006, new IntPtr(2737336208412L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_0E00()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00ༀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779007, new IntPtr(2737336209452L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00က(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_008b: Expected Obj, but got I4
		//IL_009a->IL003b: Incompatible stack heights: 1 vs 0
		//IL_0063->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0090->IL0015: Incompatible stack heights: 1 vs 0
		//IL_0055->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b1->IL0019: Incompatible stack types: I4 vs Obj
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
				default:
					return;
				case 5:
					obj2 = this;
					if (2 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 0:
					return;
				case 3:
					return;
				case 2:
					_ = 4;
					continue;
				case 4:
					break;
				case 1:
					obj2 = this;
					if (P_0 != 0)
					{
						if (false)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 5;
				}
				break;
			}
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00ᄀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779004, new IntPtr(2737336209452L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00_FF00ሀ()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00ጀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779005, new IntPtr(2737336209452L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_1400()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18601, 1790779002, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779002, new IntPtr(2737336209452L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00ᔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779003, new IntPtr(2737336578236L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00ᘀ(object P_0, ShadowJavaGameType P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779000, new IntPtr(2737336593836L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00ᜀ(object P_0, ShadowJavaGameType P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got Ref
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_008c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c0->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0051->IL0015: Incompatible stack heights: 2 vs 0
		//IL_00a7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0097->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007a->IL0019: Incompatible stack types: I4 vs Ref
		//IL_00b2->IL0019: Incompatible stack heights: 2 vs 1
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
				case 3u:
					break;
				case 6u:
					_ = ref obj;
					_ = 3;
					continue;
				case 2u:
					reference = ref obj;
					if (1 == 0)
					{
						reference = ref *(object*)1;
					}
					continue;
				default:
					_ = ref obj;
					_ = ref obj;
					if (5 == 0)
					{
						_ = 5;
					}
					continue;
				case 4u:
					_ = ref obj;
					_ = -1;
					if (false)
					{
						_ = 0;
					}
					continue;
				case 1u:
					_ = ref obj;
					_ = 6;
					continue;
				case 5u:
					return (object)(&obj);
				}
				break;
			}
			_ = ref obj;
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00ᤀ()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0090->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0074->IL0019: Incompatible stack heights: 0 vs 1
		//IL_009b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00cc->IL0019: Incompatible stack heights: 0 vs 1
		//IL_007f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0050->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00d7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b9->IL0019: Incompatible stack types: I4 vs Obj
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
			case 5:
				if ((nint)obj > 0)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto IL_0061;
			default:
				return (byte)(int)obj;
			case 3:
				obj = this;
				if (2 == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				obj = obj;
				if (4 != 0)
				{
					obj2 = 1;
				}
				break;
			case 4:
				if (obj != null)
				{
					if (4 == 0)
					{
						obj2 = 5;
					}
					break;
				}
				goto IL_0061;
			case 2:
				{
					if (obj != null)
					{
						if (1 == 0)
						{
							obj2 = 0;
						}
						break;
					}
					goto IL_0061;
				}
				IL_0061:
				return 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00ᨀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00a2->IL007e: Incompatible stack heights: 1 vs 0
		//IL_0073->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0064->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0098->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b9->IL0019: Incompatible stack types: I4 vs Obj
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
				_ = 5;
				break;
			case 3:
				if (2 == 0)
				{
					_ = 4;
				}
				break;
			case 2:
				obj2 = this;
				if (3 == 0)
				{
					obj2 = 1;
				}
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
				goto case 2;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_1B00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779001, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00ᰀ(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778950, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00ᴀ(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_004e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0063->IL0088: Incompatible stack heights: 1 vs 0
		//IL_0087->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0059->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00cb->IL0019: Incompatible stack heights: 2 vs 1
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
			default:
				if (4 != 0)
				{
					_ = 5;
				}
				break;
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
				_ = 6;
				break;
			case 1:
				return;
			case 6:
				return;
			case 3:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 5:
				if (2 == 0)
				{
					_ = 4;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00Ḁ(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778951, new IntPtr(2737336605276L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00ἀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_2000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778948, new IntPtr(2737336604236L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_2100()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_2200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778949, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_2300()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18616, 1790778946, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778946, new IntPtr(2737336593836L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_2400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778947, new IntPtr(2737336575116L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
