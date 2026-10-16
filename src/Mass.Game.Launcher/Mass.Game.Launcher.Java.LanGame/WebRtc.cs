using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Mass.Application.Desktop;
using Mass.Common.Extensions;
using Mass.Domain.Desktop.Entities.Mods;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Game.Launcher.Cpp;
using Mass.Game.Launcher.Entities;
using Mass.Game.Launcher.Entities.Fever;
using Mass.Game.Launcher.Entities.Java;
using Mass.Game.Launcher.Entities.Rpc;
using Mass.Game.Launcher.Extensions;
using Mass.Game.Launcher.Helpers;
using Mass.Game.Launcher.Models;
using Mass.Game.Launcher.Paths;
using Mass.Game.Launcher.Values;
using Microsoft.Win32;
using Org.BouncyCastle.Crypto.Engines;
using RestSharp;
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00欀(object P_0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00氀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_0054: Expected Obj, but got I4
			//IL_00a2: Expected Obj, but got VT
			//IL_00ab: Expected Obj, but got I4
			//IL_00bb: Expected Obj, but got Ref
			//IL_007b: Expected VT, but got Obj
			//IL_0085: Expected native int or pointer, but got Obj
			//IL_0128: Expected Ref, but got F8
			//IL_0132: Expected Obj, but got VT
			//IL_0213: Expected native int or pointer, but got Obj
			//IL_03d6: Expected VT, but got Ref
			//IL_0410: Expected Obj, but got I
			//IL_0421: Expected I4, but got Obj
			//IL_026d: Expected Obj, but got Ref
			//IL_04fa: Expected Obj, but got I4
			//IL_04ff: Expected VT, but got I4
			//IL_02e7: Expected Obj, but got I4
			//IL_02ec: Expected VT, but got I4
			//IL_0290: Expected Obj, but got I4
			//IL_0295: Expected Obj, but got I4
			//IL_0295: Expected Obj, but got Ref
			//IL_04af: Expected VT, but got Obj
			//IL_04b9: Expected native int or pointer, but got Obj
			//IL_036e: Expected Obj, but got I4
			//IL_0373: Expected Obj, but got I4
			//IL_0339: Expected native int or pointer, but got Obj
			//IL_0348: Expected Ref, but got VT
			//IL_0302: Expected native int or pointer, but got Obj
			//IL_030c: Expected Ref, but got VT
			//IL_0281: Expected Obj, but got Ref
			//IL_03ba: Expected native int or pointer, but got Obj
			//IL_0258: Expected I4, but got Obj
			//IL_0383: Unknown result type (might be due to invalid IL or missing references)
			//IL_0393: Expected native int or pointer, but got Obj
			//IL_0498: Expected Obj, but got Ref
			//IL_02a1: Expected native int or pointer, but got Obj
			//IL_02a8: Expected native int or pointer, but got Obj
			//IL_02bc: Expected Obj, but got VT
			//IL_00ec->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00cf->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0073->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00da->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0482->IL0187: Incompatible stack heights: 2 vs 1
			//IL_0239->IL0187: Incompatible stack heights: 2 vs 1
			//IL_0521->IL0187: Incompatible stack heights: 2 vs 1
			//IL_035e->IL0187: Incompatible stack heights: 2 vs 1
			//IL_03c4->IL0187: Incompatible stack heights: 2 vs 1
			//IL_0369->IL0187: Incompatible stack heights: 2 vs 1
			//IL_03cf->IL0187: Incompatible stack heights: 2 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 3;
			while (true)
			{
				object obj = awaiter;
				while (true)
				{
					int num;
					int num2;
					switch ((int)obj)
					{
					case 2:
						awaiter = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
						obj = 1;
						if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
						{
							obj = 1;
						}
						continue;
					case 5:
						return;
					case 6:
						((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1 = (TaskAwaiter)null;
						obj = 4;
						if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
						{
							obj = 3;
						}
						continue;
					case 3:
						goto end_IL_0026;
					case 4:
						((TcpListener)Unsafe.AsPointer(ref ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this).listener)).Dispose();
						obj = 5;
						if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler != null)
						{
							obj = 0;
						}
						continue;
					case 1:
						{
							if ((nuint)(nint)awaiter > (nuint)1u)
							{
								num = 2;
								goto IL_0103;
							}
							goto IL_0151;
						}
						IL_0187:
						while (true)
						{
							switch (num2)
							{
							case 7:
								return;
							case 21:
								return;
							case 3:
								goto end_IL_0187;
							case 11:
							case 17:
								((TaskAwaiter<TcpClient>*)(&awaiter))->GetResult();
								_ = 4;
								continue;
							case 8:
								Unsafe.As<object, AsyncTaskMethodBuilder>(ref Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverManifest>*)(&awaiter), ref Unsafe.As<_003CConnectSignalServerAsync_003Ed__31, FeverInstaller._003CInstallAsync_003Ed__11>(ref this));
								num2 = 21;
								continue;
							case 23:
								((FeverInstaller)/*Error near IL_025d: Stack underflow*/)._003CappVersion_003EP = new Encoding((byte[])/*Error near IL_0258: Stack underflow*/, (int)/*Error near IL_0258: Stack underflow*/, (int)awaiter);
								num2 = 26;
								continue;
							case 5:
								awaiter = FeverInstaller.McBedrock__BackingField;
								num2 = 19;
								continue;
							case 20:
								((FeverInstaller)Unsafe.AsPointer(ref this)).Client__BackingField = awaiter;
								num2 = 8;
								continue;
							case 10:
								awaiter = 1;
								FeverInstaller.ReflectVisualArgument = 1;
								num2 = 12;
								continue;
							case 26:
							{
								int num3 = ((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)awaiter)->_003C_003E1__state;
								AsyncTaskMethodBuilder<T> asyncTaskMethodBuilder = ((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)awaiter)->_003C_003Et__builder;
								((RestClientOptions)new TaskAwaiter<string>())._002Ector();
								((RestClientOptions)num3).UserAgent = (string)asyncTaskMethodBuilder;
								((RestClientOptions)/*Error near IL_02c1: Stack underflow*/).AutomaticDecompression = (DecompressionMethods)/*Error near IL_02c1: Stack underflow*/;
								awaiter = (object)/*Error near IL_02c3: Stack underflow*/;
								num2 = 2;
								if (((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003Et__builder)._003C_003E4__this == null)
								{
									num2 = 0;
								}
								continue;
							}
							case 9:
								awaiter = 0;
								((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003Eu__1 = (TaskAwaiter<EntityFeverApp>)0;
								num2 = 20;
								continue;
							case 18:
								((FeverInstaller._003CFeverRequest_003Ed__15<>*)/*Error near IL_0300: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor);
								((AsyncTaskMethodBuilder*)/*Error near IL_030c: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)/*Error near IL_030c: Stack underflow*/, ref *(Rpc._003CRemoteCallBackAsync_003Ed__21*)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)awaiter)->_003C_003Et__builder);
								num2 = 22;
								continue;
							case 27:
								if ((nint)awaiter != 1)
								{
									num2 = 23;
									continue;
								}
								goto case 5;
							case 16:
								_ = ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)awaiter)->info;
								awaiter = ((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)AsyncTaskMethodBuilder<EntityFeverAppVersion>.Create())->Task;
								_ = 25;
								if ((int)((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13._003C_003E1__state)->_003C_003Et__builder != 0)
								{
									_ = 8;
								}
								continue;
							case 14:
								awaiter = -1;
								((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003E4__this = (FeverInstaller)(-1);
								num2 = 11;
								continue;
							case 24:
								((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this).version = (EntityFeverAppVersion)default(Salsa20Engine);
								num2 = 6;
								if (((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CheckScalableWorker)->_003C_003E1__state == 0)
								{
									num2 = 6;
								}
								continue;
							case 22:
								FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CallGateway();
								_ = 1;
								if ((int)((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)FeverInstaller._003CInstallAsync_003Ed__11._003C_003E4__this)->_003C_003Eu__1 != 0)
								{
									_ = 1;
								}
								continue;
							case 2:
								((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_03d6: Stack underflow*/)->SetResult((_00210)(&awaiter));
								if ((int)/*Error near IL_03db: Stack underflow*/ == 0)
								{
									num2 = 9;
									if (FeverInstaller._003CInstallAsync_003Ed__11.ReflectAccessibleWatcher == null)
									{
										num2 = 1;
									}
									continue;
								}
								goto case 15;
							case 4:
								((Rpc)/*Error near IL_0404: Stack underflow*/).ProcessId = (int)Rpc.ProcessId__BackingField;
								((Rpc)(object)(((Rpc)((Rpc)awaiter).NeedCha__BackingField).NeedCha ? ((TaskAwaiter<RestResponse<EntityFeverResponse<_00210>>>*)1) : ((TaskAwaiter<RestResponse<EntityFeverResponse<_00210>>>*)null))->GetResult()).UseCha = (byte)(int)((Rpc)awaiter).Writer__BackingField != 0;
								((AsyncTaskMethodBuilder*)/*Error near IL_0426: Stack underflow*/)->Start(ref *(JavaGame._003COnDataReceivedAsync_003Ed__13*)/*Error near IL_0426: Stack underflow*/);
								num2 = 0;
								if (Rpc.ParseMap == null)
								{
									num2 = 0;
								}
								continue;
							case 1:
								Rpc._003CListenAsync_003Ed__34._003C_003E4__this.Dispose();
								((TaskAwaiter<EntityFeverApp>*)/*Error near IL_0478: Stack underflow*/)->GetResult();
								_ = 16;
								continue;
							case 25:
								((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)/*Error near IL_0498: Stack underflow*/)->SetException((Exception)(&awaiter));
								if ((int)/*Error near IL_049d: Stack underflow*/ != 0)
								{
									num2 = 17;
									continue;
								}
								goto case 10;
							case 12:
								((Rpc._003CListenControlConnectAsync_003Ed__35)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)awaiter;
								num2 = 13;
								if (((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)Rpc._003CListenControlConnectAsync_003Ed__35.listener)->_003C_003E4__this == null)
								{
									num2 = 11;
								}
								continue;
							case 15:
								((AsyncTaskMethodBuilder<EntityFeverManifest>*)/*Error near IL_04d5: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_04d5: Stack underflow*/, ref *(TStateMachine*)(&awaiter));
								num2 = 18;
								continue;
							case 19:
								Rpc._003CListenControlConnectAsync_003Ed__35.ReflectSymbolicDecorator = null;
								num2 = 14;
								continue;
							case 6:
								awaiter = -1;
								((Rpc._003CReceiveAsync_003Ed__28)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-1);
								num2 = 15;
								continue;
							case 13:
								_ = ref ((Rpc._003CReceiveAsync_003Ed__28)this).client;
								((AsyncTaskMethodBuilder*)(&awaiter))->Start(ref Unsafe.As<_003CConnectSignalServerAsync_003Ed__31, JavaGame._003CPrepareServerResourceAsync_003Ed__36>(ref this));
								_ = 7;
								continue;
							}
							goto end_IL_0026_2;
							continue;
							end_IL_0187:
							break;
						}
						goto IL_0201;
						IL_0151:
						num = 0;
						if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E1__state)->_003C_003Et__builder == 0)
						{
							num = 1;
						}
						goto IL_0103;
						IL_0103:
						while (true)
						{
							switch (num)
							{
							case 2:
								((AsyncTaskMethodBuilder*)/*Error near IL_0128: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref Unsafe.As<_003CConnectSignalServerAsync_003Ed__31, TAwaiter>(ref this), ref *(TStateMachine*)10.0);
								Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)(nint)/*Error near IL_0132: Stack underflow*/)->client, (TcpClient)new TaskAwaiter());
								num = 0;
								if (Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain == null)
								{
									num = 0;
								}
								continue;
							case 1:
								goto IL_0171;
							}
							break;
						}
						goto IL_0151;
						IL_0171:
						if (awaiter != null)
						{
							num2 = 27;
							goto IL_0187;
						}
						goto IL_0201;
						IL_0201:
						awaiter = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this).client;
						num2 = 23;
						if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E4__this)->_003Cstream_003E5__2 == null)
						{
							num2 = 24;
						}
						goto IL_0187;
						end_IL_0026_2:
						break;
					}
					((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003E1__state = -2;
					obj = 6;
					continue;
					end_IL_0026:
					break;
				}
				awaiter = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Et__builder;
				awaiter = 2;
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00琀()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00圀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00堀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777425, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00夀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_004b: Expected I4, but got Obj
			//IL_006a: Expected VT, but got Obj
			//IL_0074: Expected native int or pointer, but got Obj
			//IL_0a70: Expected Obj, but got Ref
			//IL_0059: Expected Obj, but got I4
			//IL_0a98: Expected Obj, but got Ref
			//IL_0a87: Expected Obj, but got I4
			//IL_0a87: Expected Obj, but got Ref
			//IL_0154: Expected native int or pointer, but got Obj
			//IL_00c2: Expected native int or pointer, but got Obj
			//IL_0176: Expected Obj, but got I4
			//IL_017b: Expected Obj, but got Ref
			//IL_0185: Expected native int or pointer, but got Obj
			//IL_012a: Expected Obj, but got VT
			//IL_0134: Expected native int or pointer, but got Obj
			//IL_010a: Expected native int or pointer, but got Obj
			//IL_069a: Expected Obj, but got Ref
			//IL_06ae: Expected VT, but got Obj
			//IL_06ae: Expected VT, but got I
			//IL_06ae: Expected Obj, but got I
			//IL_06b9: Expected Obj, but got I4
			//IL_024d: Expected I4, but got Obj
			//IL_066d: Expected I4, but got Obj
			//IL_044e: Expected Obj, but got VT
			//IL_044e: Expected Obj, but got Ref
			//IL_025a: Expected Obj, but got VT
			//IL_06eb: Expected Obj, but got I4
			//IL_076d: Expected I4, but got Obj
			//IL_0719: Expected I4, but got Obj
			//IL_0734: Expected Obj, but got I4
			//IL_037a: Expected Obj, but got I4
			//IL_037f: Expected VT, but got I4
			//IL_06c4: Expected Obj, but got Ref
			//IL_06d5: Expected Obj, but got I4
			//IL_0837: Expected Obj, but got I4
			//IL_0852: Expected Obj, but got Ref
			//IL_0861: Expected Obj, but got I4
			//IL_0866: Expected Obj, but got I4
			//IL_0866: Expected Obj, but got Ref
			//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_080b: Expected VT, but got I4
			//IL_0345: Expected Ref, but got VT
			//IL_034a: Expected Ref, but got VT
			//IL_0364: Expected I4, but got VT
			//IL_0369: Expected Obj, but got I4
			//IL_036b: Expected Obj, but got VT
			//IL_028c: Expected Obj, but got Ref
			//IL_0292: Expected Obj, but got Ref
			//IL_029f: Expected I4, but got Obj
			//IL_0845: Expected Obj, but got I4
			//IL_08c7: Expected Obj, but got I4
			//IL_0522: Expected native int or pointer, but got Obj
			//IL_04e4: Expected Obj, but got I4
			//IL_04e6: Expected native int or pointer, but got Obj
			//IL_04f7: Expected native int or pointer, but got Obj
			//IL_04aa: Expected native int or pointer, but got Obj
			//IL_04b4: Expected Obj, but got I4
			//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bb: Expected Obj, but got Unknown
			//IL_053d: Expected native int or pointer, but got Obj
			//IL_0900: Expected I4, but got Obj
			//IL_0900: Expected Obj, but got I4
			//IL_0566: Expected native int or pointer, but got Obj
			//IL_007e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0a7f->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00a5->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0aac->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0a91->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00b0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0ab7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01ac->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_0677->IL01b0: Incompatible stack heights: 3 vs 1
			//IL_0458->IL01b0: Incompatible stack heights: 2 vs 1
			//IL_026e->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_03e4->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_0781->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_0739->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_0389->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_083c->IL0744: Incompatible stack heights: 1 vs 0
			//IL_085c->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_0870->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_0817->IL01b0: Incompatible stack heights: 2 vs 1
			//IL_0375->IL01b0: Incompatible stack heights: 2 vs 1
			//IL_0335->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_02b3->IL01b0: Incompatible stack heights: 2 vs 1
			//IL_0279->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_068d->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_07ac->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_0704->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_03ef->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_078c->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_0764->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_0744->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_084a->IL01ac: Incompatible stack heights: 1 vs 0
			//IL_0661->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_0426->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_02be->IL01b0: Incompatible stack heights: 2 vs 1
			//IL_0515->IL047a: Incompatible stack heights: 2 vs 1
			//IL_070f->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_02f3->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_0431->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_0520->IL047a: Incompatible stack heights: 2 vs 1
			//IL_02fe->IL01b0: Incompatible stack types: I4 vs Obj
			//IL_08fb->IL090a: Incompatible stack heights: 2 vs 3
			//IL_08f1->IL090a: Incompatible stack heights: 2 vs 3
			//IL_0905->IL090a: Incompatible stack heights: 0 vs 3
			//IL_0919->IL01b0: Incompatible stack heights: 2 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 3;
			object obj = awaiter;
			while (true)
			{
				int num;
				object obj2;
				switch ((int)obj)
				{
				case 6:
					return;
				case 3:
					awaiter = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
					obj = 2;
					break;
				default:
					((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)null;
					obj = 1;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj = 1;
					}
					break;
				case 2:
					awaiter = Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton;
					obj = 5;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj = 2;
					}
					break;
				case 5:
					if (awaiter != null)
					{
						num = 1;
						if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
						{
							num = 4;
						}
						goto IL_00db;
					}
					goto IL_0149;
				case 1:
					((EqualityComparer<ushort>)/*Error near IL_0a75: Stack underflow*/).GetHashCode((ushort)Unsafe.AsPointer(ref ((MinecraftPath)Unsafe.AsPointer(ref this)).Options));
					_ = 6;
					break;
				case 7:
					goto IL_0a7f;
				case 4:
					{
						((ServerModPath)Unsafe.AsPointer(ref this)).Resource = null;
						obj = 0;
						if (((ServerModPath)(object)ServerModPath.ResourceMd5).Mods != null)
						{
							obj = 0;
						}
						break;
					}
					IL_06be:
					Unsafe.As<string, AsyncTaskMethodBuilder>(ref ((BedrockGamePath)Unsafe.AsPointer(ref this)).Launcher).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CReceiveAsync_003Ed__35, JavaGame._003CPrepareVersionAsync_003Ed__44>(ref this));
					awaiter = 15;
					goto IL_01ac;
					IL_0a7f:
					MinecraftPath.CheckFilteredListener = (MinecraftPath)(-2);
					obj = 4;
					break;
					IL_0149:
					num = 0;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain)->_003C_003E1__state == 0)
					{
						num = 0;
					}
					goto IL_00db;
					IL_00db:
					while (true)
					{
						switch (num)
						{
						case 4:
							((IAsyncStateMachine)/*Error near IL_00fe: Stack underflow*/).MoveNext();
							awaiter = (object)/*Error near IL_0100: Stack underflow*/;
							num = 2;
							if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state == 0)
							{
								num = 1;
							}
							continue;
						case 3:
							Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)(nint)/*Error near IL_012a: Stack underflow*/)->_003C_003E4__this, (Authenticator)new AsyncTaskMethodBuilder(ref *(TAwaiter*)/*Error near IL_0125: Stack underflow*/, ref Unsafe.As<_003CReceiveAsync_003Ed__35, TStateMachine>(ref this)));
							num = 1;
							if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9.client)->_003C_003Eu__1 == 0)
							{
								num = 0;
							}
							continue;
						case 1:
							break;
						case 2:
							((AsyncTaskMethodBuilder*)awaiter)->SetStateMachine((IAsyncStateMachine)4096);
							Unsafe.Write(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)/*Error near IL_017b: Stack underflow*/)->client, (TcpClient)Unsafe.AsPointer(ref this));
							num = 3;
							if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E4__this)->_003Cstream_003E5__2 == null)
							{
								num = 1;
							}
							continue;
						default:
							goto IL_019a;
						}
						break;
					}
					goto IL_0149;
					IL_019a:
					if (awaiter == null)
					{
						obj2 = 16;
						goto IL_01b0;
					}
					goto IL_068d;
					IL_068d:
					((ILogger)/*Error near IL_06ae: Stack underflow*/).Debug<_0021_00210, _0021_00211>((string)((JavaGameValue)awaiter).GuiScale__BackingField, (_0021_00210)((JavaGameValue)Unsafe.AsPointer(ref this)).SetSize__BackingField, (_0021_00211)((Delegate)new BinaryWriter()).Method.Name);
					awaiter = (object)/*Error near IL_06b0: Stack underflow*/;
					awaiter = 5;
					goto IL_01ac;
					IL_01ac:
					obj2 = awaiter;
					goto IL_01b0;
					IL_01b0:
					while (true)
					{
						switch ((int)obj2)
						{
						case 15:
							return;
						case 6:
						case 16:
							awaiter = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003Eu__1;
							obj2 = 12;
							if (((FeverInstaller)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway)._003CfeverVersion_003EP == null)
							{
								obj2 = 12;
							}
							continue;
						case 13:
							((Encoding)/*Error near IL_0280: Stack underflow*/).GetString((byte[])/*Error near IL_0280: Stack underflow*/, (int)/*Error near IL_0280: Stack underflow*/, (int)(&awaiter));
							throw new TcpClient();
						case 1:
							((Stream)FeverInstaller.McBedrock__BackingField).Read((byte[])((FeverInstaller)Unsafe.AsPointer(ref this)).Client__BackingField, 0, (int)((TaskAwaiter<string>*)awaiter)->GetResult());
							_ = 8;
							if (((FeverInstaller._003CFeverRequest_003Ed__15<>)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Et__builder)._003C_003E4__this == null)
							{
								_ = 1;
							}
							continue;
						case 30:
							throw new RestClientOptions();
						case 37:
							((AsyncTaskMethodBuilder<EntityFeverManifest>*)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E4__this)->Start<TStateMachine>(ref *(TStateMachine*)FeverInstaller.CheckStaticProgram());
							obj2 = 9;
							continue;
						case 34:
						{
							((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)AsyncTaskMethodBuilder<EntityFeverManifest>.Create())->Start<TStateMachine>(ref *(TStateMachine*)((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003Et__builder)->Task);
							_ = FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003Eu__1;
							bool flag2 = FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.AnalyzeHandler();
							((DefaultInterpolatedStringHandler*)((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003E1__state)->AppendFormatted((EnumGameVersion)(int)AsyncTaskMethodBuilder<_0021_00210>.Create());
							awaiter = JavaRpcUnpacker.Unpack<_0021_00210>((byte[])flag2);
							_ = 26;
							continue;
						}
						case 22:
							awaiter = 0;
							((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003Eu__1 = (TaskAwaiter<EntityFeverManifestInfo>)0;
							obj2 = 27;
							continue;
						case 18:
						case 36:
							_ = ref awaiter;
							/*Error near IL_038b: Member reference must be method, but was: Field*/;
						case 12:
							((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003E4__this = null;
							obj2 = 28;
							if ((int)((FeverInstaller._003CInstallAsync_003Ed__11)FeverInstaller._003CInstallAsync_003Ed__11._003C_003Eu__2)._003C_003Eu__3 == 0)
							{
								obj2 = 10;
							}
							continue;
						case 5:
							_ = ref awaiter;
							/*Error near IL_03f1: Member reference must be method, but was: Field*/;
						case 31:
							break;
						case 4:
							((IEnumerable<FileInfo>)(&awaiter)).MaxBy((Func<FileInfo, DateTime>)((Task<RestResponse<EntityFeverResponse<_00210>>>)awaiter).GetAwaiter());
							_ = 13;
							continue;
						case 9:
						{
							((AsyncTaskMethodBuilder*)awaiter)->Start(ref *(((Rpc)awaiter).UseCha ? ((JavaGame._003COnDataReceivedAsync_003Ed__12*)1) : ((JavaGame._003COnDataReceivedAsync_003Ed__12*)null)));
							((Rpc)/*Error near IL_046c: Stack underflow*/)._chaChaEn = (object)/*Error near IL_046c: Stack underflow*/;
							int num2 = 2;
							while (true)
							{
								switch (num2)
								{
								case 2:
									((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)/*Error near IL_049f: Stack underflow*/)->SetResult((EntityFeverAppVersion)awaiter);
									awaiter = (object)/*Error near IL_04a1: Stack underflow*/;
									((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)/*Error near IL_04a8: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_04a8: Stack underflow*/, ref *(TStateMachine*)(&awaiter));
									Unsafe.Write(&((Rpc._003CListenAsync_003Ed__34*)(nint)/*Error near IL_04bb: Stack underflow*/)->_003C_003E4__this, (Rpc)(/*Error near IL_04b6: Stack underflow*/ + (long)((Rpc)/*Error near IL_04b4: Stack underflow*/).RemoteCallBackAsync((object)((Rpc._003CListenAsync_003Ed__34*)(nint)awaiter)->_003C_003E1__state)));
									num2 = 0;
									if (Rpc._003CListenAsync_003Ed__34.DecorateIterableWriter != null)
									{
										num2 = 1;
									}
									continue;
								case 1:
									((AsyncTaskMethodBuilder<EntityFeverManifest>*)/*Error near IL_04f5: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)((Rpc)/*Error near IL_04e4: Stack underflow*/).ReceiveAsync((object)Rpc._003CListenControlConnectAsync_003Ed__35._003C_003E1__state), ref *(TStateMachine*)((Rpc)(object)((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)awaiter)->listener).Listener);
									((IEnumerable<ComponentPath>)/*Error near IL_0501: Stack underflow*/).FirstOrDefault((Func<ComponentPath, bool>)Rpc._003CListenControlConnectAsync_003Ed__35.ReflectSymbolicDecorator);
									_ = 0;
									if (((Rpc._003CReceiveAsync_003Ed__28)Rpc._003CReceiveAsync_003Ed__28._003C_003Et__builder).client == null)
									{
										_ = 0;
									}
									continue;
								default:
								{
									Rpc rpc = ((Rpc._003CReceiveAsync_003Ed__28*)(nint)awaiter)->_003C_003E4__this;
									if (rpc == null)
									{
										num2 = 2;
										if (((Rpc._003CRemoteCallBackAsync_003Ed__21*)(nint)Rpc._003CReceiveAsync_003Ed__28.CheckMonoProgram)->_003C_003E1__state == 0)
										{
											num2 = 4;
										}
										continue;
									}
									((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)/*Error near IL_055c: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_055c: Stack underflow*/, ref *(TStateMachine*)rpc);
									num2 = 3;
									if ((object)((Rpc._003CRemoteCallBackAsync_003Ed__21*)(nint)Rpc._003CRemoteCallBackAsync_003Ed__21._003C_003E4__this)->callBack == null)
									{
										num2 = 1;
									}
									continue;
								}
								case 3:
								case 4:
									break;
								}
								break;
							}
							goto IL_0a7f;
						}
						case 29:
							((Rpc._003CSyncChaChaAsync_003Ed__38*)awaiter)->MoveNext();
							((Rpc._003CSyncChaChaAsync_003Ed__38*)/*Error near IL_064d: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_064d: Stack underflow*/);
							((Func<RpcCallBack, Task>)/*Error near IL_0652: Stack underflow*/)._002Ector((object)/*Error near IL_0652: Stack underflow*/, (nint)/*Error near IL_0652: Stack underflow*/);
							if ((int)/*Error near IL_0657: Stack underflow*/ != 0)
							{
								obj2 = 32;
								continue;
							}
							goto case 11;
						case 2:
							_ = ref awaiter;
							BitConverter.GetBytes((ushort)(int)Rpc._003CSyncChaChaAsync_003Ed__38.CheckAlphabeticPolicy());
							_ = 4;
							continue;
						case 8:
							if (Enumerable.Concat<TSource>((IEnumerable<TSource>)/*Error near IL_067e: Stack underflow*/, (IEnumerable<TSource>)awaiter) == null)
							{
								obj2 = 7;
								continue;
							}
							goto case 34;
						case 7:
						case 21:
							goto end_IL_01b0;
						case 23:
							goto IL_06be;
						case 11:
							((GameValue)awaiter)._002Ector();
							if (((BinaryReader)GameValue.CheckControllablePolicy()).ReadUInt16() != 0)
							{
								obj2 = 17;
								if (((ComponentPath)(object)ComponentPath.ComponentName).ComponentZip == null)
								{
									obj2 = 9;
								}
								continue;
							}
							goto case 10;
						case 20:
						case 24:
							((JavaGameValue)/*Error near IL_0719: Stack underflow*/).Reconnect = (byte)(int)ComponentPath.ComponentMd5 != 0;
							((AsyncTaskMethodBuilder*)/*Error near IL_0725: Stack underflow*/)->Start(ref *(JavaRpc._003CAuthenticationNewVersionAsync_003Ed__26*)((JavaGameValue)awaiter).ReconnectDelay);
							obj2 = 0;
							if (((ComponentPath)ComponentPath.IsShaderPack).IsResourcePack)
							{
								obj2 = 0;
							}
							continue;
						case 19:
							((JavaGameValue)/*Error near IL_0750: Stack underflow*/).SetChinese = ((JavaGameValue)awaiter).SetChinese;
							if (((TcpClient)/*Error near IL_0755: Stack underflow*/).Connected)
							{
								obj2 = 25;
								continue;
							}
							goto case 29;
						case 14:
							((JavaGameValue)awaiter).SetGuiScale = (byte)(int)awaiter != 0;
							obj2 = 0;
							if (((CppGamePath)(object)CppGamePath.Bedrock).GameZip == null)
							{
								obj2 = 3;
							}
							continue;
						case 10:
							((JavaGameValue)/*Error near IL_0798: Stack underflow*/).SetSize = ((JavaGameValue)awaiter).SetSize;
							if (!string.IsNullOrWhiteSpace((string?)/*Error near IL_079d: Stack underflow*/))
							{
								obj2 = 24;
								continue;
							}
							goto case 17;
						case 33:
							goto IL_0803;
						case 26:
							if (((RegistryKey)JavaGameValue.DecorateSortedEvent()).GetValue((string?)(object)JavaGameValue.CombineProgram()) == null)
							{
								goto case 19;
							}
							goto IL_083c;
						case 27:
							((GamePath)Unsafe.AsPointer(ref this)).Cache = (string)awaiter;
							obj2 = 23;
							continue;
						case 28:
							awaiter = -1;
							((GamePath)Unsafe.AsPointer(ref this)).Game = (string)(-1);
							obj2 = 18;
							continue;
						case 17:
						case 25:
						case 32:
						case 35:
						{
							((ComponentPath)/*Error near IL_088d: Stack underflow*/)._002Ector((string)/*Error near IL_088d: Stack underflow*/, (EntityItemDownload)/*Error near IL_088d: Stack underflow*/, (EntitySubItemDownload)(object)GamePath.GameAuthenticationDllSource);
							object obj3 = awaiter;
							bool flag = ComponentPath.CloseRecord();
							object obj4 = awaiter;
							((CppGamePath)(object)ComponentPath.DecorateGlobalComparator())._002Ector((EntityLaunchCppGame)awaiter);
							string text;
							if ((CppGamePath.ReflectDetailedCommand() ? ((DefaultInterpolatedStringHandler*)1) : ((DefaultInterpolatedStringHandler*)null))->ToStringAndClear() == null)
							{
								((GamePath)awaiter)._002Ector();
								if (((EntitySubItemDownload)GamePath.ReflectExtendedSorter()).ResourceName == null)
								{
									((JavaGamePath)obj4)._002Ector((EntityLaunchJavaGame)awaiter);
									if (((EntitySubItemDownload)JavaGamePath.GetGameVersionNameLower(flag ? ((EnumGameVersion)1u) : EnumGameVersion.None)).ResourceMd5 == null)
									{
										JavaGamePath.CheckStatelessRunner();
									}
									else
									{
										JavaGamePath.DecorateScheduledClient();
									}
								}
								else
								{
									((MinecraftPath)obj3)._002Ector((string)flag, (EnumGameVersion)(int)obj4);
								}
							}
							else
							{
								text = ((MinecraftPath)obj4).ToString();
							}
							(flag ? ((AsyncTaskMethodBuilder*)1) : ((AsyncTaskMethodBuilder*)null))->Start(ref *(DesktopTransfer._003CReceiveAsync_003Ed__39*)text);
							_ = 14;
							continue;
						}
						default:
							goto IL_0a7f;
						}
						if ((((TaskAwaiter<RestResponse<EntityFeverResponse<_00210>>>*)awaiter)->IsCompleted ? 1 : 0) != 2)
						{
							((RestClientOptions)/*Error near IL_02da: Stack underflow*/).UserAgent = (string)awaiter;
							if ((int)/*Error near IL_02df: Stack underflow*/ == 0)
							{
								obj2 = 1;
								if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E1__state)->_003C_003Et__builder != 0)
								{
									obj2 = 1;
								}
								continue;
							}
							goto IL_0803;
						}
						obj2 = 30;
						if (((Rpc)Rpc.Logger__BackingField).NeedCha__BackingField == 0)
						{
							obj2 = 24;
						}
						continue;
						IL_0803:
						_ = 31;
						awaiter = new Type((RuntimeTypeHandle)1);
						_ = 2;
						continue;
						end_IL_01b0:
						break;
					}
					goto IL_068d;
					IL_083c:
					awaiter = 37;
					goto IL_01ac;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00栀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00䰀(object P_0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00䴀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_009f: Expected VT, but got I4
			//IL_00b4: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I4
			//IL_0077: Expected Obj, but got VT
			//IL_0081: Expected native int or pointer, but got Obj
			//IL_039a: Expected native int or pointer, but got Obj
			//IL_03d5: Expected native int or pointer, but got Obj
			//IL_03e4: Expected I4, but got VT
			//IL_01ca: Expected Obj, but got I4
			//IL_0271: Expected I4, but got Obj
			//IL_022d: Expected Obj, but got I4
			//IL_0232: Expected Obj, but got I4
			//IL_0232: Expected Obj, but got Ref
			//IL_0198: Expected Obj, but got Ref
			//IL_0198: Expected Obj, but got Ref
			//IL_01ee: Expected Obj, but got I4
			//IL_01f3: Expected Obj, but got I4
			//IL_01fd: Expected native int or pointer, but got Obj
			//IL_00a9->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c8->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0269->IL013a: Incompatible stack heights: 2 vs 1
			//IL_01a2->IL013a: Incompatible stack heights: 3 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				case 4:
					obj = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
					obj2 = 0;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 1;
					}
					break;
				case 5:
					obj = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1;
					obj2 = 1;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state != 0)
					{
						obj2 = 4;
					}
					break;
				case 0:
					return;
				case 2:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-2);
					obj2 = 3;
					break;
				case 3:
					((TcpListener)Unsafe.AsPointer(ref ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this).listener)).Dispose();
					obj2 = 0;
					if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
					{
						obj2 = 0;
					}
					break;
				case 1:
					{
						if (obj != null)
						{
							num = 5;
							goto IL_00e9;
						}
						goto IL_0437;
					}
					IL_0437:
					num = 3;
					goto IL_00e9;
					IL_00e9:
					while (true)
					{
						int num2;
						switch (num)
						{
						case 4:
							break;
						case 3:
							if (obj != null)
							{
								num2 = 1;
								if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder == 0)
								{
									num2 = 0;
								}
								goto IL_013a;
							}
							goto IL_01c2;
						case 1:
						case 2:
							goto IL_0398;
						case 5:
						{
							AsyncTaskMethodBuilder asyncTaskMethodBuilder = FeverInstaller._003CInstallAsync_003Ed__11._003C_003Et__builder;
							((AsyncTaskMethodBuilder<_00210>*)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.DecorateGroupedVisitor())->SetResult((_00210)((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)obj)->_003C_003Eu__1);
							((DefaultInterpolatedStringHandler*)/*Error near IL_03e4: Stack underflow*/)->AppendFormatted((int)asyncTaskMethodBuilder);
							num = 2;
							continue;
						}
						default:
							((AsyncTaskMethodBuilder*)((Rpc)Rpc.Logger__BackingField).Logger)->Start(ref *(JavaGame._003CLaunchStepsAsync_003Ed__2*)((TaskAwaiter<RestResponse<EntityFeverResponse<_00210>>>*)((Rpc)obj).UseCha__BackingField)->GetResult());
							num = 4;
							continue;
						case 6:
							goto IL_0437;
							IL_0398:
							_ = ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)obj)->version;
							/*Error near IL_039f: Member reference must be method, but was: Field*/;
							IL_013a:
							while (true)
							{
								switch (num2)
								{
								case 6:
									return;
								case 5:
									((TaskAwaiter*)(&obj))->GetResult();
									if ((int)/*Error near IL_0180: Stack underflow*/ != 0)
									{
										num2 = 9;
										continue;
									}
									goto case 11;
								case 8:
									_ = ref ((Authenticator._003CReceiveAsync_003Ed__9)this).client;
									((FeverInstaller)(&obj)).FeverRequest<EntityFeverApp>((RestRequest)(object)Unsafe.AsPointer(ref this));
									_ = 6;
									continue;
								case 4:
								case 9:
									((AsyncTaskMethodBuilder*)(&obj))->SetResult();
									num2 = 2;
									continue;
								case 10:
									break;
								case 11:
									obj = 0;
									((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003E4__this = (Authenticator)0;
									num2 = 0;
									if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003Cstream_003E5__2)->_003C_003Eu__1 == 0)
									{
										num2 = 0;
									}
									continue;
								case 3:
									Unsafe.As<object, byte>(ref Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway) = default;
									num2 = 7;
									continue;
								case 7:
									obj = -1;
									((FeverInstaller)Unsafe.AsPointer(ref this))._003CappId_003EP = -1;
									num2 = 4;
									if (FeverInstaller.McBedrock__BackingField == null)
									{
										num2 = 4;
									}
									continue;
								case 1:
									obj = ((TaskAwaiter<string>*)FeverInstaller.McBedrock)->GetResult();
									_ = 5;
									continue;
								default:
									((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003E1__state = (int)obj;
									num2 = 1;
									if (((FeverInstaller._003CFeverRequest_003Ed__15<>)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Et__builder)._003C_003E4__this == null)
									{
										num2 = 8;
									}
									continue;
								case 2:
									goto IL_0398;
								}
								break;
							}
							goto IL_01c2;
							IL_01c2:
							obj = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003E1__state;
							num2 = 3;
							if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Et__builder).client != null)
							{
								num2 = 0;
							}
							goto IL_013a;
						}
						break;
					}
					goto case 2;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00吀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00䀀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00䄀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777418, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00䈀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0669: Expected Obj, but got Ref
			//IL_066b: Expected Obj, but got I
			//IL_0674: Expected Obj, but got I4
			//IL_067f: Expected Obj, but got Ref
			//IL_0681: Expected Obj, but got I
			//IL_06a8: Expected Obj, but got I4
			//IL_06a8: Expected Obj, but got Ref
			//IL_005d: Expected native int or pointer, but got Obj
			//IL_0084: Expected native int or pointer, but got Obj
			//IL_0520: Expected native int or pointer, but got Obj
			//IL_02f3: Expected Obj, but got I4
			//IL_04c4: Expected Obj, but got I4
			//IL_04c9: Expected Obj, but got I4
			//IL_0235: Expected Obj, but got I4
			//IL_023a: Expected Obj, but got I4
			//IL_023a: Expected Obj, but got Ref
			//IL_021a: Expected Obj, but got Ref
			//IL_0222: Expected Obj, but got Ref
			//IL_0222: Expected Obj, but got Ref
			//IL_022b: Expected Obj, but got I4
			//IL_04db: Expected I4, but got Obj
			//IL_01f0: Expected Obj, but got Ref
			//IL_03e7: Expected Obj, but got Ref
			//IL_03bc: Expected Obj, but got Ref
			//IL_03c2: Expected Obj, but got Ref
			//IL_03c8: Expected Obj, but got Ref
			//IL_03cf: Expected Obj, but got I
			//IL_019e: Expected Obj, but got I4
			//IL_01b4: Expected VT, but got Obj
			//IL_0417: Unknown result type (might be due to invalid IL or missing references)
			//IL_041d: Expected I4, but got Unknown
			//IL_04ea: Expected Obj, but got I4
			//IL_04ef: Expected VT, but got I4
			//IL_030a: Expected VT, but got Obj
			//IL_0314: Expected native int or pointer, but got Obj
			//IL_0284: Expected Obj, but got VT
			//IL_0284: Expected Obj, but got I4
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b5: Expected native int or pointer, but got Obj
			//IL_0585: Expected Obj, but got VT
			//IL_058c: Expected Obj, but got I4
			//IL_0342: Expected Ref, but got VT
			//IL_0358: Expected Obj, but got VT
			//IL_049b: Expected native int or pointer, but got Obj
			//IL_0509: Expected Obj, but got I4
			//IL_0695->IL0026: Incompatible stack types: I4 vs Obj
			//IL_06bc->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
			//IL_06a0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_06c7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0072->IL0026: Incompatible stack types: I4 vs Obj
			//IL_054d->IL009d: Incompatible stack heights: 2 vs 1
			//IL_0157->IL009d: Incompatible stack heights: 3 vs 1
			//IL_01c8->IL009d: Incompatible stack heights: 2 vs 1
			//IL_02bf->IL009d: Incompatible stack heights: 3 vs 1
			//IL_0596->IL009d: Incompatible stack heights: 2 vs 1
			//IL_036c->IL009d: Incompatible stack heights: 3 vs 1
			//IL_009d->IL009d: Incompatible stack heights: 3 vs 1
			//IL_050e->IL0099: Incompatible stack heights: 0 vs 2
			//IL_01d3->IL009d: Incompatible stack heights: 2 vs 1
			//IL_02ca->IL009d: Incompatible stack heights: 3 vs 1
			//IL_0377->IL009d: Incompatible stack heights: 3 vs 1
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
					int num;
					switch ((int)obj2)
					{
					case 3:
						((Func<Task>)/*Error near IL_0053: Stack underflow*/)._002Ector((object)/*Error near IL_0053: Stack underflow*/, (nint)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state));
						obj2 = 3;
						if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
						{
							obj2 = 4;
						}
						continue;
					case 5:
						if (obj == null)
						{
							num = 3;
							if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
							{
								num = 9;
							}
							goto IL_009d;
						}
						goto IL_045e;
					default:
						goto end_IL_0026;
					case 1:
						obj = ((JavaGameValue)Unsafe.AsPointer(ref this)).WindowHeight__BackingField;
						obj2 = 0;
						if (((BedrockGamePath)(object)JavaGameValue.ReflectResponsiveModule).NeteaseData == null)
						{
							obj2 = 0;
						}
						continue;
					case 2:
						break;
					case 4:
						return;
						IL_009d:
						while (true)
						{
							switch (num)
							{
							case 23:
								_ = ref obj;
								AsyncTaskMethodBuilder.Create();
								_ = 26;
								continue;
							case 9:
							case 11:
								obj = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this).listener;
								num = 16;
								continue;
							case 35:
								if ((nint)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003E4__this <= 0)
								{
									num = 14;
									if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
									{
										num = 15;
									}
									continue;
								}
								goto case 29;
							case 27:
							{
								((Authenticator._003CListenAsync_003Ed__7*)/*Error near IL_019e: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state);
								Authenticator authenticator = ((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003E4__this;
								((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)((Authenticator._003CReceiveAsync_003Ed__9)this).client)->MoveNext();
								RestClientExtensions.ExecuteAsync<EntityFeverManifest>((IRestClient)/*Error near IL_01b4: Stack underflow*/, (RestRequest)/*Error near IL_01b4: Stack underflow*/, (CancellationToken)authenticator);
								_ = 6;
								if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E1__state)->_003C_003Et__builder == 0)
								{
									_ = 6;
								}
								continue;
							}
							case 16:
								((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this).client = null;
								num = 7;
								continue;
							case 22:
								if ((int)((Task<TcpClient>)(&obj)).GetAwaiter() == 0)
								{
									num = 0;
									if (Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway == null)
									{
										num = 0;
									}
									continue;
								}
								goto case 23;
							case 14:
								_ = ref ((FeverInstaller)Unsafe.AsPointer(ref this))._003CfeverVersion_003EP;
								((IEnumerable<byte>)(&obj)).Concat((IEnumerable<byte>)Unsafe.AsPointer(ref this));
								obj = 4;
								continue;
							case 12:
								obj = -1;
								((FeverInstaller)Unsafe.AsPointer(ref this))._003CappVersion_003EP = -1;
								num = 24;
								if (((FeverInstaller)FeverInstaller.McBedrock__BackingField).Client__BackingField == null)
								{
									num = 11;
								}
								continue;
							case 32:
							{
								((FeverInstaller)FeverInstaller.ReflectVisualArgument).Dispose();
								ConfigureSerialization[] array = new ConfigureSerialization[4];
								array[0] = (ConfigureSerialization)(object)(RestRequest)((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003E4__this;
								array[(object)array] = (ConfigureSerialization)((FeverInstaller)1).FeverRequest<T>((RestRequest)(object)((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003Eu__1);
								_003F val = /*Error near IL_0285: Stack underflow*/;
								((object[])2)[((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003Et__builder] = (object)(Method)FeverInstaller.CheckScopeSummarizer();
								((object[])val)[3] = FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor;
								AsyncTaskMethodBuilder<EntityFeverManifestInfo>.Create();
								_ = 6;
								if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E4__this)->info == null)
								{
									_ = 33;
								}
								continue;
							}
							default:
								obj = 0;
								((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003E1__state = 0;
								num = 31;
								continue;
							case 31:
								((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003Et__builder = (AsyncTaskMethodBuilder<EntityFeverManifestInfo>)obj;
								num = 14;
								if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13._003C_003E4__this)->version == null)
								{
									num = 14;
								}
								continue;
							case 8:
							case 34:
								((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13._003C_003Eu__1)->MoveNext();
								_ = ((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003E1__state;
								JsonSerializer.Deserialize<Dictionary<string, JsonElement>>((string)((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Et__builder, (JsonSerializerOptions?)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.DecorateGroupedVisitor());
								_ = 1;
								if ((int)((FeverInstaller._003CInstallAsync_003Ed__11)FeverInstaller._003CInstallAsync_003Ed__11._003C_003Eu__2)._003C_003Eu__3 == 0)
								{
									_ = 0;
								}
								continue;
							case 13:
								return;
							case 10:
								_ = 1000;
								/*Error near IL_039e: Member reference must be method, but was: Field*/;
							case 26:
							{
								object obj3 = obj;
								object obj4 = ((Rpc)Unsafe.AsPointer(ref this)).Logger__BackingField;
								((Rpc)((Rpc)Unsafe.AsPointer(ref this)).NeedCha__BackingField).NeedCha = (byte)(((Rpc)Unsafe.AsPointer(ref this)).UseCha__BackingField - 1) != 0;
								((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_03d4: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)obj3, ref *(TStateMachine*)obj4);
								obj = (object)/*Error near IL_03d6: Stack underflow*/;
								num = 18;
								continue;
							}
							case 24:
							case 25:
								((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_03e7: Stack underflow*/)->SetException((Exception)(&obj));
								num = 2;
								if (((Rpc)Rpc._chaChaEn)._chaChaDe == null)
								{
									num = 1;
								}
								continue;
							case 29:
								((Rpc)/*Error near IL_0410: Stack underflow*/).AddCallBack((ushort)/*Error near IL_0410: Stack underflow*/, (Func<RpcCallBack, Task>)Rpc.ParseMap);
								((ILogger)/*Error near IL_041d: Stack underflow*/).Information<bool>((string)/*Error near IL_041d: Stack underflow*/, (byte)(((Rpc._003CListenAsync_003Ed__34)this)._003C_003Et__builder - 1) != 0);
								num = 10;
								continue;
							case 4:
								return;
							case 5:
								break;
							case 18:
								if (((TaskAwaiter<RestResponse<EntityFeverManifest>>*)(&obj))->IsCompleted)
								{
									num = 13;
									if ((int)((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)Rpc._003CListenControlConnectAsync_003Ed__35._003C_003E4__this)->_003C_003Eu__1 != 0)
									{
										num = 25;
									}
									continue;
								}
								goto case 30;
							case 7:
								obj = -1;
								Rpc._003CListenControlConnectAsync_003Ed__35.ReflectSymbolicDecorator = -1;
								num = 23;
								continue;
							case 20:
								((Rpc._003CReceiveAsync_003Ed__28)this)._003C_003E1__state = (int)obj;
								num = 19;
								continue;
							case 30:
								obj = 1;
								((Rpc._003CReceiveAsync_003Ed__28)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)1;
								num = 20;
								continue;
							case 21:
								if (obj == null)
								{
									obj = 35;
									continue;
								}
								goto case 15;
							case 17:
								goto IL_050e;
							case 19:
								_ = ref ((Rpc._003CRemoteCallBackAsync_003Ed__21)this)._003C_003E1__state;
								((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CRetrySetIceCandidateAsync_003Ed__38, JavaGame._003CPrepareVersionAsync_003Ed__44>(ref this));
								_ = 13;
								continue;
							case 15:
							case 28:
								if (obj != null)
								{
									num = 8;
									continue;
								}
								goto case 27;
							case 33:
								((Rpc._003CListenControlConnectAsync_003Ed__35*)((Rpc._003CRemoteCallBackAsync_003Ed__21)this)._003C_003E4__this)->SetStateMachine((IAsyncStateMachine)((Rpc._003CRemoteCallBackAsync_003Ed__21)this).callBack);
								_ = Rpc._003CRemoteCallBackAsync_003Ed__21.MeasureCalc;
								((Rpc._003CReceiveAsync_003Ed__28*)Rpc._003CListenControlConnectAsync_003Ed__35.DecorateSeparatedSummarizer())->SetStateMachine((IAsyncStateMachine)((Rpc._003CSyncChaChaAsync_003Ed__38)this)._003C_003Et__builder);
								obj = Rpc._003CReceiveAsync_003Ed__28.DecorateOrderedTemplate();
								_ = 21;
								continue;
							case 3:
								Rpc._003CSyncChaChaAsync_003Ed__38.RateStack = null;
								num = 12;
								continue;
							case 1:
							case 2:
							case 6:
								goto end_IL_0026_2;
							}
							break;
						}
						goto IL_045e;
						IL_050e:
						obj = ((Rpc._003CReceiveAsync_003Ed__28)this).client;
						num = 3;
						if (Rpc._003CReceiveAsync_003Ed__28.CheckMonoProgram != null)
						{
							num = 3;
						}
						goto IL_009d;
						IL_045e:
						if ((nint)obj != 1)
						{
							num = 32;
							if ((int)((Rpc._003CListenControlConnectAsync_003Ed__35*)Rpc._003CListenControlConnectAsync_003Ed__35._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								num = 29;
							}
							goto IL_009d;
						}
						goto IL_050e;
						end_IL_0026_2:
						break;
					}
					((BedrockGamePath)Unsafe.AsPointer(ref this)).Launcher = (string)(-2);
					obj2 = 1;
					if (((ComponentPath)(object)BedrockGamePath.StartTemplate).IsDirectory)
					{
						obj2 = 3;
					}
					continue;
					end_IL_0026:
					break;
				}
				obj = ((JavaGameValue)Unsafe.AsPointer(ref this)).WindowWidth__BackingField;
				obj = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00䤀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00㘀(object P_0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00㜀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0050: Expected Obj, but got I4
			//IL_04c0: Expected native int or pointer, but got Obj
			//IL_04ea: Expected native int or pointer, but got Obj
			//IL_0077: Expected VT, but got I4
			//IL_03a9: Invalid comparison between Unknown and I4
			//IL_0093: Expected native int or pointer, but got Obj
			//IL_0141: Expected native int or pointer, but got Obj
			//IL_0154: Expected Ref, but got VT
			//IL_0368: Expected Obj, but got Ref
			//IL_03cf: Expected Obj, but got I4
			//IL_03ea: Expected I4, but got Obj
			//IL_03be: Expected Obj, but got Ref
			//IL_0343: Expected Obj, but got Ref
			//IL_0343: Expected Obj, but got Ref
			//IL_01c4: Expected Obj, but got I4
			//IL_01c4: Expected Ref, but got VT
			//IL_01d6: Expected Obj, but got VT
			//IL_01d6: Expected Obj, but got VT
			//IL_01dd: Expected Obj, but got Ref
			//IL_01ee: Expected I4, but got Obj
			//IL_01ee: Expected Obj, but got Unknown
			//IL_0194: Expected Obj, but got I4
			//IL_0199: Expected Obj, but got I4
			//IL_01a3: Expected native int or pointer, but got Obj
			//IL_011b: Expected Obj, but got Ref
			//IL_0327: Expected VT, but got Obj
			//IL_0330: Expected Obj, but got I4
			//IL_0174: Expected Obj, but got VT
			//IL_0176: Expected native int or pointer, but got Obj
			//IL_0180: Expected Obj, but got I4
			//IL_0315: Expected Obj, but got VT
			//IL_012a: Expected native int or pointer, but got Obj
			//IL_0109: Expected I4, but got Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04ca->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04f4->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0081->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04d5->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009d->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_04ff->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0280->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_03b8->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_00a8->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_028b->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_016a->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_0378->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_03de->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_0400->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_03ca->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_0357->IL00ac: Incompatible stack heights: 3 vs 1
			//IL_020e->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_01ad->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_02b0->IL00ac: Incompatible stack heights: 2 vs 1
			//IL_025d->IL00ac: Incompatible stack heights: 2 vs 1
			//IL_018f->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_031f->IL00ac: Incompatible stack heights: 3 vs 1
			//IL_040b->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_0362->IL00ac: Incompatible stack heights: 3 vs 1
			//IL_0219->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_01b8->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_02bb->IL00ac: Incompatible stack heights: 2 vs 1
			//IL_0134->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_013f->IL00ac: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				default:
					obj = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
					obj2 = 2;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 3;
					}
					break;
				case 5:
					((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1 = (TaskAwaiter)(-2);
					obj2 = 4;
					break;
				case 3:
					if (obj == null)
					{
						obj3 = 18;
						if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state != 0)
						{
							obj3 = 12;
						}
						goto IL_00ac;
					}
					goto IL_039c;
				case 2:
					return;
				case 1:
					obj = ((Rpc._003CReceiveAsync_003Ed__28)this)._003C_003E4__this;
					obj2 = 0;
					if (((Rpc._003CRemoteCallBackAsync_003Ed__21*)(nint)Rpc._003CReceiveAsync_003Ed__28.CheckMonoProgram)->_003C_003E1__state == 0)
					{
						obj2 = 0;
					}
					break;
				case 4:
					{
						RestRequestExtensions.AddQueryParameter<_0021_00210>((RestRequest)/*Error near IL_04e0: Stack underflow*/, (string)/*Error near IL_04e0: Stack underflow*/, (_0021_00210)/*Error near IL_04e0: Stack underflow*/, (byte)Unsafe.AsPointer(ref ((Rpc._003CRemoteCallBackAsync_003Ed__21)this)._003C_003Et__builder) != 0);
						_ = 1;
						if ((int)((Rpc._003CRemoteCallBackAsync_003Ed__21*)(nint)Rpc._003CRemoteCallBackAsync_003Ed__21.callBack)->_003C_003Eu__1 != 0)
						{
							_ = 2;
						}
						break;
					}
					IL_025d:
					((FeverInstaller._003CFeverRequest_003Ed__15<>*)obj)->SetStateMachine((IAsyncStateMachine)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor);
					obj = (object)/*Error near IL_026c: Stack underflow*/;
					obj3 = 1;
					if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003Et__builder)._003C_003E4__this != null)
					{
						obj3 = 14;
					}
					goto IL_00ac;
					IL_00ac:
					while (true)
					{
						switch ((int)obj3)
						{
						case 1:
						case 3:
						case 20:
							break;
						case 14:
						{
							object obj5 = obj;
							GC.SuppressFinalize((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Et__builder));
							if (obj5 == null)
							{
								obj3 = 12;
								if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 != 0)
								{
									obj3 = 3;
								}
								continue;
							}
							goto case 8;
						}
						default:
						{
							object obj4 = Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler;
							((AsyncTaskMethodBuilder*)((Task)obj).GetAwaiter())->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)null, ref *(TStateMachine*)1);
							((TaskAwaiter*)obj4)->GetResult();
							((ILogger)/*Error near IL_015e: Stack underflow*/).Error((Exception)/*Error near IL_015e: Stack underflow*/, (string)/*Error near IL_015e: Stack underflow*/);
							obj = (object)/*Error near IL_0160: Stack underflow*/;
							obj3 = 17;
							continue;
						}
						case 16:
							((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)/*Error near IL_0174: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)Authenticator._003CReceiveAsync_003Ed__9._003C_003Eu__1);
							((AsyncTaskMethodBuilder*)/*Error near IL_0180: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)obj)->_003C_003E1__state);
							((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)/*Error near IL_0185: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverManifestInfo>*)/*Error near IL_0185: Stack underflow*/, ref *(FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)/*Error near IL_0185: Stack underflow*/);
							obj3 = 20;
							continue;
						case 11:
							obj = -1;
							((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003E4__this = (Authenticator)(-1);
							obj3 = 2;
							if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003Cstream_003E5__2)->_003C_003Eu__1 == 0)
							{
								obj3 = 13;
							}
							continue;
						case 8:
						{
							Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10 obj6 = (Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)new Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10();
							((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)obj6)->SetStateMachine((IAsyncStateMachine)1);
							((FeverInstaller)/*Error near IL_01d6: Stack underflow*/)._002Ector((string)obj6, (string)obj6, (string)(object)((TcpClient)((FeverInstaller)obj)._003CappId_003EP).GetStream());
							_003F val = /*Error near IL_01d6: Stack underflow*/;
							RestClient client = ((FeverInstaller)((FeverInstaller)Unsafe.AsPointer(ref this)).Client__BackingField).Client;
							((Stream)val).Write((byte[])(object)client, (int)client, ((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003E1__state);
							((RestClientOptions)((FeverInstaller)/*Error near IL_01f3: Stack underflow*/).GetFeverManifestAsync((object)/*Error near IL_01f3: Stack underflow*/))._002Ector();
							obj = (object)/*Error near IL_01fa: Stack underflow*/;
							obj3 = 5;
							if (((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Eu__1)._003C_003E1__state == 0)
							{
								obj3 = 2;
							}
							continue;
						}
						case 10:
							return;
						case 13:
							_ = ((AsyncTaskMethodBuilder<EntityFeverManifest>*)(&obj))->Task;
							_ = 21;
							continue;
						case 19:
							goto IL_025d;
						case 12:
							((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)/*Error near IL_0295: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)FeverInstaller._003CGetFeverManifestAsync_003Ed__12.info);
							((RpcCallBack)obj).As<EntityChaChaHandShake>();
							_ = 0;
							if ((int)((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								_ = 1;
							}
							continue;
						case 17:
							_ = ref obj;
							/*Error near IL_02cc: Member reference must be method, but was: Field*/;
						case 21:
							((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)/*Error near IL_02ff: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CheckScalableWorker);
							_ = ((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Et__builder;
							JsonSerializer.Serialize((EntityUserPropertiesEx)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.DecorateGroupedVisitor(), (JsonSerializerOptions?)((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Eu__1);
							_ = 3;
							continue;
						case 15:
							((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Eu__3 = (TaskAwaiter<EntityFeverManifest>)obj;
							obj = 7;
							obj3 = obj;
							continue;
						case 7:
							_ = ref FeverInstaller._003CInstallAsync_003Ed__11.ReflectAccessibleWatcher;
							((IEnumerable<string>)(&obj)).Select((Func<string, string>)Unsafe.AsPointer(ref this));
							_ = 10;
							if (((Rpc)Rpc.Logger__BackingField).NeedCha__BackingField != 0)
							{
								_ = 7;
							}
							continue;
						case 2:
							Unsafe.As<nint, @null>(ref ((Rpc)Unsafe.AsPointer(ref this)).UseCha__BackingField) = null;
							obj3 = 11;
							continue;
						case 9:
							goto IL_039c;
						case 6:
						case 18:
							obj = Rpc.ParseMap;
							obj3 = 2;
							continue;
						case 4:
							obj = 0;
							((Rpc._003CListenAsync_003Ed__34)this)._003C_003E1__state = 0;
							obj3 = 15;
							continue;
						case 5:
							((RestRequest)/*Error near IL_03e3: Stack underflow*/)._002Ector((string)/*Error near IL_03e3: Stack underflow*/, (Method)/*Error near IL_03e3: Stack underflow*/);
							obj = RestRequestExtensions.AddQueryParameter((RestRequest)/*Error near IL_03ea: Stack underflow*/, (string)/*Error near IL_03ea: Stack underflow*/, (string)/*Error near IL_03ea: Stack underflow*/, (byte)(int)obj != 0);
							obj3 = 0;
							if (Rpc._003CListenAsync_003Ed__34.DecorateIterableWriter == null)
							{
								obj3 = 0;
							}
							continue;
						}
						break;
					}
					goto case 5;
					IL_039c:
					((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)/*Error near IL_03a8: Stack underflow*/)->SetResult((EntityFeverAppVersion)((Rpc)obj)._chaChaEn);
					if ((int)/*Error near IL_03ae: Stack underflow*/ != 2)
					{
						obj3 = 16;
						goto IL_00ac;
					}
					goto IL_025d;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00㴀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
	public unsafe WebRtc(DesktopSession session, string url)
	{
		//IL_001b: Expected I4, but got Obj
		//IL_0016: Expected native int or pointer, but got Obj
		//IL_0027: Expected VT, but got Obj
		//IL_0022: Expected native int or pointer, but got Obj
		//IL_0037: Expected VT, but got Obj
		//IL_0047: Expected I4, but got VT
		//IL_0057: Expected Obj, but got VT
		//IL_0052: Expected native int or pointer, but got Obj
		//IL_0067: Expected VT, but got Obj
		//IL_0062: Expected native int or pointer, but got Obj
		//IL_0077: Expected I4, but got VT
		//IL_0072: Expected native int or pointer, but got Obj
		//IL_0087: Expected Obj, but got VT
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)session;
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Et__builder, (AsyncTaskMethodBuilder)url);
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)/*Error near IL_0037: Stack underflow*/)->_003C_003Eu__1, (TaskAwaiter)new Task((Func<Task?>)(object)this));
		((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)/*Error near IL_0047: Stack underflow*/)->_003C_003E1__state = (int)new AsyncTaskMethodBuilder(ref *(TStateMachine*)this);
		Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->listener, (TcpListener)new AsyncTaskMethodBuilder());
		Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003Eu__1, (TaskAwaiter<TcpClient>)new TcpListener());
		((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003E1__state = (new TaskAwaiter() ? 1 : 0);
		Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)(nint)/*Error near IL_0087: Stack underflow*/)->_003C_003E4__this, (Authenticator)new AsyncTaskMethodBuilder(ref *(TAwaiter*)/*Error near IL_0082: Stack underflow*/, ref *(TStateMachine*)this));
		((ILogger)/*Error near IL_0092: Stack underflow*/).Error((Exception)/*Error near IL_0092: Stack underflow*/, (string)(object)this);
		int num = 0;
		if (Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain == null)
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
	internal unsafe void _FF00_FF00_FF00_FF00퀀(Action<string, byte[]> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0097: Expected native int or pointer, but got Obj
		//IL_00a7: Expected Obj, but got I
		//IL_0077: Expected native int or pointer, but got Obj
		//IL_0050: Expected VT, but got Obj
		//IL_0057: Expected Obj, but got VT
		//IL_0061: Expected native int or pointer, but got Obj
		//IL_00c4: Expected native int or pointer, but got Obj
		//IL_00b1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0088->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0076->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ce->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d9->IL0026: Incompatible stack types: I4 vs Obj
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
			case 4:
				((ILogger)/*Error near IL_0050: Stack underflow*/).Debug<_0021_00210>((string)obj, (_0021_00210)P_0);
				obj = (TaskAwaiter<string>)/*Error near IL_0051: Stack underflow*/;
				obj2 = 0;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				obj = Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton;
				obj2 = 2;
				break;
			case 2:
				obj = obj;
				obj2 = 4;
				break;
			default:
			{
				int* ptr = &((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E1__state;
				((AsyncTaskMethodBuilder*)obj)->Start(ref *(FeverInstaller._003CInstallAsync_003Ed__11*)obj);
				obj = (object)ptr;
				obj2 = 5;
				break;
			}
			case 5:
				if (obj == obj)
				{
					obj2 = 1;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this != null)
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
	internal unsafe void _FF00_FF00_FF00_FF00툀(Action<string> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0071: Expected native int or pointer, but got Obj
		//IL_0091: Expected Obj, but got VT
		//IL_00b2: Expected native int or pointer, but got Obj
		//IL_00c2: Expected Obj, but got I
		//IL_00f9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0082->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0104->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
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
				if (obj == obj)
				{
					obj2 = 1;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)Authenticator._003CListenAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						obj2 = 1;
					}
					continue;
				}
				break;
			case 3:
				obj = ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E4__this;
				obj2 = 2;
				continue;
			case 4:
			{
				object obj3 = obj;
				((TcpListener)(object)P_0).Start();
				obj = (AsyncTaskMethodBuilder<EntityFeverAppVersion>)obj3;
				obj2 = 5;
				if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					obj2 = 1;
				}
				continue;
			}
			case 1:
				return;
			case 5:
			{
				TcpListener* ptr = &((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->listener;
				((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)obj)->Start(ref *(FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)obj);
				obj = (object)ptr;
				obj2 = 0;
				if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
				{
					obj2 = 0;
				}
				continue;
			}
			case 2:
				break;
			}
			obj = obj;
			obj2 = 1;
			if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder == 0)
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
		//IL_001d: Expected Obj, but got I4
		//IL_006b: Expected I4, but got Obj
		//IL_01c7: Expected Obj, but got Ref
		//IL_044d: Expected native int or pointer, but got Obj
		//IL_0464: Expected Obj, but got I4
		//IL_017c: Expected Obj, but got VT
		//IL_0186: Expected native int or pointer, but got Obj
		//IL_00f3: Expected native int or pointer, but got Obj
		//IL_011d: Expected native int or pointer, but got Obj
		//IL_0095: Expected native int or pointer, but got Obj
		//IL_00b6: Expected Obj, but got I4
		//IL_00b7: Expected I4, but got Obj
		//IL_0487: Expected VT, but got Ref
		//IL_019e: Expected Obj, but got I4
		//IL_0218: Expected native int or pointer, but got Obj
		//IL_0355: Expected Obj, but got VT
		//IL_035f: Expected native int or pointer, but got Obj
		//IL_02f8: Expected native int or pointer, but got Obj
		//IL_0253: Expected Obj, but got Ref
		//IL_0375: Expected native int or pointer, but got Obj
		//IL_03a5: Expected native int or pointer, but got Obj
		//IL_00ba: Expected I4, but got Obj
		//IL_0469->IL0022: Incompatible stack heights: 3 vs 0
		//IL_0190->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011c->IL0026: Incompatible stack heights: 3 vs 1
		//IL_01b2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_019b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0108->IL0026: Incompatible stack types: I4 vs Obj
		//IL_013a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0150->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0175->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0496->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01bd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_023a->IL01d5: Incompatible stack heights: 6 vs 3
		//IL_02c4->IL03c5: Incompatible stack heights: 1 vs 2
		//IL_030b->IL03a4: Incompatible stack heights: 3 vs 2
		//IL_0258->IL0392: Incompatible stack heights: 4 vs 2
		//IL_02b2->IL03c5: Incompatible stack heights: 1 vs 2
		//IL_039a->IL03c5: Incompatible stack heights: 1 vs 2
		//IL_0245->IL01d5: Incompatible stack heights: 6 vs 3
		//IL_02ce->IL01d5: Incompatible stack heights: 2 vs 3
		//IL_031f->IL01d5: Incompatible stack heights: 4 vs 3
		//IL_026c->IL01d5: Incompatible stack heights: 5 vs 3
		//IL_02bc->IL01d5: Incompatible stack heights: 2 vs 3
		//IL_03a4->IL01d5: Incompatible stack heights: 2 vs 3
		//IL_032a->IL01d5: Incompatible stack heights: 4 vs 3
		//IL_0277->IL01d5: Incompatible stack heights: 5 vs 3
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 4;
		while (true)
		{
			object obj = stateMachine;
			while (true)
			{
				switch ((int)obj)
				{
				case 7:
					if (((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E4__this == null)
					{
						obj = 13;
						continue;
					}
					goto case 5;
				case 6:
				case 9:
				case 13:
					return (byte)(int)((Authenticator)((Array)stateMachine).Length).ListenAsync();
				case 3:
					stateMachine = Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton;
					obj = 14;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj = 8;
					}
					continue;
				case 4:
					((Authenticator)P_1).Dispose();
					stateMachine = this;
					obj = 0;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj = 3;
					}
					continue;
				case 12:
					stateMachine = Authenticator.PatchUser();
					_ = 9;
					continue;
				case 5:
					((AsyncTaskMethodBuilder*)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003E1__state)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)stateMachine, ref *(TStateMachine*)(&stateMachine));
					if ((int)/*Error near IL_0130: Stack underflow*/ == 0)
					{
						obj = 6;
						continue;
					}
					goto case 12;
				case 8:
				case 15:
					return Authenticator._003CListenAsync_003Ed__7.DecorateExpandableParser() ? ((byte)1) : ((byte)0);
				case 10:
					if (Authenticator._003CListenAsync_003Ed__7.ObserveTracker() != null)
					{
						stateMachine = P_0;
						_ = 7;
					}
					else
					{
						_ = 11;
					}
					continue;
				case 2:
					stateMachine = new Authenticator._003CListenAuthenticationConnectAsync_003Ed__8();
					obj = 0;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain)->_003C_003E1__state != 0)
					{
						obj = 1;
					}
					continue;
				case 14:
					stateMachine = 0;
					obj = 0;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Et__builder).client == null)
					{
						obj = 0;
					}
					continue;
				default:
				{
					Task<TcpClient> task = ((TcpListener)(&stateMachine)).AcceptTcpClientAsync();
					int num = 8;
					while (true)
					{
						switch (num)
						{
						case 2:
							return (byte)(int)stateMachine;
						case 1:
							_ = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003Cstream_003E5__2;
							((TaskAwaiter<TcpClient>*)stateMachine)->GetResult();
							_ = 3;
							if (((FeverInstaller)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway)._003CfeverVersion_003EP != null)
							{
								_ = 0;
							}
							continue;
						case 8:
							_ = ((FeverInstaller)this)._003CappId_003EP;
							if (((TcpClient)(&stateMachine)).GetStream() == null)
							{
								_ = 0;
								if (((FeverInstaller)FeverInstaller.McBedrock__BackingField).Client__BackingField == null)
								{
									_ = 7;
								}
								continue;
							}
							goto case 12;
						case 11:
							if (task == stateMachine)
							{
								_ = 13;
								continue;
							}
							break;
						case 5:
							if (task == stateMachine)
							{
								_ = 10;
								continue;
							}
							break;
						case 3:
							stateMachine = ((FeverInstaller)stateMachine).GetFeverManifestInfoAsync(P_0);
							num = 0;
							if (((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Eu__1)._003C_003E1__state != 0)
							{
								num = 2;
							}
							continue;
						case 6:
						case 7:
						{
							_ = ((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)this)->_003C_003Et__builder;
							object obj3 = stateMachine;
							((RestClient*)(&stateMachine))->Dispose();
							if (obj3 != null)
							{
								_ = 10;
								if (FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor != null)
								{
									_ = 11;
								}
								continue;
							}
							goto case 13;
						}
						case 4:
							stateMachine = new FeverInstaller._003CFeverRequest_003Ed__15<>();
							num = 1;
							if ((int)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12.info)->_003C_003Eu__1 == 0)
							{
								num = 0;
							}
							continue;
						case 9:
						case 10:
						{
							object obj2 = FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReflectReporter;
							((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)stateMachine)->Start<TStateMachine>(ref *(TStateMachine*)(&stateMachine));
							if (obj2 == null)
							{
								num = 4;
								continue;
							}
							goto case 3;
						}
						case 12:
							if (task == stateMachine)
							{
								_ = 6;
								continue;
							}
							break;
						case 13:
							_ = ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)this)->_003C_003E4__this;
							FeverInstaller._003CGetFeverManifestAsync_003Ed__12.SearchChain();
							_ = ref stateMachine;
							/*Error near IL_03b1: Member reference must be method, but was: Field*/;
						}
						break;
					}
					goto case 10;
				}
				case 1:
					break;
				case 11:
					if (RestClientExtensions.ExecuteAsync<_0021_00210>((IRestClient)((Rpc)this).Logger__BackingField, (RestRequest)stateMachine, (CancellationToken)(&stateMachine)) != null)
					{
						obj = 8;
						continue;
					}
					goto case 2;
				}
				break;
			}
			_ = FeverInstaller._003CInstallAsync_003Ed__11.ReflectAccessibleWatcher;
			_ = ((TaskAwaiter<RestResponse<EntityFeverResponse<_00210>>>*)stateMachine)->IsCompleted;
			stateMachine = 15;
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
	private unsafe void _FF00_FF00_FF00_FF00_FFFD(object P_0, object P_1, object P_2)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_006f: Expected I4, but got Obj
		//IL_0173: Expected native int or pointer, but got Obj
		//IL_0097: Expected native int or pointer, but got Obj
		//IL_0265: Expected native int or pointer, but got Obj
		//IL_0139: Expected Obj, but got VT
		//IL_0139: Expected Ref, but got VT
		//IL_0151: Expected native int or pointer, but got Obj
		//IL_024d: Expected Ref, but got VT
		//IL_025a: Expected I4, but got VT
		//IL_0239: Expected Obj, but got I4
		//IL_0281: Expected native int or pointer, but got Obj
		//IL_01f5: Expected Obj, but got I4
		//IL_01fb: Expected I4, but got Obj
		//IL_01cf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0187->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a1->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00fb->IL01ab: Incompatible stack heights: 1 vs 0
		//IL_015b->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0264->IL0026: Incompatible stack heights: 4 vs 1
		//IL_012e->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0243->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ac->IL0026: Incompatible stack heights: 2 vs 1
		//IL_010f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_028b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0166->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0205->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00eb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ea->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011a->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0296->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
			{
				TcpListener? authenticator = new Authenticator();
				((Authenticator)(object)authenticator).Listener = authenticator;
				((Authenticator)/*Error near IL_0084: Stack underflow*/).StartListening((int)/*Error near IL_0084: Stack underflow*/);
				/*Error near IL_0084: Stack underflow*/;
				obj = ((Authenticator)P_2).ListenAsync();
				_ = 15;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state != 0)
				{
					_ = 1;
				}
				continue;
			}
			case 8:
				return;
			case 13:
				((IAsyncStateMachine)((Authenticator)/*Error near IL_00d7: Stack underflow*/).HandleAuthentication((string)P_1)).MoveNext();
				if ((int)/*Error near IL_00e1: Stack underflow*/ != 0)
				{
					obj2 = 7;
					continue;
				}
				goto case 6;
			case 6:
				if ((int)((Task)(object)Authenticator.PatchUser()).GetAwaiter() != 0)
				{
					_ = 2;
					if (((Authenticator._003CReceiveAsync_003Ed__9)Authenticator._003CReceiveAsync_003Ed__9._003C_003Et__builder)._003C_003E4__this != null)
					{
						_ = 1;
					}
					continue;
				}
				goto case 12;
			case 15:
				Authenticator._003CListenAsync_003Ed__7.ObserveTracker();
				_ = 5;
				continue;
			case 10:
			{
				Authenticator._003CListenAuthenticationConnectAsync_003Ed__8 obj4 = (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)new Authenticator._003CListenAuthenticationConnectAsync_003Ed__8();
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)obj4)->SetStateMachine((IAsyncStateMachine)obj4);
				Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateGenericStruct();
				obj = Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.ReflectRandomReporter();
				_ = 0;
				if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.client)->_003C_003E4__this == null)
				{
					_ = 0;
				}
				continue;
			}
			case 1:
				_ = Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003Cstream_003E5__2;
				((AsyncTaskMethodBuilder*)Authenticator._003CReceiveAsync_003Ed__9.DecorateConvertibleParameter())->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverManifest>*)obj, ref *(FeverInstaller._003CInstallAsync_003Ed__11*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway);
				_ = 10;
				continue;
			default:
				((FeverInstaller)/*Error near IL_01c4: Stack underflow*/)._002Ector((string)(object)this, (string)obj, (string)obj);
				obj2 = 3;
				continue;
			case 5:
				return;
			case 2:
				if (((TaskAwaiter<string>*)((FeverInstaller)this).Client__BackingField)->GetResult() != null)
				{
					obj2 = 11;
					continue;
				}
				goto case 9;
			case 3:
				return;
			case 12:
				((IEnumerable<byte>)((FeverInstaller)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003E1__state).InstallAsync()).Take((int)P_1);
				_ = 8;
				continue;
			case 7:
			case 16:
			{
				int num = FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E1__state;
				FeverInstaller._002Ecctor();
				((ILogger)/*Error near IL_0239: Stack underflow*/).Error<IPAddress>((string)num, (IPAddress)P_0);
				obj2 = 4;
				continue;
			}
			case 14:
				((FeverInstaller._003CFeverRequest_003Ed__15<>*)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003Eu__1)->MoveNext();
				((IReadOnlyDictionary<ushort, Func<RpcCallBack, Task>>)P_2).GetValueOrDefault((ushort)(int)AsyncTaskMethodBuilder<EntityFeverManifest>.Create());
				_ = 13;
				continue;
			case 9:
				obj3 = ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)this)->_003C_003E4__this;
				break;
			case 11:
				obj3 = P_0;
				break;
			}
			obj = obj3;
			obj2 = 0;
			if ((int)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12.info)->_003C_003Eu__1 == 0)
			{
				obj2 = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004f: Expected I4, but got Obj
		//IL_0083: Expected Obj, but got VT
		//IL_03f6: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I4
		//IL_009a: Expected native int or pointer, but got Obj
		//IL_03ab: Expected native int or pointer, but got Obj
		//IL_00c2: Expected Obj, but got I4
		//IL_0114: Expected I4, but got Obj
		//IL_0183: Invalid comparison between VT and Obj
		//IL_022c: Expected Obj, but got Ref
		//IL_0267: Expected Obj, but got I4
		//IL_026b: Expected native int or pointer, but got Obj
		//IL_01e7: Invalid comparison between VT and Obj
		//IL_0280: Expected native int or pointer, but got Obj
		//IL_028a: Expected I4, but got VT
		//IL_0127: Expected native int or pointer, but got Obj
		//IL_01c4: Expected native int or pointer, but got Obj
		//IL_01ca: Expected native int or pointer, but got Obj
		//IL_01df: Expected Obj, but got I4
		//IL_0253: Expected Obj, but got VT
		//IL_02e1: Expected native int or pointer, but got Obj
		//IL_0193: Expected native int or pointer, but got Obj
		//IL_01ae: Expected native int or pointer, but got Obj
		//IL_0171: Invalid comparison between VT and Obj
		//IL_029a: Expected native int or pointer, but got Obj
		//IL_039f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03fb->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0071->IL0026: Incompatible stack heights: 2 vs 1
		//IL_03aa->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0406->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00af->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0422->IL0026: Incompatible stack heights: 3 vs 1
		//IL_03cb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007c->IL0026: Incompatible stack heights: 2 vs 1
		//IL_042d->IL0026: Incompatible stack heights: 3 vs 1
		//IL_03d6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0188->IL02c6: Incompatible stack heights: 2 vs 3
		//IL_0231->IL0180: Incompatible stack heights: 5 vs 3
		//IL_027f->IL00cb: Incompatible stack heights: 6 vs 4
		//IL_01ec->IL0180: Incompatible stack heights: 2 vs 3
		//IL_028f->IL025d: Incompatible stack heights: 1 vs 3
		//IL_0131->IL00cb: Incompatible stack types: I4 vs Obj
		//IL_01e4->IL00c7: Incompatible stack heights: 6 vs 3
		//IL_025d->IL00cb: Incompatible stack heights: 3 vs 4
		//IL_02f3->IL021a: Incompatible stack heights: 6 vs 3
		//IL_01b8->IL00cb: Incompatible stack heights: 5 vs 4
		//IL_0176->IL021a: Incompatible stack heights: 2 vs 3
		//IL_02bb->IL00cb: Incompatible stack heights: 6 vs 4
		//IL_0154->IL00cb: Incompatible stack types: I4 vs Obj
		//IL_02e0->IL00cb: Incompatible stack types: I4 vs Obj
		//IL_0192->IL00cb: Incompatible stack heights: 3 vs 4
		//IL_0245->IL00cb: Incompatible stack heights: 6 vs 4
		//IL_01f6->IL00cb: Incompatible stack heights: 3 vs 4
		//IL_0299->IL00cb: Incompatible stack heights: 2 vs 4
		//IL_013c->IL00cb: Incompatible stack types: I4 vs Obj
		//IL_02fd->IL00cb: Incompatible stack heights: 7 vs 4
		//IL_01c3->IL00cb: Incompatible stack heights: 5 vs 4
		//IL_0180->IL00cb: Incompatible stack heights: 3 vs 4
		//IL_02c6->IL00cb: Incompatible stack heights: 6 vs 4
		//IL_015f->IL00cb: Incompatible stack types: I4 vs Obj
		//IL_0250->IL00cb: Incompatible stack heights: 6 vs 4
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
			case 8:
				obj = ((Authenticator)P_0).Listener;
				_ = 6;
				if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
				{
					_ = 2;
				}
				break;
			case 1:
				obj = Authenticator._003CListenAsync_003Ed__7._003C_003Eu__1;
				obj2 = 4;
				break;
			case 4:
				obj = 0;
				obj2 = 6;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state != 0)
				{
					obj2 = 7;
				}
				break;
			case 7:
			{
				AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
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
							obj3 = 0;
							if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this != null)
							{
								obj3 = 0;
							}
							continue;
						case 15:
							obj = obj;
							obj3 = 4;
							if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
							{
								obj3 = 4;
							}
							continue;
						case 12:
							if (asyncTaskMethodBuilder != (AsyncTaskMethodBuilder)obj)
							{
								_ = 15;
								continue;
							}
							goto case 1;
						default:
							if (asyncTaskMethodBuilder != (AsyncTaskMethodBuilder)obj)
							{
								_ = 14;
								continue;
							}
							goto case 16;
						case 11:
							_ = ((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003E4__this;
							((AsyncTaskMethodBuilder*)Authenticator._003CListenAsync_003Ed__7.ObserveTracker())->SetException((Exception)obj);
							_ = 3;
							if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain)->_003C_003E1__state != 0)
							{
								_ = 6;
							}
							continue;
						case 8:
							break;
						case 5:
							if (asyncTaskMethodBuilder != (AsyncTaskMethodBuilder)obj)
							{
								_ = 7;
								continue;
							}
							goto default;
						case 1:
							_ = ((FeverInstaller)this)._003CfeverVersion_003EP;
							Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.DecorateFlexibleProfiler();
							if (((TcpClient)(&obj)).GetStream() != null)
							{
								_ = 0;
								if (((FeverInstaller)FeverInstaller.McBedrock__BackingField).Client__BackingField == null)
								{
									_ = 5;
								}
								continue;
							}
							goto default;
						case 9:
							obj = asyncTaskMethodBuilder;
							_ = 10;
							continue;
						case 2:
							((FeverInstaller)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003E1__state).InstallAsync();
							((AsyncTaskMethodBuilder*)P_0)->Start(ref *(Rpc._003CListenAsync_003Ed__34*)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)this)->_003C_003E4__this);
							_ = 13;
							continue;
						case 6:
							((RestClientOptions)asyncTaskMethodBuilder).AutomaticDecompression = (DecompressionMethods)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)this)->_003C_003Eu__1;
							if (&obj == null)
							{
								_ = 8;
								continue;
							}
							goto case 2;
						case 14:
							_ = ((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)this)->_003C_003Et__builder;
							((RestClient)obj).Dispose();
							_ = 11;
							if (FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor == null)
							{
								_ = 2;
							}
							continue;
						case 16:
							((AsyncTaskMethodBuilder*)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E1__state)->AwaitUnsafeOnCompleted(ref *(FeverInstaller._003CFeverRequest_003Ed__15<>.CheckAdaptableResponder() ? ((TaskAwaiter*)1) : ((TaskAwaiter*)null)), ref *(Rpc._003CRemoteCallBackAsync_003Ed__21*)P_0);
							obj3 = 3;
							continue;
						case 10:
							_ = ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)this)->info;
							_ = ref obj;
							if ((int)AsyncTaskMethodBuilder<EntityFeverAppVersion>.Create() != 0)
							{
								_ = 12;
								continue;
							}
							goto case 1;
						case 3:
						case 13:
							goto end_IL_00c7;
						}
						break;
					}
					_ = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003C_003Et__builder;
					_ = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->client;
					((TcpListener)obj).AcceptTcpClientAsync();
					obj = 2;
					continue;
					end_IL_00c7:
					break;
				}
				goto default;
			}
			default:
				((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)this)->SetStateMachine((IAsyncStateMachine)P_0);
				obj2 = 8;
				if (((FeverInstaller._003CInstallAsync_003Ed__11)FeverInstaller._003CInstallAsync_003Ed__11._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj2 = 1;
				}
				break;
			case 6:
				if ((int)((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)this)->_003C_003Eu__1 == 0)
				{
					obj2 = 5;
					if ((int)((FeverInstaller._003CInstallAsync_003Ed__11)FeverInstaller._003CInstallAsync_003Ed__11._003C_003Eu__2)._003C_003Eu__3 == 0)
					{
						obj2 = 5;
					}
					break;
				}
				((TaskAwaiter<RestResponse<EntityFeverResponse<_00210>>>*)obj)->GetResult();
				_ = 1;
				if (((Rpc)Rpc.Writer__BackingField).Listener__BackingField != null)
				{
					_ = 3;
				}
				break;
			case 3:
				return;
			case 2:
				string.Join((char)((Rpc)FeverInstaller._003CInstallAsync_003Ed__11.ReflectAccessibleWatcher).ProcessId, (IEnumerable<string>)P_0);
				_ = 1;
				if (((Rpc)Rpc.NeedCha__BackingField).UseCha__BackingField == 0)
				{
					_ = 0;
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
	internal unsafe static object _FF00_FF00_FF00_FF00_E200()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00bb: Expected native int or pointer, but got Obj
		//IL_004b: Expected I, but got Obj
		//IL_00fe: Expected I, but got Obj
		//IL_006f: Invalid comparison between Unknown and Obj
		//IL_0096: Invalid comparison between Unknown and Obj
		//IL_004c: Expected native int or pointer, but got Obj
		//IL_0056: Expected Obj, but got I4
		//IL_005d: Expected Obj, but got Ref
		//IL_007e: Expected native int or pointer, but got Obj
		//IL_00ff: Expected native int or pointer, but got Obj
		//IL_00a5: Expected native int or pointer, but got Obj
		//IL_0130: Expected I4, but got VT
		//IL_0131: Expected I, but got Obj
		//IL_0125: Expected Obj, but got I
		//IL_012b: Expected Obj, but got VT
		//IL_00cd->IL006c: Incompatible stack heights: 2 vs 0
		//IL_00e1->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0088->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00af->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ec->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0093->IL0026: Incompatible stack types: I4 vs Obj
		//IL_012b->IL012b: Incompatible stack heights: 2 vs 1
		//IL_00ba->IL0026: Incompatible stack types: I4 vs Obj
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
				return (nint)obj;
			default:
				((Authenticator)/*Error near IL_0056: Stack underflow*/).Listener = (TcpListener?)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
				if (Task.Run((Func<Task?>)(&obj)) != null)
				{
					obj2 = 5;
					continue;
				}
				break;
			case 4:
			{
				object obj3 = obj;
				if ((object)/*Error near IL_0074: Stack underflow*/ != obj3)
				{
					obj2 = 2;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state != 0)
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
				if ((object)/*Error near IL_009b: Stack underflow*/ != obj4)
				{
					obj2 = 3;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this != null)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			}
			case 1:
				_ = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003Eu__1;
				if (!((TaskAwaiter*)(&obj))->IsCompleted)
				{
					_ = 0;
					if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder != 0)
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
		((ILogger)/*Error near IL_0109: Stack underflow*/).Error((Exception)/*Error near IL_0109: Stack underflow*/, (string)(object)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003E4__this);
		TaskAwaiter taskAwaiter = Authenticator._003CReceiveAsync_003Ed__9._003C_003Eu__1;
		if ((int)taskAwaiter == 0)
		{
			_ = Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain;
			Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.client = (TcpClient)new AsyncTaskMethodBuilder((IAsyncStateMachine)(delegate*<bool>)(&Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateGenericStruct));
		}
		return (nint)RestRequestExtensions.AddQueryParameter<int>((RestRequest)/*Error near IL_0130: Stack underflow*/, (string)/*Error near IL_0130: Stack underflow*/, (int)/*Error near IL_0130: Stack underflow*/, (byte)(int)taskAwaiter != 0);
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
	internal unsafe void _FF00_FF00_FF00_FF00_E700(Action<string> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0097: Expected Obj, but got I4
		//IL_0064: Expected native int or pointer, but got Obj
		//IL_0049: Expected native int or pointer, but got Obj
		//IL_0059: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got VT
		//IL_007f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c4->IL0026: Incompatible stack types: I4 vs Obj
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
				default:
					return;
				case 3:
				{
					int* ptr = &((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
					((AsyncTaskMethodBuilder*)obj)->Start(ref *(Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)obj);
					obj = (object)ptr;
					obj2 = 4;
					continue;
				}
				case 2:
					obj = ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E4__this;
					obj2 = 0;
					if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
					{
						obj2 = 1;
					}
					continue;
				case 1:
					break;
				case 4:
					if (obj == obj)
					{
						obj2 = 0;
						if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder != 0)
						{
							obj2 = 0;
						}
						continue;
					}
					break;
				case 5:
				{
					object obj3 = obj;
					GC.SuppressFinalize(P_0);
					obj = (AsyncTaskMethodBuilder<_00210>)obj3;
					obj2 = 3;
					if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
					{
						obj2 = 3;
					}
					continue;
				}
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
	internal unsafe void _FF00_FF00_FF00_FF00_EA00(Action<Exception> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00ea: Expected native int or pointer, but got Obj
		//IL_00fa: Expected Obj, but got VT
		//IL_0103: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got VT
		//IL_0085: Expected native int or pointer, but got Obj
		//IL_009b: Expected native int or pointer, but got Obj
		//IL_00a2: Expected Obj, but got VT
		//IL_00ac: Expected native int or pointer, but got Obj
		//IL_0108->IL0022: Incompatible stack heights: 2 vs 0
		//IL_008f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0060->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009a->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00de->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e9->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					obj2 = 2;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)Authenticator._003CListenAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj2 = 1;
					}
					continue;
				case 1:
					return;
				case 2:
					obj = (AsyncTaskMethodBuilder<EntityFeverManifestInfo>)Task.Run((Func<Task?>)(object)P_0);
					_ = 0;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state != 0)
					{
						_ = 0;
					}
					continue;
				case 5:
					obj = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003Et__builder;
					obj2 = 4;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
					{
						obj2 = 0;
					}
					continue;
				case 3:
					if (obj == obj)
					{
						obj2 = 1;
						if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 4;
				}
				break;
			}
			_ = &((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003E1__state;
			obj = ((RestResponse<EntityFeverResponse<_00210>>)obj).EnsureSuccessStatusCode<_00210>();
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
	internal unsafe void _FF00_FF00_FF00_FF00_EF00(byte P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_003f: Expected native int or pointer, but got Obj
		//IL_006d: Expected Obj, but got VT
		//IL_0091: Expected native int or pointer, but got Obj
		//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a6->IL0026: Incompatible stack types: I4 vs Obj
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
				((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = P_0;
				obj2 = 0;
				if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
				{
					obj2 = 0;
				}
				break;
			case 2:
			{
				object client = ((Authenticator)/*Error near IL_006d: Stack underflow*/).ListenAuthenticationConnectAsync((object)Authenticator._003CListenAsync_003Ed__7._003C_003Eu__1);
				object obj3 = ((P_0 != 0) ? ((Authenticator)/*Error near IL_0082: Stack underflow*/).ReceiveAuthenticationDataAsync(client) : ((Authenticator)/*Error near IL_0078: Stack underflow*/).ReceiveAsync(client));
				((AsyncTaskMethodBuilder<EntityFeverManifest>*)/*Error near IL_0087: Stack underflow*/)->Start(ref *(FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)obj3);
				obj2 = 0;
				if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					obj2 = 1;
				}
				break;
			}
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
	private unsafe void _FF00_FF00_FF00_FF00_F200(object P_0, object P_1, uint P_2, object P_3)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0075: Expected native int or pointer, but got Obj
		//IL_004b: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_007f->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00c6->IL0026: Incompatible stack heights: 8 vs 1
		//IL_008a->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00d1->IL0026: Incompatible stack heights: 8 vs 1
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
				default:
					return;
				case 0:
					return;
				case 3:
					break;
				case 1:
					((Authenticator)P_0).ListenAsync();
					_ = 0;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
					{
						_ = 0;
					}
					continue;
				case 2:
				{
					object authenticator = new Authenticator((object)/*Error near IL_008f: Stack underflow*/);
					((Authenticator)authenticator).Dispose();
					((Authenticator)/*Error near IL_009a: Stack underflow*/).HandleAuthentication((string)authenticator);
					Authenticator.ReflectMonoObject();
					Authenticator authenticator2 = Authenticator.PatchUser();
					((Authenticator._003CListenAsync_003Ed__7*)P_3)->MoveNext();
					obj = authenticator2;
					_ = 1;
					if (((Authenticator._003CReceiveAsync_003Ed__9)Authenticator._003CReceiveAsync_003Ed__9._003C_003Et__builder)._003C_003E4__this == null)
					{
						_ = 1;
					}
					continue;
				}
				}
				break;
			}
			((Authenticator)/*Error near IL_004b: Stack underflow*/).Listener = (TcpListener?)Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
			((AsyncTaskMethodBuilder*)P_0)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)P_1, ref *(Authenticator._003CListenAsync_003Ed__7*)P_2);
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_F300()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		//IL_001d: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_0091: Expected Obj, but got I4
		//IL_00f8: Expected Obj, but got Ref
		//IL_0102: Expected native int or pointer, but got Obj
		//IL_006a: Expected VT, but got I4
		//IL_0074: Expected native int or pointer, but got Obj
		//IL_00a7: Expected VT, but got Obj
		//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010c->IL0026: Incompatible stack heights: 3 vs 1
		//IL_007e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00df->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0117->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ea->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 7;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				((Authenticator._003CListenAsync_003Ed__7*)(&obj))->_003C_003E1__state = (int)P_0;
				obj2 = 3;
				break;
			case 5:
				((Authenticator._003CListenAsync_003Ed__7*)(&obj))->_003C_003Et__builder = (AsyncTaskMethodBuilder)P_2;
				obj2 = 0;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
				{
					obj2 = 2;
				}
				break;
			case 2:
				Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton = -1;
				obj2 = 4;
				break;
			case 7:
				Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)/*Error near IL_00a7: Stack underflow*/)->_003C_003Et__builder, (AsyncTaskMethodBuilder)((AsyncTaskMethodBuilder*)(&obj))->Task);
				obj2 = 6;
				break;
			case 3:
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&obj))->listener = (TcpListener)P_1;
				obj2 = 5;
				break;
			case 6:
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&obj))->_003C_003E4__this = (Authenticator)(object)this;
				obj2 = 0;
				if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
				{
					obj2 = 0;
				}
				break;
			case 4:
				_ = ref ((Authenticator._003CReceiveAsync_003Ed__9*)(&obj))->_003C_003E1__state;
				((RestResponse<EntityFeverResponse<_00210>>)(object)(&obj)).EnsureSuccessStatusCode<_00210>();
				_ = 1;
				if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9._003C_003E4__this)->client != null)
				{
					_ = 1;
				}
				break;
			case 1:
				((AsyncTaskMethodBuilder*)(&((Authenticator._003CReceiveAsync_003Ed__9*)(&obj))->_003C_003Eu__1))->SetResult();
				return (object)/*Error near IL_0124: Stack underflow*/;
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
		//IL_001d: Expected Obj, but got I4
		//IL_006b: Expected I4, but got Obj
		//IL_00bd: Invalid comparison between Unknown and Obj
		//IL_02cf: Expected native int or pointer, but got Obj
		//IL_02dd: Expected Obj, but got I4
		//IL_029a: Expected Obj, but got VT
		//IL_02f1: Expected native int or pointer, but got Obj
		//IL_0133: Expected Obj, but got Ref
		//IL_0261: Expected Obj, but got I4
		//IL_0071: Expected native int or pointer, but got Obj
		//IL_02b9: Expected native int or pointer, but got Obj
		//IL_0088: Expected Obj, but got I4
		//IL_02eb: Expected Obj, but got I4
		//IL_0169: Expected native int or pointer, but got Obj
		//IL_0176: Expected Obj, but got Ref
		//IL_0181: Expected native int or pointer, but got Obj
		//IL_02a4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0275->IL0026: Incompatible stack heights: 5 vs 1
		//IL_02c3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0293->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ba->IL0026: Incompatible stack types: I4 vs Obj
		//IL_024c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0316->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0280->IL0026: Incompatible stack heights: 5 vs 1
		//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02ce->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0257->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0321->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0335->IL0026: Incompatible stack heights: 5 vs 1
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
				case 11:
					if (((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state == 0)
					{
						obj2 = 4;
						break;
					}
					goto case 6;
				case 14:
					obj = 0;
					obj2 = 3;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
					{
						obj2 = 9;
					}
					break;
				case 1:
					return;
				default:
				{
					object obj3 = obj;
					if ((object)/*Error near IL_00c2: Stack underflow*/ != obj3)
					{
						obj2 = 3;
						if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
						{
							obj2 = 5;
						}
						break;
					}
					goto case 4;
				}
				case 9:
				{
					((Task)(&obj)).GetAwaiter();
					int num = 0;
					if (((Authenticator._003CReceiveAsync_003Ed__9)Authenticator._003CReceiveAsync_003Ed__9._003C_003Et__builder)._003C_003E4__this != null)
					{
						num = 0;
					}
					while (true)
					{
						switch (num)
						{
						case 1:
							break;
						default:
							_ = ((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->client;
							((AsyncTaskMethodBuilder*)P_0)->SetException((Exception)(&obj));
							num = 1;
							if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain)->_003C_003E1__state != 0)
							{
								num = 1;
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
						obj = new void[P_2];
						obj2 = 10;
						break;
					}
					obj2 = 1;
					if (((FeverInstaller)FeverInstaller._003CappId_003EP)._003CappVersion_003EP != null)
					{
						obj2 = 1;
					}
					break;
				case 10:
					_ = 0;
					((Task<string>)P_2).GetAwaiter();
					_ = 0;
					if (FeverInstaller.ReflectVisualArgument != null)
					{
						_ = 11;
					}
					break;
				case 4:
				case 13:
				case 15:
					((FeverInstaller)P_0).Dispose();
					obj = this;
					obj2 = 7;
					break;
				case 6:
					obj = FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Et__builder;
					obj2 = 14;
					break;
				case 12:
					obj = ((FeverInstaller)obj).GetFeverManifestAsync(obj);
					obj2 = 15;
					if ((int)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller._003CFeverRequest_003Ed__15<>.request)->_003C_003Eu__1 != 0)
					{
						obj2 = 13;
					}
					break;
				case 5:
					((RestClient)/*Error near IL_02dd: Stack underflow*/)._002Ector((RestClientOptions)/*Error near IL_02dd: Stack underflow*/, (ConfigureHeaders)(object)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)this)->_003C_003E1__state, (ConfigureSerialization)obj, (byte)(&obj) != 0);
					if ((int)/*Error near IL_02e2: Stack underflow*/ == 0)
					{
						goto end_IL_0026;
					}
					goto case 12;
				case 7:
					if (((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)this)->_003C_003E4__this == null)
					{
						obj2 = 8;
						if (FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor != null)
						{
							obj2 = 6;
						}
					}
					else
					{
						AsyncTaskMethodBuilder<EntityFeverManifest>.Create();
						_ = 3;
					}
					break;
				case 8:
					return;
				}
				continue;
				end_IL_0026:
				break;
			}
			obj = 13;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_F800(Action<string, byte[]> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_009f: Expected native int or pointer, but got Obj
		//IL_00a6: Expected Obj, but got VT
		//IL_00b0: Expected native int or pointer, but got Obj
		//IL_00ea: Expected native int or pointer, but got Obj
		//IL_00fa: Expected Obj, but got VT
		//IL_0103: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got VT
		//IL_0089: Expected native int or pointer, but got Obj
		//IL_00de->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ba->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0108->IL0022: Incompatible stack heights: 2 vs 0
		//IL_0093->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00e9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
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
				case 3:
					if (obj == obj)
					{
						obj2 = 2;
						if ((int)((Authenticator._003CListenAsync_003Ed__7*)Authenticator._003CListenAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder == 0)
						{
							obj2 = 2;
						}
						continue;
					}
					goto default;
				case 5:
					obj = (AsyncTaskMethodBuilder<EntityFeverManifestInfo>)Task.Run((Func<Task?>)(object)P_0);
					_ = 1;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
					{
						_ = 4;
					}
					continue;
				case 1:
					obj = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003Et__builder;
					obj2 = 0;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					return;
				default:
					obj = obj;
					obj2 = 5;
					if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler != null)
					{
						obj2 = 4;
					}
					continue;
				case 4:
					break;
				}
				break;
			}
			_ = &((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003E1__state;
			obj = ((RestResponse<EntityFeverResponse<_00210>>)obj).EnsureSuccessStatusCode<_00210>();
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
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_02f1: Expected Obj, but got I4
		//IL_02fb: Expected native int or pointer, but got Obj
		//IL_0062: Expected Obj, but got VT
		//IL_006c: Expected native int or pointer, but got Obj
		//IL_0327: Expected Obj, but got VT
		//IL_0268: Expected native int or pointer, but got Obj
		//IL_0272: Expected Obj, but got VT
		//IL_0204: Expected native int or pointer, but got Obj
		//IL_020f: Expected Obj, but got VT
		//IL_0216: Expected I4, but got Obj
		//IL_0221: Expected native int or pointer, but got Obj
		//IL_0239: Invalid comparison between Unknown and Obj
		//IL_00d8: Expected native int or pointer, but got Obj
		//IL_00e3: Expected Obj, but got I4
		//IL_01e4: Expected I4, but got Obj
		//IL_01ee: Expected native int or pointer, but got Obj
		//IL_0305->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0076->IL0026: Incompatible stack types: I4 vs Obj
		//IL_033b->IL0026: Incompatible stack heights: 2 vs 1
		//IL_005b->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0310->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0081->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0346->IL0026: Incompatible stack heights: 2 vs 1
		//IL_027c->IL0099: Incompatible stack heights: 2 vs 1
		//IL_01ae->IL0099: Incompatible stack heights: 3 vs 1
		//IL_01cf->IL0099: Incompatible stack heights: 4 vs 1
		//IL_01f8->IL0099: Incompatible stack heights: 2 vs 1
		//IL_0144->IL0099: Incompatible stack heights: 2 vs 1
		//IL_010d->IL0162: Incompatible stack heights: 2 vs 0
		//IL_0203->IL0099: Incompatible stack heights: 2 vs 1
		//IL_0121->IL0099: Incompatible stack heights: 3 vs 1
		//IL_012c->IL0099: Incompatible stack heights: 3 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 3;
		object obj = stateMachine;
		while (true)
		{
			switch ((int)obj)
			{
			case 4:
				_ = ((Authenticator)P_0).Listener;
				_ = 5;
				break;
			case 2:
				stateMachine = Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder;
				obj = 0;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					obj = 0;
				}
				break;
			case 1:
			{
				((AsyncTaskMethodBuilder*)stateMachine)->Start<TStateMachine>(ref *(TStateMachine*)(&stateMachine));
				int num = 10;
				while (true)
				{
					switch (num)
					{
					case 2:
						break;
					case 7:
						GC.SuppressFinalize(((Authenticator)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E1__state).ReceiveAuthenticationDataAsync(P_0));
						((TcpListener)P_0).Dispose();
						num = 11;
						continue;
					case 11:
						Authenticator.ReflectMonoObject();
						if ((int)((Task)(object)Authenticator.PatchUser()).GetAwaiter() == 0)
						{
							_ = 1;
							if (((Authenticator._003CReceiveAsync_003Ed__9)Authenticator._003CReceiveAsync_003Ed__9._003C_003Et__builder)._003C_003E4__this == null)
							{
								_ = 1;
							}
							continue;
						}
						goto case 9;
					case 10:
						((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAsync_003Ed__7.ObserveTracker())->MoveNext();
						stateMachine = P_0;
						_ = 4;
						continue;
					case 1:
						return;
					case 12:
						return;
					case 9:
						((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)this)->SetStateMachine((IAsyncStateMachine)P_0);
						((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)/*Error near IL_016e: Stack underflow*/)->_003C_003E1__state = (int)/*Error near IL_016e: Stack underflow*/;
						num = 0;
						if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Et__builder).client == null)
						{
							num = 0;
						}
						continue;
					case 5:
						_ = Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E4__this;
						Authenticator._003CReceiveAsync_003Ed__9.ReflectAdvancedEnumerator();
						((AsyncTaskMethodBuilder*)stateMachine)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverManifestInfo>*)P_0, ref *(FeverInstaller._003CInstallAsync_003Ed__11*)Authenticator._003CReceiveAsync_003Ed__9.DecorateConvertibleParameter());
						_ = 3;
						continue;
					case 6:
						_ = ((FeverInstaller)this)._003CfeverVersion_003EP;
						Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.DecorateFlexibleProfiler();
						((Task<string>)(object)new TcpClient()).GetAwaiter();
						_ = 7;
						continue;
					case 8:
					{
						RestClient client = ((FeverInstaller)FeverInstaller.Client__BackingField).Client;
						((FeverInstaller)P_0).Dispose();
						((IEnumerable<byte>)/*Error near IL_01e4: Stack underflow*/).Skip((int)client);
						_ = 6;
						if (((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003E4__this)->request == null)
						{
							_ = 5;
						}
						continue;
					}
					case 3:
						((RestClient)/*Error near IL_0216: Stack underflow*/)._002Ector((RestClientOptions)/*Error near IL_0216: Stack underflow*/, (ConfigureHeaders)/*Error near IL_0216: Stack underflow*/, (ConfigureSerialization)(object)((FeverInstaller)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)this)->_003C_003Eu__1).FeverRequest<T>((RestRequest)P_0), (byte)(int)stateMachine != 0);
						num = 2;
						if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E4__this)->_003C_003Eu__1 != 0)
						{
							num = 2;
						}
						continue;
					case 4:
					{
						object obj2 = stateMachine;
						if ((object)/*Error near IL_023e: Stack underflow*/ == obj2)
						{
							num = 8;
							if ((int)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E1__state)->_003C_003Et__builder != 0)
							{
								num = 7;
							}
							continue;
						}
						goto case 5;
					}
					default:
						((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E4__this)->MoveNext();
						((RpcCallBack)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)this)->_003C_003Eu__1).As<EntityChaChaHandShake>();
						_ = 12;
						continue;
					}
					break;
				}
				goto case 4;
			}
			default:
				stateMachine = 0;
				obj = 1;
				if (((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CheckScalableWorker)->_003C_003E1__state == 0)
				{
					obj = 1;
				}
				break;
			case 5:
				return;
			case 3:
			{
				AsyncTaskMethodBuilder asyncTaskMethodBuilder = FeverInstaller._003CInstallAsync_003Ed__11._003C_003Et__builder;
				object options = FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.DecorateGroupedVisitor();
				((FeverInstaller._003CInstallAsync_003Ed__11*)P_0)->MoveNext();
				JsonSerializer.Serialize((EntityUserPropertiesEx)asyncTaskMethodBuilder, (JsonSerializerOptions?)options);
				_ = 2;
				if (FeverInstaller._003CInstallAsync_003Ed__11.ReflectAccessibleWatcher != null)
				{
					_ = 2;
				}
				break;
			}
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
		//IL_001d: Expected Obj, but got I4
		//IL_006f: Expected I4, but got Obj
		//IL_0415: Expected Obj, but got I4
		//IL_0402: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got Ref
		//IL_038b: Expected Obj, but got I4
		//IL_032e: Expected I4, but got Obj
		//IL_011a: Expected native int or pointer, but got Obj
		//IL_0133: Expected native int or pointer, but got Obj
		//IL_0140: Expected Obj, but got Ref
		//IL_021c: Expected Obj, but got Ref
		//IL_0165: Expected native int or pointer, but got Obj
		//IL_016f: Expected Obj, but got I4
		//IL_0458->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0429->IL0026: Incompatible stack heights: 3 vs 1
		//IL_040c->IL0026: Incompatible stack heights: 2 vs 1
		//IL_03ef->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0309->IL0026: Incompatible stack heights: 3 vs 1
		//IL_035a->IL0314: Incompatible stack heights: 1 vs 0
		//IL_02ed->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0395->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0434->IL0026: Incompatible stack heights: 3 vs 1
		//IL_03b0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0314->IL0026: Incompatible stack heights: 3 vs 1
		//IL_03c6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_036e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0342->IL0026: Incompatible stack heights: 3 vs 1
		//IL_03d7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0379->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0132->IL00b0: Incompatible stack heights: 6 vs 3
		//IL_0145->IL01a5: Incompatible stack heights: 3 vs 2
		//IL_0221->IL0119: Incompatible stack heights: 4 vs 2
		//IL_01ad->IL01b7: Incompatible stack heights: 1 vs 2
		//IL_0181->IL00b0: Incompatible stack heights: 1 vs 3
		//IL_01bf->IL020d: Incompatible stack heights: 1 vs 2
		//IL_034d->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0159->IL00b0: Incompatible stack heights: 4 vs 3
		//IL_0235->IL00b0: Incompatible stack heights: 5 vs 3
		//IL_01b7->IL00b0: Incompatible stack heights: 2 vs 3
		//IL_01d3->IL00b0: Incompatible stack heights: 2 vs 3
		//IL_0164->IL00b0: Incompatible stack heights: 4 vs 3
		//IL_0240->IL00b0: Incompatible stack heights: 5 vs 3
		//IL_01de->IL00b0: Incompatible stack heights: 2 vs 3
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
			case 10:
				return;
			case 13:
			{
				Task task = Task.Run((Func<Task?>)(&obj));
				int num = 3;
				while (true)
				{
					switch (num)
					{
					case 2:
						return;
					case 1:
						_ = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E1__state;
						_ = ref obj;
						AsyncTaskMethodBuilder.Create();
						_ = 9;
						continue;
					case 3:
						_ = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->listener;
						((TcpListener)(&obj)).Dispose();
						if (P_0 == null)
						{
							_ = 2;
							if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler != null)
							{
								_ = 4;
							}
							continue;
						}
						goto case 7;
					case 4:
					case 8:
						((Authenticator._003CListenAsync_003Ed__7*)task)->SetStateMachine((IAsyncStateMachine)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003E1__state);
						((TaskAwaiter*)(&obj))->GetResult();
						_ = 10;
						continue;
					case 7:
						if (task == obj)
						{
							_ = 8;
							continue;
						}
						goto case 10;
					case 10:
						if (task == obj)
						{
							_ = 2;
							if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Et__builder).client != null)
							{
								_ = 5;
							}
							continue;
						}
						goto case 6;
					case 5:
						((AsyncTaskMethodBuilder*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E4__this)->AwaitUnsafeOnCompleted(ref *(Authenticator._003CReceiveAsync_003Ed__9.ReflectAdvancedEnumerator() ? ((TaskAwaiter<EntityFeverAppVersion>*)1) : ((TaskAwaiter<EntityFeverAppVersion>*)null)), ref *(FeverInstaller._003CInstallAsync_003Ed__11*)P_0);
						num = 2;
						if (((FeverInstaller)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway)._003CfeverVersion_003EP == null)
						{
							num = 2;
						}
						continue;
					case 6:
						_ = ((FeverInstaller)this)._003CappId_003EP;
						if (((TcpClient)(&obj)).GetStream() != null)
						{
							_ = 0;
							if (((FeverInstaller)FeverInstaller.McBedrock__BackingField).Client__BackingField != null)
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
			{
				object obj3 = obj;
				FeverInstaller._002Ecctor();
				obj = obj3;
				obj2 = 7;
				break;
			}
			case 9:
				return;
			case 6:
				FeverInstaller.CheckScopeSummarizer();
				_ = 0;
				if (FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor == null)
				{
					_ = 2;
				}
				break;
			case 12:
				return;
			case 14:
				_ = FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E1__state;
				FeverInstaller._003CFeverRequest_003Ed__15<>.CheckAdaptableResponder();
				((ILogger)obj).Error<ushort>((Exception)FeverInstaller._003CFeverRequest_003Ed__15<>.VisitParser(), (string)P_0, (ushort)(int)obj);
				_ = 11;
				if (FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReflectReporter == null)
				{
					_ = 1;
				}
				break;
			case 8:
				if ((nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.ReflectRemoteFinder() <= 0)
				{
					return;
				}
				_ = 2;
				if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13._003C_003Et__builder)._003C_003E4__this != null)
				{
					_ = 14;
				}
				break;
			case 16:
				obj = 0;
				obj2 = 13;
				break;
			case 3:
				return;
			case 5:
				((ILogger)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.version).Warning<string>((string)FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReceiveEnumerator(), (string)P_0);
				obj2 = 9;
				break;
			case 7:
				((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)/*Error near IL_03b7: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)obj);
				if ((int)/*Error near IL_03bc: Stack underflow*/ == 0)
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
				FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CallGateway();
				_ = 6;
				break;
			case 2:
				((FeverInstaller._003CInstallAsync_003Ed__11*)FeverInstaller._003CInstallAsync_003Ed__11._003C_003E4__this)->MoveNext();
				JsonSerializer.Serialize((EntityUserPropertiesEx)/*Error near IL_0402: Stack underflow*/, (JsonSerializerOptions?)((Array)obj).Length);
				_ = 3;
				break;
			case 1:
				obj = FeverInstaller._003CInstallAsync_003Ed__11.CheckIsolatedElement();
				_ = 0;
				if (((Rpc)FeverInstaller._003CInstallAsync_003Ed__11.ReflectAccessibleWatcher).ProcessId__BackingField == 0)
				{
					_ = 0;
				}
				break;
			default:
				obj = Rpc.Logger__BackingField;
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_0900(Action<string> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0071: Expected native int or pointer, but got Obj
		//IL_00c0: Expected native int or pointer, but got Obj
		//IL_008c: Expected native int or pointer, but got Obj
		//IL_00f8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ca->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0103->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)Authenticator._003CListenAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 4;
			case 3:
				((AsyncTaskMethodBuilder*)(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E4__this))->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<TcpClient>*)obj, ref *(Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)obj);
				obj = (object)/*Error near IL_0081: Stack underflow*/;
				obj2 = 2;
				break;
			case 5:
				obj = Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton;
				obj2 = 0;
				if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					obj2 = 4;
				}
				break;
			case 4:
				obj = obj;
				obj2 = 1;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
				{
					obj2 = 0;
				}
				break;
			case 1:
			{
				object obj3 = obj;
				((IAsyncStateMachine)(object)P_0).MoveNext();
				obj = (Task<RestResponse<EntityFeverResponse<_00210>>>)obj3;
				obj2 = 0;
				if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder != 0)
				{
					obj2 = 3;
				}
				break;
			}
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00ༀ(nint P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0067: Expected I4, but got Obj
		//IL_01c7: Expected Obj, but got VT
		//IL_01c8: Expected native int or pointer, but got Obj
		//IL_01de: Expected Ref, but got VT
		//IL_027d: Expected VT, but got Obj
		//IL_0278: Expected native int or pointer, but got Obj
		//IL_0076: Expected Obj, but got I4
		//IL_007d: Expected I4, but got Obj
		//IL_0128: Expected native int or pointer, but got Obj
		//IL_018a: Expected I4, but got Obj
		//IL_018a: Expected I4, but got Obj
		//IL_01b8: Expected Obj, but got I4
		//IL_0271->IL0026: Incompatible stack heights: 2 vs 1
		//IL_01f2->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0287->IL0026: Incompatible stack heights: 2 vs 1
		//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_016d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_010a->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0132->IL0026: Incompatible stack heights: 4 vs 1
		//IL_022e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00bf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01fd->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0178->IL0026: Incompatible stack heights: 2 vs 1
		//IL_013d->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0239->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0199->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((Authenticator)/*Error near IL_0076: Stack underflow*/).Listener = (TcpListener?)Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
					((Authenticator)/*Error near IL_007d: Stack underflow*/).StartListening((int)obj);
					((AsyncTaskMethodBuilder*)/*Error near IL_0089: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)/*Error near IL_0089: Stack underflow*/, ref *(Authenticator._003CReceiveAsync_003Ed__9*)((Authenticator)obj).ListenAsync());
					obj2 = 9;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj2 = 3;
					}
					break;
				case 13:
					((Authenticator)P_1).Dispose();
					((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)/*Error near IL_00b3: Stack underflow*/)->Start(ref *(FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)/*Error near IL_00b3: Stack underflow*/);
					obj = (object)/*Error near IL_00b5: Stack underflow*/;
					obj2 = 12;
					break;
				case 8:
					return;
				case 9:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)5)->MoveNext();
					_ = 8;
					break;
				case 10:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)P_0)->SetStateMachine((IAsyncStateMachine)obj);
					Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateGenericStruct();
					Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.ReflectRandomReporter();
					_ = 1;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.client)->_003C_003E4__this == null)
					{
						_ = 1;
					}
					break;
				case 5:
					return;
				case 7:
				{
					object obj3 = Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003Cstream_003E5__2;
					object s = Authenticator._003CReceiveAsync_003Ed__9.DecorateConvertibleParameter();
					((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)obj)->MoveNext();
					((IEnumerable<byte>)/*Error near IL_0159: Stack underflow*/).Concat(((Encoding)obj3).GetBytes((string)s));
					_ = 10;
					if (FeverInstaller.McBedrock__BackingField == null)
					{
						_ = 10;
					}
					break;
				}
				case 14:
					return;
				case 11:
					((RestClientOptions)((FeverInstaller)/*Error near IL_01a5: Stack underflow*/).GetFeverManifestAsync((object)((FeverInstaller)obj).InstallAsync()))._002Ector();
					if ((int)/*Error near IL_01af: Stack underflow*/ != 0)
					{
						goto end_IL_0026;
					}
					if (((Stream)/*Error near IL_018a: Stack underflow*/).Read((byte[])/*Error near IL_018a: Stack underflow*/, (int)obj, (int)FeverInstaller.McBedrock.Client) == 0)
					{
						obj2 = 6;
						break;
					}
					goto case 7;
				case 2:
					((FeverInstaller)/*Error near IL_01c7: Stack underflow*/).FeverRequest<T>((RestRequest)(object)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Eu__1);
					((AsyncTaskMethodBuilder*)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)this)->_003C_003Et__builder)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<TcpClient>*)obj, ref *(Rpc._003CListenControlConnectAsync_003Ed__35*)(FeverInstaller.CheckScopeSummarizer() ? ((AsyncTaskMethodBuilder<EntityFeverManifest>*)1) : ((AsyncTaskMethodBuilder<EntityFeverManifest>*)null))->Task);
					_ = 0;
					if ((int)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						_ = 0;
					}
					break;
				case 12:
					((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E4__this)->MoveNext();
					((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)P_0)->SetStateMachine((IAsyncStateMachine)obj);
					((DefaultInterpolatedStringHandler*)P_1)->AppendFormatted(FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.AnalyzeHandler() ? EnumItemMasterType.SingleGame : EnumItemMasterType.None);
					obj2 = 11;
					if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 2;
					}
					break;
				case 1:
					return;
				case 6:
					FeverInstaller._003CGetFeverManifestAsync_003Ed__12.SearchChain();
					FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReceiveEnumerator();
					/*Error near IL_0246: Member reference must be method, but was: Field*/;
				default:
					((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)P_0)->SetStateMachine((IAsyncStateMachine)obj);
					FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CallGateway();
					_ = 14;
					break;
				case 3:
					Unsafe.Write(&((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)P_1)->_003C_003Eu__1, (TaskAwaiter<EntityFeverAppVersion>)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.DecorateGroupedVisitor());
					_ = 2;
					break;
				}
				continue;
				end_IL_0026:
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00ᄀ(Action<string> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0051: Expected VT, but got Obj
		//IL_0058: Expected Obj, but got VT
		//IL_0088: Expected native int or pointer, but got Obj
		//IL_00c5: Expected native int or pointer, but got Obj
		//IL_0063: Expected native int or pointer, but got Obj
		//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ac->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0074->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00da->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				((ILogger)/*Error near IL_0051: Stack underflow*/).Debug<_0021_00210>((string)obj, (_0021_00210)P_0);
				obj = (TaskAwaiter<string>)/*Error near IL_0052: Stack underflow*/;
				obj2 = 2;
				continue;
			case 4:
				obj = ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E4__this;
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
				((AsyncTaskMethodBuilder*)(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Eu__1))->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)obj, ref *(Authenticator._003CReceiveAsync_003Ed__9*)obj);
				obj = (object)/*Error near IL_0098: Stack underflow*/;
				obj2 = 0;
				if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					obj2 = 0;
				}
				continue;
			case 3:
				break;
			}
			obj = obj;
			obj2 = 0;
			if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00ጀ(Action<Exception> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0084: Expected native int or pointer, but got Obj
		//IL_0049: Expected native int or pointer, but got Obj
		//IL_0050: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got VT
		//IL_00a8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ef->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0077->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0082->IL0026: Incompatible stack types: I4 vs Obj
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
			case 3:
				obj = ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
				obj2 = 2;
				continue;
			default:
				if (obj == obj)
				{
					obj2 = 5;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 5;
					}
					continue;
				}
				break;
			case 5:
				return;
			case 1:
				((AsyncTaskMethodBuilder*)(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Eu__1))->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)obj, ref *(Authenticator._003CReceiveAsync_003Ed__9*)obj);
				obj = (object)/*Error near IL_0094: Stack underflow*/;
				obj2 = 0;
				if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder != 0)
				{
					obj2 = 0;
				}
				continue;
			case 4:
			{
				object obj3 = obj;
				GC.SuppressFinalize(P_0);
				obj = (AsyncTaskMethodBuilder<_00210>)obj3;
				obj2 = 1;
				if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler != null)
				{
					obj2 = 0;
				}
				continue;
			}
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
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.ArgumentNullException: Value cannot be null. (Parameter 'source')
		//    at System.Linq.ThrowHelper.ThrowArgumentNullException(ExceptionArgument argument)
		//    at System.Linq.Enumerable.Skip[TSource](IEnumerable`1 source, Int32 count)
		//    at ICSharpCode.Decompiler.CSharp.ArgumentList.GetArgumentResolveResultsDirect(Int32 skipCount) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 124
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Probe() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 493
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Run() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 438
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.ForMethodReference(ExpressionBuilder expressionBuilder, IMethod method, IType targetType, TranslatedExpression target, Boolean requireTarget, ExpectedTargetDetails expectedTargetDetails, Boolean isExtensionMethodReference, Boolean castTargetUpFront) in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 131
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.DisambiguateDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1718
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1648
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildMethodReference(IMethod method, Boolean isVirtual) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1639
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitLdFtn(LdFtn inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 5058
		//    at ICSharpCode.Decompiler.IL.LdFtn.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 3175
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.HandleDelegateConstruction(CallInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1586
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 220
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitNewObj(NewObj inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 538
		//    at ICSharpCode.Decompiler.IL.NewObj.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4578
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 461
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitCall(Call inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2530
		//    at ICSharpCode.Decompiler.IL.Call.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2192
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Default(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 93
		//    at ICSharpCode.Decompiler.IL.ILVisitor`1.VisitCall(Call inst) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 7663
		//    at ICSharpCode.Decompiler.IL.Call.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2188
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertSwitchSectionBody(SwitchSection astSection, ILInstruction bodyInst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 334
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 280
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1338
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertAsBlock(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 87
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2435
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
	private void _FF00_FF00_FF00_FF00_FF00Ⰰ(object P_0)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.ArgumentNullException: Value cannot be null. (Parameter 'source')
		//    at System.Linq.ThrowHelper.ThrowArgumentNullException(ExceptionArgument argument)
		//    at System.Linq.Enumerable.Skip[TSource](IEnumerable`1 source, Int32 count)
		//    at ICSharpCode.Decompiler.CSharp.ArgumentList.GetArgumentResolveResultsDirect(Int32 skipCount) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 124
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Probe() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 493
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Run() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 438
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.ForMethodReference(ExpressionBuilder expressionBuilder, IMethod method, IType targetType, TranslatedExpression target, Boolean requireTarget, ExpectedTargetDetails expectedTargetDetails, Boolean isExtensionMethodReference, Boolean castTargetUpFront) in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 131
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.DisambiguateDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1718
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1648
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildMethodReference(IMethod method, Boolean isVirtual) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1639
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitLdFtn(LdFtn inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 5058
		//    at ICSharpCode.Decompiler.IL.LdFtn.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 3175
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Default(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 93
		//    at ICSharpCode.Decompiler.IL.ILVisitor`1.VisitLdFtn(LdFtn inst) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 7747
		//    at ICSharpCode.Decompiler.IL.LdFtn.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 3171
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitIfInstruction(IfInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 162
		//    at ICSharpCode.Decompiler.IL.IfInstruction.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 1440
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertSwitchSectionBody(SwitchSection astSection, ILInstruction bodyInst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 334
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 280
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertSwitchSectionBody(SwitchSection astSection, ILInstruction bodyInst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 334
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 280
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1338
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertAsBlock(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 87
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2435
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
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00fe: Expected native int or pointer, but got Obj
		//IL_0119: Expected native int or pointer, but got Obj
		//IL_0046: Expected native int or pointer, but got Obj
		//IL_005a: Expected native int or pointer, but got Obj
		//IL_01a0: Expected Obj, but got Ref
		//IL_01af: Expected native int or pointer, but got Obj
		//IL_02e8->IL0026: Incompatible stack heights: 3 vs 1
		//IL_02cc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02d7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01b9->IL0158: Incompatible stack heights: 1 vs 2
		//IL_0169->IL0199: Incompatible stack heights: 1 vs 0
		//IL_0169->IL016e: Incompatible stack heights: 1 vs 0
		//IL_01c4->IL0158: Incompatible stack heights: 1 vs 2
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				((Func<Task>)/*Error near IL_0050: Stack underflow*/)._002Ector((object)/*Error near IL_0050: Stack underflow*/, (nint)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state);
				int num3 = 0;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				}
				goto case 3;
			}
			case 1:
			{
				((AsyncTaskMethodBuilder*)/*Error near IL_0108: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_0108: Stack underflow*/, ref *(TStateMachine*)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003E1__state);
				((TaskAwaiter*)/*Error near IL_010d: Stack underflow*/)->GetResult();
				obj = (object)/*Error near IL_010f: Stack underflow*/;
				int num = 0;
				if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9.client)->_003C_003Eu__1 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					while (true)
					{
						if (((TcpListener)(&obj)).AcceptTcpClientAsync() == null)
						{
							_ = 0;
							if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003Cstream_003E5__2)->_003C_003Eu__1 == 0)
							{
								_ = 0;
							}
							goto IL_0158;
						}
						goto IL_016e;
						IL_016e:
						((AsyncTaskMethodBuilder*)(&obj))->SetResult();
						Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateGenericStruct();
						int num2 = 0;
						if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Et__builder).client == null)
						{
							num2 = 1;
						}
						goto IL_0158;
						IL_0158:
						switch (num2)
						{
						case 2:
							break;
						case 1:
							continue;
						default:
							goto end_IL_0132;
						}
						goto IL_016e;
					}
				case 1:
					break;
					end_IL_0132:
					break;
				}
				break;
			}
			case 3:
				obj2 = 1;
				if (FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor != null)
				{
					obj2 = 0;
				}
				continue;
			case 2:
				return;
			}
			AsyncTaskMethodBuilder<EntityFeverManifest>.Create();
			_ = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00㘀(nint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_020f: Expected I4, but got Obj
		//IL_0211: Expected Obj, but got I4
		//IL_01e8: Expected Obj, but got I
		//IL_006f: Expected native int or pointer, but got Obj
		//IL_005a: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got Ref
		//IL_014c: Expected Obj, but got Ref
		//IL_0130: Expected native int or pointer, but got Obj
		//IL_0225->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01fd->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0230->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0208->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00cc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0095->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0169->IL0100: Incompatible stack heights: 2 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 4;
		while (true)
		{
			object obj = stateMachine;
			while (true)
			{
				switch ((int)obj)
				{
				case 6:
					break;
				case 4:
				{
					TaskAwaiter taskAwaiter = ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Eu__1;
					((AsyncTaskMethodBuilder*)P_0)->Start<TStateMachine>(ref *(TStateMachine*)(&stateMachine));
					if ((int)taskAwaiter != 0)
					{
						obj = 3;
						if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
						{
							obj = 1;
						}
						continue;
					}
					break;
				}
				case 5:
					return;
				case 3:
				{
					Task<string> task = ((Authenticator)/*Error near IL_00ab: Stack underflow*/).HandleAuthentication((string)(object)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener);
					((IAsyncStateMachine)stateMachine).MoveNext();
					((AsyncTaskMethodBuilder<_0021_00210>*)task)->Start(ref *(FeverInstaller._003CFeverRequest_003Ed__15<_0021_00210>*)P_0);
					obj = 0;
					if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj = 0;
					}
					continue;
				}
				case 7:
					while (true)
					{
						((AsyncTaskMethodBuilder*)/*Error near IL_0121: Stack underflow*/)->SetException((Exception)(&stateMachine));
						int num;
						if ((int)/*Error near IL_0126: Stack underflow*/ == 0)
						{
							num = 1;
							if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain)->_003C_003E1__state != 0)
							{
								num = 1;
							}
							goto IL_0100;
						}
						goto IL_0145;
						IL_0145:
						((AsyncTaskMethodBuilder*)/*Error near IL_014c: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)(&stateMachine));
						stateMachine = (object)/*Error near IL_014e: Stack underflow*/;
						num = 3;
						goto IL_0100;
						IL_0100:
						while (true)
						{
							switch (num)
							{
							case 2:
								break;
							default:
								goto IL_0145;
							case 3:
								_ = ((TaskAwaiter<TcpClient>*)(&stateMachine))->IsCompleted;
								_ = 2;
								continue;
							case 1:
								goto end_IL_011a;
							}
							break;
						}
						continue;
						end_IL_011a:
						break;
					}
					goto case 2;
				case 1:
					return;
				case 2:
					_ = ((FeverInstaller)this)._003CappVersion_003EP;
					((Task<string>)P_0).GetAwaiter();
					_ = 0;
					if (FeverInstaller.ReflectVisualArgument == null)
					{
						_ = 1;
					}
					continue;
				default:
					stateMachine = ((Stream)/*Error near IL_020f: Stack underflow*/).Read((byte[])/*Error near IL_020f: Stack underflow*/, (int)/*Error near IL_020f: Stack underflow*/, (int)stateMachine);
					obj = 7;
					if (((FeverInstaller._003CFeverRequest_003Ed__15<>)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj = 4;
					}
					continue;
				}
				break;
			}
			((Authenticator)/*Error near IL_005a: Stack underflow*/).Listener = (TcpListener?)Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
			((AsyncTaskMethodBuilder*)/*Error near IL_0060: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)/*Error near IL_0060: Stack underflow*/, ref *(Authenticator._003CListenAsync_003Ed__7*)P_0);
			stateMachine = 5;
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
	private unsafe void _FF00_FF00_FF00_FF00_FF00㬀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004f: Expected I4, but got Obj
		//IL_005e: Expected VT, but got Ref
		//IL_02b9: Expected native int or pointer, but got Obj
		//IL_029d: Expected Obj, but got I4
		//IL_02d4: Expected native int or pointer, but got Obj
		//IL_009b: Expected native int or pointer, but got Obj
		//IL_00a1: Expected native int or pointer, but got Obj
		//IL_013e: Expected native int or pointer, but got Obj
		//IL_014d: Expected Obj, but got I4
		//IL_0127: Expected native int or pointer, but got Obj
		//IL_0188: Expected native int or pointer, but got Obj
		//IL_0159: Expected native int or pointer, but got Obj
		//IL_00fb: Expected native int or pointer, but got Obj
		//IL_00e3: Expected native int or pointer, but got Obj
		//IL_00b7: Expected native int or pointer, but got Obj
		//IL_02fe: Expected Obj, but got I4
		//IL_0172: Expected native int or pointer, but got Obj
		//IL_029a->IL0026: Incompatible stack heights: 3 vs 1
		//IL_024b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02b8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_027c->IL0026: Incompatible stack heights: 2 vs 1
		//IL_02a7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0256->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0287->IL0026: Incompatible stack heights: 2 vs 1
		//IL_02de->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011b->IL006c: Incompatible stack heights: 2 vs 1
		//IL_00d7->IL006c: Incompatible stack heights: 2 vs 1
		//IL_02e9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0303->IL0022: Incompatible stack heights: 3 vs 0
		//IL_0126->IL006c: Incompatible stack heights: 2 vs 1
		//IL_00e2->IL006c: Incompatible stack heights: 2 vs 1
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
				case 4:
				{
					((ILogger)/*Error near IL_005e: Stack underflow*/).Debug<_0021_00210>((string)obj, (_0021_00210)(&obj));
					int num = 8;
					while (true)
					{
						switch (num)
						{
						default:
							_ = ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Et__builder;
							((TcpListener)(object)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E4__this).Start();
							num = 7;
							continue;
						case 8:
							_ = Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton;
							_ = ((AsyncTaskMethodBuilder*)P_0)->Task;
							_ = 1;
							if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener == null)
							{
								_ = 1;
							}
							continue;
						case 7:
							_ = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E4__this;
							((IAsyncStateMachine)obj).MoveNext();
							num = 5;
							continue;
						case 5:
							_ = Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler;
							((Task)P_0).GetAwaiter();
							_ = 3;
							if (((Authenticator._003CReceiveAsync_003Ed__9)Authenticator._003CReceiveAsync_003Ed__9._003C_003Et__builder)._003C_003E4__this != null)
							{
								_ = 3;
							}
							continue;
						case 2:
							((AsyncTaskMethodBuilder*)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->client)->SetException((Exception)P_0);
							num = 6;
							continue;
						case 1:
							((AsyncTaskMethodBuilder*)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain)->SetStateMachine((IAsyncStateMachine)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateGenericStruct());
							num = 4;
							continue;
						case 4:
							if (((TcpListener)(object)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->client).AcceptTcpClientAsync() == null)
							{
								num = 0;
								if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003Cstream_003E5__2)->_003C_003Eu__1 == 0)
								{
									num = 0;
								}
								continue;
							}
							goto case 7;
						case 3:
							((Encoding)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway).GetBytes((string)obj);
							num = 2;
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
					((AsyncTaskMethodBuilder*)((FeverInstaller)/*Error near IL_0231: Stack underflow*/).GetFeverManifestInfoAsync((object)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003E4__this))->Start(ref *(Rpc._003CListenControlConnectAsync_003Ed__35*)P_0);
					obj2 = 1;
					if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj2 = 0;
					}
					continue;
				case 5:
					_ = FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E4__this;
					((AsyncTaskMethodBuilder*)FeverInstaller.CheckStaticProgram())->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<TcpClient>*)P_0, ref *(Rpc._003CListenControlConnectAsync_003Ed__35*)obj);
					_ = 8;
					if ((int)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						_ = 8;
					}
					continue;
				case 1:
					obj = FeverInstaller._003CFeverRequest_003Ed__15<>.VisitParser();
					_ = 6;
					continue;
				case 7:
					obj = 0;
					obj2 = 4;
					continue;
				default:
					obj = FeverInstaller._003CGetFeverManifestAsync_003Ed__12.info;
					obj2 = 7;
					continue;
				case 6:
					if ((int)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)this)->_003C_003Eu__1 == 0)
					{
						obj2 = 0;
						if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReflectReporter)->_003C_003E1__state == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					AsyncTaskMethodBuilder<_0021_00210>.Create();
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
