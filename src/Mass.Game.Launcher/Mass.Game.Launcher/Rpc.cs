using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Mass.Game.Launcher.Models;
using Serilog;

namespace Mass.Game.Launcher;

public class Rpc : IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CListenAsync_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Rpc _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object DecorateIterableWriter;

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
		internal static bool CheckIntegratedDic()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckLocalObject()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00稀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778531, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00笀(object P_0)
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
		internal static object _FF00簀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00紀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778530, new IntPtr(2737337545004L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00缀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778529, new IntPtr(2737337554364L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00耀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0330: Expected Obj, but got Ref
			//IL_02ec: Expected Obj, but got Ref
			//IL_011d: Expected Obj, but got Ref
			//IL_0192: Expected Obj, but got I4
			//IL_00f1: Expected Obj, but got I4
			//IL_0320->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0310->IL0019: Incompatible stack heights: 2 vs 1
			//IL_033c->IL0019: Incompatible stack heights: 0 vs 1
			//IL_02f8->IL0019: Incompatible stack heights: 0 vs 1
			//IL_032b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0347->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0303->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0078->IL0051: Incompatible stack heights: 0 vs 1
			//IL_025b->IL0051: Incompatible stack heights: 0 vs 1
			//IL_0134->IL00a6: Incompatible stack heights: 1 vs 0
			//IL_00a2->IL00a6: Incompatible stack heights: 1 vs 0
			//IL_0173->IL00a6: Incompatible stack heights: 2 vs 0
			//IL_0182->IL00a6: Incompatible stack heights: 1 vs 0
			//IL_00ec->IL00a6: Incompatible stack heights: 4 vs 0
			//IL_0119->IL00a6: Incompatible stack heights: 3 vs 0
			//IL_0143->IL00a6: Incompatible stack heights: 1 vs 0
			//IL_019f->IL00a6: Incompatible stack heights: 2 vs 0
			//IL_00fc->IL00a6: Incompatible stack heights: 3 vs 0
			//IL_018d->IL00a6: Incompatible stack heights: 1 vs 0
			//IL_0160->IL00a6: Incompatible stack heights: 1 vs 0
			//IL_014e->IL00a6: Incompatible stack heights: 1 vs 0
			//IL_01aa->IL00a6: Incompatible stack heights: 2 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 2:
					if (obj == null)
					{
						num = 3;
						goto IL_0051;
					}
					goto IL_0247;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					if (3 != 0)
					{
						obj2 = 1;
					}
					break;
				case 1:
					_ = 5;
					break;
				default:
					goto IL_0310;
				case 5:
					return;
				case 3:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (2 == 0)
						{
							obj2 = 2;
						}
						break;
					}
					IL_0310:
					_ = -2;
					if (false)
					{
						_ = 1;
					}
					break;
					IL_0051:
					switch (num)
					{
					case 3:
						break;
					case 1:
						if (obj != null)
						{
							if (0 == 0)
							{
								_ = 0;
							}
							goto IL_00a6;
						}
						goto IL_0119;
					case 2:
						goto IL_0247;
					default:
						goto IL_0310;
						IL_0119:
						obj = (object)Unsafe.AsPointer(ref this);
						if (true)
						{
							_ = 1;
						}
						goto IL_00a6;
						IL_00a6:
						while (true)
						{
							switch ((int)/*Error near IL_00d7: Stack underflow*/)
							{
							case 3:
								_ = ref obj;
								_ = 2;
								continue;
							case 10:
								obj = -1;
								_ = 8;
								continue;
							case 2:
								return;
							case 7:
								_ = 3;
								continue;
							case 6:
								break;
							case 8:
								_ = ref obj;
								if (false)
								{
									_ = 4;
								}
								continue;
							case 5:
								if (&obj == null)
								{
									_ = 9;
									continue;
								}
								goto case 8;
							default:
								obj = obj;
								_ = 5;
								continue;
							case 1:
								if (6 != 0)
								{
									_ = 10;
								}
								continue;
							case 9:
								obj = 0;
								if (4 != 0)
								{
									_ = 7;
								}
								continue;
							case 4:
								goto IL_0247;
							}
							break;
						}
						goto IL_0119;
					}
					goto IL_006b;
					IL_006b:
					if (0 == 0)
					{
						num = 1;
					}
					goto IL_0051;
					IL_0247:
					if (obj == null)
					{
						if (0 == 0)
						{
							num = 0;
						}
						goto IL_0051;
					}
					goto IL_006b;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00脀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778528, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00舀()
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
	private struct _003CListenControlConnectAsync_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TcpListener listener;

		public Rpc _003C_003E4__this;

		private TaskAwaiter<TcpClient> _003C_003Eu__1;

		private static object ReflectSymbolicDecorator;

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
		internal static bool DecorateConfigurableArgument()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateSeparatedSummarizer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00渀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778463, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00漀(object P_0)
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
		private unsafe sealed void _FF00瀀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778462, new IntPtr(2737337545004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00焀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778461, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00爀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00瘀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0367: Expected Obj, but got Ref
			//IL_034c: Expected Obj, but got Ref
			//IL_01a5: Expected Obj, but got Ref
			//IL_0196: Expected Obj, but got I4
			//IL_0187: Expected Obj, but got Ref
			//IL_020b: Expected Obj, but got I4
			//IL_015a: Expected Obj, but got I4
			//IL_01d5: Expected Obj, but got Ref
			//IL_01f1: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0373->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0358->IL0019: Incompatible stack heights: 0 vs 1
			//IL_033c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_037e->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0363->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0347->IL0019: Incompatible stack heights: 2 vs 1
			//IL_01af->IL006b: Incompatible stack types: I4 vs Ref
			//IL_0067->IL006b: Incompatible stack types: I4 vs Ref
			//IL_0055->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0101->IL006b: Incompatible stack heights: 3 vs 1
			//IL_01a1->IL006b: Incompatible stack heights: 3 vs 1
			//IL_0191->IL006b: Incompatible stack types: I4 vs Ref
			//IL_01e1->IL006b: Incompatible stack heights: 0 vs 1
			//IL_0283->IL006b: Incompatible stack heights: 0 vs 1
			//IL_029c->IL006b: Incompatible stack heights: 3 vs 1
			//IL_014e->IL006b: Incompatible stack heights: 3 vs 1
			//IL_00e4->IL006b: Incompatible stack types: Obj vs Ref
			//IL_01fc->IL006b: Incompatible stack heights: 3 vs 1
			//IL_0222->IL006b: Incompatible stack heights: 3 vs 1
			//IL_0111->IL006b: Incompatible stack types: I4 vs Ref
			//IL_006b->IL006b: Incompatible stack heights: 2 vs 1
			//IL_01ec->IL006b: Incompatible stack types: I4 vs Ref
			//IL_0182->IL006b: Incompatible stack types: I4 vs Ref
			//IL_0247->IL006b: Incompatible stack types: I4 vs Ref
			//IL_028e->IL006b: Incompatible stack types: I4 vs Ref
			//IL_0170->IL006b: Incompatible stack types: I4 vs Ref
			//IL_00ef->IL006b: Incompatible stack types: I4 vs Ref
			//IL_01c4->IL006b: Incompatible stack heights: 0 vs 1
			//IL_022d->IL006b: Incompatible stack heights: 3 vs 1
			//IL_02bb->IL006b: Incompatible stack heights: 3 vs 1
			//IL_01cf->IL006b: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			ref _003CListenControlConnectAsync_003Ed__35 reference = ref *(_003CListenControlConnectAsync_003Ed__35*)obj;
			while (true)
			{
				ref _003CListenControlConnectAsync_003Ed__35 reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 5u:
					reference = ref this;
					if (0 == 0)
					{
						reference = ref *(_003CListenControlConnectAsync_003Ed__35*)2;
					}
					break;
				case 4u:
					if (obj != null)
					{
						reference2 = ref *(_003CListenControlConnectAsync_003Ed__35*)10;
						goto IL_006b;
					}
					goto IL_01a1;
				case 3u:
					goto IL_032c;
				case 2u:
					return;
				case 1u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						reference = ref *(_003CListenControlConnectAsync_003Ed__35*)null;
					}
					break;
				default:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (2 == 0)
						{
							reference = ref *(_003CListenControlConnectAsync_003Ed__35*)4;
						}
						break;
					}
					IL_006b:
					while (true)
					{
						object obj2;
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						case 19u:
							reference2 = ref *(_003CListenControlConnectAsync_003Ed__35*)obj;
							if (14 != 0)
							{
								reference2 = ref *(_003CListenControlConnectAsync_003Ed__35*)9;
							}
							continue;
						default:
							_ = 19;
							continue;
						case 23u:
							obj = obj;
							reference2 = ref *(_003CListenControlConnectAsync_003Ed__35*)15;
							continue;
						case 17u:
							_ = 6;
							continue;
						case 9u:
							obj2 = obj;
							obj = 8;
							continue;
						case 18u:
							if (obj != null)
							{
								reference2 = ref *(_003CListenControlConnectAsync_003Ed__35*)4;
								continue;
							}
							goto case 1u;
						case 12u:
							if (&obj == null)
							{
								reference2 = ref *(_003CListenControlConnectAsync_003Ed__35*)20;
								continue;
							}
							goto case 3u;
						case 3u:
							obj = (object)(&obj);
							reference2 = ref *(_003CListenControlConnectAsync_003Ed__35*)23;
							continue;
						case 2u:
							obj = -1;
							_ = 3;
							continue;
						case 11u:
							break;
						case 4u:
						case 21u:
							if (obj == null)
							{
								if (0 == 0)
								{
									reference2 = ref *(_003CListenControlConnectAsync_003Ed__35*)null;
								}
								continue;
							}
							goto case 17u;
						case 10u:
							obj = (object)Unsafe.AsPointer(ref this);
							if (3 != 0)
							{
								reference2 = ref *(_003CListenControlConnectAsync_003Ed__35*)12;
							}
							continue;
						case 20u:
							obj = 0;
							_ = 16;
							continue;
						case 6u:
							obj2 = obj;
							obj = 7;
							continue;
						case 22u:
							_ = ref obj;
							if (5 != 0)
							{
								_ = 0;
							}
							continue;
						case 13u:
							reference2 = ref this;
							if (2 == 0)
							{
								reference2 = ref *(_003CListenControlConnectAsync_003Ed__35*)2;
							}
							continue;
						case 5u:
							return;
						case 15u:
							obj = obj;
							if (18 == 0)
							{
								reference2 = ref *(_003CListenControlConnectAsync_003Ed__35*)15;
							}
							continue;
						case 16u:
							_ = 22;
							continue;
						case 1u:
							_ = 9;
							continue;
						case 7u:
						case 8u:
						case 14u:
							goto IL_032c;
						}
						break;
					}
					goto IL_01a1;
					IL_032c:
					_ = -2;
					if (5 != 0)
					{
						_ = 5;
					}
					break;
					IL_01a1:
					obj = (object)Unsafe.AsPointer(ref this);
					reference2 = ref *(_003CListenControlConnectAsync_003Ed__35*)13;
					goto IL_006b;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00眀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778460, new IntPtr(2737337545004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00砀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00礀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778459, new IntPtr(2737337535644L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CReceiveAsync_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TcpClient client;

		public Rpc _003C_003E4__this;

		internal static object CheckMonoProgram;

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
		internal static bool DecorateOrderedTemplate()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectVisualAuditor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00昀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778458, new IntPtr(2737337554364L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00最(object P_0)
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
		internal static object _FF00栀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00椀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778457, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00欀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_0073: Expected Obj, but got Ref
			//IL_0277: Expected Obj, but got Ref
			//IL_0129: Expected I4, but got Obj
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0283->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0062->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0052->IL0019: Incompatible stack types: I4 vs Ref
			//IL_028e->IL0019: Incompatible stack types: I4 vs Ref
			//IL_006d->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00d5->IL0081: Incompatible stack heights: 2 vs 1
			//IL_00b8->IL0081: Incompatible stack heights: 0 vs 1
			//IL_00e0->IL0081: Incompatible stack heights: 2 vs 1
			//IL_011c->IL0120: Incompatible stack types: I4 vs Obj
			//IL_01d2->IL0081: Incompatible stack heights: 0 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			ref _003CReceiveAsync_003Ed__28 reference = ref *(_003CReceiveAsync_003Ed__28*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 0u:
					return;
				case 1u:
					reference = ref this;
					if (0 == 0)
					{
						reference = ref *(_003CReceiveAsync_003Ed__28*)null;
					}
					break;
				case 4u:
					_ = -2;
					if (0 == 0)
					{
						_ = 1;
					}
					break;
				case 2u:
				{
					obj = (object)Unsafe.AsPointer(ref this);
					int num = 5;
					while (true)
					{
						switch (num)
						{
						case 1:
							break;
						case 5:
							obj = obj;
							if (false)
							{
								num = 0;
							}
							continue;
						default:
							if (4 != 0)
							{
								_ = 4;
							}
							continue;
						case 2:
						{
							object obj2 = obj;
							if (false)
							{
								obj2 = 0;
							}
							switch ((int)obj2)
							{
							}
							goto case 4;
						}
						case 4:
						case 6:
							if (Unsafe.AsPointer(ref this) == null)
							{
								if (1 == 0)
								{
									num = 1;
								}
								continue;
							}
							goto case 3;
						case 3:
							num = 2;
							continue;
						}
						break;
					}
					goto case 4u;
				}
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 != 0)
					{
						reference = ref *(_003CReceiveAsync_003Ed__28*)2;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00氀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778456, new IntPtr(2737337545004L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00洀()
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
	private struct _003CRemoteCallBackAsync_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Rpc _003C_003E4__this;

		public RpcCallBack callBack;

		private TaskAwaiter _003C_003Eu__1;

		internal static object MeasureCalc;

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
		internal static bool RemoveTree()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ConvertFilter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00嬀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778455, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00尀(object P_0)
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
		internal static object _FF00崀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00帀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778454, new IntPtr(2737337554364L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00戀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0040: Expected Obj, but got Ref
			//IL_0393: Expected Obj, but got Ref
			//IL_02f2: Expected Obj, but got I4
			//IL_00a1: Expected Obj, but got Ref
			//IL_01b1: Expected Obj, but got Ref
			//IL_0239: Expected Obj, but got I4
			//IL_0156: Expected Obj, but got Ref
			//IL_0191: Expected Obj, but got I4
			//IL_01c0: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_004a->IL0019: Incompatible stack types: I4 vs Ref
			//IL_039f->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0058->IL0019: Incompatible stack heights: 3 vs 1
			//IL_03aa->IL0019: Incompatible stack types: I4 vs Ref
			//IL_038f->IL0019: Incompatible stack types: I4 vs Ref
			//IL_006a->IL006e: Incompatible stack heights: 1 vs 0
			//IL_00e1->IL006e: Incompatible stack heights: 1 vs 0
			//IL_02d2->IL006e: Incompatible stack heights: 2 vs 0
			//IL_00ab->IL006e: Incompatible stack heights: 2 vs 0
			//IL_02dd->IL006e: Incompatible stack heights: 2 vs 0
			//IL_006e->IL006e: Incompatible stack heights: 4 vs 0
			//IL_00f5->IL0104: Incompatible stack heights: 0 vs 2
			//IL_00c9->IL006e: Incompatible stack heights: 1 vs 0
			//IL_013d->IL01a9: Incompatible stack heights: 1 vs 0
			//IL_0100->IL0104: Incompatible stack heights: 1 vs 2
			//IL_018c->IL0104: Incompatible stack heights: 3 vs 2
			//IL_0162->IL0104: Incompatible stack heights: 1 vs 2
			//IL_0152->IL0104: Incompatible stack heights: 5 vs 2
			//IL_019e->IL0104: Incompatible stack heights: 3 vs 2
			//IL_0210->IL0104: Incompatible stack heights: 3 vs 2
			//IL_01cd->IL0104: Incompatible stack heights: 3 vs 2
			//IL_0104->IL0104: Incompatible stack heights: 4 vs 2
			//IL_016d->IL0104: Incompatible stack heights: 1 vs 2
			//IL_01a9->IL0104: Incompatible stack heights: 3 vs 2
			//IL_01d8->IL0104: Incompatible stack heights: 3 vs 2
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			ref _003CRemoteCallBackAsync_003Ed__21 reference = ref *(_003CRemoteCallBackAsync_003Ed__21*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 0u:
					return;
				case 1u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CRemoteCallBackAsync_003Ed__21*)5;
					break;
				case 3u:
					_ = -2;
					_ = 4;
					break;
				case 5u:
					if (obj != null)
					{
						_ = 6;
						goto IL_006e;
					}
					goto IL_00c9;
				case 4u:
					reference = ref this;
					if (0 == 0)
					{
						reference = ref *(_003CRemoteCallBackAsync_003Ed__21*)null;
					}
					break;
				case 2u:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (1 == 0)
						{
							reference = ref *(_003CRemoteCallBackAsync_003Ed__21*)1;
						}
						break;
					}
					IL_006e:
					while (true)
					{
						int num;
						switch ((int)/*Error near IL_0093: Stack underflow*/)
						{
						case 6:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 5;
							continue;
						case 5:
							if (obj == null)
							{
								if (true)
								{
									_ = 1;
								}
								continue;
							}
							goto case 3;
						case 4:
							goto IL_00c9;
						case 7:
							if (obj == null)
							{
								if (5 == 0)
								{
									_ = 8;
								}
								goto IL_0104;
							}
							goto IL_01a9;
						case 1:
							if (false)
							{
								_ = 2;
							}
							continue;
						case 3:
							{
								obj = 4;
								continue;
							}
							IL_01a9:
							obj = (object)Unsafe.AsPointer(ref this);
							num = 5;
							goto IL_0104;
							IL_0104:
							while (true)
							{
								switch (num)
								{
								case 10:
									return;
								case 6:
									break;
								case 7:
									_ = ref obj;
									_ = 10;
									continue;
								case 2:
								case 8:
									obj = (object)Unsafe.AsPointer(ref this);
									if (11 == 0)
									{
										_ = 8;
									}
									continue;
								case 5:
									if (&obj != null)
									{
										num = 3;
										continue;
									}
									goto case 12;
								default:
									_ = ref obj;
									_ = 6;
									continue;
								case 9:
									obj = -1;
									if (0 == 0)
									{
										_ = 0;
									}
									continue;
								case 4:
									goto IL_01a9;
								case 12:
									obj = 0;
									if (0 == 0)
									{
										_ = 1;
									}
									continue;
								case 11:
									_ = 9;
									continue;
								case 1:
									obj = 7;
									continue;
								}
								break;
							}
							break;
						}
						break;
					}
					goto case 3u;
					IL_00c9:
					if (6 == 0)
					{
						_ = 7;
					}
					goto IL_006e;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00挀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778453, new IntPtr(2737337564764L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00搀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00攀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778452, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSyncChaChaAsync_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Rpc _003C_003E4__this;

		public RpcCallBack callBack;

		private static object RateStack;

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
		internal static bool DecorateConnectedMapper()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckAlphabeticPolicy()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00刀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778451, new IntPtr(2737337545004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00匀(object P_0)
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
		private unsafe sealed void _FF00吀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778450, new IntPtr(2737337539804L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00唀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00嘀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778449, new IntPtr(2737337534604L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00堀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_01d7: Expected Obj, but got Ref
			//IL_00f4: Expected Obj, but got Ref
			//IL_011c: Expected Obj, but got I4
			//IL_01e3->IL0019: Incompatible stack heights: 0 vs 1
			//IL_01fb->IL0019: Incompatible stack heights: 2 vs 1
			//IL_01c8->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004a->IL004e: Incompatible stack heights: 1 vs 0
			//IL_01ee->IL0019: Incompatible stack types: I4 vs Obj
			//IL_01d3->IL0019: Incompatible stack heights: 2 vs 1
			//IL_010b->IL004e: Incompatible stack heights: 1 vs 0
			//IL_0138->IL004e: Incompatible stack heights: 1 vs 0
			//IL_00ae->IL004e: Incompatible stack heights: 5 vs 0
			//IL_00e4->IL004e: Incompatible stack heights: 4 vs 0
			//IL_0126->IL004e: Incompatible stack heights: 5 vs 0
			//IL_00c4->IL004e: Incompatible stack heights: 2 vs 0
			//IL_00ef->IL004e: Incompatible stack heights: 4 vs 0
			//IL_00cf->IL004e: Incompatible stack heights: 2 vs 0
			//IL_009b->IL004e: Incompatible stack heights: 1 vs 0
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
					if (obj == null)
					{
						_ = 8;
						goto IL_004e;
					}
					goto IL_00ef;
				case 3:
					goto IL_01b8;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				case 2:
					_ = 4;
					break;
				case 4:
					return;
					IL_01b8:
					_ = -2;
					if (2 == 0)
					{
						_ = 1;
					}
					break;
					IL_004e:
					while (true)
					{
						switch ((int)/*Error near IL_0077: Stack underflow*/)
						{
						case 3:
							if (obj != null)
							{
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							}
							goto IL_01b8;
						case 1:
							_ = 8;
							_ = 0;
							_ = 2;
							continue;
						case 7:
							_ = obj == null;
							if (3 != 0)
							{
								_ = 2;
							}
							continue;
						case 4:
							_ = 8;
							_ = 1;
							if (1 == 0)
							{
								_ = 0;
							}
							continue;
						case 6:
							break;
						case 5:
							_ = 16;
							_ = 16;
							obj = 16;
							_ = 4;
							continue;
						default:
							obj = obj;
							_ = 5;
							continue;
						case 2:
						case 8:
							goto IL_01b8;
						}
						break;
					}
					goto IL_00ef;
					IL_00ef:
					obj = (object)Unsafe.AsPointer(ref this);
					if (7 == 0)
					{
						_ = 7;
					}
					goto IL_004e;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00夀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00娀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778448, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	private object _chaChaEn;

	private object _chaChaDe;

	private static object ParseMap;

	public int ProcessId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00萀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00글((uint)value);
		}
	}

	private ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ILogger)_FF00鸀();
		}
	}

	public bool NeedCha
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00销() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_A700(value ? ((byte)1) : ((byte)0));
		}
	}

	private bool UseCha
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00謀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00ꈀ(value ? ((byte)1) : ((byte)0));
		}
	}

	private Dictionary<ushort, Func<RpcCallBack, Task>> Callbacks
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00蜀();
		}
	}

	protected BinaryWriter? Writer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (BinaryWriter?)_FF00褀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00딀(value);
		}
	}

	private TcpListener? Listener
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (TcpListener?)_FF00눀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00谀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected Rpc(ILogger logger, bool needCha = false)
	{
		//IL_0046: Expected I4, but got Obj
		//IL_0028->IL0031: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0031: Incompatible stack heights: 3 vs 2
		//IL_0079->IL0031: Incompatible stack heights: 5 vs 2
		//IL_005a->IL0031: Incompatible stack heights: 3 vs 2
		//IL_009e->IL0031: Incompatible stack heights: 3 vs 2
		//IL_0084->IL0031: Incompatible stack heights: 5 vs 2
		//IL_0065->IL0031: Incompatible stack heights: 3 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		Rpc rpc = this;
		if (0 == 0)
		{
			rpc = (Rpc)0;
		}
		while (true)
		{
			switch ((int)rpc)
			{
			case 3:
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 2:
				return;
			case 1:
				_ = 0;
				if (2 == 0)
				{
					_ = 2;
				}
				break;
			default:
				if (2 != 0)
				{
					_ = 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendMessage(BinaryWriter writer, params object[] values)
	{
		_FF00관(writer, values);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void AddCallBack(ushort sid, Func<RpcCallBack, Task> callback)
	{
		_FF00넀(sid, callback);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoteCallBackAsync_003Ed__21))]
	private object RemoteCallBackAsync(object callBack)
	{
		return _FF00ꀀ(callBack);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartListen(int port)
	{
		_FF00_AB00((uint)port);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		_FF00蔀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReceiveAsync_003Ed__28))]
	private object ReceiveAsync(object client)
	{
		return _FF00鐀(client);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReceiveControlData(object reader, object writer)
	{
		_FF00鄀(reader, writer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CListenAsync_003Ed__34))]
	private object ListenAsync()
	{
		return _FF00頀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CListenControlConnectAsync_003Ed__35))]
	private object ListenControlConnectAsync(object listener)
	{
		return _FF00鰀(listener);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSyncChaChaAsync_003Ed__38))]
	public virtual Task SyncChaChaAsync(RpcCallBack callBack)
	{
		return (Task)_FF00鬀(callBack);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PopVisitor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Rpc CheckConnectedDecider()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00茀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778496, new IntPtr(2737337566844L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00萀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00蔀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0070->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0063->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_008e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0057->IL0019: Incompatible stack types: I4 vs Obj
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
				obj2 = this;
				if (obj2 == null)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
				}
				else if (2 != 0)
				{
					obj2 = 1;
				}
				break;
			case 4:
				_ = 3;
				break;
			default:
				_ = null;
				_ = 4;
				break;
			case 3:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00蘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778559, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Dictionary<ushort, Func<RpcCallBack, Task>> _FF00蜀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (Dictionary<ushort, Func<RpcCallBack, Task>>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Dictionary<ushort, Func<RpcCallBack, Task>> _FF00蠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778558, new IntPtr(2737337549164L), 15))(null, 0, new IntPtr(0L));
		return (Dictionary<ushort, Func<RpcCallBack, Task>>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected object _FF00褀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe byte _FF00言()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778557, new IntPtr(2737337557484L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte _FF00謀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00谀(object P_0)
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
	private unsafe void _FF00贀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778556, new IntPtr(2737337545004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00踀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00輀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778555, new IntPtr(2737337557484L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00鄀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_004a: Expected I4, but got Obj
		//IL_00ad: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got I4
		//IL_0089: Expected Obj, but got I4
		//IL_010e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00e3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d5->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00a7->IL0019: Incompatible stack heights: 5 vs 1
		//IL_0078->IL0019: Incompatible stack heights: 6 vs 1
		//IL_00c4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0119->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00f4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_012f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0083->IL0019: Incompatible stack heights: 6 vs 1
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
				obj = obj;
				_ = 5;
				break;
			case 10:
				_ = 0;
				_ = ((Array)obj).Length;
				_ = 0;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 4:
				obj = 2;
				_ = 6;
				break;
			case 9:
				_ = 7;
				break;
			default:
				obj2 = obj;
				obj = 0;
				if (0 == 0)
				{
					obj2 = 1;
				}
				break;
			case 7:
				return;
			case 6:
				_ = 9;
				break;
			case 3:
				obj = P_0;
				obj2 = 2;
				break;
			case 5:
				if (this != null)
				{
					obj2 = 10;
					break;
				}
				goto default;
			case 1:
				_ = 2;
				obj = ((Array)obj).Length - 2;
				if (8 == 0)
				{
					_ = 8;
				}
				break;
			case 8:
				if ((nint)obj == 261)
				{
					obj2 = 4;
					break;
				}
				goto case 9;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00鈀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778554, new IntPtr(2737337557484L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00錀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778553, new IntPtr(2737337539804L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00鐀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4198, 1790778552, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778552, new IntPtr(2737337557484L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00销()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00阀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778551, new IntPtr(2737337539804L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00需()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778550, new IntPtr(2737337554364L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00頀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4202, 1790778549, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778549, new IntPtr(2737337549164L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00餀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778548, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00騀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778547, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00鬀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4205, 1790778546, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778546, new IntPtr(2737337566844L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00鰀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4206, 1790778545, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778545, new IntPtr(2737337550204L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00鴀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778544, new IntPtr(2737337545004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00鸀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00鼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778543, new IntPtr(2737337536684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00ꀀ(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4210, 1790778542, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778542, new IntPtr(2737337558524L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00ꄀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778541, new IntPtr(2737337554364L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00ꈀ(byte P_0)
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
	private unsafe void _FF00ꌀ(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778540, new IntPtr(2737337554364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00ꐀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778539, new IntPtr(2737337545004L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00ꔀ()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00ꘀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778538, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_A700(byte P_0)
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
	internal unsafe void _FF00ꠀ(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778537, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ꨀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778536, new IntPtr(2737337545004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_AB00(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0060: Expected Obj, but got I4
		//IL_0065->IL0015: Incompatible stack heights: 1 vs 0
		//IL_0092->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0076->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0081->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0054->IL0019: Incompatible stack heights: 2 vs 1
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
				case 2:
					return;
				case 4:
					if (2 == 0)
					{
						_ = 3;
					}
					continue;
				case 3:
					if (2 != 0)
					{
						obj2 = 2;
					}
					continue;
				case 1:
					if (false)
					{
						_ = 0;
					}
					continue;
				}
				break;
			}
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00가(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778535, new IntPtr(2737337551244L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00관(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_004c: Expected Obj, but got I4
		//IL_0081: Expected Obj, but got I4
		//IL_0051->IL0015: Incompatible stack heights: 2 vs 0
		//IL_009d->IL0019: Incompatible stack heights: 7 vs 1
		//IL_0069->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00af->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0074->IL0019: Incompatible stack types: I4 vs Obj
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
				case 1:
					obj = 5;
					break;
				case 6:
				{
					ushort num = (ushort)((Array)obj).Length;
					obj = obj;
					obj2 = num;
					if (1 != 0)
					{
						obj2 = 0;
					}
					continue;
				}
				case 4:
					obj = P_1;
					obj = 3;
					break;
				case 2:
					_ = 0;
					_ = ((Array)obj).Length;
					_ = 0;
					_ = 6;
					continue;
				case 0:
					return;
				case 3:
					if (this != null)
					{
						obj2 = 2;
						continue;
					}
					goto case 6;
				case 5:
					obj2 = P_0;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00글(uint P_0)
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
	internal unsafe void _FF00꼀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778534, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _FF00넀(ushort P_0, Func<RpcCallBack, Task> P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0044->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0060->IL0019: Incompatible stack heights: 3 vs 1
		//IL_004f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_006b->IL0019: Incompatible stack heights: 3 vs 1
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
				if (2 == 0)
				{
					_ = 1;
				}
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
	private object _FF00눀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00대()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778533, new IntPtr(2737337545004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe void _FF00됀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778532, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _FF00딀(object P_0)
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
}
