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
using System.Security.Authentication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Mass.Application.Desktop.Models;
using Mass.Application.Netease;
using Mass.Application.Services;
using Mass.Common.Extensions;
using Mass.Domain.Desktop.Entities;
using Mass.Domain.Desktop.Entities.Item;
using Mass.Domain.Desktop.Entities.LanGame;
using Mass.Domain.Desktop.Entities.Mods;
using Mass.Domain.Desktop.Entities.NetGame;
using Mass.Domain.Desktop.Entities.RentalGame;
using Mass.Domain.Desktop.Entities.Skin;
using Mass.Domain.Desktop.Interfaces;
using Mass.Domain.Desktop.Models;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Entities.Netease;
using Org.BouncyCastle.Crypto.Engines;
using RestSharp;
using Serilog;

namespace Mass.Application.Desktop;

public class NeteaseDesktop : IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAuthenticationOtpAsync_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityAuthenticationOtp> _003C_003Et__builder;

		public NeteaseDesktop _003C_003E4__this;

		public EntityAuthenticationOtpDto dto;

		private TaskAwaiter<RestResponse<Entity<EntityAuthenticationOtp>>> _003C_003Eu__1;

		internal static object ReflectLiteralDispatcher;

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
		internal static bool ReflectScalableSingleton()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateModularCalculator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_2000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778767, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_2100()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_033a: Expected Obj, but got I4
			//IL_0344: Expected native int or pointer, but got Obj
			//IL_0313: Expected Obj, but got Ref
			//IL_0361: Expected Obj, but got VT
			//IL_0160: Expected Obj, but got Ref
			//IL_016c: Expected native int or pointer, but got Obj
			//IL_00a4: Expected Obj, but got Ref
			//IL_0212: Expected Obj, but got I4
			//IL_0217: Expected VT, but got I4
			//IL_0221: Expected native int or pointer, but got Obj
			//IL_01b4: Expected Obj, but got Ref
			//IL_01be: Expected Ref, but got VT
			//IL_00ca: Expected VT, but got Ref
			//IL_01ec: Expected Obj, but got I4
			//IL_0208: Expected Obj, but got I4
			//IL_023b: Expected Obj, but got I4
			//IL_0240: Expected VT, but got I4
			//IL_0097: Expected I4, but got Obj
			//IL_034e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0327->IL0026: Incompatible stack types: I4 vs Obj
			//IL_037d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_036b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0359->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0332->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0176->IL005e: Incompatible stack types: I4 vs Obj
			//IL_005a->IL005e: Incompatible stack types: I4 vs Obj
			//IL_0181->IL005e: Incompatible stack types: I4 vs Obj
			//IL_00b8->IL005e: Incompatible stack types: I4 vs Obj
			//IL_0260->IL005e: Incompatible stack types: I4 vs Obj
			//IL_022b->IL005e: Incompatible stack types: I4 vs Obj
			//IL_01d4->IL005e: Incompatible stack types: I4 vs Obj
			//IL_01ad->IL005e: Incompatible stack types: I4 vs Obj
			//IL_020d->IL005a: Incompatible stack heights: 1 vs 0
			//IL_024a->IL005e: Incompatible stack types: I4 vs Obj
			//IL_00c3->IL005e: Incompatible stack types: I4 vs Obj
			//IL_0236->IL005e: Incompatible stack types: I4 vs Obj
			//IL_01df->IL005e: Incompatible stack types: I4 vs Obj
			//IL_00e3->IL005e: Incompatible stack types: I4 vs Obj
			//IL_00ee->IL005e: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
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
				case 5:
					if (obj != null)
					{
						obj3 = 3;
						goto IL_005e;
					}
					goto IL_015a;
				case 1:
					((ILogger)/*Error near IL_0313: Stack underflow*/).Warning((Exception)Unsafe.AsPointer(ref ((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003Eu__1), (string)obj);
					obj2 = 1;
					if ((int)((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22*)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj2 = 4;
					}
					break;
				default:
					goto IL_0332;
				case 3:
					obj = ((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003Eu__2;
					obj2 = 2;
					break;
				case 2:
					obj = DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22.DecorateBasicTag;
					obj2 = 5;
					break;
				case 4:
					return;
					IL_0332:
					((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003E4__this = (DesktopAuthentication)(-2);
					obj2 = 1;
					if ((int)((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22*)(nint)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22.data)->_003C_003Eu__1 == 0)
					{
						obj2 = 1;
					}
					break;
					IL_005e:
					while (true)
					{
						switch ((int)obj3)
						{
						default:
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP = obj;
							obj3 = 11;
							if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
							{
								obj3 = 6;
							}
							continue;
						case 8:
							if (!((EqualityComparer<_00210>)/*Error near IL_00ca: Stack underflow*/).Equals((_00210?)/*Error near IL_00ca: Stack underflow*/, (_00210?)(&obj)))
							{
								obj3 = 1;
								if (DesktopAuthentication.Logger == null)
								{
									obj3 = 6;
								}
								continue;
							}
							goto case 7;
						case 3:
							((DesktopAuthentication)/*Error near IL_00fa: Stack underflow*/)._002Ector((string)/*Error near IL_00fa: Stack underflow*/, (string)/*Error near IL_00fa: Stack underflow*/, (string)/*Error near IL_00fa: Stack underflow*/, (string)(object)DesktopAuthentication.TokenKey);
							_ = 1;
							/*Error near IL_00fb: Member reference must be method, but was: Field*/;
						case 5:
							return;
						case 1:
							break;
						case 10:
							DesktopAuthentication._002Ecctor();
							((DesktopAuthentication)/*Error near IL_018b: Stack underflow*/)._003CConnect_003Eb__19_0();
							((AsyncTaskMethodBuilder*)/*Error near IL_0192: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_0192: Stack underflow*/, ref *(TStateMachine*)obj);
							((AsyncTaskMethodBuilder*)/*Error near IL_01a3: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(((TaskAwaiter*)/*Error near IL_0197: Stack underflow*/)->IsCompleted ? ((TaskAwaiter*)1) : ((TaskAwaiter*)null)), ref *(DesktopAuthentication._003CSendPacketAsync_003Ed__28*)((TaskAwaiter<byte[]>*)obj)->GetResult());
							obj3 = 9;
							continue;
						case 7:
							((AsyncTaskMethodBuilder<_0021_00210>*)((Task)(&obj)).GetAwaiter())->Start(ref *(DesktopAuthentication._003CAuthentication_003Ed__27.CheckExpandableComparator() ? ((DesktopSession._003CEntityRequestAsync_003Ed__10<_0021_00210>*)1) : ((DesktopSession._003CEntityRequestAsync_003Ed__10<_0021_00210>*)null)));
							obj = (object)/*Error near IL_01c0: Stack underflow*/;
							obj3 = 1;
							if (((DesktopAuthentication._003CConnect_003Ed__19)DesktopAuthentication._003CConnect_003Ed__19._003C_003Et__builder)._003C_003E4__this == null)
							{
								obj3 = 10;
							}
							continue;
						case 9:
							obj = obj;
							obj = 2;
							goto IL_005a;
						case 11:
							_ = ref ((DesktopAuthentication._003CConnect_003Ed__19)this).authServer;
							((AsyncTaskMethodBuilder<EntityNetGameItem[]>*)(&obj))->Start(ref Unsafe.As<_003CAuthenticationOtpAsync_003Ed__18, DesktopSession._003CGetNetGamesAsync_003Ed__15>(ref this));
							obj = 5;
							goto IL_005a;
						case 6:
							obj = 0;
							((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003Eu__1 = (TaskAwaiter)0;
							obj3 = 0;
							if (((DesktopAuthentication._003CHeartbeatAsync_003Ed__25*)(nint)DesktopAuthentication._003CConnect_003Ed__19.CheckAdjustableCommand)->_003C_003E1__state == 0)
							{
								obj3 = 0;
							}
							continue;
						case 12:
							obj = -1;
							((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-1);
							obj3 = 7;
							continue;
						case 4:
							Unsafe.As<DesktopAuthentication, AsyncTaskMethodBuilder<EntityNetGameDetails>>(ref ((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003E4__this) = default;
							obj3 = 12;
							continue;
						case 2:
							goto IL_0332;
							IL_005a:
							obj3 = obj;
							continue;
						}
						break;
					}
					goto IL_015a;
					IL_015a:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._authenticationTcs;
					obj3 = 4;
					if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication.PrepareDic)->_003C_003E1__state != 0)
					{
						obj3 = 4;
					}
					goto IL_005e;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_2200(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778766, new IntPtr(2737336616716L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_2300(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected VT, but got Ref
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
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
					((EqualityComparer<_00211>)/*Error near IL_0044: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
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
		internal static byte _FF00_FF00_FF00_2400()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_2500()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778761, new IntPtr(2737336630236L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_2600()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778760, new IntPtr(2737336628156L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_2700()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_2800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778763, new IntPtr(2737336630236L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAuthenticationUpdateAsync_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityAuthenticationOtp> _003C_003Et__builder;

		public string userId;

		public NeteaseDesktop _003C_003E4__this;

		public string userToken;

		private TaskAwaiter<RestResponse<Entity<EntityAuthenticationOtp>>> _003C_003Eu__1;

		private static object DecorateGroupedDictionary;

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
		internal static bool CheckAccessibleMonitor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateIsolatedSynchronizer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00ᘀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778762, new IntPtr(2737336618796L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00ᜀ()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_03a7: Expected I4, but got Obj
			//IL_03a7: Expected Obj, but got Ref
			//IL_03ba: Expected Obj, but got VT
			//IL_03c4: Expected native int or pointer, but got Obj
			//IL_00ba: Expected VT, but got Obj
			//IL_00ba: Expected VT, but got Obj
			//IL_00c1: Expected VT, but got Obj
			//IL_00c1: Expected Obj, but got I4
			//IL_01b7: Expected native int or pointer, but got Obj
			//IL_01d4: Expected Obj, but got VT
			//IL_01f6: Expected native int or pointer, but got Obj
			//IL_0286: Expected Obj, but got I4
			//IL_028b: Expected VT, but got I4
			//IL_0295: Expected native int or pointer, but got Obj
			//IL_0260: Expected Obj, but got I4
			//IL_0265: Expected VT, but got I4
			//IL_0154: Expected Obj, but got I4
			//IL_016f: Expected Obj, but got I4
			//IL_0174: Expected Ref, but got VT
			//IL_03b1->IL0026: Incompatible stack heights: 2 vs 1
			//IL_037d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03ce->IL0026: Incompatible stack types: I4 vs Obj
			//IL_039a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0388->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03d9->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0200->IL005e: Incompatible stack heights: 2 vs 1
			//IL_020b->IL005e: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				int num;
				Action action;
				switch ((int)obj2)
				{
				case 2:
					if (obj == null)
					{
						num = 12;
						goto IL_005e;
					}
					goto IL_0221;
				case 1:
					goto IL_0361;
				case 4:
					obj = ((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this).buffer;
					obj2 = 3;
					break;
				default:
					Enumerable.Skip<TSource>((IEnumerable<TSource>)Unsafe.AsPointer(ref ((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this)._003C_003Eu__1), (int)obj);
					_ = 5;
					break;
				case 5:
					return;
				case 3:
					{
						obj = ((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this)._003C_003Eu__2;
						obj2 = 2;
						if (((DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23*)(nint)DesktopAuthentication._003CReceiveDataAsync_003Ed__21.CheckActiveRecommender)->_003C_003E1__state == 0)
						{
							obj2 = 0;
						}
						break;
					}
					IL_005e:
					while (true)
					{
						switch (num)
						{
						default:
							((_003C_003Ef__AnonymousType0<, >)/*Error near IL_00ae: Stack underflow*/)._002Ector((_003Corderid_003Ej__TPar)/*Error near IL_00ae: Stack underflow*/, ((_003C_003Ef__AnonymousType0<, >)/*Error near IL_00a9: Stack underflow*/).buy_type);
							((AsyncTaskMethodBuilder*)/*Error near IL_00c6: Stack underflow*/)->Start(ref *(DesktopAuthentication._003CSendPacketAsync_003Ed__28*)((EqualityComparer<_00210>)((EqualityComparer<_00210>)/*Error near IL_00ba: Stack underflow*/).Equals((_00210?)obj, (_00210?)EqualityComparer<_00210>.Default)).GetHashCode((_00210)obj));
							num = 1;
							if (((DesktopAuthentication)(object)DesktopAuthentication.TokenKey)._client != null)
							{
								num = 1;
							}
							continue;
						case 3:
							_ = ref obj;
							/*Error near IL_00e7: Member reference must be method, but was: Field*/;
						case 2:
							((AsyncTaskMethodBuilder*)/*Error near IL_0121: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)/*Error near IL_0121: Stack underflow*/, ref *(DesktopAuthentication._003CReceiveAsync_003Ed__20*)((DesktopAuthentication)/*Error near IL_011c: Stack underflow*/).RemoteCallBackAsync((ushort)/*Error near IL_011c: Stack underflow*/, (object)((AsyncTaskMethodBuilder*)(&obj))->Task));
							obj = (object)/*Error near IL_0123: Stack underflow*/;
							num = 0;
							if (((DesktopAuthentication)DesktopAuthentication._encryptChaCha)._decryptChaCha == null)
							{
								num = 0;
							}
							continue;
						case 13:
						{
							ILogger loggerExtensions = new LoggerExtensions((ILogger)((DesktopAuthentication)/*Error near IL_014e: Stack underflow*/).SendPacketAsync((byte)/*Error near IL_014e: Stack underflow*/, ((DesktopAuthentication)obj)._handshakeTcs), (string)1);
							((DesktopAuthentication)obj).Dispose();
							AsyncTaskMethodBuilder asyncTaskMethodBuilder = ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Et__builder;
							DesktopAuthentication desktopAuthentication = ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E4__this;
							object obj3 = obj;
							((DesktopAuthentication)0)._003CAuthentication_003Eb__27_0();
							((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<int>*)desktopAuthentication, ref *(DesktopAuthentication._003CReceiveDataAsync_003Ed__21*)obj3);
							obj = ((TaskAwaiter<byte[]>*)loggerExtensions)->GetResult();
							num = 3;
							continue;
						}
						case 14:
							return;
						case 1:
							obj = obj;
							num = 2;
							if (((DesktopAuthentication._003CConnect_003Ed__19*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27.ReflectInternalAnnotation)->_003C_003E1__state == 0)
							{
								num = 7;
							}
							continue;
						case 4:
						case 12:
							obj = ((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003Et__builder;
							num = 11;
							continue;
						case 6:
							_ = ref ((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003E4__this;
							((AsyncTaskMethodBuilder<_0021_00210>*)(&obj))->Start(ref Unsafe.As<_003CAuthenticationUpdateAsync_003Ed__19, DesktopSession._003CRequestAsync_003Ed__13<_0021_00210>>(ref this));
							_ = 5;
							if ((int)((DesktopAuthentication._003CConnect_003Ed__19*)(nint)DesktopAuthentication._003CConnect_003Ed__19._003Ccts_003E5__2)->_003C_003Eu__1 == 0)
							{
								_ = 14;
							}
							continue;
						case 11:
							Unsafe.As<object, AsyncTaskMethodBuilder<EntityItemDownload[]>>(ref DesktopAuthentication._003CConnect_003Ed__19.CheckAdjustableCommand) = default;
							num = 8;
							continue;
						case 5:
							break;
						case 10:
							obj = 0;
							((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)0;
							num = 9;
							continue;
						case 9:
							((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003E4__this = (DesktopAuthentication)obj;
							num = 6;
							continue;
						case 8:
							obj = -1;
							((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Eu__1 = (TaskAwaiter)(-1);
							num = 2;
							if (((DesktopAuthentication._003CReceiveAsync_003Ed__20*)(nint)DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24.ReflectMixedRunner)->_003C_003E1__state == 0)
							{
								num = 2;
							}
							continue;
						case 7:
							goto IL_0361;
						}
						break;
					}
					goto IL_0221;
					IL_0361:
					((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this)._003C_003E1__state = -2;
					obj2 = 0;
					if (((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)DesktopAuthentication._003CReceiveDataAsync_003Ed__21._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 0;
					}
					break;
					IL_0221:
					action = new Action((object)/*Error near IL_0226: Stack underflow*/, (nint)/*Error near IL_0226: Stack underflow*/);
					((IDisposable)((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003E4__this).Dispose();
					((AsyncTaskMethodBuilder*)action)->SetException((Exception)(object)action);
					((AsyncTaskMethodBuilder*)/*Error near IL_023c: Stack underflow*/)->SetResult();
					obj = (object)/*Error near IL_023e: Stack underflow*/;
					num = 13;
					goto IL_005e;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_1800(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778869, new IntPtr(2737336617756L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00ᤀ(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected VT, but got Ref
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
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
					((EqualityComparer<_00211>)/*Error near IL_0044: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
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
		internal static byte _FF00_FF00_FF00ᨀ()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_1B00()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00ᰀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778868, new IntPtr(2737336628156L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetRelatedLanGameRooms_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityLanGameRoom[]> _003C_003Et__builder;

		public NeteaseDesktop _003C_003E4__this;

		public int count;

		private TaskAwaiter<RestResponse<EntityRelatedLanGameRoomResponse>> _003C_003Eu__1;

		private static object SerializeDispatcher;

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
		internal static bool ReflectIterableSystem()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckIntegratedRole()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_0900()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778871, new IntPtr(2737336633356L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_0A00()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_032f: Expected Obj, but got VT
			//IL_0339: Expected native int or pointer, but got Obj
			//IL_004e: Expected Obj, but got Ref
			//IL_0059: Expected Obj, but got I4
			//IL_0311: Expected native int or pointer, but got Obj
			//IL_0356: Expected VT, but got I4
			//IL_0145: Expected Obj, but got Ref
			//IL_0147: Expected Obj, but got I
			//IL_020b: Expected VT, but got Ref
			//IL_0216: Expected Obj, but got I4
			//IL_01e0: Expected Obj, but got I4
			//IL_019f: Expected Obj, but got I4
			//IL_00d6: Expected Obj, but got I4
			//IL_00db: Expected Obj, but got I4
			//IL_00db: Expected Obj, but got Ref
			//IL_00e4: Expected Obj, but got I4
			//IL_00b0: Expected Obj, but got Ref
			//IL_00f0: Expected VT, but got Ref
			//IL_011a: Expected Obj, but got Ref
			//IL_016e: Expected Obj, but got Ref
			//IL_024c: Expected Ref, but got VT
			//IL_00a5: Expected I4, but got Obj
			//IL_0343->IL0026: Incompatible stack types: I4 vs Obj
			//IL_031b->IL0026: Incompatible stack heights: 4 vs 1
			//IL_0360->IL0026: Incompatible stack types: I4 vs Obj
			//IL_015b->IL0074: Incompatible stack types: I4 vs Obj
			//IL_0070->IL0074: Incompatible stack types: I4 vs Obj
			//IL_034e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0326->IL0026: Incompatible stack heights: 4 vs 1
			//IL_0166->IL0074: Incompatible stack types: I4 vs Obj
			//IL_01f9->IL0074: Incompatible stack types: I4 vs Obj
			//IL_01db->IL0074: Incompatible stack heights: 2 vs 1
			//IL_00c2->IL0074: Incompatible stack heights: 2 vs 1
			//IL_0134->IL0074: Incompatible stack types: I4 vs Obj
			//IL_0182->IL0074: Incompatible stack types: I4 vs Obj
			//IL_022b->IL0242: Incompatible stack heights: 2 vs 4
			//IL_0204->IL0074: Incompatible stack types: I4 vs Obj
			//IL_0109->IL0074: Incompatible stack types: I4 vs Obj
			//IL_013f->IL0074: Incompatible stack types: I4 vs Obj
			//IL_018d->IL0074: Incompatible stack types: I4 vs Obj
			//IL_0258->IL0074: Incompatible stack types: I4 vs Obj
			//IL_0114->IL0074: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					object obj3;
					switch ((int)obj2)
					{
					case 3:
						goto end_IL_0026;
					default:
						if (obj != null)
						{
							obj3 = 3;
							goto IL_0074;
						}
						goto IL_013f;
					case 4:
						_ = ref ((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003Et__builder;
						_ = Encoding.ASCII;
						_ = 1;
						if ((int)((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22*)(nint)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22.data)->_003C_003Eu__1 == 0)
						{
							_ = 1;
						}
						continue;
					case 1:
						return;
					case 2:
						obj = ((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003Eu__2;
						obj2 = 0;
						if (((DesktopAuthentication._003CReceiveDataAsync_003Ed__21*)(nint)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22.DecorateBasicTag)->_003C_003E1__state != 0)
						{
							obj2 = 0;
						}
						continue;
					case 5:
						break;
						IL_0074:
						while (true)
						{
							switch ((int)obj3)
							{
							case 6:
								_ = ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserToken_003EP;
								((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CGetRelatedLanGameRooms_003Ed__20, DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24>(ref this));
								_ = 7;
								continue;
							case 7:
								return;
							case 4:
								obj = 0;
								((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP = 0;
								obj = 10;
								obj3 = obj;
								continue;
							case 8:
								if (((EqualityComparer<_00210>)/*Error near IL_00f0: Stack underflow*/).GetHashCode((_00210)(&obj)) == 0)
								{
									obj3 = 4;
									if (DesktopAuthentication.TokenKey == null)
									{
										obj3 = 1;
									}
									continue;
								}
								goto default;
							case 9:
								((DesktopAuthentication)Unsafe.AsPointer(ref this))._client = null;
								obj3 = 1;
								if (((DesktopAuthentication)(object)DesktopAuthentication._buffer)._handshake == 0)
								{
									obj3 = 0;
								}
								continue;
							case 5:
								break;
							case 10:
								((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptChaCha = obj;
								obj3 = 0;
								if (((DesktopAuthentication)DesktopAuthentication._decryptChaCha)._handshakeTcs != null)
								{
									obj3 = 6;
								}
								continue;
							case 3:
							{
								object obj4 = ((DesktopAuthentication)/*Error near IL_0199: Stack underflow*/).SendMessageAsync(((DesktopAuthentication)obj)._authenticationTcs);
								TaskCompletionSource taskCompletionSource = (TaskCompletionSource)new TaskCompletionSource((Exception)new TimeoutException((string?)1));
								((AsyncTaskMethodBuilder*)taskCompletionSource)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)taskCompletionSource, ref *(TStateMachine*)((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E4__this);
								_ = ((TaskAwaiter*)obj4)->IsCompleted;
								byte[] result = ((TaskAwaiter<byte[]>*)3)->GetResult();
								*(RuntimeFieldHandle*)(&obj) = default;
								((AsyncTaskMethodBuilder*)result)->Start(ref *(DesktopSession._003CHeartbeatAsync_003Ed__7*)obj);
								obj = MassService.Instance;
								_ = 8;
								continue;
							}
							case 1:
								obj = -1;
								((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003E1__state = -1;
								obj3 = 0;
								if (((DesktopAuthentication._003CConnect_003Ed__19)DesktopAuthentication._003CConnect_003Ed__19._003C_003Et__builder)._003C_003E4__this != null)
								{
									obj3 = 0;
								}
								continue;
							default:
							{
								((CancellationTokenSource)/*Error near IL_020b: Stack underflow*/)._002Ector((TimeSpan)(&obj));
								Task task = ((TaskCompletionSource)(object)((IEnumerable<EntityNetGameItem>)DesktopAuthentication._003CConnect_003Ed__19.VerifyTracer()).FirstOrDefault((Func<EntityNetGameItem, bool>)1)).Task;
								AsyncTaskMethodBuilder asyncTaskMethodBuilder;
								object disposable;
								if (DesktopAuthentication._003CHeartbeatAsync_003Ed__25._003C_003E1__state == 0)
								{
									asyncTaskMethodBuilder = DesktopAuthentication._003CHeartbeatAsync_003Ed__25._003C_003Et__builder;
									disposable = (DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver = new IDisposable());
								}
								((AsyncTaskMethodBuilder<EntityGameModsHash>*)__ldftn(DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24.MoveNext))->Start(ref *(DesktopSession._003CGetModHashListAsync_003Ed__26*)disposable);
								((AsyncTaskMethodBuilder<bool>*)task)->Start(ref *(DesktopSession._003CGetBuyItemResultAsync_003Ed__28*)asyncTaskMethodBuilder);
								obj = (object)/*Error near IL_024e: Stack underflow*/;
								obj3 = 2;
								continue;
							}
							case 2:
								goto end_IL_0026_2;
							}
							break;
						}
						goto IL_013f;
						IL_013f:
						obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeSent;
						obj3 = 9;
						if (((DesktopAuthentication)DesktopAuthentication._handshakeKey)._encryptedToken != null)
						{
							obj3 = 1;
						}
						goto IL_0074;
						end_IL_0026_2:
						break;
					}
					((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-2);
					obj2 = 4;
					continue;
					end_IL_0026:
					break;
				}
				obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
				obj = 2;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_0B00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778870, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_0C00(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_0D00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778865, new IntPtr(2737336634396L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_0E00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778864, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00ༀ()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00က()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778867, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00ᄀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778866, new IntPtr(2737336635436L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00ሀ()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetSingleLanGameRoom_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityLanGameRoom> _003C_003Et__builder;

		public NeteaseDesktop _003C_003E4__this;

		public uint hostId;

		public uint roomId;

		private TaskAwaiter<RestResponse<EntitySingleLanGameRoomResponse>> _003C_003Eu__1;

		internal static object DecorateLocalCollection;

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
		internal static bool CloneHandler()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectConfigurableChooser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00ﴀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778877, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FE00()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_00b6: Expected Obj, but got Ref
			//IL_004f: Expected Obj, but got Ref
			//IL_008d: Expected Obj, but got Ref
			//IL_0061: Expected Obj, but got Ref
			//IL_0179: Expected Obj, but got I4
			//IL_018a: Expected Obj, but got VT
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected Obj, but got I
			//IL_029f: Expected Obj, but got Ref
			//IL_02cc: Expected Obj, but got VT
			//IL_02ce: Expected Obj, but got VT
			//IL_0205: Expected Obj, but got Ref
			//IL_022e: Expected Obj, but got I4
			//IL_0233: Expected Obj, but got I4
			//IL_0143: Expected Obj, but got I4
			//IL_0148: Expected Obj, but got I4
			//IL_0148: Expected Obj, but got Ref
			//IL_0261: Expected I4, but got Obj
			//IL_01c9: Expected Obj, but got VT
			//IL_01d3: Expected native int or pointer, but got Obj
			//IL_0254: Expected Obj, but got I4
			//IL_00ca->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_007c->IL0026: Incompatible stack heights: 4 vs 1
			//IL_00d5->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ae->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0087->IL0026: Incompatible stack heights: 4 vs 1
			//IL_02e2->IL0100: Incompatible stack heights: 4 vs 1
			//IL_02ed->IL0100: Incompatible stack heights: 4 vs 1
			//IL_0100->IL0100: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				int num;
				TimeoutException ex;
				byte[] result;
				bool isCompleted;
				switch ((int)obj2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
					obj2 = 4;
					continue;
				case 5:
					_ = ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserToken_003EP;
					_ = EqualityComparer<_00210>.Default;
					_ = 0;
					if (DesktopAuthentication.Crc32 == null)
					{
						_ = 0;
					}
					continue;
				case 3:
					obj = DesktopAuthentication.Logger;
					obj2 = 2;
					if (((DesktopAuthentication)(object)DesktopAuthentication.TokenKey)._client == null)
					{
						obj2 = 0;
					}
					continue;
				case 1:
					break;
				case 4:
					{
						if (obj == null)
						{
							num = 9;
							if (((DesktopAuthentication)DesktopAuthentication._handshakeSent)._handshakeKey == null)
							{
								num = 2;
							}
							goto IL_0100;
						}
						goto IL_0167;
					}
					IL_0167:
					ex = new TimeoutException((string?)(object)new LoggerExtensions((ILogger)((DesktopAuthentication)/*Error near IL_0173: Stack underflow*/).SendPacketAsync((byte)/*Error near IL_0173: Stack underflow*/, ((DesktopAuthentication)obj)._handshakeTcs), (string)1));
					((IAsyncStateMachine)((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Et__builder).MoveNext();
					result = (((TaskAwaiter*)((DesktopAuthentication._003CAuthentication_003Ed__27)this).modHashList)->IsCompleted ? ((TaskAwaiter<byte[]>*)1) : ((TaskAwaiter<byte[]>*)null))->GetResult();
					isCompleted = ((TaskAwaiter<byte[]>*)3)->IsCompleted;
					obj = (object)default(Log);
					(isCompleted ? ((AsyncTaskMethodBuilder*)1) : ((AsyncTaskMethodBuilder*)null))->Start(ref *(DesktopSession._003CEntityRequestAsync_003Ed__9*)obj);
					obj = ((MassService)/*Error near IL_01b5: Stack underflow*/).JoinServerAsync((byte[])/*Error near IL_01b5: Stack underflow*/, (string)/*Error near IL_01b5: Stack underflow*/, (string)(object)ex, (string)(object)ex, (string)(object)ex, (string)(object)result);
					num = 3;
					goto IL_0100;
					IL_0100:
					while (true)
					{
						switch (num)
						{
						case 8:
							return;
						case 12:
							break;
						case 6:
							obj = -1;
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptedToken = -1;
							num = 2;
							if (((DesktopAuthentication)DesktopAuthentication._encryptChaCha)._decryptChaCha != null)
							{
								num = 2;
							}
							continue;
						case 5:
							goto end_IL_0100;
						case 9:
						case 10:
							obj = ((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003Et__builder;
							num = 1;
							if (((DesktopAuthentication._003CConnect_003Ed__19*)(nint)DesktopAuthentication._003CConnect_003Ed__19._003C_003E4__this)->authServer == null)
							{
								num = 1;
							}
							continue;
						case 1:
							Unsafe.As<object, AsyncTaskMethodBuilder<EntityAuthItem>>(ref ((DesktopAuthentication._003CConnect_003Ed__19)this)._003Ccts_003E5__2) = default;
							num = 6;
							continue;
						case 3:
							if (((TaskCompletionSource)(&obj)).Task != null)
							{
								num = 0;
								if ((int)((DesktopAuthentication._003CHeartbeatAsync_003Ed__25*)DesktopAuthentication._003CHeartbeatAsync_003Ed__25._003C_003E1__state)->_003C_003Et__builder == 0)
								{
									num = 0;
								}
								continue;
							}
							goto case 4;
						case 4:
							obj = 0;
							((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003E4__this = (DesktopAuthentication)0;
							num = 7;
							continue;
						case 11:
							_ = ref ((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003Eu__1;
							((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CGetSingleLanGameRoom_003Ed__21, DesktopSession._003CGetSkinImagesAsync_003Ed__25>(ref this));
							obj = 8;
							continue;
						case 7:
							((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003E1__state = (int)obj;
							num = 11;
							continue;
						default:
						{
							((IAsyncStateMachine)/*Error near IL_029f: Stack underflow*/).SetStateMachine((IAsyncStateMachine)(&obj));
							((DesktopAuthentication._003CReceiveAsync_003Ed__20*)/*Error near IL_02a4: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_02a4: Stack underflow*/);
							((AsyncTaskMethodBuilder*)/*Error near IL_02aa: Stack underflow*/)->Start(ref *(DesktopSession._003CInterLoginStartAsync_003Ed__30*)1);
							IPAddress.Parse((string)/*Error near IL_02af: Stack underflow*/);
							new EntityAuthServer();
							AsyncTaskMethodBuilder asyncTaskMethodBuilder = ((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003Et__builder;
							T[] array = Array.Empty<T>();
							((ILogger)array).Warning((Exception)(object)array, (string)((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003Eu__1);
							obj = asyncTaskMethodBuilder;
							_ = 8;
							if ((int)((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22*)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								_ = 12;
							}
							continue;
						}
						}
						goto end_IL_0026;
						continue;
						end_IL_0100:
						break;
					}
					goto IL_0167;
					end_IL_0026:
					break;
				}
				((DesktopAuthentication)Unsafe.AsPointer(ref this))._connected = -2;
				obj2 = 3;
				if (((DesktopAuthentication)(object)DesktopAuthentication._buffer)._handshake == 0)
				{
					obj2 = 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778876, new IntPtr(2737336621916L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00Ā(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected VT, but got Ref
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
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
					((EqualityComparer<_00211>)/*Error near IL_0044: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
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
		private unsafe sealed void _FF00_FF00_FF00Ȁ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778879, new IntPtr(2737336628156L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_0300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778878, new IntPtr(2737336635436L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00Ѐ()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00Ԁ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778873, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_0600()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_0700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778872, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NeteaseDesktop _003C_003E4__this;

		private object _003Cclient_003E5__2;

		private TaskAwaiter<string> _003C_003Eu__1;

		private TaskAwaiter<EntityAuthServer[]?> _003C_003Eu__2;

		private TaskAwaiter<EntityTransferServer[]?> _003C_003Eu__3;

		internal static object ReflectSeparatedSolver;

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
		internal static bool ReflectMonoTester()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectOrderedTracer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_F500()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778875, new IntPtr(2737336635436L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_F600()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_00a0: Expected Obj, but got Ref
			//IL_0064: Expected Obj, but got Ref
			//IL_008b: Expected Obj, but got Ref
			//IL_0090: Expected VT, but got Ref
			//IL_00c8: Expected Obj, but got Ref
			//IL_00d7: Expected Obj, but got I
			//IL_0054: Expected Obj, but got I4
			//IL_0054: Expected Obj, but got Ref
			//IL_0177: Expected Obj, but got Ref
			//IL_017c: Expected I4, but got Obj
			//IL_01af: Expected I4, but got Obj
			//IL_041e: Expected Obj, but got VT
			//IL_01b9: Expected native int or pointer, but got Obj
			//IL_0579: Expected Obj, but got Ref
			//IL_04d5: Expected I4, but got Obj
			//IL_04b0: Expected I4, but got Obj
			//IL_04ab: Expected native int or pointer, but got Obj
			//IL_0600: Expected Obj, but got I4
			//IL_0330: Expected Obj, but got I4
			//IL_0335: Expected Obj, but got I4
			//IL_035c: Expected Obj, but got I4
			//IL_0361: Expected Obj, but got I4
			//IL_036a: Expected Obj, but got I4
			//IL_04c1: Expected Obj, but got Ref
			//IL_0374: Expected Obj, but got I4
			//IL_0379: Expected VT, but got I4
			//IL_0383: Expected native int or pointer, but got Obj
			//IL_05bb: Expected Obj, but got Ref
			//IL_02bb: Expected Obj, but got I4
			//IL_042f: Expected Obj, but got Ref
			//IL_047c: Expected native int or pointer, but got Obj
			//IL_048d: Expected native int or pointer, but got Obj
			//IL_0497: Expected Obj, but got I
			//IL_049c: Expected I4, but got Obj
			//IL_05d0: Expected Obj, but got Ref
			//IL_05eb: Expected Obj, but got VT
			//IL_03f5: Expected Obj, but got I4
			//IL_03fa: Expected Obj, but got I4
			//IL_0316: Expected native int or pointer, but got Obj
			//IL_046b: Expected Obj, but got I4
			//IL_0470: Expected VT, but got I4
			//IL_0545: Expected I4, but got Obj
			//IL_054a: Expected I4, but got Obj
			//IL_0550: Expected I4, but got Obj
			//IL_0595: Expected Obj, but got I4
			//IL_059f: Expected native int or pointer, but got Obj
			//IL_04f1: Expected native int or pointer, but got Obj
			//IL_0587: Expected Obj, but got I4
			//IL_06be: Expected I4, but got Obj
			//IL_06a4: Expected Obj, but got I4
			//IL_06c9: Expected I4, but got Obj
			//IL_06c4: Expected native int or pointer, but got Obj
			//IL_0277: Expected I4, but got Obj
			//IL_00b6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_007a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009a->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00dc->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c1->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00e7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0428->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_028e->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_0416->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_01c3->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_01ce->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_0453->IL01d2: Incompatible stack heights: 2 vs 1
			//IL_04df->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_03ba->IL01d2: Incompatible stack heights: 2 vs 1
			//IL_04ba->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_0620->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_0300->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_0572->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_033f->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_04cd->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_02a4->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_038d->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_03f0->IL01d2: Incompatible stack heights: 2 vs 1
			//IL_02d4->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_043b->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_04a7->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_0357->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_05f5->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_0404->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_0320->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_047a->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_055c->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_02b6->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_05a9->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_04fb->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_03c5->IL01d2: Incompatible stack heights: 2 vs 1
			//IL_067b->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_0466->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_0398->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_05ca->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_02df->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_032b->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_05b4->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_065a->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_0506->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_06d3->IL01d2: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				int num;
				object obj3;
				switch ((int)obj2)
				{
				case 6:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP = -2;
					obj2 = 5;
					break;
				case 1:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserToken_003EP;
					obj2 = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
					{
						obj2 = 0;
					}
					break;
				case 2:
					((EqualityComparer<_00211>)/*Error near IL_0090: Stack underflow*/).GetHashCode((_00211)Unsafe.AsPointer(ref DesktopAuthentication.Crc32));
					_ = 4;
					break;
				default:
					obj = DesktopAuthentication.TokenKey;
					obj2 = 0;
					if (((DesktopAuthentication)DesktopAuthentication._client)._connected == 0)
					{
						obj2 = 3;
					}
					break;
				case 5:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._buffer = null;
					obj2 = 2;
					if (((DesktopAuthentication)DesktopAuthentication._handshake)._handshakeSent == 0)
					{
						obj2 = 2;
					}
					break;
				case 3:
					if ((nuint)(nint)obj <= (nuint)2u)
					{
						num = 3;
						if (((DesktopAuthentication)DesktopAuthentication._handshakeKey)._encryptedToken == null)
						{
							num = 2;
						}
						goto IL_0113;
					}
					goto IL_0171;
				case 4:
					return;
					IL_0171:
					((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)/*Error near IL_017c: Stack underflow*/)->_003C_003E1__state = (int)new LoggerExtensions((ILogger)/*Error near IL_0177: Stack underflow*/, (string)Unsafe.AsPointer(ref this));
					num = 0;
					if (((DesktopAuthentication._003CAuthentication_003Ed__27)DesktopAuthentication._003CAuthentication_003Ed__27._003C_003Et__builder)._003C_003E4__this == null)
					{
						num = 0;
					}
					goto IL_0113;
					IL_0113:
					while (true)
					{
						switch (num)
						{
						default:
							num = 1;
							if (((DesktopAuthentication)DesktopAuthentication._handshakeTcs)._authenticationTcs != null)
							{
								num = 1;
							}
							continue;
						case 2:
							break;
						case 1:
							goto IL_019b;
						}
						break;
					}
					goto IL_0171;
					IL_019b:
					switch ((int)obj)
					{
					default:
						obj3 = 9;
						if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27.modHashList)->serverIdHash == null)
						{
							obj3 = 2;
						}
						goto IL_01d2;
					case 1:
						obj = ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003Ccts_003E5__2;
						obj3 = 17;
						goto IL_01d2;
					case 2:
						goto IL_0404;
					case 0:
						goto IL_0416;
						IL_01d2:
						while (true)
						{
							switch ((int)obj3)
							{
							case 25:
								break;
							case 36:
								goto end_IL_01d2;
							case 17:
								Unsafe.As<TaskAwaiter<byte[]>, AsyncTaskMethodBuilder<EntityUserDetail>>(ref ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Eu__1) = default;
								obj3 = 15;
								continue;
							case 34:
								DesktopAuthentication._003CAuthentication_003Ed__27.ReflectInternalAnnotation = obj;
								obj3 = 21;
								continue;
							case 22:
								obj = 2;
								((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003E1__state = 2;
								obj3 = 7;
								if (((DesktopAuthentication._003CConnect_003Ed__19)DesktopAuthentication._003CConnect_003Ed__19._003C_003Et__builder)._003C_003E4__this == null)
								{
									obj3 = 39;
								}
								continue;
							case 9:
							{
								EntityAuthServer entityAuthServer = ((DesktopAuthentication._003CConnect_003Ed__19)this).authServer;
								((TaskCompletionSource)DesktopAuthentication._003CConnect_003Ed__19.VerifyTracer())._002Ector();
								obj = ((TaskCompletionSource)(object)entityAuthServer).Task;
								obj3 = 37;
								continue;
							}
							case 31:
								Unsafe.As<int, AsyncTaskMethodBuilder<EntityRentalGameItem[]>>(ref ((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003E1__state) = default;
								obj3 = 18;
								if ((int)((DesktopAuthentication._003CHeartbeatAsync_003Ed__25*)(nint)DesktopAuthentication._003CHeartbeatAsync_003Ed__25._003C_003E4__this)->_003C_003Eu__1 == 0)
								{
									obj3 = 7;
								}
								continue;
							case 14:
								obj = 1;
								DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver = 1;
								obj3 = 34;
								continue;
							case 28:
								((AsyncTaskMethodBuilder<EntityGameModsHash>*)obj)->Start(ref *(DesktopSession._003CGetModHashListAsync_003Ed__26*)obj);
								Unsafe.Write(&((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)(nint)/*Error near IL_034d: Stack underflow*/)->_003C_003Et__builder, /*Error near IL_034d: Stack underflow*/);
								obj3 = 6;
								continue;
							case 15:
								obj = -1;
								((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003E4__this = (DesktopAuthentication)(-1);
								obj = 35;
								goto IL_01ce;
							case 18:
								obj = -1;
								((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Eu__1 = (TaskAwaiter)(-1);
								obj3 = 2;
								if (((DesktopAuthentication._003CReceiveAsync_003Ed__20*)(nint)DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24.ReflectMixedRunner)->_003C_003E1__state != 0)
								{
									obj3 = 16;
								}
								continue;
							case 4:
								_ = ref ((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003Et__builder;
								((AsyncTaskMethodBuilder<string>*)(&obj))->Start(ref Unsafe.As<_003CInitAsync_003Ed__14, DesktopSession._003CDownloadImageAsync_003Ed__34>(ref this));
								_ = 1;
								if (DesktopAuthentication._003CReceiveAsync_003Ed__20.CheckCommonTracker != null)
								{
									_ = 1;
								}
								continue;
							case 38:
								return;
							case 21:
								_ = ref ((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003E1__state;
								((AsyncTaskMethodBuilder<EntityItemChannel[]>*)(&obj))->Start(ref Unsafe.As<_003CInitAsync_003Ed__14, DesktopSession._003CGetItemChannelAsync_003Ed__42>(ref this));
								_ = 38;
								continue;
							case 30:
								obj = 0;
								((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003E4__this = (DesktopAuthentication)0;
								obj3 = 3;
								continue;
							case 5:
								goto IL_0404;
							case 24:
								goto IL_0416;
							case 23:
								obj = Enumerable.Concat<TSource>((IEnumerable<TSource>)/*Error near IL_042f: Stack underflow*/, (IEnumerable<TSource>)(&obj));
								obj3 = 33;
								continue;
							default:
								_ = ref DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22.DecorateBasicTag;
								((AsyncTaskMethodBuilder<EntityAuthItem>*)(&obj))->Start(ref Unsafe.As<_003CInitAsync_003Ed__14, DesktopSession._003CGetAuthItemsAsync_003Ed__48>(ref this));
								_ = 20;
								continue;
							case 11:
								goto IL_0453;
							case 32:
								obj = -1;
								((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-1);
								obj3 = 23;
								continue;
							case 27:
							{
								DesktopAuthentication desktopAuthentication = ((DesktopAuthentication._003CReceiveDataAsync_003Ed__21*)(nint)obj)->_003C_003E4__this;
								((DesktopAuthentication._003CSendPacketAsync_003Ed__28*)DesktopAuthentication._003CSendMessageAsync_003Ed__29.ReflectAutomatableMonitor())->MoveNext();
								((TaskCompletionSource)((DesktopAuthentication._003CReceiveDataAsync_003Ed__21*)(nint)obj)->_003Clength_003E5__2).SetResult();
								Unsafe.Write((void*)(nint)/*Error near IL_049c: Stack underflow*/, new DefaultInterpolatedStringHandler((int)/*Error near IL_049c: Stack underflow*/, (int)desktopAuthentication));
								obj3 = 29;
								continue;
							}
							case 6:
								((DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23*)(nint)obj)->_003C_003E1__state = (int)obj;
								obj3 = 27;
								continue;
							case 16:
							case 26:
								((DefaultInterpolatedStringHandler*)/*Error near IL_04c1: Stack underflow*/)->AppendFormatted<T>((T)/*Error near IL_04c1: Stack underflow*/, (string?)(&obj));
								obj = (object)/*Error near IL_04c3: Stack underflow*/;
								obj3 = 10;
								continue;
							case 3:
								((DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23)this).sid = (ushort)(int)obj;
								obj3 = 4;
								continue;
							case 39:
								((DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23)this).payload = (byte[])obj;
								obj3 = 0;
								if (DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23.ReflectScalableNotifier != null)
								{
									obj3 = 0;
								}
								continue;
							case 20:
								return;
							case 1:
								return;
							case 33:
							{
								object url = ((DesktopSession)/*Error near IL_0529: Stack underflow*/).EntityRequestAsync((object)/*Error near IL_0529: Stack underflow*/, (object)/*Error near IL_0529: Stack underflow*/, (byte)/*Error near IL_0529: Stack underflow*/);
								object body = obj;
								EnumGameType[] array = new EnumGameType[2]
								{
									(EnumGameType)44,
									EnumGameType.OnlineLobbyGame
								};
								obj = ((DesktopSession)/*Error near IL_0550: Stack underflow*/).EntitiesRequestAsync<EntityNetGameVersion>((string)/*Error near IL_0550: Stack underflow*/, (object)Enumerable.Take<TSource>((IEnumerable<TSource>)/*Error near IL_054a: Stack underflow*/, (int)((DesktopSession)/*Error near IL_0545: Stack underflow*/).RequestAsync<T>((string)url, body, (byte)(int)((List<byte>)(object)array).ToArray() != 0)), (byte)(int)null != 0);
								obj3 = 11;
								continue;
							}
							case 13:
								Unsafe.As<int, @null>(ref ((DesktopAuthentication._003CSendPacketAsync_003Ed__28)this)._003C_003E1__state) = null;
								obj3 = 32;
								continue;
							case 2:
								if (((List<byte>)(&obj)).Count != 0)
								{
									obj = 26;
									goto IL_01ce;
								}
								goto case 22;
							case 35:
								obj = ((TaskAwaiter<int>*)(&obj))->GetResult();
								obj3 = 4;
								if ((int)((DesktopAuthentication._003CSendPacketAsync_003Ed__28*)(nint)DesktopAuthentication._003CSendPacketAsync_003Ed__28._003C_003E4__this)->_003C_003Eu__1 == 0)
								{
									obj3 = 7;
								}
								continue;
							case 19:
								if ((int)((Task<int>)(&obj)).GetAwaiter() == 0)
								{
									obj3 = 14;
									continue;
								}
								goto case 35;
							case 29:
							{
								EntityGameModsHash modHashList = ((DesktopSession)/*Error near IL_05d5: Stack underflow*/).GetModHashList((EntityItemDownload[])((DesktopSession)Unsafe.AsPointer(ref this))._netGames);
								*(ulong*)(&obj) = default;
								((AsyncTaskMethodBuilder*)/*Error near IL_05e4: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<object>*)modHashList, ref *(DesktopSession._003CEntityRequestAsync_003Ed__9*)obj);
								obj = ((Stream)/*Error near IL_05e9: Stack underflow*/).WriteAsync((ReadOnlyMemory<byte>)/*Error near IL_05e9: Stack underflow*/, (CancellationToken)/*Error near IL_05e9: Stack underflow*/);
								obj3 = 19;
								continue;
							}
							case 8:
							{
								Task task = ((DesktopSession)((DesktopSession._003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed)this)._003C_003E1__state).LogoutAsync();
								obj = null;
								((AsyncTaskMethodBuilder<EntityCppGameClientInfo>*)/*Error near IL_060f: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityCppGameClientInfo>*)task, ref *(DesktopSession._003CGetCppGameClientInfo_003Ed__57*)obj);
								((BinaryWriter)/*Error near IL_0614: Stack underflow*/).Write((byte[])/*Error near IL_0614: Stack underflow*/);
								obj = (object)/*Error near IL_0616: Stack underflow*/;
								obj3 = 2;
								continue;
							}
							case 37:
								((NeteaseSession)/*Error near IL_064b: Stack underflow*/)._002Ector((string)/*Error near IL_064b: Stack underflow*/, (string)/*Error near IL_064b: Stack underflow*/, (byte)(&obj) != 0);
								if ((int)/*Error near IL_0650: Stack underflow*/ == 0)
								{
									obj3 = 30;
									continue;
								}
								goto case 23;
							case 12:
								((DesktopSession)/*Error near IL_065f: Stack underflow*/).GetGameCharactersAsync((EnumGameType)/*Error near IL_065f: Stack underflow*/, (string)/*Error near IL_065f: Stack underflow*/);
								throw new NeteaseSession();
							case 7:
							{
								object obj4 = obj;
								object obj5 = obj;
								if (obj5 == null)
								{
									((DesktopSession)/*Error near IL_0690: Stack underflow*/).AddRentalGameCharacterAsync((string)/*Error near IL_0690: Stack underflow*/, (string)obj4);
									/*Error near IL_0690: Member reference must be method, but was: Field*/;
								}
								DesktopSession._003C_003Ec__DisplayClass16_0.IncludeEvent = obj5;
								obj = 8;
								goto IL_01ce;
							}
							case 10:
								goto IL_06a9;
								IL_01ce:
								obj3 = obj;
								continue;
							}
							goto end_IL_019e;
							IL_06a9:
							object obj6 = obj;
							object obj7 = obj;
							if (obj7 == null)
							{
								((DesktopSession)/*Error near IL_06be: Stack underflow*/).GetAuthItemsAsync((EnumGameType)/*Error near IL_06be: Stack underflow*/, (EnumGameVersion)(int)obj6);
								/*Error near IL_06be: Member reference must be method, but was: Field*/;
							}
							((DesktopSession._003CAddGameCharacterAsync_003Ed__44*)(nint)obj6)->_003C_003E1__state = (int)obj7;
							obj3 = 25;
							continue;
							IL_0453:
							object obj8 = obj;
							if (obj8 == null)
							{
								obj3 = 12;
								continue;
							}
							((Dictionary<int, IDesktopSkin[]>)obj8).Clear();
							((AsyncTaskMethodBuilder<EntityItemDownload>*)/*Error near IL_066f: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityItemDownload>*)/*Error near IL_066f: Stack underflow*/, ref *(DesktopSession._003CGetItemDownloadAsync_003Ed__49*)/*Error near IL_066f: Stack underflow*/);
							obj = (object)/*Error near IL_0671: Stack underflow*/;
							obj3 = 28;
							continue;
							end_IL_01d2:
							break;
						}
						goto case 1;
						IL_0416:
						obj = ((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003Eu__1;
						obj3 = 13;
						goto IL_01d2;
						IL_0404:
						obj = ((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this).data;
						obj3 = 31;
						goto IL_01d2;
						end_IL_019e:
						break;
					}
					goto case 6;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_F700(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778874, new IntPtr(2737336617756L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_F800(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected VT, but got Ref
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
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
					((EqualityComparer<_00211>)/*Error near IL_0044: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
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
		internal static byte _FF00_FF00豈()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00切()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00ﬀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778853, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoginAsync_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<DesktopSession> _003C_003Et__builder;

		public string cookies;

		public NeteaseDesktop _003C_003E4__this;

		private TaskAwaiter<DesktopSession> _003C_003Eu__1;

		private static object CompressParameter;

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
		internal static bool ReflectScopeDecryptor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateStaticError()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_E300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778852, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_E400()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0406: Expected native int or pointer, but got Obj
			//IL_0423: Expected Obj, but got VT
			//IL_03d5: Expected Obj, but got I4
			//IL_03ae: Expected I4, but got Obj
			//IL_03ae: Expected Obj, but got Ref
			//IL_03b8: Expected native int or pointer, but got Obj
			//IL_017c: Expected Obj, but got Ref
			//IL_01d7: Expected Obj, but got Ref
			//IL_01e6: Expected Obj, but got I4
			//IL_0103: Expected Obj, but got Ref
			//IL_0113: Expected Obj, but got Ref
			//IL_0124: Expected Obj, but got I4
			//IL_01a2: Expected Obj, but got I4
			//IL_01a7: Expected Obj, but got I4
			//IL_01a7: Expected Obj, but got Ref
			//IL_00c3: Expected VT, but got Ref
			//IL_00ec: Expected Obj, but got I4
			//IL_00f1: Expected Obj, but got I4
			//IL_00f1: Expected Obj, but got Ref
			//IL_00b7: Expected Obj, but got I4
			//IL_0228: Expected native int or pointer, but got Obj
			//IL_00a0: Expected I4, but got Obj
			//IL_0410->IL0026: Incompatible stack types: I4 vs Obj
			//IL_042d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03e9->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03c2->IL0026: Incompatible stack heights: 2 vs 1
			//IL_01c6->IL005f: Incompatible stack types: I4 vs Obj
			//IL_005b->IL005f: Incompatible stack types: I4 vs Obj
			//IL_041b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03f4->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03cd->IL0026: Incompatible stack heights: 2 vs 1
			//IL_01d1->IL005f: Incompatible stack types: I4 vs Obj
			//IL_0192->IL005f: Incompatible stack types: I4 vs Obj
			//IL_010d->IL005f: Incompatible stack types: I4 vs Obj
			//IL_0176->IL005f: Incompatible stack types: I4 vs Obj
			//IL_01b1->IL005f: Incompatible stack types: I4 vs Obj
			//IL_00fb->IL005f: Incompatible stack types: I4 vs Obj
			//IL_00bc->IL005b: Incompatible stack heights: 1 vs 0
			//IL_019d->IL005f: Incompatible stack types: I4 vs Obj
			//IL_00dc->IL005f: Incompatible stack types: I4 vs Obj
			//IL_00e7->IL005f: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 3;
			object obj = awaiter;
			while (true)
			{
				object obj2;
				switch ((int)obj)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					if (awaiter == null)
					{
						obj2 = 10;
						goto IL_005f;
					}
					goto IL_01b1;
				case 5:
					((TcpClient)/*Error near IL_03ae: Stack underflow*/).ConnectAsync((IPAddress)Unsafe.AsPointer(ref ((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003E1__state), (int)awaiter);
					_ = 0;
					if ((int)((DesktopAuthentication._003CReceiveAsync_003Ed__20*)(nint)DesktopAuthentication._003CReceiveAsync_003Ed__20._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						_ = 0;
					}
					break;
				case 4:
					goto IL_03cd;
				case 2:
					awaiter = ((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003E4__this;
					obj = 0;
					if ((int)((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22*)(nint)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22.data)->_003C_003Eu__1 == 0)
					{
						obj = 1;
					}
					break;
				case 3:
					{
						awaiter = ((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003Eu__2;
						obj = 2;
						break;
					}
					IL_01b1:
					obj2 = 14;
					if (((DesktopAuthentication)DesktopAuthentication._handshakeTcs)._authenticationTcs == null)
					{
						obj2 = 14;
					}
					goto IL_005f;
					IL_03cd:
					DesktopAuthentication._003CReceiveAsync_003Ed__20.CheckCommonTracker = -2;
					obj = 5;
					if ((int)((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22*)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj = 4;
					}
					break;
					IL_005f:
					while (true)
					{
						switch ((int)obj2)
						{
						case 12:
							return;
						case 5:
						case 13:
							_ = ref awaiter;
							awaiter = EqualityComparer<_00211>.Default;
							awaiter = 8;
							goto IL_005b;
						case 9:
							if (((EqualityComparer<_00211>)/*Error near IL_00c3: Stack underflow*/).Equals((_00211?)/*Error near IL_00c3: Stack underflow*/, (_00211?)(&awaiter)))
							{
								obj2 = 5;
								if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
								{
									obj2 = 3;
								}
								continue;
							}
							goto case 11;
						case 11:
							awaiter = 0;
							DesktopAuthentication.Crc32 = 0;
							obj2 = 3;
							continue;
						case 3:
							DesktopAuthentication.Logger = awaiter;
							obj2 = 6;
							continue;
						case 6:
							Unsafe.As<byte[], AsyncTaskMethodBuilder>(ref DesktopAuthentication.TokenKey).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CLoginAsync_003Ed__15, DesktopAuthentication._003CAuthentication_003Ed__27>(ref this));
							awaiter = 12;
							goto IL_005b;
						case 4:
							awaiter = ((AsyncTaskMethodBuilder*)((DesktopAuthentication)awaiter).ReceiveDataAsync(awaiter))->Task;
							obj2 = 9;
							continue;
						default:
							awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeKey;
							obj2 = 0;
							if (((DesktopAuthentication)DesktopAuthentication._encryptedToken)._encryptChaCha == null)
							{
								obj2 = 1;
							}
							continue;
						case 7:
							awaiter = -1;
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._decryptChaCha = -1;
							obj2 = 13;
							continue;
						case 2:
							break;
						case 1:
							Unsafe.As<DesktopAuthentication, AsyncTaskMethodBuilder<EntitySkinItem>>(ref DesktopAuthentication.PrepareDic) = default;
							awaiter = 7;
							goto IL_005b;
						case 14:
						{
							((AsyncTaskMethodBuilder*)/*Error near IL_021c: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<int>*)((DesktopAuthentication._003CAuthentication_003Ed__27)this).modHashList, ref *(DesktopAuthentication._003CReceiveDataAsync_003Ed__21*)null);
							awaiter = (object)/*Error near IL_021e: Stack underflow*/;
							int num = 0;
							if ((int)((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27._003Ccts_003E5__2)->_003C_003Eu__1 != 0)
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
									if (awaiter != null)
									{
										num = 1;
										if (DesktopAuthentication._003CAuthentication_003Ed__27.ReflectInternalAnnotation == null)
										{
											num = 0;
										}
										continue;
									}
									goto case 2;
								case 2:
									DesktopAuthentication._003CAuthentication_003Ed__27.PopChooser();
									throw new Task<byte[]>();
								}
								break;
							}
							goto case 4;
						}
						case 8:
							goto IL_03cd;
							IL_005b:
							obj2 = awaiter;
							continue;
						}
						break;
					}
					goto IL_01b1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_E500()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778855, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_E600(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_E700(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778854, new IntPtr(2737336621916L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_E800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778849, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_E900()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_EA00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778848, new IntPtr(2737336620876L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_EB00()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoginAsync_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<DesktopSession> _003C_003Et__builder;

		public EntityLoginOtpDto dto;

		public NeteaseDesktop _003C_003E4__this;

		private object _003CsAuth_003E5__2;

		private object _003CmgbSdk_003E5__3;

		private object _003Csession_003E5__4;

		private TaskAwaiter<EntityMgbSdk> _003C_003Eu__1;

		private TaskAwaiter<EntityLoginOtp> _003C_003Eu__2;

		private TaskAwaiter<EntityAuthenticationOtp> _003C_003Eu__3;

		private TaskAwaiter _003C_003Eu__4;

		internal static object ConvertFactory;

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
		internal static bool RateCompressor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QueryResponder()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778851, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FFFD()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_004f: Expected I4, but got Obj
			//IL_00a5: Expected Obj, but got Ref
			//IL_00ac: Expected VT, but got Obj
			//IL_00ac: Expected Obj, but got Ref
			//IL_005c: Expected Obj, but got I4
			//IL_005c: Expected Obj, but got Ref
			//IL_006c: Expected Obj, but got Ref
			//IL_0093: Expected Obj, but got Ref
			//IL_00e3: Expected I4, but got Obj
			//IL_09b4: Expected I4, but got Obj
			//IL_007f: Expected Obj, but got Ref
			//IL_0088: Expected Obj, but got I4
			//IL_0771: Expected Obj, but got VT
			//IL_07de: Expected Obj, but got VT
			//IL_0811: Expected Obj, but got VT
			//IL_00f2: Expected Obj, but got I
			//IL_0736: Expected Obj, but got I4
			//IL_073b: Expected VT, but got I4
			//IL_0851: Expected Obj, but got VT
			//IL_0628: Expected Obj, but got Ref
			//IL_07c5: Expected Obj, but got VT
			//IL_07cc: Expected Obj, but got VT
			//IL_04e8: Expected Obj, but got I4
			//IL_05a0: Expected Obj, but got I4
			//IL_0493: Expected Obj, but got I4
			//IL_0498: Expected Obj, but got I4
			//IL_04a1: Expected Obj, but got I4
			//IL_0340: Expected Obj, but got Ref
			//IL_0206: Expected Obj, but got Ref
			//IL_0212: Expected Ref, but got VT
			//IL_0217: Expected Obj, but got I
			//IL_0220: Expected Obj, but got I4
			//IL_0245: Expected I4, but got Obj
			//IL_0245: Expected Obj, but got Ref
			//IL_0438: Expected native int or pointer, but got Obj
			//IL_022b: Expected Obj, but got Ref
			//IL_02c1: Expected VT, but got Obj
			//IL_02f1: Expected Obj, but got Ref
			//IL_02f6: Expected VT, but got Obj
			//IL_050f: Expected Obj, but got I4
			//IL_0567: Expected I4, but got Obj
			//IL_056c: Expected I4, but got Obj
			//IL_0823: Expected Obj, but got I4
			//IL_05f8: Expected VT, but got Obj
			//IL_05c9: Expected Obj, but got I4
			//IL_05ce: Expected Obj, but got I4
			//IL_05d7: Expected Obj, but got I4
			//IL_0534: Expected native int or pointer, but got Obj
			//IL_060f: Expected I4, but got Obj
			//IL_061d: Expected Obj, but got I4
			//IL_05e1: Expected Obj, but got I4
			//IL_05e6: Expected Obj, but got I4
			//IL_0282: Expected Obj, but got Ref
			//IL_058c: Expected Obj, but got I4
			//IL_0591: Expected Obj, but got I4
			//IL_04fe: Expected Obj, but got Ref
			//IL_03df: Expected Obj, but got VT
			//IL_03e6: Expected Obj, but got Ref
			//IL_067b: Expected I4, but got Obj
			//IL_0692: Expected I4, but got Obj
			//IL_0695: Expected native int or pointer, but got Obj
			//IL_069f: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a6: Expected Obj, but got Ref
			//IL_02d2: Expected Obj, but got Ref
			//IL_07b0: Expected VT, but got Obj
			//IL_0793: Expected native int or pointer, but got Obj
			//IL_0871: Expected VT, but got Obj
			//IL_087b: Expected native int or pointer, but got Obj
			//IL_0397: Expected native int or pointer, but got Obj
			//IL_034f: Expected native int or pointer, but got Obj
			//IL_0291: Expected native int or pointer, but got Obj
			//IL_02e0: Expected Obj, but got I4
			//IL_087b: Expected native int or pointer, but got Obj
			//IL_01eb: Expected I4, but got Obj
			//IL_00c0->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0066->IL0026: Incompatible stack types: I4 vs Obj
			//IL_09ad->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0078->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_09c8->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00cb->IL0026: Incompatible stack heights: 2 vs 1
			//IL_077b->IL0106: Incompatible stack types: I4 vs Obj
			//IL_03c8->IL0106: Incompatible stack types: I4 vs Obj
			//IL_07e8->IL0106: Incompatible stack types: I4 vs Obj
			//IL_081b->IL0106: Incompatible stack types: I4 vs Obj
			//IL_00f7->IL0106: Incompatible stack types: I4 vs Obj
			//IL_09d3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03d3->IL0106: Incompatible stack types: I4 vs Obj
			//IL_0102->IL0106: Incompatible stack types: I4 vs Obj
			//IL_0745->IL0106: Incompatible stack types: I4 vs Obj
			//IL_055a->IL0106: Incompatible stack heights: 2 vs 1
			//IL_0857->IL086c: Incompatible stack types: Obj vs VT
			//IL_0638->IL0106: Incompatible stack types: I4 vs Obj
			//IL_07d6->IL0106: Incompatible stack heights: 2 vs 1
			//IL_04f7->IL0106: Incompatible stack types: I4 vs Obj
			//IL_05b9->IL0106: Incompatible stack types: I4 vs Obj
			//IL_0731->IL0106: Incompatible stack types: I4 vs Obj
			//IL_0809->IL0106: Incompatible stack types: I4 vs Obj
			//IL_0257->IL0106: Incompatible stack types: I4 vs Obj
			//IL_04e3->IL0106: Incompatible stack types: I4 vs Obj
			//IL_0442->IL0106: Incompatible stack heights: 2 vs 1
			//IL_023b->IL0106: Incompatible stack types: I4 vs Obj
			//IL_032a->IL0106: Incompatible stack heights: 2 vs 1
			//IL_02cb->IL0106: Incompatible stack types: I4 vs Obj
			//IL_0300->IL0106: Incompatible stack types: I4 vs Obj
			//IL_051e->IL0106: Incompatible stack types: I4 vs Obj
			//IL_0578->IL0106: Incompatible stack types: I4 vs Obj
			//IL_0837->IL0106: Incompatible stack types: I4 vs Obj
			//IL_0312->IL0106: Incompatible stack types: I4 vs Obj
			//IL_0602->IL0106: Incompatible stack types: I4 vs Obj
			//IL_02b9->IL0106: Incompatible stack types: I4 vs Obj
			//IL_053e->IL0106: Incompatible stack types: I4 vs Obj
			//IL_0622->IL0102: Incompatible stack heights: 2 vs 0
			//IL_0377->IL0106: Incompatible stack types: I4 vs Obj
			//IL_0674->IL0106: Incompatible stack types: I4 vs Obj
			//IL_05f0->IL0106: Incompatible stack types: I4 vs Obj
			//IL_046a->IL0106: Incompatible stack types: I4 vs Obj
			//IL_059b->IL0106: Incompatible stack types: I4 vs Obj
			//IL_050a->IL0106: Incompatible stack types: I4 vs Obj
			//IL_03eb->IL055a: Incompatible stack heights: 1 vs 0
			//IL_0420->IL0106: Incompatible stack types: I4 vs Obj
			//IL_07ba->IL0106: Incompatible stack types: I4 vs Obj
			//IL_079d->IL0106: Incompatible stack types: I4 vs Obj
			//IL_0885->IL0106: Incompatible stack types: I4 vs Obj
			//IL_086c->IL086c: Incompatible stack types: I4 vs Ref
			//IL_03a1->IL0106: Incompatible stack types: I4 vs Obj
			//IL_05c4->IL0106: Incompatible stack types: I4 vs Obj
			//IL_0359->IL0106: Incompatible stack types: I4 vs Obj
			//IL_044d->IL0106: Incompatible stack heights: 2 vs 1
			//IL_0842->IL0106: Incompatible stack types: I4 vs Obj
			//IL_04c6->IL0106: Incompatible stack types: I4 vs Obj
			//IL_0549->IL0106: Incompatible stack types: I4 vs Obj
			//IL_029b->IL0106: Incompatible stack types: I4 vs Obj
			//IL_03ff->IL0106: Incompatible stack heights: 2 vs 1
			//IL_07a8->IL0106: Incompatible stack types: I4 vs Obj
			//IL_0890->IL0106: Incompatible stack types: I4 vs Obj
			//IL_03ac->IL0106: Incompatible stack types: I4 vs Obj
			//IL_0364->IL0106: Incompatible stack types: I4 vs Obj
			//IL_04d1->IL0106: Incompatible stack types: I4 vs Obj
			//IL_02a6->IL0106: Incompatible stack types: I4 vs Obj
			//IL_040a->IL0106: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 4;
			while (true)
			{
				object obj = awaiter;
				while (true)
				{
					switch ((int)obj)
					{
					case 1:
						((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP = -2;
						obj = 7;
						continue;
					case 3:
						awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserToken_003EP;
						obj = 5;
						continue;
					case 7:
						break;
					case 4:
						awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP;
						obj = 3;
						continue;
					default:
						((EqualityComparer<_00211>)Unsafe.AsPointer(ref DesktopAuthentication.Crc32)).GetHashCode((_00211)awaiter);
						_ = 8;
						if (((DesktopAuthentication)(object)DesktopAuthentication.TokenKey)._client == null)
						{
							_ = 4;
						}
						continue;
					case 5:
					{
						object obj2;
						switch ((int)awaiter)
						{
						default:
							obj2 = 25;
							if (((DesktopAuthentication)DesktopAuthentication._connected)._buffer == null)
							{
								obj2 = 2;
							}
							goto IL_0106;
						case 1:
							awaiter = DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver;
							obj2 = 40;
							if ((int)((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								obj2 = 53;
							}
							goto IL_0106;
						case 0:
							goto IL_0769;
						case 2:
							goto IL_07d6;
						case 3:
							goto IL_0809;
							IL_0106:
							while (true)
							{
								switch ((int)obj2)
								{
								case 23:
								case 36:
									break;
								case 12:
								{
									nint handshakeSent = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeSent;
									((AsyncTaskMethodBuilder*)AsyncTaskMethodBuilder.Create())->Start<TStateMachine>(ref *(TStateMachine*)awaiter);
									((TcpClient)handshakeSent).Close();
									awaiter = 2;
									goto IL_0102;
								}
								case 21:
									((DesktopAuthentication)Unsafe.AsPointer(ref this))._decryptChaCha = null;
									obj2 = 10;
									continue;
								case 15:
								{
									object prepareDic = (awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this)).SendPacketAsync((byte)(int)awaiter, awaiter));
									DesktopAuthentication.PrepareDic = (DesktopAuthentication)prepareDic;
									obj2 = 6;
									continue;
								}
								case 30:
									return;
								case 45:
									((IAsyncStateMachine)(&awaiter)).MoveNext();
									if ((int)/*Error near IL_0287: Stack underflow*/ == 0)
									{
										obj2 = 37;
										if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27.modHashList)->serverIdHash != null)
										{
											obj2 = 10;
										}
										continue;
									}
									goto case 1;
								case 16:
								case 35:
									awaiter = ((TaskAwaiter<byte[]>*)(&awaiter))->GetResult();
									obj2 = 34;
									continue;
								case 24:
									((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Eu__1 = (TaskAwaiter<byte[]>)awaiter;
									obj2 = 19;
									continue;
								case 52:
									if ((int)((Task)(&awaiter)).GetAwaiter() != 0)
									{
										awaiter = 51;
										goto IL_0102;
									}
									goto default;
								case 25:
									Unsafe.Write(&((DesktopAuthentication._003CConnect_003Ed__19*)(nint)/*Error near IL_02f6: Stack underflow*/)->_003C_003Et__builder, (AsyncTaskMethodBuilder)((MassService)/*Error near IL_02f1: Stack underflow*/).JoinServerAsync((byte[])/*Error near IL_02f1: Stack underflow*/, (string)/*Error near IL_02f1: Stack underflow*/, (string)/*Error near IL_02f1: Stack underflow*/, (string)/*Error near IL_02f1: Stack underflow*/, (string)Unsafe.AsPointer(ref this), (string)DesktopAuthentication._003CAuthentication_003Ed__27.ReflectInternalAnnotation));
									obj2 = 14;
									continue;
								case 32:
									((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003E4__this = (DesktopAuthentication)awaiter;
									obj2 = 22;
									continue;
								case 22:
									_ = ref ((DesktopAuthentication._003CConnect_003Ed__19)this).authServer;
									((AsyncTaskMethodBuilder<EntityNetGameItem[]>*)(&awaiter))->Start(ref Unsafe.As<_003CLoginAsync_003Ed__16, DesktopSession._003CGetNetGamesAsync_003Ed__15>(ref this));
									_ = 27;
									continue;
								case 11:
									((TaskCompletionSource)(&awaiter))._002Ector();
									if ((int)/*Error near IL_0345: Stack underflow*/ != 0)
									{
										obj2 = 16;
										if (((DesktopAuthentication._003CHeartbeatAsync_003Ed__25*)(nint)DesktopAuthentication._003CConnect_003Ed__19.CheckAdjustableCommand)->_003C_003E1__state == 0)
										{
											obj2 = 10;
										}
										continue;
									}
									goto case 46;
								case 41:
								case 51:
									((Action)/*Error near IL_036b: Stack underflow*/)._002Ector((object)/*Error near IL_036b: Stack underflow*/, (nint)(&awaiter));
									awaiter = (object)/*Error near IL_036d: Stack underflow*/;
									obj2 = 50;
									continue;
								case 6:
									if (awaiter != null)
									{
										obj2 = 17;
										if ((int)((DesktopAuthentication._003CHeartbeatAsync_003Ed__25*)(nint)DesktopAuthentication._003CHeartbeatAsync_003Ed__25._003C_003E4__this)->_003C_003Eu__1 == 0)
										{
											obj2 = 12;
										}
										continue;
									}
									goto case 29;
								case 28:
									goto end_IL_0106;
								case 48:
									IPAddress.Parse((string)((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Eu__1);
									if (((EntityAuthServer)(&awaiter)).Port != 0)
									{
										_ = 15;
										if (((DesktopAuthentication._003CReceiveAsync_003Ed__20)DesktopAuthentication._003CReceiveAsync_003Ed__20._003C_003Et__builder)._003C_003E4__this != null)
										{
											_ = 15;
										}
										continue;
									}
									goto case 29;
								case 53:
									Unsafe.As<TaskAwaiter, @null>(ref ((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003Eu__1) = null;
									obj2 = 7;
									continue;
								case 19:
									_ = ref ((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003E1__state;
									((AsyncTaskMethodBuilder<EntityItemChannel[]>*)(&awaiter))->Start(ref Unsafe.As<_003CLoginAsync_003Ed__16, DesktopSession._003CGetItemChannelAsync_003Ed__42>(ref this));
									_ = 30;
									if (((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22*)(nint)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22._003C_003E4__this)->data == null)
									{
										_ = 6;
									}
									continue;
								case 44:
									((AuthenticationException)Enumerable.Concat<TSource>((IEnumerable<TSource>)/*Error near IL_0455: Stack underflow*/, (IEnumerable<TSource>)awaiter))._002Ector((string?)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22.DecorateBasicTag);
									obj2 = 4;
									continue;
								case 20:
									return;
								case 10:
									awaiter = -1;
									((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this).buffer = (byte[])(-1);
									awaiter = 47;
									goto IL_0102;
								case 33:
									((Salsa20Engine)/*Error near IL_04ad: Stack underflow*/).ProcessBytes((byte[])/*Error near IL_04ad: Stack underflow*/, (int)/*Error near IL_04ad: Stack underflow*/, (int)/*Error near IL_04ad: Stack underflow*/, (byte[])/*Error near IL_04ad: Stack underflow*/, (int)(&awaiter));
									if ((int)/*Error near IL_04b2: Stack underflow*/ != 0)
									{
										obj2 = 10;
										if ((int)((DesktopAuthentication._003CReceiveDataAsync_003Ed__21*)DesktopAuthentication._003CReceiveDataAsync_003Ed__21._003Clength_003E5__2)->_003C_003Eu__2 != 0)
										{
											obj2 = 13;
										}
										continue;
									}
									goto case 26;
								case 17:
									awaiter = DesktopAuthentication._003CReceiveDataAsync_003Ed__21.CheckActiveRecommender;
									obj2 = 23;
									continue;
								case 7:
									awaiter = -1;
									((DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23)this)._003C_003E1__state = -1;
									obj2 = 41;
									continue;
								case 13:
								case 47:
									((DefaultInterpolatedStringHandler*)/*Error near IL_04fe: Stack underflow*/)->AppendFormatted<T>((T)/*Error near IL_04fe: Stack underflow*/, (string?)(&awaiter));
									awaiter = (object)/*Error near IL_0500: Stack underflow*/;
									obj2 = 12;
									continue;
								case 26:
									awaiter = 2;
									((DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23)this).sid = 2;
									obj2 = 9;
									continue;
								case 39:
									((DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23)this).payload = null;
									obj2 = 5;
									if (((DesktopAuthentication._003CSendMessageAsync_003Ed__29*)(nint)DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23.ReflectScalableNotifier)->_003C_003E1__state == 0)
									{
										obj2 = 8;
									}
									continue;
								case 1:
									((List<byte>)/*Error near IL_0550: Stack underflow*/).GetRange((int)/*Error near IL_0550: Stack underflow*/, (int)(&awaiter));
									_ = 31;
									continue;
								case 29:
									awaiter = Enumerable.Take<TSource>((IEnumerable<TSource>)/*Error near IL_056c: Stack underflow*/, (int)((DesktopSession)/*Error near IL_0567: Stack underflow*/).RequestAsync<T>((string)/*Error near IL_0567: Stack underflow*/, awaiter, (byte)(int)((DesktopAuthentication._003CSendMessageAsync_003Ed__29)this)._003C_003E4__this != 0));
									obj2 = 52;
									continue;
								case 27:
									return;
								case 46:
									awaiter = 0;
									DesktopAuthentication._003CSendMessageAsync_003Ed__29.CheckAccessibleCalculator = 0;
									obj2 = 24;
									continue;
								case 8:
									awaiter = -1;
									((DesktopAuthentication._003CSendPacketAsync_003Ed__28)this)._003C_003E1__state = -1;
									obj2 = 1;
									if (((DesktopAuthentication._003CSendPacketAsync_003Ed__28)DesktopAuthentication._003CSendPacketAsync_003Ed__28._003C_003Et__builder).id == 0)
									{
										obj2 = 1;
									}
									continue;
								case 37:
									awaiter = 3;
									((DesktopAuthentication._003CSendPacketAsync_003Ed__28)this).data = (byte[])3;
									awaiter = 54;
									goto IL_0102;
								case 43:
									awaiter = -1;
									((DesktopAuthentication._003CSendPacketAsync_003Ed__28)this)._003C_003E4__this = (DesktopAuthentication)(-1);
									obj2 = 35;
									continue;
								case 34:
									((DesktopAuthentication._003CSendPacketAsync_003Ed__28)this)._003C_003Eu__1 = (TaskAwaiter)awaiter;
									obj2 = 48;
									continue;
								case 40:
									_ = DesktopAuthentication._003CSendPacketAsync_003Ed__28.CheckIterableSynchronizer;
									_ = ((ValueTaskAwaiter*)BitConverter.GetBytes((ushort)(int)awaiter))->IsCompleted;
									awaiter = 44;
									goto IL_0102;
								case 3:
									Unsafe.As<nint, @null>(ref ((DesktopSession)Unsafe.AsPointer(ref this))._skinTotal) = null;
									obj2 = 43;
									continue;
								case 18:
									return;
								case 42:
									Unsafe.As<AsyncTaskMethodBuilder<Entities<EntityNetGameItem>>, AsyncTaskMethodBuilder<bool>>(ref ((DesktopSession._003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed)this)._003C_003Et__builder).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CLoginAsync_003Ed__16, DesktopSession._003CGetBuyItemResultAsync_003Ed__28>(ref this));
									obj2 = 18;
									continue;
								case 50:
								{
									BinaryWriter binaryWriter = (BinaryWriter)new BinaryWriter((byte)(int)awaiter);
									BinaryWriter binaryWriter2 = (BinaryWriter)new BinaryWriter((byte[])(object)binaryWriter);
									((Dictionary<int, IDesktopSkin[]>)(object)((DesktopSession._003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed)this)._003CversionDictionary_003E5__3)._002Ector();
									((NeteaseSession)/*Error near IL_0692: Stack underflow*/)._002Ector((string)(object)binaryWriter, (string)(object)binaryWriter2, (byte)(int)binaryWriter2 != 0);
									/*Error near IL_0692: Stack underflow*/;
									((NeteaseSession)DesktopSession._003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed.UpdateRecord).Dispose();
									_ = DesktopSession._003C_003Ec._003C_003E9__15_2;
									AsyncTaskMethodBuilder<_0021_00210>.Create();
									/*Error near IL_06ab: Member reference must be method, but was: Field*/;
								}
								case 9:
									((DesktopSession._003CAddRentalGameCharacterAsync_003Ed__45)this).name = (string)awaiter;
									obj2 = 55;
									continue;
								default:
									awaiter = 1;
									((DesktopSession._003CAddRentalGameCharacterAsync_003Ed__45)this)._003C_003Eu__1 = (TaskAwaiter)1;
									obj2 = 32;
									continue;
								case 38:
									goto IL_0769;
								case 55:
									Unsafe.As<string, AsyncTaskMethodBuilder<EntityRentalGameAddress>>(ref ((DesktopSession._003CDownloadImageAsync_003Ed__34)this).url).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityRentalGameAddress>*)(&awaiter), ref Unsafe.As<_003CLoginAsync_003Ed__16, DesktopSession._003CGetRentalGameAddressAsync_003Ed__47>(ref this));
									obj2 = 20;
									if (((DesktopSession._003CDownloadImageAsync_003Ed__34*)(nint)DesktopSession._003CDownloadImageAsync_003Ed__34._003CimageName_003E5__2)->_003CimagePath_003E5__3 == null)
									{
										obj2 = 7;
									}
									continue;
								case 54:
									((DesktopSession._003CDownloadImageAsync_003Ed__34)this)._003C_003Eu__1 = (TaskAwaiter<byte[]?>)awaiter;
									obj2 = 42;
									continue;
								case 4:
									((DesktopSession._003C_003Ec__DisplayClass16_0)/*Error near IL_07c5: Stack underflow*/)._003CGetNetGame_003Eb__0((EntityNetGameItem)((DesktopSession._003CDownloadImageAsync_003Ed__34)this)._003C_003Eu__2);
									awaiter = AsyncTaskMethodBuilder<EntityNetGameItem[]>.Create();
									_ = 45;
									continue;
								case 5:
									goto IL_07d6;
								case 14:
									((AsyncTaskMethodBuilder<EntityNetGameItem[]>*)/*Error near IL_07ed: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)/*Error near IL_07ed: Stack underflow*/);
									((SessionContext<DesktopSession, EntityNetGameItem>)/*Error near IL_07f8: Stack underflow*/)._002Ector((DesktopSession)/*Error near IL_07f8: Stack underflow*/, (EntityNetGameItem)(object)((DesktopSession._003CEntitiesRequestAsync_003Ed__11<>)this).url);
									((Func<EntityNetGameItem, bool>)/*Error near IL_07fd: Stack underflow*/)._002Ector((object)/*Error near IL_07fd: Stack underflow*/, (nint)/*Error near IL_07fd: Stack underflow*/);
									awaiter = (object)/*Error near IL_07ff: Stack underflow*/;
									obj2 = 11;
									continue;
								case 49:
									goto IL_0809;
								case 31:
									awaiter = ((DesktopSession._003CEntityRequestAsync_003Ed__10<>)this)._003C_003E1__state;
									obj2 = 36;
									if (((DesktopSession._003CEntityRequestAsync_003Ed__10<>)DesktopSession._003CEntityRequestAsync_003Ed__10<>._003C_003Et__builder)._003C_003E4__this == null)
									{
										obj2 = 27;
									}
									continue;
								case 2:
									{
										ref _003CLoginAsync_003Ed__16 reference = ref this;
										object obj3 = awaiter;
										((DesktopSession._003CAddRentalGameCharacterAsync_003Ed__45*)awaiter)->SetStateMachine((IAsyncStateMachine)AsyncTaskMethodBuilder<EntitySkinItem>.Create());
										DesktopSession._003CDownloadImageAsync_003Ed__34 obj4 = (DesktopSession._003CDownloadImageAsync_003Ed__34)obj3;
										if (obj3 == null)
										{
											Unsafe.As<_003CLoginAsync_003Ed__16, AsyncTaskMethodBuilder<EntitySkinItem>>(ref reference).Start<TStateMachine>(ref *(TStateMachine*)awaiter);
											((AsyncTaskMethodBuilder<EntitySkinItem[]>*)/*Error near IL_0866: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)awaiter);
											obj4 = (DesktopSession._003CDownloadImageAsync_003Ed__34)new DesktopSession._003CDownloadImageAsync_003Ed__34();
											reference = ref *(_003CLoginAsync_003Ed__16*)1;
										}
										Unsafe.As<_003CLoginAsync_003Ed__16, DesktopSession._003CEntityRequestAsync_003Ed__9>(ref reference)._003C_003Et__builder = (AsyncTaskMethodBuilder)obj4;
										obj2 = 4;
										if (((DesktopSession._003CEntityRequestAsync_003Ed__9*)(nint)DesktopSession._003CEntityRequestAsync_003Ed__9._003C_003E4__this)->url == null)
										{
											obj2 = 40;
										}
										continue;
									}
									IL_0102:
									obj2 = awaiter;
									continue;
								}
								goto end_IL_00ce;
								continue;
								end_IL_0106:
								break;
							}
							goto case 1;
							IL_0809:
							awaiter = ((DesktopSession._003CEntitiesRequestAsync_003Ed__11<>)this)._003C_003Eu__1;
							obj2 = 39;
							goto IL_0106;
							IL_07d6:
							awaiter = ((DesktopSession._003CEntitiesRequestAsync_003Ed__11<>)this)._003C_003Et__builder;
							obj2 = 21;
							goto IL_0106;
							IL_0769:
							awaiter = ((DesktopSession._003CDownloadImageAsync_003Ed__34)this)._003C_003Et__builder;
							obj2 = 3;
							goto IL_0106;
							end_IL_00ce:
							break;
						}
						goto case 1;
					}
					case 8:
						return;
					case 2:
						DesktopSession._003CGetBuyItemResultAsync_003Ed__28.SerializeNotifier = null;
						obj = 6;
						continue;
					case 6:
						((DesktopSession._003CGetCppGameClientInfo_003Ed__57)this)._003C_003E1__state = (int)null;
						obj = 0;
						if (((DesktopSession._003CGetCppGameClientInfo_003Ed__57)DesktopSession._003CGetCppGameClientInfo_003Ed__57._003C_003Et__builder)._003C_003E4__this == null)
						{
							obj = 0;
						}
						continue;
					}
					break;
				}
				((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CgameVersion_003EP = null;
				awaiter = 2;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FFFD(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778850, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FFFD(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FFFD()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778861, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FFFD()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_E000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778860, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoginOtpAsync_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityLoginOtp> _003C_003Et__builder;

		public NeteaseDesktop _003C_003E4__this;

		public EntityLoginOtpDto dto;

		private TaskAwaiter<RestResponse<Entity<EntityLoginOtp>>> _003C_003Eu__1;

		private static object DecorateAlphabeticPublisher;

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
		internal static bool FillEncryptor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SelectController()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00툀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778863, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00팀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_030d: Expected VT, but got I4
			//IL_0317: Expected native int or pointer, but got Obj
			//IL_02fb: Expected Obj, but got I4
			//IL_004e: Expected Obj, but got Ref
			//IL_0146: Expected Obj, but got Ref
			//IL_022a: Expected Obj, but got I4
			//IL_022f: Expected VT, but got I4
			//IL_01a5: Expected Obj, but got I4
			//IL_01aa: Expected Obj, but got I4
			//IL_01b3: Expected Obj, but got I4
			//IL_01e5: Expected native int or pointer, but got Obj
			//IL_01ef: Expected Obj, but got VT
			//IL_0220: Expected Obj, but got I4
			//IL_00e0: Expected Obj, but got Ref
			//IL_00b5: Expected VT, but got Ref
			//IL_00ba: Expected Obj, but got I4
			//IL_0136: Expected Obj, but got Ref
			//IL_01ce: Expected native int or pointer, but got Obj
			//IL_00a9: Expected I4, but got Obj
			//IL_0321->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02f3->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0305->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_032c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_015c->IL0070: Incompatible stack types: I4 vs Obj
			//IL_006c->IL0070: Incompatible stack types: I4 vs Obj
			//IL_0167->IL0070: Incompatible stack types: I4 vs Obj
			//IL_01a0->IL0070: Incompatible stack types: I4 vs Obj
			//IL_0239->IL0070: Incompatible stack types: I4 vs Obj
			//IL_017f->IL0070: Incompatible stack types: I4 vs Obj
			//IL_012e->IL0070: Incompatible stack types: I4 vs Obj
			//IL_00fc->IL0070: Incompatible stack heights: 2 vs 1
			//IL_00cb->IL0070: Incompatible stack types: I4 vs Obj
			//IL_0140->IL0070: Incompatible stack types: I4 vs Obj
			//IL_018a->IL0070: Incompatible stack types: I4 vs Obj
			//IL_01d8->IL0070: Incompatible stack types: I4 vs Obj
			//IL_0107->IL0070: Incompatible stack heights: 2 vs 1
			//IL_01e3->IL0070: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object stateMachine = 4;
			object obj = stateMachine;
			while (true)
			{
				object obj2;
				switch ((int)obj)
				{
				case 4:
					stateMachine = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
					obj = 3;
					continue;
				case 2:
					if (stateMachine != null)
					{
						obj2 = 5;
						goto IL_0070;
					}
					goto IL_0140;
				case 5:
					return;
				case 1:
					_ = ref ((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Eu__1;
					IPAddress.Parse((string)stateMachine);
					_ = 5;
					continue;
				case 3:
					{
						stateMachine = ((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003E1__state;
						obj = 2;
						continue;
					}
					IL_0070:
					while (true)
					{
						switch ((int)obj2)
						{
						default:
							return;
						case 11:
							((AsyncTaskMethodBuilder*)/*Error near IL_00bf: Stack underflow*/)->Start(ref *(((_003C_003Ef__AnonymousType0<, >)/*Error near IL_00ba: Stack underflow*/).Equals((object)((EqualityComparer<_00211>)/*Error near IL_00b5: Stack underflow*/).Equals((_00211?)/*Error near IL_00b5: Stack underflow*/, (_00211?)(&stateMachine))) ? ((DesktopAuthentication._003CHeartbeatAsync_003Ed__25*)1) : ((DesktopAuthentication._003CHeartbeatAsync_003Ed__25*)null)));
							stateMachine = (object)/*Error near IL_00c1: Stack underflow*/;
							obj2 = 6;
							continue;
						case 0:
							return;
						case 9:
							_ = ref DesktopAuthentication.Crc32;
							((AsyncTaskMethodBuilder*)(&stateMachine))->Start(ref Unsafe.As<_003CLoginOtpAsync_003Ed__17, DesktopAuthentication._003CSendPacketAsync_003Ed__28>(ref this));
							_ = 0;
							if (((DesktopAuthentication)(object)DesktopAuthentication.TokenKey)._client == null)
							{
								_ = 0;
							}
							continue;
						case 6:
						{
							object obj3 = ((DesktopAuthentication)(object)((DesktopAuthentication)/*Error near IL_010c: Stack underflow*/).Connect((EntityAuthServer)/*Error near IL_010c: Stack underflow*/)).ReceiveAsync();
							((List<byte>)stateMachine)._002Ector();
							((AsyncTaskMethodBuilder*)/*Error near IL_0124: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)obj3, ref *(DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)((AsyncTaskMethodBuilder*)stateMachine)->Task);
							obj2 = 3;
							continue;
						}
						case 12:
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptedToken = stateMachine;
							obj2 = 9;
							continue;
						case 10:
							break;
						case 3:
							stateMachine = stateMachine;
							obj2 = 4;
							if (DesktopAuthentication.PrepareDic == null)
							{
								obj2 = 8;
							}
							continue;
						case 1:
							Unsafe.As<int, AsyncTaskMethodBuilder<EntitySkinItem[]>>(ref ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E1__state) = default;
							obj2 = 2;
							continue;
						case 4:
							stateMachine = 0;
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E4__this = (DesktopAuthentication)0;
							stateMachine = 12;
							goto IL_006c;
						case 7:
							((AsyncTaskMethodBuilder*)/*Error near IL_01bf: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_01bf: Stack underflow*/, ref *(TStateMachine*)(&stateMachine));
							if ((int)/*Error near IL_01c4: Stack underflow*/ == 0)
							{
								obj2 = 4;
								if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27.serverIdHash)->_003Ccts_003E5__2 != null)
								{
									obj2 = 3;
								}
								continue;
							}
							goto case 11;
						case 5:
						{
							((DesktopAuthentication._003CAuthentication_003Ed__27*)/*Error near IL_01ef: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)stateMachine)->_003C_003Eu__1);
							MassService massService = new MassService();
							((AsyncTaskMethodBuilder<_0021_00210[]>*)((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003E1__state)->Start(ref *(DesktopSession._003CEntitiesRequestAsync_003Ed__11<_0021_00210>*)null);
							stateMachine = null;
							((AsyncTaskMethodBuilder<_0021_00210>*)massService)->Start(ref *(DesktopSession._003CRequestAsync_003Ed__13<_0021_00210>*)stateMachine);
							((TaskAwaiter*)1)->GetResult();
							stateMachine = (object)/*Error near IL_0217: Stack underflow*/;
							stateMachine = 7;
							goto IL_006c;
						}
						case 2:
							stateMachine = -1;
							((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003Eu__1 = (TaskAwaiter)(-1);
							obj2 = 11;
							continue;
						case 8:
							goto end_IL_0026;
							IL_006c:
							obj2 = stateMachine;
							continue;
						}
						break;
					}
					goto IL_0140;
					IL_0140:
					stateMachine = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptChaCha;
					obj2 = 1;
					if (((DesktopAuthentication)DesktopAuthentication._decryptChaCha)._handshakeTcs != null)
					{
						obj2 = 1;
					}
					goto IL_0070;
					end_IL_0026:
					break;
				}
				((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-2);
				obj = 1;
				if ((int)((DesktopAuthentication._003CReceiveAsync_003Ed__20*)(nint)DesktopAuthentication._003CReceiveAsync_003Ed__20._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					obj = 0;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00퐀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778862, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00픀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00혀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778857, new IntPtr(2737336616716L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00휀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FFFD()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSearchLanGameRoom_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityLanGameRoom[]> _003C_003Et__builder;

		public NeteaseDesktop _003C_003E4__this;

		public string name;

		private TaskAwaiter<RestResponse<EntityRelatedLanGameRoomResponse>> _003C_003Eu__1;

		internal static object DecorateSimpleVisitor;

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
		internal static bool WatchAllocator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectTransferableElement()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00씀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778856, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00였()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0336: Expected Obj, but got Ref
			//IL_02f8: Expected Obj, but got I4
			//IL_004e: Expected Obj, but got Ref
			//IL_012e: Expected Obj, but got Ref
			//IL_0138: Expected Obj, but got VT
			//IL_013e: Expected VT, but got I4
			//IL_013e: Expected Obj, but got VT
			//IL_014d: Expected Ref, but got VT
			//IL_01fc: Expected F8, but got Obj
			//IL_01c2: Expected Obj, but got I4
			//IL_01c7: Expected VT, but got I4
			//IL_01d6: Expected Obj, but got I4
			//IL_01db: Expected VT, but got I4
			//IL_00e9: Expected Obj, but got Ref
			//IL_0223: Expected I4, but got Obj
			//IL_022d: Expected Ref, but got VT
			//IL_022f: Expected Obj, but got Ref
			//IL_034a->IL0026: Incompatible stack heights: 2 vs 1
			//IL_030c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0329->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0355->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0317->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0105->IL009a: Incompatible stack heights: 2 vs 1
			//IL_020c->IL0223: Incompatible stack heights: 3 vs 5
			//IL_0110->IL009a: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				int num;
				object message;
				AsyncTaskMethodBuilder asyncTaskMethodBuilder;
				AsyncTaskMethodBuilder asyncTaskMethodBuilder2;
				switch ((int)obj2)
				{
				case 3:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
					obj2 = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
					{
						obj2 = 2;
					}
					break;
				case 4:
					if (obj == null)
					{
						num = 2;
						if (DesktopAuthentication.Crc32 != null)
						{
							num = 0;
						}
						goto IL_009a;
					}
					goto IL_0110;
				case 1:
					goto IL_02f0;
				case 2:
					obj = ((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003E4__this;
					obj2 = 4;
					break;
				default:
					((byte[])Unsafe.AsPointer(ref ((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this).data)).Xor((byte[])obj);
					_ = 5;
					if (DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22.DecorateBasicTag == null)
					{
						_ = 5;
					}
					break;
				case 5:
					return;
					IL_009a:
					while (true)
					{
						switch (num)
						{
						case 1:
							return;
						case 11:
							_ = ref DesktopAuthentication.Logger;
							((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CSearchLanGameRoom_003Ed__22, DesktopAuthentication._003CSendMessageAsync_003Ed__29>(ref this));
							_ = 1;
							if (((DesktopAuthentication)DesktopAuthentication._client)._connected == 0)
							{
								_ = 1;
							}
							continue;
						case 5:
							break;
						case 7:
							Unsafe.As<AsyncTaskMethodBuilder, AsyncTaskMethodBuilder<EntityGameModsHash>>(ref ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Et__builder) = default;
							num = 9;
							continue;
						case 4:
							((DesktopAuthentication._003CAuthentication_003Ed__27)this).modHashList = (string)obj;
							num = 11;
							continue;
						case 2:
						case 6:
							obj = ((DesktopAuthentication._003CAuthentication_003Ed__27)this).serverIdHash;
							num = 7;
							continue;
						case 8:
							if (((TaskAwaiter<byte[]>*)(&obj))->GetResult() == null)
							{
								num = 10;
								continue;
							}
							goto case 3;
						case 9:
							obj = -1;
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Eu__1 = (TaskAwaiter<byte[]>)(-1);
							num = 3;
							continue;
						case 10:
							obj = 0;
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Eu__2 = (TaskAwaiter)0;
							num = 4;
							continue;
						case 3:
						{
							MassService instance = MassService.Instance;
							((AsyncTaskMethodBuilder<_0021_00210[]>*)DesktopAuthentication._003CAuthentication_003Ed__27.PopChooser())->Start(ref *(DesktopSession._003CEntitiesRequestAsync_003Ed__11<_0021_00210>*)1);
							TimeSpan timeSpan = TimeSpan.FromSeconds((double)instance);
							object obj3;
							Task taskCompletionSource;
							if (DesktopAuthentication._003CConnect_003Ed__19.authServer == null)
							{
								obj3 = DesktopAuthentication._003CConnect_003Ed__19._003Ccts_003E5__2;
								taskCompletionSource = new TaskCompletionSource();
								DesktopAuthentication._003CHeartbeatAsync_003Ed__25._003C_003E1__state = (int)taskCompletionSource;
							}
							((AsyncTaskMethodBuilder<EntitySkinItem[]>*)__ldftn(DesktopAuthentication._003CHeartbeatAsync_003Ed__25.MoveNext))->Start(ref *(DesktopSession._003CGetSkinsByIdAsync_003Ed__22*)taskCompletionSource);
							((AsyncTaskMethodBuilder<PageModel<IDesktopSkin>>*)timeSpan)->Start(ref *(DesktopSession._003CGetOwnedSkinsAsync_003Ed__23*)obj3);
							obj = (object)(&obj);
							num = 0;
							if (DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver == null)
							{
								num = 0;
							}
							continue;
						}
						default:
							goto IL_02f0;
						}
						break;
					}
					goto IL_0110;
					IL_02f0:
					DesktopAuthentication._003CReceiveAsync_003Ed__20.CheckCommonTracker = -2;
					obj2 = 0;
					if ((int)((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22*)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj2 = 0;
					}
					break;
					IL_0110:
					message = ((DesktopAuthentication)/*Error near IL_011c: Stack underflow*/).ReceiveDataAsync((object)((DesktopAuthentication)obj)._buffer);
					asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)new AsyncTaskMethodBuilder();
					asyncTaskMethodBuilder2 = new AsyncTaskMethodBuilder();
					((TcpClient)((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptedToken).Close();
					GC.SuppressFinalize(asyncTaskMethodBuilder2);
					RuntimeHelpers.InitializeArray((Array)asyncTaskMethodBuilder2, (RuntimeFieldHandle)3);
					obj = null;
					((AsyncTaskMethodBuilder*)1)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<byte[]>*)asyncTaskMethodBuilder, ref *(DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22*)obj);
					((TimeoutException)/*Error near IL_0152: Stack underflow*/)._002Ector((string?)message);
					obj = (object)/*Error near IL_0154: Stack underflow*/;
					num = 8;
					goto IL_009a;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00윀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778859, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00저(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778858, new IntPtr(2737336633356L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00준(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00쨀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778837, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00쬀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00찀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778836, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00촀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778839, new IntPtr(2737336633356L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00츀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	[CompilerGenerated]
	private static readonly object Instance__BackingField;

	public EntityAuthServer[] AuthServers;

	public EntityTransferServer[] TransferServers;

	public string NeteaseVersion;

	public Dictionary<string, EntityJavaPatch> NeteasePatchList;

	public readonly RestClient Client;

	private static object EvaluateTemplate;

	public static ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	public static NeteaseDesktop Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasSession(string userId)
	{
		return _FF00_FF00_FF00_FF00_FF00뀀(userId) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DesktopSession GetSession(string userId)
	{
		return (DesktopSession)_FF00_FF00_FF00_FF00_FF00阀(userId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DesktopSession? TryGetSession(string userId)
	{
		return (DesktopSession?)_FF00_FF00_FF00_FF00_FF00ꘀ(userId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitAsync_003Ed__14))]
	public Task InitAsync()
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00꤀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoginAsync_003Ed__15))]
	public Task<DesktopSession> LoginAsync(string cookies)
	{
		return _FF00_FF00_FF00_FF00_FF00가(cookies);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoginAsync_003Ed__16))]
	private Task<DesktopSession> LoginAsync(object dto)
	{
		return _FF00_FF00_FF00_FF00_FF00錀(dto);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoginOtpAsync_003Ed__17))]
	private Task<EntityLoginOtp> LoginOtpAsync(object dto)
	{
		return _FF00_FF00_FF00_FF00_FF00꼀(dto);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAuthenticationOtpAsync_003Ed__18))]
	private Task<EntityAuthenticationOtp> AuthenticationOtpAsync(object dto)
	{
		return _FF00_FF00_FF00_FF00_FF00_AB00(dto);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAuthenticationUpdateAsync_003Ed__19))]
	internal Task<EntityAuthenticationOtp> AuthenticationUpdateAsync(string userId, string userToken)
	{
		return _FF00_FF00_FF00_FF00_FF00踀(userId, userToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetRelatedLanGameRooms_003Ed__20))]
	public Task<EntityLanGameRoom[]> GetRelatedLanGameRooms(int count = 50)
	{
		return _FF00_FF00_FF00_FF00_FF00退((uint)count);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSingleLanGameRoom_003Ed__21))]
	public Task<EntityLanGameRoom> GetSingleLanGameRoom(uint hostId, uint roomId)
	{
		return _FF00_FF00_FF00_FF00_FF00鬀(hostId, roomId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSearchLanGameRoom_003Ed__22))]
	public Task<EntityLanGameRoom[]> SearchLanGameRoom(string name)
	{
		return _FF00_FF00_FF00_FF00_FF00鸀(name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		_FF00_FF00_FF00_FF00_FF00ꌀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe NeteaseDesktop()
	{
		//IL_0077: Expected Obj, but got VT
		//IL_0077: Expected Obj, but got I4
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((AsyncTaskMethodBuilder*)/*Error near IL_001a: Stack underflow*/)->Start(ref *(DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22*)this);
		((DesktopAuthentication)/*Error near IL_001f: Stack underflow*/)._003CuserToken_003EP = (object)/*Error near IL_001f: Stack underflow*/;
		((AsyncTaskMethodBuilder*)/*Error near IL_002a: Stack underflow*/)->Start(ref *(DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)this);
		((DesktopAuthentication)/*Error near IL_002f: Stack underflow*/)._003CserverId_003EP = (object)/*Error near IL_002f: Stack underflow*/;
		DesktopAuthentication.Logger = ((_003C_003Ef__AnonymousType0<, >)this).ToString();
		((DesktopAuthentication)this)._client = new object();
		((DesktopAuthentication)/*Error near IL_005a: Stack underflow*/).Connect((EntityAuthServer)(object)this);
		TcpClient tcpClient = new TcpClient();
		_ = ((AsyncTaskMethodBuilder*)((DesktopAuthentication)(object)tcpClient).ReceiveDataAsync((object)tcpClient))->Task;
		_ = null;
		_ = null;
		((DesktopAuthentication)0)._encryptedToken = new AsyncTaskMethodBuilder();
		((TcpClient)this).Close();
		int num = 0;
		if (((DesktopAuthentication)DesktopAuthentication._decryptChaCha)._handshakeTcs != null)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static NeteaseDesktop()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0023: Expected I4, but got Obj
		//IL_0079->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0050->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0084->IL0012: Incompatible stack types: I4 vs Obj
		//IL_005b->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00餀());
				obj2 = 0;
				if (_003CModule_003E_007Bb8824bbe_002D6cfa_002D4013_002D8120_002Dcb1e84055f2d_007D.m_2f25a4da0ad14a089b13089b3bff794c.m_64a93f7adb8a4bdf8e57237a4efaaddc == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				Instance__BackingField = new NeteaseDesktop();
				obj2 = 2;
				if (_003CModule_003E_007Bb8824bbe_002D6cfa_002D4013_002D8120_002Dcb1e84055f2d_007D.m_2f25a4da0ad14a089b13089b3bff794c.m_8ab3a27dfef14c7492f7da35eb7da664 != 0)
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
	internal static bool DecorateFilteredMapper()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static NeteaseDesktop ReflectAutomatedPolicy()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityAuthenticationOtp> _FF00_FF00_FF00_FF00_FF00贀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778794, new IntPtr(2737336620876L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityAuthenticationOtp>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityAuthenticationOtp> _FF00_FF00_FF00_FF00_FF00踀(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2105, 1790778773, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790778773, new IntPtr(2737336611516L), 15);
		}
		return (Task<EntityAuthenticationOtp>)((delegate*<object, object, object, object>)obj)(this, P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityAuthenticationOtp> _FF00_FF00_FF00_FF00_FF00輀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778772, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityAuthenticationOtp>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityLanGameRoom[]> _FF00_FF00_FF00_FF00_FF00退(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00d6: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got Ref
		//IL_00e7: Expected Obj, but got Ref
		//IL_00ee: Expected Obj, but got Ref
		//IL_00ee: Expected Obj, but got Ref
		//IL_004f: Expected Obj, but got Ref
		//IL_0054: Expected VT, but got Ref
		//IL_0055: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got Ref
		//IL_00be: Expected Obj, but got I
		//IL_0088: Expected Obj, but got Ref
		//IL_0061: Expected Obj, but got Ref
		//IL_00e0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f8->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0075->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ce->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0080->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				return (Task<EntityLanGameRoom[]>)((EqualityComparer<_00211>)/*Error near IL_0054: Stack underflow*/).Equals((_00211?)/*Error near IL_0054: Stack underflow*/, (_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)(&obj))._003CuserId_003EP));
			case 5:
				((DesktopAuthentication)(&obj))._003CserverId_003EP = EqualityComparer<_00210>.Default;
				obj2 = 4;
				if (DesktopAuthentication.Logger != null)
				{
					obj2 = 4;
				}
				break;
			case 4:
				DesktopAuthentication.TokenKey = (byte[])(object)this;
				obj2 = 0;
				if (((DesktopAuthentication)DesktopAuthentication._client)._connected != 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				((DesktopAuthentication)(&obj))._buffer = (List<byte>)(-1);
				obj2 = 0;
				if (((DesktopAuthentication)DesktopAuthentication._handshake)._handshakeSent == 0)
				{
					obj2 = 1;
				}
				break;
			default:
				((DesktopAuthentication)(&obj))._handshakeKey = P_0;
				obj2 = 3;
				break;
			case 1:
				((IEnumerable<byte>)Unsafe.AsPointer(ref ((DesktopAuthentication)(&obj))._encryptedToken)).Concat((IEnumerable<byte>)(&obj));
				_ = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityLanGameRoom[]> _FF00_FF00_FF00_FF00_FF00鄀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778775, new IntPtr(2737336619836L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityLanGameRoom[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<DesktopSession> _FF00_FF00_FF00_FF00_FF00鈀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778774, new IntPtr(2737336613596L), 15))(null, 0, new IntPtr(0L));
		return (Task<DesktopSession>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<DesktopSession> _FF00_FF00_FF00_FF00_FF00錀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2110, 1790778769, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778769, new IntPtr(2737336637516L), 15);
		}
		return (Task<DesktopSession>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00销(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778768, new IntPtr(2737336631276L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00阀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2113, 1790778771, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778771, new IntPtr(2737336612556L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00需()
	{
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00頀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778770, new IntPtr(2737336613596L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00騀()
	{
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return DesktopAuthentication._003CuserId_003EP;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityLanGameRoom> _FF00_FF00_FF00_FF00_FF00鬀(uint P_0, uint P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_0103: Expected Obj, but got I4
		//IL_0103: Expected Obj, but got Ref
		//IL_00dc: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got Ref
		//IL_00a7: Expected Obj, but got Ref
		//IL_0081: Expected Obj, but got I4
		//IL_0081: Expected Obj, but got Ref
		//IL_0053: Expected Obj, but got Ref
		//IL_00b5: Expected Obj, but got Ref
		//IL_00c4: Expected Obj, but got I
		//IL_0114: Expected VT, but got Ref
		//IL_010d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0095->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0123->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0079->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d4->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 6;
		object obj = stateMachine;
		while (true)
		{
			switch ((int)obj)
			{
			case 4:
				Unsafe.As<object, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication)(&stateMachine))._003CuserId_003EP).Start(ref *(DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23*)(&stateMachine));
				obj = 2;
				if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
				{
					obj = 0;
				}
				break;
			case 3:
				DesktopAuthentication.Crc32 = P_0;
				obj = 1;
				if (DesktopAuthentication.TokenKey == null)
				{
					obj = 1;
				}
				break;
			case 2:
				_ = ref ((DesktopAuthentication)(&stateMachine))._client;
				/*Error near IL_00a7: Member reference must be method, but was: Field*/;
			case 5:
				((DesktopAuthentication)(&stateMachine))._buffer = (List<byte>)(object)this;
				obj = 3;
				if (((DesktopAuthentication)DesktopAuthentication._handshake)._handshakeSent != 0)
				{
					obj = 0;
				}
				break;
			case 1:
				((DesktopAuthentication)(&stateMachine))._handshakeKey = P_1;
				obj = 0;
				if (((DesktopAuthentication)DesktopAuthentication._encryptedToken)._encryptChaCha != null)
				{
					obj = 0;
				}
				break;
			default:
				((DesktopAuthentication)(&stateMachine))._decryptChaCha = -1;
				obj = 4;
				break;
			case 6:
				RuntimeHelpers.InitializeArray((Array)/*Error near IL_0114: Stack underflow*/, (RuntimeFieldHandle)(&stateMachine));
				((DesktopAuthentication)/*Error near IL_0119: Stack underflow*/)._authenticationTcs = (object?)/*Error near IL_0119: Stack underflow*/;
				obj = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityLanGameRoom> _FF00_FF00_FF00_FF00_FF00鰀(uint P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778781, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityLanGameRoom>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityLanGameRoom[]> _FF00_FF00_FF00_FF00_FF00鴀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778780, new IntPtr(2737336627116L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityLanGameRoom[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityLanGameRoom[]> _FF00_FF00_FF00_FF00_FF00鸀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2121, 1790778783, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778783, new IntPtr(2737336631276L), 15);
		}
		return (Task<EntityLanGameRoom[]>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityLanGameRoom[]> _FF00_FF00_FF00_FF00_FF00鼀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778782, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityLanGameRoom[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00ꀀ()
	{
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return DesktopAuthentication._003CuserId_003EP;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00ꄀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778777, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00ꈀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778776, new IntPtr(2737336614636L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00_FF00ꌀ()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_006d: Expected VT, but got Obj
		//IL_0057->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0081->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0062->IL0026: Incompatible stack heights: 3 vs 1
		//IL_008c->IL0026: Incompatible stack heights: 2 vs 1
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			case 2:
				return;
			default:
				_ = EqualityComparer<_00211>.Default;
				_ = 2;
				if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
				{
					_ = 2;
				}
				break;
			case 1:
				((EqualityComparer<_00210>)/*Error near IL_006d: Stack underflow*/).GetHashCode((_00210)((DesktopAuthentication)this)._003CserverId_003EP);
				_ = 0;
				if (DesktopAuthentication.TokenKey == null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00ꐀ()
	{
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return DesktopAuthentication._003CuserId_003EP;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00ꔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778779, new IntPtr(2737336613596L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00ꘀ(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2129, 1790778778, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778778, new IntPtr(2737336625036L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_A700(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778757, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00ꠀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778756, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00꤀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2132, 1790778759, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778759, new IntPtr(2737336629196L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00ꨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778758, new IntPtr(2737336614636L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<EntityAuthenticationOtp> _FF00_FF00_FF00_FF00_FF00_AB00(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2134, 1790778753, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778753, new IntPtr(2737336613596L), 15);
		}
		return (Task<EntityAuthenticationOtp>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<DesktopSession> _FF00_FF00_FF00_FF00_FF00가(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2135, 1790778752, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778752, new IntPtr(2737336619836L), 15);
		}
		return (Task<DesktopSession>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<DesktopSession> _FF00_FF00_FF00_FF00_FF00관(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778755, new IntPtr(2737336614636L), 15))(null, 0, new IntPtr(0L));
		return (Task<DesktopSession>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<EntityLoginOtp> _FF00_FF00_FF00_FF00_FF00글(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778754, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityLoginOtp>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<EntityLoginOtp> _FF00_FF00_FF00_FF00_FF00꼀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2138, 1790778765, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778765, new IntPtr(2737336614636L), 15);
		}
		return (Task<EntityLoginOtp>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00뀀(object P_0)
	{
		//IL_001b: Expected VT, but got Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((EqualityComparer<_00211>)/*Error near IL_001b: Stack underflow*/).Equals((_00211?)/*Error near IL_001b: Stack underflow*/, (_00211?)P_0) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00넀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778764, new IntPtr(2737336630236L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
