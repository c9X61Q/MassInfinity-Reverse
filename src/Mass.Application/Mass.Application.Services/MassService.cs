using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Mass.Application.Models;
using Mass.Common.Extensions;
using Mass.Common.Models;
using Mass.Domain.Entities.Mass;
using RestSharp;
using Serilog;

namespace Mass.Application.Services;

public class MassService
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAdjustOrderAsync_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MassService _003C_003E4__this;

		public int orderId;

		private TaskAwaiter _003C_003Eu__1;

		private static object ReflectJoinedHandler;

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
		internal static bool ReflectLiteralStruct()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateScalableReporter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00쨀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778537, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00쬀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0207: Expected Obj, but got Ref
			//IL_0230: Expected Obj, but got Ref
			//IL_00fc: Expected Obj, but got Ref
			//IL_010b: Expected Obj, but got I4
			//IL_00d2: Expected Obj, but got I4
			//IL_016d: Expected Obj, but got I4
			//IL_00e1: Expected Obj, but got Ref
			//IL_0254->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0211->IL0019: Incompatible stack types: I4 vs Obj
			//IL_023c->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0221->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0247->IL0019: Incompatible stack types: I4 vs Obj
			//IL_022c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0106->IL0051: Incompatible stack types: I4 vs Ref
			//IL_004d->IL0051: Incompatible stack types: I4 vs Ref
			//IL_0116->IL0051: Incompatible stack heights: 3 vs 1
			//IL_0140->IL0051: Incompatible stack heights: 2 vs 1
			//IL_017a->IL0051: Incompatible stack heights: 2 vs 1
			//IL_0098->IL0051: Incompatible stack heights: 2 vs 1
			//IL_00ed->IL0051: Incompatible stack types: Obj vs Ref
			//IL_015d->IL0051: Incompatible stack heights: 3 vs 1
			//IL_014b->IL0051: Incompatible stack heights: 2 vs 1
			//IL_0051->IL0051: Incompatible stack heights: 2 vs 1
			//IL_00c6->IL0051: Incompatible stack types: I4 vs Ref
			//IL_0185->IL0051: Incompatible stack heights: 2 vs 1
			//IL_00f8->IL0051: Incompatible stack types: I4 vs Ref
			//IL_0168->IL0051: Incompatible stack heights: 3 vs 1
			//IL_0130->IL0051: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				ref _003CAdjustOrderAsync_003Ed__30 reference;
				switch ((int)obj2)
				{
				case 5:
					if (obj != null)
					{
						reference = ref *(_003CAdjustOrderAsync_003Ed__30*)5;
						goto IL_0051;
					}
					goto IL_00f8;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 5;
					break;
				case 3:
					goto IL_0211;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						obj2 = 1;
					}
					break;
				default:
					_ = 4;
					break;
				case 4:
					return;
					IL_0051:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 5u:
							_ = 6;
							continue;
						case 7u:
							return;
						case 3u:
							if (&obj == null)
							{
								reference = ref *(_003CAdjustOrderAsync_003Ed__30*)4;
								continue;
							}
							goto case 2u;
						case 2u:
							_ = ref obj;
							obj = 11;
							continue;
						case 6u:
						{
							object obj3 = obj;
							obj = (object)Unsafe.AsPointer(ref this);
							reference = ref *(_003CAdjustOrderAsync_003Ed__30*)obj3;
							if (1 == 0)
							{
								reference = ref *(_003CAdjustOrderAsync_003Ed__30*)3;
							}
							continue;
						}
						case 9u:
							break;
						default:
							obj = -1;
							_ = 2;
							continue;
						case 10u:
							reference = ref this;
							if (0 == 0)
							{
								reference = ref *(_003CAdjustOrderAsync_003Ed__30*)null;
							}
							continue;
						case 1u:
							if (5 == 0)
							{
								_ = 8;
							}
							continue;
						case 8u:
							_ = ref obj;
							if (7 == 0)
							{
								_ = 1;
							}
							continue;
						case 4u:
							obj = 0;
							if (false)
							{
								_ = 1;
							}
							continue;
						case 11u:
							goto IL_0211;
						}
						break;
					}
					goto IL_00f8;
					IL_0211:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
					IL_00f8:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CAdjustOrderAsync_003Ed__30*)10;
					goto IL_0051;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00찀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778536, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00촀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778543, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00츀(object P_0)
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
		internal static byte _FF00_FF00케()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00퀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778542, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00턀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00툀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778541, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CApiRequestAsync_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MassService _003C_003E4__this;

		public string endpoint;

		public object data;

		private TaskAwaiter<object> _003C_003Eu__1;

		internal static object ReflectModularSystem;

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
		internal static bool DecorateGroupedRole()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GetViewer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00뼀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778540, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00쀀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_021c: Expected Obj, but got Ref
			//IL_00e3: Expected Obj, but got Ref
			//IL_011c: Expected Obj, but got I4
			//IL_00c7: Expected Obj, but got I4
			//IL_014c: Expected Obj, but got Ref
			//IL_0167: Expected Obj, but got I4
			//IL_0235->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0242->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0226->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00fa->IL0079: Incompatible stack heights: 1 vs 0
			//IL_0075->IL0079: Incompatible stack heights: 1 vs 0
			//IL_00df->IL0079: Incompatible stack heights: 2 vs 0
			//IL_0127->IL0079: Incompatible stack heights: 3 vs 0
			//IL_0137->IL0079: Incompatible stack heights: 2 vs 0
			//IL_00d2->IL0079: Incompatible stack heights: 3 vs 0
			//IL_010c->IL0079: Incompatible stack heights: 3 vs 0
			//IL_0156->IL0079: Incompatible stack heights: 3 vs 0
			//IL_0142->IL0079: Incompatible stack heights: 2 vs 0
			//IL_0117->IL0079: Incompatible stack heights: 3 vs 0
			//IL_019a->IL0079: Incompatible stack heights: 1 vs 0
			//IL_0079->IL0079: Incompatible stack heights: 1 vs 0
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
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						obj2 = 0;
					}
					break;
				default:
					if (obj != null)
					{
						if (11 != 0)
						{
							_ = 5;
						}
						goto IL_0079;
					}
					goto IL_00df;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 3;
					break;
				case 5:
					return;
				case 1:
					goto IL_0227;
				case 2:
					{
						_ = 5;
						break;
					}
					IL_0079:
					while (true)
					{
						switch ((int)/*Error near IL_00ae: Stack underflow*/)
						{
						case 8:
							return;
						case 5:
							obj = 0;
							_ = 4;
							continue;
						default:
							_ = 3;
							continue;
						case 7:
							break;
						case 6:
							_ = ref obj;
							if (3 != 0)
							{
								_ = 8;
							}
							continue;
						case 3:
							obj = -1;
							_ = 10;
							continue;
						case 4:
							if (0 == 0)
							{
								_ = 6;
							}
							continue;
						case 11:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 2;
							continue;
						case 2:
							if (&obj != null)
							{
								obj = 9;
								continue;
							}
							goto case 5;
						case 9:
						case 10:
							_ = ref obj;
							if (false)
							{
								_ = 1;
							}
							continue;
						case 1:
							goto IL_0227;
						}
						break;
					}
					goto IL_00df;
					IL_0227:
					_ = -2;
					_ = 2;
					break;
					IL_00df:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						_ = 0;
					}
					goto IL_0079;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00섀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778579, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00숀(object P_0)
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
		private unsafe sealed void _FF00_FF00쌀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778578, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00쐀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00씀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778577, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00였()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778576, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00윀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00저()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778583, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CApiRequestAsync_003Ed__13<TResult> : IAsyncStateMachine where TResult : notnull
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<TResult> _003C_003Et__builder;

		public object data;

		public string endpoint;

		public MassService _003C_003E4__this;

		private MassResponse<TResult> _003Cresult_003E5__2;

		private TaskAwaiter<RestResponse> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

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

		internal static bool ReflectAutomatableChooser()
		{
			return true;
		}

		internal static object LoadMonitor()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCheckVersionAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityMassVersion> _003C_003Et__builder;

		public MassService _003C_003E4__this;

		private TaskAwaiter<EntityMassVersion> _003C_003Eu__1;

		private static object ReflectIntegratedTester;

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
		internal static bool MoveEditor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ChangeSystem()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00똀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778582, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00뜀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_025f: Expected Obj, but got Ref
			//IL_027a: Expected Obj, but got Ref
			//IL_013a: Expected Obj, but got Ref
			//IL_018b: Expected Obj, but got I4
			//IL_011f: Expected Obj, but got Ref
			//IL_01bd: Expected Obj, but got I4
			//IL_0149: Expected Obj, but got I4
			//IL_004c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0250->IL0019: Incompatible stack heights: 2 vs 1
			//IL_026b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0286->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0057->IL0019: Incompatible stack heights: 2 vs 1
			//IL_025b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0276->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0291->IL0019: Incompatible stack types: I4 vs Obj
			//IL_010f->IL006e: Incompatible stack heights: 2 vs 1
			//IL_0198->IL006e: Incompatible stack heights: 2 vs 1
			//IL_017b->IL006e: Incompatible stack heights: 2 vs 1
			//IL_00d1->IL006e: Incompatible stack heights: 3 vs 1
			//IL_012b->IL006e: Incompatible stack heights: 0 vs 1
			//IL_0154->IL006e: Incompatible stack heights: 3 vs 1
			//IL_0162->IL006e: Incompatible stack heights: 3 vs 1
			//IL_011a->IL006e: Incompatible stack heights: 2 vs 1
			//IL_00f0->IL006e: Incompatible stack heights: 0 vs 1
			//IL_01a3->IL006e: Incompatible stack heights: 2 vs 1
			//IL_0186->IL006e: Incompatible stack heights: 2 vs 1
			//IL_00dc->IL006e: Incompatible stack heights: 3 vs 1
			//IL_006e->IL006e: Incompatible stack heights: 2 vs 1
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
				default:
					if (5 == 0)
					{
						_ = 5;
					}
					break;
				case 5:
					return;
				case 4:
					if (obj != null)
					{
						num = 4;
						goto IL_006e;
					}
					goto IL_0136;
				case 1:
					goto IL_0240;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 != 0)
					{
						obj2 = 4;
					}
					break;
				case 3:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (2 == 0)
						{
							obj2 = 0;
						}
						break;
					}
					IL_006e:
					while (true)
					{
						switch (num)
						{
						case 2:
							return;
						case 6:
							_ = ref obj;
							if (2 != 0)
							{
								_ = 2;
							}
							continue;
						case 1:
							if (&obj == null)
							{
								if (false)
								{
									num = 11;
								}
								continue;
							}
							goto case 7;
						default:
							obj = obj;
							if (false)
							{
								_ = 8;
							}
							continue;
						case 7:
							obj = (object)(&obj);
							if (0 == 0)
							{
								num = 0;
							}
							continue;
						case 5:
							break;
						case 11:
							obj = 0;
							_ = 12;
							continue;
						case 12:
							_ = 6;
							continue;
						case 4:
							obj = null;
							if (false)
							{
								_ = 1;
							}
							continue;
						case 3:
							obj = -1;
							if (3 == 0)
							{
								_ = 7;
							}
							continue;
						case 8:
							obj = obj;
							num = 9;
							continue;
						case 10:
							obj = 3;
							continue;
						case 9:
							goto IL_0240;
						}
						break;
					}
					goto IL_0136;
					IL_0240:
					_ = -2;
					if (false)
					{
						_ = 0;
					}
					break;
					IL_0136:
					obj = (object)Unsafe.AsPointer(ref this);
					num = 10;
					goto IL_006e;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00렀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778581, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00뤀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778580, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00먀(object P_0)
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
		internal static byte _FF00_FF00묀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00밀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778587, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00봀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00븀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778586, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CComputeSignatureAsync_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public MassService _003C_003E4__this;

		public string message;

		private TaskAwaiter<string> _003C_003Eu__1;

		private static object CustomizeRole;

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
		internal static bool ReflectSeparatedError()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object InstantiateProfile()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00ꨀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778585, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_AB00()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_025c: Expected Obj, but got Ref
			//IL_0232: Expected Obj, but got Ref
			//IL_0199: Expected Obj, but got Ref
			//IL_0118: Expected Obj, but got Ref
			//IL_0190: Expected Obj, but got I4
			//IL_00f1: Expected Obj, but got I4
			//IL_0127: Expected Obj, but got I4
			//IL_00b9: Expected Obj, but got Ref
			//IL_0268->IL0019: Incompatible stack heights: 0 vs 1
			//IL_023e->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0258->IL0019: Incompatible stack heights: 3 vs 1
			//IL_004c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0273->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0249->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0057->IL0019: Incompatible stack heights: 2 vs 1
			//IL_01b0->IL007a: Incompatible stack heights: 1 vs 0
			//IL_0076->IL007a: Incompatible stack heights: 1 vs 0
			//IL_014d->IL007a: Incompatible stack heights: 3 vs 0
			//IL_0122->IL007a: Incompatible stack heights: 2 vs 0
			//IL_0176->IL007a: Incompatible stack heights: 1 vs 0
			//IL_00fc->IL007a: Incompatible stack heights: 3 vs 0
			//IL_0134->IL007a: Incompatible stack heights: 2 vs 0
			//IL_015c->IL007a: Incompatible stack heights: 1 vs 0
			//IL_0181->IL007a: Incompatible stack heights: 1 vs 0
			//IL_007a->IL007a: Incompatible stack heights: 4 vs 0
			//IL_013f->IL007a: Incompatible stack heights: 2 vs 0
			//IL_00d0->IL007a: Incompatible stack heights: 1 vs 0
			//IL_0167->IL007a: Incompatible stack heights: 1 vs 0
			//IL_010e->IL007a: Incompatible stack heights: 1 vs 0
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
					if (5 == 0)
					{
						_ = 5;
					}
					break;
				case 3:
					if (obj != null)
					{
						if (9 == 0)
						{
							_ = 8;
						}
						goto IL_007a;
					}
					goto IL_0195;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				case 5:
					return;
				case 2:
					goto IL_024a;
				default:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (1 == 0)
						{
							obj2 = 3;
						}
						break;
					}
					IL_0195:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						_ = 4;
					}
					goto IL_007a;
					IL_007a:
					while (true)
					{
						switch ((int)/*Error near IL_00af: Stack underflow*/)
						{
						case 8:
							obj = (object)(&obj);
							if (false)
							{
								_ = 1;
							}
							continue;
						case 11:
							return;
						case 6:
							obj = 0;
							_ = 2;
							continue;
						case 10:
							if (&obj == null)
							{
								_ = 6;
								continue;
							}
							goto case 8;
						case 3:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 10;
							continue;
						case 7:
							obj = -1;
							if (7 != 0)
							{
								_ = 8;
							}
							continue;
						case 2:
							_ = 5;
							continue;
						case 9:
							if (3 == 0)
							{
								_ = 3;
							}
							continue;
						case 4:
							if (7 == 0)
							{
								_ = 1;
							}
							continue;
						case 5:
							_ = ref obj;
							obj = 11;
							continue;
						case 1:
							goto IL_024a;
						}
						break;
					}
					goto IL_0195;
					IL_024a:
					_ = -2;
					_ = 4;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00가()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778584, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00관(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778591, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00글(object P_0)
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
		private unsafe sealed void _FF00_FF00꼀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778590, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00뀀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00넀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778589, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00눀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00대()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778588, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CConsumeIdentityAsync_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityMassIdentity> _003C_003Et__builder;

		public MassService _003C_003E4__this;

		private TaskAwaiter<EntityMassIdentity> _003C_003Eu__1;

		internal static object DecorateOrderedUser;

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
		internal static bool AttachSolver()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectScopePublisher()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00ꀀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778563, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00ꄀ()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0246: Expected Obj, but got Ref
			//IL_024f: Expected Obj, but got I4
			//IL_003f: Expected Obj, but got Ref
			//IL_00b2: Expected I4, but got Obj
			//IL_00db: Expected Obj, but got Ref
			//IL_01af: Expected Obj, but got I4
			//IL_0136: Expected Obj, but got Ref
			//IL_00ea: Expected Obj, but got I4
			//IL_00f4: Expected Obj, but got I4
			//IL_00fe: Expected Obj, but got I4
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_027f->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0265->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_006a->IL0079: Incompatible stack heights: 0 vs 1
			//IL_0270->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0179->IL0079: Incompatible stack types: I4 vs Obj
			//IL_0075->IL0079: Incompatible stack types: I4 vs Obj
			//IL_0189->IL0079: Incompatible stack heights: 2 vs 1
			//IL_00e5->IL0079: Incompatible stack types: I4 vs Obj
			//IL_0140->IL0079: Incompatible stack types: I4 vs Obj
			//IL_00f9->IL0075: Incompatible stack heights: 2 vs 1
			//IL_010b->IL0079: Incompatible stack heights: 2 vs 1
			//IL_01c4->IL0079: Incompatible stack heights: 4 vs 1
			//IL_0154->IL0079: Incompatible stack heights: 0 vs 1
			//IL_0194->IL0079: Incompatible stack heights: 2 vs 1
			//IL_00d6->IL0079: Incompatible stack types: I4 vs Obj
			//IL_0079->IL0079: Incompatible stack heights: 2 vs 1
			//IL_0116->IL0079: Incompatible stack heights: 2 vs 1
			//IL_015f->IL0079: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					object obj3;
					switch ((int)obj2)
					{
					case 1:
						obj = (object)Unsafe.AsPointer(ref this);
						if (false)
						{
							obj2 = 0;
						}
						continue;
					case 4:
						if (obj == null)
						{
							if (3 != 0)
							{
								obj3 = 6;
							}
							goto IL_0079;
						}
						goto IL_015f;
					default:
						goto end_IL_0019;
					case 5:
						if (2 == 0)
						{
							_ = 2;
						}
						continue;
					case 2:
						return;
					case 3:
						break;
						IL_015f:
						obj3 = obj;
						if (true)
						{
							obj3 = 4;
						}
						goto IL_0079;
						IL_0079:
						while (true)
						{
							switch ((int)obj3)
							{
							case 4:
								obj3 = obj;
								obj = null;
								if (0 == 0)
								{
									obj3 = 0;
								}
								continue;
							case 3:
								obj = (object)(&obj);
								obj3 = 5;
								continue;
							case 10:
								obj = -1;
								obj = 3;
								continue;
							case 11:
								obj = 0;
								if (2 == 0)
								{
									_ = 2;
								}
								continue;
							case 6:
							case 9:
								obj = (object)Unsafe.AsPointer(ref this);
								obj3 = 8;
								continue;
							default:
								if (&obj == null)
								{
									if (6 == 0)
									{
										obj3 = 11;
									}
									continue;
								}
								goto case 3;
							case 1:
								break;
							case 2:
								if (12 == 0)
								{
									_ = 2;
								}
								continue;
							case 7:
								return;
							case 8:
								obj = 10;
								continue;
							case 12:
								_ = ref obj;
								_ = 7;
								continue;
							case 5:
								goto end_IL_0019_2;
							}
							break;
						}
						goto IL_015f;
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
		private unsafe sealed void _FF00_FF00ꈀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778562, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00ꌀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778561, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00ꐀ(object P_0)
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
		internal static byte _FF00_FF00ꔀ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00ꘀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778560, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_A700()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00ꠀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778567, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetHeypixelMachineContext_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MassService _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object CheckStaticTransformer;

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
		internal static bool ParseResolver()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateConcreteVisitor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00阀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778566, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00需()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0040: Expected Obj, but got Ref
			//IL_0075: Expected Obj, but got Ref
			//IL_0104: Expected Obj, but got I4
			//IL_01de: Expected Obj, but got Ref
			//IL_01cf: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_008f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004c->IL0019: Incompatible stack heights: 0 vs 1
			//IL_007f->IL0019: Incompatible stack types: I4 vs Ref
			//IL_009a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0071->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0057->IL0019: Incompatible stack types: I4 vs Ref
			//IL_01b8->IL00bd: Incompatible stack types: I4 vs Ref
			//IL_00ae->IL00bd: Incompatible stack heights: 0 vs 2
			//IL_00fa->IL01ab: Incompatible stack heights: 1 vs 0
			//IL_00b9->IL00bd: Incompatible stack heights: 1 vs 2
			//IL_010f->IL00bd: Incompatible stack heights: 4 vs 2
			//IL_013d->IL00bd: Incompatible stack heights: 4 vs 2
			//IL_01e8->IL00bd: Incompatible stack types: I4 vs Ref
			//IL_0177->IL00bd: Incompatible stack heights: 3 vs 2
			//IL_01ca->IL00bd: Incompatible stack heights: 3 vs 2
			//IL_01da->IL00bd: Incompatible stack heights: 4 vs 2
			//IL_0148->IL00bd: Incompatible stack heights: 4 vs 2
			//IL_0211->IL00bd: Incompatible stack types: I4 vs Ref
			//IL_019c->IL00bd: Incompatible stack types: I4 vs Ref
			//IL_0182->IL00bd: Incompatible stack heights: 3 vs 2
			//IL_015c->IL00bd: Incompatible stack heights: 1 vs 2
			//IL_0167->IL00bd: Incompatible stack heights: 1 vs 2
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			ref _003CGetHeypixelMachineContext_003Ed__33 reference = ref *(_003CGetHeypixelMachineContext_003Ed__33*)obj;
			while (true)
			{
				ref byte reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 0u:
					return;
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (5 == 0)
					{
						reference = ref *(_003CGetHeypixelMachineContext_003Ed__33*)1;
					}
					continue;
				case 2u:
					reference = ref this;
					if (0 == 0)
					{
						reference = ref *(_003CGetHeypixelMachineContext_003Ed__33*)null;
					}
					continue;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CGetHeypixelMachineContext_003Ed__33*)3;
					continue;
				case 1u:
					break;
				case 5u:
					{
						if (obj == null)
						{
							if (8 == 0)
							{
								_ = 5;
							}
							goto IL_00bd;
						}
						goto IL_01ab;
					}
					IL_01ab:
					reference2 = ref *(byte*)12;
					goto IL_00bd;
					IL_00bd:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						case 6u:
							return;
						case 1u:
							break;
						default:
							obj = -1;
							_ = 3;
							continue;
						case 2u:
							_ = ref obj;
							if (6 == 0)
							{
								_ = 4;
							}
							continue;
						case 10u:
							if (&obj != null)
							{
								if (11 != 0)
								{
									_ = 11;
								}
								continue;
							}
							goto case 13u;
						case 9u:
							if (2 != 0)
							{
								_ = 0;
							}
							continue;
						case 5u:
							reference2 = ref Unsafe.As<_003CGetHeypixelMachineContext_003Ed__33, byte>(ref this);
							if (false)
							{
								reference2 = ref *(byte*)null;
							}
							continue;
						case 7u:
							goto end_IL_00bd;
						case 12u:
							obj = null;
							_ = 10;
							continue;
						case 13u:
							obj = 0;
							_ = 9;
							continue;
						case 4u:
						case 8u:
							obj = (object)Unsafe.AsPointer(ref this);
							reference2 = ref *(byte*)5;
							continue;
						case 3u:
						case 11u:
							reference2 = ref *(byte*)(&obj);
							if (true)
							{
								reference2 = ref *(byte*)1;
							}
							continue;
						}
						goto end_IL_0019;
						continue;
						end_IL_00bd:
						break;
					}
					goto IL_01ab;
					end_IL_0019:
					break;
				}
				_ = -2;
				if (2 != 0)
				{
					_ = 0;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00頀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778565, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00餀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778564, new IntPtr(2737337472204L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00騀(object P_0)
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
		internal static byte _FF00_FF00鬀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00鰀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778571, new IntPtr(2737337471164L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00鴀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00鸀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778570, new IntPtr(2737337475324L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetHistoryOrderAsync_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<EntityMassHistoryOrder>> _003C_003Et__builder;

		public MassService _003C_003E4__this;

		private TaskAwaiter<List<EntityMassHistoryOrder>> _003C_003Eu__1;

		internal static object ReflectConnectedWatcher;

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
		internal static bool DecorateAlphabeticElement()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VerifyUser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00謀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778569, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00谀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_01fb: Expected Obj, but got Ref
			//IL_0232: Expected Obj, but got Ref
			//IL_016f: Expected Obj, but got Ref
			//IL_012d: Expected Obj, but got I4
			//IL_0137: Expected Obj, but got I4
			//IL_0151: Expected Obj, but got I4
			//IL_0161: Expected Obj, but got Ref
			//IL_0223->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0207->IL0019: Incompatible stack heights: 0 vs 1
			//IL_023c->IL0019: Incompatible stack types: I4 vs Obj
			//IL_022e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0068->IL006c: Incompatible stack heights: 1 vs 0
			//IL_0212->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0186->IL006c: Incompatible stack heights: 1 vs 0
			//IL_00b3->IL006c: Incompatible stack heights: 2 vs 0
			//IL_011d->IL006c: Incompatible stack heights: 2 vs 0
			//IL_014c->IL006c: Incompatible stack heights: 4 vs 0
			//IL_0102->IL006c: Incompatible stack heights: 1 vs 0
			//IL_015c->IL006c: Incompatible stack heights: 3 vs 0
			//IL_00c7->IL006c: Incompatible stack heights: 1 vs 0
			//IL_016b->IL006c: Incompatible stack heights: 1 vs 0
			//IL_00e4->IL006c: Incompatible stack heights: 1 vs 0
			//IL_0128->IL006c: Incompatible stack heights: 2 vs 0
			//IL_006c->IL006c: Incompatible stack heights: 3 vs 0
			//IL_010d->IL006c: Incompatible stack heights: 1 vs 0
			//IL_00d2->IL006c: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 2:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				case 3:
					if (obj != null)
					{
						_ = 8;
						goto IL_006c;
					}
					goto IL_016b;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						obj2 = 3;
					}
					break;
				default:
					if (true)
					{
						_ = 0;
					}
					break;
				case 5:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 4;
					break;
				case 1:
					return;
					IL_016b:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						_ = 0;
					}
					goto IL_006c;
					IL_006c:
					while (true)
					{
						switch ((int)/*Error near IL_00a1: Stack underflow*/)
						{
						case 5:
							break;
						default:
							_ = 6;
							continue;
						case 10:
							obj = null;
							if (false)
							{
								_ = 1;
							}
							continue;
						case 1:
							if (&obj == null)
							{
								_ = 9;
								continue;
							}
							goto case 11;
						case 7:
							return;
						case 8:
							if (10 != 0)
							{
								_ = 3;
							}
							continue;
						case 2:
							if (4 == 0)
							{
								_ = 4;
							}
							continue;
						case 6:
							obj = -1;
							obj = 11;
							continue;
						case 4:
							_ = ref obj;
							_ = 7;
							continue;
						case 9:
							obj = 0;
							_ = 2;
							continue;
						case 11:
							obj = (object)(&obj);
							_ = 5;
							continue;
						case 3:
							goto IL_016b;
						}
						break;
					}
					goto case 2;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00贀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778568, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00踀(object P_0)
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
		private unsafe sealed void _FF00_FF00輀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778575, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00退()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00鄀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778574, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00鈀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778573, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00錀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00鐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778572, new IntPtr(2737337472204L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetIrcTokenAsync_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public MassService _003C_003E4__this;

		private TaskAwaiter<EntityMassIrcToken> _003C_003Eu__1;

		internal static object CheckLogicalWriter;

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
		internal static bool EncodePublisher()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ExcludeTransformer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00脀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778611, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00舀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0262: Expected Obj, but got Ref
			//IL_0298: Expected Obj, but got Ref
			//IL_00f7: Expected Obj, but got I4
			//IL_01c6: Expected Obj, but got I4
			//IL_01a6: Expected Obj, but got I4
			//IL_01d6: Expected Obj, but got Ref
			//IL_0100: Expected Obj, but got Ref
			//IL_0162: Expected Obj, but got I4
			//IL_0181: Expected Obj, but got I4
			//IL_01bc: Expected Obj, but got I4
			//IL_0289->IL0019: Incompatible stack heights: 2 vs 1
			//IL_02b4->IL0019: Incompatible stack heights: 2 vs 1
			//IL_026e->IL0019: Incompatible stack heights: 0 vs 1
			//IL_02a2->IL0019: Incompatible stack types: I4 vs Obj
			//IL_004d->IL0051: Incompatible stack heights: 1 vs 2
			//IL_0294->IL0019: Incompatible stack heights: 2 vs 1
			//IL_02bf->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0279->IL0019: Incompatible stack types: I4 vs Obj
			//IL_009a->IL00ce: Incompatible stack heights: 1 vs 0
			//IL_01d1->IL0051: Incompatible stack heights: 4 vs 2
			//IL_01ab->IL004d: Incompatible stack types: Obj vs Ref
			//IL_010c->IL0051: Incompatible stack heights: 1 vs 2
			//IL_00eb->IL0051: Incompatible stack heights: 5 vs 2
			//IL_0128->IL0051: Incompatible stack heights: 3 vs 2
			//IL_016d->IL0051: Incompatible stack heights: 4 vs 2
			//IL_0141->IL0051: Incompatible stack heights: 4 vs 2
			//IL_0051->IL0051: Incompatible stack heights: 3 vs 2
			//IL_0186->IL004d: Incompatible stack heights: 1 vs 2
			//IL_00c3->IL0051: Incompatible stack heights: 1 vs 2
			//IL_0117->IL0051: Incompatible stack heights: 1 vs 2
			//IL_0133->IL0051: Incompatible stack heights: 3 vs 2
			//IL_01c1->IL004d: Incompatible stack heights: 1 vs 2
			//IL_00ce->IL0051: Incompatible stack heights: 1 vs 2
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				default:
					return;
				case 1:
					if (obj == null)
					{
						_ = 16;
						goto IL_0051;
					}
					goto IL_00ce;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					if (true)
					{
						obj2 = 0;
					}
					break;
				case 2:
					goto IL_0279;
				case 5:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 4;
					break;
				case 0:
					return;
				case 3:
					{
						if (0 == 0)
						{
							_ = 0;
						}
						break;
					}
					IL_00ce:
					num = 14;
					goto IL_0051;
					IL_0051:
					while (true)
					{
						ref _003CGetIrcTokenAsync_003Ed__37 reference;
						switch (num)
						{
						case 8:
							obj = obj;
							num = 7;
							continue;
						case 9:
							if (&obj == null)
							{
								if (10 == 0)
								{
									_ = 13;
								}
								continue;
							}
							goto case 6;
						case 1:
							break;
						case 11:
							_ = ref obj;
							_ = 5;
							continue;
						default:
							reference = ref this;
							obj = 3;
							continue;
						case 10:
						case 16:
							obj = (object)Unsafe.AsPointer(ref this);
							if (false)
							{
								_ = 0;
							}
							continue;
						case 12:
							if (8 == 0)
							{
								_ = 4;
							}
							continue;
						case 15:
							_ = 11;
							continue;
						case 13:
							obj = 0;
							_ = 15;
							continue;
						case 2:
							if (obj != null)
							{
								obj = 4;
								continue;
							}
							goto case 8;
						case 5:
							return;
						case 4:
						{
							object obj3 = obj;
							obj = null;
							obj = 9;
							reference = ref *(_003CGetIrcTokenAsync_003Ed__37*)obj3;
							continue;
						}
						case 14:
							if (obj != null)
							{
								obj = 2;
								continue;
							}
							goto case 4;
						case 3:
							obj = -1;
							_ = 6;
							continue;
						case 6:
							obj = (object)(&obj);
							num = 12;
							continue;
						case 7:
							goto IL_0279;
						}
						break;
					}
					goto IL_00ce;
					IL_0279:
					_ = -2;
					if (true)
					{
						_ = 3;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00茀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778610, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00萀(object P_0)
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
		internal unsafe static byte _FF00_FF00蔀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778609, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00蘀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00蜀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778608, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00蠀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00褀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778615, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetManifest_003Ed__56 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityMassManifest> _003C_003Et__builder;

		public MassService _003C_003E4__this;

		private TaskAwaiter<RestResponse<MassResponse<EntityMassManifest>>> _003C_003Eu__1;

		internal static object TrackMap;

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
		internal static bool ReflectResponsiveArgument()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateSortedSummarizer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00眀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778614, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00砀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_004d: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_0172: Expected Obj, but got Ref
			//IL_013a: Expected Obj, but got I4
			//IL_0181: Expected Obj, but got I4
			//IL_018b: Expected Obj, but got I4
			//IL_01cd: Expected Obj, but got I4
			//IL_01d6: Expected Obj, but got I4
			//IL_00d2: Expected Obj, but got I4
			//IL_026a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0284->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0057->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0275->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0147->IL006d: Incompatible stack heights: 2 vs 1
			//IL_01ab->IL006d: Incompatible stack heights: 3 vs 1
			//IL_0135->IL006d: Incompatible stack heights: 3 vs 1
			//IL_01db->IL0069: Incompatible stack heights: 1 vs 2
			//IL_0127->IL006d: Incompatible stack heights: 4 vs 1
			//IL_00d7->IL0069: Incompatible stack heights: 1 vs 2
			//IL_0152->IL006d: Incompatible stack heights: 2 vs 1
			//IL_01b6->IL006d: Incompatible stack heights: 3 vs 1
			//IL_006d->IL006d: Incompatible stack heights: 3 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 5:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 4;
					break;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 3;
					break;
				case 3:
					if (obj != null)
					{
						num = 2;
						goto IL_006d;
					}
					goto IL_016e;
				case 2:
					return;
				default:
					goto IL_025a;
				case 1:
					{
						_ = 2;
						break;
					}
					IL_016e:
					obj = (object)Unsafe.AsPointer(ref this);
					num = 13;
					goto IL_006d;
					IL_006d:
					while (true)
					{
						switch (num)
						{
						case 9:
							throw obj;
						case 6:
							obj = obj;
							num = 5;
							continue;
						case 13:
							obj = 3;
							continue;
						case 1:
							if (&obj != null)
							{
								num = 11;
								continue;
							}
							goto default;
						case 10:
							if (obj == null)
							{
								num = 6;
								continue;
							}
							goto case 9;
						case 8:
							_ = ref obj;
							_ = 12;
							continue;
						case 4:
							_ = 8;
							continue;
						default:
							obj = 0;
							if (1 == 0)
							{
								_ = 4;
							}
							continue;
						case 14:
							break;
						case 3:
							obj = -1;
							obj = 7;
							continue;
						case 2:
							_ = 0;
							_ = ref obj;
							obj = obj;
							if (1 == 0)
							{
								_ = 1;
							}
							continue;
						case 12:
							return;
						case 7:
						case 11:
							_ = ref obj;
							obj = 1;
							obj = 10;
							continue;
						case 5:
							goto IL_025a;
						}
						break;
					}
					goto IL_016e;
					IL_025a:
					_ = -2;
					if (1 == 0)
					{
						_ = 1;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00礀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778613, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00稀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778612, new IntPtr(2737337475324L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00笀(object P_0)
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
		internal static byte _FF00_FF00簀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00紀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778619, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00縀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00缀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778618, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetNoticeAsync_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public MassService _003C_003E4__this;

		private TaskAwaiter<RestResponse> _003C_003Eu__1;

		internal static object CheckCombinedProgram;

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
		internal static bool DecorateTransformableTemplate()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ResumeWriter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00洀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778617, new IntPtr(2737337475324L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00渀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0265: Expected Obj, but got Ref
			//IL_026e: Expected Obj, but got I4
			//IL_0278: Expected Obj, but got Ref
			//IL_0195: Expected Obj, but got I4
			//IL_0094: Expected Obj, but got I4
			//IL_0157: Expected Obj, but got Ref
			//IL_0106: Expected Obj, but got I4
			//IL_0284->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0256->IL0019: Incompatible stack heights: 2 vs 1
			//IL_029f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_028f->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0261->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0153->IL0051: Incompatible stack types: I4 vs Ref
			//IL_004d->IL0051: Incompatible stack heights: 1 vs 4
			//IL_02aa->IL0019: Incompatible stack heights: 2 vs 1
			//IL_008a->IL013a: Incompatible stack heights: 3 vs 0
			//IL_01a1->IL0051: Incompatible stack heights: 5 vs 4
			//IL_009f->IL0051: Incompatible stack heights: 6 vs 4
			//IL_01bc->IL0051: Incompatible stack heights: 5 vs 4
			//IL_00f6->IL0051: Incompatible stack heights: 6 vs 4
			//IL_0163->IL0051: Incompatible stack heights: 3 vs 4
			//IL_0113->IL0051: Incompatible stack heights: 5 vs 4
			//IL_01ac->IL0051: Incompatible stack heights: 5 vs 4
			//IL_00b9->IL0051: Incompatible stack types: I4 vs Ref
			//IL_01c7->IL0051: Incompatible stack heights: 5 vs 4
			//IL_0101->IL0051: Incompatible stack heights: 6 vs 4
			//IL_0182->IL0051: Incompatible stack heights: 3 vs 4
			//IL_016e->IL0051: Incompatible stack heights: 3 vs 4
			//IL_011e->IL0051: Incompatible stack heights: 5 vs 4
			//IL_018d->IL0051: Incompatible stack heights: 3 vs 4
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					scoped ref _003CGetNoticeAsync_003Ed__35 reference;
					switch ((int)obj2)
					{
					case 4:
						if (obj == null)
						{
							_ = 5;
							goto IL_0051;
						}
						goto IL_013a;
					case 2:
						if (3 != 0)
						{
							_ = 3;
						}
						continue;
					default:
						goto end_IL_0019;
					case 3:
						return;
					case 1:
						obj = (object)Unsafe.AsPointer(ref this);
						if (false)
						{
							obj2 = 0;
						}
						continue;
					case 5:
						break;
						IL_0051:
						while (true)
						{
							switch ((uint)Unsafe.AsPointer(ref reference))
							{
							case 1u:
								obj = 0;
								_ = 4;
								continue;
							case 3u:
								reference = ref this;
								if (1 == 0)
								{
									reference = ref *(_003CGetNoticeAsync_003Ed__35*)12;
								}
								continue;
							case 2u:
								return;
							case 6u:
								_ = ref obj;
								if (2 == 0)
								{
									_ = 0;
								}
								continue;
							case 12u:
								obj = -1;
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							case 9u:
								break;
							case 5u:
							case 10u:
								obj = (object)Unsafe.AsPointer(ref this);
								if (2 != 0)
								{
									_ = 3;
								}
								continue;
							case 7u:
								if (&obj != null)
								{
									if (8 == 0)
									{
										_ = 8;
									}
									continue;
								}
								goto case 1u;
							default:
								_ = ref obj;
								_ = null;
								obj = 1;
								if (11 == 0)
								{
									_ = 1;
								}
								continue;
							case 4u:
								if (6 != 0)
								{
									_ = 1;
								}
								continue;
							case 11u:
								goto end_IL_0019_2;
							}
							break;
						}
						goto IL_013a;
						IL_013a:
						_ = 0;
						_ = ref obj;
						obj = obj;
						reference = ref *(_003CGetNoticeAsync_003Ed__35*)7;
						goto IL_0051;
						end_IL_0019_2:
						break;
					}
					_ = -2;
					if (0 == 0)
					{
						_ = 2;
					}
					continue;
					end_IL_0019:
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
				obj = 4;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00漀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778616, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00瀀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778623, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00焀(object P_0)
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
		private unsafe sealed void _FF00_FF00爀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778622, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00猀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00琀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778621, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00甀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00瘀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778620, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetReferralInfoAsync_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityMassReferralInfo> _003C_003Et__builder;

		public MassService _003C_003E4__this;

		private TaskAwaiter<EntityMassReferralInfo> _003C_003Eu__1;

		private static object ArrangeDic;

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
		internal static bool SaveObject()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckAttachedRecord()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00攀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778595, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00昀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_005b: Expected Obj, but got Ref
			//IL_004d: Expected Obj, but got Ref
			//IL_0179: Expected Obj, but got I4
			//IL_01bd: Expected Obj, but got I4
			//IL_0135: Expected Obj, but got Ref
			//IL_01ad: Expected Obj, but got I4
			//IL_00ce: Expected Obj, but got Ref
			//IL_0258->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0067->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0057->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0049->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0263->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0072->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0088->IL0088: Incompatible stack heights: 2 vs 1
			//IL_01ca->IL0088: Incompatible stack heights: 2 vs 1
			//IL_0130->IL0088: Incompatible stack heights: 2 vs 1
			//IL_0141->IL0088: Incompatible stack heights: 0 vs 1
			//IL_018e->IL0088: Incompatible stack heights: 2 vs 1
			//IL_015e->IL0088: Incompatible stack heights: 2 vs 1
			//IL_0111->IL0088: Incompatible stack heights: 4 vs 1
			//IL_01b8->IL0088: Incompatible stack heights: 3 vs 1
			//IL_00da->IL0088: Incompatible stack heights: 0 vs 1
			//IL_01d5->IL0088: Incompatible stack heights: 2 vs 1
			//IL_0199->IL0088: Incompatible stack heights: 2 vs 1
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
				case 5:
					_ = -2;
					_ = 2;
					break;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 3;
					break;
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				default:
					if (obj == null)
					{
						num = 8;
						goto IL_0088;
					}
					goto IL_016d;
				case 1:
					return;
				case 2:
					{
						if (true)
						{
							_ = 0;
						}
						break;
					}
					IL_016d:
					obj = 5;
					goto IL_0088;
					IL_0088:
					while (true)
					{
						switch (num)
						{
						case 6:
							break;
						case 8:
						case 12:
							obj = (object)Unsafe.AsPointer(ref this);
							if (true)
							{
								num = 0;
							}
							continue;
						case 9:
							_ = ref obj;
							_ = 10;
							continue;
						case 7:
							if (&obj != null)
							{
								num = 13;
								continue;
							}
							goto default;
						case 1:
							_ = 11;
							continue;
						case 2:
						case 13:
							obj = (object)(&obj);
							if (2 != 0)
							{
								num = 6;
							}
							continue;
						case 5:
							obj = null;
							_ = 7;
							continue;
						case 10:
							return;
						case 4:
							goto IL_016d;
						case 3:
							if (9 != 0)
							{
								_ = 9;
							}
							continue;
						case 11:
							obj = -1;
							_ = 2;
							continue;
						default:
							obj = 0;
							if (3 == 0)
							{
								_ = 0;
							}
							continue;
						}
						break;
					}
					goto case 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00最()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778594, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00栀(object P_0)
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
		internal static byte _FF00_FF00椀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00樀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00欀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778593, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetReferralProductsAsync_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<EntityMassReferralProduct>> _003C_003Et__builder;

		public MassService _003C_003E4__this;

		private TaskAwaiter<List<EntityMassReferralProduct>> _003C_003Eu__1;

		internal static object CheckGlobalContext;

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
		internal static bool ControlSummarizer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CalcProgram()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00嬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778592, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00尀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_02a3: Expected Obj, but got Ref
			//IL_026b: Expected Obj, but got Ref
			//IL_0138: Expected Obj, but got Ref
			//IL_01a8: Expected Obj, but got I4
			//IL_01c4: Expected Obj, but got Ref
			//IL_018b: Expected Obj, but got I4
			//IL_009b: Expected I4, but got Obj
			//IL_0294->IL0019: Incompatible stack heights: 2 vs 1
			//IL_025c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_02af->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0277->IL0019: Incompatible stack heights: 0 vs 1
			//IL_029f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_015c->IL005e: Incompatible stack types: I4 vs Obj
			//IL_004f->IL005e: Incompatible stack heights: 0 vs 2
			//IL_0267->IL0019: Incompatible stack heights: 2 vs 1
			//IL_02ba->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0282->IL0019: Incompatible stack types: I4 vs Obj
			//IL_009b->IL014f: Incompatible stack heights: 1 vs 0
			//IL_005a->IL005e: Incompatible stack heights: 1 vs 2
			//IL_00de->IL005e: Incompatible stack heights: 4 vs 2
			//IL_016c->IL005e: Incompatible stack heights: 3 vs 2
			//IL_00ad->IL005e: Incompatible stack heights: 3 vs 2
			//IL_0144->IL005e: Incompatible stack heights: 1 vs 2
			//IL_01b5->IL005e: Incompatible stack heights: 3 vs 2
			//IL_01d0->IL005e: Incompatible stack heights: 1 vs 2
			//IL_0198->IL005e: Incompatible stack heights: 3 vs 2
			//IL_00e9->IL005e: Incompatible stack heights: 4 vs 2
			//IL_0117->IL005e: Incompatible stack types: I4 vs Obj
			//IL_0177->IL005e: Incompatible stack heights: 3 vs 2
			//IL_014f->IL005e: Incompatible stack heights: 1 vs 2
			//IL_01c0->IL005e: Incompatible stack heights: 3 vs 2
			//IL_01db->IL005e: Incompatible stack heights: 1 vs 2
			//IL_01a3->IL005e: Incompatible stack heights: 3 vs 2
			//IL_00c1->IL005e: Incompatible stack heights: 1 vs 2
			//IL_00cc->IL005e: Incompatible stack heights: 1 vs 2
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				case 1:
					if (obj == null)
					{
						if (3 == 0)
						{
							_ = 3;
						}
						goto IL_005e;
					}
					goto IL_014f;
				case 3:
					goto IL_024c;
				case 5:
					obj = (object)Unsafe.AsPointer(ref this);
					if (4 == 0)
					{
						obj2 = 1;
					}
					break;
				case 2:
					return;
				default:
					if (0 == 0)
					{
						_ = 2;
					}
					break;
				case 4:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (1 == 0)
						{
							obj2 = 1;
						}
						break;
					}
					IL_005e:
					while (true)
					{
						switch ((int)obj3)
						{
						case 7:
							_ = 9;
							continue;
						case 13:
							if (&obj != null)
							{
								if (4 == 0)
								{
									_ = 4;
								}
								continue;
							}
							goto case 12;
						default:
							_ = ref obj;
							if (1 == 0)
							{
								_ = 1;
							}
							continue;
						case 1:
							return;
						case 5:
							obj3 = obj;
							obj = null;
							if (13 == 0)
							{
								obj3 = 13;
							}
							continue;
						case 4:
						case 8:
							obj = (object)(&obj);
							if (10 != 0)
							{
								_ = 11;
							}
							continue;
						case 2:
							break;
						case 6:
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 12:
							obj = 0;
							if (1 == 0)
							{
								_ = 6;
							}
							continue;
						case 9:
							obj = -1;
							if (4 == 0)
							{
								_ = 8;
							}
							continue;
						case 3:
						case 10:
							obj = (object)Unsafe.AsPointer(ref this);
							if (7 == 0)
							{
								_ = 7;
							}
							continue;
						case 11:
							goto IL_024c;
						}
						break;
					}
					goto IL_014f;
					IL_024c:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
					IL_014f:
					obj3 = 5;
					goto IL_005e;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00崀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778599, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00帀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778598, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00开(object P_0)
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
		internal static byte _FF00_FF00怀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00愀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778597, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00戀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778596, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00挀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetShopAsync_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityMassShop> _003C_003Et__builder;

		public MassService _003C_003E4__this;

		private TaskAwaiter<EntityMassShop> _003C_003Eu__1;

		internal static object PrepareTemplate;

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
		internal static bool DecorateGeneralModule()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NewDecider()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00倀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778603, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00儀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0075: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_01c0: Expected Obj, but got Ref
			//IL_017a: Expected Obj, but got I4
			//IL_018a: Expected Obj, but got Ref
			//IL_015d: Expected Obj, but got I4
			//IL_0265->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0081->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
			//IL_008c->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0071->IL0019: Incompatible stack heights: 2 vs 1
			//IL_01d7->IL00af: Incompatible stack heights: 1 vs 0
			//IL_00ab->IL00af: Incompatible stack heights: 1 vs 0
			//IL_01e4->IL00af: Incompatible stack heights: 2 vs 0
			//IL_013b->IL00af: Incompatible stack heights: 3 vs 0
			//IL_0185->IL00af: Incompatible stack heights: 3 vs 0
			//IL_01a4->IL00af: Incompatible stack heights: 2 vs 0
			//IL_01bc->IL00af: Incompatible stack heights: 2 vs 0
			//IL_0194->IL00af: Incompatible stack heights: 1 vs 0
			//IL_011e->IL00af: Incompatible stack heights: 2 vs 0
			//IL_016a->IL00af: Incompatible stack heights: 2 vs 0
			//IL_0158->IL00af: Incompatible stack heights: 1 vs 0
			//IL_0146->IL00af: Incompatible stack heights: 3 vs 0
			//IL_01af->IL00af: Incompatible stack heights: 2 vs 0
			//IL_0129->IL00af: Incompatible stack heights: 2 vs 0
			//IL_0175->IL00af: Incompatible stack heights: 2 vs 0
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
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						obj2 = 1;
					}
					break;
				case 3:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (4 == 0)
					{
						obj2 = 4;
					}
					break;
				case 4:
					if (obj != null)
					{
						if (2 != 0)
						{
							_ = 7;
						}
						goto IL_00af;
					}
					goto IL_01bc;
				case 5:
					return;
				default:
					{
						_ = 5;
						break;
					}
					IL_01bc:
					obj = (object)Unsafe.AsPointer(ref this);
					if (true)
					{
						_ = 1;
					}
					goto IL_00af;
					IL_00af:
					while (true)
					{
						switch ((int)/*Error near IL_00e4: Stack underflow*/)
						{
						case 11:
							break;
						case 4:
							return;
						case 9:
							obj = null;
							if (1 == 0)
							{
								_ = 2;
							}
							continue;
						case 3:
							_ = ref obj;
							if (2 == 0)
							{
								_ = 4;
							}
							continue;
						case 2:
							if (&obj == null)
							{
								_ = 10;
								continue;
							}
							goto case 8;
						case 10:
							obj = 0;
							if (5 == 0)
							{
								_ = 6;
							}
							continue;
						case 5:
							obj = -1;
							_ = 8;
							continue;
						case 8:
							obj = (object)(&obj);
							_ = 11;
							continue;
						case 6:
							if (3 == 0)
							{
								_ = 0;
							}
							continue;
						case 7:
							_ = 9;
							continue;
						default:
							goto IL_01bc;
						case 1:
							_ = 5;
							continue;
						}
						break;
					}
					goto case 3;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00刀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778602, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00匀(object P_0)
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
		private unsafe sealed void _FF00_FF00吀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778601, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00唀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778600, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00嘀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00圀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778607, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00堀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00夀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778606, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetUpdaterManifest_003Ed__57 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityMassManifest> _003C_003Et__builder;

		public MassService _003C_003E4__this;

		private TaskAwaiter<RestResponse<MassResponse<EntityMassManifest>>> _003C_003Eu__1;

		internal static object DecorateVisibleWrapper;

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
		internal static bool DecorateCentralProcessor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectStatelessContainer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00䠀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778605, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00䤀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0259: Expected Obj, but got Ref
			//IL_011f: Expected Obj, but got Ref
			//IL_0128: Expected Obj, but got I4
			//IL_00c6: Expected I4, but got Obj
			//IL_0148: Expected Obj, but got I4
			//IL_0151: Expected Obj, but got I4
			//IL_018a: Expected Obj, but got I4
			//IL_017a: Expected Obj, but got I4
			//IL_00f7: Expected Obj, but got I4
			//IL_0073->IL0019: Incompatible stack heights: 3 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0263->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0065->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0085->IL0089: Incompatible stack types: I4 vs Obj
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0156->IL0085: Incompatible stack heights: 1 vs 0
			//IL_01b0->IL0089: Incompatible stack heights: 3 vs 1
			//IL_011b->IL0089: Incompatible stack heights: 4 vs 1
			//IL_0195->IL0089: Incompatible stack heights: 3 vs 1
			//IL_0185->IL0089: Incompatible stack heights: 3 vs 1
			//IL_0163->IL0089: Incompatible stack heights: 2 vs 1
			//IL_00db->IL0089: Incompatible stack heights: 2 vs 1
			//IL_0175->IL0089: Incompatible stack types: I4 vs Obj
			//IL_01bb->IL0089: Incompatible stack heights: 3 vs 1
			//IL_0140->IL0089: Incompatible stack types: I4 vs Obj
			//IL_00e6->IL0089: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				object obj3;
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
					_ = 5;
					break;
				case 1:
					_ = -2;
					_ = 4;
					break;
				default:
					if (obj != null)
					{
						obj3 = 3;
						goto IL_0089;
					}
					goto IL_011b;
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 2;
					break;
				case 5:
					return;
					IL_011b:
					obj = (object)Unsafe.AsPointer(ref this);
					obj = 10;
					goto IL_0085;
					IL_0085:
					obj3 = obj;
					goto IL_0089;
					IL_0089:
					while (true)
					{
						switch ((int)obj3)
						{
						case 13:
							break;
						case 11:
							if (5 == 0)
							{
								_ = 5;
							}
							continue;
						case 4:
							if (obj == null)
							{
								goto IL_00ee;
							}
							goto case 6;
						case 5:
							_ = ref obj;
							_ = 12;
							continue;
						case 1:
							goto IL_011b;
						case 6:
							throw obj;
						case 9:
							obj = obj;
							obj3 = 13;
							continue;
						case 2:
							goto IL_0140;
						case 10:
							_ = 7;
							continue;
						default:
							if (&obj == null)
							{
								obj3 = 8;
								continue;
							}
							goto IL_0140;
						case 8:
							obj = 0;
							_ = 11;
							continue;
						case 7:
							obj = -1;
							_ = 2;
							continue;
						case 3:
							_ = 0;
							_ = ref obj;
							obj = obj;
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 12:
							return;
						}
						break;
					}
					goto case 1;
					IL_0140:
					_ = ref obj;
					obj = 1;
					obj = 4;
					goto IL_0085;
					IL_00ee:
					obj = 9;
					goto IL_0085;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00䨀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778604, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00䬀(object P_0)
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
		internal static byte _FF00_FF00䰀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00䴀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00一()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778643, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitAsync_003Ed__55 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MassService _003C_003E4__this;

		public string applicationName;

		public string versionName;

		private TaskAwaiter<KeyValuePair<string, string>> _003C_003Eu__1;

		private static object EvaluateMapper;

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
		internal static bool SortPolicy()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectAutomatedAnnotation()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00㸀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778642, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00㼀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0288: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_0107: Expected Obj, but got Ref
			//IL_014b: Expected Obj, but got I4
			//IL_01d1: Expected Obj, but got I4
			//IL_0169: Expected Obj, but got I4
			//IL_00cc: Expected Obj, but got Ref
			//IL_0294->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0284->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0277->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0111->IL0079: Incompatible stack types: I4 vs Ref
			//IL_006a->IL0079: Incompatible stack heights: 0 vs 1
			//IL_029f->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0075->IL0079: Incompatible stack types: I4 vs Ref
			//IL_0156->IL0079: Incompatible stack heights: 3 vs 1
			//IL_01a1->IL0079: Incompatible stack heights: 3 vs 1
			//IL_0103->IL0079: Incompatible stack types: I4 vs Ref
			//IL_0192->IL0079: Incompatible stack heights: 2 vs 1
			//IL_00f2->IL0079: Incompatible stack heights: 3 vs 1
			//IL_0174->IL0079: Incompatible stack heights: 3 vs 1
			//IL_0184->IL0079: Incompatible stack heights: 4 vs 1
			//IL_00d8->IL0079: Incompatible stack heights: 0 vs 1
			//IL_0164->IL0079: Incompatible stack heights: 3 vs 1
			//IL_0146->IL0079: Incompatible stack types: I4 vs Ref
			//IL_0079->IL0079: Incompatible stack types: Obj vs Ref
			//IL_012c->IL0079: Incompatible stack types: I4 vs Ref
			//IL_01f8->IL0079: Incompatible stack heights: 6 vs 1
			//IL_01b3->IL0079: Incompatible stack types: I4 vs Ref
			//IL_00e3->IL0079: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				ref byte reference;
				switch ((int)obj2)
				{
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						obj2 = 1;
					}
					break;
				default:
					if (obj != null)
					{
						if (true)
						{
							reference = ref *(byte*)1;
						}
						goto IL_0079;
					}
					goto IL_0103;
				case 5:
					goto IL_0269;
				case 3:
					_ = 4;
					break;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				case 4:
					return;
					IL_0079:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 14u:
							obj = (object)(&obj);
							if (8 == 0)
							{
								reference = ref *(byte*)8;
							}
							continue;
						case 5u:
							_ = 6;
							continue;
						case 3u:
							reference = ref *(byte*)7;
							continue;
						case 13u:
							break;
						case 8u:
							reference = ref *(byte*)(&obj);
							if (4 != 0)
							{
								reference = ref *(byte*)4;
							}
							continue;
						case 2u:
							reference = ref Unsafe.As<_003CInitAsync_003Ed__55, byte>(ref this);
							if (false)
							{
								reference = ref *(byte*)null;
							}
							continue;
						default:
							obj = -1;
							_ = 14;
							continue;
						case 15u:
							_ = 11;
							continue;
						case 9u:
							obj = 0;
							_ = 15;
							continue;
						case 11u:
							_ = ref obj;
							_ = 16;
							continue;
						case 4u:
							_ = ref obj;
							_ = 10;
							continue;
						case 1u:
							_ = 5;
							continue;
						case 12u:
							if (&obj == null)
							{
								reference = ref *(byte*)9;
								continue;
							}
							goto case 14u;
						case 16u:
							return;
						case 6u:
							obj = obj;
							obj = 12;
							reference = ref *(byte*)obj;
							continue;
						case 10u:
						{
							object obj3 = obj;
							_ = null;
							_ = null;
							_ = 0;
							_ = 3;
							continue;
						}
						case 7u:
							goto IL_0269;
						}
						break;
					}
					goto IL_0103;
					IL_0269:
					_ = -2;
					_ = 3;
					break;
					IL_0103:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(byte*)2;
					goto IL_0079;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00䀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778641, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00䄀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778640, new IntPtr(2737337475324L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00䈀(object P_0)
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
		private unsafe sealed void _FF00_FF00䌀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778647, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00䐀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00䔀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CJoinServerAsync_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<byte[]> _003C_003Et__builder;

		public MassService _003C_003E4__this;

		public byte[] handshakeKey;

		public string userId;

		public byte[] encryptToken;

		public string gameVersion;

		public string gameId;

		private TaskAwaiter<string> _003C_003Eu__1;

		internal static object ReflectPassiveComparator;

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
		internal static bool OpenEvent()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckOperationalCommand()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00㔀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778646, new IntPtr(2737337475324L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00㘀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_005a: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_00db: Expected I4, but got Obj
			//IL_01be: Expected Obj, but got I4
			//IL_0170: Expected Obj, but got I4
			//IL_0161: Expected Obj, but got Ref
			//IL_014c: Expected Obj, but got I4
			//IL_0156: Expected Obj, but got I4
			//IL_011e: Expected Obj, but got Ref
			//IL_01e4: Expected Obj, but got Ref
			//IL_01ed: Expected Obj, but got I4
			//IL_0280->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0064->IL0019: Incompatible stack types: I4 vs Obj
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0074->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0093->IL00a2: Incompatible stack heights: 0 vs 1
			//IL_007f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_01b1->IL00a2: Incompatible stack types: I4 vs Obj
			//IL_009e->IL00a2: Incompatible stack types: I4 vs Obj
			//IL_017d->IL00a2: Incompatible stack heights: 2 vs 1
			//IL_016b->IL00a2: Incompatible stack types: I4 vs Obj
			//IL_0109->IL00a2: Incompatible stack heights: 2 vs 1
			//IL_01d5->IL00a2: Incompatible stack heights: 3 vs 1
			//IL_015b->IL009e: Incompatible stack types: I4 vs Obj
			//IL_0128->IL00a2: Incompatible stack heights: 7 vs 1
			//IL_01f2->IL009e: Incompatible stack heights: 0 vs 2
			//IL_00a2->IL00a2: Incompatible stack heights: 3 vs 1
			//IL_0188->IL00a2: Incompatible stack heights: 2 vs 1
			//IL_01e0->IL00a2: Incompatible stack heights: 3 vs 1
			//IL_013c->IL00a2: Incompatible stack heights: 0 vs 1
			//IL_0147->IL00a2: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (true)
					{
						obj2 = 1;
					}
					break;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 3;
					break;
				case 4:
					_ = -2;
					if (false)
					{
						_ = 0;
					}
					break;
				case 3:
					if (obj == null)
					{
						if (7 != 0)
						{
							obj3 = 0;
						}
						goto IL_00a2;
					}
					goto IL_0197;
				case 5:
					return;
				default:
					{
						_ = 5;
						break;
					}
					IL_0197:
					obj3 = obj;
					if (10 == 0)
					{
						obj3 = 5;
					}
					goto IL_00a2;
					IL_00a2:
					while (true)
					{
						scoped ref _003CJoinServerAsync_003Ed__24 reference;
						object obj4;
						switch ((int)obj3)
						{
						case 3:
							break;
						case 6:
							_ = 9;
							continue;
						case 10:
							_ = 1;
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 12;
							continue;
						case 12:
							if (&obj == null)
							{
								if (2 == 0)
								{
									obj3 = 1;
								}
								continue;
							}
							goto case 4;
						case 9:
							reference = ref this;
							obj = -1;
							obj = 4;
							obj4 = -1;
							continue;
						case 4:
							obj = (object)(&obj);
							obj3 = 3;
							continue;
						case 2:
							obj = 0;
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 5:
							return;
						case 1:
							goto IL_0197;
						default:
							reference = ref this;
							obj4 = obj;
							obj = 8;
							continue;
						case 8:
							_ = ref obj;
							if (5 != 0)
							{
								_ = 5;
							}
							continue;
						case 7:
						case 11:
							obj = (object)Unsafe.AsPointer(ref this);
							obj = 6;
							continue;
						}
						break;
					}
					goto case 4;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00㜀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778645, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00㠀(object P_0)
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
		private unsafe sealed void _FF00_FF00㤀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778644, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00㨀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00㬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778651, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00㰀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CJoinServerAsync_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<byte[]> _003C_003Et__builder;

		public MassService _003C_003E4__this;

		public byte[] handshakeKey;

		public string userId;

		public string gameVersion;

		public string gameId;

		public string modHashList;

		public string serverIdHash;

		private TaskAwaiter<string> _003C_003Eu__1;

		private static object CheckVirtualConsumer;

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
		internal static bool ReflectIdentifiableStrategy()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectInterruptibleSorter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00ⴀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778650, new IntPtr(2737337472204L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_2E00()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0069: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_0131: Expected Obj, but got Ref
			//IL_00e6: Expected Obj, but got I4
			//IL_018f: Expected Obj, but got Ref
			//IL_0154: Expected Obj, but got Ref
			//IL_01ab: Expected Obj, but got I4
			//IL_00dc: Expected I4, but got Obj
			//IL_0075->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_026e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0065->IL0019: Incompatible stack heights: 3 vs 1
			//IL_013b->IL00a3: Incompatible stack types: I4 vs Obj
			//IL_0094->IL00a3: Incompatible stack heights: 0 vs 1
			//IL_0080->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0279->IL0019: Incompatible stack heights: 2 vs 1
			//IL_009f->IL00a3: Incompatible stack types: I4 vs Obj
			//IL_010e->IL00a3: Incompatible stack heights: 4 vs 1
			//IL_00f3->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_019b->IL00a3: Incompatible stack heights: 7 vs 1
			//IL_011b->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_015e->IL00a3: Incompatible stack types: I4 vs Obj
			//IL_01b6->IL00a3: Incompatible stack heights: 3 vs 1
			//IL_016e->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_00fe->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_01a6->IL00a3: Incompatible stack heights: 7 vs 1
			//IL_01d0->IL00a3: Incompatible stack types: I4 vs Obj
			//IL_012d->IL00a3: Incompatible stack types: I4 vs Obj
			//IL_0179->IL00a3: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 5:
					_ = 4;
					continue;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						obj2 = 0;
					}
					continue;
				default:
					if (obj != null)
					{
						if (3 == 0)
						{
							obj3 = 4;
						}
						goto IL_00a3;
					}
					goto IL_012d;
				case 4:
					return;
				case 3:
					break;
					IL_012d:
					obj = (object)Unsafe.AsPointer(ref this);
					obj3 = 5;
					goto IL_00a3;
					IL_00a3:
					while (true)
					{
						switch ((int)obj3)
						{
						case 1:
							obj = 0;
							if (12 == 0)
							{
								_ = 6;
							}
							continue;
						default:
							_ = ref obj;
							_ = 10;
							continue;
						case 5:
							_ = 11;
							continue;
						case 8:
							if (&obj != null)
							{
								obj3 = 7;
								continue;
							}
							goto case 1;
						case 2:
							break;
						case 10:
							return;
						case 6:
						case 7:
							obj = (object)(&obj);
							obj3 = 9;
							continue;
						case 12:
							if (false)
							{
								_ = 0;
							}
							continue;
						case 3:
							_ = 0;
							obj = (object)Unsafe.AsPointer(ref this);
							if (8 != 0)
							{
								_ = 3;
							}
							continue;
						case 11:
							obj = -1;
							_ = 6;
							continue;
						case 4:
							obj3 = obj;
							if (3 == 0)
							{
								obj3 = 1;
							}
							continue;
						case 9:
							goto end_IL_0019;
						}
						break;
					}
					goto IL_012d;
					end_IL_0019:
					break;
				}
				_ = -2;
				if (2 == 0)
				{
					_ = 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_2F00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778649, new IntPtr(2737337476364L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_3000(object P_0)
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
		internal static byte _FF00_FF00_3100()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_3200()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778648, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_3300()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00㐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778655, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoginAsync_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string username;

		public string password;

		public MassService _003C_003E4__this;

		private object _003C_003E7__wrap1;

		private object _003C_003E7__wrap2;

		private object _003C_003E7__wrap3;

		private TaskAwaiter<string[]> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private static object ReflectCustomizableConfig;

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
		internal static bool ReflectInternalEmitter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateExpandableRunner()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_2400()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778654, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_2500()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0098: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0069: Expected Obj, but got Ref
			//IL_007f: Expected Obj, but got I4
			//IL_0298: Expected Obj, but got Ref
			//IL_0148: Expected Obj, but got Ref
			//IL_01ae: Expected Obj, but got Ref
			//IL_02d6: Expected Obj, but got I4
			//IL_026f: Expected Obj, but got I4
			//IL_033c: Expected Obj, but got Ref
			//IL_03ea: Expected Obj, but got I4
			//IL_031d: Expected Obj, but got I4
			//IL_02b9: Expected Obj, but got I4
			//IL_03ca: Expected Obj, but got I4
			//IL_0064->IL0019: Incompatible stack heights: 3 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0073->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0084->IL0015: Incompatible stack heights: 1 vs 0
			//IL_02a2->IL00a6: Incompatible stack types: I4 vs Ref
			//IL_0152->IL00a6: Incompatible stack types: I4 vs Ref
			//IL_01b8->IL00a6: Incompatible stack types: I4 vs Ref
			//IL_00a2->IL00a6: Incompatible stack types: I4 vs Ref
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_01e4->IL00a6: Incompatible stack heights: 3 vs 1
			//IL_02e1->IL00a6: Incompatible stack heights: 3 vs 1
			//IL_03e5->IL00a6: Incompatible stack heights: 4 vs 1
			//IL_0398->IL00a6: Incompatible stack heights: 3 vs 1
			//IL_0380->IL00a6: Incompatible stack heights: 2 vs 1
			//IL_0402->IL00a6: Incompatible stack heights: 2 vs 1
			//IL_027a->IL00a6: Incompatible stack heights: 3 vs 1
			//IL_0237->IL00a6: Incompatible stack heights: 3 vs 1
			//IL_016e->IL00a6: Incompatible stack heights: 3 vs 1
			//IL_0346->IL00a6: Incompatible stack types: I4 vs Ref
			//IL_03f5->IL00a6: Incompatible stack heights: 3 vs 1
			//IL_0252->IL00a6: Incompatible stack heights: 2 vs 1
			//IL_0160->IL00a6: Incompatible stack heights: 3 vs 1
			//IL_0328->IL00a6: Incompatible stack heights: 3 vs 1
			//IL_0309->IL00a6: Incompatible stack heights: 3 vs 1
			//IL_018d->IL00a6: Incompatible stack heights: 2 vs 1
			//IL_0356->IL00a6: Incompatible stack heights: 0 vs 1
			//IL_0289->IL00a6: Incompatible stack heights: 2 vs 1
			//IL_017d->IL00a6: Incompatible stack heights: 3 vs 1
			//IL_02c6->IL00a6: Incompatible stack heights: 2 vs 1
			//IL_03a6->IL00a6: Incompatible stack types: I4 vs Ref
			//IL_02fc->IL00a6: Incompatible stack heights: 5 vs 1
			//IL_026a->IL00a6: Incompatible stack heights: 2 vs 1
			//IL_03d5->IL00a6: Incompatible stack heights: 3 vs 1
			//IL_03ba->IL00a6: Incompatible stack heights: 0 vs 1
			//IL_01ef->IL00a6: Incompatible stack heights: 3 vs 1
			//IL_01aa->IL00a6: Incompatible stack types: I4 vs Ref
			//IL_02b4->IL00a6: Incompatible stack types: I4 vs Ref
			//IL_038b->IL00a6: Incompatible stack heights: 2 vs 1
			//IL_0242->IL00a6: Incompatible stack heights: 3 vs 1
			//IL_025d->IL00a6: Incompatible stack heights: 2 vs 1
			//IL_0225->IL00a6: Incompatible stack types: I4 vs Ref
			//IL_01d2->IL00a6: Incompatible stack types: I4 vs Ref
			//IL_0198->IL00a6: Incompatible stack heights: 2 vs 1
			//IL_0361->IL00a6: Incompatible stack types: I4 vs Ref
			//IL_0294->IL00a6: Incompatible stack heights: 2 vs 1
			//IL_02d1->IL00a6: Incompatible stack heights: 2 vs 1
			//IL_03c5->IL00a6: Incompatible stack types: I4 vs Ref
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
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 1:
						_ = -2;
						_ = 5;
						continue;
					case 4:
						return;
					case 3:
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 2;
						continue;
					case 5:
						break;
					default:
					{
						ref _003CLoginAsync_003Ed__15 reference;
						switch ((int)obj)
						{
						default:
							reference = ref *(_003CLoginAsync_003Ed__15*)15;
							goto IL_00a6;
						case 1:
							obj = (object)Unsafe.AsPointer(ref this);
							reference = ref *(_003CLoginAsync_003Ed__15*)24;
							goto IL_00a6;
						case 2:
							goto IL_01aa;
						case 0:
							goto IL_0294;
							IL_00a6:
							while (true)
							{
								switch ((uint)Unsafe.AsPointer(ref reference))
								{
								case 36u:
									break;
								case 3u:
									return;
								case 11u:
									return;
								case 32u:
									return;
								case 19u:
									goto end_IL_00a6;
								case 20u:
									_ = 6;
									continue;
								case 15u:
									_ = 18;
									continue;
								case 29u:
									_ = ref obj;
									_ = 27;
									continue;
								case 25u:
									if (7 == 0)
									{
										_ = 14;
									}
									continue;
								case 7u:
									if (&obj != null)
									{
										reference = ref *(_003CLoginAsync_003Ed__15*)5;
										continue;
									}
									goto case 30u;
								case 2u:
									goto IL_01aa;
								case 24u:
									reference = ref this;
									if (3 == 0)
									{
										reference = ref *(_003CLoginAsync_003Ed__15*)21;
									}
									continue;
								case 1u:
									_ = ref obj;
									if (6 == 0)
									{
										_ = 11;
									}
									continue;
								case 23u:
									reference = ref this;
									if (13 == 0)
									{
										reference = ref *(_003CLoginAsync_003Ed__15*)7;
									}
									continue;
								case 14u:
									_ = ref obj;
									if (3 != 0)
									{
										_ = 3;
									}
									continue;
								case 18u:
									if (31 == 0)
									{
										_ = 30;
									}
									continue;
								case 34u:
									_ = 35;
									continue;
								case 13u:
									obj = -1;
									_ = 12;
									continue;
								case 28u:
									_ = null;
									if (29 != 0)
									{
										_ = 36;
									}
									continue;
								case 26u:
									goto IL_0294;
								case 9u:
									if (&obj == null)
									{
										reference = ref *(_003CLoginAsync_003Ed__15*)4;
										continue;
									}
									goto case 29u;
								case 30u:
									obj = 2;
									if (10 == 0)
									{
										_ = 0;
									}
									continue;
								case 4u:
									obj = 0;
									_ = 25;
									continue;
								case 33u:
									obj = obj;
									_ = 7;
									continue;
								case 22u:
									_ = null;
									_ = 28;
									continue;
								case 21u:
									obj = -1;
									_ = 16;
									continue;
								case 16u:
									obj = (object)(&obj);
									reference = ref *(_003CLoginAsync_003Ed__15*)33;
									continue;
								case 27u:
									obj = (object)/*Error near IL_034a: Stack underflow*/;
									if (false)
									{
										reference = ref *(_003CLoginAsync_003Ed__15*)null;
									}
									continue;
								case 10u:
									if (1 == 0)
									{
										_ = 0;
									}
									continue;
								case 8u:
									_ = null;
									_ = 22;
									continue;
								case 31u:
									obj = (object)/*Error near IL_039c: Stack underflow*/;
									reference = ref *(_003CLoginAsync_003Ed__15*)9;
									continue;
								default:
									if (&obj == null)
									{
										if (17 == 0)
										{
											reference = ref *(_003CLoginAsync_003Ed__15*)7;
										}
										continue;
									}
									goto case 16u;
								case 35u:
									obj = -1;
									_ = 29;
									continue;
								case 6u:
									_ = ref obj;
									_ = 32;
									continue;
								case 17u:
									obj = 1;
									_ = 20;
									continue;
								case 5u:
								case 12u:
									_ = ref obj;
									_ = 8;
									continue;
								}
								goto end_IL_0087;
								continue;
								end_IL_00a6:
								break;
							}
							goto case 1;
							IL_0294:
							obj = (object)Unsafe.AsPointer(ref this);
							reference = ref *(_003CLoginAsync_003Ed__15*)34;
							goto IL_00a6;
							IL_01aa:
							obj = (object)Unsafe.AsPointer(ref this);
							reference = ref *(_003CLoginAsync_003Ed__15*)23;
							goto IL_00a6;
							end_IL_0087:
							break;
						}
						goto case 1;
					}
					}
					break;
				}
				obj = 4;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_2600()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778653, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_2700(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778652, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_2800(object P_0)
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
		internal unsafe static byte _FF00_FF00_2900()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778627, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_2A00()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_2B00()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COrderAsync_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityMassOrder> _003C_003Et__builder;

		public MassService _003C_003E4__this;

		public string method;

		public int quantity;

		private TaskAwaiter<EntityMassOrder> _003C_003Eu__1;

		internal static object ObserveBridge;

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
		internal static bool MergeCommand()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckGenericTracker()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_1B00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778626, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00ᰀ()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0069: Expected Obj, but got Ref
			//IL_0258: Expected Obj, but got Ref
			//IL_00c2: Expected I4, but got Obj
			//IL_0154: Expected Obj, but got Ref
			//IL_00e6: Expected Obj, but got Ref
			//IL_0163: Expected Obj, but got I4
			//IL_0180: Expected Obj, but got I4
			//IL_0101: Expected Obj, but got Ref
			//IL_005a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004a->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0073->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0262->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0065->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0085->IL0089: Incompatible stack types: I4 vs Obj
			//IL_00e1->IL0089: Incompatible stack types: I4 vs Obj
			//IL_01c8->IL0089: Incompatible stack heights: 2 vs 1
			//IL_015e->IL0089: Incompatible stack heights: 4 vs 1
			//IL_00f2->IL0089: Incompatible stack heights: 0 vs 1
			//IL_0170->IL0089: Incompatible stack heights: 2 vs 1
			//IL_0128->IL0089: Incompatible stack heights: 2 vs 1
			//IL_018b->IL0089: Incompatible stack heights: 3 vs 1
			//IL_0143->IL0089: Incompatible stack heights: 4 vs 1
			//IL_010d->IL0089: Incompatible stack heights: 0 vs 1
			//IL_01bb->IL0089: Incompatible stack types: I4 vs Obj
			//IL_00fd->IL0089: Incompatible stack types: I4 vs Obj
			//IL_017b->IL0089: Incompatible stack heights: 2 vs 1
			//IL_0133->IL0089: Incompatible stack heights: 2 vs 1
			//IL_0118->IL0089: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				case 1:
					_ = 3;
					break;
				default:
					_ = -2;
					if (true)
					{
						_ = 1;
					}
					break;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 2;
					break;
				case 2:
					if (obj == null)
					{
						obj3 = 6;
						goto IL_0089;
					}
					goto IL_00c7;
				case 3:
					return;
				case 5:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 4;
						break;
					}
					IL_00c7:
					obj3 = obj;
					if (0 == 0)
					{
						obj3 = 1;
					}
					goto IL_0089;
					IL_0089:
					while (true)
					{
						switch ((int)obj3)
						{
						case 9:
							break;
						case 5:
							goto IL_00c7;
						case 3:
							obj = (object)(&obj);
							if (9 != 0)
							{
								obj3 = 0;
							}
							continue;
						case 6:
						case 12:
							obj = (object)Unsafe.AsPointer(ref this);
							if (0 == 0)
							{
								obj3 = 0;
							}
							continue;
						case 7:
							if (11 == 0)
							{
								_ = 6;
							}
							continue;
						case 11:
							_ = ref obj;
							_ = 10;
							continue;
						case 1:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 2;
							continue;
						case 4:
							obj = 0;
							if (7 == 0)
							{
								_ = 3;
							}
							continue;
						case 8:
							obj = -1;
							_ = 3;
							continue;
						case 10:
							return;
						case 2:
							if (&obj == null)
							{
								obj3 = 4;
								continue;
							}
							goto case 3;
						default:
							_ = 8;
							continue;
						}
						break;
					}
					goto default;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00ᴀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778625, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00Ḁ(object P_0)
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
		private unsafe sealed void _FF00_FF00ἀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778624, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_2000()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_2100()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778631, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_2200()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPingAsync_003Ed__53 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public KeyValuePair<string, string> address;

		private object _003Chandler_003E5__2;

		private object _003Cclient_003E5__3;

		private TaskAwaiter<ApiResponse<long>?> _003C_003Eu__1;

		internal static object CheckRandomFinalizer;

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
		internal static bool ReflectCustomAggregator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecodeConfig()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00ᄀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778630, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00ሀ()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_04e2: Expected Obj, but got I4
			//IL_04eb: Expected Obj, but got Ref
			//IL_009b: Expected Obj, but got I4
			//IL_0125: Expected Obj, but got I4
			//IL_0289: Expected Obj, but got Ref
			//IL_02e9: Expected Obj, but got I4
			//IL_024c: Expected Obj, but got I4
			//IL_0277: Expected Obj, but got Ref
			//IL_0213: Expected Obj, but got I4
			//IL_04e7->IL0015: Incompatible stack heights: 2 vs 0
			//IL_0048->IL0019: Incompatible stack heights: 2 vs 1
			//IL_04f7->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0053->IL0019: Incompatible stack heights: 2 vs 1
			//IL_006f->IL0073: Incompatible stack heights: 1 vs 0
			//IL_0502->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00a5->IL0073: Incompatible stack heights: 1 vs 0
			//IL_0098->IL0073: Incompatible stack heights: 1 vs 0
			//IL_00b9->IL00c8: Incompatible stack heights: 0 vs 2
			//IL_00dd->IL00fe: Incompatible stack heights: 1 vs 0
			//IL_011b->IL00c8: Incompatible stack types: I4 vs Ref
			//IL_00c4->IL00c8: Incompatible stack heights: 1 vs 2
			//IL_00c8->IL00c8: Incompatible stack types: Obj vs Ref
			//IL_013e->IL014d: Incompatible stack heights: 1 vs 4
			//IL_0162->IL019b: Incompatible stack heights: 3 vs 1
			//IL_0149->IL014d: Incompatible stack heights: 1 vs 4
			//IL_0190->IL014d: Incompatible stack heights: 3 vs 4
			//IL_01be->IL01cd: Incompatible stack heights: 3 vs 6
			//IL_019b->IL014d: Incompatible stack heights: 3 vs 4
			//IL_0202->IL02bd: Incompatible stack heights: 5 vs 3
			//IL_02e4->IL01cd: Incompatible stack types: I4 vs Ref
			//IL_01c9->IL01cd: Incompatible stack heights: 3 vs 6
			//IL_0247->IL01cd: Incompatible stack heights: 9 vs 6
			//IL_0293->IL01cd: Incompatible stack types: I4 vs Ref
			//IL_02f4->IL01cd: Incompatible stack heights: 8 vs 6
			//IL_0259->IL01cd: Incompatible stack heights: 7 vs 6
			//IL_0281->IL01cd: Incompatible stack types: I4 vs Ref
			//IL_02a3->IL01cd: Incompatible stack heights: 7 vs 6
			//IL_022c->IL01cd: Incompatible stack heights: 5 vs 6
			//IL_0264->IL01cd: Incompatible stack heights: 7 vs 6
			//IL_02ae->IL01cd: Incompatible stack heights: 7 vs 6
			//IL_01cd->IL01cd: Incompatible stack heights: 7 vs 6
			//IL_0237->IL01cd: Incompatible stack heights: 5 vs 6
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
					case 2:
						if (false)
						{
							_ = 0;
						}
						continue;
					case 0:
						return;
					case 3:
						if (true)
						{
							_ = 1;
						}
						while (true)
						{
							ref object reference;
							scoped ref _003CPingAsync_003Ed__53 reference2;
							switch ((int)/*Error near IL_0088: Stack underflow*/)
							{
							case 1:
								_ = 2;
								continue;
							default:
								obj = 0;
								_ = 3;
								continue;
							case 2:
								if (obj == null)
								{
									if (0 == 0)
									{
										_ = 0;
									}
									goto IL_00c8;
								}
								goto IL_00fe;
							case 3:
								break;
								IL_01aa:
								if (obj == null)
								{
									if (7 == 0)
									{
										_ = 7;
									}
									goto IL_01cd;
								}
								goto IL_02bd;
								IL_01cd:
								while (true)
								{
									switch ((uint)Unsafe.AsPointer(ref reference))
									{
									case 3u:
										return;
									case 11u:
										obj = 4;
										continue;
									default:
										if (&obj == null)
										{
											if (4 != 0)
											{
												_ = 5;
											}
											continue;
										}
										goto case 2u;
									case 1u:
										_ = ref obj;
										_ = 3;
										continue;
									case 5u:
										obj = 0;
										if (10 == 0)
										{
											_ = 6;
										}
										continue;
									case 6u:
									case 7u:
										obj = (object)Unsafe.AsPointer(ref this);
										reference = ref *(object*)11;
										continue;
									case 2u:
										obj = (object)(&obj);
										reference = ref *(object*)8;
										continue;
									case 10u:
										if (true)
										{
											_ = 1;
										}
										continue;
									case 9u:
										break;
									case 4u:
										obj = -1;
										_ = 2;
										continue;
									case 8u:
										goto end_IL_0073;
									}
									break;
								}
								goto IL_02bd;
								IL_00fe:
								reference2 = ref this;
								if (0 == 0)
								{
									reference2 = ref *(_003CPingAsync_003Ed__53*)1;
								}
								goto IL_00c8;
								IL_00c8:
								while (true)
								{
									switch ((uint)Unsafe.AsPointer(ref reference2))
									{
									case 2u:
										break;
									default:
										obj = 3;
										reference2 = ref *(_003CPingAsync_003Ed__53*)obj;
										continue;
									case 3u:
										goto IL_012a;
									}
									break;
								}
								goto IL_00fe;
								IL_012a:
								if (obj == null)
								{
									if (0 == 0)
									{
										_ = 1;
									}
									goto IL_014d;
								}
								goto IL_019b;
								IL_02bd:
								reference = ref obj;
								obj = obj;
								if (0 == 0)
								{
									reference = ref *(object*)null;
								}
								goto IL_01cd;
								IL_019b:
								goto IL_014d;
								IL_014d:
								while (true)
								{
									switch (2)
									{
									case 1:
									case 2:
										if (0 == 0)
										{
											_ = 0;
										}
										continue;
									case 3:
										break;
									default:
										goto IL_01aa;
									}
									break;
								}
								goto IL_019b;
								end_IL_0073:
								break;
							}
							break;
						}
						break;
					case 1:
						break;
					case 4:
						obj = (object)Unsafe.AsPointer(ref this);
						if (1 == 0)
						{
							obj2 = 3;
						}
						continue;
					}
					break;
				}
				_ = -2;
				obj = 2;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00ጀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778629, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_1400(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778628, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00ᔀ(object P_0)
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
		internal unsafe static byte _FF00_FF00ᘀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778635, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00ᜀ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_1800()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPingAsync_003Ed__54 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<KeyValuePair<string, string>> _003C_003Et__builder;

		public MassService _003C_003E4__this;

		private Dictionary<string, string>.Enumerator _003C_003E7__wrap1;

		private KeyValuePair<string, string> _003Ckvp_003E5__3;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private HashSet<string>.Enumerator _003C_003E7__wrap3;

		private TaskAwaiter<HashSet<string>> _003C_003Eu__2;

		private KeyValuePair<string, string> _003Caddress_003E5__5;

		internal static object DecorateConvertibleDefinition;

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
		internal static bool CheckMixedTransmitter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AssessClient()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_0600()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778634, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_0700()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_083a: Expected Obj, but got Ref
			//IL_0855: Expected Obj, but got Ref
			//IL_00ce: Expected I4, but got Obj
			//IL_06fc: Expected Obj, but got Ref
			//IL_04a8: Expected Obj, but got Ref
			//IL_0601: Expected Obj, but got Ref
			//IL_01a6: Expected Obj, but got I4
			//IL_06b4: Expected Obj, but got I4
			//IL_04e6: Expected Obj, but got I4
			//IL_0625: Expected Obj, but got Ref
			//IL_0197: Expected Obj, but got Ref
			//IL_052f: Expected Obj, but got Ref
			//IL_05b7: Expected Obj, but got I4
			//IL_01df: Expected Obj, but got I4
			//IL_0499: Expected Obj, but got I4
			//IL_02b2: Expected Obj, but got Ref
			//IL_02bb: Expected Obj, but got I4
			//IL_0365: Expected Obj, but got Ref
			//IL_0283: Expected Obj, but got Ref
			//IL_0326: Expected Obj, but got I4
			//IL_0397: Expected Obj, but got I4
			//IL_02c5: Expected Obj, but got I4
			//IL_0271: Expected Obj, but got Ref
			//IL_081b->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0846->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0861->IL0019: Incompatible stack heights: 0 vs 1
			//IL_082b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0851->IL0019: Incompatible stack types: I4 vs Obj
			//IL_086c->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0050->IL005f: Incompatible stack heights: 0 vs 1
			//IL_0836->IL0019: Incompatible stack heights: 2 vs 1
			//IL_009c->IL005f: Incompatible stack types: I4 vs Ref
			//IL_005b->IL005f: Incompatible stack types: I4 vs Ref
			//IL_00ba->IL005f: Incompatible stack types: I4 vs Ref
			//IL_078f->IL005f: Incompatible stack heights: 2 vs 1
			//IL_0185->IL00dc: Incompatible stack heights: 1 vs 0
			//IL_00d8->IL00dc: Incompatible stack heights: 1 vs 0
			//IL_0713->IL00dc: Incompatible stack heights: 1 vs 0
			//IL_04bf->IL00dc: Incompatible stack heights: 1 vs 0
			//IL_0641->IL00dc: Incompatible stack heights: 3 vs 0
			//IL_060b->IL00dc: Incompatible stack heights: 1 vs 0
			//IL_0192->IL00dc: Incompatible stack heights: 2 vs 0
			//IL_01b3->IL00dc: Incompatible stack heights: 2 vs 0
			//IL_06c1->IL00dc: Incompatible stack heights: 2 vs 0
			//IL_051d->IL00dc: Incompatible stack heights: 1 vs 0
			//IL_062f->IL00dc: Incompatible stack heights: 2 vs 0
			//IL_01a1->IL00dc: Incompatible stack heights: 1 vs 0
			//IL_06a4->IL00dc: Incompatible stack heights: 2 vs 0
			//IL_04f5->IL06cc: Incompatible stack heights: 1 vs 0
			//IL_0722->IL00dc: Incompatible stack heights: 3 vs 0
			//IL_04ca->IL00dc: Incompatible stack heights: 1 vs 0
			//IL_05c4->IL00dc: Incompatible stack heights: 2 vs 0
			//IL_01e4->IL00d8: Incompatible stack heights: 3 vs 2
			//IL_04d9->IL00dc: Incompatible stack heights: 1 vs 0
			//IL_065b->IL00dc: Incompatible stack heights: 1 vs 0
			//IL_04a4->IL00dc: Incompatible stack heights: 3 vs 0
			//IL_0489->IL00dc: Incompatible stack heights: 1 vs 0
			//IL_05a7->IL00dc: Incompatible stack heights: 2 vs 0
			//IL_064c->IL00dc: Incompatible stack heights: 3 vs 0
			//IL_05e1->IL00dc: Incompatible stack heights: 1 vs 0
			//IL_0694->IL00dc: Incompatible stack heights: 1 vs 0
			//IL_01be->IL00dc: Incompatible stack heights: 2 vs 0
			//IL_06cc->IL00dc: Incompatible stack heights: 2 vs 0
			//IL_0528->IL00dc: Incompatible stack heights: 1 vs 0
			//IL_00dc->IL00dc: Incompatible stack heights: 3 vs 0
			//IL_06e9->IL00dc: Incompatible stack heights: 1 vs 0
			//IL_01d0->IL00dc: Incompatible stack heights: 1 vs 0
			//IL_061d->IL00dc: Incompatible stack heights: 1 vs 0
			//IL_06af->IL00dc: Incompatible stack heights: 2 vs 0
			//IL_0546->IL054a: Incompatible stack heights: 1 vs 0
			//IL_04ff->IL00dc: Incompatible stack heights: 2 vs 0
			//IL_05cf->IL00dc: Incompatible stack heights: 2 vs 0
			//IL_0666->IL00dc: Incompatible stack heights: 1 vs 0
			//IL_0494->IL00dc: Incompatible stack heights: 1 vs 0
			//IL_05b2->IL00dc: Incompatible stack heights: 2 vs 0
			//IL_0208->IL0208: Incompatible stack heights: 1 vs 0
			//IL_0204->IL0208: Incompatible stack heights: 1 vs 0
			//IL_0308->IL0208: Incompatible stack heights: 1 vs 0
			//IL_0355->IL0208: Incompatible stack heights: 3 vs 0
			//IL_03c4->IL0208: Incompatible stack heights: 3 vs 0
			//IL_028d->IL0208: Incompatible stack heights: 2 vs 0
			//IL_0321->IL0208: Incompatible stack heights: 3 vs 0
			//IL_0331->IL0208: Incompatible stack heights: 3 vs 0
			//IL_039c->IL0204: Incompatible stack heights: 1 vs 0
			//IL_02d2->IL0208: Incompatible stack heights: 2 vs 0
			//IL_027b->IL0208: Incompatible stack heights: 1 vs 0
			//IL_0313->IL0208: Incompatible stack heights: 1 vs 0
			//IL_0360->IL0208: Incompatible stack heights: 3 vs 0
			//IL_0343->IL0208: Incompatible stack heights: 1 vs 0
			//IL_029f->IL0208: Incompatible stack heights: 1 vs 0
			//IL_03cf->IL0208: Incompatible stack heights: 3 vs 0
			//IL_03ae->IL0208: Incompatible stack heights: 1 vs 0
			//IL_037c->IL0208: Incompatible stack heights: 1 vs 0
			//IL_02dd->IL0208: Incompatible stack heights: 2 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				ref _003CPingAsync_003Ed__54 reference;
				switch ((int)obj2)
				{
				case 3:
					if ((nuint)(nint)obj <= (nuint)2u)
					{
						if (0 == 0)
						{
							reference = ref *(_003CPingAsync_003Ed__54*)null;
						}
						goto IL_005f;
					}
					goto IL_0081;
				case 5:
					return;
				default:
					_ = 5;
					break;
				case 4:
					goto IL_081b;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (true)
					{
						obj2 = 3;
					}
					break;
				case 2:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (1 == 0)
						{
							obj2 = 1;
						}
						break;
					}
					IL_005f:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 3u:
							break;
						default:
							reference = ref *(_003CPingAsync_003Ed__54*)2;
							continue;
						case 2u:
							switch ((int)obj)
							{
							default:
								_ = 15;
								goto IL_00dc;
							case 2:
								_ = 17;
								goto IL_00dc;
							case 1:
								goto IL_04a4;
							case 0:
								goto IL_06f8;
								IL_00dc:
								while (true)
								{
									switch ((int)/*Error near IL_0175: Stack underflow*/)
									{
									case 36:
										break;
									case 2:
										_ = 18;
										continue;
									case 14:
										obj = (object)(&obj);
										_ = 24;
										continue;
									case 5:
										obj = -1;
										if (2 == 0)
										{
											_ = 3;
										}
										continue;
									case 16:
										if (&obj == null)
										{
											_ = 30;
											continue;
										}
										goto case 14;
									case 27:
										_ = ref obj;
										obj = 21;
										continue;
									case 17:
										if ((nint)obj != 2)
										{
											if (1 == 0)
											{
												_ = 0;
											}
											goto IL_0208;
										}
										goto IL_02ae;
									case 21:
										return;
									case 32:
										if (6 != 0)
										{
											_ = 2;
										}
										continue;
									case 30:
										obj = 1;
										_ = 9;
										continue;
									case 8:
										goto IL_04a4;
									case 25:
									case 31:
										_ = 20;
										continue;
									case 28:
										obj = obj;
										_ = 23;
										continue;
									case 9:
										obj = 27;
										continue;
									case 23:
										if (&obj != null)
										{
											_ = 33;
											continue;
										}
										goto case 12;
									case 7:
										goto IL_050e;
									case 20:
										obj = (object)Unsafe.AsPointer(ref this);
										if (false)
										{
											_ = 0;
										}
										switch ((int)/*Error near IL_0553: Stack underflow*/)
										{
										}
										goto case 28;
									case 35:
										if (8 == 0)
										{
											_ = 10;
										}
										continue;
									case 26:
										obj = 0;
										if (19 == 0)
										{
											_ = 19;
										}
										continue;
									case 3:
										if (&obj == null)
										{
											_ = 31;
											continue;
										}
										goto case 1;
									case 1:
										obj = (object)Unsafe.AsPointer(ref this);
										_ = 11;
										continue;
									case 15:
									case 18:
									case 33:
										if (Unsafe.AsPointer(ref this) == null)
										{
											_ = 22;
											continue;
										}
										goto case 35;
									case 10:
										obj = (object)Unsafe.AsPointer(ref this);
										_ = 4;
										continue;
									default:
										_ = ref obj;
										if (34 == 0)
										{
											_ = 23;
										}
										continue;
									case 29:
										if (4 != 0)
										{
											_ = 5;
										}
										continue;
									case 34:
										return;
									case 4:
										if (&obj == null)
										{
											_ = 26;
											continue;
										}
										goto case 3;
									case 19:
										if (false)
										{
											_ = 0;
										}
										continue;
									case 6:
										obj = -1;
										if (7 != 0)
										{
											_ = 14;
										}
										continue;
									case 12:
										obj = obj;
										if (16 != 0)
										{
											_ = 3;
										}
										continue;
									case 13:
										goto IL_06f8;
									case 24:
										_ = 36;
										continue;
									case 22:
										goto end_IL_00bd;
									case 11:
										goto IL_081b;
										IL_02ae:
										obj = (object)Unsafe.AsPointer(ref this);
										obj = 14;
										goto IL_0208;
										IL_050e:
										if (2 != 0)
										{
											_ = 2;
										}
										continue;
										IL_0208:
										while (true)
										{
											switch ((int)/*Error near IL_0259: Stack underflow*/)
											{
											case 18:
												return;
											case 16:
												obj = (object)Unsafe.AsPointer(ref this);
												_ = 3;
												continue;
											case 10:
												obj = (object)Unsafe.AsPointer(ref this);
												_ = 8;
												continue;
											case 5:
											case 7:
												if (&obj != null)
												{
													_ = 16;
													continue;
												}
												goto default;
											case 17:
												break;
											case 15:
												obj = 2;
												if (11 == 0)
												{
													_ = 5;
												}
												continue;
											default:
												if (4 == 0)
												{
													_ = 1;
												}
												continue;
											case 11:
												_ = 2;
												continue;
											case 13:
												obj = -1;
												_ = 5;
												continue;
											case 1:
											case 4:
												if (Unsafe.AsPointer(ref this) == null)
												{
													_ = 12;
													continue;
												}
												goto case 9;
											case 2:
												_ = ref obj;
												if (9 != 0)
												{
													_ = 18;
												}
												continue;
											case 9:
												obj = (object)Unsafe.AsPointer(ref this);
												if (6 != 0)
												{
													_ = 0;
												}
												continue;
											case 14:
												obj = 13;
												continue;
											case 8:
												if (&obj != null)
												{
													_ = 7;
													continue;
												}
												goto case 15;
											case 6:
												if (8 == 0)
												{
													_ = 10;
												}
												continue;
											case 12:
												goto IL_050e;
											case 3:
												goto IL_081b;
											}
											break;
										}
										goto IL_02ae;
									}
									break;
								}
								goto case 2;
								IL_06f8:
								obj = (object)Unsafe.AsPointer(ref this);
								if (4 != 0)
								{
									_ = 29;
								}
								goto IL_00dc;
								IL_04a4:
								obj = (object)Unsafe.AsPointer(ref this);
								if (32 == 0)
								{
									_ = 21;
								}
								goto IL_00dc;
								end_IL_00bd:
								break;
							}
							goto case 5u;
						case 5u:
							_ = 4;
							continue;
						case 4u:
							throw /*Error near IL_0792: Stack underflow*/;
						}
						break;
					}
					goto IL_0081;
					IL_0081:
					reference = ref this;
					if (1 == 0)
					{
						reference = ref *(_003CPingAsync_003Ed__54*)1;
					}
					goto IL_005f;
					IL_081b:
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
		private unsafe sealed void _FF00_FF00ࠀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778633, new IntPtr(2737337472204L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_0900(object P_0)
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
		private unsafe sealed void _FF00_FF00_0A00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778632, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_0B00()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_0C00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778639, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_0D00()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRedeemCodeAsync_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MassService _003C_003E4__this;

		public string code;

		private TaskAwaiter _003C_003Eu__1;

		private static object CheckSegmentedAnalyzer;

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
		internal static bool CheckCommonDistributor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectAdaptableNotifier()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00切()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778638, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00ﬀ()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0040: Expected Obj, but got Ref
			//IL_0069: Expected Obj, but got Ref
			//IL_027d: Expected Obj, but got I4
			//IL_0194: Expected Obj, but got Ref
			//IL_01b2: Expected Obj, but got I4
			//IL_0179: Expected Obj, but got Ref
			//IL_0111: Expected Obj, but got I4
			//IL_004a->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0075->IL0019: Incompatible stack heights: 0 vs 1
			//IL_005a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0282->IL0015: Incompatible stack heights: 1 vs 0
			//IL_0080->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0065->IL0019: Incompatible stack heights: 2 vs 1
			//IL_019e->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_0094->IL00a3: Incompatible stack heights: 0 vs 1
			//IL_009f->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_0150->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_00f1->IL00a3: Incompatible stack heights: 4 vs 1
			//IL_0101->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_01bd->IL00a3: Incompatible stack heights: 3 vs 1
			//IL_0185->IL00a3: Incompatible stack types: Obj vs Ref
			//IL_011e->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_010c->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_01d7->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_0190->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_0164->IL00a3: Incompatible stack heights: 0 vs 1
			//IL_0143->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_0129->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_016f->IL00a3: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					ref byte reference;
					switch ((int)obj2)
					{
					case 4:
						return;
					default:
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 5;
						continue;
					case 2:
						_ = -2;
						if (3 == 0)
						{
							_ = 3;
						}
						continue;
					case 1:
						obj = (object)Unsafe.AsPointer(ref this);
						if (false)
						{
							obj2 = 0;
						}
						continue;
					case 5:
						if (obj != null)
						{
							if (false)
							{
								reference = ref *(byte*)null;
							}
							goto IL_00a3;
						}
						goto IL_0190;
					case 3:
						break;
						IL_0190:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(byte*)11;
						goto IL_00a3;
						IL_00a3:
						while (true)
						{
							switch ((uint)Unsafe.AsPointer(ref reference))
							{
							case 9u:
								return;
							case 7u:
								break;
							case 1u:
								_ = ref obj;
								_ = 9;
								continue;
							case 3u:
								if (1 == 0)
								{
									_ = 1;
								}
								continue;
							case 12u:
								obj = -1;
								if (4 != 0)
								{
									_ = 1;
								}
								continue;
							case 11u:
								reference = ref Unsafe.As<_003CRedeemCodeAsync_003Ed__31, byte>(ref this);
								if (12 == 0)
								{
									reference = ref *(byte*)1;
								}
								continue;
							default:
								_ = 8;
								continue;
							case 10u:
								if (&obj != null)
								{
									if (2 != 0)
									{
										reference = ref *(byte*)1;
									}
									continue;
								}
								goto case 6u;
							case 8u:
							{
								object obj3 = obj;
								obj = (object)Unsafe.AsPointer(ref this);
								reference = ref *(byte*)obj3;
								if (10 != 0)
								{
									reference = ref *(byte*)8;
								}
								continue;
							}
							case 5u:
								goto IL_0190;
							case 6u:
								obj = 0;
								_ = 3;
								continue;
							case 2u:
							case 4u:
								reference = ref *(byte*)(&obj);
								if (7 == 0)
								{
									reference = ref *(byte*)6;
								}
								continue;
							}
							break;
						}
						goto case 2;
					}
					break;
				}
				obj = 4;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00ﰀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778637, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00ﴀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778636, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FE00(object P_0)
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
		internal static byte _FF00_FF00()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00Ā()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778675, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00Ȁ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_0300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778674, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRedeemProductAsync_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MassService _003C_003E4__this;

		public string code;

		private TaskAwaiter _003C_003Eu__1;

		internal static object DecoratePortableDispatcher;

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
		internal static bool ConcatTag()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateReadableParser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_F000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778673, new IntPtr(2737337475324L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_F100()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0244: Expected Obj, but got I4
			//IL_003f: Expected Obj, but got Ref
			//IL_0268: Expected Obj, but got Ref
			//IL_009c: Expected I4, but got Obj
			//IL_0145: Expected Obj, but got Ref
			//IL_0192: Expected Obj, but got Ref
			//IL_0123: Expected Obj, but got I4
			//IL_01ae: Expected Obj, but got I4
			//IL_0249->IL0015: Incompatible stack heights: 1 vs 0
			//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0274->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0259->IL0019: Incompatible stack heights: 2 vs 1
			//IL_027f->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0264->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00b0->IL005f: Incompatible stack types: Obj vs Ref
			//IL_005b->IL005f: Incompatible stack types: I4 vs Ref
			//IL_00bb->IL005f: Incompatible stack types: I4 vs Ref
			//IL_014f->IL005f: Incompatible stack heights: 2 vs 1
			//IL_016c->IL005f: Incompatible stack heights: 2 vs 1
			//IL_015f->IL005f: Incompatible stack heights: 4 vs 1
			//IL_019e->IL005f: Incompatible stack heights: 0 vs 1
			//IL_00f9->IL005f: Incompatible stack heights: 2 vs 1
			//IL_0130->IL005f: Incompatible stack heights: 2 vs 1
			//IL_01b9->IL005f: Incompatible stack heights: 3 vs 1
			//IL_01a9->IL005f: Incompatible stack types: I4 vs Ref
			//IL_00e9->IL005f: Incompatible stack types: I4 vs Ref
			//IL_0104->IL005f: Incompatible stack heights: 2 vs 1
			//IL_013b->IL005f: Incompatible stack heights: 2 vs 1
			//IL_011e->IL005f: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					ref object reference;
					switch ((int)obj2)
					{
					case 1:
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 4;
						continue;
					case 4:
						if (obj == null)
						{
							reference = ref *(object*)12;
							goto IL_005f;
						}
						goto IL_00a1;
					case 5:
						return;
					case 3:
						goto IL_0249;
					case 2:
						{
							obj = (object)Unsafe.AsPointer(ref this);
							if (1 == 0)
							{
								obj2 = 0;
							}
							continue;
						}
						IL_005f:
						while (true)
						{
							switch ((uint)Unsafe.AsPointer(ref reference))
							{
							case 5u:
								break;
							case 8u:
								if (&obj != null)
								{
									reference = ref *(object*)2;
									continue;
								}
								goto case 13u;
							case 9u:
								if (2 != 0)
								{
									_ = 3;
								}
								continue;
							case 2u:
							case 11u:
								reference = ref obj;
								if (7 == 0)
								{
									reference = ref *(object*)4;
								}
								continue;
							case 10u:
								obj = -1;
								if (11 == 0)
								{
									_ = 3;
								}
								continue;
							default:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 8;
								continue;
							case 3u:
								_ = ref obj;
								_ = 4;
								continue;
							case 1u:
								_ = 10;
								continue;
							case 4u:
								return;
							case 6u:
							case 12u:
								obj = (object)Unsafe.AsPointer(ref this);
								if (1 == 0)
								{
									reference = ref *(object*)1;
								}
								continue;
							case 13u:
								obj = 0;
								_ = 9;
								continue;
							case 7u:
								goto IL_0249;
							}
							break;
						}
						goto IL_00a1;
						IL_0249:
						_ = -2;
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
						IL_00a1:
						reference = ref *(object*)obj;
						if (0 != 0)
						{
							reference = ref *(object*)null;
						}
						goto IL_005f;
					}
					break;
				}
				obj = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_F200()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778672, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_F300(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778679, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_F400(object P_0)
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
		internal static byte _FF00_F500()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_F600()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778678, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_F700()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_F800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778677, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRedeemReferralPointsAsync_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityMassReferralVoucher> _003C_003Et__builder;

		public MassService _003C_003E4__this;

		public string productCode;

		private TaskAwaiter<EntityMassReferralVoucher> _003C_003Eu__1;

		internal static object CheckRemoteState;

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
		internal static bool ReflectActiveHandler()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SearchAnalyzer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_E500()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778676, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_E600()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0056: Expected Obj, but got I4
			//IL_003f: Expected Obj, but got Ref
			//IL_005f: Expected Obj, but got Ref
			//IL_011c: Expected Obj, but got Ref
			//IL_007a: Expected Obj, but got I4
			//IL_010d: Expected Obj, but got I4
			//IL_00cb: Expected Obj, but got Ref
			//IL_00ea: Expected Obj, but got Ref
			//IL_00f3: Expected Obj, but got I4
			//IL_013f: Expected Obj, but got I4
			//IL_00fd: Expected Obj, but got I4
			//IL_005b->IL0015: Incompatible stack heights: 2 vs 0
			//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0069->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0245->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0250->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0133->IL0083: Incompatible stack heights: 1 vs 0
			//IL_0083->IL0083: Incompatible stack heights: 1 vs 0
			//IL_0118->IL0083: Incompatible stack heights: 3 vs 0
			//IL_01b6->IL0083: Incompatible stack heights: 3 vs 0
			//IL_00d5->IL0083: Incompatible stack heights: 2 vs 0
			//IL_0151->IL0083: Incompatible stack heights: 2 vs 0
			//IL_0144->IL007f: Incompatible stack heights: 1 vs 0
			//IL_0108->IL0083: Incompatible stack heights: 3 vs 0
			//IL_00e5->IL0083: Incompatible stack heights: 4 vs 0
			//IL_018c->IL0083: Incompatible stack heights: 1 vs 0
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
					case 2:
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 5;
						continue;
					case 1:
						break;
					case 3:
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 2;
						continue;
					case 5:
						if (obj != null)
						{
							obj = 8;
							goto IL_0083;
						}
						goto IL_0118;
					case 4:
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
					case 0:
						return;
						IL_0083:
						while (true)
						{
							switch ((int)/*Error near IL_00bc: Stack underflow*/)
							{
							case 6:
								break;
							case 4:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 7;
								continue;
							case 12:
								_ = ref obj;
								_ = 11;
								continue;
							default:
								obj = (object)(&obj);
								obj = 6;
								continue;
							case 10:
								obj = -1;
								_ = 5;
								continue;
							case 2:
								obj = 0;
								_ = 3;
								continue;
							case 1:
								goto end_IL_0083;
							case 9:
								obj = 10;
								continue;
							case 8:
								_ = 4;
								continue;
							case 7:
								if (&obj != null)
								{
									if (0 == 0)
									{
										_ = 0;
									}
									continue;
								}
								goto case 2;
							case 11:
								return;
							case 3:
								_ = 12;
								continue;
							}
							goto end_IL_0019;
							continue;
							end_IL_0083:
							break;
						}
						goto IL_0118;
						IL_0118:
						obj = (object)Unsafe.AsPointer(ref this);
						if (9 == 0)
						{
							_ = 6;
						}
						goto IL_0083;
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
		private unsafe sealed void _FF00_E700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778683, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_E800(object P_0)
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
		private unsafe sealed void _FF00_E900(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778682, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_EA00()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_EB00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778681, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_EC00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778680, new IntPtr(2737337472204L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_ED00()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_EE00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778687, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRedeemReferralSelfAsync_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MassService _003C_003E4__this;

		public string productCode;

		private TaskAwaiter _003C_003Eu__1;

		private static object CheckLiteralReporter;

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
		internal static bool CheckScalableChain()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectModularRole()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778686, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FFFD()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_022c: Expected Obj, but got Ref
			//IL_0247: Expected Obj, but got Ref
			//IL_00ba: Expected Obj, but got Ref
			//IL_00fe: Expected Obj, but got Ref
			//IL_012c: Expected Obj, but got I4
			//IL_00d6: Expected Obj, but got I4
			//IL_00a4: Expected I4, but got Obj
			//IL_0228->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0238->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0253->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0048->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0151->IL006b: Incompatible stack types: I4 vs Obj
			//IL_005c->IL006b: Incompatible stack heights: 0 vs 2
			//IL_0243->IL0019: Incompatible stack types: I4 vs Obj
			//IL_025e->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00a4->IL0144: Incompatible stack heights: 1 vs 0
			//IL_0067->IL006b: Incompatible stack heights: 1 vs 2
			//IL_00b6->IL006b: Incompatible stack heights: 3 vs 2
			//IL_00c4->IL006b: Incompatible stack types: I4 vs Obj
			//IL_0139->IL006b: Incompatible stack heights: 3 vs 2
			//IL_0161->IL006b: Incompatible stack heights: 3 vs 2
			//IL_00d1->IL006b: Incompatible stack heights: 3 vs 2
			//IL_00e1->IL006b: Incompatible stack heights: 4 vs 2
			//IL_017e->IL006b: Incompatible stack heights: 4 vs 2
			//IL_0115->IL006b: Incompatible stack types: I4 vs Obj
			//IL_0127->IL006b: Incompatible stack types: I4 vs Obj
			//IL_0144->IL006b: Incompatible stack heights: 3 vs 2
			//IL_016c->IL006b: Incompatible stack heights: 3 vs 2
			//IL_0189->IL006b: Incompatible stack heights: 4 vs 2
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				case 4:
					_ = 5;
					break;
				case 1:
					if (obj == null)
					{
						if (false)
						{
							_ = 0;
						}
						goto IL_006b;
					}
					goto IL_0144;
				default:
					goto IL_021a;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						obj2 = 1;
					}
					break;
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 == 0)
					{
						obj2 = 1;
					}
					break;
				case 5:
					return;
					IL_0144:
					obj3 = 3;
					goto IL_006b;
					IL_006b:
					while (true)
					{
						switch ((int)obj3)
						{
						case 1:
							_ = ref obj;
							_ = 8;
							continue;
						default:
							obj = (object)Unsafe.AsPointer(ref this);
							obj3 = 10;
							continue;
						case 10:
							_ = 5;
							continue;
						case 11:
							obj = 0;
							_ = 7;
							continue;
						case 9:
							return;
						case 3:
							obj3 = obj;
							obj = (object)Unsafe.AsPointer(ref this);
							if (4 != 0)
							{
								obj3 = 3;
							}
							continue;
						case 4:
							if (&obj == null)
							{
								obj3 = 11;
								continue;
							}
							goto case 1;
						case 5:
							obj = -1;
							if (false)
							{
								_ = 1;
							}
							continue;
						case 6:
							break;
						case 7:
							if (9 != 0)
							{
								_ = 12;
							}
							continue;
						case 12:
							_ = ref obj;
							if (1 == 0)
							{
								_ = 9;
							}
							continue;
						case 8:
							goto IL_021a;
						}
						break;
					}
					goto IL_0144;
					IL_021a:
					_ = -2;
					_ = 4;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778685, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FFFD(object P_0)
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
		internal unsafe static byte _FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778684, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_E000()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_E100()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778659, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_E200()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_E300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778658, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRegisterAsync_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MassService _003C_003E4__this;

		public string username;

		public string password;

		public string inviteCode;

		private TaskAwaiter _003C_003Eu__1;

		internal static object ReflectGroupedCollection;

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
		internal static bool CheckAccessibleProfile()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateIsolatedChooser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00턀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778657, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00툀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0218: Expected Obj, but got Ref
			//IL_024f: Expected Obj, but got Ref
			//IL_00d2: Expected Obj, but got Ref
			//IL_00b6: Expected Obj, but got I4
			//IL_0163: Expected Obj, but got I4
			//IL_0152: Expected Obj, but got I4
			//IL_0137: Expected Obj, but got I4
			//IL_0141: Expected Obj, but got I4
			//IL_017f: Expected Obj, but got Ref
			//IL_0240->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0048->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0224->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0259->IL0019: Incompatible stack types: I4 vs Obj
			//IL_024b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_022f->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00e9->IL006b: Incompatible stack heights: 1 vs 0
			//IL_0067->IL006b: Incompatible stack heights: 1 vs 0
			//IL_00c3->IL006b: Incompatible stack heights: 2 vs 0
			//IL_00b1->IL006b: Incompatible stack heights: 4 vs 0
			//IL_0116->IL006b: Incompatible stack heights: 3 vs 0
			//IL_0146->IL0067: Incompatible stack heights: 2 vs 1
			//IL_018b->IL006b: Incompatible stack heights: 3 vs 0
			//IL_0179->IL0179: Incompatible stack heights: 3 vs 4
			//IL_00ce->IL006b: Incompatible stack heights: 2 vs 0
			//IL_006b->IL006b: Incompatible stack heights: 2 vs 0
			//IL_0196->IL006b: Incompatible stack heights: 3 vs 0
			//IL_0108->IL006b: Incompatible stack heights: 1 vs 0
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
					_ = 2;
					break;
				case 1:
					if (obj != null)
					{
						if (0 == 0)
						{
							_ = 0;
						}
						goto IL_006b;
					}
					goto IL_00ce;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					if (true)
					{
						obj2 = 0;
					}
					break;
				case 2:
					return;
				default:
					goto IL_0230;
				case 5:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 4;
						break;
					}
					IL_006b:
					while (true)
					{
						scoped ref byte reference;
						switch ((int)/*Error near IL_009c: Stack underflow*/)
						{
						case 3:
							_ = ref obj;
							_ = 9;
							continue;
						case 2:
							obj = -1;
							if (6 == 0)
							{
								_ = 4;
							}
							continue;
						case 1:
							break;
						case 8:
							if (&obj == null)
							{
								if (9 != 0)
								{
									_ = 10;
								}
								continue;
							}
							goto case 6;
						case 4:
							_ = 3;
							continue;
						case 9:
							return;
						case 10:
							obj = 0;
							obj = 4;
							continue;
						case 6:
							reference = ref *(byte*)(&obj);
							obj = 7;
							continue;
						case 5:
							reference = ref Unsafe.As<_003CRegisterAsync_003Ed__17, byte>(ref this);
							obj = 2;
							continue;
						default:
							if (Unsafe.AsPointer(ref this) == null)
							{
							}
							obj = (object)Unsafe.AsPointer(ref this);
							if (2 != 0)
							{
								_ = 8;
							}
							continue;
						case 7:
							goto IL_0230;
						}
						break;
					}
					goto IL_00ce;
					IL_0230:
					_ = -2;
					if (3 == 0)
					{
						_ = 3;
					}
					break;
					IL_00ce:
					obj = (object)Unsafe.AsPointer(ref this);
					if (5 != 0)
					{
						_ = 1;
					}
					goto IL_006b;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00팀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778656, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00퐀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778663, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00픀(object P_0)
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
		internal static byte _FF00혀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00휀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778662, new IntPtr(2737337475324L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FFFD()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778661, new IntPtr(2737337475324L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSolveCaptchaAsync_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public MassService _003C_003E4__this;

		public byte[] captcha;

		public int version;

		private TaskAwaiter<string> _003C_003Eu__1;

		internal static object CheckAutomatableSolver;

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
		internal static bool MatchStruct()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AssembleReporter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00였()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778660, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00윀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_004d: Expected Obj, but got Ref
			//IL_00ef: Expected I4, but got Obj
			//IL_0141: Expected Obj, but got Ref
			//IL_01a4: Expected Obj, but got I4
			//IL_01e6: Expected Obj, but got Ref
			//IL_015c: Expected Obj, but got Ref
			//IL_01f5: Expected Obj, but got I4
			//IL_0075->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0091->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0059->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0080->IL0019: Incompatible stack heights: 2 vs 1
			//IL_009c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0131->IL00b2: Incompatible stack types: Obj vs Ref
			//IL_00ae->IL00b2: Incompatible stack types: I4 vs Ref
			//IL_0064->IL0019: Incompatible stack types: I4 vs Obj
			//IL_013c->IL00b2: Incompatible stack types: I4 vs Ref
			//IL_014d->IL00b2: Incompatible stack heights: 0 vs 1
			//IL_01af->IL00b2: Incompatible stack heights: 3 vs 1
			//IL_01bd->IL00b2: Incompatible stack heights: 3 vs 1
			//IL_0176->IL00b2: Incompatible stack heights: 4 vs 1
			//IL_01f0->IL00b2: Incompatible stack heights: 3 vs 1
			//IL_0166->IL00b2: Incompatible stack types: I4 vs Ref
			//IL_0202->IL00b2: Incompatible stack heights: 2 vs 1
			//IL_0158->IL00b2: Incompatible stack types: I4 vs Ref
			//IL_019f->IL00b2: Incompatible stack types: I4 vs Ref
			//IL_0108->IL00b2: Incompatible stack heights: 0 vs 1
			//IL_020d->IL00b2: Incompatible stack heights: 2 vs 1
			//IL_0113->IL00b2: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				ref _003CSolveCaptchaAsync_003Ed__23 reference;
				switch ((int)obj2)
				{
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 3;
					break;
				case 5:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 4;
					}
					break;
				case 2:
					return;
				default:
					_ = -2;
					if (1 == 0)
					{
						_ = 0;
					}
					break;
				case 1:
					if (2 != 0)
					{
						_ = 0;
					}
					break;
				case 3:
					{
						if (obj == null)
						{
							reference = ref *(_003CSolveCaptchaAsync_003Ed__23*)4;
							goto IL_00b2;
						}
						goto IL_0122;
					}
					IL_0122:
					reference = ref *(_003CSolveCaptchaAsync_003Ed__23*)obj;
					if (9 != 0)
					{
						reference = ref *(_003CSolveCaptchaAsync_003Ed__23*)7;
					}
					goto IL_00b2;
					IL_00b2:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 11u:
							return;
						case 1u:
							break;
						case 10u:
							if (&obj != null)
							{
								if (3 == 0)
								{
									reference = ref *(_003CSolveCaptchaAsync_003Ed__23*)7;
								}
								continue;
							}
							goto case 3u;
						default:
							goto IL_0122;
						case 2u:
						case 7u:
							obj = (object)(&obj);
							if (true)
							{
								reference = ref *(_003CSolveCaptchaAsync_003Ed__23*)null;
							}
							continue;
						case 4u:
						case 12u:
							obj = (object)Unsafe.AsPointer(ref this);
							reference = ref *(_003CSolveCaptchaAsync_003Ed__23*)5;
							continue;
						case 8u:
							_ = ref obj;
							_ = 11;
							continue;
						case 5u:
							reference = ref this;
							if (3 == 0)
							{
								reference = ref *(_003CSolveCaptchaAsync_003Ed__23*)13;
							}
							continue;
						case 3u:
							obj = 0;
							_ = 6;
							continue;
						case 6u:
							_ = 8;
							continue;
						case 9u:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 10;
							continue;
						case 13u:
							obj = -1;
							if (2 == 0)
							{
								_ = 2;
							}
							continue;
						}
						break;
					}
					goto default;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00저()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778667, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00준(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778666, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00쨀(object P_0)
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
		private unsafe sealed void _FF00쬀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778665, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00찀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00촀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778664, new IntPtr(2737337471164L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00츀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00케()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778671, new IntPtr(2737337475324L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUpdateAsync_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MassService _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object CheckLocalResolver;

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
		internal static bool CheckSymbolicDecryptor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object StopParameter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00븀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778670, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00뼀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_021d: Expected Obj, but got Ref
			//IL_0226: Expected Obj, but got I4
			//IL_023e: Expected Obj, but got Ref
			//IL_00a0: Expected I4, but got Obj
			//IL_0184: Expected Obj, but got Ref
			//IL_00f4: Expected Obj, but got I4
			//IL_014b: Expected Obj, but got I4
			//IL_0239->IL0019: Incompatible stack heights: 3 vs 1
			//IL_024a->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0048->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0255->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00e4->IL006b: Incompatible stack types: Obj vs Ref
			//IL_005c->IL006b: Incompatible stack heights: 0 vs 1
			//IL_00ef->IL006b: Incompatible stack types: I4 vs Ref
			//IL_0067->IL006b: Incompatible stack types: I4 vs Ref
			//IL_0190->IL006b: Incompatible stack heights: 0 vs 1
			//IL_0175->IL006b: Incompatible stack heights: 3 vs 1
			//IL_00ff->IL006b: Incompatible stack heights: 3 vs 1
			//IL_0129->IL006b: Incompatible stack heights: 2 vs 1
			//IL_0163->IL006b: Incompatible stack heights: 2 vs 1
			//IL_0156->IL006b: Incompatible stack heights: 3 vs 1
			//IL_019b->IL006b: Incompatible stack types: I4 vs Ref
			//IL_0180->IL006b: Incompatible stack heights: 3 vs 1
			//IL_0119->IL006b: Incompatible stack types: I4 vs Ref
			//IL_0134->IL006b: Incompatible stack heights: 2 vs 1
			//IL_0146->IL006b: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					ref _003CUpdateAsync_003Ed__22 reference;
					object obj3;
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
								reference = ref *(_003CUpdateAsync_003Ed__22*)1;
							}
							goto IL_006b;
						}
						goto IL_00d0;
					case 1:
						break;
					default:
						goto IL_022b;
					case 4:
						return;
					case 2:
						{
							obj = (object)Unsafe.AsPointer(ref this);
							if (1 == 0)
							{
								obj2 = 0;
							}
							continue;
						}
						IL_006b:
						while (true)
						{
							switch ((uint)Unsafe.AsPointer(ref reference))
							{
							case 9u:
								return;
							case 5u:
								break;
							case 4u:
								obj = -1;
								_ = 7;
								continue;
							case 3u:
								reference = ref this;
								if (2 == 0)
								{
									reference = ref *(_003CUpdateAsync_003Ed__22*)4;
								}
								continue;
							case 6u:
								if (2 == 0)
								{
									_ = 0;
								}
								continue;
							case 10u:
								if (&obj == null)
								{
									reference = ref *(_003CUpdateAsync_003Ed__22*)11;
									continue;
								}
								goto case 7u;
							case 11u:
								obj = 0;
								_ = 6;
								continue;
							case 7u:
								_ = ref obj;
								_ = 8;
								continue;
							case 2u:
								_ = ref obj;
								if (6 == 0)
								{
									_ = 9;
								}
								continue;
							default:
								obj = (object)Unsafe.AsPointer(ref this);
								if (false)
								{
									reference = ref *(_003CUpdateAsync_003Ed__22*)3;
								}
								continue;
							case 8u:
								goto IL_022b;
							}
							break;
						}
						goto IL_00d0;
						IL_022b:
						_ = -2;
						_ = 5;
						continue;
						IL_00d0:
						obj3 = obj;
						obj = null;
						reference = ref *(_003CUpdateAsync_003Ed__22*)obj3;
						if (8 == 0)
						{
							reference = ref *(_003CUpdateAsync_003Ed__22*)10;
						}
						goto IL_006b;
					}
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
				obj = 3;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00쀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778669, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00섀(object P_0)
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
		internal static byte _FF00숀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00쌀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00쐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778668, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CVerifyTokenAsync_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MassService _003C_003E4__this;

		public string token;

		private TaskAwaiter _003C_003Eu__1;

		internal static object ReadGateway;

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
		internal static bool DecorateMonoUser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectOrderedInitializer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00됀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778707, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00딀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0075: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_00f7: Expected Obj, but got Ref
			//IL_018b: Expected Obj, but got Ref
			//IL_012f: Expected Obj, but got I4
			//IL_01af: Expected Obj, but got I4
			//IL_0159: Expected Obj, but got I4
			//IL_0081->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0099->IL0019: Incompatible stack heights: 2 vs 1
			//IL_008c->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0071->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0101->IL00bd: Incompatible stack types: I4 vs Ref
			//IL_00ae->IL00bd: Incompatible stack heights: 0 vs 1
			//IL_00b9->IL00bd: Incompatible stack types: I4 vs Ref
			//IL_0197->IL00bd: Incompatible stack types: Obj vs Ref
			//IL_013a->IL00bd: Incompatible stack heights: 3 vs 1
			//IL_012a->IL00bd: Incompatible stack heights: 2 vs 1
			//IL_0176->IL00bd: Incompatible stack heights: 3 vs 1
			//IL_0164->IL00bd: Incompatible stack heights: 3 vs 1
			//IL_01c6->IL00bd: Incompatible stack types: I4 vs Ref
			//IL_01a2->IL00bd: Incompatible stack types: I4 vs Ref
			//IL_0181->IL00bd: Incompatible stack heights: 3 vs 1
			//IL_0154->IL00bd: Incompatible stack types: I4 vs Ref
			//IL_00bd->IL00bd: Incompatible stack heights: 3 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				ref object reference;
				switch ((int)obj2)
				{
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				case 2:
					_ = -2;
					if (4 == 0)
					{
						_ = 4;
					}
					break;
				default:
					obj = (object)Unsafe.AsPointer(ref this);
					if (3 == 0)
					{
						obj2 = 5;
					}
					break;
				case 4:
					_ = 3;
					break;
				case 3:
					return;
				case 5:
					{
						if (obj != null)
						{
							if (false)
							{
								reference = ref *(object*)3;
							}
							goto IL_00bd;
						}
						goto IL_00f3;
					}
					IL_00f3:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(object*)5;
					goto IL_00bd;
					IL_00bd:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 9u:
							return;
						case 2u:
							goto IL_00f3;
						case 5u:
							_ = 4;
							continue;
						case 4u:
							obj = -1;
							_ = 7;
							continue;
						case 7u:
							reference = ref obj;
							if (0 == 0)
							{
								reference = ref *(object*)null;
							}
							continue;
						case 10u:
							obj = 0;
							_ = 8;
							continue;
						case 6u:
							_ = ref obj;
							if (3 != 0)
							{
								_ = 9;
							}
							continue;
						case 3u:
						{
							object obj3 = obj;
							obj = (object)Unsafe.AsPointer(ref this);
							reference = ref *(object*)obj3;
							if (1 == 0)
							{
								reference = ref *(object*)1;
							}
							continue;
						}
						case 8u:
							obj = 6;
							continue;
						case 1u:
							if (&obj == null)
							{
								reference = ref *(object*)10;
								continue;
							}
							goto case 7u;
						}
						break;
					}
					goto case 2;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00똀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778706, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00뜀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778705, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00렀(object P_0)
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
		internal static byte _FF00뤀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00먀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778704, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00묀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778711, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00밀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}
	}

	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	[CompilerGenerated]
	private Action<EntityMassUser>? m_UserChanged;

	[CompilerGenerated]
	private Func<EntityMassContent[], Task>? m_ResultContent;

	public EntityMassUser? User;

	public EntityMassVersion? Version;

	private object? _ircToken;

	[CompilerGenerated]
	private static readonly object Instance__BackingField;

	private object? _client;

	internal static MassService HandleRunner;

	public static ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	private string ApplicationName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00대();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00言(value);
		}
	}

	private string VersionName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00蜀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00蔀(value);
		}
	}

	public static MassService Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	private RestClient Client
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (RestClient)_FF00_FF00_FF00簀();
		}
	}

	public event Action<EntityMassUser>? UserChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00_FF00_FF00ꠀ(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00_FF00_FF00鼀(value);
		}
	}

	public event Func<EntityMassContent[], Task>? ResultContent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00_FF00_FF00ꘀ(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00_FF00_FF00瘀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Logout()
	{
		_FF00_FF00_FF00ꨀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CApiRequestAsync_003Ed__12))]
	private object ApiRequestAsync(object endpoint, object? data = null)
	{
		return _FF00_FF00_FF00씀(endpoint, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CApiRequestAsync_003Ed__13<>))]
	public Task<TResult> ApiRequestAsync<TResult>(string endpoint, object? data = null)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCheckVersionAsync_003Ed__14))]
	public Task<EntityMassVersion> CheckVersionAsync()
	{
		return _FF00_FF00_FF00阀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoginAsync_003Ed__15))]
	public Task LoginAsync(string username, string password)
	{
		return (Task)_FF00_FF00_FF00輀(username, password);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CVerifyTokenAsync_003Ed__16))]
	public Task VerifyTokenAsync(string token)
	{
		return (Task)_FF00_FF00_FF00관(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRegisterAsync_003Ed__17))]
	public Task RegisterAsync(string username, string password, string? inviteCode = null)
	{
		return (Task)_FF00_FF00_FF00销(username, password, inviteCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetReferralProductsAsync_003Ed__18))]
	public Task<List<EntityMassReferralProduct>> GetReferralProductsAsync()
	{
		return _FF00_FF00_FF00봀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetReferralInfoAsync_003Ed__19))]
	public Task<EntityMassReferralInfo> GetReferralInfoAsync()
	{
		return _FF00_FF00_FF00븀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedeemReferralSelfAsync_003Ed__20))]
	public Task RedeemReferralSelfAsync(string productCode)
	{
		return (Task)_FF00_FF00_FF00騀(productCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedeemReferralPointsAsync_003Ed__21))]
	public Task<EntityMassReferralVoucher> RedeemReferralPointsAsync(string productCode)
	{
		return _FF00_FF00_FF00琀(productCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdateAsync_003Ed__22))]
	public Task UpdateAsync()
	{
		return (Task)_FF00_FF00_FF00焀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSolveCaptchaAsync_003Ed__23))]
	public Task<string> SolveCaptchaAsync(int version, byte[] captcha)
	{
		return _FF00_FF00_FF00踀((uint)version, captcha);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CJoinServerAsync_003Ed__24))]
	public Task<byte[]> JoinServerAsync(byte[] handshakeKey, string userId, string gameVersion, byte[] encryptToken, string gameId)
	{
		return _FF00_FF00_FF00缀(handshakeKey, userId, gameVersion, encryptToken, gameId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CJoinServerAsync_003Ed__25))]
	public Task<byte[]> JoinServerAsync(byte[] handshakeKey, string userId, string gameVersion, string gameId, string modHashList, string serverIdHash)
	{
		return _FF00_FF00_FF00鈀(handshakeKey, userId, gameVersion, gameId, modHashList, serverIdHash);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CComputeSignatureAsync_003Ed__26))]
	public Task<string> ComputeSignatureAsync(string message)
	{
		return _FF00_FF00_FF00뀀(message);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CConsumeIdentityAsync_003Ed__27))]
	public Task<EntityMassIdentity> ConsumeIdentityAsync()
	{
		return _FF00_FF00_FF00_AB00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetShopAsync_003Ed__28))]
	public Task<EntityMassShop> GetShopAsync()
	{
		return _FF00_FF00_FF00먀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetHistoryOrderAsync_003Ed__29))]
	public Task<List<EntityMassHistoryOrder>> GetHistoryOrderAsync()
	{
		return _FF00_FF00_FF00쀀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAdjustOrderAsync_003Ed__30))]
	public Task AdjustOrderAsync(int orderId)
	{
		return (Task)_FF00_FF00_FF00猀((uint)orderId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedeemCodeAsync_003Ed__31))]
	public Task RedeemCodeAsync(string code)
	{
		return (Task)_FF00_FF00_FF00묀(code);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedeemProductAsync_003Ed__32))]
	public Task RedeemProductAsync(string code)
	{
		return (Task)_FF00_FF00_FF00頀(code);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetHeypixelMachineContext_003Ed__33))]
	public Task GetHeypixelMachineContext()
	{
		return (Task)_FF00_FF00_FF00鴀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COrderAsync_003Ed__34))]
	public Task<EntityMassOrder> OrderAsync(string method, int quantity)
	{
		return _FF00_FF00_FF00蘀(method, (uint)quantity);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetNoticeAsync_003Ed__35))]
	public Task<string> GetNoticeAsync()
	{
		return _FF00_FF00_FF00謀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetIrcTokenAsync_003Ed__37))]
	public Task<string> GetIrcTokenAsync()
	{
		return _FF00_FF00_FF00茀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckLogin()
	{
		_FF00_FF00_FF00ꐀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPingAsync_003Ed__53))]
	private Task<bool> PingAsync(KeyValuePair<string, string> address)
	{
		return _FF00_FF00_FF00렀(address);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPingAsync_003Ed__54))]
	private Task<KeyValuePair<string, string>> PingAsync()
	{
		return _FF00_FF00_FF00蠀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitAsync_003Ed__55))]
	public Task InitAsync(string applicationName, string versionName)
	{
		return (Task)_FF00_FF00_FF00똀(applicationName, versionName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetManifest_003Ed__56))]
	public Task<EntityMassManifest> GetManifest()
	{
		return _FF00_FF00_FF00砀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetUpdaterManifest_003Ed__57))]
	public Task<EntityMassManifest> GetUpdaterManifest()
	{
		return _FF00_FF00_FF00脀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MassService()
	{
		//IL_0042: Expected I4, but got Obj
		//IL_0030->IL0039: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		MassService massService = this;
		if (0 == 0)
		{
			massService = (MassService)0;
		}
		switch ((int)massService)
		{
		case 0:
			break;
		}
	}

	static MassService()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0023: Expected I4, but got Obj
		//IL_007a->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0050->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0085->IL0012: Incompatible stack types: I4 vs Obj
		//IL_005b->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_FF00_A700());
				obj2 = 0;
				if (_003CModule_003E_007Bc547b36a_002Df832_002D4783_002Dbff4_002D35ff9bad7e58_007D.m_a6edc9c6177f4d1d9742e13736eb3634.m_5f0b6466dd9c48e78deddb01ca933754 == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				return;
			default:
				Instance__BackingField = new MassService();
				obj2 = 2;
				if (_003CModule_003E_007Bc547b36a_002Df832_002D4783_002Dbff4_002D35ff9bad7e58_007D.m_a6edc9c6177f4d1d9742e13736eb3634.m_6beed14500934829a0a0e38ea138e75d != 0)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectCommonTransmitter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MassService PushListener()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00瀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778474, new IntPtr(2737337468044L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00焀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1651, 1790778473, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778473, new IntPtr(2737337481564L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00爀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778472, new IntPtr(2737337483644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00猀(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0069: Expected Obj, but got Ref
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_007b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0094->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00a4->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0064->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0086->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0056->IL0019: Incompatible stack types: I4 vs Ref
		//IL_00af->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
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
				break;
			case 5u:
				_ = ref obj;
				_ = 3;
				break;
			case 4u:
				return (object)(&obj);
			default:
				_ = ref obj;
				_ = ref obj;
				if (1 == 0)
				{
					_ = 4;
				}
				break;
			case 1u:
				_ = ref obj;
				_ = 5;
				break;
			case 3u:
				_ = ref obj;
				_ = -1;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityMassReferralVoucher> _FF00_FF00_FF00琀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1654, 1790778479, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778479, new IntPtr(2737337480524L), 15);
		}
		return (Task<EntityMassReferralVoucher>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityMassReferralVoucher> _FF00_FF00_FF00甀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778478, new IntPtr(2737337486764L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityMassReferralVoucher>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00瘀(Func<EntityMassContent[], Task> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_008e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c5->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00aa->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0099->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0050->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0079->IL0019: Incompatible stack types: I4 vs Obj
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
			case 4:
				if (obj == obj)
				{
					if (true)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			case 5:
				obj2 = obj;
				obj = P_0;
				if (false)
				{
					obj2 = 0;
				}
				continue;
			default:
				obj = obj;
				if (4 == 0)
				{
					_ = 2;
				}
				continue;
			case 1:
				return;
			case 3:
				obj = this;
				if (2 == 0)
				{
					obj2 = 0;
				}
				continue;
			case 2:
				break;
			}
			obj = obj;
			if (5 == 0)
			{
				obj2 = 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityMassManifest> _FF00_FF00_FF00眀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778477, new IntPtr(2737337473244L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityMassManifest>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityMassManifest> _FF00_FF00_FF00砀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1658, 1790778476, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778476, new IntPtr(2737337488844L), 15);
		}
		return (Task<EntityMassManifest>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityMassManifest> _FF00_FF00_FF00礀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778515, new IntPtr(2737337474284L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityMassManifest>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00笀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778514, new IntPtr(2737337493004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00簀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1662, 1790778513, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778513, new IntPtr(2737337490924L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00紀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778512, new IntPtr(2737337486764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<byte[]> _FF00_FF00_FF00縀(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778519, new IntPtr(2737337499244L), 15))(null, 0, new IntPtr(0L));
		return (Task<byte[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<byte[]> _FF00_FF00_FF00缀(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005f: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1665, 1790778518, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 6, 1790778518, new IntPtr(2737337482604L), 15);
		}
		return (Task<byte[]>)((delegate*<object, object, object, object, object, object, object>)obj)(this, P_0, P_1, P_2, P_3, P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00耀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityMassManifest> _FF00_FF00_FF00脀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1667, 1790778517, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778517, new IntPtr(2737337484684L), 15);
		}
		return (Task<EntityMassManifest>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<string> _FF00_FF00_FF00舀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778516, new IntPtr(2737337473244L), 15))(null, 0, new IntPtr(0L));
		return (Task<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<string> _FF00_FF00_FF00茀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1669, 1790778523, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778523, new IntPtr(2737337477404L), 15);
		}
		return (Task<string>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00萀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778522, new IntPtr(2737337479484L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00蔀(object P_0)
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
	internal unsafe Task<EntityMassOrder> _FF00_FF00_FF00蘀(object P_0, uint P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_0056: Expected Obj, but got Ref
		//IL_004c: Expected Obj, but got I4
		//IL_0051->IL0015: Incompatible stack heights: 2 vs 0
		//IL_00ac->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0064->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0076->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0091->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0081->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009c->IL0019: Incompatible stack heights: 2 vs 1
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
				case 1:
					break;
				default:
					return (Task<EntityMassOrder>)(&obj);
				case 3:
					_ = ref obj;
					_ = 2;
					continue;
				case 4:
					_ = ref obj;
					_ = ref obj;
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 5:
					_ = ref obj;
					if (true)
					{
						_ = 3;
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
					_ = ref obj;
					_ = 5;
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
	private object _FF00_FF00_FF00蜀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<KeyValuePair<string, string>> _FF00_FF00_FF00蠀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1674, 1790778521, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778521, new IntPtr(2737337483644L), 15);
		}
		return (Task<KeyValuePair<string, string>>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<KeyValuePair<string, string>> _FF00_FF00_FF00褀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778520, new IntPtr(2737337485724L), 15))(null, 0, new IntPtr(0L));
		return (Task<KeyValuePair<string, string>>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00言(object P_0)
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
	internal unsafe Task<string> _FF00_FF00_FF00謀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1677, 1790778527, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778527, new IntPtr(2737337496124L), 15);
		}
		return (Task<string>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00谀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<string> _FF00_FF00_FF00贀(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778526, new IntPtr(2737337469084L), 15))(null, 0, new IntPtr(0L));
		return (Task<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<string> _FF00_FF00_FF00踀(uint P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_0044: Expected Obj, but got Ref
		//IL_0051: Expected Obj, but got I4
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_007f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0056->IL0015: Incompatible stack heights: 2 vs 0
		//IL_009f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00c5->IL0019: Incompatible stack types: I4 vs Ref
		//IL_00aa->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0071->IL0019: Incompatible stack heights: 2 vs 1
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
					return (Task<string>)(&obj);
				case 3u:
					break;
				case 5u:
					_ = ref obj;
					if (1 == 0)
					{
						_ = 3;
					}
					continue;
				case 1u:
					_ = ref obj;
					_ = 6;
					continue;
				case 6u:
					_ = ref obj;
					_ = 5;
					continue;
				case 4u:
					_ = ref obj;
					_ = ref obj;
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 2u:
					reference = ref obj;
					if (true)
					{
						reference = ref *(object*)null;
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
	internal unsafe object _FF00_FF00_FF00輀(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1681, 1790778525, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790778525, new IntPtr(2737337468044L), 15);
		}
		return ((delegate*<object, object, object, object>)obj)(this, P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00退(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778524, new IntPtr(2737337486764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<byte[]> _FF00_FF00_FF00鄀(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778499, new IntPtr(2737337485724L), 15))(null, 0, new IntPtr(0L));
		return (Task<byte[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<byte[]> _FF00_FF00_FF00鈀(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0061: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1684, 1790778498, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 7, 1790778498, new IntPtr(2737337499244L), 15);
		}
		return (Task<byte[]>)((delegate*<object, object, object, object, object, object, object, object>)obj)(this, P_0, P_1, P_2, P_3, P_4, P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<byte[]> _FF00_FF00_FF00錀(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778497, new IntPtr(2737337485724L), 15))(null, 0, new IntPtr(0L));
		return (Task<byte[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00鐀(object P_0, object P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778496, new IntPtr(2737337474284L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00销(object P_0, object P_1, object P_2)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005b: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1687, 1790778503, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 4, 1790778503, new IntPtr(2737337497164L), 15);
		}
		return ((delegate*<object, object, object, object, object>)obj)(this, P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityMassVersion> _FF00_FF00_FF00阀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1688, 1790778502, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778502, new IntPtr(2737337493004L), 15);
		}
		return (Task<EntityMassVersion>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityMassVersion> _FF00_FF00_FF00需()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778501, new IntPtr(2737337489884L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityMassVersion>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00頀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1690, 1790778500, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778500, new IntPtr(2737337474284L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00餀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778507, new IntPtr(2737337485724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00騀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1692, 1790778506, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778506, new IntPtr(2737337498204L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00鬀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778505, new IntPtr(2737337501324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00鰀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778504, new IntPtr(2737337501324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00鴀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1695, 1790778511, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778511, new IntPtr(2737337485724L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00鸀(Action<EntityMassUser> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778510, new IntPtr(2737337475324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00鼀(Action<EntityMassUser> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00c3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0069->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00aa->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0059->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0074->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0095->IL0019: Incompatible stack types: I4 vs Obj
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
			case 2:
				obj2 = obj;
				obj = P_0;
				if (3 != 0)
				{
					obj2 = 5;
				}
				continue;
			case 4:
				obj = this;
				if (3 != 0)
				{
					obj2 = 3;
				}
				continue;
			case 0:
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
			case 5:
				obj = obj;
				if (1 == 0)
				{
					_ = 1;
				}
				continue;
			case 3:
				break;
			}
			obj = obj;
			obj2 = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00ꀀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00ꄀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778509, new IntPtr(2737337501324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00ꌀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778508, new IntPtr(2737337501324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00ꐀ()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
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
				return;
			default:
				throw /*Error near IL_004c: Stack underflow*/;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00ꔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778547, new IntPtr(2737337475324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00ꘀ(Func<EntityMassContent[], Task> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_004e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00aa->IL0019: Incompatible stack heights: 0 vs 1
		//IL_005c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00b5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009a->IL0019: Incompatible stack types: I4 vs Obj
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
				obj = obj;
				_ = 3;
				continue;
			case 5:
				obj = this;
				obj2 = 4;
				continue;
			case 2:
				obj2 = obj;
				obj = P_0;
				if (0 == 0)
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
				break;
			case 4:
				break;
			case 1:
				return;
			}
			obj = obj;
			if (2 != 0)
			{
				obj2 = 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00ꠀ(Action<EntityMassUser> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_004f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_005f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0098->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0088->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b8->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c3->IL0019: Incompatible stack types: I4 vs Obj
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
				obj = obj;
				_ = 2;
				break;
			case 3:
				obj = obj;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				obj2 = obj;
				obj = P_0;
				if (true)
				{
					obj2 = 1;
				}
				break;
			case 4:
				obj = this;
				if (2 == 0)
				{
					obj2 = 3;
				}
				break;
			case 2:
				if (obj == obj)
				{
					if (5 == 0)
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
	internal unsafe void _FF00_FF00_FF00꤀(Action<EntityMassUser> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778546, new IntPtr(2737337501324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00ꨀ()
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
	internal unsafe Task<EntityMassIdentity> _FF00_FF00_FF00_AB00()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1709, 1790778545, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778545, new IntPtr(2737337473244L), 15);
		}
		return (Task<EntityMassIdentity>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00가(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778544, new IntPtr(2737337501324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00관(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1711, 1790778551, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778551, new IntPtr(2737337478444L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00글(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778550, new IntPtr(2737337476364L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<string> _FF00_FF00_FF00꼀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778549, new IntPtr(2737337486764L), 15))(null, 0, new IntPtr(0L));
		return (Task<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<string> _FF00_FF00_FF00뀀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1714, 1790778548, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778548, new IntPtr(2737337479484L), 15);
		}
		return (Task<string>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<string> _FF00_FF00_FF00넀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778555, new IntPtr(2737337486764L), 15))(null, 0, new IntPtr(0L));
		return (Task<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00눀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778554, new IntPtr(2737337469084L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00대()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00됀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778553, new IntPtr(2737337475324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00딀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778552, new IntPtr(2737337486764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00똀(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1720, 1790778559, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790778559, new IntPtr(2737337486764L), 15);
		}
		return ((delegate*<object, object, object, object>)obj)(this, P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<bool> _FF00_FF00_FF00뜀(KeyValuePair<string, string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778558, new IntPtr(2737337487804L), 15))(null, 0, new IntPtr(0L));
		return (Task<bool>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<bool> _FF00_FF00_FF00렀(KeyValuePair<string, string> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0074: Expected Obj, but got Ref
		//IL_0064->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0084->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0052->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008f->IL0019: Incompatible stack heights: 2 vs 1
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
				_ = ref obj;
				_ = -1;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			default:
				_ = ref obj;
				_ = ref obj;
				if (true)
				{
					_ = 1;
				}
				break;
			case 1:
				return (Task<bool>)(&obj);
			case 3:
				_ = ref obj;
				if (2 == 0)
				{
					_ = 2;
				}
				break;
			case 4:
				_ = ref obj;
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<bool> _FF00_FF00_FF00뤀(KeyValuePair<string, string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778557, new IntPtr(2737337487804L), 15))(null, 0, new IntPtr(0L));
		return (Task<bool>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityMassShop> _FF00_FF00_FF00먀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1724, 1790778556, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778556, new IntPtr(2737337489884L), 15);
		}
		return (Task<EntityMassShop>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00묀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1725, 1790778531, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778531, new IntPtr(2737337487804L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00밀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778530, new IntPtr(2737337475324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<List<EntityMassReferralProduct>> _FF00_FF00_FF00봀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1727, 1790778529, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778529, new IntPtr(2737337501324L), 15);
		}
		return (Task<List<EntityMassReferralProduct>>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityMassReferralInfo> _FF00_FF00_FF00븀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1728, 1790778528, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778528, new IntPtr(2737337491964L), 15);
		}
		return (Task<EntityMassReferralInfo>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityMassReferralInfo> _FF00_FF00_FF00뼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778535, new IntPtr(2737337469084L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityMassReferralInfo>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<List<EntityMassHistoryOrder>> _FF00_FF00_FF00쀀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1730, 1790778534, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778534, new IntPtr(2737337469084L), 15);
		}
		return (Task<List<EntityMassHistoryOrder>>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<List<EntityMassHistoryOrder>> _FF00_FF00_FF00섀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778533, new IntPtr(2737337471164L), 15))(null, 0, new IntPtr(0L));
		return (Task<List<EntityMassHistoryOrder>>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00숀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778532, new IntPtr(2737337502364L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00쌀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00쐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778539, new IntPtr(2737337475324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00씀(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1735, 1790778538, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790778538, new IntPtr(2737337502364L), 15);
		}
		return ((delegate*<object, object, object, object>)obj)(this, P_0, P_1);
	}
}
