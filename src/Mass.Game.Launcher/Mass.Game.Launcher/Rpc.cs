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
using System.Threading;
using System.Threading.Tasks;
using Mass.Application.Extensions;
using Mass.Game.Launcher.Entities.Fever;
using Mass.Game.Launcher.Java;
using Mass.Game.Launcher.Models;
using RestSharp;
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
		private unsafe sealed void _FF00笀(object P_0)
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
		internal unsafe static object _FF00簀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_03fa: Expected VT, but got I4
			//IL_0404: Expected native int or pointer, but got Obj
			//IL_0422: Expected Obj, but got VT
			//IL_03c8: Expected native int or pointer, but got Obj
			//IL_02fb: Expected native int or pointer, but got Obj
			//IL_00aa: Expected native int or pointer, but got Obj
			//IL_01de: Expected native int or pointer, but got Obj
			//IL_019a: Expected Obj, but got Ref
			//IL_0174: Expected Obj, but got Ref
			//IL_01f8: Expected Obj, but got I4
			//IL_01fd: Expected VT, but got I4
			//IL_0116: Expected Obj, but got I4
			//IL_011b: Expected VT, but got I4
			//IL_040e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03f2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0436->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03d2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0419->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0441->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03dd->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0188->IL00c3: Incompatible stack heights: 2 vs 1
			//IL_0193->IL00c3: Incompatible stack heights: 2 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 4;
			object obj = awaiter;
			while (true)
			{
				int num;
				int num2;
				object obj2;
				switch ((int)obj)
				{
				case 2:
					if (awaiter == null)
					{
						num = 3;
						goto IL_005e;
					}
					goto IL_02e5;
				case 4:
					awaiter = ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003E4__this;
					obj = 3;
					if ((int)((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.version)->_003C_003Eu__1 != 0)
					{
						obj = 1;
					}
					break;
				case 1:
					((AsyncTaskMethodBuilder<_0021_00210>*)/*Error near IL_03e8: Stack underflow*/)->Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CheckScalableWorker));
					obj = 5;
					break;
				default:
					goto IL_03f2;
				case 5:
					return;
				case 3:
					{
						awaiter = ((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Eu__2;
						obj = 2;
						if (FeverInstaller._003CInstallAsync_003Ed__11.ReflectAccessibleWatcher == null)
						{
							obj = 2;
						}
						break;
					}
					IL_03f2:
					((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-2);
					obj = 0;
					if ((int)((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)FeverInstaller._003CInstallAsync_003Ed__11._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						obj = 1;
					}
					break;
					IL_005e:
					switch (num)
					{
					case 3:
						break;
					case 1:
						if (awaiter != null)
						{
							num2 = 0;
							if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
							{
								num2 = 0;
							}
							goto IL_00c3;
						}
						goto IL_0146;
					case 2:
						goto IL_02e5;
					default:
						goto IL_03f2;
						IL_0146:
						awaiter = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003E4__this;
						num2 = 1;
						if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler != null)
						{
							num2 = 1;
						}
						goto IL_00c3;
						IL_00c3:
						while (true)
						{
							switch (num2)
							{
							case 3:
								Unsafe.As<object, AsyncTaskMethodBuilder>(ref Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<string>*)(&awaiter), ref Unsafe.As<_003CListenAsync_003Ed__34, Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10>(ref this));
								num2 = 2;
								continue;
							case 10:
								awaiter = -1;
								((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-1);
								num2 = 8;
								continue;
							case 2:
								return;
							case 7:
								((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this).listener = (TcpListener)awaiter;
								num2 = 3;
								continue;
							case 6:
								break;
							case 8:
								((Task)(&awaiter)).GetAwaiter();
								_ = 0;
								if (((Authenticator._003CReceiveAsync_003Ed__9)Authenticator._003CReceiveAsync_003Ed__9._003C_003Et__builder)._003C_003E4__this != null)
								{
									_ = 4;
								}
								continue;
							case 5:
								((ILogger)/*Error near IL_019a: Stack underflow*/).Error((Exception)/*Error near IL_019a: Stack underflow*/, (string)(&awaiter));
								if ((int)/*Error near IL_019f: Stack underflow*/ == 0)
								{
									num2 = 9;
									continue;
								}
								goto case 8;
							default:
							{
								object stateMachine = awaiter;
								((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)awaiter)->MoveNext();
								((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)/*Error near IL_01b7: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)stateMachine);
								((IAsyncStateMachine)/*Error near IL_01bc: Stack underflow*/).SetStateMachine((IAsyncStateMachine)/*Error near IL_01bc: Stack underflow*/);
								awaiter = (object)/*Error near IL_01be: Stack underflow*/;
								num2 = 5;
								continue;
							}
							case 1:
								Unsafe.As<AsyncTaskMethodBuilder, @null>(ref ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003Et__builder) = null;
								num2 = 6;
								if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E4__this)->_003Cstream_003E5__2 != null)
								{
									num2 = 10;
								}
								continue;
							case 9:
								awaiter = 0;
								((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003Eu__1 = (TaskAwaiter<string>)0;
								num2 = 4;
								if (((FeverInstaller)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway)._003CfeverVersion_003EP != null)
								{
									num2 = 7;
								}
								continue;
							case 4:
								goto IL_02e5;
							}
							break;
						}
						goto IL_0146;
					}
					goto IL_0078;
					IL_0078:
					num = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)Authenticator._003CListenAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						num = 1;
					}
					goto IL_005e;
					IL_02e5:
					obj2 = awaiter;
					FeverInstaller._002Ecctor();
					if (obj2 == null)
					{
						num = 0;
						if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E4__this)->_003C_003Eu__1 == 0)
						{
							num = 0;
						}
						goto IL_005e;
					}
					goto IL_0078;
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
		internal unsafe static byte _FF00舀()
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
		private unsafe sealed void _FF00漀(object P_0)
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
		internal unsafe static object _FF00爀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00瘀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_047f: Expected Obj, but got Ref
			//IL_0458: Expected Obj, but got Ref
			//IL_0432: Expected Obj, but got I4
			//IL_0432: Expected Obj, but got Ref
			//IL_0441: Expected Obj, but got I
			//IL_005d: Expected native int or pointer, but got Obj
			//IL_01fb: Expected Obj, but got I4
			//IL_0200: Expected VT, but got I4
			//IL_01ea: Expected Obj, but got Ref
			//IL_01ec: Expected Obj, but got VT
			//IL_02a4: Expected Obj, but got I4
			//IL_01b7: Expected Obj, but got I4
			//IL_0252: Expected Obj, but got Ref
			//IL_025c: Expected I4, but got Obj
			//IL_025e: Expected Obj, but got I4
			//IL_01d4: Expected Obj, but got Ref
			//IL_0282: Expected Obj, but got I4
			//IL_0287: Expected Obj, but got I4
			//IL_0228: Expected I4, but got Obj
			//IL_02c1: Expected native int or pointer, but got Obj
			//IL_0146: Expected Ref, but got VT
			//IL_0495->IL0026: Incompatible stack types: I4 vs Obj
			//IL_046e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0446->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04a0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0479->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0451->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0072->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01bc->IL0084: Incompatible stack types: I4 vs Obj
			//IL_01a7->IL0088: Incompatible stack heights: 2 vs 1
			//IL_0088->IL0088: Incompatible stack heights: 2 vs 1
			//IL_039d->IL0088: Incompatible stack heights: 2 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 1;
			object obj = awaiter;
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				case 5:
					((Func<Task>)/*Error near IL_0053: Stack underflow*/)._002Ector((object)/*Error near IL_0053: Stack underflow*/, (nint)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state));
					obj = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj = 2;
					}
					break;
				case 4:
					if (awaiter != null)
					{
						num = 10;
						goto IL_0088;
					}
					goto IL_020a;
				case 3:
					goto IL_042a;
				case 2:
					return;
				case 1:
					awaiter = ((Rpc)Unsafe.AsPointer(ref this)).Callbacks__BackingField;
					obj = 0;
					if (((Rpc)Rpc.Writer__BackingField).Listener__BackingField == null)
					{
						obj = 0;
					}
					break;
				default:
					{
						awaiter = ((Rpc)Unsafe.AsPointer(ref this))._chaChaEn;
						obj = 2;
						if (ParseMap == null)
						{
							obj = 4;
						}
						break;
					}
					IL_0088:
					while (true)
					{
						object obj2;
						switch (num)
						{
						case 19:
							((AsyncTaskMethodBuilder*)/*Error near IL_00f9: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)awaiter);
							num = 14;
							if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder != 0)
							{
								num = 9;
							}
							continue;
						default:
						{
							((Authenticator)awaiter).Dispose();
							Task<string> task = ((Authenticator)/*Error near IL_0124: Stack underflow*/).HandleAuthentication((string)/*Error near IL_0124: Stack underflow*/);
							((IAsyncStateMachine)awaiter).MoveNext();
							((AsyncTaskMethodBuilder<_0021_00210>*)/*Error near IL_0130: Stack underflow*/)->Start(ref *(FeverInstaller._003CFeverRequest_003Ed__15<_0021_00210>*)task);
							num = 19;
							continue;
						}
						case 23:
							((AsyncTaskMethodBuilder*)/*Error near IL_0146: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_0146: Stack underflow*/, ref *(TStateMachine*)((Task)awaiter).GetAwaiter());
							awaiter = (object)/*Error near IL_0148: Stack underflow*/;
							num = 15;
							continue;
						case 17:
							((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)awaiter)->MoveNext();
							((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)/*Error near IL_0191: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_0191: Stack underflow*/);
							((IAsyncStateMachine)/*Error near IL_0198: Stack underflow*/).SetStateMachine((IAsyncStateMachine)awaiter);
							((RestResponse<EntityFeverManifest>)/*Error near IL_019d: Stack underflow*/).EnsureSuccessStatusCode<EntityFeverManifest>((string?)/*Error near IL_019d: Stack underflow*/, (byte)/*Error near IL_019d: Stack underflow*/ != 0);
							_ = 6;
							continue;
						case 9:
						{
							bool isCompleted = ((TaskAwaiter<TcpClient>*)awaiter)->IsCompleted;
							awaiter = 8;
							obj2 = isCompleted;
							continue;
						}
						case 18:
							if (awaiter != null)
							{
								num = 4;
								continue;
							}
							goto IL_036e;
						case 12:
							if (((TcpListener)(&awaiter)).AcceptTcpClientAsync() == null)
							{
								num = 20;
								continue;
							}
							goto case 3;
						case 3:
							awaiter = ((Task<TcpClient>)(&awaiter)).GetAwaiter();
							num = 23;
							continue;
						case 2:
							awaiter = -1;
							((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003Eu__1 = (TaskAwaiter<string>)(-1);
							num = 3;
							continue;
						case 11:
							break;
						case 4:
						case 21:
							if (((Encoding)/*Error near IL_0228: Stack underflow*/).GetString((byte[])/*Error near IL_0228: Stack underflow*/, (int)/*Error near IL_0228: Stack underflow*/, (int)((Encoding)/*Error near IL_0223: Stack underflow*/).GetBytes((string)awaiter)) == null)
							{
								num = 0;
								if (FeverInstaller.McBedrock__BackingField == null)
								{
									num = 0;
								}
								continue;
							}
							goto case 17;
						case 10:
							awaiter = ((Stream)/*Error near IL_025c: Stack underflow*/).Read((byte[])/*Error near IL_025c: Stack underflow*/, (int)/*Error near IL_025c: Stack underflow*/, (int)((TaskAwaiter<string>*)((FeverInstaller)Unsafe.AsPointer(ref this)).Client__BackingField)->GetResult());
							num = 3;
							if (((FeverInstaller._003CFeverRequest_003Ed__15<>)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Et__builder)._003C_003E4__this != null)
							{
								num = 12;
							}
							continue;
						case 20:
							awaiter = 0;
							((FeverInstaller._003CFeverRequest_003Ed__15<>)this).request = (RestRequest)(object)0;
							num = 16;
							continue;
						case 6:
							obj2 = awaiter;
							((FeverInstaller)awaiter).GetFeverAppVersionAsync();
							awaiter = 7;
							continue;
						case 22:
							Unsafe.As<int, AsyncTaskMethodBuilder>(ref ((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003E1__state).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CListenControlConnectAsync_003Ed__35, _003CListenAsync_003Ed__34>(ref this));
							num = 5;
							if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E4__this)->_003C_003Eu__1 != 0)
							{
								num = 0;
							}
							continue;
						case 13:
							Unsafe.As<object, List<Mass.Game.Launcher.Paths.ComponentPath>.Enumerator>(ref FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor) = default;
							num = 2;
							if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003Et__builder)._003C_003E4__this == null)
							{
								num = 2;
							}
							continue;
						case 5:
							return;
						case 15:
							awaiter = awaiter as BinaryWriter;
							num = 18;
							if ((int)((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								num = 15;
							}
							continue;
						case 16:
							((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003E4__this = (FeverInstaller)awaiter;
							num = 22;
							continue;
						case 1:
							goto IL_036e;
						case 7:
						case 8:
						case 14:
							goto IL_042a;
						}
						break;
						IL_036e:
						bool flag = FeverInstaller._003CGetFeverManifestAsync_003Ed__12.SearchChain();
						object obj3 = FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReceiveEnumerator();
						if (awaiter != null)
						{
							/*Error near IL_0389: Member reference must be method, but was: Field*/;
						}
						((ILogger)flag).Debug<string>((string)obj3, (string)null);
						_ = 9;
					}
					goto IL_020a;
					IL_042a:
					((Rpc)Unsafe.AsPointer(ref this)).Logger__BackingField = -2;
					obj = 5;
					if (((Rpc)Rpc.NeedCha__BackingField).UseCha__BackingField != 0)
					{
						obj = 5;
					}
					break;
					IL_020a:
					awaiter = Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway;
					num = 13;
					goto IL_0088;
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
		internal unsafe static byte _FF00砀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00最(object P_0)
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
		internal unsafe static object _FF00栀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Expected I4, but got Obj
			//IL_005a: Expected native int or pointer, but got Obj
			//IL_0340: Expected Obj, but got I4
			//IL_0077: Expected Obj, but got I4
			//IL_0118: Expected native int or pointer, but got Obj
			//IL_016c: Expected native int or pointer, but got Obj
			//IL_00eb: Expected native int or pointer, but got Obj
			//IL_0252: Expected Ref, but got VT
			//IL_0261: Expected native int or pointer, but got Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0354->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_035f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0122->IL00b2: Incompatible stack heights: 3 vs 1
			//IL_00f5->IL00b2: Incompatible stack heights: 2 vs 1
			//IL_012d->IL00b2: Incompatible stack heights: 3 vs 1
			//IL_0100->IL00b2: Incompatible stack heights: 2 vs 1
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
				case 0:
					return;
				case 1:
					((Func<Task>)/*Error near IL_0050: Stack underflow*/)._002Ector((object)/*Error near IL_0050: Stack underflow*/, (nint)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state));
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj2 = 0;
					}
					break;
				case 4:
					Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton = -2;
					obj2 = 0;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj2 = 1;
					}
					break;
				case 2:
				{
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this).listener.Dispose();
					obj = (object)/*Error near IL_00a4: Stack underflow*/;
					int num = 5;
					while (true)
					{
						switch (num)
						{
						case 1:
							break;
						case 5:
							obj = new IAsyncStateMachine();
							_ = 0;
							if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state != 0)
							{
								_ = 0;
							}
							continue;
						default:
							new AsyncTaskMethodBuilder(ref *(TAwaiter*)obj, ref *(TStateMachine*)obj);
							Authenticator._003CListenAsync_003Ed__7.DecorateExpandableParser();
							_ = 4;
							if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9.client)->_003C_003Eu__1 != 0)
							{
								_ = 4;
							}
							continue;
						case 2:
						{
							((Authenticator._003CReceiveAsync_003Ed__9*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.ReflectRandomReporter())->MoveNext();
							int num2 = 0;
							if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E4__this)->_003Cstream_003E5__2 != null)
							{
								num2 = 0;
							}
							switch (num2)
							{
							}
							goto case 4;
						}
						case 4:
						case 6:
							if (!((TaskAwaiter<string>*)((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003Et__builder)->IsCompleted)
							{
								num = 1;
								if ((int)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller._003CFeverRequest_003Ed__15<>.request)->_003C_003Eu__1 == 0)
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
					goto case 4;
				}
				case 3:
					obj = ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003E1__state;
					obj2 = 2;
					if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13._003C_003Et__builder)._003C_003E4__this != null)
					{
						obj2 = 2;
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
		internal unsafe static byte _FF00洀()
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
		private unsafe sealed void _FF00尀(object P_0)
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
		internal unsafe static object _FF00崀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0051: Expected Obj, but got I4
			//IL_0063: Expected VT, but got I4
			//IL_04ac: Expected native int or pointer, but got Obj
			//IL_0101: Expected native int or pointer, but got Obj
			//IL_03aa: Expected native int or pointer, but got Obj
			//IL_03d6: Expected Obj, but got VT
			//IL_00b4: Expected I4, but got Obj
			//IL_00bf: Expected Obj, but got VT
			//IL_0220: Expected Obj, but got VT
			//IL_0128: Expected native int or pointer, but got Obj
			//IL_01db: Expected Obj, but got Ref
			//IL_02ca: Expected VT, but got Obj
			//IL_02d3: Expected Obj, but got I4
			//IL_01c5: Expected Obj, but got Ref
			//IL_01ea: Expected Obj, but got I4
			//IL_01ef: Expected Obj, but got I4
			//IL_01f9: Expected native int or pointer, but got Obj
			//IL_028e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0231: Expected Obj, but got I4
			//IL_0236: Expected Obj, but got I4
			//IL_0236: Expected Obj, but got Ref
			//IL_017a: Expected I4, but got Obj
			//IL_005b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04dd->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04b6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04e8->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04c1->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03b4->IL0083: Incompatible stack heights: 2 vs 1
			//IL_03bf->IL0083: Incompatible stack heights: 2 vs 1
			//IL_022c->IL0141: Incompatible stack types: I4 vs Obj
			//IL_0132->IL0141: Incompatible stack heights: 1 vs 2
			//IL_017a->IL020e: Incompatible stack heights: 1 vs 0
			//IL_013d->IL0141: Incompatible stack heights: 1 vs 2
			//IL_01e5->IL0141: Incompatible stack heights: 1 vs 2
			//IL_01b3->IL0141: Incompatible stack types: I4 vs Obj
			//IL_01ca->IL022c: Incompatible stack heights: 0 vs 1
			//IL_0197->IL0141: Incompatible stack types: I4 vs Obj
			//IL_0203->IL0141: Incompatible stack types: I4 vs Obj
			//IL_029e->IL0141: Incompatible stack types: I4 vs Obj
			//IL_024a->IL0141: Incompatible stack types: I4 vs Obj
			//IL_01be->IL0141: Incompatible stack types: I4 vs Obj
			//IL_01d4->IL0141: Incompatible stack heights: 1 vs 2
			//IL_020e->IL0141: Incompatible stack types: I4 vs Obj
			//IL_0255->IL0141: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 2;
			object obj = awaiter;
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					awaiter = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
					obj = 5;
					break;
				case 3:
					((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-2);
					obj = 4;
					break;
				case 5:
					if (awaiter != null)
					{
						num = 6;
						goto IL_0083;
					}
					goto IL_00f6;
				case 4:
					((RestRequest)/*Error near IL_04a2: Stack underflow*/)._002Ector((string)/*Error near IL_04a2: Stack underflow*/, (Method)(ref ((_003CListenAsync_003Ed__34)this)._003C_003E1__state));
					obj = 0;
					if ((int)((_003CListenAsync_003Ed__34*)(nint)_003CListenAsync_003Ed__34._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj = 0;
					}
					break;
				case 2:
					{
						awaiter = _003CListenAsync_003Ed__34.DecorateIterableWriter;
						obj = 1;
						if ((int)((_003CListenControlConnectAsync_003Ed__35*)_003CListenControlConnectAsync_003Ed__35._003C_003E1__state)->_003C_003Et__builder == 0)
						{
							obj = 1;
						}
						break;
					}
					IL_0083:
					while (true)
					{
						object obj2;
						object obj3;
						switch (num)
						{
						case 6:
							((Authenticator)/*Error near IL_00b4: Stack underflow*/).StartListening((int)awaiter);
							((AsyncTaskMethodBuilder*)/*Error near IL_00c4: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<string>*)/*Error near IL_00c4: Stack underflow*/, ref *(Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)((Authenticator)/*Error near IL_00bf: Stack underflow*/).ListenAuthenticationConnectAsync((object)((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1));
							awaiter = (object)/*Error near IL_00c6: Stack underflow*/;
							num = 5;
							continue;
						case 5:
							if (awaiter == null)
							{
								num = 1;
								if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener != null)
								{
									num = 1;
								}
								continue;
							}
							goto case 3;
						case 4:
							goto IL_00f6;
						case 7:
							if (awaiter == null)
							{
								_ = 5;
								if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state == 0)
								{
									_ = 8;
								}
								goto IL_0141;
							}
							goto IL_020e;
						case 1:
							((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.ReflectRemoteFinder())->MoveNext();
							((AsyncTaskMethodBuilder<string>*)((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003E4__this)->Start(ref *(FeverInstaller._003CGetFeverManifestAsync_003Ed__12.SearchChain() ? ((JavaAuthenticator._003CHandleAuthentication_003Ed__9*)1) : ((JavaAuthenticator._003CHandleAuthentication_003Ed__9*)null)));
							_ = 0;
							if (((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CheckScalableWorker)->_003C_003E1__state != 0)
							{
								_ = 2;
							}
							continue;
						case 3:
							{
								FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CallGateway();
								((FeverInstaller._003CInstallAsync_003Ed__11*)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.DecorateGroupedVisitor())->SetStateMachine((IAsyncStateMachine)((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Eu__1);
								/*Error near IL_03d8: Member reference must be method, but was: Field*/;
							}
							IL_020e:
							obj2 = awaiter;
							awaiter = ((Encoding)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003Eu__1).GetBytes((string)(object)Encoding.UTF8);
							obj3 = 5;
							goto IL_0141;
							IL_0141:
							while (true)
							{
								switch ((int)obj3)
								{
								case 10:
									return;
								case 6:
									break;
								case 7:
									Unsafe.As<AsyncTaskMethodBuilder, AsyncTaskMethodBuilder<_00210>>(ref ((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003Et__builder).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<RestResponse<EntityFeverResponse<_00210>>>*)(&awaiter), ref Unsafe.As<_003CRemoteCallBackAsync_003Ed__21, FeverInstaller._003CFeverRequest_003Ed__15<_00210>>(ref this));
									obj3 = 10;
									continue;
								case 2:
								case 8:
									awaiter = ((Authenticator._003CReceiveAsync_003Ed__9)this).client;
									obj3 = 11;
									if (Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain == null)
									{
										obj3 = 8;
									}
									continue;
								case 5:
									((IAsyncStateMachine)obj2).SetStateMachine((IAsyncStateMachine)(&awaiter));
									if ((int)/*Error near IL_01ca: Stack underflow*/ != 0)
									{
										_ = 3;
										continue;
									}
									goto case 12;
								default:
									((AsyncTaskMethodBuilder*)obj2)->SetStateMachine((IAsyncStateMachine)(&awaiter));
									_ = 6;
									continue;
								case 9:
									awaiter = -1;
									((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this).client = (TcpClient)(-1);
									obj3 = 0;
									if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E4__this)->_003Cstream_003E5__2 == null)
									{
										obj3 = 0;
									}
									continue;
								case 4:
									goto IL_020e;
								case 12:
									awaiter = 0;
									((FeverInstaller)Unsafe.AsPointer(ref this))._003CappId_003EP = 0;
									obj3 = 0;
									if (FeverInstaller.McBedrock__BackingField == null)
									{
										obj3 = 1;
									}
									continue;
								case 11:
									((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003E1__state = (int)default(ConfigureSerialization);
									obj3 = 9;
									continue;
								case 1:
									((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003Eu__1 = (TaskAwaiter<RestResponse<EntityFeverResponse<T>>>)awaiter;
									awaiter = 7;
									obj3 = awaiter;
									continue;
								}
								break;
							}
							break;
						}
						break;
					}
					goto case 3;
					IL_00f6:
					num = 6;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						num = 7;
					}
					goto IL_0083;
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
		internal unsafe static byte _FF00搀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00匀(object P_0)
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
		private unsafe sealed void _FF00吀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778450, new IntPtr(2737337539804L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00唀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Expected I4, but got Obj
			//IL_0280: Expected Obj, but got I4
			//IL_0259: Expected Obj, but got I4
			//IL_014f: Expected native int or pointer, but got Obj
			//IL_0119: Expected Obj, but got VT
			//IL_016d: Expected Obj, but got I4
			//IL_00e2: Invalid comparison between Unknown and I4
			//IL_00f3: Expected native int or pointer, but got Obj
			//IL_00a3: Expected native int or pointer, but got Obj
			//IL_0294->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02b4->IL0026: Incompatible stack heights: 3 vs 1
			//IL_026d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_029f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0278->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01b5->IL005f: Incompatible stack heights: 3 vs 1
			//IL_00d3->IL005f: Incompatible stack heights: 4 vs 1
			//IL_012d->IL005f: Incompatible stack heights: 4 vs 1
			//IL_00fd->IL005f: Incompatible stack heights: 3 vs 1
			//IL_0138->IL005f: Incompatible stack heights: 4 vs 1
			//IL_0108->IL005f: Incompatible stack heights: 3 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				default:
					if (((Authenticator)obj).Listener == null)
					{
						num = 8;
						goto IL_005f;
					}
					goto IL_0138;
				case 3:
					goto IL_0251;
				case 1:
					obj = ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003E1__state;
					obj2 = 0;
					if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 0;
					}
					break;
				case 2:
					_ = ref ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this).info;
					AsyncTaskMethodBuilder<EntityFeverAppVersion>.Create();
					_ = 4;
					break;
				case 4:
					return;
					IL_0251:
					((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003E4__this = (FeverInstaller)(-2);
					obj2 = 2;
					if (FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor == null)
					{
						obj2 = 1;
					}
					break;
					IL_005f:
					while (true)
					{
						switch (num)
						{
						case 3:
							((Authenticator)/*Error near IL_0094: Stack underflow*/).Listener = (TcpListener?)obj;
							if ((int)/*Error near IL_0099: Stack underflow*/ != 0)
							{
								num = 0;
								if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
								{
									num = 0;
								}
								continue;
							}
							goto IL_0251;
						case 1:
							_ = 8;
							Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)null)->_003C_003Et__builder, (AsyncTaskMethodBuilder)new AsyncTaskMethodBuilder());
							_ = 2;
							continue;
						case 7:
						{
							object obj3 = obj;
							((Authenticator)obj).Dispose();
							((TcpListener)obj3).Dispose();
							_ = (int)/*Error near IL_00e4: Stack underflow*/ == 0;
							Authenticator.ReflectMonoObject();
							_ = 3;
							if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state != 0)
							{
								_ = 2;
							}
							continue;
						}
						case 4:
							_ = 8;
							Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)1)->client, (TcpClient)new TaskAwaiter());
							_ = 1;
							if (Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain == null)
							{
								_ = 0;
							}
							continue;
						case 6:
							break;
						case 5:
							((AsyncTaskMethodBuilder*)/*Error near IL_0174: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverAppVersion>*)((FeverInstaller)obj).FeverRequest<EntityFeverManifestInfo>((RestRequest)(object)16), ref *(FeverInstaller._003CInstallAsync_003Ed__11*)16);
							((AsyncTaskMethodBuilder*)/*Error near IL_017d: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverManifestInfo>*)obj, ref *(FeverInstaller._003CInstallAsync_003Ed__11*)16);
							((AsyncTaskMethodBuilder*)/*Error near IL_0182: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverManifest>*)/*Error near IL_0182: Stack underflow*/, ref *(FeverInstaller._003CInstallAsync_003Ed__11*)/*Error near IL_0182: Stack underflow*/);
							obj = ((IEnumerable<byte>)/*Error near IL_0187: Stack underflow*/).Concat((IEnumerable<byte>)/*Error near IL_0187: Stack underflow*/);
							num = 4;
							continue;
						default:
							((Task<string>)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.HandleNotifier()).GetAwaiter();
							obj = ((TaskAwaiter<string>*)FeverInstaller.McBedrock)->GetResult();
							_ = 5;
							continue;
						case 2:
						case 8:
							goto IL_0251;
						}
						break;
					}
					goto IL_0138;
					IL_0138:
					obj = ((RestResponse<EntityFeverManifest>)/*Error near IL_0143: Stack underflow*/).EnsureSuccessStatusCode<EntityFeverManifest>((string?)/*Error near IL_0143: Stack underflow*/, (byte)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003E1__state != 0);
					num = 7;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.client)->_003C_003E4__this == null)
					{
						num = 7;
					}
					goto IL_005f;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00夀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00娀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778448, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[CompilerGenerated]
	private readonly object Logger__BackingField;

	[CompilerGenerated]
	private nint NeedCha__BackingField;

	[CompilerGenerated]
	private nint UseCha__BackingField;

	[CompilerGenerated]
	private readonly Dictionary<ushort, Func<RpcCallBack, Task>> Callbacks__BackingField;

	[CompilerGenerated]
	private object? Writer__BackingField;

	[CompilerGenerated]
	private object? Listener__BackingField;

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
	protected unsafe Rpc(ILogger logger, bool needCha = false)
	{
		//IL_001a: Expected VT, but got Obj
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected VT, but got Unknown
		//IL_00c8: Expected native int or pointer, but got Obj
		//IL_00d7: Expected native int or pointer, but got Obj
		//IL_0073: Expected Obj, but got I4
		//IL_00bb->IL0052: Incompatible stack heights: 8 vs 2
		//IL_0087->IL0052: Incompatible stack heights: 3 vs 2
		//IL_00c6->IL0052: Incompatible stack heights: 8 vs 2
		//IL_0092->IL0052: Incompatible stack heights: 3 vs 2
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)/*Error near IL_001f: Stack underflow*/)->_003C_003Et__builder, (AsyncTaskMethodBuilder)new ILogger((string)/*Error near IL_001a: Stack underflow*/, (_0021_00210)this));
		Task.Run((Func<Task?>)(object)this);
		int num = 0;
		if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				((Authenticator)this).ReceiveAsync((object)needCha);
				_ = 1;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener == null)
				{
					_ = 1;
				}
				break;
			case 2:
				return;
			case 1:
				_ = 0;
				__ldvirtftn(Authenticator.HandleAuthentication);
				new IAsyncStateMachine();
				Authenticator.PatchUser();
				_ = 2;
				if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					_ = 2;
				}
				break;
			default:
				Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003E4__this, logger);
				num = 2;
				if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9.client)->_003C_003Eu__1 != 0)
				{
					num = 3;
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
	internal unsafe uint _FF00萀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00蔀()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0091->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0080->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b0->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00bb->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
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
				TcpListener? listener = ((Authenticator)this).Listener;
				if (listener == null)
				{
					obj2 = 0;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 0;
					}
					break;
				}
				_ = ((AsyncTaskMethodBuilder*)listener)->Task;
				_ = 2;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener != null)
				{
					_ = 1;
				}
				break;
			}
			case 4:
				((TcpListener)this).Start();
				obj2 = 3;
				break;
			default:
				((Authenticator)this).ListenAuthenticationConnectAsync((object)null);
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
	private unsafe Dictionary<ushort, Func<RpcCallBack, Task>> _FF00蜀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_001b: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Dictionary<ushort, Func<RpcCallBack, Task>>)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Dictionary<ushort, Func<RpcCallBack, Task>> _FF00蠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778558, new IntPtr(2737337549164L), 15))(null, 0, new IntPtr(0L));
		return (Dictionary<ushort, Func<RpcCallBack, Task>>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe object _FF00褀()
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
	private unsafe byte _FF00言()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778557, new IntPtr(2737337557484L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe byte _FF00謀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00谀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected I4, but got Obj
		//IL_003b: Expected native int or pointer, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
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
				((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)P_0;
				obj2 = 0;
				if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
				{
					obj2 = 0;
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
	internal unsafe static object _FF00踀()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00輀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778555, new IntPtr(2737337557484L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00鄀(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0057: Expected I4, but got Obj
		//IL_00dc: Expected Obj, but got I4
		//IL_0149: Expected VT, but got I4
		//IL_0165: Expected native int or pointer, but got Obj
		//IL_0064: Expected VT, but got Obj
		//IL_0071: Expected native int or pointer, but got Obj
		//IL_0085: Expected Obj, but got I4
		//IL_00f2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_016f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
		//IL_012c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b8->IL0026: Incompatible stack heights: 2 vs 1
		//IL_011a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d4->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0099->IL0026: Incompatible stack heights: 7 vs 1
		//IL_00fd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_017a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0141->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0190->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a4->IL0026: Incompatible stack heights: 7 vs 1
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
				((ILogger)/*Error near IL_0064: Stack underflow*/).Debug<_0021_00210>((string)P_0, (_0021_00210)obj);
				obj = (object)/*Error near IL_0066: Stack underflow*/;
				obj2 = 5;
				break;
			case 10:
				_ = ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Et__builder;
				_ = 0;
				_ = ((Array)obj).Length;
				Task.Run((Func<Task?>)0);
				_ = 0;
				if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
				{
					_ = 0;
				}
				break;
			case 4:
				obj = ((AsyncTaskMethodBuilder*)2)->Task;
				_ = 6;
				break;
			case 9:
				((Authenticator)new Authenticator(obj)).Dispose();
				_ = 7;
				break;
			default:
			{
				object obj3 = obj;
				((TcpListener)0).Dispose();
				obj = obj3;
				obj2 = 0;
				if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
				{
					obj2 = 1;
				}
				break;
			}
			case 7:
				return;
			case 6:
				((Authenticator._003CListenAsync_003Ed__7*)this)->MoveNext();
				((Authenticator._003CListenAsync_003Ed__7*)/*Error near IL_0109: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_0109: Stack underflow*/);
				((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_0110: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<RestResponse<EntityFeverResponse<_00210>>>*)/*Error near IL_0110: Stack underflow*/, ref *(FeverInstaller._003CFeverRequest_003Ed__15<_00210>*)obj);
				obj2 = 9;
				break;
			case 3:
				((ILogger)/*Error near IL_0120: Stack underflow*/).Error((Exception)/*Error near IL_0120: Stack underflow*/, (string)P_0);
				obj = (object)/*Error near IL_0122: Stack underflow*/;
				obj2 = 2;
				break;
			case 5:
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)this)->MoveNext();
				if ((int)/*Error near IL_0137: Stack underflow*/ != 0)
				{
					obj2 = 10;
					break;
				}
				goto default;
			case 1:
				((AsyncTaskMethodBuilder<EntityFeverManifest>*)/*Error near IL_0154: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<RestResponse<EntityFeverManifest>>*)RestClientExtensions.ExecuteAsync<EntityFeverManifest>((IRestClient)/*Error near IL_0149: Stack underflow*/, (RestRequest)obj, (CancellationToken)2), ref *(FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(((Array)obj).Length - 2));
				obj = ((RestResponse<EntityFeverManifest>)/*Error near IL_0159: Stack underflow*/).EnsureSuccessStatusCode<EntityFeverManifest>((string?)/*Error near IL_0159: Stack underflow*/, (byte)/*Error near IL_0159: Stack underflow*/ != 0);
				obj2 = 8;
				if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.client)->_003C_003E4__this == null)
				{
					obj2 = 8;
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
	internal unsafe byte _FF00销()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
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
	private unsafe object _FF00鸀()
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
	private unsafe void _FF00ꈀ(byte P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003b: Expected native int or pointer, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
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
				((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = P_0;
				obj2 = 0;
				if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj2 = 0;
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
	internal unsafe static byte _FF00ꔀ()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00ꘀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778538, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_A700(byte P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003a: Expected native int or pointer, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
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
				((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = P_0;
				obj2 = 0;
				if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
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
	internal unsafe void _FF00_AB00(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0089: Expected Obj, but got I4
		//IL_00aa: Expected native int or pointer, but got Obj
		//IL_008e->IL0022: Incompatible stack heights: 2 vs 0
		//IL_00e0->IL0026: Incompatible stack heights: 5 vs 1
		//IL_00b4->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00eb->IL0026: Incompatible stack heights: 5 vs 1
		//IL_00bf->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0075->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((Authenticator)/*Error near IL_0050: Stack underflow*/).Listener = ((Authenticator)this).Listener;
					((AsyncTaskMethodBuilder*)/*Error near IL_0056: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)/*Error near IL_0056: Stack underflow*/, ref *(Authenticator._003CListenAsync_003Ed__7*)P_0);
					obj2 = 2;
					if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
					{
						obj2 = 3;
					}
					continue;
				case 3:
					__ldftn(Authenticator.Dispose);
					((IAsyncStateMachine)new TcpListener()).MoveNext();
					_ = 2;
					if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state != 0)
					{
						_ = 2;
					}
					continue;
				case 1:
					new TaskAwaiter();
					Authenticator._003CListenAsync_003Ed__7.ObserveTracker();
					_ = 0;
					if (Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain != null)
					{
						_ = 0;
					}
					continue;
				}
				break;
			}
			((Authenticator)/*Error near IL_007b: Stack underflow*/).ReceiveAsync((object)this);
			AsyncTaskMethodBuilder.Create();
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
	internal unsafe void _FF00관(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_0054: Expected VT, but got Obj
		//IL_005d: Expected Obj, but got I4
		//IL_00b0: Expected native int or pointer, but got Obj
		//IL_00c4: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I4
		//IL_0084: Expected native int or pointer, but got Obj
		//IL_00ce->IL0026: Incompatible stack heights: 6 vs 1
		//IL_00da->IL0062: Incompatible stack heights: 1 vs 0
		//IL_00fe->IL0026: Incompatible stack heights: 2 vs 1
		//IL_008e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e4->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0109->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0099->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((ILogger)/*Error near IL_0054: Stack underflow*/).Debug<_0021_00210>((string)P_0, (_0021_00210)obj);
					obj = 5;
					break;
				case 6:
					((Func<Task>)/*Error near IL_006c: Stack underflow*/)._002Ector((object)/*Error near IL_006c: Stack underflow*/, (nint)(int)(ushort)((Array)obj).Length);
					((AsyncTaskMethodBuilder*)/*Error near IL_0073: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)/*Error near IL_0073: Stack underflow*/, ref *(Authenticator._003CListenAsync_003Ed__7*)obj);
					((AsyncTaskMethodBuilder*)/*Error near IL_0078: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<TcpClient>*)/*Error near IL_0078: Stack underflow*/, ref *(Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)/*Error near IL_0078: Stack underflow*/);
					obj = (object)/*Error near IL_007a: Stack underflow*/;
					obj2 = 1;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state != 0)
					{
						obj2 = 0;
					}
					continue;
				case 4:
					obj = ((Authenticator)/*Error near IL_009f: Stack underflow*/).ReceiveAuthenticationDataAsync(P_1);
					obj = 3;
					break;
				case 2:
					_ = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->listener;
					_ = 0;
					_ = ((Array)obj).Length;
					((TcpListener)0).Dispose();
					_ = 6;
					continue;
				case 0:
					return;
				case 3:
					if (Authenticator.ReflectMonoObject())
					{
						_ = 2;
						continue;
					}
					goto case 6;
				case 5:
					_ = ((TaskAwaiter*)P_0)->IsCompleted;
					_ = 0;
					if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						_ = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00글(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003b: Expected native int or pointer, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
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
				((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)P_0;
				obj2 = 0;
				if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj2 = 0;
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
	protected unsafe void _FF00넀(ushort P_0, Func<RpcCallBack, Task> P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_006d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0099->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0078->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a4->IL0026: Incompatible stack heights: 2 vs 1
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
			case 2:
				return;
			case 1:
				((Authenticator)this).Dispose();
				((TcpListener)(object)P_1).Dispose();
				_ = 0;
				if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
				{
					_ = 0;
				}
				continue;
			}
			((Authenticator)/*Error near IL_0048: Stack underflow*/).Listener = ((Authenticator)this).Listener;
			ushort num = P_0;
			((TcpListener)(object)Task.Run((Func<Task?>)(object)P_1)).Start();
			((AsyncTaskMethodBuilder*)/*Error near IL_0059: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)/*Error near IL_0059: Stack underflow*/, ref *(Authenticator._003CReceiveAsync_003Ed__9*)num);
			obj2 = 2;
			if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
			{
				obj2 = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00눀()
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
	protected unsafe void _FF00딀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected I4, but got Obj
		//IL_003b: Expected native int or pointer, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
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
				((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)P_0;
				obj2 = 0;
				if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}
}
