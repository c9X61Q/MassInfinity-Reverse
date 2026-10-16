using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mass.Application.Desktop;
using Mass.Common.Extensions;
using Mass.Domain.Desktop.Entities.LanGame;
using Serilog;

namespace Mass.Game.Launcher.Java.LanGame;

public class LanGameProxy : IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAcceptLoopAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TcpListener listener;

		public LanGameProxy _003C_003E4__this;

		private TaskAwaiter<TcpClient> _003C_003Eu__1;

		internal static object DecorateResponsiveVerifier;

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
		internal static bool PresentDecider()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckCombinedComparator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00ꘀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777584, new IntPtr(2737367884924L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_A700(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00ꠀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777583, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00꤀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777582, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00ꨀ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_AB00()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_021b: Expected Obj, but got Ref
			//IL_0224: Expected Obj, but got I4
			//IL_013f: Expected Obj, but got Ref
			//IL_00f7: Expected Obj, but got I4
			//IL_014e: Expected Obj, but got I4
			//IL_00ba: Expected Obj, but got Ref
			//IL_00c3: Expected Obj, but got I4
			//IL_016b: Expected Obj, but got Ref
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0239->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_025e->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0244->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0149->IL007a: Incompatible stack types: I4 vs Ref
			//IL_006b->IL007a: Incompatible stack heights: 0 vs 1
			//IL_0056->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0076->IL007a: Incompatible stack types: I4 vs Ref
			//IL_0102->IL007a: Incompatible stack heights: 3 vs 1
			//IL_00d8->IL007a: Incompatible stack heights: 2 vs 1
			//IL_015b->IL007a: Incompatible stack heights: 2 vs 1
			//IL_0187->IL007a: Incompatible stack types: Obj vs Ref
			//IL_01a2->IL007a: Incompatible stack heights: 4 vs 1
			//IL_0175->IL007a: Incompatible stack types: I4 vs Ref
			//IL_00e3->IL007a: Incompatible stack heights: 2 vs 1
			//IL_0166->IL007a: Incompatible stack heights: 2 vs 1
			//IL_0192->IL007a: Incompatible stack types: I4 vs Ref
			//IL_0116->IL007a: Incompatible stack heights: 0 vs 1
			//IL_013b->IL007a: Incompatible stack types: I4 vs Ref
			//IL_007a->IL007a: Incompatible stack types: Obj vs Ref
			//IL_0121->IL007a: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			while (true)
			{
				ref _003CAcceptLoopAsync_003Ed__8 reference = ref *(_003CAcceptLoopAsync_003Ed__8*)obj;
				while (true)
				{
					ref _003CAcceptLoopAsync_003Ed__8 reference2;
					switch ((uint)Unsafe.AsPointer(ref reference))
					{
					case 4u:
						obj = (object)Unsafe.AsPointer(ref this);
						if (false)
						{
							reference = ref *(_003CAcceptLoopAsync_003Ed__8*)3;
						}
						continue;
					case 1u:
						return;
					case 3u:
						if (obj != null)
						{
							if (10 == 0)
							{
								reference2 = ref *(_003CAcceptLoopAsync_003Ed__8*)7;
							}
							goto IL_007a;
						}
						goto IL_013b;
					case 5u:
						break;
					case 2u:
						goto IL_0229;
					default:
						{
							reference = ref this;
							if (true)
							{
								reference = ref *(_003CAcceptLoopAsync_003Ed__8*)1;
							}
							continue;
						}
						IL_007a:
						while (true)
						{
							switch ((uint)Unsafe.AsPointer(ref reference2))
							{
							case 8u:
								return;
							case 10u:
								obj = (object)Unsafe.AsPointer(ref this);
								obj = 6;
								reference2 = ref *(_003CAcceptLoopAsync_003Ed__8*)obj;
								continue;
							case 1u:
								if (7 == 0)
								{
									_ = 1;
								}
								continue;
							default:
								obj = -1;
								_ = 11;
								continue;
							case 6u:
								if (&obj == null)
								{
									if (true)
									{
										reference2 = ref *(_003CAcceptLoopAsync_003Ed__8*)2;
									}
									continue;
								}
								goto case 11u;
							case 9u:
								reference2 = ref this;
								if (false)
								{
									reference2 = ref *(_003CAcceptLoopAsync_003Ed__8*)null;
								}
								continue;
							case 4u:
								break;
							case 2u:
								obj = 0;
								if (0 == 0)
								{
									_ = 1;
								}
								continue;
							case 11u:
								obj = (object)(&obj);
								reference2 = ref *(_003CAcceptLoopAsync_003Ed__8*)3;
								continue;
							case 3u:
								reference2 = ref *(_003CAcceptLoopAsync_003Ed__8*)obj;
								if (5 != 0)
								{
									reference2 = ref *(_003CAcceptLoopAsync_003Ed__8*)4;
								}
								continue;
							case 7u:
								_ = ref obj;
								_ = 8;
								continue;
							case 5u:
								goto IL_0229;
							}
							break;
						}
						goto IL_013b;
						IL_0229:
						_ = -2;
						if (false)
						{
							_ = 0;
						}
						continue;
						IL_013b:
						obj = (object)Unsafe.AsPointer(ref this);
						reference2 = ref *(_003CAcceptLoopAsync_003Ed__8*)9;
						goto IL_007a;
					}
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
				obj = 4;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00가()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777581, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00관()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00글()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777580, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CListenAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LanGameProxy _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object StartRecord;

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
		internal static bool ResumeContext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ArrangeMapper()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00鸀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777579, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00鼀(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00ꀀ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00ꄀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777578, new IntPtr(2737367884924L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00ꌀ()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_02fd: Expected Obj, but got Ref
			//IL_0318: Expected Obj, but got Ref
			//IL_0269: Expected Obj, but got I4
			//IL_0106: Expected Obj, but got Ref
			//IL_018a: Expected Obj, but got I4
			//IL_0124: Expected Obj, but got I4
			//IL_033e->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0309->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0324->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0048->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0314->IL0019: Incompatible stack types: I4 vs Obj
			//IL_032f->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0258->IL006b: Incompatible stack heights: 1 vs 0
			//IL_0067->IL006b: Incompatible stack heights: 1 vs 0
			//IL_006b->IL006b: Incompatible stack heights: 1 vs 0
			//IL_0102->IL009b: Incompatible stack types: I4 vs Ref
			//IL_0097->IL009b: Incompatible stack heights: 1 vs 2
			//IL_00d0->IL00ef: Incompatible stack heights: 1 vs 0
			//IL_0110->IL009b: Incompatible stack types: I4 vs Ref
			//IL_01b2->IL009b: Incompatible stack heights: 5 vs 2
			//IL_0197->IL009b: Incompatible stack heights: 3 vs 2
			//IL_012f->IL009b: Incompatible stack heights: 4 vs 2
			//IL_0185->IL009b: Incompatible stack heights: 4 vs 2
			//IL_00ef->IL009b: Incompatible stack types: I4 vs Ref
			//IL_0177->IL009b: Incompatible stack types: I4 vs Ref
			//IL_01a2->IL009b: Incompatible stack heights: 3 vs 2
			//IL_0141->IL009b: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				scoped ref byte reference;
				switch ((int)obj2)
				{
				case 5:
					_ = 4;
					continue;
				case 3:
					if (obj == null)
					{
						if (1 == 0)
						{
							_ = 0;
						}
						goto IL_006b;
					}
					goto IL_0258;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (3 != 0)
					{
						obj2 = 3;
					}
					continue;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 4:
					return;
					IL_0258:
					if (obj == null)
					{
						obj = 3;
						goto IL_006b;
					}
					goto IL_024d;
					IL_024d:
					_ = 2;
					goto IL_006b;
					IL_006b:
					switch ((int)/*Error near IL_0080: Stack underflow*/)
					{
					case 2:
						if (obj == null)
						{
							_ = 5;
							goto IL_009b;
						}
						goto IL_00ef;
					case 1:
						break;
					default:
						goto IL_0258;
					case 3:
						goto end_IL_0019;
						IL_009b:
						while (true)
						{
							switch ((uint)Unsafe.AsPointer(ref reference))
							{
							case 2u:
								reference = ref *(byte*)(&obj);
								if (0 == 0)
								{
									reference = ref *(byte*)null;
								}
								continue;
							case 9u:
								break;
							case 1u:
							case 5u:
								obj = (object)Unsafe.AsPointer(ref this);
								reference = ref *(byte*)3;
								continue;
							case 8u:
								obj = 0;
								_ = 11;
								continue;
							case 10u:
								if (&obj == null)
								{
									reference = ref *(byte*)8;
									continue;
								}
								goto case 2u;
							case 6u:
								return;
							case 3u:
								reference = ref Unsafe.As<_003CListenAsync_003Ed__7, byte>(ref this);
								if (7 == 0)
								{
									reference = ref *(byte*)7;
								}
								continue;
							case 11u:
								_ = 4;
								continue;
							case 7u:
								obj = -1;
								if (2 == 0)
								{
									_ = 2;
								}
								continue;
							case 4u:
								_ = ref obj;
								_ = 6;
								continue;
							default:
								goto IL_0258;
							}
							break;
						}
						goto IL_00ef;
						IL_00ef:
						obj = obj;
						reference = ref *(byte*)10;
						goto IL_009b;
					}
					goto IL_024d;
					end_IL_0019:
					break;
				}
				_ = -2;
				_ = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00ꐀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777577, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00ꔀ()
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
	private struct _003CReceiveAsync_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LanGameProxy _003C_003E4__this;

		public TcpClient client;

		private object _003Ctransfer_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		internal static object ReflectEfficientStrategy;

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
		internal static bool CheckAttachedSorter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectGlobalConfig()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00鐀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777576, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00销(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00阀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00需()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777575, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00騀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_0043: Expected Obj, but got Ref
			//IL_006c: Expected Obj, but got Ref
			//IL_0121: Expected Obj, but got I4
			//IL_03fe: Expected Obj, but got Ref
			//IL_022d: Expected Obj, but got Ref
			//IL_0381: Expected Obj, but got I4
			//IL_039e: Expected Obj, but got I4
			//IL_03a8: Expected Obj, but got I4
			//IL_03d1: Expected Obj, but got Ref
			//IL_01d6: Expected Obj, but got I4
			//IL_01f4: Expected Obj, but got Ref
			//IL_0258: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0086->IL0019: Incompatible stack heights: 2 vs 1
			//IL_009e->IL0019: Incompatible stack heights: 3 vs 1
			//IL_004d->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0076->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0091->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0067->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0110->IL00c2: Incompatible stack heights: 1 vs 0
			//IL_00be->IL00c2: Incompatible stack heights: 1 vs 0
			//IL_00ed->IL00c2: Incompatible stack heights: 3 vs 0
			//IL_00f8->IL00c2: Incompatible stack heights: 3 vs 0
			//IL_02f8->IL012a: Incompatible stack heights: 1 vs 0
			//IL_012a->IL012a: Incompatible stack heights: 1 vs 0
			//IL_0408->IL0334: Incompatible stack types: I4 vs Ref
			//IL_0325->IL0334: Incompatible stack heights: 0 vs 1
			//IL_0160->IL016f: Incompatible stack heights: 0 vs 1
			//IL_0310->IL012a: Incompatible stack heights: 1 vs 0
			//IL_0330->IL0334: Incompatible stack types: I4 vs Ref
			//IL_04f5->IL012a: Incompatible stack heights: 1 vs 0
			//IL_038e->IL0334: Incompatible stack heights: 2 vs 1
			//IL_045f->IL0334: Incompatible stack heights: 3 vs 1
			//IL_037c->IL0334: Incompatible stack heights: 3 vs 1
			//IL_03dd->IL0334: Incompatible stack heights: 2 vs 1
			//IL_01e3->IL016f: Incompatible stack heights: 2 vs 1
			//IL_01b2->IL016f: Incompatible stack heights: 2 vs 1
			//IL_0229->IL016f: Incompatible stack heights: 4 vs 1
			//IL_0219->IL016f: Incompatible stack heights: 3 vs 1
			//IL_020b->IL016f: Incompatible stack heights: 2 vs 1
			//IL_0265->IL016f: Incompatible stack heights: 2 vs 1
			//IL_0399->IL0334: Incompatible stack heights: 2 vs 1
			//IL_046a->IL0334: Incompatible stack heights: 3 vs 1
			//IL_03c7->IL0334: Incompatible stack types: I4 vs Ref
			//IL_03fa->IL0334: Incompatible stack types: I4 vs Ref
			//IL_0334->IL0334: Incompatible stack heights: 3 vs 1
			//IL_03e8->IL0334: Incompatible stack heights: 2 vs 1
			//IL_043e->IL0334: Incompatible stack types: I4 vs Ref
			//IL_01ee->IL016f: Incompatible stack heights: 2 vs 1
			//IL_0270->IL016f: Incompatible stack heights: 2 vs 1
			//IL_01c6->IL016f: Incompatible stack heights: 0 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			ref _003CReceiveAsync_003Ed__9 reference = ref *(_003CReceiveAsync_003Ed__9*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CReceiveAsync_003Ed__9*)6;
					break;
				case 5u:
					reference = ref this;
					if (2 == 0)
					{
						reference = ref *(_003CReceiveAsync_003Ed__9*)2;
					}
					break;
				case 2u:
					return;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CReceiveAsync_003Ed__9*)3;
					break;
				default:
					_ = -2;
					if (1 == 0)
					{
						_ = 1;
					}
					break;
				case 1u:
					_ = null;
					_ = 5;
					break;
				case 6u:
					{
						if ((nuint)(nint)obj > (nuint)1u)
						{
							if (true)
							{
								_ = 2;
							}
							goto IL_00c2;
						}
						goto IL_00f8;
					}
					IL_00f8:
					if (0 == 0)
					{
						_ = 0;
					}
					goto IL_00c2;
					IL_00c2:
					while (true)
					{
						switch ((int)/*Error near IL_00d3: Stack underflow*/)
						{
						case 2:
							if (true)
							{
								_ = 0;
							}
							continue;
						case 1:
							break;
						default:
							goto IL_0110;
						}
						break;
					}
					goto IL_00f8;
					IL_0110:
					if (obj != null)
					{
						obj = 3;
						goto IL_012a;
					}
					goto IL_02e0;
					IL_02e0:
					if (1 == 0)
					{
						_ = 2;
					}
					goto IL_012a;
					IL_012a:
					while (true)
					{
						int num;
						ref byte reference2;
						switch ((int)/*Error near IL_0147: Stack underflow*/)
						{
						case 1:
							break;
						case 2:
							if (obj != null)
							{
								if (3 != 0)
								{
									num = 0;
								}
								goto IL_016f;
							}
							goto IL_0229;
						case 4:
							goto IL_02e0;
						case 5:
							goto IL_02f8;
						default:
							if ((nint)obj != 1)
							{
								if (2 == 0)
								{
									reference2 = ref *(byte*)10;
								}
								goto IL_0334;
							}
							goto IL_03fa;
						case 3:
							{
								if ((nint)obj != 1)
								{
									if (2 == 0)
									{
										_ = 4;
									}
									continue;
								}
								goto IL_02f8;
							}
							IL_016f:
							while (true)
							{
								switch (num)
								{
								case 6:
									return;
								case 1:
									_ = ref obj;
									_ = 4;
									continue;
								case 10:
									if (&obj == null)
									{
										if (false)
										{
											num = 0;
										}
										continue;
									}
									goto case 1;
								default:
									obj = 0;
									if (4 == 0)
									{
										_ = 7;
									}
									continue;
								case 3:
									obj = (object)Unsafe.AsPointer(ref this);
									num = 10;
									continue;
								case 8:
									_ = 9;
									continue;
								case 7:
									_ = 2;
									continue;
								case 2:
									_ = ref obj;
									_ = 6;
									continue;
								case 5:
									break;
								case 9:
									obj = -1;
									if (true)
									{
										_ = 0;
									}
									continue;
								case 4:
									goto IL_02f8;
								}
								break;
							}
							goto IL_0229;
							IL_02f8:
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
							IL_0229:
							obj = (object)Unsafe.AsPointer(ref this);
							num = 8;
							goto IL_016f;
							IL_03fa:
							obj = (object)Unsafe.AsPointer(ref this);
							reference2 = ref *(byte*)11;
							goto IL_0334;
							IL_0334:
							while (true)
							{
								switch ((uint)Unsafe.AsPointer(ref reference2))
								{
								case 7u:
									return;
								case 1u:
									break;
								case 8u:
									_ = 2;
									continue;
								default:
									obj = -1;
									if (3 != 0)
									{
										_ = 3;
									}
									continue;
								case 6u:
									obj = 1;
									obj = 8;
									continue;
								case 3u:
								case 5u:
									reference2 = ref *(byte*)(&obj);
									if (false)
									{
										reference2 = ref *(byte*)1;
									}
									continue;
								case 10u:
									obj = (object)Unsafe.AsPointer(ref this);
									if (0 == 0)
									{
										_ = 4;
									}
									continue;
								case 4u:
									if (&obj != null)
									{
										reference2 = ref *(byte*)5;
										continue;
									}
									goto case 6u;
								case 9u:
									goto IL_03fa;
								case 11u:
									reference2 = ref Unsafe.As<_003CReceiveAsync_003Ed__9, byte>(ref this);
									if (0 == 0)
									{
										reference2 = ref *(byte*)null;
									}
									continue;
								case 2u:
									_ = ref obj;
									if (5 != 0)
									{
										_ = 7;
									}
									continue;
								}
								break;
							}
							break;
						}
						break;
					}
					goto default;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00鬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777574, new IntPtr(2737367892204L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00鰀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00鴀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777573, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CReceiveGameDataAsync_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TcpClient client;

		public DesktopTransfer transfer;

		private object _003C_003E8__1;

		private object _003C_003E7__wrap1;

		private nint _003C_003E7__wrap2;

		private object _003Cbuffer_003E5__4;

		private ValueTaskAwaiter<int> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private ValueTaskAwaiter _003C_003Eu__3;

		internal static object CheckDetachedEmitter;

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
		internal static bool ReflectDetailedRunner()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectDividedClient()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00谀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777572, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00贀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00踀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777571, new IntPtr(2737367885964L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00輀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00退()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777570, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00鄀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_003b: Expected Obj, but got Ref
			//IL_0185: Expected Obj, but got Ref
			//IL_01b1: Expected Obj, but got Ref
			//IL_08d8: Expected Obj, but got I4
			//IL_07d6: Expected Obj, but got I4
			//IL_087a: Expected Obj, but got Ref
			//IL_0833: Expected Obj, but got Ref
			//IL_0825: Expected Obj, but got Ref
			//IL_0356: Expected Obj, but got Ref
			//IL_035f: Expected Obj, but got I4
			//IL_0376: Expected Obj, but got I4
			//IL_0380: Expected Obj, but got I4
			//IL_0320: Expected Obj, but got I4
			//IL_032a: Expected Obj, but got I4
			//IL_03e6: Expected Obj, but got I4
			//IL_039c: Expected Obj, but got Ref
			//IL_0334: Expected Obj, but got I4
			//IL_04db: Expected Obj, but got Ref
			//IL_0577: Expected Obj, but got Ref
			//IL_04f3: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0047->IL0019: Incompatible stack heights: 0 vs 1
			//IL_09bb->IL0019: Incompatible stack heights: 2 vs 1
			//IL_006c->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0052->IL0019: Incompatible stack types: I4 vs Ref
			//IL_09c6->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0800->IL0090: Incompatible stack heights: 1 vs 0
			//IL_008c->IL0090: Incompatible stack heights: 1 vs 0
			//IL_019c->IL0090: Incompatible stack heights: 1 vs 0
			//IL_07a9->IL0090: Incompatible stack heights: 1 vs 0
			//IL_01bb->IL0090: Incompatible stack heights: 1 vs 0
			//IL_08ba->IL0090: Incompatible stack heights: 2 vs 0
			//IL_091c->IL0090: Incompatible stack heights: 3 vs 0
			//IL_08e5->IL0090: Incompatible stack heights: 2 vs 0
			//IL_079a->IL0090: Incompatible stack heights: 1 vs 0
			//IL_08a0->IL0090: Incompatible stack heights: 2 vs 0
			//IL_07d1->IL0090: Incompatible stack heights: 4 vs 0
			//IL_0162->IL0090: Incompatible stack heights: 3 vs 0
			//IL_08d3->IL0090: Incompatible stack heights: 3 vs 0
			//IL_07c1->IL0090: Incompatible stack heights: 2 vs 0
			//IL_07e3->IL0090: Incompatible stack heights: 2 vs 0
			//IL_0857->IL0090: Incompatible stack heights: 3 vs 0
			//IL_0136->IL0090: Incompatible stack heights: 2 vs 0
			//IL_082f->IL0090: Incompatible stack heights: 1 vs 0
			//IL_07b4->IL0090: Incompatible stack heights: 1 vs 0
			//IL_078f->IL0090: Incompatible stack heights: 1 vs 0
			//IL_08c5->IL0090: Incompatible stack heights: 2 vs 0
			//IL_01d0->IL01df: Incompatible stack heights: 0 vs 4
			//IL_08f0->IL0090: Incompatible stack heights: 2 vs 0
			//IL_08ab->IL0090: Incompatible stack heights: 2 vs 0
			//IL_0934->IL0090: Incompatible stack heights: 2 vs 0
			//IL_0821->IL0090: Incompatible stack heights: 1 vs 0
			//IL_07ee->IL0090: Incompatible stack heights: 2 vs 0
			//IL_0891->IL0090: Incompatible stack heights: 1 vs 0
			//IL_084a->IL0090: Incompatible stack heights: 1 vs 0
			//IL_0155->IL0090: Incompatible stack heights: 1 vs 0
			//IL_01fc->IL0703: Incompatible stack heights: 3 vs 0
			//IL_01db->IL01df: Incompatible stack heights: 1 vs 4
			//IL_0181->IL0090: Incompatible stack heights: 1 vs 0
			//IL_06f8->IL01df: Incompatible stack heights: 5 vs 4
			//IL_06cf->IL01df: Incompatible stack heights: 3 vs 4
			//IL_0216->IL0225: Incompatible stack heights: 3 vs 6
			//IL_0703->IL01df: Incompatible stack heights: 5 vs 4
			//IL_06da->IL01df: Incompatible stack heights: 3 vs 4
			//IL_023e->IL0243: Incompatible stack heights: 5 vs 3
			//IL_0221->IL0225: Incompatible stack heights: 3 vs 6
			//IL_0651->IL06e9: Incompatible stack heights: 0 vs 3
			//IL_0291->IL0291: Incompatible stack heights: 6 vs 5
			//IL_0316->IL0352: Incompatible stack heights: 4 vs 5
			//IL_028d->IL0291: Incompatible stack types: I4 vs Ref
			//IL_05a0->IL0291: Incompatible stack heights: 6 vs 5
			//IL_05b0->IL064c: Incompatible stack heights: 0 vs 5
			//IL_037b->IL028d: Incompatible stack heights: 9 vs 5
			//IL_038d->IL0291: Incompatible stack heights: 6 vs 5
			//IL_032f->IL028d: Incompatible stack heights: 6 vs 5
			//IL_03e1->IL0291: Incompatible stack heights: 6 vs 5
			//IL_03f1->IL0291: Incompatible stack heights: 7 vs 5
			//IL_03a8->IL0291: Incompatible stack heights: 4 vs 5
			//IL_053c->IL0291: Incompatible stack heights: 6 vs 5
			//IL_0559->IL0291: Incompatible stack heights: 7 vs 5
			//IL_0512->IL0291: Incompatible stack heights: 7 vs 5
			//IL_033f->IL0291: Incompatible stack heights: 7 vs 5
			//IL_03c5->IL0291: Incompatible stack heights: 7 vs 5
			//IL_0572->IL0291: Incompatible stack heights: 7 vs 5
			//IL_04e5->IL0291: Incompatible stack types: I4 vs Ref
			//IL_052d->IL0291: Incompatible stack heights: 8 vs 5
			//IL_0581->IL0291: Incompatible stack types: I4 vs Ref
			//IL_04f8->IL028d: Incompatible stack heights: 4 vs 5
			//IL_041d->IL0291: Incompatible stack types: I4 vs Ref
			//IL_04d6->IL0291: Incompatible stack types: I4 vs Ref
			//IL_05ab->IL0291: Incompatible stack heights: 6 vs 5
			//IL_0398->IL0291: Incompatible stack heights: 6 vs 5
			//IL_0403->IL0291: Incompatible stack types: I4 vs Ref
			//IL_0458->IL0291: Incompatible stack types: I4 vs Ref
			//IL_04a8->IL0291: Incompatible stack types: I4 vs Ref
			//IL_03b3->IL0291: Incompatible stack heights: 4 vs 5
			//IL_0547->IL0291: Incompatible stack heights: 6 vs 5
			//IL_0564->IL0291: Incompatible stack heights: 7 vs 5
			//IL_051d->IL0291: Incompatible stack heights: 7 vs 5
			//IL_0489->IL0291: Incompatible stack types: I4 vs Ref
			//IL_046c->IL0291: Incompatible stack heights: 4 vs 5
			//IL_0446->IL0291: Incompatible stack types: I4 vs Ref
			//IL_0477->IL0291: Incompatible stack heights: 4 vs 5
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			ref _003CReceiveGameDataAsync_003Ed__10 reference = ref *(_003CReceiveGameDataAsync_003Ed__10*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 2u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						reference = ref *(_003CReceiveGameDataAsync_003Ed__10*)1;
					}
					continue;
				default:
					reference = ref this;
					if (3 == 0)
					{
						reference = ref *(_003CReceiveGameDataAsync_003Ed__10*)3;
					}
					continue;
				case 1u:
					if ((nuint)(nint)obj <= (nuint)1u)
					{
						if (2 == 0)
						{
							_ = 27;
						}
						goto IL_0090;
					}
					goto IL_07ee;
				case 3u:
					return;
				case 4u:
					break;
					IL_0090:
					while (true)
					{
						switch ((int)/*Error near IL_0115: Stack underflow*/)
						{
						case 30:
							return;
						case 28:
							_ = 10;
							continue;
						case 6:
							if (Unsafe.AsPointer(ref this) == null)
							{
								if (26 == 0)
								{
									_ = 5;
								}
								continue;
							}
							goto case 4;
						case 17:
							_ = null;
							_ = 7;
							continue;
						case 13:
							if (&obj != null)
							{
								if (12 != 0)
								{
									_ = 3;
								}
								continue;
							}
							goto case 23;
						case 3:
							break;
						case 4:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 25;
							continue;
						case 9:
							if ((nuint)(nint)obj <= (nuint)1u)
							{
								if (4 == 0)
								{
									_ = 4;
								}
								goto IL_01df;
							}
							goto IL_0703;
						case 2:
							if (obj == null)
							{
								_ = 16;
								continue;
							}
							goto IL_091c;
						case 11:
						case 27:
							_ = 9;
							continue;
						case 1:
						case 12:
							_ = ref obj;
							if (31 == 0)
							{
								_ = 13;
							}
							continue;
						case 21:
							_ = 8;
							continue;
						case 15:
							_ = ref obj;
							_ = 30;
							continue;
						case 23:
							obj = 2;
							if (11 == 0)
							{
								_ = 20;
							}
							continue;
						case 18:
							goto IL_07ee;
						case 22:
							if ((nint)obj == 1)
							{
								_ = 5;
								continue;
							}
							goto case 24;
						case 26:
						case 31:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 2;
							continue;
						case 16:
						case 29:
							obj = (object)Unsafe.AsPointer(ref this);
							if (14 == 0)
							{
								_ = 22;
							}
							continue;
						case 24:
							_ = null;
							_ = 14;
							continue;
						case 25:
							obj = (object)(&obj);
							if (13 == 0)
							{
								_ = 7;
							}
							continue;
						case 14:
							_ = null;
							if (false)
							{
								_ = 0;
							}
							continue;
						case 7:
							_ = 0;
							if (11 != 0)
							{
								_ = 1;
							}
							continue;
						case 20:
							_ = 15;
							continue;
						case 10:
							obj = -1;
							if (true)
							{
								_ = 0;
							}
							continue;
						case 8:
							_ = 17;
							continue;
						case 19:
							goto IL_091c;
						default:
							throw null;
						case 5:
							goto end_IL_0019;
							IL_0703:
							_ = 1;
							_ = 1;
							goto IL_01df;
							IL_01df:
							while (true)
							{
								scoped ref byte reference2;
								int num;
								switch (3)
								{
								case 1:
									if ((nuint)(nint)obj <= (nuint)1u)
									{
										if (0 == 0)
										{
											_ = 0;
										}
										goto IL_0225;
									}
									goto IL_0243;
								case 3:
								case 4:
									if (1 == 0)
									{
										_ = 0;
									}
									continue;
								case 2:
									goto IL_06e9;
								case 5:
									goto IL_0703;
									IL_0243:
									reference2 = ref Unsafe.As<_003CReceiveGameDataAsync_003Ed__10, byte>(ref this);
									num = 2;
									goto IL_0225;
									IL_0225:
									while (true)
									{
										switch (num)
										{
										case 3:
											break;
										default:
											num = 4;
											continue;
										case 4:
											if (obj != null)
											{
												if (13 != 0)
												{
													reference2 = ref *(byte*)23;
												}
												goto IL_0291;
											}
											goto IL_0352;
										case 1:
											goto IL_06e9;
											IL_0291:
											while (true)
											{
												switch ((uint)Unsafe.AsPointer(ref reference2))
												{
												case 7u:
													obj = -1;
													obj = 31;
													continue;
												case 21u:
													obj = 1;
													_ = 24;
													continue;
												case 4u:
													return;
												case 14u:
													break;
												case 5u:
													_ = 0;
													_ = 0;
													obj = 15;
													continue;
												case 6u:
													obj = 0;
													if (2 == 0)
													{
														_ = 1;
													}
													continue;
												case 16u:
													obj = (object)Unsafe.AsPointer(ref this);
													if (0 == 0)
													{
														_ = 0;
													}
													continue;
												case 22u:
													_ = 8192;
													_ = 13;
													continue;
												case 10u:
													_ = 11;
													continue;
												case 11u:
													obj = -1;
													_ = 29;
													continue;
												case 8u:
													if ((nint)obj <= 0)
													{
														reference2 = ref *(byte*)17;
														continue;
													}
													goto case 30u;
												default:
													reference2 = ref Unsafe.As<_003CReceiveGameDataAsync_003Ed__10, byte>(ref this);
													if (7 == 0)
													{
														reference2 = ref *(byte*)4;
													}
													continue;
												case 26u:
													return;
												case 9u:
												case 31u:
													reference2 = ref *(byte*)(&obj);
													if (11 != 0)
													{
														reference2 = ref *(byte*)12;
													}
													continue;
												case 12u:
												case 13u:
													if (Unsafe.AsPointer(ref this) == null)
													{
														reference2 = ref *(byte*)18;
														continue;
													}
													goto case 20u;
												case 28u:
													if (&obj == null)
													{
														if (0 == 0)
														{
															_ = 6;
														}
														continue;
													}
													goto case 29u;
												case 23u:
													if ((nint)obj != 1)
													{
														reference2 = ref *(byte*)22;
														continue;
													}
													goto case 16u;
												case 15u:
													reference2 = ref Unsafe.As<_003CReceiveGameDataAsync_003Ed__10, byte>(ref this);
													obj = obj;
													if (true)
													{
														reference2 = ref *(byte*)null;
													}
													continue;
												case 1u:
													if (&obj != null)
													{
														reference2 = ref *(byte*)9;
														continue;
													}
													goto case 21u;
												case 25u:
													obj = (object)(&obj);
													reference2 = ref *(byte*)28;
													continue;
												case 30u:
													obj = obj;
													obj = 5;
													continue;
												case 20u:
													_ = ref obj;
													obj = obj;
													if (25 != 0)
													{
														_ = 10;
													}
													continue;
												case 27u:
													_ = ref obj;
													_ = 4;
													continue;
												case 17u:
												case 18u:
													_ = null;
													if (3 != 0)
													{
														_ = 2;
													}
													continue;
												case 19u:
													_ = ref obj;
													if (25 == 0)
													{
														_ = 26;
													}
													continue;
												case 24u:
													_ = 27;
													continue;
												case 29u:
													obj = (object)(&obj);
													reference2 = ref *(byte*)8;
													continue;
												case 2u:
													if (19 == 0)
													{
														_ = 2;
													}
													continue;
												case 3u:
													goto IL_06e9;
												}
												break;
											}
											goto IL_0352;
											IL_0352:
											obj = (object)Unsafe.AsPointer(ref this);
											obj = 10;
											goto IL_0291;
										}
										break;
									}
									goto IL_0243;
									IL_06e9:
									_ = 1;
									if (0 == 0)
									{
										_ = 0;
									}
									continue;
								}
								break;
							}
							goto case 6;
						}
						break;
						IL_091c:
						if (obj == null)
						{
							throw obj;
						}
						_ = 29;
					}
					goto IL_0181;
					IL_07ee:
					if ((nint)obj != 2)
					{
						_ = 21;
						goto IL_0090;
					}
					goto IL_0181;
					IL_0181:
					obj = (object)Unsafe.AsPointer(ref this);
					if (28 != 0)
					{
						_ = 23;
					}
					goto IL_0090;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00鈀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00錀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777569, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	private static readonly object Logger;

	public int Port;

	private object? _listener;

	private static object DecorateEditableContext;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LanGameProxy(DesktopSession session, EntityLanGameRoom room)
	{
		//IL_0042: Expected I4, but got Obj
		//IL_0030->IL0039: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		LanGameProxy lanGameProxy = this;
		if (false)
		{
			lanGameProxy = (LanGameProxy)0;
		}
		switch ((int)lanGameProxy)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartListen(int port)
	{
		_FF00_FF00_FF00_FF00저((uint)port);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CListenAsync_003Ed__7))]
	private object ListenAsync()
	{
		return _FF00_FF00_FF00_FF00쨀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAcceptLoopAsync_003Ed__8))]
	private object AcceptLoopAsync(object listener)
	{
		return _FF00_FF00_FF00_FF00씀(listener);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReceiveAsync_003Ed__9))]
	private object ReceiveAsync(object client)
	{
		return _FF00_FF00_FF00_FF00밀(client);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReceiveGameDataAsync_003Ed__10))]
	private object ReceiveGameDataAsync(object transfer, object client)
	{
		return _FF00_FF00_FF00_FF00숀(transfer, client);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		_FF00_FF00_FF00_FF00섀();
	}

	static LanGameProxy()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_001f: Expected I4, but got Obj
		//IL_004d->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0058->IL0012: Incompatible stack types: I4 vs Obj
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
				Logger = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_FF00_FF00쐀());
				obj2 = 0;
				if (_003CModule_003E_007B8336717d_002D71de_002D47ce_002Dbc69_002D4d75223ebc5e_007D.m_d836f3f9b6194f49a23d85cb66f28ddf.m_1aef3360c092496fb40fb0a2a21e97e2 != 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SelectLogger()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LanGameProxy ReflectSimplePolicy()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00묀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777539, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00밀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 5003, 1790777538, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790777538, new IntPtr(2737367913004L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00봀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777537, new IntPtr(2737367887004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00븀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00뼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777536, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00섀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0048->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006e->IL0072: Incompatible stack heights: 1 vs 0
		//IL_0096->IL0072: Incompatible stack heights: 1 vs 0
		//IL_00a1->IL0072: Incompatible stack heights: 1 vs 0
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
				break;
			case 2:
				if (this == null)
				{
					if (true)
					{
						_ = 1;
					}
				}
				else if (0 == 0)
				{
					_ = 0;
				}
				switch ((int)/*Error near IL_007f: Stack underflow*/)
				{
				}
				break;
			case 0:
				return;
			}
			obj2 = this;
			if (false)
			{
				obj2 = 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00숀(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 5009, 1790777599, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790777599, new IntPtr(2737367904684L), 15);
		}
		return ((delegate*<object, object, object, object>)obj)(this, P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00쌀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777598, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00씀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 5012, 1790777597, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790777597, new IntPtr(2737367887004L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00였(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777596, new IntPtr(2737367892204L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00윀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777595, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00저(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0047->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0061->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0096->IL0019: Incompatible stack types: I4 vs Obj
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
				_ = 3;
				break;
			case 2:
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 3:
				obj2 = this;
				if (3 == 0)
				{
					obj2 = 4;
				}
				break;
			case 0:
				return;
			case 4:
				if (false)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00준(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777594, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00쨀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 5017, 1790777593, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777593, new IntPtr(2737367890124L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00쬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777592, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00찀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00촀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777591, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
