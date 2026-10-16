using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Mass.Application.Desktop;
using Mass.Common.Extensions;
using Mass.Domain.Desktop.Entities.LanGame;
using Mass.Domain.Desktop.Entities.Mods;
using Mass.Domain.Value;
using Mass.Game.Launcher.Entities.Fever;
using Mass.Game.Launcher.Java.Option;
using Mass.Game.Launcher.Paths;
using Mass.Game.Launcher.Values;
using RestSharp;
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_A700(object P_0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00ꨀ()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_AB00()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0307: Expected native int or pointer, but got Obj
			//IL_02d3: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I4
			//IL_02bd: Expected Obj, but got VT
			//IL_02c6: Expected Obj, but got I4
			//IL_0130: Expected Obj, but got I4
			//IL_01ac: Expected Obj, but got I4
			//IL_01b1: Expected Obj, but got I4
			//IL_01bb: Expected native int or pointer, but got Obj
			//IL_0212: Expected Obj, but got Ref
			//IL_00e5: Expected Obj, but got VT
			//IL_00e7: Expected Obj, but got I4
			//IL_00f0: Expected Obj, but got I4
			//IL_0155: Expected native int or pointer, but got Obj
			//IL_00d0: Expected I4, but got Obj
			//IL_0311->IL0026: Incompatible stack heights: 3 vs 1
			//IL_02e7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_031c->IL0026: Incompatible stack heights: 3 vs 1
			//IL_02f2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01a7->IL009b: Incompatible stack types: I4 vs Obj
			//IL_008c->IL009b: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0097->IL009b: Incompatible stack types: I4 vs Obj
			//IL_013f->IL009b: Incompatible stack types: I4 vs Obj
			//IL_0111->IL009b: Incompatible stack types: I4 vs Obj
			//IL_01c5->IL009b: Incompatible stack types: I4 vs Obj
			//IL_0201->IL009b: Incompatible stack types: I4 vs Obj
			//IL_0224->IL009b: Incompatible stack heights: 2 vs 1
			//IL_018a->IL009b: Incompatible stack types: I4 vs Obj
			//IL_01e3->IL009b: Incompatible stack heights: 2 vs 1
			//IL_011c->IL009b: Incompatible stack types: I4 vs Obj
			//IL_01d0->IL009b: Incompatible stack types: I4 vs Obj
			//IL_020c->IL009b: Incompatible stack types: I4 vs Obj
			//IL_015f->IL009b: Incompatible stack types: I4 vs Obj
			//IL_0195->IL009b: Incompatible stack types: I4 vs Obj
			//IL_016a->IL009b: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object stateMachine = 5;
			while (true)
			{
				object obj = stateMachine;
				while (true)
				{
					object obj2;
					switch ((int)obj)
					{
					case 4:
						stateMachine = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
						obj = 0;
						if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
						{
							obj = 3;
						}
						continue;
					case 1:
						return;
					case 3:
						if (stateMachine != null)
						{
							obj2 = 10;
							if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
							{
								obj2 = 7;
							}
							goto IL_009b;
						}
						goto IL_0195;
					case 5:
						break;
					case 2:
						goto IL_02cb;
					default:
						{
							_ = ref ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003E1__state;
							AsyncTaskMethodBuilder<EntityFeverManifestInfo>.Create();
							_ = 1;
							if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E4__this)->info != null)
							{
								_ = 1;
							}
							continue;
						}
						IL_009b:
						while (true)
						{
							switch ((int)obj2)
							{
							case 8:
								return;
							case 10:
							{
								int num = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003E1__state;
								GC.SuppressFinalize(AsyncTaskMethodBuilder.Create());
								stateMachine = num;
								stateMachine = 6;
								obj2 = stateMachine;
								continue;
							}
							case 1:
								((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003E4__this = (Authenticator)stateMachine;
								obj2 = 7;
								if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
								{
									obj2 = 1;
								}
								continue;
							default:
								stateMachine = -1;
								((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003E1__state = -1;
								obj2 = 11;
								continue;
							case 6:
								((AsyncTaskMethodBuilder*)/*Error near IL_0146: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_0146: Stack underflow*/, ref *(TStateMachine*)(&stateMachine));
								if ((int)/*Error near IL_014b: Stack underflow*/ == 0)
								{
									obj2 = 1;
									if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9._003C_003E4__this)->client != null)
									{
										obj2 = 2;
									}
									continue;
								}
								goto case 11;
							case 9:
								Unsafe.As<TaskAwaiter, @null>(ref ((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003Eu__1) = null;
								obj2 = 0;
								if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E1__state)->_003C_003Et__builder != 0)
								{
									obj2 = 0;
								}
								continue;
							case 4:
								break;
							case 2:
								stateMachine = 0;
								((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003E4__this = (Authenticator)0;
								obj2 = 0;
								if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003Cstream_003E5__2)->_003C_003Eu__1 == 0)
								{
									obj2 = 1;
								}
								continue;
							case 11:
								_ = ref stateMachine;
								stateMachine = Encoding.UTF8;
								_ = 3;
								continue;
							case 3:
								((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)stateMachine)->SetStateMachine((IAsyncStateMachine)stateMachine);
								obj2 = 5;
								if (((FeverInstaller)FeverInstaller._003CappId_003EP)._003CappVersion_003EP != null)
								{
									obj2 = 4;
								}
								continue;
							case 7:
								_ = ref FeverInstaller.McBedrock__BackingField;
								((AsyncTaskMethodBuilder*)(&stateMachine))->Start(ref Unsafe.As<_003CAcceptLoopAsync_003Ed__8, Rpc._003CRemoteCallBackAsync_003Ed__21>(ref this));
								_ = 8;
								continue;
							case 5:
								goto IL_02cb;
							}
							break;
						}
						goto IL_0195;
						IL_02cb:
						((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003E4__this = (FeverInstaller)(-2);
						obj = 0;
						if (FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor != null)
						{
							obj = 0;
						}
						continue;
						IL_0195:
						stateMachine = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this).client;
						obj2 = 9;
						goto IL_009b;
					}
					break;
				}
				stateMachine = ((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003Et__builder;
				stateMachine = 4;
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00관()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00鼀(object P_0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00ꀀ()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_041e: Expected Obj, but got I4
			//IL_03d9: Expected native int or pointer, but got Obj
			//IL_02f8: Expected native int or pointer, but got Obj
			//IL_006f: Expected native int or pointer, but got Obj
			//IL_030b: Expected Obj, but got I4
			//IL_009d: Expected I4, but got Obj
			//IL_011c: Expected native int or pointer, but got Obj
			//IL_01e8: Expected Obj, but got I4
			//IL_01ed: Expected Obj, but got I4
			//IL_01f7: Expected native int or pointer, but got Obj
			//IL_015d: Expected Obj, but got I4
			//IL_0428->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03e3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_040a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03ee->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0415->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0079->IL0088: Incompatible stack types: I4 vs Obj
			//IL_02f6->IL0088: Incompatible stack types: I4 vs Obj
			//IL_0084->IL0088: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 2;
			object obj = awaiter;
			while (true)
			{
				object obj2;
				int num;
				switch ((int)obj)
				{
				case 5:
					((Func<Task>)/*Error near IL_0053: Stack underflow*/)._002Ector((object)/*Error near IL_0053: Stack underflow*/, (nint)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state));
					obj = 4;
					continue;
				case 3:
					if (awaiter == null)
					{
						obj2 = 1;
						if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
						{
							obj2 = 0;
						}
						goto IL_0088;
					}
					goto IL_02f6;
				case 1:
					awaiter = ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003E4__this;
					obj = 3;
					if ((int)((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.version)->_003C_003Eu__1 != 0)
					{
						obj = 3;
					}
					continue;
				case 2:
					awaiter = FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CheckScalableWorker;
					obj = 0;
					if ((int)((FeverInstaller._003CInstallAsync_003Ed__11*)FeverInstaller._003CInstallAsync_003Ed__11._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj = 1;
					}
					continue;
				case 4:
					return;
					IL_02f6:
					if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)awaiter)->_003C_003Et__builder == 0)
					{
						awaiter = 3;
						obj2 = awaiter;
						goto IL_0088;
					}
					goto IL_02eb;
					IL_02eb:
					obj2 = 2;
					goto IL_0088;
					IL_0088:
					switch ((int)obj2)
					{
					case 2:
						if (awaiter == null)
						{
							num = 5;
							goto IL_00b8;
						}
						goto IL_0118;
					case 1:
						break;
					default:
						goto IL_02f6;
					case 3:
						goto end_IL_0026;
						IL_00b8:
						while (true)
						{
							switch (num)
							{
							case 2:
								((AsyncTaskMethodBuilder*)/*Error near IL_00f9: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)(&awaiter));
								num = 0;
								if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
								{
									num = 0;
								}
								continue;
							case 9:
								break;
							case 1:
							case 5:
								awaiter = Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler;
								num = 3;
								continue;
							case 8:
								awaiter = 0;
								((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003E1__state = 0;
								num = 11;
								continue;
							case 10:
								((AsyncTaskMethodBuilder*)/*Error near IL_0173: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_0173: Stack underflow*/, ref *(TStateMachine*)(&awaiter));
								if ((int)/*Error near IL_0178: Stack underflow*/ == 0)
								{
									num = 8;
									continue;
								}
								goto case 2;
							case 6:
								return;
							case 3:
								Unsafe.As<TaskAwaiter, bool>(ref ((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003Eu__1) = default;
								num = 7;
								if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E1__state)->_003C_003Et__builder == 0)
								{
									num = 7;
								}
								continue;
							case 11:
								((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this).client = (TcpClient)awaiter;
								num = 4;
								continue;
							case 7:
								awaiter = -1;
								((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003E4__this = (Authenticator)(-1);
								num = 2;
								if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003Cstream_003E5__2)->_003C_003Eu__1 == 0)
								{
									num = 2;
								}
								continue;
							case 4:
								Unsafe.As<object, AsyncTaskMethodBuilder>(ref Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverManifest>*)(&awaiter), ref Unsafe.As<_003CListenAsync_003Ed__7, FeverInstaller._003CInstallAsync_003Ed__11>(ref this));
								num = 6;
								continue;
							default:
								goto IL_02f6;
							}
							break;
						}
						goto IL_0118;
						IL_0118:
						((IAsyncStateMachine)((Authenticator)awaiter).HandleAuthentication((string)(object)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)awaiter)->listener)).MoveNext();
						awaiter = (object)/*Error near IL_012d: Stack underflow*/;
						num = 10;
						goto IL_00b8;
					}
					goto IL_02eb;
					end_IL_0026:
					break;
				}
				((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003E4__this = (FeverInstaller)(-2);
				obj = 5;
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00ꔀ()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00销(object P_0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00阀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_00a3: Expected VT, but got I4
			//IL_00ad: Expected native int or pointer, but got Obj
			//IL_00c9: Expected VT, but got Obj
			//IL_0054: Expected Obj, but got I4
			//IL_0091: Expected Obj, but got I4
			//IL_0069: Expected Obj, but got Ref
			//IL_00e6: Expected native int or pointer, but got Obj
			//IL_0118: Expected native int or pointer, but got Obj
			//IL_011f: Expected native int or pointer, but got Obj
			//IL_0129: Expected native int or pointer, but got Obj
			//IL_0138: Expected native int or pointer, but got Obj
			//IL_017e: Expected Obj, but got I4
			//IL_03e9: Expected native int or pointer, but got Obj
			//IL_01a4: Expected I4, but got Obj
			//IL_01bb: Expected native int or pointer, but got Obj
			//IL_066b: Expected native int or pointer, but got Obj
			//IL_047b: Expected Obj, but got I4
			//IL_0480: Expected Obj, but got Ref
			//IL_05aa: Expected Obj, but got Ref
			//IL_05aa: Expected Obj, but got Ref
			//IL_05aa: Expected Obj, but got Ref
			//IL_05b4: Expected native int or pointer, but got Obj
			//IL_051d: Expected Obj, but got Ref
			//IL_04a4: Expected Obj, but got I4
			//IL_04a9: Expected Obj, but got Ref
			//IL_04b2: Expected Obj, but got I4
			//IL_04e5: Expected Obj, but got Ref
			//IL_04eb: Expected Obj, but got Ref
			//IL_04f7: Expected Obj, but got I4
			//IL_024b: Expected Obj, but got I4
			//IL_0250: Expected Obj, but got I4
			//IL_0250: Expected Obj, but got Ref
			//IL_0275: Expected Obj, but got Ref
			//IL_02a9: Expected VT, but got Obj
			//IL_0291: Unknown result type (might be due to invalid IL or missing references)
			//IL_0306: Expected Obj, but got I4
			//IL_045f: Expected I4, but got Obj
			//IL_00b7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_007d->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00c2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0088->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0142->IL00ff: Incompatible stack heights: 3 vs 1
			//IL_03d3->IL0187: Incompatible stack types: I4 vs Obj
			//IL_014d->IL00ff: Incompatible stack heights: 3 vs 1
			//IL_03de->IL0187: Incompatible stack types: I4 vs Obj
			//IL_03f3->IL0187: Incompatible stack types: I4 vs Obj
			//IL_053e->IL042a: Incompatible stack types: I4 vs Obj
			//IL_041b->IL042a: Incompatible stack types: I4 vs Obj
			//IL_0675->IL0187: Incompatible stack types: I4 vs Obj
			//IL_03fe->IL0187: Incompatible stack types: I4 vs Obj
			//IL_0426->IL042a: Incompatible stack types: I4 vs Obj
			//IL_0680->IL0187: Incompatible stack types: I4 vs Obj
			//IL_0494->IL042a: Incompatible stack types: I4 vs Obj
			//IL_05be->IL042a: Incompatible stack types: I4 vs Obj
			//IL_04d2->IL042a: Incompatible stack heights: 2 vs 1
			//IL_0476->IL042a: Incompatible stack types: I4 vs Obj
			//IL_050b->IL042a: Incompatible stack types: I4 vs Obj
			//IL_0582->IL042a: Incompatible stack types: I4 vs Obj
			//IL_021b->IL01d4: Incompatible stack heights: 2 vs 1
			//IL_0227->IL020a: Incompatible stack heights: 1 vs 0
			//IL_049f->IL042a: Incompatible stack types: I4 vs Obj
			//IL_05c9->IL042a: Incompatible stack types: I4 vs Obj
			//IL_04dd->IL042a: Incompatible stack heights: 2 vs 1
			//IL_052c->IL042a: Incompatible stack types: I4 vs Obj
			//IL_0516->IL042a: Incompatible stack types: I4 vs Obj
			//IL_058d->IL042a: Incompatible stack types: I4 vs Obj
			//IL_023b->IL01d4: Incompatible stack heights: 2 vs 1
			//IL_0246->IL01d4: Incompatible stack heights: 2 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 4;
			object obj = awaiter;
			while (true)
			{
				int num;
				object obj2;
				switch ((int)obj)
				{
				case 3:
					awaiter = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
					obj = 6;
					break;
				case 5:
					Task.Run((Func<Task?>)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Et__builder));
					_ = 2;
					if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
					{
						_ = 2;
					}
					break;
				case 2:
					return;
				case 4:
					awaiter = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003E1__state;
					obj = 3;
					break;
				default:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-2);
					obj = 1;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
					{
						obj = 1;
					}
					break;
				case 1:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Eu__1 = (TaskAwaiter<TcpClient>)null;
					obj = 5;
					break;
				case 6:
					{
						if ((nuint)(nint)awaiter > (nuint)1u)
						{
							num = 1;
							if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state != 0)
							{
								num = 2;
							}
							goto IL_00ff;
						}
						goto IL_014d;
					}
					IL_014d:
					num = 0;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Et__builder).client == null)
					{
						num = 0;
					}
					goto IL_00ff;
					IL_00ff:
					while (true)
					{
						switch (num)
						{
						case 2:
							_ = ((Authenticator._003CReceiveAsync_003Ed__9*)(nint)awaiter)->_003C_003Et__builder;
							Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)(nint)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)awaiter)->_003C_003E4__this)->_003C_003Eu__1, (TaskAwaiter)new Authenticator._003CListenAsync_003Ed__7());
							_ = 1;
							if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain)->_003C_003E1__state != 0)
							{
								_ = 0;
							}
							continue;
						case 1:
							break;
						default:
							goto IL_016d;
						}
						break;
					}
					goto IL_014d;
					IL_016d:
					if (awaiter != null)
					{
						awaiter = 3;
						obj2 = awaiter;
						goto IL_0187;
					}
					goto IL_03be;
					IL_03be:
					obj2 = 1;
					if ((int)((FeverInstaller._003CInstallAsync_003Ed__11*)FeverInstaller._003CInstallAsync_003Ed__11._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj2 = 2;
					}
					goto IL_0187;
					IL_0187:
					while (true)
					{
						int num2;
						object obj3;
						switch ((int)obj2)
						{
						case 1:
							break;
						case 2:
							if (awaiter != null)
							{
								num2 = 3;
								if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E4__this)->_003Cstream_003E5__2 != null)
								{
									num2 = 0;
								}
								goto IL_01d4;
							}
							goto IL_02cb;
						case 4:
							goto IL_03be;
						case 5:
							goto IL_03de;
						default:
							if ((nint)awaiter != 1)
							{
								obj3 = 2;
								if ((int)((FeverInstaller._003CInstallAsync_003Ed__11)FeverInstaller._003CInstallAsync_003Ed__11._003C_003Eu__2)._003C_003Eu__3 == 0)
								{
									obj3 = 10;
								}
								goto IL_042a;
							}
							goto IL_052c;
						case 3:
							{
								if ((nint)awaiter != 1)
								{
									obj2 = 2;
									if ((object)((Rpc._003CSyncChaChaAsync_003Ed__38*)(nint)Rpc._003CSyncChaChaAsync_003Ed__38._003C_003E4__this)->callBack == null)
									{
										obj2 = 4;
									}
									continue;
								}
								goto IL_03de;
							}
							IL_01d4:
							while (true)
							{
								switch (num2)
								{
								case 6:
									return;
								case 1:
									((TaskAwaiter<TcpClient>*)(&awaiter))->GetResult();
									_ = 4;
									continue;
								case 10:
									_ = ref awaiter;
									if (Encoding.UTF8 == null)
									{
										_ = 0;
										if (((FeverInstaller)FeverInstaller._003CfeverVersion_003EP)._003CappId_003EP != null)
										{
											_ = 0;
										}
										continue;
									}
									goto case 1;
								default:
									awaiter = 0;
									((FeverInstaller)Unsafe.AsPointer(ref this))._003CappVersion_003EP = 0;
									num2 = 4;
									if (((FeverInstaller)FeverInstaller.McBedrock__BackingField).Client__BackingField == null)
									{
										num2 = 7;
									}
									continue;
								case 3:
									((FeverInstaller)FeverInstaller.ReflectVisualArgument).Dispose();
									((Stream)/*Error near IL_027f: Stack underflow*/).Write((byte[])/*Error near IL_027f: Stack underflow*/, (int)/*Error near IL_027f: Stack underflow*/, (int)/*Error near IL_027f: Stack underflow*/);
									awaiter = (object)/*Error near IL_0281: Stack underflow*/;
									num2 = 10;
									continue;
								case 8:
									((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003E4__this = (FeverInstaller)default(RestRequest);
									num2 = 9;
									continue;
								case 7:
									((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003Eu__1 = (TaskAwaiter<RestResponse<EntityFeverResponse<T>>>)awaiter;
									num2 = 2;
									continue;
								case 2:
									Unsafe.As<int, AsyncTaskMethodBuilder>(ref ((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003E1__state).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CReceiveAsync_003Ed__9, Rpc._003CListenAsync_003Ed__34>(ref this));
									num2 = 6;
									continue;
								case 5:
									break;
								case 9:
									awaiter = -1;
									((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003E1__state = -1;
									num2 = 1;
									if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003Et__builder)._003C_003E4__this != null)
									{
										num2 = 0;
									}
									continue;
								case 4:
									goto IL_03de;
								}
								break;
							}
							goto IL_02cb;
							IL_03de:
							obj2 = 0;
							if ((int)((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)FeverInstaller._003CInstallAsync_003Ed__11._003C_003E4__this)->_003C_003Eu__1 == 0)
							{
								obj2 = 0;
							}
							continue;
							IL_02cb:
							awaiter = ((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003E4__this;
							num2 = 8;
							goto IL_01d4;
							IL_052c:
							awaiter = Rpc._003CListenAsync_003Ed__34.DecorateIterableWriter;
							obj3 = 11;
							goto IL_042a;
							IL_042a:
							while (true)
							{
								switch ((int)obj3)
								{
								case 7:
									return;
								case 1:
									break;
								case 8:
									FeverInstaller._003CInstallAsync_003Ed__11.ReflectAccessibleWatcher = awaiter;
									obj3 = 2;
									continue;
								default:
									awaiter = -1;
									((Rpc)Unsafe.AsPointer(ref this)).ProcessId__BackingField = -1;
									obj3 = 3;
									if (((Rpc)Rpc.Logger__BackingField).NeedCha__BackingField != 0)
									{
										obj3 = 3;
									}
									continue;
								case 6:
									awaiter = 1;
									((Rpc)Unsafe.AsPointer(ref this)).UseCha__BackingField = 1;
									awaiter = 8;
									obj3 = awaiter;
									continue;
								case 3:
								case 5:
									((TaskAwaiter<RestResponse<EntityFeverResponse<_00210>>>*)(&awaiter))->GetResult();
									_ = 0;
									if (((Rpc)Rpc.Writer__BackingField).Listener__BackingField != null)
									{
										_ = 1;
									}
									continue;
								case 10:
									((Rpc)awaiter).SendMessage((BinaryWriter)((Rpc)Unsafe.AsPointer(ref this))._chaChaEn, (object[])((Rpc)Unsafe.AsPointer(ref this))._chaChaDe);
									awaiter = ((TaskAwaiter<EntityFeverApp>*)/*Error near IL_04f5: Stack underflow*/)->IsCompleted;
									obj3 = 0;
									if (((Rpc._003CListenAsync_003Ed__34)Rpc._003CListenAsync_003Ed__34._003C_003Et__builder)._003C_003E4__this == null)
									{
										obj3 = 4;
									}
									continue;
								case 4:
									if ((int)((Task<EntityFeverApp>)(&awaiter)).GetAwaiter() != 0)
									{
										obj3 = 5;
										continue;
									}
									goto case 6;
								case 9:
									goto IL_052c;
								case 11:
									((Rpc._003CListenControlConnectAsync_003Ed__35)this).listener = null;
									obj3 = 0;
									if (Rpc._003CListenControlConnectAsync_003Ed__35.ReflectSymbolicDecorator == null)
									{
										obj3 = 0;
									}
									continue;
								case 2:
									((ILogger)/*Error near IL_05aa: Stack underflow*/).Debug<string, string>((string)Unsafe.AsPointer(ref ((Rpc._003CReceiveAsync_003Ed__28)this)._003C_003E1__state), (string)(&awaiter), (string)Unsafe.AsPointer(ref this));
									obj3 = 5;
									if (((Rpc._003CReceiveAsync_003Ed__28*)(nint)Rpc._003CReceiveAsync_003Ed__28.client)->_003C_003E4__this != null)
									{
										obj3 = 7;
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00鰀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00贀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00踀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777571, new IntPtr(2737367885964L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00輀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Expected I4, but got Obj
			//IL_004c: Expected Obj, but got I4
			//IL_0c92: Expected Obj, but got I4
			//IL_0c92: Expected Obj, but got Ref
			//IL_00a8: Expected native int or pointer, but got Obj
			//IL_01ed: Expected native int or pointer, but got Obj
			//IL_09d0: Expected Obj, but got Ref
			//IL_0b35: Expected Obj, but got I4
			//IL_0b35: Expected Obj, but got Ref
			//IL_0bb9: Expected Obj, but got Ref
			//IL_0bbf: Expected Obj, but got Ref
			//IL_0b6b: Expected Obj, but got I4
			//IL_0b70: Expected Obj, but got I4
			//IL_0b70: Expected Obj, but got Ref
			//IL_0b0f: Expected Obj, but got Ref
			//IL_0a0a: Expected Obj, but got Ref
			//IL_0a12: Expected Obj, but got Ref
			//IL_0a12: Expected Obj, but got Ref
			//IL_01a6: Expected VT, but got Obj
			//IL_0b5c: Expected Obj, but got Ref
			//IL_09fa: Expected Obj, but got Ref
			//IL_0a21: Expected Obj, but got I4
			//IL_0a26: Expected Obj, but got I4
			//IL_0a26: Expected Obj, but got Ref
			//IL_0ab8: Expected Obj, but got Ref
			//IL_0a90: Expected Obj, but got Ref
			//IL_0a7e: Expected Obj, but got Ref
			//IL_018a: Expected native int or pointer, but got Obj
			//IL_0910: Expected Obj, but got Ref
			//IL_0917: Expected Obj, but got I4
			//IL_091c: Expected Obj, but got I4
			//IL_08eb: Expected Obj, but got I4
			//IL_08eb: Expected Obj, but got Ref
			//IL_08fa: Expected Obj, but got I4
			//IL_02cb: Expected Obj, but got Ref
			//IL_02e1: Expected Obj, but got VT
			//IL_02e1: Expected Obj, but got I
			//IL_0401: Expected Obj, but got VT
			//IL_040a: Expected Obj, but got I4
			//IL_03b5: Expected I4, but got Obj
			//IL_04f9: Expected native int or pointer, but got Obj
			//IL_05f8: Expected Obj, but got I4
			//IL_0728: Expected native int or pointer, but got Obj
			//IL_0429: Expected Obj, but got I4
			//IL_0433: Expected Obj, but got I4
			//IL_0438: Expected VT, but got I4
			//IL_0442: Expected native int or pointer, but got Obj
			//IL_03bf: Expected Obj, but got I4
			//IL_03c4: Expected VT, but got I4
			//IL_03cd: Expected Obj, but got I4
			//IL_04c2: Expected Obj, but got I4
			//IL_04c7: Expected Obj, but got I4
			//IL_0549: Expected Obj, but got Ref
			//IL_054e: Expected Obj, but got I
			//IL_05a0: Expected Obj, but got Ref
			//IL_05a7: Expected I4, but got Obj
			//IL_045f: Expected Obj, but got VT
			//IL_0469: Expected native int or pointer, but got Obj
			//IL_06c3: Expected Obj, but got Ref
			//IL_06c3: Expected Obj, but got Ref
			//IL_03d7: Expected Obj, but got I4
			//IL_03dc: Expected Obj, but got I4
			//IL_06ea: Expected I4, but got Obj
			//IL_060e: Expected Obj, but got Ref
			//IL_0610: Expected Obj, but got VT
			//IL_0564: Expected VT, but got Ref
			//IL_0564: Expected Obj, but got I4
			//IL_06fd: Expected Obj, but got I4
			//IL_062c: Expected Obj, but got I4
			//IL_0524: Expected VT, but got Ref
			//IL_0578: Expected Obj, but got I
			//IL_008a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0060->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0ca6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0095->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0cb1->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0a1c->IL00c1: Incompatible stack heights: 3 vs 1
			//IL_024a->IL0259: Incompatible stack heights: 1 vs 2
			//IL_0bf7->IL00c1: Incompatible stack heights: 2 vs 1
			//IL_0276->IL090a: Incompatible stack heights: 1 vs 0
			//IL_0255->IL0259: Incompatible stack heights: 1 vs 2
			//IL_0298->IL02a7: Incompatible stack heights: 2 vs 5
			//IL_02c0->IL02c5: Incompatible stack heights: 4 vs 1
			//IL_02a3->IL02a7: Incompatible stack heights: 2 vs 5
			//IL_0820->IL08e4: Incompatible stack heights: 0 vs 1
			//IL_0321->IL0330: Incompatible stack types: I4 vs Obj
			//IL_032c->IL0330: Incompatible stack types: I4 vs Obj
			//IL_0503->IL0330: Incompatible stack types: I4 vs Obj
			//IL_05fd->IL03d2: Incompatible stack heights: 1 vs 4
			//IL_0732->IL0330: Incompatible stack types: I4 vs Obj
			//IL_0742->IL081b: Incompatible stack heights: 0 vs 4
			//IL_042e->IL032c: Incompatible stack heights: 10 vs 4
			//IL_044c->IL0330: Incompatible stack types: I4 vs Obj
			//IL_04bd->IL0330: Incompatible stack types: I4 vs Obj
			//IL_04d1->IL0330: Incompatible stack types: I4 vs Obj
			//IL_05c2->IL0330: Incompatible stack heights: 2 vs 5
			//IL_0473->IL0330: Incompatible stack types: I4 vs Obj
			//IL_06aa->IL0330: Incompatible stack types: I4 vs Obj
			//IL_06d7->IL0330: Incompatible stack heights: 6 vs 5
			//IL_066c->IL0330: Incompatible stack heights: 7 vs 5
			//IL_03e6->IL0330: Incompatible stack types: I4 vs Obj
			//IL_0498->IL0330: Incompatible stack types: I4 vs Obj
			//IL_06f4->IL0330: Incompatible stack types: I4 vs Obj
			//IL_061a->IL0330: Incompatible stack types: I4 vs Obj
			//IL_068f->IL0330: Incompatible stack heights: 6 vs 5
			//IL_0569->IL06f4: Incompatible stack heights: 2 vs 4
			//IL_0707->IL0330: Incompatible stack types: I4 vs Obj
			//IL_0538->IL0330: Incompatible stack heights: 4 vs 5
			//IL_050e->IL0330: Incompatible stack types: I4 vs Obj
			//IL_0607->IL0330: Incompatible stack heights: 2 vs 5
			//IL_073d->IL0330: Incompatible stack types: I4 vs Obj
			//IL_0457->IL0330: Incompatible stack types: I4 vs Obj
			//IL_04e3->IL0330: Incompatible stack types: I4 vs Obj
			//IL_055d->IL0330: Incompatible stack types: I4 vs Obj
			//IL_05cd->IL0330: Incompatible stack heights: 2 vs 5
			//IL_047e->IL0330: Incompatible stack types: I4 vs Obj
			//IL_06b5->IL0330: Incompatible stack types: I4 vs Obj
			//IL_06e2->IL0330: Incompatible stack heights: 6 vs 5
			//IL_0677->IL0330: Incompatible stack heights: 7 vs 5
			//IL_059a->IL0330: Incompatible stack types: I4 vs Obj
			//IL_057d->IL0330: Incompatible stack heights: 3 vs 5
			//IL_0543->IL0330: Incompatible stack heights: 4 vs 5
			//IL_0588->IL0330: Incompatible stack heights: 3 vs 5
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 2:
					obj = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
					obj2 = 1;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 1;
					}
					continue;
				default:
					((AsyncTaskMethodBuilder*)/*Error near IL_0076: Stack underflow*/)->Start<TStateMachine>(ref Unsafe.As<TaskAwaiter, TStateMachine>(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1));
					obj2 = 3;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj2 = 3;
					}
					continue;
				case 1:
					if ((nuint)(nint)obj <= (nuint)1u)
					{
						num = 2;
						if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
						{
							num = 27;
						}
						goto IL_00c1;
					}
					goto IL_0a45;
				case 3:
					return;
				case 4:
					break;
					IL_00c1:
					while (true)
					{
						int num2;
						switch (num)
						{
						case 30:
							return;
						case 28:
							Unsafe.As<TaskAwaiter<TcpClient>, @null>(ref ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Eu__1) = null;
							num = 10;
							continue;
						case 6:
							if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								num = 26;
								if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9._003C_003E4__this)->client == null)
								{
									num = 5;
								}
								continue;
							}
							goto case 4;
						case 17:
							((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003Eu__1 = (TaskAwaiter)null;
							num = 7;
							continue;
						case 13:
							((AsyncTaskMethodBuilder*)(&obj))->SetResult();
							if ((int)/*Error near IL_01bc: Stack underflow*/ != 0)
							{
								num = 12;
								if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E1__state)->_003C_003Et__builder != 0)
								{
									num = 3;
								}
								continue;
							}
							goto case 23;
						case 3:
							break;
						case 4:
							obj = ((Encoding)/*Error near IL_0221: Stack underflow*/).GetBytes((string)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway);
							num = 25;
							continue;
						case 9:
							if ((nuint)(nint)obj <= (nuint)1u)
							{
								_ = 4;
								if (((FeverInstaller)FeverInstaller._003CappId_003EP)._003CappVersion_003EP == null)
								{
									_ = 4;
								}
								goto IL_0259;
							}
							goto IL_090a;
						case 2:
							if (obj == null)
							{
								num = 16;
								continue;
							}
							goto IL_0bd3;
						case 11:
						case 27:
							num = 9;
							continue;
						case 1:
						case 12:
							ConfigValue.InitValue((object?)(&obj));
							num = 31;
							if (CppGamePath.CheckDetachedBridge == null)
							{
								num = 13;
							}
							continue;
						case 21:
							((GamePath)Unsafe.AsPointer(ref this)).Resources = (string)(object)new JavaGameValue();
							num = 8;
							continue;
						case 15:
							_ = ref ((GamePath)Unsafe.AsPointer(ref this)).Data;
							((JavaGameOption)(&obj)).GetArray<string>((string)Unsafe.AsPointer(ref this));
							_ = 30;
							continue;
						case 23:
							obj = 2;
							((GamePath)Unsafe.AsPointer(ref this)).Cache = (string)2;
							num = 11;
							if (((GamePath)(object)GamePath.Game).GameAuthenticationDllSource == null)
							{
								num = 20;
							}
							continue;
						case 18:
							goto IL_0a45;
						case 22:
							if ((nint)obj == 1)
							{
								num = 5;
								continue;
							}
							goto case 24;
						case 26:
						case 31:
							obj = ((GamePath)Unsafe.AsPointer(ref this)).PatchMcpSource;
							num = 2;
							continue;
						case 16:
						case 29:
							obj = GamePath.CheckGeneralStrategy;
							num = 14;
							if (((JavaGamePath)(object)JavaGamePath.Java).JavaUrl == null)
							{
								num = 22;
							}
							continue;
						case 24:
							((JavaGamePath)Unsafe.AsPointer(ref this)).JavaTarget = null;
							num = 14;
							continue;
						case 25:
							obj = ((DefaultInterpolatedStringHandler*)(&obj))->ToStringAndClear();
							num = 13;
							if (((JavaGamePath)(object)JavaGamePath.JavaExe).GameBase == null)
							{
								num = 7;
							}
							continue;
						case 14:
							((JavaGamePath)Unsafe.AsPointer(ref this)).GameBaseComponents = null;
							num = 0;
							if (((JavaGamePath)(object)JavaGamePath.GameBaseMd5).BaseMinecraft != null)
							{
								num = 0;
							}
							continue;
						case 7:
							((JavaGamePath)Unsafe.AsPointer(ref this)).GameVersionMd5 = (string)0;
							num = 11;
							if (((JavaGamePath)(object)JavaGamePath.GameCoreLibs).GameCoreLibMd5 != null)
							{
								num = 1;
							}
							continue;
						case 20:
							((JavaGamePath)Unsafe.AsPointer(ref this)).GameRuntime = (string)obj;
							num = 15;
							continue;
						case 10:
							obj = -1;
							((JavaGamePath)Unsafe.AsPointer(ref this)).GameRuntimeMd5 = (string)(-1);
							num = 1;
							if (((JavaGamePath)(object)JavaGamePath.Custom).CustomOptions != null)
							{
								num = 0;
							}
							continue;
						case 8:
							_ = JavaGamePath.ReflectCentralEmitter;
							_ = ((MinecraftPath)Unsafe.AsPointer(ref this)).Root;
							/*Error near IL_0bbf: Member reference must be method, but was: Field*/;
						case 19:
							goto IL_0bd3;
						default:
							throw null;
						case 5:
							goto end_IL_0026;
							IL_090a:
							_ = ComponentPath.ReflectEfficientVerifier;
							((CppGamePath)1).BedrockLauncher = (string)(object)new BinaryWriter((Stream)1);
							num2 = 3;
							goto IL_0259;
							IL_0259:
							while (true)
							{
								object reflectVisualArgument;
								int num3;
								Task<EntityFeverManifestInfo> feverManifestInfoAsync;
								int num4;
								switch (num2)
								{
								case 1:
									if ((nuint)(nint)obj <= (nuint)1u)
									{
										_ = 0;
										if (((FeverInstaller)FeverInstaller.McBedrock__BackingField).Client__BackingField == null)
										{
											_ = 0;
										}
										goto IL_02a7;
									}
									goto IL_02c5;
								case 3:
								case 4:
									num2 = 1;
									if (((ComponentPath)(object)ComponentPath.ComponentCache).ComponentExtension == null)
									{
										num2 = 0;
									}
									continue;
								case 2:
									goto IL_08e4;
								case 5:
									goto IL_090a;
									IL_02c5:
									reflectVisualArgument = FeverInstaller.ReflectVisualArgument;
									num3 = ((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003E1__state;
									feverManifestInfoAsync = ((FeverInstaller)__ldftn(FeverInstaller.InstallAsync)).GetFeverManifestInfoAsync((object)new TaskAwaiter<string>());
									num4 = 2;
									goto IL_02a7;
									IL_02a7:
									while (true)
									{
										object obj3;
										switch (num4)
										{
										case 3:
											break;
										default:
											num4 = 4;
											continue;
										case 4:
											if (obj != null)
											{
												obj3 = 13;
												if (((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Eu__1)._003C_003E1__state != 0)
												{
													obj3 = 23;
												}
												goto IL_0330;
											}
											goto IL_03f9;
										case 1:
											goto IL_08e4;
											IL_040f:
											_ = FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor;
											_ = 0;
											_ = 0;
											AsyncTaskMethodBuilder<EntityFeverManifest>.Create();
											obj = 15;
											goto IL_032c;
											IL_03f9:
											obj = ((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003Eu__1;
											obj = 10;
											goto IL_032c;
											IL_032c:
											obj3 = obj;
											goto IL_0330;
											IL_0330:
											while (true)
											{
												switch ((int)obj3)
												{
												case 7:
													break;
												case 21:
													obj = 1;
													((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003E4__this = (FeverInstaller)1;
													obj3 = 24;
													continue;
												case 4:
													return;
												case 14:
													goto IL_03f9;
												case 5:
													goto IL_040f;
												case 6:
													obj = 0;
													((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003Et__builder = (AsyncTaskMethodBuilder<EntityFeverManifest>)0;
													obj3 = 2;
													if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E4__this)->info == null)
													{
														obj3 = 1;
													}
													continue;
												case 16:
													obj = ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003Eu__1;
													obj3 = 0;
													if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReflectReporter)->_003C_003E1__state == 0)
													{
														obj3 = 0;
													}
													continue;
												case 22:
													((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003E4__this = (FeverInstaller)(object)new BitConverter[8192];
													obj3 = 13;
													continue;
												case 10:
													Unsafe.As<EntityFeverAppVersion, TaskAwaiter<EntityAuthItem>>(ref ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this).version) = default;
													obj3 = 11;
													continue;
												case 11:
													obj = -1;
													FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CheckScalableWorker = -1;
													obj3 = 29;
													continue;
												case 8:
													if ((nint)obj <= 0)
													{
														obj3 = 17;
														continue;
													}
													goto IL_061a;
												default:
													Unsafe.As<int, @null>(ref ((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003E1__state) = null;
													obj3 = 7;
													if ((int)((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)FeverInstaller._003CInstallAsync_003Ed__11._003C_003E4__this)->_003C_003Eu__1 == 0)
													{
														obj3 = 4;
													}
													continue;
												case 26:
													return;
												case 9:
												case 31:
													((AsyncTaskMethodBuilder<_00210>*)feverManifestInfoAsync)->SetResult((_00210)(&obj));
													_ = 11;
													if (FeverInstaller._003CInstallAsync_003Ed__11.ReflectAccessibleWatcher != null)
													{
														_ = 12;
													}
													continue;
												case 12:
												case 13:
													if (((Rpc)((Rpc)Unsafe.AsPointer(ref this)).ProcessId__BackingField).Logger__BackingField == null)
													{
														obj3 = 18;
														continue;
													}
													goto case 20;
												case 28:
													if (RestClientExtensions.ExecuteAsync<_0021_00210>((IRestClient)(object)num3, (RestRequest)(object)feverManifestInfoAsync, (CancellationToken)(&obj)) == null)
													{
														_ = 0;
														if (((Rpc)Rpc.UseCha__BackingField).Callbacks__BackingField == null)
														{
															_ = 6;
														}
														continue;
													}
													goto case 29;
												case 23:
													if ((nint)obj != 1)
													{
														obj3 = 22;
														continue;
													}
													goto case 16;
												case 15:
													((Rpc)((Rpc)Unsafe.AsPointer(ref this)).Writer__BackingField).UseCha = (byte)(int)obj != 0;
													((AsyncTaskMethodBuilder<_00210>*)num3)->SetStateMachine((IAsyncStateMachine)feverManifestInfoAsync);
													obj = reflectVisualArgument;
													_ = 1;
													if (Rpc.ParseMap != null)
													{
														_ = 0;
													}
													continue;
												case 1:
													if (RestRequestExtensions.AddQueryParameter((RestRequest)reflectVisualArgument, (string)num3, (string)(object)feverManifestInfoAsync, (byte)(&obj) != 0) != null)
													{
														_ = 9;
														continue;
													}
													goto case 21;
												case 25:
													obj = ((Task<EntityFeverApp>)(&obj)).GetAwaiter();
													obj3 = 28;
													continue;
												case 30:
													goto IL_061a;
												case 20:
													_ = ((Rpc._003CListenControlConnectAsync_003Ed__35*)((Rpc._003CListenControlConnectAsync_003Ed__35)this)._003C_003E1__state)->_003C_003Et__builder;
													((Task<RestResponse<EntityFeverManifest>>)(object)((Rpc._003CListenControlConnectAsync_003Ed__35)this).listener).GetAwaiter();
													*(Environment.SpecialFolder*)(&obj) = default;
													obj = ((TaskAwaiter<RestResponse<EntityFeverManifest>>*)obj)->GetResult();
													_ = 25;
													if ((int)((Rpc._003CReceiveAsync_003Ed__28*)Rpc._003CReceiveAsync_003Ed__28._003C_003E1__state)->_003C_003Et__builder != 0)
													{
														_ = 10;
													}
													continue;
												case 27:
													_ = ref ((Rpc._003CReceiveAsync_003Ed__28)this).client;
													((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CReceiveGameDataAsync_003Ed__10, JavaGame._003CPrepareServerResourceAsync_003Ed__36>(ref this));
													_ = 4;
													continue;
												case 17:
												case 18:
													Rpc._003CReceiveAsync_003Ed__28.CheckMonoProgram = null;
													obj3 = 3;
													if ((int)((Rpc._003CRemoteCallBackAsync_003Ed__21*)Rpc._003CRemoteCallBackAsync_003Ed__21._003C_003E1__state)->_003C_003Et__builder != 0)
													{
														obj3 = 2;
													}
													continue;
												case 19:
													Interlocked.CompareExchange(ref Unsafe.As<Rpc, Action<JavaGame>>(ref ((Rpc._003CRemoteCallBackAsync_003Ed__21)this)._003C_003E4__this), (Action<JavaGame>)(&obj), (Action<JavaGame>)Unsafe.AsPointer(ref this));
													_ = 25;
													if (Rpc._003CRemoteCallBackAsync_003Ed__21.MeasureCalc == null)
													{
														_ = 26;
													}
													continue;
												case 24:
													((Rpc._003CSyncChaChaAsync_003Ed__38)this)._003C_003E1__state = (int)obj;
													obj3 = 27;
													continue;
												case 29:
													obj = ((TaskAwaiter<EntityFeverManifestInfo>*)(&obj))->IsCompleted;
													obj3 = 8;
													continue;
												case 2:
													((Rpc._003CSyncChaChaAsync_003Ed__38)this)._003C_003E4__this = (Rpc)obj;
													obj3 = 19;
													if (Rpc._003CSyncChaChaAsync_003Ed__38.RateStack == null)
													{
														obj3 = 2;
													}
													continue;
												case 3:
													goto IL_08e4;
												}
												break;
											}
											obj = -1;
											((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003Et__builder = (AsyncTaskMethodBuilder<EntityFeverAppVersion>)(-1);
											obj = 31;
											goto IL_032c;
											IL_061a:
											obj = new EntityItemDownload[obj];
											obj = 5;
											goto IL_032c;
										}
										break;
									}
									goto IL_02c5;
									IL_08e4:
									((ComponentPath)Unsafe.AsPointer(ref this)).Item = (EntitySubItemDownload)1;
									num2 = 0;
									if (!((ComponentPath)ComponentPath.IsShaderPack).IsResourcePack)
									{
										num2 = 0;
									}
									continue;
								}
								break;
							}
							goto case 6;
						}
						break;
						IL_0bd3:
						((StringBuilder)(((obj is Span<>) ? obj : null) ?? throw obj))._002Ector();
						((StringBuilder)/*Error near IL_0bed: Stack underflow*/).Append((string?)/*Error near IL_0bed: Stack underflow*/);
						_ = 29;
					}
					goto IL_01db;
					IL_0a45:
					if ((nint)obj != 2)
					{
						num = 21;
						goto IL_00c1;
					}
					goto IL_01db;
					IL_01db:
					obj = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this).client;
					num = 28;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E4__this)->_003Cstream_003E5__2 != null)
					{
						num = 23;
					}
					goto IL_00c1;
					end_IL_0026:
					break;
				}
				((MinecraftPath)Unsafe.AsPointer(ref this)).Assets = (string)(-2);
				obj2 = 0;
				if (((MinecraftPath)(object)MinecraftPath.Options).OptionsShaders != null)
				{
					obj2 = 0;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00鈀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
	public unsafe LanGameProxy(DesktopSession session, EntityLanGameRoom room)
	{
		//IL_001b: Expected I4, but got Obj
		//IL_0016: Expected native int or pointer, but got Obj
		//IL_0027: Expected VT, but got Obj
		//IL_0022: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)session;
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Et__builder, (AsyncTaskMethodBuilder)room);
		Task.Run((Func<Task?>)(object)this);
		int num = 0;
		if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton != null)
		{
			num = 0;
		}
		switch (num)
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
	internal unsafe static byte _FF00_FF00_FF00_FF00븀()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00뼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777536, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00섀()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0042: Expected VT, but got Obj
		//IL_0063: Expected native int or pointer, but got Obj
		//IL_007e: Expected native int or pointer, but got Obj
		//IL_00bd: Expected native int or pointer, but got Obj
		//IL_0056->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0061->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c7->IL0097: Incompatible stack heights: 3 vs 1
		//IL_00d2->IL0097: Incompatible stack heights: 3 vs 1
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
				break;
			case 2:
			{
				int num;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Eu__1 == 0)
				{
					num = 1;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state != 0)
					{
						num = 1;
					}
				}
				else
				{
					AsyncTaskMethodBuilder.Create();
					_ = 0;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
					{
						_ = 0;
					}
				}
				switch (num)
				{
				}
				break;
			}
			case 0:
				return;
			}
			((ILogger)/*Error near IL_0042: Stack underflow*/).Debug<_0021_00210>((string)/*Error near IL_0042: Stack underflow*/, (_0021_00210)this);
			obj2 = 0;
			if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
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
	internal unsafe void _FF00_FF00_FF00_FF00저(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0047: Expected native int or pointer, but got Obj
		//IL_0051: Expected Obj, but got VT
		//IL_0056: Expected VT, but got Obj
		//IL_0051: Expected native int or pointer, but got Obj
		//IL_0067: Expected Obj, but got I4
		//IL_0062: Expected native int or pointer, but got Obj
		//IL_0087: Expected native int or pointer, but got Obj
		//IL_0060->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0086->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d7->IL0026: Incompatible stack types: I4 vs Obj
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
				Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Eu__1, (TaskAwaiter)new Task((Func<Task?>)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Et__builder));
				obj2 = 3;
				break;
			case 2:
				Unsafe.Write(&Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton, (object)P_0);
				obj2 = 1;
				if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					obj2 = 1;
				}
				break;
			case 3:
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->listener.Dispose();
				obj2 = 3;
				if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
				{
					obj2 = 4;
				}
				break;
			case 0:
				return;
			case 4:
				((Authenticator._003CListenAsync_003Ed__7*)this)->MoveNext();
				obj2 = 0;
				if (((Authenticator._003CReceiveAsync_003Ed__9)Authenticator._003CReceiveAsync_003Ed__9._003C_003Et__builder)._003C_003E4__this != null)
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
	internal unsafe static object _FF00_FF00_FF00_FF00찀()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00촀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777591, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
