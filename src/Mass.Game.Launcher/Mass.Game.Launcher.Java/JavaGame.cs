using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Mass.Application.Desktop;
using Mass.Application.Models;
using Mass.Common.Extensions;
using Mass.Domain.Desktop.Entities.Mods;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Entities;
using Mass.Domain.ValueObjects;
using Mass.Game.Launcher.Enums;
using Mass.Game.Launcher.Java.Option;
using Mass.Game.Launcher.Paths;
using Mass.Game.Launcher.Values;
using Mass.Game.Proxy;
using Serilog;

namespace Mass.Game.Launcher.Java;

public class JavaGame : GameInstance
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003Ec__DisplayClass138_0
	{
		public JavaGame _003C_003E4__this;

		public int percentage;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLaunchAsync_003Ed__106 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object RestartIterator;

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
		internal static bool DecorateDividedEmitter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateGeneralRunner()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 㼀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778740, new IntPtr(2737337578284L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void 䀀(object P_0)
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
		internal static object 䄀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 䈀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778739, new IntPtr(2737337580364L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 䌀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_03f9: Expected Obj, but got Ref
			//IL_0421: Expected Obj, but got Ref
			//IL_0123: Expected Obj, but got Ref
			//IL_012c: Expected Obj, but got I4
			//IL_00ea: Expected I4, but got Obj
			//IL_0114: Expected Obj, but got I4
			//IL_013d: Expected Obj, but got I4
			//IL_018c: Expected Obj, but got I4
			//IL_0163: Expected Obj, but got I4
			//IL_016d: Expected Obj, but got I4
			//IL_0405->IL0019: Incompatible stack heights: 0 vs 1
			//IL_042d->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0447->IL0019: Incompatible stack heights: 3 vs 1
			//IL_041d->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004d->IL0051: Incompatible stack heights: 1 vs 0
			//IL_0410->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0438->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0083->IL0051: Incompatible stack heights: 1 vs 0
			//IL_0093->IL0051: Incompatible stack heights: 2 vs 0
			//IL_00b1->IL00b5: Incompatible stack types: I4 vs Ref
			//IL_009e->IL0051: Incompatible stack heights: 2 vs 0
			//IL_00b5->IL00b5: Incompatible stack types: Obj vs Ref
			//IL_011f->IL00b5: Incompatible stack heights: 3 vs 1
			//IL_010f->IL00b5: Incompatible stack types: I4 vs Ref
			//IL_017f->IL00b5: Incompatible stack heights: 2 vs 1
			//IL_0142->IL00b1: Incompatible stack heights: 1 vs 0
			//IL_0191->IL00b1: Incompatible stack heights: 2 vs 0
			//IL_00ff->IL00b5: Incompatible stack heights: 4 vs 1
			//IL_0172->IL00b1: Incompatible stack heights: 2 vs 0
			//IL_01bf->IL00b5: Incompatible stack heights: 0 vs 1
			//IL_01ab->IL00b5: Incompatible stack types: I4 vs Ref
			//IL_01ca->IL00b5: Incompatible stack types: I4 vs Ref
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
					if (obj != null)
					{
						_ = 2;
						goto IL_0051;
					}
					goto IL_006b;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 5:
					_ = 4;
					continue;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						obj2 = 1;
					}
					continue;
				case 4:
					return;
				case 3:
					break;
					IL_0051:
					while (true)
					{
						ref object reference;
						switch ((int)/*Error near IL_0066: Stack underflow*/)
						{
						case 3:
							break;
						case 2:
							_ = 1;
							if (3 == 0)
							{
								_ = 2;
							}
							continue;
						case 1:
							if (obj != null)
							{
								reference = ref *(object*)6;
								goto IL_00b5;
							}
							goto IL_011f;
						default:
							goto end_IL_0019;
							IL_011f:
							obj = (object)Unsafe.AsPointer(ref this);
							obj = 5;
							goto IL_00b1;
							IL_00b1:
							reference = ref *(object*)obj;
							goto IL_00b5;
							IL_00b5:
							while (true)
							{
								switch ((uint)Unsafe.AsPointer(ref reference))
								{
								case 10u:
									_ = ref obj;
									_ = 9;
									continue;
								case 3u:
									obj = obj;
									reference = ref *(object*)4;
									continue;
								case 2u:
									obj = -1;
									_ = 7;
									continue;
								case 6u:
									goto IL_0131;
								case 9u:
									return;
								case 11u:
									goto IL_015e;
								case 5u:
									_ = 2;
									continue;
								case 8u:
									goto IL_017f;
								case 7u:
									reference = ref obj;
									if (1 == 0)
									{
										reference = ref *(object*)1;
									}
									continue;
								case 4u:
									if (&obj == null)
									{
										if (11 != 0)
										{
											reference = ref *(object*)6;
										}
										continue;
									}
									goto case 7u;
								case 1u:
									goto end_IL_0019;
								}
								break;
							}
							goto IL_011f;
							IL_017f:
							obj = 10;
							goto IL_00b1;
							IL_015e:
							obj = 0;
							obj = 8;
							goto IL_00b1;
							IL_0131:
							obj = 3;
							goto IL_00b1;
						}
						break;
					}
					goto IL_006b;
					IL_006b:
					if (true)
					{
						_ = 0;
					}
					goto IL_0051;
					end_IL_0019:
					break;
				}
				_ = -2;
				_ = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 䐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778738, new IntPtr(2737337577244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte 䔀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 䘀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778737, new IntPtr(2737337594924L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLaunchStepsAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object DetachChooser;

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
		internal static bool CheckVisibleListener()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateCentralTracker()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 㔀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778736, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void 㘀(object P_0)
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
		private unsafe sealed void 㜀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778735, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object 㠀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 㤀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778734, new IntPtr(2737337578284L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 㨀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778733, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 㬀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0a06: Expected Obj, but got I4
			//IL_0069: Expected I4, but got Obj
			//IL_09c7: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_035c: Expected Obj, but got Ref
			//IL_0665: Expected Obj, but got Ref
			//IL_06de: Expected Obj, but got Ref
			//IL_08d8: Expected Obj, but got Ref
			//IL_05cc: Expected Obj, but got Ref
			//IL_0802: Expected Obj, but got Ref
			//IL_03ac: Expected Obj, but got I4
			//IL_0698: Expected Obj, but got I4
			//IL_022c: Expected Obj, but got I4
			//IL_0249: Expected Obj, but got I4
			//IL_0473: Expected Obj, but got I4
			//IL_0517: Expected Obj, but got I4
			//IL_0873: Expected Obj, but got I4
			//IL_057d: Expected Obj, but got I4
			//IL_03f3: Expected Obj, but got I4
			//IL_0521: Expected Obj, but got I4
			//IL_067e: Expected Obj, but got I4
			//IL_06b5: Expected Obj, but got I4
			//IL_077a: Expected Obj, but got I4
			//IL_0770: Expected Obj, but got I4
			//IL_03c8: Expected Obj, but got I4
			//IL_08c9: Expected Obj, but got I4
			//IL_01ed: Expected Obj, but got I4
			//IL_0587: Expected Obj, but got I4
			//IL_0a0b->IL0015: Incompatible stack heights: 1 vs 0
			//IL_09ee->IL0019: Incompatible stack heights: 2 vs 1
			//IL_09d3->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
			//IL_066f->IL0077: Incompatible stack heights: 1 vs 0
			//IL_05d6->IL0077: Incompatible stack heights: 1 vs 0
			//IL_0073->IL0077: Incompatible stack heights: 1 vs 0
			//IL_09f9->IL0019: Incompatible stack heights: 2 vs 1
			//IL_09de->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0373->IL0077: Incompatible stack heights: 1 vs 0
			//IL_06f5->IL0077: Incompatible stack heights: 1 vs 0
			//IL_08ef->IL0077: Incompatible stack heights: 1 vs 0
			//IL_0819->IL0077: Incompatible stack heights: 1 vs 0
			//IL_062f->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0727->IL0077: Incompatible stack heights: 4 vs 0
			//IL_06a5->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0239->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0256->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0826->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0935->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0480->IL0077: Incompatible stack heights: 2 vs 0
			//IL_05ae->IL0077: Incompatible stack heights: 1 vs 0
			//IL_0693->IL0077: Incompatible stack heights: 1 vs 0
			//IL_07d9->IL0077: Incompatible stack heights: 1 vs 0
			//IL_0617->IL0077: Incompatible stack heights: 1 vs 0
			//IL_07af->IL0077: Incompatible stack heights: 2 vs 0
			//IL_02de->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0202->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0331->IL0077: Incompatible stack heights: 1 vs 0
			//IL_051c->IL0073: Incompatible stack types: Obj vs Ref
			//IL_0661->IL0077: Incompatible stack heights: 1 vs 0
			//IL_0880->IL0077: Incompatible stack heights: 2 vs 0
			//IL_026e->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0395->IL0077: Incompatible stack heights: 1 vs 0
			//IL_021c->IL0077: Incompatible stack heights: 1 vs 0
			//IL_0761->IL0077: Incompatible stack heights: 3 vs 0
			//IL_0835->IL0077: Incompatible stack heights: 1 vs 0
			//IL_0942->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0400->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0432->IL0077: Incompatible stack heights: 2 vs 0
			//IL_052e->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0683->IL0073: Incompatible stack heights: 0 vs 1
			//IL_06c2->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0797->IL0077: Incompatible stack heights: 3 vs 0
			//IL_0566->IL0077: Incompatible stack heights: 3 vs 0
			//IL_0449->IL0077: Incompatible stack heights: 1 vs 0
			//IL_0906->IL0077: Incompatible stack heights: 1 vs 0
			//IL_0748->IL0077: Incompatible stack heights: 3 vs 0
			//IL_0340->IL0077: Incompatible stack heights: 1 vs 0
			//IL_04b7->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0785->IL0077: Incompatible stack heights: 3 vs 0
			//IL_0717->IL0077: Incompatible stack heights: 3 vs 0
			//IL_0775->IL0073: Incompatible stack heights: 0 vs 1
			//IL_0358->IL0077: Incompatible stack heights: 2 vs 0
			//IL_06da->IL0077: Incompatible stack heights: 2 vs 0
			//IL_089a->IL0077: Incompatible stack heights: 1 vs 0
			//IL_0646->IL0077: Incompatible stack heights: 1 vs 0
			//IL_03d5->IL0077: Incompatible stack heights: 2 vs 0
			//IL_08d4->IL0077: Incompatible stack heights: 3 vs 0
			//IL_07bf->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0498->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0709->IL0077: Incompatible stack heights: 2 vs 0
			//IL_027b->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0594->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0312->IL0077: Incompatible stack heights: 4 vs 0
			//IL_041a->IL0077: Incompatible stack heights: 1 vs 0
			//IL_0463->IL0077: Incompatible stack heights: 1 vs 0
			//IL_04e4->IL0077: Incompatible stack heights: 2 vs 0
			//IL_05e3->IL0077: Incompatible stack heights: 2 vs 0
			//IL_03ee->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0549->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0952->IL0077: Incompatible stack heights: 4 vs 0
			//IL_07f3->IL0077: Incompatible stack heights: 1 vs 0
			//IL_0077->IL0077: Incompatible stack heights: 2 vs 0
			//IL_06b0->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0244->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0261->IL0077: Incompatible stack heights: 2 vs 0
			//IL_02f0->IL0077: Incompatible stack heights: 1 vs 0
			//IL_048b->IL0077: Incompatible stack heights: 2 vs 0
			//IL_05b9->IL0077: Incompatible stack heights: 1 vs 0
			//IL_07e4->IL0077: Incompatible stack heights: 1 vs 0
			//IL_0622->IL0077: Incompatible stack heights: 1 vs 0
			//IL_020d->IL0077: Incompatible stack heights: 2 vs 0
			//IL_088b->IL0077: Incompatible stack heights: 2 vs 0
			//IL_03a0->IL0077: Incompatible stack heights: 1 vs 0
			//IL_0600->IL0077: Incompatible stack heights: 1 vs 0
			//IL_0227->IL0077: Incompatible stack heights: 1 vs 0
			//IL_03c3->IL0077: Incompatible stack heights: 1 vs 0
			//IL_0302->IL0077: Incompatible stack heights: 1 vs 0
			//IL_0840->IL0077: Incompatible stack heights: 1 vs 0
			//IL_040b->IL0077: Incompatible stack heights: 2 vs 0
			//IL_04d4->IL0077: Incompatible stack heights: 1 vs 0
			//IL_0539->IL0077: Incompatible stack heights: 2 vs 0
			//IL_06cd->IL0077: Incompatible stack heights: 2 vs 0
			//IL_07a2->IL0077: Incompatible stack heights: 3 vs 0
			//IL_0571->IL0077: Incompatible stack heights: 3 vs 0
			//IL_0454->IL0077: Incompatible stack heights: 1 vs 0
			//IL_0911->IL0077: Incompatible stack heights: 1 vs 0
			//IL_0753->IL0077: Incompatible stack heights: 3 vs 0
			//IL_034b->IL0077: Incompatible stack heights: 1 vs 0
			//IL_04aa->IL0077: Incompatible stack heights: 1 vs 0
			//IL_08a5->IL0077: Incompatible stack heights: 1 vs 0
			//IL_0651->IL0077: Incompatible stack heights: 1 vs 0
			//IL_03e0->IL0077: Incompatible stack heights: 2 vs 0
			//IL_07ca->IL0077: Incompatible stack heights: 2 vs 0
			//IL_02d1->IL0077: Incompatible stack heights: 1 vs 0
			//IL_0298->IL0077: Incompatible stack heights: 1 vs 0
			//IL_059f->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0425->IL0077: Incompatible stack heights: 1 vs 0
			//IL_046e->IL0077: Incompatible stack heights: 1 vs 0
			//IL_04ef->IL0077: Incompatible stack heights: 2 vs 0
			//IL_0554->IL0077: Incompatible stack heights: 2 vs 0
			//IL_07fe->IL0077: Incompatible stack heights: 1 vs 0
			//IL_086e->IL0077: Incompatible stack heights: 1 vs 0
			//IL_08c4->IL0077: Incompatible stack heights: 1 vs 0
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
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 3;
						continue;
					case 1:
						switch ((int)obj)
						{
						default:
							_ = 83;
							goto IL_0077;
						case 0:
							obj = (object)Unsafe.AsPointer(ref this);
							if (3 != 0)
							{
								_ = 18;
							}
							goto IL_0077;
						case 4:
							goto IL_05c8;
						case 1:
							goto IL_0661;
						case 2:
							goto IL_06da;
						case 5:
							goto IL_07fe;
						case 3:
							goto IL_08d4;
							IL_0077:
							while (true)
							{
								scoped ref object reference;
								switch ((int)/*Error near IL_01dc: Stack underflow*/)
								{
								case 68:
									reference = ref obj;
									obj = 24;
									continue;
								case 20:
									if (40 != 0)
									{
										_ = 51;
									}
									continue;
								case 30:
									if (7 != 0)
									{
										_ = 25;
									}
									continue;
								case 5:
									obj = -1;
									if (5 == 0)
									{
										_ = 13;
									}
									continue;
								case 7:
									obj = -1;
									if (44 == 0)
									{
										_ = 80;
									}
									continue;
								case 27:
									_ = 42;
									continue;
								case 74:
									_ = 21;
									continue;
								case 75:
									obj = obj;
									if (49 != 0)
									{
										_ = 78;
									}
									continue;
								case 46:
									return;
								case 72:
									obj = obj;
									if (22 == 0)
									{
										_ = 38;
									}
									continue;
								case 19:
									_ = 76;
									continue;
								case 11:
									if (&obj == null)
									{
										_ = 43;
										continue;
									}
									goto case 57;
								case 34:
									if (&obj != null)
									{
										_ = 8;
										continue;
									}
									goto case 12;
								case 77:
									_ = ref obj;
									_ = 46;
									continue;
								case 1:
									return;
								case 21:
									obj = obj;
									_ = 28;
									continue;
								case 8:
								case 52:
									_ = ref obj;
									if (56 != 0)
									{
										_ = 13;
									}
									continue;
								case 57:
									_ = ref obj;
									_ = 9;
									continue;
								case 26:
									break;
								case 28:
									_ = ref obj;
									if (22 == 0)
									{
										_ = 2;
									}
									continue;
								case 3:
									reference = ref obj;
									obj = 62;
									continue;
								case 33:
									if (&obj == null)
									{
										_ = 4;
										continue;
									}
									goto case 68;
								case 65:
									obj = -1;
									if (52 == 0)
									{
										_ = 41;
									}
									continue;
								case 83:
									_ = 50;
									continue;
								case 40:
									obj = 1;
									if (55 != 0)
									{
										_ = 40;
									}
									continue;
								case 78:
									_ = ref obj;
									if (31 == 0)
									{
										_ = 82;
									}
									continue;
								case 41:
									_ = ref obj;
									_ = 64;
									continue;
								case 49:
									obj = obj;
									if (34 != 0)
									{
										_ = 3;
									}
									continue;
								case 80:
									_ = ref obj;
									if (44 == 0)
									{
										_ = 19;
									}
									continue;
								case 12:
									obj = 2;
									if (3 != 0)
									{
										_ = 35;
									}
									continue;
								case 69:
									_ = ref obj;
									_ = 49;
									continue;
								case 58:
									if (&obj != null)
									{
										_ = 73;
										continue;
									}
									goto case 40;
								case 53:
									_ = ref obj;
									_ = 74;
									continue;
								case 42:
									obj = obj;
									if (false)
									{
										_ = 32;
									}
									continue;
								case 81:
									if (47 != 0)
									{
										_ = 12;
									}
									continue;
								case 22:
								{
									object obj3 = obj;
									obj = 75;
									reference = ref *(object*)obj3;
									continue;
								}
								case 43:
									obj = 5;
									if (20 != 0)
									{
										_ = 0;
									}
									continue;
								case 84:
									if (42 == 0)
									{
										_ = 48;
									}
									continue;
								case 48:
									_ = ref obj;
									if (true)
									{
										_ = 0;
									}
									continue;
								case 32:
									reference = ref obj;
									obj = 10;
									continue;
								case 76:
									obj = -1;
									if (51 == 0)
									{
										_ = 87;
									}
									continue;
								case 13:
									_ = ref obj;
									if (24 != 0)
									{
										_ = 29;
									}
									continue;
								case 79:
									return;
								case 31:
									goto IL_05c8;
								case 82:
									_ = 71;
									continue;
								case 29:
									obj = obj;
									if (38 != 0)
									{
										_ = 41;
									}
									continue;
								case 17:
									obj = obj;
									if (15 != 0)
									{
										_ = 33;
									}
									continue;
								default:
									_ = 54;
									continue;
								case 64:
									obj = obj;
									if (58 == 0)
									{
										_ = 58;
									}
									continue;
								case 24:
									obj = obj;
									_ = 39;
									continue;
								case 36:
									goto IL_0661;
								case 44:
									obj = obj;
									obj = 53;
									continue;
								case 14:
									obj = obj;
									_ = 69;
									continue;
								case 4:
									obj = 3;
									if (37 == 0)
									{
										_ = 81;
									}
									continue;
								case 45:
									obj = 4;
									if (84 != 0)
									{
										_ = 33;
									}
									continue;
								case 59:
									_ = 65;
									continue;
								case 70:
									goto IL_06da;
								case 71:
									obj = obj;
									_ = 11;
									continue;
								case 55:
									_ = 77;
									continue;
								case 2:
									_ = ref obj;
									_ = 61;
									continue;
								case 61:
									return;
								case 51:
									_ = ref obj;
									if (16 == 0)
									{
										_ = 8;
									}
									continue;
								case 35:
									_ = 2;
									continue;
								case 56:
									obj = obj;
									obj = 3;
									continue;
								case 54:
									obj = -1;
									_ = 57;
									continue;
								case 47:
									_ = ref obj;
									if (7 != 0)
									{
										_ = 63;
									}
									continue;
								case 18:
									_ = 5;
									continue;
								case 67:
									if (85 == 0)
									{
										_ = 40;
									}
									continue;
								case 15:
									if (1 == 0)
									{
										_ = 7;
									}
									continue;
								case 73:
								case 87:
									_ = ref obj;
									if (14 == 0)
									{
										_ = 6;
									}
									continue;
								case 6:
									goto IL_07fe;
								case 9:
									_ = 23;
									continue;
								case 38:
									_ = ref obj;
									if (17 == 0)
									{
										_ = 11;
									}
									continue;
								case 63:
									return;
								case 60:
									if (&obj == null)
									{
										if (45 != 0)
										{
											_ = 37;
										}
										continue;
									}
									goto case 80;
								case 25:
									obj = -1;
									if (50 == 0)
									{
										_ = 68;
									}
									continue;
								case 62:
									if (65 != 0)
									{
										_ = 72;
									}
									continue;
								case 86:
									if (&obj == null)
									{
										if (2 == 0)
										{
											_ = 66;
										}
										continue;
									}
									goto case 13;
								case 66:
									obj = 0;
									_ = 67;
									continue;
								case 37:
									goto IL_08d4;
								case 50:
									obj = obj;
									if (56 == 0)
									{
										_ = 86;
									}
									continue;
								case 16:
									return;
								case 10:
									obj = obj;
									_ = 60;
									continue;
								case 39:
									_ = ref obj;
									_ = 27;
									continue;
								case 85:
									_ = ref obj;
									_ = 79;
									continue;
								case 23:
									goto end_IL_004c;
								}
								break;
							}
							goto case 0;
							IL_08d4:
							obj = (object)Unsafe.AsPointer(ref this);
							if (30 == 0)
							{
								_ = 11;
							}
							goto IL_0077;
							IL_05c8:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 15;
							goto IL_0077;
							IL_07fe:
							obj = (object)Unsafe.AsPointer(ref this);
							if (false)
							{
								_ = 0;
							}
							goto IL_0077;
							IL_06da:
							obj = (object)Unsafe.AsPointer(ref this);
							if (44 != 0)
							{
								_ = 59;
							}
							goto IL_0077;
							IL_0661:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 19;
							goto IL_0077;
							end_IL_004c:
							break;
						}
						break;
					case 3:
						obj = (object)Unsafe.AsPointer(ref this);
						if (1 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 2:
						break;
					case 5:
						return;
					default:
						goto end_IL_0019;
					}
					_ = -2;
					if (false)
					{
						_ = 0;
					}
					continue;
					end_IL_0019:
					break;
				}
				obj = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 㰀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778732, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte 㴀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 㸀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778731, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnDataReceivedAsync_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DataReceivedEventArgs e;

		public JavaGame _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object DecorateStatelessFinalizer;

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
		internal static bool CheckScheduledAggregator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JoinDecryptor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void Ⰰ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778730, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void ⴀ(object P_0)
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
		internal unsafe static object _2E00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778729, new IntPtr(2737337594924L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _2F00()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _3000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778728, new IntPtr(2737337584524L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _3200()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_005b: Expected Obj, but got Ref
			//IL_02f1: Expected Obj, but got Ref
			//IL_0200: Expected Obj, but got I4
			//IL_021c: Expected Obj, but got Ref
			//IL_01c7: Expected Obj, but got I4
			//IL_0396->IL0019: Incompatible stack heights: 3 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0065->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0072->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0086->IL0095: Incompatible stack heights: 0 vs 1
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00e4->IL0095: Incompatible stack heights: 0 vs 1
			//IL_0102->IL0095: Incompatible stack heights: 0 vs 1
			//IL_0121->IL0130: Incompatible stack heights: 0 vs 2
			//IL_0169->IL0233: Incompatible stack heights: 1 vs 0
			//IL_012c->IL0130: Incompatible stack heights: 1 vs 2
			//IL_020d->IL0130: Incompatible stack heights: 3 vs 2
			//IL_0228->IL0130: Incompatible stack heights: 1 vs 2
			//IL_01fb->IL0130: Incompatible stack heights: 3 vs 2
			//IL_017b->IL0130: Incompatible stack heights: 3 vs 2
			//IL_01a8->IL0130: Incompatible stack heights: 3 vs 2
			//IL_018d->IL0130: Incompatible stack heights: 4 vs 2
			//IL_01d2->IL0130: Incompatible stack heights: 4 vs 2
			//IL_0275->IL0130: Incompatible stack heights: 1 vs 2
			//IL_0218->IL0130: Incompatible stack heights: 3 vs 2
			//IL_0233->IL0130: Incompatible stack heights: 1 vs 2
			//IL_01b3->IL0130: Incompatible stack heights: 3 vs 2
			//IL_0198->IL0130: Incompatible stack heights: 4 vs 2
			//IL_0280->IL0130: Incompatible stack heights: 1 vs 2
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 4:
					return;
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 2;
					continue;
				case 5:
					_ = 4;
					continue;
				default:
					if (obj == null)
					{
						if (2 != 0)
						{
							num = 2;
						}
						goto IL_0095;
					}
					goto IL_02ec;
				case 1:
					break;
					IL_02ec:
					obj = (object)Unsafe.AsPointer(ref this);
					num = 3;
					goto IL_0095;
					IL_0095:
					while (true)
					{
						switch (num)
						{
						default:
							if (4 == 0)
							{
								num = 5;
							}
							continue;
						case 3:
							if (obj == null)
							{
								if (6 == 0)
								{
									num = 6;
								}
								continue;
							}
							goto default;
						case 5:
							if (obj == null)
							{
								if (0 == 0)
								{
									_ = 0;
								}
								goto IL_0130;
							}
							goto IL_0233;
						case 4:
							break;
						case 1:
						case 6:
							goto end_IL_0019;
							IL_0233:
							obj = obj;
							goto IL_0130;
							IL_0130:
							while (true)
							{
								switch (2)
								{
								case 11:
									return;
								case 1:
								case 7:
									_ = ref obj;
									_ = 3;
									continue;
								case 9:
									_ = ref obj;
									if (5 == 0)
									{
										_ = 11;
									}
									continue;
								case 8:
									if (3 == 0)
									{
										_ = 9;
									}
									continue;
								case 10:
									obj = 0;
									_ = 8;
									continue;
								case 6:
									_ = 4;
									continue;
								case 4:
									obj = -1;
									if (7 == 0)
									{
										_ = 4;
									}
									continue;
								default:
									obj = (object)Unsafe.AsPointer(ref this);
									if (false)
									{
										_ = 6;
									}
									continue;
								case 12:
									break;
								case 2:
									if (&obj != null)
									{
										if (1 == 0)
										{
											_ = 0;
										}
										continue;
									}
									goto case 10;
								case 3:
									goto end_IL_0019;
								}
								break;
							}
							goto IL_0233;
						}
						break;
					}
					goto IL_02ec;
					end_IL_0019:
					break;
				}
				_ = -2;
				_ = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _3300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778727, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte 㐀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnDataReceivedAsync_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		public string line;

		private TaskAwaiter _003C_003Eu__1;

		private static object MoveError;

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
		internal static bool ChangeCache()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CustomizeUser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _2100(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778726, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _2200(object P_0)
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
		internal static object _2300()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _2400()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778725, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _2800()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_048f: Expected Obj, but got Ref
			//IL_0474: Expected Obj, but got Ref
			//IL_00c5: Expected Obj, but got Ref
			//IL_009c: Expected Obj, but got I4
			//IL_00aa: Expected Obj, but got I4
			//IL_0189: Expected Obj, but got I4
			//IL_03d3: Expected Obj, but got I4
			//IL_030b: Expected Obj, but got I4
			//IL_0321: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0499->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0480->IL0019: Incompatible stack heights: 0 vs 1
			//IL_04a8->IL0019: Incompatible stack heights: 3 vs 1
			//IL_048b->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0470->IL0019: Incompatible stack types: I4 vs Ref
			//IL_004d->IL0051: Incompatible stack heights: 1 vs 0
			//IL_00dc->IL0051: Incompatible stack heights: 1 vs 0
			//IL_00a7->IL0051: Incompatible stack heights: 3 vs 0
			//IL_0194->IL0051: Incompatible stack heights: 3 vs 0
			//IL_00ea->IL0051: Incompatible stack heights: 3 vs 0
			//IL_0105->IL03d8: Incompatible stack heights: 1 vs 0
			//IL_0175->IL0051: Incompatible stack heights: 2 vs 0
			//IL_0184->IL0051: Incompatible stack heights: 1 vs 0
			//IL_015d->IL0051: Incompatible stack heights: 3 vs 0
			//IL_012e->IL0051: Incompatible stack heights: 1 vs 0
			//IL_01b1->IL01b5: Incompatible stack types: I4 vs Ref
			//IL_00c1->IL0051: Incompatible stack heights: 1 vs 0
			//IL_014b->IL0051: Incompatible stack heights: 1 vs 0
			//IL_0051->IL0051: Incompatible stack heights: 2 vs 0
			//IL_0111->IL0051: Incompatible stack heights: 1 vs 0
			//IL_0168->IL0051: Incompatible stack heights: 3 vs 0
			//IL_0234->IL01b5: Incompatible stack heights: 3 vs 2
			//IL_0270->IL01b5: Incompatible stack heights: 1 vs 2
			//IL_011c->IL0051: Incompatible stack heights: 1 vs 0
			//IL_02bf->IL01b5: Incompatible stack heights: 1 vs 2
			//IL_0254->IL01b5: Incompatible stack heights: 1 vs 2
			//IL_0326->IL01b1: Incompatible stack heights: 1 vs 3
			//IL_01b5->IL01b5: Incompatible stack heights: 4 vs 2
			//IL_023f->IL01b5: Incompatible stack heights: 3 vs 2
			//IL_027b->IL01b5: Incompatible stack heights: 1 vs 2
			//IL_0290->IL01b5: Incompatible stack heights: 1 vs 2
			//IL_02e4->IL01b5: Incompatible stack heights: 1 vs 2
			//IL_02ca->IL01b5: Incompatible stack heights: 1 vs 2
			//IL_025f->IL01b5: Incompatible stack heights: 1 vs 2
			//IL_029b->IL01b5: Incompatible stack heights: 1 vs 2
			//IL_02ef->IL01b5: Incompatible stack heights: 1 vs 2
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			ref _003COnDataReceivedAsync_003Ed__13 reference = ref *(_003COnDataReceivedAsync_003Ed__13*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 4u:
					if (obj != null)
					{
						_ = 13;
						goto IL_0051;
					}
					goto IL_00c1;
				case 3u:
					reference = ref this;
					if (false)
					{
						reference = ref *(_003COnDataReceivedAsync_003Ed__13*)null;
					}
					continue;
				case 2u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						reference = ref *(_003COnDataReceivedAsync_003Ed__13*)1;
					}
					continue;
				case 1u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003COnDataReceivedAsync_003Ed__13*)4;
					continue;
				case 0u:
					return;
				case 5u:
					break;
					IL_0051:
					while (true)
					{
						switch ((int)/*Error near IL_0092: Stack underflow*/)
						{
						case 2:
							obj = -1;
							_ = 9;
							continue;
						case 3:
							obj = 0;
							if (0 == 0)
							{
								_ = 1;
							}
							continue;
						case 12:
							break;
						case 6:
							_ = 14;
							continue;
						case 10:
							return;
						case 8:
							if (obj != null)
							{
								if (2 == 0)
								{
									_ = 4;
								}
								continue;
							}
							goto end_IL_0019;
						default:
							if (&obj == null)
							{
								_ = 5;
								continue;
							}
							goto case 9;
						case 4:
							obj = obj;
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 14:
							_ = ref obj;
							if (10 == 0)
							{
								_ = 10;
							}
							continue;
						case 9:
							_ = ref obj;
							_ = 11;
							continue;
						case 13:
							obj = obj;
							_ = 3;
							continue;
						case 5:
							obj = 0;
							_ = 6;
							continue;
						case 1:
						{
							ref object reference2 = ref obj;
							if (6 != 0)
							{
								reference2 = ref *(object*)4;
							}
							while (true)
							{
								switch ((uint)Unsafe.AsPointer(ref reference2))
								{
								case 4u:
								case 8u:
								case 9u:
									break;
								case 6u:
									if (true)
									{
										_ = 12;
									}
									continue;
								case 2u:
									if (Unsafe.AsPointer(ref this) == null)
									{
										if (5 != 0)
										{
											_ = 11;
										}
										continue;
									}
									goto case 5u;
								case 10u:
									if (3 == 0)
									{
										_ = 3;
									}
									continue;
								case 11u:
									if (Unsafe.AsPointer(ref this) != null)
									{
										if (7 == 0)
										{
											_ = 1;
										}
										continue;
									}
									goto default;
								default:
									if (Unsafe.AsPointer(ref this) == null)
									{
										if (9 == 0)
										{
											_ = 0;
										}
										continue;
									}
									goto case 5u;
								case 12u:
									if ((nint)obj <= 500)
									{
										if (true)
										{
											_ = 0;
										}
										continue;
									}
									goto case 10u;
								case 5u:
								case 7u:
									_ = 1;
									obj = 8;
									continue;
								case 1u:
								case 3u:
									if (obj != null)
									{
										obj = 4;
										continue;
									}
									goto case 2u;
								}
								break;
							}
							goto case 8;
						}
						case 7:
							obj = 2;
							continue;
						case 11:
							goto end_IL_0019;
						}
						break;
					}
					goto IL_00c1;
					IL_00c1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (7 == 0)
					{
						_ = 7;
					}
					goto IL_0051;
					end_IL_0019:
					break;
				}
				_ = -2;
				_ = 3;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _2900()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778724, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _2A00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778723, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _2B00()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnDisconnectedAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		private CancellationToken _003Ctoken_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		internal static object CheckOperationalAnalyzer;

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
		internal static bool InstantiatePublisher()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateIdentifiableNotifier()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _1400(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778722, new IntPtr(2737337578284L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void ᔀ(object P_0)
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
		private unsafe sealed void ᘀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778721, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ᜀ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _1800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778720, new IntPtr(2737337594924L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void Ḁ()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_0043: Expected Obj, but got Ref
			//IL_067b: Expected Obj, but got Ref
			//IL_023b: Expected Obj, but got Ref
			//IL_046c: Expected Obj, but got Ref
			//IL_02b3: Expected Obj, but got Ref
			//IL_01cb: Expected Obj, but got I4
			//IL_028f: Expected Obj, but got I4
			//IL_02e6: Expected Obj, but got I4
			//IL_04ec: Expected Obj, but got I4
			//IL_0450: Expected Obj, but got I4
			//IL_0440: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_06a1->IL0019: Incompatible stack heights: 3 vs 1
			//IL_004d->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0687->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0677->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0692->IL0019: Incompatible stack types: I4 vs Ref
			//IL_065d->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00ce->IL0070: Incompatible stack heights: 1 vs 0
			//IL_006c->IL0070: Incompatible stack heights: 1 vs 0
			//IL_055d->IL0070: Incompatible stack heights: 1 vs 0
			//IL_03a3->IL0070: Incompatible stack heights: 1 vs 0
			//IL_056e->IL0070: Incompatible stack heights: 2 vs 0
			//IL_0111->IL0070: Incompatible stack heights: 2 vs 0
			//IL_0396->IL0070: Incompatible stack heights: 1 vs 0
			//IL_0150->IL0070: Incompatible stack heights: 1 vs 0
			//IL_0579->IL0070: Incompatible stack heights: 2 vs 0
			//IL_011c->IL0070: Incompatible stack heights: 2 vs 0
			//IL_03b5->IL03b9: Incompatible stack heights: 1 vs 0
			//IL_0598->IL0070: Incompatible stack heights: 1 vs 0
			//IL_0252->IL0174: Incompatible stack heights: 1 vs 0
			//IL_0170->IL0174: Incompatible stack heights: 1 vs 0
			//IL_00ed->IL0070: Incompatible stack heights: 1 vs 0
			//IL_0483->IL03b9: Incompatible stack heights: 1 vs 0
			//IL_025f->IL0174: Incompatible stack heights: 2 vs 0
			//IL_02bd->IL0174: Incompatible stack heights: 2 vs 0
			//IL_026c->IL0174: Incompatible stack heights: 1 vs 0
			//IL_01d6->IL0174: Incompatible stack heights: 3 vs 0
			//IL_027f->IL0174: Incompatible stack heights: 1 vs 0
			//IL_029c->IL0174: Incompatible stack heights: 2 vs 0
			//IL_0216->IL0174: Incompatible stack heights: 4 vs 0
			//IL_01f7->IL0174: Incompatible stack heights: 2 vs 0
			//IL_0411->IL03b9: Incompatible stack heights: 2 vs 0
			//IL_043b->IL03b9: Incompatible stack heights: 3 vs 0
			//IL_04b1->IL03b9: Incompatible stack heights: 1 vs 0
			//IL_045d->IL03b9: Incompatible stack heights: 2 vs 0
			//IL_0404->IL03b9: Incompatible stack heights: 2 vs 0
			//IL_044b->IL03b9: Incompatible stack heights: 3 vs 0
			//IL_028a->IL0174: Incompatible stack heights: 1 vs 0
			//IL_02a7->IL0174: Incompatible stack heights: 2 vs 0
			//IL_0228->IL0174: Incompatible stack heights: 1 vs 0
			//IL_0174->IL0174: Incompatible stack heights: 3 vs 0
			//IL_030f->IL0174: Incompatible stack heights: 1 vs 0
			//IL_01ea->IL0174: Incompatible stack heights: 1 vs 0
			//IL_02fd->IL0174: Incompatible stack heights: 1 vs 0
			//IL_04dd->IL03b9: Incompatible stack heights: 1 vs 0
			//IL_03b9->IL03b9: Incompatible stack heights: 4 vs 0
			//IL_04bc->IL03b9: Incompatible stack heights: 1 vs 0
			//IL_0468->IL03b9: Incompatible stack heights: 2 vs 0
			//IL_04a1->IL03b9: Incompatible stack heights: 1 vs 0
			//IL_031a->IL0174: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			ref _003COnDisconnectedAsync_003Ed__14 reference = ref *(_003COnDisconnectedAsync_003Ed__14*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003COnDisconnectedAsync_003Ed__14*)2;
					continue;
				case 2u:
					if (obj != null)
					{
						if (9 != 0)
						{
							_ = 8;
						}
						goto IL_0070;
					}
					goto IL_00b6;
				case 5u:
					reference = ref this;
					if (true)
					{
						reference = ref *(_003COnDisconnectedAsync_003Ed__14*)1;
					}
					continue;
				case 1u:
					reference = ref this;
					if (6 != 0)
					{
						reference = ref *(_003COnDisconnectedAsync_003Ed__14*)1;
					}
					continue;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (3 == 0)
					{
						reference = ref *(_003COnDisconnectedAsync_003Ed__14*)3;
					}
					continue;
				case 6u:
					return;
					IL_0070:
					while (true)
					{
						switch ((int)/*Error near IL_00b1: Stack underflow*/)
						{
						case 12:
							break;
						case 9:
							if ((nint)obj != 1)
							{
								if (1 == 0)
								{
									_ = 0;
								}
								continue;
							}
							goto case 6;
						case 13:
							if (6 == 0)
							{
								_ = 8;
							}
							continue;
						case 6:
						case 10:
							if (7 == 0)
							{
								_ = 0;
							}
							continue;
						case 7:
							if ((nint)obj != 1)
							{
								if (0 == 0)
								{
									_ = 4;
								}
								goto IL_0174;
							}
							goto IL_0237;
						case 4:
							if (obj == null)
							{
								goto end_IL_0019;
							}
							_ = 10;
							continue;
						case 8:
							_ = 4;
							continue;
						case 14:
							if (obj != null)
							{
								_ = 12;
								goto IL_03b9;
							}
							goto IL_0468;
						case 2:
						case 5:
							goto IL_0550;
						case 11:
							if (13 == 0)
							{
								_ = 13;
							}
							continue;
						case 1:
							if (obj == null)
							{
								if (5 == 0)
								{
									_ = 5;
								}
								continue;
							}
							break;
						default:
							goto end_IL_0019;
							IL_0237:
							obj = (object)Unsafe.AsPointer(ref this);
							if (false)
							{
								_ = 0;
							}
							goto IL_0174;
							IL_0468:
							obj = (object)Unsafe.AsPointer(ref this);
							if (8 != 0)
							{
								_ = 9;
							}
							goto IL_03b9;
							IL_03b9:
							while (true)
							{
								switch ((int)/*Error near IL_03f2: Stack underflow*/)
								{
								case 9:
									_ = 7;
									continue;
								case 1:
								case 2:
									_ = ref obj;
									_ = 6;
									continue;
								case 3:
									_ = 5;
									continue;
								case 10:
									obj = 0;
									_ = 3;
									continue;
								case 7:
									obj = -1;
									if (1 == 0)
									{
										_ = 0;
									}
									continue;
								case 8:
									break;
								case 12:
									obj = obj;
									if (0 == 0)
									{
										_ = 0;
									}
									continue;
								case 6:
									if (4 == 0)
									{
										_ = 1;
									}
									continue;
								case 11:
									return;
								default:
									if (&obj != null)
									{
										_ = 2;
										continue;
									}
									goto case 10;
								case 5:
									_ = ref obj;
									obj = 11;
									continue;
								case 4:
									goto IL_0550;
								}
								break;
							}
							goto IL_0468;
							IL_0550:
							obj = (object)/*Error near IL_0553: Stack underflow*/;
							_ = 11;
							continue;
							IL_0174:
							while (true)
							{
								switch ((int)/*Error near IL_01c1: Stack underflow*/)
								{
								case 3:
									obj = 1;
									_ = 15;
									continue;
								case 16:
									break;
								case 13:
								case 14:
									_ = ref obj;
									_ = 17;
									continue;
								case 11:
									_ = ref obj;
									_ = 12;
									continue;
								case 10:
									if (&obj != null)
									{
										_ = 14;
										continue;
									}
									goto case 3;
								case 12:
									return;
								case 9:
									goto end_IL_0174;
								default:
									_ = 5;
									continue;
								case 2:
									_ = 16;
									continue;
								case 4:
									if (1 == 0)
									{
										_ = 1;
									}
									continue;
								case 5:
									obj = -1;
									if (10 == 0)
									{
										_ = 13;
									}
									continue;
								case 1:
									_ = (double)obj;
									obj = (object)Unsafe.AsPointer(ref this);
									_ = 10;
									continue;
								case 15:
									obj = 11;
									continue;
								case 17:
									if (Unsafe.AsPointer(ref this) != null)
									{
										_ = 7;
										continue;
									}
									goto case 2;
								case 6:
								case 7:
								case 8:
									goto end_IL_0019;
								}
								if (obj == null)
								{
									_ = 8;
								}
								else if (false)
								{
									_ = 6;
								}
								continue;
								end_IL_0174:
								break;
							}
							goto IL_0237;
						}
						break;
					}
					goto IL_00b6;
					IL_00b6:
					if (14 == 0)
					{
						_ = 3;
					}
					goto IL_0070;
					end_IL_0019:
					break;
				}
				_ = -2;
				_ = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte ἀ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _2000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778655, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPrepareBaseVersionAsync_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		public CancellationToken cancellationToken;

		private TaskAwaiter<EntityGameClientPatch> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		internal static object AttachMap;

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
		internal static bool AddVisitor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectInternalParser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _0B00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778654, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _0C00(object P_0)
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
		private unsafe sealed void _0D00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778653, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _0E00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778652, new IntPtr(2737337583484L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ༀ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void က()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0365: Expected Obj, but got Ref
			//IL_039b: Expected Obj, but got Ref
			//IL_017a: Expected Obj, but got Ref
			//IL_0183: Expected Obj, but got I4
			//IL_027c: Expected Obj, but got I4
			//IL_015a: Expected Obj, but got Ref
			//IL_0108: Expected Obj, but got I4
			//IL_00c9: Expected Obj, but got I4
			//IL_00d3: Expected Obj, but got I4
			//IL_01ac: Expected Obj, but got I4
			//IL_0212: Expected Obj, but got I4
			//IL_016c: Expected Obj, but got I4
			//IL_01e9: Expected Obj, but got Ref
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_038c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0371->IL0019: Incompatible stack heights: 0 vs 1
			//IL_03a5->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0361->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0397->IL0019: Incompatible stack heights: 2 vs 1
			//IL_037c->IL0019: Incompatible stack types: I4 vs Ref
			//IL_005e->IL005e: Incompatible stack heights: 1 vs 0
			//IL_005a->IL005e: Incompatible stack heights: 1 vs 0
			//IL_0281->IL005a: Incompatible stack heights: 3 vs 0
			//IL_014a->IL005e: Incompatible stack heights: 9 vs 0
			//IL_0164->IL005e: Incompatible stack heights: 1 vs 0
			//IL_0113->IL005e: Incompatible stack heights: 3 vs 0
			//IL_00e8->IL005e: Incompatible stack heights: 2 vs 0
			//IL_02b0->IL005e: Incompatible stack heights: 2 vs 0
			//IL_00d8->IL005a: Incompatible stack heights: 2 vs 0
			//IL_01b7->IL005e: Incompatible stack heights: 3 vs 0
			//IL_0239->IL005e: Incompatible stack heights: 1 vs 0
			//IL_0253->IL005e: Incompatible stack heights: 1 vs 0
			//IL_0103->IL005e: Incompatible stack heights: 4 vs 0
			//IL_021f->IL005e: Incompatible stack heights: 2 vs 0
			//IL_0176->IL005e: Incompatible stack heights: 2 vs 0
			//IL_0202->IL005e: Incompatible stack heights: 1 vs 0
			//IL_01f3->IL005e: Incompatible stack heights: 1 vs 0
			//IL_0155->IL005e: Incompatible stack heights: 9 vs 0
			//IL_00f3->IL005e: Incompatible stack heights: 2 vs 0
			//IL_02bb->IL005e: Incompatible stack heights: 2 vs 0
			//IL_0244->IL005e: Incompatible stack heights: 1 vs 0
			//IL_025e->IL005e: Incompatible stack heights: 1 vs 0
			//IL_022a->IL005e: Incompatible stack heights: 2 vs 0
			//IL_020d->IL005e: Incompatible stack heights: 1 vs 0
			//IL_01a7->IL005e: Incompatible stack heights: 1 vs 0
			//IL_02a0->IL005e: Incompatible stack heights: 1 vs 0
			//IL_01d6->IL005e: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			ref _003CPrepareBaseVersionAsync_003Ed__43 reference = ref *(_003CPrepareBaseVersionAsync_003Ed__43*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 1u:
					if (obj != null)
					{
						if (false)
						{
							_ = 2;
						}
						goto IL_005e;
					}
					goto IL_0176;
				case 0u:
					return;
				case 2u:
					reference = ref this;
					if (false)
					{
						reference = ref *(_003CPrepareBaseVersionAsync_003Ed__43*)null;
					}
					break;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						reference = ref *(_003CPrepareBaseVersionAsync_003Ed__43*)1;
					}
					break;
				case 3u:
					goto IL_037c;
				case 5u:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(_003CPrepareBaseVersionAsync_003Ed__43*)4;
						break;
					}
					IL_037c:
					_ = -2;
					if (2 == 0)
					{
						_ = 2;
					}
					break;
					IL_0176:
					obj = (object)Unsafe.AsPointer(ref this);
					obj = 15;
					goto IL_005e;
					IL_005e:
					while (true)
					{
						switch ((int)/*Error near IL_00bf: Stack underflow*/)
						{
						case 12:
							obj = 1;
							obj = 11;
							continue;
						case 9:
							if (1 == 0)
							{
								_ = 1;
							}
							continue;
						case 16:
							_ = ref obj;
							_ = 22;
							continue;
						case 7:
							obj = 0;
							_ = 9;
							continue;
						case 22:
							return;
						case 4:
							_ = 2;
							_ = null;
							obj = null;
							if (false)
							{
								_ = 0;
							}
							continue;
						case 6:
						case 17:
							obj = (object)(&obj);
							_ = 4;
							continue;
						case 19:
							obj = 0;
							_ = 8;
							continue;
						case 5:
							break;
						default:
							if (&obj == null)
							{
								if (3 == 0)
								{
									_ = 12;
								}
								continue;
							}
							goto case 14;
						case 13:
							obj = -1;
							_ = 14;
							continue;
						case 8:
							if (&obj != null)
							{
								if (15 == 0)
								{
									_ = 17;
								}
								continue;
							}
							goto case 7;
						case 3:
							return;
						case 21:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 20;
							continue;
						case 20:
							if (1 == 0)
							{
								_ = 13;
							}
							continue;
						case 18:
							obj = -1;
							if (6 != 0)
							{
								_ = 3;
							}
							continue;
						case 14:
							_ = ref obj;
							if (10 == 0)
							{
								_ = 3;
							}
							continue;
						case 15:
							if (18 == 0)
							{
								_ = 16;
							}
							continue;
						case 1:
							_ = ref obj;
							obj = 3;
							continue;
						case 2:
							if ((nint)obj != 1)
							{
								if (15 != 0)
								{
									_ = 19;
								}
								continue;
							}
							goto case 21;
						case 11:
							if (7 != 0)
							{
								_ = 16;
							}
							continue;
						case 10:
							goto IL_037c;
						}
						break;
					}
					goto IL_0176;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void ᄀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778651, new IntPtr(2737337584524L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte ሀ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte ጀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778650, new IntPtr(2737337584524L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPrepareComponentsAsync_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		public CancellationToken cancellationToken;

		private List<ComponentPath> _003Cdownloads_003E5__2;

		private List<ulong> _003C_003E7__wrap2;

		private TaskAwaiter<EntityAuthItem> _003C_003Eu__1;

		private TaskAwaiter<EntityItemDownload[]> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private List<ComponentPath>.Enumerator _003C_003E7__wrap3;

		private object _003Cpath_003E5__5;

		private static object CheckExpandableState;

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
		internal static bool CheckHiddenHandler()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckAdjustableStruct()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ﴀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778649, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FE00(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FF00()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object Ā()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778648, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void ࠀ()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_0076: Expected I4, but got Obj
			//IL_0043: Expected Obj, but got Ref
			//IL_0db5: Expected Obj, but got Ref
			//IL_03ce: Expected Obj, but got Ref
			//IL_05af: Expected Obj, but got Ref
			//IL_0206: Expected Obj, but got Ref
			//IL_04cd: Expected Obj, but got Ref
			//IL_0535: Expected Obj, but got I4
			//IL_028d: Expected Obj, but got Ref
			//IL_0323: Expected Obj, but got Ref
			//IL_0b89: Expected Obj, but got I4
			//IL_0b93: Expected Obj, but got I4
			//IL_0526: Expected Obj, but got I4
			//IL_0b9d: Expected Obj, but got I4
			//IL_05cb: Expected Obj, but got I4
			//IL_0b43: Expected Obj, but got I4
			//IL_0bbd: Expected Obj, but got I4
			//IL_0545: Expected Obj, but got I4
			//IL_0251: Expected Obj, but got I4
			//IL_0a56: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a59: Expected Obj, but got Unknown
			//IL_0a81: Expected Obj, but got I4
			//IL_02fd: Expected Obj, but got I4
			//IL_0cdd: Expected Obj, but got Ref
			//IL_0ce6: Expected Obj, but got I4
			//IL_0960: Expected Obj, but got Ref
			//IL_0969: Expected Obj, but got I4
			//IL_0d0b: Expected Obj, but got Ref
			//IL_0999: Expected Obj, but got I4
			//IL_09a3: Expected Obj, but got I4
			//IL_08d0: Expected Obj, but got I4
			//IL_0862: Expected Obj, but got Ref
			//IL_086b: Expected Obj, but got I4
			//IL_089c: Expected Obj, but got I4
			//IL_0794: Expected Obj, but got Ref
			//IL_0725: Expected Obj, but got I4
			//IL_072f: Expected Obj, but got I4
			//IL_083a: Expected Obj, but got I4
			//IL_07e6: Expected Obj, but got I4
			//IL_0df4->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004f->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0dc1->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0ddb->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0e02->IL0019: Incompatible stack heights: 3 vs 1
			//IL_03d8->IL0091: Incompatible stack types: I4 vs Ref
			//IL_05bb->IL0091: Incompatible stack heights: 0 vs 1
			//IL_0210->IL0091: Incompatible stack types: I4 vs Ref
			//IL_04d7->IL0091: Incompatible stack types: I4 vs Ref
			//IL_0347->IL0091: Incompatible stack heights: 0 vs 1
			//IL_0082->IL0091: Incompatible stack heights: 0 vs 1
			//IL_005a->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0dcc->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0de6->IL0019: Incompatible stack heights: 2 vs 1
			//IL_05c6->IL0091: Incompatible stack types: I4 vs Ref
			//IL_0352->IL0091: Incompatible stack types: I4 vs Ref
			//IL_008d->IL0091: Incompatible stack types: I4 vs Ref
			//IL_041d->IL0b11: Incompatible stack heights: 1 vs 0
			//IL_0c77->IL0091: Incompatible stack heights: 3 vs 1
			//IL_0ac0->IL0091: Incompatible stack heights: 3 vs 1
			//IL_0ace->IL0091: Incompatible stack heights: 2 vs 1
			//IL_0581->IL0091: Incompatible stack heights: 2 vs 1
			//IL_0518->IL0091: Incompatible stack types: Obj vs Ref
			//IL_0540->IL0091: Incompatible stack heights: 3 vs 1
			//IL_05ab->IL0091: Incompatible stack heights: 3 vs 1
			//IL_0b72->IL0091: Incompatible stack heights: 3 vs 1
			//IL_0299->IL0091: Incompatible stack heights: 0 vs 1
			//IL_032f->IL0091: Incompatible stack heights: 0 vs 1
			//IL_024c->IL0091: Incompatible stack heights: 2 vs 1
			//IL_0b24->IL0091: Incompatible stack heights: 3 vs 1
			//IL_02b4->IL0091: Incompatible stack heights: 0 vs 1
			//IL_0ab2->IL0091: Incompatible stack heights: 4 vs 1
			//IL_04a9->IL0091: Incompatible stack heights: 3 vs 1
			//IL_0380->IL0091: Incompatible stack heights: 4 vs 1
			//IL_0c18->IL0091: Incompatible stack heights: 4 vs 1
			//IL_039c->IL0091: Incompatible stack heights: 2 vs 1
			//IL_04e5->IL0091: Incompatible stack heights: 2 vs 1
			//IL_04b6->IL0091: Incompatible stack heights: 2 vs 1
			//IL_0288->IL0091: Incompatible stack heights: 3 vs 1
			//IL_01f7->IL0091: Incompatible stack heights: 2 vs 1
			//IL_0a97->IL0091: Incompatible stack heights: 2 vs 1
			//IL_0c65->IL0091: Incompatible stack heights: 5 vs 1
			//IL_04f3->IL0091: Incompatible stack heights: 2 vs 1
			//IL_02e1->IL0091: Incompatible stack heights: 2 vs 1
			//IL_0530->IL0091: Incompatible stack types: I4 vs Ref
			//IL_0ba8->IL0091: Incompatible stack heights: 3 vs 1
			//IL_05d6->IL0091: Incompatible stack heights: 3 vs 1
			//IL_0b50->IL0091: Incompatible stack heights: 2 vs 1
			//IL_0370->IL0091: Incompatible stack heights: 2 vs 1
			//IL_0bca->IL0091: Incompatible stack heights: 2 vs 1
			//IL_038f->IL0091: Incompatible stack heights: 3 vs 1
			//IL_0550->IL0091: Incompatible stack heights: 3 vs 1
			//IL_0c49->IL0091: Incompatible stack types: Obj vs Ref
			//IL_025e->IL0091: Incompatible stack heights: 2 vs 1
			//IL_0bfd->IL0091: Incompatible stack heights: 0 vs 1
			//IL_0a65->IL0091: Incompatible stack heights: 0 vs 1
			//IL_03ca->IL0091: Incompatible stack heights: 3 vs 1
			//IL_0471->IL0091: Incompatible stack heights: 4 vs 1
			//IL_0600->IL0091: Incompatible stack types: Obj vs Ref
			//IL_0bb8->IL0091: Incompatible stack heights: 3 vs 1
			//IL_0af7->IL0091: Incompatible stack heights: 2 vs 1
			//IL_0c2c->IL0091: Incompatible stack heights: 0 vs 1
			//IL_0a86->IL008d: Incompatible stack heights: 0 vs 2
			//IL_0363->IL0091: Incompatible stack types: I4 vs Ref
			//IL_0427->IL0091: Incompatible stack heights: 2 vs 1
			//IL_0c82->IL0091: Incompatible stack heights: 3 vs 1
			//IL_0302->IL008d: Incompatible stack heights: 0 vs 2
			//IL_0523->IL0091: Incompatible stack types: I4 vs Ref
			//IL_0b84->IL0091: Incompatible stack types: I4 vs Ref
			//IL_02a4->IL0091: Incompatible stack types: I4 vs Ref
			//IL_033a->IL0091: Incompatible stack types: I4 vs Ref
			//IL_02bf->IL0091: Incompatible stack types: I4 vs Ref
			//IL_0bea->IL0091: Incompatible stack types: I4 vs Ref
			//IL_0b3e->IL0091: Incompatible stack types: I4 vs Ref
			//IL_0091->IL0091: Incompatible stack heights: 3 vs 1
			//IL_0ae0->IL0091: Incompatible stack types: I4 vs Ref
			//IL_0ceb->IL008d: Incompatible stack heights: 3 vs 2
			//IL_0202->IL0091: Incompatible stack heights: 2 vs 1
			//IL_0aa2->IL0091: Incompatible stack heights: 2 vs 1
			//IL_02ec->IL0091: Incompatible stack heights: 2 vs 1
			//IL_0b5b->IL0091: Incompatible stack heights: 2 vs 1
			//IL_0bd5->IL0091: Incompatible stack heights: 2 vs 1
			//IL_03b0->IL0091: Incompatible stack heights: 0 vs 1
			//IL_0cab->IL0091: Incompatible stack types: I4 vs Ref
			//IL_0c54->IL0091: Incompatible stack types: I4 vs Ref
			//IL_02d1->IL0091: Incompatible stack types: I4 vs Ref
			//IL_0269->IL0091: Incompatible stack heights: 2 vs 1
			//IL_045d->IL0091: Incompatible stack types: I4 vs Ref
			//IL_05f0->IL0091: Incompatible stack types: I4 vs Ref
			//IL_0c08->IL0091: Incompatible stack types: I4 vs Ref
			//IL_0a70->IL0091: Incompatible stack types: I4 vs Ref
			//IL_060b->IL0091: Incompatible stack types: I4 vs Ref
			//IL_0b02->IL0091: Incompatible stack heights: 2 vs 1
			//IL_0c37->IL0091: Incompatible stack types: I4 vs Ref
			//IL_0cbe->IL0091: Incompatible stack types: I4 vs Ref
			//IL_0d17->IL0091: Incompatible stack heights: 2 vs 1
			//IL_03bb->IL0091: Incompatible stack types: I4 vs Ref
			//IL_063d->IL063d: Incompatible stack heights: 1 vs 0
			//IL_0639->IL063d: Incompatible stack heights: 1 vs 0
			//IL_0d22->IL0091: Incompatible stack heights: 2 vs 1
			//IL_0920->IL063d: Incompatible stack heights: 3 vs 0
			//IL_07ae->IL063d: Incompatible stack heights: 3 vs 0
			//IL_09a8->IL0639: Incompatible stack heights: 2 vs 0
			//IL_0812->IL063d: Incompatible stack heights: 2 vs 0
			//IL_0942->IL063d: Incompatible stack heights: 2 vs 0
			//IL_0932->IL063d: Incompatible stack heights: 3 vs 0
			//IL_0994->IL063d: Incompatible stack heights: 3 vs 0
			//IL_09f3->IL063d: Incompatible stack heights: 2 vs 0
			//IL_070e->IL063d: Incompatible stack heights: 2 vs 0
			//IL_0890->IL063d: Incompatible stack heights: 2 vs 0
			//IL_08a1->IL0639: Incompatible stack heights: 2 vs 0
			//IL_09da->IL063d: Incompatible stack heights: 2 vs 0
			//IL_0789->IL063d: Incompatible stack heights: 2 vs 0
			//IL_06f5->IL063d: Incompatible stack heights: 3 vs 0
			//IL_079e->IL063d: Incompatible stack heights: 2 vs 0
			//IL_0906->IL063d: Incompatible stack heights: 2 vs 0
			//IL_0734->IL0639: Incompatible stack heights: 2 vs 0
			//IL_083f->IL0639: Incompatible stack heights: 1 vs 0
			//IL_076e->IL063d: Incompatible stack heights: 1 vs 0
			//IL_07f0->IL063d: Incompatible stack heights: 3 vs 0
			//IL_0802->IL063d: Incompatible stack heights: 1 vs 0
			//IL_08b3->IL063d: Incompatible stack heights: 1 vs 0
			//IL_0982->IL063d: Incompatible stack heights: 1 vs 0
			//IL_094d->IL063d: Incompatible stack heights: 2 vs 0
			//IL_0720->IL063d: Incompatible stack heights: 1 vs 0
			//IL_0882->IL063d: Incompatible stack heights: 1 vs 0
			//IL_09e5->IL063d: Incompatible stack heights: 2 vs 0
			//IL_0700->IL063d: Incompatible stack heights: 3 vs 0
			//IL_0911->IL063d: Incompatible stack heights: 2 vs 0
			//IL_0779->IL063d: Incompatible stack heights: 1 vs 0
			//IL_08f4->IL063d: Incompatible stack heights: 1 vs 0
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
					continue;
				default:
				{
					ref byte reference;
					switch ((int)obj)
					{
					default:
						if (42 == 0)
						{
							reference = ref *(byte*)39;
						}
						goto IL_0091;
					case 2:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(byte*)35;
						goto IL_0091;
					case 4:
						goto IL_033a;
					case 0:
						goto IL_03ca;
					case 3:
						goto IL_04c9;
					case 1:
						goto IL_05ab;
						IL_033a:
						if (78 != 0)
						{
							reference = ref *(byte*)28;
						}
						goto IL_0091;
						IL_0091:
						while (true)
						{
							object obj3;
							switch ((uint)Unsafe.AsPointer(ref reference))
							{
							case 41u:
								if (4 == 0)
								{
									_ = 1;
								}
								continue;
							case 45u:
								break;
							case 15u:
								return;
							case 59u:
								return;
							case 19u:
								_ = 56;
								continue;
							case 66u:
								obj = -1;
								if (17 != 0)
								{
									_ = 33;
								}
								continue;
							case 39u:
								_ = 28;
								continue;
							case 17u:
								obj = (object)(&obj);
								if (57 == 0)
								{
									reference = ref *(byte*)76;
								}
								continue;
							case 21u:
								obj = obj;
								if (6 != 0)
								{
									reference = ref *(byte*)49;
								}
								continue;
							case 65u:
								if (&obj != null)
								{
									reference = ref *(byte*)25;
									continue;
								}
								goto case 51u;
							case 47u:
								if (19 == 0)
								{
									_ = 30;
								}
								continue;
							case 7u:
								if (obj == null)
								{
									obj = 72;
									continue;
								}
								goto case 34u;
							case 46u:
								return;
							case 18u:
							case 31u:
								obj = (object)(&obj);
								if (29 == 0)
								{
									reference = ref *(byte*)39;
								}
								continue;
							case 74u:
								goto IL_033a;
							case 2u:
								if (obj == null)
								{
									reference = ref *(byte*)64;
									continue;
								}
								goto case 81u;
							case 54u:
								_ = 66;
								continue;
							case 30u:
								_ = ref obj;
								_ = 59;
								continue;
							case 61u:
								_ = 74;
								continue;
							case 33u:
							case 60u:
								_ = ref obj;
								_ = 61;
								continue;
							case 57u:
								if (obj == null)
								{
									if (26 != 0)
									{
										reference = ref *(byte*)19;
									}
									continue;
								}
								obj3 = obj;
								goto IL_0caf;
							case 73u:
								_ = 71;
								continue;
							case 23u:
								goto IL_03ca;
							case 5u:
								return;
							case 3u:
								if (obj != null)
								{
									_ = 55;
									continue;
								}
								goto case 20u;
							case 67u:
								reference = ref Unsafe.As<_003CPrepareComponentsAsync_003Ed__28, byte>(ref this);
								if (8 == 0)
								{
									reference = ref *(byte*)8;
								}
								continue;
							case 76u:
								_ = 67;
								continue;
							case 28u:
								_ = null;
								_ = 9;
								continue;
							case 35u:
								_ = 50;
								continue;
							case 40u:
								goto IL_04c9;
							case 34u:
								_ = 48;
								continue;
							case 44u:
							case 72u:
								_ = 79;
								continue;
							case 10u:
							{
								object obj4 = obj;
								obj = obj;
								reference = ref *(byte*)obj4;
								if (2 != 0)
								{
									reference = ref *(byte*)2;
								}
								continue;
							}
							case 49u:
								obj = 0;
								reference = ref *(byte*)68;
								continue;
							case 12u:
								obj = 1;
								_ = 14;
								continue;
							case 62u:
								obj = 3;
								_ = 6;
								continue;
							case 9u:
								obj = obj;
								_ = 37;
								continue;
							case 14u:
								_ = 32;
								continue;
							case 77u:
								goto IL_05ab;
							case 51u:
								obj = 2;
								_ = 41;
								continue;
							case 69u:
								reference = ref Unsafe.As<_003CPrepareComponentsAsync_003Ed__28, byte>(ref this);
								if (82 == 0)
								{
									reference = ref *(byte*)64;
								}
								continue;
							case 48u:
							case 79u:
								reference = ref *(byte*)obj;
								if (63 == 0)
								{
									reference = ref *(byte*)73;
								}
								continue;
							case 26u:
								obj3 = obj;
								goto IL_0caf;
							case 78u:
								if ((nint)obj != 4)
								{
									if (3 == 0)
									{
										_ = 2;
									}
									goto IL_063d;
								}
								goto IL_095c;
							case 13u:
							case 55u:
							case 71u:
								obj++;
								if (17 == 0)
								{
									reference = ref *(byte*)24;
								}
								continue;
							case 1u:
								if (Unsafe.AsPointer(ref this) == null)
								{
									goto end_IL_005d;
								}
								obj = 36;
								continue;
							case 42u:
								if (16 != 0)
								{
									_ = 13;
								}
								continue;
							case 22u:
								_ = ref obj;
								_ = 15;
								continue;
							case 6u:
								_ = 22;
								continue;
							case 8u:
								_ = 21;
								continue;
							case 37u:
								if (&obj == null)
								{
									reference = ref *(byte*)12;
									continue;
								}
								goto case 17u;
							case 81u:
								obj = obj;
								if (80 != 0)
								{
									_ = 80;
								}
								continue;
							case 20u:
								_ = 7;
								continue;
							case 25u:
							case 27u:
								reference = ref *(byte*)(&obj);
								if (16 == 0)
								{
									reference = ref *(byte*)52;
								}
								continue;
							case 53u:
								obj = 0;
								if (47 == 0)
								{
									_ = 13;
								}
								continue;
							case 16u:
								obj = obj;
								_ = 11;
								continue;
							case 11u:
								if (&obj != null)
								{
									reference = ref *(byte*)31;
									continue;
								}
								goto case 53u;
							case 29u:
								obj = -1;
								obj = 18;
								continue;
							case 50u:
								obj = -1;
								_ = 27;
								continue;
							case 80u:
								_ = 57;
								continue;
							case 56u:
								obj = -1;
								if (17 == 0)
								{
									_ = 7;
								}
								continue;
							case 24u:
							case 68u:
								if ((nint)obj < ((Array)obj).Length)
								{
									reference = ref *(byte*)75;
									continue;
								}
								goto case 1u;
							case 70u:
							case 75u:
								obj = ((object[])obj)[obj];
								if (10 == 0)
								{
									reference = ref *(byte*)5;
								}
								continue;
							case 32u:
								_ = ref obj;
								_ = 46;
								continue;
							default:
								if (&obj != null)
								{
									if (33 == 0)
									{
										reference = ref *(byte*)60;
									}
									continue;
								}
								goto case 62u;
							case 64u:
								reference = ref *(byte*)obj;
								if (13 == 0)
								{
									reference = ref *(byte*)6;
								}
								continue;
							case 36u:
							case 43u:
								_ = 1;
								_ = 5;
								_ = 0;
								_ = 38;
								continue;
							case 4u:
								_ = ref obj;
								if (5 != 0)
								{
									_ = 3;
								}
								continue;
							case 63u:
								reference = ref Unsafe.As<_003CPrepareComponentsAsync_003Ed__28, byte>(ref this);
								if (29 != 0)
								{
									reference = ref *(byte*)3;
								}
								continue;
							case 38u:
							{
								ref _003CPrepareComponentsAsync_003Ed__28 reference3 = ref this;
								if (Unsafe.AsPointer(ref reference3) == null)
								{
									reference3 = ref *(_003CPrepareComponentsAsync_003Ed__28*)/*Error near IL_0ccb: Stack underflow*/;
								}
								obj = (object)Unsafe.AsPointer(ref this);
								obj = 65;
								continue;
							}
							case 52u:
							{
								ref _003CPrepareComponentsAsync_003Ed__28 reference2 = ref this;
								if (Unsafe.AsPointer(ref reference2) == null)
								{
									reference2 = ref *(_003CPrepareComponentsAsync_003Ed__28*)/*Error near IL_0cfd: Stack underflow*/;
								}
								obj = (object)Unsafe.AsPointer(ref this);
								if (false)
								{
									_ = 0;
								}
								continue;
							}
							case 58u:
							case 82u:
								goto end_IL_005d;
								IL_0caf:
								if (obj3 != null)
								{
									reference = ref *(byte*)3;
									continue;
								}
								goto case 48u;
								IL_095c:
								obj = (object)Unsafe.AsPointer(ref this);
								obj = 35;
								goto IL_063d;
								IL_063d:
								while (true)
								{
									switch ((int)/*Error near IL_06de: Stack underflow*/)
									{
									case 9:
										break;
									case 31:
										_ = ref obj;
										if (36 == 0)
										{
											_ = 2;
										}
										continue;
									case 24:
										_ = 26;
										continue;
									case 19:
										if (Unsafe.AsPointer(ref this) == null)
										{
											_ = 4;
											continue;
										}
										goto case 11;
									case 34:
										obj = 4;
										obj = 14;
										continue;
									case 15:
									case 37:
										_ = ref obj;
										if (4 == 0)
										{
											_ = 24;
										}
										continue;
									case 29:
										_ = 12;
										continue;
									case 32:
										obj = (object)Unsafe.AsPointer(ref this);
										_ = 2;
										continue;
									case 6:
										_ = 28;
										continue;
									case 4:
									case 38:
										obj = 1;
										_ = 5;
										continue;
									case 2:
										if (&obj != null)
										{
											_ = 15;
											continue;
										}
										goto case 34;
									case 8:
										_ = 23;
										continue;
									case 35:
										obj = 7;
										continue;
									case 11:
										obj = (object)Unsafe.AsPointer(ref this);
										obj = 27;
										continue;
									case 27:
										if (obj == null)
										{
											_ = 29;
											continue;
										}
										goto case 33;
									case 25:
										_ = 19;
										continue;
									case 26:
										_ = null;
										obj = 16;
										continue;
									case 5:
										if (((Array)obj).Length != 0)
										{
											_ = 20;
											continue;
										}
										goto case 8;
									case 10:
									case 20:
										obj = obj;
										obj = 13;
										continue;
									case 3:
									case 12:
									case 16:
									case 21:
										if (Unsafe.AsPointer(ref this) == null)
										{
											if (0 == 0)
											{
												_ = 9;
											}
											continue;
										}
										goto default;
									case 33:
										if (14 != 0)
										{
											_ = 22;
										}
										continue;
									default:
										_ = 25;
										continue;
									case 17:
									case 30:
										_ = 6;
										continue;
									case 14:
										if (31 != 0)
										{
											_ = 9;
										}
										continue;
									case 1:
										goto IL_095c;
									case 13:
										if (((Array)obj).Length <= 1)
										{
											_ = 30;
											continue;
										}
										goto case 18;
									case 18:
										_ = 17;
										continue;
									case 7:
										obj = -1;
										obj = 37;
										continue;
									case 36:
										return;
									case 22:
									case 28:
										if (32 == 0)
										{
											_ = 31;
										}
										continue;
									case 23:
										_ = 21;
										continue;
									}
									break;
								}
								goto case 69u;
							}
							break;
						}
						goto case 2;
						IL_05ab:
						obj = (object)Unsafe.AsPointer(ref this);
						if (19 == 0)
						{
							reference = ref *(byte*)2;
						}
						goto IL_0091;
						IL_04c9:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(byte*)54;
						goto IL_0091;
						IL_03ca:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(byte*)63;
						goto IL_0091;
						end_IL_005d:
						break;
					}
					break;
				}
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					if (true)
					{
						obj2 = 2;
					}
					continue;
				case 5:
					_ = null;
					if (0 == 0)
					{
						_ = 1;
					}
					continue;
				case 4:
					return;
				case 1:
					_ = 4;
					continue;
				case 6:
					break;
				}
				_ = -2;
				_ = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _0900()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778647, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _0A00()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPrepareJreAsync_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		public CancellationToken cancellationToken;

		private TaskAwaiter _003C_003Eu__1;

		internal static object StoreDic;

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
		internal static bool ReflectRandomChain()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckCustomEnumerator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F500(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778646, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F600(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F700()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778645, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00豈()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0048: Expected Obj, but got I4
			//IL_03b6: Expected Obj, but got Ref
			//IL_0137: Expected Obj, but got Ref
			//IL_010a: Expected Obj, but got Ref
			//IL_02c4: Expected Obj, but got I4
			//IL_0232: Expected Obj, but got I4
			//IL_02f2: Expected Obj, but got Ref
			//IL_0222: Expected Obj, but got I4
			//IL_00f3: Expected Obj, but got I4
			//IL_031c: Expected Obj, but got Ref
			//IL_0195: Expected Obj, but got I4
			//IL_01fd: Expected Obj, but got I4
			//IL_01be: Expected Obj, but got I4
			//IL_03e8->IL0019: Incompatible stack heights: 2 vs 1
			//IL_03d0->IL0019: Incompatible stack heights: 2 vs 1
			//IL_03c0->IL0019: Incompatible stack types: I4 vs Obj
			//IL_03db->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0141->IL0070: Incompatible stack types: I4 vs Ref
			//IL_0061->IL0070: Incompatible stack heights: 0 vs 1
			//IL_006c->IL0070: Incompatible stack types: I4 vs Ref
			//IL_025c->IL0070: Incompatible stack heights: 3 vs 1
			//IL_0114->IL0070: Incompatible stack heights: 4 vs 1
			//IL_02d1->IL0070: Incompatible stack heights: 2 vs 1
			//IL_023d->IL0070: Incompatible stack heights: 3 vs 1
			//IL_0286->IL0070: Incompatible stack heights: 4 vs 1
			//IL_024a->IL0070: Incompatible stack heights: 2 vs 1
			//IL_02fc->IL0070: Incompatible stack heights: 5 vs 1
			//IL_022d->IL0070: Incompatible stack heights: 3 vs 1
			//IL_0212->IL0070: Incompatible stack heights: 2 vs 1
			//IL_0326->IL0070: Incompatible stack types: I4 vs Ref
			//IL_0174->IL0070: Incompatible stack heights: 5 vs 1
			//IL_01a2->IL0070: Incompatible stack heights: 2 vs 1
			//IL_01d0->IL0070: Incompatible stack heights: 2 vs 1
			//IL_0202->IL006c: Incompatible stack heights: 1 vs 2
			//IL_0185->IL0070: Incompatible stack types: Obj vs Ref
			//IL_0267->IL0070: Incompatible stack heights: 3 vs 1
			//IL_02dc->IL0070: Incompatible stack heights: 2 vs 1
			//IL_01e6->IL0070: Incompatible stack heights: 0 vs 1
			//IL_0128->IL0070: Incompatible stack heights: 0 vs 1
			//IL_02a0->IL0070: Incompatible stack types: I4 vs Ref
			//IL_02b4->IL0070: Incompatible stack heights: 0 vs 1
			//IL_0070->IL0070: Incompatible stack heights: 3 vs 1
			//IL_021d->IL0070: Incompatible stack heights: 2 vs 1
			//IL_01ad->IL0070: Incompatible stack heights: 2 vs 1
			//IL_01c3->IL006c: Incompatible stack heights: 0 vs 2
			//IL_0190->IL0070: Incompatible stack types: I4 vs Ref
			//IL_01f1->IL0070: Incompatible stack types: I4 vs Ref
			//IL_0133->IL0070: Incompatible stack types: I4 vs Ref
			//IL_02bf->IL0070: Incompatible stack types: I4 vs Ref
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
					case 3:
						break;
					case 5:
						if (obj != null)
						{
							if (6 == 0)
							{
								reference = ref *(object*)23;
							}
							goto IL_0070;
						}
						goto IL_0133;
					case 2:
						return;
					case 4:
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 3;
						continue;
					case 1:
						goto IL_03c0;
					default:
						{
							_ = 2;
							continue;
						}
						IL_0070:
						while (true)
						{
							switch ((uint)Unsafe.AsPointer(ref reference))
							{
							case 16u:
								obj = 4;
								continue;
							case 1u:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 15;
								continue;
							case 10u:
								if (&obj == null)
								{
									if (14 == 0)
									{
										reference = ref *(object*)9;
									}
									continue;
								}
								goto case 13u;
							case 9u:
								break;
							case 20u:
								return;
							case 21u:
								_ = 1;
								_ = 1;
								_ = 0;
								_ = 12;
								continue;
							case 26u:
								reference = ref *(object*)obj;
								if (3 == 0)
								{
									reference = ref *(object*)6;
								}
								continue;
							case 22u:
								obj = -1;
								if (4 == 0)
								{
									_ = 7;
								}
								continue;
							case 23u:
								if ((nint)obj != 1)
								{
									obj = 5;
									continue;
								}
								goto case 18u;
							case 24u:
								_ = 3;
								continue;
							case 5u:
								if (obj != null)
								{
									if (19 == 0)
									{
										reference = ref *(object*)10;
									}
									continue;
								}
								goto case 21u;
							case 25u:
								obj = 22;
								continue;
							case 17u:
								if (false)
								{
									_ = 0;
								}
								continue;
							case 14u:
								obj = 0;
								_ = 16;
								continue;
							case 3u:
								obj = -1;
								_ = 13;
								continue;
							case 7u:
							case 8u:
								_ = ref obj;
								_ = 26;
								continue;
							default:
								_ = ref obj;
								if (15 == 0)
								{
									_ = 20;
								}
								continue;
							case 4u:
								_ = ref obj;
								_ = 11;
								continue;
							case 13u:
								reference = ref obj;
								if (1 == 0)
								{
									reference = ref *(object*)1;
								}
								continue;
							case 15u:
								if (&obj != null)
								{
									if (3 != 0)
									{
										reference = ref *(object*)8;
									}
									continue;
								}
								goto case 2u;
							case 2u:
								obj = 1;
								if (17 == 0)
								{
									_ = 6;
								}
								continue;
							case 12u:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 10;
								continue;
							case 11u:
								return;
							case 18u:
								obj = (object)Unsafe.AsPointer(ref this);
								reference = ref *(object*)25;
								continue;
							case 6u:
							case 19u:
								goto IL_03c0;
							}
							break;
						}
						goto IL_0133;
						IL_03c0:
						_ = -2;
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
						IL_0133:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(object*)24;
						goto IL_0070;
					}
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
				obj = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00切()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778644, new IntPtr(2737337594924L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00ﬀ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00ﰀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778643, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPreparePackageAsync_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		public JavaStep step;

		public string md5Path;

		public string md5;

		public Action before;

		public string name;

		public string url;

		public CancellationToken cancellationToken;

		public string outputPath;

		private object _003C_003E8__1;

		public Action after;

		private object _003CzipPath_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		internal static object EncodeArgument;

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
		internal static bool ExcludeSummarizer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckMixedProfiler()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_EB00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778642, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_EC00(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_ED00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778641, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_EE00()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_EF00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778640, new IntPtr(2737337577244L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F200()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_003e: Expected I4, but got Obj
			//IL_0057: Expected I4, but got Obj
			//IL_062b: Expected Obj, but got Ref
			//IL_05db: Expected Obj, but got Ref
			//IL_0237: Expected Obj, but got Ref
			//IL_021c: Expected Obj, but got Ref
			//IL_0252: Expected Obj, but got Ref
			//IL_03ff: Expected Obj, but got Ref
			//IL_026b: Expected Obj, but got I4
			//IL_047b: Expected Obj, but got I4
			//IL_01cd: Expected Obj, but got I4
			//IL_0158: Expected Obj, but got I4
			//IL_034e: Expected Obj, but got I4
			//IL_0209: Expected Obj, but got I4
			//IL_0213: Expected Obj, but got I4
			//IL_0309: Expected Obj, but got Ref
			//IL_042e: Expected Obj, but got I4
			//IL_0133: Expected Obj, but got I4
			//IL_03c3: Expected Obj, but got Ref
			//IL_01ff: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_05f2->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0601->IL0019: Incompatible stack heights: 2 vs 1
			//IL_061c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0637->IL0019: Incompatible stack heights: 0 vs 1
			//IL_05e5->IL0019: Incompatible stack types: I4 vs Ref
			//IL_025c->IL0065: Incompatible stack heights: 1 vs 0
			//IL_0061->IL0065: Incompatible stack heights: 1 vs 0
			//IL_060c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0627->IL0019: Incompatible stack heights: 2 vs 1
			//IL_05d7->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0642->IL0019: Incompatible stack types: I4 vs Ref
			//IL_024e->IL0065: Incompatible stack heights: 1 vs 0
			//IL_0233->IL0065: Incompatible stack heights: 1 vs 0
			//IL_0409->IL0065: Incompatible stack heights: 5 vs 0
			//IL_0486->IL0065: Incompatible stack heights: 3 vs 0
			//IL_01c8->IL0065: Incompatible stack heights: 4 vs 0
			//IL_0199->IL0065: Incompatible stack heights: 2 vs 0
			//IL_02df->IL0065: Incompatible stack heights: 3 vs 0
			//IL_0148->IL0065: Incompatible stack heights: 2 vs 0
			//IL_02b6->IL0065: Incompatible stack heights: 2 vs 0
			//IL_033e->IL0065: Incompatible stack heights: 1 vs 0
			//IL_01a6->IL0065: Incompatible stack heights: 2 vs 0
			//IL_01d8->IL0065: Incompatible stack heights: 3 vs 0
			//IL_0165->IL0065: Incompatible stack heights: 2 vs 0
			//IL_035b->IL0065: Incompatible stack heights: 2 vs 0
			//IL_0448->IL0065: Incompatible stack heights: 1 vs 0
			//IL_0280->IL0065: Incompatible stack heights: 2 vs 0
			//IL_041e->IL0065: Incompatible stack heights: 3 vs 0
			//IL_0218->IL0061: Incompatible stack heights: 2 vs 3
			//IL_0313->IL0065: Incompatible stack heights: 4 vs 0
			//IL_04c2->IL0065: Incompatible stack heights: 3 vs 0
			//IL_0464->IL0065: Incompatible stack heights: 3 vs 0
			//IL_01eb->IL0065: Incompatible stack heights: 5 vs 0
			//IL_0390->IL0065: Incompatible stack heights: 2 vs 0
			//IL_01f6->IL0170: Incompatible stack heights: 1 vs 0
			//IL_03bb->IL0065: Incompatible stack heights: 3 vs 0
			//IL_02ce->IL0065: Incompatible stack heights: 2 vs 0
			//IL_0439->IL0065: Incompatible stack heights: 3 vs 0
			//IL_0378->IL0065: Incompatible stack heights: 3 vs 0
			//IL_0138->IL0061: Incompatible stack heights: 1 vs 3
			//IL_029a->IL0065: Incompatible stack heights: 1 vs 0
			//IL_03cf->IL0065: Incompatible stack heights: 1 vs 0
			//IL_0065->IL0065: Incompatible stack heights: 4 vs 0
			//IL_0514->IL0065: Incompatible stack heights: 2 vs 0
			//IL_03ed->IL0065: Incompatible stack heights: 1 vs 0
			//IL_0153->IL0065: Incompatible stack heights: 2 vs 0
			//IL_02c1->IL0065: Incompatible stack heights: 2 vs 0
			//IL_0349->IL0065: Incompatible stack heights: 1 vs 0
			//IL_0170->IL0065: Incompatible stack heights: 2 vs 0
			//IL_0366->IL0065: Incompatible stack heights: 2 vs 0
			//IL_0453->IL0065: Incompatible stack heights: 1 vs 0
			//IL_01b8->IL0065: Incompatible stack heights: 1 vs 0
			//IL_028b->IL0065: Incompatible stack heights: 2 vs 0
			//IL_0429->IL0065: Incompatible stack heights: 3 vs 0
			//IL_0476->IL0065: Incompatible stack heights: 1 vs 0
			//IL_0204->IL0061: Incompatible stack heights: 1 vs 3
			//IL_0383->IL0065: Incompatible stack heights: 3 vs 0
			//IL_02a5->IL0065: Incompatible stack heights: 1 vs 0
			//IL_03da->IL0065: Incompatible stack heights: 1 vs 0
			//IL_04b4->IL0065: Incompatible stack heights: 1 vs 0
			//IL_04e7->IL0065: Incompatible stack heights: 1 vs 0
			//IL_04f9->IL0065: Incompatible stack heights: 1 vs 0
			//IL_0504->IL0065: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 7;
			ref _003CPreparePackageAsync_003Ed__45 reference = ref *(_003CPreparePackageAsync_003Ed__45*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 1u:
					switch ((int)obj)
					{
					default:
						_ = 7;
						goto IL_0065;
					case 1:
						obj = (object)Unsafe.AsPointer(ref this);
						if (42 == 0)
						{
							_ = 33;
						}
						goto IL_0065;
					case 0:
						goto IL_0233;
					case 2:
						goto IL_024e;
						IL_0065:
						while (true)
						{
							switch ((int)/*Error near IL_0122: Stack underflow*/)
							{
							case 42:
								obj = 15;
								continue;
							case 9:
								if (2 == 0)
								{
									_ = 2;
								}
								continue;
							case 15:
								obj = -1;
								if (17 == 0)
								{
									_ = 14;
								}
								continue;
							case 7:
								_ = 10;
								continue;
							case 13:
								_ = 40;
								continue;
							case 18:
								if (&obj == null)
								{
									_ = 3;
									continue;
								}
								goto case 43;
							case 5:
								_ = ref obj;
								_ = 4;
								continue;
							case 14:
								obj = -1;
								_ = 11;
								continue;
							case 33:
							case 39:
								_ = 1;
								_ = 0;
								_ = 23;
								continue;
							case 36:
								if (Unsafe.AsPointer(ref this) != null)
								{
									goto end_IL_0046;
								}
								obj = 26;
								continue;
							case 24:
								obj = 1;
								obj = 21;
								continue;
							case 22:
								break;
							case 25:
								goto IL_0233;
							case 31:
								goto IL_024e;
							case 2:
								_ = ref obj;
								obj = 12;
								continue;
							case 21:
								if (true)
								{
									_ = 5;
								}
								continue;
							case 43:
								_ = ref obj;
								if (27 == 0)
								{
									_ = 15;
								}
								continue;
							case 10:
								if (15 == 0)
								{
									_ = 37;
								}
								continue;
							case 38:
								_ = 14;
								continue;
							case 8:
							case 26:
								_ = 34;
								continue;
							case 27:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 30;
								continue;
							case 4:
								return;
							case 11:
								_ = ref obj;
								if (0 == 0)
								{
									_ = 1;
								}
								continue;
							case 16:
								obj = 2;
								if (6 != 0)
								{
									_ = 9;
								}
								continue;
							case 41:
								_ = ref obj;
								if (3 != 0)
								{
									_ = 20;
								}
								continue;
							case 35:
								_ = 6;
								continue;
							case 12:
								return;
							case 37:
								_ = 36;
								continue;
							case 44:
								obj = (object)Unsafe.AsPointer(ref this);
								if (29 != 0)
								{
									_ = 3;
								}
								continue;
							case 6:
								goto IL_03da;
							default:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 18;
								continue;
							case 23:
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							case 40:
								obj = -1;
								_ = 43;
								continue;
							case 17:
								_ = ref obj;
								if (35 != 0)
								{
									_ = 20;
								}
								continue;
							case 19:
							case 32:
								_ = 44;
								continue;
							case 29:
								if (&obj == null)
								{
									_ = 16;
									continue;
								}
								goto case 11;
							case 3:
								obj = 0;
								_ = 28;
								continue;
							case 20:
								return;
							case 30:
								if (&obj == null)
								{
									if (24 != 0)
									{
										_ = 4;
									}
									continue;
								}
								goto case 17;
							case 28:
								_ = 41;
								continue;
							case 34:
								goto IL_04c2;
							case 1:
							case 45:
								goto end_IL_0046;
							}
							break;
							IL_04c2:
							if (Unsafe.AsPointer(ref this) == null)
							{
								if (39 != 0)
								{
									_ = 16;
								}
							}
							else if (19 == 0)
							{
								_ = 33;
							}
							continue;
							IL_03da:
							if (Unsafe.AsPointer(ref this) == null)
							{
								_ = 19;
							}
							else
							{
								_ = 32;
							}
						}
						goto case 1;
						IL_024e:
						obj = (object)Unsafe.AsPointer(ref this);
						_ = 38;
						goto IL_0065;
						IL_0233:
						obj = (object)Unsafe.AsPointer(ref this);
						if (7 == 0)
						{
							_ = 13;
						}
						goto IL_0065;
						end_IL_0046:
						break;
					}
					goto case 3u;
				case 5u:
					return;
				case 4u:
					reference = ref this;
					if (5 == 0)
					{
						reference = ref *(_003CPreparePackageAsync_003Ed__45*)3;
					}
					break;
				case 7u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CPreparePackageAsync_003Ed__45*)6;
					break;
				default:
					_ = null;
					_ = 2;
					break;
				case 2u:
					_ = null;
					if (4 != 0)
					{
						_ = 0;
					}
					break;
				case 3u:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				case 6u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						reference = ref *(_003CPreparePackageAsync_003Ed__45*)1;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F300()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F400()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778639, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPrepareServerResourceAsync_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		public CancellationToken cancellationToken;

		private TaskAwaiter<EntityItemDownload> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		internal static object DecorateFlexibleFactory;

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
		internal static bool PresentAuditor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectCommonResponder()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E300(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778638, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E400(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E500()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E600()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778637, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778636, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E800()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0377: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_0218: Expected Obj, but got Ref
			//IL_01c0: Expected Obj, but got I4
			//IL_026f: Expected Obj, but got I4
			//IL_0209: Expected Obj, but got I4
			//IL_0233: Expected Obj, but got Ref
			//IL_027f: Expected Obj, but got I4
			//IL_0289: Expected Obj, but got I4
			//IL_029a: Expected Obj, but got I4
			//IL_0250: Expected Obj, but got Ref
			//IL_0175: Expected Obj, but got I4
			//IL_0383->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_039b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0367->IL0019: Incompatible stack heights: 2 vs 1
			//IL_038e->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0068->IL006c: Incompatible stack heights: 1 vs 0
			//IL_0372->IL0019: Incompatible stack heights: 2 vs 1
			//IL_022f->IL006c: Incompatible stack heights: 1 vs 0
			//IL_011a->IL006c: Incompatible stack heights: 2 vs 0
			//IL_024b->IL006c: Incompatible stack heights: 3 vs 0
			//IL_01f9->IL006c: Incompatible stack heights: 9 vs 0
			//IL_01b0->IL006c: Incompatible stack heights: 1 vs 0
			//IL_01cb->IL006c: Incompatible stack heights: 3 vs 0
			//IL_02af->IL006c: Incompatible stack heights: 1 vs 0
			//IL_027a->IL006c: Incompatible stack heights: 3 vs 0
			//IL_026a->IL006c: Incompatible stack heights: 4 vs 0
			//IL_018a->IL006c: Incompatible stack heights: 4 vs 0
			//IL_0164->IL006c: Incompatible stack heights: 6 vs 0
			//IL_0214->IL006c: Incompatible stack heights: 3 vs 0
			//IL_023d->IL006c: Incompatible stack heights: 1 vs 0
			//IL_02cb->IL006c: Incompatible stack heights: 2 vs 0
			//IL_02d9->IL006c: Incompatible stack heights: 3 vs 0
			//IL_029f->IL0068: Incompatible stack heights: 1 vs 2
			//IL_025a->IL006c: Incompatible stack heights: 1 vs 0
			//IL_014b->IL006c: Incompatible stack heights: 1 vs 0
			//IL_0204->IL006c: Incompatible stack heights: 9 vs 0
			//IL_01bb->IL006c: Incompatible stack heights: 1 vs 0
			//IL_010d->IL006c: Incompatible stack heights: 1 vs 0
			//IL_006c->IL006c: Incompatible stack heights: 3 vs 0
			//IL_017a->IL0068: Incompatible stack heights: 0 vs 2
			//IL_0139->IL006c: Incompatible stack heights: 1 vs 0
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
				case 2:
					if (obj != null)
					{
						_ = 19;
						goto IL_006c;
					}
					goto IL_0214;
				case 5:
					goto IL_0357;
				case 4:
					return;
				default:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						obj2 = 2;
					}
					break;
				case 3:
					{
						_ = 4;
						break;
					}
					IL_006c:
					while (true)
					{
						switch ((int)/*Error near IL_00d9: Stack underflow*/)
						{
						case 11:
							if ((nint)obj != 2)
							{
								_ = 16;
								continue;
							}
							goto case 5;
						default:
							_ = 14;
							continue;
						case 8:
							if (&obj == null)
							{
								if (9 == 0)
								{
									_ = 3;
								}
								continue;
							}
							goto case 23;
						case 1:
							if (&obj == null)
							{
								_ = 6;
								continue;
							}
							goto case 25;
						case 13:
							_ = 4;
							continue;
						case 19:
							if ((nint)obj != 1)
							{
								obj = 11;
								continue;
							}
							goto case 15;
						case 12:
							_ = ref obj;
							_ = 21;
							continue;
						case 3:
							return;
						case 5:
							obj = obj;
							if (1 == 0)
							{
								_ = 0;
							}
							continue;
						case 6:
							obj = 0;
							_ = 22;
							continue;
						case 4:
							_ = 6;
							obj = obj;
							if (8 != 0)
							{
								_ = 6;
							}
							continue;
						case 14:
							obj = -1;
							_ = 25;
							continue;
						case 18:
							break;
						case 15:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 20;
							continue;
						case 2:
							_ = 12;
							continue;
						case 25:
							obj = (object)(&obj);
							_ = 7;
							continue;
						case 10:
							_ = ref obj;
							_ = 3;
							continue;
						case 9:
							obj = 1;
							_ = 2;
							continue;
						case 17:
							obj = -1;
							obj = 23;
							continue;
						case 23:
							_ = ref obj;
							obj = 24;
							continue;
						case 7:
							obj = obj;
							_ = 13;
							continue;
						case 21:
							return;
						case 20:
							_ = 17;
							continue;
						case 22:
							_ = 10;
							continue;
						case 16:
						case 24:
							goto IL_0357;
						}
						break;
					}
					goto IL_0214;
					IL_0357:
					_ = -2;
					if (3 == 0)
					{
						_ = 2;
					}
					break;
					IL_0214:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						_ = 0;
					}
					goto IL_006c;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E900()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778635, new IntPtr(2737337584524L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_EA00()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPrepareVersionAsync_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		public CancellationToken cancellationToken;

		private object _003Cpatch_003E5__2;

		private TaskAwaiter<EntityGameClientPatch> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private static object DecorateAdaptableStream;

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
		internal static bool DecoratePortableEncryptor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ArrangeContext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778634, new IntPtr(2737337578284L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object P_0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778633, new IntPtr(2737337584524L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778632, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E000()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_00b2: Expected I4, but got Obj
			//IL_0051: Expected Obj, but got Ref
			//IL_005f: Expected Obj, but got Ref
			//IL_040a: Expected Obj, but got Ref
			//IL_0152: Expected Obj, but got Ref
			//IL_02b1: Expected Obj, but got Ref
			//IL_02e7: Expected Obj, but got Ref
			//IL_01ef: Expected Obj, but got I4
			//IL_025a: Expected Obj, but got I4
			//IL_0285: Expected Obj, but got I4
			//IL_021d: Expected Obj, but got I4
			//IL_0227: Expected Obj, but got I4
			//IL_03b3: Expected Obj, but got I4
			//IL_0295: Expected Obj, but got I4
			//IL_0206: Expected Obj, but got I4
			//IL_004d->IL0019: Incompatible stack heights: 3 vs 1
			//IL_009e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0085->IL0019: Incompatible stack heights: 2 vs 1
			//IL_005b->IL0019: Incompatible stack types: I4 vs Obj
			//IL_006b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0414->IL00c0: Incompatible stack types: I4 vs Ref
			//IL_015e->IL00c0: Incompatible stack heights: 0 vs 1
			//IL_02bd->IL00c0: Incompatible stack heights: 0 vs 1
			//IL_00bc->IL00c0: Incompatible stack types: I4 vs Ref
			//IL_0090->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0076->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0169->IL00c0: Incompatible stack types: I4 vs Ref
			//IL_02c8->IL00c0: Incompatible stack types: I4 vs Ref
			//IL_01b3->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_0218->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_02f3->IL00c0: Incompatible stack heights: 0 vs 1
			//IL_0280->IL00c0: Incompatible stack heights: 3 vs 1
			//IL_01fa->IL00c0: Incompatible stack heights: 3 vs 1
			//IL_0267->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_0290->IL00c0: Incompatible stack heights: 3 vs 1
			//IL_03c0->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_02a2->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_03f6->IL00c0: Incompatible stack heights: 10 vs 1
			//IL_0406->IL00c0: Incompatible stack heights: 4 vs 1
			//IL_01c3->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_020b->IL00bc: Incompatible stack heights: 1 vs 2
			//IL_01a6->IL00c0: Incompatible stack heights: 10 vs 1
			//IL_035e->IL00c0: Incompatible stack heights: 3 vs 1
			//IL_017d->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_0379->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_0255->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_0310->IL00c0: Incompatible stack heights: 3 vs 1
			//IL_0394->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_02fe->IL00c0: Incompatible stack types: I4 vs Ref
			//IL_0272->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_00c0->IL00c0: Incompatible stack heights: 3 vs 1
			//IL_03cb->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_02e2->IL00c0: Incompatible stack types: I4 vs Ref
			//IL_02ad->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_01ce->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_0341->IL00c0: Incompatible stack heights: 0 vs 1
			//IL_032d->IL00c0: Incompatible stack types: I4 vs Ref
			//IL_0369->IL00c0: Incompatible stack heights: 3 vs 1
			//IL_0384->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_031b->IL00c0: Incompatible stack heights: 3 vs 1
			//IL_0437->IL00c0: Incompatible stack heights: 0 vs 1
			//IL_039f->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_034c->IL00c0: Incompatible stack types: I4 vs Ref
			//IL_0442->IL00c0: Incompatible stack types: I4 vs Ref
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
					_ = -2;
					_ = 4;
					break;
				case 5:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 3;
					break;
				case 6:
					obj = (object)Unsafe.AsPointer(ref this);
					if (5 != 0)
					{
						obj2 = 1;
					}
					break;
				case 4:
					_ = null;
					if (0 == 0)
					{
						_ = 1;
					}
					break;
				case 2:
					return;
				case 1:
					_ = 2;
					break;
				case 3:
				{
					ref _003CPrepareVersionAsync_003Ed__44 reference;
					switch ((int)obj)
					{
					default:
						reference = ref *(_003CPrepareVersionAsync_003Ed__44*)24;
						goto IL_00c0;
					case 1:
						obj = (object)Unsafe.AsPointer(ref this);
						if (10 != 0)
						{
							reference = ref *(_003CPrepareVersionAsync_003Ed__44*)10;
						}
						goto IL_00c0;
					case 2:
						goto IL_02ad;
					case 0:
						goto IL_0406;
						IL_00c0:
						while (true)
						{
							switch ((uint)Unsafe.AsPointer(ref reference))
							{
							case 30u:
								break;
							case 7u:
								return;
							case 19u:
								return;
							case 23u:
								return;
							case 15u:
								goto end_IL_00c0;
							case 24u:
								obj = obj;
								_ = 29;
								continue;
							case 21u:
								_ = 3;
								_ = null;
								obj = obj;
								_ = 20;
								continue;
							default:
								_ = 5;
								continue;
							case 14u:
								if (13 == 0)
								{
									_ = 9;
								}
								continue;
							case 4u:
								obj = -1;
								_ = 26;
								continue;
							case 17u:
								obj = 6;
								continue;
							case 1u:
							case 32u:
								_ = ref obj;
								_ = 30;
								continue;
							case 8u:
								obj = 2;
								obj = 25;
								continue;
							case 26u:
								_ = ref obj;
								_ = 12;
								continue;
							case 5u:
								obj = -1;
								if (0 == 0)
								{
									_ = 1;
								}
								continue;
							case 3u:
								_ = 27;
								continue;
							case 6u:
								obj = -1;
								_ = 2;
								continue;
							case 11u:
								obj = 0;
								if (2 == 0)
								{
									_ = 3;
								}
								continue;
							case 16u:
								goto IL_02ad;
							case 10u:
								reference = ref this;
								if (4 == 0)
								{
									reference = ref *(_003CPrepareVersionAsync_003Ed__44*)4;
								}
								continue;
							case 2u:
								obj = (object)(&obj);
								if (18 == 0)
								{
									reference = ref *(_003CPrepareVersionAsync_003Ed__44*)31;
								}
								continue;
							case 27u:
								_ = ref obj;
								if (19 != 0)
								{
									_ = 1;
								}
								continue;
							case 20u:
								if (&obj == null)
								{
									reference = ref *(_003CPrepareVersionAsync_003Ed__44*)9;
									continue;
								}
								goto case 26u;
							case 18u:
								if (&obj != null)
								{
									if (32 != 0)
									{
										reference = ref *(_003CPrepareVersionAsync_003Ed__44*)17;
									}
									continue;
								}
								goto case 8u;
							case 22u:
								_ = ref obj;
								if (23 != 0)
								{
									_ = 23;
								}
								continue;
							case 25u:
								if (22 != 0)
								{
									_ = 15;
								}
								continue;
							case 31u:
								if (17 == 0)
								{
									_ = 21;
								}
								continue;
							case 9u:
								obj = 1;
								if (4 == 0)
								{
									_ = 14;
								}
								continue;
							case 12u:
								_ = 4;
								_ = null;
								obj = obj;
								_ = 18;
								continue;
							case 13u:
								_ = ref obj;
								_ = 7;
								continue;
							case 28u:
								goto IL_0406;
							case 29u:
								if (&obj == null)
								{
									if (11 == 0)
									{
										reference = ref *(_003CPrepareVersionAsync_003Ed__44*)1;
									}
									continue;
								}
								goto case 2u;
							}
							goto end_IL_00a1;
							continue;
							end_IL_00c0:
							break;
						}
						goto case 1;
						IL_0406:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(_003CPrepareVersionAsync_003Ed__44*)17;
						goto IL_00c0;
						IL_02ad:
						obj = (object)Unsafe.AsPointer(ref this);
						if (false)
						{
							reference = ref *(_003CPrepareVersionAsync_003Ed__44*)null;
						}
						goto IL_00c0;
						end_IL_00a1:
						break;
					}
					goto default;
				}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E100()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778631, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E200()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStartGameAsync_003Ed__137 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		public CancellationToken token;

		private nint _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		private static object SaveMapper;

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
		internal static bool CheckRemoteAllocator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectActiveQueue()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00턀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778630, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00툀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00팀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778629, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00퐀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00픀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778628, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00혀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0078: Expected I4, but got Obj
			//IL_0040: Expected Obj, but got Ref
			//IL_0564: Expected Obj, but got Ref
			//IL_03ee: Expected Obj, but got Ref
			//IL_04a2: Expected Obj, but got Ref
			//IL_0377: Expected Obj, but got Ref
			//IL_035d: Expected Obj, but got I4
			//IL_03a1: Expected Obj, but got I4
			//IL_0303: Expected Obj, but got I4
			//IL_0118: Expected Obj, but got Ref
			//IL_0337: Expected Obj, but got Ref
			//IL_036e: Expected Obj, but got I4
			//IL_03d2: Expected Obj, but got I4
			//IL_0443: Expected Obj, but got I4
			//IL_0196: Expected Obj, but got Ref
			//IL_014f: Expected Obj, but got I4
			//IL_0103: Expected I4, but got F8
			//IL_01c9: Expected Obj, but got I4
			//IL_01a8: Expected Obj, but got Ref
			//IL_01d9: Expected Obj, but got I4
			//IL_0589->IL0019: Incompatible stack heights: 3 vs 1
			//IL_004c->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0570->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0064->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0473->IL0086: Incompatible stack types: I4 vs F8
			//IL_03f8->IL0086: Incompatible stack types: I4 vs F8
			//IL_04ae->IL0086: Incompatible stack heights: 0 vs 1
			//IL_0082->IL0086: Incompatible stack types: I4 vs F8
			//IL_0057->IL0019: Incompatible stack types: I4 vs Obj
			//IL_057b->IL0019: Incompatible stack types: I4 vs Obj
			//IL_04b9->IL0086: Incompatible stack types: I4 vs F8
			//IL_041f->IL0086: Incompatible stack heights: 2 vs 1
			//IL_0383->IL0086: Incompatible stack heights: 0 vs 1
			//IL_0407->IL0086: Incompatible stack heights: 0 vs 1
			//IL_039c->IL0086: Incompatible stack heights: 3 vs 1
			//IL_0481->IL0086: Incompatible stack heights: 3 vs 1
			//IL_03ac->IL0086: Incompatible stack heights: 3 vs 1
			//IL_0468->IL0086: Incompatible stack heights: 2 vs 1
			//IL_0493->IL0086: Incompatible stack heights: 3 vs 1
			//IL_030e->IL0086: Incompatible stack heights: 3 vs 1
			//IL_04d5->IL0086: Incompatible stack heights: 2 vs 1
			//IL_0341->IL0086: Incompatible stack heights: 2 vs 1
			//IL_0373->IL0082: Incompatible stack heights: 0 vs 1
			//IL_03df->IL0086: Incompatible stack heights: 2 vs 1
			//IL_0351->IL0086: Incompatible stack heights: 4 vs 1
			//IL_0450->IL0086: Incompatible stack heights: 2 vs 1
			//IL_02fe->IL0086: Incompatible stack heights: 3 vs 1
			//IL_038e->IL0086: Incompatible stack types: I4 vs F8
			//IL_01a0->IL0158: Incompatible stack types: I4 vs Ref
			//IL_0412->IL0086: Incompatible stack types: I4 vs F8
			//IL_03cd->IL0086: Incompatible stack types: I4 vs F8
			//IL_0086->IL0086: Incompatible stack heights: 2 vs 1
			//IL_049e->IL0086: Incompatible stack heights: 3 vs 1
			//IL_012f->IL0086: Incompatible stack types: I4 vs F8
			//IL_0320->IL0086: Incompatible stack types: I4 vs F8
			//IL_03ea->IL0086: Incompatible stack heights: 2 vs 1
			//IL_045b->IL0086: Incompatible stack heights: 2 vs 1
			//IL_0433->IL0086: Incompatible stack heights: 0 vs 1
			//IL_0158->IL0158: Incompatible stack types: Obj vs Ref
			//IL_043e->IL0086: Incompatible stack types: I4 vs F8
			//IL_01d4->IL0158: Incompatible stack heights: 3 vs 1
			//IL_01b2->IL0158: Incompatible stack heights: 2 vs 1
			//IL_01e6->IL0158: Incompatible stack heights: 2 vs 1
			//IL_0254->IL0158: Incompatible stack heights: 2 vs 1
			//IL_021f->IL0158: Incompatible stack heights: 3 vs 1
			//IL_01f1->IL0158: Incompatible stack heights: 2 vs 1
			//IL_0279->IL0158: Incompatible stack types: I4 vs Ref
			//IL_0244->IL0158: Incompatible stack types: I4 vs Ref
			//IL_025f->IL0158: Incompatible stack heights: 2 vs 1
			//IL_022a->IL0158: Incompatible stack heights: 3 vs 1
			//IL_01c4->IL0158: Incompatible stack types: I4 vs Ref
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
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 5:
					_ = 2;
					continue;
				default:
				{
					double num;
					switch ((int)obj)
					{
					default:
						num = 29.0;
						goto IL_0086;
					case 1:
						obj = (object)Unsafe.AsPointer(ref this);
						num = 8.0;
						goto IL_0086;
					case 0:
						goto IL_0468;
					case 2:
						goto IL_049e;
						IL_0086:
						while (true)
						{
							ref byte reference;
							switch ((int)num)
							{
							case 2:
								return;
							case 20:
								return;
							case 16:
								num = 1.0;
								obj = (object)Unsafe.AsPointer(ref this);
								if (10 != 0)
								{
									num = 17.0;
								}
								continue;
							case 3:
								if (obj != null)
								{
									obj = 3;
									reference = ref *(byte*)obj;
									goto IL_0158;
								}
								goto IL_0192;
							case 29:
								_ = 0;
								_ = 27;
								continue;
							case 15:
								obj = 1;
								_ = 9;
								continue;
							case 17:
								if (&obj != null)
								{
									num = 25.0;
									continue;
								}
								goto case 15;
							case 19:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 7;
								continue;
							case 24:
								_ = ref obj;
								_ = 20;
								continue;
							case 8:
								obj = 26;
								continue;
							case 21:
								obj = 16;
								continue;
							case 1:
								goto IL_0373;
							case 6:
								_ = 24;
								continue;
							case 10:
								obj = -1;
								_ = 13;
								continue;
							case 7:
								if (&obj != null)
								{
									num = 12.0;
									continue;
								}
								goto case 22;
							case 22:
								obj = 2;
								if (4 != 0)
								{
									_ = 6;
								}
								continue;
							case 5:
								break;
							case 4:
								if (8 != 0)
								{
									num = 19.0;
								}
								continue;
							default:
								_ = 10;
								continue;
							case 28:
								if ((nint)obj == 1)
								{
									if (21 == 0)
									{
										num = 11.0;
									}
									continue;
								}
								goto end_IL_0067;
							case 26:
								obj = -1;
								if (11 == 0)
								{
									_ = 18;
								}
								continue;
							case 12:
							case 13:
								_ = ref obj;
								_ = 23;
								continue;
							case 27:
								goto IL_0468;
							case 9:
								_ = 14;
								continue;
							case 14:
								_ = ref obj;
								if (false)
								{
									_ = 2;
								}
								continue;
							case 11:
								goto IL_049e;
							case 18:
							case 25:
								_ = ref obj;
								_ = 4;
								continue;
							case 23:
								goto end_IL_0067;
								IL_0373:
								obj = (object)Unsafe.AsPointer(ref this);
								if (25 != 0)
								{
									num = 28.0;
								}
								continue;
								IL_0192:
								obj = (object)Unsafe.AsPointer(ref this);
								reference = ref *(byte*)5;
								goto IL_0158;
								IL_0158:
								while (true)
								{
									switch ((uint)Unsafe.AsPointer(ref reference))
									{
									case 2u:
										return;
									case 1u:
										break;
									case 3u:
										obj = (object)Unsafe.AsPointer(ref this);
										_ = 11;
										continue;
									case 11u:
										if (&obj != null)
										{
											reference = ref *(byte*)8;
											continue;
										}
										goto case 4u;
									default:
										obj = -1;
										_ = 6;
										continue;
									case 4u:
										obj = 0;
										if (7 != 0)
										{
											_ = 3;
										}
										continue;
									case 9u:
										_ = ref obj;
										if (1 == 0)
										{
											_ = 2;
										}
										continue;
									case 6u:
									case 8u:
										reference = ref *(byte*)(&obj);
										if (10 == 0)
										{
											reference = ref *(byte*)6;
										}
										continue;
									case 7u:
										if (9 != 0)
										{
											_ = 2;
										}
										continue;
									case 5u:
										reference = ref Unsafe.As<_003CStartGameAsync_003Ed__137, byte>(ref this);
										if (false)
										{
											reference = ref *(byte*)null;
										}
										continue;
									case 10u:
										goto IL_0373;
									}
									break;
								}
								goto IL_0192;
							}
							break;
						}
						goto case 1;
						IL_049e:
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							num = 0.0;
						}
						goto IL_0086;
						IL_0468:
						num = 3.0;
						goto IL_0086;
						end_IL_0067:
						break;
					}
					break;
				}
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 != 0)
					{
						obj2 = 3;
					}
					continue;
				case 1:
					break;
				}
				_ = -2;
				_ = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00휀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778627, new IntPtr(2737337577244L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778626, new IntPtr(2737337583484L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStartGameUnsafe_003Ed__138 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		public CancellationToken token;

		private _003C_003Ec__DisplayClass138_0 _003C_003E8__1;

		private nint _003CsocketPort_003E5__2;

		private object _003CserverAddress_003E5__3;

		private nint _003CserverPort_003E5__4;

		private TaskAwaiter _003C_003Eu__1;

		private static object ControlModule;

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
		internal static bool CheckLiteralWorker()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateScalableProvider()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00저(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778625, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00준(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00쨀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00쬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778624, new IntPtr(2737337583484L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00츀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_003e: Expected I4, but got Obj
			//IL_006f: Expected Obj, but got Ref
			//IL_0706: Expected Obj, but got Ref
			//IL_058a: Expected Obj, but got Ref
			//IL_028d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0292: Expected Obj, but got I4
			//IL_030f: Expected Obj, but got I4
			//IL_0320: Expected Obj, but got Ref
			//IL_0503: Expected Obj, but got I4
			//IL_022c: Expected Obj, but got I4
			//IL_023d: Expected Obj, but got Ref
			//IL_02a8: Expected Obj, but got I4
			//IL_05b6: Expected Obj, but got I4
			//IL_057b: Expected Obj, but got I4
			//IL_01aa: Expected Obj, but got Ref
			//IL_0471: Expected Obj, but got Ref
			//IL_0360: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_007b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0710->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0094->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0050->IL0019: Incompatible stack heights: 3 vs 1
			//IL_00c2->IL00d1: Incompatible stack heights: 0 vs 2
			//IL_00ae->IL0019: Incompatible stack types: I4 vs Ref
			//IL_006b->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0086->IL0019: Incompatible stack types: I4 vs Ref
			//IL_01a2->IL03f2: Incompatible stack heights: 1 vs 0
			//IL_040e->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_00cd->IL00d1: Incompatible stack heights: 1 vs 2
			//IL_049a->IL00d1: Incompatible stack heights: 4 vs 2
			//IL_0594->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_029c->IL00d1: Incompatible stack heights: 14 vs 2
			//IL_032c->IL00d1: Incompatible stack heights: 6 vs 2
			//IL_063b->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_0247->IL00d1: Incompatible stack heights: 7 vs 2
			//IL_02ad->IL00cd: Incompatible stack heights: 2 vs 3
			//IL_0576->IL00d1: Incompatible stack heights: 4 vs 2
			//IL_02be->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_0623->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_0559->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_02f8->IL00d1: Incompatible stack heights: 4 vs 2
			//IL_03e7->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_0254->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_05cf->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_0613->IL00d1: Incompatible stack heights: 4 vs 2
			//IL_0392->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_0455->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_05c1->IL00d1: Incompatible stack heights: 4 vs 2
			//IL_02e9->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_053a->IL00d1: Incompatible stack heights: 14 vs 2
			//IL_042e->IL00d1: Incompatible stack heights: 7 vs 2
			//IL_0586->IL00d1: Incompatible stack heights: 4 vs 2
			//IL_05b1->IL00d1: Incompatible stack heights: 4 vs 2
			//IL_0263->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_01b4->IL00d1: Incompatible stack heights: 1 vs 2
			//IL_04ca->IL00d1: Incompatible stack heights: 5 vs 2
			//IL_0208->IL00d1: Incompatible stack heights: 9 vs 2
			//IL_0215->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_04e9->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_01c5->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_047d->IL00d1: Incompatible stack types: Obj vs Ref
			//IL_03c8->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_05a1->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_0376->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_0365->IL00cd: Incompatible stack heights: 15 vs 3
			//IL_0307->IL00d1: Incompatible stack heights: 4 vs 2
			//IL_0224->IL00d1: Incompatible stack heights: 4 vs 2
			//IL_0337->IL00d1: Incompatible stack heights: 6 vs 2
			//IL_00d1->IL00d1: Incompatible stack heights: 4 vs 2
			//IL_01ea->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_02c9->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_062e->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_02db->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_0564->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_03f2->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_05f7->IL00d1: Incompatible stack heights: 1 vs 2
			//IL_0468->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_039d->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_0545->IL00d1: Incompatible stack heights: 14 vs 2
			//IL_0439->IL00d1: Incompatible stack heights: 7 vs 2
			//IL_0655->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_04f4->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_01d0->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_0488->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_04af->IL00d1: Incompatible stack heights: 1 vs 2
			//IL_03d3->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_03b7->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_0381->IL00d1: Incompatible stack heights: 3 vs 2
			//IL_0602->IL00d1: Incompatible stack heights: 1 vs 2
			//IL_04ba->IL00d1: Incompatible stack heights: 1 vs 2
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			ref _003CStartGameUnsafe_003Ed__138 reference = ref *(_003CStartGameUnsafe_003Ed__138*)obj;
			while (true)
			{
				scoped ref byte reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 7u:
					_ = null;
					_ = 2;
					break;
				case 0u:
					return;
				case 3u:
					reference = ref this;
					if (7 != 0)
					{
						reference = ref *(_003CStartGameUnsafe_003Ed__138*)2;
					}
					break;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (true)
					{
						reference = ref *(_003CStartGameUnsafe_003Ed__138*)null;
					}
					break;
				case 6u:
					_ = -2;
					_ = 3;
					break;
				case 2u:
					reference = ref this;
					if (false)
					{
						reference = ref *(_003CStartGameUnsafe_003Ed__138*)null;
					}
					break;
				case 1u:
					if (obj == null)
					{
						if (0 == 0)
						{
							_ = 1;
						}
						goto IL_00d1;
					}
					goto IL_03f2;
				case 5u:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(_003CStartGameUnsafe_003Ed__138*)4;
						break;
					}
					IL_03f2:
					reference2 = ref Unsafe.As<_003CStartGameUnsafe_003Ed__138, byte>(ref this);
					if (10 == 0)
					{
						reference2 = ref *(byte*)25;
					}
					goto IL_00d1;
					IL_00d1:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						case 29u:
							return;
						case 36u:
							break;
						case 34u:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 37;
							continue;
						case 41u:
							if (2 != 0)
							{
								_ = 5;
							}
							continue;
						case 7u:
							reference2 = ref Unsafe.As<_003CStartGameUnsafe_003Ed__138, byte>(ref this);
							if (3 == 0)
							{
								reference2 = ref *(byte*)28;
							}
							continue;
						case 37u:
							_ = 32;
							continue;
						case 39u:
							_ = 7;
							continue;
						case 50u:
							_ = 3;
							continue;
						case 8u:
							_ = 10;
							obj = 1;
							_ = ref obj;
							_ = ref obj;
							obj = (object)(&obj);
							_ = 19;
							continue;
						case 19u:
							_ = 24;
							continue;
						case 33u:
							reference2 = ref *(byte*)23;
							continue;
						case 3u:
							_ = obj * 1024;
							obj = 1;
							_ = 43;
							continue;
						case 9u:
							obj = 49;
							continue;
						case 11u:
							if (16 == 0)
							{
								_ = 6;
							}
							continue;
						case 14u:
							if (&obj != null)
							{
								reference2 = ref *(byte*)22;
								continue;
							}
							goto case 26u;
						case 27u:
							_ = 44;
							continue;
						case 16u:
							_ = 20;
							continue;
						case 49u:
							_ = 11;
							continue;
						case 4u:
							_ = 9;
							obj = 1;
							_ = ref obj;
							_ = ref obj;
							obj = (object)(&obj);
							if (8 == 0)
							{
								_ = 0;
							}
							continue;
						case 48u:
							_ = 0;
							_ = 1;
							_ = 1;
							_ = 1;
							obj = 47;
							continue;
						case 47u:
							_ = 1;
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 24u:
							if (37 == 0)
							{
								_ = 48;
							}
							continue;
						case 22u:
						case 45u:
							reference2 = ref *(byte*)(&obj);
							if (46 == 0)
							{
								reference2 = ref *(byte*)null;
							}
							continue;
						case 44u:
							if (36 == 0)
							{
								_ = 13;
							}
							continue;
						case 17u:
							if (28 == 0)
							{
								_ = 42;
							}
							continue;
						case 13u:
							goto IL_03f2;
						case 30u:
							if (5 != 0)
							{
								_ = 6;
							}
							continue;
						case 25u:
							_ = 12;
							continue;
						case 20u:
							if (obj != null)
							{
								reference2 = ref *(byte*)39;
								continue;
							}
							goto case 46u;
						case 42u:
						{
							object obj2 = obj;
							obj = (object)Unsafe.AsPointer(ref this);
							reference2 = ref *(byte*)obj2;
							if (14 == 0)
							{
								reference2 = ref *(byte*)4;
							}
							continue;
						}
						default:
							_ = 10;
							continue;
						case 43u:
							if (obj != null)
							{
								if (4 == 0)
								{
									_ = 18;
								}
								continue;
							}
							goto case 19u;
						case 35u:
							_ = ref obj;
							_ = 29;
							continue;
						case 40u:
							if (31 != 0)
							{
								_ = 35;
							}
							continue;
						case 6u:
							obj = 9;
							continue;
						case 28u:
							_ = 1;
							if (17 == 0)
							{
								_ = 8;
							}
							continue;
						case 15u:
							if (33 != 0)
							{
								_ = 11;
							}
							continue;
						case 10u:
							_ = 15;
							continue;
						case 31u:
							obj = -1;
							_ = 45;
							continue;
						case 1u:
						case 2u:
							obj = (object)Unsafe.AsPointer(ref this);
							reference2 = ref *(byte*)38;
							continue;
						case 46u:
							_ = 34;
							continue;
						case 32u:
							_ = 50;
							continue;
						case 26u:
							obj = 0;
							_ = 40;
							continue;
						case 21u:
							_ = 27;
							continue;
						case 18u:
							if ((nuint)(nint)obj >= (nuint)1018000u)
							{
								if (4 != 0)
								{
									_ = 4;
								}
								continue;
							}
							goto case 19u;
						case 23u:
							_ = 21;
							continue;
						case 12u:
							_ = 0;
							if (12 == 0)
							{
								_ = 41;
							}
							continue;
						case 5u:
							_ = 30;
							continue;
						case 38u:
							reference2 = ref Unsafe.As<_003CStartGameUnsafe_003Ed__138, byte>(ref this);
							if (31 == 0)
							{
								reference2 = ref *(byte*)1;
							}
							continue;
						}
						break;
					}
					goto case 6u;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00케()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00퀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778687, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	private object? _tokenSource;

	private readonly Queue<string> _recentLog;

	private nint _crashDetectedByLog;

	private readonly object _logLock;

	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	public readonly string Name;

	public readonly DesktopSession Session;

	public readonly string GameId;

	public readonly EnumGameType GameType;

	public readonly EnumGameVersion GameVersion;

	public readonly string ServerAddress;

	public readonly int ServerPort;

	[CompilerGenerated]
	private Action<JavaGame>? m_GameProgressChanged;

	[CompilerGenerated]
	private object? m_Disposed;

	[CompilerGenerated]
	private static readonly object Task__BackingField;

	private static readonly nint TotalStep;

	private static object CheckCommonGateway;

	private JavaLog Log
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (JavaLog)_FF00_FF00_FF00㤀();
		}
	}

	private CancellationTokenSource? ReconnectCts
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (CancellationTokenSource?)_FF00_FF00_FF00礀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00준(value);
		}
	}

	private JavaGameOption? GameOptions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (JavaGameOption?)_FF00_FF00_FF00ꠀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00褀(value);
		}
	}

	public List<ComponentPath>? Components
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00猀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00ᄀ(value);
		}
	}

	public ServerModPath? ServerModPath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ServerModPath?)_FF00_FF00_FF00㬀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00䔀(value);
		}
	}

	private static ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	public bool Starting
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00ᴀ() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00က(value ? ((byte)1) : ((byte)0));
		}
	}

	public List<ulong> ComponentList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00㘀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00錀(value);
		}
	}

	public string ModHashList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00ᘀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00縀(value);
		}
	}

	public bool Launched
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FFFD() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			_FF00_FF00_FF00_F600(value ? ((byte)1) : ((byte)0));
		}
	}

	private Process? Process
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Process?)_FF00_FF00_FF00ꌀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FFFD((object)value);
		}
	}

	private static JavaTask Task
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	private JavaGameValue Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (JavaGameValue)_FF00_FF00_FF00_FF00_0600();
		}
	}

	private JavaGamePath Path
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (JavaGamePath)_FF00_FF00_FF00_FF00_2A00();
		}
	}

	public EntityProgress Progress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EntityProgress)_FF00_FF00_FF00_E600();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00萀(value);
		}
	}

	public EnumStepPhase LastPhase
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00蔀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_0900(value);
		}
	}

	public JavaStep LastStep
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00簀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_F700(value);
		}
	}

	private GameProxy? Proxy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (GameProxy?)_FF00_FF00_FF00_E200();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00㴀(value);
		}
	}

	private JavaRpc? Rpc
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (JavaRpc?)_FF00_FF00_FF00넀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_2900(value);
		}
	}

	private JavaAuthenticator? Authenticator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (JavaAuthenticator?)_FF00_FF00_FF00_FF00ᤀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00鴀(value);
		}
	}

	public bool HasExited
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00㼀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			_FF00_FF00_FF00鈀(value ? ((byte)1) : ((byte)0));
		}
	}

	public int ExitCode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00瘀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			_FF00_FF00_FF00픀((uint)value);
		}
	}

	public int ProcessId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_1B00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			_FF00_FF00_FF00ꘀ((uint)value);
		}
	}

	public event Action<JavaGame>? GameProgressChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00_FF00_FF00㜀(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00_FF00_FF00騀(value);
		}
	}

	public event Action? Disposed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00_FF00_FF00_FF00_2700(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			this._FF00_FF00_FF00_FFFD((object)value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LaunchPreCheck()
	{
		_FF00_FF00_FF00_FF00㐀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLaunchStepsAsync_003Ed__2))]
	private object LaunchStepsAsync()
	{
		return _FF00_FF00_FF00_FF00_2F00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		_FF00_FF00_FF00_F200();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WaitWindow()
	{
		_FF00_FF00_FF00_FF00Ѐ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDataReceived(object sender, object e)
	{
		_FF00_FF00_FF00_E900(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnDataReceivedAsync_003Ed__12))]
	private object OnDataReceivedAsync(object sender, object e)
	{
		return _FF00_FF00_FF00_E000(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnDataReceivedAsync_003Ed__13))]
	private object OnDataReceivedAsync(object line)
	{
		return _FF00_FF00_FF00퀀(line);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnDisconnectedAsync_003Ed__14))]
	private object OnDisconnectedAsync()
	{
		return _FF00_FF00_FF00윀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnGameExit(object? sender, object e)
	{
		_FF00_FF00_FF00_FF00_2500(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareStart()
	{
		_FF00_FF00_FF00_FF00_0E00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareEnvironment()
	{
		_FF00_FF00_FF00츀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareOptions()
	{
		_FF00_FF00_FF00嘀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveGameOptions()
	{
		_FF00_FF00_FF00需();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPrepareComponentsAsync_003Ed__28))]
	public Task PrepareComponentsAsync(CancellationToken cancellationToken)
	{
		return (Task)_FF00_FF00_FF00관(cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InstallComponents()
	{
		_FF00_FF00_FF00ﬀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InstallCoreLib()
	{
		_FF00_FF00_FF00洀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPrepareJreAsync_003Ed__35))]
	public Task PrepareJreAsync(CancellationToken cancellationToken)
	{
		return (Task)_FF00_FF00_FF00ꨀ(cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPrepareServerResourceAsync_003Ed__36))]
	public Task PrepareServerResourceAsync(CancellationToken cancellationToken)
	{
		return (Task)_FF00_FF00_FF00贀(cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InstallServerResources()
	{
		_FF00_FF00_FF00_E400();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InstallServerMods()
	{
		_FF00_FF00_FF00脀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPrepareBaseVersionAsync_003Ed__43))]
	public Task PrepareBaseVersionAsync(CancellationToken cancellationToken)
	{
		return (Task)_FF00_FF00_FF00_F400(cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPrepareVersionAsync_003Ed__44))]
	public Task PrepareVersionAsync(CancellationToken cancellationToken)
	{
		return (Task)_FF00_FF00_FF00_FF00_0C00(cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPreparePackageAsync_003Ed__45))]
	private object PreparePackageAsync(JavaStep step, object md5, object name, object url, object md5Path, object outputPath, CancellationToken cancellationToken, object? before = null, object? after = null)
	{
		return _FF00_FF00_FF00_FFFD(step, md5, name, url, md5Path, outputPath, cancellationToken, before, after);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JavaGame(EntityLaunchJavaGame args)
	{
		//IL_00cd: Expected I4, but got Obj
		//IL_00bb->IL00c4: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = 4;
		_ = 0;
		_ = 0;
		_ = 0;
		JavaGame javaGame = this;
		if (0 == 0)
		{
			javaGame = (JavaGame)0;
		}
		switch ((int)javaGame)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartLaunch()
	{
		_FF00_FF00_FF00瀀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLaunchAsync_003Ed__106))]
	private object LaunchAsync()
	{
		return _FF00_FF00_FF00팀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReportProgress(EnumStepPhase phase, JavaStep step, uint percentage, object message = "")
	{
		_FF00_FF00_FF00茀(phase, step, percentage, message);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReportProgress()
	{
		_FF00_FF00_FF00씀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object GetStepMessage(EnumStepPhase phase, JavaStep step, object message = "")
	{
		return _FF00_FF00_FF00_FF00_0300(phase, step, message);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object GetStepName(EnumStepPhase phase, JavaStep step)
	{
		return _FF00_FF00_FF00숀(phase, step);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareMods()
	{
		_FF00_FF00_FF00夀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CStartGameAsync_003Ed__137))]
	private object StartGameAsync(CancellationToken token)
	{
		return _FF00_FF00_FF00蠀(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CStartGameUnsafe_003Ed__138))]
	private object StartGameUnsafe(CancellationToken token)
	{
		return _FF00_FF00_FF00ﰀ(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return (string)_FF00_FF00_FF00退();
	}

	static JavaGame()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0027: Expected I4, but got Obj
		//IL_00a1->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0055->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0083->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00ac->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0060->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				return;
			case 1:
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_FF00㨀());
				obj2 = 0;
				if (_003CModule_003E_007B8336717d_002D71de_002D47ce_002Dbc69_002D4d75223ebc5e_007D.m_d836f3f9b6194f49a23d85cb66f28ddf.m_f8b10c0cb3e1457fa63d1cc479fd3526 != 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				TotalStep = Enum.GetValues(typeof(JavaStep)).Length;
				obj2 = 3;
				break;
			default:
				Task__BackingField = new JavaTask();
				obj2 = 1;
				if (_003CModule_003E_007B8336717d_002D71de_002D47ce_002Dbc69_002D4d75223ebc5e_007D.m_d836f3f9b6194f49a23d85cb66f28ddf.m_8d15d782e61741a1bab9ffa500515719 == 0)
				{
					obj2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateAdaptableProfiler()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static JavaGame ReflectPortableFactory()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00㘀(Action<JavaGame> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778778, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00㜀(Action<JavaGame> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00b8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0059->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0095->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0079->IL0019: Incompatible stack types: I4 vs Obj
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
				obj2 = obj;
				obj = P_0;
				if (2 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				if (obj == obj)
				{
					if (true)
					{
						obj2 = 3;
					}
					break;
				}
				goto case 4;
			case 3:
				return;
			case 4:
				obj = obj;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			case 5:
				obj = this;
				obj2 = 4;
				break;
			case 2:
				obj = obj;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00㠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778777, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00㤀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00㬀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00㰀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778776, new IntPtr(2737337588684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00㴀(object P_0)
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
	internal unsafe byte _FF00_FF00_FF00㸀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778775, new IntPtr(2737337586604L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00㼀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00䀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778774, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00䄀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778773, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00䈀()
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
	private unsafe void _FF00_FF00_FF00䌀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778772, new IntPtr(2737337586604L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00_FF00䐀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00䔀(object P_0)
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
	private void _FF00_FF00_FF00嘀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0062: Expected I4, but got Obj
		//IL_05bc: Expected I4, but got Obj
		//IL_0194: Expected I4, but got Obj
		//IL_00cf: Expected I4, but got Obj
		//IL_04ac: Expected I4, but got Obj
		//IL_0073->IL008a: Incompatible stack heights: 1 vs 0
		//IL_015b->IL0067: Incompatible stack heights: 1 vs 0
		//IL_0210->IL014f: Incompatible stack heights: 1 vs 0
		//IL_0165->IL0019: Incompatible stack heights: 2 vs 1
		//IL_05ab->IL05af: Incompatible stack types: I4 vs Obj
		//IL_0204->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0582->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0187->IL018b: Incompatible stack types: I4 vs Obj
		//IL_0550->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00be->IL00c2: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0564->IL0019: Incompatible stack heights: 0 vs 1
		//IL_049b->IL049f: Incompatible stack types: I4 vs Obj
		//IL_008a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0227->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05d3->IL05af: Incompatible stack heights: 2 vs 1
		//IL_058d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0403->IL03e1: Incompatible stack heights: 2 vs 1
		//IL_00e5->IL00c2: Incompatible stack heights: 2 vs 1
		//IL_0269->IL0247: Incompatible stack heights: 2 vs 1
		//IL_067f->IL065d: Incompatible stack heights: 2 vs 1
		//IL_056f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04c7->IL049f: Incompatible stack heights: 4 vs 2
		//IL_05de->IL05af: Incompatible stack heights: 2 vs 1
		//IL_040e->IL03e1: Incompatible stack heights: 2 vs 1
		//IL_00f0->IL00c2: Incompatible stack heights: 2 vs 1
		//IL_0274->IL0247: Incompatible stack heights: 2 vs 1
		//IL_068a->IL065d: Incompatible stack heights: 2 vs 1
		//IL_0310->IL0314: Incompatible stack heights: 1 vs 0
		//IL_04d2->IL049f: Incompatible stack heights: 4 vs 2
		//IL_034a->IL0314: Incompatible stack heights: 1 vs 0
		//IL_0339->IL0314: Incompatible stack heights: 3 vs 0
		//IL_0355->IL0314: Incompatible stack heights: 1 vs 0
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 7;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				obj2 = this;
				if (this == null)
				{
					if (12 == 0)
					{
						obj2 = 6;
					}
					break;
				}
				return;
			case 1:
				return;
			case 14:
				if (this != null)
				{
					obj2 = 5;
					break;
				}
				goto case 3;
			case 10:
			{
				JavaGame javaGame2 = this;
				obj = this;
				if (true)
				{
					javaGame2 = (JavaGame)1;
				}
				while (true)
				{
					switch ((int)javaGame2)
					{
					case 1:
						if (false)
						{
							_ = 0;
						}
						continue;
					}
					break;
				}
				goto case 15;
			}
			case 2:
				if (this == null)
				{
					_ = 11;
					break;
				}
				goto default;
			case 7:
			{
				JavaGame javaGame4 = this;
				if (false)
				{
					javaGame4 = (JavaGame)0;
				}
				switch ((int)javaGame4)
				{
				}
				goto case 6;
			}
			case 4:
				return;
			case 3:
				obj2 = this;
				if (this == null)
				{
					if (8 != 0)
					{
						obj2 = 8;
					}
					break;
				}
				goto case 2;
			case 11:
			{
				int num2 = 0;
				if (0 == 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						break;
					default:
						_ = 0;
						if (1 == 0)
						{
							_ = 0;
						}
						continue;
					}
					break;
				}
				goto default;
			}
			case 13:
				if ((nuint)(nint)this > (nuint)1010002u)
				{
				}
				obj = (object)/*Error near IL_02f9: Stack underflow*/;
				if (false)
				{
					_ = 0;
				}
				while (true)
				{
					switch ((int)/*Error near IL_0325: Stack underflow*/)
					{
					case 1:
						_ = 2;
						continue;
					default:
						if (0 == 0)
						{
							_ = 1;
						}
						continue;
					case 2:
						break;
					}
					break;
				}
				goto case 9;
			case 8:
			{
				int num3 = 0;
				if (0 == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						break;
					default:
						_ = 0;
						if (true)
						{
							_ = 0;
						}
						continue;
					}
					break;
				}
				goto case 2;
			}
			case 16:
			{
				JavaGame javaGame3 = this;
				if (0 == 0)
				{
					javaGame3 = (JavaGame)0;
				}
				while (true)
				{
					switch ((int)javaGame3)
					{
					case 1:
						break;
					default:
						if (true)
						{
							_ = 1;
						}
						continue;
					}
					break;
				}
				goto case 14;
			}
			case 9:
				if (this != null)
				{
					obj2 = 16;
					break;
				}
				goto case 14;
			case 15:
				if (this != null)
				{
					if (false)
					{
						obj2 = 13;
					}
					break;
				}
				goto case 9;
			case 6:
				if (this != null)
				{
					obj2 = 10;
				}
				else if (true)
				{
					obj2 = 4;
				}
				break;
			case 5:
			{
				JavaGame javaGame = this;
				if (1 == 0)
				{
					javaGame = (JavaGame)0;
				}
				while (true)
				{
					switch ((int)javaGame)
					{
					case 1:
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
					}
					break;
				}
				goto case 3;
			}
			case 12:
			{
				int num = 1;
				if (0 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						return;
					}
					_ = 1;
					if (true)
					{
						_ = 1;
					}
				}
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte _FF00_FF00_FF00圀(object P_0)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (P_0 == this) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe byte _FF00_FF00_FF00堀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778771, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00夀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
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
	private unsafe void _FF00_FF00_FF00娀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778770, new IntPtr(2737337576204L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00氀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778769, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00洀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_00b6: Expected I4, but got Obj
		//IL_03c0: Expected Obj, but got I4
		//IL_03c4: Expected Obj, but got I4
		//IL_03c8: Expected Obj, but got I4
		//IL_03cc: Expected Obj, but got I4
		//IL_03d5: Expected Obj, but got I4
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected Obj, but got Unknown
		//IL_0128: Expected Obj, but got I4
		//IL_012c: Expected Obj, but got I4
		//IL_0130: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got I4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_02e8: Expected Obj, but got I4
		//IL_02ec: Expected Obj, but got I4
		//IL_02f0: Expected Obj, but got I4
		//IL_02f9: Expected Obj, but got I4
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected Obj, but got Unknown
		//IL_0354: Expected Obj, but got I4
		//IL_0326: Expected Obj, but got I4
		//IL_036c: Expected Obj, but got I4
		//IL_00c8: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I4
		//IL_00d9: Expected Obj, but got I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected Obj, but got Unknown
		//IL_0220: Expected Obj, but got I4
		//IL_0224: Expected Obj, but got I4
		//IL_0228: Expected Obj, but got I4
		//IL_0231: Expected Obj, but got I4
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_02c7: Expected Obj, but got I4
		//IL_039f: Expected Obj, but got I4
		//IL_034c: Expected Obj, but got I4
		//IL_043e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01ad->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03e7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_014d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0108->IL0019: Incompatible stack heights: 2 vs 1
		//IL_03f8->IL0019: Incompatible stack heights: 0 vs 1
		//IL_030d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_035e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_019c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_042b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_032b->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0371->IL0015: Incompatible stack heights: 1 vs 0
		//IL_00eb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0208->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0468->IL0019: Incompatible stack types: I4 vs Obj
		//IL_027b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0245->IL0019: Incompatible stack heights: 0 vs 1
		//IL_018c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0449->IL0019: Incompatible stack heights: 2 vs 1
		//IL_016d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0158->IL0019: Incompatible stack types: I4 vs Obj
		//IL_011b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0403->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0318->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0213->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0286->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02b7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0418->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0250->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0178->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 17;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 23:
				{
					((object[])6)[0] = this;
					((object[])6)[6] = 1;
					_003F val4 = /*Error near IL_00c8: Stack underflow*/;
					((object[])/*Error near IL_00cc: Stack underflow*/)[val4] = 2;
					_003F val5 = /*Error near IL_00cc: Stack underflow*/;
					((object[])/*Error near IL_00d0: Stack underflow*/)[val5] = 3;
					_003F val6 = /*Error near IL_00d0: Stack underflow*/;
					((object[])4)[obj] = 4;
					((object[])val6)[5] = obj;
					obj = (object)val6;
					obj2 = 26;
					continue;
				}
				case 10:
					_ = 13;
					continue;
				case 11:
				case 20:
					if (obj == null)
					{
						obj2 = 37;
						continue;
					}
					goto case 6;
				case 9:
				{
					((object[])6)[0] = this;
					((object[])6)[6] = 1;
					_003F val14 = /*Error near IL_0128: Stack underflow*/;
					((object[])/*Error near IL_012c: Stack underflow*/)[val14] = 2;
					_003F val15 = /*Error near IL_012c: Stack underflow*/;
					((object[])/*Error near IL_0130: Stack underflow*/)[val15] = 3;
					_003F val16 = /*Error near IL_0130: Stack underflow*/;
					((object[])4)[obj] = 4;
					((object[])val16)[5] = obj;
					obj = (object)val16;
					if (31 == 0)
					{
						obj2 = 13;
					}
					continue;
				}
				case 7:
					if (obj != null)
					{
						if (15 != 0)
						{
							obj2 = 13;
						}
						continue;
					}
					goto case 35;
				case 13:
					return;
				default:
					if (obj == null)
					{
						obj2 = 5;
						continue;
					}
					goto case 19;
				case 17:
					obj = this;
					obj2 = 16;
					continue;
				case 2:
					obj = ((object[])obj)[obj];
					obj2 = 14;
					continue;
				case 3:
				case 8:
				case 12:
				case 24:
				case 25:
				case 26:
				case 31:
					obj = obj;
					if (18 != 0)
					{
						obj2 = 18;
					}
					continue;
				case 36:
				{
					((object[])6)[0] = this;
					((object[])6)[6] = 1;
					_003F val7 = /*Error near IL_0220: Stack underflow*/;
					((object[])/*Error near IL_0224: Stack underflow*/)[val7] = 2;
					_003F val8 = /*Error near IL_0224: Stack underflow*/;
					((object[])/*Error near IL_0228: Stack underflow*/)[val8] = 3;
					_003F val9 = /*Error near IL_0228: Stack underflow*/;
					((object[])4)[obj] = 4;
					((object[])val9)[5] = obj;
					obj = (object)val9;
					if (24 != 0)
					{
						obj2 = 15;
					}
					continue;
				}
				case 28:
				case 37:
					obj = null;
					if (25 == 0)
					{
						obj2 = 16;
					}
					continue;
				case 5:
				case 29:
					if (obj != null)
					{
						obj2 = 36;
						continue;
					}
					goto case 30;
				case 18:
					if (obj != null)
					{
						obj = 4;
						break;
					}
					goto case 22;
				case 15:
				{
					((object[])6)[0] = this;
					((object[])6)[6] = 1;
					_003F val = /*Error near IL_02e8: Stack underflow*/;
					((object[])/*Error near IL_02ec: Stack underflow*/)[val] = 2;
					_003F val2 = /*Error near IL_02ec: Stack underflow*/;
					((object[])/*Error near IL_02f0: Stack underflow*/)[val2] = 3;
					_003F val3 = /*Error near IL_02f0: Stack underflow*/;
					((object[])4)[obj] = 4;
					((object[])val3)[5] = obj;
					obj = (object)val3;
					if (12 != 0)
					{
						obj2 = 2;
					}
					continue;
				}
				case 21:
					obj = 27;
					break;
				case 35:
					if (obj == null)
					{
						obj = 20;
						break;
					}
					goto case 9;
				case 16:
					obj = 0;
					obj2 = 33;
					continue;
				case 22:
					obj = 34;
					break;
				case 30:
					if (obj != null)
					{
						obj = 23;
						break;
					}
					goto case 7;
				case 6:
				{
					((object[])7)[0] = this;
					((object[])7)[7] = 1;
					_003F val10 = /*Error near IL_03c0: Stack underflow*/;
					((object[])/*Error near IL_03c4: Stack underflow*/)[val10] = 2;
					_003F val11 = /*Error near IL_03c4: Stack underflow*/;
					((object[])/*Error near IL_03c8: Stack underflow*/)[val11] = 3;
					_003F val12 = /*Error near IL_03c8: Stack underflow*/;
					((object[])/*Error near IL_03cc: Stack underflow*/)[val12] = 4;
					_003F val13 = /*Error near IL_03cc: Stack underflow*/;
					((object[])5)[obj] = 4;
					((object[])val13)[6] = obj;
					obj = (object)val13;
					obj2 = 8;
					continue;
				}
				case 14:
					obj = obj;
					if (false)
					{
						obj2 = 0;
					}
					continue;
				case 32:
				case 33:
					if ((nint)obj >= ((Array)obj).Length)
					{
						obj2 = 10;
						continue;
					}
					goto case 2;
				case 19:
					obj = obj;
					_ = 3;
					continue;
				case 1:
				case 4:
					if (21 != 0)
					{
						_ = 15;
					}
					continue;
				case 27:
				case 34:
					obj++;
					obj2 = 32;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00渀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778768, new IntPtr(2737337577244L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00漀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778767, new IntPtr(2737337582444L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00瀀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003c->IL0019: Incompatible stack heights: 0 vs 1
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
	internal unsafe void _FF00_FF00_FF00焀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778766, new IntPtr(2737337583484L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<ComponentPath> _FF00_FF00_FF00爀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778765, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (List<ComponentPath>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<ComponentPath> _FF00_FF00_FF00猀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (List<ComponentPath>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<ComponentPath> _FF00_FF00_FF00琀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778764, new IntPtr(2737337594924L), 15))(null, 0, new IntPtr(0L));
		return (List<ComponentPath>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00甀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778763, new IntPtr(2737337588684L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00瘀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00眀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778762, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00砀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778761, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00礀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00稀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778760, new IntPtr(2737337582444L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe JavaStep _FF00_FF00_FF00笀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778759, new IntPtr(2737337594924L), 15))(null, 0, new IntPtr(0L));
		return (JavaStep)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal JavaStep _FF00_FF00_FF00簀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (JavaStep)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00紀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778758, new IntPtr(2737337594924L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00縀(object P_0)
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
	private unsafe void _FF00_FF00_FF00耀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778757, new IntPtr(2737337579324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00脀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_006a: Expected Obj, but got I4
		//IL_004e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0059->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0083->IL0019: Incompatible stack heights: 0 vs 1
		//IL_008e->IL0019: Incompatible stack types: I4 vs Obj
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
					throw /*Error near IL_003a: Stack underflow*/;
				case 2:
					if (true)
					{
						_ = 0;
					}
					continue;
				case 4:
					if ((nint)this != 2)
					{
						break;
					}
					if (this != null)
					{
						if (2 == 0)
						{
							obj2 = 2;
						}
						continue;
					}
					goto default;
				case 3:
					return;
				case 1:
					return;
				}
				break;
			}
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00舀(EnumStepPhase P_0, JavaStep P_1, uint P_2, object P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778756, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00茀(EnumStepPhase P_0, JavaStep P_1, uint P_2, object P_3)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0066: Expected Obj, but got I4
		//IL_0087->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0078->IL0019: Incompatible stack heights: 3 vs 1
		//IL_006b->IL0015: Incompatible stack heights: 8 vs 0
		//IL_0092->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0050->IL0019: Incompatible stack types: I4 vs Obj
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
					obj2 = this;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 3:
					break;
				case 1:
					_ = 4;
					continue;
				default:
					if (1 == 0)
					{
						_ = 1;
					}
					continue;
				case 4:
					return;
				}
				break;
			}
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00萀(object P_0)
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
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal EnumStepPhase _FF00_FF00_FF00蔀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (EnumStepPhase)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumStepPhase _FF00_FF00_FF00蘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778755, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (EnumStepPhase)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00蜀(CancellationToken P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778754, new IntPtr(2737337582444L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00蠀(CancellationToken P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0040: Expected Obj, but got Ref
		//IL_0094->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0079->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a4->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0084->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00af->IL0019: Incompatible stack heights: 2 vs 1
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
			case 4:
				return (object)(&obj);
			case 3:
				_ = ref obj;
				_ = 2;
				break;
			case 5:
				_ = ref obj;
				_ = -1;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 1:
				_ = ref obj;
				if (5 == 0)
				{
					_ = 5;
				}
				break;
			default:
				_ = ref obj;
				_ = ref obj;
				_ = 4;
				break;
			case 2:
				_ = ref obj;
				if (true)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00褀(object P_0)
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
	internal unsafe static byte _FF00_FF00_FF00言()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778753, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00謀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00谀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778752, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00贀(CancellationToken P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_006b: Expected Obj, but got Ref
		//IL_0078: Expected Obj, but got I4
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_004b->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00a8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007d->IL0015: Incompatible stack heights: 2 vs 0
		//IL_00b3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0098->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
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
				default:
					_ = ref obj;
					_ = ref obj;
					_ = 4;
					continue;
				case 3u:
					_ = ref obj;
					_ = -1;
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 4u:
					return (object)(&obj);
				case 5u:
					break;
				case 2u:
					reference = ref obj;
					if (true)
					{
						reference = ref *(object*)1;
					}
					continue;
				case 1u:
					_ = ref obj;
					if (5 == 0)
					{
						_ = 3;
					}
					continue;
				}
				break;
			}
			_ = ref obj;
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00踀(CancellationToken P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778815, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00輀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778814, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00退()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00鄀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778813, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00鈀(byte P_0)
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
	internal void _FF00_FF00_FF00錀(List<ulong> P_0)
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
	internal unsafe void _FF00_FF00_FF00鐀(List<ulong> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778812, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00需()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00ad: Expected I4, but got Obj
		//IL_0079: Expected Obj, but got I4
		//IL_00a0->IL00a4: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0069->IL0019: Incompatible stack types: I4 vs Obj
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
					return;
				case 5:
					if (this == null)
					{
						obj2 = 2;
					}
					else if (false)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					return;
				case 3:
					return;
				case 4:
					if (this == null)
					{
						break;
					}
					goto case 5;
				default:
				{
					JavaGame javaGame = this;
					if (0 == 0)
					{
						javaGame = (JavaGame)0;
					}
					switch ((int)javaGame)
					{
					case 0:
						break;
					}
					return;
				}
				}
				break;
			}
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00頀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778811, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00餀(Action<JavaGame> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778810, new IntPtr(2737337576204L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00騀(Action<JavaGame> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00b6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00a5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_008a->IL0019: Incompatible stack types: I4 vs Obj
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
				obj = this;
				if (true)
				{
					obj2 = 0;
				}
				break;
			case 5:
				return;
			case 4:
				obj = obj;
				_ = 3;
				break;
			case 3:
				if (obj == obj)
				{
					if (5 == 0)
					{
						obj2 = 5;
					}
					break;
				}
				goto case 1;
			case 1:
				obj = obj;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				obj = P_0;
				_ = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00鬀(Action<JavaGame> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778809, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00鰀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778808, new IntPtr(2737337594924L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00鴀(object P_0)
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
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00鸀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778807, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00鼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778806, new IntPtr(2737337592844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00ꀀ()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0064->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0050->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008a->IL0019: Incompatible stack types: I4 vs Obj
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
			default:
				obj2 = this;
				if (3 == 0)
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
			case 2:
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
	private unsafe void _FF00_FF00_FF00ꄀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778805, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00ꈀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00ꌀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00ꐀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778804, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00ꔀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778803, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00ꘀ(uint P_0)
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
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_A700(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778802, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00ꠀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00꤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778801, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00ꨀ(CancellationToken P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00af: Expected Obj, but got Ref
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_008f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_009f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0076->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00aa->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0066->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0081->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			case 4u:
				_ = ref obj;
				_ = ref obj;
				_ = 3;
				break;
			case 2u:
				reference = ref obj;
				if (true)
				{
					reference = ref *(object*)null;
				}
				break;
			case 5u:
				_ = ref obj;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			default:
				_ = ref obj;
				_ = -1;
				_ = 4;
				break;
			case 1u:
				_ = ref obj;
				if (5 == 0)
				{
					_ = 5;
				}
				break;
			case 3u:
				return (object)(&obj);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_AB00(CancellationToken P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778800, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00가(CancellationToken P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778799, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00관(CancellationToken P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00ae: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got Ref
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_0079->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0064->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00b3->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0094->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0084->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0056->IL0019: Incompatible stack types: I4 vs Ref
		//IL_009f->IL0019: Incompatible stack heights: 2 vs 1
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
				case 2u:
					reference = ref obj;
					if (1 == 0)
					{
						reference = ref *(object*)1;
					}
					continue;
				case 1u:
					_ = ref obj;
					_ = 4;
					continue;
				case 5u:
					return (object)(&obj);
				default:
					_ = ref obj;
					_ = -1;
					if (0 == 0)
					{
						_ = 3;
					}
					continue;
				case 4u:
					_ = ref obj;
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 3u:
					break;
				}
				break;
			}
			_ = ref obj;
			_ = ref obj;
			obj = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00글(CancellationToken P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778798, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00꼀(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003d->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0048->IL0019: Incompatible stack heights: 4 vs 1
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
				_ = 2;
				_ = 5;
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
	private unsafe object _FF00_FF00_FF00뀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778797, new IntPtr(2737337584524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00넀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00섀(EnumStepPhase P_0, JavaStep P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778796, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00숀(EnumStepPhase P_0, JavaStep P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_00c6: Expected I4, but got Obj
		//IL_00fb: Expected Obj, but got I4
		//IL_0261: Expected Obj, but got Ref
		//IL_010c: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I4
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_0228->IL0019: Incompatible stack heights: 0 vs 1
		//IL_03e1->IL0019: Incompatible stack types: I4 vs Ref
		//IL_02fd->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0363->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0131->IL0019: Incompatible stack types: I4 vs Ref
		//IL_02a3->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0289->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01b1->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0326->IL0019: Incompatible stack types: I4 vs Ref
		//IL_01da->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0240->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0172->IL0019: Incompatible stack heights: 0 vs 1
		//IL_024d->IL0019: Incompatible stack types: I4 vs Ref
		//IL_026b->IL0019: Incompatible stack types: I4 vs Ref
		//IL_01f6->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0233->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0354->IL0019: Incompatible stack types: I4 vs Ref
		//IL_036e->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0294->IL0019: Incompatible stack types: I4 vs Ref
		//IL_01bc->IL0019: Incompatible stack heights: 3 vs 1
		//IL_03d4->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0216->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0390->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0163->IL0019: Incompatible stack types: I4 vs Ref
		//IL_017d->IL0019: Incompatible stack types: I4 vs Ref
		//IL_01cd->IL0019: Incompatible stack types: I4 vs Ref
		//IL_039b->IL0019: Incompatible stack types: I4 vs Ref
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 39;
		while (true)
		{
			ref object reference = ref *(object*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 39u:
					if (P_0 != EnumStepPhase.Download)
					{
						obj = 38;
						break;
					}
					goto case 28u;
				case 26u:
					obj = (object)/*Error near IL_00f2: Stack underflow*/;
					obj = 4;
					break;
				case 36u:
					goto IL_0100;
				case 9u:
					goto IL_0124;
				case 28u:
					switch (P_1)
					{
					case JavaStep.Components:
						break;
					case JavaStep.ServerResource:
						goto IL_0100;
					case JavaStep.BaseVersion:
						goto IL_0124;
					default:
						goto IL_0159;
					case JavaStep.CoreLib:
						goto IL_0163;
					case JavaStep.GameWindow:
						goto IL_019f;
					case JavaStep.Java:
						goto IL_0219;
					case JavaStep.GameProcess:
						goto IL_0319;
					case JavaStep.GameVersion:
						goto IL_0354;
					}
					goto case 26u;
				case 32u:
					goto IL_0163;
				case 14u:
					goto IL_019f;
				case 38u:
					if (P_0 != EnumStepPhase.Install)
					{
						reference = ref *(object*)37;
						continue;
					}
					goto case 24u;
				case 22u:
					obj = (object)/*Error near IL_01d0: Stack underflow*/;
					reference = ref *(object*)31;
					continue;
				case 40u:
					goto IL_01e9;
				case 25u:
				case 37u:
					if (P_1 != JavaStep.GameProcess)
					{
						reference = ref *(object*)27;
						continue;
					}
					goto IL_0319;
				case 4u:
				case 7u:
				case 8u:
				case 12u:
				case 13u:
				case 15u:
				case 17u:
				case 18u:
				case 20u:
				case 21u:
				case 29u:
				case 30u:
				case 31u:
				case 33u:
				case 41u:
					return obj;
				default:
					goto IL_0219;
				case 23u:
					goto IL_0233;
				case 34u:
					goto IL_0240;
				case 35u:
					obj = (object)(&obj);
					reference = ref *(object*)21;
					continue;
				case 11u:
					goto IL_027a;
				case 10u:
					_ = ref obj;
					_ = 35;
					continue;
				case 3u:
				case 6u:
				case 19u:
					obj = (object)/*Error near IL_02f3: Stack underflow*/;
					reference = ref *(object*)13;
					continue;
				case 16u:
					goto IL_0319;
				case 1u:
					reference = ref obj;
					if (10 == 0)
					{
						reference = ref *(object*)5;
					}
					continue;
				case 5u:
					goto IL_0354;
				case 27u:
					if (P_1 != JavaStep.GameWindow)
					{
						if (19 == 0)
						{
							reference = ref *(object*)15;
						}
						continue;
					}
					goto IL_019f;
				case 24u:
					switch (P_1)
					{
					case JavaStep.Java:
						break;
					case JavaStep.BaseVersion:
						goto IL_01e9;
					case JavaStep.GameVersion:
						goto IL_0233;
					case JavaStep.Components:
						goto IL_0240;
					case JavaStep.CoreLib:
						goto IL_027a;
					default:
						goto IL_03ca;
					case JavaStep.ServerResource:
						goto IL_03d4;
					}
					goto case 22u;
				case 2u:
					goto IL_03d4;
					IL_0319:
					obj = (object)/*Error near IL_031c: Stack underflow*/;
					reference = ref *(object*)7;
					continue;
					IL_0219:
					obj = (object)/*Error near IL_021c: Stack underflow*/;
					if (20 != 0)
					{
						reference = ref *(object*)null;
					}
					continue;
					IL_0124:
					obj = (object)/*Error near IL_0127: Stack underflow*/;
					reference = ref *(object*)15;
					continue;
					IL_019f:
					_ = ref obj;
					_ = 12;
					_ = 1;
					if (1 == 0)
					{
						_ = 1;
					}
					continue;
					IL_0100:
					obj = (object)/*Error near IL_0103: Stack underflow*/;
					obj = 8;
					break;
					IL_03d4:
					obj = (object)/*Error near IL_03d7: Stack underflow*/;
					reference = ref *(object*)30;
					continue;
					IL_03ca:
					reference = ref *(object*)25;
					continue;
					IL_027a:
					obj = (object)/*Error near IL_027d: Stack underflow*/;
					if (11 != 0)
					{
						reference = ref *(object*)12;
					}
					continue;
					IL_0163:
					obj = (object)/*Error near IL_0166: Stack underflow*/;
					if (18 != 0)
					{
						reference = ref *(object*)18;
					}
					continue;
					IL_0240:
					obj = (object)/*Error near IL_0243: Stack underflow*/;
					reference = ref *(object*)33;
					continue;
					IL_0233:
					obj = (object)/*Error near IL_0236: Stack underflow*/;
					reference = ref *(object*)17;
					continue;
					IL_01e9:
					obj = (object)/*Error near IL_01ec: Stack underflow*/;
					reference = ref *(object*)29;
					continue;
					IL_0354:
					obj = (object)/*Error near IL_0357: Stack underflow*/;
					if (33 == 0)
					{
						reference = ref *(object*)41;
					}
					continue;
					IL_0159:
					reference = ref *(object*)6;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00쌀(EnumStepPhase P_0, JavaStep P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778795, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00쐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778794, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00씀()
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
						obj2 = 1;
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
	private unsafe object _FF00_FF00_FF00였()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778793, new IntPtr(2737337594924L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00윀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4759, 1790778792, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778792, new IntPtr(2737337585564L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00저()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778791, new IntPtr(2737337583484L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00준(object P_0)
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
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00쨀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778790, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00촀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778789, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00츀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_00ad: Expected I4, but got Obj
		//IL_0063->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0044->IL0019: Incompatible stack heights: 0 vs 1
		//IL_008c->IL0090: Incompatible stack types: I4 vs Obj
		//IL_006e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0103->IL0090: Incompatible stack heights: 2 vs 1
		//IL_0130->IL0090: Incompatible stack heights: 3 vs 1
		//IL_011d->IL0090: Incompatible stack heights: 2 vs 1
		//IL_00c7->IL0090: Incompatible stack heights: 2 vs 1
		//IL_010e->IL0090: Incompatible stack heights: 2 vs 1
		//IL_00ee->IL0090: Incompatible stack types: I4 vs Obj
		//IL_00d2->IL0090: Incompatible stack heights: 2 vs 1
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
				if (2 == 0)
				{
					obj2 = 2;
				}
				break;
			case 1:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 4:
				return;
			default:
			{
				JavaGame javaGame = this;
				if (true)
				{
					javaGame = (JavaGame)4;
				}
				while (true)
				{
					switch ((int)javaGame)
					{
					case 5:
						if (false)
						{
							_ = 1;
						}
						continue;
					case 3:
						javaGame = this;
						if (2 != 0)
						{
							javaGame = (JavaGame)1;
						}
						continue;
					case 1:
						if (false)
						{
							_ = 0;
						}
						continue;
					case 4:
						_ = 3;
						continue;
					case 2:
						_ = 5;
						continue;
					}
					break;
				}
				goto case 3;
			}
			case 2:
			{
				int num = (((nint)this != 9) ? 1 : 0);
				if (0 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
				return;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00케()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778788, new IntPtr(2737337576204L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00퀀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4768, 1790778787, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778787, new IntPtr(2737337586604L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00턀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778786, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00툀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778785, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00팀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4771, 1790778784, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778784, new IntPtr(2737337582444L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00퐀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778719, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00픀(uint P_0)
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
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00혀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778718, new IntPtr(2737337583484L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00휀(nint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0043->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0061->IL0019: Incompatible stack heights: 4 vs 1
		//IL_004e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006c->IL0019: Incompatible stack heights: 4 vs 1
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
				_ = P_0 + 25;
				if (2 == 0)
				{
					_ = 2;
				}
				break;
			case 1:
				_ = 4;
				_ = 7;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FFFD()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778717, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0095->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00aa->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0064->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0079->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00b5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0084->IL0019: Incompatible stack types: I4 vs Obj
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
			case 4:
				obj = obj;
				if (2 != 0)
				{
					obj2 = 0;
				}
				break;
			case 5:
				obj = this;
				obj2 = 4;
				break;
			case 1:
				if (obj == obj)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 4;
			case 2:
				obj = P_0;
				_ = 3;
				break;
			case 3:
				obj = obj;
				if (1 == 0)
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
	private void _FF00_FF00_FF00_FFFD(object P_0)
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
	private unsafe void _FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778716, new IntPtr(2737337584524L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FFFD(JavaStep P_0, object P_1, object P_2, object P_3, object P_4, object P_5, CancellationToken P_6, object P_7, object P_8)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778715, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FFFD(JavaStep P_0, object P_1, object P_2, object P_3, object P_4, object P_5, CancellationToken P_6, object P_7, object P_8)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0056: Expected I4, but got Obj
		//IL_0060: Expected Obj, but got Ref
		//IL_011a: Expected Obj, but got I4
		//IL_006f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00ff->IL0019: Incompatible stack heights: 3 vs 1
		//IL_008c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_010d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_009c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_013e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00e5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d4->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00bb->IL0019: Incompatible stack heights: 2 vs 1
		//IL_012d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ab->IL0019: Incompatible stack heights: 3 vs 1
		//IL_011f->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0149->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00f0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c6->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 10;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 12:
					return (object)(&obj);
				default:
					_ = ref obj;
					_ = 13;
					continue;
				case 6:
					_ = ref obj;
					_ = 3;
					continue;
				case 2:
					_ = ref obj;
					_ = 5;
					continue;
				case 4:
					_ = ref obj;
					_ = ref obj;
					_ = 12;
					continue;
				case 11:
					_ = ref obj;
					_ = 7;
					continue;
				case 9:
					_ = ref obj;
					if (7 != 0)
					{
						_ = 8;
					}
					continue;
				case 8:
					_ = ref obj;
					_ = 6;
					continue;
				case 7:
					_ = ref obj;
					if (false)
					{
						_ = 0;
					}
					continue;
				case 1:
					_ = ref obj;
					_ = 11;
					continue;
				case 3:
					_ = ref obj;
					_ = 2;
					continue;
				case 13:
					break;
				case 10:
					_ = ref obj;
					_ = 9;
					continue;
				case 5:
					_ = ref obj;
					if (true)
					{
						_ = 1;
					}
					continue;
				}
				break;
			}
			_ = ref obj;
			_ = -1;
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FFFD(JavaStep P_0, object P_1, object P_2, object P_3, object P_4, object P_5, CancellationToken P_6, object P_7, object P_8)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778714, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_E000(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4784, 1790778713, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790778713, new IntPtr(2737337588684L), 15);
		}
		return ((delegate*<object, object, object, object>)obj)(this, P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_E100(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778712, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00_E200()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_E400()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		//IL_00fb->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00e6->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0106->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0068->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0118->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0088->IL00b1: Incompatible stack heights: 1 vs 0
		//IL_00a6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0092->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b1->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 8;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				if (3 == 0)
				{
					_ = 5;
				}
				break;
			default:
				throw /*Error near IL_007a: Stack underflow*/;
			case 7:
				return;
			case 4:
				return;
			case 2:
				if (1 == 0)
				{
					_ = 0;
				}
				break;
			case 6:
				return;
			case 5:
				_ = 6;
				break;
			case 1:
				if (3 == 0)
				{
					_ = 0;
				}
				break;
			case 8:
				if ((nint)this != 2)
				{
					obj2 = 7;
				}
				else if (this != null)
				{
					if (this != null)
					{
						return;
					}
					_ = 2;
				}
				else if (false)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_E500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778711, new IntPtr(2737337576204L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_E600()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_E700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778710, new IntPtr(2737337584524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_E800(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003e->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 4 vs 1
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
				_ = 1;
				_ = 1;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_E900(object P_0, object P_1)
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
	internal unsafe void _FF00_FF00_FF00_F100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778709, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_F200()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_006a: Expected I4, but got Obj
		//IL_0298: Expected I4, but got Obj
		//IL_0358: Expected I4, but got Obj
		//IL_0417: Expected I4, but got Obj
		//IL_05db: Expected I4, but got Obj
		//IL_0096->IL0019: Incompatible stack heights: 3 vs 1
		//IL_007e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_04a7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_059e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_015d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_03e5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0326->IL0019: Incompatible stack heights: 3 vs 1
		//IL_025b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0582->IL0019: Incompatible stack types: I4 vs Obj
		//IL_058f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0089->IL0019: Incompatible stack heights: 2 vs 1
		//IL_027c->IL028b: Incompatible stack heights: 0 vs 1
		//IL_04b2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_05a9->IL0019: Incompatible stack heights: 2 vs 1
		//IL_033c->IL034b: Incompatible stack heights: 0 vs 1
		//IL_0168->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0241->IL0019: Incompatible stack heights: 0 vs 1
		//IL_03fb->IL040a: Incompatible stack heights: 0 vs 1
		//IL_05bf->IL05ce: Incompatible stack heights: 0 vs 1
		//IL_0266->IL0019: Incompatible stack heights: 2 vs 1
		//IL_04d8->IL04dc: Incompatible stack heights: 1 vs 0
		//IL_0500->IL04dc: Incompatible stack heights: 1 vs 0
		//IL_02ba->IL028b: Incompatible stack types: I4 vs Obj
		//IL_0287->IL028b: Incompatible stack types: I4 vs Obj
		//IL_037a->IL034b: Incompatible stack types: I4 vs Obj
		//IL_0347->IL034b: Incompatible stack types: I4 vs Obj
		//IL_024c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0439->IL040a: Incompatible stack types: I4 vs Obj
		//IL_0406->IL040a: Incompatible stack types: I4 vs Obj
		//IL_00bc->IL00c0: Incompatible stack heights: 1 vs 0
		//IL_00e4->IL00c0: Incompatible stack heights: 1 vs 0
		//IL_05fd->IL05ce: Incompatible stack types: I4 vs Obj
		//IL_05ca->IL05ce: Incompatible stack types: I4 vs Obj
		//IL_018f->IL0193: Incompatible stack heights: 1 vs 0
		//IL_01b7->IL0193: Incompatible stack heights: 1 vs 0
		//IL_050b->IL04dc: Incompatible stack heights: 1 vs 0
		//IL_00ef->IL00c0: Incompatible stack heights: 1 vs 0
		//IL_01c2->IL0193: Incompatible stack heights: 1 vs 0
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 10;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				_ = null;
				if (8 == 0)
				{
					_ = 2;
				}
				continue;
			case 1:
				_ = 0;
				_ = 18;
				continue;
			case 12:
				if (this == null)
				{
					if (1 == 0)
					{
						_ = 1;
					}
				}
				else if (false)
				{
					_ = 0;
				}
				switch ((int)/*Error near IL_00cd: Stack underflow*/)
				{
				}
				goto case 2;
			case 7:
				_ = null;
				if (2 == 0)
				{
					_ = 14;
				}
				continue;
			case 11:
				return;
			case 14:
				if (this == null)
				{
					if (false)
					{
						_ = 0;
					}
				}
				else if (false)
				{
					_ = 1;
				}
				switch ((int)/*Error near IL_01a0: Stack underflow*/)
				{
				}
				break;
			case 9:
				if (this == null)
				{
					if (2 == 0)
					{
						obj2 = 6;
					}
					continue;
				}
				goto case 17;
			case 16:
				_ = null;
				if (0 == 0)
				{
					_ = 0;
				}
				continue;
			case 3:
			{
				JavaGame javaGame2 = this;
				if (javaGame2 == null)
				{
					if (1 == 0)
					{
						javaGame2 = (JavaGame)1;
					}
				}
				else if (false)
				{
					javaGame2 = (JavaGame)0;
				}
				switch ((int)javaGame2)
				{
				}
				goto case 15;
			}
			case 15:
				_ = null;
				_ = 13;
				continue;
			case 6:
			{
				JavaGame javaGame3 = this;
				if (javaGame3 == null)
				{
					if (false)
					{
						javaGame3 = (JavaGame)0;
					}
				}
				else if (0 == 0)
				{
					javaGame3 = (JavaGame)1;
				}
				switch ((int)javaGame3)
				{
				}
				goto case 17;
			}
			case 8:
				_ = 11;
				continue;
			case 10:
			{
				JavaGame javaGame4 = this;
				if (javaGame4 == null)
				{
					if (true)
					{
						javaGame4 = (JavaGame)0;
					}
				}
				else if (0 == 0)
				{
					javaGame4 = (JavaGame)0;
				}
				switch ((int)javaGame4)
				{
				}
				goto case 9;
			}
			case 4:
				_ = null;
				if (6 == 0)
				{
					_ = 12;
				}
				continue;
			default:
				if (this == null)
				{
					if (0 == 0)
					{
						_ = 0;
					}
				}
				else if (1 == 0)
				{
					_ = 1;
				}
				switch ((int)/*Error near IL_04e9: Stack underflow*/)
				{
				}
				goto case 7;
			case 17:
				obj2 = 3;
				continue;
			case 18:
				_ = 0;
				_ = 4;
				continue;
			case 5:
				break;
			case 13:
			{
				JavaGame javaGame = this;
				if (javaGame == null)
				{
					if (false)
					{
						javaGame = (JavaGame)0;
					}
				}
				else if (1 == 0)
				{
					javaGame = (JavaGame)1;
				}
				switch ((int)javaGame)
				{
				}
				goto case 16;
			}
			}
			_ = null;
			if (0 == 0)
			{
				_ = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_F300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778708, new IntPtr(2737337578284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_F400(CancellationToken P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0093: Expected Obj, but got Ref
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_00a1->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00af->IL0019: Incompatible stack heights: 3 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0068->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008e->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0073->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			case 4u:
				_ = ref obj;
				if (3 != 0)
				{
					_ = 1;
				}
				break;
			case 5u:
				_ = ref obj;
				_ = ref obj;
				if (2 != 0)
				{
					_ = 2;
				}
				break;
			case 1u:
				reference = ref obj;
				if (0 == 0)
				{
					reference = ref *(object*)null;
				}
				break;
			case 2u:
				return (object)(&obj);
			default:
				_ = ref obj;
				_ = 4;
				break;
			case 3u:
				_ = ref obj;
				_ = -1;
				_ = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_F500(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778707, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_F600(byte P_0)
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
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_F700(JavaStep P_0)
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
	private unsafe void _FF00_FF00_FF00切()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778706, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00ﬀ()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0052: Expected I4, but got Obj
		//IL_00d6: Expected Obj, but got Ref
		//IL_01cf->IL0019: Incompatible stack heights: 2 vs 1
		//IL_022d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01a0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01ec->IL0019: Incompatible stack heights: 2 vs 1
		//IL_017f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02a8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01da->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0238->IL0019: Incompatible stack types: I4 vs Obj
		//IL_020d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01ab->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0249->IL0019: Incompatible stack types: I4 vs Obj
		//IL_018a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0122->IL006b: Incompatible stack heights: 1 vs 0
		//IL_00ed->IL006b: Incompatible stack heights: 1 vs 0
		//IL_028c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0105->IL006b: Incompatible stack heights: 3 vs 0
		//IL_00b5->IL006b: Incompatible stack heights: 3 vs 0
		//IL_0110->IL006b: Incompatible stack heights: 3 vs 0
		//IL_00a3->IL006b: Incompatible stack heights: 1 vs 0
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
				while (true)
				{
					IL_0110:
					if (&obj == null)
					{
						_ = 2;
						goto IL_006b;
					}
					goto IL_00d1;
					IL_006b:
					while (true)
					{
						switch ((int)/*Error near IL_008c: Stack underflow*/)
						{
						case 1:
							if (obj != null)
							{
								_ = 4;
								continue;
							}
							goto default;
						case 4:
							_ = 5;
							continue;
						case 6:
							break;
						default:
							if (true)
							{
								_ = 3;
							}
							continue;
						case 3:
						case 5:
							goto IL_0110;
						case 2:
							goto end_IL_0110;
						}
						break;
					}
					goto IL_00d1;
					IL_00d1:
					obj = (object)(&obj);
					if (true)
					{
						_ = 1;
					}
					goto IL_006b;
					continue;
					end_IL_0110:
					break;
				}
				goto case 9;
			case 3:
				if (this != null)
				{
					if (2 == 0)
					{
						obj2 = 1;
					}
					continue;
				}
				goto case 8;
			case 10:
				if (1 == 0)
				{
					_ = 0;
				}
				continue;
			case 12:
				return;
			case 6:
				if (4 != 0)
				{
					_ = 4;
				}
				continue;
			case 8:
				throw /*Error near IL_01dd: Stack underflow*/;
			case 2:
				_ = 7;
				continue;
			case 9:
				obj2 = this;
				obj = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				continue;
			case 7:
				obj = this;
				if (0 == 0)
				{
					obj2 = 5;
				}
				continue;
			case 11:
				if (obj == null)
				{
					obj2 = 12;
					continue;
				}
				goto case 10;
			case 1:
				return;
			case 4:
				obj = ((object)this) ?? ((object)/*Error near IL_0299: Stack underflow*/);
				obj2 = 11;
				continue;
			}
			obj2 = ((object)this) ?? ((object)/*Error near IL_025c: Stack underflow*/);
			if (obj2 == null)
			{
				obj2 = (object)/*Error near IL_026a: Stack underflow*/;
			}
			obj = obj;
			if (3 == 0)
			{
				obj2 = 6;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00ﰀ(CancellationToken P_0)
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
		//IL_009f->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0076->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			default:
				_ = ref obj;
				if (2 == 0)
				{
					_ = 2;
				}
				break;
			case 4u:
				return (object)(&obj);
			case 2u:
				_ = ref obj;
				if (3 == 0)
				{
					_ = 3;
				}
				break;
			case 3u:
				_ = ref obj;
				_ = -1;
				_ = 5;
				break;
			case 1u:
				reference = ref obj;
				if (0 == 0)
				{
					reference = ref *(object*)null;
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
	private void _FF00_FF00_FF00_FE00()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0058: Expected I4, but got Obj
		//IL_004b->IL004f: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 1:
		{
			JavaGame javaGame = this;
			if (0 == 0)
			{
				javaGame = (JavaGame)0;
			}
			switch ((int)javaGame)
			{
			case 0:
				break;
			}
			break;
		}
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778705, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00Ȁ(EnumStepPhase P_0, JavaStep P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778704, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00_FF00_0300(EnumStepPhase P_0, JavaStep P_1, object P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0096: Expected Obj, but got I4
		//IL_0083->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ad->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00ce->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0058->IL0019: Incompatible stack types: I4 vs Obj
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
				if (P_0 != EnumStepPhase.Error)
				{
					if (4 != 0)
					{
						obj2 = 4;
					}
					break;
				}
				goto default;
			default:
				obj = P_2;
				if (2 == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				obj = P_1;
				if (false)
				{
					_ = 1;
				}
				break;
			case 1:
			case 2:
				return obj;
			case 4:
				if (P_0 == EnumStepPhase.Complete)
				{
					if (false)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00Ѐ()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_00a9: Expected Obj, but got I4
		//IL_00ae->IL0015: Incompatible stack heights: 12 vs 0
		//IL_007b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00dc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c2->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0052->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0086->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00cd->IL0019: Incompatible stack heights: 4 vs 1
		//IL_005d->IL0019: Incompatible stack types: I4 vs Obj
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
					if (this != null)
					{
						if (0 == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					return;
				case 5:
					_ = 1;
					if (2 == 0)
					{
						_ = 0;
					}
					continue;
				case 2:
					break;
				case 4:
					return;
				default:
					_ = 4;
					_ = 8;
					_ = 99;
					if (6 == 0)
					{
						_ = 4;
					}
					continue;
				case 3:
					return;
				case 6:
					obj2 = 5;
					continue;
				}
				break;
			}
			_ = 5;
			_ = 8;
			_ = 0;
			_ = ref obj;
			_ = 7;
			_ = 1;
			_ = ref obj;
			_ = ref obj;
			_ = ref obj;
			_ = ref obj;
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00_FF00_0600()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_0700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778703, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00ࠀ(EnumStepPhase P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778702, new IntPtr(2737337579324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_0900(EnumStepPhase P_0)
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
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_0A00(EnumStepPhase P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778701, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_0B00(CancellationToken P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778700, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_0C00(CancellationToken P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_008e: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got Ref
		//IL_00a8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0076->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0093->IL0015: Incompatible stack heights: 1 vs 0
		//IL_005b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0081->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
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
				case 1:
					_ = ref obj;
					_ = -1;
					_ = 5;
					continue;
				case 5:
					_ = ref obj;
					_ = ref obj;
					if (0 == 0)
					{
						_ = 4;
					}
					continue;
				case 2:
					_ = ref obj;
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 3:
					break;
				case 4:
					return (object)(&obj);
				default:
					_ = ref obj;
					if (0 == 0)
					{
						_ = 1;
					}
					continue;
				}
				break;
			}
			_ = ref obj;
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_0D00(CancellationToken P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778699, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_0E00()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0062->IL0019: Incompatible stack types: I4 vs Obj
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
	internal unsafe void _FF00_FF00_FF00_FF00ༀ(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778698, new IntPtr(2737337576204L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00က(byte P_0)
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
	internal void _FF00_FF00_FF00_FF00ᄀ(List<ComponentPath> P_0)
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
	private unsafe void _FF00_FF00_FF00_FF00ሀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778697, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00ጀ(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003d->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0048->IL0019: Incompatible stack heights: 4 vs 1
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
				_ = 1;
				_ = 5;
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
	private unsafe void _FF00_FF00_FF00_FF00_1400(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778696, new IntPtr(2737337579324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00ᔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778695, new IntPtr(2737337594924L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00ᘀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00ᜀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778694, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_1800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778693, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00_FF00ᤀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00ᨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778692, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00_1B00()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00ᰀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778691, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00ᴀ()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_2500(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_006e: Expected I4, but got Obj
		//IL_036c: Expected Obj, but got I4
		//IL_0316: Expected Obj, but got I4
		//IL_020e: Expected Obj, but got I4
		//IL_014c: Expected I4, but got Obj
		//IL_038d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0102->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00d5->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0111->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0082->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c8->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00e7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0371->IL0015: Incompatible stack heights: 4 vs 0
		//IL_035d->IL0019: Incompatible stack heights: 13 vs 1
		//IL_00a9->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0099->IL0019: Incompatible stack heights: 2 vs 1
		//IL_012b->IL012f: Incompatible stack types: I4 vs Obj
		//IL_031b->IL0015: Incompatible stack heights: 2 vs 0
		//IL_03a6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03b6->IL0019: Incompatible stack heights: 3 vs 1
		//IL_032e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_011c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ba->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00f2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_03c8->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0339->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0268->IL012f: Incompatible stack heights: 2 vs 1
		//IL_0236->IL012f: Incompatible stack heights: 6 vs 1
		//IL_021a->IL012f: Incompatible stack heights: 0 vs 1
		//IL_03d3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_016e->IL0172: Incompatible stack types: I4 vs Ref
		//IL_0273->IL012f: Incompatible stack heights: 2 vs 1
		//IL_0252->IL012f: Incompatible stack types: I4 vs Obj
		//IL_0225->IL012f: Incompatible stack types: I4 vs Obj
		//IL_0195->IL0172: Incompatible stack heights: 1 vs 2
		//IL_01a0->IL0172: Incompatible stack heights: 1 vs 2
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
				case 7:
					if (18 != 0)
					{
						obj2 = 17;
					}
					continue;
				case 16:
					_ = 9;
					continue;
				case 15:
					_ = 4;
					continue;
				case 9:
					if (this != null)
					{
						obj2 = 8;
						continue;
					}
					goto case 2;
				case 17:
					return;
				case 10:
					_ = 0;
					_ = 12;
					continue;
				case 5:
					_ = 1;
					_ = 3;
					continue;
				case 11:
					if (true)
					{
						_ = 0;
					}
					continue;
				case 4:
					_ = 11;
					continue;
				case 6:
					_ = 1;
					if (5 != 0)
					{
						_ = 4;
					}
					continue;
				case 18:
				{
					obj = this;
					object obj3 = 5;
					while (true)
					{
						switch ((int)obj3)
						{
						case 3:
							return;
						default:
						{
							ref object reference = ref obj;
							if (1 == 0)
							{
								reference = ref *(object*)null;
							}
							while (true)
							{
								switch ((uint)Unsafe.AsPointer(ref reference))
								{
								case 1u:
									obj = this;
									if (0 == 0)
									{
										_ = 0;
									}
									continue;
								}
								break;
							}
							break;
						}
						case 5:
							obj = 0;
							if (0 == 0)
							{
								obj3 = 0;
							}
							continue;
						case 2:
							_ = 0;
							_ = 7;
							_ = 0;
							_ = 3;
							continue;
						case 4:
							obj3 = obj;
							if (2 == 0)
							{
								obj3 = 2;
							}
							continue;
						case 1:
							break;
						}
						obj = this;
						if (4 == 0)
						{
							_ = 4;
						}
					}
				}
				case 2:
					if (this == null)
					{
						goto case 13;
					}
					goto case 8;
				case 19:
					obj = 15;
					break;
				case 3:
					if (this == null)
					{
						if (false)
						{
							obj2 = 0;
						}
					}
					else
					{
						_ = 19;
					}
					continue;
				case 13:
					_ = 5;
					_ = 7;
					_ = 0;
					_ = ref obj;
					_ = 7;
					_ = 1;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 17;
					continue;
				case 12:
					_ = 0;
					_ = 7;
					_ = 0;
					obj = 7;
					break;
				case 1:
					_ = 16;
					continue;
				default:
					obj2 = this;
					if (14 != 0)
					{
						obj2 = 9;
					}
					continue;
				case 14:
					return;
				case 8:
					if (10 == 0)
					{
						obj2 = 8;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_2600(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778690, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_2700(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_007a: Expected Obj, but got I4
		//IL_0094->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ad->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0050->IL0019: Incompatible stack heights: 0 vs 1
		//IL_009f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005b->IL0019: Incompatible stack types: I4 vs Obj
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
				case 1:
					if (obj == obj)
					{
						if (0 == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					break;
				case 3:
					obj = P_0;
					_ = 2;
					continue;
				case 0:
					return;
				case 4:
					break;
				case 2:
					obj = obj;
					if (1 == 0)
					{
						_ = 1;
					}
					continue;
				case 5:
					obj = this;
					obj2 = 4;
					continue;
				}
				break;
			}
			obj = obj;
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_2800(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778689, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_2900(object P_0)
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
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00_FF00_2A00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_2B00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778688, new IntPtr(2737337578284L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00_FF00_FF00Ⰰ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00ⴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778751, new IntPtr(2737337577244L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_2E00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778750, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_2F00()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4862, 1790778749, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778749, new IntPtr(2737337590764L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_3000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778748, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_3100(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003e->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 4 vs 1
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
				_ = 2;
				_ = 1;
				if (false)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_3300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778747, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00㐀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0044->IL0019: Incompatible stack heights: 0 vs 1
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
				if (32 == 0)
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
			case 2:
				break;
			}
			break;
		}
		throw /*Error near IL_006e: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00㔀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778746, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<ulong> _FF00_FF00_FF00_FF00㘀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (List<ulong>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<ulong> _FF00_FF00_FF00_FF00㜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778745, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		return (List<ulong>)/*Error near IL_0033: Stack underflow*/;
	}
}
