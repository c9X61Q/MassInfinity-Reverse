using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Mass.Common.Extensions;
using Mass.Domain.Entities.Mass;
using Serilog;

namespace Mass.Application.Services;

public class MassIrcService
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CConnectAsync_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MassIrcService _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object ManageSender;

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
		internal static bool DecorateConvertibleTag()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FindProvider()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_EC00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778463, new IntPtr(2737337477404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_ED00()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0391: Expected Obj, but got Ref
			//IL_039a: Expected Obj, but got I4
			//IL_0376: Expected Obj, but got Ref
			//IL_0126: Expected Obj, but got I4
			//IL_01bb: Expected Obj, but got I4
			//IL_0162: Expected Obj, but got I4
			//IL_01ea: Expected Obj, but got I4
			//IL_00c4: Expected Obj, but got Ref
			//IL_0236: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0382->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0367->IL0019: Incompatible stack heights: 2 vs 1
			//IL_038d->IL0019: Incompatible stack types: I4 vs Ref
			//IL_03b9->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0372->IL0019: Incompatible stack heights: 2 vs 1
			//IL_005a->IL005e: Incompatible stack heights: 1 vs 0
			//IL_0215->IL005e: Incompatible stack heights: 2 vs 0
			//IL_0131->IL005e: Incompatible stack heights: 3 vs 0
			//IL_00f3->IL005e: Incompatible stack heights: 2 vs 0
			//IL_01d2->IL005e: Incompatible stack heights: 3 vs 0
			//IL_013e->IL005e: Incompatible stack heights: 2 vs 0
			//IL_01a0->IL005e: Incompatible stack heights: 3 vs 0
			//IL_016d->IL005e: Incompatible stack heights: 3 vs 0
			//IL_00db->IL005e: Incompatible stack heights: 2 vs 0
			//IL_01ef->IL005a: Incompatible stack heights: 2 vs 0
			//IL_0121->IL005e: Incompatible stack heights: 2 vs 0
			//IL_0183->IL005e: Incompatible stack heights: 1 vs 0
			//IL_00ce->IL005e: Incompatible stack heights: 1 vs 0
			//IL_00fe->IL005e: Incompatible stack heights: 2 vs 0
			//IL_01dd->IL005e: Incompatible stack heights: 3 vs 0
			//IL_02a7->IL005e: Incompatible stack heights: 2 vs 0
			//IL_005e->IL005e: Incompatible stack heights: 1 vs 0
			//IL_018e->IL005e: Incompatible stack heights: 1 vs 0
			//IL_028c->IL005e: Incompatible stack heights: 1 vs 0
			//IL_02c9->IL005e: Incompatible stack heights: 1 vs 0
			//IL_015d->IL005e: Incompatible stack heights: 1 vs 0
			//IL_02d4->IL005e: Incompatible stack heights: 1 vs 0
			//IL_026a->IL005e: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			while (true)
			{
				ref _003CConnectAsync_003Ed__11 reference = ref *(_003CConnectAsync_003Ed__11*)obj;
				while (true)
				{
					switch ((uint)Unsafe.AsPointer(ref reference))
					{
					default:
						return;
					case 5u:
						if (obj == null)
						{
							if (false)
							{
								_ = 0;
							}
							goto IL_005e;
						}
						goto IL_01ef;
					case 0u:
						return;
					case 4u:
						goto IL_0357;
					case 2u:
						obj = (object)Unsafe.AsPointer(ref this);
						if (1 == 0)
						{
							reference = ref *(_003CConnectAsync_003Ed__11*)1;
						}
						continue;
					case 1u:
						break;
					case 3u:
						{
							reference = ref this;
							if (false)
							{
								reference = ref *(_003CConnectAsync_003Ed__11*)null;
							}
							continue;
						}
						IL_005e:
						while (true)
						{
							switch ((int)/*Error near IL_00bb: Stack underflow*/)
							{
							default:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 7;
								continue;
							case 14:
								_ = ref obj;
								_ = 9;
								continue;
							case 3:
								_ = ref obj;
								obj = obj;
								if (21 == 0)
								{
									_ = 18;
								}
								continue;
							case 16:
								_ = 10;
								continue;
							case 2:
								obj = 0;
								_ = 15;
								continue;
							case 7:
								_ = 12;
								continue;
							case 21:
								if (&obj == null)
								{
									if (2 != 0)
									{
										_ = 2;
									}
									continue;
								}
								goto case 14;
							case 12:
								obj = -1;
								_ = 14;
								continue;
							case 17:
								if (13 == 0)
								{
									_ = 13;
								}
								continue;
							case 10:
								_ = 6;
								continue;
							case 18:
								return;
							case 9:
								obj = 11;
								continue;
							case 5:
								_ = ref obj;
								if (3 != 0)
								{
									_ = 18;
								}
								continue;
							case 15:
								obj = 5;
								continue;
							case 8:
								break;
							case 13:
								_ = obj ?? ((object)/*Error near IL_0229: Stack underflow*/);
								obj = 20;
								continue;
							case 20:
								_ = obj ?? ((object)/*Error near IL_024f: Stack underflow*/);
								if (true)
								{
									_ = 1;
								}
								continue;
							case 1:
								_ = obj ?? ((object)/*Error near IL_027e: Stack underflow*/);
								_ = 16;
								continue;
							case 6:
								_ = obj ?? ((object)/*Error near IL_029a: Stack underflow*/);
								_ = 4;
								continue;
							case 4:
								_ = obj ?? ((object)/*Error near IL_02ba: Stack underflow*/);
								if (3 == 0)
								{
									_ = 1;
								}
								continue;
							case 11:
								goto IL_0357;
							}
							break;
						}
						goto IL_01ef;
						IL_01ef:
						_ = obj ?? ((object)/*Error near IL_0205: Stack underflow*/);
						_ = 17;
						goto IL_005e;
						IL_0357:
						_ = -2;
						if (3 == 0)
						{
							_ = 3;
						}
						continue;
					}
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
				obj = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_EE00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778462, new IntPtr(2737337479484L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_EF00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778461, new IntPtr(2737337497164L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_F000(object P_0)
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
		private unsafe sealed void _FF00_FF00_F100(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778460, new IntPtr(2737337486764L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_F200()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_F300()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDisconnectAsync_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MassIrcService _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object FlushCalc;

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
		internal static bool PlayTree()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateCommonAnalyzer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778435, new IntPtr(2737337499244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FFFD()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_023d: Expected Obj, but got Ref
			//IL_0258: Expected Obj, but got Ref
			//IL_0234: Expected Obj, but got I4
			//IL_0133: Expected Obj, but got Ref
			//IL_0142: Expected Obj, but got I4
			//IL_00b2: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0249->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0264->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0239->IL0015: Incompatible stack heights: 2 vs 0
			//IL_013d->IL0051: Incompatible stack types: I4 vs Ref
			//IL_004d->IL0051: Incompatible stack types: I4 vs Ref
			//IL_0254->IL0019: Incompatible stack types: I4 vs Ref
			//IL_026f->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0226->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00a0->IL0051: Incompatible stack heights: 2 vs 1
			//IL_018e->IL0051: Incompatible stack heights: 4 vs 1
			//IL_014d->IL0051: Incompatible stack heights: 3 vs 1
			//IL_0101->IL0051: Incompatible stack heights: 3 vs 1
			//IL_0173->IL0051: Incompatible stack heights: 2 vs 1
			//IL_0163->IL0051: Incompatible stack heights: 3 vs 1
			//IL_00ad->IL0051: Incompatible stack types: I4 vs Ref
			//IL_00bf->IL0051: Incompatible stack heights: 2 vs 1
			//IL_00f3->IL0051: Incompatible stack types: I4 vs Ref
			//IL_017e->IL0051: Incompatible stack heights: 2 vs 1
			//IL_012f->IL0051: Incompatible stack types: I4 vs Ref
			//IL_00ca->IL0051: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			while (true)
			{
				ref _003CDisconnectAsync_003Ed__12 reference = ref *(_003CDisconnectAsync_003Ed__12*)obj;
				while (true)
				{
					ref _003CDisconnectAsync_003Ed__12 reference2;
					switch ((uint)Unsafe.AsPointer(ref reference))
					{
					default:
						if (obj != null)
						{
							reference2 = ref *(_003CDisconnectAsync_003Ed__12*)8;
							goto IL_0051;
						}
						goto IL_012f;
					case 4u:
						reference = ref this;
						if (0 == 0)
						{
							reference = ref *(_003CDisconnectAsync_003Ed__12*)3;
						}
						continue;
					case 3u:
						return;
					case 5u:
						break;
					case 1u:
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							reference = ref *(_003CDisconnectAsync_003Ed__12*)null;
						}
						continue;
					case 2u:
						{
							obj = (object)Unsafe.AsPointer(ref this);
							if (0 == 0)
							{
								reference = ref *(_003CDisconnectAsync_003Ed__12*)1;
							}
							continue;
						}
						IL_0051:
						while (true)
						{
							switch ((uint)Unsafe.AsPointer(ref reference2))
							{
							default:
								_ = ref obj;
								_ = 4;
								continue;
							case 12u:
								reference2 = ref *(_003CDisconnectAsync_003Ed__12*)10;
								continue;
							case 13u:
								obj = -1;
								if (false)
								{
									_ = 0;
								}
								continue;
							case 5u:
								return;
							case 2u:
								reference2 = ref this;
								if (11 != 0)
								{
									reference2 = ref *(_003CDisconnectAsync_003Ed__12*)13;
								}
								continue;
							case 4u:
								_ = 0;
								_ = 12;
								continue;
							case 9u:
								if (&obj != null)
								{
									reference2 = ref *(_003CDisconnectAsync_003Ed__12*)11;
									continue;
								}
								goto case 3u;
							case 7u:
								break;
							case 3u:
								obj = 0;
								_ = 6;
								continue;
							case 8u:
								_ = ref obj;
								obj = obj;
								_ = 9;
								continue;
							case 6u:
								if (false)
								{
									_ = 1;
								}
								continue;
							case 1u:
								_ = ref obj;
								_ = 5;
								continue;
							case 10u:
								goto end_IL_0019;
							}
							break;
						}
						goto IL_012f;
						IL_012f:
						obj = (object)Unsafe.AsPointer(ref this);
						reference2 = ref *(_003CDisconnectAsync_003Ed__12*)2;
						goto IL_0051;
						end_IL_0019:
						break;
					}
					break;
				}
				_ = -2;
				obj = 4;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_E000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778434, new IntPtr(2737337482604L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_E100(object P_0)
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
		private unsafe sealed void _FF00_FF00_E200(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778433, new IntPtr(2737337486764L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_E300()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_E400()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778432, new IntPtr(2737337496124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_E500()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSendMessageAsync_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MassIrcService _003C_003E4__this;

		public string message;

		private TaskAwaiter _003C_003Eu__1;

		private static object ReflectAdaptableDistributor;

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
		internal static bool CheckPortableNotifier()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ScanLogger()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00픀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778439, new IntPtr(2737337487804L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00혀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_005a: Expected Obj, but got Ref
			//IL_0063: Expected Obj, but got I4
			//IL_006d: Expected Obj, but got Ref
			//IL_019d: Expected Obj, but got Ref
			//IL_0171: Expected Obj, but got I4
			//IL_0161: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0079->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0084->IL0019: Incompatible stack types: I4 vs Ref
			//IL_02bc->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
			//IL_01b4->IL00a7: Incompatible stack heights: 1 vs 0
			//IL_00a3->IL00a7: Incompatible stack heights: 1 vs 0
			//IL_017c->IL00a7: Incompatible stack heights: 3 vs 0
			//IL_020a->IL00a7: Incompatible stack heights: 4 vs 0
			//IL_0199->IL00a7: Incompatible stack heights: 4 vs 0
			//IL_01c4->IL00a7: Incompatible stack heights: 2 vs 0
			//IL_0219->IL00a7: Incompatible stack heights: 1 vs 0
			//IL_016c->IL00a7: Incompatible stack heights: 3 vs 0
			//IL_0189->IL00a7: Incompatible stack heights: 2 vs 0
			//IL_011f->IL00a7: Incompatible stack heights: 1 vs 0
			//IL_01cf->IL00a7: Incompatible stack heights: 2 vs 0
			//IL_0224->IL00a7: Incompatible stack heights: 1 vs 0
			//IL_0103->IL00a7: Incompatible stack heights: 1 vs 0
			//IL_013e->IL00a7: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			while (true)
			{
				ref _003CSendMessageAsync_003Ed__13 reference = ref *(_003CSendMessageAsync_003Ed__13*)obj;
				while (true)
				{
					switch ((uint)Unsafe.AsPointer(ref reference))
					{
					case 5u:
						_ = -2;
						if (3 != 0)
						{
							_ = 4;
						}
						continue;
					case 2u:
						return;
					case 1u:
						obj = (object)Unsafe.AsPointer(ref this);
						if (false)
						{
							reference = ref *(_003CSendMessageAsync_003Ed__13*)null;
						}
						continue;
					case 3u:
						if (obj != null)
						{
							if (false)
							{
								_ = 1;
							}
							goto IL_00a7;
						}
						goto IL_0199;
					case 4u:
						{
							reference = ref this;
							if (true)
							{
								reference = ref *(_003CSendMessageAsync_003Ed__13*)2;
							}
							continue;
						}
						IL_00a7:
						while (true)
						{
							switch ((int)/*Error near IL_00ec: Stack underflow*/)
							{
							case 4:
							case 9:
								break;
							case 13:
								return;
							case 12:
								if (&obj != null)
								{
									_ = 2;
									continue;
								}
								goto case 3;
							case 5:
								if (8 == 0)
								{
									_ = 9;
								}
								continue;
							case 1:
								if (obj != null)
								{
									if (0 == 0)
									{
										_ = 0;
									}
									continue;
								}
								goto case 5;
							case 11:
								obj = -1;
								_ = 15;
								continue;
							case 3:
								obj = 0;
								_ = 8;
								continue;
							case 2:
							case 15:
								_ = ref obj;
								_ = 4;
								continue;
							case 7:
								_ = ref obj;
								_ = 13;
								continue;
							case 14:
								goto IL_0199;
							case 8:
								if (3 == 0)
								{
									_ = 7;
								}
								continue;
							default:
								_ = ref obj;
								obj = obj;
								_ = 12;
								continue;
							case 10:
								if (11 == 0)
								{
									_ = 4;
								}
								continue;
							}
							break;
						}
						goto case 5u;
						IL_0199:
						obj = (object)Unsafe.AsPointer(ref this);
						if (10 == 0)
						{
							_ = 0;
						}
						goto IL_00a7;
					}
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
				obj = 3;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00휀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778438, new IntPtr(2737337482604L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FFFD(object P_0)
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
		internal static byte _FF00_FF00_FFFD()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778437, new IntPtr(2737337468044L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FFFD()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778436, new IntPtr(2737337484684L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[CompilerGenerated]
	private Func<EntityMassContent[], Task>? m_ResultContent;

	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	[CompilerGenerated]
	private static readonly object Instance__BackingField;

	private object _connection;

	private nint _connected;

	internal static MassIrcService EnableSorter;

	private static ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	public static MassIrcService Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	public event Func<EntityMassContent[], Task>? ResultContent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00_FF00_FF00刀(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00_FF00_FF00愀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CConnectAsync_003Ed__11))]
	public Task ConnectAsync()
	{
		return (Task)_FF00_FF00_FF00崀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisconnectAsync_003Ed__12))]
	public Task DisconnectAsync()
	{
		return (Task)_FF00_FF00_FF00帀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSendMessageAsync_003Ed__13))]
	public Task SendMessageAsync(string message)
	{
		return (Task)_FF00_FF00_FF00挀(message);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MassIrcService()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}

	static MassIrcService()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0023: Expected I4, but got Obj
		//IL_0046->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0079->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0051->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0084->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				Instance__BackingField = new MassIrcService();
				obj2 = 0;
				if (_003CModule_003E_007Bc547b36a_002Df832_002D4783_002Dbff4_002D35ff9bad7e58_007D.m_a6edc9c6177f4d1d9742e13736eb3634.m_e2dac19c706c42ccb1b1d24e54479149 == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_FF00开());
				obj2 = 1;
				if (_003CModule_003E_007Bc547b36a_002Df832_002D4783_002Dbff4_002D35ff9bad7e58_007D.m_a6edc9c6177f4d1d9742e13736eb3634.m_230c333d1e6f4c77880fc2e70f54af99 == 0)
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
	internal static bool ReflectMixedAggregator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MassIrcService CheckFlexibleTag()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00儀(Func<EntityMassContent[], Task> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778429, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00刀(Func<EntityMassContent[], Task> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0069->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0098->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00b8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0050->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0088->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005b->IL0019: Incompatible stack types: I4 vs Obj
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
				if (obj == obj)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
				obj = obj;
				obj2 = 4;
				break;
			case 0:
				return;
			case 4:
				obj2 = obj;
				obj = P_0;
				if (5 == 0)
				{
					obj2 = 3;
				}
				break;
			case 2:
				obj = this;
				if (false)
				{
					obj2 = 1;
				}
				break;
			case 5:
				obj = obj;
				if (3 == 0)
				{
					_ = 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00匀(Func<EntityMassContent[], Task> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778428, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00嘀(byte P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778403, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00圀(byte P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_009f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0084->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00aa->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0072->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008f->IL0019: Incompatible stack types: I4 vs Obj
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
			case 5:
				obj2 = P_1;
				if (2 != 0)
				{
					obj2 = 4;
				}
				break;
			case 2:
				if (P_0 != 0)
				{
					if (true)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 5;
			case 0:
				return;
			case 3:
				_ = 1;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 4:
				return;
			case 1:
				obj2 = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00堀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00夀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778402, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00娀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778401, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00嬀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00尀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778400, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00崀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1631, 1790778407, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778407, new IntPtr(2737336623996L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00帀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1632, 1790778406, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778406, new IntPtr(2737337494044L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00怀(Func<EntityMassContent[], Task> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778405, new IntPtr(2737337469084L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00愀(Func<EntityMassContent[], Task> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0087->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0067->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a7->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00d0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b2->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				obj = obj;
				if (0 == 0)
				{
					obj2 = 1;
				}
				break;
			case 2:
				return;
			case 5:
				obj = this;
				if (3 != 0)
				{
					obj2 = 4;
				}
				break;
			case 3:
				obj = obj;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			default:
				if (obj == obj)
				{
					if (2 == 0)
					{
						obj2 = 2;
					}
					break;
				}
				goto case 4;
			case 1:
				obj2 = obj;
				obj = P_0;
				if (3 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00戀(Func<EntityMassContent[], Task> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778404, new IntPtr(2737337493004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00挀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1637, 1790778411, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778411, new IntPtr(2737337500284L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00搀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778410, new IntPtr(2737337491964L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00攀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778409, new IntPtr(2737337495084L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00_FF00昀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00最()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778408, new IntPtr(2737337468044L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00栀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00椀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778415, new IntPtr(2737337477404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00樀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0045->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006b->IL0019: Incompatible stack types: I4 vs Obj
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
			default:
				return;
			case 2:
				return;
			case 1:
				obj2 = this;
				if (obj2 == null)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
				}
				else if (2 == 0)
				{
					obj2 = 2;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00氀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1646, 1790778414, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778414, new IntPtr(2737337495084L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00洀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778413, new IntPtr(2737337475324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
