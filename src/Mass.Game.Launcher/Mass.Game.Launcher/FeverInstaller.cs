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
using Mass.Domain.Desktop.ValueObjects;
using Mass.Game.Launcher.Entities.Fever;
using RestSharp;
using Serilog;

namespace Mass.Game.Launcher;

public class FeverInstaller : IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CFeverRequest_003Ed__15<T> : IAsyncStateMachine where T : notnull
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public FeverInstaller _003C_003E4__this;

		public RestRequest request;

		private TaskAwaiter<RestResponse<EntityFeverResponse<T>>> _003C_003Eu__1;

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

		internal static bool CheckAdaptableResponder()
		{
			return true;
		}

		internal static object VisitParser()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetFeverAppVersionAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityFeverAppVersion> _003C_003Et__builder;

		public FeverInstaller _003C_003E4__this;

		private TaskAwaiter<EntityFeverApp> _003C_003Eu__1;

		internal static object CheckBasicEncryptor;

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
		internal static bool AnalyzeHandler()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectRemoteFinder()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00혀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778594, new IntPtr(2737337565804L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00휀(object P_0)
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
		internal unsafe static object _FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778593, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FFFD()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778592, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778527, new IntPtr(2737337536684L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FFFD()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_00ae: Expected native int or pointer, but got Obj
			//IL_00cb: Expected Obj, but got I4
			//IL_0055: Expected I, but got Obj
			//IL_0055: Expected Obj, but got Ref
			//IL_005f: Expected native int or pointer, but got Obj
			//IL_0256: Expected Obj, but got VT
			//IL_0260: Expected native int or pointer, but got Obj
			//IL_028d: Expected native int or pointer, but got Obj
			//IL_01b7: Expected native int or pointer, but got Obj
			//IL_01c2: Expected Obj, but got I4
			//IL_01d4: Expected Obj, but got I4
			//IL_01d9: Expected Ref, but got VT
			//IL_0156: Expected Obj, but got Ref
			//IL_0156: Expected Obj, but got Ref
			//IL_0165: Expected Obj, but got I4
			//IL_016a: Expected Obj, but got I4
			//IL_02a7: Expected Obj, but got I4
			//IL_02ac: Expected Obj, but got I4
			//IL_02b5: Expected Obj, but got I4
			//IL_019e: Expected Obj, but got I4
			//IL_0131: Expected I4, but got Obj
			//IL_0090->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00b8->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00df->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0069->IL0026: Incompatible stack types: I4 vs Obj
			//IL_026a->IL0100: Incompatible stack types: I4 vs Obj
			//IL_00fc->IL0100: Incompatible stack types: I4 vs Obj
			//IL_009b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ea->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0074->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0275->IL0100: Incompatible stack types: I4 vs Obj
			//IL_0148->IL0100: Incompatible stack types: I4 vs Obj
			//IL_0297->IL0100: Incompatible stack heights: 3 vs 1
			//IL_01f4->IL0100: Incompatible stack heights: 5 vs 1
			//IL_0160->IL0100: Incompatible stack heights: 3 vs 1
			//IL_017e->IL0100: Incompatible stack types: I4 vs Obj
			//IL_0243->IL0100: Incompatible stack types: I4 vs Obj
			//IL_02a2->IL0100: Incompatible stack heights: 3 vs 1
			//IL_01ff->IL0100: Incompatible stack heights: 5 vs 1
			//IL_0189->IL0100: Incompatible stack types: I4 vs Obj
			//IL_024e->IL0100: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				default:
					return;
				case 5:
					((Func<Task>)/*Error near IL_0055: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)obj);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					obj = Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton;
					obj2 = 1;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj2 = 1;
					}
					continue;
				case 0:
					return;
				case 3:
					obj = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this).listener;
					obj2 = 1;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						obj2 = 2;
					}
					continue;
				case 4:
					break;
				case 1:
					{
						if (obj != null)
						{
							obj3 = 4;
							goto IL_0100;
						}
						goto IL_024e;
					}
					IL_024e:
					obj = _003C_003Eu__1;
					obj3 = 7;
					if (((_003CGetFeverManifestAsync_003Ed__12*)(nint)CheckBasicEncryptor)->_003C_003E1__state == 0)
					{
						obj3 = 7;
					}
					goto IL_0100;
					IL_0100:
					while (true)
					{
						switch ((int)obj3)
						{
						case 3:
							return;
						case 9:
							break;
						default:
							((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003E4__this = (Authenticator)obj;
							obj3 = 5;
							continue;
						case 5:
							_ = ref ((Authenticator._003CReceiveAsync_003Ed__9)this).client;
							((FeverInstaller)(&obj)).FeverRequest<EntityFeverApp>((RestRequest)(object)Unsafe.AsPointer(ref this));
							_ = 3;
							continue;
						case 6:
							obj = 0;
							Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain = 0;
							obj3 = 0;
							if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E1__state)->_003C_003Et__builder != 0)
							{
								obj3 = 0;
							}
							continue;
						case 1:
							if (!((TaskAwaiter<TcpClient>*)(&obj))->IsCompleted)
							{
								obj = 6;
								goto IL_00fc;
							}
							goto case 2;
						case 4:
						{
							((Authenticator._003CReceiveAsync_003Ed__9*)/*Error near IL_01aa: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)obj);
							_ = 0;
							new Task<TcpClient>();
							Authenticator._003CReceiveAsync_003Ed__9.DecorateConvertibleParameter();
							((Encoding)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway).GetBytes((string)1);
							bool flag = Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.DecorateFlexibleProfiler();
							((AsyncTaskMethodBuilder*)((FeverInstaller)obj)._003CappVersion_003EP)->Start(ref *(Rpc._003CRemoteCallBackAsync_003Ed__21*)((Task<string>)1).GetAwaiter());
							obj = (flag ? ((TaskAwaiter<string>*)1) : ((TaskAwaiter<string>*)null))->GetResult();
							_ = 1;
							if ((int)((_003CFeverRequest_003Ed__15<>*)_003CFeverRequest_003Ed__15<>._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								_ = 1;
							}
							continue;
						}
						case 7:
							Unsafe.As<TaskAwaiter<RestResponse<EntityFeverResponse<T>>>, @null>(ref ((_003CFeverRequest_003Ed__15<>)this)._003C_003Eu__1) = null;
							obj3 = 4;
							if (((_003CGetFeverAppVersionAsync_003Ed__14)_003CGetFeverAppVersionAsync_003Ed__14._003C_003Et__builder)._003C_003E4__this == null)
							{
								obj3 = 8;
							}
							continue;
						case 10:
							goto end_IL_0100;
						case 2:
							_ = ref obj;
							AsyncTaskMethodBuilder<EntityFeverManifestInfo>.Create();
							obj = _003CFeverRequest_003Ed__15<>.VisitParser();
							_ = 9;
							if ((int)((_003CGetFeverManifestAsync_003Ed__12*)(nint)_003CGetFeverManifestAsync_003Ed__12.info)->_003C_003Eu__1 == 0)
							{
								_ = 1;
							}
							continue;
						case 8:
							{
								obj = -1;
								_003CGetFeverManifestAsync_003Ed__12.ReflectReporter = -1;
								obj = 2;
								goto IL_00fc;
							}
							IL_00fc:
							obj3 = obj;
							continue;
						}
						goto end_IL_0026;
						continue;
						end_IL_0100:
						break;
					}
					goto IL_024e;
					end_IL_0026:
					break;
				}
				Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler = -2;
				obj2 = 4;
				if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder != 0)
				{
					obj2 = 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_E000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778526, new IntPtr(2737337557484L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_E100()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_E200()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778525, new IntPtr(2737337554364L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetFeverManifestAsync_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityFeverManifest> _003C_003Et__builder;

		public FeverInstaller _003C_003E4__this;

		public EntityFeverManifestInfo info;

		private TaskAwaiter<RestResponse<EntityFeverManifest>> _003C_003Eu__1;

		private static object ReflectReporter;

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
		internal static bool SearchChain()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReceiveEnumerator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00케(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778524, new IntPtr(2737337557484L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00퀀(object P_0)
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
		internal unsafe static object _FF00턀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00툀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778523, new IntPtr(2737337536684L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00팀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_02d7: Expected Obj, but got I4
			//IL_0334: Expected native int or pointer, but got Obj
			//IL_0204: Expected Obj, but got Ref
			//IL_020d: Expected Obj, but got VT
			//IL_00c4: Expected Obj, but got I4
			//IL_00c9: Expected VT, but got I4
			//IL_00d3: Expected native int or pointer, but got Obj
			//IL_01cf: Expected Obj, but got Ref
			//IL_0150: Expected Obj, but got I4
			//IL_0150: Expected Obj, but got I4
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Expected VT, but got Obj
			//IL_015f: Expected Obj, but got Unknown
			//IL_015f: Expected Obj, but got VT
			//IL_016f: Expected Obj, but got I4
			//IL_01a3: Expected Obj, but got I4
			//IL_01a8: Expected Obj, but got I4
			//IL_00ba: Expected I4, but got Obj
			//IL_02eb->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0312->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_033e->IL0026: Incompatible stack heights: 4 vs 1
			//IL_02f6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_031d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_019e->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0081->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0349->IL0026: Incompatible stack heights: 4 vs 1
			//IL_0217->IL0085: Incompatible stack types: I4 vs Obj
			//IL_00dd->IL0085: Incompatible stack types: I4 vs Obj
			//IL_01e3->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0103->IL019e: Incompatible stack heights: 1 vs 0
			//IL_012d->IL0085: Incompatible stack types: I4 vs Obj
			//IL_01bc->IL0085: Incompatible stack types: I4 vs Obj
			//IL_018c->IL0085: Incompatible stack types: I4 vs Obj
			//IL_00e8->IL0085: Incompatible stack types: I4 vs Obj
			//IL_01ee->IL0085: Incompatible stack types: I4 vs Obj
			//IL_010d->IL0085: Incompatible stack heights: 2 vs 1
			//IL_0138->IL0085: Incompatible stack types: I4 vs Obj
			//IL_01c7->IL0085: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 1;
			object obj = awaiter;
			while (true)
			{
				object obj2;
				switch ((int)obj)
				{
				case 2:
					((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state = -2;
					obj = 5;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj = 1;
					}
					break;
				case 4:
					if (awaiter != null)
					{
						obj2 = 5;
						goto IL_0085;
					}
					goto IL_018c;
				case 3:
					return;
				default:
					awaiter = _003C_003E1__state;
					obj = 4;
					if (((_003CGetFeverManifestAsync_003Ed__12)_003CGetFeverManifestAsync_003Ed__12._003C_003Et__builder)._003C_003E4__this != null)
					{
						obj = 2;
					}
					break;
				case 1:
					awaiter = info;
					obj = 0;
					if (ReflectReporter != null)
					{
						obj = 0;
					}
					break;
				case 5:
					{
						_ = ref ((_003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003E1__state;
						AsyncTaskMethodBuilder<_0021_00210>.Create();
						_ = 3;
						if (((_003CGetFeverManifestInfoAsync_003Ed__13*)(nint)_003CGetFeverManifestInfoAsync_003Ed__13._003C_003E4__this)->version != null)
						{
							_ = 1;
						}
						break;
					}
					IL_018c:
					awaiter = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003E4__this;
					obj2 = 4;
					goto IL_0085;
					IL_0085:
					while (true)
					{
						switch ((int)obj2)
						{
						case 11:
							break;
						case 1:
							awaiter = -1;
							((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1 = (TaskAwaiter)(-1);
							obj2 = 0;
							if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
							{
								obj2 = 0;
							}
							continue;
						case 7:
							return;
						case 3:
							_ = ref awaiter;
							if ((int)AsyncTaskMethodBuilder.Create() != 0)
							{
								_ = 9;
								continue;
							}
							goto case 6;
						case 4:
							Unsafe.As<TcpListener, AsyncTaskMethodBuilder<_00210>>(ref ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this).listener) = default;
							obj2 = 1;
							if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
							{
								obj2 = 1;
							}
							continue;
						case 5:
						{
							((Authenticator._003CListenAsync_003Ed__7*)awaiter)->MoveNext();
							AsyncTaskMethodBuilder asyncTaskMethodBuilder = ((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003Et__builder;
							ILogger val = (ILogger)new ILogger((Exception)Authenticator._003CListenAsync_003Ed__7.DecorateExpandableParser(), (string)0);
							awaiter = null;
							((IAsyncStateMachine)/*Error near IL_0164: Stack underflow*/).SetStateMachine((IAsyncStateMachine)RestClientExtensions.ExecuteAsync<EntityFeverManifest>((IRestClient)(object)asyncTaskMethodBuilder, (RestRequest)val, (CancellationToken)awaiter));
							awaiter = (object)/*Error near IL_0166: Stack underflow*/;
							awaiter = 3;
							obj2 = awaiter;
							continue;
						}
						case 10:
							Unsafe.As<AsyncTaskMethodBuilder, AsyncTaskMethodBuilder<EntityFeverManifestInfo>>(ref ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003Et__builder).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverManifestInfo>*)(&awaiter), ref Unsafe.As<_003CGetFeverManifestAsync_003Ed__12, _003CGetFeverManifestInfoAsync_003Ed__13>(ref this));
							obj2 = 7;
							continue;
						case 8:
							goto IL_018c;
						case 6:
							awaiter = 0;
							((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003Cstream_003E5__2 = 0;
							obj2 = 2;
							if (Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway == null)
							{
								obj2 = 2;
							}
							continue;
						case 2:
							((FeverInstaller)Unsafe.AsPointer(ref this))._003CfeverVersion_003EP = awaiter;
							obj2 = 8;
							if (((FeverInstaller)FeverInstaller._003CappId_003EP)._003CappVersion_003EP != null)
							{
								obj2 = 10;
							}
							continue;
						default:
						{
							TaskAwaiter<string> awaiter2 = ((Task<string>)(&awaiter)).GetAwaiter();
							((AsyncTaskMethodBuilder*)null)->Start(ref *(Rpc._003CRemoteCallBackAsync_003Ed__21*)1);
							awaiter = awaiter2;
							obj2 = 11;
							continue;
						}
						}
						break;
					}
					goto case 2;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00퐀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00픀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778522, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetFeverManifestInfoAsync_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityFeverManifestInfo> _003C_003Et__builder;

		public FeverInstaller _003C_003E4__this;

		public EntityFeverAppVersion version;

		private TaskAwaiter<EntityFeverManifestInfo> _003C_003Eu__1;

		internal static object CheckScalableWorker;

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
		internal static bool CallGateway()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateGroupedVisitor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00봀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778521, new IntPtr(2737337557484L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00븀(object P_0)
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
		private unsafe sealed void _FF00뼀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778520, new IntPtr(2737337550204L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00쀀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00섀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778519, new IntPtr(2737337557484L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00쬀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_00a1: Expected Obj, but got VT
			//IL_008e: Expected Obj, but got I4
			//IL_0202: Expected Obj, but got I4
			//IL_0202: Expected Obj, but got I4
			//IL_0208: Expected Obj, but got Ref
			//IL_021f: Expected native int or pointer, but got Obj
			//IL_00bd: Expected native int or pointer, but got Obj
			//IL_02df: Expected VT, but got Obj
			//IL_01a2: Expected Obj, but got Ref
			//IL_01ae: Expected native int or pointer, but got Obj
			//IL_02b8: Expected Obj, but got I4
			//IL_02ee: Expected Obj, but got I4
			//IL_02f3: Expected VT, but got I4
			//IL_0119: Expected Obj, but got I4
			//IL_011e: Expected VT, but got I4
			//IL_0128: Expected native int or pointer, but got Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0086->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ab->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0098->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 3;
			object obj = awaiter;
			while (true)
			{
				switch ((int)obj)
				{
				default:
					((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state = -2;
					obj = 1;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj = 1;
					}
					continue;
				case 1:
					Unsafe.As<TaskAwaiter, AsyncTaskMethodBuilder>(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1).Start<TStateMachine>(ref *(TStateMachine*)awaiter);
					obj = 5;
					continue;
				case 3:
					awaiter = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003E1__state;
					obj = 2;
					continue;
				case 5:
					return;
				case 2:
					awaiter = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Et__builder;
					obj = 4;
					continue;
				case 4:
					{
						if (awaiter != null)
						{
							break;
						}
						int num = 0;
						if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
						{
							num = 0;
						}
						while (true)
						{
							switch (num)
							{
							case 10:
								break;
							case 2:
								return;
							case 12:
								awaiter = 0;
								((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Eu__1 = (TaskAwaiter<TcpClient>)0;
								num = 1;
								if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state == 0)
								{
									num = 1;
								}
								continue;
							case 9:
								Unsafe.As<TcpClient, TaskAwaiter<EntityFeverManifestInfo>>(ref ((Authenticator._003CReceiveAsync_003Ed__9)this).client) = default;
								num = 11;
								continue;
							case 5:
							case 6:
								((AsyncTaskMethodBuilder*)/*Error near IL_01a2: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)(&awaiter));
								awaiter = (object)/*Error near IL_01a4: Stack underflow*/;
								num = 10;
								if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.client)->_003C_003E4__this == null)
								{
									num = 8;
								}
								continue;
							case 4:
								Unsafe.As<object, AsyncTaskMethodBuilder>(ref ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003Cstream_003E5__2).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverAppVersion>*)(&awaiter), ref Unsafe.As<_003CGetFeverManifestInfoAsync_003Ed__13, _003CInstallAsync_003Ed__11>(ref this));
								num = 0;
								if (((FeverInstaller)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway)._003CfeverVersion_003EP != null)
								{
									num = 2;
								}
								continue;
							case 3:
								goto end_IL_0026;
							case 7:
								_ = ref awaiter;
								/*Error near IL_029c: Member reference must be method, but was: Field*/;
							default:
								awaiter = ((_003CInstallAsync_003Ed__11)this)._003C_003E1__state;
								num = 7;
								if (((_003CInstallAsync_003Ed__11)_003CInstallAsync_003Ed__11._003C_003Et__builder)._003C_003E4__this != null)
								{
									num = 9;
								}
								continue;
							case 1:
								((_003CInstallAsync_003Ed__11)this)._003C_003Eu__1 = (TaskAwaiter<EntityFeverAppVersion>)awaiter;
								num = 4;
								continue;
							case 11:
								awaiter = -1;
								((_003CInstallAsync_003Ed__11)this)._003C_003Eu__2 = (TaskAwaiter<EntityFeverManifestInfo>)(-1);
								num = 6;
								continue;
							}
							break;
						}
						goto default;
					}
					end_IL_0026:
					break;
				}
				break;
			}
			((FeverInstaller)awaiter)._002Ector((string)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.DecorateFlexibleProfiler(), (string)0, (string)(object)new TcpClient());
			((ILogger)/*Error near IL_0213: Stack underflow*/).Debug<short>((string)((FeverInstaller)((FeverInstaller)Unsafe.AsPointer(ref this)).Client__BackingField)._FF00_FF00_2B00(), (short)1);
			((RestClientOptions)((FeverInstaller)/*Error near IL_021d: Stack underflow*/).GetFeverManifestAsync((object)((FeverInstaller)/*Error near IL_0218: Stack underflow*/).InstallAsync())).UserAgent = (string)(object)((_003CFeverRequest_003Ed__15<>*)(nint)awaiter)->request;
			((RestClientOptions)/*Error near IL_022f: Stack underflow*/).AutomaticDecompression = DecompressionMethods.GZip;
			FeverInstaller._002Ecctor();
			((RestClient)6).Dispose();
			((_003CFeverRequest_003Ed__15<>*)CheckStaticProgram())->MoveNext();
			AsyncTaskMethodBuilder<EntityFeverManifest>.Create();
			_ = 1;
			AsyncTaskMethodBuilder<EntityFeverManifestInfo>.Create();
			((_003CGetFeverAppVersionAsync_003Ed__14*)_003CFeverRequest_003Ed__15<>.VisitParser())->MoveNext();
			_ = 1;
			AsyncTaskMethodBuilder<EntityFeverAppVersion>.Create();
			_003CGetFeverAppVersionAsync_003Ed__14.AnalyzeHandler();
			((_003CGetFeverManifestAsync_003Ed__12*)_003C_003E1__state)->MoveNext();
			_ = 1;
			/*Error near IL_0270: Member reference must be method, but was: Field*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00찀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778518, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00촀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778517, new IntPtr(2737337566844L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00츀()
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
	private struct _003CInstallAsync_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FeverInstaller _003C_003E4__this;

		private TaskAwaiter<EntityFeverAppVersion> _003C_003Eu__1;

		private TaskAwaiter<EntityFeverManifestInfo> _003C_003Eu__2;

		private TaskAwaiter<EntityFeverManifest> _003C_003Eu__3;

		private static object ReflectAccessibleWatcher;

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
		internal static bool CheckIsolatedElement()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SerializeResponder()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00똀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778516, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00뜀(object P_0)
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
		internal unsafe static object _FF00렀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00뤀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778515, new IntPtr(2737337557484L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00먀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0066: Expected Obj, but got Ref
			//IL_008d: Expected Obj, but got I4
			//IL_0051: Expected Obj, but got I4
			//IL_05c8: Expected Obj, but got I4
			//IL_05d2: Expected native int or pointer, but got Obj
			//IL_00c0: Expected I4, but got Obj
			//IL_03b5: Expected Obj, but got VT
			//IL_03bf: Expected native int or pointer, but got Obj
			//IL_04e2: Expected Obj, but got VT
			//IL_0453: Expected Obj, but got Ref
			//IL_0455: Expected Obj, but got I
			//IL_0288: Expected Obj, but got I4
			//IL_028d: Expected Obj, but got I4
			//IL_028d: Expected Obj, but got Ref
			//IL_0358: Expected native int or pointer, but got Obj
			//IL_04f1: Expected Obj, but got I4
			//IL_04f6: Expected Obj, but got I4
			//IL_0177: Expected Obj, but got I4
			//IL_017c: Expected VT, but got I4
			//IL_0186: Expected native int or pointer, but got Obj
			//IL_01c0: Expected native int or pointer, but got Obj
			//IL_032b: Expected native int or pointer, but got Obj
			//IL_0491: Expected Obj, but got I4
			//IL_0496: Expected Obj, but got I4
			//IL_0496: Expected Obj, but got Ref
			//IL_02f4: Expected Obj, but got I4
			//IL_02f9: Expected VT, but got I4
			//IL_0241: Expected Obj, but got Ref
			//IL_03d9: Expected Obj, but got I4
			//IL_03de: Expected VT, but got I4
			//IL_03e8: Expected native int or pointer, but got Obj
			//IL_04cc: Expected I4, but got Obj
			//IL_04d5: Expected Obj, but got I4
			//IL_038e: Expected Obj, but got VT
			//IL_0398: Expected native int or pointer, but got Obj
			//IL_043d: Expected Obj, but got I
			//IL_0163: Expected Obj, but got Ref
			//IL_01a3: Expected VT, but got Obj
			//IL_0157: Expected I4, but got Obj
			//IL_007a->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00a1->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_05dc->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0085->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00ac->IL0026: Incompatible stack types: I4 vs Obj
			//IL_05e7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03c9->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_04ec->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_045f->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_00ca->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_03d4->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_02a1->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_0362->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_050a->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_0190->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_01ca->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_02c2->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_0335->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_04aa->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_0303->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_052f->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_01f5->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_03f2->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_0385->IL00ce: Incompatible stack heights: 2 vs 1
			//IL_02e4->IL00ce: Incompatible stack heights: 2 vs 1
			//IL_03a2->IL00ce: Incompatible stack heights: 2 vs 1
			//IL_022f->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_0481->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_0442->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_01ad->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_02ac->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_036d->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_0515->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_019b->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_01d5->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_0319->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_0340->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_04b5->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_0200->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_025a->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_03fd->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_02ef->IL00ce: Incompatible stack heights: 2 vs 1
			//IL_03ad->IL00ce: Incompatible stack heights: 2 vs 1
			//IL_023a->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_048c->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_044d->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_0172->IL00ce: Incompatible stack types: I4 vs Obj
			//IL_0265->IL00ce: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 3;
			object obj = awaiter;
			while (true)
			{
				switch ((int)obj)
				{
				case 1:
					return;
				case 3:
					awaiter = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
					obj = 2;
					continue;
				default:
					Task.Run((Func<Task?>)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Et__builder));
					_ = 1;
					if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton != null)
					{
						_ = 1;
					}
					continue;
				case 2:
					awaiter = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003E1__state;
					obj = 3;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener != null)
					{
						obj = 5;
					}
					continue;
				case 5:
				{
					object obj2;
					switch ((int)awaiter)
					{
					default:
						obj2 = 26;
						goto IL_00ce;
					case 0:
						awaiter = ((_003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003Eu__1;
						obj2 = 11;
						if (((_003CInstallAsync_003Ed__11*)(nint)_003CGetFeverManifestInfoAsync_003Ed__13.CheckScalableWorker)->_003C_003E1__state == 0)
						{
							obj2 = 7;
						}
						goto IL_00ce;
					case 2:
						goto IL_044d;
					case 1:
						goto IL_04da;
						IL_00ce:
						while (true)
						{
							switch ((int)obj2)
							{
							case 1:
								return;
							case 2:
								return;
							case 24:
								return;
							case 29:
								((TcpListener)(&awaiter)).Dispose();
								if ((int)/*Error near IL_0168: Stack underflow*/ != 0)
								{
									obj2 = 31;
									continue;
								}
								goto case 14;
							case 8:
								awaiter = -1;
								((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Eu__1 = (TaskAwaiter<TcpClient>)(-1);
								obj2 = 7;
								if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state != 0)
								{
									obj2 = 23;
								}
								continue;
							case 32:
								((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)awaiter;
								obj2 = 20;
								continue;
							case 9:
							case 31:
								((TaskAwaiter*)(&awaiter))->GetResult();
								awaiter = (object)/*Error near IL_01b6: Stack underflow*/;
								obj2 = 14;
								if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9.client)->_003C_003Eu__1 == 0)
								{
									obj2 = 15;
								}
								continue;
							case 16:
								Unsafe.As<object, TaskAwaiter<EntityFeverAppVersion>>(ref Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain) = default;
								obj2 = 0;
								if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Et__builder).client == null)
								{
									obj2 = 0;
								}
								continue;
							case 25:
								((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003E4__this = null;
								obj2 = 8;
								if (Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway != null)
								{
									obj2 = 6;
								}
								continue;
							case 17:
								if (((Encoding)/*Error near IL_0241: Stack underflow*/).GetBytes((string)(&awaiter)) != null)
								{
									obj2 = 30;
									if (((FeverInstaller)FeverInstaller._003CappId_003EP)._003CappVersion_003EP == null)
									{
										obj2 = 21;
									}
									continue;
								}
								goto case 7;
							default:
								awaiter = -1;
								McBedrock__BackingField = -1;
								obj2 = 12;
								if (ReflectVisualArgument == null)
								{
									obj2 = 4;
								}
								continue;
							case 11:
								Unsafe.As<int, @null>(ref ((_003CFeverRequest_003Ed__15<>)this)._003C_003E1__state) = null;
								obj2 = 13;
								continue;
							case 20:
								_ = ref ((_003CFeverRequest_003Ed__15<>)this)._003C_003E4__this;
								((AsyncTaskMethodBuilder*)(&awaiter))->Start(ref Unsafe.As<_003CInstallAsync_003Ed__11, Rpc._003CListenAsync_003Ed__34>(ref this));
								_ = 1;
								if (((_003CGetFeverAppVersionAsync_003Ed__14)_003CFeverRequest_003Ed__15<>._003C_003Eu__1)._003C_003E1__state != 0)
								{
									_ = 1;
								}
								continue;
							case 14:
								awaiter = 0;
								((_003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003Et__builder = (AsyncTaskMethodBuilder<EntityFeverAppVersion>)0;
								obj2 = 32;
								continue;
							case 10:
								((RestClient*)(&awaiter))->Dispose();
								if ((int)/*Error near IL_030f: Stack underflow*/ == 0)
								{
									obj2 = 18;
									continue;
								}
								goto case 12;
							case 12:
								_ = ((AsyncTaskMethodBuilder<EntityFeverManifest>*)(&awaiter))->Task;
								obj2 = 3;
								if (((_003CGetFeverManifestAsync_003Ed__12*)(nint)_003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor)->_003C_003E1__state != 0)
								{
									obj2 = 3;
								}
								continue;
							case 4:
								Unsafe.As<AsyncTaskMethodBuilder<EntityFeverManifest>, AsyncTaskMethodBuilder>(ref ((_003CGetFeverManifestAsync_003Ed__12)this)._003C_003Et__builder).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CInstallAsync_003Ed__11, Rpc._003CRemoteCallBackAsync_003Ed__21>(ref this));
								obj2 = 2;
								if ((int)((_003CGetFeverManifestAsync_003Ed__12*)(nint)_003CGetFeverManifestAsync_003Ed__12.info)->_003C_003Eu__1 == 0)
								{
									obj2 = 2;
								}
								continue;
							case 19:
								_ = ref _003CGetFeverManifestAsync_003Ed__12.ReflectReporter;
								((DefaultInterpolatedStringHandler*)(&awaiter))->AppendFormatted((EnumItemMasterType)(int)Unsafe.AsPointer(ref this));
								_ = 24;
								continue;
							case 23:
							case 30:
								_ = ref awaiter;
								awaiter = AsyncTaskMethodBuilder<_0021_00210>.Create();
								_ = 28;
								if (((_003CGetFeverManifestInfoAsync_003Ed__13*)(nint)_003CGetFeverManifestInfoAsync_003Ed__13._003C_003E4__this)->version != null)
								{
									_ = 12;
								}
								continue;
							case 5:
								break;
							case 18:
								awaiter = 2;
								_003C_003Et__builder = (AsyncTaskMethodBuilder)2;
								obj2 = 16;
								if ((int)((_003CInstallAsync_003Ed__11*)(nint)_003CInstallAsync_003Ed__11._003C_003E4__this)->_003C_003Eu__1 == 0)
								{
									obj2 = 21;
								}
								continue;
							case 28:
								((_003CInstallAsync_003Ed__11*)awaiter)->SetStateMachine((IAsyncStateMachine)awaiter);
								/*Error near IL_0415: Member reference must be method, but was: Field*/;
							case 27:
								ReflectAccessibleWatcher = awaiter;
								obj2 = 1;
								if (((Rpc)Rpc.ProcessId__BackingField).Logger__BackingField != null)
								{
									obj2 = 4;
								}
								continue;
							case 22:
								goto IL_044d;
							case 26:
								awaiter = (((Rpc)awaiter).NeedCha ? ((TaskAwaiter<RestResponse<EntityFeverResponse<_00210>>>*)1) : ((TaskAwaiter<RestResponse<EntityFeverResponse<_00210>>>*)null))->GetResult();
								obj2 = 29;
								if (((Rpc)Rpc.Writer__BackingField).Listener__BackingField == null)
								{
									obj2 = 25;
								}
								continue;
							case 13:
								awaiter = -1;
								((Rpc)Unsafe.AsPointer(ref this))._chaChaEn = -1;
								obj2 = 3;
								if (Rpc.ParseMap == null)
								{
									obj2 = 9;
								}
								continue;
							case 21:
								((Rpc._003CListenAsync_003Ed__34)this)._003C_003E1__state = (int)awaiter;
								awaiter = 19;
								obj2 = awaiter;
								continue;
							case 6:
								goto IL_04da;
							case 7:
								awaiter = 1;
								((Rpc._003CListenAsync_003Ed__34)this)._003C_003E4__this = (Rpc)1;
								obj2 = 22;
								if (Rpc._003CListenAsync_003Ed__34.DecorateIterableWriter != null)
								{
									obj2 = 27;
								}
								continue;
							case 15:
								((Rpc)awaiter).Writer = (BinaryWriter?)awaiter;
								((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)/*Error near IL_0523: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_0523: Stack underflow*/);
								awaiter = (object)/*Error near IL_0525: Stack underflow*/;
								obj2 = 17;
								continue;
							case 3:
								goto end_IL_00af;
							}
							break;
						}
						goto case 0;
						IL_04da:
						awaiter = ((Rpc._003CListenAsync_003Ed__34)this)._003C_003Et__builder;
						obj2 = 25;
						goto IL_00ce;
						IL_044d:
						awaiter = ((Rpc)Unsafe.AsPointer(ref this)).NeedCha__BackingField;
						obj2 = 16;
						goto IL_00ce;
						end_IL_00af:
						break;
					}
					break;
				}
				case 4:
					break;
				}
				((Rpc._003CReceiveAsync_003Ed__28)this)._003C_003E4__this = (Rpc)(-2);
				obj = 0;
				if (((Rpc._003CRemoteCallBackAsync_003Ed__21*)(nint)Rpc._003CReceiveAsync_003Ed__28.CheckMonoProgram)->_003C_003E1__state == 0)
				{
					obj = 0;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00묀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00밀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778514, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[CompilerGenerated]
	private static readonly object McBedrock__BackingField;

	[CompilerGenerated]
	private readonly object Client__BackingField;

	private static object ReflectVisualArgument;

	public static FeverInstaller McBedrock
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
		[CompilerGenerated]
		get
		{
			return (RestClient)_FF00_FF00_2B00();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe FeverInstaller(string feverVersion, string appId, string appVersion)
	{
		//IL_001b: Expected I4, but got Obj
		//IL_0016: Expected native int or pointer, but got Obj
		//IL_0027: Expected VT, but got Obj
		//IL_0022: Expected native int or pointer, but got Obj
		//IL_002e: Expected native int or pointer, but got Obj
		//IL_0058: Expected Obj, but got I4
		//IL_0058: Expected native int or pointer, but got Obj
		//IL_0072: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)feverVersion;
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Et__builder, (AsyncTaskMethodBuilder)appId);
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E4__this, appVersion);
		TcpListener tcpListener = (TcpListener)new TcpListener();
		_ = ((AsyncTaskMethodBuilder*)((Authenticator)(object)tcpListener).ListenAuthenticationConnectAsync((object)tcpListener))->Task;
		_ = 3;
		AsyncTaskMethodBuilder.Create();
		_ = null;
		Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)unchecked((nint)null))->_003C_003E4__this, (Authenticator)new GC((object)0));
		((IAsyncStateMachine)this).MoveNext();
		int num = 0;
		if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state == 0)
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
		_FF00_FF00_2800();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInstallAsync_003Ed__11))]
	public Task InstallAsync()
	{
		return (Task)_FF00_FF00_2400();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetFeverManifestAsync_003Ed__12))]
	private Task<EntityFeverManifest> GetFeverManifestAsync(object info)
	{
		return _FF00_FF00_2500(info);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetFeverManifestInfoAsync_003Ed__13))]
	private Task<EntityFeverManifestInfo> GetFeverManifestInfoAsync(object version)
	{
		return _FF00_FF00Ḁ(version);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetFeverAppVersionAsync_003Ed__14))]
	private Task<EntityFeverAppVersion> GetFeverAppVersionAsync()
	{
		return _FF00_FF00_2000();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CFeverRequest_003Ed__15<>))]
	private Task<T> FeverRequest<T>(RestRequest request)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	static FeverInstaller()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_001f: Expected I4, but got Obj
		//IL_0052->IL0012: Incompatible stack types: I4 vs Obj
		//IL_005d->IL0012: Incompatible stack types: I4 vs Obj
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
				McBedrock__BackingField = new FeverInstaller((string)ZYXDNGuarder._FF00_FF00_2600(), (string)ZYXDNGuarder._FF00_FF00_2700(), (string)ZYXDNGuarder._FF00준());
				obj2 = 0;
				if (_003CModule_003E_007B8336717d_002D71de_002D47ce_002Dbc69_002D4d75223ebc5e_007D.m_d836f3f9b6194f49a23d85cb66f28ddf.m_8bfbede9d7cb466eab6596d6cf928300 != 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckScopeSummarizer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FeverInstaller CheckStaticProgram()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00ᨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778607, new IntPtr(2737337543964L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_1B00()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00ᰀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778606, new IntPtr(2737337542924L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<EntityFeverManifestInfo> _FF00_FF00ᴀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778605, new IntPtr(2737337534604L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityFeverManifestInfo>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<EntityFeverManifestInfo> _FF00_FF00Ḁ(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4335, 1790778604, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778604, new IntPtr(2737337552284L), 15);
		}
		return (Task<EntityFeverManifestInfo>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<EntityFeverManifestInfo> _FF00_FF00ἀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778603, new IntPtr(2737337557484L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityFeverManifestInfo>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<EntityFeverAppVersion> _FF00_FF00_2000()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4337, 1790778602, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778602, new IntPtr(2737337542924L), 15);
		}
		return (Task<EntityFeverAppVersion>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<EntityFeverAppVersion> _FF00_FF00_2100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778601, new IntPtr(2737337564764L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityFeverAppVersion>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_2200()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_2300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778600, new IntPtr(2737337536684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_2400()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4341, 1790778599, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778599, new IntPtr(2737337543964L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<EntityFeverManifest> _FF00_FF00_2500(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4342, 1790778598, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778598, new IntPtr(2737337553324L), 15);
		}
		return (Task<EntityFeverManifest>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_2800()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0044: Expected I, but got Obj
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
			case 0:
				return;
			case 1:
				((Func<Task>)/*Error near IL_0044: Stack underflow*/)._002Ector((object)/*Error near IL_0044: Stack underflow*/, (nint)((Authenticator)this).Listener);
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
	internal unsafe sealed void _FF00_FF00_2900()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778597, new IntPtr(2737337545004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_2B00()
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
	internal unsafe static byte _FF00_FF00Ⰰ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778596, new IntPtr(2737337564764L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00ⴀ()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_2E00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778595, new IntPtr(2737337550204L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
