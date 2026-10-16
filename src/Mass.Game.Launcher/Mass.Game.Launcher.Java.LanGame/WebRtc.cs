using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Mass.Application.Desktop;
using Mass.Common.Extensions;
using Mass.Game.Launcher.Entities;
using Serilog;

namespace Mass.Game.Launcher.Java.LanGame;

public class WebRtc : IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CConnectSignalServerAsync_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public WebRtc _003C_003E4__this;

		private object _003Ccts_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private static object DecorateExternalDistributor;

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
		internal static bool ReflectOperationalNotifier()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckVirtualDispatcher()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00樀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777430, new IntPtr(2737367918204L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00欀(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00氀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00洀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777429, new IntPtr(2737367918204L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00焀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_0043: Expected Obj, but got Ref
			//IL_0079: Expected Obj, but got Ref
			//IL_0082: Expected Obj, but got I4
			//IL_01ac: Expected Obj, but got Ref
			//IL_01f2: Expected Obj, but got Ref
			//IL_03a7: Expected Obj, but got I4
			//IL_0242: Expected Obj, but got I4
			//IL_020f: Expected Obj, but got I4
			//IL_02a1: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_00af->IL0019: Incompatible stack heights: 3 vs 1
			//IL_004f->IL0019: Incompatible stack heights: 0 vs 1
			//IL_006a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00c2->IL00c6: Incompatible stack heights: 1 vs 0
			//IL_005a->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00a1->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0075->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0118->IL00c6: Incompatible stack heights: 1 vs 0
			//IL_00f5->IL00c6: Incompatible stack heights: 2 vs 0
			//IL_012a->IL012e: Incompatible stack heights: 1 vs 0
			//IL_0100->IL00c6: Incompatible stack heights: 2 vs 0
			//IL_01c3->IL012e: Incompatible stack heights: 1 vs 0
			//IL_034c->IL012e: Incompatible stack heights: 1 vs 0
			//IL_0318->IL012e: Incompatible stack heights: 2 vs 0
			//IL_01fc->IL012e: Incompatible stack heights: 1 vs 0
			//IL_03b2->IL012e: Incompatible stack heights: 3 vs 0
			//IL_01e0->IL012e: Incompatible stack heights: 4 vs 0
			//IL_024d->IL012e: Incompatible stack heights: 3 vs 0
			//IL_021a->IL012e: Incompatible stack heights: 3 vs 0
			//IL_01d0->IL012e: Incompatible stack heights: 2 vs 0
			//IL_037d->IL012e: Incompatible stack heights: 2 vs 0
			//IL_03c2->IL012e: Incompatible stack heights: 4 vs 0
			//IL_02ac->IL012e: Incompatible stack heights: 3 vs 0
			//IL_0395->IL012e: Incompatible stack heights: 2 vs 0
			//IL_025d->IL012e: Incompatible stack heights: 2 vs 0
			//IL_03a2->IL012e: Incompatible stack heights: 2 vs 0
			//IL_020a->IL012e: Incompatible stack heights: 3 vs 0
			//IL_01ee->IL012e: Incompatible stack heights: 2 vs 0
			//IL_02bb->IL012e: Incompatible stack heights: 1 vs 0
			//IL_0232->IL012e: Incompatible stack heights: 1 vs 0
			//IL_0323->IL012e: Incompatible stack heights: 2 vs 0
			//IL_0388->IL012e: Incompatible stack heights: 2 vs 0
			//IL_029c->IL012e: Incompatible stack heights: 1 vs 0
			//IL_02e1->IL012e: Incompatible stack heights: 1 vs 0
			//IL_02c6->IL012e: Incompatible stack heights: 1 vs 0
			//IL_036d->IL012e: Incompatible stack heights: 1 vs 0
			//IL_023d->IL012e: Incompatible stack heights: 1 vs 0
			//IL_027e->IL012e: Incompatible stack heights: 1 vs 0
			//IL_0300->IL012e: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			while (true)
			{
				ref _003CConnectSignalServerAsync_003Ed__31 reference = ref *(_003CConnectSignalServerAsync_003Ed__31*)obj;
				while (true)
				{
					switch ((uint)Unsafe.AsPointer(ref reference))
					{
					case 2u:
						obj = (object)Unsafe.AsPointer(ref this);
						if (true)
						{
							reference = ref *(_003CConnectSignalServerAsync_003Ed__31*)1;
						}
						continue;
					case 5u:
						return;
					case 6u:
						_ = null;
						if (4 == 0)
						{
							_ = 3;
						}
						continue;
					case 3u:
						goto end_IL_0019;
					case 4u:
						reference = ref this;
						if (5 != 0)
						{
							reference = ref *(_003CConnectSignalServerAsync_003Ed__31*)null;
						}
						continue;
					case 1u:
						{
							if ((nuint)(nint)obj > (nuint)1u)
							{
								_ = 2;
								goto IL_00c6;
							}
							goto IL_0100;
						}
						IL_012e:
						while (true)
						{
							switch ((int)/*Error near IL_01a3: Stack underflow*/)
							{
							case 7:
								return;
							case 21:
								return;
							case 3:
								goto end_IL_012e;
							case 11:
							case 17:
								_ = ref obj;
								_ = 4;
								continue;
							case 8:
								_ = ref obj;
								_ = 21;
								continue;
							case 23:
								_ = 26;
								continue;
							case 5:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 19;
								continue;
							case 20:
								_ = 8;
								continue;
							case 10:
								obj = 1;
								_ = 12;
								continue;
							case 26:
								obj = obj;
								if (2 == 0)
								{
									_ = 0;
								}
								continue;
							case 9:
								obj = 0;
								_ = 20;
								continue;
							case 18:
								_ = 22;
								continue;
							case 27:
								if ((nint)obj != 1)
								{
									_ = 23;
									continue;
								}
								goto case 5;
							case 16:
								obj = obj;
								if (25 != 0)
								{
									_ = 8;
								}
								continue;
							case 14:
								obj = -1;
								_ = 11;
								continue;
							case 24:
								if (6 == 0)
								{
									_ = 6;
								}
								continue;
							case 22:
								if (true)
								{
									_ = 1;
								}
								continue;
							case 2:
								if (&obj == null)
								{
									if (9 == 0)
									{
										_ = 1;
									}
									continue;
								}
								goto case 15;
							case 4:
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							case 1:
								_ = 16;
								continue;
							case 25:
								if (&obj != null)
								{
									_ = 17;
									continue;
								}
								goto case 10;
							case 12:
								if (13 == 0)
								{
									_ = 11;
								}
								continue;
							case 15:
								_ = ref obj;
								_ = 18;
								continue;
							case 19:
								_ = 14;
								continue;
							case 6:
								obj = -1;
								_ = 15;
								continue;
							case 13:
								_ = ref obj;
								_ = 7;
								continue;
							}
							goto end_IL_0019_2;
							continue;
							end_IL_012e:
							break;
						}
						goto IL_01a8;
						IL_0100:
						if (0 == 0)
						{
							_ = 1;
						}
						goto IL_00c6;
						IL_00c6:
						while (true)
						{
							switch ((int)/*Error near IL_00d7: Stack underflow*/)
							{
							case 2:
								_ = 10.0;
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							case 1:
								goto IL_0118;
							}
							break;
						}
						goto IL_0100;
						IL_0118:
						if (obj != null)
						{
							_ = 27;
							goto IL_012e;
						}
						goto IL_01a8;
						IL_01a8:
						obj = (object)Unsafe.AsPointer(ref this);
						if (23 == 0)
						{
							_ = 24;
						}
						goto IL_012e;
						end_IL_0019_2:
						break;
					}
					_ = -2;
					_ = 6;
					continue;
					end_IL_0019:
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
				obj = 2;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00爀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777428, new IntPtr(2737367918204L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00猀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777427, new IntPtr(2737367918204L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00琀()
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
	private struct _003CReceiveAsync_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public WebRtc _003C_003E4__this;

		private object _003Cbuffer_003E5__2;

		private object _003Cms_003E5__3;

		private TaskAwaiter<WebSocketReceiveResult> _003C_003Eu__1;

		internal static object ReflectIdentifiableSingleton;

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
		internal static bool InterruptClient()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectCustomizableState()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00嘀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777426, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00圀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00堀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777425, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00夀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00娀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777424, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00最()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_003e: Expected I4, but got Obj
			//IL_0070: Expected Obj, but got Ref
			//IL_0048: Expected Obj, but got Ref
			//IL_04e2: Expected Obj, but got Ref
			//IL_04eb: Expected Obj, but got I4
			//IL_01f1: Expected Obj, but got Ref
			//IL_02b5: Expected Obj, but got Ref
			//IL_02a5: Expected Obj, but got I4
			//IL_04ff: Expected Obj, but got I4
			//IL_0617: Expected Obj, but got I4
			//IL_05d3: Expected Obj, but got I4
			//IL_0296: Expected Obj, but got Ref
			//IL_05ff: Expected Obj, but got I4
			//IL_0061->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0799->IL0019: Incompatible stack heights: 2 vs 1
			//IL_007c->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0052->IL0019: Incompatible stack types: I4 vs Obj
			//IL_07b6->IL0019: Incompatible stack heights: 2 vs 1
			//IL_07a7->IL0019: Incompatible stack heights: 3 vs 1
			//IL_006c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0087->IL0019: Incompatible stack types: I4 vs Obj
			//IL_07c1->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0114->IL00aa: Incompatible stack heights: 1 vs 0
			//IL_00a6->IL00aa: Incompatible stack heights: 1 vs 0
			//IL_012a->IL00aa: Incompatible stack heights: 3 vs 0
			//IL_00f1->IL00aa: Incompatible stack heights: 1 vs 0
			//IL_0147->IL014b: Incompatible stack types: I4 vs Ref
			//IL_0135->IL00aa: Incompatible stack heights: 3 vs 0
			//IL_00fc->IL00aa: Incompatible stack heights: 1 vs 0
			//IL_00e2->IL00aa: Incompatible stack heights: 1 vs 0
			//IL_014b->IL014b: Incompatible stack heights: 2 vs 1
			//IL_04c5->IL014b: Incompatible stack heights: 2 vs 1
			//IL_034a->IL014b: Incompatible stack heights: 3 vs 1
			//IL_01fd->IL014b: Incompatible stack heights: 0 vs 1
			//IL_035c->IL0360: Incompatible stack types: I4 vs Ref
			//IL_0567->IL014b: Incompatible stack heights: 2 vs 1
			//IL_02c1->IL014b: Incompatible stack heights: 0 vs 1
			//IL_0537->IL014b: Incompatible stack types: Obj vs Ref
			//IL_02b0->IL014b: Incompatible stack heights: 3 vs 1
			//IL_0504->IL0147: Incompatible stack heights: 3 vs 1
			//IL_0612->IL014b: Incompatible stack heights: 3 vs 1
			//IL_0622->IL014b: Incompatible stack heights: 3 vs 1
			//IL_05dd->IL014b: Incompatible stack heights: 2 vs 1
			//IL_02a0->IL014b: Incompatible stack heights: 2 vs 1
			//IL_0288->IL014b: Incompatible stack types: I4 vs Ref
			//IL_0222->IL014b: Incompatible stack heights: 4 vs 1
			//IL_030b->IL014b: Incompatible stack types: I4 vs Ref
			//IL_0208->IL014b: Incompatible stack types: I4 vs Ref
			//IL_04d7->IL014b: Incompatible stack types: I4 vs Ref
			//IL_0586->IL014b: Incompatible stack types: I4 vs Ref
			//IL_051a->IL014b: Incompatible stack heights: 0 vs 1
			//IL_02f9->IL014b: Incompatible stack types: I4 vs Ref
			//IL_0572->IL014b: Incompatible stack heights: 2 vs 1
			//IL_02cc->IL014b: Incompatible stack types: I4 vs Ref
			//IL_0556->IL014b: Incompatible stack types: I4 vs Ref
			//IL_0542->IL014b: Incompatible stack types: I4 vs Ref
			//IL_0604->IL0147: Incompatible stack heights: 0 vs 1
			//IL_04b7->IL014b: Incompatible stack types: I4 vs Ref
			//IL_0320->IL014b: Incompatible stack heights: 0 vs 1
			//IL_022d->IL014b: Incompatible stack heights: 4 vs 1
			//IL_03bb->IL0360: Incompatible stack heights: 4 vs 3
			//IL_0525->IL014b: Incompatible stack types: I4 vs Ref
			//IL_0252->IL014b: Incompatible stack heights: 0 vs 1
			//IL_032b->IL014b: Incompatible stack types: I4 vs Ref
			//IL_03e1->IL0360: Incompatible stack heights: 2 vs 3
			//IL_03c6->IL0360: Incompatible stack heights: 4 vs 3
			//IL_03a4->IL0360: Incompatible stack types: I4 vs Ref
			//IL_025d->IL014b: Incompatible stack types: I4 vs Ref
			//IL_0683->IL014b: Incompatible stack heights: 3 vs 1
			//IL_03ec->IL0360: Incompatible stack heights: 2 vs 3
			//IL_03fe->IL0360: Incompatible stack types: Obj vs Ref
			//IL_0409->IL0360: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				ref _003CReceiveAsync_003Ed__35 reference;
				switch ((int)obj2)
				{
				case 6:
					return;
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 2;
					break;
				default:
					_ = null;
					if (1 == 0)
					{
						_ = 1;
					}
					break;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (5 == 0)
					{
						obj2 = 2;
					}
					break;
				case 5:
					if (obj != null)
					{
						if (1 == 0)
						{
							_ = 4;
						}
						goto IL_00aa;
					}
					goto IL_00fc;
				case 1:
					_ = 6;
					break;
				case 7:
					goto IL_0799;
				case 4:
					{
						_ = null;
						if (false)
						{
							_ = 0;
						}
						break;
					}
					IL_014b:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 15u:
							return;
						case 6u:
						case 16u:
							obj = (object)Unsafe.AsPointer(ref this);
							if (12 == 0)
							{
								reference = ref *(_003CReceiveAsync_003Ed__35*)12;
							}
							continue;
						case 13u:
							throw ref obj;
						case 1u:
							_ = 0;
							if (8 == 0)
							{
								_ = 1;
							}
							continue;
						case 30u:
							throw /*Error near IL_023e: Stack underflow*/;
						case 37u:
							reference = ref *(_003CReceiveAsync_003Ed__35*)9;
							continue;
						case 34u:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 26;
							continue;
						case 22u:
							obj = 0;
							_ = 27;
							continue;
						case 18u:
						case 36u:
							obj = (object)(&obj);
							if (31 == 0)
							{
								reference = ref *(_003CReceiveAsync_003Ed__35*)29;
							}
							continue;
						case 12u:
							reference = ref this;
							if (28 == 0)
							{
								reference = ref *(_003CReceiveAsync_003Ed__35*)10;
							}
							continue;
						case 5u:
							if (&obj != null)
							{
								reference = ref *(_003CReceiveAsync_003Ed__35*)36;
								continue;
							}
							goto case 22u;
						case 31u:
							break;
						case 4u:
							_ = ref obj;
							_ = 13;
							continue;
						case 9u:
						{
							ref byte reference2 = ref *(byte*)2;
							while (true)
							{
								switch ((uint)Unsafe.AsPointer(ref reference2))
								{
								case 2u:
									obj = obj;
									reference2 = ref Unsafe.As<object, byte>(ref Unsafe.AddByteOffset(ref obj, (long)obj));
									if (false)
									{
										reference2 = ref *(byte*)1;
									}
									continue;
								case 1u:
									if (0 == 0)
									{
										_ = 0;
									}
									continue;
								default:
								{
									object obj3 = obj;
									if (obj3 == null)
									{
										if (2 == 0)
										{
											_ = 4;
										}
										continue;
									}
									reference2 = ref *(byte*)obj3;
									if (3 == 0)
									{
										reference2 = ref *(byte*)1;
									}
									continue;
								}
								case 3u:
								case 4u:
									break;
								}
								break;
							}
							goto IL_0799;
						}
						case 29u:
							if (obj != null)
							{
								reference = ref *(_003CReceiveAsync_003Ed__35*)32;
								continue;
							}
							goto case 11u;
						case 2u:
							_ = ref obj;
							_ = 4;
							continue;
						case 8u:
							if (obj == null)
							{
								reference = ref *(_003CReceiveAsync_003Ed__35*)7;
								continue;
							}
							goto case 34u;
						case 7u:
						case 21u:
							goto end_IL_014b;
						case 23u:
							_ = ref obj;
							obj = 15;
							continue;
						case 11u:
							if (obj != null)
							{
								if (17 == 0)
								{
									reference = ref *(_003CReceiveAsync_003Ed__35*)9;
								}
								continue;
							}
							goto case 10u;
						case 20u:
						case 24u:
							reference = ref *(_003CReceiveAsync_003Ed__35*)obj;
							if (0 != 0)
							{
								reference = ref *(_003CReceiveAsync_003Ed__35*)null;
							}
							continue;
						case 19u:
							if (obj != null)
							{
								reference = ref *(_003CReceiveAsync_003Ed__35*)25;
								continue;
							}
							goto case 29u;
						case 14u:
							if (0 == 0)
							{
								_ = 3;
							}
							continue;
						case 10u:
							if (obj == null)
							{
								reference = ref *(_003CReceiveAsync_003Ed__35*)24;
								continue;
							}
							goto case 17u;
						case 33u:
							goto IL_05cd;
						case 26u:
							if (obj != null)
							{
								obj = 37;
								continue;
							}
							goto case 19u;
						case 27u:
							_ = 23;
							continue;
						case 28u:
							obj = -1;
							_ = 18;
							continue;
						case 17u:
						case 25u:
						case 32u:
						case 35u:
							if (obj != null || obj != null || obj == null)
							{
							}
							_ = 14;
							continue;
						default:
							goto IL_0799;
						}
						if ((nint)obj != 2)
						{
							if (obj == null)
							{
								if (true)
								{
									reference = ref *(_003CReceiveAsync_003Ed__35*)1;
								}
								continue;
							}
							goto IL_05cd;
						}
						if (30 == 0)
						{
							reference = ref *(_003CReceiveAsync_003Ed__35*)24;
						}
						continue;
						IL_05cd:
						_ = 31;
						obj = 1;
						_ = 2;
						continue;
						end_IL_014b:
						break;
					}
					goto IL_04d7;
					IL_0799:
					_ = -2;
					_ = 4;
					break;
					IL_00fc:
					if (0 == 0)
					{
						_ = 0;
					}
					goto IL_00aa;
					IL_00aa:
					while (true)
					{
						switch ((int)/*Error near IL_00c3: Stack underflow*/)
						{
						case 4:
							obj = (object)/*Error near IL_00cb: Stack underflow*/;
							if (2 == 0)
							{
								_ = 1;
							}
							continue;
						case 3:
							if (1 == 0)
							{
								_ = 0;
							}
							continue;
						case 1:
							break;
						case 2:
							_ = 4096;
							if (3 == 0)
							{
								_ = 1;
							}
							continue;
						default:
							goto IL_0135;
						}
						break;
					}
					goto IL_00fc;
					IL_0135:
					if (obj == null)
					{
						reference = ref *(_003CReceiveAsync_003Ed__35*)16;
						goto IL_014b;
					}
					goto IL_04d7;
					IL_04d7:
					obj = (object)Unsafe.AsPointer(ref this);
					obj = 5;
					goto IL_014b;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00栀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00椀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777423, new IntPtr(2737367918204L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CReceiveLoopAsync_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public WebRtc _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object DecorateInternalHandler;

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
		internal static bool ResetFinalizer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ObserveAggregator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00䬀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777422, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00䰀(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00䴀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00一()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777421, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00匀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_005a: Expected Obj, but got Ref
			//IL_0175: Expected Obj, but got Ref
			//IL_01bb: Expected Obj, but got I4
			//IL_0191: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0080->IL0019: Incompatible stack heights: 3 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0066->IL0019: Incompatible stack heights: 0 vs 1
			//IL_009a->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0056->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0071->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0325->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_02f8->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_02dc->IL00b0: Incompatible stack heights: 0 vs 1
			//IL_018c->IL00f9: Incompatible stack heights: 1 vs 0
			//IL_00f5->IL00f9: Incompatible stack heights: 1 vs 0
			//IL_01f3->IL00f9: Incompatible stack heights: 2 vs 0
			//IL_01e3->IL00f9: Incompatible stack heights: 1 vs 0
			//IL_01b6->IL00f9: Incompatible stack heights: 2 vs 0
			//IL_0162->IL00f9: Incompatible stack heights: 2 vs 0
			//IL_01c8->IL00f9: Incompatible stack heights: 2 vs 0
			//IL_0155->IL00f9: Incompatible stack heights: 4 vs 0
			//IL_019e->IL00f9: Incompatible stack heights: 2 vs 0
			//IL_01fe->IL00f9: Incompatible stack heights: 2 vs 0
			//IL_0145->IL00f9: Incompatible stack heights: 1 vs 0
			//IL_01d3->IL00f9: Incompatible stack heights: 2 vs 0
			//IL_01a9->IL00f9: Incompatible stack heights: 2 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			ref _003CReceiveLoopAsync_003Ed__34 reference = ref *(_003CReceiveLoopAsync_003Ed__34*)obj;
			while (true)
			{
				int num;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						reference = ref *(_003CReceiveLoopAsync_003Ed__34*)1;
					}
					break;
				case 5u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (true)
					{
						reference = ref *(_003CReceiveLoopAsync_003Ed__34*)4;
					}
					break;
				case 0u:
					return;
				case 2u:
					_ = -2;
					_ = 3;
					break;
				case 3u:
					reference = ref this;
					if (0 == 0)
					{
						reference = ref *(_003CReceiveLoopAsync_003Ed__34*)null;
					}
					break;
				case 1u:
					{
						if (obj != null)
						{
							num = 5;
							goto IL_00b0;
						}
						goto IL_0325;
					}
					IL_0325:
					num = 3;
					goto IL_00b0;
					IL_00b0:
					while (true)
					{
						switch (num)
						{
						case 4:
							break;
						case 3:
							if (obj != null)
							{
								if (1 == 0)
								{
									_ = 0;
								}
								goto IL_00f9;
							}
							goto IL_0171;
						case 1:
						case 2:
							goto IL_02c6;
						case 5:
							_ = 2;
							continue;
						default:
							_ = 4;
							continue;
						case 6:
							goto IL_0325;
							IL_02c6:
							if ((nint)obj != 2)
							{
								if (false)
								{
									num = 0;
								}
								continue;
							}
							goto IL_0325;
							IL_00f9:
							while (true)
							{
								switch ((int)/*Error near IL_012e: Stack underflow*/)
								{
								case 6:
									return;
								case 5:
									if (&obj != null)
									{
										_ = 9;
										continue;
									}
									goto case 11;
								case 8:
									_ = ref obj;
									_ = 6;
									continue;
								case 4:
								case 9:
									_ = ref obj;
									_ = 2;
									continue;
								case 10:
									break;
								case 11:
									obj = 0;
									if (0 == 0)
									{
										_ = 0;
									}
									continue;
								case 3:
									_ = 7;
									continue;
								case 7:
									obj = -1;
									if (4 == 0)
									{
										_ = 4;
									}
									continue;
								case 1:
									obj = obj;
									_ = 5;
									continue;
								default:
									if (1 == 0)
									{
										_ = 8;
									}
									continue;
								case 2:
									goto IL_02c6;
								}
								break;
							}
							goto IL_0171;
							IL_0171:
							obj = (object)Unsafe.AsPointer(ref this);
							if (3 != 0)
							{
								_ = 0;
							}
							goto IL_00f9;
						}
						break;
					}
					goto case 2u;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00吀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00唀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777420, new IntPtr(2737367918204L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRetrySetIceCandidateAsync_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public nint handle;

		public EntitySessionDescription desc;

		public int retryCount;

		public WebRtc _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object ReflectAdjustableChain;

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
		internal static bool ReflectGenericEnumerator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FilterTransmitter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00㼀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777419, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00䀀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00䄀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777418, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00䈀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00䌀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777417, new IntPtr(2737367918204L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00䠀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_04a8: Expected Obj, but got Ref
			//IL_04b1: Expected Obj, but got I4
			//IL_04ba: Expected Obj, but got Ref
			//IL_03bc: Expected Obj, but got Ref
			//IL_022d: Expected Obj, but got I4
			//IL_037a: Expected Obj, but got I4
			//IL_02ac: Expected Obj, but got I4
			//IL_0132: Expected Obj, but got Ref
			//IL_01bf: Expected Obj, but got I4
			//IL_01b5: Expected Obj, but got I4
			//IL_02c4: Expected Obj, but got Ref
			//IL_0398: Expected Obj, but got I4
			//IL_01e1: Expected Obj, but got Ref
			//IL_01e7: Expected Obj, but got Ref
			//IL_01ee: Expected Obj, but got Ref
			//IL_01f4: Expected Obj, but got Ref
			//IL_0402: Expected Obj, but got Ref
			//IL_03b3: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_04c6->IL0019: Incompatible stack heights: 0 vs 1
			//IL_04e1->IL0019: Incompatible stack heights: 2 vs 1
			//IL_04d1->IL0019: Incompatible stack types: I4 vs Ref
			//IL_04ec->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0055->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0074->IL0078: Incompatible stack heights: 1 vs 0
			//IL_03d3->IL0078: Incompatible stack heights: 1 vs 0
			//IL_0347->IL0078: Incompatible stack heights: 1 vs 0
			//IL_0238->IL0078: Incompatible stack heights: 3 vs 0
			//IL_0419->IL0078: Incompatible stack heights: 2 vs 0
			//IL_0385->IL0078: Incompatible stack heights: 3 vs 0
			//IL_02b6->IL0078: Incompatible stack heights: 1 vs 0
			//IL_013c->IL0078: Incompatible stack heights: 1 vs 0
			//IL_01cc->IL0078: Incompatible stack heights: 2 vs 0
			//IL_0187->IL0078: Incompatible stack heights: 2 vs 0
			//IL_03e3->IL0078: Incompatible stack heights: 4 vs 0
			//IL_0393->IL0078: Incompatible stack heights: 3 vs 0
			//IL_012e->IL0078: Incompatible stack heights: 2 vs 0
			//IL_02dd->IL0078: Incompatible stack heights: 1 vs 0
			//IL_02ce->IL0078: Incompatible stack heights: 4 vs 0
			//IL_016f->IL0078: Incompatible stack heights: 2 vs 0
			//IL_02f9->IL0078: Incompatible stack heights: 2 vs 0
			//IL_03a3->IL0078: Incompatible stack heights: 3 vs 0
			//IL_0248->IL0078: Incompatible stack heights: 2 vs 0
			//IL_0201->IL0078: Incompatible stack heights: 1 vs 0
			//IL_040c->IL0078: Incompatible stack heights: 4 vs 0
			//IL_0276->IL0078: Incompatible stack heights: 2 vs 0
			//IL_01d7->IL0078: Incompatible stack heights: 2 vs 0
			//IL_0078->IL0078: Incompatible stack heights: 4 vs 0
			//IL_03b8->IL0074: Incompatible stack heights: 0 vs 3
			//IL_02e8->IL0078: Incompatible stack heights: 1 vs 0
			//IL_017a->IL0078: Incompatible stack heights: 2 vs 0
			//IL_03f4->IL0078: Incompatible stack heights: 1 vs 0
			//IL_0253->IL0078: Incompatible stack heights: 2 vs 0
			//IL_020c->IL0078: Incompatible stack heights: 1 vs 0
			//IL_0281->IL0078: Incompatible stack heights: 2 vs 0
			//IL_0366->IL0078: Incompatible stack heights: 1 vs 0
			//IL_01a6->IL0078: Incompatible stack heights: 1 vs 0
			//IL_015b->IL0078: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			while (true)
			{
				ref _003CRetrySetIceCandidateAsync_003Ed__38 reference = ref *(_003CRetrySetIceCandidateAsync_003Ed__38*)obj;
				while (true)
				{
					switch ((uint)Unsafe.AsPointer(ref reference))
					{
					case 3u:
						reference = ref this;
						if (3 == 0)
						{
							reference = ref *(_003CRetrySetIceCandidateAsync_003Ed__38*)4;
						}
						continue;
					case 5u:
						if (obj == null)
						{
							if (3 == 0)
							{
								_ = 9;
							}
							goto IL_0078;
						}
						goto IL_0328;
					default:
						goto end_IL_0019;
					case 1u:
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							reference = ref *(_003CRetrySetIceCandidateAsync_003Ed__38*)null;
						}
						continue;
					case 2u:
						break;
					case 4u:
						return;
						IL_0078:
						while (true)
						{
							switch ((int)/*Error near IL_010d: Stack underflow*/)
							{
							case 23:
								_ = ref obj;
								_ = 26;
								continue;
							case 9:
							case 11:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 16;
								continue;
							case 35:
								if ((nint)Unsafe.AsPointer(ref this) <= unchecked((nint)null))
								{
									if (14 == 0)
									{
										_ = 15;
									}
									continue;
								}
								goto case 29;
							case 27:
								if (6 == 0)
								{
									_ = 6;
								}
								continue;
							case 16:
								_ = 7;
								continue;
							case 22:
								if (&obj == null)
								{
									if (0 == 0)
									{
										_ = 0;
									}
									continue;
								}
								goto case 23;
							case 14:
								_ = ref obj;
								obj = 4;
								continue;
							case 12:
								obj = -1;
								if (24 == 0)
								{
									_ = 11;
								}
								continue;
							case 32:
								((object[])4)[0] = (object)Unsafe.AsPointer(ref this);
								((object[])4)[1] = (object)Unsafe.AsPointer(ref this);
								((object[])4)[2] = (object)Unsafe.AsPointer(ref this);
								((object[])4)[3] = (object)Unsafe.AsPointer(ref this);
								if (6 == 0)
								{
									_ = 33;
								}
								continue;
							default:
								obj = 0;
								_ = 31;
								continue;
							case 31:
								if (14 == 0)
								{
									_ = 14;
								}
								continue;
							case 8:
							case 34:
								if (1 == 0)
								{
									_ = 0;
								}
								continue;
							case 13:
								return;
							case 10:
								obj = 1000;
								_ = 22;
								continue;
							case 26:
								obj = (object)Unsafe.AsPointer(ref Unsafe.SubtractByteOffset(ref this, 1));
								_ = 18;
								continue;
							case 24:
							case 25:
								_ = ref obj;
								if (2 == 0)
								{
									_ = 1;
								}
								continue;
							case 29:
								Unsafe.SubtractByteOffset(ref this, 1);
								_ = 10;
								continue;
							case 4:
								return;
							case 5:
								break;
							case 18:
								if (&obj != null)
								{
									if (13 != 0)
									{
										_ = 25;
									}
									continue;
								}
								goto case 30;
							case 7:
								obj = -1;
								_ = 23;
								continue;
							case 20:
								_ = 19;
								continue;
							case 30:
								obj = 1;
								_ = 20;
								continue;
							case 21:
								if (obj == null)
								{
									obj = 35;
									continue;
								}
								goto case 15;
							case 17:
								goto IL_03b8;
							case 19:
								_ = ref obj;
								_ = 13;
								continue;
							case 15:
							case 28:
								if (obj != null)
								{
									_ = 8;
									continue;
								}
								goto case 27;
							case 33:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 21;
								continue;
							case 3:
								_ = 12;
								continue;
							case 1:
							case 2:
							case 6:
								goto end_IL_0019_2;
							}
							break;
						}
						goto IL_0328;
						IL_03b8:
						obj = (object)Unsafe.AsPointer(ref this);
						if (3 != 0)
						{
							_ = 3;
						}
						goto IL_0078;
						IL_0328:
						if ((nint)obj != 1)
						{
							if (32 == 0)
							{
								_ = 29;
							}
							goto IL_0078;
						}
						goto IL_03b8;
						end_IL_0019_2:
						break;
					}
					_ = -2;
					if (true)
					{
						_ = 3;
					}
					continue;
					end_IL_0019:
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
				obj = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00䤀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00䨀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777416, new IntPtr(2737367918204L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSendSessionDescriptionAsync_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public WebRtc _003C_003E4__this;

		public string peerId;

		public EntitySessionDescription desc;

		private long _003Cto_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private static object DecorateCustomGateway;

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
		internal static bool CheckAdvancedProfiler()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckConvertibleFactory()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00㔀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777415, new IntPtr(2737367918204L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00㘀(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00㜀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00㠀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777414, new IntPtr(2737367918204L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00㰀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0358: Expected Obj, but got Ref
			//IL_01bb: Expected Obj, but got Ref
			//IL_0117: Expected Obj, but got I4
			//IL_02ad: Expected Obj, but got I4
			//IL_029e: Expected Obj, but got Ref
			//IL_0165: Expected Obj, but got Ref
			//IL_0137: Expected Obj, but got I4
			//IL_023b: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0364->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0064->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0056->IL0019: Incompatible stack types: I4 vs Ref
			//IL_036f->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0389->IL0019: Incompatible stack types: I4 vs Ref
			//IL_01c7->IL0087: Incompatible stack heights: 1 vs 0
			//IL_029a->IL0087: Incompatible stack heights: 1 vs 0
			//IL_0083->IL0087: Incompatible stack heights: 1 vs 0
			//IL_01d2->IL0087: Incompatible stack heights: 1 vs 0
			//IL_0121->IL0087: Incompatible stack heights: 4 vs 0
			//IL_026a->IL0087: Incompatible stack heights: 2 vs 0
			//IL_02b8->IL0087: Incompatible stack heights: 3 vs 0
			//IL_02a8->IL0087: Incompatible stack heights: 1 vs 0
			//IL_0252->IL0087: Incompatible stack heights: 3 vs 0
			//IL_0171->IL0087: Incompatible stack heights: 7 vs 0
			//IL_0144->IL0087: Incompatible stack heights: 2 vs 0
			//IL_01e3->IL0087: Incompatible stack heights: 1 vs 0
			//IL_01b4->IL0087: Incompatible stack heights: 2 vs 0
			//IL_00f3->IL014f: Incompatible stack heights: 1 vs 0
			//IL_0132->IL0087: Incompatible stack heights: 2 vs 0
			//IL_022e->IL0087: Incompatible stack heights: 3 vs 0
			//IL_02d5->IL0087: Incompatible stack heights: 1 vs 0
			//IL_025d->IL0087: Incompatible stack heights: 3 vs 0
			//IL_017c->IL0087: Incompatible stack heights: 7 vs 0
			//IL_014f->IL0087: Incompatible stack heights: 2 vs 0
			//IL_01ee->IL0087: Incompatible stack heights: 1 vs 0
			//IL_00ff->IL0087: Incompatible stack heights: 1 vs 0
			//IL_0087->IL0087: Incompatible stack heights: 3 vs 0
			//IL_010a->IL0087: Incompatible stack heights: 1 vs 0
			//IL_021c->IL0087: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			ref _003CSendSessionDescriptionAsync_003Ed__44 reference = ref *(_003CSendSessionDescriptionAsync_003Ed__44*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 == 0)
					{
						reference = ref *(_003CSendSessionDescriptionAsync_003Ed__44*)3;
					}
					break;
				case 5u:
					_ = -2;
					_ = 4;
					break;
				case 3u:
					if (obj == null)
					{
						if (18 != 0)
						{
							_ = 12;
						}
						goto IL_0087;
					}
					goto IL_0286;
				case 2u:
					return;
				case 1u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						reference = ref *(_003CSendSessionDescriptionAsync_003Ed__44*)null;
					}
					break;
				case 4u:
					{
						reference = ref this;
						if (true)
						{
							reference = ref *(_003CSendSessionDescriptionAsync_003Ed__44*)2;
						}
						break;
					}
					IL_01b4:
					obj = (object)Unsafe.AsPointer(ref this);
					if (true)
					{
						_ = 14;
					}
					goto IL_0087;
					IL_0087:
					while (true)
					{
						switch ((int)/*Error near IL_00e4: Stack underflow*/)
						{
						case 1:
						case 3:
						case 20:
							break;
						case 14:
							if (Unsafe.AsPointer(ref this) == null)
							{
								if (12 != 0)
								{
									_ = 3;
								}
								continue;
							}
							goto case 8;
						default:
							_ = 0;
							obj = 1;
							_ = 17;
							continue;
						case 16:
							_ = 20;
							continue;
						case 11:
							obj = -1;
							if (2 == 0)
							{
								_ = 13;
							}
							continue;
						case 8:
							/*Error near IL_0150: Stack underflow*/;
							_ = 1;
							obj = (object)Unsafe.AsPointer(ref this);
							if (5 == 0)
							{
								_ = 2;
							}
							continue;
						case 10:
							return;
						case 13:
							_ = ref obj;
							_ = 21;
							continue;
						case 19:
							goto IL_01b4;
						case 12:
							if (0 == 0)
							{
								_ = 1;
							}
							continue;
						case 17:
							if (&obj == null)
							{
								if (4 != 0)
								{
									_ = 4;
								}
								continue;
							}
							goto case 13;
						case 21:
							_ = 3;
							continue;
						case 15:
							obj = 7;
							continue;
						case 7:
							_ = ref obj;
							if (10 != 0)
							{
								_ = 7;
							}
							continue;
						case 2:
							_ = 11;
							continue;
						case 9:
							goto IL_0286;
						case 6:
						case 18:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 2;
							continue;
						case 4:
							obj = 0;
							_ = 15;
							continue;
						case 5:
							obj = obj;
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						}
						break;
					}
					goto case 5u;
					IL_0286:
					if ((nint)obj != 2)
					{
						_ = 16;
						goto IL_0087;
					}
					goto IL_01b4;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00㴀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00㸀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777413, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	public static readonly ILogger Logger;

	private static readonly object GlobalLock;

	private static nint _sslInitialized;

	[CompilerGenerated]
	private Action<string>? m_OnDataChannelOpen;

	[CompilerGenerated]
	private Action<Exception>? m_OnDataChannelError;

	[CompilerGenerated]
	private Action<string>? m_OnDataChannelClose;

	[CompilerGenerated]
	private Action<string, byte[]>? m_OnBinaryMessage;

	private readonly object _socket;

	private nint _compression;

	private object? _handshakeTcs;

	private object _turnAuthServer;

	private long _expirationTimestamp;

	private readonly Dictionary<string, nint> _peerHandles;

	private readonly Dictionary<string, List<EntityWebSocketMessage>> _pendingSignalsByPeer;

	private readonly Dictionary<nint, List<GCHandle>> _gcHandlesByHandle;

	private readonly Dictionary<nint, WebRtcCompressor> _compressorsByHandle;

	private readonly Dictionary<string, PendingBuffer> _pendingDataByPeer;

	private object? _currentRemoteId;

	internal static WebRtc PlayReg;

	public event Action<string>? OnDataChannelOpen
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00_FF00_FF00_FF00툀(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00_FF00_FF00_FF00_FF00ᄀ(value);
		}
	}

	public event Action<Exception>? OnDataChannelError
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00_FF00_FF00_FF00_EA00(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00_FF00_FF00_FF00_FF00ጀ(value);
		}
	}

	public event Action<string>? OnDataChannelClose
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00_FF00_FF00_FF00_E700(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00_FF00_FF00_FF00_FF00_0900(value);
		}
	}

	public event Action<string, byte[]>? OnBinaryMessage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00_FF00_FF00_FF00_F800(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00_FF00_FF00_FF00퀀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WebRtc(DesktopSession session, string url)
	{
		//IL_0072: Expected I4, but got Obj
		//IL_0060->IL0069: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		WebRtc webRtc = this;
		if (0 == 0)
		{
			webRtc = (WebRtc)0;
		}
		switch ((int)webRtc)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		_FF00_FF00_FF00_FF00_FF00_3300();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCompressionEnabled(bool enabled)
	{
		_FF00_FF00_FF00_FF00_EF00(enabled ? ((byte)1) : ((byte)0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CConnectSignalServerAsync_003Ed__31))]
	public Task ConnectSignalServerAsync()
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00_2E00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartWebRtc(string peerId = "Any")
	{
		_FF00_FF00_FF00_FF00_FF00ᘀ(peerId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InstallWebRtc(object peerId)
	{
		_FF00_FF00_FF00_FF00_FF00Ⰰ(peerId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReceiveLoopAsync_003Ed__34))]
	private object ReceiveLoopAsync()
	{
		return _FF00_FF00_FF00_FF00_FF00_2F00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReceiveAsync_003Ed__35))]
	private object ReceiveAsync()
	{
		return _FF00_FF00_FF00_FF00_E300();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleSignalMessage(object signal)
	{
		_FF00_FF00_FF00_FF00_FF00(signal);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleSessionDescription(nint handle, object signal)
	{
		_FF00_FF00_FF00_FF00_FF00ༀ(handle, signal);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRetrySetIceCandidateAsync_003Ed__38))]
	private object RetrySetIceCandidateAsync(nint handle, object desc, uint retryCount = 5)
	{
		return _FF00_FF00_FF00_FF00_F500(handle, desc, retryCount);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleasePinnedCallbacks(nint handle)
	{
		_FF00_FF00_FF00_FF00_FF00㘀(handle);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RegisterCallback<T>(nint handle, T callback, Action<nint, T> register) where T : Delegate
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DataBinaryMessageCallback(object peerId, nint dataPtr, uint length)
	{
		_FF00_FF00_FF00_FF00_F700(peerId, dataPtr, length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object NormalizePeerId(object peerId)
	{
		return _FF00_FF00_FF00_FF00_FF00㼀(peerId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IceCandidateCallback(object peerId, object mid, uint index, object sdp)
	{
		_FF00_FF00_FF00_FF00_F200(peerId, mid, index, sdp);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSendSessionDescriptionAsync_003Ed__44))]
	private object SendSessionDescriptionAsync(object desc, object peerId)
	{
		return _FF00_FF00_FF00_FF00_FF00㴀(desc, peerId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DataChannelOpenCallback(object peerId)
	{
		_FF00_FF00_FF00_FF00_FFFD(peerId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DataChannelCloseCallback(object peerId)
	{
		_FF00_FF00_FF00_FF00_FF00㬀(peerId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SuccessCallback(object peerId, object type, object sdp)
	{
		_FF00_FF00_FF00_FF00_FFFD(peerId, type, sdp);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FlushPendingData(object peerId)
	{
		_FF00_FF00_FF00_FF00_FF00_0600(peerId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SendData(byte[] data, string peerId = "Any")
	{
		return _FF00_FF00_FF00_FF00퐀(data, peerId) != 0;
	}

	static WebRtc()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0023: Expected I4, but got Obj
		//IL_0079->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0050->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0084->IL0012: Incompatible stack types: I4 vs Obj
		//IL_005b->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 2:
				Logger = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_0700());
				obj2 = 1;
				if (_003CModule_003E_007B8336717d_002D71de_002D47ce_002Dbc69_002D4d75223ebc5e_007D.m_d836f3f9b6194f49a23d85cb66f28ddf.m_909585e5bb074f56b84395f6cc262932 == 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				GlobalLock = new object();
				obj2 = 0;
				if (_003CModule_003E_007B8336717d_002D71de_002D47ce_002Dbc69_002D4d75223ebc5e_007D.m_d836f3f9b6194f49a23d85cb66f28ddf.m_bba3bc948d05406eb63333eb807a2700 == 0)
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
	internal static bool SetupExecutor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static WebRtc ReflectTransformableContainer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00케(Action<string, byte[]> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777534, new IntPtr(2737367883884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00퀀(Action<string, byte[]> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0088->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0075->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0067->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0059->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a8->IL0019: Incompatible stack types: I4 vs Obj
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
				obj2 = obj;
				obj = P_0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				obj = this;
				obj2 = 2;
				break;
			case 2:
				obj = obj;
				obj2 = 4;
				break;
			default:
				obj = obj;
				_ = 5;
				break;
			case 5:
				if (obj == obj)
				{
					if (true)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 2;
			case 1:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00턀(Action<string, byte[]> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777533, new IntPtr(2737367883884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00툀(Action<string> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00b8->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0069->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0050->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a8->IL0019: Incompatible stack heights: 2 vs 1
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
				if (obj == obj)
				{
					if (true)
					{
						obj2 = 1;
					}
					continue;
				}
				break;
			case 3:
				obj = this;
				obj2 = 2;
				continue;
			case 4:
				obj2 = obj;
				obj = P_0;
				if (5 == 0)
				{
					obj2 = 1;
				}
				continue;
			case 1:
				return;
			case 5:
				obj = obj;
				if (0 == 0)
				{
					_ = 0;
				}
				continue;
			case 2:
				break;
			}
			obj = obj;
			if (1 == 0)
			{
				obj2 = 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00팀(Action<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777532, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00퐀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_005e: Expected I4, but got Obj
		//IL_0373: Expected Obj, but got I4
		//IL_0149: Expected Obj, but got I4
		//IL_00fe: Expected I4, but got Obj
		//IL_02a4: Expected Obj, but got Ref
		//IL_0236: Invalid comparison between Ref and Obj
		//IL_0224: Invalid comparison between Ref and Obj
		//IL_02d4: Invalid comparison between Ref and Obj
		//IL_009d: Expected I4, but got Obj
		//IL_01b1: Expected I4, but got Obj
		//IL_0170->IL0174: Incompatible stack types: I4 vs Obj
		//IL_0378->IL0015: Incompatible stack heights: 3 vs 0
		//IL_013b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00ac->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00ef->IL00d3: Incompatible stack heights: 2 vs 0
		//IL_0393->IL012c: Incompatible stack heights: 2 vs 0
		//IL_00e3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0155->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0146->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00f9->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0090->IL0019: Incompatible stack types: I4 vs Obj
		//IL_010b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_012c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_039d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0160->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01c9->IL0174: Incompatible stack heights: 5 vs 3
		//IL_02b0->IL0174: Incompatible stack heights: 1 vs 3
		//IL_023b->IL02f8: Incompatible stack heights: 1 vs 2
		//IL_026e->IL02e3: Incompatible stack heights: 4 vs 2
		//IL_01df->IL02d1: Incompatible stack heights: 4 vs 2
		//IL_02c7->IL0245: Incompatible stack heights: 4 vs 2
		//IL_0229->IL02f8: Incompatible stack heights: 1 vs 2
		//IL_02d9->IL02f8: Incompatible stack heights: 1 vs 2
		//IL_02ee->IL0233: Incompatible stack heights: 3 vs 2
		//IL_01d4->IL0174: Incompatible stack heights: 5 vs 3
		//IL_0262->IL0174: Incompatible stack types: I4 vs Obj
		//IL_02bb->IL0174: Incompatible stack heights: 1 vs 3
		//IL_0245->IL0174: Incompatible stack heights: 2 vs 3
		//IL_027a->IL0174: Incompatible stack heights: 4 vs 3
		//IL_01eb->IL0174: Incompatible stack heights: 4 vs 3
		//IL_02d1->IL0174: Incompatible stack heights: 5 vs 3
		//IL_0233->IL0174: Incompatible stack heights: 2 vs 3
		//IL_02e3->IL0174: Incompatible stack heights: 2 vs 3
		//IL_02f8->IL0174: Incompatible stack heights: 4 vs 3
		//IL_0285->IL0174: Incompatible stack heights: 4 vs 3
		//IL_01f6->IL0174: Incompatible stack heights: 4 vs 3
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
				case 7:
					if (this == null)
					{
						obj2 = 13;
						continue;
					}
					goto case 5;
				case 6:
				case 9:
				case 13:
					return (byte)((Array)obj).Length;
				case 3:
					obj = (object)/*Error near IL_00a0: Stack underflow*/;
					if (14 == 0)
					{
						obj2 = 8;
					}
					continue;
				case 4:
					obj2 = this;
					obj = P_1;
					if (0 == 0)
					{
						obj2 = 3;
					}
					continue;
				case 12:
					obj = P_0;
					_ = 9;
					continue;
				case 5:
					if (&obj == null)
					{
						_ = 6;
						continue;
					}
					goto case 12;
				case 8:
				case 15:
					return (byte)(int)P_0;
				case 10:
					if (obj == null)
					{
						obj2 = 11;
						continue;
					}
					obj = P_0;
					obj2 = 7;
					continue;
				case 2:
					obj = (object)/*Error near IL_012f: Stack underflow*/;
					if (false)
					{
						obj2 = 1;
					}
					continue;
				case 14:
					obj = 0;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				default:
				{
					object obj3 = 8;
					while (true)
					{
						switch ((int)obj3)
						{
						case 2:
							return (byte)(int)obj;
						case 1:
							if (3 != 0)
							{
								_ = 0;
							}
							continue;
						case 8:
							if (&obj == null)
							{
								if (0 == 0)
								{
									_ = 7;
								}
								continue;
							}
							goto case 12;
						case 11:
							if (Unsafe.AreSame(ref *(byte*)(&obj), ref *(byte*)obj))
							{
								_ = 13;
								continue;
							}
							break;
						case 5:
							if (Unsafe.AreSame(ref *(byte*)(&obj), ref *(byte*)obj))
							{
								_ = 10;
								continue;
							}
							break;
						case 3:
							obj3 = obj;
							obj = P_0;
							if (false)
							{
								obj3 = 2;
							}
							continue;
						case 6:
						case 7:
							if (&obj != null)
							{
								if (10 != 0)
								{
									_ = 11;
								}
								continue;
							}
							goto case 13;
						case 4:
							obj = (object)(&obj);
							if (1 == 0)
							{
								_ = 0;
							}
							continue;
						case 9:
						case 10:
							if (&obj == null)
							{
								_ = 4;
								continue;
							}
							goto case 3;
						case 12:
							if (Unsafe.AreSame(ref *(byte*)(&obj), ref *(byte*)obj))
							{
								_ = 6;
								continue;
							}
							break;
						case 13:
							if (&obj == null)
							{
								_ = 9;
								continue;
							}
							goto case 5;
						}
						break;
					}
					goto case 10;
				}
				case 1:
					break;
				case 11:
					if (&obj != null)
					{
						_ = 8;
						continue;
					}
					goto case 2;
				}
				break;
			}
			obj = 15;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00픀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777531, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FFFD(object P_0, object P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777530, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_FFFD(object P_0, object P_1, object P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0062: Expected I4, but got Obj
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0116->IL0019: Incompatible stack heights: 3 vs 1
		//IL_007c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00fa->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01af->IL0019: Incompatible stack heights: 4 vs 1
		//IL_00e5->IL0019: Incompatible stack heights: 3 vs 1
		//IL_019e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0087->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ca->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01ca->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0105->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0174->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0165->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01d5->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 14;
		object obj2 = obj;
		while (true)
		{
			object obj3;
			switch ((int)obj2)
			{
			case 4:
				/*Error near IL_0068: Stack underflow*/;
				obj = P_2;
				if (15 != 0)
				{
					_ = 1;
				}
				continue;
			case 8:
				return;
			case 13:
				if (P_1 != null)
				{
					obj2 = 7;
					continue;
				}
				goto case 6;
			case 6:
				if (P_1 != null)
				{
					if (2 != 0)
					{
						obj2 = 1;
					}
					continue;
				}
				goto case 12;
			case 15:
				_ = 5;
				continue;
			case 10:
				/*Error near IL_00e6: Stack underflow*/;
				obj = P_2;
				if (0 == 0)
				{
					_ = 0;
				}
				continue;
			case 1:
				_ = 10;
				continue;
			default:
				_ = 3;
				continue;
			case 5:
				return;
			case 2:
				if (this != null)
				{
					obj2 = 11;
					continue;
				}
				goto case 9;
			case 3:
				return;
			case 12:
				_ = 8;
				continue;
			case 7:
			case 16:
				_ = 4;
				continue;
			case 14:
				_ = 13;
				continue;
			case 9:
				obj3 = this;
				break;
			case 11:
				obj3 = P_0;
				break;
			}
			obj = obj3;
			if (0 == 0)
			{
				obj2 = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		//IL_0073: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I4
		//IL_00eb: Expected I4, but got Obj
		//IL_014a: Invalid comparison between Ref and Obj
		//IL_018e: Invalid comparison between Ref and Obj
		//IL_0186: Expected Obj, but got I4
		//IL_01de: Expected Obj, but got Ref
		//IL_0138: Invalid comparison between Ref and Obj
		//IL_02c6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0070->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02d1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_030d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_031d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02e6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0063->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0328->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02f1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_014f->IL0229: Incompatible stack heights: 1 vs 2
		//IL_01c4->IL0147: Incompatible stack heights: 3 vs 2
		//IL_01fa->IL00a2: Incompatible stack heights: 6 vs 3
		//IL_0193->IL0147: Incompatible stack heights: 1 vs 2
		//IL_0100->IL00a2: Incompatible stack heights: 2 vs 3
		//IL_018b->IL009e: Incompatible stack heights: 5 vs 2
		//IL_01e8->IL00a2: Incompatible stack heights: 2 vs 3
		//IL_0242->IL01b9: Incompatible stack heights: 4 vs 2
		//IL_016b->IL00a2: Incompatible stack heights: 4 vs 3
		//IL_013d->IL01b9: Incompatible stack heights: 1 vs 2
		//IL_021e->IL00a2: Incompatible stack heights: 5 vs 3
		//IL_011b->IL00a2: Incompatible stack heights: 2 vs 3
		//IL_0237->IL00a2: Incompatible stack heights: 4 vs 3
		//IL_0159->IL00a2: Incompatible stack heights: 2 vs 3
		//IL_019d->IL00a2: Incompatible stack heights: 2 vs 3
		//IL_020c->IL00a2: Incompatible stack types: I4 vs Obj
		//IL_010b->IL00a2: Incompatible stack heights: 2 vs 3
		//IL_024c->IL00a2: Incompatible stack heights: 5 vs 3
		//IL_0176->IL00a2: Incompatible stack heights: 4 vs 3
		//IL_0147->IL00a2: Incompatible stack heights: 2 vs 3
		//IL_0229->IL00a2: Incompatible stack heights: 5 vs 3
		//IL_0126->IL00a2: Incompatible stack heights: 2 vs 3
		//IL_01db->IL00a2: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 8:
				obj2 = this;
				obj = P_0;
				if (6 != 0)
				{
					obj2 = 2;
				}
				break;
			case 1:
				obj = (object)/*Error near IL_0066: Stack underflow*/;
				obj2 = 4;
				break;
			case 4:
				obj = 0;
				if (6 != 0)
				{
					obj2 = 7;
				}
				break;
			case 7:
				obj = 9;
				while (true)
				{
					object obj3 = obj;
					while (true)
					{
						switch ((int)obj3)
						{
						case 7:
							obj = obj;
							if (false)
							{
								_ = 0;
							}
							continue;
						case 15:
							obj = obj;
							if (4 == 0)
							{
								_ = 4;
							}
							continue;
						case 12:
							if (!Unsafe.AreSame(ref *(byte*)(&obj), ref *(byte*)obj))
							{
								_ = 15;
								continue;
							}
							goto case 1;
						default:
							if (!Unsafe.AreSame(ref *(byte*)(&obj), ref *(byte*)obj))
							{
								_ = 14;
								continue;
							}
							goto case 16;
						case 11:
							if (3 != 0)
							{
								_ = 6;
							}
							continue;
						case 8:
							goto end_IL_00a2;
						case 5:
							if (!Unsafe.AreSame(ref *(byte*)(&obj), ref *(byte*)obj))
							{
								_ = 7;
								continue;
							}
							goto default;
						case 1:
							obj3 = this;
							if (&obj != null)
							{
								if (0 == 0)
								{
									obj3 = 5;
								}
								continue;
							}
							goto default;
						case 9:
							obj = (object)(&obj);
							_ = 10;
							continue;
						case 2:
							_ = 13;
							continue;
						case 6:
							if (this == null)
							{
								obj3 = 8;
								continue;
							}
							goto case 2;
						case 14:
							if (11 == 0)
							{
								_ = 2;
							}
							continue;
						case 16:
							_ = 3;
							continue;
						case 10:
							if (&obj != null)
							{
								_ = 12;
								continue;
							}
							goto case 1;
						case 3:
						case 13:
							break;
						}
						goto end_IL_009e;
						continue;
						end_IL_00a2:
						break;
					}
					obj = 2;
					continue;
					end_IL_009e:
					break;
				}
				goto default;
			default:
				if (8 == 0)
				{
					_ = 1;
				}
				break;
			case 6:
				if (this == null)
				{
					if (5 == 0)
					{
						obj2 = 5;
					}
				}
				else if (true)
				{
					_ = 3;
				}
				break;
			case 3:
				return;
			case 2:
				obj2 = P_0;
				if (1 == 0)
				{
					obj2 = 0;
				}
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_E000(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777529, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_E100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777528, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_E200()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_E300()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 5042, 1790777527, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777527, new IntPtr(2737367916124L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe nint _FF00_FF00_FF00_FF00_E400(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_003e: Expected I, but got Obj
		//IL_00c5: Expected I, but got Obj
		//IL_0056: Invalid comparison between Unknown and Obj
		//IL_0075: Invalid comparison between Unknown and Obj
		//IL_00d7: Expected I, but got Obj
		//IL_009c->IL0053: Incompatible stack heights: 2 vs 0
		//IL_0049->IL00c5: Incompatible stack heights: 1 vs 0
		//IL_00a8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0067->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0086->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0053->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0072->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0091->IL0019: Incompatible stack types: I4 vs Obj
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
				return (nint)obj;
			default:
				if (&obj != null)
				{
					_ = 5;
					continue;
				}
				break;
			case 4:
			{
				object obj3 = obj;
				if ((object)/*Error near IL_005b: Stack underflow*/ != obj3)
				{
					if (2 != 0)
					{
						obj2 = 2;
					}
					continue;
				}
				goto default;
			}
			case 5:
			{
				object obj4 = obj;
				if ((object)/*Error near IL_007a: Stack underflow*/ != obj4)
				{
					if (3 != 0)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			}
			case 1:
				if (&obj == null)
				{
					if (false)
					{
						_ = 0;
					}
					continue;
				}
				goto case 4;
			case 3:
				return (nint)obj;
			}
			break;
		}
		return (nint)(((object)this) ?? ((object)/*Error near IL_00d3: Stack underflow*/));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe nint _FF00_FF00_FF00_FF00_E500(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777526, new IntPtr(2737367883884L), 15))(null, 0, new IntPtr(0L));
		return (nint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_E600(Action<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777525, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_E700(Action<string> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0076: Expected Obj, but got I4
		//IL_005e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0069->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0090->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00b9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009b->IL0019: Incompatible stack types: I4 vs Obj
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
				case 3:
					obj = obj;
					_ = 4;
					continue;
				case 2:
					obj = this;
					if (0 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 1:
					break;
				case 4:
					if (obj == obj)
					{
						if (false)
						{
							obj2 = 0;
						}
						continue;
					}
					break;
				case 5:
					obj2 = obj;
					obj = P_0;
					if (3 == 0)
					{
						obj2 = 3;
					}
					continue;
				case 0:
					return;
				}
				break;
			}
			obj = obj;
			obj = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_E800(Action<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777524, new IntPtr(2737367893244L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_E900(Action<Exception> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777523, new IntPtr(2737367883884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_EA00(Action<Exception> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00c2: Expected Obj, but got I4
		//IL_00c7->IL0015: Incompatible stack heights: 2 vs 0
		//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0085->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0075->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a5->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0090->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b0->IL0019: Incompatible stack types: I4 vs Obj
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
				case 4:
					obj = obj;
					if (2 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 1:
					return;
				case 2:
					obj2 = obj;
					obj = P_0;
					if (false)
					{
						obj2 = 0;
					}
					continue;
				case 5:
					obj = this;
					if (4 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 3:
					if (obj == obj)
					{
						if (1 == 0)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 4;
				}
				break;
			}
			obj = obj;
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_EB00(Action<Exception> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777522, new IntPtr(2737367883884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_EF00(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_003f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004a->IL0019: Incompatible stack heights: 2 vs 1
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
				return;
			case 0:
				return;
			case 1:
				if (false)
				{
					_ = 0;
				}
				break;
			case 2:
				if (P_0 == 0)
				{
				}
				if (0 == 0)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_F100(object P_0, object P_1, uint P_2, object P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777521, new IntPtr(2737367893244L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_F200(object P_0, object P_1, uint P_2, object P_3)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got I4
		//IL_005a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0081->IL0019: Incompatible stack heights: 6 vs 1
		//IL_0048->IL0015: Incompatible stack heights: 3 vs 0
		//IL_0065->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008c->IL0019: Incompatible stack heights: 6 vs 1
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
					return;
				case 0:
					return;
				case 3:
					break;
				case 1:
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 2:
					/*Error near IL_0066: Stack underflow*/;
					obj = P_3;
					if (1 == 0)
					{
						_ = 1;
					}
					continue;
				}
				break;
			}
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_F300()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_F400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777520, new IntPtr(2737367883884L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_F500(nint P_0, object P_1, uint P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_00d3: Expected Obj, but got Ref
		//IL_0051->IL0019: Incompatible stack heights: 3 vs 1
		//IL_007a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0096->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00c3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0061->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0088->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ce->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b1->IL0019: Incompatible stack heights: 2 vs 1
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
				_ = ref obj;
				_ = 3;
				break;
			case 5:
				_ = ref obj;
				if (false)
				{
					_ = 2;
				}
				break;
			case 2:
				_ = ref obj;
				_ = -1;
				_ = 4;
				break;
			case 7:
				_ = ref obj;
				_ = 6;
				break;
			case 3:
				_ = ref obj;
				_ = 5;
				break;
			case 6:
				_ = ref obj;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 4:
				_ = ref obj;
				_ = ref obj;
				if (true)
				{
					_ = 1;
				}
				break;
			case 1:
				return (object)(&obj);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_F600(nint P_0, object P_1, uint P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777519, new IntPtr(2737367883884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_F700(object P_0, nint P_1, uint P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_005e: Expected I4, but got Obj
		//IL_00a0: Invalid comparison between Unknown and Obj
		//IL_0077: Expected Obj, but got I4
		//IL_0093: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I4
		//IL_0245->IL021b: Incompatible stack heights: 2 vs 0
		//IL_021b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01f4->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0083->IL0019: Incompatible stack heights: 0 vs 1
		//IL_020e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b1->IL0019: Incompatible stack heights: 0 vs 1
		//IL_009d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01d7->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0253->IL0015: Incompatible stack heights: 2 vs 0
		//IL_026d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0111->IL0115: Incompatible stack types: I4 vs Ref
		//IL_01ff->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0074->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0239->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00bc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01e2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0278->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0288->IL0019: Incompatible stack heights: 4 vs 1
		//IL_013a->IL0115: Incompatible stack heights: 3 vs 2
		//IL_0145->IL0115: Incompatible stack heights: 3 vs 2
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
				case 11:
					if (this == null)
					{
						obj2 = 4;
						break;
					}
					goto case 6;
				case 14:
					obj = 0;
					if (3 != 0)
					{
						obj2 = 9;
					}
					break;
				case 1:
					return;
				default:
				{
					object obj3 = obj;
					if ((object)/*Error near IL_00a5: Stack underflow*/ != obj3)
					{
						if (3 == 0)
						{
							obj2 = 5;
						}
						break;
					}
					goto case 4;
				}
				case 9:
				{
					ref object reference = ref obj;
					if (false)
					{
						reference = ref *(object*)null;
					}
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 1u:
							break;
						default:
							_ = ref obj;
							if (true)
							{
								_ = 1;
							}
							continue;
						}
						break;
					}
					goto default;
				}
				case 3:
					return;
				case 2:
					if ((int)P_2 > 0)
					{
						obj = P_2;
						obj2 = 10;
					}
					else if (true)
					{
						obj2 = 1;
					}
					break;
				case 10:
					_ = 0;
					if (false)
					{
						_ = 11;
					}
					break;
				case 4:
				case 13:
				case 15:
					obj = P_0;
					_ = 7;
					break;
				case 6:
					obj = (object)/*Error near IL_0211: Stack underflow*/;
					obj2 = 14;
					break;
				case 12:
					obj2 = obj;
					obj = obj;
					if (15 != 0)
					{
						obj2 = 13;
					}
					break;
				case 5:
					if (&obj == null)
					{
						goto end_IL_0019;
					}
					goto case 12;
				case 7:
					if (this == null)
					{
						if (8 != 0)
						{
							obj2 = 6;
						}
					}
					else
					{
						_ = 3;
					}
					break;
				case 8:
					return;
				}
				continue;
				end_IL_0019:
				break;
			}
			obj = 13;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_F800(Action<string, byte[]> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00c2: Expected Obj, but got I4
		//IL_00a5->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0089->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c7->IL0015: Incompatible stack heights: 2 vs 0
		//IL_00b0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0094->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0050->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0079->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005b->IL0019: Incompatible stack types: I4 vs Obj
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
					if (obj == obj)
					{
						if (2 == 0)
						{
							obj2 = 2;
						}
						continue;
					}
					break;
				case 5:
					obj2 = obj;
					obj = P_0;
					if (1 == 0)
					{
						obj2 = 4;
					}
					continue;
				case 1:
					obj = this;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					return;
				case 4:
					goto end_IL_0019;
				}
				obj = obj;
				if (5 != 0)
				{
					obj2 = 4;
				}
				continue;
				end_IL_0019:
				break;
			}
			obj = obj;
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00豈(Action<string, byte[]> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777518, new IntPtr(2737367883884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FE00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777517, new IntPtr(2737367883884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_021c: Expected Obj, but got I4
		//IL_0190: Invalid comparison between Ref and Obj
		//IL_00b1: Expected I4, but got Obj
		//IL_0228->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0074->IL0078: Incompatible stack types: I4 vs Obj
		//IL_0059->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004a->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0233->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0064->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0251->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01bb->IL0078: Incompatible stack heights: 4 vs 3
		//IL_0182->IL0078: Incompatible stack heights: 4 vs 3
		//IL_0195->IL0130: Incompatible stack heights: 1 vs 2
		//IL_0141->IL0078: Incompatible stack heights: 5 vs 3
		//IL_0152->IL0078: Incompatible stack heights: 4 vs 3
		//IL_00c7->IL0078: Incompatible stack heights: 6 vs 3
		//IL_0125->IL0078: Incompatible stack heights: 4 vs 3
		//IL_00f7->IL0078: Incompatible stack heights: 4 vs 3
		//IL_018d->IL0078: Incompatible stack heights: 4 vs 3
		//IL_01a1->IL0078: Incompatible stack heights: 1 vs 3
		//IL_016e->IL0078: Incompatible stack types: I4 vs Obj
		//IL_0130->IL0078: Incompatible stack heights: 4 vs 3
		//IL_00dc->IL0078: Incompatible stack heights: 2 vs 3
		//IL_01ac->IL0078: Incompatible stack heights: 1 vs 3
		//IL_00e7->IL0078: Incompatible stack heights: 2 vs 3
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
				_ = 5;
				break;
			case 2:
				obj = (object)/*Error near IL_004d: Stack underflow*/;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
			{
				object obj3 = 10;
				while (true)
				{
					switch ((int)obj3)
					{
					case 2:
						break;
					case 7:
						_ = 11;
						continue;
					case 11:
						if (P_0 == null)
						{
							if (1 == 0)
							{
								_ = 1;
							}
							continue;
						}
						goto case 9;
					case 10:
						obj = P_0;
						_ = 4;
						continue;
					case 1:
						return;
					case 12:
						return;
					case 9:
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
					case 5:
						_ = 3;
						continue;
					case 6:
						_ = 7;
						continue;
					case 8:
						obj3 = P_0;
						if (6 == 0)
						{
							obj3 = 5;
						}
						continue;
					case 3:
						if (2 != 0)
						{
							_ = 2;
						}
						continue;
					case 4:
						if (Unsafe.AreSame(ref *(byte*)(&obj), ref *(byte*)obj))
						{
							if (8 != 0)
							{
								_ = 7;
							}
							continue;
						}
						goto case 5;
					default:
						_ = 12;
						continue;
					}
					break;
				}
				goto case 4;
			}
			default:
				obj = 0;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			case 5:
				return;
			case 3:
				obj2 = P_0;
				if (2 != 0)
				{
					obj2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00Ԁ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777516, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_0600(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0062: Expected I4, but got Obj
		//IL_02c2: Expected Obj, but got I4
		//IL_015b: Invalid comparison between Ref and Obj
		//IL_016d: Invalid comparison between Ref and Obj
		//IL_00c8: Expected I4, but got Obj
		//IL_035f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0323->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0312->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0254->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0097: Incompatible stack types: I4 vs Obj
		//IL_02cc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_033f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02db->IL0019: Incompatible stack heights: 2 vs 1
		//IL_026f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02ed->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02a5->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0285->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02fe->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02b0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0109->IL0097: Incompatible stack heights: 5 vs 3
		//IL_0114->IL0158: Incompatible stack heights: 4 vs 2
		//IL_01b0->IL00f8: Incompatible stack heights: 4 vs 2
		//IL_0160->IL016a: Incompatible stack heights: 1 vs 2
		//IL_013c->IL0097: Incompatible stack heights: 4 vs 3
		//IL_0172->IL01a4: Incompatible stack heights: 1 vs 2
		//IL_0290->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0120->IL0097: Incompatible stack heights: 4 vs 3
		//IL_01a4->IL0097: Incompatible stack types: I4 vs Obj
		//IL_01bc->IL0097: Incompatible stack heights: 4 vs 3
		//IL_016a->IL0097: Incompatible stack heights: 2 vs 3
		//IL_017e->IL0097: Incompatible stack heights: 1 vs 3
		//IL_012b->IL0097: Incompatible stack heights: 4 vs 3
		//IL_01c7->IL0097: Incompatible stack heights: 4 vs 3
		//IL_0189->IL0097: Incompatible stack heights: 1 vs 3
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 10:
				return;
			case 13:
			{
				object obj3 = 3;
				while (true)
				{
					switch ((int)obj3)
					{
					case 2:
						return;
					case 1:
						_ = ref obj;
						_ = 9;
						continue;
					case 3:
						if (&obj == null)
						{
							if (2 != 0)
							{
								_ = 4;
							}
							continue;
						}
						goto case 7;
					case 4:
					case 8:
						_ = ref obj;
						_ = 10;
						continue;
					case 7:
						if (Unsafe.AreSame(ref *(byte*)(&obj), ref *(byte*)obj))
						{
							_ = 8;
							continue;
						}
						goto case 10;
					case 10:
						if (Unsafe.AreSame(ref *(byte*)(&obj), ref *(byte*)obj))
						{
							if (2 != 0)
							{
								_ = 5;
							}
							continue;
						}
						goto case 6;
					case 5:
						obj3 = P_0;
						if (2 == 0)
						{
							obj3 = 2;
						}
						continue;
					case 6:
						if (&obj != null)
						{
							if (false)
							{
								_ = 0;
							}
							continue;
						}
						goto case 1;
					}
					break;
				}
				goto case 15;
			}
			case 11:
				obj = obj;
				obj2 = 7;
				break;
			case 9:
				return;
			case 6:
				obj2 = obj;
				if (0 == 0)
				{
					obj2 = 2;
				}
				break;
			case 12:
				return;
			case 14:
				if (11 == 0)
				{
					_ = 1;
				}
				break;
			case 8:
				if ((nint)obj <= 0)
				{
					return;
				}
				if (2 != 0)
				{
					obj2 = 14;
				}
				break;
			case 16:
				obj = 0;
				obj2 = 13;
				break;
			case 3:
				return;
			case 5:
				_ = 9;
				break;
			case 7:
				if (obj == null)
				{
					obj2 = 5;
					break;
				}
				goto case 4;
			case 15:
				if (obj == null)
				{
					obj2 = 10;
					break;
				}
				goto case 8;
			case 4:
				_ = ((Array)obj).Length;
				_ = 6;
				break;
			case 2:
				_ = ((Array)obj).Length;
				_ = 3;
				break;
			case 1:
				obj2 = this;
				obj = P_0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				obj = (object)/*Error near IL_0355: Stack underflow*/;
				obj2 = 16;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00ࠀ(Action<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777515, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_0900(Action<string> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_006e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0099->IL0019: Incompatible stack heights: 0 vs 1
		//IL_007e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0050->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0089->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005b->IL0019: Incompatible stack types: I4 vs Obj
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
				if (obj == obj)
				{
					if (false)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 4;
			case 3:
				obj = obj;
				_ = 2;
				break;
			case 5:
				obj = this;
				if (0 == 0)
				{
					obj2 = 4;
				}
				break;
			case 4:
				obj = obj;
				if (1 == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				obj2 = obj;
				obj = P_0;
				if (false)
				{
					obj2 = 3;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_FF00ༀ(nint P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_005a: Expected I4, but got Obj
		//IL_0123: Expected Obj, but got I4
		//IL_018c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_013d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_019a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0074->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00bd->IL0019: Incompatible stack heights: 4 vs 1
		//IL_00d1->IL0019: Incompatible stack heights: 3 vs 1
		//IL_015d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_008e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0148->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00fb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00dc->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0168->IL0019: Incompatible stack heights: 3 vs 1
		//IL_017d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0110->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ac->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 13;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 4:
					if (9 == 0)
					{
						_ = 3;
					}
					break;
				case 13:
					obj = P_1;
					obj2 = 12;
					break;
				case 8:
					return;
				case 9:
					_ = 5;
					_ = 8;
					break;
				case 10:
					if (1 == 0)
					{
						_ = 1;
					}
					break;
				case 5:
					return;
				case 7:
					obj2 = obj;
					if (10 == 0)
					{
						obj2 = 10;
					}
					break;
				case 14:
					return;
				case 11:
					if (obj != null)
					{
						goto end_IL_0019;
					}
					if (obj == null)
					{
						obj2 = 6;
						break;
					}
					goto case 7;
				case 2:
					if (false)
					{
						_ = 0;
					}
					break;
				case 12:
					if (11 == 0)
					{
						_ = 2;
					}
					break;
				case 1:
					return;
				case 6:
					if (obj != null)
					{
						obj2 = 4;
						break;
					}
					obj2 = obj;
					if (4 == 0)
					{
						obj2 = 5;
					}
					break;
				default:
					_ = 14;
					break;
				case 3:
					_ = 2;
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
	private unsafe void _FF00_FF00_FF00_FF00_FF00က(nint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777514, new IntPtr(2737367883884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00ᄀ(Action<string> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_004d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0083->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_005b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a9->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 5:
				return;
			case 1:
				obj = P_0;
				_ = 2;
				continue;
			case 4:
				obj = this;
				obj2 = 3;
				continue;
			default:
				if (obj == obj)
				{
					obj2 = 5;
					continue;
				}
				break;
			case 2:
				obj = obj;
				if (0 == 0)
				{
					_ = 0;
				}
				continue;
			case 3:
				break;
			}
			obj = obj;
			if (0 == 0)
			{
				obj2 = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00ሀ(Action<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777513, new IntPtr(2737367883884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00ጀ(Action<Exception> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_007f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_008a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0069->IL0019: Incompatible stack types: I4 vs Obj
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
				obj = this;
				obj2 = 2;
				continue;
			default:
				if (obj == obj)
				{
					if (5 == 0)
					{
						obj2 = 5;
					}
					continue;
				}
				break;
			case 5:
				return;
			case 1:
				obj = obj;
				if (false)
				{
					_ = 0;
				}
				continue;
			case 4:
				obj2 = obj;
				obj = P_0;
				if (true)
				{
					obj2 = 0;
				}
				continue;
			case 2:
				break;
			}
			obj = obj;
			obj2 = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00ᔀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777512, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00ᘀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0063->IL0019: Incompatible stack heights: 3 vs 1
		//IL_009d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0072->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0055->IL0019: Incompatible stack heights: 3 vs 1
		//IL_008d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007d->IL0019: Incompatible stack types: I4 vs Obj
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
				_ = 327680;
				_ = 4;
				break;
			default:
				_ = 5;
				break;
			case 2:
				obj = (object)/*Error near IL_0066: Stack underflow*/;
				if (0 == 0)
				{
					obj2 = 1;
				}
				break;
			case 5:
				_ = 3;
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00ᜀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777511, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_2B00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777510, new IntPtr(2737367893244L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00Ⰰ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_006a: Expected I4, but got Obj
		//IL_0960: Expected Obj, but got I4
		//IL_0792: Expected Obj, but got I4
		//IL_04e8: Expected Obj, but got Ref
		//IL_04f1: Expected Obj, but got I4
		//IL_0413: Expected Obj, but got Ref
		//IL_04c2: Expected I4, but got Obj
		//IL_0304: Expected I4, but got Obj
		//IL_044b: Expected Obj, but got I4
		//IL_0577: Expected Obj, but got Ref
		//IL_036f: Expected Obj, but got Ref
		//IL_08b6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_09db->IL0019: Incompatible stack heights: 2 vs 1
		//IL_09b1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_08c3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_09e7->IL09cc: Incompatible stack heights: 2 vs 0
		//IL_09a4->IL0019: Incompatible stack heights: 3 vs 1
		//IL_096a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_093f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0996->IL0019: Incompatible stack heights: 2 vs 1
		//IL_09cc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008c->IL0090: Incompatible stack types: I4 vs Ref
		//IL_0a1a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_09f3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0986->IL0019: Incompatible stack types: I4 vs Obj
		//IL_095d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0930->IL0019: Incompatible stack types: I4 vs Obj
		//IL_08f9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_08df->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0665->IL0090: Incompatible stack heights: 3 vs 2
		//IL_068a->IL071c: Incompatible stack heights: 3 vs 1
		//IL_01ef->IL0090: Incompatible stack types: Obj vs Ref
		//IL_018c->IL0196: Incompatible stack heights: 0 vs 1
		//IL_06f1->IL0090: Incompatible stack types: Obj vs Ref
		//IL_0653->IL0090: Incompatible stack types: I4 vs Ref
		//IL_013f->IL067f: Incompatible stack heights: 2 vs 1
		//IL_070d->IL0090: Incompatible stack heights: 4 vs 2
		//IL_02b0->IL0090: Incompatible stack heights: 3 vs 2
		//IL_067f->IL0090: Incompatible stack heights: 3 vs 2
		//IL_0223->IL0090: Incompatible stack heights: 4 vs 2
		//IL_0281->IL0090: Incompatible stack heights: 3 vs 2
		//IL_01a3->IL0090: Incompatible stack types: I4 vs Ref
		//IL_0293->IL0090: Incompatible stack heights: 4 vs 2
		//IL_0267->IL0090: Incompatible stack heights: 1 vs 2
		//IL_01c3->IL0090: Incompatible stack heights: 1 vs 2
		//IL_0233->IL0090: Incompatible stack heights: 1 vs 2
		//IL_076a->IL0090: Incompatible stack heights: 3 vs 2
		//IL_06c4->IL0090: Incompatible stack heights: 1 vs 2
		//IL_072e->IL0090: Incompatible stack heights: 1 vs 2
		//IL_01b2->IL0090: Incompatible stack heights: 3 vs 2
		//IL_074c->IL0090: Incompatible stack heights: 4 vs 2
		//IL_0208->IL0090: Incompatible stack types: I4 vs Ref
		//IL_017b->IL0090: Incompatible stack heights: 3 vs 2
		//IL_09fe->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0670->IL0090: Incompatible stack heights: 3 vs 2
		//IL_0694->IL0090: Incompatible stack heights: 4 vs 2
		//IL_01fa->IL0090: Incompatible stack types: I4 vs Ref
		//IL_0196->IL0090: Incompatible stack heights: 1 vs 2
		//IL_06fc->IL0090: Incompatible stack types: I4 vs Ref
		//IL_06a7->IL0090: Incompatible stack heights: 1 vs 2
		//IL_0149->IL0090: Incompatible stack heights: 3 vs 2
		//IL_082b->IL0090: Incompatible stack heights: 5 vs 2
		//IL_0820->IL0820: Incompatible stack heights: 5 vs 4
		//IL_07a9->IL07af: Incompatible stack heights: 4 vs 5
		//IL_02bb->IL0090: Incompatible stack heights: 3 vs 2
		//IL_0788->IL0788: Incompatible stack heights: 5 vs 4
		//IL_029e->IL0090: Incompatible stack heights: 4 vs 2
		//IL_07ef->IL07f5: Incompatible stack heights: 4 vs 5
		//IL_0272->IL0090: Incompatible stack heights: 1 vs 2
		//IL_01ce->IL0090: Incompatible stack heights: 1 vs 2
		//IL_023e->IL0090: Incompatible stack heights: 1 vs 2
		//IL_01e0->IL0090: Incompatible stack types: I4 vs Ref
		//IL_07cc->IL07d2: Incompatible stack heights: 4 vs 5
		//IL_0775->IL0090: Incompatible stack heights: 3 vs 2
		//IL_06cf->IL0090: Incompatible stack heights: 1 vs 2
		//IL_0739->IL0090: Incompatible stack heights: 1 vs 2
		//IL_0757->IL0090: Incompatible stack heights: 4 vs 2
		//IL_0213->IL0090: Incompatible stack types: I4 vs Ref
		//IL_0186->IL0090: Incompatible stack heights: 3 vs 2
		//IL_06e2->IL0090: Incompatible stack types: I4 vs Ref
		//IL_06b2->IL0090: Incompatible stack heights: 1 vs 2
		//IL_07ba->IL0090: Incompatible stack heights: 6 vs 2
		//IL_0090->IL0090: Incompatible stack heights: 5 vs 2
		//IL_0802->IL0090: Incompatible stack heights: 5 vs 2
		//IL_043c->IL02eb: Incompatible stack heights: 2 vs 1
		//IL_07dd->IL0090: Incompatible stack heights: 6 vs 2
		//IL_04a1->IL04a1: Incompatible stack heights: 2 vs 1
		//IL_04c2->IL04f6: Incompatible stack heights: 0 vs 1
		//IL_04c2->IL04e3: Incompatible stack heights: 0 vs 1
		//IL_0515->IL04a1: Incompatible stack types: I4 vs Obj
		//IL_080d->IL0090: Incompatible stack heights: 5 vs 2
		//IL_0304->IL040e: Incompatible stack heights: 0 vs 1
		//IL_0304->IL042a: Incompatible stack heights: 0 vs 1
		//IL_042a->IL02eb: Incompatible stack types: I4 vs Obj
		//IL_04d8->IL04a1: Incompatible stack heights: 0 vs 1
		//IL_05fd->IL04a1: Incompatible stack heights: 2 vs 1
		//IL_060d->IL06e2: Incompatible stack heights: 0 vs 1
		//IL_0455->IL0670: Incompatible stack heights: 0 vs 1
		//IL_0309->IL040e: Incompatible stack heights: 0 vs 1
		//IL_04e3->IL04a1: Incompatible stack types: I4 vs Obj
		//IL_0608->IL04a1: Incompatible stack heights: 2 vs 1
		//IL_05e9->IL04a1: Incompatible stack types: I4 vs Obj
		//IL_058e->IL0529: Incompatible stack heights: 1 vs 0
		//IL_0562->IL0529: Incompatible stack heights: 1 vs 0
		//IL_0386->IL032a: Incompatible stack heights: 1 vs 0
		//IL_03c4->IL032a: Incompatible stack heights: 1 vs 0
		//IL_0593->IL04f6: Incompatible stack heights: 0 vs 1
		//IL_0572->IL0529: Incompatible stack heights: 4 vs 0
		//IL_03c9->IL042a: Incompatible stack heights: 0 vs 1
		//IL_039a->IL032a: Incompatible stack heights: 2 vs 0
		//IL_035f->IL032a: Incompatible stack heights: 4 vs 0
		//IL_03a5->IL032a: Incompatible stack heights: 2 vs 0
		//IL_036a->IL032a: Incompatible stack heights: 4 vs 0
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
			{
				object obj3 = obj;
				ref object reference = ref obj;
				if (4 == 0)
				{
					reference = ref *(object*)3;
				}
				while (true)
				{
					switch ((uint)Unsafe.AsPointer(ref reference))
					{
					case 9u:
						if (P_0 != null)
						{
							_ = 31;
							continue;
						}
						goto case 2u;
					case 37u:
						if (26 != 0)
						{
							_ = 24;
						}
						continue;
					case 4u:
						if (obj3 != null)
						{
							_ = 13;
							continue;
						}
						goto case 19u;
					case 19u:
						reference = ref *(object*)24;
						continue;
					case 34u:
						_ = 7;
						continue;
					case 26u:
						obj = obj;
						if (11 == 0)
						{
							_ = 7;
						}
						continue;
					case 28u:
						if (this != null)
						{
							reference = ref *(object*)6;
							continue;
						}
						goto case 9u;
					case 3u:
						reference = ref *(object*)obj;
						if (13 != 0)
						{
							reference = ref *(object*)33;
						}
						continue;
					case 36u:
						reference = ref *(object*)1;
						if (27 == 0)
						{
							reference = ref *(object*)8;
						}
						continue;
					case 17u:
						_ = 18;
						continue;
					case 13u:
					case 27u:
						obj = P_0;
						if (3 != 0)
						{
							_ = 15;
						}
						continue;
					case 24u:
						if (34 == 0)
						{
							_ = 36;
						}
						continue;
					case 18u:
						_ = 21;
						continue;
					default:
						if (true)
						{
							_ = 1;
						}
						continue;
					case 15u:
						if (10 == 0)
						{
							_ = 32;
						}
						continue;
					case 25u:
						while (true)
						{
							IL_042a:
							if (&obj == null)
							{
								_ = 2;
								goto IL_02eb;
							}
							goto IL_040e;
							IL_02eb:
							while (true)
							{
								switch ((int)obj3)
								{
								case 4:
									while (true)
									{
										IL_03a5:
										if (&obj == null)
										{
											if (0 == 0)
											{
												_ = 1;
											}
											goto IL_032a;
										}
										goto IL_036a;
										IL_036a:
										obj = (object)(&obj);
										if (2 == 0)
										{
											_ = 0;
										}
										goto IL_032a;
										IL_032a:
										while (true)
										{
											switch ((int)/*Error near IL_0343: Stack underflow*/)
											{
											case 3:
												if (false)
												{
													_ = 0;
												}
												continue;
											case 4:
												break;
											case 2:
												if (3 == 0)
												{
													_ = 3;
												}
												continue;
											default:
												goto IL_03a5;
											case 1:
												goto end_IL_03a5;
											}
											break;
										}
										goto IL_036a;
										continue;
										end_IL_03a5:
										break;
									}
									goto IL_042a;
								case 1:
									goto IL_042a;
								case 3:
									obj = obj;
									obj = 4;
									obj3 = obj;
									continue;
								case 2:
									goto end_IL_042a;
								}
								break;
							}
							goto IL_040e;
							IL_040e:
							obj = (object)(&obj);
							if (3 == 0)
							{
								obj3 = 3;
							}
							goto IL_02eb;
							continue;
							end_IL_042a:
							break;
						}
						goto case 16u;
					case 11u:
						while (true)
						{
							IL_04f6:
							if (&obj == null)
							{
								if (3 == 0)
								{
									obj3 = 1;
								}
								goto IL_04a1;
							}
							goto IL_04e3;
							IL_04e3:
							obj = (object)(&obj);
							obj = 2;
							goto IL_04a1;
							IL_04a1:
							while (true)
							{
								switch ((int)obj3)
								{
								default:
									obj = obj;
									if (false)
									{
										obj3 = 4;
									}
									continue;
								case 6:
									break;
								case 5:
									goto IL_04f6;
								case 4:
									while (true)
									{
										IL_0543:
										if (&obj == null)
										{
											if (0 == 0)
											{
												_ = 0;
											}
											goto IL_0529;
										}
										goto IL_0572;
										IL_0572:
										obj = (object)(&obj);
										if (1 == 0)
										{
											_ = 1;
										}
										goto IL_0529;
										IL_0529:
										while (true)
										{
											switch ((int)/*Error near IL_053e: Stack underflow*/)
											{
											case 3:
												goto IL_0543;
											case 1:
												_ = 3;
												continue;
											case 2:
												goto IL_0572;
											}
											break;
										}
										break;
									}
									goto IL_04f6;
								case 2:
									obj3 = this;
									obj = obj;
									if (0 == 0)
									{
										obj3 = 1;
									}
									continue;
								case 1:
									if (false)
									{
										_ = 0;
									}
									continue;
								case 3:
									goto end_IL_04f6;
								}
								break;
							}
							goto IL_04e3;
							continue;
							end_IL_04f6:
							break;
						}
						goto case 5u;
					case 8u:
						reference = ref *(object*)20;
						continue;
					case 1u:
						if (3 == 0)
						{
							_ = 28;
						}
						continue;
					case 16u:
						_ = 8;
						continue;
					case 2u:
					case 6u:
						if (&obj != null)
						{
							_ = 12;
							continue;
						}
						goto case 33u;
					case 7u:
						if (this == null)
						{
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						}
						goto case 17u;
					case 32u:
						obj = this;
						if (25 == 0)
						{
							_ = 25;
						}
						continue;
					case 38u:
						if ((nint)obj <= 0)
						{
							reference = ref *(object*)22;
							continue;
						}
						goto case 37u;
					case 5u:
						reference = ref *(object*)this;
						if (30 != 0)
						{
							reference = ref *(object*)27;
						}
						continue;
					case 12u:
						_ = 3;
						continue;
					case 33u:
						obj = this;
						if (22 == 0)
						{
							_ = 38;
						}
						continue;
					case 35u:
						if (2 != 0)
						{
							_ = 0;
						}
						continue;
					case 31u:
						if (30 == 0)
						{
							_ = 35;
						}
						continue;
					case 20u:
						if (this == null)
						{
							_ = null;
						}
						obj = 14;
						continue;
					case 14u:
						if (this == null)
						{
							_ = null;
						}
						_ = 29;
						continue;
					case 29u:
						if (this == null)
						{
							_ = null;
						}
						_ = 23;
						continue;
					case 23u:
						if (this == null)
						{
							_ = null;
						}
						if (8 == 0)
						{
							_ = 10;
						}
						continue;
					case 10u:
						if (this == null)
						{
							_ = null;
						}
						_ = 34;
						continue;
					case 22u:
					case 30u:
						break;
					}
					break;
				}
				goto case 13;
			}
			default:
				obj = (object)/*Error near IL_08ac: Stack underflow*/;
				obj2 = 10;
				break;
			case 6:
				_ = 12;
				break;
			case 17:
				obj2 = obj;
				if (6 == 0)
				{
					obj2 = 18;
				}
				break;
			case 15:
				obj2 = obj;
				if (17 == 0)
				{
					obj2 = 10;
				}
				break;
			case 14:
				obj2 = P_0;
				if (0 == 0)
				{
					obj2 = 9;
				}
				break;
			case 13:
				_ = 15;
				break;
			case 9:
				return;
			case 12:
				obj2 = this;
				if (11 != 0)
				{
					obj2 = 10;
				}
				break;
			case 10:
				obj = 0;
				obj2 = 3;
				break;
			case 11:
			case 16:
				obj2 = obj;
				if (5 == 0)
				{
					obj2 = 4;
				}
				break;
			case 18:
				_ = 2000;
				_ = 4;
				break;
			case 8:
				_ = 7;
				break;
			case 5:
				_ = 14;
				break;
			case 1:
				obj2 = P_0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				_ = 6;
				break;
			case 7:
				if (&obj == null)
				{
					if (10 != 0)
					{
						_ = 16;
					}
					break;
				}
				goto case 2;
			case 4:
				obj2 = obj;
				if (8 == 0)
				{
					obj2 = 6;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00ⴀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777509, new IntPtr(2737367883884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_2E00()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 5116, 1790777508, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777508, new IntPtr(2737367883884L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_2F00()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 5117, 1790777507, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777507, new IntPtr(2737367893244L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_3000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777506, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_3300()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_005f: Expected I4, but got Obj
		//IL_0236->IL0019: Incompatible stack heights: 2 vs 1
		//IL_021e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00e1->IL00e5: Incompatible stack heights: 1 vs 0
		//IL_0229->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0052->IL0056: Incompatible stack types: I4 vs Obj
		//IL_0150->IL010b: Incompatible stack heights: 0 vs 1
		//IL_013c->IL010b: Incompatible stack types: I4 vs Ref
		//IL_015b->IL010b: Incompatible stack types: I4 vs Ref
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
			{
				WebRtc webRtc = this;
				if (0 == 0)
				{
					webRtc = (WebRtc)0;
				}
				switch ((int)webRtc)
				{
				}
				goto case 3;
			}
			case 1:
				obj = this;
				if (false)
				{
					_ = 0;
				}
				switch ((int)/*Error near IL_00f2: Stack underflow*/)
				{
				default:
					while (true)
					{
						ref object reference;
						if (&obj == null)
						{
							if (0 == 0)
							{
								reference = ref *(object*)null;
							}
							goto IL_010b;
						}
						goto IL_0121;
						IL_0121:
						reference = ref obj;
						if (0 == 0)
						{
							reference = ref *(object*)1;
						}
						goto IL_010b;
						IL_010b:
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 2u:
							break;
						case 1u:
							continue;
						default:
							goto end_IL_00e5;
						}
						goto IL_0121;
					}
				case 1:
					break;
					end_IL_00e5:
					break;
				}
				break;
			case 3:
				if (true)
				{
					obj2 = 0;
				}
				continue;
			case 2:
				return;
			}
			_ = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00㘀(nint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_0050: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got Ref
		//IL_0193->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0060->IL0043: Incompatible stack heights: 2 vs 0
		//IL_0055->IL0015: Incompatible stack heights: 1 vs 0
		//IL_019e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0182->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0096->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0077->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00e5->IL00b7: Incompatible stack heights: 0 vs 1
		//IL_010c->IL00b7: Incompatible stack heights: 2 vs 1
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
				case 6:
					break;
				case 4:
					if (&obj != null)
					{
						if (3 == 0)
						{
							_ = 1;
						}
						continue;
					}
					break;
				case 5:
					return;
				case 3:
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 7:
					while (true)
					{
						int num;
						if (&obj == null)
						{
							if (true)
							{
								num = 1;
							}
							goto IL_00b7;
						}
						goto IL_00f0;
						IL_00f0:
						obj = (object)(&obj);
						num = 3;
						goto IL_00b7;
						IL_00b7:
						while (true)
						{
							switch (num)
							{
							case 2:
								break;
							default:
								goto IL_00f0;
							case 3:
								_ = ref obj;
								_ = 2;
								continue;
							case 1:
								goto end_IL_00d1;
							}
							break;
						}
						continue;
						end_IL_00d1:
						break;
					}
					goto case 2;
				case 1:
					return;
				case 2:
					obj2 = this;
					if (0 == 0)
					{
						obj2 = 1;
					}
					continue;
				default:
					obj = obj;
					if (7 == 0)
					{
						obj2 = 4;
					}
					continue;
				}
				break;
			}
			obj = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00㜀(nint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777505, new IntPtr(2737367917164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00㨀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777504, new IntPtr(2737367917164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_FF00㬀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		//IL_01e4: Expected Obj, but got I4
		//IL_0231: Expected Obj, but got I4
		//IL_0084: Expected I4, but got Obj
		//IL_01e1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01fb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0057->IL005b: Incompatible stack types: I4 vs Obj
		//IL_01c7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01ee->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01b5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01d2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0215->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0099->IL005b: Incompatible stack heights: 4 vs 3
		//IL_00ff->IL005b: Incompatible stack types: I4 vs Obj
		//IL_00f0->IL005b: Incompatible stack heights: 4 vs 3
		//IL_012e->IL005b: Incompatible stack heights: 4 vs 3
		//IL_00c5->IL005b: Incompatible stack heights: 4 vs 3
		//IL_0220->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0236->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0113->IL005b: Incompatible stack heights: 2 vs 3
		//IL_00e1->IL005b: Incompatible stack types: I4 vs Obj
		//IL_00b5->IL005b: Incompatible stack types: I4 vs Obj
		//IL_011e->IL005b: Incompatible stack heights: 2 vs 3
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
				{
					_ = ref obj;
					WebRtc webRtc = (WebRtc)8;
					while (true)
					{
						switch ((int)webRtc)
						{
						default:
							_ = 7;
							continue;
						case 8:
							webRtc = this;
							if (1 == 0)
							{
								webRtc = (WebRtc)1;
							}
							continue;
						case 7:
							_ = 5;
							continue;
						case 5:
							webRtc = this;
							if (3 != 0)
							{
								webRtc = (WebRtc)3;
							}
							continue;
						case 2:
							_ = 6;
							continue;
						case 1:
							webRtc = (WebRtc)4;
							continue;
						case 4:
							if (this == null)
							{
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							}
							goto case 7;
						case 3:
							_ = 2;
							continue;
						case 6:
							break;
						}
						break;
					}
					goto case 5;
				}
				case 8:
					return;
				case 2:
					obj2 = P_0;
					if (1 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 5:
					if (8 == 0)
					{
						_ = 8;
					}
					continue;
				case 1:
					obj = P_0;
					_ = 6;
					continue;
				case 7:
					obj = 0;
					obj2 = 4;
					continue;
				default:
					obj = (object)/*Error near IL_01f1: Stack underflow*/;
					obj2 = 7;
					continue;
				case 6:
					if (this == null)
					{
						if (0 == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					obj = 3;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00㰀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777439, new IntPtr(2737367917164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00㴀(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 5131, 1790777438, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790777438, new IntPtr(2737367917164L), 15);
		}
		return ((delegate*<object, object, object, object>)obj)(this, P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00㸀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777437, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00㼀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 5133, 1790777436, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790777436, new IntPtr(2737367884924L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00䀀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777435, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
