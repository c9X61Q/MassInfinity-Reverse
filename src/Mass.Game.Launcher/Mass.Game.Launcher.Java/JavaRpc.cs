using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Mass.Application.Desktop;
using Mass.Common.Extensions;
using Mass.Domain.Desktop.Entities.Mods;
using Mass.Domain.Desktop.Entities.Skin;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Game.Launcher.Models;
using Serilog;

namespace Mass.Game.Launcher.Java;

public class JavaRpc : Rpc
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAuthenticationAsync_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaRpc _003C_003E4__this;

		public RpcCallBack callBack;

		private static object DirectProcessor;

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
		internal static bool NewContainer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckConverter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00甀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779071, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00瘀(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00眀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00砀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779070, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00礀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779069, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00稀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_0104: Expected Obj, but got Ref
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0110->IL0019: Incompatible stack heights: 0 vs 1
			//IL_012b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0051->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0070->IL0074: Incompatible stack types: I4 vs Ref
			//IL_011b->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0136->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			ref _003CAuthenticationAsync_003Ed__28 reference = ref *(_003CAuthenticationAsync_003Ed__28*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					reference = ref this;
					if (4 != 0)
					{
						reference = ref *(_003CAuthenticationAsync_003Ed__28*)1;
					}
					continue;
				case 4u:
					return;
				case 1u:
				{
					ref _003CAuthenticationAsync_003Ed__28 reference2 = ref this;
					if (0 == 0)
					{
						reference2 = ref *(_003CAuthenticationAsync_003Ed__28*)null;
					}
					switch ((uint)Unsafe.AsPointer(ref reference2))
					{
					}
					break;
				}
				case 2u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						reference = ref *(_003CAuthenticationAsync_003Ed__28*)1;
					}
					continue;
				case 3u:
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00笀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779068, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00簀()
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
	private struct _003CAuthenticationNewVersionAsync_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RpcCallBack callBack;

		public JavaRpc _003C_003E4__this;

		internal static object DecorateIsolatedDriver;

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
		internal static bool ReflectAutomatableWriter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EvaluateComparator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00氀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779067, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00洀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00渀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779066, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00漀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779065, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00瀀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00焀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_0096: Expected Obj, but got I4
			//IL_0057: Expected Obj, but got Ref
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0063->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0088->IL0019: Incompatible stack types: I4 vs Ref
			//IL_006e->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0052->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			ref _003CAuthenticationNewVersionAsync_003Ed__26 reference = ref *(_003CAuthenticationNewVersionAsync_003Ed__26*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 4u:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				case 3u:
					return;
				case 2u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						reference = ref *(_003CAuthenticationNewVersionAsync_003Ed__26*)1;
					}
					break;
				default:
					reference = ref this;
					if (3 == 0)
					{
						reference = ref *(_003CAuthenticationNewVersionAsync_003Ed__26*)3;
					}
					break;
				case 1u:
				{
					int num = 4;
					((object[])num)[0] = 1799;
					((object[])num)[1] = obj;
					((object[])num)[2] = obj;
					((object[])num)[3] = obj;
					if (false)
					{
						num = 0;
					}
					switch (num)
					{
					}
					goto case 4u;
				}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00爀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779064, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00猀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00琀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779063, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCheckPlayerMsgAsync_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RpcCallBack callBack;

		internal static object CheckIntegratedObject;

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
		internal static bool CheckLocalDecorator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectSymbolicArgument()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00攀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779062, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00昀(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00最()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00栀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779061, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00椀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002e: Expected I4, but got Obj
			//IL_0039: Expected Obj, but got Ref
			//IL_0070: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0123->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0149->IL0019: Incompatible stack types: I4 vs Ref
			//IL_012e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0050->IL0054: Incompatible stack heights: 1 vs 0
			//IL_008a->IL0054: Incompatible stack heights: 2 vs 0
			//IL_0095->IL0054: Incompatible stack heights: 2 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			ref _003CCheckPlayerMsgAsync_003Ed__24 reference = ref *(_003CCheckPlayerMsgAsync_003Ed__24*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 2u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						_ = 0;
					}
					while (true)
					{
						switch ((int)/*Error near IL_0061: Stack underflow*/)
						{
						default:
							((object[])3)[0] = 18;
							((object[])3)[1] = obj;
							((object[])3)[2] = obj;
							if (true)
							{
								_ = 0;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
					goto case 1u;
				case 1u:
					_ = -2;
					if (false)
					{
						_ = 0;
					}
					break;
				case 3u:
					return;
				default:
					reference = ref this;
					if (1 == 0)
					{
						reference = ref *(_003CCheckPlayerMsgAsync_003Ed__24*)3;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00樀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779060, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00欀()
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
	private struct _003CClientShieldCheckAsync_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RpcCallBack callBack;

		internal static object DecorateConfigurableSummarizer;

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
		internal static bool ReflectSeparatedProgram()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckMonoTemplate()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00崀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779059, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00帀(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00开()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00怀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779058, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00愀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002e: Expected I4, but got Obj
			//IL_0039: Expected Obj, but got Ref
			//IL_0070: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0130->IL0019: Incompatible stack heights: 2 vs 1
			//IL_013b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0050->IL0054: Incompatible stack heights: 1 vs 0
			//IL_0155->IL0019: Incompatible stack types: I4 vs Ref
			//IL_008a->IL0054: Incompatible stack heights: 2 vs 0
			//IL_0095->IL0054: Incompatible stack heights: 2 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			ref _003CClientShieldCheckAsync_003Ed__20 reference = ref *(_003CClientShieldCheckAsync_003Ed__20*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 1u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (true)
					{
						_ = 0;
					}
					while (true)
					{
						switch ((int)/*Error near IL_0061: Stack underflow*/)
						{
						case 1:
							((object[])3)[0] = 18;
							((object[])3)[1] = obj;
							((object[])3)[2] = obj;
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						}
						break;
					}
					goto default;
				default:
					_ = -2;
					if (3 == 0)
					{
						_ = 3;
					}
					break;
				case 3u:
					reference = ref this;
					if (2 == 0)
					{
						reference = ref *(_003CClientShieldCheckAsync_003Ed__20*)null;
					}
					break;
				case 2u:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00戀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779057, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00挀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00搀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779056, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CFilterSalogAsync_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RpcCallBack callBack;

		private static object ReflectOrderedAuditor;

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
		internal static bool CheckVisualDecider()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateScopeList()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00唀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779055, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00嘀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00圀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779054, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00堀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00夀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779053, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00娀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002e: Expected I4, but got Obj
			//IL_0077: Expected Obj, but got I4
			//IL_007b: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0043->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0068->IL0019: Incompatible stack types: I4 vs Ref
			//IL_004e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0093->IL0097: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			ref _003CFilterSalogAsync_003Ed__22 reference = ref *(_003CFilterSalogAsync_003Ed__22*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 2u:
					_ = -2;
					if (true)
					{
						_ = 1;
					}
					break;
				case 1u:
					reference = ref this;
					if (0 == 0)
					{
						reference = ref *(_003CFilterSalogAsync_003Ed__22*)null;
					}
					break;
				case 0u:
					return;
				case 3u:
				{
					ref _003CFilterSalogAsync_003Ed__22 reference2 = ref this;
					((object[])2)[0] = 530;
					((object[])2)[2] = 1;
					if (0 == 0)
					{
						reference2 = ref *(_003CFilterSalogAsync_003Ed__22*)null;
					}
					switch ((uint)Unsafe.AsPointer(ref reference2))
					{
					}
					goto case 2u;
				}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00嬀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00尀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779052, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGameChatOtherAsync_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private static object InvokeListener;

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
		internal static bool ResetTracker()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ObserveFinalizer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00䴀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779051, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00一(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00伀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00倀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779050, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00儀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779049, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00刀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002e: Expected I4, but got Obj
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_00e1->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00ec->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004e->IL0019: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			ref _003CGameChatOtherAsync_003Ed__21 reference = ref *(_003CGameChatOtherAsync_003Ed__21*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 0u:
					return;
				case 3u:
					reference = ref this;
					if (false)
					{
						reference = ref *(_003CGameChatOtherAsync_003Ed__21*)null;
					}
					break;
				case 1u:
				case 2u:
					_ = -2;
					if (3 == 0)
					{
						_ = 3;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00匀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779048, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00吀()
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
	private struct _003CHeartBeatAsync_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RpcCallBack callBack;

		private static object CheckConnectedPolicy;

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
		internal static bool DecorateAlphabeticRequester()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateEditableModule()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00䌀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779047, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00䐀(object P_0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00䔀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779046, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00䘀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00䜀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779045, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00䨀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002e: Expected I4, but got Obj
			//IL_0133: Expected Obj, but got I4
			//IL_0071: Expected Obj, but got I4
			//IL_0075: Expected Obj, but got I4
			//IL_0138->IL0015: Incompatible stack heights: 1 vs 0
			//IL_011c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0127->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004e->IL0052: Incompatible stack heights: 1 vs 0
			//IL_0082->IL0052: Incompatible stack heights: 1 vs 0
			//IL_008d->IL0052: Incompatible stack heights: 1 vs 0
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
					case 2:
						if (0 == 0)
						{
							_ = 0;
						}
						while (true)
						{
							switch ((int)/*Error near IL_005f: Stack underflow*/)
							{
							default:
								((object[])2)[0] = 512;
								((object[])2)[2] = 1;
								if (true)
								{
									_ = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
						break;
					case 3:
						return;
					case 1:
						break;
					default:
						goto end_IL_0019;
					}
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
					end_IL_0019:
					break;
				}
				obj = 3;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00䬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779044, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00䰀()
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
	private struct _003CLoginGameAsync_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		internal static object DecorateLogicalEvent;

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
		internal static bool DecodeRecommender()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectControllableProcessor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00㤀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779043, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00㨀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00㬀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779042, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㰀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㴀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779041, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00㼀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002e: Expected I4, but got Obj
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0043->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0069->IL0019: Incompatible stack types: I4 vs Ref
			//IL_004e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0084->IL0088: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			ref _003CLoginGameAsync_003Ed__33 reference = ref *(_003CLoginGameAsync_003Ed__33*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 2u:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				case 1u:
					return;
				default:
					reference = ref this;
					if (true)
					{
						reference = ref *(_003CLoginGameAsync_003Ed__33*)1;
					}
					break;
				case 3u:
					if (false)
					{
						_ = 0;
					}
					switch ((int)/*Error near IL_0091: Stack underflow*/)
					{
					}
					goto case 2u;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00䀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779040, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00䄀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00䈀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778975, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMsgFilterCheckAsync_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RpcCallBack callBack;

		internal static object ReflectTransferableContainer;

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
		internal static bool AssessNotifier()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HandleDispatcher()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_3100(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778974, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_3200(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_3300()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778973, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00㔀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002e: Expected I4, but got Obj
			//IL_0041: Expected Obj, but got I4
			//IL_0046: Expected Obj, but got I4
			//IL_004c: Expected Obj, but got I8
			//IL_0052: Expected Obj, but got I8
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0116->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0130->IL0019: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			ref _003CMsgFilterCheckAsync_003Ed__32 reference = ref *(_003CMsgFilterCheckAsync_003Ed__32*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 2u:
				{
					int num = 4;
					((object[])num)[0] = 1298;
					((object[])num)[1] = 0;
					((object[])num)[2] = 0;
					((object[])num)[3] = 0;
					if (0 == 0)
					{
						num = 0;
					}
					switch (num)
					{
					}
					goto case 1u;
				}
				case 0u:
					return;
				case 1u:
					_ = -2;
					_ = 3;
					break;
				case 3u:
					reference = ref this;
					if (false)
					{
						reference = ref *(_003CMsgFilterCheckAsync_003Ed__32*)null;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00㘀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778972, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00㜀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00㠀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778971, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPCycEntityCheckAsync_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private static object ReflectCombinedAnnotation;

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
		internal static bool PushParser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectSequentialBridge()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2900(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778970, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2A00(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2B00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778969, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ⰰ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ⴀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778968, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2E00()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002e: Expected I4, but got Obj
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0043->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00f5->IL0019: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			ref _003CPCycEntityCheckAsync_003Ed__25 reference = ref *(_003CPCycEntityCheckAsync_003Ed__25*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 1u:
				case 2u:
					_ = -2;
					if (3 == 0)
					{
						_ = 3;
					}
					break;
				case 0u:
					return;
				case 3u:
					reference = ref this;
					if (0 == 0)
					{
						reference = ref *(_003CPCycEntityCheckAsync_003Ed__25*)null;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2F00()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_3000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778967, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPlayerBaseInfoAsync_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private static object DecorateSetCommand;

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
		internal static bool AnalyzeStruct()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SetReporter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2100(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778966, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2200(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2300()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2400()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778965, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2500()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778964, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2600()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002e: Expected I4, but got Obj
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_00ce->IL0019: Incompatible stack heights: 3 vs 1
			//IL_00e8->IL0019: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			ref _003CPlayerBaseInfoAsync_003Ed__23 reference = ref *(_003CPlayerBaseInfoAsync_003Ed__23*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 0u:
					return;
				case 1u:
				case 2u:
					_ = -2;
					_ = 3;
					break;
				case 3u:
					reference = ref this;
					if (0 == 0)
					{
						reference = ref *(_003CPlayerBaseInfoAsync_003Ed__23*)null;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778963, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2800()
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
	private struct _003CPlayerSkinAsync_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RpcCallBack callBack;

		public JavaRpc _003C_003E4__this;

		private object _003Ccontent_003E5__2;

		private object _003Cskin_003E5__3;

		private TaskAwaiter<EntityUserSkin?> _003C_003Eu__1;

		private object _003CimageDir_003E5__4;

		private TaskAwaiter<EntityItemDownload> _003C_003Eu__2;

		private TaskAwaiter<string> _003C_003Eu__3;

		internal static object DecorateGlobalSorter;

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
		internal static bool ReflectDetachedConfig()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectDetailedEmitter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᘀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778962, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᜀ(object P_0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_1800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778961, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᤀ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᨀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778960, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ḁ()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_003e: Expected I4, but got Obj
			//IL_00c2: Expected I4, but got Obj
			//IL_063f: Expected Obj, but got Ref
			//IL_0070: Expected Obj, but got Ref
			//IL_0271: Expected Obj, but got Ref
			//IL_035c: Expected Obj, but got Ref
			//IL_01eb: Expected Obj, but got Ref
			//IL_0450: Expected Obj, but got Ref
			//IL_02b3: Expected Obj, but got I4
			//IL_02b9: Expected Obj, but got Ref
			//IL_02bd: Expected Obj, but got I4
			//IL_02c1: Expected Obj, but got I4
			//IL_02c6: Expected Obj, but got I4
			//IL_01bf: Expected Obj, but got I4
			//IL_04e0: Expected Obj, but got Ref
			//IL_01af: Expected Obj, but got I4
			//IL_03a8: Expected Obj, but got Ref
			//IL_03e7: Expected Obj, but got I4
			//IL_03ed: Expected Obj, but got Ref
			//IL_03f6: Expected Obj, but got I4
			//IL_03fd: Expected Obj, but got Ref
			//IL_02e3: Expected Obj, but got I4
			//IL_04c9: Expected Obj, but got I4
			//IL_04d3: Expected Obj, but got I4
			//IL_0472: Expected Obj, but got Ref
			//IL_0481: Expected Obj, but got I4
			//IL_04ef: Expected Obj, but got I4
			//IL_0510: Expected Obj, but got I4
			//IL_0514: Expected Obj, but got I4
			//IL_0518: Expected Obj, but got I4
			//IL_04ff: Expected Obj, but got Ref
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_00a3->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0061->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0052->IL0019: Incompatible stack heights: 3 vs 1
			//IL_064b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_007a->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0094->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00ae->IL0019: Incompatible stack heights: 2 vs 1
			//IL_006c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0366->IL00d0: Incompatible stack heights: 1 vs 0
			//IL_00cc->IL00d0: Incompatible stack heights: 1 vs 0
			//IL_0656->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0288->IL00d0: Incompatible stack heights: 1 vs 0
			//IL_0202->IL00d0: Incompatible stack heights: 1 vs 0
			//IL_058e->IL00d0: Incompatible stack heights: 2 vs 0
			//IL_0392->IL00d0: Incompatible stack heights: 2 vs 0
			//IL_0238->IL00d0: Incompatible stack heights: 2 vs 0
			//IL_01cc->IL00d0: Incompatible stack heights: 2 vs 0
			//IL_04ea->IL00d0: Incompatible stack heights: 1 vs 0
			//IL_021f->IL00d0: Incompatible stack heights: 3 vs 0
			//IL_01ba->IL00d0: Incompatible stack heights: 3 vs 0
			//IL_0262->IL00d0: Incompatible stack heights: 2 vs 0
			//IL_055a->IL00d0: Incompatible stack heights: 3 vs 0
			//IL_0408->IL00d0: Incompatible stack heights: 2 vs 0
			//IL_02f0->IL00d0: Incompatible stack heights: 2 vs 0
			//IL_04a9->IL00d0: Incompatible stack heights: 2 vs 0
			//IL_01e7->IL00d0: Incompatible stack heights: 4 vs 0
			//IL_0537->IL00d0: Incompatible stack heights: 1 vs 0
			//IL_047c->IL00d0: Incompatible stack heights: 2 vs 0
			//IL_048e->IL00d0: Incompatible stack heights: 2 vs 0
			//IL_0310->IL00d0: Incompatible stack heights: 3 vs 0
			//IL_0211->IL00d0: Incompatible stack heights: 3 vs 0
			//IL_04fa->IL00d0: Incompatible stack heights: 3 vs 0
			//IL_031d->IL00d0: Incompatible stack heights: 2 vs 0
			//IL_03cc->IL00d0: Incompatible stack heights: 3 vs 0
			//IL_0524->IL00d0: Incompatible stack heights: 1 vs 0
			//IL_03a2->IL00d0: Incompatible stack heights: 4 vs 0
			//IL_04c4->IL00d0: Incompatible stack heights: 4 vs 0
			//IL_03da->IL00d0: Incompatible stack heights: 3 vs 0
			//IL_0509->IL00d0: Incompatible stack heights: 1 vs 0
			//IL_0467->IL00d0: Incompatible stack heights: 1 vs 0
			//IL_0243->IL00d0: Incompatible stack heights: 2 vs 0
			//IL_02de->IL00d0: Incompatible stack heights: 1 vs 0
			//IL_01d7->IL00d0: Incompatible stack heights: 2 vs 0
			//IL_042d->IL00d0: Incompatible stack heights: 1 vs 0
			//IL_026d->IL00d0: Incompatible stack heights: 2 vs 0
			//IL_0565->IL00d0: Incompatible stack heights: 3 vs 0
			//IL_03bf->IL00d0: Incompatible stack heights: 1 vs 0
			//IL_02fb->IL00d0: Incompatible stack heights: 2 vs 0
			//IL_04b4->IL00d0: Incompatible stack heights: 2 vs 0
			//IL_00d0->IL00d0: Incompatible stack heights: 3 vs 0
			//IL_0542->IL00d0: Incompatible stack heights: 1 vs 0
			//IL_0499->IL00d0: Incompatible stack heights: 2 vs 0
			//IL_0358->IL00d0: Incompatible stack heights: 1 vs 0
			//IL_044b->IL00d0: Incompatible stack heights: 1 vs 0
			//IL_0385->IL00d0: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 7;
			ref _003CPlayerSkinAsync_003Ed__31 reference = ref *(_003CPlayerSkinAsync_003Ed__31*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 3u:
					return;
				case 4u:
					_ = -2;
					_ = 2;
					break;
				case 2u:
					_ = null;
					if (true)
					{
						_ = 0;
					}
					break;
				case 7u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CPlayerSkinAsync_003Ed__31*)6;
					break;
				default:
					reference = ref this;
					if (3 == 0)
					{
						reference = ref *(_003CPlayerSkinAsync_003Ed__31*)2;
					}
					break;
				case 1u:
					_ = null;
					if (false)
					{
						_ = 0;
					}
					break;
				case 5u:
					switch ((int)obj)
					{
					default:
						_ = 30;
						goto IL_00d0;
					case 2:
						obj = (object)Unsafe.AsPointer(ref this);
						if (4 != 0)
						{
							_ = 1;
						}
						goto IL_00d0;
					case 0:
						goto IL_026d;
					case 1:
						goto IL_0358;
						IL_00d0:
						while (true)
						{
							switch ((int)/*Error near IL_0189: Stack underflow*/)
							{
							case 18:
								return;
							case 36:
								return;
							case 39:
								return;
							case 33:
							case 42:
								break;
							case 13:
								obj = -1;
								_ = 44;
								continue;
							case 8:
								obj = 0;
								if (37 != 0)
								{
									_ = 43;
								}
								continue;
							case 24:
								_ = ref obj;
								_ = 36;
								continue;
							case 15:
								goto end_IL_00d0;
							case 30:
								_ = 20;
								continue;
							case 12:
								_ = 24;
								continue;
							case 6:
								_ = ref obj;
								obj = obj;
								if (9 == 0)
								{
									_ = 14;
								}
								continue;
							case 17:
								if (7 != 0)
								{
									_ = 9;
								}
								continue;
							case 1:
								goto IL_026d;
							case 7:
								((object[])5)[0] = 520;
								((object[])5)[1] = (object)Unsafe.AsPointer(ref this);
								((object[])5)[5] = 2;
								((object[])(ref this))[ref Unsafe.As<_003CPlayerSkinAsync_003Ed__31, byte>(ref this)] = 3;
								((object[])/*Error near IL_02c1: Stack underflow*/)[4] = 0;
								if (33 != 0)
								{
									_ = 16;
								}
								continue;
							case 22:
								obj = -1;
								if (2 != 0)
								{
									_ = 2;
								}
								continue;
							case 29:
								obj = obj;
								_ = 16;
								continue;
							case 34:
								_ = 28;
								continue;
							case 5:
								if (&obj != null)
								{
									if (3 == 0)
									{
										_ = 2;
									}
									continue;
								}
								goto case 31;
							case 10:
								goto IL_0358;
							case 14:
								if (&obj != null)
								{
									if (2 != 0)
									{
										_ = 38;
									}
									continue;
								}
								goto case 8;
							case 4:
								_ = 22;
								continue;
							case 40:
								_ = ref obj;
								_ = 39;
								continue;
							case 20:
								obj = (object)Unsafe.AsPointer(ref this);
								if (4 != 0)
								{
									_ = 6;
								}
								continue;
							case 35:
								_ = null;
								_ = 42;
								continue;
							case 43:
								_ = 40;
								continue;
							case 21:
								((object[])5)[0] = 520;
								((object[])5)[1] = (object)Unsafe.AsPointer(ref this);
								((object[])5)[2] = obj;
								((object[])5)[5] = 3;
								((object[])(ref this))[4] = (object)Unsafe.AsPointer(ref this);
								_ = 19;
								continue;
							case 16:
								if (&obj != null)
								{
									_ = 32;
									continue;
								}
								goto case 25;
							case 9:
								if (Unsafe.AsPointer(ref this) == null)
								{
									if (0 == 0)
									{
										_ = 7;
									}
									continue;
								}
								goto case 27;
							case 2:
							case 32:
								obj = (object)(&obj);
								if (26 == 0)
								{
									_ = 13;
								}
								continue;
							case 27:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 5;
								continue;
							case 28:
								obj = -1;
								if (true)
								{
									_ = 11;
								}
								continue;
							case 23:
								if (21 != 0)
								{
									_ = 41;
								}
								continue;
							case 41:
								_ = ref obj;
								_ = 18;
								continue;
							case 25:
								obj = 2;
								obj = 23;
								continue;
							case 3:
							case 11:
								obj = (object)(&obj);
								_ = 37;
								continue;
							case 31:
								obj = 1;
								_ = 12;
								continue;
							case 38:
							case 44:
								obj = (object)(&obj);
								_ = 17;
								continue;
							case 37:
							{
								((object[])3)[3] = 0;
								((object[])(ref this))[ref Unsafe.As<_003CPlayerSkinAsync_003Ed__31, byte>(ref this)] = 1;
								_003F val = /*Error near IL_0514: Stack underflow*/;
								((object[])/*Error near IL_0518: Stack underflow*/)[val] = 2;
								_ = 29;
								continue;
							}
							case 26:
								obj = obj;
								if (21 != 0)
								{
									_ = 19;
								}
								continue;
							case 19:
								if (26 == 0)
								{
									_ = 35;
								}
								continue;
							default:
								_ = 13;
								continue;
							}
							goto end_IL_00b1;
							continue;
							end_IL_00d0:
							break;
						}
						goto case 2;
						IL_0358:
						obj = (object)Unsafe.AsPointer(ref this);
						_ = 34;
						goto IL_00d0;
						IL_026d:
						obj = (object)Unsafe.AsPointer(ref this);
						if (false)
						{
							_ = 0;
						}
						goto IL_00d0;
						end_IL_00b1:
						break;
					}
					goto case 4u;
				case 6u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (4 != 0)
					{
						reference = ref *(_003CPlayerSkinAsync_003Ed__31*)5;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ἀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778959, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2000()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}
	}

	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	internal static JavaRpc ReflectScalableAllocator;

	private static ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	private DesktopSession Session
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DesktopSession)_FF00_FF00_FF00_FF00开();
		}
	}

	private string ServerAddress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00儀();
		}
	}

	private int ServerPort
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00䰀();
		}
	}

	private string CharacterName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00圀();
		}
	}

	private EnumGameType Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00䈀();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JavaRpc(DesktopSession session, EnumGameType type, EnumGameVersion version, string serverAddress, int serverPort, string characterName)
	{
		//IL_00b0->IL001e: Incompatible stack heights: 5 vs 3
		//IL_0097->IL001e: Incompatible stack heights: 4 vs 3
		//IL_0061->IL001e: Incompatible stack heights: 4 vs 3
		//IL_0079->IL001e: Incompatible stack heights: 5 vs 3
		//IL_0086->IL001e: Incompatible stack heights: 5 vs 3
		//IL_0052->IL001e: Incompatible stack heights: 5 vs 3
		//IL_00a2->IL001e: Incompatible stack heights: 4 vs 3
		//IL_006c->IL001e: Incompatible stack heights: 4 vs 3
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = 0;
		while (true)
		{
			switch (2)
			{
			case 6:
				_ = 5;
				break;
			case 2:
				if (0 == 0)
				{
					_ = 1;
				}
				break;
			case 4:
				_ = 3;
				break;
			case 5:
				_ = 4;
				break;
			case 3:
				return;
			case 1:
				if (false)
				{
					_ = 0;
				}
				break;
			default:
				_ = 6;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void RegisterCallBack(EnumGameVersion version)
	{
		_FF00_FF00_FF00_FF00堀(version);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CClientShieldCheckAsync_003Ed__20))]
	public Task ClientShieldCheckAsync(RpcCallBack callBack)
	{
		return (Task)_FF00_FF00_FF00_FF00㴀(callBack);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGameChatOtherAsync_003Ed__21))]
	public Task GameChatOtherAsync(RpcCallBack callBack)
	{
		return (Task)_FF00_FF00_FF00_FF00崀(callBack);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CFilterSalogAsync_003Ed__22))]
	public Task FilterSalogAsync(RpcCallBack callBack)
	{
		return (Task)_FF00_FF00_FF00_FF00愀(callBack);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPlayerBaseInfoAsync_003Ed__23))]
	public Task PlayerBaseInfoAsync(RpcCallBack callBack)
	{
		return (Task)_FF00_FF00_FF00_FF00匀(callBack);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCheckPlayerMsgAsync_003Ed__24))]
	public Task CheckPlayerMsgAsync(RpcCallBack callBack)
	{
		return (Task)_FF00_FF00_FF00_FF00嬀(callBack);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPCycEntityCheckAsync_003Ed__25))]
	public Task PCycEntityCheckAsync(RpcCallBack callBack)
	{
		return (Task)_FF00_FF00_FF00_FF00㬀(callBack);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAuthenticationNewVersionAsync_003Ed__26))]
	public virtual Task AuthenticationNewVersionAsync(RpcCallBack callBack)
	{
		return (Task)_FF00_FF00_FF00_FF00㼀(callBack);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CHeartBeatAsync_003Ed__27))]
	public Task HeartBeatAsync(RpcCallBack callBack)
	{
		return (Task)_FF00_FF00_FF00_FF00昀(callBack);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAuthenticationAsync_003Ed__28))]
	public Task AuthenticationAsync(RpcCallBack callBack)
	{
		return (Task)_FF00_FF00_FF00_FF00䤀(callBack);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendReconnect()
	{
		_FF00_FF00_FF00_FF00䠀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SendReconnect(object writer)
	{
		_FF00_FF00_FF00_FF00挀(writer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPlayerSkinAsync_003Ed__31))]
	public Task PlayerSkinAsync(RpcCallBack callBack)
	{
		return (Task)_FF00_FF00_FF00_FF00䐀(callBack);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CMsgFilterCheckAsync_003Ed__32))]
	public Task MsgFilterCheckAsync(RpcCallBack callBack)
	{
		return (Task)_FF00_FF00_FF00_FF00䴀(callBack);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoginGameAsync_003Ed__33))]
	public Task LoginGameAsync(RpcCallBack callBack)
	{
		return (Task)_FF00_FF00_FF00_FF00伀(callBack);
	}

	static JavaRpc()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_001f: Expected I4, but got Obj
		//IL_004c->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0057->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_FF00_FF00一());
				obj2 = 0;
				if (_003CModule_003E_007B8336717d_002D71de_002D47ce_002Dbc69_002D4d75223ebc5e_007D.m_d836f3f9b6194f49a23d85cb66f28ddf.m_6df226b27371400690be0eaea4a03213 == 0)
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
	internal static bool CheckModularInitializer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static JavaRpc ReflectGroupedPublisher()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00㠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779106, new IntPtr(2737337576204L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00_FF00_FF00㤀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00㨀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779105, new IntPtr(2737337576204L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00㬀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4874, 1790779104, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779104, new IntPtr(2737337592844L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00㰀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779039, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00㴀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4876, 1790779038, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779038, new IntPtr(2737337580364L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00㸀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779037, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00㼀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4878, 1790779036, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779036, new IntPtr(2737337597004L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00䀀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779035, new IntPtr(2737337576204L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe EnumGameType _FF00_FF00_FF00_FF00䄀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779034, new IntPtr(2737337576204L), 15))(null, 0, new IntPtr(0L));
		return (EnumGameType)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private EnumGameType _FF00_FF00_FF00_FF00䈀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (EnumGameType)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00䌀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779033, new IntPtr(2737337576204L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00䐀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4883, 1790779032, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779032, new IntPtr(2737337594924L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00䔀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779031, new IntPtr(2737337576204L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00䘀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779030, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00䠀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_007d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0063->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006e->IL0019: Incompatible stack types: I4 vs Obj
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
				return;
			case 1:
				if (this != null)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				return;
			case 2:
				return;
			default:
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00䤀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4888, 1790779029, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779029, new IntPtr(2737337583484L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00䨀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779028, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe uint _FF00_FF00_FF00_FF00䬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779027, new IntPtr(2737337584524L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private uint _FF00_FF00_FF00_FF00䰀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00䴀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4892, 1790779026, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779026, new IntPtr(2737337584524L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00伀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4894, 1790779025, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779025, new IntPtr(2737337591804L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00倀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779024, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00_FF00儀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00刀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779023, new IntPtr(2737337576204L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00匀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4898, 1790779022, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779022, new IntPtr(2737337579324L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00吀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779021, new IntPtr(2737337576204L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00唀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00嘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779020, new IntPtr(2737337576204L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00_FF00圀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _FF00_FF00_FF00_FF00堀(EnumGameVersion P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0056: Expected I4, but got Obj
		//IL_0194: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I4
		//IL_0179->IL0019: Incompatible stack heights: 3 vs 1
		//IL_006f->IL0019: Incompatible stack heights: 4 vs 1
		//IL_014d->IL0019: Incompatible stack heights: 4 vs 1
		//IL_00cf->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0199->IL0015: Incompatible stack heights: 3 vs 0
		//IL_00ee->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0162->IL0019: Incompatible stack heights: 5 vs 1
		//IL_0085->IL0019: Incompatible stack heights: 3 vs 1
		//IL_013c->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0104->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00a4->IL0019: Incompatible stack heights: 4 vs 1
		//IL_00bc->IL0015: Incompatible stack heights: 3 vs 0
		//IL_0184->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00da->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0090->IL0019: Incompatible stack heights: 3 vs 1
		//IL_010f->IL0019: Incompatible stack heights: 3 vs 1
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
					_ = 517;
					_ = 13;
					continue;
				case 7:
					_ = 274;
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 12:
					_ = 1298;
					_ = 10;
					continue;
				case 13:
					_ = 520;
					obj = 8;
					break;
				case 3:
					_ = 18;
					if (0 == 0)
					{
						_ = 2;
					}
					continue;
				case 5:
					_ = 1031;
					_ = 12;
					continue;
				case 10:
					_ = 4612;
					if (9 != 0)
					{
						_ = 11;
					}
					continue;
				case 9:
					if (P_0 > EnumGameVersion.V_1_18)
					{
						obj = 6;
						break;
					}
					goto case 7;
				case 8:
					_ = 530;
					_ = 5;
					continue;
				case 2:
					_ = 19;
					_ = 4;
					continue;
				case 6:
					_ = 261;
					_ = 7;
					continue;
				case 11:
					return;
				default:
					_ = 512;
					if (true)
					{
						_ = 0;
					}
					continue;
				case 4:
					_ = 81;
					obj = 9;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe void _FF00_FF00_FF00_FF00夀(EnumGameVersion P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779019, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00娀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779018, new IntPtr(2737337576204L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00嬀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4906, 1790779017, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779017, new IntPtr(2737337576204L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00尀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779016, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00崀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4908, 1790779015, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779015, new IntPtr(2737337577244L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00帀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779014, new IntPtr(2737337578284L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00_FF00开()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00怀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779013, new IntPtr(2737337578284L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00愀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4912, 1790779012, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779012, new IntPtr(2737337587644L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00戀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779011, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00挀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0038: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I4
		//IL_005f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_006a->IL0019: Incompatible stack heights: 3 vs 1
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
				((object[])5)[0] = 1031;
				((object[])5)[1] = this;
				((object[])5)[2] = this;
				((object[])5)[3] = this;
				((object[])5)[4] = (nint)this == 9;
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
	private unsafe void _FF00_FF00_FF00_FF00搀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779010, new IntPtr(2737337578284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00攀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779009, new IntPtr(2737337578284L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00昀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4917, 1790779008, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779008, new IntPtr(2737337578284L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}
}
