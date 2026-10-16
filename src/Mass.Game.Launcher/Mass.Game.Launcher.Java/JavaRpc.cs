using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Mass.Application.Desktop;
using Mass.Application.Models;
using Mass.Common.Extensions;
using Mass.Common.Helpers;
using Mass.Domain.Desktop.Entities.Mods;
using Mass.Domain.Desktop.Entities.Skin;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Game.Launcher.Entities.Fever;
using Mass.Game.Launcher.Models;
using Mass.Game.Launcher.Paths;
using Mass.Game.Launcher.Values;
using RestSharp;
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00瘀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((Func<Task>)/*Error near IL_0044: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00眀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Expected I4, but got Obj
			//IL_0059: Expected native int or pointer, but got Obj
			//IL_008c: Expected native int or pointer, but got Obj
			//IL_015d: Expected Obj, but got VT
			//IL_0167: Expected native int or pointer, but got Obj
			//IL_0184: Expected Obj, but got I4
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0171->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0198->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_017c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01a3->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					((Func<Task>)/*Error near IL_004f: Stack underflow*/)._002Ector((object)/*Error near IL_004f: Stack underflow*/, (nint)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state));
					obj2 = 4;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						obj2 = 1;
					}
					continue;
				case 4:
					return;
				case 1:
				{
					((Authenticator)/*Error near IL_0082: Stack underflow*/).ReceiveAuthenticationDataAsync(((Authenticator)obj).ReceiveAsync(Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton));
					int num = 0;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
					{
						num = 0;
					}
					switch (num)
					{
					}
					break;
				}
				case 2:
					obj = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003Et__builder;
					obj2 = 0;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.client)->_003C_003E4__this == null)
					{
						obj2 = 1;
					}
					continue;
				case 3:
					break;
				}
				((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003Cstream_003E5__2 = -2;
				obj2 = 0;
				if (Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway == null)
				{
					obj2 = 0;
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00簀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00洀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((Func<Task>)/*Error near IL_0044: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00瀀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00焀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Expected I4, but got Obj
			//IL_009e: Expected Obj, but got Ref
			//IL_00a8: Expected native int or pointer, but got Obj
			//IL_00d6: Expected VT, but got I4
			//IL_00e1: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got VT
			//IL_007e: Expected native int or pointer, but got Obj
			//IL_00b2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0088->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0060->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00bd->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0093->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 4:
					((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state = -2;
					obj2 = 0;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 0;
					}
					break;
				case 3:
					return;
				case 2:
					obj = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1;
					obj2 = 1;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
					{
						obj2 = 1;
					}
					break;
				default:
					GC.SuppressFinalize((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Et__builder));
					obj2 = 3;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj2 = 3;
					}
					break;
				case 1:
				{
					_ = Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler;
					nint[] array = new nint[4]
					{
						(nint)(object)(AsyncTaskMethodBuilder)1799,
						default,
						default,
						default
					};
					((object[])1)[obj] = Authenticator._003CListenAsync_003Ed__7.DecorateExpandableParser();
					((object[])2)[obj] = Authenticator._003CListenAsync_003Ed__7.ObserveTracker();
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)3)->SetStateMachine((IAsyncStateMachine)obj);
					((object[])(object)array)[(object)array] = array;
					Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateGenericStruct();
					int num = 0;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Et__builder).client != null)
					{
						num = 0;
					}
					switch (num)
					{
					}
					goto case 4;
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00猀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00昀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((Func<Task>)/*Error near IL_0044: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00最()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_003b: Expected I4, but got Obj
			//IL_01a6: Expected Obj, but got Ref
			//IL_01ab: Expected Obj, but got Ref
			//IL_0180: Expected VT, but got I4
			//IL_0058: Expected native int or pointer, but got Obj
			//IL_00a7: Expected Obj, but got I4
			//IL_00b2: Expected Obj, but got I4
			//IL_01bf->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0194->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01ca->IL0026: Incompatible stack heights: 2 vs 1
			//IL_019f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00cb->IL0071: Incompatible stack heights: 4 vs 1
			//IL_00d6->IL0071: Incompatible stack heights: 4 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 2:
				{
					((AsyncTaskMethodBuilder*)/*Error near IL_004c: Stack underflow*/)->Start(ref *(Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state);
					obj = (object)/*Error near IL_004e: Stack underflow*/;
					int num = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						num = 0;
					}
					while (true)
					{
						switch (num)
						{
						default:
						{
							_ = Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton;
							TcpListener[] array = new TcpListener[3]
							{
								(TcpListener)(object)18,
								null,
								null
							};
							((Authenticator)obj).Dispose();
							array[(object)array] = (TcpListener)1;
							((object[])2)[obj] = Authenticator.ReflectMonoObject();
							Authenticator.PatchUser();
							_ = 1;
							if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder != 0)
							{
								_ = 0;
							}
							continue;
						}
						case 1:
							break;
						}
						break;
					}
					goto case 1;
				}
				case 1:
					((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003Eu__1 = (TaskAwaiter<string>)(-2);
					obj2 = 0;
					if (((FeverInstaller)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway)._003CfeverVersion_003EP != null)
					{
						obj2 = 0;
					}
					break;
				case 3:
					return;
				default:
					((TcpClient)Unsafe.AsPointer(ref ((FeverInstaller)Unsafe.AsPointer(ref this))._003CappId_003EP)).GetStream();
					_ = 1;
					if (((FeverInstaller)FeverInstaller.McBedrock__BackingField).Client__BackingField == null)
					{
						_ = 3;
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00欀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00帀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0045: Expected I, but got Obj
			//IL_0045: Expected Obj, but got Ref
			//IL_004f: Expected native int or pointer, but got Obj
			//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((Func<Task>)/*Error near IL_0045: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00开()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_003b: Expected I4, but got Obj
			//IL_0195: Expected Obj, but got I4
			//IL_0195: Expected Obj, but got Ref
			//IL_0058: Expected native int or pointer, but got Obj
			//IL_01ba: Expected Obj, but got Ref
			//IL_01bf: Expected Obj, but got Ref
			//IL_01c9: Expected native int or pointer, but got Obj
			//IL_00a7: Expected Obj, but got I4
			//IL_00b2: Expected Obj, but got I4
			//IL_01a9->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01d3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01b4->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01de->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00cb->IL0071: Incompatible stack heights: 4 vs 1
			//IL_00d6->IL0071: Incompatible stack heights: 4 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 1:
				{
					((AsyncTaskMethodBuilder*)/*Error near IL_004c: Stack underflow*/)->Start(ref *(Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state);
					obj = (object)/*Error near IL_004e: Stack underflow*/;
					int num = 1;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						num = 0;
					}
					while (true)
					{
						switch (num)
						{
						case 1:
						{
							_ = Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton;
							TcpListener[] array = new TcpListener[3]
							{
								(TcpListener)(object)18,
								null,
								null
							};
							((Authenticator)obj).Dispose();
							array[(object)array] = (TcpListener)1;
							((object[])2)[obj] = Authenticator.ReflectMonoObject();
							Authenticator.PatchUser();
							_ = 0;
							if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								_ = 0;
							}
							continue;
						}
						}
						break;
					}
					goto default;
				}
				default:
					((FeverInstaller)Unsafe.AsPointer(ref this))._003CfeverVersion_003EP = -2;
					obj2 = 3;
					if (((FeverInstaller)FeverInstaller._003CappId_003EP)._003CappVersion_003EP == null)
					{
						obj2 = 3;
					}
					break;
				case 3:
					((TcpClient)Unsafe.AsPointer(ref FeverInstaller.McBedrock__BackingField)).Close();
					obj2 = 2;
					if (((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller.ReflectVisualArgument)->_003C_003E1__state == 0)
					{
						obj2 = 0;
					}
					break;
				case 2:
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00挀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00嘀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((Func<Task>)/*Error near IL_0044: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00圀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779054, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00堀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_003b: Expected I4, but got Obj
			//IL_00ab: Expected Obj, but got I4
			//IL_0086->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0091->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				case 2:
					((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state = -2;
					obj2 = 1;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
					{
						obj2 = 1;
					}
					break;
				case 1:
					((AsyncTaskMethodBuilder*)/*Error near IL_0072: Stack underflow*/)->Start<TStateMachine>(ref Unsafe.As<TaskAwaiter, TStateMachine>(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1));
					obj2 = 0;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj2 = 0;
					}
					break;
				case 0:
					return;
				case 3:
				{
					_ = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this).listener;
					((Authenticator._003CListenAsync_003Ed__7*)new string[2]
					{
						(string)530,
						(string)(object)Authenticator.PatchUser()
					})->MoveNext();
					int num = 0;
					if (((Authenticator._003CReceiveAsync_003Ed__9)Authenticator._003CReceiveAsync_003Ed__9._003C_003Et__builder)._003C_003E4__this == null)
					{
						num = 0;
					}
					switch (num)
					{
					}
					goto case 2;
				}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00嬀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00一(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0045: Expected I, but got Obj
			//IL_0045: Expected Obj, but got Ref
			//IL_004f: Expected native int or pointer, but got Obj
			//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((Func<Task>)/*Error near IL_0045: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00伀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_003b: Expected I4, but got Obj
			//IL_011a: Expected Obj, but got I4
			//IL_0124: Expected native int or pointer, but got Obj
			//IL_0056: Expected native int or pointer, but got Obj
			//IL_012e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0060->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0139->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				case 3:
					((Func<Task>)/*Error near IL_004c: Stack underflow*/)._002Ector((object)/*Error near IL_004c: Stack underflow*/, (nint)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state));
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						obj2 = 0;
					}
					break;
				case 1:
				case 2:
					((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003E4__this = (Authenticator)(-2);
					obj2 = 3;
					if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9.client)->_003C_003Eu__1 == 0)
					{
						obj2 = 3;
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00吀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00䐀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((Func<Task>)/*Error near IL_0044: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00䔀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779046, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00䘀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00䜀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779045, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00䨀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_003b: Expected I4, but got Obj
			//IL_019a: Expected Obj, but got Ref
			//IL_01a8: Expected Obj, but got I4
			//IL_0175: Expected Obj, but got I4
			//IL_009d: Expected Obj, but got I4
			//IL_00a5: Expected Obj, but got I4
			//IL_00b5: Expected native int or pointer, but got Obj
			//IL_01ad->IL0022: Incompatible stack heights: 1 vs 0
			//IL_0189->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0194->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00bf->IL0073: Incompatible stack heights: 3 vs 2
			//IL_00ca->IL0073: Incompatible stack heights: 3 vs 2
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					{
						((Authenticator)/*Error near IL_004b: Stack underflow*/).Listener = ((Authenticator)/*Error near IL_0046: Stack underflow*/).Listener;
						Task.Run((Func<Task?>)/*Error near IL_0050: Stack underflow*/);
						int num = 0;
						if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
						{
							num = 0;
						}
						while (true)
						{
							switch (num)
							{
							default:
							{
								int num2 = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003E1__state;
								int[] array = new int[2]
								{
									(int)(object)512,
									0
								};
								((object[])num2)[(object)array] = ((Authenticator)(object)array).HandleAuthentication((string)1);
								Authenticator.ReflectMonoObject();
								_ = 1;
								if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state != 0)
								{
									_ = 1;
								}
								continue;
							}
							case 1:
								break;
							}
							break;
						}
						break;
					}
					case 3:
						return;
					case 1:
						break;
					default:
						goto end_IL_0026;
					}
					((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003Cstream_003E5__2 = -2;
					obj2 = 0;
					if (Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway == null)
					{
						obj2 = 0;
					}
					continue;
					end_IL_0026:
					break;
				}
				((Encoding)/*Error near IL_019f: Stack underflow*/).GetString((byte[])/*Error near IL_019f: Stack underflow*/, (int)/*Error near IL_019f: Stack underflow*/, (int)Unsafe.AsPointer(ref ((FeverInstaller)Unsafe.AsPointer(ref this))._003CfeverVersion_003EP));
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00䰀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00㨀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0045: Expected I, but got Obj
			//IL_0045: Expected Obj, but got Ref
			//IL_004f: Expected native int or pointer, but got Obj
			//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((Func<Task>)/*Error near IL_0045: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj2 = 0;
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㰀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_003b: Expected I4, but got Obj
			//IL_00ac: Expected native int or pointer, but got Obj
			//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0092->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 2:
					((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state = -2;
					obj2 = 0;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 0;
					}
					break;
				case 1:
					return;
				default:
					((AsyncTaskMethodBuilder*)/*Error near IL_0073: Stack underflow*/)->Start<TStateMachine>(ref Unsafe.As<TaskAwaiter, TStateMachine>(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1));
					obj2 = 1;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						obj2 = 1;
					}
					break;
				case 3:
				{
					((Authenticator)/*Error near IL_0098: Stack underflow*/).Dispose();
					((IAsyncStateMachine)((Authenticator)/*Error near IL_009d: Stack underflow*/).HandleAuthentication((string)/*Error near IL_009d: Stack underflow*/)).MoveNext();
					int num = 0;
					if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state != 0)
					{
						num = 0;
					}
					switch (num)
					{
					}
					goto case 2;
				}
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00䄀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_3200(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0045: Expected I, but got Obj
			//IL_0045: Expected Obj, but got Ref
			//IL_004f: Expected native int or pointer, but got Obj
			//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((Func<Task>)/*Error near IL_0045: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_3300()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_003b: Expected I4, but got Obj
			//IL_016d: Expected Obj, but got I4
			//IL_0059: Expected Obj, but got I4
			//IL_0062: Expected Void, but got I4
			//IL_0076: Expected Obj, but got I8
			//IL_007c: Expected Obj, but got I4
			//IL_0086: Expected native int or pointer, but got Obj
			//IL_0177->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0196->IL0026: Incompatible stack heights: 2 vs 1
			//IL_01a1->IL0026: Incompatible stack heights: 2 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				{
					((Authenticator)((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state).ReceiveAuthenticationDataAsync((object)new MulticastDelegate[4]
					{
						(MulticastDelegate)1298,
						(MulticastDelegate)(object)0,
						(MulticastDelegate)(object)(ILogger)0,
						(MulticastDelegate)0
					});
					int num = 0;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
					{
						num = 0;
					}
					switch (num)
					{
					}
					goto case 1;
				}
				case 0:
					return;
				case 1:
					((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003E4__this = (Authenticator)(-2);
					obj2 = 3;
					break;
				case 3:
					Unsafe.As<object, TaskAwaiter<TcpClient>>(ref ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003Cstream_003E5__2).GetResult();
					_ = 0;
					if (((FeverInstaller)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway)._003CfeverVersion_003EP != null)
					{
						_ = 0;
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00㜀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2A00(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((Func<Task>)/*Error near IL_0044: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2B00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778969, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ⰰ()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_003b: Expected I4, but got Obj
			//IL_012b: Expected Obj, but got Ref
			//IL_0135: Expected native int or pointer, but got Obj
			//IL_005c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_013f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
			//IL_014a->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				case 2:
					((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state = -2;
					obj2 = 3;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 3;
					}
					break;
				case 0:
					return;
				case 3:
					((AsyncTaskMethodBuilder*)/*Error near IL_012b: Stack underflow*/)->SetException((Exception)Unsafe.AsPointer(ref ((Authenticator._003CReceiveAsync_003Ed__9)this).client));
					obj2 = 0;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain)->_003C_003E1__state == 0)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2F00()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2200(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((Func<Task>)/*Error near IL_0044: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2300()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_003b: Expected I4, but got Obj
			//IL_0120: Expected native int or pointer, but got Obj
			//IL_010b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_012a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0135->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				case 2:
					((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003E1__state = -2;
					obj2 = 3;
					break;
				case 3:
					Unsafe.As<AsyncTaskMethodBuilder, TaskAwaiter>(ref ((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003Et__builder).GetResult();
					obj2 = 0;
					if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9.client)->_003C_003Eu__1 == 0)
					{
						obj2 = 0;
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2800()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᜀ(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((Func<Task>)/*Error near IL_0044: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_1800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778961, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᤀ()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_004b: Expected I4, but got Obj
			//IL_00b0: Expected native int or pointer, but got Obj
			//IL_00cc: Expected VT, but got Obj
			//IL_00d6: Expected native int or pointer, but got Obj
			//IL_006a: Expected VT, but got Obj
			//IL_0074: Expected native int or pointer, but got Obj
			//IL_00ff: Expected I4, but got Obj
			//IL_08b5: Expected Obj, but got Ref
			//IL_0468: Expected Obj, but got Ref
			//IL_0256: Expected native int or pointer, but got Obj
			//IL_07be: Expected Obj, but got Ref
			//IL_05cd: Expected Obj, but got Ref
			//IL_043e: Expected Obj, but got Ref
			//IL_02a6: Expected Obj, but got Ref
			//IL_02b2: Expected I4, but got Obj
			//IL_02c3: Expected native int or pointer, but got Obj
			//IL_036b: Expected Obj, but got I4
			//IL_037e: Expected Obj, but got I4
			//IL_0382: Expected Obj, but got I4
			//IL_038a: Expected Obj, but got I4
			//IL_039a: Expected native int or pointer, but got Obj
			//IL_0208: Expected Obj, but got I4
			//IL_020d: Expected VT, but got I4
			//IL_0217: Expected native int or pointer, but got Obj
			//IL_06a2: Expected Obj, but got Ref
			//IL_06b3: Expected Obj, but got I4
			//IL_028e: Expected Obj, but got Ref
			//IL_01f4: Expected Obj, but got I4
			//IL_01f9: Expected Obj, but got I4
			//IL_047b: Expected Obj, but got Ref
			//IL_058d: Expected Obj, but got Ref
			//IL_02ef: Expected VT, but got Obj
			//IL_0755: Expected Obj, but got Ref
			//IL_04e9: Expected native int or pointer, but got Obj
			//IL_0539: Expected Obj, but got I4
			//IL_0548: Expected Obj, but got I4
			//IL_0551: Expected Obj, but got I4
			//IL_055e: Expected I4, but got VT
			//IL_055e: Expected VT, but got I4
			//IL_03b4: Expected Obj, but got I4
			//IL_03b9: Expected Obj, but got I4
			//IL_064c: Expected I, but got Obj
			//IL_064c: Expected Obj, but got Ref
			//IL_065b: Expected Obj, but got I
			//IL_0688: Expected Obj, but got I4
			//IL_068d: Expected Obj, but got I4
			//IL_068d: Expected Obj, but got Ref
			//IL_0696: Expected Obj, but got I4
			//IL_071d: Expected Obj, but got Ref
			//IL_0724: Expected Obj, but got I4
			//IL_05fb: Expected Obj, but got Ref
			//IL_0600: Expected Obj, but got I
			//IL_0605: Expected Obj, but got VT
			//IL_060a: Expected Obj, but got VT
			//IL_0620: Expected Obj, but got I4
			//IL_0625: Expected Obj, but got Ref
			//IL_0634: Expected Obj, but got I
			//IL_03ec: Expected VT, but got Obj
			//IL_03ec: Expected Ref, but got VT
			//IL_06c2: Expected Obj, but got I4
			//IL_06c7: Expected Obj, but got I4
			//IL_06c7: Expected Obj, but got Ref
			//IL_0505: Expected VT, but got Obj
			//IL_06f2: Expected Obj, but got I4
			//IL_06fa: Expected Obj, but got Ref
			//IL_06fb: Expected Obj, but got Ref
			//IL_0702: Expected Obj, but got I4
			//IL_0703: Expected Obj, but got I4
			//IL_070d: Expected I4, but got Obj
			//IL_04c3: Expected Obj, but got Ref
			//IL_0671: Expected Obj, but got Ref
			//IL_01c6: Expected I4, but got Obj
			//IL_00ba->IL0026: Incompatible stack heights: 3 vs 1
			//IL_00e0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_007e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			//IL_08cb->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c5->IL0026: Incompatible stack heights: 3 vs 1
			//IL_00eb->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
			//IL_032a->IL010d: Incompatible stack types: I4 vs Obj
			//IL_0474->IL010d: Incompatible stack types: I4 vs Obj
			//IL_0260->IL010d: Incompatible stack types: I4 vs Obj
			//IL_0109->IL010d: Incompatible stack types: I4 vs Obj
			//IL_08d6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0335->IL010d: Incompatible stack types: I4 vs Obj
			//IL_026b->IL010d: Incompatible stack types: I4 vs Obj
			//IL_07ce->IL010d: Incompatible stack types: I4 vs Obj
			//IL_05e3->IL010d: Incompatible stack types: I4 vs Obj
			//IL_04b5->IL010d: Incompatible stack types: I4 vs Obj
			//IL_02cd->IL010d: Incompatible stack types: I4 vs Obj
			//IL_03a4->IL010d: Incompatible stack types: I4 vs Obj
			//IL_0221->IL010d: Incompatible stack types: I4 vs Obj
			//IL_06bd->IL010d: Incompatible stack types: I4 vs Obj
			//IL_0298->IL010d: Incompatible stack types: I4 vs Obj
			//IL_0203->IL010d: Incompatible stack types: I4 vs Obj
			//IL_0303->IL010d: Incompatible stack types: I4 vs Obj
			//IL_04f3->IL010d: Incompatible stack types: I4 vs Obj
			//IL_0573->IL010d: Incompatible stack types: I4 vs Obj
			//IL_03cd->IL010d: Incompatible stack types: I4 vs Obj
			//IL_0660->IL010d: Incompatible stack types: I4 vs Obj
			//IL_0244->IL010d: Incompatible stack types: I4 vs Obj
			//IL_073a->IL010d: Incompatible stack types: I4 vs Obj
			//IL_061b->IL010d: Incompatible stack types: I4 vs Obj
			//IL_0639->IL010d: Incompatible stack types: I4 vs Obj
			//IL_0286->IL010d: Incompatible stack types: I4 vs Obj
			//IL_06d1->IL010d: Incompatible stack types: I4 vs Obj
			//IL_0413->IL010d: Incompatible stack types: I4 vs Obj
			//IL_050f->IL010d: Incompatible stack types: I4 vs Obj
			//IL_0717->IL010d: Incompatible stack types: I4 vs Obj
			//IL_04cd->IL010d: Incompatible stack types: I4 vs Obj
			//IL_0683->IL010d: Incompatible stack types: I4 vs Obj
			//IL_0521->IL010d: Incompatible stack types: I4 vs Obj
			//IL_06e4->IL010d: Incompatible stack types: I4 vs Obj
			//IL_05ee->IL010d: Incompatible stack types: I4 vs Obj
			//IL_0457->IL010d: Incompatible stack types: I4 vs Obj
			//IL_02d8->IL010d: Incompatible stack types: I4 vs Obj
			//IL_03af->IL010d: Incompatible stack types: I4 vs Obj
			//IL_022c->IL010d: Incompatible stack types: I4 vs Obj
			//IL_05bb->IL010d: Incompatible stack types: I4 vs Obj
			//IL_0494->IL010d: Incompatible stack types: I4 vs Obj
			//IL_059c->IL010d: Incompatible stack types: I4 vs Obj
			//IL_030e->IL010d: Incompatible stack types: I4 vs Obj
			//IL_04fe->IL010d: Incompatible stack types: I4 vs Obj
			//IL_03d8->IL010d: Incompatible stack types: I4 vs Obj
			//IL_066b->IL010d: Incompatible stack types: I4 vs Obj
			//IL_0745->IL010d: Incompatible stack types: I4 vs Obj
			//IL_0644->IL010d: Incompatible stack types: I4 vs Obj
			//IL_0462->IL010d: Incompatible stack types: I4 vs Obj
			//IL_05c6->IL010d: Incompatible stack types: I4 vs Obj
			//IL_049f->IL010d: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 7;
			object obj = awaiter;
			while (true)
			{
				switch ((int)obj)
				{
				case 3:
					return;
				case 4:
					((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state = -2;
					obj = 2;
					break;
				case 2:
					((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)null;
					obj = 1;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						obj = 0;
					}
					break;
				case 7:
					awaiter = Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton;
					obj = 6;
					break;
				default:
					_ = ref ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003E1__state;
					AsyncTaskMethodBuilder.Create();
					_ = 3;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
					{
						_ = 2;
					}
					break;
				case 1:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Eu__1 = (TaskAwaiter<TcpClient>)null;
					obj = 0;
					if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state != 0)
					{
						obj = 0;
					}
					break;
				case 5:
				{
					object obj2;
					switch ((int)awaiter)
					{
					default:
						obj2 = 30;
						goto IL_010d;
					case 2:
						awaiter = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003E4__this;
						obj2 = 4;
						if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003Cstream_003E5__2)->_003C_003Eu__1 != 0)
						{
							obj2 = 1;
						}
						goto IL_010d;
					case 0:
						goto IL_030e;
					case 1:
						goto IL_0462;
						IL_010d:
						while (true)
						{
							switch ((int)obj2)
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
								awaiter = -1;
								((Authenticator._003CReceiveAsync_003Ed__9)this).client = (TcpClient)(-1);
								obj2 = 44;
								continue;
							case 8:
								awaiter = 0;
								((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003Eu__1 = (TaskAwaiter)0;
								obj2 = 37;
								if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain)->_003C_003E1__state != 0)
								{
									obj2 = 43;
								}
								continue;
							case 24:
								Unsafe.As<AsyncTaskMethodBuilder, AsyncTaskMethodBuilder<EntityFeverManifestInfo>>(ref ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003Et__builder).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverManifestInfo>*)(&awaiter), ref Unsafe.As<_003CPlayerSkinAsync_003Ed__31, FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13>(ref this));
								obj2 = 36;
								continue;
							case 15:
								goto end_IL_010d;
							case 30:
								((AsyncTaskMethodBuilder*)/*Error near IL_0277: Stack underflow*/)->AwaitUnsafeOnCompleted(ref Unsafe.As<_003CPlayerSkinAsync_003Ed__31, TaskAwaiter<EntityFeverManifest>>(ref this), ref *(FeverInstaller._003CInstallAsync_003Ed__11*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway);
								((FeverInstaller)/*Error near IL_027c: Stack underflow*/)._003CappId_003EP = (object)/*Error near IL_027c: Stack underflow*/;
								obj2 = 20;
								continue;
							case 12:
								((FeverInstaller)Unsafe.AsPointer(ref this))._003CappVersion_003EP = awaiter;
								obj2 = 24;
								continue;
							case 6:
								((FeverInstaller)/*Error near IL_029f: Stack underflow*/)._002Ector((string)/*Error near IL_029f: Stack underflow*/, (string)/*Error near IL_029f: Stack underflow*/, (string)awaiter);
								((TcpClient)(&awaiter)).Close();
								((Stream)/*Error near IL_02b7: Stack underflow*/).Write((byte[])/*Error near IL_02b7: Stack underflow*/, (int)/*Error near IL_02b7: Stack underflow*/, ((Stream)/*Error near IL_02b2: Stack underflow*/).Read((byte[])/*Error near IL_02b2: Stack underflow*/, (int)/*Error near IL_02b2: Stack underflow*/, (int)((FeverInstaller)awaiter).Client));
								awaiter = (object)/*Error near IL_02b9: Stack underflow*/;
								obj2 = 9;
								if (((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003E4__this)->request == null)
								{
									obj2 = 14;
								}
								continue;
							case 17:
								((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003Eu__1 = (TaskAwaiter<RestResponse<EntityFeverResponse<T>>>)awaiter;
								obj2 = 7;
								if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E1__state)->_003C_003Et__builder != 0)
								{
									obj2 = 9;
								}
								continue;
							case 1:
								goto IL_030e;
							case 7:
							{
								int num = ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003E1__state;
								RandomHelper[] array2 = new RandomHelper[5]
								{
									(RandomHelper)520,
									null,
									null,
									null,
									null
								};
								((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)1)->SetStateMachine((IAsyncStateMachine)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this).info);
								((object[])num)[(object)array2] = array2;
								_003F val = /*Error near IL_037a: Stack underflow*/;
								((object[])/*Error near IL_037e: Stack underflow*/)[val] = 2;
								_003F val2 = /*Error near IL_037e: Stack underflow*/;
								((object[])/*Error near IL_0382: Stack underflow*/)[val2] = 3;
								((object[])/*Error near IL_0382: Stack underflow*/)[4] = 0;
								((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)/*Error near IL_0390: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_0390: Stack underflow*/);
								obj2 = 33;
								if ((int)((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.version)->_003C_003Eu__1 != 0)
								{
									obj2 = 16;
								}
								continue;
							}
							case 22:
								awaiter = -1;
								FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CheckScalableWorker = -1;
								obj2 = 2;
								if ((int)((FeverInstaller._003CInstallAsync_003Ed__11*)FeverInstaller._003CInstallAsync_003Ed__11._003C_003E1__state)->_003C_003Et__builder != 0)
								{
									obj2 = 2;
								}
								continue;
							case 29:
								FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.DecorateGroupedVisitor();
								((AsyncTaskMethodBuilder<_00210>*)((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Eu__1)->SetResult((_00210)awaiter);
								/*Error near IL_03ec: Member reference must be method, but was: Field*/;
							case 34:
								FeverInstaller._003CInstallAsync_003Ed__11.ReflectAccessibleWatcher = null;
								obj2 = 28;
								continue;
							case 5:
								if ((int)((Task<RestResponse<EntityFeverResponse<_00210>>>)(&awaiter)).GetAwaiter() != 0)
								{
									obj2 = 3;
									if (((Rpc)(object)Rpc.Callbacks__BackingField).Writer__BackingField == null)
									{
										obj2 = 2;
									}
									continue;
								}
								goto case 31;
							case 10:
								goto IL_0462;
							case 14:
								((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_047b: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)(&awaiter));
								if ((int)/*Error near IL_0480: Stack underflow*/ != 0)
								{
									obj2 = 2;
									if (Rpc.ParseMap != null)
									{
										obj2 = 38;
									}
									continue;
								}
								goto case 8;
							case 4:
								Unsafe.As<int, @null>(ref ((Rpc._003CListenAsync_003Ed__34)this)._003C_003E1__state) = null;
								obj2 = 22;
								continue;
							case 40:
								((ILogger)/*Error near IL_04c3: Stack underflow*/).Information<int, int>((string)Unsafe.AsPointer(ref ((Rpc._003CListenAsync_003Ed__34)this)._003C_003E4__this), (int)(&awaiter), (int)Unsafe.AsPointer(ref this));
								obj2 = 39;
								continue;
							case 20:
								((Rpc)/*Error near IL_04d8: Stack underflow*/).Writer = (BinaryWriter?)Rpc._003CListenAsync_003Ed__34.DecorateIterableWriter;
								((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)/*Error near IL_04dd: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_04dd: Stack underflow*/);
								awaiter = (object)/*Error near IL_04df: Stack underflow*/;
								obj2 = 4;
								if (((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)Rpc._003CListenControlConnectAsync_003Ed__35.listener)->_003C_003E4__this != null)
								{
									obj2 = 6;
								}
								continue;
							case 35:
								((Rpc._003CListenControlConnectAsync_003Ed__35)this)._003C_003Eu__1 = (TaskAwaiter<TcpClient>)null;
								obj2 = 42;
								continue;
							case 43:
								Rpc._003CListenControlConnectAsync_003Ed__35.ReflectSymbolicDecorator = awaiter;
								obj2 = 40;
								continue;
							case 21:
							{
								int num2 = ((Rpc._003CReceiveAsync_003Ed__28)this)._003C_003E1__state;
								AppDomain[] array3 = new AppDomain[5]
								{
									(AppDomain)520,
									null,
									null,
									null,
									null
								};
								((Rpc._003CListenAsync_003Ed__34*)((Rpc._003CReceiveAsync_003Ed__28)this)._003C_003E4__this)->MoveNext();
								array3[(object)array3] = (AppDomain)1;
								((object[])num2)[2] = awaiter;
								((object[])num2)[num2] = 3;
								((object[])/*Error near IL_0564: Stack underflow*/)[/*Error near IL_0564: Stack underflow*/] = RestRequestExtensions.AddQueryParameter<_0021_00210>((RestRequest)/*Error near IL_055e: Stack underflow*/, (string)/*Error near IL_0551: Stack underflow*/, (_0021_00210)4, (byte)(int)((Rpc._003CRemoteCallBackAsync_003Ed__21)this)._003C_003Et__builder != 0);
								((Rpc._003CListenControlConnectAsync_003Ed__35*)/*Error near IL_0569: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_0569: Stack underflow*/);
								obj2 = 19;
								continue;
							}
							case 16:
								if (((string)/*Error near IL_058d: Stack underflow*/).Replace((string)/*Error near IL_058d: Stack underflow*/, (string?)(&awaiter)) != null)
								{
									obj2 = 32;
									continue;
								}
								goto case 25;
							case 9:
								if (((Rpc._003CSyncChaChaAsync_003Ed__38)this)._003C_003E1__state == 0)
								{
									obj2 = 0;
									if (((Rpc._003CSyncChaChaAsync_003Ed__38)Rpc._003CSyncChaChaAsync_003Ed__38._003C_003Et__builder)._003C_003E4__this == null)
									{
										obj2 = 7;
									}
									continue;
								}
								goto case 27;
							case 2:
							case 32:
								((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)/*Error near IL_05cd: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)(&awaiter));
								awaiter = (object)/*Error near IL_05cf: Stack underflow*/;
								obj2 = 26;
								if (((CppGameValue)Rpc._003CSyncChaChaAsync_003Ed__38.RateStack).SkinPath__BackingField == null)
								{
									obj2 = 13;
								}
								continue;
							case 27:
								((Rpc._003CRemoteCallBackAsync_003Ed__21*)/*Error near IL_05f5: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)awaiter);
								((Dictionary<ushort, Func<RpcCallBack, Task>>)((Task<EntityFeverAppVersion>)((Task<EntityFeverManifest>)((GameValue)Unsafe.AsPointer(ref this)).MaxConcurrency__BackingField).GetAwaiter()).GetAwaiter())._002Ector();
								((Func<RpcCallBack, Task>)/*Error near IL_060f: Stack underflow*/)._002Ector((object)/*Error near IL_060f: Stack underflow*/, (nint)/*Error near IL_060f: Stack underflow*/);
								awaiter = (object)/*Error near IL_0611: Stack underflow*/;
								obj2 = 5;
								continue;
							case 28:
								awaiter = -1;
								((JavaGameValue)Unsafe.AsPointer(ref this)).SaveOptions__BackingField = -1;
								obj2 = 1;
								if (((JavaGameValue)JavaGameValue.SetChinese__BackingField).SetGuiScale__BackingField != 0)
								{
									obj2 = 11;
								}
								continue;
							case 23:
								((JavaGameValue)Unsafe.AsPointer(ref this)).GuiScale__BackingField = (nint)awaiter;
								obj2 = 21;
								if (((JavaGameValue)JavaGameValue.SetSize__BackingField).WindowWidth__BackingField != 0)
								{
									obj2 = 41;
								}
								continue;
							case 41:
								Unsafe.As<nint, AsyncTaskMethodBuilder>(ref ((JavaGameValue)Unsafe.AsPointer(ref this)).WindowHeight__BackingField).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityItemDownload>*)(&awaiter), ref Unsafe.As<_003CPlayerSkinAsync_003Ed__31, JavaGame._003CPrepareServerResourceAsync_003Ed__36>(ref this));
								obj2 = 18;
								continue;
							case 25:
								awaiter = 2;
								((BedrockGamePath)Unsafe.AsPointer(ref this)).NeteaseData = (string)2;
								awaiter = 23;
								obj2 = awaiter;
								continue;
							case 3:
							case 11:
								((Dictionary<ushort, Func<RpcCallBack, Task>>)/*Error near IL_06a2: Stack underflow*/)[(ushort)/*Error near IL_06a2: Stack underflow*/] = (Func<RpcCallBack, Task>)(&awaiter);
								((AsyncTaskMethodBuilder*)/*Error near IL_06ac: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)/*Error near IL_06ac: Stack underflow*/, ref *(JavaGame._003CStartGameAsync_003Ed__137*)((BinaryReader)/*Error near IL_06a7: Stack underflow*/).ReadBytes((int)/*Error near IL_06a7: Stack underflow*/));
								awaiter = BitConverter.ToUInt16((byte[])/*Error near IL_06b1: Stack underflow*/, (int)/*Error near IL_06b1: Stack underflow*/);
								obj2 = 37;
								continue;
							case 31:
								awaiter = 1;
								((ComponentPath)Unsafe.AsPointer(ref this)).Source = (string)1;
								obj2 = 12;
								continue;
							case 38:
							case 44:
								awaiter = Enumerable.Skip<TSource>((IEnumerable<TSource>)/*Error near IL_06d8: Stack underflow*/, (int)(&awaiter));
								obj2 = 17;
								continue;
							case 37:
							{
								Nullable<>[] array = new Nullable<>[3];
								((object[])(object)array)[(object)array] = ((IPEndPoint)0).Address;
								((JavaGameValue)Unsafe.AsPointer(ref this)).Reconnect = true;
								((object[])/*Error near IL_06fb: Stack underflow*/)[/*Error near IL_06fb: Stack underflow*/] = (object)Unsafe.AsPointer(ref this);
								((object[])/*Error near IL_0703: Stack underflow*/)[/*Error near IL_06fb: Stack underflow*/] = ((JavaGameValue)2).ReconnectDelay;
								((ComponentPath)/*Error near IL_070d: Stack underflow*/).IsShaderPack = (byte)(int)((Socket)/*Error near IL_0708: Stack underflow*/).RemoteEndPoint != 0;
								obj2 = 29;
								continue;
							}
							case 26:
								((BinaryReader)((ComponentPath)Unsafe.AsPointer(ref this)).IsResourcePack)._002Ector((Stream)awaiter);
								awaiter = (object)/*Error near IL_0726: Stack underflow*/;
								obj2 = 21;
								if (((CppGamePath)(object)CppGamePath.BedrockLauncherFile).BedrockLauncher != null)
								{
									obj2 = 19;
								}
								continue;
							case 19:
								((JavaGameValue)/*Error near IL_074a: Stack underflow*/).SetGuiScale = (byte)/*Error near IL_074a: Stack underflow*/ != 0;
								_ = ((JavaGameValue)/*Error near IL_074f: Stack underflow*/).GuiScale;
								_ = ((CppGamePath)Unsafe.AsPointer(ref this)).GameZip;
								/*Error near IL_0755: Member reference must be method, but was: Field*/;
							default:
								((GamePath)Unsafe.AsPointer(ref this)).Files = null;
								obj2 = 13;
								continue;
							}
							goto end_IL_00ee;
							continue;
							end_IL_010d:
							break;
						}
						goto case 2;
						IL_0462:
						awaiter = ((Rpc)Unsafe.AsPointer(ref this)).Listener__BackingField;
						obj2 = 34;
						goto IL_010d;
						IL_030e:
						awaiter = ((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003E4__this;
						obj2 = 0;
						if (FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor != null)
						{
							obj2 = 0;
						}
						goto IL_010d;
						end_IL_00ee:
						break;
					}
					goto case 4;
				}
				case 6:
					awaiter = ((JavaGamePath)Unsafe.AsPointer(ref this)).GameVersionMd5;
					obj = 4;
					if (((JavaGamePath)(object)JavaGamePath.GameCoreLibs).GameCoreLibMd5 != null)
					{
						obj = 5;
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2000()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
	public unsafe JavaRpc(DesktopSession session, EnumGameType type, EnumGameVersion version, string serverAddress, int serverPort, string characterName)
	{
		//IL_0020: Expected Obj, but got I4
		//IL_00de: Expected native int or pointer, but got Obj
		//IL_00b7: Expected native int or pointer, but got Obj
		//IL_0072: Expected VT, but got Obj
		//IL_006d: Expected native int or pointer, but got Obj
		//IL_007c: Expected native int or pointer, but got Obj
		//IL_0098: Expected Obj, but got I4
		//IL_00a9: Expected Obj, but got I4
		//IL_00a4: Expected native int or pointer, but got Obj
		//IL_005c: Expected native int or pointer, but got Obj
		//IL_00a2->IL0033: Incompatible stack heights: 2 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Authenticator)(object)((Authenticator)(object)this).Listener).Listener = (TcpListener?)0;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 6:
				Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E4__this, characterName);
				num = 5;
				break;
			case 2:
				Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Eu__1, (TaskAwaiter)session);
				num = 0;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
				{
					num = 1;
				}
				break;
			case 4:
				((Authenticator)(object)this).ReceiveAuthenticationDataAsync((object)version);
				_ = 3;
				break;
			case 5:
				Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->listener, (TcpListener)type);
				num = 4;
				break;
			case 3:
				return;
			case 1:
				Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E4__this, serverAddress);
				num = 0;
				if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler != null)
				{
					num = 0;
				}
				break;
			default:
				((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003E1__state = serverPort;
				num = 6;
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
	private unsafe static object _FF00_FF00_FF00_FF00㤀()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
	private unsafe EnumGameType _FF00_FF00_FF00_FF00䈀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (EnumGameType)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
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
	internal unsafe static object _FF00_FF00_FF00_FF00䘀()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779030, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00䠀()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_006b: Expected I4, but got Obj
		//IL_00a6->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0084->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008f->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				((Authenticator)/*Error near IL_006b: Stack underflow*/).StartListening((int)this);
				if ((int)/*Error near IL_0070: Stack underflow*/ == 0)
				{
					return;
				}
				obj2 = 0;
				if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
				{
					obj2 = 0;
				}
				break;
			case 2:
				return;
			default:
				((Authenticator)/*Error near IL_009c: Stack underflow*/).ReceiveAuthenticationDataAsync(((Authenticator)(object)this).ReceiveAsync((object)this));
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
	private unsafe uint _FF00_FF00_FF00_FF00䰀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
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
	private unsafe object _FF00_FF00_FF00_FF00儀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_001b: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
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
	internal unsafe static byte _FF00_FF00_FF00_FF00唀()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00嘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779020, new IntPtr(2737337576204L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00圀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_001b: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe void _FF00_FF00_FF00_FF00堀(EnumGameVersion P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0063: Expected I4, but got Obj
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected native int or pointer, but got Obj
		//IL_007f: Expected I4, but got Obj
		//IL_007f: Expected Obj, but got I4
		//IL_01d8: Expected I4, but got Obj
		//IL_01d8: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got I
		//IL_0119: Expected Obj, but got VT
		//IL_0254: Expected Ref, but got VT
		//IL_025d: Expected Obj, but got I4
		//IL_01fa: Expected Obj, but got I
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_00a0: Expected Obj, but got VT
		//IL_0100: Expected Obj, but got I4
		//IL_01a3: Expected Obj, but got I4
		//IL_0235->IL0026: Incompatible stack heights: 7 vs 1
		//IL_0089->IL0026: Incompatible stack heights: 2 vs 1
		//IL_01e7->IL0026: Incompatible stack heights: 2 vs 1
		//IL_012d->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0262->IL0022: Incompatible stack heights: 4 vs 0
		//IL_0159->IL0026: Incompatible stack heights: 7 vs 1
		//IL_0209->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00b4->IL0026: Incompatible stack heights: 4 vs 1
		//IL_01c9->IL0026: Incompatible stack heights: 6 vs 1
		//IL_0184->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00e0->IL0026: Incompatible stack heights: 7 vs 1
		//IL_0105->IL0022: Incompatible stack heights: 4 vs 0
		//IL_0240->IL0026: Incompatible stack heights: 7 vs 1
		//IL_0138->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00bf->IL0026: Incompatible stack heights: 4 vs 1
		//IL_018f->IL0026: Incompatible stack heights: 4 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((Authenticator)517).StartListening((int)(Func<Task>)([MethodImpl(MethodImplOptions.NoInlining)] () => (TcpListener?)((Authenticator)(object)this)._FF00_FF00_1400()));
					_ = 13;
					continue;
				case 7:
					_ = 274;
					((Authenticator)(object)this).ReceiveAsync((object)new AsyncTaskMethodBuilder(ref *(TStateMachine*)__ldftn(Authenticator.ListenAsync)));
					_ = 0;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener == null)
					{
						_ = 0;
					}
					continue;
				case 12:
					_ = 1298;
					__ldftn(Authenticator.HandleAuthentication);
					new IAsyncStateMachine();
					Authenticator.PatchUser();
					_ = 10;
					continue;
				case 13:
					_ = 520;
					new AsyncTaskMethodBuilder(ref *(TAwaiter*)this, ref *(TStateMachine*)__ldftn(Authenticator._003CListenAsync_003Ed__7.MoveNext));
					Authenticator._003CListenAsync_003Ed__7.DecorateExpandableParser();
					obj = 8;
					break;
				case 3:
					_ = 18;
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)this)->SetStateMachine((IAsyncStateMachine)new AsyncTaskMethodBuilder((Exception)(delegate*<object>)(&Authenticator._003CListenAsync_003Ed__7.ObserveTracker)));
					_ = 0;
					if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						_ = 2;
					}
					continue;
				case 5:
					_ = 1031;
					__ldftn(Authenticator._003CReceiveAsync_003Ed__9.MoveNext);
					new TcpListener();
					Authenticator._003CReceiveAsync_003Ed__9.ReflectAdvancedEnumerator();
					_ = 12;
					continue;
				case 10:
					_ = 4612;
					((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(delegate*<object>)(&Authenticator._003CReceiveAsync_003Ed__9.DecorateConvertibleParameter))->SetStateMachine((IAsyncStateMachine)new Encoding());
					_ = 9;
					if (((FeverInstaller)FeverInstaller._003CappId_003EP)._003CappVersion_003EP != null)
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
					__ldftn(FeverInstaller._002Ector);
					_ = ((FeverInstaller)new TcpClient()).Client;
					_ = 5;
					continue;
				case 2:
					((FeverInstaller)(object)this).GetFeverManifestAsync((object)new Stream((byte[])19, (int)this, (int)__ldftn(FeverInstaller.Dispose)));
					_ = 4;
					continue;
				case 6:
					_ = 261;
					((FeverInstaller)(object)this).FeverRequest<T>((RestRequest)(object)new RestClientOptions((string)__ldvirtftn(FeverInstaller.GetFeverManifestInfoAsync)));
					_ = 7;
					continue;
				case 11:
					return;
				default:
					_ = 512;
					_ = (delegate*<void>)(&FeverInstaller._002Ecctor);
					new RestClient();
					FeverInstaller.CheckStaticProgram();
					_ = 1;
					if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor)->_003C_003E1__state != 0)
					{
						_ = 0;
					}
					continue;
				case 4:
					_ = 81;
					_ = (delegate*<bool>)(&FeverInstaller._003CFeverRequest_003Ed__15<>.CheckAdaptableResponder);
					((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)new AsyncTaskMethodBuilder<EntityFeverManifestInfo>())->MoveNext();
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
	private unsafe object _FF00_FF00_FF00_FF00开()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_001b: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
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
	private unsafe void _FF00_FF00_FF00_FF00挀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_004c: Expected Obj, but got I4
		//IL_0055: Expected I4, but got Obj
		//IL_0055: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I4
		//IL_0098->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a3->IL0026: Incompatible stack heights: 2 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
			{
				GameInstance[] array = new GameInstance[5]
				{
					(GameInstance)1031,
					null,
					null,
					null,
					null
				};
				((Authenticator)1).StartListening((int)this);
				((object[])P_0)[(object)array] = array;
				((object[])(object)this)[2] = (object)(ILogger)((Authenticator)(object)this).ListenAsync();
				((object[])(object)this)[(object)this] = ((Authenticator)3).ReceiveAsync((object)this);
				((object[])/*Error near IL_007f: Stack underflow*/)[/*Error near IL_006d: Stack underflow*/] = (nint)((Authenticator)4).ReceiveAuthenticationDataAsync((object)this) == 9;
				((Authenticator)/*Error near IL_0084: Stack underflow*/).HandleAuthentication((string)/*Error near IL_0084: Stack underflow*/);
				_ = 0;
				if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
				{
					_ = 0;
				}
				break;
			}
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
