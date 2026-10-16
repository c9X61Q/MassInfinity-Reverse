using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Mass.Application.Extensions;
using Mass.Game.Launcher.Entities.Fever;
using Mass.Game.Launcher.Extensions;
using RestSharp;
using Serilog;

namespace Mass.Game.Launcher;

public abstract class Authenticator : IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CListenAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Authenticator _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object CheckInternalSingleton;

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
		internal static bool DecorateExpandableParser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ObserveTracker()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00ﰀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778575, new IntPtr(2737337565804L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00ﴀ(object P_0)
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
					((Func<Task>)/*Error near IL_0045: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref _003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((_003CListenAsync_003Ed__7*)(nint)_003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FE00()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return _003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778574, new IntPtr(2737337536684L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00Ā()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_046a: Expected Obj, but got VT
			//IL_0050: Expected Obj, but got I4
			//IL_0443: Expected VT, but got I4
			//IL_044d: Expected native int or pointer, but got Obj
			//IL_0124: Expected native int or pointer, but got Obj
			//IL_0254: Expected Obj, but got Ref
			//IL_022f: Expected Obj, but got Ref
			//IL_0265: Expected Obj, but got I4
			//IL_026a: Expected Obj, but got I4
			//IL_026a: Expected Obj, but got Ref
			//IL_01cc: Expected Obj, but got Ref
			//IL_01cc: Expected Obj, but got Ref
			//IL_0204: Expected Obj, but got I4
			//IL_0209: Expected Obj, but got I4
			//IL_01eb: Expected Obj, but got I4
			//IL_0172: Expected I4, but got Obj
			//IL_043b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_047e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0457->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0489->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0462->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01ac->IL013d: Incompatible stack types: I4 vs Obj
			//IL_012e->IL013d: Incompatible stack heights: 1 vs 2
			//IL_0172->IL018d: Incompatible stack heights: 1 vs 0
			//IL_0139->IL013d: Incompatible stack heights: 1 vs 2
			//IL_01be->IL013d: Incompatible stack types: I4 vs Obj
			//IL_0260->IL013d: Incompatible stack types: I4 vs Obj
			//IL_0243->IL013d: Incompatible stack types: I4 vs Obj
			//IL_0183->IL0228: Incompatible stack heights: 0 vs 1
			//IL_0274->IL013d: Incompatible stack types: I4 vs Obj
			//IL_01d6->IL013d: Incompatible stack heights: 3 vs 2
			//IL_021d->IL013d: Incompatible stack types: I4 vs Obj
			//IL_024e->IL013d: Incompatible stack types: I4 vs Obj
			//IL_018d->IL013d: Incompatible stack heights: 1 vs 2
			//IL_0228->IL013d: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object stateMachine = 2;
			object obj = stateMachine;
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				case 2:
					stateMachine = _003C_003E1__state;
					obj = 0;
					if (((_003CListenAsync_003Ed__7)_003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
					{
						obj = 1;
					}
					break;
				case 4:
					if (stateMachine != null)
					{
						num = 0;
						if (CheckInternalSingleton == null)
						{
							num = 0;
						}
						goto IL_009a;
					}
					goto IL_00ce;
				case 5:
					return;
				default:
					((AsyncTaskMethodBuilder<_0021_00210>*)/*Error near IL_0431: Stack underflow*/)->Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CheckScalableWorker));
					obj = 5;
					break;
				case 3:
					goto IL_043b;
				case 1:
					{
						stateMachine = ((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Eu__2;
						obj = 4;
						if (FeverInstaller._003CInstallAsync_003Ed__11.ReflectAccessibleWatcher == null)
						{
							obj = 3;
						}
						break;
					}
					IL_009a:
					while (true)
					{
						object obj2;
						object obj3;
						object obj4;
						switch (num)
						{
						default:
							if (((Authenticator)/*Error near IL_00bf: Stack underflow*/).ReceiveAsync(stateMachine) == null)
							{
								num = 3;
								continue;
							}
							break;
						case 4:
							break;
						case 1:
							if (stateMachine == null)
							{
								_ = 4;
								if (((_003CReceiveAsync_003Ed__9*)(nint)_003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state != 0)
								{
									_ = 0;
								}
								goto IL_013d;
							}
							goto IL_018d;
						case 3:
							goto IL_043b;
							IL_013d:
							while (true)
							{
								switch ((int)obj2)
								{
								case 5:
									((AsyncTaskMethodBuilder*)/*Error near IL_017e: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)obj3, ref *(TStateMachine*)(&stateMachine));
									if ((int)/*Error near IL_0183: Stack underflow*/ == 0)
									{
										_ = 10;
										continue;
									}
									goto case 3;
								case 7:
									goto IL_018d;
								case 1:
									_003CReceiveAsync_003Ed__9.CheckCustomChain = stateMachine;
									obj2 = 9;
									continue;
								case 9:
									((RestResponse<EntityFeverManifest>)(object)Unsafe.AsPointer(ref ((_003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003E1__state)).EnsureSuccessStatusCode<EntityFeverManifest>((string?)(&stateMachine), (byte)Unsafe.AsPointer(ref this) != 0);
									_ = 6;
									continue;
								case 11:
									((_003CReceiveAuthenticationDataAsync_003Ed__10)this).client = null;
									stateMachine = 8;
									obj2 = stateMachine;
									continue;
								case 10:
									stateMachine = 0;
									((_003CReceiveAuthenticationDataAsync_003Ed__10)this)._003Cstream_003E5__2 = 0;
									obj2 = 0;
									if (_003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway == null)
									{
										obj2 = 1;
									}
									continue;
								case 3:
									obj3 = ((Encoding)obj3).GetBytes((string)(&stateMachine));
									obj2 = 0;
									if (((FeverInstaller)FeverInstaller._003CappId_003EP)._003CappVersion_003EP == null)
									{
										obj2 = 0;
									}
									continue;
								case 2:
								case 4:
									stateMachine = FeverInstaller.McBedrock__BackingField;
									obj2 = 11;
									continue;
								case 8:
									stateMachine = -1;
									((FeverInstaller)Unsafe.AsPointer(ref this)).Client__BackingField = -1;
									obj2 = 3;
									continue;
								case 6:
									return;
								}
								break;
							}
							goto default;
							IL_018d:
							obj3 = stateMachine;
							obj4 = stateMachine;
							(DecorateExpandableParser() ? ((AsyncTaskMethodBuilder*)1) : ((AsyncTaskMethodBuilder*)null))->SetException((Exception)ObserveTracker());
							stateMachine = obj4;
							obj2 = 5;
							goto IL_013d;
						}
						break;
					}
					goto IL_00ce;
					IL_043b:
					((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-2);
					obj = 0;
					if ((int)((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)FeverInstaller._003CInstallAsync_003Ed__11._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj = 0;
					}
					break;
					IL_00ce:
					num = 1;
					if (((_003CListenAuthenticationConnectAsync_003Ed__8)_003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener == null)
					{
						num = 1;
					}
					goto IL_009a;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00Ȁ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778573, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_0300()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (_003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00Ѐ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778572, new IntPtr(2737337551244L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CListenAuthenticationConnectAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TcpListener listener;

		public Authenticator _003C_003E4__this;

		private TaskAwaiter<TcpClient> _003C_003Eu__1;

		internal static object DecorateAdjustableHandler;

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
		internal static bool DecorateGenericStruct()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectRandomReporter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_F400(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778571, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_F500(object P_0)
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
					((Func<Task>)/*Error near IL_0044: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((_003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((_003CListenAsync_003Ed__7*)(nint)_003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
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
		private unsafe sealed void _FF00_F600(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778570, new IntPtr(2737337542924L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_F700()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return _003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_F800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778569, new IntPtr(2737337542924L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00豈()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0075: Expected Obj, but got I4
			//IL_0062: Expected Obj, but got VT
			//IL_0050: Expected Obj, but got I4
			//IL_01e6: Expected Obj, but got VT
			//IL_01c5: Expected Obj, but got I4
			//IL_01ca: Expected VT, but got I4
			//IL_0191: Expected Obj, but got VT
			//IL_0174: Expected native int or pointer, but got Obj
			//IL_00f0: Expected I4, but got Obj
			//IL_0142: Expected Obj, but got I4
			//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02d9->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0094->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02e4->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0127->IL00aa: Incompatible stack heights: 2 vs 1
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
				case 5:
					obj = ((_003CListenAsync_003Ed__7)this)._003C_003E1__state;
					obj2 = 4;
					break;
				case 4:
					obj = ((_003CListenAsync_003Ed__7)this)._003C_003Et__builder;
					obj2 = 2;
					break;
				case 0:
					return;
				case 1:
					((_003CListenAsync_003Ed__7)this)._003C_003E4__this = (Authenticator)(-2);
					obj2 = 3;
					if (_003CListenAsync_003Ed__7.CheckInternalSingleton == null)
					{
						obj2 = 3;
					}
					break;
				case 2:
					if (obj == null)
					{
						num = 5;
						goto IL_00aa;
					}
					goto IL_01d4;
				case 3:
					{
						((RestClientOptions)/*Error near IL_02c5: Stack underflow*/).AutomaticDecompression = (DecompressionMethods)(int)Unsafe.AsPointer(ref ((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003Eu__1);
						obj2 = 0;
						if (((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003Et__builder)._003C_003E4__this == null)
						{
							obj2 = 0;
						}
						break;
					}
					IL_01d4:
					obj = ((TcpListener)(object)((_003CReceiveAuthenticationDataAsync_003Ed__10)this).client).AcceptTcpClientAsync().GetAwaiter();
					num = 3;
					goto IL_00aa;
					IL_00aa:
					while (true)
					{
						switch (num)
						{
						case 9:
							return;
						case 1:
							break;
						case 8:
							_003C_003E1__state = (int)obj;
							num = 0;
							if (((_003CListenAuthenticationConnectAsync_003Ed__8)_003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener != null)
							{
								num = 0;
							}
							continue;
						default:
							_ = ref _003C_003E4__this;
							((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)(&obj))->Start(ref Unsafe.As<_003CListenAuthenticationConnectAsync_003Ed__8, FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14>(ref this));
							_ = 9;
							continue;
						case 3:
							if (!((TaskAwaiter*)(&obj))->IsCompleted)
							{
								num = 12;
								continue;
							}
							goto case 10;
						case 12:
							obj = 0;
							((_003CReceiveAsync_003Ed__9)this)._003C_003E1__state = 0;
							num = 8;
							continue;
						case 7:
							((_003CListenAsync_003Ed__7*)obj)->SetStateMachine((IAsyncStateMachine)obj);
							num = 1;
							if (((_003CReceiveAsync_003Ed__9*)(nint)_003CReceiveAsync_003Ed__9._003C_003E4__this)->client != null)
							{
								num = 0;
							}
							continue;
						case 4:
						case 5:
							obj = ((_003CReceiveAsync_003Ed__9)this)._003C_003Eu__1;
							num = 11;
							continue;
						case 11:
							Unsafe.As<object, TaskAwaiter<EntityFeverAppVersion>>(ref _003CReceiveAsync_003Ed__9.CheckCustomChain) = default;
							num = 2;
							continue;
						case 2:
							obj = -1;
							((_003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-1);
							num = 10;
							continue;
						case 6:
							goto IL_01d4;
						case 10:
							obj = ((TaskAwaiter<TcpClient>*)(&obj))->GetResult();
							num = 7;
							continue;
						}
						break;
					}
					goto case 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00切()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778568, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00ﬀ()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (_003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CReceiveAsync_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Authenticator _003C_003E4__this;

		public TcpClient client;

		private TaskAwaiter _003C_003Eu__1;

		internal static object CheckCustomChain;

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
		internal static bool ReflectAdvancedEnumerator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateConvertibleParameter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_EC00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778567, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_ED00(object P_0)
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
					((Func<Task>)/*Error near IL_0045: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((_003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((_003CListenAsync_003Ed__7*)(nint)_003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_EE00()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return _003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_EF00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778566, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_F100()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0418: Expected Obj, but got Ref
			//IL_041a: Expected Obj, but got I
			//IL_0051: Expected Obj, but got I4
			//IL_0078: Expected VT, but got I4
			//IL_03f3: Expected VT, but got Ref
			//IL_0090: Expected native int or pointer, but got Obj
			//IL_031c: Expected native int or pointer, but got Obj
			//IL_0260: Expected Obj, but got I4
			//IL_0153: Expected Obj, but got Ref
			//IL_01e7: Expected Obj, but got I4
			//IL_01ec: Expected VT, but got I4
			//IL_01be: Expected Obj, but got I4
			//IL_01c3: Expected Obj, but got I4
			//IL_01cd: Expected native int or pointer, but got Obj
			//IL_0220: Expected Obj, but got Ref
			//IL_0228: Expected Obj, but got Ref
			//IL_0424->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0082->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0407->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0412->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0258->IL00ea: Incompatible stack heights: 2 vs 1
			//IL_023c->IL00ea: Incompatible stack heights: 4 vs 1
			//IL_0247->IL00ea: Incompatible stack heights: 4 vs 1
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
					obj = ((_003CListenAsync_003Ed__7)this)._003C_003E1__state;
					obj2 = 0;
					if (((_003CListenAsync_003Ed__7)_003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
					{
						obj2 = 0;
					}
					break;
				case 2:
					((_003CListenAsync_003Ed__7)this)._003C_003Eu__1 = (TaskAwaiter)(-2);
					obj2 = 4;
					break;
				case 5:
				{
					int num = 1;
					if (((_003CListenAuthenticationConnectAsync_003Ed__8*)(nint)_003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
					{
						num = 1;
					}
					while (true)
					{
						int num2;
						object obj3;
						switch (num)
						{
						case 2:
							break;
						default:
							if (obj == null)
							{
								num2 = 4;
								if (((_003CListenAuthenticationConnectAsync_003Ed__8)_003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener == null)
								{
									num2 = 5;
								}
								goto IL_00ea;
							}
							goto IL_0186;
						case 1:
							{
								num = 0;
								if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E4__this)->info != null)
								{
									num = 0;
								}
								continue;
							}
							IL_00ea:
							while (true)
							{
								switch (num2)
								{
								case 3:
									return;
								case 6:
									break;
								case 7:
									((_003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003E4__this = null;
									num2 = 9;
									continue;
								case 10:
									_003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler = obj;
									num2 = 11;
									continue;
								case 1:
									if ((int)((Task)(&obj)).GetAwaiter() == 0)
									{
										num2 = 4;
										continue;
									}
									goto case 8;
								case 2:
									goto end_IL_00ea;
								case 9:
									obj = -1;
									((_003CReceiveAuthenticationDataAsync_003Ed__10)this).client = (TcpClient)(-1);
									num2 = 7;
									if (((_003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)_003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E4__this)->_003Cstream_003E5__2 != null)
									{
										num2 = 8;
									}
									continue;
								case 4:
									obj = 0;
									((_003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003Eu__1 = (TaskAwaiter<string>)0;
									num2 = 10;
									continue;
								case 11:
									_ = ref ((FeverInstaller)Unsafe.AsPointer(ref this))._003CappId_003EP;
									_ = ref obj;
									((IEnumerable<byte>)Unsafe.AsPointer(ref this)).ToArray();
									_ = 3;
									if (((FeverInstaller)FeverInstaller.McBedrock__BackingField).Client__BackingField == null)
									{
										_ = 0;
									}
									continue;
								case 8:
									((TaskAwaiter<string>*)(&obj))->GetResult();
									_ = 6;
									continue;
								default:
									obj = ((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003E1__state;
									num2 = 7;
									if (((FeverInstaller._003CFeverRequest_003Ed__15<>)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Et__builder)._003C_003E4__this == null)
									{
										num2 = 7;
									}
									continue;
								}
								goto end_IL_00a9;
								continue;
								end_IL_00ea:
								break;
							}
							goto IL_0186;
							IL_0186:
							obj3 = obj;
							((_003CListenAuthenticationConnectAsync_003Ed__8*)client)->MoveNext();
							((AsyncTaskMethodBuilder*)obj3)->SetResult();
							obj = (object)/*Error near IL_019a: Stack underflow*/;
							num2 = 1;
							if ((int)((_003CReceiveAuthenticationDataAsync_003Ed__10*)_003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								num2 = 1;
							}
							goto IL_00ea;
							end_IL_00a9:
							break;
						}
						break;
					}
					goto case 2;
				}
				case 4:
					((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_03f3: Stack underflow*/)->SetResult((_00210)Unsafe.AsPointer(ref ((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Eu__1));
					obj2 = 3;
					if (FeverInstaller._003CInstallAsync_003Ed__11.ReflectAccessibleWatcher == null)
					{
						obj2 = 3;
					}
					break;
				default:
					obj = ((Rpc)Unsafe.AsPointer(ref this)).ProcessId__BackingField;
					obj2 = 5;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_F200()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (_003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_F300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778565, new IntPtr(2737337543964L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CReceiveAuthenticationDataAsync_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TcpClient client;

		public Authenticator _003C_003E4__this;

		private object _003Cstream_003E5__2;

		private TaskAwaiter<string> _003C_003Eu__1;

		internal static object ReflectMixedGateway;

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
		internal static bool DecorateFlexibleProfiler()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HandleNotifier()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_E300(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778564, new IntPtr(2737337543964L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_E400(object P_0)
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
					((Func<Task>)/*Error near IL_0044: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((_003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((_003CListenAsync_003Ed__7*)(nint)_003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
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
		internal unsafe static object _FF00_E500()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778563, new IntPtr(2737337539804L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_E600()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return _003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_E700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778562, new IntPtr(2737337542924L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_E800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778561, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_E900()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_043b: Expected Obj, but got Ref
			//IL_0415: Expected Obj, but got I4
			//IL_0415: Expected Obj, but got Ref
			//IL_0424: Expected Obj, but got I
			//IL_03ed: Expected Obj, but got VT
			//IL_0054: Expected Obj, but got I4
			//IL_0069: Expected Obj, but got Ref
			//IL_0192: Expected Obj, but got I4
			//IL_014a: Expected Obj, but got Ref
			//IL_0154: Expected native int or pointer, but got Obj
			//IL_0102: Expected Obj, but got VT
			//IL_011d: Expected Obj, but got I4
			//IL_01ad: Expected Ref, but got VT
			//IL_01b2: Expected Obj, but got I4
			//IL_01bc: Expected native int or pointer, but got Obj
			//IL_01f0: Expected Obj, but got I4
			//IL_01f5: Expected Obj, but got I4
			//IL_01f5: Expected Obj, but got Ref
			//IL_021a: Expected Obj, but got Ref
			//IL_0445->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0429->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0401->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_007d->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0434->IL0026: Incompatible stack types: I4 vs Obj
			//IL_040c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0088->IL0026: Incompatible stack heights: 2 vs 1
			//IL_015e->IL009e: Incompatible stack heights: 4 vs 1
			//IL_010c->IL009e: Incompatible stack heights: 3 vs 1
			//IL_0131->IL009e: Incompatible stack heights: 2 vs 1
			//IL_0233->IL009e: Incompatible stack heights: 2 vs 1
			//IL_02fc->IL018d: Incompatible stack heights: 1 vs 0
			//IL_02be->IL009e: Incompatible stack heights: 2 vs 1
			//IL_02da->IL009e: Incompatible stack heights: 6 vs 1
			//IL_0169->IL009e: Incompatible stack heights: 4 vs 1
			//IL_013c->IL009e: Incompatible stack heights: 2 vs 1
			//IL_023e->IL009e: Incompatible stack heights: 2 vs 1
			//IL_0306->IL009e: Incompatible stack heights: 2 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 4:
					obj = ((_003CListenAsync_003Ed__7)this)._003C_003E1__state;
					obj2 = 3;
					break;
				case 6:
					Task.Run((Func<Task?>)Unsafe.AsPointer(ref ((_003CListenAsync_003Ed__7)this)._003C_003Et__builder));
					_ = 1;
					if (_003CListenAsync_003Ed__7.CheckInternalSingleton == null)
					{
						_ = 1;
					}
					break;
				case 5:
					if (obj != null)
					{
						num = 8;
						goto IL_009e;
					}
					goto IL_023e;
				case 3:
					obj = ((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Eu__3;
					obj2 = 5;
					if (((Rpc)FeverInstaller._003CInstallAsync_003Ed__11.ReflectAccessibleWatcher).ProcessId__BackingField == 0)
					{
						obj2 = 3;
					}
					break;
				case 1:
					return;
				case 2:
					goto IL_040d;
				default:
					{
						((Rpc)Unsafe.AsPointer(ref this)).Callbacks__BackingField = null;
						obj2 = 6;
						break;
					}
					IL_023e:
					obj = ((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003E4__this;
					num = 18;
					goto IL_009e;
					IL_009e:
					while (true)
					{
						switch (num)
						{
						case 5:
							_ = ((AsyncTaskMethodBuilder*)/*Error near IL_00f9: Stack underflow*/)->Task;
							obj = AsyncTaskMethodBuilder.Create();
							_ = 14;
							continue;
						case 6:
							GC.SuppressFinalize((object)/*Error near IL_0111: Stack underflow*/);
							((TcpListener)obj).Dispose();
							obj = 0;
							_ = 1;
							if (_003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
							{
								_ = 0;
							}
							continue;
						case 3:
							_ = ref ((_003CReceiveAsync_003Ed__9)this)._003C_003E1__state;
							_ = ref obj;
							((RestResponse<EntityFeverResponse<_00210>>)(object)Unsafe.AsPointer(ref this)).EnsureSuccessStatusCode<_00210>();
							_ = 17;
							if (((_003CReceiveAsync_003Ed__9*)(nint)_003CReceiveAsync_003Ed__9._003C_003E4__this)->client != null)
							{
								_ = 10;
							}
							continue;
						case 2:
							obj = 0;
							_003C_003E1__state = 0;
							num = 7;
							continue;
						case 8:
							_003C_003E4__this = (Authenticator)((TaskAwaiter<TcpClient>*)_003C_003Et__builder)->IsCompleted;
							num = 16;
							if ((int)((_003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)_003CReceiveAuthenticationDataAsync_003Ed__10._003Cstream_003E5__2)->_003C_003Eu__1 == 0)
							{
								num = 7;
							}
							continue;
						case 1:
						{
							object s = obj;
							((_003CReceiveAuthenticationDataAsync_003Ed__10*)obj)->MoveNext();
							obj = ((Encoding)/*Error near IL_01df: Stack underflow*/).GetBytes((string)s);
							num = 12;
							continue;
						}
						case 9:
							obj = -1;
							((FeverInstaller)Unsafe.AsPointer(ref this))._003CappId_003EP = -1;
							num = 6;
							if (FeverInstaller.McBedrock__BackingField != null)
							{
								num = 11;
							}
							continue;
						case 10:
							((TaskAwaiter<string>*)((FeverInstaller)Unsafe.AsPointer(ref this)).Client__BackingField)->GetResult();
							_ = 0;
							if ((int)((FeverInstaller._003CFeverRequest_003Ed__15<>*)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								_ = 0;
							}
							continue;
						case 4:
							break;
						case 7:
							((FeverInstaller._003CFeverRequest_003Ed__15<>)this).request = (RestRequest)obj;
							num = 3;
							continue;
						case 16:
							obj = new RestResponse<>[1024];
							num = 13;
							if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E1__state)->_003C_003Et__builder != 0)
							{
								num = 12;
							}
							continue;
						case 11:
						case 15:
							((RestClient*)(&obj))->Dispose();
							obj = (object)/*Error near IL_0296: Stack underflow*/;
							num = 5;
							continue;
						case 13:
						{
							_ = ((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003Eu__1;
							object obj3 = obj;
							((AsyncTaskMethodBuilder<EntityFeverManifest>*)null)->Start<TStateMachine>(ref *(TStateMachine*)((Array)obj).Length);
							obj = obj3;
							_ = 6;
							continue;
						}
						case 14:
							_ = ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003E1__state;
							_ = 0;
							_ = ((Array)obj).Length;
							AsyncTaskMethodBuilder<EntityFeverManifestInfo>.Create();
							_ = 10;
							continue;
						case 18:
							((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003E4__this = null;
							num = 9;
							continue;
						case 12:
							_ = ref obj;
							if ((int)AsyncTaskMethodBuilder<EntityFeverAppVersion>.Create() != 0)
							{
								_ = 15;
								continue;
							}
							goto case 2;
						case 17:
							return;
						default:
							goto IL_040d;
						}
						break;
					}
					goto IL_023e;
					IL_040d:
					((Rpc)Unsafe.AsPointer(ref this)).Logger__BackingField = -2;
					obj2 = 0;
					if (((Rpc)Rpc.NeedCha__BackingField).UseCha__BackingField != 0)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_EA00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778560, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_EB00()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (_003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}
	}

	private static object GuideError;

	private TcpListener? Listener
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (TcpListener?)_FF00_FF00_1400();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00ሀ(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe Authenticator(ILogger logger)
	{
		//IL_001b: Expected I4, but got Obj
		//IL_0016: Expected native int or pointer, but got Obj
		//IL_0026: Expected I, but got Obj
		//IL_0030: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((_003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)logger;
		((Func<Task>)/*Error near IL_0026: Stack underflow*/)._002Ector((object)/*Error near IL_0026: Stack underflow*/, (nint)this);
		int num = 0;
		if ((int)((_003CListenAsync_003Ed__7*)(nint)_003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
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
	public void StartListening(int port)
	{
		_FF00_FF00ࠀ((uint)port);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CListenAsync_003Ed__7))]
	private object ListenAsync()
	{
		return _FF00_FF00_0C00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CListenAuthenticationConnectAsync_003Ed__8))]
	private object ListenAuthenticationConnectAsync(object listener)
	{
		return _FF00_FF00_0E00(listener);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReceiveAsync_003Ed__9))]
	private object ReceiveAsync(object client)
	{
		return _FF00_FF00က(client);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReceiveAuthenticationDataAsync_003Ed__10))]
	private object ReceiveAuthenticationDataAsync(object client)
	{
		return _FF00_FF00ᘀ(client);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		_FF00_FF00_0600();
	}

	protected abstract Task<string> HandleAuthentication(string message);

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectMonoObject()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Authenticator PatchUser()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00Ԁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778589, new IntPtr(2737337548124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_0600()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_007b: Expected native int or pointer, but got Obj
		//IL_00ac: Expected native int or pointer, but got Obj
		//IL_00d5: Expected native int or pointer, but got Obj
		//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0090->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006a->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00b6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00df->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ea->IL0026: Incompatible stack types: I4 vs Obj
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
			case 1:
			case 3:
				((Authenticator)null)._FF00_FF00_1400();
				_ = 0;
				if (((_003CListenAsync_003Ed__7)_003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
				{
					_ = 0;
				}
				break;
			case 2:
				return;
			default:
				((TcpListener)this).Start();
				obj2 = 2;
				if (((_003CListenAuthenticationConnectAsync_003Ed__8*)(nint)_003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
			{
				object obj3 = ((Authenticator)/*Error near IL_0096: Stack underflow*/).ReceiveAuthenticationDataAsync((object)this);
				if (obj3 == null)
				{
					obj2 = 3;
					if (((_003CListenAuthenticationConnectAsync_003Ed__8*)(nint)_003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this != null)
					{
						obj2 = 1;
					}
					break;
				}
				((IAsyncStateMachine)obj3).MoveNext();
				obj2 = 0;
				if (((_003CReceiveAsync_003Ed__9*)(nint)_003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state != 0)
				{
					obj2 = 1;
				}
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00ࠀ(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_005d: Expected native int or pointer, but got Obj
		//IL_0067: Expected Obj, but got VT
		//IL_00bd: Expected native int or pointer, but got Obj
		//IL_0051: Expected I4, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_0077->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a8->IL0026: Incompatible stack types: I4 vs Obj
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
				((Authenticator)/*Error near IL_0051: Stack underflow*/).StartListening((int)new Func<Task>(this, (int)P_0));
				obj2 = 2;
				break;
			case 1:
				return;
			default:
				((AsyncTaskMethodBuilder*)/*Error near IL_006d: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<string>*)((Authenticator)/*Error near IL_0067: Stack underflow*/).ListenAuthenticationConnectAsync((object)((_003CListenAsync_003Ed__7*)(nint)this)->_003C_003Eu__1), ref *(_003CReceiveAuthenticationDataAsync_003Ed__10*)P_0);
				obj2 = 4;
				break;
			case 4:
				((TcpListener)new GC((object)__ldftn(Authenticator.ReceiveAuthenticationDataAsync))).Dispose();
				obj2 = 0;
				if (_003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler != null)
				{
					obj2 = 1;
				}
				break;
			case 2:
				((_003CListenAsync_003Ed__7*)this)->MoveNext();
				((AsyncTaskMethodBuilder*)/*Error near IL_00b3: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_00b3: Stack underflow*/, ref *(TStateMachine*)/*Error near IL_00b3: Stack underflow*/);
				obj2 = 0;
				if (((_003CReceiveAsync_003Ed__9*)(nint)_003CReceiveAsync_003Ed__9._003C_003E4__this)->client == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_0900()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (_003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_0A00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778588, new IntPtr(2737337541884L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_0B00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778587, new IntPtr(2737337557484L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_0C00()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4317, 1790778586, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778586, new IntPtr(2737337547084L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_0D00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778585, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_0E00(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4319, 1790778584, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778584, new IntPtr(2737337541884L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00ༀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778583, new IntPtr(2737337566844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00က(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4321, 1790778582, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778582, new IntPtr(2737337556444L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00ᄀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778581, new IntPtr(2737337557484L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00ሀ(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected I4, but got Obj
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
				((_003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)P_0;
				obj2 = 0;
				if (((_003CListenAsync_003Ed__7)_003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
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
	private unsafe object _FF00_FF00ጀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778580, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_1400()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_001b: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((_003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00ᔀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778579, new IntPtr(2737337557484L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00ᘀ(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4327, 1790778578, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778578, new IntPtr(2737337548124L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00ᜀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778577, new IntPtr(2737337550204L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_1800()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return _003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00ᤀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778576, new IntPtr(2737337549164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
