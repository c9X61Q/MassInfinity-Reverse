using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Mass.Application.Desktop.Models;
using Mass.Application.Models;
using Mass.Common.Extensions;
using Mass.Domain.Desktop.Entities;
using Mass.Domain.Desktop.Entities.RentalGame;
using Mass.Domain.Entities.Netease;
using Mass.Domain.Mobile.Entities;
using Mass.Domain.Mobile.Entities.Game;
using Mass.Domain.Mobile.Entities.NetGame;
using RestSharp;
using Serilog;

namespace Mass.Application.Mobile;

public class NeteaseMobile : IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAuthenticationAsync_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public EntityAuthenticationDto dto;

		public NeteaseMobile _003C_003E4__this;

		public string userId;

		public string token;

		private TaskAwaiter<RestResponse> _003C_003Eu__1;

		private static object CheckDetachedAllocator;

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
		internal static bool CheckDetailedQueue()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateDividedSender()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object ꔀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778508, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object ꘀ()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return MobileSession._003C_003Ec._003C_003E9;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _A700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778515, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte ꠀ()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (MobileSession._003C_003Ec._003C_003E9 == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _꤀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778514, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 관()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778513, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 글()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_038a: Expected native int or pointer, but got Obj
			//IL_004e: Expected Obj, but got Ref
			//IL_00c6: Expected Obj, but got Ref
			//IL_0207: Expected Obj, but got I4
			//IL_020c: Expected Obj, but got I4
			//IL_0216: Expected native int or pointer, but got Obj
			//IL_018a: Expected native int or pointer, but got Obj
			//IL_0102: Expected Obj, but got I4
			//IL_0107: Expected Obj, but got I4
			//IL_00e8: Expected native int or pointer, but got Obj
			//IL_0394->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0368->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0341->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_039f->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0373->IL0026: Incompatible stack types: I4 vs Obj
			//IL_034c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_024d->IL0086: Incompatible stack heights: 2 vs 1
			//IL_0258->IL0086: Incompatible stack heights: 2 vs 1
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object stateMachine = 5;
			object obj = stateMachine;
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				case 5:
					stateMachine = MobileSession._003C_003Ec._003C_003E9;
					obj = 4;
					break;
				case 1:
					return;
				default:
					if (stateMachine != null)
					{
						num = 10;
						if (((MobileSession._003C_003Ec__DisplayClass19_0)(object)MobileSession._003C_003Ec._003C_003E9__15_0).gameId != null)
						{
							num = 8;
						}
						goto IL_0086;
					}
					goto IL_00c0;
				case 4:
					stateMachine = ((MobileSession._003CGetRentalGameAddressAsync_003Ed__18)this).password;
					obj = 0;
					if (MobileSession._003CGetRentalGameAddressAsync_003Ed__18.StoreComparator == null)
					{
						obj = 0;
					}
					break;
				case 3:
					goto IL_034c;
				case 2:
					{
						_ = ref ((MobileSession._003CGetRentalGamesAsync_003Ed__17)this).offset;
						((IAsyncStateMachine)stateMachine).MoveNext();
						_ = 1;
						if (((MobileSession._003CRequestAsync_003Ed__10<>*)(nint)MobileSession._003CGetRentalGamesAsync_003Ed__17.EncodeConsumer)->_003C_003E1__state == 0)
						{
							_ = 1;
						}
						break;
					}
					IL_00c0:
					stateMachine = MobileSession._003C_003Ec__DisplayClass19_0.CheckRemoteExplorer;
					num = 8;
					goto IL_0086;
					IL_0086:
					while (true)
					{
						switch (num)
						{
						case 9:
							return;
						case 11:
							break;
						case 8:
							Unsafe.As<int, AsyncTaskMethodBuilder<EntityRentalGameAddress>>(ref ((MobileSession._003CEntitiesRequestAsync_003Ed__9<>)this)._003C_003E1__state) = default;
							num = 7;
							if (((MobileSession._003CEntitiesRequestAsync_003Ed__9<>*)(nint)MobileSession._003CEntitiesRequestAsync_003Ed__9<>._003C_003E4__this)->url != null)
							{
								num = 1;
							}
							continue;
						case 7:
							stateMachine = -1;
							((MobileSession._003CEntitiesRequestAsync_003Ed__9<>)this).body = -1;
							num = 6;
							if ((int)((MobileSession._003CEntitiesRequestAsync_003Ed__9<>*)(MobileSession._003CEntitiesRequestAsync_003Ed__9<>.checkCode ? 1 : 0))->_003C_003Eu__1 != 0)
							{
								num = 5;
							}
							continue;
						case 10:
							_ = ((MobileSession._003CEntityRequestAsync_003Ed__7)this)._003C_003E1__state;
							/*Error near IL_012c: Member reference must be method, but was: Field*/;
						case 1:
							((MobileSession._003CEntityRequestAsync_003Ed__7)this).body = stateMachine;
							num = 5;
							if ((int)((MobileSession._003CEntityRequestAsync_003Ed__7*)(MobileSession._003CEntityRequestAsync_003Ed__7.checkCode ? 1 : 0))->_003C_003Eu__1 != 0)
							{
								num = 0;
							}
							continue;
						case 4:
							_ = MobileSession._003CEntityRequestAsync_003Ed__7.CheckGroupedEmitter;
							MobileSession.DecorateEfficientStream();
							_ = 1;
							/*Error near IL_0195: Member reference must be method, but was: Field*/;
						case 6:
							_ = ref stateMachine;
							/*Error near IL_01d7: Member reference must be method, but was: Field*/;
						default:
							stateMachine = 0;
							((MobileSession._003CGetNetGameAddressAsync_003Ed__21)this)._003C_003E4__this = (MobileSession)0;
							num = 1;
							if ((int)((MobileSession._003CGetNetGameAddressAsync_003Ed__21*)(nint)MobileSession._003CGetNetGameAddressAsync_003Ed__21.gameId)->_003C_003Eu__1 == 0)
							{
								num = 1;
							}
							continue;
						case 5:
							_ = ref MobileSession._003CGetNetGameAddressAsync_003Ed__21.GuideRequester;
							((AsyncTaskMethodBuilder*)(&stateMachine))->Start(ref Unsafe.As<_003CAuthenticationAsync_003Ed__16, _003CInitAsync_003Ed__12>(ref this));
							_ = 4;
							if (((MobileSession._003CGetNetGameDetailsAsync_003Ed__20)MobileSession._003CGetNetGameDetailsAsync_003Ed__20._003C_003Et__builder)._003C_003E4__this == null)
							{
								_ = 9;
							}
							continue;
						case 3:
							((AsyncTaskMethodBuilder<EntityRentalGameAddress>*)/*Error near IL_025f: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)(&stateMachine));
							if ((int)/*Error near IL_0264: Stack underflow*/ == 0)
							{
								num = 0;
								if (MobileSession._003CGetNetGameDetailsAsync_003Ed__20.AttachWrapper == null)
								{
									num = 0;
								}
								continue;
							}
							goto case 6;
						case 2:
							goto IL_034c;
						}
						break;
					}
					goto IL_00c0;
					IL_034c:
					((MobileSession._003CGetRentalGamesAsync_003Ed__17)this)._003C_003E1__state = -2;
					obj = 2;
					if (((MobileSession._003CGetRentalGamesAsync_003Ed__17)MobileSession._003CGetRentalGamesAsync_003Ed__17._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj = 1;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 꼀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778512, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 뀀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778519, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 넀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0058->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 3 vs 1
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
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
					_ = ref MobileSession._003C_003Ec._003C_003E9;
					_ = ((AsyncTaskMethodBuilder*)P_0)->Task;
					_ = 0;
					if (MobileSession._003C_003Ec__DisplayClass19_0.CheckRemoteExplorer != null)
					{
						_ = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAuthenticationV2Async_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityAuthentication> _003C_003Et__builder;

		public EntityAuthenticationDto dto;

		public NeteaseMobile _003C_003E4__this;

		public string userId;

		public string token;

		private TaskAwaiter<RestResponse<EntityAuthentication>> _003C_003Eu__1;

		internal static object DirectAnalyzer;

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
		internal static bool ReflectExtendedProvider()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateVisibleCalc()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 눀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778518, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 대()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return MobileSession._003C_003Ec._003C_003E9;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 됀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778517, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 딀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778516, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 똀()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (MobileSession._003C_003Ec._003C_003E9 == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 뜀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778523, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 뤀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0078: Expected Obj, but got I4
			//IL_0078: Expected Obj, but got Ref
			//IL_03d2: Expected native int or pointer, but got Obj
			//IL_004f: Expected Obj, but got Ref
			//IL_03b1: Expected Obj, but got VT
			//IL_0123: Expected Obj, but got VT
			//IL_02a5: Expected Obj, but got Ref
			//IL_02a5: Expected Obj, but got VT
			//IL_0147: Expected Obj, but got I4
			//IL_014c: Expected Obj, but got I4
			//IL_0156: Expected native int or pointer, but got Obj
			//IL_01af: Expected native int or pointer, but got Obj
			//IL_0101: Expected native int or pointer, but got Obj
			//IL_02ce: Expected Obj, but got I4
			//IL_0231: Expected I4, but got Obj
			//IL_008c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03dc->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03bb->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0097->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03e7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a9->IL00ad: Incompatible stack heights: 1 vs 2
			//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00e6->IL0116: Incompatible stack heights: 1 vs 0
			//IL_02aa->IL016b: Incompatible stack heights: 0 vs 1
			//IL_029e->IL00ad: Incompatible stack heights: 6 vs 2
			//IL_02be->IL00ad: Incompatible stack heights: 1 vs 2
			//IL_02c9->IL00ad: Incompatible stack heights: 1 vs 2
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				int num;
				TaskAwaiter<Entities<T>> taskAwaiter;
				switch ((int)obj2)
				{
				case 2:
					return;
				case 4:
					obj = MobileSession._003C_003Ec._003C_003E9;
					obj2 = 2;
					if (((MobileSession._003C_003Ec__DisplayClass19_0)(object)MobileSession._003C_003Ec._003C_003E9__15_0).gameId != null)
					{
						obj2 = 3;
					}
					break;
				default:
					MobileSession._003C_003Ec__DisplayClass19_0.CheckRemoteExplorer = (MobileSession._003C_003Ec__DisplayClass19_0)(-2);
					obj2 = 1;
					if ((int)((MobileSession._003CEntitiesRequestAsync_003Ed__9<>*)MobileSession._003CEntitiesRequestAsync_003Ed__9<>._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj2 = 0;
					}
					break;
				case 3:
					if (obj == null)
					{
						_ = 4;
						goto IL_00ad;
					}
					goto IL_0116;
				case 5:
					obj = ((MobileSession._003CRequestAsync_003Ed__10<>)this)._003C_003Et__builder;
					obj2 = 4;
					break;
				case 1:
					{
						((AsyncTaskMethodBuilder<_00210[]>*)/*Error near IL_03c8: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref Unsafe.As<MobileSession, TAwaiter>(ref ((MobileSession._003CRequestAsync_003Ed__10<>)this)._003C_003E4__this), ref *(TStateMachine*)obj);
						obj2 = 2;
						if (!((MobileSession._003CRequestAsync_003Ed__10<>*)(nint)MobileSession._003CRequestAsync_003Ed__10<>.body)->checkCode)
						{
							obj2 = 2;
						}
						break;
					}
					IL_00ad:
					while (true)
					{
						switch (num)
						{
						case 5:
							return;
						case 7:
							break;
						case 8:
							((MobileSession._003CEntitiesRequestAsync_003Ed__9<>)this)._003C_003E4__this = null;
							num = 0;
							if (!((MobileSession._003CEntitiesRequestAsync_003Ed__9<>*)(nint)MobileSession._003CEntitiesRequestAsync_003Ed__9<>.body)->checkCode)
							{
								num = 1;
							}
							continue;
						case 12:
							goto IL_0116;
						case 1:
							obj = -1;
							((MobileSession._003CEntityRequestAsync_003Ed__7)this).url = (string)(-1);
							num = 2;
							if (((MobileSession._003CEntityRequestAsync_003Ed__7*)(nint)MobileSession._003CEntityRequestAsync_003Ed__7.body)->checkCode)
							{
								num = 2;
							}
							continue;
						case 2:
							_ = ref obj;
							/*Error near IL_016d: Member reference must be method, but was: Field*/;
						case 3:
							_ = ((MobileSession._003CEntityRequestAsync_003Ed__8<>*)(nint)obj)->_003C_003Eu__1;
							MobileSession._003C_003Ec__DisplayClass19_0.DecorateActiveAuthenticator();
							_ = 1;
							/*Error near IL_01ba: Member reference must be method, but was: Field*/;
						case 11:
							((MobileSession._003CGetNetGameDetailsAsync_003Ed__20)this)._003C_003E1__state = (int)obj;
							num = 6;
							if (((MobileSession._003CGetNetGameDetailsAsync_003Ed__20)MobileSession._003CGetNetGameDetailsAsync_003Ed__20._003C_003Et__builder)._003C_003E4__this != null)
							{
								num = 4;
							}
							continue;
						case 4:
						case 10:
							obj = MobileSession._003CGetNetGameDetailsAsync_003Ed__20.AttachWrapper;
							num = 8;
							continue;
						case 6:
							_ = ref ((MobileSession._003CGetNetGamesAsync_003Ed__15)this)._003C_003E1__state;
							_ = ref obj;
							Array.Empty<EntityLinkServer>();
							_ = 5;
							continue;
						default:
							((SessionContext<MobileSession, EntityNetGameItem>)/*Error near IL_02a5: Stack underflow*/)._002Ector((MobileSession)taskAwaiter, (EntityNetGameItem)(&obj));
							if ((int)/*Error near IL_02aa: Stack underflow*/ == 0)
							{
								_ = 9;
								if (MobileSession._003CGetNetGamesAsync_003Ed__15.DecorateDynamicSingleton == null)
								{
									_ = 8;
								}
								continue;
							}
							goto case 2;
						case 9:
							obj = 0;
							((MobileSession._003CGetRentalGameAddressAsync_003Ed__18)this)._003C_003E1__state = 0;
							num = 11;
							if (((MobileSession._003CGetRentalGameAddressAsync_003Ed__18)MobileSession._003CGetRentalGameAddressAsync_003Ed__18._003C_003Et__builder)._003C_003E4__this != null)
							{
								num = 0;
							}
							continue;
						}
						break;
					}
					goto default;
					IL_0116:
					taskAwaiter = ((MobileSession._003CEntitiesRequestAsync_003Ed__9<>)this)._003C_003Eu__1;
					obj = AsyncTaskMethodBuilder<_0021_00210[]>.Create();
					num = 3;
					if (((MobileSession._003CEntityRequestAsync_003Ed__7)MobileSession._003CEntityRequestAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						num = 2;
					}
					goto IL_00ad;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 먀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778522, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 묀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 3 vs 1
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
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
					_ = ref MobileSession._003C_003Ec._003C_003E9;
					_ = ((AsyncTaskMethodBuilder*)P_0)->Task;
					_ = 0;
					if (MobileSession._003C_003Ec__DisplayClass19_0.CheckRemoteExplorer == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetEncryptionKeyAsync_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Jwt<EntityEncryptionKeyHeader, EntityEncryptionKeyPayload>> _003C_003Et__builder;

		public EntityGetEncryptionKeyDto dto;

		public NeteaseMobile _003C_003E4__this;

		public string userId;

		public string token;

		private TaskAwaiter<RestResponse<Entity<EntityEncryptionKey>>> _003C_003Eu__1;

		internal static object ReflectCentralTree;

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
		internal static bool CheckStatelessFilter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckScheduledStack()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 밀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778521, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 봀()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return MobileSession._003C_003Ec._003C_003E9;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 븀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778520, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 뼀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778527, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 쀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778526, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 섀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778525, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 쐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778524, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 씀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778531, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 였()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778530, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 윀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778529, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 저(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778528, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitAsync_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NeteaseMobile _003C_003E4__this;

		private object _003Cclient_003E5__2;

		private TaskAwaiter<EntityLinkServer[]?> _003C_003Eu__1;

		private static object DecorateFilteredSubscriber;

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
		internal unsafe static bool CheckAutomatedLogger()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778533, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object UpdateStruct()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778532, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 준()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778539, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 쨀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778538, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 쬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778537, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 찀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778536, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 촀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778543, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 퀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778542, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 턀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778541, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 툀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778540, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 팀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778547, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoginAsync_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<MobileSession> _003C_003Et__builder;

		public string cookies;

		public NeteaseMobile _003C_003E4__this;

		private TaskAwaiter<MobileSession> _003C_003Eu__1;

		internal static object OpenReporter;

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
		internal unsafe static bool CheckOperationalAuthorizer()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778544, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object TestEnumerator()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778551, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 퐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778550, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 픀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778549, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 혀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778548, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 휀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778555, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778554, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778553, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FFFD(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778552, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoginAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<MobileSession> _003C_003Et__builder;

		public Mass.Domain.Mobile.Entities.EntityLoginOtpDto dto;

		public NeteaseMobile _003C_003E4__this;

		private object _003CsAuth_003E5__2;

		private object _003CmgbSdk_003E5__3;

		private TaskAwaiter<EntityMgbSdk> _003C_003Eu__1;

		private object _003C_003E7__wrap3;

		private object _003C_003E7__wrap4;

		private TaskAwaiter<string> _003C_003Eu__2;

		private TaskAwaiter<EntityAuthenticationOtp> _003C_003Eu__3;

		private static object ReflectIdentifiableReg;

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
		internal unsafe static bool DecorateInterruptibleExecutor()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778557, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object CheckCustomizablePredictor()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778556, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778563, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778562, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778561, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _E000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778560, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _E100()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778567, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _E200()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778566, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _E300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778565, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _E400()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778564, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _E500(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778571, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _E600(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778570, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _E700(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778569, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPeAuthenticationAsync_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityAuthenticationOtp> _003C_003Et__builder;

		public NeteaseMobile _003C_003E4__this;

		public EntityPeAuthenticationDto dto;

		private TaskAwaiter<RestResponse<Entity<EntityAuthenticationOtp>>> _003C_003Eu__1;

		internal static object InvokeFactory;

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
		internal unsafe static bool ResetCompressor()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778574, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object ReflectHiddenFunction()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778573, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _E800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778572, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _E900()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778579, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _EA00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778578, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _EB00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778577, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _EC00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778576, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _EF00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778583, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _F000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778582, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _F100()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778581, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _F200(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778580, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	[CompilerGenerated]
	private static readonly object Instance__BackingField;

	public EntityLinkServer[] LinkServers;

	public string NeteaseVersion;

	internal readonly RestClient Client;

	private static object ReflectLogger;

	private static ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	public static NeteaseMobile Instance
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
		return 踀(userId) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MobileSession GetSession(string userId)
	{
		return (MobileSession)褀(userId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MobileSession? TryGetSession(string userId)
	{
		return (MobileSession?)鐀(userId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitAsync_003Ed__12))]
	public Task InitAsync()
	{
		return (Task)阀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoginAsync_003Ed__13))]
	public Task<MobileSession> LoginAsync(string cookies)
	{
		return 蘀(cookies);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoginAsync_003Ed__14))]
	private Task<MobileSession> LoginAsync(object dto)
	{
		return ꄀ(dto);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPeAuthenticationAsync_003Ed__15))]
	private Task<EntityAuthenticationOtp> PeAuthenticationAsync(object dto)
	{
		return 鸀(dto);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAuthenticationAsync_003Ed__16))]
	public Task<string> AuthenticationAsync(string userId, string token, EntityAuthenticationDto dto)
	{
		return 鈀(userId, token, dto);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAuthenticationV2Async_003Ed__17))]
	public Task<EntityAuthentication> AuthenticationV2Async(string userId, string token, EntityAuthenticationDto dto)
	{
		return ꌀ(userId, token, dto);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetEncryptionKeyAsync_003Ed__18))]
	public Task<Jwt<EntityEncryptionKeyHeader, EntityEncryptionKeyPayload>> GetEncryptionKeyAsync(string userId, string token, EntityGetEncryptionKeyDto dto)
	{
		return 言(userId, token, dto);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		退();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe NeteaseMobile()
	{
		//IL_003a: Expected I4, but got Obj
		((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((AsyncTaskMethodBuilder<_0021_00210>*)/*Error near IL_001a: Stack underflow*/)->Start(ref *(MobileSession._003CRequestAsync_003Ed__10<_0021_00210>*)this);
		MobileSession._003C_003Ec._003C_003E9__15_0 = (Func<EntityNetGameItem, long>)/*Error near IL_001f: Stack underflow*/;
		((MobileSession)this).Dispose();
		MobileSession._003C_003Ec__DisplayClass19_0.CheckRemoteExplorer = (MobileSession._003C_003Ec__DisplayClass19_0)/*Error near IL_002f: Stack underflow*/;
		((MobileSession)/*Error near IL_003a: Stack underflow*/).EntityRequestAsync<T>((string)/*Error near IL_003a: Stack underflow*/, (object)/*Error near IL_003a: Stack underflow*/, (byte)(int)this != 0);
		/*Error near IL_003a: Member reference must be method, but was: Field*/;
	}

	static NeteaseMobile()
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
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder.騀());
				obj2 = 0;
				if (_003CModule_003E_007Bdbd119a4_002D39f4_002D4b7c_002Dbc69_002D20e65d7a2b8a_007D.m_b6f4e2307c8340e493bf28273abbb38e.m_399bb3aac7c5455d9a9cc06bfe79f346 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				Instance__BackingField = new NeteaseMobile();
				obj2 = 0;
				if (_003CModule_003E_007Bdbd119a4_002D39f4_002D4b7c_002Dbc69_002D20e65d7a2b8a_007D.m_b6f4e2307c8340e493bf28273abbb38e.m_e5444c2fde2b47cfa605b73b568923ff == 0)
				{
					obj2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckDetachedFinder()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static NeteaseMobile ReceiveAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<MobileSession> 蔀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778489, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		return (Task<MobileSession>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<MobileSession> 蘀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 342, 1790778488, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778488, new IntPtr(2737336615676L), 15);
		}
		return (Task<MobileSession>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 蠀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778495, new IntPtr(2737336617756L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 褀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 345, 1790778494, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778494, new IntPtr(2737336617756L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<Jwt<EntityEncryptionKeyHeader, EntityEncryptionKeyPayload>> 言(object P_0, object P_1, object P_2)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005b: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 346, 1790778493, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 4, 1790778493, new IntPtr(2737336626076L), 15);
		}
		return (Task<Jwt<EntityEncryptionKeyHeader, EntityEncryptionKeyPayload>>)((delegate*<object, object, object, object, object>)obj)(this, P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte 踀(object P_0)
	{
		//IL_001c: Expected I4, but got Obj
		((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)((AsyncTaskMethodBuilder*)P_0)->Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte 輀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778492, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void 退()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0056->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0061->IL0026: Incompatible stack heights: 3 vs 1
		((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
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
			case 1:
				_ = MobileSession._003C_003Ec__DisplayClass19_0.CheckRemoteExplorer;
				/*Error near IL_0068: Member reference must be method, but was: Field*/;
			}
			AsyncTaskMethodBuilder.Create();
			_ = 2;
			if (((MobileSession._003C_003Ec__DisplayClass19_0)(object)MobileSession._003C_003Ec._003C_003E9__15_0).gameId == null)
			{
				_ = 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object 鄀()
	{
		((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return MobileSession._003C_003Ec._003C_003E9;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<string> 鈀(object P_0, object P_1, object P_2)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005b: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 354, 1790778499, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 4, 1790778499, new IntPtr(2737336632316L), 15);
		}
		return (Task<string>)((delegate*<object, object, object, object, object>)obj)(this, P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<string> 錀(object P_0, object P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778498, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
		return (Task<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 鐀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 356, 1790778497, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778497, new IntPtr(2737336618796L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 销()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778496, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 阀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 358, 1790778503, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778503, new IntPtr(2737336620876L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object 需()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778502, new IntPtr(2737336621916L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object 頀()
	{
		((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return MobileSession._003C_003Ec._003C_003E9;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object 餀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778501, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte 鬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778500, new IntPtr(2737336621916L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte 鰀()
	{
		((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (MobileSession._003C_003Ec._003C_003E9 == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<EntityAuthenticationOtp> 鴀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778507, new IntPtr(2737336621916L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityAuthenticationOtp>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<EntityAuthenticationOtp> 鸀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 366, 1790778506, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778506, new IntPtr(2737336622956L), 15);
		}
		return (Task<EntityAuthenticationOtp>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<EntityAuthenticationOtp> 鼀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778505, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityAuthenticationOtp>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object ꀀ()
	{
		((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return MobileSession._003C_003Ec._003C_003E9;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<MobileSession> ꄀ(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 369, 1790778504, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778504, new IntPtr(2737336621916L), 15);
		}
		return (Task<MobileSession>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<MobileSession> ꈀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778511, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		return (Task<MobileSession>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityAuthentication> ꌀ(object P_0, object P_1, object P_2)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005b: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 371, 1790778510, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 4, 1790778510, new IntPtr(2737336636476L), 15);
		}
		return (Task<EntityAuthentication>)((delegate*<object, object, object, object, object>)obj)(this, P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityAuthentication> ꐀ(object P_0, object P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778509, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityAuthentication>)/*Error near IL_0033: Stack underflow*/;
	}
}
