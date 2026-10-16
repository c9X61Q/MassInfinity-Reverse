using System;
using System.Collections.Generic;
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
using Mass.Common.Extensions;
using Mass.Game.Launcher.Entities.Fever;
using Mass.Game.Launcher.Paths;
using Mass.Game.Launcher.Values;
using RestSharp;
using Serilog;

namespace Mass.Game.Launcher.Helpers;

public static class CompressionHelper
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CExtractAllAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Action<int> progress;

		public List<(string archivePath, string outputDir)> extractList;

		public CancellationToken cancellationToken;

		private object _003C_003E8__1;

		private List<(string archivePath, string outputDir)>.Enumerator _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		internal static object ReflectActiveWorker;

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
		internal static bool SearchParameter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateLiteralCalc()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_0B00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777366, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_0C00(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_0D00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777365, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_0E00()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00ༀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777364, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00က()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_068c: Expected Obj, but got Ref
			//IL_0691: Expected Obj, but got Ref
			//IL_062d: Expected I, but got Obj
			//IL_062d: Expected Obj, but got Ref
			//IL_063c: Expected Obj, but got I
			//IL_0666: Expected Obj, but got Ref
			//IL_0675: Expected Obj, but got I
			//IL_0652: Expected Obj, but got Ref
			//IL_0654: Expected Obj, but got I
			//IL_0538: Expected native int or pointer, but got Obj
			//IL_0554: Expected native int or pointer, but got Obj
			//IL_04f4: Expected Obj, but got Ref
			//IL_04f9: Expected VT, but got Obj
			//IL_0503: Expected native int or pointer, but got Obj
			//IL_00b2: Expected Obj, but got VT
			//IL_00ad: Expected native int or pointer, but got Obj
			//IL_00e2: Expected Obj, but got I4
			//IL_0250: Expected Obj, but got Ref
			//IL_034c: Expected Obj, but got I4
			//IL_0144: Expected I4, but got Obj
			//IL_0312: Expected Obj, but got Ref
			//IL_0312: Expected Obj, but got Ref
			//IL_031c: Expected native int or pointer, but got Obj
			//IL_02e5: Expected VT, but got Obj
			//IL_027e: Expected Obj, but got I4
			//IL_0283: Expected Obj, but got I4
			//IL_0283: Expected Obj, but got Ref
			//IL_02d8: Expected Obj, but got I4
			//IL_022b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0231: Expected Obj, but got Unknown
			//IL_022c: Expected native int or pointer, but got VT
			//IL_01e6: Expected native int or pointer, but got Obj
			//IL_01ed: Expected Obj, but got I4
			//IL_0292: Expected Obj, but got I4
			//IL_0297: Expected Obj, but got I4
			//IL_0297: Expected Obj, but got Ref
			//IL_035b: Expected native int or pointer, but got Obj
			//IL_020d: Expected native int or pointer, but got Obj
			//IL_01cb: Expected native int or pointer, but got Obj
			//IL_03e4: Expected Obj, but got I
			//IL_03ff: Expected Obj, but got Ref
			//IL_0404: Expected Obj, but got I
			//IL_040b: Expected Obj, but got Ref
			//IL_0422: Expected Obj, but got I4
			//IL_06a5->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0641->IL0026: Incompatible stack types: I4 vs Obj
			//IL_067a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_065e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_06b0->IL0026: Incompatible stack heights: 2 vs 1
			//IL_064c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0685->IL0026: Incompatible stack types: I4 vs Obj
			//IL_026e->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0279->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0326->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_02ef->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_028d->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_02bc->IL00eb: Incompatible stack heights: 2 vs 1
			//IL_023b->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_01f7->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0304->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_02a1->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0217->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_01d5->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0331->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_02c7->IL00eb: Incompatible stack heights: 2 vs 1
			//IL_03e9->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0222->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_01e0->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_03f4->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0436->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0441->IL00eb: Incompatible stack types: I4 vs Obj
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
				case 4:
					if (obj != null)
					{
						num = 6;
						if ((int)((Authenticator._003CListenAsync_003Ed__7*)Authenticator._003CListenAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder != 0)
						{
							num = 5;
						}
						goto IL_0073;
					}
					goto IL_0579;
				case 1:
					((JavaGameValue)Unsafe.AsPointer(ref this)).ReconnectDelay__BackingField = unchecked((nint)null);
					obj2 = 0;
					if (((JavaGameValue)JavaGameValue.SaveOptions__BackingField).SetChinese__BackingField != 0)
					{
						obj2 = 0;
					}
					break;
				case 5:
					obj = ((JavaGameValue)Unsafe.AsPointer(ref this)).SetGuiScale__BackingField;
					obj2 = 4;
					break;
				case 2:
					goto IL_065e;
				case 3:
					return;
				default:
					{
						_ = ((MemberInfo)Unsafe.AsPointer(ref ((JavaGameValue)Unsafe.AsPointer(ref this)).WindowHeight__BackingField)).Name;
						_ = 2;
						if (((BedrockGamePath)(object)BedrockGamePath.NeteaseData).Launcher == null)
						{
							_ = 3;
						}
						break;
					}
					IL_0579:
					num = 5;
					goto IL_0073;
					IL_0073:
					while (true)
					{
						object obj3;
						switch (num)
						{
						case 8:
							Unsafe.Write(&Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton, (object)((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1);
							num = 1;
							if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder != 0)
							{
								num = 0;
							}
							continue;
						case 5:
							if (obj == null)
							{
								obj = 16;
								goto IL_00e7;
							}
							goto IL_024a;
						case 7:
							((AsyncTaskMethodBuilder<EntityFeverManifest>*)/*Error near IL_04df: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref Unsafe.As<_003CExtractAllAsync_003Ed__3, TAwaiter>(ref this), ref *(TStateMachine*)((Rpc._003CListenControlConnectAsync_003Ed__35)this)._003C_003E4__this);
							Unsafe.Write(&Rpc._003CListenControlConnectAsync_003Ed__35.ReflectSymbolicDecorator, /*Error near IL_04e4: Stack underflow*/);
							num = 4;
							continue;
						case 6:
							Unsafe.Write(&((Rpc._003CReceiveAsync_003Ed__28*)(nint)/*Error near IL_04f9: Stack underflow*/)->_003C_003Et__builder, (AsyncTaskMethodBuilder)new Rpc((object)Unsafe.AsPointer(ref this)));
							num = 6;
							if (((Rpc._003CReceiveAsync_003Ed__28*)(nint)Rpc._003CReceiveAsync_003Ed__28.client)->_003C_003E4__this == null)
							{
								num = 8;
							}
							continue;
						case 1:
							((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)/*Error near IL_0529: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)Rpc._003CReceiveAsync_003Ed__28.CheckMonoProgram, ref *(TStateMachine*)((Rpc._003CRemoteCallBackAsync_003Ed__21)this)._003C_003E1__state);
							Unsafe.Write(&((Rpc._003CRemoteCallBackAsync_003Ed__21*)(nint)/*Error near IL_052e: Stack underflow*/)->_003C_003E4__this, /*Error near IL_052e: Stack underflow*/);
							num = 3;
							if ((int)((Rpc._003CRemoteCallBackAsync_003Ed__21*)(nint)Rpc._003CRemoteCallBackAsync_003Ed__21.callBack)->_003C_003Eu__1 == 0)
							{
								num = 2;
							}
							continue;
						case 3:
							((Rpc._003CSyncChaChaAsync_003Ed__38*)(nint)Rpc._003CRemoteCallBackAsync_003Ed__21.MeasureCalc)->_003C_003E1__state = 0;
							num = 7;
							continue;
						default:
							goto IL_0563;
						case 4:
							break;
						case 2:
							goto IL_065e;
							IL_00e7:
							obj3 = obj;
							goto IL_00eb;
							IL_00eb:
							while (true)
							{
								switch ((int)obj3)
								{
								case 9:
									return;
								default:
									((TaskAwaiter*)(&obj))->GetResult();
									if ((int)/*Error near IL_01c1: Stack underflow*/ != 0)
									{
										obj3 = 4;
										if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9.client)->_003C_003Eu__1 == 0)
										{
											obj3 = 4;
										}
										continue;
									}
									goto case 6;
								case 12:
									obj = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain)->_003C_003E1__state;
									obj3 = 10;
									continue;
								case 19:
									Unsafe.As<AsyncTaskMethodBuilder, @null>(ref ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003Et__builder) = null;
									obj3 = 15;
									if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E4__this)->_003Cstream_003E5__2 != null)
									{
										obj3 = 15;
									}
									continue;
								case 10:
									Unsafe.Write(&Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway, (object)(obj + 1));
									obj3 = 18;
									continue;
								case 1:
								case 11:
								case 14:
									break;
								case 6:
									obj = 0;
									((FeverInstaller)Unsafe.AsPointer(ref this)).Client__BackingField = 0;
									obj3 = 3;
									continue;
								case 15:
									obj = -1;
									FeverInstaller.ReflectVisualArgument = -1;
									obj3 = 7;
									continue;
								case 4:
								case 7:
									((Stream)/*Error near IL_02a8: Stack underflow*/).Read((byte[])/*Error near IL_02a8: Stack underflow*/, (int)/*Error near IL_02a8: Stack underflow*/, (int)(&obj));
									_ = 12;
									if (((FeverInstaller._003CFeverRequest_003Ed__15<>)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Et__builder)._003C_003E4__this != null)
									{
										_ = 6;
									}
									continue;
								case 8:
								case 16:
									goto IL_02c7;
								case 3:
									((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003Eu__1 = (TaskAwaiter<RestResponse<EntityFeverResponse<T>>>)obj;
									obj3 = 2;
									continue;
								case 13:
									((RestClient)/*Error near IL_02fa: Stack underflow*/)._002Ector((RestClientOptions)/*Error near IL_02fa: Stack underflow*/, (ConfigureHeaders)/*Error near IL_02fa: Stack underflow*/, (ConfigureSerialization)/*Error near IL_02fa: Stack underflow*/, (byte)Unsafe.AsPointer(ref ((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003E1__state) != 0);
									obj3 = 17;
									continue;
								case 2:
									Unsafe.As<FeverInstaller, ILogger>(ref ((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003E4__this).Debug<IPAddress>((string)(&obj), (IPAddress)Unsafe.AsPointer(ref this));
									obj3 = 9;
									if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor)->_003C_003E1__state == 0)
									{
										obj3 = 4;
									}
									continue;
								case 5:
									goto IL_0331;
								case 17:
									goto IL_0351;
								case 18:
									goto IL_03be;
								case 20:
									goto IL_0563;
								}
								break;
								IL_03be:
								object obj4 = FeverInstaller._003CInstallAsync_003Ed__11.ReflectAccessibleWatcher;
								if (obj4 == null)
								{
									obj3 = 1;
									if (((Rpc)Rpc.ProcessId__BackingField).Logger__BackingField != null)
									{
										obj3 = 1;
									}
									continue;
								}
								((AsyncTaskMethodBuilder<_00210>*)obj4)->SetException((Exception)(int)((double)((Rpc)((Rpc)Unsafe.AsPointer(ref this)).NeedCha__BackingField).UseCha__BackingField / (double)((Rpc)(object)((Rpc)Unsafe.AsPointer(ref this)).Callbacks__BackingField).Writer__BackingField * 100.0));
								obj3 = 11;
								if (((Rpc)Rpc._chaChaEn)._chaChaDe != null)
								{
									obj3 = 4;
								}
							}
							goto IL_024a;
							IL_0563:
							Unsafe.As<AsyncTaskMethodBuilder, ReadOnlyMemory<byte>>(ref ((Rpc._003CSyncChaChaAsync_003Ed__38)this)._003C_003Et__builder) = default;
							num = 2;
							continue;
							IL_024a:
							if (((Encoding)/*Error near IL_0255: Stack underflow*/).GetString((byte[])/*Error near IL_0255: Stack underflow*/, (int)/*Error near IL_0255: Stack underflow*/, (int)Unsafe.AsPointer(ref ((FeverInstaller)Unsafe.AsPointer(ref this))._003CfeverVersion_003EP)) == null)
							{
								obj3 = 0;
								if (FeverInstaller.McBedrock__BackingField == null)
								{
									obj3 = 20;
								}
								goto IL_00eb;
							}
							goto IL_0331;
							IL_02c7:
							obj = ((FeverInstaller._003CFeverRequest_003Ed__15<>)this).request;
							obj = 19;
							goto IL_00e7;
							IL_0331:
							obj = (obj = Unsafe.As<AsyncTaskMethodBuilder<EntityFeverManifest>, AsyncTaskMethodBuilder<EntityFeverManifestInfo>>(ref ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003Et__builder).Task);
							obj = 13;
							goto IL_00e7;
						}
						break;
					}
					goto IL_0579;
					IL_065e:
					((JavaGameValue)Unsafe.AsPointer(ref this)).GuiScale__BackingField = -2;
					obj2 = 1;
					if (((JavaGameValue)JavaGameValue.SetSize__BackingField).WindowWidth__BackingField != 0)
					{
						obj2 = 1;
					}
					break;
					IL_0351:
					if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReflectReporter)->_003C_003E1__state == 0)
					{
						_ = ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003Et__builder;
						_ = ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003E4__this;
						_ = (delegate*<bool>)(&FeverInstaller._003CGetFeverManifestAsync_003Ed__12.SearchChain);
						/*Error near IL_037e: Member reference must be method, but was: Field*/;
					}
					_ = ((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003E1__state;
					FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CallGateway();
					/*Error near IL_0398: Member reference must be method, but was: Field*/;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00ᄀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777363, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00ሀ()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00ጀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777362, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CExtractAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Action<int> progress;

		public string archivePath;

		public string outputDir;

		public CancellationToken cancellationToken;

		private object _003C_003E8__1;

		private object _003C_003E8__2;

		private CancellationTokenRegistration _003Cregistration_003E5__2;

		private object _003C_003E7__wrap2;

		private nint _003C_003E7__wrap3;

		private TaskAwaiter _003C_003Eu__1;

		private ValueTaskAwaiter _003C_003Eu__2;

		private static object MonitorProfiler;

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
		internal static bool ReflectModularElement()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LeadCompressor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00ﴀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777361, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FE00(object P_0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00Ā()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777360, new IntPtr(2737367923404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00ࠀ()
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
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
			//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 461
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitNewObj(NewObj inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 538
			//    at ICSharpCode.Decompiler.IL.NewObj.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4578
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 461
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitCall(Call inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2530
			//    at ICSharpCode.Decompiler.IL.Call.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2192
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
			//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitStObj(StObj inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 3219
			//    at ICSharpCode.Decompiler.IL.StObj.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4386
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitStObj(StObj inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 140
			//    at ICSharpCode.Decompiler.IL.StObj.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4382
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
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
			//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 307
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_0900()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_0A00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777359, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	private static object RestartProxy;

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
	[AsyncStateMachine(typeof(_003CExtractAllAsync_003Ed__3))]
	public static Task ExtractAllAsync(List<(string archivePath, string outputDir)> extractList, Action<int>? progress = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00䌀(extractList, progress, cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CExtractAsync_003Ed__4))]
	public static Task ExtractAsync(string archivePath, string outputDir, Action<int> progress, CancellationToken cancellationToken = default(CancellationToken))
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00䘀(archivePath, outputDir, progress, cancellationToken);
	}

	static CompressionHelper()
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
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00䄀());
				obj2 = 0;
				if (_003CModule_003E_007B8336717d_002D71de_002D47ce_002Dbc69_002D4d75223ebc5e_007D.m_d836f3f9b6194f49a23d85cb66f28ddf.m_93c7682517474b7e96a6fa3d7f857ec8 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PeekExtractor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CompressionHelper ReflectGeneralSorter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00䈀(List<(string, string)> P_0, Action<int> P_1, CancellationToken P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777445, new IntPtr(2737367928604L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00䌀(List<(string, string)> P_0, Action<int> P_1, CancellationToken P_2)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_009f: Expected Obj, but got Ref
		//IL_00dd: Expected VT, but got I4
		//IL_00e7: Expected native int or pointer, but got Obj
		//IL_00b6: Expected VT, but got Obj
		//IL_00c0: Expected native int or pointer, but got Obj
		//IL_008d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ca->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0098->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d5->IL0026: Incompatible stack types: I4 vs Obj
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
			default:
				((Func<Task>)/*Error near IL_0058: Stack underflow*/)._002Ector((object)/*Error near IL_0058: Stack underflow*/, (nint)(&((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003E1__state));
				return (object)/*Error near IL_0059: Stack underflow*/;
			case 2:
				((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003E4__this = (Authenticator)(object)P_0;
				obj = 5;
				break;
			case 1:
				((AsyncTaskMethodBuilder*)/*Error near IL_0079: Stack underflow*/)->AwaitUnsafeOnCompleted(ref ((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003Eu__1, ref *(Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine));
				obj = 0;
				if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					obj = 0;
				}
				break;
			case 3:
				GC.SuppressFinalize((object)(&stateMachine));
				Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)/*Error near IL_00a4: Stack underflow*/)->_003C_003E4__this, /*Error near IL_00a4: Stack underflow*/);
				obj = 2;
				break;
			case 5:
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->_003C_003Eu__1 = (TaskAwaiter<TcpClient>)P_1;
				obj = 6;
				if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state == 0)
				{
					obj = 4;
				}
				break;
			case 4:
				((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->_003C_003Et__builder = (AsyncTaskMethodBuilder)(-1);
				obj = 1;
				if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9._003C_003E4__this)->client == null)
				{
					obj = 1;
				}
				break;
			case 6:
				((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->_003C_003Eu__1 = (TaskAwaiter)P_2;
				obj = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00䐀(List<(string, string)> P_0, Action<int> P_1, CancellationToken P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777444, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00䔀()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00䘀(object P_0, object P_1, Action<int> P_2, CancellationToken P_3)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_00bc: Expected Obj, but got I4
		//IL_0058: Expected I4, but got VT
		//IL_00ce: Expected VT, but got Obj
		//IL_00d8: Expected native int or pointer, but got Obj
		//IL_007e: Expected Obj, but got Ref
		//IL_0117->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0097->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0105->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0077->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ed->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a2->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 5;
		object obj = stateMachine;
		while (true)
		{
			switch ((int)obj)
			{
			case 2:
				((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003E1__state = (int)P_3;
				obj = 1;
				if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj = 0;
				}
				break;
			case 5:
				((TcpListener)(&stateMachine)).Start();
				Unsafe.Write(&Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton, /*Error near IL_0083: Stack underflow*/);
				obj = 4;
				if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					obj = 3;
				}
				break;
			case 4:
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->listener = (TcpListener)P_0;
				obj = 3;
				break;
			case 1:
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->_003C_003E4__this = (Authenticator)(-1);
				obj = 6;
				break;
			case 3:
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->_003C_003Eu__1 = (TaskAwaiter<TcpClient>)P_1;
				obj = 0;
				if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state == 0)
				{
					obj = 0;
				}
				break;
			case 6:
				((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_00fb: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<RestResponse<EntityFeverResponse<_00210>>>*)(&((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->_003C_003Et__builder), ref *(FeverInstaller._003CFeverRequest_003Ed__15<_00210>*)(&stateMachine));
				obj = 7;
				break;
			default:
				((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->client = (TcpClient)(object)P_2;
				obj = 2;
				break;
			case 7:
				((AsyncTaskMethodBuilder*)(&((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->_003C_003Eu__1))->SetResult();
				return (object)/*Error near IL_0124: Stack underflow*/;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00䜀(object P_0, object P_1, Action<int> P_2, CancellationToken P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777443, new IntPtr(2737367925484L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00䠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777442, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00䤀()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00䨀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777441, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00䬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777440, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00䰀()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}
}
