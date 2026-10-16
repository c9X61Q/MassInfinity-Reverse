using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Mass.Application.Desktop;
using Mass.Common.Extensions;
using Mass.Domain.Desktop.Entities.Mods;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Value;
using Mass.Game.Launcher.Entities.Fever;
using Mass.Game.Launcher.Models;
using Mass.Game.Launcher.Paths;
using Mass.Game.Launcher.Values;
using RestSharp;
using Serilog;

namespace Mass.Game.Launcher.Java;

public class JavaAuthenticator : Authenticator
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CHandleAuthentication_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public JavaAuthenticator _003C_003E4__this;

		public string message;

		private object _003CserverIdHash_003E5__2;

		private object _003Cauthentication_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		private static object FillConnection;

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
		internal static bool ReflectLogicalModule()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectSimpleEvent()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _F300(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778406, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _F400(object P_0)
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
		private unsafe sealed void _F500(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778405, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _F600()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _F700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778404, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void ﰀ()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_089f: Expected Obj, but got Ref
			//IL_08cd: Expected Obj, but got I4
			//IL_08cd: Expected Obj, but got Ref
			//IL_08dd: Expected Obj, but got Ref
			//IL_0904: Expected Obj, but got Ref
			//IL_092c: Expected Obj, but got Ref
			//IL_015b: Expected native int or pointer, but got Obj
			//IL_0102: Expected Obj, but got I4
			//IL_0170: Expected Obj, but got I4
			//IL_0111: Expected native int or pointer, but got Obj
			//IL_01af: Expected Obj, but got I4
			//IL_0098: Expected I4, but got Obj
			//IL_02d1: Expected Ref, but got VT
			//IL_02db: Expected native int or pointer, but got Obj
			//IL_026a: Expected I4, but got Obj
			//IL_026c: Expected native int or pointer, but got Obj
			//IL_0276: Expected Ref, but got VT
			//IL_0278: Expected native int or pointer, but got Obj
			//IL_027f: Expected native int or pointer, but got Obj
			//IL_0289: Expected I4, but got VT
			//IL_0284: Unknown result type (might be due to invalid IL or missing references)
			//IL_028e: Expected VT, but got Unknown
			//IL_0289: Expected native int or pointer, but got Obj
			//IL_0298: Expected native int or pointer, but got Obj
			//IL_0302: Expected native int or pointer, but got Obj
			//IL_04d1: Expected Obj, but got VT
			//IL_04db: Expected native int or pointer, but got Obj
			//IL_0496: Expected Obj, but got Ref
			//IL_0527: Expected native int or pointer, but got Obj
			//IL_0441: Expected Obj, but got I4
			//IL_0446: Expected Obj, but got I4
			//IL_040b: Expected VT, but got Obj
			//IL_066c: Expected Obj, but got Ref
			//IL_0456: Expected Obj, but got Ref
			//IL_045c: Expected Obj, but got Ref
			//IL_0468: Expected Obj, but got I
			//IL_046d: Expected Ref, but got VT
			//IL_04a5: Expected Obj, but got I4
			//IL_04aa: Expected Obj, but got I4
			//IL_04aa: Expected Obj, but got Ref
			//IL_04b4: Expected native int or pointer, but got Obj
			//IL_0585: Expected Obj, but got Ref
			//IL_0585: Expected Obj, but got Ref
			//IL_0585: Expected Obj, but got Ref
			//IL_0553: Expected Obj, but got I4
			//IL_05a9: Expected Obj, but got I4
			//IL_05ae: Expected Obj, but got I4
			//IL_05b8: Expected native int or pointer, but got Obj
			//IL_08ba->IL0026: Incompatible stack heights: 2 vs 1
			//IL_08d7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_08f3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_091a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0940->IL0026: Incompatible stack types: I4 vs Obj
			//IL_08c5->IL0026: Incompatible stack heights: 2 vs 1
			//IL_005f->IL0063: Incompatible stack types: I4 vs Obj
			//IL_08fe->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0925->IL0026: Incompatible stack types: I4 vs Obj
			//IL_094b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00cb->IL0063: Incompatible stack types: I4 vs Obj
			//IL_011b->IL0063: Incompatible stack types: I4 vs Obj
			//IL_01fd->IL0063: Incompatible stack types: I4 vs Obj
			//IL_01c8->IL0063: Incompatible stack heights: 2 vs 1
			//IL_00e6->IL0063: Incompatible stack types: I4 vs Obj
			//IL_014e->IL0063: Incompatible stack types: I4 vs Obj
			//IL_0126->IL0063: Incompatible stack types: I4 vs Obj
			//IL_0208->IL0063: Incompatible stack types: I4 vs Obj
			//IL_01d3->IL0063: Incompatible stack heights: 2 vs 1
			//IL_00f1->IL0063: Incompatible stack types: I4 vs Obj
			//IL_0159->IL0063: Incompatible stack types: I4 vs Obj
			//IL_02a2->IL0234: Incompatible stack heights: 3 vs 1
			//IL_02ad->IL0234: Incompatible stack heights: 3 vs 1
			//IL_05ef->IL031b: Incompatible stack heights: 2 vs 1
			//IL_0399->IL05a4: Incompatible stack heights: 1 vs 0
			//IL_0483->IL031b: Incompatible stack heights: 3 vs 1
			//IL_050b->IL031b: Incompatible stack heights: 2 vs 1
			//IL_05fa->IL031b: Incompatible stack heights: 2 vs 1
			//IL_03a3->IL031b: Incompatible stack heights: 2 vs 1
			//IL_048e->IL031b: Incompatible stack heights: 3 vs 1
			//IL_0516->IL031b: Incompatible stack heights: 2 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object stateMachine = 5;
			object obj = stateMachine;
			while (true)
			{
				object obj2;
				Task<string> task;
				switch ((int)obj)
				{
				case 1:
					if ((nuint)(nint)stateMachine <= (nuint)1u)
					{
						obj2 = 4;
						goto IL_0063;
					}
					goto IL_0159;
				case 3:
					return;
				case 2:
					goto IL_08c5;
				case 4:
					stateMachine = ((GamePath)Unsafe.AsPointer(ref this)).Resources;
					obj = 1;
					if (((GamePath)(object)GamePath.Data).Files != null)
					{
						obj = 0;
					}
					continue;
				case 5:
					stateMachine = ((GamePath)Unsafe.AsPointer(ref this)).Cache;
					obj = 4;
					if (((GamePath)(object)GamePath.Game).GameAuthenticationDllSource == null)
					{
						obj = 0;
					}
					continue;
				case 6:
					{
						((GamePath)Unsafe.AsPointer(ref this)).PatchMcpSource = null;
						obj = 0;
						if (((JavaGamePath)GamePath.CheckGeneralStrategy).Java == null)
						{
							obj = 0;
						}
						continue;
					}
					IL_0159:
					if ((nint)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)stateMachine)->client == 9)
					{
						stateMachine = 9;
						obj2 = stateMachine;
						goto IL_0063;
					}
					goto IL_00f1;
					IL_00ac:
					((Authenticator)/*Error near IL_00b6: Stack underflow*/).Listener = ((Authenticator)/*Error near IL_00b1: Stack underflow*/).Listener;
					((AsyncTaskMethodBuilder*)/*Error near IL_00c1: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<TcpClient>*)/*Error near IL_00c1: Stack underflow*/, ref *(Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E4__this);
					obj2 = 5;
					goto IL_0063;
					IL_00f1:
					task = ((Authenticator)/*Error near IL_00fc: Stack underflow*/).HandleAuthentication((string)(object)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this).listener);
					((IAsyncStateMachine)5).MoveNext();
					if (task != null)
					{
						obj2 = 3;
						if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state == 0)
						{
							obj2 = 0;
						}
						goto IL_0063;
					}
					goto IL_00ac;
					IL_0063:
					while (true)
					{
						int num;
						int num2;
						switch ((int)obj2)
						{
						case 11:
							break;
						case 9:
							stateMachine = ((Authenticator)/*Error near IL_00d0: Stack underflow*/).ListenAuthenticationConnectAsync((object)/*Error near IL_00d0: Stack underflow*/);
							obj2 = 0;
							if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder != 0)
							{
								obj2 = 1;
							}
							continue;
						case 6:
							goto IL_00f1;
						case 4:
						case 10:
							obj2 = 0;
							if (((Authenticator._003CReceiveAsync_003Ed__9)Authenticator._003CReceiveAsync_003Ed__9._003C_003Et__builder)._003C_003E4__this == null)
							{
								obj2 = 0;
							}
							continue;
						case 2:
							goto IL_0159;
						case 3:
						case 7:
							Unsafe.Write(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003E1__state)->_003Cstream_003E5__2, ((TcpListener)((TaskAwaiter<TcpClient>*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.ReflectRandomReporter())->IsCompleted).AcceptTcpClientAsync());
							_ = 10;
							if (Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway == null)
							{
								_ = 6;
							}
							continue;
						case 5:
							((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)/*Error near IL_01e7: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_01e7: Stack underflow*/);
							stateMachine = (object)/*Error near IL_01e9: Stack underflow*/;
							obj2 = 8;
							if (((FeverInstaller)FeverInstaller._003CappId_003EP)._003CappVersion_003EP != null)
							{
								obj2 = 1;
							}
							continue;
						default:
							if ((nuint)(nint)stateMachine <= (nuint)1u)
							{
								num = 0;
								if (((FeverInstaller)FeverInstaller.McBedrock__BackingField).Client__BackingField != null)
								{
									num = 0;
								}
								goto IL_0234;
							}
							goto IL_02bc;
						case 1:
						case 8:
							goto IL_08c5;
							IL_04c9:
							stateMachine = ((Rpc._003CListenAsync_003Ed__34)this)._003C_003Et__builder;
							num2 = 9;
							if ((int)((Rpc._003CListenAsync_003Ed__34*)(nint)Rpc._003CListenAsync_003Ed__34._003C_003E4__this)->_003C_003Eu__1 != 0)
							{
								num2 = 5;
							}
							goto IL_031b;
							IL_02bc:
							((FeverInstaller._003CFeverRequest_003Ed__15<>*)/*Error near IL_02c1: Stack underflow*/)->MoveNext();
							((FeverInstaller._003CFeverRequest_003Ed__15<>*)/*Error near IL_02c6: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_02c6: Stack underflow*/);
							((AsyncTaskMethodBuilder*)/*Error near IL_02d1: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)/*Error near IL_02d1: Stack underflow*/, ref *(Rpc._003CRemoteCallBackAsync_003Ed__21*)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003Et__builder);
							num = 2;
							if ((int)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12.info)->_003C_003Eu__1 != 0)
							{
								num = 2;
							}
							goto IL_0234;
							IL_0234:
							while (true)
							{
								switch (num)
								{
								default:
									num = 3;
									continue;
								case 2:
									((Stream)/*Error near IL_026a: Stack underflow*/).Read((byte[])/*Error near IL_026a: Stack underflow*/, (int)Unsafe.AsPointer(ref this), (int)FeverInstaller.ReflectVisualArgument);
									_ = ((TaskAwaiter<string>*)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)stateMachine)->_003C_003Et__builder)->IsCompleted;
									Unsafe.Write(&((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)stateMachine)->request)->_003C_003Et__builder, (AsyncTaskMethodBuilder<EntityFeverAppVersion>)new RestClientOptions((DecompressionMethods)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)stateMachine)->_003C_003Eu__1));
									_ = 1;
									if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E4__this)->_003C_003Eu__1 != 0)
									{
										_ = 1;
									}
									continue;
								case 4:
									break;
								case 3:
									goto IL_02f0;
								}
								break;
							}
							goto IL_02bc;
							IL_02f0:
							if (stateMachine == null)
							{
								num2 = 2;
								if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReflectReporter)->_003C_003E1__state != 0)
								{
									num2 = 3;
								}
								goto IL_031b;
							}
							goto IL_0415;
							IL_031b:
							while (true)
							{
								switch (num2)
								{
								case 12:
									_ = ref stateMachine;
									if ((int)AsyncTaskMethodBuilder<_0021_00210>.Create() != 0)
									{
										_ = 20;
										continue;
									}
									goto case 25;
								case 9:
									((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003E4__this = null;
									num2 = 7;
									if (FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CheckScalableWorker == null)
									{
										num2 = 4;
									}
									continue;
								case 1:
								case 20:
									((AsyncTaskMethodBuilder<_0021_00210>*)/*Error near IL_03d5: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)(&stateMachine));
									num2 = 15;
									continue;
								case 11:
									((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Eu__1 = (TaskAwaiter<EntityFeverAppVersion>)stateMachine;
									num2 = 5;
									continue;
								case 14:
									break;
								case 7:
									stateMachine = -1;
									FeverInstaller._003CInstallAsync_003Ed__11.ReflectAccessibleWatcher = -1;
									num2 = 23;
									continue;
								case 15:
									_ = ((Rpc)Unsafe.AsPointer(ref this)).ProcessId__BackingField;
									_ = ((Rpc)Unsafe.AsPointer(ref this)).Logger__BackingField;
									stateMachine = ((TaskAwaiter<RestResponse<EntityFeverResponse<_00210>>>*)((Task<RestResponse<EntityFeverResponse<_00210>>>)((Rpc)stateMachine).NeedCha__BackingField).GetAwaiter())->GetResult();
									_ = 1;
									if (((Rpc)Rpc.Writer__BackingField).Listener__BackingField == null)
									{
										_ = 4;
									}
									continue;
								default:
									((Rpc)Unsafe.AsPointer(ref this))._chaChaEn = stateMachine;
									num2 = 22;
									continue;
								case 18:
									stateMachine = -1;
									((Rpc)Unsafe.AsPointer(ref this))._chaChaDe = -1;
									num2 = 1;
									if (((Rpc._003CListenAsync_003Ed__34*)(nint)Rpc.ParseMap)->_003C_003E1__state != 0)
									{
										num2 = 1;
									}
									continue;
								case 6:
									goto IL_04c9;
								case 10:
								case 23:
									((TaskAwaiter<EntityFeverApp>*)(&stateMachine))->GetResult();
									_ = 1;
									if ((int)((Rpc._003CListenControlConnectAsync_003Ed__35*)Rpc._003CListenControlConnectAsync_003Ed__35._003C_003E1__state)->_003C_003Et__builder != 0)
									{
										_ = 2;
									}
									continue;
								case 2:
									((Rpc)/*Error near IL_051b: Stack underflow*/).ReceiveControlData((object)/*Error near IL_051b: Stack underflow*/, (object)/*Error near IL_051b: Stack underflow*/);
									stateMachine = (object)/*Error near IL_051d: Stack underflow*/;
									num2 = 13;
									if ((int)((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)Rpc._003CListenControlConnectAsync_003Ed__35._003C_003E4__this)->_003C_003Eu__1 != 0)
									{
										num2 = 21;
									}
									continue;
								case 3:
								case 16:
									stateMachine = Rpc._003CListenControlConnectAsync_003Ed__35.ReflectSymbolicDecorator;
									num2 = 8;
									continue;
								case 24:
									stateMachine = 1;
									((Rpc._003CReceiveAsync_003Ed__28)this)._003C_003E1__state = 1;
									num2 = 11;
									if (((Rpc._003CReceiveAsync_003Ed__28)Rpc._003CReceiveAsync_003Ed__28._003C_003Et__builder).client == null)
									{
										num2 = 2;
									}
									continue;
								case 22:
									((ILogger)/*Error near IL_0585: Stack underflow*/).Warning<string, string>((string)Unsafe.AsPointer(ref ((Rpc._003CReceiveAsync_003Ed__28)this)._003C_003E4__this), (string)(&stateMachine), (string)Unsafe.AsPointer(ref this));
									num2 = 6;
									if ((int)((Rpc._003CRemoteCallBackAsync_003Ed__21*)Rpc._003CRemoteCallBackAsync_003Ed__21._003C_003E1__state)->_003C_003Et__builder != 0)
									{
										num2 = 19;
									}
									continue;
								case 25:
									stateMachine = 0;
									((Rpc._003CRemoteCallBackAsync_003Ed__21)this)._003C_003E4__this = (Rpc)0;
									num2 = 0;
									if ((int)((Rpc._003CRemoteCallBackAsync_003Ed__21*)(nint)Rpc._003CRemoteCallBackAsync_003Ed__21.callBack)->_003C_003Eu__1 != 0)
									{
										num2 = 0;
									}
									continue;
								case 5:
									_ = ref Rpc._003CRemoteCallBackAsync_003Ed__21.MeasureCalc;
									((AsyncTaskMethodBuilder*)(&stateMachine))->Start(ref Unsafe.As<_003CHandleAuthentication_003Ed__9, JavaGame._003CStartGameAsync_003Ed__137>(ref this));
									_ = 17;
									if (((Rpc._003CSyncChaChaAsync_003Ed__38)Rpc._003CSyncChaChaAsync_003Ed__38._003C_003Et__builder)._003C_003E4__this == null)
									{
										_ = 17;
									}
									continue;
								case 8:
									((Rpc._003CSyncChaChaAsync_003Ed__38)this).callBack = null;
									num2 = 18;
									continue;
								case 4:
									if (((TaskAwaiter<EntityFeverAppVersion>*)(&stateMachine))->GetResult() != null)
									{
										num2 = 10;
										continue;
									}
									goto case 24;
								case 17:
									return;
								case 19:
									return;
								case 13:
								{
									EntityFeverManifest result = ((TaskAwaiter<EntityFeverManifest>*)CppGameValue.DecorateAlphabeticList)->GetResult();
									((AsyncTaskMethodBuilder*)/*Error near IL_0677: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityAuthItem>*)/*Error near IL_0677: Stack underflow*/, ref *(JavaGame._003CPrepareComponentsAsync_003Ed__28*)result);
									((Dictionary<ushort, Func<RpcCallBack, Task>>)/*Error near IL_067c: Stack underflow*/)._002Ector();
									((Func<RpcCallBack, Task>)/*Error near IL_0681: Stack underflow*/)._002Ector((object)/*Error near IL_0681: Stack underflow*/, (nint)/*Error near IL_0681: Stack underflow*/);
									stateMachine = (object)/*Error near IL_0683: Stack underflow*/;
									num2 = 12;
									continue;
								}
								case 21:
									goto IL_08c5;
								}
								break;
							}
							goto IL_0415;
							IL_0415:
							if ((nint)stateMachine != 1)
							{
								num2 = 2;
								if ((int)((FeverInstaller._003CInstallAsync_003Ed__11)FeverInstaller._003CInstallAsync_003Ed__11._003C_003Eu__2)._003C_003Eu__3 == 0)
								{
									num2 = 13;
								}
								goto IL_031b;
							}
							goto IL_04c9;
						}
						break;
					}
					goto IL_00ac;
					IL_08c5:
					((GamePath)Unsafe.AsPointer(ref this)).Root = (string)(-2);
					obj = 6;
					continue;
				}
				_ = ref ((CppGamePath)Unsafe.AsPointer(ref this)).GameRuntime;
				ConfigValue.InitValue(stateMachine);
				_ = 3;
				if (CppGamePath.CheckDetachedBridge == null)
				{
					_ = 2;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte ﴀ()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FE00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778403, new IntPtr(2737337564764L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	private static object ReflectInternalDistributor;

	private static ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe JavaAuthenticator(DesktopSession session, EnumGameType type, string gameId, string gameVersion, string modHashList)
	{
		//IL_001b: Expected I4, but got Obj
		//IL_0016: Expected native int or pointer, but got Obj
		//IL_0027: Expected VT, but got I4
		//IL_0022: Expected native int or pointer, but got Obj
		//IL_002e: Expected native int or pointer, but got Obj
		//IL_0040: Expected VT, but got Obj
		//IL_003b: Expected native int or pointer, but got Obj
		//IL_0048: Expected native int or pointer, but got Obj
		//IL_0067: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)session;
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Et__builder, (AsyncTaskMethodBuilder)type);
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E4__this, gameId);
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Eu__1, (TaskAwaiter)gameVersion);
		Unsafe.Write(&Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton, modHashList);
		((Authenticator)/*Error near IL_005d: Stack underflow*/).ReceiveAuthenticationDataAsync(((Authenticator)/*Error near IL_0058: Stack underflow*/).ReceiveAsync((object)this));
		int num = 0;
		if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
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
	[AsyncStateMachine(typeof(_003CHandleAuthentication_003Ed__9))]
	protected override Task<string> HandleAuthentication(string message)
	{
		return _FF00_FF00뀀(message);
	}

	static JavaAuthenticator()
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
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_AB00());
				obj2 = 0;
				if (_003CModule_003E_007B8336717d_002D71de_002D47ce_002Dbc69_002D4d75223ebc5e_007D.m_d836f3f9b6194f49a23d85cb66f28ddf.m_e9c9a9d05681470697ac06912d5f5b55 != 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckExpandableNotifier()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static JavaAuthenticator ReflectHiddenDispatcher()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00가()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778412, new IntPtr(2737337565804L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00관()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00글()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778411, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00꼀()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe Task<string> _FF00_FF00뀀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4481, 1790778410, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778410, new IntPtr(2737337534604L), 15);
		}
		return (Task<string>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe Task<string> _FF00_FF00넀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778409, new IntPtr(2737337535644L), 15))(null, 0, new IntPtr(0L));
		return (Task<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00눀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778408, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00대()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00됀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778407, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
