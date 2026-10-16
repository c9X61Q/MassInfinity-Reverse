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
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Mass.Application.Desktop;
using Mass.Application.Desktop.Security;
using Mass.Application.Extensions;
using Mass.Application.Models;
using Mass.Application.Netease;
using Mass.Common.Extensions;
using Mass.Domain.Desktop.Entities.Mods;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Entities;
using Mass.Domain.Value;
using Mass.Domain.ValueObjects;
using Mass.Game.Launcher.Cpp;
using Mass.Game.Launcher.Entities.Fever;
using Mass.Game.Launcher.Enums;
using Mass.Game.Launcher.Helpers;
using Mass.Game.Launcher.Java.LanGame;
using Mass.Game.Launcher.Java.Option;
using Mass.Game.Launcher.Models;
using Mass.Game.Launcher.Paths;
using Mass.Game.Launcher.Values;
using Mass.Game.Proxy;
using Microsoft.Win32;
using Org.BouncyCastle.Crypto.Engines;
using RestSharp;
using Serilog;

namespace Mass.Game.Launcher.Java;

public class JavaGame : GameInstance
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003Ec__DisplayClass138_0
	{
		public JavaGame _003C_003E4__this;

		public int percentage;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLaunchAsync_003Ed__106 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object RestartIterator;

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
		internal static bool DecorateDividedEmitter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateGeneralRunner()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 㼀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778740, new IntPtr(2737337578284L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 䀀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0045: Expected I, but got Obj
			//IL_0045: Expected Obj, but got Ref
			//IL_004f: Expected native int or pointer, but got Obj
			//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 䄀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 䈀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778739, new IntPtr(2737337580364L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 䌀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_052b: Expected Obj, but got VT
			//IL_0535: Expected native int or pointer, but got Obj
			//IL_0165: Expected Obj, but got I4
			//IL_010b: Expected I4, but got Obj
			//IL_0145: Expected Obj, but got I4
			//IL_014a: Expected VT, but got I4
			//IL_0214: Expected Obj, but got Ref
			//IL_017a: Expected Obj, but got I4
			//IL_01ee: Expected Obj, but got Ref
			//IL_01f8: Expected native int or pointer, but got Obj
			//IL_01d9: Expected I4, but got Obj
			//IL_01e2: Expected Obj, but got I4
			//IL_01a8: Expected Obj, but got I4
			//IL_01ad: Expected Obj, but got I4
			//IL_01b6: Expected Obj, but got I4
			//IL_053f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_057b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0599->IL0026: Incompatible stack types: I4 vs Obj
			//IL_055f->IL0026: Incompatible stack heights: 2 vs 1
			//IL_054a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0586->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d2->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_0154->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_0140->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_01d1->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_0202->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_0128->IL00d6: Incompatible stack heights: 2 vs 1
			//IL_022d->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_020d->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_0238->IL00d6: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				default:
					if (obj != null)
					{
						num = 2;
						goto IL_005e;
					}
					goto IL_0078;
				case 1:
					obj = ((Rpc._003CListenAsync_003Ed__34)this)._003C_003Eu__1;
					obj2 = 0;
					if (((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)Mass.Game.Launcher.Rpc._003CListenAsync_003Ed__34.DecorateIterableWriter)->_003C_003E1__state == 0)
					{
						obj2 = 0;
					}
					continue;
				case 5:
					_ = Unsafe.As<AsyncTaskMethodBuilder, TaskAwaiter<RestResponse<EntityFeverManifest>>>(ref ((Rpc._003CListenControlConnectAsync_003Ed__35)this)._003C_003Et__builder).IsCompleted;
					_ = 4;
					continue;
				case 2:
					obj = ((Rpc._003CListenControlConnectAsync_003Ed__35)this)._003C_003E4__this;
					obj2 = 0;
					if (Mass.Game.Launcher.Rpc._003CListenControlConnectAsync_003Ed__35.ReflectSymbolicDecorator != null)
					{
						obj2 = 1;
					}
					continue;
				case 4:
					return;
				case 3:
					break;
					IL_005e:
					while (true)
					{
						object obj3;
						switch (num)
						{
						case 3:
							break;
						case 2:
							((Authenticator)obj).StartListening(1);
							num = 3;
							if (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
							{
								num = 2;
							}
							continue;
						case 1:
							if (obj != null)
							{
								obj3 = 6;
								goto IL_00d6;
							}
							goto IL_0154;
						default:
							goto end_IL_0026;
							IL_0154:
							obj = Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler;
							obj = 5;
							goto IL_00d2;
							IL_00d2:
							obj3 = obj;
							goto IL_00d6;
							IL_00d6:
							while (true)
							{
								switch ((int)obj3)
								{
								case 10:
									_ = ref ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003E1__state;
									((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CLaunchAsync_003Ed__106, FeverInstaller._003CInstallAsync_003Ed__11>(ref this));
									_ = 9;
									continue;
								case 3:
									((Authenticator)obj).Dispose();
									((TcpListener)/*Error near IL_0134: Stack underflow*/).Dispose();
									obj = (object)/*Error near IL_0136: Stack underflow*/;
									obj3 = 4;
									continue;
								case 2:
									obj = -1;
									((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Eu__1 = (TaskAwaiter<TcpClient>)(-1);
									obj3 = 7;
									continue;
								case 6:
									goto IL_016a;
								case 9:
									return;
								case 11:
									goto IL_01a3;
								case 5:
									Unsafe.As<TaskAwaiter, bool>(ref ((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003Eu__1) = default;
									obj3 = 2;
									continue;
								case 8:
									goto IL_01d1;
								case 7:
									((AsyncTaskMethodBuilder*)/*Error near IL_01ee: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)(&obj));
									obj3 = 1;
									if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.client)->_003C_003E4__this == null)
									{
										obj3 = 1;
									}
									continue;
								case 4:
									if ((int)((Task<TcpClient>)(&obj)).GetAwaiter() == 0)
									{
										obj3 = 11;
										if (Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway != null)
										{
											obj3 = 6;
										}
										continue;
									}
									goto case 7;
								case 1:
									goto end_IL_0026;
								}
								break;
							}
							goto IL_0154;
							IL_01d1:
							((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003E1__state = (int)obj;
							obj = 10;
							goto IL_00d2;
							IL_01a3:
							obj = 0;
							((Authenticator._003CReceiveAsync_003Ed__9)this).client = (TcpClient)0;
							obj = 8;
							goto IL_00d2;
							IL_016a:
							((Authenticator._003CListenAsync_003Ed__7*)obj)->MoveNext();
							obj = 3;
							goto IL_00d2;
						}
						break;
					}
					goto IL_0078;
					IL_0078:
					num = 1;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						num = 0;
					}
					goto IL_005e;
					end_IL_0026:
					break;
				}
				((Rpc._003CReceiveAsync_003Ed__28)this)._003C_003E1__state = -2;
				obj2 = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 䐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778738, new IntPtr(2737337577244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 䔀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 䘀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778737, new IntPtr(2737337594924L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLaunchStepsAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object DetachChooser;

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
		internal static bool CheckVisibleListener()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateCentralTracker()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 㔀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778736, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 㘀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
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
		private unsafe sealed void 㜀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778735, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 㠀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 㤀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778734, new IntPtr(2737337578284L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 㨀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778733, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 㬀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0d93: Expected Obj, but got Ref
			//IL_0da1: Expected Obj, but got I4
			//IL_007a: Expected I4, but got Obj
			//IL_0d6d: Expected Obj, but got I4
			//IL_0d6d: Expected Obj, but got Ref
			//IL_0d7c: Expected Obj, but got I
			//IL_0d44: Expected Obj, but got Ref
			//IL_0d46: Expected Obj, but got I
			//IL_0050: Expected Obj, but got I4
			//IL_086f: Expected Obj, but got Ref
			//IL_091d: Expected Obj, but got Ref
			//IL_0bf1: Expected Obj, but got Ref
			//IL_0775: Expected Obj, but got Ref
			//IL_0777: Expected Obj, but got I
			//IL_0acb: Expected Obj, but got Ref
			//IL_0803: Expected Obj, but got Ref
			//IL_097a: Expected Obj, but got Ref
			//IL_0473: Expected Obj, but got I4
			//IL_08b4: Expected Obj, but got I4
			//IL_08b9: Expected Obj, but got I4
			//IL_08b9: Expected Obj, but got Ref
			//IL_025e: Expected Obj, but got I4
			//IL_0263: Expected VT, but got I4
			//IL_026d: Expected native int or pointer, but got Obj
			//IL_0287: Expected Obj, but got I4
			//IL_028c: Expected VT, but got I4
			//IL_0296: Expected native int or pointer, but got Obj
			//IL_0c68: Expected native int or pointer, but got Obj
			//IL_0c77: Expected Obj, but got VT
			//IL_0c7e: Expected Obj, but got I4
			//IL_0596: Expected Obj, but got I4
			//IL_0741: Expected Obj, but got Ref
			//IL_0750: Expected Obj, but got I
			//IL_08a3: Expected VT, but got Obj
			//IL_0a7a: Expected Obj, but got Ref
			//IL_07d2: Expected Obj, but got I
			//IL_07d7: Expected I4, but got Obj
			//IL_07dc: Expected Obj, but got I4
			//IL_0a3d: Expected Obj, but got Ref
			//IL_0351: Expected Obj, but got Ref
			//IL_0351: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b6: Expected native int or pointer, but got Obj
			//IL_067a: Expected Obj, but got I4
			//IL_085d: Expected Obj, but got I4
			//IL_0b62: Expected Obj, but got I4
			//IL_0b67: Expected Obj, but got I4
			//IL_0b67: Expected Obj, but got Ref
			//IL_044e: Expected native int or pointer, but got Obj
			//IL_079e: Expected Obj, but got I
			//IL_07af: Expected Obj, but got I
			//IL_0244: Expected native int or pointer, but got Obj
			//IL_070c: Expected Obj, but got I4
			//IL_09d0: Expected Obj, but got Ref
			//IL_0b04: Expected Obj, but got Ref
			//IL_0c8f: Expected Obj, but got Ref
			//IL_04d2: Expected Obj, but got I4
			//IL_05f4: Expected native int or pointer, but got Obj
			//IL_05fe: Expected Ref, but got VT
			//IL_0600: Expected Obj, but got I4
			//IL_060a: Expected native int or pointer, but got Obj
			//IL_0684: Expected Obj, but got I4
			//IL_0887: Expected VT, but got Obj
			//IL_0889: Expected Obj, but got VT
			//IL_0892: Expected Obj, but got I4
			//IL_08dd: Expected Obj, but got I4
			//IL_08e2: Expected Obj, but got I4
			//IL_08e2: Expected Obj, but got Ref
			//IL_0a10: Expected Obj, but got Ref
			//IL_06e7: Expected native int or pointer, but got Obj
			//IL_0540: Expected VT, but got Obj
			//IL_0540: Expected Obj, but got I4
			//IL_09a1: Expected Obj, but got Ref
			//IL_09a9: Expected Obj, but got Ref
			//IL_09a9: Expected Obj, but got Ref
			//IL_05e8: Expected Obj, but got Ref
			//IL_09fb: Expected Obj, but got I4
			//IL_0a00: Expected Obj, but got I4
			//IL_0a00: Expected Obj, but got Ref
			//IL_096a: Expected Obj, but got Ref
			//IL_09f1: Expected Obj, but got I4
			//IL_0907: Expected Obj, but got Ref
			//IL_082b: Expected I4, but got Obj
			//IL_0830: Expected Obj, but got I4
			//IL_0493: Expected Obj, but got I4
			//IL_0498: Expected VT, but got I4
			//IL_04a2: Expected native int or pointer, but got Obj
			//IL_0bdc: Expected Obj, but got I4
			//IL_0be1: Expected Obj, but got I4
			//IL_0be1: Expected Obj, but got Ref
			//IL_0a55: Expected Obj, but got Ref
			//IL_0202: Expected Obj, but got I4
			//IL_05c1: Expected Obj, but got Ref
			//IL_0320: Expected native int or pointer, but got Obj
			//IL_02cf: Expected native int or pointer, but got Obj
			//IL_02d9: Expected Obj, but got I4
			//IL_02e5: Expected native int or pointer, but got Obj
			//IL_0716: Expected Obj, but got I4
			//IL_071b: Expected Obj, but got I4
			//IL_071b: Expected Obj, but got Ref
			//IL_039b: Expected Obj, but got Ref
			//IL_0572: Expected Obj, but got Ref
			//IL_0c9f: Expected Obj, but got Ref
			//IL_0ca7: Expected Obj, but got Ref
			//IL_0ca7: Expected Obj, but got Ref
			//IL_0aa6: Expected Obj, but got Ref
			//IL_0da6->IL0022: Incompatible stack heights: 1 vs 0
			//IL_0d81->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0d5a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0d8c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0d65->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0755->IL0088: Incompatible stack heights: 2 vs 1
			//IL_067f->IL0084: Incompatible stack heights: 0 vs 1
			//IL_0458->IL0088: Incompatible stack heights: 2 vs 1
			//IL_0711->IL0084: Incompatible stack types: I4 vs Obj
			//IL_0b18->IL0088: Incompatible stack heights: 2 vs 1
			//IL_0897->IL0084: Incompatible stack heights: 0 vs 1
			//IL_0a2c->IL0088: Incompatible stack heights: 2 vs 1
			//IL_06f1->IL0088: Incompatible stack heights: 2 vs 1
			//IL_09bd->IL0088: Incompatible stack heights: 2 vs 1
			//IL_09f6->IL0084: Incompatible stack heights: 0 vs 1
			//IL_0403->IL0088: Incompatible stack heights: 2 vs 1
			//IL_0b3e->IL056b: Incompatible stack heights: 1 vs 0
			//IL_0207->IL0084: Incompatible stack heights: 0 vs 1
			//IL_05cb->IL0088: Incompatible stack heights: 2 vs 1
			//IL_03a5->IL0088: Incompatible stack heights: 3 vs 1
			//IL_0792->IL0088: Incompatible stack heights: 3 vs 1
			//IL_0088->IL0088: Incompatible stack heights: 2 vs 1
			//IL_0760->IL0088: Incompatible stack heights: 2 vs 1
			//IL_0463->IL0088: Incompatible stack heights: 2 vs 1
			//IL_0b23->IL0088: Incompatible stack heights: 2 vs 1
			//IL_0a37->IL0088: Incompatible stack heights: 2 vs 1
			//IL_06fc->IL0088: Incompatible stack heights: 2 vs 1
			//IL_09c8->IL0088: Incompatible stack heights: 2 vs 1
			//IL_0b52->IL0088: Incompatible stack heights: 2 vs 1
			//IL_0b5d->IL0088: Incompatible stack heights: 2 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
					case 4:
						stateMachine = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
						obj = 3;
						continue;
					case 1:
					{
						int num;
						switch ((int)stateMachine)
						{
						default:
							num = 83;
							goto IL_0088;
						case 0:
							stateMachine = FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor;
							num = 3;
							if ((int)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E1__state)->_003C_003Et__builder != 0)
							{
								num = 18;
							}
							goto IL_0088;
						case 4:
							goto IL_076f;
						case 1:
							goto IL_0869;
						case 2:
							goto IL_0917;
						case 5:
							goto IL_0ac5;
						case 3:
							goto IL_0beb;
							IL_0088:
							while (true)
							{
								Task<EntityFeverAppVersion> task;
								switch (num)
								{
								case 68:
									((Func<Task>)/*Error near IL_01f9: Stack underflow*/)._002Ector((object)/*Error near IL_01f9: Stack underflow*/, (nint)(&stateMachine));
									stateMachine = 24;
									continue;
								case 20:
									((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E4__this = (Authenticator)stateMachine;
									num = 40;
									if (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton != null)
									{
										num = 51;
									}
									continue;
								case 30:
									((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003E1__state = default;
									num = 7;
									if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this != null)
									{
										num = 25;
									}
									continue;
								case 5:
									stateMachine = -1;
									((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Eu__1 = (TaskAwaiter<TcpClient>)(-1);
									num = 5;
									if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state == 0)
									{
										num = 13;
									}
									continue;
								case 7:
									stateMachine = -1;
									((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-1);
									num = 44;
									if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9._003C_003E4__this)->client == null)
									{
										num = 80;
									}
									continue;
								case 27:
									((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)stateMachine)->MoveNext();
									num = 42;
									continue;
								case 74:
									((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)/*Error near IL_02c3: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)stateMachine);
									num = 21;
									continue;
								case 75:
									((AsyncTaskMethodBuilder*)/*Error near IL_02d9: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)stateMachine)->_003C_003E1__state);
									stateMachine = (object)/*Error near IL_02db: Stack underflow*/;
									num = 49;
									if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.client)->_003C_003E4__this != null)
									{
										num = 78;
									}
									continue;
								case 46:
									return;
								case 72:
									stateMachine = ((Encoding)/*Error near IL_032a: Stack underflow*/).GetBytes((string)Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway);
									num = 22;
									if (((FeverInstaller)FeverInstaller._003CappId_003EP)._003CappVersion_003EP == null)
									{
										num = 38;
									}
									continue;
								case 19:
									FeverInstaller.McBedrock__BackingField = (object)default(RestClientOptions);
									num = 76;
									continue;
								case 11:
									if (((TaskAwaiter<string>*)(&stateMachine))->GetResult() == null)
									{
										num = 43;
										continue;
									}
									goto case 57;
								case 34:
									if (((Stream)/*Error near IL_037e: Stack underflow*/).Read((byte[])/*Error near IL_037e: Stack underflow*/, (int)/*Error near IL_037e: Stack underflow*/, (int)(&stateMachine)) != 0)
									{
										num = 8;
										continue;
									}
									goto case 12;
								case 77:
									_ = ref ((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003Et__builder;
									((IEnumerable<byte>)(&stateMachine)).Take((int)Unsafe.AsPointer(ref this));
									_ = 46;
									continue;
								case 1:
									return;
								case 21:
									((RestClientOptions)/*Error near IL_03c0: Stack underflow*/).UserAgent = (string)(object)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)stateMachine)->request;
									stateMachine = (object)/*Error near IL_03c2: Stack underflow*/;
									num = 28;
									continue;
								case 8:
								case 52:
									((RestClientOptions)/*Error near IL_03d3: Stack underflow*/).AutomaticDecompression = (DecompressionMethods)(int)(&stateMachine);
									num = 56;
									if (((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003Et__builder)._003C_003E4__this != null)
									{
										num = 13;
									}
									continue;
								case 57:
									_ = ((AsyncTaskMethodBuilder<EntityFeverManifest>*)(&stateMachine))->Task;
									_ = 9;
									continue;
								case 26:
									break;
								case 28:
									_ = ((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)(&stateMachine))->Task;
									_ = 22;
									if ((int)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12.info)->_003C_003Eu__1 == 0)
									{
										_ = 2;
									}
									continue;
								case 3:
									task = ((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)(&stateMachine))->Task;
									stateMachine = 62;
									continue;
								case 33:
									((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)/*Error near IL_047f: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)(&stateMachine));
									if ((int)/*Error near IL_0484: Stack underflow*/ == 0)
									{
										num = 4;
										continue;
									}
									goto case 68;
								case 65:
									stateMachine = -1;
									((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003Et__builder = (AsyncTaskMethodBuilder<EntityFeverManifestInfo>)(-1);
									num = 52;
									if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13._003C_003E4__this)->version == null)
									{
										num = 41;
									}
									continue;
								case 83:
									/*Error near IL_04b9: Member reference must be method, but was: Field*/;
								case 40:
									stateMachine = 1;
									((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003E1__state = 1;
									num = 55;
									if (((FeverInstaller._003CInstallAsync_003Ed__11)FeverInstaller._003CInstallAsync_003Ed__11._003C_003Et__builder)._003C_003E4__this != null)
									{
										num = 40;
									}
									continue;
								case 78:
									_ = ref stateMachine;
									/*Error near IL_04f8: Member reference must be method, but was: Field*/;
								case 41:
									_ = ref stateMachine;
									/*Error near IL_051e: Member reference must be method, but was: Field*/;
								case 49:
									stateMachine = (((Rpc)(object)RestClientExtensions.ExecuteAsync<_0021_00210>((IRestClient)(object)((Rpc)/*Error near IL_0532: Stack underflow*/).ProcessId, (RestRequest)stateMachine, (CancellationToken)((Rpc)stateMachine).Logger__BackingField)).NeedCha ? ((TaskAwaiter<RestResponse<EntityFeverResponse<_00210>>>*)1) : ((TaskAwaiter<RestResponse<EntityFeverResponse<_00210>>>*)null))->GetResult();
									num = 34;
									if (((Rpc)Mass.Game.Launcher.Rpc.Writer__BackingField).Listener__BackingField != null)
									{
										num = 3;
									}
									continue;
								case 80:
									((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_0572: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)(&stateMachine));
									num = 44;
									if (Mass.Game.Launcher.Rpc.ParseMap == null)
									{
										num = 19;
									}
									continue;
								case 12:
									stateMachine = 2;
									((Rpc._003CListenAsync_003Ed__34)this)._003C_003E1__state = 2;
									num = 3;
									if (((Rpc._003CListenAsync_003Ed__34)Mass.Game.Launcher.Rpc._003CListenAsync_003Ed__34._003C_003Et__builder)._003C_003E4__this != null)
									{
										num = 35;
									}
									continue;
								case 69:
									((Task<EntityFeverApp>)(&stateMachine)).GetAwaiter();
									_ = 49;
									continue;
								case 58:
									if (((TaskAwaiter<EntityFeverApp>*)(&stateMachine))->GetResult() != null)
									{
										num = 73;
										continue;
									}
									goto case 40;
								case 53:
									((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)/*Error near IL_05e8: Stack underflow*/)->SetException((Exception)(&stateMachine));
									num = 74;
									continue;
								case 42:
									stateMachine = ((TaskAwaiter<RestResponse<EntityFeverManifest>>*)((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)stateMachine)->_003C_003Et__builder)->IsCompleted;
									num = 0;
									if ((int)((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)Mass.Game.Launcher.Rpc._003CListenControlConnectAsync_003Ed__35._003C_003E4__this)->_003C_003Eu__1 != 0)
									{
										num = 32;
									}
									continue;
								case 81:
									Mass.Game.Launcher.Rpc._003CListenControlConnectAsync_003Ed__35.ReflectSymbolicDecorator = stateMachine;
									num = 47;
									if ((int)((Rpc._003CReceiveAsync_003Ed__28*)Mass.Game.Launcher.Rpc._003CReceiveAsync_003Ed__28._003C_003E1__state)->_003C_003Et__builder != 0)
									{
										num = 12;
									}
									continue;
								case 22:
									((Rpc._003CListenAsync_003Ed__34*)stateMachine)->MoveNext();
									stateMachine = 75;
									continue;
								case 43:
									stateMachine = 5;
									((Rpc._003CRemoteCallBackAsync_003Ed__21)this)._003C_003E1__state = 5;
									num = 20;
									if (((Rpc._003CRemoteCallBackAsync_003Ed__21)Mass.Game.Launcher.Rpc._003CRemoteCallBackAsync_003Ed__21._003C_003Et__builder)._003C_003E4__this != null)
									{
										num = 0;
									}
									continue;
								case 84:
									((Rpc._003CRemoteCallBackAsync_003Ed__21)this).callBack = (RpcCallBack)stateMachine;
									num = 42;
									if (Mass.Game.Launcher.Rpc._003CRemoteCallBackAsync_003Ed__21.MeasureCalc == null)
									{
										num = 48;
									}
									continue;
								case 48:
									_ = ref ((Rpc._003CSyncChaChaAsync_003Ed__38)this)._003C_003E1__state;
									((AsyncTaskMethodBuilder*)(&stateMachine))->Start(ref Unsafe.As<_003CLaunchStepsAsync_003Ed__2, _003CStartGameUnsafe_003Ed__138>(ref this));
									_ = 1;
									if ((object)((Rpc._003CSyncChaChaAsync_003Ed__38*)(nint)Mass.Game.Launcher.Rpc._003CSyncChaChaAsync_003Ed__38._003C_003E4__this)->callBack != null)
									{
										_ = 0;
									}
									continue;
								case 32:
								{
									bool isCompleted = ((TaskAwaiter<EntityFeverAppVersion>*)(&stateMachine))->IsCompleted;
									stateMachine = 10;
									task = (Task<EntityFeverAppVersion>)isCompleted;
									continue;
								}
								case 76:
									stateMachine = -1;
									((CppGameValue)Unsafe.AsPointer(ref this)).SkinPath__BackingField = -1;
									num = 51;
									if (((GameValue)CppGameValue.DecorateAlphabeticList).MaxConcurrency__BackingField == 0)
									{
										num = 87;
									}
									continue;
								case 13:
									((Task<EntityFeverManifest>)(&stateMachine)).GetAwaiter();
									_ = 24;
									if (((JavaGameValue)JavaGameValue.MaxMemory__BackingField).Reconnect__BackingField != 0)
									{
										_ = 29;
									}
									continue;
								case 79:
									return;
								case 31:
									goto IL_076f;
								case 82:
									Mass.Game.Launcher.Rpc._003CSyncChaChaAsync_003Ed__38.CheckAlphabeticPolicy();
									_ = 71;
									continue;
								case 29:
									stateMachine = Enumerable.Concat<TSource>((IEnumerable<TSource>)/*Error near IL_079e: Stack underflow*/, (IEnumerable<TSource>)((JavaGameValue)stateMachine).SetChinese__BackingField);
									num = 38;
									if (((JavaGameValue)JavaGameValue.GuiScale__BackingField).SetSize__BackingField != 0)
									{
										num = 41;
									}
									continue;
								case 17:
								{
									bool flag = CppGameValue.ReflectEditableRecord();
									((GameValue)stateMachine).MaxConcurrency = (int)((MemberInfo)((JavaGameValue)stateMachine).WindowHeight__BackingField).Name;
									((Dictionary<ushort, Func<RpcCallBack, Task>>)/*Error near IL_07dc: Stack underflow*/)[(ushort)/*Error near IL_07dc: Stack underflow*/] = (Func<RpcCallBack, Task>)flag;
									stateMachine = (object)/*Error near IL_07de: Stack underflow*/;
									num = 15;
									if (((ComponentPath)(object)BedrockGamePath.StartTemplate).IsDirectory)
									{
										num = 33;
									}
									continue;
								}
								default:
									((ComponentPath)Unsafe.AsPointer(ref this)).Target = null;
									num = 54;
									continue;
								case 64:
								{
									int maxMemory = ((JavaGameValue)/*Error near IL_0818: Stack underflow*/).MaxMemory;
									((JavaGameValue)stateMachine).Reconnect = (byte)(int)((IPEndPoint)(object)((ComponentPath)stateMachine).ComponentZip).Address != 0;
									stateMachine = ((TcpClient)maxMemory).Client;
									num = 58;
									if (!((ComponentPath)(object)ComponentPath.Item).IsShaderPack)
									{
										num = 58;
									}
									continue;
								}
								case 24:
									((BinaryReader)/*Error near IL_085d: Stack underflow*/)._002Ector((Stream)((ComponentPath)stateMachine).IsResourcePack);
									stateMachine = (object)/*Error near IL_085f: Stack underflow*/;
									num = 39;
									continue;
								case 36:
									goto IL_0869;
								case 44:
									stateMachine = CollectionExtensions.GetValueOrDefault<TKey, TValue>((IReadOnlyDictionary<TKey, TValue>)/*Error near IL_0887: Stack underflow*/, (TKey)((CppGamePath)stateMachine).BedrockLauncher);
									stateMachine = 53;
									continue;
								case 14:
									((ILogger)/*Error near IL_08a3: Stack underflow*/).Error<_0021_00210>((Exception)/*Error near IL_08a3: Stack underflow*/, (string)/*Error near IL_08a3: Stack underflow*/, (_0021_00210)((CppGamePath)stateMachine).Bedrock);
									stateMachine = (object)/*Error near IL_08a5: Stack underflow*/;
									num = 69;
									continue;
								case 4:
									stateMachine = 3;
									((CppGamePath)Unsafe.AsPointer(ref this)).BePackCache = (string)3;
									num = 37;
									if (((CppGamePath)(object)CppGamePath.BeMain).AppData == null)
									{
										num = 81;
									}
									continue;
								case 45:
									stateMachine = 4;
									((CppGamePath)Unsafe.AsPointer(ref this)).GameRuntime = (string)4;
									num = 84;
									if (((CppGamePath)(object)CppGamePath.ConfigFile).ErrorLog != null)
									{
										num = 33;
									}
									continue;
								case 59:
									CppGamePath.CheckDetachedBridge = null;
									num = 65;
									continue;
								case 70:
									goto IL_0917;
								case 71:
								{
									object obj2 = stateMachine;
									((IDisposable)(object)((GamePath)stateMachine).Cache).Dispose();
									stateMachine = ((RegistryKey)obj2).OpenSubKey((string)(object)BedrockGamePath.DecorateSetConverter());
									num = 11;
									continue;
								}
								case 55:
									GamePath.CheckGeneralStrategy = stateMachine;
									num = 77;
									continue;
								case 2:
									((Tuple<ChaChaX, ChaChaX, byte[], byte[]>)/*Error near IL_0982: Stack underflow*/).Deconstruct(out *(ChaChaX*)/*Error near IL_0982: Stack underflow*/, out Unsafe.As<string, ChaChaX>(ref ((JavaGamePath)Unsafe.AsPointer(ref this)).Java), out *(byte[]*)(&stateMachine), out Unsafe.As<_003CLaunchStepsAsync_003Ed__2, byte[]>(ref this));
									num = 61;
									continue;
								case 61:
									return;
								case 51:
									Interlocked.CompareExchange(ref Unsafe.As<string, Action<byte[]>>(ref ((JavaGamePath)Unsafe.AsPointer(ref this)).JavaTarget), (Action<byte[]>)(&stateMachine), (Action<byte[]>)Unsafe.AsPointer(ref this));
									_ = 16;
									if (((JavaGamePath)(object)JavaGamePath.JavaExe).GameBase == null)
									{
										_ = 8;
									}
									continue;
								case 35:
									((JavaGamePath)Unsafe.AsPointer(ref this)).GameBaseComponents = (string)stateMachine;
									num = 2;
									continue;
								case 56:
									stateMachine = ((EntityItemDownload)(object)((JavaGamePath)stateMachine).GameBaseMd5).ItemId;
									stateMachine = 3;
									continue;
								case 54:
									stateMachine = -1;
									((JavaGamePath)Unsafe.AsPointer(ref this)).GameVersionMd5 = (string)(-1);
									num = 57;
									continue;
								case 47:
									_ = ref ((JavaGamePath)Unsafe.AsPointer(ref this)).GameCoreLibs;
									((AsyncTaskMethodBuilder*)(&stateMachine))->Start(ref Unsafe.As<_003CLaunchStepsAsync_003Ed__2, DesktopTransfer._003CConnectWebRtc_003Ed__35>(ref this));
									_ = 7;
									if (((JavaGamePath)(object)JavaGamePath.GameRuntime).GameRuntimeMd5 != null)
									{
										_ = 63;
									}
									continue;
								case 18:
									((JavaGamePath)Unsafe.AsPointer(ref this)).Custom = null;
									num = 5;
									continue;
								case 67:
									((JavaGamePath)Unsafe.AsPointer(ref this)).GameCustom = (string)stateMachine;
									num = 85;
									if (JavaGamePath.ReflectCentralEmitter == null)
									{
										num = 40;
									}
									continue;
								case 15:
									((MinecraftPath)Unsafe.AsPointer(ref this)).Root = null;
									num = 1;
									if (((MinecraftPath)(object)MinecraftPath.Version).VersionDat == null)
									{
										num = 7;
									}
									continue;
								case 73:
								case 87:
									((StringBuilder)(&stateMachine))._002Ector();
									num = 14;
									if (((MinecraftPath)(object)MinecraftPath.VersionJar).Natives == null)
									{
										num = 6;
									}
									continue;
								case 6:
									goto IL_0ac5;
								case 9:
									((RpcCallBack)/*Error near IL_0af3: Stack underflow*/).Send((object[])stateMachine);
									num = 23;
									continue;
								case 38:
									((EqualityComparer<Rpc>)/*Error near IL_0b04: Stack underflow*/).GetHashCode((Rpc)(&stateMachine));
									_ = 17;
									if (((MinecraftPath)(object)MinecraftPath.Libraries).Assets == null)
									{
										_ = 11;
									}
									continue;
								case 63:
									return;
								case 60:
									_ = ref stateMachine;
									if (EqualityComparer<ushort>.Default == null)
									{
										_ = 45;
										if (MinecraftPath.CheckFilteredListener != null)
										{
											_ = 37;
										}
										continue;
									}
									goto case 80;
								case 25:
									stateMachine = -1;
									((ServerModPath)Unsafe.AsPointer(ref this)).Resource = (string)(-1);
									num = 50;
									if (((ServerModPath)(object)Mass.Game.Launcher.Paths.ServerModPath.ResourceMd5).Mods == null)
									{
										num = 68;
									}
									continue;
								case 62:
									((RpcCallBack)/*Error near IL_0b8d: Stack underflow*/)._002Ector((RpcCallBack)stateMachine);
									num = 65;
									if (Mass.Game.Launcher.Paths.ServerModPath.DecorateExternalAggregator != null)
									{
										num = 72;
									}
									continue;
								case 86:
									((AsyncTaskMethodBuilder<string>*)/*Error near IL_0bb3: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)(&stateMachine));
									if ((int)/*Error near IL_0bb8: Stack underflow*/ == 0)
									{
										num = 2;
										if (((RpcCallBack)RpcCallBack.Writer__BackingField).Sid__BackingField == 0)
										{
											num = 66;
										}
										continue;
									}
									goto case 13;
								case 66:
									stateMachine = 0;
									((RpcCallBack)Unsafe.AsPointer(ref this)).Data__BackingField = 0;
									num = 67;
									continue;
								case 37:
									goto IL_0beb;
								case 50:
									((JavaAuthenticator._003CHandleAuthentication_003Ed__9*)/*Error near IL_0c17: Stack underflow*/)->MoveNext();
									((DesktopAuthentication)/*Error near IL_0c2f: Stack underflow*/)._002Ector((string)/*Error near IL_0c2f: Stack underflow*/, (string)stateMachine, ((NeteaseSession)((JavaAuthenticator)stateMachine)._003CgameVersion_003EP).UserId, (string)JavaAuthenticator._003CHandleAuthentication_003Ed__9.ReflectSimpleEvent());
									stateMachine = (object)/*Error near IL_0c31: Stack underflow*/;
									num = 56;
									if ((int)((JavaAuthenticator._003CHandleAuthentication_003Ed__9*)JavaAuthenticator._003CHandleAuthentication_003Ed__9._003C_003E1__state)->_003C_003Et__builder == 0)
									{
										num = 86;
									}
									continue;
								case 16:
									return;
								case 10:
								{
									EnumGameVersion version = ((JavaCommand)/*Error near IL_0c64: Stack underflow*/).Version;
									((AsyncTaskMethodBuilder<string>*)stateMachine)->SetException((Exception)(object)((JavaCommand)Enumerable.First<TSource>((IEnumerable<TSource>)(object)((JavaAuthenticator._003CHandleAuthentication_003Ed__9*)(nint)stateMachine)->message)).GameId);
									stateMachine = version;
									num = 60;
									continue;
								}
								case 39:
									((AsyncTaskMethodBuilder<string>*)/*Error near IL_0c8f: Stack underflow*/)->SetResult((string)(&stateMachine));
									num = 27;
									continue;
								case 85:
									((ILogger)/*Error near IL_0ca7: Stack underflow*/).Debug<nint, string>((string)Unsafe.AsPointer(ref JavaCommand.Logger__BackingField), (nint)(&stateMachine), (string)Unsafe.AsPointer(ref this));
									num = 79;
									continue;
								case 23:
									goto end_IL_005d;
								}
								break;
							}
							goto case 0;
							IL_0beb:
							stateMachine = RpcCallBack.ReflectIdentifiableTransmitter;
							num = 30;
							if (((JavaAuthenticator)JavaAuthenticator._003Csession_003EP)._003Ctype_003EP == 0)
							{
								num = 11;
							}
							goto IL_0088;
							IL_076f:
							stateMachine = ((JavaGameValue)Unsafe.AsPointer(ref this)).ReconnectDelay__BackingField;
							num = 15;
							goto IL_0088;
							IL_0ac5:
							stateMachine = ((MinecraftPath)Unsafe.AsPointer(ref this)).GameAuthenticationDll;
							num = 0;
							if (((MinecraftPath)(object)MinecraftPath.Runtime).Mods != null)
							{
								num = 0;
							}
							goto IL_0088;
							IL_0917:
							stateMachine = ((GamePath)Unsafe.AsPointer(ref this)).Resources;
							num = 44;
							if (((GamePath)(object)GamePath.Data).Files != null)
							{
								num = 59;
							}
							goto IL_0088;
							IL_0869:
							stateMachine = ((CppGamePath)Unsafe.AsPointer(ref this)).BedrockLauncherFile;
							num = 19;
							goto IL_0088;
							end_IL_005d:
							break;
						}
						break;
					}
					case 3:
						stateMachine = ((JavaCommand)Unsafe.AsPointer(ref this)).MaxMemory__BackingField;
						obj = 1;
						if (((JavaCommand)JavaCommand.Address__BackingField).Port__BackingField == 0)
						{
							obj = 0;
						}
						continue;
					case 2:
						break;
					case 5:
						return;
					default:
						goto end_IL_0026;
					}
					((JavaCommand)Unsafe.AsPointer(ref this)).Session__BackingField = -2;
					obj = 0;
					if (((JavaCommand)JavaCommand.SocketPort__BackingField).RpcPort__BackingField != 0)
					{
						obj = 0;
					}
					continue;
					end_IL_0026:
					break;
				}
				_ = Unsafe.As<nint, JsonElement>(ref ((JavaCommand)Unsafe.AsPointer(ref this)).IsFilter__BackingField).ValueKind;
				stateMachine = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 㰀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778732, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 㴀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 㸀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778731, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnDataReceivedAsync_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DataReceivedEventArgs e;

		public JavaGame _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object DecorateStatelessFinalizer;

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
		internal static bool CheckScheduledAggregator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JoinDecryptor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void Ⰰ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778730, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void ⴀ(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
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
		internal unsafe static object _2E00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778729, new IntPtr(2737337594924L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _2F00()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _3000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778728, new IntPtr(2737337584524L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _3200()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0496: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I4
			//IL_0078: Expected Obj, but got VT
			//IL_0117: Expected native int or pointer, but got Obj
			//IL_02db: Expected I4, but got Obj
			//IL_0164: Expected native int or pointer, but got Obj
			//IL_0282: Expected Obj, but got I4
			//IL_0287: Expected Obj, but got I4
			//IL_0287: Expected Obj, but got Ref
			//IL_02b8: Expected native int or pointer, but got Obj
			//IL_026d: Expected Obj, but got Ref
			//IL_026d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Expected Obj, but got Ref
			//IL_01da: Expected Obj, but got Ref
			//IL_01e4: Expected native int or pointer, but got Obj
			//IL_0234: Expected Obj, but got I4
			//IL_0239: Expected Obj, but got I4
			//IL_0239: Expected Obj, but got Ref
			//IL_04a0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0082->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0097->IL0026: Incompatible stack heights: 2 vs 1
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01ee->IL017d: Incompatible stack heights: 2 vs 1
			//IL_01f9->IL017d: Incompatible stack heights: 2 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object stateMachine = 3;
			object obj = stateMachine;
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				case 2:
					stateMachine = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
					obj = 0;
					if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj = 0;
					}
					continue;
				case 4:
					return;
				case 3:
					stateMachine = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1;
					obj = 2;
					continue;
				case 5:
					_ = Unsafe.As<object, AsyncTaskMethodBuilder>(ref Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton).Task;
					_ = 4;
					continue;
				default:
					if (stateMachine == null)
					{
						num = 2;
						if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener != null)
						{
							num = 2;
						}
						goto IL_00c2;
					}
					goto IL_03c6;
				case 1:
					break;
					IL_03c6:
					((AsyncTaskMethodBuilder<_0021_00210>*)/*Error near IL_03d1: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CheckScalableWorker);
					stateMachine = (object)/*Error near IL_03d3: Stack underflow*/;
					num = 3;
					goto IL_00c2;
					IL_00c2:
					while (true)
					{
						int num2;
						switch (num)
						{
						default:
							num = 4;
							if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state == 0)
							{
								num = 5;
							}
							continue;
						case 3:
							if (stateMachine == null)
							{
								num = 6;
								if (((Authenticator._003CReceiveAsync_003Ed__9)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9._003C_003Et__builder)._003C_003E4__this == null)
								{
									num = 6;
								}
								continue;
							}
							goto default;
						case 5:
							if (stateMachine == null)
							{
								num2 = 0;
								if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9.client)->_003C_003Eu__1 == 0)
								{
									num2 = 0;
								}
								goto IL_017d;
							}
							goto IL_02cd;
						case 4:
							break;
						case 1:
						case 6:
							goto end_IL_0026;
							IL_02cd:
							((RestClient)/*Error near IL_02db: Stack underflow*/)._002Ector((RestClientOptions)/*Error near IL_02db: Stack underflow*/, (ConfigureHeaders)/*Error near IL_02db: Stack underflow*/, (ConfigureSerialization)/*Error near IL_02db: Stack underflow*/, (byte)(int)((FeverInstaller)stateMachine).FeverRequest<T>((RestRequest)stateMachine) != 0);
							stateMachine = (object)/*Error near IL_02dd: Stack underflow*/;
							num2 = 2;
							goto IL_017d;
							IL_017d:
							while (true)
							{
								switch (num2)
								{
								case 11:
									return;
								case 1:
								case 7:
									((AsyncTaskMethodBuilder*)(&stateMachine))->SetResult();
									num2 = 3;
									continue;
								case 9:
									((RestResponse<EntityFeverManifest>)(object)Unsafe.AsPointer(ref ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003E1__state)).EnsureSuccessStatusCode<EntityFeverManifest>((string?)(&stateMachine), (byte)Unsafe.AsPointer(ref this) != 0);
									_ = 5;
									if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.client)->_003C_003E4__this == null)
									{
										_ = 11;
									}
									continue;
								case 8:
									((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003Cstream_003E5__2 = stateMachine;
									num2 = 3;
									if (Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway == null)
									{
										num2 = 9;
									}
									continue;
								case 10:
									stateMachine = 0;
									((FeverInstaller)Unsafe.AsPointer(ref this))._003CfeverVersion_003EP = 0;
									num2 = 8;
									continue;
								case 6:
									FeverInstaller.McBedrock__BackingField = (object)default(RestClientOptions);
									num2 = 4;
									continue;
								case 4:
									stateMachine = -1;
									FeverInstaller.ReflectVisualArgument = -1;
									num2 = 7;
									if ((int)((FeverInstaller._003CFeverRequest_003Ed__15<>*)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003E1__state)->_003C_003Et__builder == 0)
									{
										num2 = 4;
									}
									continue;
								default:
									stateMachine = ((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003E4__this;
									num2 = 0;
									if ((int)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller._003CFeverRequest_003Ed__15<>.request)->_003C_003Eu__1 != 0)
									{
										num2 = 6;
									}
									continue;
								case 12:
									break;
								case 2:
									((AsyncTaskMethodBuilder<EntityFeverManifest>*)/*Error near IL_0312: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)(&stateMachine));
									if ((int)/*Error near IL_0317: Stack underflow*/ != 0)
									{
										num2 = 1;
										if ((int)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E1__state)->_003C_003Et__builder == 0)
										{
											num2 = 0;
										}
										continue;
									}
									goto case 10;
								case 3:
									goto end_IL_0026;
								}
								break;
							}
							goto IL_02cd;
						}
						break;
					}
					goto IL_03c6;
					end_IL_0026:
					break;
				}
				((Rpc)Unsafe.AsPointer(ref this)).UseCha__BackingField = -2;
				obj = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _3300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778727, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 㐀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnDataReceivedAsync_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		public string line;

		private TaskAwaiter _003C_003Eu__1;

		private static object MoveError;

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
		internal static bool ChangeCache()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CustomizeUser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _2100(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778726, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _2200(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
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
		internal unsafe static object _2300()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _2400()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778725, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _2800()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_05af: Expected Obj, but got Ref
			//IL_05b9: Expected native int or pointer, but got Obj
			//IL_0610: Expected Obj, but got I4
			//IL_00e2: Expected Obj, but got VT
			//IL_00ec: Expected native int or pointer, but got Obj
			//IL_020f: Expected I4, but got Obj
			//IL_00a9: Expected Obj, but got I4
			//IL_00bb: Expected Obj, but got I4
			//IL_018b: Expected native int or pointer, but got Obj
			//IL_01f6: Expected Obj, but got I4
			//IL_01fb: Expected Obj, but got I4
			//IL_01fb: Expected Obj, but got Ref
			//IL_0109: Expected VT, but got Obj
			//IL_04fd: Expected Obj, but got I4
			//IL_012f: Expected native int or pointer, but got Obj
			//IL_0139: Expected Ref, but got VT
			//IL_01e0: Expected native int or pointer, but got Obj
			//IL_01b8: Expected native int or pointer, but got Obj
			//IL_03fb: Expected Obj, but got I4
			//IL_03f6: Expected native int or pointer, but got Obj
			//IL_0404: Expected Obj, but got I4
			//IL_02a9: Expected native int or pointer, but got Obj
			//IL_02b9: Expected Ref, but got VT
			//IL_02c3: Expected native int or pointer, but got Obj
			//IL_030e: Expected native int or pointer, but got Obj
			//IL_0323: Expected native int or pointer, but got Obj
			//IL_0348: Expected Ref, but got VT
			//IL_03b1: Expected native int or pointer, but got Obj
			//IL_009f: Expected I4, but got Obj
			//IL_041e: Expected Obj, but got I4
			//IL_026b: Expected I4, but got Obj
			//IL_0607->IL0026: Incompatible stack types: I4 vs Obj
			//IL_05ea->IL0026: Incompatible stack types: I4 vs Obj
			//IL_05c3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_061a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_05f5->IL0026: Incompatible stack types: I4 vs Obj
			//IL_05ce->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00f6->IL005e: Incompatible stack types: I4 vs Obj
			//IL_005a->IL005e: Incompatible stack types: I4 vs Obj
			//IL_0101->IL005e: Incompatible stack types: I4 vs Obj
			//IL_0223->IL0232: Incompatible stack types: I4 vs Obj
			//IL_00b8->IL005e: Incompatible stack types: I4 vs Obj
			//IL_00cf->IL005e: Incompatible stack types: I4 vs Obj
			//IL_0195->IL005e: Incompatible stack types: I4 vs Obj
			//IL_0205->IL005e: Incompatible stack types: I4 vs Obj
			//IL_0113->IL005e: Incompatible stack types: I4 vs Obj
			//IL_01de->IL005e: Incompatible stack heights: 2 vs 1
			//IL_01f1->IL005e: Incompatible stack types: I4 vs Obj
			//IL_01c2->IL005e: Incompatible stack types: I4 vs Obj
			//IL_0173->IL005e: Incompatible stack types: I4 vs Obj
			//IL_022e->IL0232: Incompatible stack types: I4 vs Obj
			//IL_00da->IL005e: Incompatible stack types: I4 vs Obj
			//IL_01a0->IL005e: Incompatible stack types: I4 vs Obj
			//IL_0152->IL005e: Incompatible stack types: I4 vs Obj
			//IL_01cd->IL005e: Incompatible stack types: I4 vs Obj
			//IL_02ed->IL03f3: Incompatible stack heights: 0 vs 1
			//IL_02cd->IL0232: Incompatible stack heights: 4 vs 2
			//IL_032d->IL0232: Incompatible stack heights: 3 vs 2
			//IL_034d->IL037b: Incompatible stack heights: 0 vs 1
			//IL_015d->IL005e: Incompatible stack types: I4 vs Obj
			//IL_0301->IL0232: Incompatible stack heights: 1 vs 2
			//IL_02d8->IL0232: Incompatible stack heights: 4 vs 2
			//IL_0338->IL0232: Incompatible stack heights: 3 vs 2
			//IL_0361->IL0232: Incompatible stack heights: 1 vs 2
			//IL_030c->IL0232: Incompatible stack heights: 1 vs 2
			//IL_036c->IL0232: Incompatible stack heights: 1 vs 2
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 2;
			object obj = awaiter;
			while (true)
			{
				object obj2;
				switch ((int)obj)
				{
				default:
					return;
				case 4:
					if (awaiter != null)
					{
						obj2 = 13;
						goto IL_005e;
					}
					goto IL_00da;
				case 3:
					((AsyncTaskMethodBuilder<EntityFeverManifest>*)/*Error near IL_05af: Stack underflow*/)->SetException((Exception)Unsafe.AsPointer(ref ((Rpc._003CReceiveAsync_003Ed__28)this)._003C_003E1__state));
					obj = 0;
					if (((Rpc._003CReceiveAsync_003Ed__28*)(nint)Mass.Game.Launcher.Rpc._003CReceiveAsync_003Ed__28.client)->_003C_003E4__this != null)
					{
						obj = 0;
					}
					continue;
				case 2:
					awaiter = Mass.Game.Launcher.Rpc._003CReceiveAsync_003Ed__28.CheckMonoProgram;
					obj = 1;
					if ((int)((Rpc._003CRemoteCallBackAsync_003Ed__21*)Mass.Game.Launcher.Rpc._003CRemoteCallBackAsync_003Ed__21._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj = 1;
					}
					continue;
				case 1:
					awaiter = ((Rpc._003CRemoteCallBackAsync_003Ed__21)this)._003C_003E4__this;
					obj = 4;
					continue;
				case 0:
					return;
				case 5:
					break;
					IL_005e:
					while (true)
					{
						switch ((int)obj2)
						{
						case 2:
							awaiter = -1;
							((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state = -1;
							obj2 = 9;
							continue;
						case 3:
							awaiter = 0;
							obj2 = 0;
							if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
							{
								obj2 = 1;
							}
							continue;
						case 12:
							break;
						case 6:
							((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)awaiter;
							obj2 = 14;
							continue;
						case 10:
							return;
						case 8:
							goto IL_0122;
						default:
							((TaskAwaiter*)(&awaiter))->GetResult();
							if ((int)/*Error near IL_0169: Stack underflow*/ == 0)
							{
								obj2 = 5;
								continue;
							}
							goto case 9;
						case 4:
							((AsyncTaskMethodBuilder*)awaiter)->SetException((Exception)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.ObserveTracker());
							awaiter = (object)/*Error near IL_0181: Stack underflow*/;
							obj2 = 0;
							if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain)->_003C_003E1__state == 0)
							{
								obj2 = 0;
							}
							continue;
						case 14:
							Unsafe.As<AsyncTaskMethodBuilder, AsyncTaskMethodBuilder<EntityFeverManifestInfo>>(ref ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003Et__builder).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverManifestInfo>*)(&awaiter), ref Unsafe.As<_003COnDataReceivedAsync_003Ed__13, FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13>(ref this));
							obj2 = 10;
							if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E4__this)->_003Cstream_003E5__2 == null)
							{
								obj2 = 10;
							}
							continue;
						case 9:
							((TaskAwaiter<TcpClient>*)(&awaiter))->GetResult();
							_ = 11;
							continue;
						case 13:
							awaiter = Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway;
							obj2 = 3;
							continue;
						case 5:
							awaiter = 0;
							((FeverInstaller)Unsafe.AsPointer(ref this))._003CfeverVersion_003EP = 0;
							obj2 = 6;
							continue;
						case 1:
							goto IL_0205;
						case 7:
							Unsafe.As<int, @null>(ref ((Rpc._003CListenAsync_003Ed__34)this)._003C_003E1__state) = null;
							awaiter = 2;
							obj2 = awaiter;
							continue;
						case 11:
							goto end_IL_0026;
						}
						break;
						IL_0205:
						string text = ((Encoding)/*Error near IL_020f: Stack underflow*/).GetString((byte[])/*Error near IL_020f: Stack underflow*/, (int)awaiter, (int)(&awaiter));
						object obj3 = 6;
						if (FeverInstaller.McBedrock__BackingField != null)
						{
							obj3 = 4;
						}
						while (true)
						{
							switch ((int)obj3)
							{
							case 4:
							case 8:
							case 9:
								break;
							case 6:
								_ = ((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)awaiter)->_003C_003E1__state;
								_ = ((TaskAwaiter<string>*)((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003Et__builder)->IsCompleted;
								_ = 1;
								if ((int)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller._003CFeverRequest_003Ed__15<>.request)->_003C_003Eu__1 != 0)
								{
									_ = 12;
								}
								continue;
							case 2:
							{
								int num = ((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003E1__state;
								FeverInstaller._002Ecctor();
								((RestClient)num).Dispose();
								if (text == null)
								{
									_ = 5;
									if (FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor != null)
									{
										_ = 11;
									}
									continue;
								}
								goto case 5;
							}
							case 10:
								_ = ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)awaiter)->_003C_003E1__state;
								AsyncTaskMethodBuilder<EntityFeverManifestInfo>.Create();
								_ = 3;
								if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E4__this)->info == null)
								{
									_ = 3;
								}
								continue;
							case 11:
								((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003Eu__1)->Start<TStateMachine>(ref *(FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.AnalyzeHandler() ? ((TStateMachine*)1) : ((TStateMachine*)null)));
								if (text != null)
								{
									_ = 7;
									if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13._003C_003Et__builder)._003C_003E4__this == null)
									{
										_ = 1;
									}
									continue;
								}
								goto default;
							default:
								_ = ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this).version;
								FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReceiveEnumerator();
								/*Error near IL_0386: Member reference must be method, but was: Field*/;
							case 12:
								_ = ((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)awaiter)->_003C_003E4__this;
								/*Error near IL_03b6: Member reference must be method, but was: Field*/;
							case 5:
							case 7:
								Unsafe.Write(&FeverInstaller._003CInstallAsync_003Ed__11.ReflectAccessibleWatcher, (object)1);
								awaiter = 8;
								goto IL_022e;
							case 1:
							case 3:
								{
									if (((Rpc)awaiter).ProcessId__BackingField != 0)
									{
										awaiter = 4;
										goto IL_022e;
									}
									goto case 2;
								}
								IL_022e:
								obj3 = awaiter;
								continue;
							}
							break;
						}
						goto IL_0122;
						IL_0122:
						if (!((TaskAwaiter*)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)((Authenticator)(object)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this).listener).HandleAuthentication((string)awaiter))->_003C_003Eu__1)->IsCompleted)
						{
							goto end_IL_0026;
						}
						obj2 = 2;
						if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder == 0)
						{
							obj2 = 4;
						}
					}
					goto IL_00da;
					IL_00da:
					awaiter = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1;
					obj2 = 7;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
					{
						obj2 = 7;
					}
					goto IL_005e;
					end_IL_0026:
					break;
				}
				((Rpc._003CRemoteCallBackAsync_003Ed__21)this).callBack = (RpcCallBack)(-2);
				obj = 3;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _2900()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778724, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _2A00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778723, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _2B00()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnDisconnectedAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		private CancellationToken _003Ctoken_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		internal static object CheckOperationalAnalyzer;

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
		internal static bool InstantiatePublisher()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateIdentifiableNotifier()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _1400(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778722, new IntPtr(2737337578284L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void ᔀ(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
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
		private unsafe sealed void ᘀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778721, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object ᜀ()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _1800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778720, new IntPtr(2737337594924L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void Ḁ()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_08bc: Expected Obj, but got I4
			//IL_08bc: Expected Obj, but got Ref
			//IL_0868: Expected Obj, but got Ref
			//IL_086d: Expected Obj, but got Ref
			//IL_0054: Expected Obj, but got I4
			//IL_0892: Expected Obj, but got Ref
			//IL_083d: Expected Obj, but got Ref
			//IL_0852: Expected Obj, but got I4
			//IL_0184: Expected native int or pointer, but got Obj
			//IL_071c: Expected Obj, but got I
			//IL_0136: Expected Obj, but got Ref
			//IL_0747: Expected Obj, but got I
			//IL_02cd: Expected Obj, but got Ref
			//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_036b: Expected Ref, but got F8
			//IL_0376: Expected Ref, but got VT
			//IL_02ec: Expected I4, but got Obj
			//IL_021c: Expected Obj, but got I4
			//IL_0335: Expected Obj, but got I4
			//IL_033a: Expected VT, but got I4
			//IL_0344: Expected native int or pointer, but got Obj
			//IL_0271: Expected Obj, but got Ref
			//IL_0271: Expected Obj, but got Ref
			//IL_03bc: Expected Obj, but got I4
			//IL_064d: Expected Obj, but got Ref
			//IL_056c: Expected I4, but got Obj
			//IL_0673: Expected Obj, but got I4
			//IL_058f: Expected Obj, but got I4
			//IL_0594: Expected Obj, but got I4
			//IL_059e: Expected native int or pointer, but got Obj
			//IL_057b: Expected Obj, but got I4
			//IL_0580: Expected VT, but got I4
			//IL_05e6: Expected Obj, but got I4
			//IL_0212: Expected I4, but got Obj
			//IL_0514: Expected I4, but got Obj
			//IL_08c6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0881->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_08a8->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0857->IL0026: Incompatible stack types: I4 vs Obj
			//IL_088c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_08b3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0862->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0721->IL0089: Incompatible stack heights: 4 vs 1
			//IL_02bc->IL01c5: Incompatible stack types: I4 vs Obj
			//IL_01b6->IL01c5: Incompatible stack types: I4 vs Obj
			//IL_072c->IL0089: Incompatible stack heights: 4 vs 1
			//IL_05cf->IL04db: Incompatible stack types: I4 vs Obj
			//IL_04d7->IL04db: Incompatible stack types: I4 vs Obj
			//IL_02c7->IL01c5: Incompatible stack types: I4 vs Obj
			//IL_01c1->IL01c5: Incompatible stack types: I4 vs Obj
			//IL_05da->IL04db: Incompatible stack types: I4 vs Obj
			//IL_02dd->IL01c5: Incompatible stack types: I4 vs Obj
			//IL_0387->IL01c5: Incompatible stack types: I4 vs Obj
			//IL_02f6->IL01c5: Incompatible stack heights: 2 vs 1
			//IL_022b->IL01c5: Incompatible stack types: I4 vs Obj
			//IL_0325->IL01c5: Incompatible stack types: I4 vs Obj
			//IL_034e->IL01c5: Incompatible stack types: I4 vs Obj
			//IL_027b->IL01c5: Incompatible stack heights: 3 vs 1
			//IL_0254->IL01c5: Incompatible stack heights: 2 vs 1
			//IL_0540->IL04db: Incompatible stack heights: 2 vs 1
			//IL_0576->IL04db: Incompatible stack types: I4 vs Obj
			//IL_062c->IL04db: Incompatible stack heights: 2 vs 1
			//IL_05a8->IL04db: Incompatible stack types: I4 vs Obj
			//IL_052f->IL04db: Incompatible stack types: I4 vs Obj
			//IL_058a->IL04db: Incompatible stack types: I4 vs Obj
			//IL_0601->IL04db: Incompatible stack types: I4 vs Obj
			//IL_0330->IL01c5: Incompatible stack types: I4 vs Obj
			//IL_0359->IL01c5: Incompatible stack types: I4 vs Obj
			//IL_0291->IL01c5: Incompatible stack types: I4 vs Obj
			//IL_03f9->IL01c5: Incompatible stack types: I4 vs Obj
			//IL_0243->IL01c5: Incompatible stack heights: 2 vs 1
			//IL_065c->IL04db: Incompatible stack types: I4 vs Obj
			//IL_0637->IL04db: Incompatible stack heights: 2 vs 1
			//IL_05b3->IL04db: Incompatible stack types: I4 vs Obj
			//IL_060c->IL04db: Incompatible stack types: I4 vs Obj
			//IL_0404->IL01c5: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 4;
			object obj = awaiter;
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				case 3:
					awaiter = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
					obj = 2;
					continue;
				case 2:
					if (awaiter != null)
					{
						num = 9;
						if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
						{
							num = 8;
						}
						goto IL_0089;
					}
					goto IL_00cf;
				case 5:
					((ComponentPath)Unsafe.AsPointer(ref this)).ComponentExtension = null;
					obj = 1;
					if (((ComponentPath)ComponentPath.IsShaderPack).IsResourcePack)
					{
						obj = 1;
					}
					continue;
				case 1:
					((BinaryWriter)/*Error near IL_086d: Stack underflow*/)._002Ector((Stream)Unsafe.AsPointer(ref ComponentPath.ReflectEfficientVerifier));
					obj = 6;
					if (((CppGamePath)(object)CppGamePath.BedrockLauncher).BedrockHash != null)
					{
						obj = 1;
					}
					continue;
				case 4:
					awaiter = ((CppGamePath)Unsafe.AsPointer(ref this)).Bedrock;
					obj = 3;
					if (((CppGamePath)(object)CppGamePath.GameZip).BePackCache == null)
					{
						obj = 3;
					}
					continue;
				case 6:
					return;
					IL_0089:
					while (true)
					{
						object obj2;
						object obj3;
						switch (num)
						{
						case 12:
							break;
						case 9:
							if ((nint)awaiter != 1)
							{
								num = 1;
								if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
								{
									num = 0;
								}
								continue;
							}
							goto case 6;
						case 13:
							GC.SuppressFinalize(awaiter);
							Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)/*Error near IL_0136: Stack underflow*/)->_003C_003E4__this, (Authenticator)Unsafe.AsPointer(ref this));
							num = 6;
							if (Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
							{
								num = 8;
							}
							continue;
						case 6:
						case 10:
							num = 7;
							if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9._003C_003E4__this)->client == null)
							{
								num = 0;
							}
							continue;
						case 7:
							if ((nint)awaiter != 1)
							{
								obj2 = 0;
								if (Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain == null)
								{
									obj2 = 4;
								}
								goto IL_01c5;
							}
							goto IL_02a0;
						case 4:
							((Rpc)/*Error near IL_049d: Stack underflow*/).UseCha = ((Rpc)awaiter).UseCha;
							if ((int)/*Error near IL_04a2: Stack underflow*/ == 0)
							{
								goto end_IL_0026;
							}
							num = 10;
							continue;
						case 8:
							((Rpc)/*Error near IL_04b1: Stack underflow*/)._002Ector((ILogger)/*Error near IL_04b1: Stack underflow*/, (byte)/*Error near IL_04b1: Stack underflow*/ != 0);
							((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)/*Error near IL_04bb: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_04bb: Stack underflow*/, ref *(TStateMachine*)((Rpc)/*Error near IL_04b6: Stack underflow*/).Callbacks);
							num = 4;
							continue;
						case 14:
							if (awaiter != null)
							{
								obj3 = 12;
								goto IL_04db;
							}
							goto IL_05b3;
						case 2:
						case 5:
							goto IL_06f3;
						case 11:
							Mass.Game.Launcher.Rpc._003CSyncChaChaAsync_003Ed__38.DecorateConnectedMapper();
							_ = 13;
							if (((JavaGameValue)JavaGameValue.SaveOptions__BackingField).SetChinese__BackingField == 0)
							{
								_ = 13;
							}
							continue;
						case 1:
							((CppGameValue)/*Error near IL_0733: Stack underflow*/).SkinPath = (string)awaiter;
							if ((int)/*Error near IL_0738: Stack underflow*/ == 0)
							{
								num = 5;
								if (((JavaGameValue)JavaGameValue.GuiScale__BackingField).SetSize__BackingField == 0)
								{
									num = 5;
								}
								continue;
							}
							break;
						default:
							goto end_IL_0026;
							IL_02a0:
							awaiter = Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway;
							obj2 = 0;
							if (((FeverInstaller)FeverInstaller._003CfeverVersion_003EP)._003CappId_003EP != null)
							{
								obj2 = 0;
							}
							goto IL_01c5;
							IL_05b3:
							awaiter = Mass.Game.Launcher.Rpc._003CListenControlConnectAsync_003Ed__35.ReflectSymbolicDecorator;
							obj3 = 8;
							if ((int)((Rpc._003CReceiveAsync_003Ed__28*)Mass.Game.Launcher.Rpc._003CReceiveAsync_003Ed__28._003C_003E1__state)->_003C_003Et__builder != 0)
							{
								obj3 = 9;
							}
							goto IL_04db;
							IL_04db:
							while (true)
							{
								switch ((int)obj3)
								{
								case 9:
									Unsafe.As<int, @null>(ref ((Rpc._003CListenAsync_003Ed__34)this)._003C_003E1__state) = null;
									obj3 = 7;
									continue;
								case 1:
								case 2:
									RestRequestExtensions.AddQueryParameter((RestRequest)/*Error near IL_0536: Stack underflow*/, (string)/*Error near IL_0536: Stack underflow*/, (string)/*Error near IL_0536: Stack underflow*/, (byte)(&awaiter) != 0);
									_ = 6;
									continue;
								case 3:
									((Rpc._003CListenControlConnectAsync_003Ed__35)this)._003C_003E1__state = (int)awaiter;
									obj3 = 5;
									continue;
								case 10:
									awaiter = 0;
									((Rpc._003CListenControlConnectAsync_003Ed__35)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)0;
									obj3 = 3;
									continue;
								case 7:
									awaiter = -1;
									((Rpc._003CListenControlConnectAsync_003Ed__35)this).listener = (TcpListener)(-1);
									obj3 = 1;
									if ((int)((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)Mass.Game.Launcher.Rpc._003CListenControlConnectAsync_003Ed__35._003C_003E4__this)->_003C_003Eu__1 == 0)
									{
										obj3 = 0;
									}
									continue;
								case 8:
									break;
								case 12:
									((AsyncTaskMethodBuilder<EntityFeverManifest>*)awaiter)->SetStateMachine((IAsyncStateMachine)Mass.Game.Launcher.Rpc.PopVisitor());
									((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)/*Error near IL_05eb: Stack underflow*/)->SetResult((EntityFeverManifestInfo)/*Error near IL_05eb: Stack underflow*/);
									awaiter = (object)/*Error near IL_05ed: Stack underflow*/;
									obj3 = 0;
									if ((int)((Rpc._003CRemoteCallBackAsync_003Ed__21*)Mass.Game.Launcher.Rpc._003CRemoteCallBackAsync_003Ed__21._003C_003E1__state)->_003C_003Et__builder == 0)
									{
										obj3 = 0;
									}
									continue;
								case 6:
									_ = (string?)awaiter + (string?)Mass.Game.Launcher.Rpc._003CListenAsync_003Ed__34.CheckLocalObject();
									_ = 4;
									if (Mass.Game.Launcher.Rpc._003CRemoteCallBackAsync_003Ed__21.MeasureCalc == null)
									{
										_ = 1;
									}
									continue;
								case 11:
									return;
								default:
									if ((int)((Task<EntityFeverManifestInfo>)(&awaiter)).GetAwaiter() != 0)
									{
										obj3 = 2;
										continue;
									}
									goto case 10;
								case 5:
									((Rpc._003CSyncChaChaAsync_003Ed__38)this)._003C_003Et__builder.AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003COnDisconnectedAsync_003Ed__14, _003CLaunchAsync_003Ed__106>(ref this));
									awaiter = 11;
									obj3 = awaiter;
									continue;
								case 4:
									goto IL_06f3;
								}
								break;
							}
							goto IL_05b3;
							IL_06f3:
							awaiter = new Dictionary<ushort, Func<RpcCallBack, Task>>();
							num = 11;
							continue;
							IL_01c5:
							while (true)
							{
								switch ((int)obj2)
								{
								case 3:
									awaiter = 1;
									((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003E1__state = 1;
									obj2 = 15;
									continue;
								case 16:
									break;
								case 13:
								case 14:
									_ = ((TaskAwaiter<TcpClient>*)(&awaiter))->IsCompleted;
									_ = 17;
									continue;
								case 11:
									_ = ref ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003E4__this;
									((FeverInstaller)(&awaiter)).FeverRequest<EntityFeverManifestInfo>((RestRequest)(object)Unsafe.AsPointer(ref this));
									_ = 12;
									continue;
								case 10:
									if (((TaskAwaiter<TcpClient>*)(&awaiter))->GetResult() != null)
									{
										obj2 = 14;
										continue;
									}
									goto case 3;
								case 12:
									return;
								case 9:
									goto end_IL_01c5;
								default:
									((FeverInstaller)Unsafe.AsPointer(ref this))._003CappVersion_003EP = (object)default(RestClient);
									obj2 = 5;
									continue;
								case 2:
									((Stream)/*Error near IL_02ec: Stack underflow*/).Read((byte[])/*Error near IL_02ec: Stack underflow*/, (int)/*Error near IL_02ec: Stack underflow*/, (int)FeverInstaller.McBedrock.Client);
									_ = 16;
									continue;
								case 4:
									((AsyncTaskMethodBuilder*)/*Error near IL_0311: Stack underflow*/)->Start(ref *(Rpc._003CSyncChaChaAsync_003Ed__38*)((FeverInstaller)(object)((FeverInstaller)(object)((FeverInstaller)/*Error near IL_0300: Stack underflow*/).GetFeverManifestAsync((object)((FeverInstaller)/*Error near IL_02fb: Stack underflow*/).InstallAsync())).GetFeverManifestInfoAsync(awaiter)).GetFeverAppVersionAsync());
									obj2 = 1;
									if (((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003Et__builder)._003C_003E4__this == null)
									{
										obj2 = 1;
									}
									continue;
								case 5:
									awaiter = -1;
									((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003Eu__1 = (TaskAwaiter<EntityFeverApp>)(-1);
									obj2 = 10;
									if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor)->_003C_003E1__state == 0)
									{
										obj2 = 13;
									}
									continue;
								case 1:
								{
									object obj4 = awaiter;
									(FeverInstaller._003CFeverRequest_003Ed__15<>.CheckAdaptableResponder() ? ((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)1) : ((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)null))->Start<TStateMachine>(ref *(TStateMachine*)(double)FeverInstaller._003CFeverRequest_003Ed__15<>.VisitParser());
									((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)obj4)->Start<TStateMachine>(ref *(TStateMachine*)((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003Eu__1)->Task);
									awaiter = (object)/*Error near IL_037d: Stack underflow*/;
									obj2 = 10;
									continue;
								}
								case 15:
									((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this).version = (EntityFeverAppVersion)awaiter;
									awaiter = 11;
									obj2 = awaiter;
									continue;
								case 17:
									_ = ref ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003Eu__1;
									/*Error near IL_03c7: Member reference must be method, but was: Field*/;
								case 6:
								case 7:
								case 8:
									goto end_IL_0026;
								}
								object obj5 = awaiter;
								object obj6 = Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.ReflectRandomReporter();
								if (obj6 == null)
								{
									_ = 8;
									continue;
								}
								((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)obj5)->SetStateMachine((IAsyncStateMachine)obj6);
								obj2 = 0;
								if (((FeverInstaller._003CInstallAsync_003Ed__11)FeverInstaller._003CInstallAsync_003Ed__11._003C_003Et__builder)._003C_003E4__this != null)
								{
									obj2 = 6;
								}
								continue;
								end_IL_01c5:
								break;
							}
							goto IL_02a0;
						}
						break;
					}
					goto IL_00cf;
					IL_00cf:
					num = 14;
					if (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
					{
						num = 3;
					}
					goto IL_0089;
					end_IL_0026:
					break;
				}
				((CppGamePath)Unsafe.AsPointer(ref this)).BeMain = (string)(-2);
				obj = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte ἀ()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _2000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778655, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPrepareBaseVersionAsync_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		public CancellationToken cancellationToken;

		private TaskAwaiter<EntityGameClientPatch> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		internal static object AttachMap;

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
		internal static bool AddVisitor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectInternalParser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _0B00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778654, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _0C00(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
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
		private unsafe sealed void _0D00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778653, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _0E00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778652, new IntPtr(2737337583484L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object ༀ()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void က()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0464: Expected Obj, but got Ref
			//IL_0469: Expected Obj, but got Ref
			//IL_0473: Expected native int or pointer, but got Obj
			//IL_04b7: Expected Obj, but got I4
			//IL_0490: Expected Obj, but got VT
			//IL_049a: Expected native int or pointer, but got Obj
			//IL_01ed: Expected Obj, but got Ref
			//IL_01f8: Expected Obj, but got I4
			//IL_00d4: Expected I4, but got Obj
			//IL_0204: Expected Obj, but got Ref
			//IL_034a: Expected Obj, but got Ref
			//IL_0353: Expected Obj, but got I4
			//IL_0172: Expected Ref, but got VT
			//IL_017e: Expected native int or pointer, but got Obj
			//IL_0195: Expected Obj, but got I4
			//IL_01a1: Expected native int or pointer, but got Obj
			//IL_01bd: Expected Obj, but got Ref
			//IL_01bf: Expected Obj, but got VT
			//IL_0135: Expected Obj, but got I4
			//IL_013a: Expected Obj, but got I4
			//IL_00f9: Expected VT, but got Obj
			//IL_0103: Expected native int or pointer, but got Obj
			//IL_0387: Expected I4, but got Obj
			//IL_00de: Expected Obj, but got I4
			//IL_00e3: Expected Obj, but got I4
			//IL_00ec: Expected Obj, but got I4
			//IL_022d: Expected Obj, but got I4
			//IL_0232: Expected Obj, but got I4
			//IL_0232: Expected Obj, but got Ref
			//IL_02ed: Expected native int or pointer, but got Obj
			//IL_02b8: Expected Obj, but got I4
			//IL_02bd: Expected VT, but got I4
			//IL_02c7: Expected native int or pointer, but got Obj
			//IL_01cb: Expected native int or pointer, but got Obj
			//IL_01db: Expected Obj, but got I4
			//IL_047d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04cb->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04a4->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04e8->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0488->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04d6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04af->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0358->IL006f: Incompatible stack heights: 3 vs 0
			//IL_01ab->IL0073: Incompatible stack heights: 7 vs 1
			//IL_01c9->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0144->IL0073: Incompatible stack types: I4 vs Obj
			//IL_010d->IL0073: Incompatible stack types: I4 vs Obj
			//IL_039b->IL0073: Incompatible stack types: I4 vs Obj
			//IL_023c->IL0073: Incompatible stack types: I4 vs Obj
			//IL_02f7->IL0073: Incompatible stack heights: 3 vs 1
			//IL_0322->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0130->IL0073: Incompatible stack heights: 2 vs 1
			//IL_02d1->IL0073: Incompatible stack types: I4 vs Obj
			//IL_01e7->IL0073: Incompatible stack heights: 2 vs 1
			//IL_02a8->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0288->IL0073: Incompatible stack types: I4 vs Obj
			//IL_021d->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0374->IL0073: Incompatible stack types: I4 vs Obj
			//IL_01b6->IL0073: Incompatible stack heights: 7 vs 1
			//IL_025c->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0118->IL0073: Incompatible stack types: I4 vs Obj
			//IL_03a6->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0302->IL0073: Incompatible stack heights: 3 vs 1
			//IL_032d->IL0073: Incompatible stack types: I4 vs Obj
			//IL_02dc->IL0073: Incompatible stack types: I4 vs Obj
			//IL_02b3->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0228->IL0073: Incompatible stack types: I4 vs Obj
			//IL_037f->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0267->IL0073: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				default:
					return;
				case 1:
					if (obj != null)
					{
						obj3 = 0;
						if ((int)((Authenticator._003CListenAsync_003Ed__7*)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder != 0)
						{
							obj3 = 2;
						}
						goto IL_0073;
					}
					goto IL_01e7;
				case 0:
					return;
				case 2:
					((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)/*Error near IL_0469: Stack underflow*/)->SetResult((EntityFeverAppVersion)Unsafe.AsPointer(ref ((Rpc)Unsafe.AsPointer(ref this))._chaChaEn));
					obj2 = 0;
					if (((Rpc._003CListenAsync_003Ed__34*)(nint)Mass.Game.Launcher.Rpc.ParseMap)->_003C_003E1__state != 0)
					{
						obj2 = 0;
					}
					break;
				case 4:
					obj = ((Rpc._003CListenAsync_003Ed__34)this)._003C_003Et__builder;
					obj2 = 1;
					if ((int)((Rpc._003CListenAsync_003Ed__34*)(nint)Mass.Game.Launcher.Rpc._003CListenAsync_003Ed__34._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj2 = 1;
					}
					break;
				case 3:
					goto IL_04af;
				case 5:
					{
						obj = ((Rpc._003CListenControlConnectAsync_003Ed__35)this).listener;
						obj2 = 4;
						break;
					}
					IL_006f:
					obj3 = obj;
					goto IL_0073;
					IL_0073:
					while (true)
					{
						switch ((int)obj3)
						{
						case 12:
							break;
						case 9:
							((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1 = (TaskAwaiter)obj;
							obj3 = 1;
							if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
							{
								obj3 = 1;
							}
							continue;
						case 16:
							_ = ref ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Et__builder;
							((AsyncTaskMethodBuilder<EntityFeverManifest>*)(&obj))->Start(ref Unsafe.As<_003CPrepareBaseVersionAsync_003Ed__43, FeverInstaller._003CGetFeverManifestAsync_003Ed__12>(ref this));
							_ = 22;
							continue;
						case 7:
							obj = 0;
							((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003E4__this = (Authenticator)0;
							obj3 = 9;
							continue;
						case 22:
							return;
						case 4:
						{
							_ = 2;
							((IAsyncStateMachine)obj).MoveNext();
							bool isCompleted = ((TaskAwaiter*)obj)->IsCompleted;
							((Authenticator._003CListenAsync_003Ed__7*)((Task)obj).GetAwaiter())->SetStateMachine((IAsyncStateMachine)obj);
							_ = ((Authenticator._003CReceiveAsync_003Ed__9*)(isCompleted ? 1 : 0))->_003C_003E4__this;
							_ = ((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.ObserveTracker())->_003C_003Eu__1;
							_ = Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain;
							((AsyncTaskMethodBuilder*)null)->SetStateMachine((IAsyncStateMachine)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateGenericStruct());
							obj = null;
							_ = 0;
							if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.client)->_003C_003E4__this != null)
							{
								_ = 0;
							}
							continue;
						}
						case 6:
						case 17:
							obj = ((Task<TcpClient>)(&obj)).GetAwaiter();
							obj3 = 4;
							continue;
						case 19:
							_ = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)obj)->_003C_003Eu__1;
							obj = ((Encoding)0).GetBytes((string)(object)Encoding.UTF8);
							_ = 8;
							continue;
						case 5:
							goto IL_01e7;
						default:
							if (((TcpClient)(&obj)).GetStream() == null)
							{
								obj3 = 3;
								if (((FeverInstaller)FeverInstaller.McBedrock__BackingField).Client__BackingField == null)
								{
									obj3 = 12;
								}
								continue;
							}
							goto case 14;
						case 13:
							obj = -1;
							FeverInstaller.ReflectVisualArgument = -1;
							obj3 = 14;
							continue;
						case 8:
							if (((Stream)/*Error near IL_0243: Stack underflow*/).Read((byte[])/*Error near IL_0243: Stack underflow*/, (int)/*Error near IL_0243: Stack underflow*/, (int)(&obj)) != 0)
							{
								obj3 = 15;
								if (((FeverInstaller._003CFeverRequest_003Ed__15<>)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Et__builder)._003C_003E4__this == null)
								{
									obj3 = 17;
								}
								continue;
							}
							goto case 7;
						case 3:
							return;
						case 21:
							obj = ((FeverInstaller._003CFeverRequest_003Ed__15<>)this).request;
							obj3 = 20;
							continue;
						case 20:
							Unsafe.As<TaskAwaiter<RestResponse<EntityFeverResponse<T>>>, CancellationToken>(ref ((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003Eu__1) = default;
							obj3 = 1;
							if (((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003Et__builder)._003C_003E4__this == null)
							{
								obj3 = 13;
							}
							continue;
						case 18:
							obj = -1;
							((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003Eu__1 = (TaskAwaiter<EntityFeverApp>)(-1);
							obj3 = 6;
							if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor)->_003C_003E1__state != 0)
							{
								obj3 = 3;
							}
							continue;
						case 14:
							_ = ref obj;
							AsyncTaskMethodBuilder<EntityFeverManifestInfo>.Create();
							_ = 10;
							if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E4__this)->info == null)
							{
								_ = 3;
							}
							continue;
						case 15:
							Unsafe.As<TaskAwaiter<RestResponse<EntityFeverManifest>>, @null>(ref ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003Eu__1) = null;
							obj3 = 18;
							if ((int)((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								obj3 = 16;
							}
							continue;
						case 1:
							goto IL_033c;
						case 2:
							if ((nint)obj != 1)
							{
								obj3 = 15;
								if (FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CheckScalableWorker != null)
								{
									obj3 = 19;
								}
								continue;
							}
							goto case 21;
						case 11:
							((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003E1__state = (int)obj;
							obj3 = 7;
							if (((FeverInstaller._003CInstallAsync_003Ed__11)FeverInstaller._003CInstallAsync_003Ed__11._003C_003Et__builder)._003C_003E4__this != null)
							{
								obj3 = 16;
							}
							continue;
						case 10:
							goto IL_04af;
						}
						break;
					}
					obj = 1;
					((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E4__this = (Authenticator)1;
					obj = 11;
					goto IL_006f;
					IL_04af:
					Mass.Game.Launcher.Rpc._003CListenAsync_003Ed__34.DecorateIterableWriter = -2;
					obj2 = 2;
					if ((int)((Rpc._003CListenControlConnectAsync_003Ed__35*)Mass.Game.Launcher.Rpc._003CListenControlConnectAsync_003Ed__35._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj2 = 2;
					}
					break;
					IL_033c:
					_ = ref ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003E4__this;
					_ = ref obj;
					JavaRpcUnpacker.Unpack<_0021_00210>((byte[])Unsafe.AsPointer(ref this));
					obj = 3;
					goto IL_006f;
					IL_01e7:
					obj = ((FeverInstaller)Unsafe.AsPointer(ref this))._003CappId_003EP;
					obj = 15;
					goto IL_006f;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void ᄀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778651, new IntPtr(2737337584524L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte ሀ()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte ጀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778650, new IntPtr(2737337584524L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPrepareComponentsAsync_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		public CancellationToken cancellationToken;

		private List<ComponentPath> _003Cdownloads_003E5__2;

		private List<ulong> _003C_003E7__wrap2;

		private TaskAwaiter<EntityAuthItem> _003C_003Eu__1;

		private TaskAwaiter<EntityItemDownload[]> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private List<ComponentPath>.Enumerator _003C_003E7__wrap3;

		private object _003Cpath_003E5__5;

		private static object CheckExpandableState;

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
		internal static bool CheckHiddenHandler()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckAdjustableStruct()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ﴀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778649, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FE00(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0045: Expected I, but got Obj
			//IL_0045: Expected Obj, but got Ref
			//IL_004f: Expected native int or pointer, but got Obj
			//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FF00()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object Ā()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778648, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void ࠀ()
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
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitStObj(StObj inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 3219
			//    at ICSharpCode.Decompiler.IL.StObj.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4386
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitNullCoalescingInstruction(NullCoalescingInstruction inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 4130
			//    at ICSharpCode.Decompiler.IL.NullCoalescingInstruction.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 1535
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitStLoc(StLoc inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 855
			//    at ICSharpCode.Decompiler.IL.StLoc.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2590
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitStLoc(StLoc inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 129
			//    at ICSharpCode.Decompiler.IL.StLoc.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2586
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
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 307
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
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
		internal unsafe static byte _0900()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778647, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _0A00()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPrepareJreAsync_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		public CancellationToken cancellationToken;

		private TaskAwaiter _003C_003Eu__1;

		internal static object StoreDic;

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
		internal static bool ReflectRandomChain()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckCustomEnumerator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F500(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778646, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F600(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F700()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778645, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00豈()
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
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.TranslateTarget(ILInstruction target, Boolean nonVirtualInvocation, Boolean memberStatic, IType memberDeclaringType, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2936
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 437
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitCallVirt(CallVirt inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2535
			//    at ICSharpCode.Decompiler.IL.CallVirt.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2215
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
			//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00切()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778644, new IntPtr(2737337594924L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00ﬀ()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00ﰀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778643, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPreparePackageAsync_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		public JavaStep step;

		public string md5Path;

		public string md5;

		public Action before;

		public string name;

		public string url;

		public CancellationToken cancellationToken;

		public string outputPath;

		private object _003C_003E8__1;

		public Action after;

		private object _003CzipPath_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		internal static object EncodeArgument;

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
		internal static bool ExcludeSummarizer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckMixedProfiler()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_EB00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778642, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_EC00(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_ED00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778641, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_EE00()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_EF00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778640, new IntPtr(2737337577244L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F200()
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
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 307
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F300()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F400()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778639, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPrepareServerResourceAsync_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		public CancellationToken cancellationToken;

		private TaskAwaiter<EntityItemDownload> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		internal static object DecorateFlexibleFactory;

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
		internal static bool PresentAuditor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectCommonResponder()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E300(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778638, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E400(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E500()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E600()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778637, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778636, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E800()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_04ac: Expected Obj, but got VT
			//IL_04b6: Expected native int or pointer, but got Obj
			//IL_0050: Expected Obj, but got I4
			//IL_02dc: Expected Obj, but got VT
			//IL_02e6: Expected native int or pointer, but got Obj
			//IL_017a: Expected Obj, but got Ref
			//IL_0264: Expected native int or pointer, but got Obj
			//IL_0270: Expected Obj, but got VT
			//IL_0270: Expected native int or pointer, but got Obj
			//IL_0288: Expected Obj, but got VT
			//IL_0283: Unknown result type (might be due to invalid IL or missing references)
			//IL_029a: Expected Ref, but got VT
			//IL_02a1: Expected Obj, but got VT
			//IL_01f5: Expected native int or pointer, but got Obj
			//IL_01fc: Expected native int or pointer, but got Obj
			//IL_020b: Expected Ref, but got VT
			//IL_0236: Expected Obj, but got I4
			//IL_023b: Expected Obj, but got I4
			//IL_023b: Expected Obj, but got Ref
			//IL_014f: Expected Obj, but got Ref
			//IL_034f: Expected Obj, but got I4
			//IL_0340: Expected Obj, but got Ref
			//IL_0340: Expected Obj, but got Ref
			//IL_011d: Expected native int or pointer, but got Obj
			//IL_01da: Expected Obj, but got Ref
			//IL_01da: Expected Obj, but got Ref
			//IL_018d: Expected native int or pointer, but got Obj
			//IL_01ac: Expected Obj, but got VT
			//IL_02c5: Expected Obj, but got I4
			//IL_02ca: Expected Obj, but got I4
			//IL_0303: Expected Obj, but got VT
			//IL_0363: Expected Obj, but got I4
			//IL_0368: Expected VT, but got I4
			//IL_0371: Expected Obj, but got I4
			//IL_03d0: Expected I, but got Obj
			//IL_03d0: Expected Obj, but got Ref
			//IL_01c7: Expected Obj, but got I4
			//IL_00f2: Expected I4, but got Obj
			//IL_04c0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04e0->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0498->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04cb->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02f0->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0081->IL0085: Incompatible stack types: I4 vs Obj
			//IL_04a3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02fb->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0148->IL0085: Incompatible stack types: I4 vs Obj
			//IL_031f->IL0085: Incompatible stack types: I4 vs Obj
			//IL_02b5->IL0085: Incompatible stack heights: 7 vs 1
			//IL_0226->IL0085: Incompatible stack heights: 3 vs 1
			//IL_0245->IL0085: Incompatible stack types: I4 vs Obj
			//IL_035e->IL0085: Incompatible stack types: I4 vs Obj
			//IL_034a->IL0085: Incompatible stack types: I4 vs Obj
			//IL_01e4->IL0085: Incompatible stack heights: 2 vs 1
			//IL_01b6->IL0085: Incompatible stack heights: 6 vs 1
			//IL_02d4->IL0085: Incompatible stack types: I4 vs Obj
			//IL_030d->IL0085: Incompatible stack types: I4 vs Obj
			//IL_03c8->IL0085: Incompatible stack types: I4 vs Obj
			//IL_03da->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0189->IL0085: Incompatible stack types: I4 vs Obj
			//IL_02c0->IL0085: Incompatible stack heights: 7 vs 1
			//IL_0231->IL0085: Incompatible stack heights: 3 vs 1
			//IL_0168->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0132->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0173->IL0085: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				case 1:
					obj = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
					obj2 = 0;
					if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
					{
						obj2 = 0;
					}
					break;
				case 2:
					if (obj != null)
					{
						obj3 = 19;
						goto IL_0085;
					}
					goto IL_02d4;
				case 5:
					goto IL_047c;
				case 4:
					return;
				default:
					obj = ((Rpc._003CListenAsync_003Ed__34)this)._003C_003Eu__1;
					obj2 = 1;
					if (((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)Mass.Game.Launcher.Rpc._003CListenAsync_003Ed__34.DecorateIterableWriter)->_003C_003E1__state == 0)
					{
						obj2 = 2;
					}
					break;
				case 3:
					{
						_ = Unsafe.As<AsyncTaskMethodBuilder, TaskAwaiter<RestResponse<EntityFeverManifest>>>(ref ((Rpc._003CListenControlConnectAsync_003Ed__35)this)._003C_003Et__builder).IsCompleted;
						_ = 4;
						break;
					}
					IL_0085:
					while (true)
					{
						switch ((int)obj3)
						{
						case 11:
							if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)obj)->_003C_003E1__state != 2)
							{
								obj3 = 16;
								continue;
							}
							goto case 5;
						default:
							Unsafe.As<AsyncTaskMethodBuilder, FeverInstaller._003CFeverRequest_003Ed__15<_00210>>(ref ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Et__builder) = default;
							obj3 = 14;
							continue;
						case 8:
							((TcpListener)(&obj)).Dispose();
							if ((int)/*Error near IL_0154: Stack underflow*/ == 0)
							{
								obj3 = 9;
								if (Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
								{
									obj3 = 3;
								}
								continue;
							}
							goto case 23;
						case 1:
							if ((int)((Task)(&obj)).GetAwaiter() == 0)
							{
								obj3 = 6;
								continue;
							}
							goto case 25;
						case 13:
							_ = ((Authenticator._003CReceiveAsync_003Ed__9*)(nint)obj)->_003C_003Et__builder;
							_ = ((Authenticator._003CReceiveAsync_003Ed__9*)(Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.DecorateExpandableParser() ? 1 : 0))->client;
							((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)obj)->SetStateMachine((IAsyncStateMachine)new Authenticator._003CListenAuthenticationConnectAsync_003Ed__8());
							_ = 4;
							continue;
						case 19:
							if ((nint)obj != 1)
							{
								obj = 11;
								goto IL_0081;
							}
							goto case 15;
						case 12:
							((RestResponse<EntityFeverManifest>)(object)Unsafe.AsPointer(ref ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003E1__state)).EnsureSuccessStatusCode<EntityFeverManifest>((string?)(&obj), (byte)Unsafe.AsPointer(ref this) != 0);
							_ = 21;
							continue;
						case 3:
							return;
						case 5:
							_ = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)obj)->client;
							((TaskAwaiter<TcpClient>*)((Task<TcpClient>)(object)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)obj)->_003C_003E4__this).GetAwaiter())->GetResult();
							obj = Encoding.UTF8;
							_ = 1;
							if (((FeverInstaller)FeverInstaller._003CfeverVersion_003EP)._003CappId_003EP == null)
							{
								_ = 0;
							}
							continue;
						case 6:
							obj = 0;
							((FeverInstaller)Unsafe.AsPointer(ref this))._003CappVersion_003EP = 0;
							obj3 = 22;
							continue;
						case 4:
						{
							_ = 6;
							((Task<string>)obj).GetAwaiter();
							((TcpClient)obj).Close();
							string result = ((TaskAwaiter<string>*)obj)->GetResult();
							((FeverInstaller)obj).Dispose();
							new RestClient((RestClientOptions)(object)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)((FeverInstaller)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)result)->_003C_003Et__builder).GetFeverManifestAsync(obj))->request, (ConfigureHeaders)(object)((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003Eu__1, (ConfigureSerialization)obj, (byte)__ldftn(FeverInstaller.FeverRequest<T>) != 0);
							_ = (delegate*<bool>)(&FeverInstaller.CheckScopeSummarizer);
							((FeverInstaller._003CFeverRequest_003Ed__15<>*)new AsyncTaskMethodBuilder<EntityFeverManifest>())->MoveNext();
							obj = AsyncTaskMethodBuilder<EntityFeverManifest>.Create();
							_ = 8;
							if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003Et__builder)._003C_003E4__this != null)
							{
								_ = 6;
							}
							continue;
						}
						case 14:
							obj = -1;
							((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this).info = (EntityFeverManifestInfo)(-1);
							obj3 = 25;
							continue;
						case 18:
							break;
						case 15:
							obj = ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003Et__builder;
							obj3 = 20;
							continue;
						case 2:
							((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003E4__this = (FeverInstaller)obj;
							obj3 = 12;
							continue;
						case 25:
							_ = ref obj;
							/*Error near IL_0321: Member reference must be method, but was: Field*/;
						case 10:
							Unsafe.As<TaskAwaiter<EntityFeverManifestInfo>, ILogger>(ref ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003Eu__1).Warning<string>((string)(&obj), (string)Unsafe.AsPointer(ref this));
							obj3 = 3;
							continue;
						case 9:
							obj = 1;
							((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003E1__state = 1;
							obj3 = 2;
							continue;
						case 17:
							obj = -1;
							((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-1);
							obj = 23;
							goto IL_0081;
						case 23:
							_ = ref obj;
							/*Error near IL_0378: Member reference must be method, but was: Field*/;
						case 7:
							/*Error near IL_038d: Member reference must be method, but was: Field*/;
						case 21:
							return;
						case 20:
							Unsafe.As<TaskAwaiter<EntityFeverManifest>, @null>(ref ((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Eu__3) = null;
							obj3 = 17;
							continue;
						case 22:
							((Rpc)Unsafe.AsPointer(ref this)).ProcessId__BackingField = (nint)obj;
							obj3 = 10;
							continue;
						case 16:
						case 24:
							goto IL_047c;
							IL_0081:
							obj3 = obj;
							continue;
						}
						break;
					}
					goto IL_02d4;
					IL_047c:
					((Rpc._003CListenAsync_003Ed__34)this)._003C_003E1__state = -2;
					obj2 = 3;
					if (((Rpc._003CListenAsync_003Ed__34)Mass.Game.Launcher.Rpc._003CListenAsync_003Ed__34._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 2;
					}
					break;
					IL_02d4:
					obj = ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003Eu__1;
					obj3 = 0;
					if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReflectReporter)->_003C_003E1__state == 0)
					{
						obj3 = 0;
					}
					goto IL_0085;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E900()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778635, new IntPtr(2737337584524L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_EA00()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPrepareVersionAsync_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		public CancellationToken cancellationToken;

		private object _003Cpatch_003E5__2;

		private TaskAwaiter<EntityGameClientPatch> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private static object DecorateAdaptableStream;

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
		internal static bool DecoratePortableEncryptor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ArrangeContext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778634, new IntPtr(2737337578284L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778633, new IntPtr(2737337584524L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778632, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E000()
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
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitCallVirt(CallVirt inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2535
			//    at ICSharpCode.Decompiler.IL.CallVirt.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2215
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Default(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 93
			//    at ICSharpCode.Decompiler.IL.ILVisitor`1.VisitCallVirt(CallVirt inst) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 7667
			//    at ICSharpCode.Decompiler.IL.CallVirt.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2211
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
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 307
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E100()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778631, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E200()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStartGameAsync_003Ed__137 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		public CancellationToken token;

		private nint _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		private static object SaveMapper;

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
		internal static bool CheckRemoteAllocator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectActiveQueue()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00턀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778630, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00툀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0045: Expected I, but got Obj
			//IL_0045: Expected Obj, but got Ref
			//IL_004f: Expected native int or pointer, but got Obj
			//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00팀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778629, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00퐀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00픀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778628, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00혀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0099: Expected I4, but got Obj
			//IL_072b: Expected Obj, but got Ref
			//IL_0051: Expected Obj, but got I4
			//IL_0702: Expected Obj, but got Ref
			//IL_0713: Expected Obj, but got I
			//IL_0503: Expected Obj, but got Ref
			//IL_046a: Expected Obj, but got VT
			//IL_0491: Expected I, but got Obj
			//IL_0491: Expected Obj, but got Ref
			//IL_04c5: Expected VT, but got Ref
			//IL_0440: Expected Obj, but got I4
			//IL_04a0: Expected Obj, but got I4
			//IL_04a5: Expected Obj, but got I4
			//IL_04a5: Expected Obj, but got Ref
			//IL_05df: Expected Obj, but got Ref
			//IL_05df: Expected Obj, but got Ref
			//IL_05df: Expected Obj, but got Ref
			//IL_05e9: Expected native int or pointer, but got Obj
			//IL_03c1: Expected Obj, but got I4
			//IL_03c6: Expected VT, but got I4
			//IL_0137: Expected Ref, but got F8
			//IL_0142: Expected Obj, but got VT
			//IL_04d9: Expected Obj, but got I4
			//IL_04de: Expected Obj, but got Ref
			//IL_057f: Expected Obj, but got I4
			//IL_0584: Expected VT, but got I4
			//IL_058e: Expected native int or pointer, but got Obj
			//IL_03b2: Expected Obj, but got I4
			//IL_01d3: Expected Obj, but got I4
			//IL_0188: Expected Obj, but got I4
			//IL_0565: Expected native int or pointer, but got Obj
			//IL_0124: Expected I4, but got Obj
			//IL_0216: Expected Obj, but got I4
			//IL_021b: Expected Obj, but got I4
			//IL_01ef: Expected Obj, but got I4
			//IL_01ef: Expected Obj, but got VT
			//IL_022a: Expected Obj, but got I4
			//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a6: Expected Obj, but got Ref
			//IL_02cd: Expected Obj, but got Ref
			//IL_0202: Expected Obj, but got Ref
			//IL_01c6: Expected I4, but got Obj
			//IL_0735->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0718->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
			//IL_05bf->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_050f->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_061a->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_00a3->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0723->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0625->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_0553->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_047e->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_0532->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_049b->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_05d1->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_04af->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_05b4->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_05f3->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_03d0->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_015d->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_0645->IL00a7: Incompatible stack heights: 2 vs 1
			//IL_04f2->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_042b->IL00a7: Incompatible stack heights: 2 vs 1
			//IL_0598->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_03bc->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_0489->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_01dd->IL0191: Incompatible stack types: I4 vs Obj
			//IL_053d->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_04d4->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_05fe->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_0168->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_03e6->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_04fd->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_05a3->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_056f->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_057a->IL00a7: Incompatible stack types: I4 vs Obj
			//IL_0225->IL0191: Incompatible stack types: I4 vs Obj
			//IL_01fb->IL0191: Incompatible stack types: I4 vs Obj
			//IL_0243->IL0191: Incompatible stack types: I4 vs Obj
			//IL_030c->IL0191: Incompatible stack types: I4 vs Obj
			//IL_02ba->IL0191: Incompatible stack heights: 2 vs 1
			//IL_02e1->IL0191: Incompatible stack types: I4 vs Obj
			//IL_0294->IL0191: Incompatible stack types: I4 vs Obj
			//IL_024e->IL0191: Incompatible stack types: I4 vs Obj
			//IL_0317->IL0191: Incompatible stack types: I4 vs Obj
			//IL_02c5->IL0191: Incompatible stack heights: 2 vs 1
			//IL_02ec->IL0191: Incompatible stack types: I4 vs Obj
			//IL_029f->IL0191: Incompatible stack types: I4 vs Obj
			//IL_0211->IL0191: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 4;
			object obj = awaiter;
			while (true)
			{
				switch ((int)obj)
				{
				case 2:
					return;
				case 3:
					awaiter = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
					obj = 0;
					if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj = 0;
					}
					continue;
				case 5:
					((AsyncTaskMethodBuilder*)/*Error near IL_007b: Stack underflow*/)->Start<TStateMachine>(ref Unsafe.As<TaskAwaiter, TStateMachine>(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1));
					obj = 2;
					continue;
				default:
				{
					object obj2;
					switch ((int)awaiter)
					{
					default:
						obj2 = 29;
						goto IL_00a7;
					case 1:
						awaiter = ((Rpc)Unsafe.AsPointer(ref this)).Listener__BackingField;
						obj2 = 8;
						goto IL_00a7;
					case 0:
						goto IL_05b4;
					case 2:
						goto IL_05fe;
						IL_00a7:
						while (true)
						{
							object obj3;
							switch ((int)obj2)
							{
							case 2:
								return;
							case 20:
								return;
							case 16:
							{
								Task task = ((AsyncTaskMethodBuilder*)1.0)->Task;
								GC.SuppressFinalize(((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Et__builder);
								((TcpListener)(object)task).Dispose();
								awaiter = (object)/*Error near IL_0149: Stack underflow*/;
								obj2 = 10;
								if (Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler != null)
								{
									obj2 = 17;
								}
								continue;
							}
							case 3:
								if (awaiter != null)
								{
									awaiter = 3;
									obj3 = awaiter;
									goto IL_0191;
								}
								goto IL_01cb;
							case 29:
								((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this).info = (EntityFeverManifestInfo)0;
								obj2 = 27;
								continue;
							case 15:
								awaiter = 1;
								((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003Eu__1 = (TaskAwaiter<RestResponse<EntityFeverManifest>>)1;
								obj2 = 9;
								continue;
							case 17:
								if (((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)(&awaiter))->Task != null)
								{
									obj2 = 25;
									continue;
								}
								goto case 15;
							case 19:
								((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003E1__state)->MoveNext();
								/*Error near IL_0402: Member reference must be method, but was: Field*/;
							case 24:
								_ = ref ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this).version;
								((AsyncTaskMethodBuilder<string>*)(&awaiter))->Start(ref Unsafe.As<_003CStartGameAsync_003Ed__137, JavaAuthenticator._003CHandleAuthentication_003Ed__9>(ref this));
								_ = 20;
								continue;
							case 8:
								FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CheckScalableWorker = null;
								awaiter = 26;
								obj2 = awaiter;
								continue;
							case 21:
								FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CallGateway();
								FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.DecorateGroupedVisitor();
								/*Error near IL_044f: Member reference must be method, but was: Field*/;
							case 1:
								goto IL_0462;
							case 6:
								((Rpc)Unsafe.AsPointer(ref this)).ProcessId__BackingField = (nint)awaiter;
								obj2 = 24;
								continue;
							case 10:
								awaiter = -1;
								((Rpc)Unsafe.AsPointer(ref this)).Logger__BackingField = -1;
								obj2 = 13;
								continue;
							case 7:
								if (RestClientExtensions.ExecuteAsync<_0021_00210>((IRestClient)/*Error near IL_04c5: Stack underflow*/, (RestRequest)/*Error near IL_04c5: Stack underflow*/, (CancellationToken)(&awaiter)) != null)
								{
									obj2 = 12;
									continue;
								}
								goto case 22;
							case 22:
								awaiter = 2;
								((Rpc)Unsafe.AsPointer(ref this)).UseCha__BackingField = 2;
								obj2 = 4;
								if (((Rpc)(object)Mass.Game.Launcher.Rpc.Callbacks__BackingField).Writer__BackingField != null)
								{
									obj2 = 6;
								}
								continue;
							case 5:
								break;
							case 4:
								((Rpc)/*Error near IL_0514: Stack underflow*/)._002Ector((ILogger)/*Error near IL_0514: Stack underflow*/, (byte)/*Error near IL_0514: Stack underflow*/ != 0);
								((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)/*Error near IL_051e: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_051e: Stack underflow*/, ref *(TStateMachine*)((Rpc)/*Error near IL_0519: Stack underflow*/).Callbacks);
								obj2 = 8;
								if ((int)((Rpc._003CListenAsync_003Ed__34*)Mass.Game.Launcher.Rpc._003CListenAsync_003Ed__34._003C_003E1__state)->_003C_003Et__builder != 0)
								{
									obj2 = 19;
								}
								continue;
							default:
								((Rpc._003CListenAsync_003Ed__34)this)._003C_003E4__this = null;
								obj2 = 10;
								continue;
							case 28:
								if ((nint)awaiter == 1)
								{
									obj2 = 21;
									if (((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)Mass.Game.Launcher.Rpc._003CListenAsync_003Ed__34.DecorateIterableWriter)->_003C_003E1__state == 0)
									{
										obj2 = 11;
									}
									continue;
								}
								goto end_IL_0088;
							case 26:
								awaiter = -1;
								((Rpc._003CListenControlConnectAsync_003Ed__35)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-1);
								obj2 = 11;
								if (((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)Mass.Game.Launcher.Rpc._003CListenControlConnectAsync_003Ed__35.listener)->_003C_003E4__this == null)
								{
									obj2 = 18;
								}
								continue;
							case 12:
							case 13:
								((AsyncTaskMethodBuilder<EntityFeverManifest>*)/*Error near IL_05aa: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_05aa: Stack underflow*/, ref *(TStateMachine*)(&awaiter));
								obj2 = 23;
								continue;
							case 27:
								goto IL_05b4;
							case 9:
								Mass.Game.Launcher.Rpc._003CListenControlConnectAsync_003Ed__35.ReflectSymbolicDecorator = awaiter;
								obj2 = 14;
								continue;
							case 14:
								((ILogger)/*Error near IL_05df: Stack underflow*/).Debug<string, string>((string)Unsafe.AsPointer(ref ((Rpc._003CReceiveAsync_003Ed__28)this)._003C_003E1__state), (string)(&awaiter), (string)Unsafe.AsPointer(ref this));
								obj2 = 0;
								if (((Rpc._003CReceiveAsync_003Ed__28*)(nint)Mass.Game.Launcher.Rpc._003CReceiveAsync_003Ed__28.client)->_003C_003E4__this != null)
								{
									obj2 = 2;
								}
								continue;
							case 11:
								goto IL_05fe;
							case 18:
							case 25:
								RestRequestExtensions.AddQueryParameter<_0021_00210>((RestRequest)/*Error near IL_063b: Stack underflow*/, (string)/*Error near IL_063b: Stack underflow*/, (_0021_00210)/*Error near IL_063b: Stack underflow*/, (byte)(&awaiter) != 0);
								_ = 4;
								continue;
							case 23:
								goto end_IL_0088;
								IL_0462:
								awaiter = ((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Eu__2;
								obj2 = 25;
								if (FeverInstaller._003CInstallAsync_003Ed__11.ReflectAccessibleWatcher != null)
								{
									obj2 = 28;
								}
								continue;
								IL_01cb:
								awaiter = ((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003E1__state;
								obj3 = 5;
								goto IL_0191;
								IL_0191:
								while (true)
								{
									switch ((int)obj3)
									{
									case 2:
										return;
									case 1:
										break;
									case 3:
										((ILogger)awaiter).Error((Exception)((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003Et__builder, (string)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.DecorateExpandableParser());
										awaiter = (object)/*Error near IL_01f1: Stack underflow*/;
										obj3 = 11;
										continue;
									case 11:
										((AsyncTaskMethodBuilder*)/*Error near IL_0202: Stack underflow*/)->SetException((Exception)(&awaiter));
										if ((int)/*Error near IL_0207: Stack underflow*/ != 0)
										{
											obj3 = 8;
											continue;
										}
										goto case 4;
									default:
										awaiter = -1;
										Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain = -1;
										obj3 = 6;
										continue;
									case 4:
										awaiter = 0;
										((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003E1__state = 0;
										obj3 = 7;
										if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Et__builder).client != null)
										{
											obj3 = 3;
										}
										continue;
									case 9:
										Unsafe.As<TaskAwaiter<string>, AsyncTaskMethodBuilder>(ref ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003Eu__1).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverManifestInfo>*)(&awaiter), ref Unsafe.As<_003CStartGameAsync_003Ed__137, FeverInstaller._003CInstallAsync_003Ed__11>(ref this));
										obj3 = 1;
										if (((FeverInstaller)FeverInstaller._003CfeverVersion_003EP)._003CappId_003EP == null)
										{
											obj3 = 2;
										}
										continue;
									case 6:
									case 8:
										((TcpClient)(&awaiter)).GetStream();
										_ = 10;
										if (((FeverInstaller)FeverInstaller.McBedrock__BackingField).Client__BackingField == null)
										{
											_ = 6;
										}
										continue;
									case 7:
										FeverInstaller.ReflectVisualArgument = awaiter;
										obj3 = 9;
										if ((int)((FeverInstaller._003CFeverRequest_003Ed__15<>*)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003E1__state)->_003C_003Et__builder != 0)
										{
											obj3 = 2;
										}
										continue;
									case 5:
										((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003E4__this = (FeverInstaller)default(RestRequest);
										obj3 = 0;
										if (((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Eu__1)._003C_003E1__state != 0)
										{
											obj3 = 0;
										}
										continue;
									case 10:
										goto IL_0462;
									}
									break;
								}
								goto IL_01cb;
							}
							break;
						}
						goto case 1;
						IL_05fe:
						awaiter = Mass.Game.Launcher.Rpc._003CReceiveAsync_003Ed__28.CheckMonoProgram;
						obj2 = 0;
						if ((int)((Rpc._003CRemoteCallBackAsync_003Ed__21*)Mass.Game.Launcher.Rpc._003CRemoteCallBackAsync_003Ed__21._003C_003E1__state)->_003C_003Et__builder == 0)
						{
							obj2 = 0;
						}
						goto IL_00a7;
						IL_05b4:
						obj2 = 3;
						goto IL_00a7;
						end_IL_0088:
						break;
					}
					break;
				}
				case 4:
					awaiter = GameValue.CheckSimpleMapper;
					obj = 2;
					if (((JavaGameValue)JavaGameValue.MaxMemory__BackingField).Reconnect__BackingField != 0)
					{
						obj = 3;
					}
					continue;
				case 1:
					break;
				}
				((JavaGameValue)Unsafe.AsPointer(ref this)).ReconnectDelay__BackingField = -2;
				obj = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00휀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778627, new IntPtr(2737337577244L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778626, new IntPtr(2737337583484L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStartGameUnsafe_003Ed__138 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JavaGame _003C_003E4__this;

		public CancellationToken token;

		private _003C_003Ec__DisplayClass138_0 _003C_003E8__1;

		private nint _003CsocketPort_003E5__2;

		private object _003CserverAddress_003E5__3;

		private nint _003CserverPort_003E5__4;

		private TaskAwaiter _003C_003Eu__1;

		private static object ControlModule;

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
		internal static bool CheckLiteralWorker()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateScalableProvider()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00저(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778625, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00준(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00쨀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00쬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778624, new IntPtr(2737337583484L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00츀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_004b: Expected I4, but got Obj
			//IL_0095: Expected Obj, but got I4
			//IL_0aac: Expected Obj, but got I4
			//IL_00bc: Expected Obj, but got I4
			//IL_0057: Expected I4, but got Obj
			//IL_05ee: Expected Obj, but got Ref
			//IL_05f4: Expected Obj, but got Ref
			//IL_05f9: Expected Obj, but got I4
			//IL_05f9: Expected Obj, but got Ref
			//IL_0102: Expected native int or pointer, but got Obj
			//IL_06fb: Expected Obj, but got VT
			//IL_06fb: Expected Obj, but got I
			//IL_0899: Expected Obj, but got Ref
			//IL_0333: Expected native int or pointer, but got Obj
			//IL_0352: Expected native int or pointer, but got Obj
			//IL_035e: Expected native int or pointer, but got Obj
			//IL_0368: Expected Obj, but got VT
			//IL_0372: Expected native int or pointer, but got Obj
			//IL_037d: Expected Obj, but got Ref
			//IL_0383: Expected Obj, but got Ref
			//IL_0396: Expected Obj, but got I
			//IL_039b: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a2: Expected Obj, but got I4
			//IL_03a4: Expected Obj, but got I4
			//IL_0459: Expected Obj, but got VT
			//IL_0460: Expected Obj, but got Ref
			//IL_0465: Expected I4, but got Obj
			//IL_046e: Expected Obj, but got Ref
			//IL_047f: Expected Obj, but got Ref
			//IL_047f: Expected Ref, but got VT
			//IL_0989: Expected Obj, but got Ref
			//IL_098e: Expected Obj, but got I4
			//IL_0790: Expected Obj, but got Ref
			//IL_0795: Expected Obj, but got I4
			//IL_079e: Expected Obj, but got I4
			//IL_0234: Expected Obj, but got Ref
			//IL_02cc: Expected Obj, but got I4
			//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ce: Expected Obj, but got Unknown
			//IL_02e8: Expected Obj, but got Ref
			//IL_03b4: Expected Obj, but got Ref
			//IL_03b9: Expected Obj, but got Ref
			//IL_03c2: Expected Obj, but got I4
			//IL_03d4: Expected Obj, but got Ref
			//IL_0964: Expected VT, but got I4
			//IL_0838: Expected Obj, but got I
			//IL_083d: Expected I4, but got Obj
			//IL_083d: Expected I4, but got Obj
			//IL_083d: Expected Obj, but got I4
			//IL_0422: Expected native int or pointer, but got Obj
			//IL_042c: Expected VT, but got I4
			//IL_08f2: Expected Obj, but got I4
			//IL_053f: Expected Obj, but got Ref
			//IL_0544: Expected Obj, but got Ref
			//IL_0553: Expected Obj, but got I
			//IL_0680: Expected Obj, but got Ref
			//IL_0685: Expected Obj, but got Ref
			//IL_08d7: Expected Obj, but got I4
			//IL_08dc: Expected Obj, but got I4
			//IL_08dc: Expected Obj, but got Ref
			//IL_063b: Expected I4, but got Obj
			//IL_063b: Expected I4, but got Obj
			//IL_0884: Expected Obj, but got I4
			//IL_0889: Expected Obj, but got Ref
			//IL_073b: Expected Obj, but got Ref
			//IL_0275: Expected Obj, but got Ref
			//IL_027b: Expected Obj, but got Ref
			//IL_099e: Expected Obj, but got Ref
			//IL_029c: Expected Obj, but got Ref
			//IL_0764: Expected Obj, but got Ref
			//IL_06b7: Expected Obj, but got Ref
			//IL_0591: Expected Obj, but got Ref
			//IL_0596: Expected Obj, but got Ref
			//IL_056a: Expected Obj, but got Ref
			//IL_08ab: Expected Obj, but got Ref
			//IL_08b0: Expected VT, but got Ref
			//IL_0518: Expected Obj, but got I4
			//IL_0518: Expected Obj, but got I4
			//IL_0527: Expected Obj, but got I
			//IL_04b4: Expected native int or pointer, but got Obj
			//IL_04ce: Expected Obj, but got I4
			//IL_04f3: Expected Obj, but got I4
			//IL_04f8: Expected Obj, but got VT
			//IL_04fd: Expected Obj, but got VT
			//IL_0506: Expected Obj, but got I4
			//IL_0443: Expected Obj, but got Ref
			//IL_02b8: Expected Obj, but got Ref
			//IL_01ec: Expected I4, but got Obj
			//IL_00e5->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0082->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a9->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0ab6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0061->IL0026: Incompatible stack types: I4 vs Obj
			//IL_060d->IL011b: Incompatible stack types: I4 vs Obj
			//IL_010c->IL011b: Incompatible stack types: I4 vs Obj
			//IL_00f0->IL0026: Incompatible stack heights: 2 vs 1
			//IL_008d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00b4->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0618->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0117->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0705->IL011b: Incompatible stack heights: 2 vs 1
			//IL_08a5->IL011b: Incompatible stack types: I4 vs Obj
			//IL_03ae->IL011b: Incompatible stack heights: 10 vs 1
			//IL_049a->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0998->IL011b: Incompatible stack types: I4 vs Obj
			//IL_024d->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0305->IL011b: Incompatible stack types: I4 vs Obj
			//IL_087f->IL011b: Incompatible stack heights: 4 vs 1
			//IL_03e8->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0978->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0851->IL011b: Incompatible stack heights: 2 vs 1
			//IL_0436->IL011b: Incompatible stack types: I4 vs Obj
			//IL_05dd->IL011b: Incompatible stack heights: 3 vs 1
			//IL_031a->IL011b: Incompatible stack heights: 2 vs 1
			//IL_08fc->IL011b: Incompatible stack heights: 3 vs 1
			//IL_0558->IL011b: Incompatible stack heights: 2 vs 1
			//IL_068f->IL011b: Incompatible stack heights: 2 vs 1
			//IL_08e6->IL011b: Incompatible stack types: I4 vs Obj
			//IL_041f->IL011b: Incompatible stack heights: 2 vs 1
			//IL_0819->IL011b: Incompatible stack heights: 14 vs 1
			//IL_0660->IL011b: Incompatible stack heights: 2 vs 1
			//IL_0893->IL011b: Incompatible stack types: I4 vs Obj
			//IL_08d2->IL011b: Incompatible stack heights: 3 vs 1
			//IL_0331->IL011b: Incompatible stack heights: 3 vs 1
			//IL_0202->IL011b: Incompatible stack types: I4 vs Obj
			//IL_074d->IL011b: Incompatible stack heights: 2 vs 1
			//IL_0296->IL011b: Incompatible stack heights: 9 vs 1
			//IL_09b8->IL011b: Incompatible stack types: I4 vs Obj
			//IL_02ab->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0778->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0223->IL011b: Incompatible stack heights: 4 vs 1
			//IL_0716->IL0305: Incompatible stack heights: 2 vs 0
			//IL_05aa->IL011b: Incompatible stack heights: 2 vs 1
			//IL_057e->IL011b: Incompatible stack heights: 2 vs 1
			//IL_08ba->IL011b: Incompatible stack types: I4 vs Obj
			//IL_052c->IL011b: Incompatible stack heights: 2 vs 1
			//IL_050b->IL0117: Incompatible stack heights: 10 vs 0
			//IL_044d->IL011b: Incompatible stack heights: 3 vs 1
			//IL_02c2->IL011b: Incompatible stack heights: 2 vs 1
			//IL_04a5->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0258->IL011b: Incompatible stack types: I4 vs Obj
			//IL_03f3->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0983->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0409->IL011b: Incompatible stack types: I4 vs Obj
			//IL_085c->IL011b: Incompatible stack heights: 2 vs 1
			//IL_05e8->IL011b: Incompatible stack heights: 3 vs 1
			//IL_0930->IL011b: Incompatible stack types: I4 vs Obj
			//IL_06aa->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0563->IL011b: Incompatible stack heights: 2 vs 1
			//IL_0824->IL011b: Incompatible stack heights: 14 vs 1
			//IL_066b->IL011b: Incompatible stack heights: 2 vs 1
			//IL_09c3->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0783->IL011b: Incompatible stack types: I4 vs Obj
			//IL_022e->IL011b: Incompatible stack heights: 4 vs 1
			//IL_072a->IL011b: Incompatible stack heights: 3 vs 1
			//IL_05b5->IL011b: Incompatible stack heights: 2 vs 1
			//IL_0589->IL011b: Incompatible stack heights: 2 vs 1
			//IL_0537->IL011b: Incompatible stack heights: 2 vs 1
			//IL_093b->IL011b: Incompatible stack types: I4 vs Obj
			//IL_0735->IL011b: Incompatible stack heights: 3 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				default:
					return;
				case 7:
					((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state = (int)null;
					obj2 = 2;
					break;
				case 0:
					return;
				case 3:
					Unsafe.As<AsyncTaskMethodBuilder, Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10>(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Et__builder) = default;
					obj2 = 7;
					if (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton != null)
					{
						obj2 = 2;
					}
					break;
				case 4:
					obj = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003E1__state;
					obj2 = 1;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener != null)
					{
						obj2 = 0;
					}
					break;
				case 6:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003E4__this = (Authenticator)(-2);
					obj2 = 3;
					break;
				case 2:
					_ = Unsafe.As<TaskAwaiter<TcpClient>, TaskAwaiter>(ref ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Eu__1).IsCompleted;
					_ = 0;
					if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						_ = 0;
					}
					break;
				case 1:
					if (obj == null)
					{
						obj3 = 0;
						if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9._003C_003E4__this)->client == null)
						{
							obj3 = 1;
						}
						goto IL_011b;
					}
					goto IL_05e8;
				case 5:
					{
						obj = CrashReason.JvmArgError;
						obj2 = 4;
						break;
					}
					IL_05e8:
					ComponentPath.ReflectEfficientVerifier = (ComponentPath)((ComponentPath)Unsafe.AsPointer(ref this)).IsResourcePack;
					obj3 = 10;
					if (((CppGamePath)(object)CppGamePath.BedrockLauncherFile).BedrockLauncher == null)
					{
						obj3 = 25;
					}
					goto IL_011b;
					IL_011b:
					while (true)
					{
						switch ((int)obj3)
						{
						case 29:
							return;
						case 36:
							break;
						case 34:
							((AsyncTaskMethodBuilder*)/*Error near IL_01f6: Stack underflow*/)->SetException((Exception)/*Error near IL_01f6: Stack underflow*/);
							obj = (object)/*Error near IL_01f8: Stack underflow*/;
							obj3 = 37;
							continue;
						case 41:
							_ = ref Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain;
							Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateGenericStruct();
							_ = 2;
							if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Et__builder).client != null)
							{
								_ = 5;
							}
							continue;
						case 7:
							Unsafe.Write(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)/*Error near IL_0239: Stack underflow*/)->_003Cstream_003E5__2, ((TcpListener)Unsafe.AsPointer(ref this)).AcceptTcpClientAsync());
							obj3 = 3;
							if (Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway == null)
							{
								obj3 = 28;
							}
							continue;
						case 37:
							_ = ((FeverInstaller)obj)._003CfeverVersion_003EP;
							_ = ((FeverInstaller)obj)._003CappId_003EP;
							_ = ((FeverInstaller)obj)._003CappVersion_003EP;
							_ = FeverInstaller.McBedrock__BackingField;
							_ = ((FeverInstaller)Unsafe.AsPointer(ref this)).Client__BackingField;
							_ = FeverInstaller.ReflectVisualArgument;
							((FeverInstaller)new FeverInstaller()).InstallAsync();
							_ = 32;
							continue;
						case 39:
							Unsafe.Write(&((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)/*Error near IL_02a1: Stack underflow*/)->request, ((FeverInstaller)/*Error near IL_029c: Stack underflow*/).GetFeverManifestAsync((object)Unsafe.AsPointer(ref this)));
							obj3 = 7;
							continue;
						case 50:
							((FeverInstaller)obj).FeverRequest<T>((RestRequest)(object)Unsafe.AsPointer(ref ((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003Eu__1));
							_ = 3;
							continue;
						case 8:
						{
							obj = (object)new RestClient((RestClientOptions)/*Error near IL_02cc: Stack underflow*/, (ConfigureHeaders)obj, (ConfigureSerialization)(object)10, true);
							Task<EntityFeverManifest> task = (FeverInstaller.CheckScopeSummarizer() ? ((AsyncTaskMethodBuilder<EntityFeverManifest>*)1) : ((AsyncTaskMethodBuilder<EntityFeverManifest>*)null))->Task;
							((FeverInstaller._003CFeverRequest_003Ed__15<>*)obj)->MoveNext();
							((FeverInstaller._003CFeverRequest_003Ed__15<>*)task)->SetStateMachine((IAsyncStateMachine)(&obj));
							((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)((IReadOnlyDictionary<ushort, Func<RpcCallBack, Task>>)/*Error near IL_02ed: Stack underflow*/).GetValueOrDefault((ushort)(&obj)))->Start<TStateMachine>(ref *(TStateMachine*)((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)(&obj))->Task);
							obj = (object)/*Error near IL_02fb: Stack underflow*/;
							obj3 = 19;
							continue;
						}
						case 19:
							_ = Unsafe.As<TaskAwaiter<RestResponse<EntityFeverManifest>>, AsyncTaskMethodBuilder<EntityFeverAppVersion>>(ref ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003Eu__1).Task;
							_ = 24;
							continue;
						case 33:
							FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.ReflectRemoteFinder();
							AsyncTaskMethodBuilder<_0021_00210>.Create();
							_ = 23;
							continue;
						case 3:
						{
							_ = ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)obj)->_003C_003E4__this;
							TaskAwaiter<EntityFeverManifestInfo> taskAwaiter = ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(FeverInstaller._003CGetFeverManifestAsync_003Ed__12.SearchChain() ? 1 : 0))->_003C_003Eu__1;
							((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)obj)->MoveNext();
							_ = ((FeverInstaller._003CInstallAsync_003Ed__11*)(&taskAwaiter))->_003C_003E1__state;
							_ = ((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)obj)->_003C_003Et__builder;
							((FeverInstaller._003CInstallAsync_003Ed__11*)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.DecorateGroupedVisitor())->SetStateMachine((IAsyncStateMachine)((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)obj)->_003C_003Eu__1);
							_ = ((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Eu__3;
							_ = FeverInstaller._003CInstallAsync_003Ed__11.ReflectAccessibleWatcher;
							_ = ((Rpc)Unsafe.AsPointer(ref this)).ProcessId__BackingField;
							object obj4 = ((Rpc)Unsafe.AsPointer(ref this)).Logger__BackingField;
							((Rpc)((Rpc)obj).NeedCha__BackingField).NeedCha = ((Rpc)obj).NeedCha;
							_ = obj4 * 1024;
							obj = ((Rpc)1).UseCha;
							_ = 43;
							continue;
						}
						case 9:
							((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_03b9: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)Unsafe.AsPointer(ref ((Rpc)Unsafe.AsPointer(ref this)).Listener__BackingField));
							obj = 49;
							goto IL_0117;
						case 11:
							Mass.Game.Launcher.Rpc.ParseMap = ((Rpc)obj)._chaChaDe;
							obj3 = 16;
							if ((int)((Rpc._003CListenAsync_003Ed__34*)Mass.Game.Launcher.Rpc._003CListenAsync_003Ed__34._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								obj3 = 6;
							}
							continue;
						case 14:
							if (RestRequestExtensions.AddQueryParameter((RestRequest)/*Error near IL_03fa: Stack underflow*/, (string)/*Error near IL_03fa: Stack underflow*/, (string)/*Error near IL_03fa: Stack underflow*/, (byte)(&obj) != 0) != null)
							{
								obj3 = 22;
								continue;
							}
							goto case 26;
						case 27:
							((Rpc)obj).Dispose();
							((TaskAwaiter<EntityFeverApp>*)/*Error near IL_0415: Stack underflow*/)->GetResult();
							_ = 44;
							continue;
						case 16:
							((Rpc._003CListenControlConnectAsync_003Ed__35)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)obj)->_003C_003E1__state;
							obj3 = 20;
							continue;
						case 49:
							_ = ((Rpc)Unsafe.AsPointer(ref ((Rpc._003CListenControlConnectAsync_003Ed__35)this).listener)).Listener;
							_ = 11;
							continue;
						case 4:
						{
							object message = obj;
							obj = new AsyncTaskMethodBuilder<EntityFeverManifest>(ref *(TAwaiter*)9, ref *(TStateMachine*)1);
							T val = RestResponseExtensions.EnsureSuccessStatusCode<T>((RestResponse<T>)/*Error near IL_0465: Stack underflow*/, (string?)message, (byte)(int)((Rpc)(&obj)).ListenAsync() != 0);
							((AsyncTaskMethodBuilder*)((Rpc)(&obj)).SyncChaChaAsync((RpcCallBack)obj))->Start(ref *(Mass.Game.Launcher.Rpc.PopVisitor() ? ((_003CPrepareServerResourceAsync_003Ed__36*)1) : ((_003CPrepareServerResourceAsync_003Ed__36*)null)));
							((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)val)->SetResult((EntityFeverManifestInfo)(&obj));
							obj = ((TaskAwaiter<EntityFeverManifestInfo>*)/*Error near IL_0484: Stack underflow*/)->GetResult();
							obj3 = 8;
							if (((Rpc._003CRemoteCallBackAsync_003Ed__21)Mass.Game.Launcher.Rpc._003CRemoteCallBackAsync_003Ed__21._003C_003Et__builder)._003C_003E4__this == null)
							{
								obj3 = 0;
							}
							continue;
						}
						case 48:
						{
							string text = new string((string?)/*Error near IL_04ac: Stack underflow*/, (string?)obj);
							((Rpc._003CListenControlConnectAsync_003Ed__35*)text)->SetStateMachine((IAsyncStateMachine)obj);
							_ = Mass.Game.Launcher.Rpc._003CRemoteCallBackAsync_003Ed__21.MeasureCalc;
							new Task<EntityFeverManifestInfo>();
							(((TaskAwaiter<EntityFeverManifestInfo>*)null)->IsCompleted ? ((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)1) : ((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)null))->SetException((Exception)1);
							_ = ((TaskAwaiter<EntityFeverManifest>*)((CppGameValue)Mass.Game.Launcher.Rpc._003CSyncChaChaAsync_003Ed__38.RateStack).SkinPath__BackingField)->IsCompleted;
							((Rpc._003CSyncChaChaAsync_003Ed__38*)((TaskAwaiter<EntityFeverManifest>*)1)->GetResult())->SetStateMachine((IAsyncStateMachine)((Task<EntityFeverAppVersion>)((Task<EntityFeverManifest>)1).GetAwaiter()).GetAwaiter());
							obj = 47;
							goto IL_0117;
						}
						case 47:
							((BinaryWriter)Mass.Game.Launcher.Rpc._003CSyncChaChaAsync_003Ed__38.DecorateConnectedMapper()).Write((byte[])1);
							_ = 0;
							if (((JavaGameValue)JavaGameValue.SetChinese__BackingField).SetGuiScale__BackingField == 0)
							{
								_ = 0;
							}
							continue;
						case 24:
							((CppGameValue)Unsafe.AsPointer(ref ((JavaGameValue)Unsafe.AsPointer(ref this)).GuiScale__BackingField))._002Ector();
							_ = 37;
							if (((JavaGameValue)JavaGameValue.WindowWidth__BackingField).WindowHeight__BackingField == 0)
							{
								_ = 48;
							}
							continue;
						case 22:
						case 45:
							_ = ((MemberInfo)(&obj)).Name;
							_ = 46;
							if (((BedrockGamePath)(object)BedrockGamePath.NeteaseData).Launcher == null)
							{
								_ = 0;
							}
							continue;
						case 44:
							((GameValue)Unsafe.AsPointer(ref BedrockGamePath.StartTemplate))._002Ector();
							_ = 36;
							if (((ComponentPath)(object)ComponentPath.Target).Source == null)
							{
								_ = 13;
							}
							continue;
						case 17:
							_ = ((JavaGameValue)obj).MaxMemory;
							_ = ((JavaGameValue)(object)((ComponentPath)obj).ComponentZip).Reconnect;
							_ = 28;
							if (((ComponentPath)(object)ComponentPath.ComponentExtension).Item == null)
							{
								_ = 42;
							}
							continue;
						case 13:
							goto IL_05e8;
						case 30:
							((ChaChaX)obj)._002Ector((byte[])(object)((CppGamePath)obj).BedrockHash, (byte[])(object)((CppGamePath)obj).Bedrock, (int)((CppGamePath)obj).GameZip, (byte)(int)((CppGamePath)obj).BePackCache != 0);
							_ = ((JavaGameValue)new JavaGameValue(((JavaGameValue)obj).WindowWidth)).WindowHeight;
							_ = 5;
							if (CppGamePath.CheckDetachedBridge != null)
							{
								_ = 6;
							}
							continue;
						case 25:
							ConfigValue.Get((Type)Unsafe.AsPointer(ref ((GamePath)Unsafe.AsPointer(ref this)).Root));
							_ = 12;
							continue;
						case 20:
							if (((RegistryKey)/*Error near IL_069b: Stack underflow*/).GetValue(((GamePath)obj).Data) != null)
							{
								obj3 = 39;
								continue;
							}
							goto case 46;
						case 42:
							BedrockGamePath.GetBedrockPath();
							_ = ((GamePath)Unsafe.AsPointer(ref this)).Game;
							/*Error near IL_06b7: Member reference must be method, but was: Field*/;
						default:
							((CppGamePath)/*Error near IL_06e9: Stack underflow*/)._002Ector((EntityLaunchCppGame)obj);
							((NotSupportedException)(delegate*<bool>)(&CppGamePath.ReflectDetailedCommand))._002Ector(new DefaultInterpolatedStringHandler());
							_ = 10;
							continue;
						case 43:
							GamePath.ReflectExtendedSorter();
							if (GamePath.CheckWrapper() != null)
							{
								_ = 4;
								if (((JavaGamePath)(object)JavaGamePath.GameBaseMd5).BaseMinecraft == null)
								{
									_ = 18;
								}
								continue;
							}
							goto case 19;
						case 35:
							_ = ref ((JavaGamePath)Unsafe.AsPointer(ref this)).GameVersionMd5;
							((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CStartGameUnsafe_003Ed__138, DesktopTransfer._003CHandleJoinRoomResponseAsync_003Ed__34>(ref this));
							_ = 29;
							continue;
						case 40:
							((JavaGamePath)Unsafe.AsPointer(ref this)).GameCoreLibMd5 = (string)obj;
							obj3 = 31;
							if (((JavaGamePath)(object)JavaGamePath.GameRuntime).GameRuntimeMd5 != null)
							{
								obj3 = 35;
							}
							continue;
						case 6:
							((ServerModPath)/*Error near IL_0795: Stack underflow*/)._002Ector((EntityLaunchJavaGame)/*Error near IL_0795: Stack underflow*/, (string)obj, (EntityItemDownload)MinecraftPath.ReflectAutomatedTracker(), (EntitySubItemDownload)(object)((JavaGamePath)Unsafe.AsPointer(ref this)).CustomOptions);
							obj = 9;
							goto IL_0117;
						case 28:
							_ = ((JavaGamePath)obj).Minecraft;
							_ = JavaGamePath.ReflectCentralEmitter;
							_ = ((MinecraftPath)obj).Root;
							_ = ((MinecraftPath)obj).Versions;
							_ = ((RpcCallBack)obj).Rpc;
							_ = ((MinecraftPath)obj).VersionDat;
							_ = ((MinecraftPath)obj).VersionJson;
							((EqualityComparer<Type>)(object)new StringBuilder((object?)((MinecraftPath)obj).VersionJar)).GetHashCode((Type)(object)((RpcCallBack)(object)((MinecraftPath)obj).GameAuthenticationDll).Data);
							_ = 1;
							((RpcCallBack)new EqualityComparer<Rpc>((Rpc)(object)EqualityComparer<Mass.Game.Launcher.Rpc>.Default)).ToString();
							_ = 17;
							if (((MinecraftPath)(object)MinecraftPath.Assets).Options == null)
							{
								_ = 8;
							}
							continue;
						case 15:
							((EqualityComparer<ushort>)((RpcCallBack?)/*Error near IL_082b: Stack underflow*/ == (RpcCallBack?)obj)).Equals((ushort)(int)obj, (ushort)new EqualityComparer<byte[]>((byte[])__ldftn(RpcCallBack.GetHashCode)));
							_ = 33;
							if (((ServerModPath)(object)Mass.Game.Launcher.Paths.ServerModPath.Mods).Minecraft != null)
							{
								_ = 11;
							}
							continue;
						case 10:
							((RpcCallBack)/*Error near IL_0863: Stack underflow*/).Deconstruct(out *(Rpc*)/*Error near IL_0863: Stack underflow*/, out *(BinaryWriter*)/*Error near IL_0863: Stack underflow*/, out *(ushort*)/*Error near IL_0863: Stack underflow*/, out *(byte[]*)obj);
							new AsyncTaskMethodBuilder<string>(ref *(TStateMachine*)(delegate*<bool>)(&RpcCallBack.InterruptSorter));
							AsyncTaskMethodBuilder<string>.Create();
							_ = 15;
							continue;
						case 31:
							obj = -1;
							((RpcCallBack)Unsafe.AsPointer(ref this)).Sid__BackingField = -1;
							obj3 = 45;
							continue;
						case 1:
						case 2:
							obj = ((RpcCallBack)Unsafe.AsPointer(ref this)).Data__BackingField;
							obj3 = 38;
							continue;
						case 46:
							((ILogger)/*Error near IL_08b0: Stack underflow*/).Warning<_0021_00210>((string)/*Error near IL_08b0: Stack underflow*/, (_0021_00210)Unsafe.AsPointer(ref RpcCallBack.ReflectIdentifiableTransmitter));
							obj3 = 34;
							continue;
						case 32:
							JavaAuthenticator.ReflectHiddenDispatcher();
							((JavaAuthenticator._003CHandleAuthentication_003Ed__9*)obj)->MoveNext();
							_ = 50;
							continue;
						case 26:
							obj = 0;
							((JavaAuthenticator)Unsafe.AsPointer(ref this))._003CgameVersion_003EP = 0;
							obj3 = 40;
							continue;
						case 21:
							_ = ((NeteaseSession)JavaAuthenticator._003CHandleAuthentication_003Ed__9.ReflectLogicalModule()).Token;
							_ = 27;
							continue;
						case 18:
							if ((nuint)(nint)JavaAuthenticator.ReflectInternalDistributor >= (nuint)1018000u)
							{
								obj3 = 4;
								if ((int)((JavaAuthenticator._003CHandleAuthentication_003Ed__9*)JavaAuthenticator._003CHandleAuthentication_003Ed__9._003C_003E1__state)->_003C_003Et__builder != 0)
								{
									obj3 = 4;
								}
								continue;
							}
							goto case 19;
						case 23:
							_ = ((JavaCommand)obj).Version;
							/*Error near IL_0944: Member reference must be method, but was: Field*/;
						case 12:
							Unsafe.As<object, JavaAuthenticator._003CHandleAuthentication_003Ed__9>(ref ((JavaAuthenticator._003CHandleAuthentication_003Ed__9)this)._003Cauthentication_003E5__3)._003C_003Eu__1 = (TaskAwaiter)0;
							obj3 = 12;
							if (JavaCommand.Logger__BackingField == null)
							{
								obj3 = 41;
							}
							continue;
						case 5:
							((JavaCommand)/*Error near IL_098e: Stack underflow*/).Minecraft__BackingField = Convert.ToUInt32((string?)Unsafe.AsPointer(ref this));
							obj3 = 30;
							continue;
						case 38:
							{
								Unsafe.As<EnumGameVersion, @null>(ref ((JavaCommand)Unsafe.AsPointer(ref this)).Version__BackingField) = null;
								obj3 = 31;
								if (((JavaCommand)JavaCommand.VersionName__BackingField).GameId__BackingField == null)
								{
									obj3 = 1;
								}
								continue;
							}
							IL_0117:
							obj3 = obj;
							continue;
						}
						break;
					}
					goto case 6;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00케()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00퀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778687, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	private object? _tokenSource;

	private readonly Queue<string> _recentLog;

	private nint _crashDetectedByLog;

	private readonly object _logLock;

	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	public readonly string Name;

	public readonly DesktopSession Session;

	public readonly string GameId;

	public readonly EnumGameType GameType;

	public readonly EnumGameVersion GameVersion;

	public readonly string ServerAddress;

	public readonly int ServerPort;

	[CompilerGenerated]
	private Action<JavaGame>? m_GameProgressChanged;

	[CompilerGenerated]
	private object? m_Disposed;

	[CompilerGenerated]
	private static readonly object Task__BackingField;

	private static readonly nint TotalStep;

	private static object CheckCommonGateway;

	private JavaLog Log
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (JavaLog)_FF00_FF00_FF00㤀();
		}
	}

	private CancellationTokenSource? ReconnectCts
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (CancellationTokenSource?)_FF00_FF00_FF00礀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00준(value);
		}
	}

	private JavaGameOption? GameOptions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (JavaGameOption?)_FF00_FF00_FF00ꠀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00褀(value);
		}
	}

	public List<ComponentPath>? Components
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00猀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00ᄀ(value);
		}
	}

	public ServerModPath? ServerModPath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ServerModPath?)_FF00_FF00_FF00㬀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00䔀(value);
		}
	}

	private static ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	public bool Starting
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00ᴀ() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00က(value ? ((byte)1) : ((byte)0));
		}
	}

	public List<ulong> ComponentList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00㘀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00錀(value);
		}
	}

	public string ModHashList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00ᘀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00縀(value);
		}
	}

	public bool Launched
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FFFD() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			_FF00_FF00_FF00_F600(value ? ((byte)1) : ((byte)0));
		}
	}

	private Process? Process
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Process?)_FF00_FF00_FF00ꌀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FFFD((object)value);
		}
	}

	private static JavaTask Task
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	private JavaGameValue Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (JavaGameValue)_FF00_FF00_FF00_FF00_0600();
		}
	}

	private JavaGamePath Path
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (JavaGamePath)_FF00_FF00_FF00_FF00_2A00();
		}
	}

	public EntityProgress Progress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EntityProgress)_FF00_FF00_FF00_E600();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00萀(value);
		}
	}

	public EnumStepPhase LastPhase
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00蔀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_0900(value);
		}
	}

	public JavaStep LastStep
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00簀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_F700(value);
		}
	}

	private GameProxy? Proxy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (GameProxy?)_FF00_FF00_FF00_E200();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00㴀(value);
		}
	}

	private JavaRpc? Rpc
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (JavaRpc?)_FF00_FF00_FF00넀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_2900(value);
		}
	}

	private JavaAuthenticator? Authenticator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (JavaAuthenticator?)_FF00_FF00_FF00_FF00ᤀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00鴀(value);
		}
	}

	public bool HasExited
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00㼀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			_FF00_FF00_FF00鈀(value ? ((byte)1) : ((byte)0));
		}
	}

	public int ExitCode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00瘀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			_FF00_FF00_FF00픀((uint)value);
		}
	}

	public int ProcessId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_1B00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			_FF00_FF00_FF00ꘀ((uint)value);
		}
	}

	public event Action<JavaGame>? GameProgressChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00_FF00_FF00㜀(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00_FF00_FF00騀(value);
		}
	}

	public event Action? Disposed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00_FF00_FF00_FF00_2700(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			this._FF00_FF00_FF00_FFFD((object)value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LaunchPreCheck()
	{
		_FF00_FF00_FF00_FF00㐀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLaunchStepsAsync_003Ed__2))]
	private object LaunchStepsAsync()
	{
		return _FF00_FF00_FF00_FF00_2F00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		_FF00_FF00_FF00_F200();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WaitWindow()
	{
		_FF00_FF00_FF00_FF00Ѐ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDataReceived(object sender, object e)
	{
		_FF00_FF00_FF00_E900(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnDataReceivedAsync_003Ed__12))]
	private object OnDataReceivedAsync(object sender, object e)
	{
		return _FF00_FF00_FF00_E000(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnDataReceivedAsync_003Ed__13))]
	private object OnDataReceivedAsync(object line)
	{
		return _FF00_FF00_FF00퀀(line);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnDisconnectedAsync_003Ed__14))]
	private object OnDisconnectedAsync()
	{
		return _FF00_FF00_FF00윀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnGameExit(object? sender, object e)
	{
		_FF00_FF00_FF00_FF00_2500(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareStart()
	{
		_FF00_FF00_FF00_FF00_0E00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareEnvironment()
	{
		_FF00_FF00_FF00츀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareOptions()
	{
		_FF00_FF00_FF00嘀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveGameOptions()
	{
		_FF00_FF00_FF00需();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPrepareComponentsAsync_003Ed__28))]
	public Task PrepareComponentsAsync(CancellationToken cancellationToken)
	{
		return (Task)_FF00_FF00_FF00관(cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InstallComponents()
	{
		_FF00_FF00_FF00ﬀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InstallCoreLib()
	{
		_FF00_FF00_FF00洀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPrepareJreAsync_003Ed__35))]
	public Task PrepareJreAsync(CancellationToken cancellationToken)
	{
		return (Task)_FF00_FF00_FF00ꨀ(cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPrepareServerResourceAsync_003Ed__36))]
	public Task PrepareServerResourceAsync(CancellationToken cancellationToken)
	{
		return (Task)_FF00_FF00_FF00贀(cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InstallServerResources()
	{
		_FF00_FF00_FF00_E400();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InstallServerMods()
	{
		_FF00_FF00_FF00脀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPrepareBaseVersionAsync_003Ed__43))]
	public Task PrepareBaseVersionAsync(CancellationToken cancellationToken)
	{
		return (Task)_FF00_FF00_FF00_F400(cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPrepareVersionAsync_003Ed__44))]
	public Task PrepareVersionAsync(CancellationToken cancellationToken)
	{
		return (Task)_FF00_FF00_FF00_FF00_0C00(cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPreparePackageAsync_003Ed__45))]
	private object PreparePackageAsync(JavaStep step, object md5, object name, object url, object md5Path, object outputPath, CancellationToken cancellationToken, object? before = null, object? after = null)
	{
		return _FF00_FF00_FF00_FFFD(step, md5, name, url, md5Path, outputPath, cancellationToken, before, after);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe JavaGame(EntityLaunchJavaGame args)
	{
		//IL_001b: Expected I4, but got Obj
		//IL_0016: Expected native int or pointer, but got Obj
		//IL_0022: Expected native int or pointer, but got Obj
		//IL_002c: Expected I4, but got VT
		//IL_0041: Expected native int or pointer, but got Obj
		//IL_0061: Expected native int or pointer, but got Obj
		//IL_006d: Expected native int or pointer, but got Obj
		//IL_0077: Expected Obj, but got I4
		//IL_0083: Expected native int or pointer, but got Obj
		//IL_0099: Expected native int or pointer, but got Obj
		//IL_00af: Expected native int or pointer, but got Obj
		//IL_00be: Expected VT, but got I4
		//IL_00b9: Expected native int or pointer, but got Obj
		//IL_00c5: Expected native int or pointer, but got Obj
		//IL_0100: Expected VT, but got Obj
		//IL_0113: Expected native int or pointer, but got Obj
		//IL_011d: Expected Obj, but got VT
		//IL_012e: Expected native int or pointer, but got Obj
		//IL_013d: Expected I4, but got VT
		//IL_0138: Expected native int or pointer, but got VT
		//IL_0156: Expected Obj, but got VT
		//IL_016b: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)args;
		((Authenticator)(object)this).StartListening((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Et__builder);
		Unsafe.Write(&Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton, new Authenticator());
		Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003Et__builder, (AsyncTaskMethodBuilder)new AsyncTaskMethodBuilder());
		Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)/*Error near IL_0056: Stack underflow*/)->_003C_003E4__this, (Authenticator)new GC((object)this));
		Unsafe.Write(&Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler, (object)new IAsyncStateMachine());
		((Authenticator._003CListenAsync_003Ed__7*)this)->SetStateMachine((IAsyncStateMachine)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003E1__state);
		Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)(nint)/*Error near IL_007c: Stack underflow*/)->_003C_003E4__this, /*Error near IL_007c: Stack underflow*/);
		((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->client)->MoveNext();
		Unsafe.Write(&Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain, this);
		Unsafe.Write(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003C_003E1__state)->client, Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.ReflectRandomReporter());
		Unsafe.Write(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003C_003E4__this)->_003C_003Eu__1, (TaskAwaiter<string>)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9.ReflectAdvancedEnumerator());
		((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)this)->SetStateMachine((IAsyncStateMachine)Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway);
		((FeverInstaller)(object)this)._003CappId_003EP = this;
		((FeverInstaller)/*Error near IL_00e5: Stack underflow*/)._002Ector((string)/*Error near IL_00e5: Stack underflow*/, (string)(object)this, (string)((FeverInstaller)(object)this)._003CappVersion_003EP);
		((FeverInstaller)/*Error near IL_00ea: Stack underflow*/).Client__BackingField = (object)/*Error near IL_00ea: Stack underflow*/;
		((FeverInstaller)FeverInstaller.ReflectVisualArgument).Dispose();
		Unsafe.Write(&((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)/*Error near IL_0100: Stack underflow*/)->_003C_003Et__builder, (AsyncTaskMethodBuilder<T>)this);
		Unsafe.Write(&((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)/*Error near IL_010c: Stack underflow*/)->request, this);
		Task<T> task = ((FeverInstaller)(object)this).FeverRequest<T>((RestRequest)(object)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)this)->_003C_003Eu__1);
		FeverInstaller._002Ecctor();
		Unsafe.Write(&((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)/*Error near IL_0127: Stack underflow*/)->_003C_003E4__this, task);
		((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)this)->_003C_003Eu__1)->_003C_003E1__state = (int)new FeverInstaller._003CFeverRequest_003Ed__15<>();
		_ = 4;
		_ = 0;
		_ = 0;
		_ = 0;
		Unsafe.Write(&((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(FeverInstaller._003CFeverRequest_003Ed__15<>.CheckAdaptableResponder() ? 1 : 0))->info, (EntityFeverManifestInfo)(object)new AsyncTaskMethodBuilder<EntityFeverManifestInfo>());
		AsyncTaskMethodBuilder<EntityFeverAppVersion>.Create();
		int num = 0;
		if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReflectReporter)->_003C_003E1__state == 0)
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
	public void StartLaunch()
	{
		_FF00_FF00_FF00瀀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLaunchAsync_003Ed__106))]
	private object LaunchAsync()
	{
		return _FF00_FF00_FF00팀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReportProgress(EnumStepPhase phase, JavaStep step, uint percentage, object message = "")
	{
		_FF00_FF00_FF00茀(phase, step, percentage, message);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReportProgress()
	{
		_FF00_FF00_FF00씀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object GetStepMessage(EnumStepPhase phase, JavaStep step, object message = "")
	{
		return _FF00_FF00_FF00_FF00_0300(phase, step, message);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object GetStepName(EnumStepPhase phase, JavaStep step)
	{
		return _FF00_FF00_FF00숀(phase, step);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareMods()
	{
		_FF00_FF00_FF00夀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CStartGameAsync_003Ed__137))]
	private object StartGameAsync(CancellationToken token)
	{
		return _FF00_FF00_FF00蠀(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CStartGameUnsafe_003Ed__138))]
	private object StartGameUnsafe(CancellationToken token)
	{
		return _FF00_FF00_FF00ﰀ(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return (string)_FF00_FF00_FF00退();
	}

	static JavaGame()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0027: Expected I4, but got Obj
		//IL_00a1->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0055->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0083->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00ac->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0060->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				return;
			case 1:
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_FF00㨀());
				obj2 = 0;
				if (_003CModule_003E_007B8336717d_002D71de_002D47ce_002Dbc69_002D4d75223ebc5e_007D.m_d836f3f9b6194f49a23d85cb66f28ddf.m_f8b10c0cb3e1457fa63d1cc479fd3526 != 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				TotalStep = Enum.GetValues(typeof(JavaStep)).Length;
				obj2 = 3;
				break;
			default:
				Task__BackingField = new JavaTask();
				obj2 = 1;
				if (_003CModule_003E_007B8336717d_002D71de_002D47ce_002Dbc69_002D4d75223ebc5e_007D.m_d836f3f9b6194f49a23d85cb66f28ddf.m_8d15d782e61741a1bab9ffa500515719 == 0)
				{
					obj2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateAdaptableProfiler()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static JavaGame ReflectPortableFactory()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00㘀(Action<JavaGame> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778778, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00㜀(Action<JavaGame> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0050: Expected VT, but got Obj
		//IL_0057: Expected Obj, but got VT
		//IL_0061: Expected native int or pointer, but got Obj
		//IL_00d5: Expected native int or pointer, but got Obj
		//IL_00e5: Expected Obj, but got I
		//IL_00c3: Expected native int or pointer, but got Obj
		//IL_0089: Expected native int or pointer, but got Obj
		//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0076->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0104->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009e->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				((ILogger)/*Error near IL_0050: Stack underflow*/).Debug<_0021_00210>((string)obj, (_0021_00210)P_0);
				obj = (TaskAwaiter<string>)/*Error near IL_0051: Stack underflow*/;
				obj2 = 2;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				if (obj == obj)
				{
					obj2 = 1;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state != 0)
					{
						obj2 = 3;
					}
					break;
				}
				goto case 4;
			case 3:
				return;
			case 4:
				obj = obj;
				obj2 = 1;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener == null)
				{
					obj2 = 1;
				}
				break;
			case 5:
				obj = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E4__this;
				obj2 = 4;
				break;
			case 2:
			{
				TaskAwaiter<TcpClient>* ptr = &((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003Eu__1;
				((AsyncTaskMethodBuilder<_0021_00210>*)obj)->Start(ref *(FeverInstaller._003CFeverRequest_003Ed__15<_0021_00210>*)obj);
				obj = (object)ptr;
				obj2 = 0;
				if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					obj2 = 0;
				}
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00㠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778777, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00㤀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_001b: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00㬀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_001b: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00㰀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778776, new IntPtr(2737337588684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00㴀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected I4, but got Obj
		//IL_003b: Expected native int or pointer, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00㸀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778775, new IntPtr(2737337586604L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00㼀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00䀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778774, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00䄀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778773, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00䈀()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected native int or pointer, but got Obj
		//IL_0049: Expected Obj, but got VT
		//IL_005d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0068->IL0026: Incompatible stack heights: 2 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
			case 0:
				return;
			case 1:
				System.Threading.Tasks.Task.Run((Func<Task?>)((Authenticator._003CListenAsync_003Ed__7*)(nint)((Authenticator)(object)this).Listener)->_003C_003Et__builder);
				_ = 0;
				if (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00䌀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778772, new IntPtr(2737337586604L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00䐀()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00䔀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected I4, but got Obj
		//IL_003b: Expected native int or pointer, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00嘀()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_006f: Expected I4, but got Obj
		//IL_008f: Expected Obj, but got VT
		//IL_01d9: Expected native int or pointer, but got Obj
		//IL_01e3: Expected Obj, but got I4
		//IL_02e2: Expected native int or pointer, but got Obj
		//IL_01f5: Expected native int or pointer, but got Obj
		//IL_0205: Expected native int or pointer, but got Obj
		//IL_0223: Expected native int or pointer, but got Obj
		//IL_0572: Expected Obj, but got I
		//IL_00d0: Expected native int or pointer, but got Obj
		//IL_00e0: Expected native int or pointer, but got Obj
		//IL_00ec: Expected Obj, but got I4
		//IL_00f6: Expected native int or pointer, but got Obj
		//IL_0907: Expected I8, but got I4
		//IL_0907: Expected Obj, but got I4
		//IL_0418: Expected native int or pointer, but got Obj
		//IL_0422: Expected Obj, but got I4
		//IL_0674: Expected Obj, but got I4
		//IL_0852: Expected I4, but got Obj
		//IL_05b3: Expected Obj, but got I
		//IL_0127: Expected Ref, but got VT
		//IL_035c: Expected I4, but got Obj
		//IL_0362: Expected Obj, but got I4
		//IL_0371: Expected Obj, but got I
		//IL_0948: Expected Obj, but got I4
		//IL_044c: Expected native int or pointer, but got Obj
		//IL_06b4: Expected I4, but got Obj
		//IL_06d4: Expected I4, but got Obj
		//IL_01e8->IL0074: Incompatible stack heights: 1 vs 0
		//IL_0793->IL00b4: Incompatible stack heights: 2 vs 0
		//IL_00a8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f2->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0305->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02d1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_07eb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_079d->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0436->IL043b: Incompatible stack heights: 0 vs 1
		//IL_00ce->IL0026: Incompatible stack types: I4 vs Obj
		//IL_07c1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0310->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0870->IL0834: Incompatible stack heights: 3 vs 1
		//IL_07f6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05b8->IL0586: Incompatible stack heights: 5 vs 1
		//IL_0142->IL010f: Incompatible stack heights: 4 vs 3
		//IL_0376->IL0344: Incompatible stack heights: 2 vs 1
		//IL_095c->IL092a: Incompatible stack heights: 2 vs 1
		//IL_07cc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_087b->IL0834: Incompatible stack heights: 3 vs 1
		//IL_05c3->IL0586: Incompatible stack heights: 5 vs 1
		//IL_014d->IL010f: Incompatible stack heights: 4 vs 3
		//IL_0381->IL0344: Incompatible stack heights: 2 vs 1
		//IL_0967->IL092a: Incompatible stack heights: 2 vs 1
		//IL_0492->IL0465: Incompatible stack heights: 4 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				((Authenticator)(object)((Authenticator)(object)this).Listener).Listener = (TcpListener?)(object)this;
				((Authenticator)/*Error near IL_0085: Stack underflow*/).StartListening((int)/*Error near IL_0085: Stack underflow*/);
				if (((Authenticator)/*Error near IL_008f: Stack underflow*/).ListenAuthenticationConnectAsync((object)((Authenticator._003CListenAsync_003Ed__7)/*Error near IL_008a: Stack underflow*/)._003C_003Eu__1) != null)
				{
					return;
				}
				obj2 = 12;
				if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					obj2 = 6;
				}
				break;
			case 1:
				return;
			case 14:
				((Authenticator)(object)this).Dispose();
				if (((Authenticator)/*Error near IL_00bf: Stack underflow*/).HandleAuthentication((string)/*Error near IL_00bf: Stack underflow*/) != null)
				{
					obj2 = 5;
					break;
				}
				goto case 3;
			case 10:
			{
				_ = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003Eu__1;
				Authenticator authenticator = Mass.Game.Launcher.Authenticator.PatchUser();
				((Authenticator._003CListenAsync_003Ed__7*)this)->MoveNext();
				AsyncTaskMethodBuilder asyncTaskMethodBuilder = ((Authenticator._003CReceiveAsync_003Ed__9*)(nint)authenticator)->_003C_003Et__builder;
				obj = Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.DecorateExpandableParser();
				int num5 = 1;
				if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9.client)->_003C_003Eu__1 != 0)
				{
					num5 = 1;
				}
				while (true)
				{
					switch (num5)
					{
					case 1:
						((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)asyncTaskMethodBuilder)->SetStateMachine((IAsyncStateMachine)this);
						Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateGenericStruct();
						_ = 0;
						if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Et__builder).client != null)
						{
							_ = 0;
						}
						continue;
					}
					break;
				}
				goto case 15;
			}
			case 2:
				((FeverInstaller)/*Error near IL_01ce: Stack underflow*/)._002Ector((string)/*Error near IL_01ce: Stack underflow*/, (string)/*Error near IL_01ce: Stack underflow*/, (string)(object)this);
				if (((FeverInstaller)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller.McBedrock.Client)->_003C_003E1__state).InstallAsync() == null)
				{
					_ = 11;
					break;
				}
				goto default;
			case 7:
			{
				((FeverInstaller)(object)this).GetFeverManifestInfoAsync((object)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)this)->_003C_003E4__this);
				_ = ((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)((FeverInstaller)(object)this).GetFeverAppVersionAsync())->_003C_003E1__state)->_003C_003Et__builder;
				FeverInstaller.CheckScopeSummarizer();
				FeverInstaller.CheckStaticProgram();
				int num7 = 0;
				if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor)->_003C_003E1__state != 0)
				{
					num7 = 0;
				}
				switch (num7)
				{
				}
				goto case 6;
			}
			case 4:
				return;
			case 3:
				((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)/*Error near IL_02d7: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)this);
				(FeverInstaller._003CGetFeverManifestAsync_003Ed__12.SearchChain() ? ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)1) : ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)null))->SetStateMachine((IAsyncStateMachine)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CheckScalableWorker);
				if (this == null)
				{
					obj2 = 8;
					if (((FeverInstaller._003CInstallAsync_003Ed__11)FeverInstaller._003CInstallAsync_003Ed__11._003C_003Et__builder)._003C_003E4__this != null)
					{
						obj2 = 8;
					}
					break;
				}
				goto case 2;
			case 11:
			{
				((FeverInstaller._003CInstallAsync_003Ed__11*)/*Error near IL_0316: Stack underflow*/)->MoveNext();
				((FeverInstaller._003CInstallAsync_003Ed__11*)/*Error near IL_031b: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_031b: Stack underflow*/);
				((DefaultInterpolatedStringHandler*)/*Error near IL_0321: Stack underflow*/)->AppendFormatted(0);
				int num3 = 0;
				if (((Rpc)FeverInstaller._003CInstallAsync_003Ed__11.ReflectAccessibleWatcher).ProcessId__BackingField == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						break;
					default:
						((Rpc)/*Error near IL_035c: Stack underflow*/).ProcessId = (int)this;
						_ = ((Rpc)0).Logger;
						_ = 1;
						if (((Rpc)Mass.Game.Launcher.Rpc.UseCha__BackingField).Callbacks__BackingField == null)
						{
							_ = 0;
						}
						continue;
					}
					break;
				}
				goto default;
			}
			case 13:
			{
				TcpListener? listener;
				if ((nuint)(nint)((Rpc)(object)((Rpc)/*Error near IL_0417: Stack underflow*/).Writer).ReceiveAsync((object)((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)this)->_003C_003E1__state) > (nuint)1010002u)
				{
					((Rpc)/*Error near IL_0431: Stack underflow*/).ReceiveControlData((object)/*Error near IL_0431: Stack underflow*/, (object)/*Error near IL_0431: Stack underflow*/);
				}
				else
				{
					listener = ((Rpc)/*Error near IL_043b: Stack underflow*/).Listener;
				}
				((AsyncTaskMethodBuilder<EntityFeverManifest>*)/*Error near IL_0440: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_0440: Stack underflow*/, ref *(TStateMachine*)listener);
				obj = (object)/*Error near IL_0442: Stack underflow*/;
				int num8 = 0;
				if (((Rpc._003CReceiveAsync_003Ed__28*)(nint)Mass.Game.Launcher.Rpc._003CListenControlConnectAsync_003Ed__35.ReflectSymbolicDecorator)->_003C_003E1__state != 0)
				{
					num8 = 0;
				}
				while (true)
				{
					switch (num8)
					{
					case 1:
						((Rpc)/*Error near IL_0481: Stack underflow*/).SyncChaChaAsync((RpcCallBack)(object)this);
						Mass.Game.Launcher.Rpc.PopVisitor();
						_ = 2;
						continue;
					default:
						((Rpc._003CListenAsync_003Ed__34*)Mass.Game.Launcher.Rpc.CheckConnectedDecider())->MoveNext();
						((AsyncTaskMethodBuilder*)/*Error near IL_04a3: Stack underflow*/)->Start(ref *(_003CPrepareBaseVersionAsync_003Ed__43*)obj);
						num8 = 0;
						if (((Rpc._003CRemoteCallBackAsync_003Ed__21)Mass.Game.Launcher.Rpc._003CRemoteCallBackAsync_003Ed__21._003C_003Et__builder)._003C_003E4__this == null)
						{
							num8 = 1;
						}
						continue;
					case 2:
						break;
					}
					break;
				}
				goto case 9;
			}
			case 8:
			{
				((Rpc._003CRemoteCallBackAsync_003Ed__21*)/*Error near IL_0558: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_0558: Stack underflow*/);
				((AsyncTaskMethodBuilder*)/*Error near IL_0563: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(Mass.Game.Launcher.Rpc._003CRemoteCallBackAsync_003Ed__21.RemoveTree() ? ((TaskAwaiter<EntityGameClientPatch>*)1) : ((TaskAwaiter<EntityGameClientPatch>*)null)), ref *(_003CPrepareBaseVersionAsync_003Ed__43*)null);
				int num6 = 0;
				if (((JavaGameValue)JavaGameValue.MaxMemory__BackingField).Reconnect__BackingField == 0)
				{
					num6 = 0;
				}
				while (true)
				{
					switch (num6)
					{
					case 1:
						break;
					default:
						Mass.Game.Launcher.Rpc._003CSyncChaChaAsync_003Ed__38.DecorateConnectedMapper();
						_ = 0;
						Mass.Game.Launcher.Rpc._003CSyncChaChaAsync_003Ed__38.CheckAlphabeticPolicy();
						_ = 1;
						if (((JavaGameValue)JavaGameValue.SetChinese__BackingField).SetGuiScale__BackingField != 0)
						{
							_ = 0;
						}
						continue;
					}
					break;
				}
				goto case 2;
			}
			case 16:
			{
				bool flag2 = GameValue.CheckControllablePolicy();
				((JavaGameValue)GameValue.TrackDecorator()).MaxMemory = ((JavaGameValue)(object)this).MaxMemory;
				((JavaGameValue)flag2).Reconnect = ((JavaGameValue)(object)this).Reconnect;
				((AsyncTaskMethodBuilder*)/*Error near IL_0679: Stack underflow*/)->Start(ref *(JavaRpc._003CPCycEntityCheckAsync_003Ed__25*)/*Error near IL_0679: Stack underflow*/);
				int num4 = 0;
				if (!((ComponentPath)(object)ComponentPath.Item).IsShaderPack)
				{
					num4 = 0;
				}
				while (true)
				{
					switch (num4)
					{
					case 1:
						break;
					default:
						((JavaGameValue)/*Error near IL_06b4: Stack underflow*/).SaveOptions = (byte)(int)this != 0;
						((JavaGameValue)/*Error near IL_06bf: Stack underflow*/).SetChinese = ((JavaGameValue)(object)this).SetChinese;
						((JavaGameValue)/*Error near IL_06ca: Stack underflow*/).SetGuiScale = ((JavaGameValue)(object)this).SetGuiScale;
						((JavaGameValue)/*Error near IL_06d4: Stack underflow*/).GuiScale = (int)new Func<RpcCallBack, Task>((RpcCallBack)/*Error near IL_06cf: Stack underflow*/);
						num4 = 1;
						if (((CppGamePath)(object)CppGamePath.BePackCache).BeMain != null)
						{
							num4 = 1;
						}
						continue;
					}
					break;
				}
				goto case 14;
			}
			case 9:
				BedrockGamePath.GetBedrockPath();
				if (BedrockGamePath.DecorateSequentialContainer())
				{
					_ = 16;
					break;
				}
				goto case 14;
			case 15:
				((ComponentPath)/*Error near IL_07a8: Stack underflow*/)._002Ector((string)/*Error near IL_07a8: Stack underflow*/, (EntityItemDownload)(object)this, (EntitySubItemDownload)(object)BedrockGamePath.DecorateSetConverter());
				if ((int)/*Error near IL_07ad: Stack underflow*/ != 0)
				{
					obj2 = 0;
					if (((JavaGamePath)GamePath.CheckGeneralStrategy).Java != null)
					{
						obj2 = 13;
					}
					break;
				}
				goto case 9;
			case 6:
				((CppGamePath)/*Error near IL_07d2: Stack underflow*/)._002Ector((EntityLaunchCppGame)(object)this);
				if ((int)/*Error near IL_07d7: Stack underflow*/ != 0)
				{
					obj2 = 10;
					break;
				}
				obj2 = 1;
				if (((JavaGamePath)(object)JavaGamePath.JavaTarget).JavaZip != null)
				{
					obj2 = 4;
				}
				break;
			case 5:
			{
				((GamePath)/*Error near IL_07fc: Stack underflow*/)._002Ector();
				bool flag = GamePath.ReflectExtendedSorter();
				((JavaGamePath)(object)this)._002Ector((EntityLaunchJavaGame)(object)GamePath.CheckWrapper());
				((ILogger)/*Error near IL_0811: Stack underflow*/).Debug<uint>((string)/*Error near IL_0811: Stack underflow*/, flag ? 1u : 0u);
				int num2 = 1;
				if (((JavaGamePath)(object)JavaGamePath.GameVersionMd5).GameCoreLibs == null)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						((MinecraftPath)(object)this)._002Ector((string)(object)JavaGamePath.DecorateScheduledClient(), (EnumGameVersion)(int)this);
						((MinecraftPath)/*Error near IL_0857: Stack underflow*/).ToString();
						MinecraftPath.ReflectAutomatedTracker();
						_ = 0;
						if (((JavaGamePath)(object)JavaGamePath.CustomOptions).GameCustom == null)
						{
							_ = 0;
						}
						continue;
					}
					break;
				}
				goto case 3;
			}
			case 12:
			{
				((RpcCallBack)/*Error near IL_08fc: Stack underflow*/).Writer = (BinaryWriter)/*Error near IL_08fc: Stack underflow*/;
				((ILogger)/*Error near IL_0907: Stack underflow*/).Debug<long>((string)((RpcCallBack)/*Error near IL_0901: Stack underflow*/).Sid, 1L);
				int num = 0;
				if (((MinecraftPath)(object)MinecraftPath.Runtime).Mods == null)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						return;
					}
					((RpcCallBack)/*Error near IL_0942: Stack underflow*/).Send((object[])(object)this);
					((RpcCallBack)1).As<T>();
					_ = 1;
					if (((MinecraftPath)(object)MinecraftPath.Libraries).Assets != null)
					{
						_ = 1;
					}
				}
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe byte _FF00_FF00_FF00圀(object P_0)
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001b: Expected native int or pointer, but got Obj
		//IL_0020: Invalid comparison between Unknown and VT
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((ILogger)/*Error near IL_001a: Stack underflow*/).Debug<_0021_00210>((string)/*Error near IL_001a: Stack underflow*/, (_0021_00210)P_0);
		return ((object)/*Error near IL_0022: Stack underflow*/ == (object)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Et__builder) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe byte _FF00_FF00_FF00堀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778771, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00夀()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected native int or pointer, but got Obj
		//IL_0058: Expected native int or pointer, but got Obj
		//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006d->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				((TcpListener)(object)((Authenticator._003CListenAsync_003Ed__7)((Authenticator._003CListenAsync_003Ed__7*)(nint)((Authenticator)(object)this).Listener)->_003C_003Et__builder)._003C_003E4__this).Start();
				obj2 = 0;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state != 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00娀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778770, new IntPtr(2737337576204L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00氀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778769, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00洀()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_00c3: Expected I4, but got Obj
		//IL_05fe: Expected Obj, but got I
		//IL_0526: Expected native int or pointer, but got Obj
		//IL_052b: Expected native int or pointer, but got Obj
		//IL_0531: Expected Obj, but got VT
		//IL_0539: Expected Obj, but got I4
		//IL_0550: Expected Obj, but got I4
		//IL_0572: Expected Obj, but got I4
		//IL_01e5: Expected I4, but got Obj
		//IL_0188: Expected Obj, but got I4
		//IL_0191: Expected Obj, but got I4
		//IL_01a7: Expected Obj, but got I4
		//IL_01a7: Expected Ref, but got Unknown
		//IL_0143: Expected Ref, but got VT
		//IL_03f7: Expected Obj, but got I4
		//IL_0404: Expected Obj, but got I4
		//IL_040c: Expected Obj, but got I4
		//IL_0414: Expected Obj, but got I4
		//IL_041e: Expected Obj, but got I4
		//IL_0423: Expected I4, but got Obj
		//IL_0429: Expected Obj, but got I4
		//IL_042a: Expected Obj, but got VT
		//IL_049d: Expected Obj, but got I4
		//IL_022b: Expected native int or pointer, but got Obj
		//IL_05c9: Expected Obj, but got I
		//IL_05d0: Expected I4, but got Obj
		//IL_0467: Expected Obj, but got I4
		//IL_04c1: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I4
		//IL_00d6: Expected native int or pointer, but got Obj
		//IL_00db: Expected native int or pointer, but got Obj
		//IL_00e1: Expected Obj, but got VT
		//IL_00e8: Expected Obj, but got I4
		//IL_00f0: Expected Obj, but got I4
		//IL_00f8: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got Unknown
		//IL_010d: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got I4
		//IL_02bb: Expected native int or pointer, but got Obj
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected Obj, but got Unknown
		//IL_0377: Expected Obj, but got I
		//IL_02e9: Expected Obj, but got VT
		//IL_02f0: Expected Obj, but got I4
		//IL_02f9: Expected Obj, but got I4
		//IL_030f: Expected Obj, but got I4
		//IL_030f: Expected Ref, but got Unknown
		//IL_03d0: Expected Obj, but got I4
		//IL_0504: Expected Obj, but got I4
		//IL_0495: Expected Obj, but got I4
		//IL_0603->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0252->IL0026: Incompatible stack types: I4 vs Obj
		//IL_057c->IL0026: Incompatible stack heights: 3 vs 1
		//IL_01ce->IL0026: Incompatible stack types: I4 vs Obj
		//IL_014d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0599->IL0026: Incompatible stack types: I4 vs Obj
		//IL_044a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04a7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0241->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05dc->IL0026: Incompatible stack heights: 2 vs 1
		//IL_046c->IL0022: Incompatible stack heights: 2 vs 0
		//IL_0124->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02c5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_062d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_037c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0225->IL0026: Incompatible stack types: I4 vs Obj
		//IL_060e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01fe->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01d9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0168->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05a4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0455->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02d0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0387->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03c0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05b9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0209->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 17;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 23:
				{
					GameInstance[] array2 = new GameInstance[6];
					((Authenticator)0).Listener = (TcpListener?)(object)this;
					((object[])/*Error near IL_00e1: Stack underflow*/)[(object)array2] = ((Authenticator._003CListenAsync_003Ed__7*)(nint)((Authenticator._003CListenAsync_003Ed__7*)(nint)array2)->_003C_003E4__this)->_003C_003Eu__1;
					((object[])/*Error near IL_00e9: Stack underflow*/)[/*Error near IL_00e9: Stack underflow*/] = ((Authenticator)/*Error near IL_00e1: Stack underflow*/).ListenAuthenticationConnectAsync((object)1);
					((object[])/*Error near IL_00f1: Stack underflow*/)[/*Error near IL_00f1: Stack underflow*/] = ((Authenticator)/*Error near IL_00e9: Stack underflow*/).ReceiveAsync((object)2);
					((object[])/*Error near IL_00f9: Stack underflow*/)[/*Error near IL_00f9: Stack underflow*/] = ((Authenticator)/*Error near IL_00f1: Stack underflow*/).ReceiveAuthenticationDataAsync((object)3);
					_003F val = /*Error near IL_00f9: Stack underflow*/;
					((Authenticator)obj).Dispose();
					Task<string> task = ((Authenticator)val).HandleAuthentication((string)4);
					((IAsyncStateMachine)4).MoveNext();
					((object[])/*Error near IL_010e: Stack underflow*/)[/*Error near IL_010e: Stack underflow*/] = task;
					((object[])/*Error near IL_010e: Stack underflow*/)[5] = obj;
					obj = ((TaskAwaiter*)/*Error near IL_0118: Stack underflow*/)->IsCompleted;
					obj2 = 26;
					continue;
				}
				case 10:
					((Authenticator._003CListenAsync_003Ed__7*)this)->MoveNext();
					((TaskAwaiter*)((Authenticator._003CReceiveAsync_003Ed__9)/*Error near IL_013e: Stack underflow*/)._003C_003Et__builder)->GetResult();
					obj2 = 13;
					continue;
				case 11:
				case 20:
					((AsyncTaskMethodBuilder*)obj)->SetException((Exception)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.ObserveTracker());
					if ((int)/*Error near IL_015e: Stack underflow*/ == 0)
					{
						obj2 = 37;
						continue;
					}
					goto case 6;
				case 9:
				{
					bool[] array5 = new bool[6];
					((object[])0)[(object)this] = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateGenericStruct() ? 1 : 0))->_003C_003Et__builder).client;
					((Authenticator._003CReceiveAsync_003Ed__9*)array5)->SetStateMachine((IAsyncStateMachine)1);
					((object[])/*Error near IL_0189: Stack underflow*/)[(object)array5] = array5;
					((object[])/*Error near IL_0189: Stack underflow*/)[2] = Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9.ReflectAdvancedEnumerator();
					((object[])/*Error near IL_0191: Stack underflow*/)[3] = Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9.DecorateConvertibleParameter();
					_003F val3 = /*Error near IL_0199: Stack underflow*/;
					((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)obj)->MoveNext();
					((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)val3)->SetStateMachine((IAsyncStateMachine)4);
					((object[])/*Error near IL_01ae: Stack underflow*/)[/*Error near IL_01ae: Stack underflow*/] = ((Encoding)/*Error near IL_01ad: Stack underflow*/).GetString((byte[])/*Error near IL_01ad: Stack underflow*/, (int)/*Error near IL_01ad: Stack underflow*/, 4);
					((object[])/*Error near IL_01ae: Stack underflow*/)[5] = obj;
					obj = ((TcpClient)/*Error near IL_01b8: Stack underflow*/).GetStream();
					obj2 = 31;
					if (((FeverInstaller)FeverInstaller.McBedrock__BackingField).Client__BackingField == null)
					{
						obj2 = 13;
					}
					continue;
				}
				case 7:
					if (((Stream)/*Error near IL_01e5: Stack underflow*/).Read((byte[])/*Error near IL_01e5: Stack underflow*/, (int)/*Error near IL_01e5: Stack underflow*/, (int)((FeverInstaller)obj).Client) != 0)
					{
						obj2 = 15;
						if (((FeverInstaller._003CFeverRequest_003Ed__15<>)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Et__builder)._003C_003E4__this != null)
						{
							obj2 = 13;
						}
						continue;
					}
					goto case 35;
				case 13:
					return;
				default:
					((RestClientOptions)/*Error near IL_0216: Stack underflow*/).UserAgent = (string)(object)((FeverInstaller)/*Error near IL_0211: Stack underflow*/).GetFeverManifestInfoAsync(obj);
					if ((int)/*Error near IL_021b: Stack underflow*/ == 0)
					{
						obj2 = 5;
						continue;
					}
					goto case 19;
				case 17:
					((RestClient)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)((FeverInstaller)/*Error near IL_022b: Stack underflow*/).FeverRequest<T>((RestRequest)(object)this))->_003C_003Et__builder).Dispose();
					obj = (object)/*Error near IL_0237: Stack underflow*/;
					obj2 = 16;
					continue;
				case 2:
					obj = ((object[])obj)[obj];
					obj2 = 14;
					continue;
				case 3:
				case 8:
				case 12:
				case 24:
				case 25:
				case 26:
				case 31:
					obj = obj;
					obj2 = 18;
					if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E4__this)->info != null)
					{
						obj2 = 18;
					}
					continue;
				case 36:
				{
					Func<, >[] array4 = new Func<, >[6];
					((object[])0)[(object)this] = ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.AnalyzeHandler() ? 1 : 0))->_003C_003E1__state)->_003C_003Et__builder;
					((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)array4)->SetStateMachine((IAsyncStateMachine)1);
					((object[])/*Error near IL_02f1: Stack underflow*/)[(object)array4] = array4;
					((object[])/*Error near IL_02f1: Stack underflow*/)[2] = FeverInstaller._003CGetFeverManifestAsync_003Ed__12.SearchChain();
					((object[])/*Error near IL_02f9: Stack underflow*/)[3] = FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReceiveEnumerator();
					_003F val2 = /*Error near IL_0301: Stack underflow*/;
					((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)obj)->MoveNext();
					((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)val2)->SetStateMachine((IAsyncStateMachine)4);
					((object[])/*Error near IL_0316: Stack underflow*/)[/*Error near IL_0316: Stack underflow*/] = ((AsyncTaskMethodBuilder<_0021_00210>*)4)->Task;
					((object[])/*Error near IL_0316: Stack underflow*/)[5] = obj;
					/*Error near IL_031b: Member reference must be method, but was: Field*/;
				}
				case 28:
				case 37:
					obj = null;
					obj2 = 25;
					if (((Rpc)Mass.Game.Launcher.Rpc.ProcessId__BackingField).Logger__BackingField == null)
					{
						obj2 = 16;
					}
					continue;
				case 5:
				case 29:
					if ((int)((Task<RestResponse<EntityFeverResponse<_00210>>>)(object)((Rpc)obj).Logger).GetAwaiter() != 0)
					{
						obj2 = 36;
						continue;
					}
					goto case 30;
				case 18:
					if (obj != null)
					{
						obj = 4;
						break;
					}
					goto case 22;
				case 15:
				{
					SectionValue[] array = new SectionValue[6];
					array[0] = (SectionValue)((Rpc)((Rpc)((Rpc)(object)this).UseCha).Listener__BackingField)._chaChaEn;
					array[(object)array] = (SectionValue)(object)((Rpc)1).Callbacks;
					((Rpc)/*Error near IL_040c: Stack underflow*/).SendMessage((BinaryWriter)/*Error near IL_0405: Stack underflow*/, (object[])2);
					((object[])/*Error near IL_040d: Stack underflow*/)[/*Error near IL_040d: Stack underflow*/] = (object)/*Error near IL_040d: Stack underflow*/;
					((Rpc)/*Error near IL_0414: Stack underflow*/).AddCallBack((ushort)/*Error near IL_040d: Stack underflow*/, (Func<RpcCallBack, Task>)3);
					((object[])/*Error near IL_0415: Stack underflow*/)[/*Error near IL_0415: Stack underflow*/] = (object)/*Error near IL_0415: Stack underflow*/;
					((Rpc)/*Error near IL_0415: Stack underflow*/).StartListen((int)((Rpc)4).RemoteCallBackAsync(obj));
					((object[])/*Error near IL_042a: Stack underflow*/)[/*Error near IL_042a: Stack underflow*/] = ((Task<EntityFeverApp>)4).GetAwaiter();
					((object[])/*Error near IL_042a: Stack underflow*/)[5] = obj;
					obj = ((TaskAwaiter<EntityFeverApp>*)/*Error near IL_0434: Stack underflow*/)->GetResult();
					obj2 = 12;
					if ((int)((Rpc._003CListenControlConnectAsync_003Ed__35*)Mass.Game.Launcher.Rpc._003CListenControlConnectAsync_003Ed__35._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						obj2 = 2;
					}
					continue;
				}
				case 21:
					_ = ((TaskAwaiter<RestResponse<EntityFeverManifest>>*)obj)->IsCompleted;
					obj = 27;
					break;
				case 35:
					((AsyncTaskMethodBuilder<EntityFeverManifest>*)/*Error near IL_0487: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_0487: Stack underflow*/, ref *(TStateMachine*)((Rpc)obj).Listener);
					if ((int)/*Error near IL_048c: Stack underflow*/ == 0)
					{
						obj = 20;
						break;
					}
					goto case 9;
				case 16:
					obj = 0;
					obj2 = 33;
					continue;
				case 22:
					((ILogger)/*Error near IL_04b8: Stack underflow*/).Debug<string, string>((string)/*Error near IL_04b8: Stack underflow*/, (string)((Rpc)/*Error near IL_04b1: Stack underflow*/).ListenControlConnectAsync(((Rpc)/*Error near IL_04ac: Stack underflow*/).ListenAsync()), (string)obj);
					obj = 34;
					break;
				case 30:
					((Rpc._003CListenAsync_003Ed__34*)obj)->MoveNext();
					if (((TaskAwaiter<EntityFeverManifestInfo>*)/*Error near IL_04f6: Stack underflow*/)->GetResult() != null)
					{
						obj = 23;
						break;
					}
					goto case 7;
				case 6:
				{
					RuntimeHelpers[] array3 = new RuntimeHelpers[7];
					((object[])0)[(object)this] = ((Rpc._003CRemoteCallBackAsync_003Ed__21*)(nint)((Rpc._003CRemoteCallBackAsync_003Ed__21*)(nint)Mass.Game.Launcher.Rpc._003CListenAsync_003Ed__34.CheckLocalObject())->callBack)->_003C_003Eu__1;
					array3[1] = (RuntimeHelpers)Mass.Game.Launcher.Rpc._003CListenControlConnectAsync_003Ed__35.DecorateConfigurableArgument();
					array3[2] = (RuntimeHelpers)Mass.Game.Launcher.Rpc._003CListenControlConnectAsync_003Ed__35.DecorateSeparatedSummarizer();
					((Rpc._003CReceiveAsync_003Ed__28*)3)->MoveNext();
					array3[(object)array3] = (RuntimeHelpers)(object)array3;
					((Rpc._003CReceiveAsync_003Ed__28*)/*Error near IL_0549: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)4);
					((object[])/*Error near IL_0551: Stack underflow*/)[/*Error near IL_0551: Stack underflow*/] = (object)/*Error near IL_0551: Stack underflow*/;
					/*Error near IL_0551: Stack underflow*/;
					_ = 5;
					object obj3 = obj;
					((object[])Mass.Game.Launcher.Rpc._003CReceiveAsync_003Ed__28.DecorateOrderedTemplate())[Mass.Game.Launcher.Rpc._003CReceiveAsync_003Ed__28.ReflectVisualAuditor()] = ((TaskAwaiter<EntityFeverAppVersion>*)4)->GetResult();
					((object[])obj3)[6] = obj;
					obj = ((TaskAwaiter<EntityFeverManifest>*)obj3)->IsCompleted;
					_ = 8;
					continue;
				}
				case 14:
					obj = ((TaskAwaiter<EntityFeverManifest>*)obj)->GetResult();
					obj2 = 0;
					if (((JavaGameValue)GameValue.CheckSimpleMapper).MaxMemory__BackingField != 0)
					{
						obj2 = 0;
					}
					continue;
				case 32:
				case 33:
					if ((nint)obj >= ((Array)obj).Length)
					{
						obj2 = 10;
						continue;
					}
					goto case 2;
				case 19:
					((Rpc._003CSyncChaChaAsync_003Ed__38*)/*Error near IL_05bf: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)this);
					_ = ((JavaGameValue)((JavaGameValue)/*Error near IL_05c4: Stack underflow*/).ReconnectDelay__BackingField).SaveOptions__BackingField;
					obj = BitConverter.GetBytes((ushort)(int)obj);
					_ = 3;
					continue;
				case 1:
				case 4:
					((CppGameValue)/*Error near IL_05e1: Stack underflow*/).SkinPath = (string)/*Error near IL_05e1: Stack underflow*/;
					((AsyncTaskMethodBuilder*)CppGameValue.Get((SectionValue)/*Error near IL_05e6: Stack underflow*/))->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)obj, ref *(_003CPrepareJreAsync_003Ed__35*)obj);
					obj2 = 21;
					if (((JavaGameValue)JavaGameValue.WindowWidth__BackingField).WindowHeight__BackingField != 0)
					{
						obj2 = 15;
					}
					continue;
				case 27:
				case 34:
					obj++;
					obj2 = 32;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00渀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778768, new IntPtr(2737337577244L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00漀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778767, new IntPtr(2737337582444L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00瀀()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0069->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				System.Threading.Tasks.Task.Run((Func<Task?>)([MethodImpl(MethodImplOptions.NoInlining)] () => (TcpListener?)((Authenticator)(object)this)._FF00_FF00_1400()));
				obj2 = 0;
				if (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
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
	internal unsafe void _FF00_FF00_FF00焀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778766, new IntPtr(2737337583484L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<ComponentPath> _FF00_FF00_FF00爀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778765, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (List<ComponentPath>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<ComponentPath> _FF00_FF00_FF00猀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_001b: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (List<ComponentPath>)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<ComponentPath> _FF00_FF00_FF00琀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778764, new IntPtr(2737337594924L), 15))(null, 0, new IntPtr(0L));
		return (List<ComponentPath>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00甀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778763, new IntPtr(2737337588684L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00瘀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00眀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778762, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00砀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778761, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00礀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_001b: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00稀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778760, new IntPtr(2737337582444L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe JavaStep _FF00_FF00_FF00笀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778759, new IntPtr(2737337594924L), 15))(null, 0, new IntPtr(0L));
		return (JavaStep)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe JavaStep _FF00_FF00_FF00簀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (JavaStep)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00紀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778758, new IntPtr(2737337594924L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00縀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected I4, but got Obj
		//IL_003a: Expected native int or pointer, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)P_0;
				obj2 = 0;
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
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
	private unsafe void _FF00_FF00_FF00耀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778757, new IntPtr(2737337579324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00脀()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_004e: Expected I, but got Obj
		//IL_008f: Expected native int or pointer, but got Obj
		//IL_0055: Expected I4, but got Obj
		//IL_0060: Expected Obj, but got VT
		//IL_0060: Expected native int or pointer, but got Obj
		//IL_006f: Expected Obj, but got VT
		//IL_0079: Expected native int or pointer, but got Obj
		//IL_00a3: Expected Obj, but got I4
		//IL_0083->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d3->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
					throw new Func<Task>((object)/*Error near IL_004e: Stack underflow*/, (nint)((Authenticator)/*Error near IL_0049: Stack underflow*/).Listener);
				case 2:
					((Authenticator)/*Error near IL_0055: Stack underflow*/).StartListening((int)this);
					GC.SuppressFinalize(((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)((Authenticator)((Authenticator._003CListenAsync_003Ed__7)/*Error near IL_005a: Stack underflow*/)._003C_003Eu__1).ListenAuthenticationConnectAsync((object)this))->_003C_003E1__state)->_003C_003Et__builder);
					obj2 = 1;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						obj2 = 0;
					}
					continue;
				case 4:
					if ((nint)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler != 2)
					{
						break;
					}
					((Authenticator._003CListenAsync_003Ed__7*)this)->MoveNext();
					if ((int)/*Error near IL_00b4: Stack underflow*/ != 0)
					{
						obj2 = 2;
						if (((Authenticator._003CReceiveAsync_003Ed__9)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9._003C_003Et__builder)._003C_003E4__this == null)
						{
							obj2 = 2;
						}
						continue;
					}
					goto default;
				case 3:
					return;
				case 1:
					return;
				}
				break;
			}
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00舀(EnumStepPhase P_0, JavaStep P_1, uint P_2, object P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778756, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00茀(EnumStepPhase P_0, JavaStep P_1, uint P_2, object P_3)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00ac: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got VT
		//IL_008f: Expected Obj, but got I4
		//IL_00c0->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a5->IL0026: Incompatible stack heights: 2 vs 1
		//IL_005e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0094->IL0022: Incompatible stack heights: 8 vs 0
		//IL_00cb->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0069->IL0026: Incompatible stack heights: 2 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				case 2:
					_ = ((Authenticator)(object)this).Listener;
					_ = 0;
					if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						_ = 0;
					}
					continue;
				case 3:
					break;
				case 1:
					((Authenticator)P_1).Dispose();
					_ = 4;
					continue;
				default:
					((Authenticator)(object)this).HandleAuthentication((string)P_0);
					_ = 1;
					if (Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
					{
						_ = 1;
					}
					continue;
				case 4:
					return;
				}
				break;
			}
			_ = Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Eu__1;
			((Authenticator)((Authenticator)P_1).ListenAuthenticationConnectAsync(P_3)).ReceiveAuthenticationDataAsync((object)new AsyncTaskMethodBuilder());
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00萀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected I4, but got Obj
		//IL_003b: Expected native int or pointer, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumStepPhase _FF00_FF00_FF00蔀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (EnumStepPhase)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumStepPhase _FF00_FF00_FF00蘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778755, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (EnumStepPhase)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00蜀(CancellationToken P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778754, new IntPtr(2737337582444L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00蠀(CancellationToken P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00c7: Expected VT, but got Ref
		//IL_00c7: Expected Obj, but got Ref
		//IL_009a: Expected Obj, but got VT
		//IL_00a4: Expected native int or pointer, but got Obj
		//IL_00d9: Expected VT, but got Obj
		//IL_00e3: Expected native int or pointer, but got Obj
		//IL_005c: Expected Obj, but got Ref
		//IL_0061: Expected VT, but got Obj
		//IL_0073: Expected Obj, but got I4
		//IL_00d1->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ae->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ed->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				((Func<Task>)/*Error near IL_0054: Stack underflow*/)._002Ector((object)/*Error near IL_0054: Stack underflow*/, (nint)(&((Authenticator._003CListenAsync_003Ed__7*)(&obj))->_003C_003E1__state));
				return (object)/*Error near IL_0055: Stack underflow*/;
			case 3:
				Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)/*Error near IL_0061: Stack underflow*/)->_003C_003Eu__1, (TaskAwaiter)System.Threading.Tasks.Task.Run((Func<Task?>)(&obj)));
				obj2 = 2;
				break;
			case 5:
				Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton = -1;
				obj2 = 0;
				if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&obj))->listener = (TcpListener)P_0;
				obj2 = 5;
				if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					obj2 = 5;
				}
				break;
			default:
				RestClientExtensions.ExecuteAsync<EntityFeverResponse<_00210>>((IRestClient)/*Error near IL_00c7: Stack underflow*/, (RestRequest)(object)(&Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler), (CancellationToken)(&obj));
				_ = 4;
				break;
			case 2:
				((Authenticator._003CReceiveAsync_003Ed__9*)(&obj))->_003C_003Et__builder = (AsyncTaskMethodBuilder)this;
				obj2 = 1;
				if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9._003C_003E4__this)->client != null)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00褀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected I4, but got Obj
		//IL_003b: Expected native int or pointer, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00言()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778753, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00謀()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00谀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778752, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00贀(CancellationToken P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00dd: Expected VT, but got Obj
		//IL_00e7: Expected native int or pointer, but got Obj
		//IL_00b1: Expected Obj, but got Ref
		//IL_00c0: Expected native int or pointer, but got Obj
		//IL_0068: Expected Obj, but got I4
		//IL_0094: Expected Obj, but got VT
		//IL_009c: Expected Obj, but got VT
		//IL_00a5: Expected Obj, but got I4
		//IL_0060->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ca->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 2;
		while (true)
		{
			object obj = stateMachine;
			while (true)
			{
				switch ((int)obj)
				{
				default:
					((AsyncTaskMethodBuilder*)(&((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003E1__state))->Start(ref *(Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(&stateMachine));
					obj = 4;
					continue;
				case 3:
					((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003E4__this = (Authenticator)(-1);
					obj = 0;
					if (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
					{
						obj = 0;
					}
					continue;
				case 4:
					_ = ref ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->_003C_003E1__state;
					return AsyncTaskMethodBuilder.Create();
				case 5:
					break;
				case 2:
					((TcpListener)(&stateMachine)).Dispose();
					Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)/*Error near IL_00b6: Stack underflow*/)->_003C_003Eu__1, /*Error near IL_00b6: Stack underflow*/);
					obj = 1;
					if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state != 0)
					{
						obj = 1;
					}
					continue;
				case 1:
					((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->_003C_003Et__builder = (AsyncTaskMethodBuilder)this;
					obj = 5;
					if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9._003C_003E4__this)->client == null)
					{
						obj = 3;
					}
					continue;
				}
				break;
			}
			((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->listener = (TcpListener)P_0;
			stateMachine = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00踀(CancellationToken P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778815, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00輀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778814, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00退()
	{
		//IL_001f: Expected I, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Func<Task>)/*Error near IL_001f: Stack underflow*/)._002Ector((object)/*Error near IL_001f: Stack underflow*/, (nint)((Authenticator)(object)this).Listener);
		return (object)/*Error near IL_0020: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00鄀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778813, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00鈀(byte P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003a: Expected native int or pointer, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
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
	internal unsafe void _FF00_FF00_FF00錀(List<ulong> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected I4, but got Obj
		//IL_003b: Expected native int or pointer, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00鐀(List<ulong> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778812, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00需()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00ad: Expected native int or pointer, but got Obj
		//IL_00bd: Expected native int or pointer, but got Obj
		//IL_00c7: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got I4
		//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				case 1:
					return;
				case 5:
					((Authenticator)/*Error near IL_0054: Stack underflow*/).Listener = ((Authenticator)(object)this).Listener;
					if ((int)/*Error near IL_0059: Stack underflow*/ == 0)
					{
						obj2 = 2;
						continue;
					}
					((Authenticator)/*Error near IL_0069: Stack underflow*/).StartListening((int)/*Error near IL_0069: Stack underflow*/);
					((AsyncTaskMethodBuilder*)/*Error near IL_0073: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)((Authenticator)/*Error near IL_006e: Stack underflow*/).ListenAsync());
					obj2 = 0;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					return;
				case 3:
					return;
				case 4:
					((Authenticator)(object)this).Dispose();
					if ((int)/*Error near IL_009d: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 5;
				default:
				{
					_ = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E4__this;
					Mass.Game.Launcher.Authenticator.ReflectMonoObject();
					((Authenticator._003CListenAsync_003Ed__7*)this)->SetStateMachine((IAsyncStateMachine)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Mass.Game.Launcher.Authenticator.PatchUser())->_003C_003E1__state);
					Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.DecorateExpandableParser();
					Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.ObserveTracker();
					int num = 0;
					if (Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain == null)
					{
						num = 0;
					}
					switch (num)
					{
					case 0:
						break;
					}
					return;
				}
				}
				break;
			}
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00頀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778811, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00餀(Action<JavaGame> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778810, new IntPtr(2737337576204L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00騀(Action<JavaGame> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00c1: Expected native int or pointer, but got Obj
		//IL_0049: Expected native int or pointer, but got Obj
		//IL_0050: Expected Obj, but got I4
		//IL_0071: Expected native int or pointer, but got Obj
		//IL_00ef->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b3->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				obj = ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
				obj2 = 1;
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
				{
					obj2 = 0;
				}
				break;
			case 5:
				return;
			case 4:
				((AsyncTaskMethodBuilder*)(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Eu__1))->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)obj, ref *(Authenticator._003CReceiveAsync_003Ed__9*)obj);
				obj = (object)/*Error near IL_0081: Stack underflow*/;
				obj2 = 3;
				break;
			case 3:
				if (obj == obj)
				{
					obj2 = 5;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj2 = 5;
					}
					break;
				}
				goto case 1;
			case 1:
				obj = obj;
				obj2 = 0;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
				{
					obj2 = 0;
				}
				break;
			default:
			{
				object obj3 = obj;
				((IAsyncStateMachine)(object)P_0).MoveNext();
				obj = (Task<RestResponse<EntityFeverResponse<_00210>>>)obj3;
				obj2 = 4;
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00鬀(Action<JavaGame> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778809, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00鰀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778808, new IntPtr(2737337594924L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00鴀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected I4, but got Obj
		//IL_003b: Expected native int or pointer, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00鸀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778807, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00鼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778806, new IntPtr(2737337592844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00ꀀ()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0047: Expected native int or pointer, but got Obj
		//IL_0060: Expected native int or pointer, but got Obj
		//IL_007b: Expected native int or pointer, but got Obj
		//IL_0080: Expected native int or pointer, but got Obj
		//IL_00ba: Expected native int or pointer, but got Obj
		//IL_00c4: Expected Ref, but got VT
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a9->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00d8->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0075->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b4->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00e3->IL0026: Incompatible stack heights: 2 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				return;
			default:
				((TcpListener)(object)((Authenticator._003CListenAsync_003Ed__7)((Authenticator._003CListenAsync_003Ed__7*)(nint)((Authenticator)(object)this).Listener)->_003C_003Et__builder)._003C_003E4__this).Start();
				obj2 = 3;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				_ = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)((Authenticator)/*Error near IL_007b: Stack underflow*/).ReceiveAuthenticationDataAsync((object)this))->listener)->_003C_003E4__this;
				((Task)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler).GetAwaiter();
				_ = 0;
				if (((Authenticator._003CReceiveAsync_003Ed__9)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9._003C_003Et__builder)._003C_003E4__this == null)
				{
					_ = 0;
				}
				break;
			case 2:
				((AsyncTaskMethodBuilder*)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.ObserveTracker())->_003C_003Eu__1)->SetResult();
				_ = 1;
				if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00ꄀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778805, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00ꈀ()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00ꌀ()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_001b: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00ꐀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778804, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00ꔀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778803, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00ꘀ(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003b: Expected native int or pointer, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_A700(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778802, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00ꠀ()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_001b: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00꤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778801, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00ꨀ(CancellationToken P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00ba: Expected VT, but got I4
		//IL_0067: Expected Obj, but got Ref
		//IL_006c: Expected VT, but got Obj
		//IL_0076: Expected native int or pointer, but got Obj
		//IL_00f7: Expected Obj, but got Ref
		//IL_009d: Expected native int or pointer, but got Obj
		//IL_00c4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0080->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0060->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00eb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b2->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 2;
		object obj = stateMachine;
		while (true)
		{
			switch ((int)obj)
			{
			case 4:
				((AsyncTaskMethodBuilder*)(&((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003E1__state))->Start(ref *(Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(&stateMachine));
				obj = 3;
				break;
			case 2:
				Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)/*Error near IL_006c: Stack underflow*/)->_003C_003Eu__1, (TaskAwaiter)System.Threading.Tasks.Task.Run((Func<Task?>)(&stateMachine)));
				obj = 1;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state != 0)
				{
					obj = 0;
				}
				break;
			case 5:
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->_003C_003Et__builder = (AsyncTaskMethodBuilder)P_0;
				obj = 0;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
				{
					obj = 0;
				}
				break;
			default:
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->_003C_003Eu__1 = (TaskAwaiter<TcpClient>)(-1);
				obj = 4;
				break;
			case 1:
				Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler = this;
				obj = 5;
				if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					obj = 5;
				}
				break;
			case 3:
				((ILogger)/*Error near IL_00f7: Stack underflow*/).Error((Exception)/*Error near IL_00f7: Stack underflow*/, (string)(&((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->_003C_003E4__this));
				return (object)/*Error near IL_00f8: Stack underflow*/;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_AB00(CancellationToken P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778800, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00가(CancellationToken P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778799, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00관(CancellationToken P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_009a: Expected Obj, but got I4
		//IL_00a4: Expected native int or pointer, but got Obj
		//IL_004f: Expected VT, but got Ref
		//IL_005e: Expected native int or pointer, but got Obj
		//IL_00f7: Expected Obj, but got I4
		//IL_00c1: Expected Obj, but got VT
		//IL_0092: Expected Obj, but got VT
		//IL_00ae->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0073->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e0->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 2;
		while (true)
		{
			object obj = stateMachine;
			while (true)
			{
				switch ((int)obj)
				{
				case 2:
					((ILogger)/*Error near IL_004f: Stack underflow*/).Debug<_0021_00210>((string)/*Error near IL_004f: Stack underflow*/, (_0021_00210)(&stateMachine));
					Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)/*Error near IL_0054: Stack underflow*/)->_003C_003Et__builder, /*Error near IL_0054: Stack underflow*/);
					obj = 1;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj = 1;
					}
					continue;
				case 1:
					Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton = this;
					obj = 4;
					continue;
				case 5:
					_ = ref ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->_003C_003E1__state;
					return AsyncTaskMethodBuilder.Create();
				default:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->listener = (TcpListener)(-1);
					obj = 0;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj = 3;
					}
					continue;
				case 4:
					Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler = P_0;
					obj = 0;
					if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj = 0;
					}
					continue;
				case 3:
					break;
				}
				break;
			}
			((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)/*Error near IL_00ee: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverApp>*)(&((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->_003C_003E4__this), ref *(FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(&stateMachine));
			stateMachine = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00글(CancellationToken P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778798, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00꼀(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0041: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I4
		//IL_0050: Expected native int or pointer, but got Obj
		//IL_005a->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0065->IL0026: Incompatible stack heights: 3 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				_ = 2;
				((Authenticator)5).Listener = ((Authenticator)P_0).Listener;
				_ = 0;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
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
	private unsafe object _FF00_FF00_FF00뀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778797, new IntPtr(2737337584524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00넀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_001b: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00섀(EnumStepPhase P_0, JavaStep P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778796, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00숀(EnumStepPhase P_0, JavaStep P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_00d3: Expected I4, but got Obj
		//IL_047c: Expected Obj, but got I4
		//IL_03f2: Expected native int or pointer, but got Obj
		//IL_02d2: Expected Obj, but got I4
		//IL_01d8: Expected native int or pointer, but got Obj
		//IL_0205: Expected Obj, but got I4
		//IL_010c: Expected Obj, but got I4
		//IL_018d: Expected native int or pointer, but got Obj
		//IL_0121: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I4
		//IL_026d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03d6->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0486->IL0026: Incompatible stack types: I4 vs Obj
		//IL_036e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03fc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_014a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0308->IL0026: Incompatible stack heights: 2 vs 1
		//IL_02e6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01e2->IL0026: Incompatible stack heights: 5 vs 1
		//IL_03a3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_020f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0289->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0197->IL0026: Incompatible stack types: I4 vs Obj
		//IL_029a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02bc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_022f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0278->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03e1->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0407->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02f1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ed->IL0026: Incompatible stack heights: 5 vs 1
		//IL_0475->IL0026: Incompatible stack types: I4 vs Obj
		//IL_024f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0431->IL0026: Incompatible stack types: I4 vs Obj
		//IL_017c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01fe->IL0026: Incompatible stack types: I4 vs Obj
		//IL_043c->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 39;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 39:
					if (P_0 != EnumStepPhase.Download)
					{
						obj = 38;
						break;
					}
					goto case 28;
				case 26:
					obj = ((Authenticator)/*Error near IL_0101: Stack underflow*/).Listener;
					obj = 4;
					break;
				case 36:
					goto IL_0111;
				case 9:
					goto IL_0139;
				case 28:
					switch (P_1)
					{
					case JavaStep.Components:
						break;
					case JavaStep.ServerResource:
						goto IL_0111;
					case JavaStep.BaseVersion:
						goto IL_0139;
					default:
						goto IL_0172;
					case JavaStep.CoreLib:
						goto IL_017c;
					case JavaStep.GameWindow:
						goto IL_01c4;
					case JavaStep.Java:
						goto IL_0252;
					case JavaStep.GameProcess:
						goto IL_0392;
					case JavaStep.GameVersion:
						goto IL_03e1;
					}
					goto case 26;
				case 32:
					goto IL_017c;
				case 14:
					goto IL_01c4;
				case 38:
					if (P_0 != EnumStepPhase.Install)
					{
						obj2 = 37;
						continue;
					}
					goto case 24;
				case 22:
					obj = Mass.Game.Launcher.Authenticator.ReflectMonoObject();
					obj2 = 31;
					continue;
				case 40:
					goto IL_021e;
				case 25:
				case 37:
					if (P_1 != JavaStep.GameProcess)
					{
						obj2 = 27;
						continue;
					}
					goto IL_0392;
				case 4:
				case 7:
				case 8:
				case 12:
				case 13:
				case 15:
				case 17:
				case 18:
				case 20:
				case 21:
				case 29:
				case 30:
				case 31:
				case 33:
				case 41:
					return obj;
				default:
					goto IL_0252;
				case 23:
					goto IL_0278;
				case 34:
					goto IL_0289;
				case 35:
					((AsyncTaskMethodBuilder*)(&obj))->SetResult();
					obj = (object)/*Error near IL_02b2: Stack underflow*/;
					obj2 = 21;
					continue;
				case 11:
					goto IL_02cb;
				case 10:
					((Authenticator._003CReceiveAsync_003Ed__9*)(&obj))->SetStateMachine((IAsyncStateMachine)this);
					((FeverInstaller)/*Error near IL_02fe: Stack underflow*/).FeverRequest<EntityFeverManifestInfo>((RestRequest)/*Error near IL_02fe: Stack underflow*/);
					_ = 35;
					continue;
				case 3:
				case 6:
				case 19:
					((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)/*Error near IL_0362: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_0362: Stack underflow*/);
					obj = (object)/*Error near IL_0364: Stack underflow*/;
					obj2 = 13;
					continue;
				case 16:
					goto IL_0392;
				case 1:
					_ = ref obj;
					((TaskAwaiter<string>*)FeverInstaller.McBedrock)->GetResult();
					_ = 10;
					if ((int)((FeverInstaller._003CFeverRequest_003Ed__15<>*)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						_ = 5;
					}
					continue;
				case 5:
					goto IL_03e1;
				case 27:
					if (P_1 != JavaStep.GameWindow)
					{
						obj2 = 19;
						if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E1__state)->_003C_003Et__builder == 0)
						{
							obj2 = 15;
						}
						continue;
					}
					goto IL_01c4;
				case 24:
					switch (P_1)
					{
					case JavaStep.Java:
						break;
					case JavaStep.BaseVersion:
						goto IL_021e;
					case JavaStep.GameVersion:
						goto IL_0278;
					case JavaStep.Components:
						goto IL_0289;
					case JavaStep.CoreLib:
						goto IL_02cb;
					default:
						goto IL_046b;
					case JavaStep.ServerResource:
						goto IL_0475;
					}
					goto case 22;
				case 2:
					goto IL_0475;
					IL_0392:
					((FeverInstaller)/*Error near IL_0397: Stack underflow*/)._002Ector((string)/*Error near IL_0397: Stack underflow*/, (string)/*Error near IL_0397: Stack underflow*/, (string)/*Error near IL_0397: Stack underflow*/);
					obj = (object)/*Error near IL_0399: Stack underflow*/;
					obj2 = 7;
					continue;
					IL_0252:
					((Authenticator._003CListenAsync_003Ed__7*)/*Error near IL_0257: Stack underflow*/)->MoveNext();
					obj = (object)/*Error near IL_0259: Stack underflow*/;
					obj2 = 20;
					if (((Authenticator._003CReceiveAsync_003Ed__9)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9._003C_003Et__builder)._003C_003E4__this != null)
					{
						obj2 = 0;
					}
					continue;
					IL_0139:
					((Authenticator)/*Error near IL_013e: Stack underflow*/).StartListening((int)/*Error near IL_013e: Stack underflow*/);
					obj = (object)/*Error near IL_0140: Stack underflow*/;
					obj2 = 15;
					continue;
					IL_01c4:
					_ = ref obj;
					_ = 12;
					_ = 1;
					AsyncTaskMethodBuilder.Create();
					_ = 1;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
					{
						_ = 1;
					}
					continue;
					IL_0111:
					((Authenticator)/*Error near IL_0116: Stack underflow*/).Listener = (TcpListener?)/*Error near IL_0116: Stack underflow*/;
					obj = (object)/*Error near IL_0118: Stack underflow*/;
					obj = 8;
					break;
					IL_0475:
					obj = FeverInstaller.CheckScopeSummarizer();
					obj2 = 30;
					continue;
					IL_046b:
					obj2 = 25;
					continue;
					IL_02cb:
					obj = Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateGenericStruct();
					obj2 = 11;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Et__builder).client != null)
					{
						obj2 = 12;
					}
					continue;
					IL_017c:
					obj = ((Authenticator)/*Error near IL_0181: Stack underflow*/).ListenAsync();
					obj2 = 18;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state != 0)
					{
						obj2 = 18;
					}
					continue;
					IL_0289:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)/*Error near IL_028e: Stack underflow*/)->MoveNext();
					obj = (object)/*Error near IL_0290: Stack underflow*/;
					obj2 = 33;
					continue;
					IL_0278:
					obj = Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.ObserveTracker();
					obj2 = 17;
					continue;
					IL_021e:
					obj = Mass.Game.Launcher.Authenticator.PatchUser();
					obj2 = 29;
					continue;
					IL_03e1:
					obj = ((FeverInstaller)/*Error near IL_03e6: Stack underflow*/).GetFeverManifestAsync((object)/*Error near IL_03e6: Stack underflow*/);
					obj2 = 33;
					if ((int)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller._003CFeverRequest_003Ed__15<>.request)->_003C_003Eu__1 == 0)
					{
						obj2 = 41;
					}
					continue;
					IL_0172:
					obj2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00쌀(EnumStepPhase P_0, JavaStep P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778795, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00쐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778794, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00씀()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_003d: Expected native int or pointer, but got Obj
		//IL_007a: Expected native int or pointer, but got Obj
		//IL_0084->IL0026: Incompatible stack heights: 2 vs 1
		//IL_005d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				if (((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state == 0)
				{
					obj2 = 1;
					if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 1;
					}
					break;
				}
				((TcpListener)(object)this).Start();
				_ = 0;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 1:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00였()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778793, new IntPtr(2737337594924L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00윀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4759, 1790778792, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778792, new IntPtr(2737337585564L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00저()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778791, new IntPtr(2737337583484L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00준(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected I4, but got Obj
		//IL_003b: Expected native int or pointer, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00쨀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778790, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00촀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778789, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00츀()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00ab: Expected native int or pointer, but got Obj
		//IL_00ba: Expected Ref, but got VT
		//IL_00c4: Expected native int or pointer, but got Obj
		//IL_006a: Expected I4, but got Obj
		//IL_0075: Expected Obj, but got VT
		//IL_0075: Expected native int or pointer, but got Obj
		//IL_0084: Expected Obj, but got VT
		//IL_008e: Expected native int or pointer, but got Obj
		//IL_0295: Expected Obj, but got I
		//IL_017d: Expected native int or pointer, but got Obj
		//IL_0182: Expected native int or pointer, but got Obj
		//IL_018d: Expected native int or pointer, but got Obj
		//IL_01e5: Expected native int or pointer, but got Obj
		//IL_01f5: Expected native int or pointer, but got Obj
		//IL_014e: Expected Obj, but got I4
		//IL_0162: Expected native int or pointer, but got Obj
		//IL_011a: Expected native int or pointer, but got Obj
		//IL_0098->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01b0->IL00dd: Incompatible stack heights: 3 vs 2
		//IL_016c->IL00dd: Incompatible stack heights: 3 vs 2
		//IL_01da->IL00dd: Incompatible stack heights: 1 vs 2
		//IL_01bb->IL00dd: Incompatible stack heights: 3 vs 2
		//IL_0177->IL00dd: Incompatible stack heights: 3 vs 2
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				obj2 = 2;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					obj2 = 2;
				}
				break;
			case 1:
				((Authenticator)/*Error near IL_006a: Stack underflow*/).StartListening((int)this);
				GC.SuppressFinalize(((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)((Authenticator)((Authenticator._003CListenAsync_003Ed__7)/*Error near IL_006f: Stack underflow*/)._003C_003Eu__1).ListenAuthenticationConnectAsync((object)this))->_003C_003E1__state)->_003C_003Et__builder);
				obj2 = 0;
				if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
				return;
			default:
			{
				object obj3 = this;
				((TaskAwaiter*)((Authenticator._003CReceiveAsync_003Ed__9*)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Mass.Game.Launcher.Authenticator.PatchUser())->_003C_003E1__state)->_003C_003Et__builder)->GetResult();
				int num2 = 1;
				if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9.client)->_003C_003Eu__1 != 0)
				{
					num2 = 4;
				}
				while (true)
				{
					switch (num2)
					{
					case 5:
					{
						((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)obj3)->SetStateMachine((IAsyncStateMachine)this);
						AsyncTaskMethodBuilder asyncTaskMethodBuilder = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)/*Error near IL_010a: Stack underflow*/)._003C_003E1__state)->_003C_003Et__builder;
						((Authenticator._003CReceiveAsync_003Ed__9*)this)->MoveNext();
						obj3 = ((TaskAwaiter<TcpClient>*)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(&asyncTaskMethodBuilder))->_003C_003E4__this)->_003Cstream_003E5__2)->GetResult();
						num2 = 0;
						if (((FeverInstaller)Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway)._003CfeverVersion_003EP != null)
						{
							num2 = 1;
						}
						continue;
					}
					case 3:
						((TcpClient)FeverInstaller.McBedrock__BackingField).Close();
						_ = 2;
						if (((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller.ReflectVisualArgument)->_003C_003E1__state != 0)
						{
							_ = 1;
						}
						continue;
					case 1:
						_ = ((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)((FeverInstaller)(object)this).InstallAsync())->_003C_003E4__this)->request;
						((RestClient)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)((FeverInstaller)(object)this).GetFeverAppVersionAsync())->_003C_003E1__state)->_003C_003Et__builder).Dispose();
						_ = 0;
						if (FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor != null)
						{
							_ = 0;
						}
						continue;
					case 4:
						((FeverInstaller._003CFeverRequest_003Ed__15<>*)obj3)->SetStateMachine((IAsyncStateMachine)this);
						((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)/*Error near IL_01d0: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)/*Error near IL_01c6: Stack underflow*/)._003C_003Et__builder)._003C_003E4__this);
						_ = 3;
						continue;
					case 2:
					{
						((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)obj3)->SetStateMachine((IAsyncStateMachine)this);
						int num3 = ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReflectReporter)->_003C_003E1__state;
						((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)this)->MoveNext();
						_ = ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)num3)->_003C_003E4__this)->version;
						/*Error near IL_01fa: Member reference must be method, but was: Field*/;
					}
					}
					break;
				}
				goto case 3;
			}
			case 2:
			{
				((AsyncTaskMethodBuilder<_00210>*)this)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)((Rpc)((Rpc)FeverInstaller._003CInstallAsync_003Ed__11.SerializeResponder()).ProcessId__BackingField).Logger__BackingField, ref *(TStateMachine*)new Rpc
				{
					NeedCha = (((Rpc)(object)this).UseCha__BackingField != 9)
				});
				((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_02b7: Stack underflow*/)->SetException((Exception)/*Error near IL_02b7: Stack underflow*/);
				int num = 0;
				if (((Rpc)Mass.Game.Launcher.Rpc._chaChaEn)._chaChaDe == null)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
				return;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00케()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778788, new IntPtr(2737337576204L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00퀀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4768, 1790778787, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778787, new IntPtr(2737337586604L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00턀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778786, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00툀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778785, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00팀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4771, 1790778784, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778784, new IntPtr(2737337582444L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00퐀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778719, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00픀(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003b: Expected native int or pointer, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00혀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778718, new IntPtr(2737337583484L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00휀(nint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_004c: Expected VT, but got I4
		//IL_0056: Expected native int or pointer, but got Obj
		//IL_0079: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I4
		//IL_0088: Expected native int or pointer, but got Obj
		//IL_0060->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0026: Incompatible stack heights: 3 vs 1
		//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0026: Incompatible stack heights: 3 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
			default:
				Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)P_0)->_003C_003Et__builder, (AsyncTaskMethodBuilder)(((Authenticator._003CListenAsync_003Ed__7*)P_0)->_003C_003E1__state + 25));
				obj2 = 2;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					obj2 = 2;
				}
				break;
			case 1:
				((Authenticator)4).ReceiveAuthenticationDataAsync(((Authenticator)7).ReceiveAsync(Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton));
				_ = 0;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FFFD()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778717, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00b4: Expected Obj, but got I4
		//IL_00bf: Expected native int or pointer, but got Obj
		//IL_00cf: Expected Obj, but got I
		//IL_006c: Expected native int or pointer, but got Obj
		//IL_00be->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00e3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0060->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ee->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a5->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
			case 4:
				obj = obj;
				obj2 = 2;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder != 0)
				{
					obj2 = 0;
				}
				break;
			case 5:
				obj = ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E4__this;
				obj2 = 4;
				break;
			case 1:
				if (obj == obj)
				{
					obj2 = 0;
					if (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 4;
			case 2:
				obj = (int)((AsyncTaskMethodBuilder*)P_0)->Task;
				_ = 3;
				break;
			case 3:
			{
				TcpListener* ptr = &((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->listener;
				((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)obj)->Start(ref *(FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)obj);
				obj = (object)ptr;
				obj2 = 1;
				if (Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
				{
					obj2 = 0;
				}
				break;
			}
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected I4, but got Obj
		//IL_003b: Expected native int or pointer, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778716, new IntPtr(2737337584524L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FFFD(JavaStep P_0, object P_1, object P_2, object P_3, object P_4, object P_5, CancellationToken P_6, object P_7, object P_8)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778715, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FFFD(JavaStep P_0, object P_1, object P_2, object P_3, object P_4, object P_5, CancellationToken P_6, object P_7, object P_8)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0063: Expected I4, but got Obj
		//IL_0142: Expected VT, but got Obj
		//IL_019d: Expected native int or pointer, but got Obj
		//IL_0090: Expected VT, but got Obj
		//IL_011a: Expected VT, but got Obj
		//IL_0124: Expected native int or pointer, but got Obj
		//IL_017b: Expected Obj, but got Ref
		//IL_00ce: Expected Obj, but got VT
		//IL_016f: Expected Obj, but got I4
		//IL_0088->IL0026: Incompatible stack types: I4 vs Obj
		//IL_014c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ad->IL0026: Incompatible stack types: I4 vs Obj
		//IL_015e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_012e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0111->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_018a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01b2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0139->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ff->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 10;
		while (true)
		{
			object obj = stateMachine;
			while (true)
			{
				switch ((int)obj)
				{
				case 12:
					((Func<Task>)/*Error near IL_0074: Stack underflow*/)._002Ector((object)/*Error near IL_0074: Stack underflow*/, (nint)(&((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003E1__state));
					return (object)/*Error near IL_0075: Stack underflow*/;
				default:
					((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003E4__this = (Authenticator)P_8;
					obj = 13;
					continue;
				case 6:
					((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003Eu__1 = (TaskAwaiter)P_1;
					obj = 3;
					continue;
				case 2:
					Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton = P_3;
					obj = 5;
					continue;
				case 4:
					((AsyncTaskMethodBuilder*)(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->_003C_003E1__state))->Start(ref *(FeverInstaller._003CInstallAsync_003Ed__11*)(&stateMachine));
					obj = 12;
					continue;
				case 11:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->listener = (TcpListener)P_6;
					obj = 7;
					continue;
				case 9:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->_003C_003E4__this = (Authenticator)(object)this;
					obj = 7;
					if (Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler != null)
					{
						obj = 8;
					}
					continue;
				case 8:
					((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->_003C_003E1__state = (int)P_0;
					obj = 6;
					continue;
				case 7:
					((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->_003C_003Et__builder = (AsyncTaskMethodBuilder)P_7;
					obj = 0;
					if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9._003C_003E4__this)->client != null)
					{
						obj = 0;
					}
					continue;
				case 1:
					((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->_003C_003Eu__1 = (TaskAwaiter)P_5;
					obj = 11;
					continue;
				case 3:
					Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain = P_2;
					obj = 2;
					continue;
				case 13:
					break;
				case 10:
					((AsyncTaskMethodBuilder*)/*Error near IL_017b: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)(&stateMachine));
					Unsafe.Write(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)/*Error near IL_0180: Stack underflow*/)->client, /*Error near IL_0180: Stack underflow*/);
					obj = 9;
					continue;
				case 5:
					((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(&stateMachine))->_003C_003E4__this = (Authenticator)P_4;
					obj = 1;
					if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003Cstream_003E5__2)->_003C_003Eu__1 != 0)
					{
						obj = 1;
					}
					continue;
				}
				break;
			}
			((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(&stateMachine))->_003C_003E1__state = -1;
			stateMachine = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FFFD(JavaStep P_0, object P_1, object P_2, object P_3, object P_4, object P_5, CancellationToken P_6, object P_7, object P_8)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778714, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_E000(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4784, 1790778713, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790778713, new IntPtr(2737337588684L), 15);
		}
		return ((delegate*<object, object, object, object>)obj)(this, P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_E100(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778712, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_E200()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_001b: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_E400()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004f: Expected I4, but got Obj
		//IL_0191: Expected native int or pointer, but got Obj
		//IL_0196: Expected native int or pointer, but got Obj
		//IL_01a6: Expected native int or pointer, but got Obj
		//IL_01ba: Expected native int or pointer, but got Obj
		//IL_0064: Expected I4, but got Obj
		//IL_006f: Expected Obj, but got VT
		//IL_006f: Expected native int or pointer, but got Obj
		//IL_007e: Expected Ref, but got VT
		//IL_0088: Expected native int or pointer, but got Obj
		//IL_0167: Expected native int or pointer, but got Obj
		//IL_0172: Expected native int or pointer, but got Obj
		//IL_01d0: Expected native int or pointer, but got Obj
		//IL_01d6: Invalid comparison between VT and I4
		//IL_0101: Expected native int or pointer, but got Obj
		//IL_01c4->IL0026: Incompatible stack heights: 6 vs 1
		//IL_0092->IL0026: Incompatible stack types: I4 vs Obj
		//IL_018b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01cf->IL0026: Incompatible stack heights: 6 vs 1
		//IL_0155->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01e5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0160->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00eb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0116->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 8;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				((Authenticator)/*Error near IL_005e: Stack underflow*/).Listener = ((Authenticator)/*Error near IL_0059: Stack underflow*/).Listener;
				((Authenticator)/*Error near IL_0064: Stack underflow*/).StartListening((int)this);
				((AsyncTaskMethodBuilder<EntityFeverManifest>*)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)((Authenticator)((Authenticator._003CListenAsync_003Ed__7)/*Error near IL_0069: Stack underflow*/)._003C_003Eu__1).ListenAuthenticationConnectAsync((object)this))->_003C_003E1__state)->Start(ref *(FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)AsyncTaskMethodBuilder.Create());
				obj2 = 3;
				if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					obj2 = 5;
				}
				break;
			default:
				Mass.Game.Launcher.Authenticator.PatchUser();
				throw new Task();
			case 7:
				return;
			case 4:
				return;
			case 2:
			{
				((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9.DecorateConvertibleParameter())->MoveNext();
				((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)/*Error near IL_0127: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)this);
				object obj3 = ((FeverInstaller)/*Error near IL_012c: Stack underflow*/)._003CappId_003EP;
				((TcpClient)FeverInstaller.McBedrock__BackingField).Close();
				((AsyncTaskMethodBuilder*)obj3)->Start(ref *(Rpc._003CReceiveAsync_003Ed__28*)this);
				obj2 = 1;
				if ((int)((FeverInstaller._003CFeverRequest_003Ed__15<>*)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					obj2 = 0;
				}
				break;
			}
			case 6:
				return;
			case 5:
				((RestClient)/*Error near IL_017c: Stack underflow*/)._002Ector((RestClientOptions)/*Error near IL_017c: Stack underflow*/, (ConfigureHeaders)/*Error near IL_017c: Stack underflow*/, (ConfigureSerialization)(object)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)((FeverInstaller)/*Error near IL_0167: Stack underflow*/).GetFeverManifestAsync((object)this))->request, (byte)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)((FeverInstaller)(object)this).GetFeverAppVersionAsync())->_003C_003E1__state != 0);
				((RestClient)/*Error near IL_0181: Stack underflow*/).Dispose();
				obj2 = 6;
				break;
			case 1:
				_ = ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor)->_003C_003E1__state;
				_ = ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(FeverInstaller._003CFeverRequest_003Ed__15<>.CheckAdaptableResponder() ? 1 : 0))->_003C_003E4__this)->info;
				AsyncTaskMethodBuilder<EntityFeverAppVersion>.Create();
				_ = 3;
				if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReflectReporter)->_003C_003E1__state == 0)
				{
					_ = 0;
				}
				break;
			case 8:
				if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)this)->_003C_003Et__builder != (AsyncTaskMethodBuilder<EntityFeverManifestInfo>)(object)2)
				{
					obj2 = 7;
					break;
				}
				((Authenticator._003CReceiveAsync_003Ed__9*)this)->MoveNext();
				if ((int)/*Error near IL_00f7: Stack underflow*/ != 0)
				{
					((Authenticator._003CListenAsync_003Ed__7*)/*Error near IL_00bd: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)this);
					((ILogger)/*Error near IL_00c7: Stack underflow*/).Error((Exception)/*Error near IL_00c7: Stack underflow*/, (string)(object)((Authenticator._003CReceiveAsync_003Ed__9)/*Error near IL_00c2: Stack underflow*/)._003C_003E4__this);
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)this)->MoveNext();
					((IAsyncStateMachine)/*Error near IL_00d7: Stack underflow*/).SetStateMachine((IAsyncStateMachine)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain);
					((AsyncTaskMethodBuilder*)/*Error near IL_00dc: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_00dc: Stack underflow*/);
					if ((int)/*Error near IL_00e1: Stack underflow*/ != 0)
					{
						return;
					}
					obj2 = 2;
				}
				else
				{
					obj2 = 0;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E4__this)->_003Cstream_003E5__2 != null)
					{
						obj2 = 0;
					}
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_E500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778711, new IntPtr(2737337576204L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_E600()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_001b: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_E700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778710, new IntPtr(2737337584524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_E800(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0042: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I4
		//IL_0051: Expected native int or pointer, but got Obj
		//IL_005b->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0066->IL0026: Incompatible stack heights: 3 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
			case 0:
				return;
			case 1:
				_ = 1;
				((Authenticator)1).Listener = ((Authenticator)P_0).Listener;
				_ = 0;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_E900(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0056->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0061->IL0026: Incompatible stack heights: 3 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
			case 0:
				return;
			case 1:
				_ = ((Authenticator)P_1).Listener;
				_ = 0;
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_F100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778709, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_F200()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0077: Expected I4, but got Obj
		//IL_00a9: Expected Obj, but got I4
		//IL_0083: Expected I4, but got Obj
		//IL_007e: Expected native int or pointer, but got Obj
		//IL_05ef: Expected native int or pointer, but got Obj
		//IL_05fe: Expected native int or pointer, but got Obj
		//IL_0746: Expected Obj, but got I
		//IL_0508: Expected native int or pointer, but got Obj
		//IL_00b5: Expected native int or pointer, but got Obj
		//IL_0302: Expected native int or pointer, but got Obj
		//IL_036e: Expected native int or pointer, but got Obj
		//IL_032f: Expected native int or pointer, but got Obj
		//IL_0553: Expected Obj, but got I4
		//IL_055d: Expected native int or pointer, but got Obj
		//IL_07a3: Expected I4, but got Obj
		//IL_07b2: Expected Obj, but got I
		//IL_0773: Expected Obj, but got I
		//IL_01e3: Expected native int or pointer, but got Obj
		//IL_010f: Expected native int or pointer, but got Obj
		//IL_00b3->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0097->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0608->IL0026: Incompatible stack types: I4 vs Obj
		//IL_074b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ba->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0506->IL0026: Incompatible stack types: I4 vs Obj
		//IL_040f->IL0026: Incompatible stack heights: 4 vs 1
		//IL_030c->IL0026: Incompatible stack heights: 4 vs 1
		//IL_071f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0730->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0339->IL0348: Incompatible stack heights: 2 vs 4
		//IL_0613->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0756->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01c5->IL0026: Incompatible stack heights: 4 vs 1
		//IL_02e6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0528->IL0537: Incompatible stack heights: 1 vs 2
		//IL_0317->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0344->IL0348: Incompatible stack heights: 2 vs 4
		//IL_02f1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0533->IL0537: Incompatible stack heights: 1 vs 2
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 10;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)null;
				obj2 = 8;
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj2 = 2;
				}
				continue;
			case 1:
				((Authenticator)0).ListenAsync();
				_ = 18;
				continue;
			case 12:
			{
				object obj3 = Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton;
				int num3;
				if (obj3 == null)
				{
					num3 = 1;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						num3 = 1;
					}
				}
				else
				{
					GC.SuppressFinalize(obj3);
					num3 = 0;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						num3 = 0;
					}
				}
				switch (num3)
				{
				}
				goto case 2;
			}
			case 7:
				_ = null;
				Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateGenericStruct();
				_ = 2;
				if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Et__builder).client == null)
				{
					_ = 14;
				}
				continue;
			case 11:
				return;
			case 14:
			{
				((Authenticator._003CReceiveAsync_003Ed__9*)/*Error near IL_01cd: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)this);
				int num8;
				if ((int)/*Error near IL_01cd: Stack underflow*/ == 0)
				{
					num8 = 0;
					if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003Cstream_003E5__2)->_003C_003Eu__1 != 0)
					{
						num8 = 0;
					}
				}
				else
				{
					((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)/*Error near IL_0218: Stack underflow*/)->MoveNext();
					num8 = 0;
					if (((FeverInstaller)FeverInstaller._003CfeverVersion_003EP)._003CappId_003EP != null)
					{
						num8 = 1;
					}
				}
				switch (num8)
				{
				}
				break;
			}
			case 9:
				if (((FeverInstaller)/*Error near IL_02cd: Stack underflow*/).FeverRequest<T>((RestRequest)(object)this) == null)
				{
					obj2 = 2;
					if (((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 6;
					}
					continue;
				}
				goto case 17;
			case 16:
				_ = null;
				FeverInstaller.CheckStaticProgram();
				_ = 0;
				if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor)->_003C_003E1__state == 0)
				{
					_ = 0;
				}
				continue;
			case 3:
			{
				int num5;
				if (!FeverInstaller._003CFeverRequest_003Ed__15<>.CheckAdaptableResponder())
				{
					_ = 1;
					if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E4__this)->info == null)
					{
						_ = 1;
					}
				}
				else
				{
					AsyncTaskMethodBuilder<EntityFeverAppVersion>.Create();
					num5 = 0;
					if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReflectReporter)->_003C_003E1__state != 0)
					{
						num5 = 0;
					}
				}
				switch (num5)
				{
				}
				goto case 15;
			}
			case 15:
				_ = null;
				FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.DecorateGroupedVisitor();
				_ = 13;
				continue;
			case 6:
				((FeverInstaller._003CInstallAsync_003Ed__11*)this)->MoveNext();
				if ((int)/*Error near IL_0416: Stack underflow*/ == 0)
				{
					int num4 = 0;
					if ((int)((FeverInstaller._003CInstallAsync_003Ed__11)FeverInstaller._003CInstallAsync_003Ed__11._003C_003Eu__2)._003C_003Eu__3 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					}
					goto case 17;
				}
				/*Error near IL_0457: Member reference must be method, but was: Field*/;
			case 8:
				((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)/*Error near IL_04fc: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_04fc: Stack underflow*/, ref *(TStateMachine*)this);
				obj2 = 11;
				continue;
			case 10:
			{
				int num6 = ((Rpc._003CListenAsync_003Ed__34*)(nint)this)->_003C_003E1__state;
				int num7;
				if (num6 == 0)
				{
					_ = 1;
					if (((Rpc._003CListenAsync_003Ed__34)Mass.Game.Launcher.Rpc._003CListenAsync_003Ed__34._003C_003Et__builder)._003C_003E4__this != null)
					{
						_ = 0;
					}
				}
				else
				{
					((Task<EntityFeverApp>)num6).GetAwaiter();
					num7 = 0;
					if (((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)Mass.Game.Launcher.Rpc._003CListenAsync_003Ed__34.DecorateIterableWriter)->_003C_003E1__state == 0)
					{
						num7 = 0;
					}
				}
				switch (num7)
				{
				}
				goto case 9;
			}
			case 4:
				Unsafe.Write(&((Rpc._003CReceiveAsync_003Ed__28*)(nint)this)->client, null);
				obj2 = 6;
				if (Mass.Game.Launcher.Rpc._003CReceiveAsync_003Ed__28.CheckMonoProgram == null)
				{
					obj2 = 12;
				}
				continue;
			default:
			{
				((Rpc._003CListenAsync_003Ed__34*)/*Error near IL_061a: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)this);
				int num2;
				if ((int)/*Error near IL_061a: Stack underflow*/ == 0)
				{
					num2 = 0;
					if (((Rpc._003CRemoteCallBackAsync_003Ed__21)Mass.Game.Launcher.Rpc._003CRemoteCallBackAsync_003Ed__21._003C_003Et__builder)._003C_003E4__this == null)
					{
						num2 = 0;
					}
				}
				else
				{
					((Rpc._003CListenControlConnectAsync_003Ed__35*)/*Error near IL_0665: Stack underflow*/)->MoveNext();
					num2 = 1;
					if (Mass.Game.Launcher.Rpc._003CRemoteCallBackAsync_003Ed__21.MeasureCalc == null)
					{
						num2 = 1;
					}
				}
				switch (num2)
				{
				}
				goto case 7;
			}
			case 17:
				obj2 = 3;
				continue;
			case 18:
				((Rpc._003CSyncChaChaAsync_003Ed__38*)null)->MoveNext();
				_ = 4;
				continue;
			case 5:
				break;
			case 13:
			{
				string skinPath = ((CppGameValue)(object)this).SkinPath;
				int num;
				if (skinPath == null)
				{
					num = 0;
					if (((JavaGameValue)JavaGameValue.SetGuiScale__BackingField).GuiScale__BackingField != 0)
					{
						num = 0;
					}
				}
				else
				{
					((Salsa20Engine)/*Error near IL_07a3: Stack underflow*/).ProcessBytes((byte[])/*Error near IL_07a3: Stack underflow*/, (int)/*Error near IL_07a3: Stack underflow*/, (int)/*Error near IL_07a3: Stack underflow*/, (byte[])/*Error near IL_07a3: Stack underflow*/, (int)skinPath);
					num = 1;
					if (((JavaGameValue)JavaGameValue.WindowWidth__BackingField).WindowHeight__BackingField == 0)
					{
						num = 1;
					}
				}
				switch (num)
				{
				}
				goto case 16;
			}
			}
			((Rpc._003CSyncChaChaAsync_003Ed__38*)this)->SetStateMachine((IAsyncStateMachine)null);
			obj2 = 0;
			if (((JavaGameValue)JavaGameValue.ReconnectDelay__BackingField).SaveOptions__BackingField == 0)
			{
				obj2 = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_F300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778708, new IntPtr(2737337578284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_F400(CancellationToken P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00a3: Expected Obj, but got Ref
		//IL_00ee: Expected Obj, but got I4
		//IL_0050: Expected I4, but got VT
		//IL_00e6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00bc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0091->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009c->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 1;
		object obj = stateMachine;
		while (true)
		{
			switch ((int)obj)
			{
			case 4:
				((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003E1__state = (int)P_0;
				obj = 3;
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
				{
					obj = 1;
				}
				break;
			case 5:
				((AsyncTaskMethodBuilder*)/*Error near IL_007d: Stack underflow*/)->AwaitUnsafeOnCompleted(ref ((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003Eu__1, ref *(Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine));
				obj = 2;
				if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder != 0)
				{
					obj = 2;
				}
				break;
			case 1:
				GC.SuppressFinalize((object)(&stateMachine));
				Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)/*Error near IL_00a8: Stack underflow*/)->_003C_003E4__this, /*Error near IL_00a8: Stack underflow*/);
				obj = 0;
				if (Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
				{
					obj = 0;
				}
				break;
			case 2:
				((AsyncTaskMethodBuilder*)/*Error near IL_00d3: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_00d3: Stack underflow*/, ref *(TStateMachine*)(&((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->_003C_003E1__state));
				return (object)/*Error near IL_00d4: Stack underflow*/;
			default:
				((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->_003C_003E4__this = (Authenticator)(object)this;
				obj = 4;
				break;
			case 3:
				((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->client = (TcpClient)(-1);
				obj = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_F500(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778707, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_F600(byte P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003b: Expected native int or pointer, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_F700(JavaStep P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003a: Expected native int or pointer, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)P_0;
				obj2 = 0;
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
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
	private unsafe void _FF00_FF00_FF00切()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778706, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00ﬀ()
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
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitStLoc(StLoc inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 855
		//    at ICSharpCode.Decompiler.IL.StLoc.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2590
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitStLoc(StLoc inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 129
		//    at ICSharpCode.Decompiler.IL.StLoc.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2586
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitIfInstruction(IfInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 163
		//    at ICSharpCode.Decompiler.IL.IfInstruction.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 1440
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
	private unsafe object _FF00_FF00_FF00ﰀ(CancellationToken P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0050: Expected I4, but got Obj
		//IL_00bc: Expected Obj, but got Ref
		//IL_0084: Expected I4, but got VT
		//IL_00ab: Expected Obj, but got I4
		//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0098->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a3->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 1;
		object obj = stateMachine;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003E1__state = (int)this;
				obj = 2;
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj = 2;
				}
				break;
			case 4:
				((AsyncTaskMethodBuilder*)/*Error near IL_007b: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)(&((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003Eu__1));
				return (object)/*Error near IL_007c: Stack underflow*/;
			case 2:
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->_003C_003E1__state = (int)P_0;
				obj = 3;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener == null)
				{
					obj = 3;
				}
				break;
			case 3:
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->_003C_003E4__this = (Authenticator)(-1);
				obj = 5;
				break;
			case 1:
				((IAsyncStateMachine)(&stateMachine)).MoveNext();
				Unsafe.Write(&Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler, /*Error near IL_00c1: Stack underflow*/);
				obj = 0;
				if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					obj = 0;
				}
				break;
			case 5:
				((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)/*Error near IL_00ee: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverApp>*)(&((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->_003C_003E4__this), ref *(FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(&stateMachine));
				obj = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FE00()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected native int or pointer, but got Obj
		//IL_004a: Expected I4, but got Obj
		//IL_004a: Expected Obj, but got VT
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 1:
		{
			((Authenticator)((Authenticator._003CListenAsync_003Ed__7*)(nint)((Authenticator)(object)this).Listener)->_003C_003Et__builder).StartListening((int)this);
			_ = ((AsyncTaskMethodBuilder*)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->Task;
			int num = 0;
			if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener == null)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
			break;
		}
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778705, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00Ȁ(EnumStepPhase P_0, JavaStep P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778704, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_0300(EnumStepPhase P_0, JavaStep P_1, object P_2)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_009e: Expected native int or pointer, but got Obj
		//IL_00c0: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I4
		//IL_00a8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00db->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00b3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e6->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0104->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006d->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 5:
				if (P_0 != EnumStepPhase.Error)
				{
					obj2 = 4;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						obj2 = 4;
					}
					break;
				}
				goto default;
			default:
				obj = P_2;
				obj2 = 2;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				((Authenticator)/*Error near IL_00b8: Stack underflow*/).ReceiveAuthenticationDataAsync((object)/*Error near IL_00b8: Stack underflow*/);
				((Authenticator)P_1).Dispose();
				((TcpListener)P_0).Dispose();
				obj = this;
				_ = 0;
				if (Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler != null)
				{
					_ = 1;
				}
				break;
			case 1:
			case 2:
				return obj;
			case 4:
				if (P_0 == EnumStepPhase.Complete)
				{
					obj2 = 0;
					if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder != 0)
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
	private unsafe void _FF00_FF00_FF00_FF00Ѐ()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_00bf: Expected Obj, but got Ref
		//IL_00c4: Expected Obj, but got VT
		//IL_00f2: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I4
		//IL_0096: Expected native int or pointer, but got Obj
		//IL_0107: Expected Obj, but got I4
		//IL_00f7->IL0022: Incompatible stack heights: 6 vs 0
		//IL_00a0->IL0026: Incompatible stack heights: 3 vs 1
		//IL_013d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011b->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ab->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0126->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0076->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 1;
		while (true)
		{
			object obj = stateMachine;
			while (true)
			{
				switch ((int)obj)
				{
				case 1:
					if (((Authenticator)(object)this).Listener != null)
					{
						obj = 0;
						if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
						{
							obj = 0;
						}
						continue;
					}
					return;
				case 5:
					((Authenticator)1).ListenAsync();
					_ = 2;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
					{
						_ = 0;
					}
					continue;
				case 2:
					break;
				case 4:
					return;
				default:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)99)->MoveNext();
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)4)->SetStateMachine((IAsyncStateMachine)8);
					_ = 6;
					if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						_ = 4;
					}
					continue;
				case 3:
					return;
				case 6:
					((Authenticator._003CReceiveAsync_003Ed__9*)this)->MoveNext();
					((TcpListener)/*Error near IL_0132: Stack underflow*/).AcceptTcpClientAsync();
					obj = 5;
					continue;
				}
				break;
			}
			_ = 5;
			_ = 8;
			_ = 0;
			_ = ref stateMachine;
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			((Authenticator)(&stateMachine)).Dispose();
			((TcpListener)asyncTaskMethodBuilder).Dispose();
			((AsyncTaskMethodBuilder<_0021_00210>*)this)->Start(ref *(Mass.Game.Launcher.Authenticator.ReflectMonoObject() ? ((FeverInstaller._003CFeverRequest_003Ed__15<_0021_00210>*)1) : ((FeverInstaller._003CFeverRequest_003Ed__15<_0021_00210>*)null)));
			((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->MoveNext();
			((AsyncTaskMethodBuilder*)7)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)1, ref *(TStateMachine*)(&stateMachine));
			((TaskAwaiter*)(&stateMachine))->GetResult();
			Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.ObserveTracker();
			stateMachine = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_0600()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_001b: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_0700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778703, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00ࠀ(EnumStepPhase P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778702, new IntPtr(2737337579324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_0900(EnumStepPhase P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003b: Expected native int or pointer, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_0A00(EnumStepPhase P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778701, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_0B00(CancellationToken P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778700, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_0C00(CancellationToken P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00e7: Expected native int or pointer, but got Obj
		//IL_008f: Expected I4, but got Obj
		//IL_00b5: Expected Obj, but got Ref
		//IL_00c3: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got Ref
		//IL_00d5: Expected Obj, but got VT
		//IL_00f1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 3;
		while (true)
		{
			object obj = stateMachine;
			while (true)
			{
				switch ((int)obj)
				{
				case 1:
					((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003E1__state = -1;
					obj = 5;
					continue;
				case 5:
					((AsyncTaskMethodBuilder*)/*Error near IL_0068: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003Et__builder), ref *(Authenticator._003CListenAsync_003Ed__7*)(&stateMachine));
					obj = 0;
					if (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
					{
						obj = 4;
					}
					continue;
				case 2:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->_003C_003E1__state = (int)this;
					obj = 0;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener == null)
					{
						obj = 0;
					}
					continue;
				case 3:
					break;
				case 4:
					return ((Task)(&Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)).GetAwaiter();
				default:
					((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->_003C_003Et__builder = (AsyncTaskMethodBuilder)P_0;
					obj = 0;
					if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9._003C_003E4__this)->client == null)
					{
						obj = 1;
					}
					continue;
				}
				break;
			}
			((TcpListener)(&stateMachine)).Dispose();
			Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)/*Error near IL_00ba: Stack underflow*/)->_003C_003Eu__1, /*Error near IL_00ba: Stack underflow*/);
			stateMachine = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_0D00(CancellationToken P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778699, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_0E00()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0072: Expected native int or pointer, but got Obj
		//IL_0057->IL0026: Incompatible stack heights: 2 vs 1
		//IL_007c->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0062->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0087->IL0026: Incompatible stack heights: 2 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				_ = ((Authenticator)(object)this).Listener;
				_ = 0;
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					_ = 0;
				}
				break;
			case 2:
				((Authenticator)(object)this).ListenAsync();
				_ = 1;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state != 0)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00ༀ(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778698, new IntPtr(2737337576204L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00က(byte P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003a: Expected native int or pointer, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
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
	internal unsafe void _FF00_FF00_FF00_FF00ᄀ(List<ComponentPath> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected I4, but got Obj
		//IL_003a: Expected native int or pointer, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)P_0;
				obj2 = 0;
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
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
	private unsafe void _FF00_FF00_FF00_FF00ሀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778697, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00ጀ(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0041: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I4
		//IL_0050: Expected native int or pointer, but got Obj
		//IL_005a->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0065->IL0026: Incompatible stack heights: 3 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				_ = 1;
				((Authenticator)5).Listener = ((Authenticator)P_0).Listener;
				_ = 0;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
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
	private unsafe void _FF00_FF00_FF00_FF00_1400(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778696, new IntPtr(2737337579324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00ᔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778695, new IntPtr(2737337594924L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00ᘀ()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_001b: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00ᜀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778694, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_1800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778693, new IntPtr(2737337597004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00ᤀ()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_001b: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00ᨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778692, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_1B00()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00ᰀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778691, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00ᴀ()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_2500(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_007b: Expected I4, but got Obj
		//IL_04f3: Expected VT, but got Obj
		//IL_0415: Expected I4, but got Obj
		//IL_0416: Invalid comparison between Unknown and I4
		//IL_010d: Expected Obj, but got I4
		//IL_00e0: Expected native int or pointer, but got Obj
		//IL_0129: Expected Obj, but got I
		//IL_012e: Expected Ref, but got VT
		//IL_04cb: Expected Obj, but got I4
		//IL_04d4: Expected Obj, but got I4
		//IL_0482: Expected Obj, but got I4
		//IL_0489: Expected Obj, but got Ref
		//IL_0489: Expected Obj, but got Ref
		//IL_0489: Expected Obj, but got I4
		//IL_048e: Expected Obj, but got I4
		//IL_0496: Expected Obj, but got Ref
		//IL_049b: Expected Obj, but got VT
		//IL_04a2: Expected Obj, but got Ref
		//IL_04ae: Expected Obj, but got Ref
		//IL_043d: Expected I4, but got Obj
		//IL_0446: Expected Obj, but got I4
		//IL_0534: Expected Obj, but got I4
		//IL_0460: Expected native int or pointer, but got Obj
		//IL_054e: Expected native int or pointer, but got Obj
		//IL_01d7: Expected Obj, but got Ref
		//IL_033e: Expected Ref, but got VT
		//IL_0307: Expected I4, but got Obj
		//IL_02c2: Expected Obj, but got I4
		//IL_020d: Expected native int or pointer, but got Obj
		//IL_0217: Expected I4, but got VT
		//IL_0223: Expected native int or pointer, but got Obj
		//IL_0517->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04fd->IL0026: Incompatible stack heights: 2 vs 1
		//IL_016e->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0117->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0189->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00a3->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0106->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0142->IL0026: Incompatible stack heights: 4 vs 1
		//IL_04d9->IL0022: Incompatible stack heights: 1 vs 0
		//IL_04bd->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00df->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00be->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0522->IL0026: Incompatible stack types: I4 vs Obj
		//IL_053e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_046a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0194->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00ae->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00f4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_014d->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0558->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0475->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02f6->IL01ab: Incompatible stack heights: 5 vs 1
		//IL_0563->IL0026: Incompatible stack types: I4 vs Obj
		//IL_022d->IL01fa: Incompatible stack heights: 1 vs 3
		//IL_0238->IL01fa: Incompatible stack heights: 1 vs 3
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				case 7:
					((Authenticator)/*Error near IL_008a: Stack underflow*/).Listener = ((Authenticator)/*Error near IL_0085: Stack underflow*/).Listener;
					System.Threading.Tasks.Task.Run((Func<Task?>)/*Error near IL_008f: Stack underflow*/);
					_ = 18;
					if (Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton != null)
					{
						_ = 17;
					}
					continue;
				case 16:
					((Authenticator)/*Error near IL_00b4: Stack underflow*/).ReceiveAsync((object)this);
					_ = 9;
					continue;
				case 15:
					((Authenticator)/*Error near IL_00c4: Stack underflow*/).ReceiveAuthenticationDataAsync((object)this);
					__ldftn(Mass.Game.Launcher.Authenticator.Dispose);
					((IAsyncStateMachine)new TcpListener()).MoveNext();
					_ = 4;
					continue;
				case 9:
					if (Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler != null)
					{
						obj2 = 8;
						continue;
					}
					goto case 2;
				case 17:
					return;
				case 10:
					((Authenticator._003CListenAsync_003Ed__7*)null)->MoveNext();
					_ = 12;
					continue;
				case 5:
					((Authenticator._003CListenAsync_003Ed__7*)this)->SetStateMachine((IAsyncStateMachine)1);
					obj2 = 3;
					continue;
				case 11:
					Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.DecorateExpandableParser();
					((AsyncTaskMethodBuilder*)new AsyncTaskMethodBuilder((Exception)(delegate*<object>)(&Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.ObserveTracker)))->SetResult();
					_ = 1;
					if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)Mass.Game.Launcher.Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						_ = 0;
					}
					continue;
				case 4:
					((Authenticator._003CReceiveAsync_003Ed__9*)this)->MoveNext();
					__ldftn(Mass.Game.Launcher.Authenticator._003CReceiveAsync_003Ed__9.SetStateMachine);
					((TaskAwaiter<TcpClient>*)new Task<TcpClient>())->GetResult();
					_ = 11;
					continue;
				case 6:
					_ = 1;
					_ = Encoding.UTF8;
					_ = 5;
					if (((FeverInstaller)FeverInstaller._003CfeverVersion_003EP)._003CappId_003EP != null)
					{
						_ = 4;
					}
					continue;
				case 18:
				{
					obj = ((FeverInstaller)(object)this)._003CappVersion_003EP;
					int num = 5;
					while (true)
					{
						switch (num)
						{
						case 3:
							return;
						default:
						{
							object buffer = obj;
							TaskAwaiter<string> awaiter = ((Task<string>)(&obj)).GetAwaiter();
							int num2 = 1;
							if (FeverInstaller.ReflectVisualArgument == null)
							{
								num2 = 0;
							}
							while (true)
							{
								switch (num2)
								{
								case 1:
									((Stream)/*Error near IL_0217: Stack underflow*/).Write((byte[])buffer, (int)awaiter, ((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)this)->_003C_003E1__state);
									obj = (object)/*Error near IL_0219: Stack underflow*/;
									_ = 0;
									if (((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003E4__this)->request == null)
									{
										_ = 0;
									}
									continue;
								}
								break;
							}
							break;
						}
						case 5:
							obj = 0;
							num = 0;
							if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003Et__builder)._003C_003E4__this == null)
							{
								num = 0;
							}
							continue;
						case 2:
							_ = 0;
							_ = 7;
							_ = 0;
							((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)obj)->MoveNext();
							_ = 3;
							continue;
						case 4:
							((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)/*Error near IL_02fb: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_02fb: Stack underflow*/);
							(FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.AnalyzeHandler() ? ((DefaultInterpolatedStringHandler*)1) : ((DefaultInterpolatedStringHandler*)null))->AppendFormatted((EnumItemMasterType)obj);
							num = 2;
							if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13._003C_003Et__builder)._003C_003E4__this == null)
							{
								num = 2;
							}
							continue;
						case 1:
							break;
						}
						TaskAwaiter<EntityFeverManifestInfo> taskAwaiter = ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(FeverInstaller._003CGetFeverManifestAsync_003Ed__12.SearchChain() ? 1 : 0))->_003C_003Eu__1;
						object stateMachine = obj;
						((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)this)->MoveNext();
						((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)taskAwaiter)->SetStateMachine((IAsyncStateMachine)stateMachine);
						obj = this;
						num = 4;
						if (((FeverInstaller._003CInstallAsync_003Ed__11)FeverInstaller._003CInstallAsync_003Ed__11._003C_003Et__builder)._003C_003E4__this == null)
						{
							num = 4;
						}
					}
				}
				case 2:
					((Rpc)/*Error near IL_0415: Stack underflow*/)._002Ector((ILogger)/*Error near IL_0415: Stack underflow*/, (byte)(int)this != 0);
					if ((int)/*Error near IL_0418: Stack underflow*/ <= 0)
					{
						goto case 13;
					}
					goto case 8;
				case 19:
					((Rpc)/*Error near IL_042c: Stack underflow*/).SendMessage((BinaryWriter)/*Error near IL_042c: Stack underflow*/, (object[])(object)((Rpc)/*Error near IL_0427: Stack underflow*/).Callbacks);
					((Rpc)/*Error near IL_0432: Stack underflow*/).AddCallBack((ushort)/*Error near IL_0432: Stack underflow*/, (Func<RpcCallBack, Task>)(object)this);
					((ILogger)/*Error near IL_043d: Stack underflow*/).Information<bool>((string)/*Error near IL_043d: Stack underflow*/, (byte)(int)((Rpc)/*Error near IL_0438: Stack underflow*/).RemoteCallBackAsync((object)this) != 0);
					obj = 15;
					break;
				case 3:
					((Rpc)(object)this).Dispose();
					if ((int)/*Error near IL_0456: Stack underflow*/ == 0)
					{
						obj2 = 0;
						if (((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)Mass.Game.Launcher.Rpc._003CListenAsync_003Ed__34.DecorateIterableWriter)->_003C_003E1__state != 0)
						{
							obj2 = 0;
						}
					}
					else
					{
						((Rpc._003CReceiveAsync_003Ed__28*)this)->SetStateMachine((IAsyncStateMachine)((TaskAwaiter<EntityFeverManifestInfo>*)Mass.Game.Launcher.Rpc._003CListenControlConnectAsync_003Ed__35.DecorateSeparatedSummarizer())->IsCompleted);
						_ = 19;
					}
					continue;
				case 13:
				{
					((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)7)->SetStateMachine((IAsyncStateMachine)1);
					((Rpc)0).ReceiveControlData((object)(&obj), (object)(&obj));
					TaskAwaiter<RestResponse<EntityFeverManifest>> awaiter2 = ((Task<RestResponse<EntityFeverManifest>>)7).GetAwaiter();
					((Rpc)(&obj)).Listener = (TcpListener?)(object)this;
					((AsyncTaskMethodBuilder<EntityFeverManifest>*)5)->SetException((Exception)((Rpc)(object)((IEnumerable<string>)awaiter2).ToArray()).ListenControlConnectAsync((object)(&obj)));
					((AsyncTaskMethodBuilder<EntityFeverManifest>*)this)->SetResult((EntityFeverManifest)(&obj));
					Mass.Game.Launcher.Rpc.CheckConnectedDecider();
					_ = 17;
					continue;
				}
				case 12:
					((Rpc._003CListenAsync_003Ed__34*)null)->MoveNext();
					((Rpc._003CListenAsync_003Ed__34*)null)->SetStateMachine((IAsyncStateMachine)7);
					obj = 7;
					break;
				case 1:
					RestRequestExtensions.AddQueryParameter<_0021_00210>((RestRequest)/*Error near IL_04f3: Stack underflow*/, (string)/*Error near IL_04f3: Stack underflow*/, (_0021_00210)this, Mass.Game.Launcher.Rpc._003CListenAsync_003Ed__34.CheckIntegratedDic());
					_ = 16;
					continue;
				default:
					((Rpc._003CListenControlConnectAsync_003Ed__35*)this)->MoveNext();
					obj2 = 14;
					if (Mass.Game.Launcher.Rpc._003CRemoteCallBackAsync_003Ed__21.MeasureCalc != null)
					{
						obj2 = 9;
					}
					continue;
				case 14:
					return;
				case 8:
					obj2 = 10;
					if (Mass.Game.Launcher.Rpc._003CSyncChaChaAsync_003Ed__38.RateStack == null)
					{
						obj2 = 8;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_2600(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778690, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_2700(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_009d: Expected native int or pointer, but got Obj
		//IL_007f: Expected Obj, but got Void
		//IL_0097: Expected Obj, but got I4
		//IL_00cd: Expected native int or pointer, but got Obj
		//IL_00c1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0089->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00de->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				default:
					return;
				case 1:
					if (obj == obj)
					{
						obj2 = 0;
						if ((int)((Authenticator._003CListenAsync_003Ed__7*)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					break;
				case 3:
					obj = System.Threading.Tasks.Task.Run((Func<Task?>)P_0);
					_ = 2;
					continue;
				case 0:
					return;
				case 4:
					break;
				case 2:
					((AsyncTaskMethodBuilder*)(&Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton))->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<string>*)obj, ref *(Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)obj);
					obj = (object)/*Error near IL_00ad: Stack underflow*/;
					obj2 = 1;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Mass.Game.Launcher.Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener == null)
					{
						obj2 = 1;
					}
					continue;
				case 5:
					obj = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E4__this;
					obj2 = 4;
					continue;
				}
				break;
			}
			obj = obj;
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_2800(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778689, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_2900(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected I4, but got Obj
		//IL_003b: Expected native int or pointer, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				if (((Authenticator._003CListenAsync_003Ed__7)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_2A00()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_001b: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_2B00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778688, new IntPtr(2737337578284L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00Ⰰ()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00ⴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778751, new IntPtr(2737337577244L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_2E00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778750, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_2F00()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4862, 1790778749, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778749, new IntPtr(2737337590764L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_3000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778748, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_3100(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0042: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I4
		//IL_0051: Expected native int or pointer, but got Obj
		//IL_005b->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0066->IL0026: Incompatible stack heights: 3 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
			case 0:
				return;
			case 1:
				_ = 2;
				((Authenticator)1).Listener = ((Authenticator)P_0).Listener;
				_ = 0;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_3300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778747, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00㐀()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0057: Expected native int or pointer, but got Obj
		//IL_0061->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006c->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
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
				((ILogger)/*Error near IL_0041: Stack underflow*/).Debug<_0021_00210>((string)/*Error near IL_0041: Stack underflow*/, (_0021_00210)/*Error near IL_0041: Stack underflow*/);
				((Func<Task>)/*Error near IL_0048: Stack underflow*/)._002Ector((object)/*Error near IL_0048: Stack underflow*/, (nint)32);
				if ((int)/*Error near IL_004d: Stack underflow*/ == 0)
				{
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Mass.Game.Launcher.Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			case 0:
				return;
			case 2:
				break;
			}
			break;
		}
		throw new GC(((Authenticator)/*Error near IL_0095: Stack underflow*/).ReceiveAuthenticationDataAsync((object)/*Error near IL_0095: Stack underflow*/));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00㔀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778746, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<ulong> _FF00_FF00_FF00_FF00㘀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_001b: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Mass.Game.Launcher.Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (List<ulong>)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<ulong> _FF00_FF00_FF00_FF00㜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778745, new IntPtr(2737337591804L), 15))(null, 0, new IntPtr(0L));
		return (List<ulong>)/*Error near IL_0033: Stack underflow*/;
	}
}
